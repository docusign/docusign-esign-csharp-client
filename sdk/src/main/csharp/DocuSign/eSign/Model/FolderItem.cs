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
    public class FolderItem : IEquatable<FolderItem>
    {
        
        /// <summary>
        /// Name of the envelope owner.
        /// </summary>
        /// <value>Name of the envelope owner.</value>
        [DataMember(Name="ownerName", EmitDefaultValue=false)]
        public string OwnerName { get; set; }
  
        
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
  
        
        /// <summary>
        /// Contains a URI for an endpoint that you can use to retrieve the envelope or envelopes.
        /// </summary>
        /// <value>Contains a URI for an endpoint that you can use to retrieve the envelope or envelopes.</value>
        [DataMember(Name="envelopeUri", EmitDefaultValue=false)]
        public string EnvelopeUri { get; set; }
  
        
        /// <summary>
        /// Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Name of the envelope sender.
        /// </summary>
        /// <value>Name of the envelope sender.</value>
        [DataMember(Name="senderName", EmitDefaultValue=false)]
        public string SenderName { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="senderEmail", EmitDefaultValue=false)]
        public string SenderEmail { get; set; }
  
        
        /// <summary>
        /// Indicates the date and time the item was created.
        /// </summary>
        /// <value>Indicates the date and time the item was created.</value>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public string CreatedDateTime { get; set; }
  
        
        /// <summary>
        /// The date and time the envelope was sent.
        /// </summary>
        /// <value>The date and time the envelope was sent.</value>
        [DataMember(Name="sentDateTime", EmitDefaultValue=false)]
        public string SentDateTime { get; set; }
  
        
        /// <summary>
        /// Specifies the date and time this item was completed.
        /// </summary>
        /// <value>Specifies the date and time this item was completed.</value>
        [DataMember(Name="completedDateTime", EmitDefaultValue=false)]
        public string CompletedDateTime { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
  
        
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
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// When set to **true**, indicates that this module is enabled on the account.
        /// </summary>
        /// <value>When set to **true**, indicates that this module is enabled on the account.</value>
        [DataMember(Name="is21CFRPart11", EmitDefaultValue=false)]
        public string Is21CFRPart11 { get; set; }
  
        
        /// <summary>
        /// An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters.
        /// </summary>
        /// <value>An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public List<CustomFieldV2> CustomFields { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderItem {\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  EnvelopeUri: ").Append(EnvelopeUri).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  SentDateTime: ").Append(SentDateTime).Append("\n");
            sb.Append("  CompletedDateTime: ").Append(CompletedDateTime).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Is21CFRPart11: ").Append(Is21CFRPart11).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            
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
            return this.Equals(obj as FolderItem);
        }

        /// <summary>
        /// Returns true if FolderItem instances are equal
        /// </summary>
        /// <param name="other">Instance of FolderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OwnerName == other.OwnerName ||
                    this.OwnerName != null &&
                    this.OwnerName.Equals(other.OwnerName)
                ) && 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.EnvelopeUri == other.EnvelopeUri ||
                    this.EnvelopeUri != null &&
                    this.EnvelopeUri.Equals(other.EnvelopeUri)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SenderName == other.SenderName ||
                    this.SenderName != null &&
                    this.SenderName.Equals(other.SenderName)
                ) && 
                (
                    this.SenderEmail == other.SenderEmail ||
                    this.SenderEmail != null &&
                    this.SenderEmail.Equals(other.SenderEmail)
                ) && 
                (
                    this.CreatedDateTime == other.CreatedDateTime ||
                    this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(other.CreatedDateTime)
                ) && 
                (
                    this.SentDateTime == other.SentDateTime ||
                    this.SentDateTime != null &&
                    this.SentDateTime.Equals(other.SentDateTime)
                ) && 
                (
                    this.CompletedDateTime == other.CompletedDateTime ||
                    this.CompletedDateTime != null &&
                    this.CompletedDateTime.Equals(other.CompletedDateTime)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
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
                    this.Is21CFRPart11 == other.Is21CFRPart11 ||
                    this.Is21CFRPart11 != null &&
                    this.Is21CFRPart11.Equals(other.Is21CFRPart11)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
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
                
                if (this.OwnerName != null)
                    hash = hash * 57 + this.OwnerName.GetHashCode();
                
                if (this.EnvelopeId != null)
                    hash = hash * 57 + this.EnvelopeId.GetHashCode();
                
                if (this.EnvelopeUri != null)
                    hash = hash * 57 + this.EnvelopeUri.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.SenderName != null)
                    hash = hash * 57 + this.SenderName.GetHashCode();
                
                if (this.SenderEmail != null)
                    hash = hash * 57 + this.SenderEmail.GetHashCode();
                
                if (this.CreatedDateTime != null)
                    hash = hash * 57 + this.CreatedDateTime.GetHashCode();
                
                if (this.SentDateTime != null)
                    hash = hash * 57 + this.SentDateTime.GetHashCode();
                
                if (this.CompletedDateTime != null)
                    hash = hash * 57 + this.CompletedDateTime.GetHashCode();
                
                if (this.Subject != null)
                    hash = hash * 57 + this.Subject.GetHashCode();
                
                if (this.TemplateId != null)
                    hash = hash * 57 + this.TemplateId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Shared != null)
                    hash = hash * 57 + this.Shared.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 57 + this.Password.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.LastModified != null)
                    hash = hash * 57 + this.LastModified.GetHashCode();
                
                if (this.PageCount != null)
                    hash = hash * 57 + this.PageCount.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 57 + this.Uri.GetHashCode();
                
                if (this.Is21CFRPart11 != null)
                    hash = hash * 57 + this.Is21CFRPart11.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 57 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
