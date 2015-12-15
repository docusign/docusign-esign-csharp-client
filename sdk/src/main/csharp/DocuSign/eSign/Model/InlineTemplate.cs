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
    public class InlineTemplate : IEquatable<InlineTemplate>
    {
        
        /// <summary>
        /// Specifies the order in which templates are overlaid.
        /// </summary>
        /// <value>Specifies the order in which templates are overlaid.</value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public string Sequence { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Envelope
        /// </summary>
        [DataMember(Name="envelope", EmitDefaultValue=false)]
        public Envelope Envelope { get; set; }
  
        
        /// <summary>
        /// Complex element contains the details on the documents in the envelope.
        /// </summary>
        /// <value>Complex element contains the details on the documents in the envelope.</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<Document> Documents { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public Recipients Recipients { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public CustomFields CustomFields { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineTemplate {\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Envelope: ").Append(Envelope).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            
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
            return this.Equals(obj as InlineTemplate);
        }

        /// <summary>
        /// Returns true if InlineTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sequence == other.Sequence ||
                    this.Sequence != null &&
                    this.Sequence.Equals(other.Sequence)
                ) && 
                (
                    this.Envelope == other.Envelope ||
                    this.Envelope != null &&
                    this.Envelope.Equals(other.Envelope)
                ) && 
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(other.Documents)
                ) && 
                (
                    this.Recipients == other.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.Equals(other.Recipients)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.Equals(other.CustomFields)
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
                
                if (this.Sequence != null)
                    hash = hash * 57 + this.Sequence.GetHashCode();
                
                if (this.Envelope != null)
                    hash = hash * 57 + this.Envelope.GetHashCode();
                
                if (this.Documents != null)
                    hash = hash * 57 + this.Documents.GetHashCode();
                
                if (this.Recipients != null)
                    hash = hash * 57 + this.Recipients.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 57 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
