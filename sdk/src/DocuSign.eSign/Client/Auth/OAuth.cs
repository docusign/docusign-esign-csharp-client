using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using RestSharp;
using System.Text;
using System.Collections.Generic;
using System;

namespace DocuSign.eSign.Client.Auth
{
    public class OAuth
    {
        static readonly int MILLIS_PER_SECOND = 1000;

        //  OAuth Scope constants
        //  create and send envelopes, and obtain links for starting signing sessions.
        public static string Scope_SIGNATURE = "signature";
        //  obtain a refresh token with an extended lifetime.
        public static string Scope_EXTENDED = "extended";
        //  obtain access to the user’s account when the user is not present.
        public static string Scope_IMPERSONATION = "impersonation";

        //  OAuth ResponseType constants
        //  used by public/native client applications.
        public static string CODE = "code";
        //  used by private/trusted client application.
        public static string TOKEN = "token";

        private readonly string accessToken;
        private readonly long expirationTimeMillis;

        //    /**
        //	 * 
        //	 * UserInfo model with the following properties:
        //	 * <br><b>sub</b>: the user ID GUID.
        //	 * <br><b>accounts</b>: this is list of DocuSign accounts associated with the current user.
        //	 * <br><b>name</b>: the user's full name.
        //	 * <br><b>givenName</b>: the user's given name.
        //	 * <br><b>familyName</b>: the user's family name.
        //	 * <br><b>email</b>: the user's email address.
        //	 * <br><b>created</b>: the UTC DateTime when the user login was created.
        //	 *
        //	 * @see Account
        //	 *
        //	 */
        [DataContract]
        public class UserInfo : IEquatable<UserInfo>, IValidatableObject
        {
            /**
             * 
             * Account model with the following properties:
             * <br><b>accountId</b>: the account ID GUID.
             * <br><b>isDefault</b>: whether this is the default account, when the user has access to multiple accounts.
             * <br><b>accountName</b>: the human-readable name of the account.
             * <br><b>baseUri</b>: the base URI associated with this account.
             * It also tells which DocuSign data center the account is hosted on.
             *
             */
            [DataContract]
            public class Account : IEquatable<Account>, IValidatableObject
            {
                [DataMember(Name = "account_id", EmitDefaultValue = false)]
                private string account_id { get; set; }

                [DataMember(Name = "is_default", EmitDefaultValue = false)]
                private string is_default { get; set; }

                [DataMember(Name = "account_name", EmitDefaultValue = false)]
                private string account_name { get; set; }

                [DataMember(Name = "base_uri", EmitDefaultValue = false)]
                private string base_uri = null;

                public Account AccountId(string account_id)
                {
                    this.account_id = account_id;
                    return this;
                }

                /**
                 * Get accountId
                 *
                 * @return accountId
                 **/
                public string AccountId()
                {
                    return account_id;
                }

                public void SetAccountId(string account_id)
                {
                    this.account_id = account_id;
                }

                public Account IsDefault(string is_default)
                {
                    this.is_default = is_default;
                    return this;
                }

                /**
                 * Get isDefault
                 *
                 * @return isDefault
                 **/
                public string GetIsDefault()
                {
                    return is_default;
                }

                public void SetIsDefault(string is_default)
                {
                    this.is_default = is_default;
                }

                public Account AccountName(string account_name)
                {
                    this.account_name = account_name;
                    return this;
                }

                /**
                 * Get accountName
                 * 
                 * @return accountName
                 **/
                public string GetAccountName()
                {
                    return account_name;
                }

                public void SetAccountName(string account_name)
                {
                    this.account_name = account_name;
                }

                public Account BaseUri(string base_uri)
                {
                    this.base_uri = base_uri;
                    return this;
                }

                /**
                 * Get baseUri
                 * 
                 * @return baseUri
                 **/
                public string GetBaseUri()
                {
                    return base_uri;
                }

                public void SetBaseUri(string base_uri)
                {
                    this.base_uri = base_uri;
                }

                public override bool Equals(object obj)
                {
                    return this.Equals(obj as Account);
                }

