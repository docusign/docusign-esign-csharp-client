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
    public class TemplateSummary : IEquatable<TemplateSummary>
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
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentName", EmitDefaultValue=false)]
        public string DocumentName { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="applied", EmitDefaultValue=false)]
        public string Applied { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TemplateMatch
        /// </summary>
        [DataMember(Name="templateMatch", EmitDefaultValue=false)]
        public TemplateMatch TemplateMatch { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSummary {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  Applied: ").Append(Applied).Append("\n");
            sb.Append("  TemplateMatch: ").Append(TemplateMatch).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            
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
            return this.Equals(obj as TemplateSummary);
        }

        /// <summary>
        /// Returns true if TemplateSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSummary other)
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
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.DocumentName == other.DocumentName ||
                    this.DocumentName != null &&
                    this.DocumentName.Equals(other.DocumentName)
                ) && 
                (
                    this.Applied == other.Applied ||
                    this.Applied != null &&
                    this.Applied.Equals(other.Applied)
                ) && 
                (
                    this.TemplateMatch == other.TemplateMatch ||
                    this.TemplateMatch != null &&
                    this.TemplateMatch.Equals(other.TemplateMatch)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                
                if (this.DocumentId != null)
                    hash = hash * 57 + this.DocumentId.GetHashCode();
                
                if (this.DocumentName != null)
                    hash = hash * 57 + this.DocumentName.GetHashCode();
                
                if (this.Applied != null)
                    hash = hash * 57 + this.Applied.GetHashCode();
                
                if (this.TemplateMatch != null)
                    hash = hash * 57 + this.TemplateMatch.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 57 + this.Uri.GetHashCode();
                
                return hash;
            }
        }

    }
}
