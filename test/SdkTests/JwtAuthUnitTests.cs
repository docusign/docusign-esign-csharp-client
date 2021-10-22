using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;

namespace SdkTests
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
            EnvelopeDefinition envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc",
                // random incorrect guid
                TemplateId = "510fc78e-32f4-8778-44eb-6b53abb6c82E"
            };

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            ApiException ex = Assert.ThrowsException<ApiException>(() => envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef));

            Assert.IsNotNull(ex);
            Assert.IsNotNull(ex.Headers);
        }

        [TestMethod]
        public void SetBasePath_MultibleBasePathUsed_BasePathIsChanged()
        {
            var configBasePath = _testConfig.ApiClient.Configuration.BasePath;
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
        public void RequestJWTUserToken_WrongPrivateKeyUsed_ReturnsException()
        {
            var rsaKey = "---Invalid private key---";
            byte[] privateKeyStream = System.Text.Encoding.UTF8.GetBytes(rsaKey);

            Exception ex = Assert.ThrowsException<Exception>(() =>
                _testConfig.ApiClient.RequestJWTUserToken(
                    _testConfig.IntegratorKeyNoConsent,
                    _testConfig.UserId,
                    _testConfig.OAuthBasePath,
                    privateKeyStream,
                    _testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual(ex.Message, "Unexpected PEM type");
        }

        [TestMethod]
        public void RequestJWTUserToken_WrongIntegratorKeyUsed_ReturnsException()
        {
            byte[] privateKeyStream = _testConfig.PrivateKey;
            ApiException ex = Assert.ThrowsException<ApiException>(() =>
                _testConfig.ApiClient.RequestJWTUserToken(
                    _testConfig.IntegratorKeyNoConsent,
                    _testConfig.UserId,
                    _testConfig.OAuthBasePath,
                    privateKeyStream,
                    _testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual("{\"error\":\"invalid_grant\",\"error_description\":\"no_valid_keys_or_signatures\"}", ex.ErrorContent);
        }

        [TestMethod]
        public void RequestJWTUserToken_PrivateKeyWithoutConsentUsed_ReturnsException()
        {
            byte[] pkey = _testConfig.PrivateKeyNoConsent;
            ApiException ex = Assert.ThrowsException<ApiException>(() =>
                _testConfig.ApiClient.RequestJWTUserToken(
                    _testConfig.IntegratorKeyNoConsent,
                    _testConfig.UserId,
                    _testConfig.OAuthBasePath,
                    pkey,
                    _testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
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
