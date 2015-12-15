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
    public class BccEmailAddress : IEquatable<BccEmailAddress>
    {
        
        /// <summary>
        /// Only users with canManageAccount setting can use this option. An array of up to 5 email addresses the envelope is sent to as a BCC email. \n \nExample: If your account has BCC for Email Archive set up for the email address 'archive@mycompany.com' and you send an envelope using the BCC Email Override to send a BCC email to 'salesarchive@mycompany.com', then a copy of the envelope is only sent to the 'salesarchive@mycompany.com' email address.
        /// </summary>
        /// <value>Only users with canManageAccount setting can use this option. An array of up to 5 email addresses the envelope is sent to as a BCC email. \n \nExample: If your account has BCC for Email Archive set up for the email address 'archive@mycompany.com' and you send an envelope using the BCC Email Override to send a BCC email to 'salesarchive@mycompany.com', then a copy of the envelope is only sent to the 'salesarchive@mycompany.com' email address.</value>
        [DataMember(Name="bccEmailAddressId", EmitDefaultValue=false)]
        public string BccEmailAddressId { get; set; }
  
        
        /// <summary>
        /// Specifies the BCC email address. DocuSign verifies that the email format is correct, but does not verify that the email is active.Using this overrides the BCC for Email Archive information setting for this envelope.\n\nMaximum of length: 100 characters.
        /// </summary>
        /// <value>Specifies the BCC email address. DocuSign verifies that the email format is correct, but does not verify that the email is active.Using this overrides the BCC for Email Archive information setting for this envelope.\n\nMaximum of length: 100 characters.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BccEmailAddress {\n");
            sb.Append("  BccEmailAddressId: ").Append(BccEmailAddressId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            
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
            return this.Equals(obj as BccEmailAddress);
        }

        /// <summary>
        /// Returns true if BccEmailAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of BccEmailAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BccEmailAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BccEmailAddressId == other.BccEmailAddressId ||
                    this.BccEmailAddressId != null &&
                    this.BccEmailAddressId.Equals(other.BccEmailAddressId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                
                if (this.BccEmailAddressId != null)
                    hash = hash * 57 + this.BccEmailAddressId.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                return hash;
            }
        }

    }
}
