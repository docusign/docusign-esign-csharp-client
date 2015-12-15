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
    public class Ssn9InformationInput : IEquatable<Ssn9InformationInput>
    {
        
        /// <summary>
        /// The recipient's Social Security Number(SSN).
        /// </summary>
        /// <value>The recipient's Social Security Number(SSN).</value>
        [DataMember(Name="ssn9", EmitDefaultValue=false)]
        public string Ssn9 { get; set; }
  
        
        /// <summary>
        /// Specifies the display level for the recipient. \nValid values are: \n\n* ReadOnly\n* Editable\n* DoNotDisplay
        /// </summary>
        /// <value>Specifies the display level for the recipient. \nValid values are: \n\n* ReadOnly\n* Editable\n* DoNotDisplay</value>
        [DataMember(Name="displayLevelCode", EmitDefaultValue=false)]
        public string DisplayLevelCode { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ssn9InformationInput {\n");
            sb.Append("  Ssn9: ").Append(Ssn9).Append("\n");
            sb.Append("  DisplayLevelCode: ").Append(DisplayLevelCode).Append("\n");
            
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
            return this.Equals(obj as Ssn9InformationInput);
        }

        /// <summary>
        /// Returns true if Ssn9InformationInput instances are equal
        /// </summary>
        /// <param name="other">Instance of Ssn9InformationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ssn9InformationInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ssn9 == other.Ssn9 ||
                    this.Ssn9 != null &&
                    this.Ssn9.Equals(other.Ssn9)
                ) && 
                (
                    this.DisplayLevelCode == other.DisplayLevelCode ||
                    this.DisplayLevelCode != null &&
                    this.DisplayLevelCode.Equals(other.DisplayLevelCode)
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
                
                if (this.Ssn9 != null)
                    hash = hash * 57 + this.Ssn9.GetHashCode();
                
                if (this.DisplayLevelCode != null)
                    hash = hash * 57 + this.DisplayLevelCode.GetHashCode();
                
                return hash;
            }
        }

    }
}
