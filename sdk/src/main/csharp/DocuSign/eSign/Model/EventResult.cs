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
    public class EventResult : IEquatable<EventResult>
    {
        
        /// <summary>
        /// Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="eventTimestamp", EmitDefaultValue=false)]
        public string EventTimestamp { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="failureDescription", EmitDefaultValue=false)]
        public string FailureDescription { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="vendorFailureStatusCode", EmitDefaultValue=false)]
        public string VendorFailureStatusCode { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventResult {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventTimestamp: ").Append(EventTimestamp).Append("\n");
            sb.Append("  FailureDescription: ").Append(FailureDescription).Append("\n");
            sb.Append("  VendorFailureStatusCode: ").Append(VendorFailureStatusCode).Append("\n");
            
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
            return this.Equals(obj as EventResult);
        }

        /// <summary>
        /// Returns true if EventResult instances are equal
        /// </summary>
        /// <param name="other">Instance of EventResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.EventTimestamp == other.EventTimestamp ||
                    this.EventTimestamp != null &&
                    this.EventTimestamp.Equals(other.EventTimestamp)
                ) && 
                (
                    this.FailureDescription == other.FailureDescription ||
                    this.FailureDescription != null &&
                    this.FailureDescription.Equals(other.FailureDescription)
                ) && 
                (
                    this.VendorFailureStatusCode == other.VendorFailureStatusCode ||
                    this.VendorFailureStatusCode != null &&
                    this.VendorFailureStatusCode.Equals(other.VendorFailureStatusCode)
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
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.EventTimestamp != null)
                    hash = hash * 57 + this.EventTimestamp.GetHashCode();
                
                if (this.FailureDescription != null)
                    hash = hash * 57 + this.FailureDescription.GetHashCode();
                
                if (this.VendorFailureStatusCode != null)
                    hash = hash * 57 + this.VendorFailureStatusCode.GetHashCode();
                
                return hash;
            }
        }

    }
}
