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
    public class CorrectViewRequest : IEquatable<CorrectViewRequest>
    {
        
        /// <summary>
        /// Specifies whether the window is displayed with or without dressing.
        /// </summary>
        /// <value>Specifies whether the window is displayed with or without dressing.</value>
        [DataMember(Name="suppressNavigation", EmitDefaultValue=false)]
        public string SuppressNavigation { get; set; }
  
        
        /// <summary>
        /// Specifies the return point after correcting the envelope. DocuSign returns to the URL and includes an event parameter that can be used to redirect the recipient to another location. The possible event parameters returned are: \n\n* send (user corrects and sends the envelope)\n* save (user saves the envelope)\n* cancel (user cancels the transaction.)\n* error (there is an error when performing the correct or send)\n* sessionEnd (the session ends before the user completes another action)\n\n## Important: You must include HTTPS:// in the URL or the redirect might be blocked by some browsers.
        /// </summary>
        /// <value>Specifies the return point after correcting the envelope. DocuSign returns to the URL and includes an event parameter that can be used to redirect the recipient to another location. The possible event parameters returned are: \n\n* send (user corrects and sends the envelope)\n* save (user saves the envelope)\n* cancel (user cancels the transaction.)\n* error (there is an error when performing the correct or send)\n* sessionEnd (the session ends before the user completes another action)\n\n## Important: You must include HTTPS:// in the URL or the redirect might be blocked by some browsers.</value>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorrectViewRequest {\n");
            sb.Append("  SuppressNavigation: ").Append(SuppressNavigation).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            
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
            return this.Equals(obj as CorrectViewRequest);
        }

        /// <summary>
        /// Returns true if CorrectViewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CorrectViewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorrectViewRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SuppressNavigation == other.SuppressNavigation ||
                    this.SuppressNavigation != null &&
                    this.SuppressNavigation.Equals(other.SuppressNavigation)
                ) && 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
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
                
                if (this.SuppressNavigation != null)
                    hash = hash * 57 + this.SuppressNavigation.GetHashCode();
                
                if (this.ReturnUrl != null)
                    hash = hash * 57 + this.ReturnUrl.GetHashCode();
                
                return hash;
            }
        }

    }
}
