/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// ExternalFolder
    /// </summary>
    [DataContract]
    public partial class ExternalFolder :  IEquatable<ExternalFolder>, IValidatableObject
    {
        public ExternalFolder()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFolder" /> class.
        /// </summary>
        /// <param name="EndPosition">The last position in the result set. .</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Id">Id.</param>
        /// <param name="Items">Items.</param>
        /// <param name="Name">Name.</param>
        /// <param name="NextUri">The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null. .</param>
        /// <param name="PreviousUri">The postal code for the billing address..</param>
        /// <param name="ResultSetSize">The number of results returned in this response. .</param>
        /// <param name="SkyDriveSkipToken">SkyDriveSkipToken.</param>
        /// <param name="StartPosition">Starting position of the current result set..</param>
        /// <param name="TotalSetSize">The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response..</param>
        public ExternalFolder(string EndPosition = default(string), ExternalDocServiceErrorDetails ErrorDetails = default(ExternalDocServiceErrorDetails), string Id = default(string), List<ExternalFile> Items = default(List<ExternalFile>), string Name = default(string), string NextUri = default(string), string PreviousUri = default(string), string ResultSetSize = default(string), string SkyDriveSkipToken = default(string), string StartPosition = default(string), string TotalSetSize = default(string))
        {
            this.EndPosition = EndPosition;
            this.ErrorDetails = ErrorDetails;
            this.Id = Id;
            this.Items = Items;
            this.Name = Name;
            this.NextUri = NextUri;
            this.PreviousUri = PreviousUri;
            this.ResultSetSize = ResultSetSize;
            this.SkyDriveSkipToken = SkyDriveSkipToken;
            this.StartPosition = StartPosition;
            this.TotalSetSize = TotalSetSize;
        }
        
        /// <summary>
        /// The last position in the result set. 
        /// </summary>
        /// <value>The last position in the result set. </value>
        [DataMember(Name="endPosition", EmitDefaultValue=false)]
        public string EndPosition { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ExternalDocServiceErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ExternalFile> Items { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null. 
        /// </summary>
        /// <value>The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null. </value>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
        /// <summary>
        /// The postal code for the billing address.
        /// </summary>
        /// <value>The postal code for the billing address.</value>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }
        /// <summary>
        /// The number of results returned in this response. 
        /// </summary>
        /// <value>The number of results returned in this response. </value>
        [DataMember(Name="resultSetSize", EmitDefaultValue=false)]
        public string ResultSetSize { get; set; }
        /// <summary>
        /// Gets or Sets SkyDriveSkipToken
        /// </summary>
        [DataMember(Name="skyDriveSkipToken", EmitDefaultValue=false)]
        public string SkyDriveSkipToken { get; set; }
        /// <summary>
        /// Starting position of the current result set.
        /// </summary>
        /// <value>Starting position of the current result set.</value>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public string StartPosition { get; set; }
        /// <summary>
        /// The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response.
        /// </summary>
        /// <value>The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response.</value>
        [DataMember(Name="totalSetSize", EmitDefaultValue=false)]
        public string TotalSetSize { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalFolder {\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  SkyDriveSkipToken: ").Append(SkyDriveSkipToken).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  TotalSetSize: ").Append(TotalSetSize).Append("\n");
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
            return this.Equals(obj as ExternalFolder);
        }

        /// <summary>
        /// Returns true if ExternalFolder instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalFolder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndPosition == other.EndPosition ||
                    this.EndPosition != null &&
                    this.EndPosition.Equals(other.EndPosition)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.ResultSetSize == other.ResultSetSize ||
                    this.ResultSetSize != null &&
                    this.ResultSetSize.Equals(other.ResultSetSize)
                ) && 
                (
                    this.SkyDriveSkipToken == other.SkyDriveSkipToken ||
                    this.SkyDriveSkipToken != null &&
                    this.SkyDriveSkipToken.Equals(other.SkyDriveSkipToken)
                ) && 
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) && 
                (
                    this.TotalSetSize == other.TotalSetSize ||
                    this.TotalSetSize != null &&
                    this.TotalSetSize.Equals(other.TotalSetSize)
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
                if (this.EndPosition != null)
                    hash = hash * 59 + this.EndPosition.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();
                if (this.PreviousUri != null)
                    hash = hash * 59 + this.PreviousUri.GetHashCode();
                if (this.ResultSetSize != null)
                    hash = hash * 59 + this.ResultSetSize.GetHashCode();
                if (this.SkyDriveSkipToken != null)
                    hash = hash * 59 + this.SkyDriveSkipToken.GetHashCode();
                if (this.StartPosition != null)
                    hash = hash * 59 + this.StartPosition.GetHashCode();
                if (this.TotalSetSize != null)
                    hash = hash * 59 + this.TotalSetSize.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
