// -----------------------------------------------------------------------
// <copyright file="RestSettings.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSign.Integrations.Client
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// Reads REST configuration values from app.config
    /// </summary>
    public class RestSettings
    {
        /// <summary>
        /// Singleton instance
        /// </summary>
        private static RestSettings instance = null;

        /// <summary>
        /// Thread sync lock object
        /// </summary>
        private static ReaderWriterLockSlim slim = new ReaderWriterLockSlim();

        /// <summary>
        /// Prevents a default instance of the RestSettings class from being created
        /// </summary>
        private RestSettings()
        {
        }

        /// <summary>
        /// Gets the singleton RestSettings object
        /// </summary>
        public static RestSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    slim.EnterWriteLock();

                    if (instance == null)
                    {
                        instance = new RestSettings();
                    }

                    slim.ExitWriteLock();
                }

                return instance;
            }
        }
        /// <summary>
        /// Gets or sets the REST tracing
        /// </summary>
        public bool RestTracing { get; set; }

        /// <summary>
        /// Gets or sets the integrator key
        /// </summary>
        public string IntegratorKey { get; set; }

        /// <summary>
        /// Gets or sets the distributor code
        /// </summary>
        public string DistributorCode { get; set; }

        /// <summary>
        /// Gets or sets the distributor password
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
        /// Gets or sets the web service url
        /// </summary>
        public string WebServiceUrl { get; set; }

        /// <summary>
        /// Gets or sets the email blurb
        /// </summary>
        public string EmailBlurb { get; set; }

        /// <summary>
        /// Gets or sets the email subject line
        /// </summary>
        public string EmailSubject { get; set; }

        /// <summary>
        /// Gets or sets the DocuSign Address
        /// </summary>
        public string DocuSignAddress { get; set; }
    }
}
