// -----------------------------------------------------------------------
// <copyright file="RequestBody.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSign.Integrations.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// RequestBody class
    /// </summary>
    public class RequestBody
    {
        /// <summary>
        /// Initializes a new instance of the RequestBody class
        /// </summary>
        public RequestBody()
        {
            this.Headers = new Dictionary<string, string>();
            this.FileNameBody = string.Empty;
            this.SubstituteStrings = null;
            this.FileBytes = null;
        }

        /// <summary>
        /// Gets or sets the Headers property
        /// </summary>
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or sets the FileNameBody property
        /// </summary>
        public byte[] FileBytes { get; set; }

        /// <summary>
        /// Gets or sets the FileNameBody property
        /// </summary>
        public string FileNameBody { get; set; }

        /// <summary>
        /// Gets or sets the Text property
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the RequestString property
        /// </summary>
        public string RequestString { get; set; }

        /// <summary>
        /// Gets or sets the SubstituteStrings property
        /// </summary>
        public bool? SubstituteStrings { get; set; }
    }
}
