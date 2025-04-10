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
    /// RecipientIdentityInputOption
    /// </summary>
    [DataContract]
    public partial class RecipientIdentityInputOption :  IEquatable<RecipientIdentityInputOption>, IValidatableObject
    {
        public RecipientIdentityInputOption()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientIdentityInputOption" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="PhoneNumberList">PhoneNumberList.</param>
        /// <param name="StringValue">StringValue.</param>
        /// <param name="ValueType">ValueType.</param>
        public RecipientIdentityInputOption(string Name = default(string), List<RecipientIdentityPhoneNumber> PhoneNumberList = default(List<RecipientIdentityPhoneNumber>), string StringValue = default(string), string ValueType = default(string))
        {
            this.Name = Name;
            this.PhoneNumberList = PhoneNumberList;
            this.StringValue = StringValue;
            this.ValueType = ValueType;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets PhoneNumberList
        /// </summary>
        [DataMember(Name="phoneNumberList", EmitDefaultValue=false)]
        public List<RecipientIdentityPhoneNumber> PhoneNumberList { get; set; }
        /// <summary>
        /// Gets or Sets StringValue
        /// </summary>
        [DataMember(Name="stringValue", EmitDefaultValue=false)]
        public string StringValue { get; set; }
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public string ValueType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientIdentityInputOption {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumberList: ").Append(PhoneNumberList).Append("\n");
            sb.Append("  StringValue: ").Append(StringValue).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
            return this.Equals(obj as RecipientIdentityInputOption);
        }

        /// <summary>
        /// Returns true if RecipientIdentityInputOption instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientIdentityInputOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientIdentityInputOption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PhoneNumberList == other.PhoneNumberList ||
                    this.PhoneNumberList != null &&
                    this.PhoneNumberList.SequenceEqual(other.PhoneNumberList)
                ) && 
                (
                    this.StringValue == other.StringValue ||
                    this.StringValue != null &&
                    this.StringValue.Equals(other.StringValue)
                ) && 
                (
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PhoneNumberList != null)
                    hash = hash * 59 + this.PhoneNumberList.GetHashCode();
                if (this.StringValue != null)
                    hash = hash * 59 + this.StringValue.GetHashCode();
                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
