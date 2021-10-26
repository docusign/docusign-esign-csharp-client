using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;

namespace SdkNetCoreTests
{
    [TestClass]
    public class AuthNetCoreUnitTests
    {
        private TestConfig _testConfig;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }

        [TestMethod]
        public void CreateEnvelope_WrongTemplateId_ReturnApiException()
        {
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeDefinition envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc",
                TemplateId = "510fc78e-32f4-8778-44eb-6b53abb6c82E"
            };

            ApiException ex = Assert.ThrowsException<ApiException>(() => envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef));

            Assert.IsNotNull(ex);
            Assert.IsNotNull(ex.Headers);
        }

        [TestMethod]
        public void SetBasePath_MultibleBasePathUsed_BasePathIsChanged()
        {
            string configBasePath = _testConfig.ApiClient.Configuration.BasePath;
            string restBasePath = Convert.ToString(_testConfig.ApiClient.RestClient.BaseUrl);

            Assert.AreEqual(configBasePath, restBasePath);

            string testBasePath = "https://na.docusign.net/restapi";

            _testConfig.ApiClient.SetBasePath(testBasePath);

            Assert.AreEqual(testBasePath, Convert.ToString(_testConfig.ApiClient.RestClient.BaseUrl));
            Assert.AreEqual(testBasePath, _testConfig.ApiClient.Configuration.BasePath);

            _testConfig.ApiClient.SetBasePath(configBasePath);

            Assert.AreEqual(restBasePath, Convert.ToString(_testConfig.ApiClient.RestClient.BaseUrl));
            Assert.AreEqual(configBasePath, _testConfig.ApiClient.Configuration.BasePath);
        }

        [TestMethod]
        public void GetUserInfo_WrongAccessToken_ReturnsException()
        {
            string access_token = "---Invalid-Access-Token---";

            ApiException ex = Assert.ThrowsException<ApiException>(() => _testConfig.ApiClient.GetUserInfo(access_token));

            Assert.IsNotNull(ex);
            Assert.IsNotNull(ex.ErrorContent);

            int unauthorizedStatusCode = 401;
            Assert.AreEqual(ex.ErrorCode, unauthorizedStatusCode);
        }
    }
}
