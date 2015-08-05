// -----------------------------------------------------------------------
// <copyright file="Envelope.json.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using DocuSignClient;

namespace DocuSign.Integrations.Client
{
    using System;
    using Newtonsoft.Json;

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

        public string status { get; set; }

        public string templateId { get; set; }

        public Recipients recipients { get; set; }

        public CompositeTemplate[] compositeTemplates { get; set; }

        public TemplateRole[] templateRoles { get; set; }

        public Recipients carbonCopies { get; set; }

        public CustomFields customFields { get; set; }

        public Notification notification { get; set; }

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
        /// <summary>
        /// List of contact that needs to sign this envelope
        /// </summary>
        public Signer[] signers { get; set; }
        /// <summary>
        /// List of contacts that gets an email when this envelope is signed
        /// </summary>
        public Signer[] carbonCopies { get; set; }

        /// <summary>
        /// List of contacts that gets to view the email to complete the action
        /// </summary>
        public Signer[] certifiedDeliveries { get; set; }

        /// <summary>
        /// List of contacts that gets to address receipts
        /// </summary>
        public Signer[] agents { get; set; }

        /// <summary>
        /// List of contacts that gets to manage receipts
        /// </summary>
        public Signer[] intermediaries { get; set; }

        /// <summary>
        /// List of contacts that gets to manage envelope
        /// </summary>
        public Signer[] editors { get; set; }

        /// <summary>
        /// List of contacts who will sign in-person
        /// </summary>
        public Signer[] inPersonSigners { get; set; }

        /// <summary>
        /// Number of total contacts on the envelope
        /// </summary>
        public string recipientCount { get; set; }

