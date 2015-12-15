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
    public class EnvelopeTemplateDefinition : IEquatable<EnvelopeTemplateDefinition>
    {
        
        /// <summary>
        /// The unique identifier of the template. If this is not provided, DocuSign will generate a value.
        /// </summary>
        /// <value>The unique identifier of the template. If this is not provided, DocuSign will generate a value.</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
        public UserInfo LastModifiedBy { get; set; }
  
        
        /// <summary>
        /// An integer value specifying the number of document pages in the template. Omit this property if not submitting a page count.
        /// </summary>
        /// <value>An integer value specifying the number of document pages in the template. Omit this property if not submitting a page count.</value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// The name of the folder in which the template is located.
        /// </summary>
        /// <value>The name of the folder in which the template is located.</value>
        [DataMember(Name="folderName", EmitDefaultValue=false)]
        public string FolderName { get; set; }
  
        
        /// <summary>
        /// The ID for the folder.
        /// </summary>
        /// <value>The ID for the folder.</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }
  
        
        /// <summary>
        /// The URI of the folder.
        /// </summary>
        /// <value>The URI of the folder.</value>
        [DataMember(Name="folderUri", EmitDefaultValue=false)]
        public string FolderUri { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="parentFolderUri", EmitDefaultValue=false)]
        public string ParentFolderUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public UserInfo Owner { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeTemplateDefinition {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  FolderName: ").Append(FolderName).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  FolderUri: ").Append(FolderUri).Append("\n");
            sb.Append("  ParentFolderUri: ").Append(ParentFolderUri).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            
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
            return this.Equals(obj as EnvelopeTemplateDefinition);
        }

        /// <summary>
        /// Returns true if EnvelopeTemplateDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeTemplateDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeTemplateDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.NewPassword == other.NewPassword ||
                    this.NewPassword != null &&
                    this.NewPassword.Equals(other.NewPassword)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.LastModifiedBy == other.LastModifiedBy ||
                    this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(other.LastModifiedBy)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.FolderName == other.FolderName ||
                    this.FolderName != null &&
                    this.FolderName.Equals(other.FolderName)
                ) && 
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.FolderUri == other.FolderUri ||
                    this.FolderUri != null &&
                    this.FolderUri.Equals(other.FolderUri)
                ) && 
                (
                    this.ParentFolderUri == other.ParentFolderUri ||
                    this.ParentFolderUri != null &&
                    this.ParentFolderUri.Equals(other.ParentFolderUri)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
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
                
                if (this.TemplateId != null)
                    hash = hash * 57 + this.TemplateId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Shared != null)
                    hash = hash * 57 + this.Shared.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 57 + this.Password.GetHashCode();
                
                if (this.NewPassword != null)
                    hash = hash * 57 + this.NewPassword.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.LastModified != null)
                    hash = hash * 57 + this.LastModified.GetHashCode();
                
                if (this.LastModifiedBy != null)
                    hash = hash * 57 + this.LastModifiedBy.GetHashCode();
                
                if (this.PageCount != null)
                    hash = hash * 57 + this.PageCount.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 57 + this.Uri.GetHashCode();
                
                if (this.FolderName != null)
                    hash = hash * 57 + this.FolderName.GetHashCode();
                
                if (this.FolderId != null)
                    hash = hash * 57 + this.FolderId.GetHashCode();
                
                if (this.FolderUri != null)
                    hash = hash * 57 + this.FolderUri.GetHashCode();
                
                if (this.ParentFolderUri != null)
                    hash = hash * 57 + this.ParentFolderUri.GetHashCode();
                
                if (this.Owner != null)
                    hash = hash * 57 + this.Owner.GetHashCode();
                
                return hash;
            }
        }

    }
}
