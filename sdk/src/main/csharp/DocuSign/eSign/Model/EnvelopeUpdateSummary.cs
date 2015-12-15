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
    public class EnvelopeUpdateSummary : IEquatable<EnvelopeUpdateSummary>
    {
        
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BulkEnvelopeStatus
        /// </summary>
        [DataMember(Name="bulkEnvelopeStatus", EmitDefaultValue=false)]
        public BulkEnvelopeStatus BulkEnvelopeStatus { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LockInformation
        /// </summary>
        [DataMember(Name="lockInformation", EmitDefaultValue=false)]
        public LockInformation LockInformation { get; set; }
  
        
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
            sb.Append("class EnvelopeUpdateSummary {\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  BulkEnvelopeStatus: ").Append(BulkEnvelopeStatus).Append("\n");
            sb.Append("  LockInformation: ").Append(LockInformation).Append("\n");
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
            return this.Equals(obj as EnvelopeUpdateSummary);
        }

        /// <summary>
        /// Returns true if EnvelopeUpdateSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeUpdateSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeUpdateSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.BulkEnvelopeStatus == other.BulkEnvelopeStatus ||
                    this.BulkEnvelopeStatus != null &&
                    this.BulkEnvelopeStatus.Equals(other.BulkEnvelopeStatus)
                ) && 
                (
                    this.LockInformation == other.LockInformation ||
                    this.LockInformation != null &&
                    this.LockInformation.Equals(other.LockInformation)
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
                
                if (this.EnvelopeId != null)
                    hash = hash * 57 + this.EnvelopeId.GetHashCode();
                
                if (this.BulkEnvelopeStatus != null)
                    hash = hash * 57 + this.BulkEnvelopeStatus.GetHashCode();
                
                if (this.LockInformation != null)
                    hash = hash * 57 + this.LockInformation.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
