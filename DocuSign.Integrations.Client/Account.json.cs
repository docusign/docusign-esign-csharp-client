// -----------------------------------------------------------------------
// <copyright file="Account.json.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace DocuSignClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Json class for social account information
    /// </summary>
    [Serializable]
    public class SocialAccountInformation
    {
        /// <summary>
        /// Initializes a new instance of the SocialAccountInformation class
        /// </summary>
        public SocialAccountInformation()
        {
        }

        /// <summary>
        /// Gets or sets the provider property
        /// </summary>
        public string provider { get; set; }

        /// <summary>
        /// Gets or sets the email property
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the social id property
        /// </summary>
        public string socialId { get; set; }

        /// <summary>
        /// Gets or sets the user name property
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>AccountCreate instance</returns>
        public static SocialAccountInformation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SocialAccountInformation>(json);
        }

        /// <summary>
        /// Serializes self
        /// </summary>
        /// <returns>serialized Json text</returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// Json class for creating a new account
    /// </summary>
    [Serializable]
    public class AccountCreate
    {
        /// <summary>
        /// Initializes a new instance of the AccountCreate class.
        /// </summary>
        public AccountCreate()
        {
        }

        /// <summary>
        /// Gets or sets the account name
        /// </summary>
        public string accountName { get; set; }

        /// <summary>
        /// Gets or sets the account settings
        /// </summary>
        public AccountSetting[] accountSettings { get; set; }

        /// <summary>
        /// Gets or sets the address property
        /// </summary>
        public AddressInformation addressInformation { get; set; }

        /// <summary>
        /// Gets or sets the credit card property
        /// </summary>
        public CreditCardInformation creditCardInformation { get; set; }

        /// <summary>
        /// Gets or sets the SocialAccountInformation property
        /// </summary>
        public SocialAccountInformation socialAccountInformation { get; set; }

        /// <summary>
        /// Gets or sets the distributor code
        /// </summary>
        public string distributorCode { get; set; }

        /// <summary>
        /// Gets or sets the distributor password
        /// </summary>
        public string distributorPassword { get; set; }

        /// <summary>
        /// Gets or sets the referrer name
        /// </summary>
        public string referrer { get; set; }

        /// <summary>
        /// Gets or sets the referrer code
        /// </summary>
        public string referrerProvidedCode { get; set; }

        /// <summary>
        /// Gets or sets the InitialUser property 
        /// </summary>
        public InitialUser initialUser { get; set; }

        /// <summary>
        /// Gets or sets the PlanInformation property
        /// </summary>
        public PlanInformation planInformation { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>AccountCreate instance</returns>
        public static AccountCreate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AccountCreate>(json);
        }

        /// <summary>
        /// Serializes self
        /// </summary>
        /// <returns>serialized Json text</returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// Json class for associating a social account with an existing account
    /// </summary>
    [Serializable]
    public class AccountAssociate
    {
        /// <summary>
        /// Initializes a new instance of the AccountAssociate class
        /// </summary>
        public AccountAssociate()
        {
        }

        /// <summary>
        /// Gets or sets the SocialAccountInformation property
        /// </summary>
        public SocialAccountInformation socialAccountInformation { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>AccountCreate instance</returns>
        public static AccountAssociate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AccountAssociate>(json);
        }

        /// <summary>
        /// Serializes self
        /// </summary>
        /// <returns>serialized Json text</returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// Json class for adding users to an account
    /// </summary>
    [Serializable]
    public class AddUsers
    {
        /// <summary>
        /// Gets or sets the new users property
        /// </summary>
        public NewUser[] newUsers { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>AddUsers instance</returns>
        public static AddUsers FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AddUsers>(json);
        }

        /// <summary>
        /// Serializes self
        /// </summary>
        /// <returns>serialized Json text</returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// Json class for new user
    /// </summary>
    [Serializable]
    public class NewUser
    {
        /// <summary>
        /// Gets or sets the activation code
        /// </summary>
        public string ActivationAccessCode { get; set; }

        /// <summary>
        /// Gets or sets the email property
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the password property
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Gets or sets the user first name property
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Gets or sets the user last name property
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Gets or sets the user middle name property
        /// </summary>
        public string middleName { get; set; }

        /// <summary>
        /// Gets or sets the user name suffix property
        /// </summary>
        public string suffixName { get; set; }

        /// <summary>
        /// Gets or sets the user title property
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the user name property
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// Gets or sets this user property
        /// </summary>
        public string enableConnectForUser { get; set; }

        /// <summary>
        /// Gets or sets this user property
        /// </summary>
        public string sendActivationOnInvalidLogin { get; set; }

        /// <summary>
        /// Gets or sets the forgotten password property
        /// </summary>
        public ForgottenPasswordInfo forgottenPasswordInfo { get; set; }

        /// <summary>
        /// Gets or sets the user settings property
        /// </summary>
        public UserSetting[] userSettings { get; set; }
    }

    /// <summary>
    /// Json class for forgotten password information
    /// </summary>
    [Serializable]
    public class ForgottenPasswordInfo
    {
        /// <summary>
        /// Gets or sets the forgotten password answer 1
        /// </summary>
        public string ForgottenPasswordAnswer1 { get; set; }

        /// <summary>
        /// Gets or sets the forgotten password answer 2
        /// </summary>
        public string ForgottenPasswordAnswer2 { get; set; }

        /// <summary>
        /// Gets or sets the forgotten password answer 3
        /// </summary>
        public string ForgottenPasswordAnswer3 { get; set; }

        /// <summary>
        /// Gets or sets the forgotten password answer 4
        /// </summary>
        public string ForgottenPasswordAnswer4 { get; set; }

        /// <summary>
        /// Gets or sets the forgotten password question 1
        /// </summary>
        public string ForgottenPasswordQuestion1 { get; set; }

        /// <summary>
        /// Gets or sets the forgotten password question 2
        /// </summary>
        public string ForgottenPasswordQuestion2 { get; set; }

        /// <summary>
        /// Gets or sets the forgotten password question 3
        /// </summary>
        public string ForgottenPasswordQuestion3 { get; set; }

        /// <summary>
        /// Gets or sets the forgotten password question 4
        /// </summary>
        public string ForgottenPasswordQuestion4 { get; set; }
    }

    /// <summary>
    /// Created users class
    /// </summary>
    [Serializable]
    public class CreatedUsers
    {
        /// <summary>
        /// Gets or sets array of new user objects
        /// </summary>
        public CreatedUser[] NewUsers { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>CreatedUsers instance</returns>
        public static CreatedUsers FromJson(string json)
        {
            return JsonConvert.DeserializeObject<CreatedUsers>(json);
        }

        /// <summary>
        /// Serializes self
        /// </summary>
        /// <returns>serialized Json text</returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// Error details class
    /// </summary>
    [Serializable]
    public class ErrorDetails
    {
        /// <summary>
        /// Gets or sets the error code
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error message
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// Created user class
    /// </summary>
    [Serializable]
    public class CreatedUser
    {
        /// <summary>
        /// Gets or sets the api password property
        /// </summary>
        public string ApiPassword { get; set; }
        
        /// <summary>
        /// Gets or sets the X property
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the error details property
        /// </summary>
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets the uri property
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the user id property
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the user name property
        /// </summary>
        public string UserName { get; set; }
    }

    /// <summary>
    /// Json class for account settings
    /// </summary>
    [Serializable]
    public class AccountSetting
    {
        /// <summary>
        /// Initializes a new instance of the AccountSetting class
        /// </summary>
        /// <param name="name">setting name</param>
        /// <param name="value">setting value</param>
        public AccountSetting(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the AccountSetting class
        /// </summary>
        public AccountSetting()
        {
        }

        /// <summary>
        /// Gets or sets the name property
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string value { get; set; }
    }

    /// <summary>
    /// Json class for user settings
    /// </summary>
    [Serializable]
    public class UserSetting
    {
        /// <summary>
        /// Initializes a new instance of the UserSetting class
        /// </summary>
        /// <param name="name">setting name</param>
        /// <param name="value">setting value</param>
        public UserSetting(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the UserSetting class
        /// </summary>
        public UserSetting()
        {
        }

        /// <summary>
        /// Gets or sets the name property
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string value { get; set; }
    }

    /// <summary>
    /// Json class for address settings
    /// </summary>
    [Serializable]
    public class AddressInformation
    {
        /// <summary>
        /// Initializes a new instance of the AddressInformation class
        /// </summary>
        public AddressInformation()
        {
        }

        /// <summary>
        /// Gets or sets the name property
        /// </summary>
        public string address1 { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string address2 { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string fax { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string postalCode { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string state { get; set; }
    }

    /// <summary>
    /// Json class for credit card settings
    /// </summary>
    [Serializable]
    public class CreditCardInformation
    {
        /// <summary>
        /// Initializes a new instance of the CreditCardInformation class
        /// </summary>
        public CreditCardInformation()
        {
        }

        /// <summary>
        /// Gets or sets the name property
        /// </summary>
        public string cardNumber { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string cardType { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string expirationMonth { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string expirationYear { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string nameOnCard { get; set; }
    }

    /// <summary>
    /// Json class for initial user settings
    /// </summary>
    [Serializable]
    public class InitialUser
    {
        /// <summary>
        /// Initializes a new instance of the InitialUser class
        /// </summary>
        public InitialUser()
        {
        }

        /// <summary>
        /// Gets or sets the email property
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Gets or sets the password property
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Gets or sets the user name property
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// Gets or sets the sendActivationOnInvalidLogin property
        /// </summary>
        public string sendActivationOnInvalidLogin { get; set; }

        /// <summary>
        /// Gets or sets the userSettings property
        /// </summary>
        public UserSetting[] userSettings { get; set; }
    }

    /// <summary>
    /// Json class for Plan feature set
    /// </summary>
    [Serializable]
    public class PlanFeatureSet
    {
        /// <summary>
        /// Initializes a new instance of the PlanFeatureSet class
        /// </summary>
        /// <param name="name">setting name</param>
        /// <param name="value">setting value</param>
        public PlanFeatureSet(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the PlanFeatureSet class
        /// </summary>
        public PlanFeatureSet()
        {
        }

        /// <summary>
        /// Gets or sets the name property
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the value property
        /// </summary>
        public string value { get; set; }
    }

    /// <summary>
    /// Json class for Plan information
    /// </summary>
    [Serializable]
    public class PlanInformation
    {
        /// <summary>
        /// Initializes a new instance of the PlanInformation class
        /// </summary>
        public PlanInformation()
        {
        }

        /// <summary>
        /// Gets or sets the plan id property
        /// </summary>
        public string planId { get; set; }

        /// <summary>
        /// Gets or sets the feature sets property
        /// </summary>
        public PlanFeatureSet[] planFeatureSets { get; set; }
    }

    /// <summary>
    /// Billing plans class
    /// </summary>
    [Serializable]
    public class Plans
    {
        /// <summary>
        /// Gets or sets the billing plans array
        /// </summary>
        public BillingPlan[] BillingPlans { get; set; }

        /// <summary>
        /// Deserializes Json text into the object's properties
        /// </summary>
        /// <param name="json">string of Json text</param>
        /// <returns>Plans instance</returns>
        public static Plans FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Plans>(json);
        }

        /// <summary>
        /// Serializes self
        /// </summary>
        /// <returns>serialized Json text</returns>
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// Billing plan class
    /// </summary>
    [Serializable]
    public class BillingPlan
    {
        /// <summary>
        /// Gets or sets enable support property
        /// </summary>
        public string EnableSupport { get; set; }

        /// <summary>
        /// Gets or sets included seats property
        /// </summary>
        public string IncludedSeats { get; set; }

        /// <summary>
        /// Gets or sets other discount % property
        /// </summary>
        public string OtherDiscountPercent { get; set; }

        /// <summary>
        /// Gets or sets payment cycle property
        /// </summary>
        public string PaymentCycle { get; set; }

        /// <summary>
        /// Gets or sets payment method property
        /// </summary>
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets per seat price property
        /// </summary>
        public string PerSeatPrice { get; set; }

        /// <summary>
        /// Gets or sets plan id property
        /// </summary>
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or sets plan name property
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// Gets or sets support incident fee property
        /// </summary>
        public string SupportIncidentFee { get; set; }

        /// <summary>
        /// Gets or sets support plan fee property
        /// </summary>
        public string SupportPlanFee { get; set; }
    }
}
