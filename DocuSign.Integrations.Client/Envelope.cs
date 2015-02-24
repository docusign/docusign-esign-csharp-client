// -----------------------------------------------------------------------
// <copyright file="Envelope.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSign.Integrations.Client
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;

    /// <summary>
    /// Envelope class for creating envelopes, with or without a document
    /// </summary>
    public class Envelope
    {
        protected const string DefaultMimeType = "application/pdf";
        private static readonly int MaxBlurbSize = 1000;

        /// <summary>
        /// Gets or sets the Account property.  Required.  Account login must have been completed and successful.
        /// </summary>
        public Account Login { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the assigned envelope id for subsequent REST calls
        /// </summary>
        public string EnvelopeId { get; set; }

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

        /// <summary>
        /// Collection of custom fields (name/value)
        /// </summary>
        public CustomFields CustomFields { get; set; }

        /// <summary>
        /// Gets or sets the EventNotification for envelope events
        /// </summary>
        public eventNotification Events { get; set; }

        /// <summary>
        /// List of contact that needs to sign this envelope
        /// </summary>
        public Recipients Recipients { get; set; }

        /// <summary>
        /// Template information
        /// </summary>
        public TemplateRole[] TemplateRoles { get; set; }

        /// <summary>
        /// Composite Template Information
        /// </summary>
        public CompositeTemplate[] CompositeTemplates { get; set; }

        /// <summary>
        /// List of contacts that gets an email when this envelope is signed
        /// </summary>
        public Recipients CarbonCopies { get; set; }

        /// <summary>
        /// Optional element, if specified is included in email notifications to the envelope recipients. This can be a maximum of 10000 characters.
        /// </summary>
        public string EmailBlurb { get; set; }

        /// <summary>
        /// Subject of the envelope/s email that appears in the UI and the email sent to signers
        /// </summary>
        public string EmailSubject { get; set; }

        /// <summary>
        /// Status like "Draft", "Complete" etc.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the api error
        /// </summary>
        public Error RestError { get; private set; }

        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the api request
        /// </summary>
        public string RestTrace { get; private set; }

        /// <summary>
        /// TemplateId used for this envelope
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets the signed pdf when its completed from service
        /// </summary>
        /// <param name="envelopeId">The envelopeId for this envelope</param>
        /// <param name="includeCertificate">true to include a certificate of completion</param>
        /// <exception cref="ArgumentNullException">If we find a null or empty envelopeId</exception>
        /// <returns>Array of bytes for the signed document</returns>
        public byte[] GetCompletedDocument(string envelopeId, bool includeCertificate)
        {
            if (string.IsNullOrEmpty(envelopeId) == true)
            {
                throw new ArgumentNullException("envelopeId");
            }

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
                req.Uri = string.Format("{0}/envelopes/{1}/documents/combined?certificate={2}", this.Login.BaseUrl, envelopeId, includeCertificate.ToString().ToLower());

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();

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
        /// Get information about the documents for a specific envelope
        /// </summary>
        /// <param name="envelopeId">The envelopeId for this envelope</param>
        /// <exception cref="ArgumentNullException">If we find a null or empty envelopeId</exception>
        /// <returns>object with information about the envelope's documents</returns>
        public EnvelopeDocuments GetEnvelopeDocumentInfo(string envelopeId)
        {
            if (string.IsNullOrEmpty(envelopeId) == true)
            {
                throw new ArgumentNullException("envelopeId");
            }

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
                req.Uri = string.Format("{0}/envelopes/{1}/documents", this.Login.BaseUrl, envelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                    return null;
                }
                else
                {
                    return EnvelopeDocuments.FromJson(response.ResponseText);
                }
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
        #region Envelope Templates

        /// <summary>
        /// Adds a set of templates to the envelope
        /// </summary>
        /// <param name="templateIds">List of one or more template IDs</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddTemplates(List<string> templateIds)
        {
            if (templateIds.Count == 0)
            {
                throw new ArgumentException("Empty set of template IDs provided");
            }
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "POST";
                req.LoginEmail = this.Login.Email;
                req.ApiPassword = this.Login.ApiPassword;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}/envelopes/{1}/templates", this.Login.BaseUrl, this.EnvelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                var templates = new List<EnvelopeTemplate>();
                foreach (string templateId in templateIds)
                {
                    templates.Add(new EnvelopeTemplate { templateId = templateId });
                }
                var envelopeTemplates = new EnvelopeTemplates { templates = templates.ToArray() };

                RequestBody rb = new RequestBody();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                rb.Text = JsonConvert.SerializeObject(envelopeTemplates, settings).Replace("templates", "documentTemplates");
                requestBodies.Add(rb);
                req.RequestBody = requestBodies.ToArray();

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    this.ParseErrorResponse(response);
                    return false;
                }
                else
                {
                    return true;
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
        /// Adds a set of templates to the envelope
        /// </summary>
        /// <param name="templates">List of templates with auxiliary info such as documentStartPage etc.</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddTemplates(DocumentTemplates templates)
        {
            if (templates == null || templates.documentTemplates.Length == 0)
            {
                throw new ArgumentException("Empty set of template IDS provided");
            }
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "POST";
                req.LoginEmail = this.Login.Email;
                req.ApiPassword = this.Login.ApiPassword;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}/envelopes/{1}/templates", this.Login.BaseUrl, this.EnvelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;
                
                RequestBody rb = new RequestBody();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                rb.Text = JsonConvert.SerializeObject(templates, settings);
                requestBodies.Add(rb);
                req.RequestBody = requestBodies.ToArray();

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    this.ParseErrorResponse(response);
                    return false;
                }
                else
                {
                    return true;
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
        /// Get the list of Templates Matched with the envelope
        /// </summary>
        /// <exception cref="ArgumentNullException">If we find a null or empty envelopeId</exception>
        /// <returns>object with information about the envelope's documents</returns>
        public EnvelopeTemplates GetEnvelopeMatchingTemplates()
        {
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
                req.Uri = string.Format("{0}/envelopes/{1}/templates?include=matching%2Capplied", this.Login.BaseUrl, this.EnvelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                    return null;
                }
                else
                {
                    return EnvelopeTemplates.FromJson(response.ResponseText);
                }
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

        #endregion

        /// <summary>
        /// Get the custom fields loaded into this envelope object
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool GetCustomFields()
        {
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = Login.Email;
                req.LoginPassword = Login.Password;
                req.ApiPassword = Login.ApiPassword; 
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}/envelopes/{1}/custom_fields.json", this.Login.BaseUrl, this.EnvelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                    return false;
                }

                this.CustomFields = JsonConvert.DeserializeObject<CustomFields>(response.ResponseText);
                return true;
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
        /// Creates an envelope for the user without a document.
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        private bool CreateWithoutDocument()
        {
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

                rb.Text = this.CreateJson(new List<string>());

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
                    if (Status == "sent")
                    {
                        GetRecipientView();
                    }
                    else
                    {
                        GetSenderView(string.Empty);
                    }
                }
                else
                {
                    this.ParseErrorResponse(response);
                }
                return response.StatusCode == HttpStatusCode.Created;
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
        /// Adds tabs to the envelope for the first/default recipient 
        /// </summary>
        /// <param name="tabs">List of tabs to add</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddTabs(TabCollection tabs)
        {
            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = this.Login.BaseUrl;
                req.LoginEmail = this.Login.Email;
                req.LoginPassword = this.Login.Password;
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = string.Format("/envelopes/{0}/recipients/{1}/tabs", EnvelopeId, (string)(GetFirstRecipients().First())["recipientIdGuid"]);
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = this.Proxy;
                builder.Request = req;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                foreach (var tab in tabs.textTabs)
                    tab.tabLabel = Guid.NewGuid().ToString();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                rb.Text = JsonConvert.SerializeObject(tabs, settings);

                if (string.IsNullOrEmpty(rb.Text) == true)
                {
                    return false;
                }

                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;
                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.Created;
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
        /// Add subject and blurb information for an envelope one is sending
        /// </summary>
        /// <param name="subject">Email subject</param>
        /// <param name="blurb">Email body</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddEmailInformation(string subject, string blurb)
        {
            // for now just support adding all email details. We can expand if needed.
            if (String.IsNullOrEmpty(subject) || String.IsNullOrEmpty(blurb))
            {
                return false;
            }

            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = Login.BaseUrl;
                req.LoginEmail = Login.Email;
                req.LoginPassword = Login.Password;
                req.ApiPassword = Login.ApiPassword;
                req.Uri = String.Format("/envelopes/{0}", EnvelopeId);
                req.HttpMethod = "PUT";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = Proxy;
                builder.Request = req;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                var emailDetails = new Dictionary<string, string>(){
                    {"emailBlurb", blurb},
                    {"emailSubject", subject}
                };

                rb.Text = JsonConvert.SerializeObject(emailDetails);
                requestBodies.Add(rb);
                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;
                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.OK;
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
        /// Sends a reminder to recipient(s) that they need to sign
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool SendReminder()
        {
            RequestInfo req = new RequestInfo();
            req.RequestContentType = "application/json";
            req.AcceptContentType = "application/json";
            req.BaseUrl = Login.BaseUrl;
            req.LoginEmail = Login.Email;
            req.LoginPassword = Login.Password;
            req.ApiPassword = Login.ApiPassword;
            req.Uri = String.Format("/envelopes/{0}?resend_envelope=true", EnvelopeId);
            req.HttpMethod = "PUT";
            req.IntegratorKey = RestSettings.Instance.IntegratorKey;

            RequestBuilder builder = new RequestBuilder();
            builder.Proxy = Proxy;
            builder.Request = req;

            List<RequestBody> requestBodies = new List<RequestBody>();
            RequestBody rb = new RequestBody();
            rb.Text = "{}";
            requestBodies.Add(rb);
            req.RequestBody = requestBodies.ToArray();
            builder.Request = req;
            ResponseInfo response = builder.MakeRESTRequest();
            this.Trace(builder, response);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                this.ParseErrorResponse(response);
                return false;
            }

            return true;
        }


        /// <summary>
        /// Add recipients to the envelope
        /// </summary>
        /// <param name="recipients"></param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddRecipients(Recipients recipients)
        {
            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = Login.BaseUrl;
                req.LoginEmail = Login.Email;
                req.LoginPassword = Login.Password;
                req.ApiPassword = Login.ApiPassword;
                req.Uri = String.Format("/envelopes/{0}/recipients", EnvelopeId);
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = Proxy;
                builder.Request = req;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                rb.Text = JsonConvert.SerializeObject(recipients);
                requestBodies.Add(rb);
                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;
                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.Created;
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
        /// Update recipients in the envelope
        /// </summary>
        /// <param name="recipients"></param>
        /// <param name="resendEnvelope">True or false setting that defaults to false. 
        /// Setting this to true will resend the envelope to the recipient. 
        /// The resend_envelope flag is only used to resend an In Process envelope.</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool UpdateRecipients(Recipients recipients, bool resendEnvelope = false)
        {
            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = Login.BaseUrl;
                req.LoginEmail = Login.Email;
                req.LoginPassword = Login.Password;
                req.ApiPassword = Login.ApiPassword;
                req.Uri = String.Format(resendEnvelope ? "/envelopes/{0}/recipients?resend_envelope=true" : "/envelopes/{0}/recipients", EnvelopeId);
                req.HttpMethod = "PUT";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = Proxy;
                builder.Request = req;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                rb.Text = JsonConvert.SerializeObject(recipients);
                requestBodies.Add(rb);
                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;
                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.OK;
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
        /// Gets the recipients in the envelope
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool GetRecipients()
        {
            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = Login.BaseUrl;
                req.LoginEmail = Login.Email;
                req.LoginPassword = Login.Password;
                req.ApiPassword = Login.ApiPassword;
                req.Uri = String.Format("/envelopes/{0}/recipients", EnvelopeId);
                req.HttpMethod = "GET";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = Proxy;
                builder.Request = req;

                List<RequestBody> requestBodies = new List<RequestBody>();

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                    return false;
                }

                Recipients = JsonConvert.DeserializeObject<Recipients>(response.ResponseText);
                return true;
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
        /// Serializes the Json objects
        /// </summary>
        /// <param name="docPath">String value of the full path to a document.  Not required.  May be null or empty.</param>
        /// <returns>serialized Json text</returns>
        protected string CreateJson(List<string> docPaths, int startIndex = 1)
        {
            try
            {
                EnvelopeCreate env = new EnvelopeCreate();
                env.emailBlurb = RestSettings.Instance.EmailBlurb;
                env.emailSubject = string.IsNullOrEmpty(this.EmailSubject) ? RestSettings.Instance.EmailSubject : this.EmailSubject;
                if (this.CustomFields != null)
                {
                    env.customFields = this.CustomFields;
                }
                if (!String.IsNullOrEmpty(EmailBlurb))
                {
                    env.emailBlurb = new string(EmailBlurb.Take(MaxBlurbSize).ToArray());
                }

                env.recipients = this.Recipients;
                env.templateRoles = this.TemplateRoles;
                env.carbonCopies = this.CarbonCopies;
                env.status = this.Status;
                env.templateId = this.TemplateId;
                env.compositeTemplates = this.CompositeTemplates;

                // documents information...
                var docs = new List<Document>();
                int i = startIndex;
                foreach (var docPath in docPaths)
                {
                    var doc = new Document();

                    doc.documentId = i.ToString();
                    doc.name = docPath;
                    docs.Add(doc);
                    i++;
                }
                env.documents = docs.ToArray();

                env.eventNotification = this.Events;
                string output = JsonConvert.SerializeObject(env, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return output;
            }
            catch (Exception ex)
            {
                if (ex is WebException || ex is NotSupportedException || ex is InvalidOperationException || ex is ProtocolViolationException)
                {
                    // Once we get the debugging logger integrated into this project, we should write a log entry here
                    return string.Empty;
                }

                throw;
            }
        }

        /// <summary>
        /// Updates an envelope status
        /// </summary>
        /// <param name="envelopeId">The envelopeId for this envelope</param>
        /// <returns>Date/Time when the status was set</returns>
        public DateTime GetStatus(string envelopeId)
        {
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
                req.Uri = string.Format("{0}/envelopes/{1}", this.Login.BaseUrl, envelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                    return DateTime.MinValue;
                }
                JObject json = JObject.Parse(response.ResponseText);

                this.Status = (string)json["status"];
                this.EmailSubject = (string)json["emailSubject"];
                this.EmailBlurb = (string)json["emailBlurb"];

                return (DateTime)json["statusChangedDateTime"];

            }
            catch (Exception ex)
            {
                if (ex is WebException || ex is NotSupportedException || ex is InvalidOperationException || ex is ProtocolViolationException)
                {
                    // Once we get the debugging logger integrated into this project, we should write a log entry here
                    return DateTime.MinValue;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns a list of names of documents used to create this envelope
        /// </summary>
        /// <param name="envelopeId">The envelopeId for this envelope</param>
        /// <returns>a list of document names</returns>
        public List<string> GetDocNames(string envelopeID)
        {
            this.EnvelopeId = envelopeID;
            var res = new List<string>();
            foreach (var doc in GetDocuments())
                res.Add(doc.name);
            return res;
        }

        /// <summary>
        /// Returns a list of document Ids used to create this envelope
        /// </summary>
        /// <param name="envelopeId">The envelopeId for this envelope</param>
        /// <returns>a list of document Ids</returns>
        public List<string> GetDocIds(string envelopeID)
        {
            this.EnvelopeId = envelopeID;
            var res = new List<string>();
            foreach (var doc in GetDocuments())
                res.Add(doc.documentId);
            return res;
        }

        /// <summary>
        /// Returns a list of names of documents used to create this envelope
        /// </summary>
        /// <returns></returns>
        public List<EnvelopeDocument> GetDocuments()
        {
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
                req.Uri = string.Format("{0}/envelopes/{1}/documents", this.Login.BaseUrl, EnvelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                    return null;
                }
                JObject json = JObject.Parse(response.ResponseText);

                var docs = json["envelopeDocuments"];
                var res = new List<EnvelopeDocument>();
                if (docs != null)
                    foreach (var jsonDoc in docs)
                        if ((string)jsonDoc["type"] == "content")
                            res.Add(new EnvelopeDocument { documentId = (string)jsonDoc["documentId"], name = (string)jsonDoc["name"] });
                return res;
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
        /// updates the envelope's status to the one provided
        /// </summary>
        /// <param name="voidedReason">voided reason required when status is being updated to voided</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool UpdateStatus(string voidedReason = null)
        {
            try
            {
                RequestBuilder builder = new RequestBuilder();
                RequestInfo req = new RequestInfo();
                List<RequestBody> requestBodies = new List<RequestBody>();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "PUT";
                req.LoginEmail = this.Login.Email;
                req.ApiPassword = this.Login.ApiPassword;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}/envelopes/{1}", this.Login.BaseUrl, this.EnvelopeId);

                RequestBody rb = new RequestBody();

                StringBuilder sb = new StringBuilder();
                sb.Append("{");
                sb.AppendFormat("\"status\":\"{0}\"", this.Status);

                if (this.Status == "voided") {

                    if (String.IsNullOrEmpty(voidedReason))
                        throw new ArgumentException("The voided reason is required to change status to voided.");

                    sb.AppendFormat(", \"voidedReason\":\"{0}\"", voidedReason);
                }
                    
                sb.Append("}");

                rb.Text = sb.ToString();
                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
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
        /// Returns a list of names of the recipients
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetRecipientNames()
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
            req.Uri = string.Format("{0}/envelopes/{1}/recipients", this.Login.BaseUrl, EnvelopeId);

            builder.Request = req;
            builder.Proxy = this.Proxy;

            ResponseInfo response = builder.MakeRESTRequest();
            this.Trace(builder, response);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                this.ParseErrorResponse(response);
                return null;
            }
            JObject json = JObject.Parse(response.ResponseText);
            var names = new List<string>();
            var signers = json["signers"];
            foreach (var signer in signers)
                names.Add((string)signer["name"]);
            var ccs = json["carbonCopies"];
            foreach (var cc in ccs)
                names.Add((string)cc["name"]);
            var certifiedDeliveries = json["certifiedDeliveries"];
            foreach (var cd in certifiedDeliveries)
                names.Add((string)cd["name"]);
            return names;
        }

        /// <summary>
        /// Returns all recipients that have lowest routing value (meaning they need to sign first)
        /// </summary>
        /// <returns></returns>
        public IEnumerable<JToken> GetFirstRecipients()
        {
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
                req.Uri = string.Format("{0}/envelopes/{1}/recipients", this.Login.BaseUrl, EnvelopeId);

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                    return new List<JToken>();
                }
                JObject json = JObject.Parse(response.ResponseText);
                var signers = json["signers"];
                // return the first signer
                if (signers.Count() > 0)
                {
                    int minRoute = signers.Min(s => (int)s["routingOrder"]);

                    return signers.Where(s => (int)s["routingOrder"] == minRoute);
                }
                else
                {
                    return signers;
                }
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
        /// Creates an envelope for the user.
        /// </summary>
        /// <param name="path">String value of the full path to a document.  Not required.  May be null or empty.</param>
        /// <returns>true if successful, false otherwise</returns>
        /// <exception cref="ArgumentNullException">When Login or BaseUrl or ApiPassword or Path are missing</exception>
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
                return this.CreateWithoutDocument();
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
                var listOfOne = new List<string>();
                listOfOne.Add(fi.Name);
                rb.Text = this.CreateJson(listOfOne);

                if (string.IsNullOrEmpty(rb.Text) == true)
                {
                    return false;
                }

                requestBodies.Add(rb);

                RequestBody reqFile = new RequestBody();
                string mime = string.IsNullOrEmpty(this.MimeType) == true ? DefaultMimeType : this.MimeType;
                reqFile.Headers.Add("Content-Type", mime);
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
                    return this.GetSenderView(string.Empty);
                }
                else
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.Created;
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
        /// Creates an envelope for the user.
        /// </summary>
        /// <param name="fileBytes">Byte array of the file content.</param>
        /// <param name="fileName">Name of the file</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool Create(byte[] fileBytes, string fileName)
        {
            var fileBytesList = new List<byte[]>();
            var fileNamesList = new List<string>();
            fileBytesList.Add(fileBytes);
            fileNamesList.Add(fileName);
            return Create(fileBytesList, fileNamesList);
        }

        /// <summary>
        /// Creates an envelope for the user.
        /// </summary>
        /// <param name="fileBytes">Stream of the file content.</param>
        /// <param name="fileName">Name of the file</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool Create(Stream fileStream, string fileName)
        {
            var fileBytesList = new List<byte[]>();
            var fileNamesList = new List<string>();
            var memoryStream = new MemoryStream();
            fileStream.CopyTo(memoryStream);
            fileBytesList.Add(memoryStream.ToArray());
            fileNamesList.Add(fileName);
            return Create(fileBytesList, fileNamesList);
        }

        /// <summary>
        /// Creates a new envelope without specifying document information
        /// If the TemplateId is set - this will create the envelope based on the spcecified template
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool Create()
        {
            return this.Create(new List<byte[]>(), new List<string>());
        }


        /// <summary>
        /// Creates an envelope for the user.
        /// </summary>
        /// <param name="fileBytes">Byte arrays of the files' content - in correct order.</param>
        /// <param name="fileNames">File names - in correct order</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool Create(List<byte[]> fileBytesList, List<string> fileNames)
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
            if (fileNames.Count != fileBytesList.Count)
            {
                throw new ArgumentException("Mismatch between number of files names and files' bytes content - they must be the same");
            }

            RequestBuilder builder = new RequestBuilder();
            RequestInfo req = new RequestInfo();
            List<RequestBody> requestBodies = new List<RequestBody>();

            req.RequestContentType = "multipart/form-data";
            req.BaseUrl = this.Login.BaseUrl;
            req.LoginEmail = this.Login.Email;
            //req.LoginPassword = this.Login.Password;
            req.ApiPassword = this.Login.ApiPassword;
            req.Uri = "/envelopes?api_password=true";
            req.HttpMethod = "POST";
            req.IntegratorKey = RestSettings.Instance.IntegratorKey;
            req.IsMultipart = true;
            req.MultipartBoundary = new Guid().ToString();
            builder.Proxy = this.Proxy;

            if (string.IsNullOrWhiteSpace(this.Login.SOBOUserId) == false)
            {
                req.SOBOUserId = this.Login.SOBOUserId;
                builder.AuthorizationFormat = RequestBuilder.AuthFormat.Json;
            }

            RequestBody rb = new RequestBody();
            rb.Headers.Add("Content-Type", "application/json");
            rb.Headers.Add("Content-Disposition", "form-data");
            rb.Text = this.CreateJson(fileNames);
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
                this.ParseCreateResponse(response);
                return this.GetSenderView(string.Empty);
            }
            else
            {
                this.ParseErrorResponse(response);
            }

            return response.StatusCode == HttpStatusCode.Created;
        }

        /// <summary>
        /// Once an envelope has been created, this method obtains the URL to the recipient view
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool GetRecipientView()
        {
            return GetRecipientView(@DocuSign.Integrations.Client.RestSettings.Instance.DocuSignAddress);
        }

        /// <summary>
        /// Once an envelope has been created, this method obtains the URL to the recipient view
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool GetRecipientView(string returnUrl)
        {
            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = this.Login.BaseUrl;
                req.LoginEmail = this.Login.Email;
                req.LoginPassword = this.Login.Password;
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = "/envelopes/" + this.EnvelopeId + "/views/recipient.json?api_password=true";
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = this.Proxy;
                builder.Request = req;

                if (string.IsNullOrWhiteSpace(this.Login.SOBOUserId) == false)
                {
                    req.SOBOUserId = this.Login.SOBOUserId;
                    builder.AuthorizationFormat = RequestBuilder.AuthFormat.Json;
                }

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                RecipientView rv = new RecipientView();
                rv.returnUrl = returnUrl;
                rv.email = this.Login.Email;
                rv.userName = this.Login.AccountName;
                rv.authenticationMethod = "email";

                rb.Text = rv.Serialize();
                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;
                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    JObject json = JObject.Parse(response.ResponseText);

                    this.SenderViewUrl = (string)json["url"] + "&noDownloadPrint=true&appname=docusignit";
                }
                else
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.Created;
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
        /// Generates a URL For embedded signing for a specific signer
        /// </summary>
        /// <param name="returnUrl">URL to take user after signing is completed</param>
        /// <param name="signer">Signer information for the person that would be signing</param>
        /// <returns>Url for embedded signing</returns>
        public string GetEmbeddedSignerView(string returnUrl, Signer signer)
        {
            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = this.Login.BaseUrl;
                req.LoginEmail = this.Login.Email;
                req.LoginPassword = this.Login.Password;
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = "/envelopes/" + this.EnvelopeId + "/views/recipient";
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = this.Proxy;
                builder.Request = req;

                if (string.IsNullOrWhiteSpace(this.Login.SOBOUserId) == false)
                {
                    req.SOBOUserId = this.Login.SOBOUserId;
                    builder.AuthorizationFormat = RequestBuilder.AuthFormat.Json;
                }

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                RecipientView rv = new RecipientView();
                rv.returnUrl = returnUrl;
                rv.email = signer.email;
                rv.userName = signer.name;
                rv.clientUserId = signer.clientUserId;
                rv.authenticationMethod = "email";

                rb.Text = rv.Serialize();
                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;
                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    JObject json = JObject.Parse(response.ResponseText);
                    return (string)json["url"];
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                if (ex is WebException || ex is NotSupportedException || ex is InvalidOperationException || ex is ProtocolViolationException)
                {
                    // Once we get the debugging logger integrated into this project, we should write a log entry here
                    return string.Empty;
                }

                throw;
            }
        }

        /// <summary>
        /// Once an envelope has been created, this method obtains the URL to the sender view
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool GetSenderView(string returnUrl)
        {
            try
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

                if (string.IsNullOrWhiteSpace(this.Login.SOBOUserId) == false)
                {
                    req.SOBOUserId = this.Login.SOBOUserId;
                    builder.AuthorizationFormat = RequestBuilder.AuthFormat.Json;
                }

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                SenderView sv = new SenderView();
                sv.returnUrl = returnUrl;

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
        /// Add custom fields to this envelope
        /// </summary>
        /// <param name="customFields">Dictionary of custom fields to be added</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddCustomFields(Dictionary<string, object> customFields)
        {
            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.BaseUrl = Login.BaseUrl;
                req.LoginEmail = Login.Email;
                req.LoginPassword = Login.Password;
                req.ApiPassword = Login.ApiPassword;
                req.Uri = String.Format("/envelopes/{0}/custom_fields", EnvelopeId);
                req.HttpMethod = "POST";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder builder = new RequestBuilder();
                builder.Proxy = Proxy;
                builder.Request = req;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                var customFieldsArray = EnvelopeStatus.CustomField.CreateCustomFieldsArray(customFields);
                var textCustomFields = new Dictionary<string, TextCustomField[]>(){
                    {"textCustomFields" , customFieldsArray}
                };

                rb.Text = JsonConvert.SerializeObject(textCustomFields);
                requestBodies.Add(rb);
                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;
                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.Created;
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
        /// Add a document to this envelope (must be in draft state)
        /// </summary>
        /// <param name="fileBytes">new file content</param>
        /// <param name="fileName">new file name</param>
        /// <param name="index">Index for the new file</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddDocument(byte[] fileBytes, string fileName, int index)
        {
            List<byte[]> fileBytesList = new List<byte[]>();
            List<string> fileNames = new List<string>();
            fileBytesList.Add(fileBytes);
            fileNames.Add(fileName);

            return AddDocument(fileBytesList, fileNames, index);
        }

        /// <summary>
        /// Add documents to this envelope (must be in draft state)
        /// </summary>
        /// <param name="fileBytes">new file content</param>
        /// <param name="fileName">new file name</param>
        /// <param name="index">Index for the new file</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool AddDocument(List<byte[]> fileBytesList, List<string> fileNames, int index = 1)
        {
            RequestBuilder builder = new RequestBuilder();
            RequestInfo req = new RequestInfo();
            List<RequestBody> requestBodies = new List<RequestBody>();

            req.RequestContentType = "multipart/form-data";
            req.BaseUrl = this.Login.BaseUrl;
            req.LoginEmail = this.Login.Email;
            //req.LoginPassword = this.Login.Password;
            req.ApiPassword = this.Login.ApiPassword;
            req.Uri = "/envelopes/" + EnvelopeId + "/documents";
            req.HttpMethod = "PUT";
            req.IntegratorKey = RestSettings.Instance.IntegratorKey;
            req.IsMultipart = true;
            req.MultipartBoundary = Guid.NewGuid().ToString();
            builder.Proxy = this.Proxy;

            RequestBody rb = new RequestBody();
            rb.Text = this.CreateJson(fileNames, index);
            rb.Headers.Add("Content-Type", "application/json");
            rb.Headers.Add("Content-Disposition", "form-data");
            requestBodies.Add(rb);

            rb = new RequestBody();

            for (int i = 0; i < fileNames.Count; i++)
            {
                var fileName = fileNames[i];
                RequestBody reqFile = new RequestBody();
                string mime = string.IsNullOrEmpty(this.MimeType) == true ? DefaultMimeType : this.MimeType;
                reqFile.Headers.Add("Content-Type", mime);
                reqFile.Headers.Add("Content-Disposition", string.Format("file; filename=\"{0}\"; documentId={1}", fileName, index++));

                reqFile.FileBytes = fileBytesList[i];
                reqFile.SubstituteStrings = false;
                requestBodies.Add(reqFile);
            }

            req.RequestBody = requestBodies.ToArray();
            builder.Request = req;

            ResponseInfo response = builder.MakeRESTRequest();
            this.Trace(builder, response);

            if ((response.StatusCode == HttpStatusCode.OK) && (!response.ResponseText.Contains("FORMAT_CONVERSION_ERROR")))
            {
                this.ParseCreateResponse(response);
                return true;
            }
            else
            {
                this.ParseErrorResponse(response);
                return false;
            }
        }

        /// <summary>
        /// Remove a document from this envelop (must be in draft state)
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool RemoveDocument(int docId)
        {
            List<string> docList = new List<string>();
            docList.Add(docId.ToString());

            return RemoveDocument(docList);
        }

        /// <summary>
        /// Remove documents from this envelop (must be in draft state)
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool RemoveDocument(List<string> docList)
        {
            if (docList == null)
            {
                return false;
            }

            if (docList.Count == 0)
            {
                return true;
            }

            List<Document> docs = new List<Document>();

            foreach (string docId in docList)
            {
                var doc = new Document { documentId = docId };
                docs.Add(doc);
            }

            RequestBuilder builder = new RequestBuilder();
            RequestInfo req = new RequestInfo();
            List<RequestBody> requestBodies = new List<RequestBody>();

            req.RequestContentType = "application/json";
            req.AcceptContentType = "application/json";
            req.BaseUrl = this.Login.BaseUrl;
            req.LoginEmail = this.Login.Email;
            //req.LoginPassword = this.Login.Password;
            req.ApiPassword = this.Login.ApiPassword;
            req.Uri = "/envelopes/" + EnvelopeId + "/documents/";
            req.HttpMethod = "DELETE";
            req.IntegratorKey = RestSettings.Instance.IntegratorKey;
            builder.Proxy = this.Proxy;

            RequestBody rb = new RequestBody();
            EnvelopeCreate env = new EnvelopeCreate();
            env.documents = docs.ToArray();

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            rb.Text = JsonConvert.SerializeObject(env, settings);
            requestBodies.Add(rb);

            req.RequestBody = requestBodies.ToArray();
            builder.Request = req;

            ResponseInfo response = builder.MakeRESTRequest();
            this.Trace(builder, response);

            return response.StatusCode == HttpStatusCode.OK;
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
        protected void ParseErrorResponse(ResponseInfo response)
        {
            try
            {
                this.RestError = Error.FromJson(response.ResponseText);
            }
            catch
            {
                this.RestError = new Error { message = response.ResponseText };
            }
        }

        protected void Trace(RequestBuilder utils, ResponseInfo response)
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

        /// <summary>
        /// Get envelopes for this user's account
        /// </summary>
        /// <param name="fromDate">start date to find envelopes for this user</param>
        /// <returns>List of envelopes for this account</returns>
        public AccountEnvelopes GetAccountsEnvelopes(DateTime fromDate)
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
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = "/envelopes?api_password=true&from_date=" + fromDate.ToString();
                req.HttpMethod = "GET";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.IsMultipart = true;
                req.MultipartBoundary = new Guid().ToString();
                builder.Proxy = this.Proxy;


                RequestBody rb = new RequestBody();
                rb.Headers.Add("Content-Type", "application/json");

                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                var envs = AccountEnvelopes.FromJson(response.ResponseText);
                return envs;

            }
            catch
            {
                throw;
            }

        }
        /// <summary>
        /// Get draft envelopes for this user's account
        /// </summary>
        /// <param name="fromDate">start date to find envelopes for this user</param>
        /// <returns>List of envelopes for this account</returns>
        public AccountEnvelopes GetDraftEnvelopes(DateTime fromDate)
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
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = "/search_folders/drafts?api_password=true&from_date=" + fromDate.ToString();
                req.HttpMethod = "GET";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.IsMultipart = true;
                req.MultipartBoundary = new Guid().ToString();
                builder.Proxy = this.Proxy;


                RequestBody rb = new RequestBody();
                rb.Headers.Add("Content-Type", "application/json");

                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                var envs = new List<EnvelopeInfo>();
                JObject json = JObject.Parse(response.ResponseText);
                foreach (var item in json["folderItems"])
                {
                    var ei = new EnvelopeInfo();
                    ei.EnvelopeId = (string)item["envelopeId"];
                    ei.StatusChangedDateTime = (string)item["createdDateTime"];
                    ei.Status = "created";
                    envs.Add(ei);
                }
                return new AccountEnvelopes { Envelopes = envs.ToArray() };

            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// Gets the number of envelopes in the search folder
        /// </summary>
        /// <param name="folderName"></param>
        /// <param name="fromDate"></param>
        /// <returns></returns>
        public int GetSearchFolderCount(string folderName, DateTime fromDate)
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
                req.ApiPassword = this.Login.ApiPassword;
                req.Uri = string.Format("/search_folders/{0}?from_date={1}", folderName, fromDate);
                req.HttpMethod = "GET";
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.IsMultipart = true;
                req.MultipartBoundary = new Guid().ToString();
                builder.Proxy = this.Proxy;


                RequestBody rb = new RequestBody();
                rb.Headers.Add("Content-Type", "application/json");

                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                builder.Request = req;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                JObject json = JObject.Parse(response.ResponseText);
                return (int)json["totalRows"];

            }
            catch
            {
                throw;
            }
        }
    }
}

