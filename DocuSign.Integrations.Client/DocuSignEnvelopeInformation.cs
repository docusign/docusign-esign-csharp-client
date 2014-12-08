// -----------------------------------------------------------------------
// <copyright file="DocuSignEnvelopeInformation.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DocuSign.Integrations.Client
{
    [Serializable]
    [XmlRoot]
    public class DocuSignEnvelopeInformation
    {
        [XmlElement(ElementName = "EnvelopeStatus", Type = typeof(EnvelopeStatus))]
        public EnvelopeStatus EnvStatus { get; set; }

        public static EnvelopeStatus DeserializeEnvelopeStatusFromRequest(Stream requestBody)
        {
            // Find number of bytes in stream.
            int streamLen = Convert.ToInt32(requestBody.Length);

            string requestContents = "(Empty)";

            if (streamLen != 0)
            {
                // Create a byte array.
                byte[] streamArr = new byte[streamLen];

                // Read stream into byte array.
                int streamRead = requestBody.Read(streamArr, 0, streamLen);

                requestContents = ASCIIEncoding.ASCII.GetString(streamArr);
            }

            DocuSignEnvelopeInformation deserializedObject = null;

            var serializer = new XmlSerializer(typeof(DocuSignEnvelopeInformation));

            requestBody.Position = 0;
            var xmlTextReader = new EnvelopeInfoXmlTextReader(requestBody);

            deserializedObject = (DocuSignEnvelopeInformation)serializer.Deserialize(xmlTextReader);

            return deserializedObject.EnvStatus;
        }

    }
}
