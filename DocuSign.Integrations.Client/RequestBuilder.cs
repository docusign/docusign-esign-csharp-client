// -----------------------------------------------------------------------
// <copyright file="RequestBuilder.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

#define ENABLE_REQ_DUMP

namespace DocuSignClient
{
    using System;
    using System.IO;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;
    using System.Text;

    /// <summary>
    /// RequestBuilder class
    /// </summary>
    internal class RequestBuilder
    {
#if ENABLE_REQ_DUMP                
        /// <summary>
        /// Request stream object
        /// </summary>
        private MemoryStream requestStream = new MemoryStream();

        /// <summary>
        /// Writer for dumping the request and response
        /// </summary>
        private TextWriter dumpWriter = null;

        /// <summary>
        /// Gets the memory dump stream object
        /// </summary>
        public MemoryStream Dump 
        { 
            get 
            { 
                return requestStream; 
            } 
        }
#endif
        /// <summary>
        /// DocuSignCredentials instance
        /// </summary>
        private DocuSignCredentials docuSignCredentials = new DocuSignCredentials();

        /// <summary>
        /// HttpWebRequest instance
        /// </summary>
        private HttpWebRequest webRequest = null;

        /// <summary>
        /// Encoding instance
        /// </summary>
        private UTF8Encoding encoding = new UTF8Encoding();

        /// <summary>
        /// ResponseInfo instance
        /// </summary>
        private ResponseInfo responseInfo = new ResponseInfo();

        /// <summary>
        /// Initializes a new instance of the RequestBuilder class
        /// </summary>
        public RequestBuilder()
        {
            this.AuthorizationFlag = AuthOptions.FullCreds;
            this.AuthorizationFormat = AuthFormat.Xml;

#if ENABLE_REQ_DUMP                
            this.dumpWriter = new StreamWriter(requestStream);
#endif
        }

        /// <summary>
        /// AuthOptions enum
        /// </summary>
        public enum AuthOptions
        {
            /// <summary>
            /// Uses full credentials
            /// </summary>
            FullCreds,

            /// <summary>
            /// Uses only the integrator key
            /// </summary>
            IntegratorKeyOnly,

            /// <summary>
            /// No credentials
            /// </summary>
            NoCreds
        }

        /// <summary>
        /// AuthFormat enum
        /// </summary>
        public enum AuthFormat
        {
            /// <summary>
            /// Json format
            /// </summary>
            Json,

            /// <summary>
            /// Xml format
            /// </summary>
            Xml
        }

        /// <summary>
        /// Gets or sets the WebProxy for Http requests
        /// </summary>
        public WebProxy Proxy { get; set; }

        /// <summary>
        /// Gets the HttpRequest object
        /// </summary>
        public HttpWebRequest HttpRequest 
        { 
            get
            {
                return this.webRequest;
            }
        }

        /// <summary>
        /// Gets or sets the RequestInfo property
        /// </summary>
        public RequestInfo Request { get; set; }

        /// <summary>
        /// Gets or sets the AuthOptions property
        /// </summary>
        public AuthOptions AuthorizationFlag { get; set; }

        /// <summary>
        /// Gets or sets the AuthFormat property
        /// </summary>
        public AuthFormat AuthorizationFormat { get; set; }

        /// <summary>
        /// Constructs and submits REST request
        /// </summary>
        /// <returns>ResponseInfo object</returns>
        public ResponseInfo MakeRESTRequest()
        {
            this.CreateWebRequest();
            this.CreateDocusignCredentials();
            this.SetDistributorCredentials();
            this.SetLogonCredentials();
            this.SetAdditionalHeaders();

            if (this.Request.IsMultipart)
            {
                this.webRequest.ContentType = string.Format("{0}; boundary={1}", this.webRequest.ContentType, this.Request.MultipartBoundary);
            }

            if (this.webRequest.Method == "PUT" || this.webRequest.Method == "POST")
            {
                this.ConstructPOST();
            }

            this.SetResponseFields();

            return this.responseInfo;
        }

