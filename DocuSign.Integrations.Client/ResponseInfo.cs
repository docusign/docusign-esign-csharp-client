// -----------------------------------------------------------------------
// <copyright file="ResponseInfo.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System.Net;

    /// <summary>
    /// ResponseInfo class
    /// </summary>
    public class ResponseInfo
    {
        /// <summary>
        /// Initializes a new instance of the ResponseInfo class
        /// </summary>
        public ResponseInfo()
        {
            this.ContentType = string.Empty;
            this.StatusCode = HttpStatusCode.Unused;
            this.ErrorMessage = string.Empty;
            this.ResponseText = string.Empty;
            this.ResponseBytes = null;
        }

        /// <summary>
        /// Gets or sets the ContentType property
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the StatusCode property
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the ErrorMessage property
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the ResponseText property
        /// </summary>
        public string ResponseText { get; set; }

        /// <summary>
        /// Gets or sets the ResponseBytes property
        /// </summary>
        public byte[] ResponseBytes { get; set; } // if a binary response
    }
}
