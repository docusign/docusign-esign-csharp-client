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
    public class AccountSettingsInformation : IEquatable<AccountSettingsInformation>
    {
        
        /// <summary>
        /// The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden.
        /// </summary>
        /// <value>The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden.</value>
        [DataMember(Name="accountSettings", EmitDefaultValue=false)]
        public List<NameValue> AccountSettings { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSettingsInformation {\n");
            sb.Append("  AccountSettings: ").Append(AccountSettings).Append("\n");
            
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
            return this.Equals(obj as AccountSettingsInformation);
        }

        /// <summary>
        /// Returns true if AccountSettingsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSettingsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSettingsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountSettings == other.AccountSettings ||
                    this.AccountSettings != null &&
                    this.AccountSettings.SequenceEqual(other.AccountSettings)
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
                
                if (this.AccountSettings != null)
                    hash = hash * 57 + this.AccountSettings.GetHashCode();
                
                return hash;
            }
        }

    }
}
