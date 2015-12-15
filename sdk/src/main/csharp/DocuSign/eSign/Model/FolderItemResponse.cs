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
    public class FolderItemResponse : IEquatable<FolderItemResponse>
    {
        
        /// <summary>
        /// The number of results returned in this response.
        /// </summary>
        /// <value>The number of results returned in this response.</value>
        [DataMember(Name="resultSetSize", EmitDefaultValue=false)]
        public string ResultSetSize { get; set; }
  
        
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
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="totalRows", EmitDefaultValue=false)]
        public string TotalRows { get; set; }
  
        
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
        /// A list of the envelopes in the specified folder or folders.
        /// </summary>
        /// <value>A list of the envelopes in the specified folder or folders.</value>
        [DataMember(Name="folderItems", EmitDefaultValue=false)]
        public List<FolderItemV2> FolderItems { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderItemResponse {\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  TotalRows: ").Append(TotalRows).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  FolderItems: ").Append(FolderItems).Append("\n");
            
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
            return this.Equals(obj as FolderItemResponse);
        }

        /// <summary>
        /// Returns true if FolderItemResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FolderItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderItemResponse other)
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
                    this.TotalRows == other.TotalRows ||
                    this.TotalRows != null &&
                    this.TotalRows.Equals(other.TotalRows)
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
                    this.FolderItems == other.FolderItems ||
                    this.FolderItems != null &&
                    this.FolderItems.SequenceEqual(other.FolderItems)
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
                
                if (this.StartPosition != null)
                    hash = hash * 57 + this.StartPosition.GetHashCode();
                
                if (this.EndPosition != null)
                    hash = hash * 57 + this.EndPosition.GetHashCode();
                
                if (this.TotalRows != null)
                    hash = hash * 57 + this.TotalRows.GetHashCode();
                
                if (this.NextUri != null)
                    hash = hash * 57 + this.NextUri.GetHashCode();
                
                if (this.PreviousUri != null)
                    hash = hash * 57 + this.PreviousUri.GetHashCode();
                
                if (this.FolderItems != null)
                    hash = hash * 57 + this.FolderItems.GetHashCode();
                
                return hash;
            }
        }

    }
}
