// -----------------------------------------------------------------------
// <copyright file="Account.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Account class, for creating accounts, logging, etc.
    /// </summary>
    public class Account
    {
        private string UserId { get; set; }

        /// <summary>
        /// Gets or sets the email address to associate with the account, either for logging in or creating.
        /// This is assumed to be pre-validated by the consumer of this class.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password to associate with the account, either for logging in or creating.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the account name to associate with the account, either for logging in or creating.
        /// Not required.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the account ID.
        /// Not required.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the account ID GUID.
        /// Not required.
        /// </summary>
        public Guid AccountIdGuid { get; set; }

        /// <summary>
        /// Gets a value indicating whether the account is the default account
        /// </summary>
        public bool IsDefault { get; private set; }

        /// <summary>
        /// Gets or sets the referrer name
        /// </summary>
        public string Referrer { get; set; }

        /// <summary>
        /// Gets or sets the referrer code
        /// </summary>
        public string ReferrerProvidedCode { get; set; }
        
        /// <summary>
        /// Gets or sets a string representing the BaseUrl to be used in subsequent REST calls
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets a string representing the BaseUrl to be used in subsequent REST calls
        /// </summary>
        public string ConsoleUrl { get; set; }

        /// <summary>
        /// Gets or sets a SocialAccountInformation instance
        /// </summary>
        public SocialAccountInformation Social { get; set; }

        /// <summary>
        /// Gets or sets a SocialAccountInformation instance
        /// </summary>
        public AddressInformation Address { get; set; }

        /// <summary>
        /// Gets or sets a SocialAccountInformation instance
        /// </summary>
        public CreditCardInformation CreditCard { get; set; }
        
        /// <summary>
        /// Gets or sets the api password returned from the REST call
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Gets or sets the janrain token
        /// </summary>
        public string JanrainToken { get; set; }

        /// <summary>
        /// Gets or sets the WebProxy for Http requests
        /// </summary>
        public WebProxy Proxy { get; set; }

        /// <summary>
        /// Gets or sets the api error
        /// </summary>
        public Error RestError { get; private set; }

        /// <summary>
        /// Gets or sets the api request
        /// </summary>
        public string RestTrace { get; private set; }

        /// <summary>
        /// Logs in to the account based on the credentials provided.
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool Login()
        {
            if (string.IsNullOrEmpty(this.Password) == true && string.IsNullOrEmpty(this.ApiPassword))
            {
                if (string.IsNullOrEmpty(this.JanrainToken) == true)
                {
                    throw new ArgumentNullException("Password");
                }
            }

            if (string.IsNullOrEmpty(this.Email) == true)
            {
                throw new ArgumentNullException("Email");
            }

            this.BaseUrl = string.Empty;

            if (string.IsNullOrEmpty(this.ApiPassword) == true)
            {
                return this.LoginDirect();
            }
            else
            {
                return this.LoginSocial();
            }
        }

        /// <summary>
        /// Attempts to get the User Id
        /// </summary>
        /// <returns>user id or empty string</returns>
        public string GetUserId()
        {
            try
            {
                RequestInfo req = new RequestInfo();
                RequestBuilder utils = new RequestBuilder();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Email;
                req.LoginPassword = string.Empty;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}{1}", RestSettings.Instance.WebServiceUrl, "/login_information");

                utils.Request = req;
                utils.Proxy = this.Proxy;

                ResponseInfo response = utils.MakeRESTRequest();

                this.Trace(utils, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }

                this.ParseLoginResponse(response);

                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Creates a new account based on the account information provided.
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool Create()
        {
            if (string.IsNullOrEmpty(this.Email) == true)
            {
                throw new ArgumentNullException("Email");
            }

            if (string.IsNullOrEmpty(this.AccountName) == true && this.ValidateSocial() == false)
            {
                throw new ArgumentException("Insufficient information to create account");
            }

            // clear out any previous account information
            this.BaseUrl = string.Empty;
            this.ApiPassword = string.Empty;
            this.IsDefault = false;

            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "POST";
                req.LoginEmail = this.Email;
                req.LoginPassword = this.Password;
                req.Uri = string.Format("{0}{1}", RestSettings.Instance.WebServiceUrl, "/accounts?api_password=true&include_account_id_guid=true");
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder utils = new RequestBuilder();
                utils.Proxy = this.Proxy;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                rb.Text = this.ConstructNewAccountJson();

                if (string.IsNullOrEmpty(rb.Text) == true)
                {
                    return false;
                }

                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                utils.Request = req;
                ResponseInfo response = utils.MakeRESTRequest();

                this.Trace(utils, response);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    this.ParseCreateResponse(response);
                }
                else
                {
                    this.ParseErrorResponse(response);
                }
                return response.StatusCode == HttpStatusCode.Created;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void Trace(RequestBuilder utils, ResponseInfo response)
        {
            if (RestSettings.Instance.RestTracing == true)
            {
                StringBuilder sb = new StringBuilder(this.RestTrace);
                sb.AppendLine();
                sb.AppendLine(utils.Dump());
                sb.AppendLine();
                sb.AppendLine("Response:");
                sb.AppendLine(response.ResponseText);
                this.RestTrace = sb.ToString();
                sb.AppendLine();
            }
        }

        /// <summary>
        /// Adds a new user to an existing account
        /// </summary>
        /// <param name="users">AddUsers object</param>
        /// <returns>true if successful, false otherwise</returns>
        public CreatedUsers AddUser(AddUsers users)
        {
            if (users == null)
            {
                throw new ArgumentNullException("NewUser");
            }

            if (string.IsNullOrEmpty(this.Email) == true)
            {
                throw new ArgumentNullException("Email");
            }

            if (string.IsNullOrEmpty(this.AccountId) == true)
            {
                throw new ArgumentNullException("AccountId");
            }

            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "POST";
                req.LoginEmail = this.Email;
                req.LoginPassword = string.IsNullOrEmpty(this.ApiPassword) == false ? this.ApiPassword : this.Password;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                string method = string.Format("/accounts/{0}/users?api_password=true", this.AccountId);

                req.Uri = string.Format("{0}{1}", RestSettings.Instance.WebServiceUrl, method);
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder utils = new RequestBuilder();
                utils.Proxy = this.Proxy;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                rb.Text = users.Serialize();

                if (string.IsNullOrEmpty(rb.Text) == true)
                {
                    return null;
                }

                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                utils.Request = req;
                ResponseInfo response = utils.MakeRESTRequest();

                this.Trace(utils, response);

                if (response.StatusCode != HttpStatusCode.Created)
                {
                    this.ParseErrorResponse(response);
                }

                var created = CreatedUsers.FromJson(response.ResponseText);

                return created;
            }
            catch
            {
            }

            return null;
        }

        /// <summary>
        /// Adds social credentials to an existing account
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool AssociateSocialAccount()
        {
            if (this.ValidateSocial() == false)
            {
                throw new ArgumentException("Insufficient information to associate account");
            }

            try
            {
                RequestInfo req = new RequestInfo();
                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "PUT";
                req.ApiPassword = this.ApiPassword;
                req.LoginEmail = this.Email;
                req.Uri = string.Format("{0}/users/{2}/social.json", this.BaseUrl, this.AccountId, this.UserId);
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;

                RequestBuilder utils = new RequestBuilder();
                utils.Proxy = this.Proxy;

                List<RequestBody> requestBodies = new List<RequestBody>();
                RequestBody rb = new RequestBody();

                rb.Text = this.ConstructAssociateJson();

                if (string.IsNullOrEmpty(rb.Text) == true)
                {
                    return false;
                }

                requestBodies.Add(rb);

                req.RequestBody = requestBodies.ToArray();
                utils.Request = req;
                ResponseInfo response = utils.MakeRESTRequest();

                this.Trace(utils, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.OK;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Account provisioning
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool Provisioning()
        {
            try
            {
                RequestInfo req = new RequestInfo();
                RequestBuilder builder = new RequestBuilder();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Email;
                req.LoginPassword = string.IsNullOrEmpty(this.ApiPassword) == false ? this.ApiPassword : this.Password;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}{1}", RestSettings.Instance.WebServiceUrl, "/provisioning.json");

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();

                this.Trace(builder, response);
                this.ParseLoginResponse(response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }
                return response.StatusCode == HttpStatusCode.OK;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Logs in to the account based on the credentials provided.
        /// </summary>
        /// <returns>Plans object if successful, null otherwise</returns>
        public Plans BillingPlans()
        {
            try
            {
                RequestInfo req = new RequestInfo();
                RequestBuilder builder = new RequestBuilder();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Email;
                req.LoginPassword = string.IsNullOrEmpty(this.ApiPassword) == false ? this.ApiPassword : this.Password;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}{1}", RestSettings.Instance.WebServiceUrl, "/billing_plans.json");

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }
                else
                {
                    return Plans.FromJson(response.ResponseText);
                }
            }
            catch
            {
            }

            return null;
        }

        /// <summary>
        /// Logs in to the account based on the credentials provided.
        /// </summary>
        /// <param name="planId">Plan ID</param>
        /// <returns>true if successful, false otherwise</returns>
        public Plans BillingPlan(string planId)
        {
            try
            {
                RequestInfo req = new RequestInfo();
                RequestBuilder builder = new RequestBuilder();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Email;
                req.LoginPassword = string.IsNullOrEmpty(this.ApiPassword) == false ? this.ApiPassword : this.Password;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}{1}", RestSettings.Instance.WebServiceUrl, string.Format("/billing_plans/{0}", planId));

                builder.Request = req;
                builder.Proxy = this.Proxy;

                ResponseInfo response = builder.MakeRESTRequest();

                this.ParseLoginResponse(response);
                this.Trace(builder, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }
                else
                {
                    return Plans.FromJson(response.ResponseText);
                }
            }
            catch
            {
            }

            return null;
        }

        /// <summary>
        /// Logs in to the account based on the credentials provided.
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        public bool GetUserConsoleView()
        {
            try
            {
                RequestInfo req = new RequestInfo();
                RequestBuilder utils = new RequestBuilder();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "POST";
                req.LoginEmail = this.Email;
                req.LoginPassword = string.IsNullOrEmpty(this.ApiPassword) == false ? this.ApiPassword : this.Password;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}/views/console", this.BaseUrl);

                utils.Request = req;
                utils.Proxy = this.Proxy;

                ResponseInfo response = utils.MakeRESTRequest();
                this.Trace(utils, response);

                this.ParseLoginResponse(response);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseConsoleResponse(response);
                }

                return response.StatusCode == HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Logs in to the account based on the credentials provided.
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        private bool LoginDirect()
        {
            try
            {
                RequestInfo req = new RequestInfo();
                RequestBuilder utils = new RequestBuilder();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Email;
                req.LoginPassword = string.IsNullOrEmpty(this.ApiPassword) == false ? this.ApiPassword : this.Password;
                req.DistributorCode = RestSettings.Instance.DistributorCode;
                req.DistributorPassword = RestSettings.Instance.DistributorPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}{1}", RestSettings.Instance.WebServiceUrl, "/login_information?api_password=true&include_account_id_guid=true");

                utils.Request = req;
                utils.Proxy = this.Proxy;

                ResponseInfo response = utils.MakeRESTRequest();
                this.Trace(utils, response);

                this.ParseLoginResponse(response);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Logs in to the account based on the Janrain token provided.
        /// </summary>
        /// <returns>true if successful, false otherwise</returns>
        private bool LoginSocial()
        {
            try
            {
                RequestInfo req = new RequestInfo();
                RequestBuilder utils = new RequestBuilder();

                req.RequestContentType = "application/json";
                req.AcceptContentType = "application/json";
                req.HttpMethod = "GET";
                req.LoginEmail = this.Email;
                //req.LoginEmail = "Janrain";
                req.LoginPassword = this.ApiPassword;
                req.IntegratorKey = RestSettings.Instance.IntegratorKey;
                req.Uri = string.Format("{0}{1}", RestSettings.Instance.WebServiceUrl, "/login_information?api_password=true&include_account_id_guid=true");

                utils.Request = req;
                utils.AuthorizationFlag = RequestBuilder.AuthOptions.FullCreds;
                utils.Proxy = this.Proxy;

                ResponseInfo response = utils.MakeRESTRequest();

                this.ParseLoginResponse(response);
                this.Trace(utils, response);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    this.ParseErrorResponse(response);
                }

                return response.StatusCode == HttpStatusCode.OK;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Parses Json text for Plans
        /// </summary>
        /// <param name="text">Json text</param>
        private void ParsePlans(string text)
        {
            var plans = Plans.FromJson(text);
        }

        /// <summary>
        /// Parses the Json response for a login action
        /// </summary>
        /// <param name="response">ResponseInfo object</param>
        private void ParseLoginResponse(ResponseInfo response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject json = JObject.Parse(response.ResponseText);

                if (json != null)
                {
                    this.ApiPassword = (string)json["apiPassword"];
                    foreach (JObject j in json["loginAccounts"])
                    {
                        this.AccountId = (string)j["accountId"];
                        string def = (string)j["isDefault"];
                        string guid = (string)j["accountIdGuid"];

                        if (string.IsNullOrEmpty(guid) == false)
                        {
                            this.AccountIdGuid = new Guid(guid);
                        }

                        if (def.Equals("true"))
                        {
                            this.BaseUrl = (string)j["baseUrl"];
                            this.AccountName = (string)j["userName"];
                            this.UserId = (string)j["userId"];
                            this.IsDefault = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Parses Json response containing errors
        /// </summary>
        /// <param name="response">ResponseInfo object</param>
        private void ParseConsoleResponse(ResponseInfo response)
        {
            if (response.StatusCode == HttpStatusCode.Created)
            {
                JObject json = JObject.Parse(response.ResponseText);

                if (json != null)
                {
                    this.ConsoleUrl = (string)json["url"];
                }
            }
        }

        /// <summary>
        /// Parses Json response containing errors
        /// </summary>
        /// <param name="response">ResponseInfo object</param>
        private void ParseErrorResponse(ResponseInfo response)
        {
            this.RestError = Error.FromJson(response.ResponseText);
        }

        /// <summary>
        /// Parses Json response to a create action
        /// </summary>
        /// <param name="response">ResponseInfo object</param>
        private void ParseCreateResponse(ResponseInfo response)
        {
            if (response.StatusCode == HttpStatusCode.Created)
            {
                JObject json = JObject.Parse(response.ResponseText);

                if (json != null)
                {
                    string acct = (string)json["accountIdGuid"];
                    this.AccountIdGuid = new Guid(acct);
                    this.AccountId = (string)json["accountId"];
                    this.ApiPassword = (string)json["apiPassword"];
                    this.BaseUrl = (string)json["baseUrl"];
                }
            }
        }

        /// <summary>
        /// Validates the SocialAccountInformation instance, if there is one.
        /// The object is not required, if other parameters have been provided.
        /// </summary>
        /// <returns>true if the SocialAccountInformation object is valid, false otherwise</returns>
        private bool ValidateSocial()
        {
            if (this.Social == null)
            {
                return false;
            }

            if ((string.IsNullOrEmpty(this.Social.email) == true) ||
                (string.IsNullOrEmpty(this.Social.provider) == true) ||
                (string.IsNullOrEmpty(this.Social.userName) == true))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Serializes Json classes into a string
        /// </summary>
        /// <returns>json string</returns>
        private string ConstructAssociateJson()
        {
            return JsonConvert.SerializeObject(this.Social);
        }

        /// <summary>
        /// Serializes Json classes into a string
        /// </summary>
        /// <returns>json string</returns>
        private string ConstructNewAccountJson()
        {
            try
            {
                AccountCreate ac = new AccountCreate();
                ac.accountName = this.AccountName;
                ac.distributorCode = RestSettings.Instance.DistributorCode;
                ac.distributorPassword = RestSettings.Instance.DistributorPassword;
                ac.socialAccountInformation = this.Social;
                ac.referrer = this.Referrer;
                ac.referrerProvidedCode = this.ReferrerProvidedCode;

                List<AccountSetting> acctSettings = new List<AccountSetting>();
                acctSettings.Add(new AccountSetting("attachCompletedEnvelope", "true"));
                acctSettings.Add(new AccountSetting("envelopeIntegrationAllowed", "full"));
                acctSettings.Add(new AccountSetting("autoNavRule", "all_fields"));
                acctSettings.Add(new AccountSetting("envelopeIntegrationEnabled", "true"));
                acctSettings.Add(new AccountSetting("attachCompletedEnvelope", "true"));
                acctSettings.Add(new AccountSetting("useAccountLevelEmail", "true"));

                ac.accountSettings = acctSettings.ToArray();

                ac.initialUser = new InitialUser();
                ac.initialUser.email = this.Email;
                ac.initialUser.password = this.Password;
                ac.initialUser.userName = this.AccountName;
                ac.initialUser.sendActivationOnInvalidLogin = false.ToString();

                List<UserSetting> userSettings = new List<UserSetting>();
                userSettings.Add(new UserSetting("canManageAccount", "true"));
                userSettings.Add(new UserSetting("canManageTemplates", "Create"));
                userSettings.Add(new UserSetting("canSendAPIRequests", "true"));
                userSettings.Add(new UserSetting("canSendEnvelope", "true"));
                userSettings.Add(new UserSetting("apiAccountWideAccess", "true"));
                userSettings.Add(new UserSetting("AllowSendOnBehalfOf", "true"));

                ac.initialUser.userSettings = userSettings.ToArray();

                ac.planInformation = new PlanInformation();
                ac.planInformation.planId = RestSettings.Instance.PlanId;
                List<PlanFeatureSet> features = new List<PlanFeatureSet>();

                features.Add(new PlanFeatureSet("featureSetId", RestSettings.Instance.FeatureSetId));
                features.Add(new PlanFeatureSet("isEnabled", true.ToString()));
                features.Add(new PlanFeatureSet("forceExpressSendOnly", false.ToString()));

                if (this.Address != null)
                {
                    ac.addressInformation = this.Address;
                }

                if (this.CreditCard != null)
                {
                    ac.creditCardInformation = this.CreditCard;
                }

                ac.planInformation.planFeatureSets = features.ToArray();

                string output = ac.Serialize();
                return output;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Serializes Json classes into a string
        /// </summary>
        /// <param name="user">NewUser object</param>
        /// <returns>json string</returns>
        private string ConstructNewUserJson(NewUser user)
        {
            try
            {
                if (string.IsNullOrEmpty(user.password.Trim()) == true)
                {
                    Guid g = Guid.NewGuid();
                    user.password = g.ToString();
                }

                AddUsers au = new AddUsers();
                List<NewUser> users = new List<NewUser>();
                users.Add(user);
                au.newUsers = users.ToArray();

                string output = au.Serialize();
                return output;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
