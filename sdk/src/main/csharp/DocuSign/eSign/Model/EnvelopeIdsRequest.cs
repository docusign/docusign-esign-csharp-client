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
    public class EnvelopeIdsRequest : IEquatable<EnvelopeIdsRequest>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopeIds", EmitDefaultValue=false)]
        public List<string> EnvelopeIds { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="transactionIds", EmitDefaultValue=false)]
        public List<string> TransactionIds { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeIdsRequest {\n");
            sb.Append("  EnvelopeIds: ").Append(EnvelopeIds).Append("\n");
            sb.Append("  TransactionIds: ").Append(TransactionIds).Append("\n");
            
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
            return this.Equals(obj as EnvelopeIdsRequest);
        }

        /// <summary>
        /// Returns true if EnvelopeIdsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeIdsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeIdsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnvelopeIds == other.EnvelopeIds ||
                    this.EnvelopeIds != null &&
                    this.EnvelopeIds.SequenceEqual(other.EnvelopeIds)
                ) && 
                (
                    this.TransactionIds == other.TransactionIds ||
                    this.TransactionIds != null &&
                    this.TransactionIds.SequenceEqual(other.TransactionIds)
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
                
                if (this.EnvelopeIds != null)
                    hash = hash * 57 + this.EnvelopeIds.GetHashCode();
                
                if (this.TransactionIds != null)
                    hash = hash * 57 + this.TransactionIds.GetHashCode();
                
                return hash;
            }
        }

    }
}
