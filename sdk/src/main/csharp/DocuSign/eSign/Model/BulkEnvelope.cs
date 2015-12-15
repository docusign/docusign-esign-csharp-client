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
    public class BulkEnvelope : IEquatable<BulkEnvelope>
    {
        
        /// <summary>
        /// Used to identify an envelope. The id is a sender-generated value and is valid in the DocuSign system for 7 days. It is recommended that a transaction ID is used for offline signing to ensure that an envelope is not sent multiple times. The `transactionId` property can be used determine if an envelope status (i.e. was created or not) for cases where an internet connection was lost before the envelope status could be returned.
        /// </summary>
        /// <value>Used to identify an envelope. The id is a sender-generated value and is valid in the DocuSign system for 7 days. It is recommended that a transaction ID is used for offline signing to ensure that an envelope is not sent multiple times. The `transactionId` property can be used determine if an envelope status (i.e. was created or not) for cases where an internet connection was lost before the envelope status could be returned.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="submittedDateTime", EmitDefaultValue=false)]
        public string SubmittedDateTime { get; set; }
  
        
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
  
        
        /// <summary>
        /// Contains a URI for an endpoint that you can use to retrieve the envelope or envelopes.
        /// </summary>
        /// <value>Contains a URI for an endpoint that you can use to retrieve the envelope or envelopes.</value>
        [DataMember(Name="envelopeUri", EmitDefaultValue=false)]
        public string EnvelopeUri { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="bulkRecipientRow", EmitDefaultValue=false)]
        public string BulkRecipientRow { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="bulkStatus", EmitDefaultValue=false)]
        public string BulkStatus { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkEnvelope {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  SubmittedDateTime: ").Append(SubmittedDateTime).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  EnvelopeUri: ").Append(EnvelopeUri).Append("\n");
            sb.Append("  BulkRecipientRow: ").Append(BulkRecipientRow).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BulkStatus: ").Append(BulkStatus).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            
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
            return this.Equals(obj as BulkEnvelope);
        }

        /// <summary>
        /// Returns true if BulkEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.SubmittedDateTime == other.SubmittedDateTime ||
                    this.SubmittedDateTime != null &&
                    this.SubmittedDateTime.Equals(other.SubmittedDateTime)
                ) && 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.EnvelopeUri == other.EnvelopeUri ||
                    this.EnvelopeUri != null &&
                    this.EnvelopeUri.Equals(other.EnvelopeUri)
                ) && 
                (
                    this.BulkRecipientRow == other.BulkRecipientRow ||
                    this.BulkRecipientRow != null &&
                    this.BulkRecipientRow.Equals(other.BulkRecipientRow)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.BulkStatus == other.BulkStatus ||
                    this.BulkStatus != null &&
                    this.BulkStatus.Equals(other.BulkStatus)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
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
                
                if (this.TransactionId != null)
                    hash = hash * 57 + this.TransactionId.GetHashCode();
                
                if (this.SubmittedDateTime != null)
                    hash = hash * 57 + this.SubmittedDateTime.GetHashCode();
                
                if (this.EnvelopeId != null)
                    hash = hash * 57 + this.EnvelopeId.GetHashCode();
                
                if (this.EnvelopeUri != null)
                    hash = hash * 57 + this.EnvelopeUri.GetHashCode();
                
                if (this.BulkRecipientRow != null)
                    hash = hash * 57 + this.BulkRecipientRow.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                if (this.BulkStatus != null)
                    hash = hash * 57 + this.BulkStatus.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
