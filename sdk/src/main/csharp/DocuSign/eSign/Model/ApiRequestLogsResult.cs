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
    public class ApiRequestLogsResult : IEquatable<ApiRequestLogsResult>
    {
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="apiRequestLogs", EmitDefaultValue=false)]
        public List<ApiRequestLog> ApiRequestLogs { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiRequestLogsResult {\n");
            sb.Append("  ApiRequestLogs: ").Append(ApiRequestLogs).Append("\n");
            
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
            return this.Equals(obj as ApiRequestLogsResult);
        }

        /// <summary>
        /// Returns true if ApiRequestLogsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiRequestLogsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiRequestLogsResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiRequestLogs == other.ApiRequestLogs ||
                    this.ApiRequestLogs != null &&
                    this.ApiRequestLogs.SequenceEqual(other.ApiRequestLogs)
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
                
                if (this.ApiRequestLogs != null)
                    hash = hash * 57 + this.ApiRequestLogs.GetHashCode();
                
                return hash;
            }
        }

    }
}
