// -----------------------------------------------------------------------
// <copyright file="EnvelopeInfoXmlTextReader.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace DocuSign.Integrations.Client
{
    /// <summary>
    /// XmlTextReader we use
    /// </summary>
    class EnvelopeInfoXmlTextReader : XmlTextReader
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="stream"></param>
        public EnvelopeInfoXmlTextReader(Stream stream) : base(stream) { }

        /// <summary>
        /// Uri for the XML Namespace
        /// </summary>
        public override string NamespaceURI
        {
            get { return ""; }
        }
    }
}
