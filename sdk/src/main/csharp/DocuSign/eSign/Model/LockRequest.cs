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
    public class LockRequest : IEquatable<LockRequest>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lockedByApp", EmitDefaultValue=false)]
        public string LockedByApp { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
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
        [DataMember(Name="templatePassword", EmitDefaultValue=false)]
        public string TemplatePassword { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockRequest {\n");
            sb.Append("  LockedByApp: ").Append(LockedByApp).Append("\n");
            sb.Append("  LockDurationInSeconds: ").Append(LockDurationInSeconds).Append("\n");
            sb.Append("  LockType: ").Append(LockType).Append("\n");
            sb.Append("  UseScratchPad: ").Append(UseScratchPad).Append("\n");
            sb.Append("  TemplatePassword: ").Append(TemplatePassword).Append("\n");
            
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
            return this.Equals(obj as LockRequest);
        }

        /// <summary>
        /// Returns true if LockRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LockedByApp == other.LockedByApp ||
                    this.LockedByApp != null &&
                    this.LockedByApp.Equals(other.LockedByApp)
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
                    this.TemplatePassword == other.TemplatePassword ||
                    this.TemplatePassword != null &&
                    this.TemplatePassword.Equals(other.TemplatePassword)
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
                
                if (this.LockedByApp != null)
                    hash = hash * 57 + this.LockedByApp.GetHashCode();
                
                if (this.LockDurationInSeconds != null)
                    hash = hash * 57 + this.LockDurationInSeconds.GetHashCode();
                
                if (this.LockType != null)
                    hash = hash * 57 + this.LockType.GetHashCode();
                
                if (this.UseScratchPad != null)
                    hash = hash * 57 + this.UseScratchPad.GetHashCode();
                
                if (this.TemplatePassword != null)
                    hash = hash * 57 + this.TemplatePassword.GetHashCode();
                
                return hash;
            }
        }

    }
}