        /// <summary>
        /// Ordinal value of where the envelope currently is in signing order
        /// </summary>
        public string currentRoutingOrder { get; set; }
    }

    [Serializable]
    public class Signer
    {
        /// <summary>
        /// The signer's email address
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// The signer's name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The signer's recipient unique identifier
        /// </summary>
        public string recipientId { get; set; }
        /// <summary>
        /// The signer's recipient unique identifier in Globally Unique Identifier format
        /// </summary>
        public string recipientIdGuid { get; set; }
        /// <summary>
        /// Recipient's DocuSign user Id
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// Controls whether or not the recipient requires an RSA Id check
        /// </summary>
        public string requireIdLookup { get; set; }
        /// <summary>
        /// The signer's routing order
        /// </summary>
        public string routingOrder { get; set; }
        /// <summary>
        /// The signer's role name
        /// </summary>
        public string roleName { get; set; }
        /// <summary>
        /// The signer's client user unique identifier (For embedded signing)
        /// </summary>
        public string clientUserId { get; set; }
        /// <summary>
        /// The signer's client user unique identifier (For embedded signing)
        /// </summary>
        public string idCheckConfigurationName { get; set; }
        /// <summary>
        /// This complex element contains information related to recipient ID check.
        /// </summary>
        public CheckInformationInput idCheckInformationInput {get; set;}
        /// <summary>
        /// RecipientPhone Authentication
        /// </summary>
        public PhoneAuthentication phoneAuthentication { get; set; }
        /// <summary>
        /// RecipientSMS Authentication
        /// </summary>
        public SmsAuthentication smsAuthentication { get; set; }
        /// <summary>
        /// Collection of tab information that is included when the recipients request URL contains the query value "include_tabs=true"
        /// </summary>
        public Tabs tabs { get; set; }
        /// <summary>
        /// Has the recipient been added as a bulk recipient
        /// </summary>
        public string isBulkRecipient { get; set; }
        /// <summary>
        /// Currently envelope status with respect to the recipient
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// An optional complex type that has information for setting the language for the recipient’s email information
        /// WARNING! If this is enabled for one recipient, it overrides the Envelope Subject and EmailBlurb. Also, you must enable emailNotification for all recipients.
        /// </summary>
        public EmailNotification emailNotification { get; set; }
        /// <summary>
        /// An optional array of strings that allows the sender to provide custom data about the recipient. 
        /// This information is returned in the envelope status but otherwise not used by DocuSign. 
        /// Each customField string can be a maximum of 100 characters.
        /// </summary>
        public string[] customFields { get; set; }
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
    /// Json class for getting recipient view
    /// </summary>
    [Serializable]
    public class RecipientView
    {
        /// <summary>
        /// Initializes a new instance of the RecipientView class
        /// </summary>
        public RecipientView()
        {
        }

        /// <summary>
        /// URL to take the user after they finish signing
        /// </summary>
        public string returnUrl { get; set; }
        /// <summary>
        /// Name of the recipient
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// Email of the recipient
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Client User Unique Identifier (For Embedded signing)
        /// </summary>
        public string clientUserId { get; set; }
        /// <summary>
        /// Method for authentication
        /// </summary>
        public string authenticationMethod { get; set; }

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

        /// <summary>
        /// When set to true, messages are signed with an X509 certificate. This provides support for 2-way SSL in the envelope.
        /// </summary>
        public string signMessageWithX509Cert { get; set; }

        public string soapNameSpace { get; set; }

        public string includeCertificateWithSoap { get; set; }

        /// <summary>
        /// Gets or sets the envelope events property
        /// </summary>
        public EnvelopeEvent[] EnvelopeEvents { get; set; }

        /// <summary>
        /// Gets or sets the recipient events property
        /// </summary>
        public RecipientEvent[] RecipientEvents { get; set; }

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

    /// <summary>
    /// Recipient event class
    /// </summary>
    [Serializable]
    public class RecipientEvent
    {
        /// <summary>
        /// Gets or sets the recipient event status code property
        /// </summary>
        public string recipientEventStatusCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include documents
        /// </summary>
        public string includeDocuments { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>RecipientEvent instance</returns>
        public static RecipientEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<RecipientEvent>(json);
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
    public class EnvelopeDocuments
    {
        public string envelopeId { get; set; }
        public EnvelopeDocument[] envelopeDocuments { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>EnvelopeCreate instance</returns>
        public static EnvelopeDocuments FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnvelopeDocuments>(json);
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
    public class EnvelopeDocument
    {
        public string documentId { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public string order { get; set; }
        public string pages { get; set; }

    }

    [Serializable]
    public class AccountEnvelopes
    {

        public string ResultSetSize { get; set; }
        public string TotalSetSize { get; set; }
        public string StartPosition { get; set; }
        public string EndPosition { get; set; }
        public string NextUri { get; set; }
        public string PreviousUri { get; set; }
        public EnvelopeInfo[] Envelopes { get; set; }

        //Empty Constructor
        public AccountEnvelopes() { }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
        public static AccountEnvelopes FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AccountEnvelopes>(json);
        }
    }


    [Serializable]
    public class EnvelopeInfo
    {

        public string Status { get; set; }
        public string DocumentsUri { get; set; }
        public string RecipientsUri { get; set; }
        public string EnvelopeUri { get; set; }
        public string EnvelopeId { get; set; }
        public string CustomFieldsUri { get; set; }
        public string NotificationUri { get; set; }
        public string StatusChangedDateTime { get; set; }
        public string DocumentsCombinedUri { get; set; }
        public string CertificateUri { get; set; }
        public string TemplatesUri { get; set; }

        //Empty Constructor
        public EnvelopeInfo() { }


    }

    /// <summary>
    /// Used to provide template information for envelope creation
    /// </summary>
    [Serializable]
    public class TemplateRole
    {
        /// <summary>
        /// Recipient email's address
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Recipient's name
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Recipient's role
        /// </summary>
        public string roleName { get; set; }
        /// <summary>
        /// Recipient's routing order
        /// </summary>
        public string routingOrder { get; set; }
        /// <summary>
        /// Is this a default recipient
        /// </summary>
        public string defaultRecipient { get; set; }
        /// <summary>
        /// The signer's client user unique identifier (For embedded signing)
        /// </summary>
        public string clientUserId { get; set; }
        /// <summary>
        /// The signer's tabs
        /// </summary>
        public RoleTabs tabs { get; set; }
    }

    /// <summary>
    /// RoleTabs
    /// </summary>
    [Serializable]
    public class RoleTabs
    {
        //public RoleTab[] signHereTabs { get; set; }
        //public RoleTab[] initialHereTabs { get; set; }
        //public RoleTab[] fullNameTabs { get; set; }
        //public RoleTab[] emailTabs { get; set; }
        public RoleTextTab[] textTabs { get; set; }
        //public RoleTab[] titleTabs { get; set; }
        //public RoleTab[] companyTabs { get; set; }
        //public RoleTab[] dateSignedTabs { get; set; }
        public CheckboxTab[] checkboxTabs { get; set; }
        //public RoleTab[] signerAttachmentTabs { get; set; }
        public TemplateRadioGroupTab[] radioGroupTabs { get; set; }
        public NumberTab[] numberTabs { get; set; }
    }

    /// <summary>
    /// RoleTab
    /// </summary>
    [Serializable]
    public class RoleTab
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    /// <summary>
    /// RoleTextTab
    /// </summary>
    [Serializable]
    public class RoleTextTab
    {
        public string tabLabel { get; set; }
        public string value { get; set; }
    }

    /// <summary>
    /// CheckboxTab
    /// </summary>
    [Serializable]
    public class CheckboxTab
    {
        public string tabLabel { get; set; }
        public bool selected { get; set; }
    }

    /// <summary>
    /// RadioGroupTab
    /// </summary>
    [Serializable]
    public class TemplateRadioGroupTab
    {
        public string groupName { get; set; }
        public radio[] radios { get; set; }
    }

    [Serializable]
    public class radio
    {
        public string value { get; set; }
        public bool selected { get; set; }
    }

    /// <summary>
    /// NumberTab
    /// </summary>
    [Serializable]
    public class NumberTab
    {
        public string tabLabel { get; set; }
        public string value { get; set; }
    }
    
    /// <summary>
    /// Used for submitting for RESTAPI
    /// </summary>
    [Serializable]
    public class Tabs
    {
        public Tab[] signHereTabs { get; set; }
        public Tab[] initialHereTabs { get; set; }
        public Tab[] fullNameTabs { get; set; }
        public Tab[] emailTabs { get; set; }
        public TextTab[] textTabs { get; set; }
        public Tab[] titleTabs { get; set; }
        public Tab[] companyTabs { get; set; }
        public DateSignedTab[] dateSignedTabs { get; set; }
        public Tab[] checkboxTabs { get; set; }
        public Tab[] signerAttachmentTabs { get; set; }
        public RadioGroupTab[] radioGroupTabs { get; set; }
    }
    /// <summary>
    /// This complex element contains information related to recipient ID check.
    /// </summary>
    [Serializable]
    public class CheckInformationInput
    {
        /// <summary>
        /// This Complex type contains the following information; Street1, Street2, City, State and Zip and ZipPlus4
        /// </summary>
        public AddressInformationInput addressInformationInput { get; set; }
    }
    /// <summary>
    /// This Complex type contains the following information; Street1, Street2, City, State and Zip and ZipPlus4
    /// </summary>
    [Serializable]
    public class AddressInformationInput
    {
        public AddressInformation addressInformation { get; set; }
    }
    /// <summary>
    /// RecipientPhone Authentication
    /// </summary>
    [Serializable]
    public class PhoneAuthentication
    {
        /// <summary>
        /// if true then recipient can use whatever phone number they want
        /// </summary>
        public string recipMayProvideNumber { get; set; }
        /// <summary>
        /// a list of phone numbers the recipient may use
        /// </summary>
        public string[] senderProvidedNumbers { get; set; }
    }
    /// <summary>
    /// RecipientSMS Authentication
    /// </summary>
    [Serializable]
    public class SmsAuthentication
    {
        /// a list of phone numbers the recipient may use
        /// </summary>
        public string[] senderProvidedNumbers { get; set; }
    }
    /// <summary>
    /// Envelope Template class
    /// </summary>
    [Serializable]
    public class EnvelopeTemplates
    {
        public EnvelopeTemplate[] templates { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>EnvelopeCreate instance</returns>
        public static EnvelopeTemplates FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnvelopeTemplates>(json);
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
    public class EnvelopeTemplate
    {
        public string templateId { get; set; }
        public string documentId { get; set; }
        public string name { get; set; }
        public bool applied { get; set; }
        public string uri { get; set; }
        public TemplateMatch templateMatch { get; set; }
    }

    /// <summary>
    /// Envelope event class
    /// </summary>
    [Serializable]
    public class TemplateMatch
    {
        public string matchPercentage { get; set; }
        public string documentStartPage { get; set; }
        public string documentEndPage { get; set; }
    }

    /// <summary>
    /// Document Template Class used for Applying Template to existing envelope
    /// </summary>
    [Serializable]
    public class DocumentTemplates
    {
        public DocumentTemplate[] documentTemplates { get; set; }
    }

    /// <summary>
    /// Individual Envelope Template class used for Applying Template to existing envelope
    /// </summary>
    [Serializable]
    public class DocumentTemplate
    {
        public string templateId { get; set; }
        public string documentId { get; set; }
        public string documentStartPage { get; set; }
        public string documentEndPage { get; set; }
    }

    [Serializable]
    public class ServerTemplate
    {
        public string templateId { get; set; }
        public string sequence { get; set; }
    }

    [Serializable]
    public class CompositeTemplate
    {
        public string compositeTemplateId { get; set; }
        public ServerTemplate[] serverTemplates { get; set; }
    }
}
