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
    public class RecipientViewRequest : IEquatable<RecipientViewRequest>
    {
        
        /// <summary>
        /// A sender created value that shows the recipient is embedded (captive). \n\nMaximum length: 100 characters.
        /// </summary>
        /// <value>A sender created value that shows the recipient is embedded (captive). \n\nMaximum length: 100 characters.</value>
        [DataMember(Name="clientUserId", EmitDefaultValue=false)]
        public string ClientUserId { get; set; }
  
        
        /// <summary>
        /// Specifies the user ID of the recipient. You can use with user ID or email and user name to identify the recipient. If user ID is used and a client user ID is provided, the value in the `userId` property must match a recipient ID (which can be retrieved with a GET recipients call) for the envelope. If a user ID is used and a clientUser ID is not provided, the user ID match the user ID of the authenticating user.
        /// </summary>
        /// <value>Specifies the user ID of the recipient. You can use with user ID or email and user name to identify the recipient. If user ID is used and a client user ID is provided, the value in the `userId` property must match a recipient ID (which can be retrieved with a GET recipients call) for the envelope. If a user ID is used and a clientUser ID is not provided, the user ID match the user ID of the authenticating user.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
  
        
        /// <summary>
        /// Specifies the username of the recipient. You can use either email and userName or userId to identify the recipient.
        /// </summary>
        /// <value>Specifies the username of the recipient. You can use either email and userName or userId to identify the recipient.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
  
        
        /// <summary>
        /// Specifies the email of the recipient. You can use either email and userName or userId to identify the recipient.
        /// </summary>
        /// <value>Specifies the email of the recipient. You can use either email and userName or userId to identify the recipient.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
  
        
        /// <summary>
        /// The URL the recipient is directed to on certain events. DocuSign sends returns to the URL and includes an event parameter that can be used to redirect the recipient to another location. The possible event parameters returned are: \n\n* cancel (recipient cancels signing)\n* decline (recipient declines signing)\n* exception (exception occurs)\n* fax_pending (recipient has fax pending)\n* check); session_timeout (session times out)\n* completes signing)\n* expires)\n* viewing_complete (recipient completes viewing the envelope)\n\n## Important: You must include HTTPS:// in the URL or the redirect might be blocked by some browsers.
        /// </summary>
        /// <value>The URL the recipient is directed to on certain events. DocuSign sends returns to the URL and includes an event parameter that can be used to redirect the recipient to another location. The possible event parameters returned are: \n\n* cancel (recipient cancels signing)\n* decline (recipient declines signing)\n* exception (exception occurs)\n* fax_pending (recipient has fax pending)\n* check); session_timeout (session times out)\n* completes signing)\n* expires)\n* viewing_complete (recipient completes viewing the envelope)\n\n## Important: You must include HTTPS:// in the URL or the redirect might be blocked by some browsers.</value>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
  
        
        /// <summary>
        /// A client Url to be pinged by the DocuSign Signing experience to indicate to the client that Signing is active. An HTTP Get is executed against the client. The response from the client is ignored. The intent is for the client to reset it's session timer when the request is received.
        /// </summary>
        /// <value>A client Url to be pinged by the DocuSign Signing experience to indicate to the client that Signing is active. An HTTP Get is executed against the client. The response from the client is ignored. The intent is for the client to reset it's session timer when the request is received.</value>
        [DataMember(Name="pingUrl", EmitDefaultValue=false)]
        public string PingUrl { get; set; }
  
        
        /// <summary>
        /// Only used if pingUrl is specified. This is the interval, in seconds, between pings on the pingUrl.  The default is 300 seconds. Valid values are 60-1200 seconds.
        /// </summary>
        /// <value>Only used if pingUrl is specified. This is the interval, in seconds, between pings on the pingUrl.  The default is 300 seconds. Valid values are 60-1200 seconds.</value>
        [DataMember(Name="pingFrequency", EmitDefaultValue=false)]
        public string PingFrequency { get; set; }
  
        
        /// <summary>
        /// A sender created value that indicates the convention used to authenticate the signer. This information is included in the Certificate of Completion.
        /// </summary>
        /// <value>A sender created value that indicates the convention used to authenticate the signer. This information is included in the Certificate of Completion.</value>
        [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
        public string AuthenticationMethod { get; set; }
  
        
        /// <summary>
        /// A unique identifier of the authentication event executed by the client application.
        /// </summary>
        /// <value>A unique identifier of the authentication event executed by the client application.</value>
        [DataMember(Name="assertionId", EmitDefaultValue=false)]
        public string AssertionId { get; set; }
  
        
        /// <summary>
        /// A sender generated value that indicates the date/time that the signer was authenticated.
        /// </summary>
        /// <value>A sender generated value that indicates the date/time that the signer was authenticated.</value>
        [DataMember(Name="authenticationInstant", EmitDefaultValue=false)]
        public string AuthenticationInstant { get; set; }
  
        
        /// <summary>
        /// The domain in which the user authenticated.
        /// </summary>
        /// <value>The domain in which the user authenticated.</value>
        [DataMember(Name="securityDomain", EmitDefaultValue=false)]
        public string SecurityDomain { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientViewRequest {\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  PingUrl: ").Append(PingUrl).Append("\n");
            sb.Append("  PingFrequency: ").Append(PingFrequency).Append("\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
            sb.Append("  AssertionId: ").Append(AssertionId).Append("\n");
            sb.Append("  AuthenticationInstant: ").Append(AuthenticationInstant).Append("\n");
            sb.Append("  SecurityDomain: ").Append(SecurityDomain).Append("\n");
            
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
            return this.Equals(obj as RecipientViewRequest);
        }

        /// <summary>
        /// Returns true if RecipientViewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientViewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientViewRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientUserId == other.ClientUserId ||
                    this.ClientUserId != null &&
                    this.ClientUserId.Equals(other.ClientUserId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
                ) && 
                (
                    this.PingUrl == other.PingUrl ||
                    this.PingUrl != null &&
                    this.PingUrl.Equals(other.PingUrl)
                ) && 
                (
                    this.PingFrequency == other.PingFrequency ||
                    this.PingFrequency != null &&
                    this.PingFrequency.Equals(other.PingFrequency)
                ) && 
                (
                    this.AuthenticationMethod == other.AuthenticationMethod ||
                    this.AuthenticationMethod != null &&
                    this.AuthenticationMethod.Equals(other.AuthenticationMethod)
                ) && 
                (
                    this.AssertionId == other.AssertionId ||
                    this.AssertionId != null &&
                    this.AssertionId.Equals(other.AssertionId)
                ) && 
                (
                    this.AuthenticationInstant == other.AuthenticationInstant ||
                    this.AuthenticationInstant != null &&
                    this.AuthenticationInstant.Equals(other.AuthenticationInstant)
                ) && 
                (
                    this.SecurityDomain == other.SecurityDomain ||
                    this.SecurityDomain != null &&
                    this.SecurityDomain.Equals(other.SecurityDomain)
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
                
                if (this.ClientUserId != null)
                    hash = hash * 57 + this.ClientUserId.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 57 + this.UserId.GetHashCode();
                
                if (this.UserName != null)
                    hash = hash * 57 + this.UserName.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                if (this.RecipientId != null)
                    hash = hash * 57 + this.RecipientId.GetHashCode();
                
                if (this.ReturnUrl != null)
                    hash = hash * 57 + this.ReturnUrl.GetHashCode();
                
                if (this.PingUrl != null)
                    hash = hash * 57 + this.PingUrl.GetHashCode();
                
                if (this.PingFrequency != null)
                    hash = hash * 57 + this.PingFrequency.GetHashCode();
                
                if (this.AuthenticationMethod != null)
                    hash = hash * 57 + this.AuthenticationMethod.GetHashCode();
                
                if (this.AssertionId != null)
                    hash = hash * 57 + this.AssertionId.GetHashCode();
                
                if (this.AuthenticationInstant != null)
                    hash = hash * 57 + this.AuthenticationInstant.GetHashCode();
                
                if (this.SecurityDomain != null)
                    hash = hash * 57 + this.SecurityDomain.GetHashCode();
                
                return hash;
            }
        }

    }
}
