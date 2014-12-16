// -----------------------------------------------------------------------
// <copyright file="Envelope.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Envelope class for creating envelopes, with or without a document
    /// </summary>
    public class Envelope
    {
        /// <summary>
        /// Gets or sets the Account property.  Required.  Account login must have been completed and successful.
        /// </summary>
        public Account Login { get; set; }

        /// <summary>
        /// Gets a value indicating the assigned envelope id for subsequent REST calls
        /// </summary>
        public string EnvelopeId { get; private set; }

        /// <summary>
        /// Gets a value indicating the response URL
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets a value indicating the URL to the sender view of the envelope
        /// </summary>
        public string SenderViewUrl { get; private set; }

        /// <summary>
        /// Gets or sets the WebProxy for Http requests
        /// </summary>
        public WebProxy Proxy { get; set; }

        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Gets or sets the EventNotification for envelope events
        /// </summary>
        public eventNotification Events { get; set; }

        public Recipients Recipients{ get; set; }

        /// <summary>
        /// Gets or sets the api error
        /// </summary>
        public Error RestError { get; private set; }

        /// <summary>
        /// Gets or sets the api request
        /// </summary>
        public string RestTrace { get; private set; }

        public bool GetCustomFields(string accountId, string envelopeId)
        {
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = string.Empty;
                req.LoginPassword = string.Empty;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}/envelopes/{1}/custom_fields.json", this.Login.BaseUrl, envelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                    return false;
                }

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Creates an envelope for the user.
        /// </summary>
        /// <param name="path">String value of the full path to a document.  Not required.  May be null or empty.</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool Create(string path)
        {
            if (this.Login == null)
            {
                throw new ArgumentNullException("Login");
            }

            if (string.IsNullOrEmpty(this.Login.BaseUrl) == true)
            {
                throw new ArgumentNullException("BaseUrl");
            }

            if (string.IsNullOrEmpty(this.Login.ApiPassword) == true)
            {
                throw new ArgumentNullException("ApiPassword");
            }

            if (string.IsNullOrEmpty(path) == true)
            {
                return this.Create();
            }

            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "multipart/form-data";
                req.BaseUrl = this.Login.BaseUrl;
                req.LoginEmail = this.Login.Email;
                req.LoginPassword = this.Login.Password;
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = "/envelopes?api_password=true";
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.IsMultipart = true;
                req.MultipartBoundary = new Guid().ToString();
                builder.Proxy = this.Proxy;

                RequestBody rb = new RequestBody();
                rb.Headers.Add("Content-Type", "application/json");
                rb.Headers.Add("Content-Disposition", "form-data");

                FileInfo fi = new FileInfo(path);
                rb.Text = this.CreateJson(fi.Name);

                if (string.IsNullOrEmpty(rb.Text) == true)
                {
                    return false;
                }

                requestBodies.Add(rb);

                RequestBody reqFile = new RequestBody();
                reqFile.Headers.Add("Content-Type", "application/pdf");
                reqFile.Headers.Add("Content-Disposition", string.Format("file; filename=\"{0}\"; documentId=1", fi.Name));

                reqFile.FileNameBody = path;
                reqFile.SubstituteStrings = false;
                requestBodies.Add(reqFile);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    this.ParseCreateResponse(response);
                    return this.GetSenderView();
                }
                else
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.Created;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// Creates an envelope for the user.
        /// </summary>
        /// <param name="fileBytes">Byte array of the file content.</param>
        /// <param name="fileName">Name of the file</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool Create(byte[] fileBytes, string fileName)
        {
            if (this.Login == null)
            {
                throw new ArgumentNullException("Login");
            }

            if (string.IsNullOrEmpty(this.Login.BaseUrl) == true)
            {
                throw new ArgumentNullException("BaseUrl");
            }

            if (string.IsNullOrEmpty(this.Login.ApiPassword) == true)
            {
                throw new ArgumentNullException("ApiPassword");
            }

            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "multipart/form-data";
                req.BaseUrl = this.Login.BaseUrl;
                req.LoginEmail = this.Login.Email;
                req.LoginPassword = this.Login.Password;
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = "/envelopes?api_password=true";
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.IsMultipart = true;
                req.MultipartBoundary = new Guid().ToString();
                builder.Proxy = this.Proxy;

                RequestBody rb = new RequestBody();
                rb.Headers.Add("Content-Type", "application/json");
                rb.Headers.Add("Content-Disposition", "form-data");

                rb.Text = this.CreateJson(fileName);

                if (string.IsNullOrEmpty(rb.Text) == true)
                {
                    return false;
                }

                requestBodies.Add(rb);

                RequestBody reqFile = new RequestBody();
                reqFile.Headers.Add("Content-Type", "application/pdf");
                reqFile.Headers.Add("Content-Disposition", string.Format("file; filename=\"{0}\"; documentId=1", fileName));

                reqFile.FileBytes = fileBytes;
                reqFile.SubstituteStrings = false;
                requestBodies.Add(reqFile);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    this.ParseCreateResponse(response);
                    return this.GetSenderView();
                }
                else
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.Created;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Creates an envelope for the user without a document.
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        private bool Create()
        {
            if (this.Login == null)
            {
                throw new ArgumentNullException("Login");
            }

            if (string.IsNullOrEmpty(this.Login.BaseUrl) == true)
            {
                throw new ArgumentNullException("BaseUrl");
            }

            if (string.IsNullOrEmpty(this.Login.ApiPassword) == true)
            {
                throw new ArgumentNullException("ApiPassword");
            }

            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = this.Login.BaseUrl;
                req.LoginEmail = this.Login.Email;
                req.LoginPassword = this.Login.Password;
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = "/envelopes?api_password=true";
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = this.Proxy;
                builder.Request = req;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                rb.Text = this.CreateJson(null);

                if (string.IsNullOrEmpty(rb.Text) == true)
                {
                    return false;
                }

                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;
                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    this.ParseCreateResponse(response);
                    this.GetSenderView();
                }
                else
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.Created;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Serializes the Json objects
        /// </summary>
        /// <param name="docPath">String value of the full path to a document.  Not required.  May be null or empty.</param>
        /// <returns>serialized Json text</returns>
        private string CreateJson(string docPath)
        {
            try
            {
                EnvelopeCreate env = new EnvelopeCreate();
                env.emailBlurb = RestSettings.Instance.EmailBlurb;
                env.emailSubject = RestSettings.Instance.EmailSubject;
                if (this.CustomFields != null)
                {
                    env.customFields = this.CustomFields;
                }

                env.recipients = this.Recipients;

                if (string.IsNullOrEmpty(docPath) == false)
                {
                    List<Document> docs = new List<Document>();

                    FileInfo fi = new FileInfo(docPath);

                    Document doc = new Document();
                    doc.documentId = "1";
                    doc.name = docPath;
                    doc.fileExtension = fi.Extension;
                    docs.Add(doc);
                    env.documents = docs.ToArray();
                }

                env.eventNotification = this.Events;
                string output = JsonConvert.SerializeObject(env);
                return output;
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Once an envelope has been created, this method obtains the URL to the sender view
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        private bool GetSenderView()
        {
            RequestInfo req = new RequestInfo();
            req.RequestContentType = "application/json";
            req.AcceptContentType = "application/json";
            req.BaseUrl = this.Login.BaseUrl;
            req.LoginEmail = this.Login.Email;
            req.LoginPassword = this.Login.Password;
            req.ApiPassword = this.Login.ApiPassword;
            req.Uri = "/envelopes/" + this.EnvelopeId + "/views/sender.json?api_password=true";
            req.HttpMethod = "POST";
            req.IntegratorKey = RestSettings.Instance.IntegratorKey;

            RequestBuilder builder = new RequestBuilder();
            builder.Proxy = this.Proxy;
            builder.Request = req;

            List<RequestBody> requestBodies = new List<RequestBody>();
            RequestBody rb = new RequestBody();

            SenderView sv = new SenderView();
            sv.returnUrl = string.Empty;

            rb.Text = sv.Serialize();
            requestBodies.Add(rb);

            req.RequestBody = requestBodies.ToArray();
            builder.Request = req;
            ResponseInfo response = builder.MakeRESTRequest();
            this.Trace(builder, response);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                JObject json = JObject.Parse(response.ResponseText);

                this.SenderViewUrl = (string)json["url"];
            }
            else
            {
                this.ParseErrorResponse(response);
            }

            return response.StatusCode == HttpStatusCode.Created;
        }

        /// <summary>
        /// Parses response Json to retrieve pertinent information
        /// </summary>
        /// <param name="response">ResponseInfo object</param>
        private void ParseCreateResponse(ResponseInfo response)
        {
            if (response.StatusCode == HttpStatusCode.Created)
            {
                JObject json = JObject.Parse(response.ResponseText);

                this.EnvelopeId = (string)json["envelopeId"];
                this.Url = (string)json["uri"];
            }
        }

        /// <summary>
        /// Parses Json response containing errors
        /// </summary>
        /// <param name="response">ResponseInfo object</param>
        private void ParseErrorResponse(ResponseInfo response)
        {
            this.RestError = Error.FromJson(response.ResponseText);
        }

        private void Trace(RequestBuilder utils, ResponseInfo response)
        {
            if (RestSettings.Instance.RestTracing == true)
            {
                StringBuilder sb = new StringBuilder(this.RestTrace);
                sb.AppendLine();
                sb.AppendLine(utils.Dump());
                sb.AppendLine();
                sb.AppendLine("Response:");
                sb.AppendLine(response.ResponseText);
                sb.AppendLine();
                this.RestTrace = sb.ToString();
            }
        }
    }
}
