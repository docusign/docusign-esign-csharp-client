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
        private TestConfig _testConfig = new TestConfig();

        public FoldersApiUnitTests()
        {
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }

        [TestMethod]
        public void ListItems_CorrectInputParameters_ReturnFolderItemsResponse()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            FoldersApi foldersApi = new FoldersApi(_testConfig.ApiClient);

            var fromFolderId = "sentitems";

            FoldersRequest foldersRequest = new FoldersRequest(new List<string> { _testConfig.EnvelopeId }, FromFolderId: fromFolderId);

            string ToFolderId = "draft";

            foldersApi.MoveEnvelopes(_testConfig.AccountId, ToFolderId, foldersRequest);

            FoldersApi.ListItemsOptions searchOptions = new FoldersApi.ListItemsOptions();

            var listFromDraftsFolder = foldersApi.ListItems(_testConfig.AccountId, ToFolderId, searchOptions);

            Assert.IsNotNull(listFromDraftsFolder);

            bool doesExists = false;
            foreach (var folder in listFromDraftsFolder.Folders)
            {
                foreach (var item in folder.FolderItems)
                {
                    if (item.EnvelopeId == _testConfig.EnvelopeId)
                    {
                        doesExists = true;
                        break;
                    }
                }
            }

            Assert.IsTrue(doesExists);
        }
    }
}
