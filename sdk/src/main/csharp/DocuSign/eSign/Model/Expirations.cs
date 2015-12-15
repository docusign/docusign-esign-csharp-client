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
    public class Expirations : IEquatable<Expirations>
    {
        
        /// <summary>
        /// When set to **true**, the envelope expires (is no longer available for signing) in the set number of days. If false, the account default setting is used. If the account does not have an expiration setting, the DocuSign default value of 120 days is used.
        /// </summary>
        /// <value>When set to **true**, the envelope expires (is no longer available for signing) in the set number of days. If false, the account default setting is used. If the account does not have an expiration setting, the DocuSign default value of 120 days is used.</value>
        [DataMember(Name="expireEnabled", EmitDefaultValue=false)]
        public string ExpireEnabled { get; set; }
  
        
        /// <summary>
        /// An integer that sets the number of days the envelope is active.
        /// </summary>
        /// <value>An integer that sets the number of days the envelope is active.</value>
        [DataMember(Name="expireAfter", EmitDefaultValue=false)]
        public string ExpireAfter { get; set; }
  
        
        /// <summary>
        /// An integer that sets the number of days before envelope expiration that an expiration warning email is sent to the recipient. If set to 0 (zero), no warning email is sent.
        /// </summary>
        /// <value>An integer that sets the number of days before envelope expiration that an expiration warning email is sent to the recipient. If set to 0 (zero), no warning email is sent.</value>
        [DataMember(Name="expireWarn", EmitDefaultValue=false)]
        public string ExpireWarn { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Expirations {\n");
            sb.Append("  ExpireEnabled: ").Append(ExpireEnabled).Append("\n");
            sb.Append("  ExpireAfter: ").Append(ExpireAfter).Append("\n");
            sb.Append("  ExpireWarn: ").Append(ExpireWarn).Append("\n");
            
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
            return this.Equals(obj as Expirations);
        }

        /// <summary>
        /// Returns true if Expirations instances are equal
        /// </summary>
        /// <param name="other">Instance of Expirations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Expirations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExpireEnabled == other.ExpireEnabled ||
                    this.ExpireEnabled != null &&
                    this.ExpireEnabled.Equals(other.ExpireEnabled)
                ) && 
                (
                    this.ExpireAfter == other.ExpireAfter ||
                    this.ExpireAfter != null &&
                    this.ExpireAfter.Equals(other.ExpireAfter)
                ) && 
                (
                    this.ExpireWarn == other.ExpireWarn ||
                    this.ExpireWarn != null &&
                    this.ExpireWarn.Equals(other.ExpireWarn)
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
                
                if (this.ExpireEnabled != null)
                    hash = hash * 57 + this.ExpireEnabled.GetHashCode();
                
                if (this.ExpireAfter != null)
                    hash = hash * 57 + this.ExpireAfter.GetHashCode();
                
                if (this.ExpireWarn != null)
                    hash = hash * 57 + this.ExpireWarn.GetHashCode();
                
                return hash;
            }
        }

    }
}
