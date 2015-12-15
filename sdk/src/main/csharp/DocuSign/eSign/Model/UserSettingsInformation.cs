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
    public class UserSettingsInformation : IEquatable<UserSettingsInformation>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userSettings", EmitDefaultValue=false)]
        public List<NameValue> UserSettings { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SignerEmailNotifications
        /// </summary>
        [DataMember(Name="signerEmailNotifications", EmitDefaultValue=false)]
        public SignerEmailNotifications SignerEmailNotifications { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SenderEmailNotifications
        /// </summary>
        [DataMember(Name="senderEmailNotifications", EmitDefaultValue=false)]
        public SenderEmailNotifications SenderEmailNotifications { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSettingsInformation {\n");
            sb.Append("  UserSettings: ").Append(UserSettings).Append("\n");
            sb.Append("  SignerEmailNotifications: ").Append(SignerEmailNotifications).Append("\n");
            sb.Append("  SenderEmailNotifications: ").Append(SenderEmailNotifications).Append("\n");
            
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
            return this.Equals(obj as UserSettingsInformation);
        }

        /// <summary>
        /// Returns true if UserSettingsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSettingsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSettingsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserSettings == other.UserSettings ||
                    this.UserSettings != null &&
                    this.UserSettings.SequenceEqual(other.UserSettings)
                ) && 
                (
                    this.SignerEmailNotifications == other.SignerEmailNotifications ||
                    this.SignerEmailNotifications != null &&
                    this.SignerEmailNotifications.Equals(other.SignerEmailNotifications)
                ) && 
                (
                    this.SenderEmailNotifications == other.SenderEmailNotifications ||
                    this.SenderEmailNotifications != null &&
                    this.SenderEmailNotifications.Equals(other.SenderEmailNotifications)
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
                
                if (this.UserSettings != null)
                    hash = hash * 57 + this.UserSettings.GetHashCode();
                
                if (this.SignerEmailNotifications != null)
                    hash = hash * 57 + this.SignerEmailNotifications.GetHashCode();
                
                if (this.SenderEmailNotifications != null)
                    hash = hash * 57 + this.SenderEmailNotifications.GetHashCode();
                
                return hash;
            }
        }

    }
}
