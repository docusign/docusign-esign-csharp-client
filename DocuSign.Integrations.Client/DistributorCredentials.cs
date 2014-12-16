// -----------------------------------------------------------------------
// <copyright file="DistributorCredentials.cs" company="DocuSign, Inc.">
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

    /// <summary>
    /// DistributorCredentials class
    /// </summary>
    [DataContract(Namespace = "")]
    public class DistributorCredentials
    {
        /// <summary>
        /// Gets or sets the DistributorCode property
        /// </summary>
        [DataMember]
        public string DistributorCode { get; set; }

        /// <summary>
        /// Gets or sets the Password property
        /// </summary>
        [DataMember]
        public string Password { get; set; }
    }
}
