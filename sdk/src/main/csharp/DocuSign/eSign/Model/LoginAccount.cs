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
    public class LoginAccount : IEquatable<LoginAccount>
    {
        
        /// <summary>
        /// The name associated with the account.
        /// </summary>
        /// <value>The name associated with the account.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// The account ID associated with the envelope.
        /// </summary>
        /// <value>The account ID associated with the envelope.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
  
        
        /// <summary>
        /// The GUID associated with the account ID.
        /// </summary>
        /// <value>The GUID associated with the account ID.</value>
        [DataMember(Name="accountIdGuid", EmitDefaultValue=false)]
        public string AccountIdGuid { get; set; }
  
        
        /// <summary>
        /// The URL that should be used for successive calls to this account. It includes the protocal (https), the DocuSign server where the account is located, and the account number. Use this Url to make API calls against this account. Many of the API calls provide Uri's that are relative to this baseUrl.
        /// </summary>
        /// <value>The URL that should be used for successive calls to this account. It includes the protocal (https), the DocuSign server where the account is located, and the account number. Use this Url to make API calls against this account. Many of the API calls provide Uri's that are relative to this baseUrl.</value>
        [DataMember(Name="baseUrl", EmitDefaultValue=false)]
        public string BaseUrl { get; set; }
  
        
        /// <summary>
        /// This value is true if this is the default account for the user, otherwise false is returned.
        /// </summary>
        /// <value>This value is true if this is the default account for the user, otherwise false is returned.</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public string IsDefault { get; set; }
  
        
        /// <summary>
        /// The name of this user as defined by the account.
        /// </summary>
        /// <value>The name of this user as defined by the account.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// An optional descirption of the site that hosts the account.
        /// </summary>
        /// <value>An optional descirption of the site that hosts the account.</value>
        [DataMember(Name="siteDescription", EmitDefaultValue=false)]
        public string SiteDescription { get; set; }
  
        
        /// <summary>
        /// A list of settings on the acccount that indicate what features are available.
        /// </summary>
        /// <value>A list of settings on the acccount that indicate what features are available.</value>
        [DataMember(Name="loginAccountSettings", EmitDefaultValue=false)]
        public List<NameValue> LoginAccountSettings { get; set; }
  
        
        /// <summary>
        /// A list of user-level settings that indicate what user-specific features are available.
        /// </summary>
        /// <value>A list of user-level settings that indicate what user-specific features are available.</value>
        [DataMember(Name="loginUserSettings", EmitDefaultValue=false)]
        public List<NameValue> LoginUserSettings { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginAccount {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountIdGuid: ").Append(AccountIdGuid).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SiteDescription: ").Append(SiteDescription).Append("\n");
            sb.Append("  LoginAccountSettings: ").Append(LoginAccountSettings).Append("\n");
            sb.Append("  LoginUserSettings: ").Append(LoginUserSettings).Append("\n");
            
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
            return this.Equals(obj as LoginAccount);
        }

        /// <summary>
        /// Returns true if LoginAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginAccount other)
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
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.AccountIdGuid == other.AccountIdGuid ||
                    this.AccountIdGuid != null &&
                    this.AccountIdGuid.Equals(other.AccountIdGuid)
                ) && 
                (
                    this.BaseUrl == other.BaseUrl ||
                    this.BaseUrl != null &&
                    this.BaseUrl.Equals(other.BaseUrl)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.SiteDescription == other.SiteDescription ||
                    this.SiteDescription != null &&
                    this.SiteDescription.Equals(other.SiteDescription)
                ) && 
                (
                    this.LoginAccountSettings == other.LoginAccountSettings ||
                    this.LoginAccountSettings != null &&
                    this.LoginAccountSettings.SequenceEqual(other.LoginAccountSettings)
                ) && 
                (
                    this.LoginUserSettings == other.LoginUserSettings ||
                    this.LoginUserSettings != null &&
                    this.LoginUserSettings.SequenceEqual(other.LoginUserSettings)
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
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.AccountId != null)
                    hash = hash * 57 + this.AccountId.GetHashCode();
                
                if (this.AccountIdGuid != null)
                    hash = hash * 57 + this.AccountIdGuid.GetHashCode();
                
                if (this.BaseUrl != null)
                    hash = hash * 57 + this.BaseUrl.GetHashCode();
                
                if (this.IsDefault != null)
                    hash = hash * 57 + this.IsDefault.GetHashCode();
                
                if (this.UserName != null)
                    hash = hash * 57 + this.UserName.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 57 + this.UserId.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                if (this.SiteDescription != null)
                    hash = hash * 57 + this.SiteDescription.GetHashCode();
                
                if (this.LoginAccountSettings != null)
                    hash = hash * 57 + this.LoginAccountSettings.GetHashCode();
                
                if (this.LoginUserSettings != null)
                    hash = hash * 57 + this.LoginUserSettings.GetHashCode();
                
                return hash;
            }
        }

    }
}
