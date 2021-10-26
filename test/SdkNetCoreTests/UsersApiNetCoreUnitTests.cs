using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;
using System.Collections.Generic;
using System.Linq;

namespace SdkNetCoreTests
{
    [TestClass]
    public class UsersApiNetCoreUnitTests
    {
        private TestConfig _testConfig;
        private UsersApi _usersApi;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
            _usersApi = new UsersApi(_testConfig.ApiClient);
        }

        [TestMethod]
        public void JwtGetUsers_CorrectAccountId_ReturnUserInformationList()
        {
            UserInformationList userInformationList = _usersApi.List(_testConfig.AccountId);

            Assert.IsNotNull(userInformationList?.Users?.FirstOrDefault()?.UserId);
        }

        [TestMethod]
        public void JwtPostUsers_CorrectAccountIdAndNewUsersDefinition_ReturnNewUsersSummary()
        {
            var user = new UserInformation();
            var userInformation = new List<UserInformation>();
            var usersDefinition = new NewUsersDefinition();

            user.Email = "test@test.com";
            user.UserName = "Test User";
            
            userInformation.Add(user);
            usersDefinition.NewUsers = userInformation;

            NewUsersSummary userInformationList = _usersApi.Create(_testConfig.AccountId, usersDefinition);
            
            Assert.IsNotNull(userInformationList?.NewUsers?.Exists(x => x.Email == user.Email && x.UserName == user.UserName));
        }
    }
}
