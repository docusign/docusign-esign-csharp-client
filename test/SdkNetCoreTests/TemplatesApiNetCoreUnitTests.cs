using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using DocuSign.eSign.Client.Auth;
using System.Text;
using System.Linq;

namespace SdkNetCoreTests
{
    [TestClass]
    public class TemplatesApiNetCoreUnitTests
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
        public void JwtGetTemplatesTest()
        {
            TemplatesApi templatesApi = new TemplatesApi(testConfig.ApiClient);
            EnvelopeTemplateResults envelopeTemplateResults = templatesApi.ListTemplates(testConfig.AccountId);
            Assert.IsNotNull(envelopeTemplateResults);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault().TemplateId);
        }

        [TestMethod]
        public void JwtGetTemplateTest()
        {
            TemplatesApi templatesApi = new TemplatesApi(testConfig.ApiClient);
            EnvelopeTemplateResults envelopeTemplateResults = templatesApi.ListTemplates(testConfig.AccountId);
            Assert.IsNotNull(envelopeTemplateResults);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault().TemplateId);

            EnvelopeTemplate envelopeTemplate = templatesApi.Get(testConfig.AccountId, envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault()?.TemplateId);
            Assert.IsNotNull(envelopeTemplate);
            Assert.IsNotNull(envelopeTemplate.TemplateId);
        }
    }
}
