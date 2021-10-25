using System.Collections.Generic;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkTests462
{
    [TestClass]
    public class FoldersApiUnitTests
    {
        private TestConfig _testConfig;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }

        [TestMethod]
        public void MoveEnvelopes_CorrectInputParameters_ReturnFolderResponse()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            FoldersApi foldersApi = new FoldersApi(_testConfig.ApiClient);
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            Envelope envelope = envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);
            Assert.IsNull(envelope.VoidedDateTime);
            FoldersRequest foldersRequest = new FoldersRequest(new List<string> { _testConfig.EnvelopeId });

            string ToFolderId = "recyclebin";

            foldersApi.MoveEnvelopes(_testConfig.AccountId, ToFolderId, foldersRequest);

            envelope = envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);
            Assert.IsNotNull(envelope.VoidedDateTime);
        }
    }
}
