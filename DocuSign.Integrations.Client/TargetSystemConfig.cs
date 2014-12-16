// -----------------------------------------------------------------------
// <copyright file="TargetSystemConfig.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Web;
    using System.Xml;
    using System.Xml.XPath;
    using System.IO;

    /// <summary>
    /// Singleton class. Reads the custom configuration settings for the target system (test, demo, production, etc.)
    /// and builds a TargetSystem object from them.
    /// </summary>
    public class TargetSystemConfig 
    {
        /// <summary>
        /// Xml document
        /// </summary>
        private XmlDocument document = new XmlDocument();

        /// <summary>
        /// Gets the TargetSystem object
        /// </summary>
        public TargetSystem TargetSystem { get; private set; }

        /// <summary>
        /// Creates a new instance of the TargetSystemConfig class
        /// </summary>
        public TargetSystemConfig()
        {
            this.TargetSystem = new TargetSystem();
            Init();
        }

        /// <summary>
        /// Initializes the TargetSystem object from the custom configuration section
        /// </summary>
        private void Init()
        {
            string file = this.ConfigFilePath();
            
            if (string.IsNullOrEmpty(file) == true)
            {
                return;
            }
            
            document.Load(file);

            XPathNavigator nav = document.CreateNavigator();

            bool rc = NavigateConfig(nav);
        }

        private string ConfigFilePath()
        {
            try
            {
                if (File.Exists(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) == true)
                {
                    return AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
                }
            }
            catch (Exception e)
            {
            }

            return string.Empty;
        }

        /// <summary>
        /// Reads the configuration section
        /// </summary>
        /// <param name="nav">Root navigator</param>
        /// <returns>true if successful, false otherwise</returns>
        private bool NavigateConfig(XPathNavigator nav)
        {
            bool rc = true;

            foreach (XPathNavigator sec in nav.Select("configuration/configSections/section"))
            {
                string name = sec.GetAttribute("name", "");
                string type = sec.GetAttribute("type", "");

                if (type.Contains("DocuSignClient.TargetSystem"))
                {
                    return NavigateVariables(sec, name);
                }
            }

            return rc;
        }

        /// <summary>
        /// Finds the named custom config section and reads the variables
        /// </summary>
        /// <param name="section">Name of the custom config section</param>
        /// <param name="name">navigation section</param>
        /// <returns></returns>
        private bool NavigateVariables(XPathNavigator section, string name)
        {
            bool rc = false;
            section.MoveToRoot();

            XPathNavigator cfgSec = section.SelectSingleNode(string.Format("configuration/{0}", name));

            if (cfgSec != null)
            {
                string useversion = cfgSec.GetAttribute("useSystem", "");

                XPathNavigator target = cfgSec.SelectSingleNode(useversion);

                if (target != null)
                {
                    XPathNavigator ik = target.SelectSingleNode("IntegratorKey");
                    
                    if (ik != null)
                    {
                        this.TargetSystem.IntegratorKey = ik.Value;
                    }

                    XPathNavigator ws = target.SelectSingleNode("WebServiceUrl");

                    if (ws != null)
                    {
                        this.TargetSystem.WebServiceUrl = ws.Value;
                    }

                    XPathNavigator dc = target.SelectSingleNode("DistributorCode");

                    if (dc != null)
                    {
                        this.TargetSystem.DistributorCode = dc.Value;
                    }

                    XPathNavigator dp = target.SelectSingleNode("DistributorPassword");

                    if (dp != null)
                    {
                        this.TargetSystem.DistributorPassword = dp.Value;
                    }

                    XPathNavigator pi = target.SelectSingleNode("PlanId");

                    if (pi != null)
                    {
                        this.TargetSystem.PlanId = pi.Value;
                    }
                    XPathNavigator fs = target.SelectSingleNode("FeatureSetId");

                    if (fs != null)
                    {
                        this.TargetSystem.FeatureSetId = fs.Value;
                    }

                    XPathNavigator eb = target.SelectSingleNode("EmailBlurb");

                    if (eb != null)
                    {
                        this.TargetSystem.EmailBlurb = eb.Value;
                    }

                    XPathNavigator es = target.SelectSingleNode("EmailSubject");

                    if (es != null)
                    {
                        this.TargetSystem.EmailSubject = es.Value;
                    }

                    rc = true;
                }
            }

            return rc;
        }
    }
}