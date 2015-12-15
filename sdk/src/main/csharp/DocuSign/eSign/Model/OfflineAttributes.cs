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
    public class OfflineAttributes : IEquatable<OfflineAttributes>
    {
        
        /// <summary>
        /// A string containing information about the type of device used for offline signing.
        /// </summary>
        /// <value>A string containing information about the type of device used for offline signing.</value>
        [DataMember(Name="deviceName", EmitDefaultValue=false)]
        public string DeviceName { get; set; }
  
        
        /// <summary>
        /// A string containing information about the model of the device used for offline signing.
        /// </summary>
        /// <value>A string containing information about the model of the device used for offline signing.</value>
        [DataMember(Name="deviceModel", EmitDefaultValue=false)]
        public string DeviceModel { get; set; }
  
        
        /// <summary>
        /// A string containing the latitude of the device location at the time of signing.
        /// </summary>
        /// <value>A string containing the latitude of the device location at the time of signing.</value>
        [DataMember(Name="gpsLatitude", EmitDefaultValue=false)]
        public string GpsLatitude { get; set; }
  
        
        /// <summary>
        /// A string containing the longitude of the device location at the time of signing.
        /// </summary>
        /// <value>A string containing the longitude of the device location at the time of signing.</value>
        [DataMember(Name="gpsLongitude", EmitDefaultValue=false)]
        public string GpsLongitude { get; set; }
  
        
        /// <summary>
        /// A string with GUID of the account. This can be retrieved with the [ML:Get Disclosure] call.
        /// </summary>
        /// <value>A string with GUID of the account. This can be retrieved with the [ML:Get Disclosure] call.</value>
        [DataMember(Name="accountEsignId", EmitDefaultValue=false)]
        public string AccountEsignId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="offlineSigningHash", EmitDefaultValue=false)]
        public string OfflineSigningHash { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfflineAttributes {\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  GpsLatitude: ").Append(GpsLatitude).Append("\n");
            sb.Append("  GpsLongitude: ").Append(GpsLongitude).Append("\n");
            sb.Append("  AccountEsignId: ").Append(AccountEsignId).Append("\n");
            sb.Append("  OfflineSigningHash: ").Append(OfflineSigningHash).Append("\n");
            
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
            return this.Equals(obj as OfflineAttributes);
        }

        /// <summary>
        /// Returns true if OfflineAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of OfflineAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfflineAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeviceName == other.DeviceName ||
                    this.DeviceName != null &&
                    this.DeviceName.Equals(other.DeviceName)
                ) && 
                (
                    this.DeviceModel == other.DeviceModel ||
                    this.DeviceModel != null &&
                    this.DeviceModel.Equals(other.DeviceModel)
                ) && 
                (
                    this.GpsLatitude == other.GpsLatitude ||
                    this.GpsLatitude != null &&
                    this.GpsLatitude.Equals(other.GpsLatitude)
                ) && 
                (
                    this.GpsLongitude == other.GpsLongitude ||
                    this.GpsLongitude != null &&
                    this.GpsLongitude.Equals(other.GpsLongitude)
                ) && 
                (
                    this.AccountEsignId == other.AccountEsignId ||
                    this.AccountEsignId != null &&
                    this.AccountEsignId.Equals(other.AccountEsignId)
                ) && 
                (
                    this.OfflineSigningHash == other.OfflineSigningHash ||
                    this.OfflineSigningHash != null &&
                    this.OfflineSigningHash.Equals(other.OfflineSigningHash)
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
                
                if (this.DeviceName != null)
                    hash = hash * 57 + this.DeviceName.GetHashCode();
                
                if (this.DeviceModel != null)
                    hash = hash * 57 + this.DeviceModel.GetHashCode();
                
                if (this.GpsLatitude != null)
                    hash = hash * 57 + this.GpsLatitude.GetHashCode();
                
                if (this.GpsLongitude != null)
                    hash = hash * 57 + this.GpsLongitude.GetHashCode();
                
                if (this.AccountEsignId != null)
                    hash = hash * 57 + this.AccountEsignId.GetHashCode();
                
                if (this.OfflineSigningHash != null)
                    hash = hash * 57 + this.OfflineSigningHash.GetHashCode();
                
                return hash;
            }
        }

    }
}