                public override int GetHashCode()
                {
                    unchecked // Overflow is fine, just wrap
                    {
                        int hash = 41;
                        if (this.account_id != null)
                            hash = hash * 59 + this.account_id.GetHashCode();
                        if (is_default != null)
                            hash = hash * 59 + this.is_default.GetHashCode();
                        if (account_name != null)
                            hash = hash * 59 + this.account_name.GetHashCode();
                        if (base_uri != null)
                            hash = hash * 59 + this.base_uri.GetHashCode();
                        return hash;
                    }
                }

                public override string ToString()
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("class Account {\n");

                    sb.Append("    account_id: ").Append(ToIndentedString(account_id)).Append("\n");
                    sb.Append("    is_default: ").Append(ToIndentedString(is_default)).Append("\n");
                    sb.Append("    account_name: ").Append(ToIndentedString(account_name)).Append("\n");
                    sb.Append("    base_uri: ").Append(ToIndentedString(base_uri)).Append("\n");
                    return sb.ToString();
                }

                /**
                 * Convert the given object to string with each line indented by 4
                 * spaces (except the first line).
                 */
                private string ToIndentedString(object o)
                {
                    if (o == null)
                    {
                        return "null";
                    }
                    return o.ToString().Replace("\n", "\n    ");
                }

                public bool Equals(Account other)
                {
                    if (other == null)
                        return false;

                    return
                  (
                      this.account_id == other.account_id ||
                      this.account_id != null &&
                      this.account_id.Equals(other.account_id)
                  ) &&
                  (
                      this.account_name == other.account_name ||
                      this.account_name != null &&
                      this.account_name.Equals(other.account_name)
                  ) &&
                  (
                      this.is_default == other.is_default ||
                      this.is_default != null &&
                      this.is_default.Equals(other.is_default)
                  ) &&
                  (
                      this.base_uri == other.base_uri ||
                      this.base_uri != null &&
                      this.base_uri.Equals(other.base_uri)
                  );
                }

                /// <summary>
                /// Returns the JSON string presentation of the object
                /// </summary>
                /// <returns>JSON string presentation of the object</returns>
                public string ToJson()
                {
                    return JsonConvert.SerializeObject(this, Formatting.Indented);
                }

                public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
                {
                    yield break;
                }
            }

            [DataMember(Name = "sub", EmitDefaultValue = false)]
            private string sub = null;

            [DataMember(Name = "email", EmitDefaultValue = false)]
            private string email = null;

            [DataMember(Name = "accounts", EmitDefaultValue = false)]
            private List<Account> accounts = new List<Account>();

            [DataMember(Name = "name", EmitDefaultValue = false)]
            private string name = null;

            [DataMember(Name = "givenName", EmitDefaultValue = false)]
            private string givenName = null;

            [DataMember(Name = "familyName", EmitDefaultValue = false)]
            private string familyName = null;

            [DataMember(Name = "created", EmitDefaultValue = false)]
            private string created = null;

            public UserInfo Sub(string sub)
            {
                this.sub = sub;
                return this;
            }

            /**
             * Get sub
             *
             * @return sub
             **/
            public string GetSub()
            {
                return sub;
            }

            public void SetSub(String sub)
            {
                this.sub = sub;
            }

            public UserInfo Email(string email)
            {
                this.email = email;
                return this;
            }

            /**
             * Get email
             *
             * @return email
             **/
            public string GetEmail()
            {
                return email;
            }

            public void SetEmail(string email)
            {
                this.email = email;
            }

            public UserInfo Accounts(List<Account> accounts)
            {
                this.accounts = accounts;
                return this;
            }

            public UserInfo AddAccountsItem(Account accountsItem)
            {
                this.accounts.Add(accountsItem);
                return this;
            }

            /**
             * Get accounts
             * 
             * @return accounts
             **/
            public List<Account> GetAccounts()
            {
                return accounts;
            }

            public void SetAccounts(List<Account> accounts)
            {
                this.accounts = accounts;
            }

            public UserInfo Name(string name)
            {
                this.name = name;
                return this;
            }

            /**
             * Get name
             *
             * @return name
             **/
            public String GetName()
            {
                return name;
            }

            public void SetName(string name)
            {
                this.name = name;
            }

