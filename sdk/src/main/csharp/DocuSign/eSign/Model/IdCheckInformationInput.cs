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
    public class IdCheckInformationInput : IEquatable<IdCheckInformationInput>
    {
        
        /// <summary>
        /// Gets or Sets AddressInformationInput
        /// </summary>
        [DataMember(Name="addressInformationInput", EmitDefaultValue=false)]
        public AddressInformationInput AddressInformationInput { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DobInformationInput
        /// </summary>
        [DataMember(Name="dobInformationInput", EmitDefaultValue=false)]
        public DobInformationInput DobInformationInput { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Ssn4InformationInput
        /// </summary>
        [DataMember(Name="ssn4InformationInput", EmitDefaultValue=false)]
        public Ssn4InformationInput Ssn4InformationInput { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Ssn9InformationInput
        /// </summary>
        [DataMember(Name="ssn9InformationInput", EmitDefaultValue=false)]
        public Ssn9InformationInput Ssn9InformationInput { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdCheckInformationInput {\n");
            sb.Append("  AddressInformationInput: ").Append(AddressInformationInput).Append("\n");
            sb.Append("  DobInformationInput: ").Append(DobInformationInput).Append("\n");
            sb.Append("  Ssn4InformationInput: ").Append(Ssn4InformationInput).Append("\n");
            sb.Append("  Ssn9InformationInput: ").Append(Ssn9InformationInput).Append("\n");
            
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
            return this.Equals(obj as IdCheckInformationInput);
        }

        /// <summary>
        /// Returns true if IdCheckInformationInput instances are equal
        /// </summary>
        /// <param name="other">Instance of IdCheckInformationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdCheckInformationInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddressInformationInput == other.AddressInformationInput ||
                    this.AddressInformationInput != null &&
                    this.AddressInformationInput.Equals(other.AddressInformationInput)
                ) && 
                (
                    this.DobInformationInput == other.DobInformationInput ||
                    this.DobInformationInput != null &&
                    this.DobInformationInput.Equals(other.DobInformationInput)
                ) && 
                (
                    this.Ssn4InformationInput == other.Ssn4InformationInput ||
                    this.Ssn4InformationInput != null &&
                    this.Ssn4InformationInput.Equals(other.Ssn4InformationInput)
                ) && 
                (
                    this.Ssn9InformationInput == other.Ssn9InformationInput ||
                    this.Ssn9InformationInput != null &&
                    this.Ssn9InformationInput.Equals(other.Ssn9InformationInput)
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
                
                if (this.AddressInformationInput != null)
                    hash = hash * 57 + this.AddressInformationInput.GetHashCode();
                
                if (this.DobInformationInput != null)
                    hash = hash * 57 + this.DobInformationInput.GetHashCode();
                
                if (this.Ssn4InformationInput != null)
                    hash = hash * 57 + this.Ssn4InformationInput.GetHashCode();
                
                if (this.Ssn9InformationInput != null)
                    hash = hash * 57 + this.Ssn9InformationInput.GetHashCode();
                
                return hash;
            }
        }

    }
}
