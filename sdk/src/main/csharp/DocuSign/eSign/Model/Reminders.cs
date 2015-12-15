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
    public class Reminders : IEquatable<Reminders>
    {
        
        /// <summary>
        /// When set to **true**, the envelope expires (is no longer available for signing) in the set number of days. If false, the account default setting is used. If the account does not have an expiration setting, the DocuSign default value of 120 days is used.
        /// </summary>
        /// <value>When set to **true**, the envelope expires (is no longer available for signing) in the set number of days. If false, the account default setting is used. If the account does not have an expiration setting, the DocuSign default value of 120 days is used.</value>
        [DataMember(Name="reminderEnabled", EmitDefaultValue=false)]
        public string ReminderEnabled { get; set; }
  
        
        /// <summary>
        /// An interger that sets the number of days after the recipient receives the envelope that reminder emails are sent to the recipient.
        /// </summary>
        /// <value>An interger that sets the number of days after the recipient receives the envelope that reminder emails are sent to the recipient.</value>
        [DataMember(Name="reminderDelay", EmitDefaultValue=false)]
        public string ReminderDelay { get; set; }
  
        
        /// <summary>
        /// An interger that sets the interval, in days, between reminder emails.
        /// </summary>
        /// <value>An interger that sets the interval, in days, between reminder emails.</value>
        [DataMember(Name="reminderFrequency", EmitDefaultValue=false)]
        public string ReminderFrequency { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reminders {\n");
            sb.Append("  ReminderEnabled: ").Append(ReminderEnabled).Append("\n");
            sb.Append("  ReminderDelay: ").Append(ReminderDelay).Append("\n");
            sb.Append("  ReminderFrequency: ").Append(ReminderFrequency).Append("\n");
            
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
            return this.Equals(obj as Reminders);
        }

        /// <summary>
        /// Returns true if Reminders instances are equal
        /// </summary>
        /// <param name="other">Instance of Reminders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reminders other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReminderEnabled == other.ReminderEnabled ||
                    this.ReminderEnabled != null &&
                    this.ReminderEnabled.Equals(other.ReminderEnabled)
                ) && 
                (
                    this.ReminderDelay == other.ReminderDelay ||
                    this.ReminderDelay != null &&
                    this.ReminderDelay.Equals(other.ReminderDelay)
                ) && 
                (
                    this.ReminderFrequency == other.ReminderFrequency ||
                    this.ReminderFrequency != null &&
                    this.ReminderFrequency.Equals(other.ReminderFrequency)
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
                
                if (this.ReminderEnabled != null)
                    hash = hash * 57 + this.ReminderEnabled.GetHashCode();
                
                if (this.ReminderDelay != null)
                    hash = hash * 57 + this.ReminderDelay.GetHashCode();
                
                if (this.ReminderFrequency != null)
                    hash = hash * 57 + this.ReminderFrequency.GetHashCode();
                
                return hash;
            }
        }

    }
}
