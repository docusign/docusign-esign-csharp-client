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
    public class CompositeTemplate : IEquatable<CompositeTemplate>
    {
        
        /// <summary>
        /// Specifies the identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the composite template ID to which the document should be added. If composite template ID is not specified in the content-disposition, the document is applied based on the value of the `documentId` property only. If no document object is specified, the composite template inherits the first document.
        /// </summary>
        /// <value>Specifies the identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the composite template ID to which the document should be added. If composite template ID is not specified in the content-disposition, the document is applied based on the value of the `documentId` property only. If no document object is specified, the composite template inherits the first document.</value>
        [DataMember(Name="compositeTemplateId", EmitDefaultValue=false)]
        public string CompositeTemplateId { get; set; }
  
        
        /// <summary>
        /// 0 or more server-side templates and their position in the overlay. If supplied, they are overlaid into the envelope in the order of their Sequence value
        /// </summary>
        /// <value>0 or more server-side templates and their position in the overlay. If supplied, they are overlaid into the envelope in the order of their Sequence value</value>
        [DataMember(Name="serverTemplates", EmitDefaultValue=false)]
        public List<ServerTemplate> ServerTemplates { get; set; }
  
        
        /// <summary>
        /// Zero or more inline templates and their position in the overlay. If supplied, they are overlaid into the envelope in the order of their Sequence value.
        /// </summary>
        /// <value>Zero or more inline templates and their position in the overlay. If supplied, they are overlaid into the envelope in the order of their Sequence value.</value>
        [DataMember(Name="inlineTemplates", EmitDefaultValue=false)]
        public List<InlineTemplate> InlineTemplates { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pdfMetaDataTemplateSequence", EmitDefaultValue=false)]
        public string PdfMetaDataTemplateSequence { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public Document Document { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompositeTemplate {\n");
            sb.Append("  CompositeTemplateId: ").Append(CompositeTemplateId).Append("\n");
            sb.Append("  ServerTemplates: ").Append(ServerTemplates).Append("\n");
            sb.Append("  InlineTemplates: ").Append(InlineTemplates).Append("\n");
            sb.Append("  PdfMetaDataTemplateSequence: ").Append(PdfMetaDataTemplateSequence).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            
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
            return this.Equals(obj as CompositeTemplate);
        }

        /// <summary>
        /// Returns true if CompositeTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of CompositeTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompositeTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompositeTemplateId == other.CompositeTemplateId ||
                    this.CompositeTemplateId != null &&
                    this.CompositeTemplateId.Equals(other.CompositeTemplateId)
                ) && 
                (
                    this.ServerTemplates == other.ServerTemplates ||
                    this.ServerTemplates != null &&
                    this.ServerTemplates.SequenceEqual(other.ServerTemplates)
                ) && 
                (
                    this.InlineTemplates == other.InlineTemplates ||
                    this.InlineTemplates != null &&
                    this.InlineTemplates.SequenceEqual(other.InlineTemplates)
                ) && 
                (
                    this.PdfMetaDataTemplateSequence == other.PdfMetaDataTemplateSequence ||
                    this.PdfMetaDataTemplateSequence != null &&
                    this.PdfMetaDataTemplateSequence.Equals(other.PdfMetaDataTemplateSequence)
                ) && 
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
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
                
                if (this.CompositeTemplateId != null)
                    hash = hash * 57 + this.CompositeTemplateId.GetHashCode();
                
                if (this.ServerTemplates != null)
                    hash = hash * 57 + this.ServerTemplates.GetHashCode();
                
                if (this.InlineTemplates != null)
                    hash = hash * 57 + this.InlineTemplates.GetHashCode();
                
                if (this.PdfMetaDataTemplateSequence != null)
                    hash = hash * 57 + this.PdfMetaDataTemplateSequence.GetHashCode();
                
                if (this.Document != null)
                    hash = hash * 57 + this.Document.GetHashCode();
                
                return hash;
            }
        }

    }
}
