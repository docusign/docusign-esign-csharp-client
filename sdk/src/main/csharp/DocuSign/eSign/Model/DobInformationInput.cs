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
    public class DobInformationInput : IEquatable<DobInformationInput>
    {
        
        /// <summary>
        /// Specifies the recipient’s date, month, and year of birth.
        /// </summary>
        /// <value>Specifies the recipient’s date, month, and year of birth.</value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public string DateOfBirth { get; set; }
  
        
        /// <summary>
        /// Specifies the display level for the recipient. \nValid values are: \n\n* ReadOnly\n* Editable\n* DoNotDisplay
        /// </summary>
        /// <value>Specifies the display level for the recipient. \nValid values are: \n\n* ReadOnly\n* Editable\n* DoNotDisplay</value>
        [DataMember(Name="displayLevelCode", EmitDefaultValue=false)]
        public string DisplayLevelCode { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the information needs to be returned in the response.
        /// </summary>
        /// <value>When set to **true**, the information needs to be returned in the response.</value>
        [DataMember(Name="receiveInResponse", EmitDefaultValue=false)]
        public string ReceiveInResponse { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DobInformationInput {\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DisplayLevelCode: ").Append(DisplayLevelCode).Append("\n");
            sb.Append("  ReceiveInResponse: ").Append(ReceiveInResponse).Append("\n");
            
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
            return this.Equals(obj as DobInformationInput);
        }

        /// <summary>
        /// Returns true if DobInformationInput instances are equal
        /// </summary>
        /// <param name="other">Instance of DobInformationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DobInformationInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    this.DisplayLevelCode == other.DisplayLevelCode ||
                    this.DisplayLevelCode != null &&
                    this.DisplayLevelCode.Equals(other.DisplayLevelCode)
                ) && 
                (
                    this.ReceiveInResponse == other.ReceiveInResponse ||
                    this.ReceiveInResponse != null &&
                    this.ReceiveInResponse.Equals(other.ReceiveInResponse)
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
                
                if (this.DateOfBirth != null)
                    hash = hash * 57 + this.DateOfBirth.GetHashCode();
                
                if (this.DisplayLevelCode != null)
                    hash = hash * 57 + this.DisplayLevelCode.GetHashCode();
                
                if (this.ReceiveInResponse != null)
                    hash = hash * 57 + this.ReceiveInResponse.GetHashCode();
                
                return hash;
            }
        }

    }
}
