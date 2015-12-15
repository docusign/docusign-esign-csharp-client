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
    public class DocumentFieldsInformation : IEquatable<DocumentFieldsInformation>
    {
        
        /// <summary>
        /// The array of name/value custom data strings to be added to a document. Custom document field information is returned in the status, but otherwise is not used by DocuSign. The array contains the elements: \n\n* name – A string that can be a maximum of 50 characters. \n* value – A string that can be a maximum of 200 characters.\n\n*IMPORTANT*: If you are using xml, the name/value pair is contained in a nameValue element.
        /// </summary>
        /// <value>The array of name/value custom data strings to be added to a document. Custom document field information is returned in the status, but otherwise is not used by DocuSign. The array contains the elements: \n\n* name – A string that can be a maximum of 50 characters. \n* value – A string that can be a maximum of 200 characters.\n\n*IMPORTANT*: If you are using xml, the name/value pair is contained in a nameValue element.</value>
        [DataMember(Name="documentFields", EmitDefaultValue=false)]
        public List<NameValue> DocumentFields { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentFieldsInformation {\n");
            sb.Append("  DocumentFields: ").Append(DocumentFields).Append("\n");
            
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
            return this.Equals(obj as DocumentFieldsInformation);
        }

        /// <summary>
        /// Returns true if DocumentFieldsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentFieldsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentFieldsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentFields == other.DocumentFields ||
                    this.DocumentFields != null &&
                    this.DocumentFields.SequenceEqual(other.DocumentFields)
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
                
                if (this.DocumentFields != null)
                    hash = hash * 57 + this.DocumentFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
