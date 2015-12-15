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
    public class TabMetadataList : IEquatable<TabMetadataList>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="tabs", EmitDefaultValue=false)]
        public List<TabMetadata> Tabs { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TabMetadataList {\n");
            sb.Append("  Tabs: ").Append(Tabs).Append("\n");
            
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
            return this.Equals(obj as TabMetadataList);
        }

        /// <summary>
        /// Returns true if TabMetadataList instances are equal
        /// </summary>
        /// <param name="other">Instance of TabMetadataList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TabMetadataList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Tabs == other.Tabs ||
                    this.Tabs != null &&
                    this.Tabs.SequenceEqual(other.Tabs)
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
                
                if (this.Tabs != null)
                    hash = hash * 57 + this.Tabs.GetHashCode();
                
                return hash;
            }
        }

    }
}
