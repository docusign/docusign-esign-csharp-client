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
    /// BulkSendingCopyDocGenFormFieldRowValue
    /// </summary>
    [DataContract]
    public partial class BulkSendingCopyDocGenFormFieldRowValue :  IEquatable<BulkSendingCopyDocGenFormFieldRowValue>, IValidatableObject
    {
        public BulkSendingCopyDocGenFormFieldRowValue()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendingCopyDocGenFormFieldRowValue" /> class.
        /// </summary>
        /// <param name="DocGenFormFieldList">DocGenFormFieldList.</param>
        public BulkSendingCopyDocGenFormFieldRowValue(List<BulksendingCopyDocGenFormField> DocGenFormFieldList = default(List<BulksendingCopyDocGenFormField>))
        {
            this.DocGenFormFieldList = DocGenFormFieldList;
        }
        
        /// <summary>
        /// Gets or Sets DocGenFormFieldList
        /// </summary>
        [DataMember(Name="docGenFormFieldList", EmitDefaultValue=false)]
        public List<BulksendingCopyDocGenFormField> DocGenFormFieldList { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSendingCopyDocGenFormFieldRowValue {\n");
            sb.Append("  DocGenFormFieldList: ").Append(DocGenFormFieldList).Append("\n");
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
            return this.Equals(obj as BulkSendingCopyDocGenFormFieldRowValue);
        }

        /// <summary>
        /// Returns true if BulkSendingCopyDocGenFormFieldRowValue instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSendingCopyDocGenFormFieldRowValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendingCopyDocGenFormFieldRowValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocGenFormFieldList == other.DocGenFormFieldList ||
                    this.DocGenFormFieldList != null &&
                    this.DocGenFormFieldList.SequenceEqual(other.DocGenFormFieldList)
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
                if (this.DocGenFormFieldList != null)
                    hash = hash * 59 + this.DocGenFormFieldList.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
