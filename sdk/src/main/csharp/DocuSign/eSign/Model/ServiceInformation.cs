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
    public class ServiceInformation : IEquatable<ServiceInformation>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="serviceVersions", EmitDefaultValue=false)]
        public List<ServiceVersion> ServiceVersions { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="buildVersion", EmitDefaultValue=false)]
        public string BuildVersion { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="buildBranch", EmitDefaultValue=false)]
        public string BuildBranch { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="buildSHA", EmitDefaultValue=false)]
        public string BuildSHA { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="buildBranchDeployedDateTime", EmitDefaultValue=false)]
        public string BuildBranchDeployedDateTime { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="linkedSites", EmitDefaultValue=false)]
        public List<string> LinkedSites { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceInformation {\n");
            sb.Append("  ServiceVersions: ").Append(ServiceVersions).Append("\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
            sb.Append("  BuildBranch: ").Append(BuildBranch).Append("\n");
            sb.Append("  BuildSHA: ").Append(BuildSHA).Append("\n");
            sb.Append("  BuildBranchDeployedDateTime: ").Append(BuildBranchDeployedDateTime).Append("\n");
            sb.Append("  LinkedSites: ").Append(LinkedSites).Append("\n");
            
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
            return this.Equals(obj as ServiceInformation);
        }

        /// <summary>
        /// Returns true if ServiceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServiceVersions == other.ServiceVersions ||
                    this.ServiceVersions != null &&
                    this.ServiceVersions.SequenceEqual(other.ServiceVersions)
                ) && 
                (
                    this.BuildVersion == other.BuildVersion ||
                    this.BuildVersion != null &&
                    this.BuildVersion.Equals(other.BuildVersion)
                ) && 
                (
                    this.BuildBranch == other.BuildBranch ||
                    this.BuildBranch != null &&
                    this.BuildBranch.Equals(other.BuildBranch)
                ) && 
                (
                    this.BuildSHA == other.BuildSHA ||
                    this.BuildSHA != null &&
                    this.BuildSHA.Equals(other.BuildSHA)
                ) && 
                (
                    this.BuildBranchDeployedDateTime == other.BuildBranchDeployedDateTime ||
                    this.BuildBranchDeployedDateTime != null &&
                    this.BuildBranchDeployedDateTime.Equals(other.BuildBranchDeployedDateTime)
                ) && 
                (
                    this.LinkedSites == other.LinkedSites ||
                    this.LinkedSites != null &&
                    this.LinkedSites.SequenceEqual(other.LinkedSites)
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
                
                if (this.ServiceVersions != null)
                    hash = hash * 57 + this.ServiceVersions.GetHashCode();
                
                if (this.BuildVersion != null)
                    hash = hash * 57 + this.BuildVersion.GetHashCode();
                
                if (this.BuildBranch != null)
                    hash = hash * 57 + this.BuildBranch.GetHashCode();
                
                if (this.BuildSHA != null)
                    hash = hash * 57 + this.BuildSHA.GetHashCode();
                
                if (this.BuildBranchDeployedDateTime != null)
                    hash = hash * 57 + this.BuildBranchDeployedDateTime.GetHashCode();
                
                if (this.LinkedSites != null)
                    hash = hash * 57 + this.LinkedSites.GetHashCode();
                
                return hash;
            }
        }

    }
}
