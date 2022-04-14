using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SdkNetCoreTests
{
    [TestClass]
    public class EnvelopesApiNetCoreUnitTests
    {
        private TestConfig _testConfig;
        private EnvelopesApi _envelopesApi;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
            _envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
        }

        private void JwtGetSampleEnvelopeIds()
        {
            if (_testConfig.EnvelopeIdsList.Count <= 0)
            {
                CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);
            }
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
        }

        [TestMethod]
        public void GetEnvelope_CorrectAccountIdAndEnvelopeId_ReturnEnvelope()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            Envelope envInfo = _envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);

            Assert.IsNotNull(envInfo?.EnvelopeId);
        }

        [TestMethod]
        public void ListRecipients_CorrectAccountIdAndEnvelopeId_ReturnRecipients()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            Recipients recipients = _envelopesApi.ListRecipients(_testConfig.AccountId, _testConfig.EnvelopeId);

            Assert.IsNotNull(recipients?.RecipientCount);
        }

        [TestMethod]
        public void ListStatusChanges_CorrectInputParameters_ReturnEnvelopesInformation()
        {
            DateTime fromDate = DateTime.UtcNow;
            fromDate = fromDate.AddDays(-30);
            var fromDateStr = fromDate.ToString("o");

            var options = new EnvelopesApi.ListStatusChangesOptions()
            {
                count = "10",
                fromDate = fromDateStr
            };

            EnvelopesInformation envelopes = _envelopesApi.ListStatusChanges(_testConfig.AccountId, options);

            Assert.IsNotNull(envelopes?.Envelopes[0]?.EnvelopeId);

            foreach (Envelope envelopesList in envelopes.Envelopes)
            {
                _testConfig.EnvelopeIdsList.Add(envelopesList.EnvelopeId);
            }
        }

        [TestMethod]
        public void ListStatusChanges_CorrectInputParametersAndSpecifiedEnvelopeIds_ReturnEnvelopesInformation()
        {
            JwtGetSampleEnvelopeIds();
            var envelopeIds = string.Join(", ", _testConfig.EnvelopeIdsList);

            var options = new EnvelopesApi.ListStatusChangesOptions()
            {
                envelopeIds = envelopeIds,
                fromDate = DateTime.Now.AddMonths(-1).ToString("o")
            };

            EnvelopesInformation envelopes = _envelopesApi.ListStatusChanges(_testConfig.AccountId, options);

            Assert.IsNotNull(envelopes?.Envelopes[0]?.EnvelopeId);
            Assert.IsNotNull(envelopes?.Envelopes[0]?.Status);
        }

        [TestMethod]
        public void ListStatus_CorrectInputParametersAndSpecifiedEnvelopeIdsInRequestBody_ReturnEnvelopesInformation()
        {
            JwtGetSampleEnvelopeIds();
            var envIdsRequest = new EnvelopeIdsRequest(_testConfig.EnvelopeIdsList);

            var options = new EnvelopesApi.ListStatusOptions()
            {
                envelopeIds = "request_body",
                fromDate = DateTime.Now.AddMonths(-1).ToString("o")
            };

            EnvelopesInformation envelopes = _envelopesApi.ListStatus(_testConfig.AccountId, envIdsRequest, options);

            Assert.IsNotNull(envelopes?.Envelopes[0]?.EnvelopeId);
            Assert.IsNotNull(envelopes?.Envelopes[0]?.Status);
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

        }

        [TestMethod]
        public void CreateSenderView_CorrectInputParameters_ReturnViewUrl()
        {
            var envelopeStatusCreated = "created";
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig, envelopeStatusCreated);

            var options = new ReturnUrlRequest
            {
                ReturnUrl = _testConfig.ReturnUrl
            };

            ViewUrl senderView = _envelopesApi.CreateSenderView(_testConfig.AccountId, _testConfig.EnvelopeId, options);

            Assert.IsNotNull(senderView?.Url);
        }

        [TestMethod]
        public void CreateRecipientView_CorrectInputParameters_ReturnViewUrl()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            var viewOptions = new RecipientViewRequest()
            {
                ReturnUrl = _testConfig.ReturnUrl,
                ClientUserId = "1234",
                AuthenticationMethod = "email",
                UserName = _testConfig.RecipientName,
                Email = _testConfig.RecipientEmail
            };

            ViewUrl recipientView = _envelopesApi.CreateRecipientView(_testConfig.AccountId, _testConfig.EnvelopeId, viewOptions);

            Assert.IsNotNull(recipientView?.Url);
        }

        [TestMethod]
        public void CreateConsoleView_CorrectInputParameters_ReturnViewUrl()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            var consoleViewRequest = new ConsoleViewRequest
            {
                EnvelopeId = _testConfig.EnvelopeId,
                ReturnUrl = _testConfig.ReturnUrl
            };

            ViewUrl viewUrl = _envelopesApi.CreateConsoleView(_testConfig.AccountId, consoleViewRequest);

            Assert.IsNotNull(viewUrl?.Url);
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
        }

        [TestMethod]
        public void ListTabs_CorrectInputParameters_ReturnTabs()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            Recipients recipients = _envelopesApi.ListRecipients(_testConfig.AccountId, _testConfig.EnvelopeId);

            Tabs tabs = _envelopesApi.ListTabs(_testConfig.AccountId, _testConfig.EnvelopeId, recipients.Signers.FirstOrDefault()?.RecipientId, new EnvelopesApi.ListTabsOptions { includeAnchorTabLocations = "true", includeMetadata = "true" });

            Assert.IsNotNull(tabs?.SignHereTabs);
        }

        [TestMethod]
        public void GetFormData_CorrectInputParameters_ReturnEnvelopeFormData()
        {
            var envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc"
            };

            var tRole = new TemplateRole
            {
                Email = _testConfig.RecipientEmail,
                Name = _testConfig.RecipientName,
                RoleName = "Manager"
            };

            var rolesList = new List<TemplateRole>() { tRole };

            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = _testConfig.TemplateId;

            envDef.Status = "sent";

            EnvelopeSummary envelopeSummary = _envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary?.EnvelopeId);

            EnvelopeFormData envFormData = _envelopesApi.GetFormData(_testConfig.AccountId, envelopeSummary.EnvelopeId);

            Assert.IsNotNull(envFormData?.FormData);
            Assert.IsNotNull(envFormData?.EnvelopeId);
        }

        [TestMethod]
        public void GetAuditEventsTest_CorrectAccountIdAndEnvelopeId_ReturnEnvelopeAuditEventResponse()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            EnvelopeAuditEventResponse listAuditEvents = _envelopesApi.ListAuditEvents(_testConfig.AccountId, _testConfig.EnvelopeId);
                
            Assert.IsNotNull(listAuditEvents?.AuditEvents);
        }

        [TestMethod]
        public void PostRecipientTabs_CorrectAccountIdEnvelopeIdRecipientIdAndTabs_ReturnTabs()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            var tabs = new Tabs();
            var approveTabs = new List<Approve>();
            var approveTab = new Approve
            {
                Status = "created",
                AnchorYOffset = "5",
                AnchorXOffset = "10",
                TabLabel = "new approve tab"
            };

            approveTabs.Add(approveTab);
            tabs.ApproveTabs = approveTabs;

            Recipients recipients = _envelopesApi.ListRecipients(_testConfig.AccountId, _testConfig.EnvelopeId);
            Tabs listTabs = _envelopesApi.CreateTabs(_testConfig.AccountId, _testConfig.EnvelopeId, recipients.Signers.FirstOrDefault()?.RecipientId, tabs);
            Assert.IsNotNull(listTabs?.ApproveTabs);
            Assert.IsTrue(listTabs.ApproveTabs.Exists(x => x.TabLabel == approveTab.TabLabel));
        }

        [TestMethod]
        public void PutEnvelope_CorrectAccountIdEnvelopeIdAndEnvelope_ReturnEnvelopeUpdateSummary()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            var envelope = new Envelope()
            {
                EnvelopeId = _testConfig.EnvelopeId,
                EmailSubject = "new email subject",
                EmailBlurb = "new email message",
                Status = "sent"
            };

            EnvelopeUpdateSummary envelopeUpdateSummary = _envelopesApi.Update(_testConfig.AccountId, _testConfig.EnvelopeId, envelope);
            Assert.IsNotNull(envelopeUpdateSummary?.EnvelopeId);

            Envelope renewedEnvelope = _envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);
            Assert.AreEqual(envelope.EmailSubject, renewedEnvelope.EmailSubject);
            Assert.AreEqual(envelope.EmailBlurb, renewedEnvelope.EmailBlurb);
            Assert.AreEqual(envelope.Status, renewedEnvelope.Status);
        }

        [TestMethod]
        public void PutRecipients_CorrectAccountIdEnvelopeIdAndRecipients_ReturnRecipientsUpdateSummary()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            var signHere = new SignHere()
            {
                Name = "SignHereTab",
                XPosition = "75",
                YPosition = "572",
                TabLabel = "SignHereTab",
                PageNumber = "1",
                DocumentId = "1",
                RecipientId = "1"
            };

            var signHereTabs = new List<SignHere> { signHere };

            var signerTabs = new Tabs()
            {
                SignHereTabs = signHereTabs
            };

            var newSigner = new Signer()
            {
                Name = "Test name",
                Email = "test@test.com",
                RoutingOrder = "1",
                Status = "created",
                DeliveryMethod = "Email",
                RecipientId = "1",
                Tabs = signerTabs,
                IdCheckConfigurationName = "ID Check"
            };

            var signers = new List<Signer> { newSigner };
            var recipients = new Recipients()
            {
                Signers = signers
            };

            RecipientsUpdateSummary recipientsUpdateSummary = _envelopesApi.UpdateRecipients(
                _testConfig.AccountId,
                _testConfig.EnvelopeId,
                recipients);

            Assert.IsNotNull(recipientsUpdateSummary?.RecipientUpdateResults);

            Recipients updatedListRecipients = _envelopesApi.ListRecipients(
                _testConfig.AccountId,
                _testConfig.EnvelopeId);

            Assert.IsTrue(updatedListRecipients.Signers.Exists(
                x => 
                    x.Name == newSigner.Name && x.Email == newSigner.Email));
        }
    }
}
