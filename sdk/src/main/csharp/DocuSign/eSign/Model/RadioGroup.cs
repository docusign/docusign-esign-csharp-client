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
    public class RadioGroup : IEquatable<RadioGroup>
    {
        
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
  
        
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
  
        
        /// <summary>
        /// For conditional fields this is the TabLabel of the parent tab that controls this tab's visibility.
        /// </summary>
        /// <value>For conditional fields this is the TabLabel of the parent tab that controls this tab's visibility.</value>
        [DataMember(Name="conditionalParentLabel", EmitDefaultValue=false)]
        public string ConditionalParentLabel { get; set; }
  
        
        /// <summary>
        /// For conditional fields, this is the value of the parent tab that controls the tab's visibility.\n\nIf the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \"on\" as the value to show that the parent tab is active.
        /// </summary>
        /// <value>For conditional fields, this is the value of the parent tab that controls the tab's visibility.\n\nIf the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \"on\" as the value to show that the parent tab is active.</value>
        [DataMember(Name="conditionalParentValue", EmitDefaultValue=false)]
        public string ConditionalParentValue { get; set; }
  
        
        /// <summary>
        /// The name of the group.
        /// </summary>
        /// <value>The name of the group.</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }
  
        
        /// <summary>
        /// Specifies the locations and status for radio buttons that are grouped together.
        /// </summary>
        /// <value>Specifies the locations and status for radio buttons that are grouped together.</value>
        [DataMember(Name="radios", EmitDefaultValue=false)]
        public List<Radio> Radios { get; set; }
  
        
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
  
        
        /// <summary>
        /// Optional element for field markup. When set to **true**, the signer is required to initial when they modify a shared field.
        /// </summary>
        /// <value>Optional element for field markup. When set to **true**, the signer is required to initial when they modify a shared field.</value>
        [DataMember(Name="requireInitialOnSharedChange", EmitDefaultValue=false)]
        public string RequireInitialOnSharedChange { get; set; }
  
        
        /// <summary>
        /// When set to **true** and shared is true, information must be entered in this field to complete the envelope.
        /// </summary>
        /// <value>When set to **true** and shared is true, information must be entered in this field to complete the envelope.</value>
        [DataMember(Name="requireAll", EmitDefaultValue=false)]
        public string RequireAll { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadioGroup {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  ConditionalParentLabel: ").Append(ConditionalParentLabel).Append("\n");
            sb.Append("  ConditionalParentValue: ").Append(ConditionalParentValue).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Radios: ").Append(Radios).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  RequireInitialOnSharedChange: ").Append(RequireInitialOnSharedChange).Append("\n");
            sb.Append("  RequireAll: ").Append(RequireAll).Append("\n");
            
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
            return this.Equals(obj as RadioGroup);
        }

        /// <summary>
        /// Returns true if RadioGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of RadioGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadioGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.ConditionalParentLabel == other.ConditionalParentLabel ||
                    this.ConditionalParentLabel != null &&
                    this.ConditionalParentLabel.Equals(other.ConditionalParentLabel)
                ) && 
                (
                    this.ConditionalParentValue == other.ConditionalParentValue ||
                    this.ConditionalParentValue != null &&
                    this.ConditionalParentValue.Equals(other.ConditionalParentValue)
                ) && 
                (
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName)
                ) && 
                (
                    this.Radios == other.Radios ||
                    this.Radios != null &&
                    this.Radios.SequenceEqual(other.Radios)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.RequireInitialOnSharedChange == other.RequireInitialOnSharedChange ||
                    this.RequireInitialOnSharedChange != null &&
                    this.RequireInitialOnSharedChange.Equals(other.RequireInitialOnSharedChange)
                ) && 
                (
                    this.RequireAll == other.RequireAll ||
                    this.RequireAll != null &&
                    this.RequireAll.Equals(other.RequireAll)
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
                
                if (this.DocumentId != null)
                    hash = hash * 57 + this.DocumentId.GetHashCode();
                
                if (this.RecipientId != null)
                    hash = hash * 57 + this.RecipientId.GetHashCode();
                
                if (this.ConditionalParentLabel != null)
                    hash = hash * 57 + this.ConditionalParentLabel.GetHashCode();
                
                if (this.ConditionalParentValue != null)
                    hash = hash * 57 + this.ConditionalParentValue.GetHashCode();
                
                if (this.GroupName != null)
                    hash = hash * 57 + this.GroupName.GetHashCode();
                
                if (this.Radios != null)
                    hash = hash * 57 + this.Radios.GetHashCode();
                
                if (this.Shared != null)
                    hash = hash * 57 + this.Shared.GetHashCode();
                
                if (this.RequireInitialOnSharedChange != null)
                    hash = hash * 57 + this.RequireInitialOnSharedChange.GetHashCode();
                
                if (this.RequireAll != null)
                    hash = hash * 57 + this.RequireAll.GetHashCode();
                
                return hash;
            }
        }

    }
}
