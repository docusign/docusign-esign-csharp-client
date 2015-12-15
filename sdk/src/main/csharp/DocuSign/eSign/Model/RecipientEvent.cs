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
    public class RecipientEvent : IEquatable<RecipientEvent>
    {
        
        /// <summary>
        /// The recipient status, this can be Sent, Delivered, Completed, Declined, AuthenticationFailed, and AutoResponded.
        /// </summary>
        /// <value>The recipient status, this can be Sent, Delivered, Completed, Declined, AuthenticationFailed, and AutoResponded.</value>
        [DataMember(Name="recipientEventStatusCode", EmitDefaultValue=false)]
        public string RecipientEventStatusCode { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the envelope time zone information is included in the message.
        /// </summary>
        /// <value>When set to **true**, the envelope time zone information is included in the message.</value>
        [DataMember(Name="includeDocuments", EmitDefaultValue=false)]
        public string IncludeDocuments { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientEvent {\n");
            sb.Append("  RecipientEventStatusCode: ").Append(RecipientEventStatusCode).Append("\n");
            sb.Append("  IncludeDocuments: ").Append(IncludeDocuments).Append("\n");
            
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
            return this.Equals(obj as RecipientEvent);
        }

        /// <summary>
        /// Returns true if RecipientEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RecipientEventStatusCode == other.RecipientEventStatusCode ||
                    this.RecipientEventStatusCode != null &&
                    this.RecipientEventStatusCode.Equals(other.RecipientEventStatusCode)
                ) && 
                (
                    this.IncludeDocuments == other.IncludeDocuments ||
                    this.IncludeDocuments != null &&
                    this.IncludeDocuments.Equals(other.IncludeDocuments)
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
                
                if (this.RecipientEventStatusCode != null)
                    hash = hash * 57 + this.RecipientEventStatusCode.GetHashCode();
                
                if (this.IncludeDocuments != null)
                    hash = hash * 57 + this.IncludeDocuments.GetHashCode();
                
                return hash;
            }
        }

    }
}
