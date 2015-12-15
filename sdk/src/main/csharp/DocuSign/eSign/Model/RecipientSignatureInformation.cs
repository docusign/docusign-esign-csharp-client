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
    public class RecipientSignatureInformation : IEquatable<RecipientSignatureInformation>
    {
        
        /// <summary>
        /// Specifies the user signature name.
        /// </summary>
        /// <value>Specifies the user signature name.</value>
        [DataMember(Name="signatureName", EmitDefaultValue=false)]
        public string SignatureName { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureInitials", EmitDefaultValue=false)]
        public string SignatureInitials { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="fontStyle", EmitDefaultValue=false)]
        public string FontStyle { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientSignatureInformation {\n");
            sb.Append("  SignatureName: ").Append(SignatureName).Append("\n");
            sb.Append("  SignatureInitials: ").Append(SignatureInitials).Append("\n");
            sb.Append("  FontStyle: ").Append(FontStyle).Append("\n");
            
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
            return this.Equals(obj as RecipientSignatureInformation);
        }

        /// <summary>
        /// Returns true if RecipientSignatureInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientSignatureInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientSignatureInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignatureName == other.SignatureName ||
                    this.SignatureName != null &&
                    this.SignatureName.Equals(other.SignatureName)
                ) && 
                (
                    this.SignatureInitials == other.SignatureInitials ||
                    this.SignatureInitials != null &&
                    this.SignatureInitials.Equals(other.SignatureInitials)
                ) && 
                (
                    this.FontStyle == other.FontStyle ||
                    this.FontStyle != null &&
                    this.FontStyle.Equals(other.FontStyle)
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
                
                if (this.SignatureName != null)
                    hash = hash * 57 + this.SignatureName.GetHashCode();
                
                if (this.SignatureInitials != null)
                    hash = hash * 57 + this.SignatureInitials.GetHashCode();
                
                if (this.FontStyle != null)
                    hash = hash * 57 + this.FontStyle.GetHashCode();
                
                return hash;
            }
        }

    }
}
