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
    public class Folder : IEquatable<Folder>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ownerUserName", EmitDefaultValue=false)]
        public string OwnerUserName { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ownerEmail", EmitDefaultValue=false)]
        public string OwnerEmail { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ownerUserId", EmitDefaultValue=false)]
        public string OwnerUserId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="parentFolderId", EmitDefaultValue=false)]
        public string ParentFolderId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="parentFolderUri", EmitDefaultValue=false)]
        public string ParentFolderUri { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
  
        
        /// <summary>
        /// A collection of folder objects returned in a response.
        /// </summary>
        /// <value>A collection of folder objects returned in a response.</value>
        [DataMember(Name="folders", EmitDefaultValue=false)]
        public List<Folder> Folders { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public Filter Filter { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Folder {\n");
            sb.Append("  OwnerUserName: ").Append(OwnerUserName).Append("\n");
            sb.Append("  OwnerEmail: ").Append(OwnerEmail).Append("\n");
            sb.Append("  OwnerUserId: ").Append(OwnerUserId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
            sb.Append("  ParentFolderUri: ").Append(ParentFolderUri).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            
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
            return this.Equals(obj as Folder);
        }

        /// <summary>
        /// Returns true if Folder instances are equal
        /// </summary>
        /// <param name="other">Instance of Folder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Folder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OwnerUserName == other.OwnerUserName ||
                    this.OwnerUserName != null &&
                    this.OwnerUserName.Equals(other.OwnerUserName)
                ) && 
                (
                    this.OwnerEmail == other.OwnerEmail ||
                    this.OwnerEmail != null &&
                    this.OwnerEmail.Equals(other.OwnerEmail)
                ) && 
                (
                    this.OwnerUserId == other.OwnerUserId ||
                    this.OwnerUserId != null &&
                    this.OwnerUserId.Equals(other.OwnerUserId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.ParentFolderId == other.ParentFolderId ||
                    this.ParentFolderId != null &&
                    this.ParentFolderId.Equals(other.ParentFolderId)
                ) && 
                (
                    this.ParentFolderUri == other.ParentFolderUri ||
                    this.ParentFolderUri != null &&
                    this.ParentFolderUri.Equals(other.ParentFolderUri)
                ) && 
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Folders == other.Folders ||
                    this.Folders != null &&
                    this.Folders.SequenceEqual(other.Folders)
                ) && 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
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
                
                if (this.OwnerUserName != null)
                    hash = hash * 57 + this.OwnerUserName.GetHashCode();
                
                if (this.OwnerEmail != null)
                    hash = hash * 57 + this.OwnerEmail.GetHashCode();
                
                if (this.OwnerUserId != null)
                    hash = hash * 57 + this.OwnerUserId.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 57 + this.Uri.GetHashCode();
                
                if (this.ParentFolderId != null)
                    hash = hash * 57 + this.ParentFolderId.GetHashCode();
                
                if (this.ParentFolderUri != null)
                    hash = hash * 57 + this.ParentFolderUri.GetHashCode();
                
                if (this.FolderId != null)
                    hash = hash * 57 + this.FolderId.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                if (this.Folders != null)
                    hash = hash * 57 + this.Folders.GetHashCode();
                
                if (this.Filter != null)
                    hash = hash * 57 + this.Filter.GetHashCode();
                
                return hash;
            }
        }

    }
}
