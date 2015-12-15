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
    public class DiagnosticsSettingsInformation : IEquatable<DiagnosticsSettingsInformation>
    {
        
        /// <summary>
        /// When set to **true**, enables API request logging for the user.
        /// </summary>
        /// <value>When set to **true**, enables API request logging for the user.</value>
        [DataMember(Name="apiRequestLogging", EmitDefaultValue=false)]
        public string ApiRequestLogging { get; set; }
  
        
        /// <summary>
        /// Specifies the maximum number of API requests to log.
        /// </summary>
        /// <value>Specifies the maximum number of API requests to log.</value>
        [DataMember(Name="apiRequestLogMaxEntries", EmitDefaultValue=false)]
        public string ApiRequestLogMaxEntries { get; set; }
  
        
        /// <summary>
        /// Indicates the remaining number of API requests that can be logged.
        /// </summary>
        /// <value>Indicates the remaining number of API requests that can be logged.</value>
        [DataMember(Name="apiRequestLogRemainingEntries", EmitDefaultValue=false)]
        public string ApiRequestLogRemainingEntries { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagnosticsSettingsInformation {\n");
            sb.Append("  ApiRequestLogging: ").Append(ApiRequestLogging).Append("\n");
            sb.Append("  ApiRequestLogMaxEntries: ").Append(ApiRequestLogMaxEntries).Append("\n");
            sb.Append("  ApiRequestLogRemainingEntries: ").Append(ApiRequestLogRemainingEntries).Append("\n");
            
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
            return this.Equals(obj as DiagnosticsSettingsInformation);
        }

        /// <summary>
        /// Returns true if DiagnosticsSettingsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of DiagnosticsSettingsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagnosticsSettingsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiRequestLogging == other.ApiRequestLogging ||
                    this.ApiRequestLogging != null &&
                    this.ApiRequestLogging.Equals(other.ApiRequestLogging)
                ) && 
                (
                    this.ApiRequestLogMaxEntries == other.ApiRequestLogMaxEntries ||
                    this.ApiRequestLogMaxEntries != null &&
                    this.ApiRequestLogMaxEntries.Equals(other.ApiRequestLogMaxEntries)
                ) && 
                (
                    this.ApiRequestLogRemainingEntries == other.ApiRequestLogRemainingEntries ||
                    this.ApiRequestLogRemainingEntries != null &&
                    this.ApiRequestLogRemainingEntries.Equals(other.ApiRequestLogRemainingEntries)
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
                
                if (this.ApiRequestLogging != null)
                    hash = hash * 57 + this.ApiRequestLogging.GetHashCode();
                
                if (this.ApiRequestLogMaxEntries != null)
                    hash = hash * 57 + this.ApiRequestLogMaxEntries.GetHashCode();
                
                if (this.ApiRequestLogRemainingEntries != null)
                    hash = hash * 57 + this.ApiRequestLogRemainingEntries.GetHashCode();
                
                return hash;
            }
        }

    }
}
