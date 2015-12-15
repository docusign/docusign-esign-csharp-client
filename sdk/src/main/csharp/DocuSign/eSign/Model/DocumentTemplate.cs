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
    public class DocumentTemplate : IEquatable<DocumentTemplate>
    {
        
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
  
        
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
        [DataMember(Name="documentStartPage", EmitDefaultValue=false)]
        public string DocumentStartPage { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentEndPage", EmitDefaultValue=false)]
        public string DocumentEndPage { get; set; }
  
        
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
            sb.Append("class DocumentTemplate {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  DocumentStartPage: ").Append(DocumentStartPage).Append("\n");
            sb.Append("  DocumentEndPage: ").Append(DocumentEndPage).Append("\n");
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
            return this.Equals(obj as DocumentTemplate);
        }

        /// <summary>
        /// Returns true if DocumentTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTemplate other)
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
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.DocumentStartPage == other.DocumentStartPage ||
                    this.DocumentStartPage != null &&
                    this.DocumentStartPage.Equals(other.DocumentStartPage)
                ) && 
                (
                    this.DocumentEndPage == other.DocumentEndPage ||
                    this.DocumentEndPage != null &&
                    this.DocumentEndPage.Equals(other.DocumentEndPage)
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
                
                if (this.DocumentId != null)
                    hash = hash * 57 + this.DocumentId.GetHashCode();
                
                if (this.TemplateId != null)
                    hash = hash * 57 + this.TemplateId.GetHashCode();
                
                if (this.DocumentStartPage != null)
                    hash = hash * 57 + this.DocumentStartPage.GetHashCode();
                
                if (this.DocumentEndPage != null)
                    hash = hash * 57 + this.DocumentEndPage.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
