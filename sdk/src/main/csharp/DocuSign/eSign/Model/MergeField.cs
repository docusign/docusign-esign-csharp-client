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
    public class MergeField : IEquatable<MergeField>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="configurationType", EmitDefaultValue=false)]
        public string ConfigurationType { get; set; }
  
        
        /// <summary>
        /// Sets the object associated with the custom tab. Currently this is the Salesforce Object.
        /// </summary>
        /// <value>Sets the object associated with the custom tab. Currently this is the Salesforce Object.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
  
        
        /// <summary>
        /// When wet to true, the information entered in the tab automatically updates the related Salesforce data when an envelope is completed.
        /// </summary>
        /// <value>When wet to true, the information entered in the tab automatically updates the related Salesforce data when an envelope is completed.</value>
        [DataMember(Name="writeBack", EmitDefaultValue=false)]
        public string WriteBack { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the sender can modify the value of the custom tab during the sending process.
        /// </summary>
        /// <value>When set to **true**, the sender can modify the value of the custom tab during the sending process.</value>
        [DataMember(Name="allowSenderToEdit", EmitDefaultValue=false)]
        public string AllowSenderToEdit { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeField {\n");
            sb.Append("  ConfigurationType: ").Append(ConfigurationType).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  WriteBack: ").Append(WriteBack).Append("\n");
            sb.Append("  AllowSenderToEdit: ").Append(AllowSenderToEdit).Append("\n");
            
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
            return this.Equals(obj as MergeField);
        }

        /// <summary>
        /// Returns true if MergeField instances are equal
        /// </summary>
        /// <param name="other">Instance of MergeField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConfigurationType == other.ConfigurationType ||
                    this.ConfigurationType != null &&
                    this.ConfigurationType.Equals(other.ConfigurationType)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.WriteBack == other.WriteBack ||
                    this.WriteBack != null &&
                    this.WriteBack.Equals(other.WriteBack)
                ) && 
                (
                    this.AllowSenderToEdit == other.AllowSenderToEdit ||
                    this.AllowSenderToEdit != null &&
                    this.AllowSenderToEdit.Equals(other.AllowSenderToEdit)
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
                
                if (this.ConfigurationType != null)
                    hash = hash * 57 + this.ConfigurationType.GetHashCode();
                
                if (this.Path != null)
                    hash = hash * 57 + this.Path.GetHashCode();
                
                if (this.WriteBack != null)
                    hash = hash * 57 + this.WriteBack.GetHashCode();
                
                if (this.AllowSenderToEdit != null)
                    hash = hash * 57 + this.AllowSenderToEdit.GetHashCode();
                
                return hash;
            }
        }

    }
}
