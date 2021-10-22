using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;
using System.Collections.Generic;

namespace SdkNetCoreTests
{
    [TestClass]
    public class FoldersApiNetCoreUnitTests
    {
        private TestConfig _testConfig = new TestConfig();

        public FoldersApiNetCoreUnitTests()
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
            Assert.IsTrue(IsEnvelopeIdInFolderItems(listFromDraftsFolder, _testConfig.EnvelopeId));
        }

        public bool IsEnvelopeIdInFolderItems(FolderItemsResponse folderItemsResponse, string envelopeId)
        {
            foreach (var folder in folderItemsResponse.Folders)
            {
                if (folder == null)
                    continue;
                foreach (var item in folder.FolderItems)
                {
                    if (item.EnvelopeId == envelopeId)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
