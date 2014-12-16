// -----------------------------------------------------------------------
// <copyright file="RequestInfo.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System.Collections.Generic;

    /// <summary>
    /// RequestInfo class
    /// </summary>
    internal class RequestInfo
    {
        /// <summary>
        /// Gets or sets the uri property
        /// </summary>
        private string uri;

        /// <summary>
        /// Initializes a new instance of the RequestInfo class
        /// </summary>
        public RequestInfo()
        {
            this.InitInstance("\r\n");
        }

        /// <summary>
        /// Initializes a new instance of the RequestInfo class
        /// </summary>
        /// <param name="newLine">New line characters to use</param>
        public RequestInfo(string newLine)
        {
            this.InitInstance(newLine);
        }

        /// <summary>
        /// Gets or sets the FullUrl property
        /// </summary>
        public string FullUrl { get; set; }

        /// <summary>
        /// Gets or sets the BaseUrl property
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the HttpMethod property
        /// </summary>
        public string HttpMethod { get; set; }

        /// <summary>
        /// Gets or sets the RequestContentType property
        /// </summary>
        public string RequestContentType { get; set; }

        /// <summary>
        /// Gets or sets the AcceptContentType property
        /// </summary>
        public string AcceptContentType { get; set; }

        /// <summary>
        /// Gets the AdditionalHeaders property
        /// </summary>
        public Dictionary<string, string> AdditionalHeaders { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether the request is multi-part
        /// </summary>
        public bool IsMultipart { get; set; }

        /// <summary>
        /// Gets or sets the MultiPartBoundary property
        /// </summary>
        public string MultipartBoundary { get; set; }

        /// <summary>
        /// Gets or sets the LoginEmail property
        /// </summary>
        public string LoginEmail { get; set; }

        /// <summary>
        /// Gets or sets the LoginPassword property
        /// </summary>
        public string LoginPassword { get; set; }

        /// <summary>
        /// Gets or sets the ApiPassword property
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Gets or sets the IntegratorKey property
        /// </summary>
        public string IntegratorKey { get; set; }

        /// <summary>
        /// Gets or sets the NewLine property
        /// </summary>
        public string NewLine { get; set; }

        /// <summary>
        /// Gets or sets the Timeout property
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the DistributorCode property
        /// </summary>
        public string DistributorCode { get; set; }

        /// <summary>
        /// Gets or sets the DistributorPassword property
        /// </summary>
        public string DistributorPassword { get; set; }

        /// <summary>
        /// Gets or sets the Uri property
        /// </summary>
        public string Uri
        {
            get
            {
                return this.uri;
            }

            set
            {
                this.uri = value;
                this.FullUrl = this.BaseUrl + this.uri;
            }
        }

        /// <summary>
        /// Gets or sets the Headers property
        /// </summary>
        public RequestBody[] RequestBody { get; set; }

        /// <summary>
        /// Initializes the properties
        /// </summary>
        /// <param name="newLine">line ending characters to use</param>
        private void InitInstance(string newLine)
        {
            this.AdditionalHeaders = new Dictionary<string, string>();
            this.NewLine = newLine;
            this.Uri = string.Empty;
            this.FullUrl = string.Empty;
            this.HttpMethod = string.Empty;
            this.RequestContentType = string.Empty;
            this.AcceptContentType = string.Empty;
            this.IsMultipart = false;
            this.MultipartBoundary = string.Empty;
            this.LoginEmail = string.Empty;
            this.LoginPassword = string.Empty;
            this.IntegratorKey = string.Empty;
            this.BaseUrl = string.Empty;
            this.RequestBody = new RequestBody[0];
        }
    }
}
