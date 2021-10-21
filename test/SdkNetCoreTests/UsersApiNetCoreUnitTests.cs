using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.Collections.Generic;
using DocuSign.eSign.Client.Auth;
using System.Linq;
using SdkTests;

namespace SdkNetCoreTests
{
    [TestClass]
    public class UsersApiNetCoreUnitTests
    {
        TestConfig testConfig = new TestConfig();

        [TestInitialize()]
        [TestMethod]
        public void JwtLoginTest()
        {
            testConfig.ApiClient = new ApiClient(testConfig.Host);

            Assert.IsNotNull(testConfig.PrivateKey);

            byte[] privateKeyStream = testConfig.PrivateKey;

            List<string> scopes = new List<string>();
            scopes.Add(OAuth.Scope_SIGNATURE);
            scopes.Add(OAuth.Scope_IMPERSONATION);

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours, scopes);
            // Disposing the stream...

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.Accounts);

            foreach (var item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    testConfig.AccountId = item.AccountId;
                    testConfig.ApiClient.SetBasePath(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig.AccountId);
        }

        [TestMethod]
        public void JwtGetUsers_CorrectAccountId_ReturnUserInformationList()
        {
            UsersApi usersApi = new UsersApi(testConfig.ApiClient);
            UserInformationList userInformationList = usersApi.List(testConfig.AccountId);
            Assert.IsNotNull(userInformationList);
            Assert.IsNotNull(userInformationList.Users);
            Assert.IsNotNull(userInformationList.Users.FirstOrDefault()?.UserId);
        }

        [TestMethod]
        public void JwtPostUsers_CorrectAccountIdAndNewUsersDefinition_ReturnNewUsersSummary()
        {
            UsersApi usersApi = new UsersApi(testConfig.ApiClient);

            UserInformation user = new UserInformation();
            List<UserInformation> userInformation = new List<UserInformation>();
            NewUsersDefinition usersDefinition = new NewUsersDefinition();

            user.Email = "test@test.com";
            user.UserName = "Test User";
            
            userInformation.Add(user);
            usersDefinition.NewUsers = userInformation;

            NewUsersSummary userInformationList = usersApi.Create(testConfig.AccountId, usersDefinition);
            
            Assert.IsNotNull(userInformationList);
            Assert.IsNotNull(userInformationList.NewUsers);
            Assert.IsNotNull(userInformationList.NewUsers.Exists(x => x.Email == user.Email && x.UserName == user.UserName));
        }
    }
}
