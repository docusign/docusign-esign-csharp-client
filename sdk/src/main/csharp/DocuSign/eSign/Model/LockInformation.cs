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
    public class LockInformation : IEquatable<LockInformation>
    {
        
        /// <summary>
        /// Gets or Sets LockedByUser
        /// </summary>
        [DataMember(Name="lockedByUser", EmitDefaultValue=false)]
        public UserInfo LockedByUser { get; set; }
  
        
        /// <summary>
        /// Specifies the friendly name of  the application that is locking the envelope.
        /// </summary>
        /// <value>Specifies the friendly name of  the application that is locking the envelope.</value>
        [DataMember(Name="lockedByApp", EmitDefaultValue=false)]
        public string LockedByApp { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lockedUntilDateTime", EmitDefaultValue=false)]
        public string LockedUntilDateTime { get; set; }
  
        
        /// <summary>
        /// Sets the time, in seconds, until the lock expires when there is no activity on the envelope.\n\nIf no value is entered, then the default value of 300 seconds is used. The maximum value is 1,800 seconds.\n\nThe lock duration can be extended.
        /// </summary>
        /// <value>Sets the time, in seconds, until the lock expires when there is no activity on the envelope.\n\nIf no value is entered, then the default value of 300 seconds is used. The maximum value is 1,800 seconds.\n\nThe lock duration can be extended.</value>
        [DataMember(Name="lockDurationInSeconds", EmitDefaultValue=false)]
        public string LockDurationInSeconds { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lockType", EmitDefaultValue=false)]
        public string LockType { get; set; }
  
        
        /// <summary>
        /// Reserved for future use.\n\nIndicates whether a scratchpad is used for editing information.
        /// </summary>
        /// <value>Reserved for future use.\n\nIndicates whether a scratchpad is used for editing information.</value>
        [DataMember(Name="useScratchPad", EmitDefaultValue=false)]
        public string UseScratchPad { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lockToken", EmitDefaultValue=false)]
        public string LockToken { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockInformation {\n");
            sb.Append("  LockedByUser: ").Append(LockedByUser).Append("\n");
            sb.Append("  LockedByApp: ").Append(LockedByApp).Append("\n");
            sb.Append("  LockedUntilDateTime: ").Append(LockedUntilDateTime).Append("\n");
            sb.Append("  LockDurationInSeconds: ").Append(LockDurationInSeconds).Append("\n");
            sb.Append("  LockType: ").Append(LockType).Append("\n");
            sb.Append("  UseScratchPad: ").Append(UseScratchPad).Append("\n");
            sb.Append("  LockToken: ").Append(LockToken).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            
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
            return this.Equals(obj as LockInformation);
        }

        /// <summary>
        /// Returns true if LockInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of LockInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LockedByUser == other.LockedByUser ||
                    this.LockedByUser != null &&
                    this.LockedByUser.Equals(other.LockedByUser)
                ) && 
                (
                    this.LockedByApp == other.LockedByApp ||
                    this.LockedByApp != null &&
                    this.LockedByApp.Equals(other.LockedByApp)
                ) && 
                (
                    this.LockedUntilDateTime == other.LockedUntilDateTime ||
                    this.LockedUntilDateTime != null &&
                    this.LockedUntilDateTime.Equals(other.LockedUntilDateTime)
                ) && 
                (
                    this.LockDurationInSeconds == other.LockDurationInSeconds ||
                    this.LockDurationInSeconds != null &&
                    this.LockDurationInSeconds.Equals(other.LockDurationInSeconds)
                ) && 
                (
                    this.LockType == other.LockType ||
                    this.LockType != null &&
                    this.LockType.Equals(other.LockType)
                ) && 
                (
                    this.UseScratchPad == other.UseScratchPad ||
                    this.UseScratchPad != null &&
                    this.UseScratchPad.Equals(other.UseScratchPad)
                ) && 
                (
                    this.LockToken == other.LockToken ||
                    this.LockToken != null &&
                    this.LockToken.Equals(other.LockToken)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
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
                
                if (this.LockedByUser != null)
                    hash = hash * 57 + this.LockedByUser.GetHashCode();
                
                if (this.LockedByApp != null)
                    hash = hash * 57 + this.LockedByApp.GetHashCode();
                
                if (this.LockedUntilDateTime != null)
                    hash = hash * 57 + this.LockedUntilDateTime.GetHashCode();
                
                if (this.LockDurationInSeconds != null)
                    hash = hash * 57 + this.LockDurationInSeconds.GetHashCode();
                
                if (this.LockType != null)
                    hash = hash * 57 + this.LockType.GetHashCode();
                
                if (this.UseScratchPad != null)
                    hash = hash * 57 + this.UseScratchPad.GetHashCode();
                
                if (this.LockToken != null)
                    hash = hash * 57 + this.LockToken.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
