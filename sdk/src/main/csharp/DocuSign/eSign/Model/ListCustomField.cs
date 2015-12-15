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
    public class ListCustomField : IEquatable<ListCustomField>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="listItems", EmitDefaultValue=false)]
        public List<string> ListItems { get; set; }
  
        
        /// <summary>
        /// An ID used to specify a custom field.
        /// </summary>
        /// <value>An ID used to specify a custom field.</value>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }
  
        
        /// <summary>
        /// The name of the custom field.
        /// </summary>
        /// <value>The name of the custom field.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// A boolean indicating if the value should be displayed.
        /// </summary>
        /// <value>A boolean indicating if the value should be displayed.</value>
        [DataMember(Name="show", EmitDefaultValue=false)]
        public string Show { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the signer is required to fill out this tab
        /// </summary>
        /// <value>When set to **true**, the signer is required to fill out this tab</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public string Required { get; set; }
  
        
        /// <summary>
        /// The value of the custom field.\n\nMaximum Length: 100 characters.
        /// </summary>
        /// <value>The value of the custom field.\n\nMaximum Length: 100 characters.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="configurationType", EmitDefaultValue=false)]
        public string ConfigurationType { get; set; }
  
        
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
            sb.Append("class ListCustomField {\n");
            sb.Append("  ListItems: ").Append(ListItems).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Show: ").Append(Show).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ConfigurationType: ").Append(ConfigurationType).Append("\n");
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
            return this.Equals(obj as ListCustomField);
        }

        /// <summary>
        /// Returns true if ListCustomField instances are equal
        /// </summary>
        /// <param name="other">Instance of ListCustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListCustomField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ListItems == other.ListItems ||
                    this.ListItems != null &&
                    this.ListItems.SequenceEqual(other.ListItems)
                ) && 
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Show == other.Show ||
                    this.Show != null &&
                    this.Show.Equals(other.Show)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.ConfigurationType == other.ConfigurationType ||
                    this.ConfigurationType != null &&
                    this.ConfigurationType.Equals(other.ConfigurationType)
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
                
                if (this.ListItems != null)
                    hash = hash * 57 + this.ListItems.GetHashCode();
                
                if (this.FieldId != null)
                    hash = hash * 57 + this.FieldId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Show != null)
                    hash = hash * 57 + this.Show.GetHashCode();
                
                if (this.Required != null)
                    hash = hash * 57 + this.Required.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 57 + this.Value.GetHashCode();
                
                if (this.ConfigurationType != null)
                    hash = hash * 57 + this.ConfigurationType.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
