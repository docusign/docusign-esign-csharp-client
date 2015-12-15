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
    public class LoginInformation : IEquatable<LoginInformation>
    {
        
        /// <summary>
        /// The list of accounts that authenticating user is a member of.
        /// </summary>
        /// <value>The list of accounts that authenticating user is a member of.</value>
        [DataMember(Name="loginAccounts", EmitDefaultValue=false)]
        public List<LoginAccount> LoginAccounts { get; set; }
  
        
        /// <summary>
        /// Contains a token that can be used for authentication in API calls instead of using the user name and password. Only returned if the `api_password=true` query string is added to the URL.
        /// </summary>
        /// <value>Contains a token that can be used for authentication in API calls instead of using the user name and password. Only returned if the `api_password=true` query string is added to the URL.</value>
        [DataMember(Name="apiPassword", EmitDefaultValue=false)]
        public string ApiPassword { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginInformation {\n");
            sb.Append("  LoginAccounts: ").Append(LoginAccounts).Append("\n");
            sb.Append("  ApiPassword: ").Append(ApiPassword).Append("\n");
            
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
            return this.Equals(obj as LoginInformation);
        }

        /// <summary>
        /// Returns true if LoginInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LoginAccounts == other.LoginAccounts ||
                    this.LoginAccounts != null &&
                    this.LoginAccounts.SequenceEqual(other.LoginAccounts)
                ) && 
                (
                    this.ApiPassword == other.ApiPassword ||
                    this.ApiPassword != null &&
                    this.ApiPassword.Equals(other.ApiPassword)
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
                
                if (this.LoginAccounts != null)
                    hash = hash * 57 + this.LoginAccounts.GetHashCode();
                
                if (this.ApiPassword != null)
                    hash = hash * 57 + this.ApiPassword.GetHashCode();
                
                return hash;
            }
        }

    }
}
