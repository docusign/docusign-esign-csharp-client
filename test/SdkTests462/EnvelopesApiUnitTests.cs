using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkTests462
{
    [TestClass]
    public class EnvelopesApiUnitTests
    {
        private TestConfig _testConfig;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
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
            EnvelopeDefinition envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc"
            };

            TemplateRole tRole = new TemplateRole
            {
                Email = _testConfig.RecipientEmail,
                Name = _testConfig.RecipientName,
                RoleName = _testConfig.TemplateRoleName
            };

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = _testConfig.TemplateId;

            envDef.Status = "sent";

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            this._testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }

        [TestMethod]
        public void GetEnvelope_CorrectAccountIdAndEnvelopeId_ReturnEnvelope()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            Envelope envInfo = envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);

            Assert.IsNotNull(envInfo);
            Assert.IsNotNull(envInfo.EnvelopeId);
        }

        [TestMethod]
        public void ListRecipients_CorrectAccountIdAndEnvelopeId_ReturnRecipients()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            Recipients recipients = envelopesApi.ListRecipients(_testConfig.AccountId, _testConfig.EnvelopeId);

            Assert.IsNotNull(recipients);
            Assert.IsNotNull(recipients.RecipientCount);
        }

        [TestMethod]
        public void ListStatusChanges_CorrectInputParameters_ReturnEnvelopesInformation()
        {
            DateTime fromDate = DateTime.UtcNow;
            fromDate = fromDate.AddDays(-30);
            string fromDateStr = fromDate.ToString("o");

            EnvelopesApi.ListStatusChangesOptions options = new EnvelopesApi.ListStatusChangesOptions()
            {
                count = "10",
                fromDate = fromDateStr
            };

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopesInformation envelopes = envelopesApi.ListStatusChanges(_testConfig.AccountId, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);

            foreach (var envelopesList in envelopes.Envelopes)
            {
                _testConfig.EnvelopeIdsList.Add(envelopesList.EnvelopeId);
            }
        }

        [TestMethod]
        public void ListStatusChanges_CorrectInputParametersAndSpecifiedEnvelopeIds_ReturnEnvelopesInformation()
        {
            JwtGetSampleEnvelopeIds();
            var envelopeIds = string.Join(", ", _testConfig.EnvelopeIdsList);

            EnvelopesApi.ListStatusChangesOptions options = new EnvelopesApi.ListStatusChangesOptions()
            {
                envelopeIds = envelopeIds,
                fromDate = DateTime.Now.AddMonths(-1).ToString("o")
            };

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            EnvelopesInformation envelopes = envelopesApi.ListStatusChanges(_testConfig.AccountId, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);
            Assert.IsNotNull(envelopes.Envelopes[0].Status);
        }

        [TestMethod]
        public void ListStatus_CorrectInputParametersAndSpecifiedEnvelopeIdsInRequestBody_ReturnEnvelopesInformation()
        {
            JwtGetSampleEnvelopeIds();
            EnvelopeIdsRequest envIdsRequest = new EnvelopeIdsRequest(_testConfig.EnvelopeIdsList);

            EnvelopesApi.ListStatusOptions options = new EnvelopesApi.ListStatusOptions()
            {
                envelopeIds = "request_body",
                fromDate = DateTime.Now.AddMonths(-1).ToString("o")
            };

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            EnvelopesInformation envelopes = envelopesApi.ListStatus(_testConfig.AccountId, envIdsRequest, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);
            Assert.IsNotNull(envelopes.Envelopes[0].Status);
        }

        [TestMethod]
        public void GetDocument_CorrectInputParameters_ReturnMemoryStream()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeDocumentsResult docsList = envelopesApi.ListDocuments(_testConfig.AccountId, _testConfig.EnvelopeId);

            Assert.IsNotNull(docsList);
            Assert.IsNotNull(docsList.EnvelopeId);

            int docCount = docsList.EnvelopeDocuments.Count;

            for (int i = 0; i < docCount; i++)
            {
                Assert.IsNotNull(docsList.EnvelopeDocuments[i].DocumentId);

                MemoryStream docStream = (MemoryStream)envelopesApi.GetDocument(
                    _testConfig.AccountId,
                    _testConfig.EnvelopeId,
                    docsList.EnvelopeDocuments[i].DocumentId);

                Assert.IsNotNull(docStream);

                string filePath = Path.GetTempPath() + Path.GetRandomFileName() + ".pdf";
                FileStream fs = new FileStream(filePath, FileMode.Create);
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

            ReturnUrlRequest options = new ReturnUrlRequest
            {
                ReturnUrl = _testConfig.ReturnUrl
            };

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            ViewUrl senderView = envelopesApi.CreateSenderView(_testConfig.AccountId, _testConfig.EnvelopeId, options);

            Assert.IsNotNull(senderView);
            Assert.IsNotNull(senderView.Url);
        }

        [TestMethod]
        public void CreateRecipientView_CorrectInputParameters_ReturnViewUrl()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            RecipientViewRequest viewOptions = new RecipientViewRequest()
            {
                ReturnUrl = _testConfig.ReturnUrl,
                ClientUserId = "1234",
                AuthenticationMethod = "email",
                UserName = _testConfig.RecipientName,
                Email = _testConfig.RecipientEmail
            };

            ViewUrl recipientView = envelopesApi.CreateRecipientView(_testConfig.AccountId, _testConfig.EnvelopeId, viewOptions);

            Assert.IsNotNull(recipientView);
            Assert.IsNotNull(recipientView.Url);
        }

        [TestMethod]
        public void CreateConsoleView_CorrectInputParameters_ReturnViewUrl()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            ConsoleViewRequest consoleViewRequest = new ConsoleViewRequest
            {
                EnvelopeId = _testConfig.EnvelopeId,
                ReturnUrl = _testConfig.ReturnUrl
            };

            ViewUrl viewUrl = envelopesApi.CreateConsoleView(_testConfig.AccountId, consoleViewRequest);

            Assert.IsNotNull(viewUrl);
            Assert.IsNotNull(viewUrl.Url);
        }

        [TestMethod]
        public void CreateEnvelopeWithHttpInfo_CorrectInputParameters_ReturnsApiResponseWithHeaders()
        {
            var envDef = new EnvelopeDefinition();

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            ApiResponse<EnvelopeSummary> envelopeSummary = envelopesApi.CreateEnvelopeWithHttpInfo(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.Headers);
            Assert.IsNotNull(envelopeSummary.Data);
            Assert.IsNotNull(envelopeSummary.Data.EnvelopeId);

            var headers = envelopeSummary.Headers;
            var xRateLimitRemainingHeader = headers["X-RateLimit-Remaining"];
            var xRateLimitLimitHeader = headers["X-RateLimit-Limit"];

            Assert.IsNotNull(xRateLimitRemainingHeader);
            Assert.IsNotNull(xRateLimitLimitHeader);
        }

        [TestMethod]
        public void ListTabs_CorrectInputParameters_ReturnTabs()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc"
            };

            TemplateRole tRole = new TemplateRole
            {
                Email = _testConfig.RecipientEmail,
                Name = _testConfig.RecipientName,
                RoleName = "Manager"
            };

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = _testConfig.TemplateId;

            envDef.Status = "sent";

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            var recipients = envelopesApi.ListRecipients(_testConfig.AccountId, envelopeSummary.EnvelopeId);
            var tabs = envelopesApi.ListTabs(_testConfig.AccountId, envelopeSummary.EnvelopeId, recipients.Signers.FirstOrDefault()?.RecipientId);

            Assert.IsNotNull(tabs);
        }

        [TestMethod]
        public void GetFormData_CorrectInputParameters_ReturnEnvelopeFormData()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc"
            };

            TemplateRole tRole = new TemplateRole
            {
                Email = _testConfig.RecipientEmail,
                Name = _testConfig.RecipientName,
                RoleName = "Manager"
            };

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = _testConfig.TemplateId;

            envDef.Status = "sent";

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            EnvelopeFormData envFormData = envelopesApi.GetFormData(_testConfig.AccountId, envelopeSummary.EnvelopeId);

            Assert.IsNotNull(envFormData);
            Assert.IsNotNull(envFormData.FormData);
            Assert.IsNotNull(envFormData.EnvelopeId);
        }

        [TestMethod]
        public void GetAuditEventsTest_CorrectAccountIdAndEnvelopeId_ReturnEnvelopeAuditEventResponse()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeAuditEventResponse listAuditEvents = envelopesApi.ListAuditEvents(_testConfig.AccountId, _testConfig.EnvelopeId);

            Assert.IsNotNull(listAuditEvents);
            Assert.IsNotNull(listAuditEvents.AuditEvents);
        }

        [TestMethod]
        public void PostRecipientTabs_CorrectAccountIdEnvelopeIdRecipientIdAndTabs_ReturnTabs()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            Tabs tabs = new Tabs();
            List<Approve> approveTabs = new List<Approve>();
            Approve approveTab = new Approve
            {
                Status = "created",
                AnchorYOffset = "5",
                AnchorXOffset = "10",
                TabLabel = "new approve tab"
            };

            approveTabs.Add(approveTab);
            tabs.ApproveTabs = approveTabs;

            Recipients recipients = envelopesApi.ListRecipients(_testConfig.AccountId, _testConfig.EnvelopeId);
            Tabs listTabs = envelopesApi.CreateTabs(_testConfig.AccountId, _testConfig.EnvelopeId, recipients.Signers.FirstOrDefault()?.RecipientId, tabs);
            Assert.IsNotNull(listTabs);
            Assert.IsNotNull(listTabs.ApproveTabs);
            Assert.IsTrue(listTabs.ApproveTabs.Exists(x => x.TabLabel == approveTab.TabLabel));
        }

        [TestMethod]
        public void PutEnvelope_CorrectAccountIdEnvelopeIdAndEnvelope_ReturnEnvelopeUpdateSummary()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            Envelope envelope = new Envelope()
            {
                EnvelopeId = _testConfig.EnvelopeId,
                EmailSubject = "new email subject",
                EmailBlurb = "new email message",
                Status = "sent"
            };

            EnvelopeUpdateSummary envelopeUpdateSummary = envelopesApi.Update(_testConfig.AccountId, _testConfig.EnvelopeId, envelope);
            Assert.IsNotNull(envelopeUpdateSummary);
            Assert.IsNotNull(envelopeUpdateSummary.EnvelopeId);

            Envelope renewedEnvelope = envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);
            Assert.AreEqual(envelope.EmailSubject, renewedEnvelope.EmailSubject);
            Assert.AreEqual(envelope.EmailBlurb, renewedEnvelope.EmailBlurb);
            Assert.AreEqual(envelope.Status, renewedEnvelope.Status);
        }

        [TestMethod]
        public void PutRecipients_CorrectAccountIdEnvelopeIdAndRecipients_ReturnRecipientsUpdateSummary()
        {
            CreateEnvelopeMethod.CreateEnvelope_CorrectAccountIdAndEnvelopeDefinition_ReturnEnvelopeSummary(
                ref _testConfig);

            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            SignHere signHere = new SignHere()
            {
                Name = "SignHereTab",
                XPosition = "75",
                YPosition = "572",
                TabLabel = "SignHereTab",
                PageNumber = "1",
                DocumentId = "1",
                RecipientId = "1"
            };

            List<SignHere> signHereTabs = new List<SignHere> { signHere };

            Tabs signerTabs = new Tabs()
            {
                SignHereTabs = signHereTabs
            };

            Signer newSigner = new Signer()
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
            Recipients recipients = new Recipients()
            {
                Signers = signers
            };

            RecipientsUpdateSummary recipientsUpdateSummary = envelopesApi.UpdateRecipients(
                _testConfig.AccountId,
                _testConfig.EnvelopeId,
                recipients);

            Assert.IsNotNull(recipientsUpdateSummary);
            Assert.IsNotNull(recipientsUpdateSummary.RecipientUpdateResults);

            Recipients updatedListRecipients = envelopesApi.ListRecipients(
                _testConfig.AccountId,
                _testConfig.EnvelopeId);

            Assert.IsTrue(updatedListRecipients.Signers.Exists(
                x =>
                    x.Name == newSigner.Name && x.Email == newSigner.Email));
        }
    }
}
