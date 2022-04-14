using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;
using System.Collections.Generic;

namespace SdkTests
{
    [TestClass]
    public class FoldersApiUnitTests
    {
        private TestConfig _testConfig;
        private FoldersApi _foldersApi;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
            _foldersApi = new FoldersApi(_testConfig.ApiClient);
        }

        [TestMethod]
        public void MoveEnvelopes_CorrectInputParameters_ReturnFolderResponse()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            var envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            Envelope envelope = envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);
            Assert.IsNull(envelope?.VoidedDateTime);
            var foldersRequest = new FoldersRequest(new List<string> { _testConfig.EnvelopeId });

            var ToFolderId = "recyclebin";

            _foldersApi.MoveEnvelopes(_testConfig.AccountId, ToFolderId, foldersRequest);

            envelope = envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);
            Assert.IsNotNull(envelope?.VoidedDateTime);
        }
    }
}
