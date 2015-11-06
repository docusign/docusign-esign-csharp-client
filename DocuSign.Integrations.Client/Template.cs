// -----------------------------------------------------------------------
// <copyright file="Template.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace DocuSign.Integrations.Client
{
    /// <summary>
    /// Template is a speical kind of envelope
    /// </summary>
    public class Template : Envelope
    {
        /// <summary>
        /// Creates a new template
        /// </summary>
        /// <param name="fileBytes">Byte arrays of the files' content - in correct order.</param>
        /// <param name="fileNames">File names - in correct order</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool CreateTemplate(List<byte[]> fileBytesList, List<string> fileNames, string templateName)
        {
            CheckAPIPreRequisites();
            if (fileNames.Count != fileBytesList.Count)
            {
                throw new ArgumentException("Mismatch between number of files names and files' bytes content - they must be the same");
            }
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "multipart/form-data";
                req.BaseUrl = this.Login.BaseUrl;
                req.LoginEmail = this.Login.Email;
                //req.LoginPassword = this.Login.Password;
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = "/templates?api_password=true";
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.IsMultipart = true;
                req.MultipartBoundary = new Guid().ToString();
                builder.Proxy = this.Proxy;

                RequestBody rb = new RequestBody();
                rb.Headers.Add("Content-Type", "application/json");
                rb.Headers.Add("Content-Disposition", "form-data");
                rb.Text = this.CreateJson(fileNames);
                rb.Text += "  \"envelopeTemplateDefinition\": {\"name\": \"" + templateName + "\"}";
                requestBodies.Add(rb);

                for (int i = 0; i < fileNames.Count; i++)
                {
                    var fileName = fileNames[i];
                    RequestBody reqFile = new RequestBody();
                    string mime = string.IsNullOrEmpty(this.MimeType) == true ? DefaultMimeType : this.MimeType;
                    reqFile.Headers.Add("Content-Type", mime);
                    reqFile.Headers.Add("Content-Disposition", string.Format("file; filename=\"{0}\"; documentId={1}", fileName, i + 1));

                    reqFile.FileBytes = fileBytesList[i];
                    reqFile.SubstituteStrings = false;
                    requestBodies.Add(reqFile);
                }

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    JObject json = JObject.Parse(response.ResponseText);
                    this.EnvelopeId = (string)json["templateId"];
                    return this.GetSenderView(string.Empty);
                }
                else
                {
                    this.ParseErrorResponse(response);
                    return false;
                }
            }
            catch (Exception ex)
            {
                if (ex is WebException || ex is NotSupportedException || ex is InvalidOperationException || ex is ProtocolViolationException)
                {
                    // Once we get the debugging logger integrated into this project, we should write a log entry here
                    return false;
                }

                throw;
            }
        }

        /// <summary>
        /// This retrieves the definition of the specified template.
        /// </summary>
        /// <returns>Can return null.</returns>
        public JObject GetTemplate(string templateId)
        {
            CheckAPIPreRequisites();
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Login.Email;
                req.BaseUrl = this.Login.BaseUrl;
                req.ApiPassword = this.Login.ApiPassword;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("/templates/{0}", templateId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }

                return JObject.Parse(response.ResponseText);
            }
            catch (Exception ex)
            {
                if (ex is WebException || ex is NotSupportedException || ex is InvalidOperationException || ex is ProtocolViolationException)
                {
                    // Once we get the debugging logger integrated into this project, we should write a log entry here
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// This retrieves the definition of the specified template.
        /// </summary>
        /// <returns></returns>
        public byte[] GetTemplatePreview(string templateId)
        {
            CheckAPIPreRequisites();
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Login.Email;
                req.BaseUrl = this.Login.BaseUrl;
                req.ApiPassword = this.Login.ApiPassword;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("/templates/{0}/documents/{1}/pages/1/page_image", templateId, GetDocIds(templateId)[0]);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }

                return response.ResponseBytes;
            }
            catch (Exception ex)
            {
                if (ex is WebException || ex is NotSupportedException || ex is InvalidOperationException || ex is ProtocolViolationException)
                {
                    // Once we get the debugging logger integrated into this project, we should write a log entry here
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns a list of templates for this user's account
        /// </summary>
        /// <returns>Can return null.</returns>
        public List<TemplateInfo> GetTemplates()
        {
            CheckAPIPreRequisites();
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Login.Email;
                req.ApiPassword = this.Login.ApiPassword;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}/templates?order=desc&order_by=used", this.Login.BaseUrl);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                var templates = new List<TemplateInfo>();

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }
                else
                {
                    JObject json = JObject.Parse(response.ResponseText);

                    // For the case of no templates in an account, the JSON doesn't even contain envelopeTemplates property
                    if (json["envelopeTemplates"] != null)
                    {
                        foreach (var template in json["envelopeTemplates"])
                        {
                            templates.Add(new TemplateInfo
                            {
                                Id = (string)template["templateId"],
                                Name = (string)template["name"],
                                // removing end of lines from description as it's breaking the UI
                                Description = ((string)template["description"]).Replace('\n', ' ').Replace('\r', ' ')
                            });
                        }
                    }
                }

                return templates;
            }
            catch (Exception ex)
            {
                if (ex is WebException || ex is NotSupportedException || ex is InvalidOperationException || ex is ProtocolViolationException)
                {
                    // Once we get the debugging logger integrated into this project, we should write a log entry here
                    return null;
                }

                throw;
            }
        }
    }

    /// <summary>
    /// Data Transfer Object class for template infor
    /// </summary>
    public class TemplateInfo
    {
        /// <summary>
        /// Template ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Template Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Template's description
        /// </summary>
        public string Description { get; set; }
    }
}
