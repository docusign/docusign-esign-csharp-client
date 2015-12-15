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
    public class RecipientSMSAuthentication : IEquatable<RecipientSMSAuthentication>
    {
        
        /// <summary>
        /// An Array containing a list of phone numbers the recipient may use for SMS text authentication.
        /// </summary>
        /// <value>An Array containing a list of phone numbers the recipient may use for SMS text authentication.</value>
        [DataMember(Name="senderProvidedNumbers", EmitDefaultValue=false)]
        public List<string> SenderProvidedNumbers { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientSMSAuthentication {\n");
            sb.Append("  SenderProvidedNumbers: ").Append(SenderProvidedNumbers).Append("\n");
            
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
            return this.Equals(obj as RecipientSMSAuthentication);
        }

        /// <summary>
        /// Returns true if RecipientSMSAuthentication instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientSMSAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientSMSAuthentication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SenderProvidedNumbers == other.SenderProvidedNumbers ||
                    this.SenderProvidedNumbers != null &&
                    this.SenderProvidedNumbers.SequenceEqual(other.SenderProvidedNumbers)
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
                
                if (this.SenderProvidedNumbers != null)
                    hash = hash * 57 + this.SenderProvidedNumbers.GetHashCode();
                
                return hash;
            }
        }

    }
}
