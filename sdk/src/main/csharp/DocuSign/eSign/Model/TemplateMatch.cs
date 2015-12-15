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
    public class TemplateMatch : IEquatable<TemplateMatch>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="matchPercentage", EmitDefaultValue=false)]
        public string MatchPercentage { get; set; }
  
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateMatch {\n");
            sb.Append("  MatchPercentage: ").Append(MatchPercentage).Append("\n");
            sb.Append("  DocumentStartPage: ").Append(DocumentStartPage).Append("\n");
            sb.Append("  DocumentEndPage: ").Append(DocumentEndPage).Append("\n");
            
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
            return this.Equals(obj as TemplateMatch);
        }

        /// <summary>
        /// Returns true if TemplateMatch instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateMatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateMatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MatchPercentage == other.MatchPercentage ||
                    this.MatchPercentage != null &&
                    this.MatchPercentage.Equals(other.MatchPercentage)
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
                
                if (this.MatchPercentage != null)
                    hash = hash * 57 + this.MatchPercentage.GetHashCode();
                
                if (this.DocumentStartPage != null)
                    hash = hash * 57 + this.DocumentStartPage.GetHashCode();
                
                if (this.DocumentEndPage != null)
                    hash = hash * 57 + this.DocumentEndPage.GetHashCode();
                
                return hash;
            }
        }

    }
}
