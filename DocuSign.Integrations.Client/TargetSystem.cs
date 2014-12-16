// -----------------------------------------------------------------------
// <copyright file="TargetSystem.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// REST settings for the target system (test, demo, production, etc.)
    /// </summary>
    public class TargetSystem 
    {
        /// <summary>
        /// Gets or sets the integrator key property
        /// </summary>
        public string IntegratorKey { get; set; }

        /// <summary>
        /// Gets or sets the web service url property
        /// </summary>
        public string WebServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets the distributor code property
        /// </summary>
        public string DistributorCode { get; set; }

        /// <summary>
        /// Gets or sets the distributor password property
        /// </summary>
        public string DistributorPassword { get; set; }

        /// <summary>
        /// Gets or sets the plan id property
        /// </summary>
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or sets the feature set id
        /// </summary>
        public string FeatureSetId { get; set; }

        /// <summary>
        /// Gets or sets the email blurb property
        /// </summary>
        public string EmailBlurb { get; set; }

        /// <summary>
        /// Gets or sets the email subject property
        /// </summary>
        public string EmailSubject { get; set; }
    }
}