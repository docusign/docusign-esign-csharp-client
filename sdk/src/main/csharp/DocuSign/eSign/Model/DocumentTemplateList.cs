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
    public class DocumentTemplateList : IEquatable<DocumentTemplateList>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentTemplates", EmitDefaultValue=false)]
        public List<DocumentTemplate> DocumentTemplates { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTemplateList {\n");
            sb.Append("  DocumentTemplates: ").Append(DocumentTemplates).Append("\n");
            
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
            return this.Equals(obj as DocumentTemplateList);
        }

        /// <summary>
        /// Returns true if DocumentTemplateList instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentTemplateList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTemplateList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentTemplates == other.DocumentTemplates ||
                    this.DocumentTemplates != null &&
                    this.DocumentTemplates.SequenceEqual(other.DocumentTemplates)
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
                
                if (this.DocumentTemplates != null)
                    hash = hash * 57 + this.DocumentTemplates.GetHashCode();
                
                return hash;
            }
        }

    }
}
