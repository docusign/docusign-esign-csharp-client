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
    public class PageRequest : IEquatable<PageRequest>
    {
        
        /// <summary>
        /// Sets the direction the page image is rotated. The possible settings are: left or right
        /// </summary>
        /// <value>Sets the direction the page image is rotated. The possible settings are: left or right</value>
        [DataMember(Name="rotate", EmitDefaultValue=false)]
        public string Rotate { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageRequest {\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            
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
            return this.Equals(obj as PageRequest);
        }

        /// <summary>
        /// Returns true if PageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rotate == other.Rotate ||
                    this.Rotate != null &&
                    this.Rotate.Equals(other.Rotate)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
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
                
                if (this.Rotate != null)
                    hash = hash * 57 + this.Rotate.GetHashCode();
                
                if (this.Password != null)
                    hash = hash * 57 + this.Password.GetHashCode();
                
                return hash;
            }
        }

    }
}
