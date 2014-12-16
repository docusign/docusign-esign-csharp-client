// -----------------------------------------------------------------------
// <copyright file="DocuSignCredentials.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [DataContract(Namespace = "")]
    public class DocuSignCredentials
    {
        /// <summary>
        /// Gets or sets the Username property
        /// </summary>
        [DataMember]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the Password property
        /// </summary>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the IntegratorKey property
        /// </summary>
        [DataMember]
        public string IntegratorKey { get; set; }

        /// <summary>
        /// Gets or sets the SendOnBehalfOf property
        /// </summary>
        [DataMember]
        public string SendOnBehalfOf { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>AccountCreate instance</returns>
        public static DocuSignCredentials FromJson(string json)
        {
            return JsonConvert.DeserializeObject<DocuSignCredentials>(json);
        }

        /// <summary>
        /// Serializes self
        /// </summary>
        /// <returns>serialized Json text</returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
