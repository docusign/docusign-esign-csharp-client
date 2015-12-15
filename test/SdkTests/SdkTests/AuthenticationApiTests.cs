using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace SdkTests
{
    [TestClass]
    public class AuthenticationApiTests
    {   


        [TestMethod]
        public void LoginTest()
        {
            // configure the ApiClient for the DocuSign site and authentictaion needed.
            Utils.ConfigureApiClient();
         

            AuthenticationApi authApi = new AuthenticationApi();

            AuthenticationApi.LoginOptions options = new AuthenticationApi.LoginOptions();
            options.apiPassword = "true";
            options.includeAccountIdGuid = "true";
            LoginInformation loginInfo = authApi.Login(options);

            Assert.IsNotNull(loginInfo.LoginAccounts);

            // find the default account for this user
            foreach (LoginAccount loginAcct in loginInfo.LoginAccounts)
            {
                if (loginAcct.IsDefault == "true")
                {
                    TestConfig.AccountId = loginAcct.AccountId;
                    break;
                }
            }
            Assert.IsNotNull(TestConfig.AccountId);
                
        }
    }
}
