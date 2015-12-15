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
    public class EnvelopesInformation : IEquatable<EnvelopesInformation>
    {
        
        /// <summary>
        /// The number of results returned in this response.
        /// </summary>
        /// <value>The number of results returned in this response.</value>
        [DataMember(Name="resultSetSize", EmitDefaultValue=false)]
        public string ResultSetSize { get; set; }
  
        
        /// <summary>
        /// The total number of items available in the result set. This will always be greater than or equal to the value of the `resultSetSize` property.
        /// </summary>
        /// <value>The total number of items available in the result set. This will always be greater than or equal to the value of the `resultSetSize` property.</value>
        [DataMember(Name="totalSetSize", EmitDefaultValue=false)]
        public string TotalSetSize { get; set; }
  
        
        /// <summary>
        /// Starting position of the current result set.
        /// </summary>
        /// <value>Starting position of the current result set.</value>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public string StartPosition { get; set; }
  
        
        /// <summary>
        /// The last position in the result set.
        /// </summary>
        /// <value>The last position in the result set.</value>
        [DataMember(Name="endPosition", EmitDefaultValue=false)]
        public string EndPosition { get; set; }
  
        
        /// <summary>
        /// The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null.
        /// </summary>
        /// <value>The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null.</value>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
  
        
        /// <summary>
        /// The postal code for the billing address.
        /// </summary>
        /// <value>The postal code for the billing address.</value>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopes", EmitDefaultValue=false)]
        public List<Envelope> Envelopes { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopeTransactionStatuses", EmitDefaultValue=false)]
        public List<EnvelopeTransactionStatus> EnvelopeTransactionStatuses { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopesInformation {\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  TotalSetSize: ").Append(TotalSetSize).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  Envelopes: ").Append(Envelopes).Append("\n");
            sb.Append("  EnvelopeTransactionStatuses: ").Append(EnvelopeTransactionStatuses).Append("\n");
            
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
            return this.Equals(obj as EnvelopesInformation);
        }

        /// <summary>
        /// Returns true if EnvelopesInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopesInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopesInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResultSetSize == other.ResultSetSize ||
                    this.ResultSetSize != null &&
                    this.ResultSetSize.Equals(other.ResultSetSize)
                ) && 
                (
                    this.TotalSetSize == other.TotalSetSize ||
                    this.TotalSetSize != null &&
                    this.TotalSetSize.Equals(other.TotalSetSize)
                ) && 
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) && 
                (
                    this.EndPosition == other.EndPosition ||
                    this.EndPosition != null &&
                    this.EndPosition.Equals(other.EndPosition)
                ) && 
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) && 
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
                ) && 
                (
                    this.Envelopes == other.Envelopes ||
                    this.Envelopes != null &&
                    this.Envelopes.SequenceEqual(other.Envelopes)
                ) && 
                (
                    this.EnvelopeTransactionStatuses == other.EnvelopeTransactionStatuses ||
                    this.EnvelopeTransactionStatuses != null &&
                    this.EnvelopeTransactionStatuses.SequenceEqual(other.EnvelopeTransactionStatuses)
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
                
                if (this.ResultSetSize != null)
                    hash = hash * 57 + this.ResultSetSize.GetHashCode();
                
                if (this.TotalSetSize != null)
                    hash = hash * 57 + this.TotalSetSize.GetHashCode();
                
                if (this.StartPosition != null)
                    hash = hash * 57 + this.StartPosition.GetHashCode();
                
                if (this.EndPosition != null)
                    hash = hash * 57 + this.EndPosition.GetHashCode();
                
                if (this.NextUri != null)
                    hash = hash * 57 + this.NextUri.GetHashCode();
                
                if (this.PreviousUri != null)
                    hash = hash * 57 + this.PreviousUri.GetHashCode();
                
                if (this.Envelopes != null)
                    hash = hash * 57 + this.Envelopes.GetHashCode();
                
                if (this.EnvelopeTransactionStatuses != null)
                    hash = hash * 57 + this.EnvelopeTransactionStatuses.GetHashCode();
                
                return hash;
            }
        }

    }
}
