using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class EventNotification : IEquatable<EventNotification>
    {
        
        /// <summary>
        /// The endpoint where envelope updates are sent. This will accept XML unless �useSoapInterface� is set to true.
        /// </summary>
        /// <value>The endpoint where envelope updates are sent. This will accept XML unless �useSoapInterface� is set to true.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
  
        
        /// <summary>
        /// When set to **true**, logging is turned on for envelope events on the Web Console Connect page.
        /// </summary>
        /// <value>When set to **true**, logging is turned on for envelope events on the Web Console Connect page.</value>
        [DataMember(Name="loggingEnabled", EmitDefaultValue=false)]
        public string LoggingEnabled { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the DocuSign Connect service checks that the message was received and retries on failures.
        /// </summary>
        /// <value>When set to **true**, the DocuSign Connect service checks that the message was received and retries on failures.</value>
        [DataMember(Name="requireAcknowledgment", EmitDefaultValue=false)]
        public string RequireAcknowledgment { get; set; }
  
        
        /// <summary>
        /// The list of envelope-level events statuses that will trigger Connect to send updates to the url.
        /// </summary>
        /// <value>The list of envelope-level events statuses that will trigger Connect to send updates to the url.</value>
        [DataMember(Name="envelopeEvents", EmitDefaultValue=false)]
        public List<EnvelopeEvent> EnvelopeEvents { get; set; }
  
        
        /// <summary>
        /// The list of recipient event statuses that will trigger Connect to send updates to the url.
        /// </summary>
        /// <value>The list of recipient event statuses that will trigger Connect to send updates to the url.</value>
        [DataMember(Name="recipientEvents", EmitDefaultValue=false)]
        public List<RecipientEvent> RecipientEvents { get; set; }
  
        
        /// <summary>
        /// When set to **true**, this tells the Connect service that the user�s endpoint has implemented a SOAP interface.
        /// </summary>
        /// <value>When set to **true**, this tells the Connect service that the user�s endpoint has implemented a SOAP interface.</value>
        [DataMember(Name="useSoapInterface", EmitDefaultValue=false)]
        public string UseSoapInterface { get; set; }
  
        
        /// <summary>
        /// This lists the namespace in the SOAP listener provided.
        /// </summary>
        /// <value>This lists the namespace in the SOAP listener provided.</value>
        [DataMember(Name="soapNameSpace", EmitDefaultValue=false)]
        public string SoapNameSpace { get; set; }
  
        
        /// <summary>
        /// When set to **true**, this tells the Connect service to send the DocuSign signedby certificate as part of the outgoing SOAP xml. This appears in the XML as wsse:BinarySecurityToken.
        /// </summary>
        /// <value>When set to **true**, this tells the Connect service to send the DocuSign signedby certificate as part of the outgoing SOAP xml. This appears in the XML as wsse:BinarySecurityToken.</value>
        [DataMember(Name="includeCertificateWithSoap", EmitDefaultValue=false)]
        public string IncludeCertificateWithSoap { get; set; }
  
        
        /// <summary>
        /// When set to **true**, messages are signed with an X509 certificate. This provides support for 2-way SSL in the envelope.
        /// </summary>
        /// <value>When set to **true**, messages are signed with an X509 certificate. This provides support for 2-way SSL in the envelope.</value>
        [DataMember(Name="signMessageWithX509Cert", EmitDefaultValue=false)]
        public string SignMessageWithX509Cert { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the PDF documents are included in the message along with the updated XML.
        /// </summary>
        /// <value>When set to **true**, the PDF documents are included in the message along with the updated XML.</value>
        [DataMember(Name="includeDocuments", EmitDefaultValue=false)]
        public string IncludeDocuments { get; set; }
  
        
        /// <summary>
        /// When set to **true**, this tells the Connect Service to include the void reason, as entered by the person that voided the envelope, in the message.
        /// </summary>
        /// <value>When set to **true**, this tells the Connect Service to include the void reason, as entered by the person that voided the envelope, in the message.</value>
        [DataMember(Name="includeEnvelopeVoidReason", EmitDefaultValue=false)]
        public string IncludeEnvelopeVoidReason { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the envelope time zone information is included in the message.
        /// </summary>
        /// <value>When set to **true**, the envelope time zone information is included in the message.</value>
        [DataMember(Name="includeTimeZone", EmitDefaultValue=false)]
        public string IncludeTimeZone { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the sender account ID is included as a envelope custom field in the data.
        /// </summary>
        /// <value>When set to **true**, the sender account ID is included as a envelope custom field in the data.</value>
        [DataMember(Name="includeSenderAccountAsCustomField", EmitDefaultValue=false)]
        public string IncludeSenderAccountAsCustomField { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the Document Fields associated with envelope documents are included in the data. Document Fields are optional custom name-value pairs added to documents using the API
        /// </summary>
        /// <value>When set to **true**, the Document Fields associated with envelope documents are included in the data. Document Fields are optional custom name-value pairs added to documents using the API</value>
        [DataMember(Name="includeDocumentFields", EmitDefaultValue=false)]
        public string IncludeDocumentFields { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the Connect Service includes the Certificate of Completion with completed envelopes.
        /// </summary>
        /// <value>When set to **true**, the Connect Service includes the Certificate of Completion with completed envelopes.</value>
        [DataMember(Name="includeCertificateOfCompletion", EmitDefaultValue=false)]
        public string IncludeCertificateOfCompletion { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventNotification {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  LoggingEnabled: ").Append(LoggingEnabled).Append("\n");
            sb.Append("  RequireAcknowledgment: ").Append(RequireAcknowledgment).Append("\n");
            sb.Append("  EnvelopeEvents: ").Append(EnvelopeEvents).Append("\n");
            sb.Append("  RecipientEvents: ").Append(RecipientEvents).Append("\n");
            sb.Append("  UseSoapInterface: ").Append(UseSoapInterface).Append("\n");
            sb.Append("  SoapNameSpace: ").Append(SoapNameSpace).Append("\n");
            sb.Append("  IncludeCertificateWithSoap: ").Append(IncludeCertificateWithSoap).Append("\n");
            sb.Append("  SignMessageWithX509Cert: ").Append(SignMessageWithX509Cert).Append("\n");
            sb.Append("  IncludeDocuments: ").Append(IncludeDocuments).Append("\n");
            sb.Append("  IncludeEnvelopeVoidReason: ").Append(IncludeEnvelopeVoidReason).Append("\n");
            sb.Append("  IncludeTimeZone: ").Append(IncludeTimeZone).Append("\n");
            sb.Append("  IncludeSenderAccountAsCustomField: ").Append(IncludeSenderAccountAsCustomField).Append("\n");
            sb.Append("  IncludeDocumentFields: ").Append(IncludeDocumentFields).Append("\n");
            sb.Append("  IncludeCertificateOfCompletion: ").Append(IncludeCertificateOfCompletion).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EventNotification);
        }

        /// <summary>
        /// Returns true if EventNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of EventNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.LoggingEnabled == other.LoggingEnabled ||
                    this.LoggingEnabled != null &&
                    this.LoggingEnabled.Equals(other.LoggingEnabled)
                ) && 
                (
                    this.RequireAcknowledgment == other.RequireAcknowledgment ||
                    this.RequireAcknowledgment != null &&
                    this.RequireAcknowledgment.Equals(other.RequireAcknowledgment)
                ) && 
                (
                    this.EnvelopeEvents == other.EnvelopeEvents ||
                    this.EnvelopeEvents != null &&
                    this.EnvelopeEvents.SequenceEqual(other.EnvelopeEvents)
                ) && 
                (
                    this.RecipientEvents == other.RecipientEvents ||
                    this.RecipientEvents != null &&
                    this.RecipientEvents.SequenceEqual(other.RecipientEvents)
                ) && 
                (
                    this.UseSoapInterface == other.UseSoapInterface ||
                    this.UseSoapInterface != null &&
                    this.UseSoapInterface.Equals(other.UseSoapInterface)
                ) && 
                (
                    this.SoapNameSpace == other.SoapNameSpace ||
                    this.SoapNameSpace != null &&
                    this.SoapNameSpace.Equals(other.SoapNameSpace)
                ) && 
                (
                    this.IncludeCertificateWithSoap == other.IncludeCertificateWithSoap ||
                    this.IncludeCertificateWithSoap != null &&
                    this.IncludeCertificateWithSoap.Equals(other.IncludeCertificateWithSoap)
                ) && 
                (
                    this.SignMessageWithX509Cert == other.SignMessageWithX509Cert ||
                    this.SignMessageWithX509Cert != null &&
                    this.SignMessageWithX509Cert.Equals(other.SignMessageWithX509Cert)
                ) && 
                (
                    this.IncludeDocuments == other.IncludeDocuments ||
                    this.IncludeDocuments != null &&
                    this.IncludeDocuments.Equals(other.IncludeDocuments)
                ) && 
                (
                    this.IncludeEnvelopeVoidReason == other.IncludeEnvelopeVoidReason ||
                    this.IncludeEnvelopeVoidReason != null &&
                    this.IncludeEnvelopeVoidReason.Equals(other.IncludeEnvelopeVoidReason)
                ) && 
                (
                    this.IncludeTimeZone == other.IncludeTimeZone ||
                    this.IncludeTimeZone != null &&
                    this.IncludeTimeZone.Equals(other.IncludeTimeZone)
                ) && 
                (
                    this.IncludeSenderAccountAsCustomField == other.IncludeSenderAccountAsCustomField ||
                    this.IncludeSenderAccountAsCustomField != null &&
                    this.IncludeSenderAccountAsCustomField.Equals(other.IncludeSenderAccountAsCustomField)
                ) && 
                (
                    this.IncludeDocumentFields == other.IncludeDocumentFields ||
                    this.IncludeDocumentFields != null &&
                    this.IncludeDocumentFields.Equals(other.IncludeDocumentFields)
                ) && 
                (
                    this.IncludeCertificateOfCompletion == other.IncludeCertificateOfCompletion ||
                    this.IncludeCertificateOfCompletion != null &&
                    this.IncludeCertificateOfCompletion.Equals(other.IncludeCertificateOfCompletion)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Url != null)
                    hash = hash * 57 + this.Url.GetHashCode();
                
                if (this.LoggingEnabled != null)
                    hash = hash * 57 + this.LoggingEnabled.GetHashCode();
                
                if (this.RequireAcknowledgment != null)
                    hash = hash * 57 + this.RequireAcknowledgment.GetHashCode();
                
                if (this.EnvelopeEvents != null)
                    hash = hash * 57 + this.EnvelopeEvents.GetHashCode();
                
                if (this.RecipientEvents != null)
                    hash = hash * 57 + this.RecipientEvents.GetHashCode();
                
                if (this.UseSoapInterface != null)
                    hash = hash * 57 + this.UseSoapInterface.GetHashCode();
                
                if (this.SoapNameSpace != null)
                    hash = hash * 57 + this.SoapNameSpace.GetHashCode();
                
                if (this.IncludeCertificateWithSoap != null)
                    hash = hash * 57 + this.IncludeCertificateWithSoap.GetHashCode();
                
                if (this.SignMessageWithX509Cert != null)
                    hash = hash * 57 + this.SignMessageWithX509Cert.GetHashCode();
                
                if (this.IncludeDocuments != null)
                    hash = hash * 57 + this.IncludeDocuments.GetHashCode();
                
                if (this.IncludeEnvelopeVoidReason != null)
                    hash = hash * 57 + this.IncludeEnvelopeVoidReason.GetHashCode();
                
                if (this.IncludeTimeZone != null)
                    hash = hash * 57 + this.IncludeTimeZone.GetHashCode();
                
                if (this.IncludeSenderAccountAsCustomField != null)
                    hash = hash * 57 + this.IncludeSenderAccountAsCustomField.GetHashCode();
                
                if (this.IncludeDocumentFields != null)
                    hash = hash * 57 + this.IncludeDocumentFields.GetHashCode();
                
                if (this.IncludeCertificateOfCompletion != null)
                    hash = hash * 57 + this.IncludeCertificateOfCompletion.GetHashCode();
                
                return hash;
            }
        }

    }
}
