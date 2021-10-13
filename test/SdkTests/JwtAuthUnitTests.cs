using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Client;
using System.Collections.Generic;
using DocuSign.eSign.Client.Auth;

namespace SdkTests
{
    [TestClass]
    public class JwtAuthUnitTests
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
        public void SetBasePathTest()
        {
            // Prepare
            var configBasePath = testConfig.ApiClient.RestClient.BaseUrl;
            var restBasePath = testConfig.ApiClient.RestClient.BaseUrl;

            // Test is everything initialized properly
            Assert.AreEqual(configBasePath, restBasePath);

            // Test a new basepath
            var testBasePath = "na.docusign.net/restapi";

            testConfig.ApiClient.SetBasePath(testBasePath);

            // Assert
            Assert.AreEqual(testBasePath, testConfig.ApiClient.RestClient.BaseUrl);
            Assert.AreEqual(testBasePath, testConfig.ApiClient.RestClient.BaseUrl);

            // Rest
            testConfig.ApiClient.SetBasePath(testConfig.OAuthBasePath);

            // Assert
            Assert.AreEqual(restBasePath, testConfig.ApiClient.RestClient.BaseUrl);
            Assert.AreEqual(configBasePath, testConfig.ApiClient.RestClient.BaseUrl);
        }

        [TestMethod]
        public void JwtUnexpectedPEMTypeTest()
        {
            var rsaKey = "---Invalid private key---";
            // Create a stream of bytes... 
            byte[] privateKeyStream = System.Text.Encoding.UTF8.GetBytes(rsaKey);

            Exception ex = Assert.ThrowsException<Exception>(() => testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKeyNoConsent, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual(ex.Message, "Unexpected PEM type");
        }

        [TestMethod]
        public void JwtInvalidGrantTest()
        {
            // Adding a WRONG PEM key 
            byte[] privateKeyStream = testConfig.PrivateKey;
            ApiException ex = Assert.ThrowsException<ApiException>(() => testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKeyNoConsent, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual("{\"error\":\"invalid_grant\",\"error_description\":\"no_valid_keys_or_signatures\"}", ex.ErrorContent);
        }

        [TestMethod]
        public void JwtConsentRequiredTest()
        {
            // Adding a Correct PEM key - no consent granted
            byte[] pkey = Convert.FromBase64String(testConfig.PrivateKeyNoConsent);
            ApiException ex = Assert.ThrowsException<ApiException>(() => testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKeyNoConsent, testConfig.UserId, testConfig.OAuthBasePath, pkey, testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            // Assert.AreEqual(ex.ErrorContent, "{\"error\":\"consent_required\"}");
        }

        [TestMethod]
        public void JwtInvalidAccessToken_Unauthorized_Test()
        {
            string access_token = "---Invalid-Access-Token---";

            ApiException ex = Assert.ThrowsException<ApiException>(() => testConfig.ApiClient.GetUserInfo(access_token));

            Assert.IsNotNull(ex);
            Assert.IsNotNull(ex.ErrorContent);

            int unauthorizedStatusCode = 401;
            Assert.AreEqual(ex.ErrorCode, unauthorizedStatusCode);
        }
    }
}
