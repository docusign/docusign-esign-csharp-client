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
    public class EmailSettings : IEquatable<EmailSettings>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="replyEmailAddressOverride", EmitDefaultValue=false)]
        public string ReplyEmailAddressOverride { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="replyEmailNameOverride", EmitDefaultValue=false)]
        public string ReplyEmailNameOverride { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="bccEmailAddresses", EmitDefaultValue=false)]
        public List<BccEmailAddress> BccEmailAddresses { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailSettings {\n");
            sb.Append("  ReplyEmailAddressOverride: ").Append(ReplyEmailAddressOverride).Append("\n");
            sb.Append("  ReplyEmailNameOverride: ").Append(ReplyEmailNameOverride).Append("\n");
            sb.Append("  BccEmailAddresses: ").Append(BccEmailAddresses).Append("\n");
            
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
            return this.Equals(obj as EmailSettings);
        }

        /// <summary>
        /// Returns true if EmailSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReplyEmailAddressOverride == other.ReplyEmailAddressOverride ||
                    this.ReplyEmailAddressOverride != null &&
                    this.ReplyEmailAddressOverride.Equals(other.ReplyEmailAddressOverride)
                ) && 
                (
                    this.ReplyEmailNameOverride == other.ReplyEmailNameOverride ||
                    this.ReplyEmailNameOverride != null &&
                    this.ReplyEmailNameOverride.Equals(other.ReplyEmailNameOverride)
                ) && 
                (
                    this.BccEmailAddresses == other.BccEmailAddresses ||
                    this.BccEmailAddresses != null &&
                    this.BccEmailAddresses.SequenceEqual(other.BccEmailAddresses)
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
                
                if (this.ReplyEmailAddressOverride != null)
                    hash = hash * 57 + this.ReplyEmailAddressOverride.GetHashCode();
                
                if (this.ReplyEmailNameOverride != null)
                    hash = hash * 57 + this.ReplyEmailNameOverride.GetHashCode();
                
                if (this.BccEmailAddresses != null)
                    hash = hash * 57 + this.BccEmailAddresses.GetHashCode();
                
                return hash;
            }
        }

    }
}
