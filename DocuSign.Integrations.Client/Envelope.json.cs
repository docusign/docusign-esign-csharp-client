// -----------------------------------------------------------------------
// <copyright file="Envelope.json.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Json class for envelopes
    /// </summary>
    [Serializable]
    public class EnvelopeCreate
    {
        /// <summary>
        /// Initializes a new instance of the EnvelopeCreate class
        /// </summary>
        public EnvelopeCreate() 
        { 
        }

        /// <summary>
        /// Gets or sets the transaction id property
        /// </summary>
        public string transactionId { get; set; }

        /// <summary>
        /// Gets or sets the asynchronous property
        /// </summary>
        public string asynchronous { get; set; }

        /// <summary>
        /// Gets or sets the signing location property
        /// </summary>
        public string signingLocation { get; set; }

        /// <summary>
        /// Gets or sets the auto navigation property
        /// </summary>
        public string autoNavigation { get; set; }

        /// <summary>
        /// Gets or sets the envelope id stamping property
        /// </summary>
        public string envelopeIdStamping { get; set; }

        /// <summary>
        /// Gets or sets the authoritative copy property
        /// </summary>
        public string authoritativeCopy { get; set; }

        /// <summary>
        /// Gets or sets the enforce signer visibility property
        /// </summary>
        public string enforceSignerVisibility { get; set; }

        /// <summary>
        /// Gets or sets the enable wet sign property
        /// </summary>
        public string enableWetSign { get; set; }

        /// <summary>
        /// Gets or sets the allow markup property
        /// </summary>
        public string allowMarkup { get; set; }

        /// <summary>
        /// Gets or sets the allow reassign property
        /// </summary>
        public string allowReassign { get; set; }

        /// <summary>
        /// Gets or sets the event notification property
        /// </summary>
        public eventNotification eventNotification { get; set; }

        /// <summary>
        /// Gets or sets the email blurb property
        /// </summary>
        public string emailBlurb { get; set; }

        /// <summary>
        /// Gets or sets the email subject property
        /// </summary>
        public string emailSubject { get; set; }

        public Recipients recipients { get; set; }

        public CustomFields customFields { get; set; }

        /// <summary>
        /// Gets or sets the Document property
        /// </summary>
        public Document[] documents { get; set; }
        
        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>EnvelopeCreate instance</returns>
        public static EnvelopeCreate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnvelopeCreate>(json);
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

    [Serializable]
    public class Recipients
    {
        public Signer[] signers { get; set; }
    }

    [Serializable]
    public class Signer
    {
        public string email{ get; set; }
        public string name{ get; set; }
        public string recipientId { get; set; }
        public string routingOrder { get; set; }
    }

    /// <summary>
    /// Json class for documents
    /// </summary>
    [Serializable]
    public class CustomFields
    {
        public TextCustomField[] textCustomFields { get; set; }
    }

    /// <summary>
    /// Json class for documents
    /// </summary>
    [Serializable]
    public class TextCustomField
    {
        /// <summary>
        /// Initializes a new instance of the CustomField class
        /// </summary>
        public TextCustomField()
        {
        }

        /// <summary>
        /// Gets or sets the document id property
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the document name property
        /// </summary>
        public string show { get; set; }

        /// <summary>
        /// Gets or sets the uri property
        /// </summary>
        public string required { get; set; }

        /// <summary>
        /// Gets or sets the password property
        /// </summary>
        public string value { get; set; }
    }

    /// <summary>
    /// Json class for documents
    /// </summary>
    [Serializable]
    public class Document
    {
        /// <summary>
        /// Initializes a new instance of the Document class
        /// </summary>
        public Document()
        {
        }

        /// <summary>
        /// Gets or sets the document id property
        /// </summary>
        public string documentId { get; set; }

        /// <summary>
        /// Gets or sets the document name property
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the uri property
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Gets or sets the password property
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Gets or sets the transform pdf fields property
        /// </summary>
        public string transformPdfFields { get; set; }

        /// <summary>
        /// Gets or sets the file extension property
        /// </summary>
        public string fileExtension { get; set; }

        /// <summary>
        /// Gets or sets the attachment description property
        /// </summary>
        public string attachmentDescription { get; set; }
    }

    /// <summary>
    /// Json class for documents
    /// </summary>
    [Serializable]
    public class SenderView
    {
        /// <summary>
        /// Initializes a new instance of the SenderView class
        /// </summary>
        public SenderView() 
        { 
        }

        /// <summary>
        /// Gets or sets the return url property
        /// </summary>
        public string returnUrl { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>EnvelopeCreate instance</returns>
        public static SenderView FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SenderView>(json);
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

    /// <summary>
    /// Event notification class
    /// </summary>
    [Serializable]
    public class eventNotification
    {
        /// <summary>
        /// Gets or sets the url property
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the logging is enabled 
        /// </summary>
        public string loggingEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether event requires acknowledgment
        /// </summary>
        public string requireAcknowledgment { get; set; }

        public string useSoapInterface { get; set; }

        public string soapNameSpace { get; set; }

        public string includeCertificateWithSoap { get; set; }

        /// <summary>
        /// Gets or sets the envelope events property
        /// </summary>
        public EnvelopeEvent[] EnvelopeEvents { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>EnvelopeCreate instance</returns>
        public static eventNotification FromJson(string json)
        {
            return JsonConvert.DeserializeObject<eventNotification>(json);
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

    /// <summary>
    /// Envelope event class
    /// </summary>
    [Serializable]
    public class EnvelopeEvent
    {
        /// <summary>
        /// Gets or sets the envelope event status code property
        /// </summary>
        public string envelopeEventStatusCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include documents
        /// </summary>
        public string includeDocuments { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>EnvelopeCreate instance</returns>
        public static EnvelopeEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnvelopeEvent>(json);
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