            public UserInfo GivenName(string givenName)
            {
                this.givenName = givenName;
                return this;
            }

            /**
             * Get givenName
             *
             * @return givenName
             **/

            public String GetGivenName()
            {
                return givenName;
            }

            public void setGivenName(string givenName)
            {
                this.givenName = givenName;
            }

            public UserInfo FamilyName(string familyName)
            {
                this.familyName = familyName;
                return this;
            }

            /**
             * Get familyName
             *
             * @return familyName
             **/
            public string GetFamilyName()
            {
                return familyName;
            }

            public void SetFamilyName(string familyName)
            {
                this.familyName = familyName;
            }

            public UserInfo Created(string created)
            {
                this.created = created;
                return this;
            }

            /**
             * Get created
             *
             * @return created
             **/
            public string GetCreated()
            {
                return created;
            }

            public void SetCreated(string created)
            {
                this.created = created;
            }

            public override bool Equals(object o)
            {
                return this.Equals(o as UserInfo);
            }

            public override int GetHashCode()
            {
                unchecked // Overflow is fine, just wrap
                {
                    int hash = 41;
                    if (this.sub != null)
                        hash = hash * 59 + this.sub.GetHashCode();
                    if (email != null)
                        hash = hash * 59 + this.email.GetHashCode();
                    if (accounts != null)
                        hash = hash * 59 + this.accounts.GetHashCode();
                    if (name != null)
                        hash = hash * 59 + this.name.GetHashCode();
                    if (givenName != null)
                        hash = hash * 59 + this.givenName.GetHashCode();
                    if (familyName != null)
                        hash = hash * 59 + this.familyName.GetHashCode();
                    if (created != null)
                        hash = hash * 59 + this.created.GetHashCode();
                    return hash;
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("class UserInfo {\n");

                sb.Append("    sub: ").Append(ToIndentedString(sub)).Append("\n");
                sb.Append("    email: ").Append(ToIndentedString(email)).Append("\n");
                sb.Append("    name: ").Append(ToIndentedString(name)).Append("\n");
                sb.Append("    givenName: ").Append(ToIndentedString(givenName)).Append("\n");
                sb.Append("    familyName: ").Append(ToIndentedString(familyName)).Append("\n");
                sb.Append("    created: ").Append(ToIndentedString(created)).Append("\n");
                sb.Append("    accounts: ").Append(ToIndentedString(accounts)).Append("\n");
                return sb.ToString();
            }

            /**
             * Convert the given object to string with each line indented by 4 spaces
             * (except the first line).
             */
            private string ToIndentedString(object o)
            {
                if (o == null)
                {
                    return "null";
                }
                return o.ToString().Replace("\n", "\n    ");
            }

            /// <summary>
            /// Returns the JSON string presentation of the object
            /// </summary>
            /// <returns>JSON string presentation of the object</returns>
            public string ToJson()
            {
                return JsonConvert.SerializeObject(this, Formatting.Indented);
            }

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                yield break;
            }

            public bool Equals(UserInfo other)
            {
                if (other == null)
                    return false;

                return
                    (
                        this.accounts == other.accounts ||
                        this.accounts != null &&
                        this.accounts.Equals(other.accounts)
                    ) &&
                    (
                        this.created == other.created ||
                        this.created != null &&
                        this.created.Equals(other.created)
                    ) &&
                    (
                        this.email == other.email ||
                        this.email != null &&
                        this.email.Equals(other.email)
                    ) &&
                    (
                        this.familyName == other.familyName ||
                        this.familyName != null &&
                        this.familyName.Equals(other.familyName)
                    ) &&
                    (
                        this.givenName == other.givenName ||
                        this.givenName != null &&
                        this.givenName.Equals(other.givenName)
                    ) &&
                    (
                        this.name == other.name ||
                        this.name != null &&
                        this.name.Equals(other.name)
                    ) &&
                    (
                        this.sub == other.sub ||
                        this.sub != null &&
                        this.sub.Equals(other.sub)
                    );
            }
        }

        public class OAuthToken
        {
            public string access_token { get; set; }

            public string token_type { get; set; }

            public string refresh_token { get; set; }

            public int? expires_in { get; set; }
        }
    }
}
