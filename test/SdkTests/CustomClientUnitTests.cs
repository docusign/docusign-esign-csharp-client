using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Client.Auth;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SdkTests
{
    class CustomClient : DocuSignClient
    {
        public string RequestUrl { get; set; } = string.Empty;

        public int StatusCode { get; set; } = 0;

        public CustomClient(string apiBase, IWebProxy proxy = null) : base(apiBase, proxy)
        {
        }

        public override void InterceptRequest(DocuSignRequest request)
        {
            RequestUrl = request.Url;
        }

        public override void InterceptResponse(DocuSignRequest request, DocuSignResponse response)
        {
            StatusCode = (int)response.StatusCode;
        }
    }

    [TestClass]
    public class CustomClientUnitTests
    {
        private TestConfig _testConfig;
        private EnvelopesApi _envelopesApi;

        void RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref TestConfig testConfig)
        {
            testConfig.ApiClient = new CustomClient(testConfig.Host);

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

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
            _envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
        }

        [TestMethod]
        public void CreateEnvelope_CorrectInputParametersAndTemplateReference_ReturnEnvelopeSummary()
        {
            var envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc"
            };

            var tRole = new TemplateRole
            {
                Email = _testConfig.RecipientEmail,
                Name = _testConfig.RecipientName,
                RoleName = _testConfig.TemplateRoleName
            };

            var rolesList = new List<TemplateRole>() { tRole };

            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = _testConfig.TemplateId;

            envDef.Status = "sent";

            EnvelopeSummary envelopeSummary = _envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary?.EnvelopeId);

            this._testConfig.EnvelopeId = envelopeSummary.EnvelopeId;

            CustomClient customClient = _testConfig.ApiClient as CustomClient;

            Assert.IsTrue(!string.IsNullOrEmpty(customClient.RequestUrl));
            Assert.IsTrue(customClient.StatusCode != 0);
        }

        [TestMethod]
        public void GetDocument_CorrectInputParameters_ReturnMemoryStream()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            EnvelopeDocumentsResult docsList = _envelopesApi.ListDocuments(_testConfig.AccountId, _testConfig.EnvelopeId);

            Assert.IsNotNull(docsList?.EnvelopeId);

            int docCount = docsList.EnvelopeDocuments.Count;

            for (int i = 0; i < docCount; i++)
            {
                Assert.IsNotNull(docsList?.EnvelopeDocuments[i]?.DocumentId);

                MemoryStream docStream = (MemoryStream)_envelopesApi.GetDocument(
                    _testConfig.AccountId,
                    _testConfig.EnvelopeId,
                    docsList.EnvelopeDocuments[i].DocumentId);

                Assert.IsNotNull(docStream);

                string filePath = Path.GetTempPath() + Path.GetRandomFileName() + ".pdf";
                var fs = new FileStream(filePath, FileMode.Create);
                docStream.Seek(0, SeekOrigin.Begin);
                docStream.CopyTo(fs);
                fs.Close();
                Assert.IsNotNull(filePath);
            }

            CustomClient customClient = _testConfig.ApiClient as CustomClient;

            Assert.IsTrue(!string.IsNullOrEmpty(customClient.RequestUrl));
            Assert.IsTrue(customClient.StatusCode != 0);
        }

        [TestMethod]
        public void CreateEnvelopeWithHttpInfo_CorrectInputParameters_ReturnsApiResponseWithHeaders()
        {
            var envDef = new EnvelopeDefinition();

            ApiResponse<EnvelopeSummary> envelopeSummary = _envelopesApi.CreateEnvelopeWithHttpInfo(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary?.Headers);
            Assert.IsNotNull(envelopeSummary?.Data?.EnvelopeId);

            IDictionary<string, string> headers = envelopeSummary.Headers;
            var xRateLimitRemainingHeader = headers["X-RateLimit-Remaining"];
            var xRateLimitLimitHeader = headers["X-RateLimit-Limit"];

            Assert.IsNotNull(xRateLimitRemainingHeader);
            Assert.IsNotNull(xRateLimitLimitHeader);

            CustomClient customClient = _testConfig.ApiClient as CustomClient;

            Assert.IsTrue(!string.IsNullOrEmpty(customClient.RequestUrl));
            Assert.IsTrue(customClient.StatusCode != 0);
        }
    }
}
