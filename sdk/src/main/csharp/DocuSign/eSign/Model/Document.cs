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
    public class Document : IEquatable<Document>
    {
        
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
        /// <summary>
        /// The file id from the cloud storage service where the document is located. This information is returned using [ML:GET /folders] or [ML:/folders/{folderid}].
        /// </summary>
        /// <value>The file id from the cloud storage service where the document is located. This information is returned using [ML:GET /folders] or [ML:/folders/{folderid}].</value>
        [DataMember(Name="remoteUrl", EmitDefaultValue=false)]
        public string RemoteUrl { get; set; }
  
        
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
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
  
        
        /// <summary>
        /// When set to **true**, PDF form field data is transformed into document tab values when the PDF form field name matches the DocuSign custom tab tabLabel. The resulting PDF form data is also returned in the PDF meta data when requesting the document PDF. See the [ML:Transform PDF Fields] section for more information about how fields are transformed into DocuSign tabs.
        /// </summary>
        /// <value>When set to **true**, PDF form field data is transformed into document tab values when the PDF form field name matches the DocuSign custom tab tabLabel. The resulting PDF form data is also returned in the PDF meta data when requesting the document PDF. See the [ML:Transform PDF Fields] section for more information about how fields are transformed into DocuSign tabs.</value>
        [DataMember(Name="transformPdfFields", EmitDefaultValue=false)]
        public string TransformPdfFields { get; set; }
  
        
        /// <summary>
        /// The file extension type of the document. If the document is not a PDF it is converted to a PDF.
        /// </summary>
        /// <value>The file extension type of the document. If the document is not a PDF it is converted to a PDF.</value>
        [DataMember(Name="fileExtension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }
  
        
        /// <summary>
        /// Matchboxes define areas in a document for document matching when you are creating envelopes. They are only used when you upload and edit a template. \n\nA matchbox consists of 5 elements:\n\n* pageNumber - The document page number  on which the matchbox will appear. \n* xPosition - The x position of the matchbox on a page. \n* yPosition - The y position of the matchbox on a page.\n* width - The width of the matchbox. \n* height - The height of the matchbox.
        /// </summary>
        /// <value>Matchboxes define areas in a document for document matching when you are creating envelopes. They are only used when you upload and edit a template. \n\nA matchbox consists of 5 elements:\n\n* pageNumber - The document page number  on which the matchbox will appear. \n* xPosition - The x position of the matchbox on a page. \n* yPosition - The y position of the matchbox on a page.\n* width - The width of the matchbox. \n* height - The height of the matchbox.</value>
        [DataMember(Name="matchBoxes", EmitDefaultValue=false)]
        public List<MatchBox> MatchBoxes { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public string Pages { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentFields", EmitDefaultValue=false)]
        public List<NameValue> DocumentFields { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the document is been already encrypted by the sender for use with the DocuSign Key Manager Security Appliance.
        /// </summary>
        /// <value>When set to **true**, the document is been already encrypted by the sender for use with the DocuSign Key Manager Security Appliance.</value>
        [DataMember(Name="encryptedWithKeyManager", EmitDefaultValue=false)]
        public string EncryptedWithKeyManager { get; set; }
  
        
        /// <summary>
        /// The document byte stream. This allows putting a base64 version of document bytes into an envelope.
        /// </summary>
        /// <value>The document byte stream. This allows putting a base64 version of document bytes into an envelope.</value>
        [DataMember(Name="documentBase64", EmitDefaultValue=false)]
        public string DocumentBase64 { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="applyAnchorTabs", EmitDefaultValue=false)]
        public string ApplyAnchorTabs { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  RemoteUrl: ").Append(RemoteUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  TransformPdfFields: ").Append(TransformPdfFields).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  MatchBoxes: ").Append(MatchBoxes).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  DocumentFields: ").Append(DocumentFields).Append("\n");
            sb.Append("  EncryptedWithKeyManager: ").Append(EncryptedWithKeyManager).Append("\n");
            sb.Append("  DocumentBase64: ").Append(DocumentBase64).Append("\n");
            sb.Append("  ApplyAnchorTabs: ").Append(ApplyAnchorTabs).Append("\n");
            
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
            return this.Equals(obj as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="other">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document other)
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
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.RemoteUrl == other.RemoteUrl ||
                    this.RemoteUrl != null &&
                    this.RemoteUrl.Equals(other.RemoteUrl)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.TransformPdfFields == other.TransformPdfFields ||
                    this.TransformPdfFields != null &&
                    this.TransformPdfFields.Equals(other.TransformPdfFields)
                ) && 
                (
                    this.FileExtension == other.FileExtension ||
                    this.FileExtension != null &&
                    this.FileExtension.Equals(other.FileExtension)
                ) && 
                (
                    this.MatchBoxes == other.MatchBoxes ||
                    this.MatchBoxes != null &&
                    this.MatchBoxes.SequenceEqual(other.MatchBoxes)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.Pages == other.Pages ||
                    this.Pages != null &&
                    this.Pages.Equals(other.Pages)
                ) && 
                (
                    this.DocumentFields == other.DocumentFields ||
                    this.DocumentFields != null &&
                    this.DocumentFields.SequenceEqual(other.DocumentFields)
                ) && 
                (
                    this.EncryptedWithKeyManager == other.EncryptedWithKeyManager ||
                    this.EncryptedWithKeyManager != null &&
                    this.EncryptedWithKeyManager.Equals(other.EncryptedWithKeyManager)
                ) && 
                (
                    this.DocumentBase64 == other.DocumentBase64 ||
                    this.DocumentBase64 != null &&
                    this.DocumentBase64.Equals(other.DocumentBase64)
                ) && 
                (
                    this.ApplyAnchorTabs == other.ApplyAnchorTabs ||
                    this.ApplyAnchorTabs != null &&
                    this.ApplyAnchorTabs.Equals(other.ApplyAnchorTabs)
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
                
                if (this.Uri != null)
                    hash = hash * 57 + this.Uri.GetHashCode();
                
                if (this.RemoteUrl != null)
                    hash = hash * 57 + this.RemoteUrl.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 57 + this.Password.GetHashCode();
                
                if (this.TransformPdfFields != null)
                    hash = hash * 57 + this.TransformPdfFields.GetHashCode();
                
                if (this.FileExtension != null)
                    hash = hash * 57 + this.FileExtension.GetHashCode();
                
                if (this.MatchBoxes != null)
                    hash = hash * 57 + this.MatchBoxes.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 57 + this.Order.GetHashCode();
                
                if (this.Pages != null)
                    hash = hash * 57 + this.Pages.GetHashCode();
                
                if (this.DocumentFields != null)
                    hash = hash * 57 + this.DocumentFields.GetHashCode();
                
                if (this.EncryptedWithKeyManager != null)
                    hash = hash * 57 + this.EncryptedWithKeyManager.GetHashCode();
                
                if (this.DocumentBase64 != null)
                    hash = hash * 57 + this.DocumentBase64.GetHashCode();
                
                if (this.ApplyAnchorTabs != null)
                    hash = hash * 57 + this.ApplyAnchorTabs.GetHashCode();
                
                return hash;
            }
        }

    }
}
