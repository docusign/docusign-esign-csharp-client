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
    public class Notification : IEquatable<Notification>
    {
        
        /// <summary>
        /// When set to **true**, the account default notification settings are used for the envelope.
        /// </summary>
        /// <value>When set to **true**, the account default notification settings are used for the envelope.</value>
        [DataMember(Name="useAccountDefaults", EmitDefaultValue=false)]
        public string UseAccountDefaults { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Reminders
        /// </summary>
        [DataMember(Name="reminders", EmitDefaultValue=false)]
        public Reminders Reminders { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Expirations
        /// </summary>
        [DataMember(Name="expirations", EmitDefaultValue=false)]
        public Expirations Expirations { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  UseAccountDefaults: ").Append(UseAccountDefaults).Append("\n");
            sb.Append("  Reminders: ").Append(Reminders).Append("\n");
            sb.Append("  Expirations: ").Append(Expirations).Append("\n");
            
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
            return this.Equals(obj as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="other">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UseAccountDefaults == other.UseAccountDefaults ||
                    this.UseAccountDefaults != null &&
                    this.UseAccountDefaults.Equals(other.UseAccountDefaults)
                ) && 
                (
                    this.Reminders == other.Reminders ||
                    this.Reminders != null &&
                    this.Reminders.Equals(other.Reminders)
                ) && 
                (
                    this.Expirations == other.Expirations ||
                    this.Expirations != null &&
                    this.Expirations.Equals(other.Expirations)
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
                
                if (this.UseAccountDefaults != null)
                    hash = hash * 57 + this.UseAccountDefaults.GetHashCode();
                
                if (this.Reminders != null)
                    hash = hash * 57 + this.Reminders.GetHashCode();
                
                if (this.Expirations != null)
                    hash = hash * 57 + this.Expirations.GetHashCode();
                
                return hash;
            }
        }

    }
}
