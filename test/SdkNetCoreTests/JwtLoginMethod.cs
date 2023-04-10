using System.Collections.Generic;
using System.IO;
using DocuSign.eSign.Client;
using DocuSign.eSign.Client.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SdkNetCoreTests
{
    class JwtLoginMethod
    {
        [TestMethod]
        public static void RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref TestConfig testConfig)
        {
            testConfig.ApiClient = new ApiClient(testConfig.Host);

            Assert.IsNotNull(testConfig?.PrivateKey);

            byte[] privateKeyStream = testConfig.PrivateKey;

            var scopes = new List<string> { OAuth.Scope_SIGNATURE, OAuth.Scope_IMPERSONATION };

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(
                testConfig.IntegratorKey,
                testConfig.UserId, 
                testConfig.OAuthBasePath, 
                privateKeyStream, 
                testConfig.ExpiresInHours, 
                scopes);

            Assert.IsNotNull(tokenInfo.access_token);

            using (MemoryStream ms = new MemoryStream(privateKeyStream))
            {
                OAuth.OAuthToken tokenInfoFromStream = testConfig.ApiClient.RequestJWTUserToken(
                    testConfig.IntegratorKey,
                    testConfig.UserId,
                    testConfig.OAuthBasePath,
                    ms,
                    testConfig.ExpiresInHours,
                    scopes);

                Assert.IsNotNull(tokenInfoFromStream.access_token);
            }

            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo?.Accounts);

            foreach (OAuth.UserInfo.Account item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    testConfig.AccountId = item.AccountId;
                    testConfig.ApiClient.SetBasePath(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig?.AccountId);
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref testConfig);
        }
    }
}
