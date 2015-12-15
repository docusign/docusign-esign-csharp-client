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
    public class ListItem : IEquatable<ListItem>
    {
        
        /// <summary>
        /// Specifies the text that is shown in the dropdown list.
        /// </summary>
        /// <value>Specifies the text that is shown in the dropdown list.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
  
        
        /// <summary>
        /// Specifies the value that is used when the list item is selected.
        /// </summary>
        /// <value>Specifies the value that is used when the list item is selected.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
  
        
        /// <summary>
        /// When set to **true**, indicates that this item is the default selection shown to a signer. \n\nOnly one selection can be set as the default.
        /// </summary>
        /// <value>When set to **true**, indicates that this item is the default selection shown to a signer. \n\nOnly one selection can be set as the default.</value>
        [DataMember(Name="selected", EmitDefaultValue=false)]
        public string Selected { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListItem {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            
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
            return this.Equals(obj as ListItem);
        }

        /// <summary>
        /// Returns true if ListItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Selected == other.Selected ||
                    this.Selected != null &&
                    this.Selected.Equals(other.Selected)
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
                
                if (this.Text != null)
                    hash = hash * 57 + this.Text.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 57 + this.Value.GetHashCode();
                
                if (this.Selected != null)
                    hash = hash * 57 + this.Selected.GetHashCode();
                
                return hash;
            }
        }

    }
}
