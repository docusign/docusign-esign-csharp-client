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
    public class SignerEmailNotifications : IEquatable<SignerEmailNotifications>
    {
        
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been activated.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been activated.</value>
        [DataMember(Name="envelopeActivation", EmitDefaultValue=false)]
        public string EnvelopeActivation { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been completed.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been completed.</value>
        [DataMember(Name="envelopeComplete", EmitDefaultValue=false)]
        public string EnvelopeComplete { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notifications of carbon copy deliveries.
        /// </summary>
        /// <value>When set to **true**, the user receives notifications of carbon copy deliveries.</value>
        [DataMember(Name="carbonCopyNotification", EmitDefaultValue=false)]
        public string CarbonCopyNotification { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notifications of certified deliveries.
        /// </summary>
        /// <value>When set to **true**, the user receives notifications of certified deliveries.</value>
        [DataMember(Name="certifiedDeliveryNotification", EmitDefaultValue=false)]
        public string CertifiedDeliveryNotification { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been declined.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been declined.</value>
        [DataMember(Name="envelopeDeclined", EmitDefaultValue=false)]
        public string EnvelopeDeclined { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been voided.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been voided.</value>
        [DataMember(Name="envelopeVoided", EmitDefaultValue=false)]
        public string EnvelopeVoided { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been corrected.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been corrected.</value>
        [DataMember(Name="envelopeCorrected", EmitDefaultValue=false)]
        public string EnvelopeCorrected { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notification that the envelope has been reassigned.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that the envelope has been reassigned.</value>
        [DataMember(Name="reassignedSigner", EmitDefaultValue=false)]
        public string ReassignedSigner { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notification of document purges.
        /// </summary>
        /// <value>When set to **true**, the user receives notification of document purges.</value>
        [DataMember(Name="purgeDocuments", EmitDefaultValue=false)]
        public string PurgeDocuments { get; set; }
  
        
        /// <summary>
        /// Reserved:
        /// </summary>
        /// <value>Reserved:</value>
        [DataMember(Name="faxReceived", EmitDefaultValue=false)]
        public string FaxReceived { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notification that document markup has been activated.
        /// </summary>
        /// <value>When set to **true**, the user receives notification that document markup has been activated.</value>
        [DataMember(Name="documentMarkupActivation", EmitDefaultValue=false)]
        public string DocumentMarkupActivation { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives agent notification emails.
        /// </summary>
        /// <value>When set to **true**, the user receives agent notification emails.</value>
        [DataMember(Name="agentNotification", EmitDefaultValue=false)]
        public string AgentNotification { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the user receives notification if the offline signing failed.
        /// </summary>
        /// <value>When set to **true**, the user receives notification if the offline signing failed.</value>
        [DataMember(Name="offlineSigningFailed", EmitDefaultValue=false)]
        public string OfflineSigningFailed { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignerEmailNotifications {\n");
            sb.Append("  EnvelopeActivation: ").Append(EnvelopeActivation).Append("\n");
            sb.Append("  EnvelopeComplete: ").Append(EnvelopeComplete).Append("\n");
            sb.Append("  CarbonCopyNotification: ").Append(CarbonCopyNotification).Append("\n");
            sb.Append("  CertifiedDeliveryNotification: ").Append(CertifiedDeliveryNotification).Append("\n");
            sb.Append("  EnvelopeDeclined: ").Append(EnvelopeDeclined).Append("\n");
            sb.Append("  EnvelopeVoided: ").Append(EnvelopeVoided).Append("\n");
            sb.Append("  EnvelopeCorrected: ").Append(EnvelopeCorrected).Append("\n");
            sb.Append("  ReassignedSigner: ").Append(ReassignedSigner).Append("\n");
            sb.Append("  PurgeDocuments: ").Append(PurgeDocuments).Append("\n");
            sb.Append("  FaxReceived: ").Append(FaxReceived).Append("\n");
            sb.Append("  DocumentMarkupActivation: ").Append(DocumentMarkupActivation).Append("\n");
            sb.Append("  AgentNotification: ").Append(AgentNotification).Append("\n");
            sb.Append("  OfflineSigningFailed: ").Append(OfflineSigningFailed).Append("\n");
            
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
            return this.Equals(obj as SignerEmailNotifications);
        }

        /// <summary>
        /// Returns true if SignerEmailNotifications instances are equal
        /// </summary>
        /// <param name="other">Instance of SignerEmailNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignerEmailNotifications other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnvelopeActivation == other.EnvelopeActivation ||
                    this.EnvelopeActivation != null &&
                    this.EnvelopeActivation.Equals(other.EnvelopeActivation)
                ) && 
                (
                    this.EnvelopeComplete == other.EnvelopeComplete ||
                    this.EnvelopeComplete != null &&
                    this.EnvelopeComplete.Equals(other.EnvelopeComplete)
                ) && 
                (
                    this.CarbonCopyNotification == other.CarbonCopyNotification ||
                    this.CarbonCopyNotification != null &&
                    this.CarbonCopyNotification.Equals(other.CarbonCopyNotification)
                ) && 
                (
                    this.CertifiedDeliveryNotification == other.CertifiedDeliveryNotification ||
                    this.CertifiedDeliveryNotification != null &&
                    this.CertifiedDeliveryNotification.Equals(other.CertifiedDeliveryNotification)
                ) && 
                (
                    this.EnvelopeDeclined == other.EnvelopeDeclined ||
                    this.EnvelopeDeclined != null &&
                    this.EnvelopeDeclined.Equals(other.EnvelopeDeclined)
                ) && 
                (
                    this.EnvelopeVoided == other.EnvelopeVoided ||
                    this.EnvelopeVoided != null &&
                    this.EnvelopeVoided.Equals(other.EnvelopeVoided)
                ) && 
                (
                    this.EnvelopeCorrected == other.EnvelopeCorrected ||
                    this.EnvelopeCorrected != null &&
                    this.EnvelopeCorrected.Equals(other.EnvelopeCorrected)
                ) && 
                (
                    this.ReassignedSigner == other.ReassignedSigner ||
                    this.ReassignedSigner != null &&
                    this.ReassignedSigner.Equals(other.ReassignedSigner)
                ) && 
                (
                    this.PurgeDocuments == other.PurgeDocuments ||
                    this.PurgeDocuments != null &&
                    this.PurgeDocuments.Equals(other.PurgeDocuments)
                ) && 
                (
                    this.FaxReceived == other.FaxReceived ||
                    this.FaxReceived != null &&
                    this.FaxReceived.Equals(other.FaxReceived)
                ) && 
                (
                    this.DocumentMarkupActivation == other.DocumentMarkupActivation ||
                    this.DocumentMarkupActivation != null &&
                    this.DocumentMarkupActivation.Equals(other.DocumentMarkupActivation)
                ) && 
                (
                    this.AgentNotification == other.AgentNotification ||
                    this.AgentNotification != null &&
                    this.AgentNotification.Equals(other.AgentNotification)
                ) && 
                (
                    this.OfflineSigningFailed == other.OfflineSigningFailed ||
                    this.OfflineSigningFailed != null &&
                    this.OfflineSigningFailed.Equals(other.OfflineSigningFailed)
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
                
                if (this.EnvelopeActivation != null)
                    hash = hash * 57 + this.EnvelopeActivation.GetHashCode();
                
                if (this.EnvelopeComplete != null)
                    hash = hash * 57 + this.EnvelopeComplete.GetHashCode();
                
                if (this.CarbonCopyNotification != null)
                    hash = hash * 57 + this.CarbonCopyNotification.GetHashCode();
                
                if (this.CertifiedDeliveryNotification != null)
                    hash = hash * 57 + this.CertifiedDeliveryNotification.GetHashCode();
                
                if (this.EnvelopeDeclined != null)
                    hash = hash * 57 + this.EnvelopeDeclined.GetHashCode();
                
                if (this.EnvelopeVoided != null)
                    hash = hash * 57 + this.EnvelopeVoided.GetHashCode();
                
                if (this.EnvelopeCorrected != null)
                    hash = hash * 57 + this.EnvelopeCorrected.GetHashCode();
                
                if (this.ReassignedSigner != null)
                    hash = hash * 57 + this.ReassignedSigner.GetHashCode();
                
                if (this.PurgeDocuments != null)
                    hash = hash * 57 + this.PurgeDocuments.GetHashCode();
                
                if (this.FaxReceived != null)
                    hash = hash * 57 + this.FaxReceived.GetHashCode();
                
                if (this.DocumentMarkupActivation != null)
                    hash = hash * 57 + this.DocumentMarkupActivation.GetHashCode();
                
                if (this.AgentNotification != null)
                    hash = hash * 57 + this.AgentNotification.GetHashCode();
                
                if (this.OfflineSigningFailed != null)
                    hash = hash * 57 + this.OfflineSigningFailed.GetHashCode();
                
                return hash;
            }
        }

    }
}
