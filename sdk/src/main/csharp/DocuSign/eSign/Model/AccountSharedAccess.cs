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
    public class AccountSharedAccess : IEquatable<AccountSharedAccess>
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
        /// The account ID associated with the envelope.
        /// </summary>
        /// <value>The account ID associated with the envelope.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
  
        
        /// <summary>
        /// A complex type containing the shared access information to an envelope for the users specified in the request.
        /// </summary>
        /// <value>A complex type containing the shared access information to an envelope for the users specified in the request.</value>
        [DataMember(Name="sharedAccess", EmitDefaultValue=false)]
        public List<MemberSharedItems> SharedAccess { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSharedAccess {\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  TotalSetSize: ").Append(TotalSetSize).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  SharedAccess: ").Append(SharedAccess).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            
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
            return this.Equals(obj as AccountSharedAccess);
        }

        /// <summary>
        /// Returns true if AccountSharedAccess instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSharedAccess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSharedAccess other)
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
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.SharedAccess == other.SharedAccess ||
                    this.SharedAccess != null &&
                    this.SharedAccess.SequenceEqual(other.SharedAccess)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
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
                
                if (this.AccountId != null)
                    hash = hash * 57 + this.AccountId.GetHashCode();
                
                if (this.SharedAccess != null)
                    hash = hash * 57 + this.SharedAccess.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
