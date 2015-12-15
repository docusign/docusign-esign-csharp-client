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
    public class ServiceVersion : IEquatable<ServiceVersion>
    {
        
        /// <summary>
        /// The version of the rest API.
        /// </summary>
        /// <value>The version of the rest API.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="versionUrl", EmitDefaultValue=false)]
        public string VersionUrl { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceVersion {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  VersionUrl: ").Append(VersionUrl).Append("\n");
            
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
            return this.Equals(obj as ServiceVersion);
        }

        /// <summary>
        /// Returns true if ServiceVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceVersion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.VersionUrl == other.VersionUrl ||
                    this.VersionUrl != null &&
                    this.VersionUrl.Equals(other.VersionUrl)
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
                
                if (this.Version != null)
                    hash = hash * 57 + this.Version.GetHashCode();
                
                if (this.VersionUrl != null)
                    hash = hash * 57 + this.VersionUrl.GetHashCode();
                
                return hash;
            }
        }

    }
}
