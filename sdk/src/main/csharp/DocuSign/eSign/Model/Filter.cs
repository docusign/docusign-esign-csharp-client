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
    public class Filter : IEquatable<Filter>
    {
        
        /// <summary>
        /// Access token information.
        /// </summary>
        /// <value>Access token information.</value>
        [DataMember(Name="actionRequired", EmitDefaultValue=false)]
        public string ActionRequired { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public string Expires { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isTemplate", EmitDefaultValue=false)]
        public string IsTemplate { get; set; }
  
        
        /// <summary>
        /// Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="fromDateTime", EmitDefaultValue=false)]
        public string FromDateTime { get; set; }
  
        
        /// <summary>
        /// Must be set to \"bearer\".
        /// </summary>
        /// <value>Must be set to \"bearer\".</value>
        [DataMember(Name="toDateTime", EmitDefaultValue=false)]
        public string ToDateTime { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="searchTarget", EmitDefaultValue=false)]
        public string SearchTarget { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="searchText", EmitDefaultValue=false)]
        public string SearchText { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="folderIds", EmitDefaultValue=false)]
        public string FolderIds { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public string OrderBy { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Filter {\n");
            sb.Append("  ActionRequired: ").Append(ActionRequired).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  IsTemplate: ").Append(IsTemplate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FromDateTime: ").Append(FromDateTime).Append("\n");
            sb.Append("  ToDateTime: ").Append(ToDateTime).Append("\n");
            sb.Append("  SearchTarget: ").Append(SearchTarget).Append("\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            
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
            return this.Equals(obj as Filter);
        }

        /// <summary>
        /// Returns true if Filter instances are equal
        /// </summary>
        /// <param name="other">Instance of Filter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Filter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActionRequired == other.ActionRequired ||
                    this.ActionRequired != null &&
                    this.ActionRequired.Equals(other.ActionRequired)
                ) && 
                (
                    this.Expires == other.Expires ||
                    this.Expires != null &&
                    this.Expires.Equals(other.Expires)
                ) && 
                (
                    this.IsTemplate == other.IsTemplate ||
                    this.IsTemplate != null &&
                    this.IsTemplate.Equals(other.IsTemplate)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.FromDateTime == other.FromDateTime ||
                    this.FromDateTime != null &&
                    this.FromDateTime.Equals(other.FromDateTime)
                ) && 
                (
                    this.ToDateTime == other.ToDateTime ||
                    this.ToDateTime != null &&
                    this.ToDateTime.Equals(other.ToDateTime)
                ) && 
                (
                    this.SearchTarget == other.SearchTarget ||
                    this.SearchTarget != null &&
                    this.SearchTarget.Equals(other.SearchTarget)
                ) && 
                (
                    this.SearchText == other.SearchText ||
                    this.SearchText != null &&
                    this.SearchText.Equals(other.SearchText)
                ) && 
                (
                    this.FolderIds == other.FolderIds ||
                    this.FolderIds != null &&
                    this.FolderIds.Equals(other.FolderIds)
                ) && 
                (
                    this.OrderBy == other.OrderBy ||
                    this.OrderBy != null &&
                    this.OrderBy.Equals(other.OrderBy)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
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
                
                if (this.ActionRequired != null)
                    hash = hash * 57 + this.ActionRequired.GetHashCode();
                
                if (this.Expires != null)
                    hash = hash * 57 + this.Expires.GetHashCode();
                
                if (this.IsTemplate != null)
                    hash = hash * 57 + this.IsTemplate.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.FromDateTime != null)
                    hash = hash * 57 + this.FromDateTime.GetHashCode();
                
                if (this.ToDateTime != null)
                    hash = hash * 57 + this.ToDateTime.GetHashCode();
                
                if (this.SearchTarget != null)
                    hash = hash * 57 + this.SearchTarget.GetHashCode();
                
                if (this.SearchText != null)
                    hash = hash * 57 + this.SearchText.GetHashCode();
                
                if (this.FolderIds != null)
                    hash = hash * 57 + this.FolderIds.GetHashCode();
                
                if (this.OrderBy != null)
                    hash = hash * 57 + this.OrderBy.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 57 + this.Order.GetHashCode();
                
                return hash;
            }
        }

    }
}
