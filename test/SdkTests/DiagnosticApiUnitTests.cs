using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using DocuSign.eSign.Client.Auth;
using System.Text;

namespace SdkTests
{
    [TestClass]
    public class DiagnosticApiUnitTests
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

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey,
                testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours, scopes);

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
        public void JwtGetSettingTest()
        {
            DiagnosticsApi diagnosticsApi = new DiagnosticsApi(testConfig.ApiClient);
            ApiResponse<DiagnosticsSettingsInformation> diagnosticsSettingsInformation = diagnosticsApi.GetRequestLogSettingsWithHttpInfo();
            Assert.IsNotNull(diagnosticsSettingsInformation);
            Assert.IsNotNull(diagnosticsSettingsInformation.Data.ApiRequestLogMaxEntries);
            Assert.IsNotNull(diagnosticsSettingsInformation.Data.ApiRequestLogRemainingEntries);
            Assert.IsNotNull(diagnosticsSettingsInformation.Data.ApiRequestLogging);

            //Test the Http Response Headers
            var headers = diagnosticsSettingsInformation.Headers;
            var x_RateLimit_Remaining_Header = headers["X-RateLimit-Remaining"];
            var x_RateLimit_Limit_Header = headers["X-RateLimit-Limit"];

            Assert.IsNotNull(x_RateLimit_Remaining_Header);
            Assert.IsNotNull(x_RateLimit_Limit_Header);
        }
    }
}