        /// <summary>
        /// Constructs a DocuSignCredentials object.
        /// </summary>
        private void CreateDocusignCredentials()
        {
            this.docuSignCredentials.IntegratorKey = this.Request.IntegratorKey;

            if (this.AuthorizationFlag != AuthOptions.IntegratorKeyOnly)
            {
                this.docuSignCredentials.Username = this.Request.LoginEmail;
                this.docuSignCredentials.Password = this.Request.LoginPassword;
            }
        }

        /// <summary>
        /// Constructs an HttpWebRequest object
        /// </summary>
        private void CreateWebRequest()
        {
            this.webRequest = WebRequest.Create(this.Request.FullUrl) as HttpWebRequest;
            this.webRequest.Method = this.Request.HttpMethod;
            this.webRequest.Accept = this.Request.AcceptContentType;
            this.webRequest.ContentType = this.Request.RequestContentType;

            if (this.Request.Timeout.HasValue)
            {
                this.webRequest.Timeout = this.Request.Timeout.Value;
            }
        }

        /// <summary>
        /// Gets the response data from the request
        /// </summary>
        private void SetResponseFields()
        {
            try
            {
                using (HttpWebResponse resp = this.webRequest.GetResponse() as HttpWebResponse)
                {
                    this.responseInfo.StatusCode = resp.StatusCode;
                    this.responseInfo.ContentType = resp.ContentType;

                    this.ReadResponse(resp);

                    if (this.responseInfo.ContentType == "application/pdf")
                    {
                    }
                    else
                    {
                        if (this.responseInfo.ResponseBytes.Length > 0)
                        {
                            this.responseInfo.ResponseText = this.encoding.GetString(this.responseInfo.ResponseBytes);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse webResp = (HttpWebResponse)ex.Response;

                    this.responseInfo.StatusCode = webResp.StatusCode;
                    this.responseInfo.ErrorMessage = webResp.StatusDescription;

                    this.responseInfo.ContentType = ex.Response.ContentType;

                    using (var reader = new System.IO.StreamReader(ex.Response.GetResponseStream(), this.encoding))
                    {
                        this.responseInfo.ResponseText = reader.ReadToEnd();
                    }
                }
                else
                {
                    this.responseInfo.ResponseText = string.Format("Non-Protocol Error: {0}", ex.Status.ToString());
                }
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// Reads the response data into ResponseInfo.ResponseBytes
        /// </summary>
        /// <param name="resp">HttpWebResponse object</param>
        private void ReadResponse(HttpWebResponse resp)
        {
            int bufSizeChunk = 30000;
            int totalBufSize = bufSizeChunk;
            byte[] fileBytes = new byte[totalBufSize];

            int totalBytesRead = 0;

            using (var reader = new System.IO.BinaryReader(resp.GetResponseStream()))
            {
                // ContentLength is not set, so realloc as needed to compensate
                int bytesRead = 0;

                while ((bytesRead = reader.Read(fileBytes, totalBytesRead, totalBufSize - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if ((totalBufSize - totalBytesRead) == 0)
                    {
                        totalBufSize += bufSizeChunk;
                        Array.Resize(ref fileBytes, totalBufSize);
                    }
                }

                Array.Resize(ref fileBytes, totalBytesRead);
                this.responseInfo.ResponseBytes = fileBytes;
            }
        }

        /// <summary>
        /// Builds a POST request
        /// </summary>
        private void ConstructPOST()
        {
            using (Stream reqStream = this.webRequest.GetRequestStream())
            {
                for (int i = 0; i < this.Request.RequestBody.Length; i++)
                {
                    if (this.Request.IsMultipart)
                    {
                        this.WriteBoundary(reqStream, false);
                    }

                    this.SetRequestBody(reqStream, i);
                }

                if (this.Request.IsMultipart)
                {
                    this.WriteBoundary(reqStream, true);
                }

#if ENABLE_REQ_DUMP                
                this.dumpWriter.Flush();
#endif
            }
        }

        /// <summary>
        /// Builds the request body for POST requests
        /// </summary>
        /// <param name="reqStream">Stream object</param>
        /// <param name="i">Index into the RequestInfo.RequestBody container</param>
        private void SetRequestBody(Stream reqStream, int i)
        {
            if (this.Request.IsMultipart)
            {
                this.SetRequestHeaderKeys(reqStream, i);
            }

            if (this.Request.RequestBody[i].Headers.ContainsKey("Content-Type") &&
               (this.Request.RequestBody[i].Headers["Content-Type"].Contains("application/json") ||
                this.Request.RequestBody[i].Headers["Content-Type"].Contains("/xml")))
            {
                this.GetRequestBody(reqStream, i);
            }
            else
            {
                if (string.IsNullOrEmpty(this.Request.RequestBody[i].FileNameBody) == true)
                {
                    this.GetRequestBody(reqStream, i);
                }
                else
                {
                    this.GetRequestBodyFromFile(reqStream, i);
                }
            }
        }

        /// <summary>
        /// Sets the request header keys
        /// </summary>
        /// <param name="reqStream">Stream object</param>
        /// <param name="i">Index into the RequestInfo.RequestBody container</param>
        private void SetRequestHeaderKeys(Stream reqStream, int i)
        {
            byte[] reqBytes;
            string line = string.Empty;

            foreach (string key in this.Request.RequestBody[i].Headers.Keys)
            {
                line = string.Format("{0}: {1}{2}", key, this.Request.RequestBody[i].Headers[key], this.Request.NewLine);
                reqBytes = this.encoding.GetBytes(line);
                reqStream.Write(reqBytes, 0, reqBytes.Length);
#if ENABLE_REQ_DUMP                
                this.dumpWriter.Write(line);
#endif
            }

            // blank line required between header and body
            reqBytes = this.encoding.GetBytes(this.Request.NewLine);
            reqStream.Write(reqBytes, 0, reqBytes.Length);
#if ENABLE_REQ_DUMP                
            this.dumpWriter.Write(this.Request.NewLine);
#endif
        }

        /// <summary>
        /// Gets the request body
        /// </summary>
        /// <param name="reqStream">Stream object</param>
        /// <param name="i">Index into the RequestInfo.RequestBody container</param>
        private void GetRequestBody(Stream reqStream, int i)
        {
            string fileContent = string.Empty;

            if (!string.IsNullOrEmpty(this.Request.RequestBody[i].RequestString))
            {
                fileContent = this.Request.RequestBody[i].RequestString;
            }
            else
            {
                if (this.Request.RequestBody[i].FileBytes != null)
                {
                    reqStream.Write(this.Request.RequestBody[i].FileBytes, 0, this.Request.RequestBody[i].FileBytes.Length);
                }
                else
                {
                    if (string.IsNullOrEmpty(this.Request.RequestBody[i].FileNameBody) == false)
                    {
                        using (StreamReader sr = new StreamReader(this.Request.RequestBody[i].FileNameBody))
                        {
                            fileContent = sr.ReadToEnd();
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.Request.RequestBody[i].Text) == false)
                        {
                            fileContent = this.Request.RequestBody[i].Text;
                        }
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(fileContent) == false)
            {
                byte[] fileContentBytes = this.encoding.GetBytes(fileContent);
                reqStream.Write(fileContentBytes, 0, fileContentBytes.Length);
            }

#if ENABLE_REQ_DUMP                
            this.dumpWriter.Write(fileContent);
            this.dumpWriter.Write(this.Request.NewLine);
#endif
        }

        /// <summary>
        /// Converts request body into byte array
        /// </summary>
        /// <param name="reqStream">Stream object</param>
        /// <param name="isClosing">Indicates whether to write a closing boundary</param>
        private void WriteBoundary(Stream reqStream, bool isClosing)
        {
            byte[] reqBytes;
            const string OpeningBoundary = "{0}--{1}{2}";
            const string ClosingBoundary = "{0}--{1}--{2}";

            if (this.Request.IsMultipart)
            {
                string boundary = isClosing == true ? ClosingBoundary : OpeningBoundary;
                var line = string.Format(boundary, this.Request.NewLine, this.Request.MultipartBoundary, this.Request.NewLine);
                reqBytes = this.encoding.GetBytes(line);
                reqStream.Write(reqBytes, 0, reqBytes.Length);
#if ENABLE_REQ_DUMP                
                this.dumpWriter.Write(line);
#endif
            }
        }

        /// <summary>
        /// Gets a response body from a file
        /// </summary>
        /// <param name="reqStream">Stream object</param>
        /// <param name="i">Index into the RequestInfo.RequestBody container</param>
        private void GetRequestBodyFromFile(Stream reqStream, int i)
        {
            // get the body of the part from a file
            using (FileStream fs = File.Open(this.Request.RequestBody[i].FileNameBody, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[32768];
                int read;

                while ((read = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    reqStream.Write(buffer, 0, read);
                }

            }
#if ENABLE_REQ_DUMP                
            this.dumpWriter.Write("[file bits go here]");
            this.dumpWriter.Write(this.Request.NewLine);
#endif
        }

        /// <summary>
        /// Adds additional headers to the request
        /// </summary>
        private void SetAdditionalHeaders()
        {
            foreach (string key in this.Request.AdditionalHeaders.Keys)
            {
                this.webRequest.Headers[key] = this.Request.AdditionalHeaders[key];
            }
        }

        /// <summary>
        /// Sets the logon credentials
        /// </summary>
        private void SetLogonCredentials()
        {
            string authStr = string.Empty;

            if (this.AuthorizationFormat == AuthFormat.Xml)
            {
                // below fills the basic cred list
                if (this.AuthorizationFlag == AuthOptions.IntegratorKeyOnly)
                {
                    authStr = string.Format("<DocuSignCredentials><Username></Username><Password></Password><IntegratorKey>{0}</IntegratorKey></DocuSignCredentials>", string.IsNullOrEmpty(this.docuSignCredentials.IntegratorKey) ? string.Empty : this.docuSignCredentials.IntegratorKey);
                }
                else
                {
                    string password = string.Empty;

                    if (string.IsNullOrEmpty(this.Request.ApiPassword) == false)
                    {
                        password = this.Request.ApiPassword;
                    }
                    else
                    {
                        password = this.docuSignCredentials.Password;
                    }

                    authStr = string.Format(
                        "<DocuSignCredentials><Username>{0}</Username><Password>{1}</Password><IntegratorKey>{2}</IntegratorKey></DocuSignCredentials>",
                        string.IsNullOrEmpty(this.docuSignCredentials.Username) ? string.Empty : this.docuSignCredentials.Username,
                        password,
                        string.IsNullOrEmpty(this.docuSignCredentials.IntegratorKey) ? string.Empty : this.docuSignCredentials.IntegratorKey);
                }
            }
            else
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DocuSignCredentials));

                using (MemoryStream ms = new MemoryStream())
                {
                    ser.WriteObject(ms, this.docuSignCredentials);
                    authStr = Encoding.UTF8.GetString(ms.ToArray());
                }
            }

            if (this.AuthorizationFlag != AuthOptions.NoCreds)
            {
                this.webRequest.Headers["X-DocuSign-Authentication"] = authStr;
            }
        }

        /// <summary>
        /// Sets the DistributorCredentials values
        /// </summary>
        private void SetDistributorCredentials()
        {
            if (this.Request.DistributorCode != null || this.Request.DistributorPassword != null)
            {
                DistributorCredentials distCreds = new DistributorCredentials();
                distCreds.DistributorCode = this.Request.DistributorCode;
                distCreds.Password = this.Request.DistributorPassword;

                using (MemoryStream ms = new MemoryStream())
                {
                    if (this.AuthorizationFormat == AuthFormat.Json)
                    {
                        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DistributorCredentials));
                        ser.WriteObject(ms, distCreds);
                    }
                    else
                    {
                        DataContractSerializer ser = new DataContractSerializer(typeof(DistributorCredentials));
                        ser.WriteObject(ms, distCreds);
                    }

                    this.webRequest.Headers["X-DocuSign-Distributor"] = Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }
    }
}
