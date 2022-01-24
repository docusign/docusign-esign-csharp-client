using System;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkTests462
{
    [TestClass]
    public class AuthUnitTests
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
            var envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc",
                TemplateId = "510fc78e-32f4-8778-44eb-6b53abb6c82E"
            };

            var envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            ApiException ex = Assert.ThrowsException<ApiException>(() => envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef));

            Assert.IsNotNull(ex?.Headers);
        }

        [TestMethod]
        public void SetBasePath_MultibleBasePathUsed_BasePathIsChanged()
        {
            string configBasePath = _testConfig.ApiClient.Configuration.BasePath;
            var restBasePath = Convert.ToString(_testConfig.ApiClient.RestClient.BaseUrl);

            Assert.AreEqual(configBasePath, restBasePath);

            var testBasePath = "https://na.docusign.net/restapi";

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
            var access_token = "---Invalid-Access-Token---";

            ApiException ex = Assert.ThrowsException<ApiException>(() => _testConfig.ApiClient.GetUserInfo(access_token));

            Assert.IsNotNull(ex?.ErrorContent);

            int unauthorizedStatusCode = 401;
            Assert.AreEqual(ex.ErrorCode, unauthorizedStatusCode);
        }
    }
}
