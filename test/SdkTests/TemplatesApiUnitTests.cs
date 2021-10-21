using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.Collections.Generic;
using System.Linq;
using DocuSign.eSign.Client.Auth;

namespace SdkTests
{
    [TestClass]
    public class TemplatesApiUnitTests
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
        public void JwtGetTemplates_CorrectAccountId_ReturnEnvelopeTemplateResults()
        {
            TemplatesApi templatesApi = new TemplatesApi(testConfig.ApiClient);
            EnvelopeTemplateResults envelopeTemplateResults = templatesApi.ListTemplates(testConfig.AccountId);
            
            Assert.IsNotNull(envelopeTemplateResults);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault()?.TemplateId);
        }

        [TestMethod]
        public void JwtGetTemplate_CorrectAccountIdAndTemplateId_ReturnEnvelopeTemplate()
        {
            TemplatesApi templatesApi = new TemplatesApi(testConfig.ApiClient);
            EnvelopeTemplateResults envelopeTemplateResults = templatesApi.ListTemplates(testConfig.AccountId);
            string templateId = envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault()?.TemplateId;

            Assert.IsNotNull(envelopeTemplateResults);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates);
            Assert.IsNotNull(templateId);

            EnvelopeTemplate envelopeTemplate = templatesApi.Get(testConfig.AccountId, templateId);

            Assert.IsNotNull(envelopeTemplate);
            Assert.AreEqual(envelopeTemplate.TemplateId, templateId);
        }
    }
}
