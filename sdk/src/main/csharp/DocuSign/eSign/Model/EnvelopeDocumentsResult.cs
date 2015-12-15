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
    public class EnvelopeDocumentsResult : IEquatable<EnvelopeDocumentsResult>
    {
        
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopeDocuments", EmitDefaultValue=false)]
        public List<EnvelopeDocument> EnvelopeDocuments { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeDocumentsResult {\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  EnvelopeDocuments: ").Append(EnvelopeDocuments).Append("\n");
            
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
            return this.Equals(obj as EnvelopeDocumentsResult);
        }

        /// <summary>
        /// Returns true if EnvelopeDocumentsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeDocumentsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeDocumentsResult other)
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
                    this.EnvelopeDocuments == other.EnvelopeDocuments ||
                    this.EnvelopeDocuments != null &&
                    this.EnvelopeDocuments.SequenceEqual(other.EnvelopeDocuments)
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
                
                if (this.EnvelopeDocuments != null)
                    hash = hash * 57 + this.EnvelopeDocuments.GetHashCode();
                
                return hash;
            }
        }

    }
}
