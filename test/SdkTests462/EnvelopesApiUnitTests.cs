using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.IO;
using System.Collections.Generic;
using DocuSign.eSign.Client.Auth;
using System.Linq;
using SdkTests;

namespace SdkTestsNet462
{
    [TestClass]
    public class EnvelopesApiUnitTests
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
        public void ApiExceptionHeadersTest()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";
            // random incorrect guid
            envDef.TemplateId = "510fc78e-32f4-8778-44eb-6b53abb6c82E";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            ApiException ex = Assert.ThrowsException<ApiException>(() => envelopesApi.CreateEnvelope(testConfig.AccountId, envDef));

            Assert.IsNotNull(ex);
            Assert.IsNotNull(ex.Headers);
        }

        private void JwtRequestSignatureOnDocumentTest(string status = "sent")
        {
            // the document (file) we want signed
            const string SignTest1File = @"../../docs/SignTest1.pdf";

            // Read a file from disk to use as a document.
            byte[] fileBytes = File.ReadAllBytes(SignTest1File);

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // Add a document to the envelope
            Document doc = new Document();
            doc.DocumentBase64 = System.Convert.ToBase64String(fileBytes);
            doc.Name = "TestFile.pdf";
            doc.DocumentId = "1";

            envDef.Documents = new List<Document>();
            envDef.Documents.Add(doc);

            // Add a recipient to sign the documeent
            Signer signer = new Signer();
            signer.Email = testConfig.RecipientEmail;
            signer.Name = testConfig.RecipientName;
            signer.RecipientId = "1";
            signer.ClientUserId = "1234";

            // Create a |SignHere| tab somewhere on the document for the recipient to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "100";
            signHere.YPosition = "100";
            signHere.ScaleValue = ".5";
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.Signers.Add(signer);


            TemplateTabs templateTabs = new TemplateTabs();
            templateTabs.DateTabs = new List<Date>();

            Tabs tabs = new Tabs();
            tabs.DateTabs = new List<Date>();

            SignerAttachment signerAttachment = new SignerAttachment();
            signerAttachment.ScaleValue = "";

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = status;

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }

        private void GetSampleEnvelopeIds()
        {
            if (testConfig.EnvelopeIdsList.Count <= 0)
            {
                JwtListEnvelopesTest();
            }
        }

        [TestMethod]
        public void JwtRequestSignatureFromTemplateTest()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // assign recipient to template role by setting name, email, and role name.  Note that the
            // template role name must match the placeholder role name saved in your account template.  
            TemplateRole tRole = new TemplateRole();
            tRole.Email = testConfig.RecipientEmail;
            tRole.Name = testConfig.RecipientName;
            tRole.RoleName = testConfig.TemplateRoleName;

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            // add the role to the envelope and assign valid templateId from your account
            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = testConfig.TemplateId;

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }

        [TestMethod]
        public void JwtGetEnvelopeInformationTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes including status calls
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            Envelope envInfo = envelopesApi.GetEnvelope(testConfig.AccountId, testConfig.EnvelopeId);

            Assert.IsNotNull(envInfo);
            Assert.IsNotNull(envInfo.EnvelopeId);
        }

        [TestMethod]
        public void JwtListRecipientsTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            Recipients recips = envelopesApi.ListRecipients(testConfig.AccountId, testConfig.EnvelopeId);

            Assert.IsNotNull(recips);
            Assert.IsNotNull(recips.RecipientCount);
        }

        [TestMethod]
        public void JwtListEnvelopesTest()
        {
            // This example gets statuses of all envelopes in your account going back 1 full month...
            DateTime fromDate = DateTime.UtcNow;
            fromDate = fromDate.AddDays(-30);
            string fromDateStr = fromDate.ToString("o");

            // set a filter for the envelopes we want returned using the fromDate and count properties
            EnvelopesApi.ListStatusChangesOptions options = new EnvelopesApi.ListStatusChangesOptions()
            {
                count = "10",
                fromDate = fromDateStr
            };

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopesInformation envelopes = envelopesApi.ListStatusChanges(testConfig.AccountId, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);

            foreach (var envelopeslist in envelopes.Envelopes)
            {
                testConfig.EnvelopeIdsList.Add(envelopeslist.EnvelopeId);
            }

        } // end listEnvelopesTest()

        [TestMethod]
        public void JwtListEnvelopesWithSpecifiedEnvelopeIdsInQueryParameterTest()
        {
            GetSampleEnvelopeIds();
            // This example gets statuses of all envelopes listed in envelopeIds comma separated
            var envIds = string.Join(", ", testConfig.EnvelopeIdsList);

            // set a filter for the envelopes we want returned using the envelopeIds property in the query parameter
            EnvelopesApi.ListStatusChangesOptions options = new EnvelopesApi.ListStatusChangesOptions()
            {
                envelopeIds = envIds
            };

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);

            EnvelopesInformation envelopes = envelopesApi.ListStatusChanges(testConfig.AccountId, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);
            Assert.IsNotNull(envelopes.Envelopes[0].Status);
        }

        [TestMethod]
        public void JwtListEnvelopesWithSpecifiedEnvelopeIdsInRequestBodyTest()
        {
            GetSampleEnvelopeIds();
            // This example gets statuses of all envelopes listed in envelopeIds comma separated
            EnvelopeIdsRequest envIdsRequest = new EnvelopeIdsRequest(testConfig.EnvelopeIdsList);

            // set a filter for the envelopes we want returned - we will ask the API to let the List of Envelope Ids from request body
            EnvelopesApi.ListStatusOptions options = new EnvelopesApi.ListStatusOptions()
            {
                envelopeIds = "request_body"
            };

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);

            EnvelopesInformation envelopes = envelopesApi.ListStatus(testConfig.AccountId, envIdsRequest, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);
            Assert.IsNotNull(envelopes.Envelopes[0].Status);
        }

        /* Deprecated
        private BulkRecipientsSummaryResponse MockBulkRecipientsSummaryResponse()
        {
            string bulkRecipientsCSV = "name,email\n" + "John Doe,john.doe@mailinator.com\n" + "Jane Doe,jane.doe@mailinator.com";
            byte[] bulkRecipientsRequest = Encoding.ASCII.GetBytes(bulkRecipientsCSV);

            BulkEnvelopesApi bulkEnvelopesApi = new BulkEnvelopesApi(testConfig.ApiClient);

            return bulkEnvelopesApi.UpdateRecipients(testConfig.AccountId, testConfig.EnvelopeId, "1", bulkRecipientsRequest);
        }

        [TestMethod]
        public void JwtBulkEnvelopesApiTest()
        {
            #region Envelope Creation - with BulkRecipient Flag
            // the document (file) we want signed
            const string SignTest1File = @"../../docs/SignTest1.pdf";

            // Read a file from disk to use as a document.
            byte[] fileBytes = File.ReadAllBytes(SignTest1File);

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // Add a document to the envelope
            Document doc = new Document();
            doc.DocumentBase64 = System.Convert.ToBase64String(fileBytes);
            doc.Name = "TestFile.pdf";
            doc.DocumentId = "1";
            // doc.FileExtension = System.IO.Path.GetExtension(SignTest1File);

            envDef.Documents = new List<Document>();
            envDef.Documents.Add(doc);

            // Add a recipient to sign the documeent
            Signer signer = new Signer();
            signer.RecipientId = "1";
            signer.IsBulkRecipient = "true";

            // Create a |SignHere| tab somewhere on the document for the recipient to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "100";
            signHere.YPosition = "100";
            signHere.ScaleValue = ".5";
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.Signers.Add(signer);


            TemplateTabs templateTabs = new TemplateTabs();
            templateTabs.DateTabs = new List<Date>();

            Tabs tabs = new Tabs();
            tabs.DateTabs = new List<Date>();

            SignerAttachment signerAttachment = new SignerAttachment();
            signerAttachment.ScaleValue = "";

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "created";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
            #endregion
            var response = MockBulkRecipientsSummaryResponse();

            // update the status of the enve
            Envelope envelope = new Envelope();
            envelope.Status = "sent";

            envelopesApi.Update(testConfig.AccountId, testConfig.EnvelopeId, envelope);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.BulkRecipientsUri);
            Assert.IsNotNull(response.BulkRecipientsCount);
        }
        */

        [TestMethod]
        public void JwtListDocumentsAndDownloadTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeDocumentsResult docsList = envelopesApi.ListDocuments(testConfig.AccountId, testConfig.EnvelopeId);

            Assert.IsNotNull(docsList);
            Assert.IsNotNull(docsList.EnvelopeId);

            //===========================================================
            // Step 3: Download Envelope Document(s)
            //===========================================================

            // read how many documents are in the envelope
            int docCount = docsList.EnvelopeDocuments.Count;
            string filePath = null;
            FileStream fs = null;

            // loop through the envelope's documents and download each doc
            for (int i = 0; i < docCount; i++)
            {
                Assert.IsNotNull(docsList.EnvelopeDocuments[i].DocumentId);

                // GetDocument() API call returns a MemoryStream
                MemoryStream docStream = (MemoryStream)envelopesApi.GetDocument(testConfig.AccountId, testConfig.EnvelopeId, docsList.EnvelopeDocuments[i].DocumentId);

                Assert.IsNotNull(docStream);

                // let's save the document to local file system
                filePath = Path.GetTempPath() + Path.GetRandomFileName() + ".pdf";
                fs = new FileStream(filePath, FileMode.Create);
                docStream.Seek(0, SeekOrigin.Begin);
                docStream.CopyTo(fs);
                fs.Close();
                Assert.IsNotNull(filePath);
            }

        }

        [TestMethod]
        public void JwtCreateEmbeddedSendingViewTest()
        {
            JwtRequestSignatureOnDocumentTest("created");

            ReturnUrlRequest options = new ReturnUrlRequest();
            options.ReturnUrl = testConfig.ReturnUrl;

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);

            // generate the embedded sending URL
            ViewUrl senderView = envelopesApi.CreateSenderView(testConfig.AccountId, testConfig.EnvelopeId, options);

            Assert.IsNotNull(senderView);

            Assert.IsNotNull(senderView.Url);
        }

        [TestMethod]
        public void JwtCreateEmbeddedSigningViewTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);

            RecipientViewRequest viewOptions = new RecipientViewRequest()
            {
                ReturnUrl = testConfig.ReturnUrl,
                ClientUserId = "1234",  // must match clientUserId set in step #2!
                AuthenticationMethod = "email",
                UserName = testConfig.RecipientName,
                Email = testConfig.RecipientEmail
            };

            // create the recipient view (aka signing URL)
            ViewUrl recipientView = envelopesApi.CreateRecipientView(testConfig.AccountId, testConfig.EnvelopeId, viewOptions);

            Assert.IsNotNull(recipientView);

            Assert.IsNotNull(recipientView.Url);
        }

        [TestMethod]
        public void JwtCreateEmbeddedConsoleViewTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // Adding the envelopeId start sthe console with the envelope open
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);

            ConsoleViewRequest consoleViewRequest = new ConsoleViewRequest();
            consoleViewRequest.EnvelopeId = testConfig.EnvelopeId;
            consoleViewRequest.ReturnUrl = testConfig.ReturnUrl;

            ViewUrl viewUrl = envelopesApi.CreateConsoleView(testConfig.AccountId, consoleViewRequest);

            Assert.IsNotNull(viewUrl);
            Assert.IsNotNull(viewUrl.Url);
        }

        [TestMethod]
        public void JwtCreateEnvelopeWithHttpInfoRateLimitHeadersTest()
        {
            var envDef = new EnvelopeDefinition();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);

            ApiResponse<EnvelopeSummary> envelopeSummary = envelopesApi.CreateEnvelopeWithHttpInfo(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.Headers);
            Assert.IsNotNull(envelopeSummary.Data);
            Assert.IsNotNull(envelopeSummary.Data.EnvelopeId);

            //Test the Http Response Headers
            var headers = envelopeSummary.Headers;
            var x_RateLimit_Remaining_Header = headers["X-RateLimit-Remaining"];
            var x_RateLimit_Limit_Header = headers["X-RateLimit-Limit"];

            Assert.IsNotNull(x_RateLimit_Remaining_Header);
            Assert.IsNotNull(x_RateLimit_Limit_Header);
        }

        [TestMethod]
        public void JwtListTabsTest()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // assign recipient to template role by setting name, email, and role name.  Note that the
            // template role name must match the placeholder role name saved in your account template.  
            TemplateRole tRole = new TemplateRole();
            tRole.Email = testConfig.RecipientEmail;
            tRole.Name = testConfig.RecipientName;
            tRole.RoleName = "Manager";

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            // add the role to the envelope and assign valid templateId from your account
            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = testConfig.TemplateId;

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            var recipients = envelopesApi.ListRecipients(testConfig.AccountId, envelopeSummary.EnvelopeId);
            var tabs = envelopesApi.ListTabs(testConfig.AccountId, envelopeSummary.EnvelopeId, recipients.Signers.FirstOrDefault().RecipientId);

            Assert.IsNotNull(tabs);
        }

        [TestMethod]
        public void JwtGetFormDataTest()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // assign recipient to template role by setting name, email, and role name.  Note that the
            // template role name must match the placeholder role name saved in your account template.  
            TemplateRole tRole = new TemplateRole();
            tRole.Email = testConfig.RecipientEmail;
            tRole.Name = testConfig.RecipientName;
            tRole.RoleName = "Manager";

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            // add the role to the envelope and assign valid templateId from your account
            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = testConfig.TemplateId;

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            EnvelopeFormData envFormData = envelopesApi.GetFormData(testConfig.AccountId, envelopeSummary.EnvelopeId);

            Assert.IsNotNull(envFormData);
            Assert.IsNotNull(envFormData.FormData);
            Assert.IsNotNull(envFormData.EnvelopeId);
        }

        [TestMethod]
        public void JwtGetAuditEventsTest()
        {
            JwtRequestSignatureOnDocumentTest();

            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            EnvelopeAuditEventResponse listAuditEvents = envelopesApi.ListAuditEvents(testConfig.AccountId, testConfig.EnvelopeId);
            
            Assert.IsNotNull(listAuditEvents);
            Assert.IsNotNull(listAuditEvents.AuditEvents);
        }

        [TestMethod]
        public void JwtPostRecipientTest()
        {
            JwtRequestSignatureOnDocumentTest();

            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);

            Tabs tabs = new Tabs();
            Approve approveTab = new Approve();
            List<Approve> approveTabs = new List<Approve>();

            approveTab.Status = "created";
            approveTab.AnchorYOffset = "5";
            approveTab.AnchorXOffset = "10";
            approveTabs.Add(approveTab);
            tabs.ApproveTabs = approveTabs;

            Recipients recipients = envelopesApi.ListRecipients(testConfig.AccountId, testConfig.EnvelopeId);
            Tabs listTabs = envelopesApi.CreateTabs(testConfig.AccountId, testConfig.EnvelopeId, recipients.Signers.FirstOrDefault().RecipientId, tabs);
            
            Assert.IsNotNull(listTabs);
            Assert.IsNotNull(listTabs.ApproveTabs);
        }

        [TestMethod]
        public void JwtPutEnvelopeTest()
        {
            JwtRequestSignatureOnDocumentTest();

            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
            Envelope envelope = new Envelope()
            {
                EnvelopeId = testConfig.EnvelopeId,
                EmailSubject = "new email subject",
                EmailBlurb = "new email message",
                Status = "sent"
            };

            EnvelopeUpdateSummary envelopeUpdateSummary = envelopesApi.Update(testConfig.AccountId, testConfig.EnvelopeId, envelope);
            
            Assert.IsNotNull(envelopeUpdateSummary);
            Assert.IsNotNull(envelopeUpdateSummary.EnvelopeId);

            Envelope renewedEnvelope = envelopesApi.GetEnvelope(testConfig.AccountId, testConfig.EnvelopeId);
            
            Assert.AreEqual(envelope.EmailSubject, renewedEnvelope.EmailSubject);
            Assert.AreEqual(envelope.EmailBlurb, renewedEnvelope.EmailBlurb);
            Assert.AreEqual(envelope.Status, renewedEnvelope.Status);
        }

        [TestMethod]
        public void JwtPutRecipientsTest()
        {
            JwtRequestSignatureOnDocumentTest();

            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient);
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

            var signHereTabs = new List<SignHere>();
            signHereTabs.Add(signHere);

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

            var signers = new List<Signer>();
            signers.Add(newSigner);
            Recipients recipients = new Recipients()
            {
                Signers = signers
            };

            RecipientsUpdateSummary recipientsUpdateSummary = envelopesApi.UpdateRecipients(
                testConfig.AccountId,
                testConfig.EnvelopeId,
                recipients);

            Assert.IsNotNull(recipientsUpdateSummary);
            Assert.IsNotNull(recipientsUpdateSummary.RecipientUpdateResults);

            Recipients updatedListRecipients = envelopesApi.ListRecipients(
                testConfig.AccountId,
                testConfig.EnvelopeId);

            Assert.IsTrue(updatedListRecipients.Signers.Exists(x => x.Name == newSigner.Name && x.Email == newSigner.Email));
        }
    }
}
