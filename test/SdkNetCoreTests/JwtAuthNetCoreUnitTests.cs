using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using DocuSign.eSign.Client.Auth;

namespace SdkNetCoreTests
{
    [TestClass]
    public class JwtAuthNetCoreUnitTests
    {
        TestConfig testConfig = new TestConfig();

        [TestInitialize()]
        [TestMethod]
        public void JwtLoginTest()
        {
            testConfig.ApiClient = new ApiClient(testConfig.Host);

            // Create a stream of bytes... 
            byte[] privateKeyStream = File.ReadAllBytes(testConfig.PrivateKeyFilename);
            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours);
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
                    testConfig.ApiClient = new ApiClient(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig.AccountId);
        }

        private void JwtRequestSignatureOnDocumentTest(string status = "sent")
        {
            // the document (file) we want signed
            const string SignTest1File = @"../../../docs/SignTest1.pdf";

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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);
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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);
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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);
            Envelope envInfo = envelopesApi.GetEnvelope(testConfig.AccountId, testConfig.EnvelopeId);

            Assert.IsNotNull(envInfo);
            Assert.IsNotNull(envInfo.EnvelopeId);
        }

        [TestMethod]
        public void JwtListRecipientsTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);
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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);
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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);

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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);

            EnvelopesInformation envelopes = envelopesApi.ListStatus(testConfig.AccountId, envIdsRequest, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);
            Assert.IsNotNull(envelopes.Envelopes[0].Status);
        }

        private BulkRecipientsSummaryResponse MockBulkRecipientsSummaryResponse()
        {
            BulkRecipient bulkRecipient1 = new BulkRecipient(
                Email: "john.jay.rele@mailinator.com",
                Name: "John Jay"
                );
            BulkRecipient bulkRecipient2 = new BulkRecipient(
                Email: "jon.jon@mailinator.com",
                Name: "jon jon"
                );
            BulkRecipient bulkRecipient3 = new BulkRecipient(
                Email: "tom.tom@mailinator.com",
                Name: "tom tom",
                AccessCode: "123"
                );

            List<BulkRecipient> bulkRecipients = new List<BulkRecipient> { bulkRecipient1, bulkRecipient2, bulkRecipient3 };

            BulkRecipientsRequest bulkRecipientsRequest = new BulkRecipientsRequest(bulkRecipients);

            BulkEnvelopesApi bulkEnvelopesApi = new BulkEnvelopesApi();

            return bulkEnvelopesApi.UpdateRecipients(testConfig.AccountId, testConfig.EnvelopeId, "1", bulkRecipientsRequest);
        }

        [TestMethod]
        public void JwtBulkEnvelopesApiTest()
        {
            #region Envelope Creation - with BulkRecipient Flag
            // the document (file) we want signed
            const string SignTest1File = @"../../../docs/SignTest1.pdf";

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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);
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

        [TestMethod]
        public void JwtListDocumentsAndDownloadTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);
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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);

            // generate the embedded sending URL
            ViewUrl senderView = envelopesApi.CreateSenderView(testConfig.AccountId, testConfig.EnvelopeId, options);

            Assert.IsNotNull(senderView);

            // Start the embedded sending session
            //System.Diagnostics.Process.Start(senderView.Url);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {senderView.Url}"));

            Assert.IsNotNull(senderView.Url);
        }

        [TestMethod]
        public void JwtCreateEmbeddedSigningViewTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);

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

            // Start the embedded signing session
            //System.Diagnostics.Process.Start(recipientView.Url);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {recipientView.Url}"));

            Assert.IsNotNull(recipientView.Url);
        }

        [TestMethod]
        public void JwtCreateEmbeddedConsoleViewTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // Adding the envelopeId start sthe console with the envelope open
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);

            ConsoleViewRequest consoleViewRequest = new ConsoleViewRequest();
            consoleViewRequest.EnvelopeId = testConfig.EnvelopeId;
            consoleViewRequest.ReturnUrl = testConfig.ReturnUrl;

            ViewUrl viewUrl = envelopesApi.CreateConsoleView(testConfig.AccountId, consoleViewRequest);

            // Start the embedded signing session.
            //System.Diagnostics.Process.Start(viewUrl.Url);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {viewUrl.Url}"));

            Assert.IsNotNull(viewUrl);
            Assert.IsNotNull(viewUrl.Url);
        }
        
        [TestMethod]
        public void JwtCreateEnvelopeWithHttpInfoRateLimitHeadersTest()
        {
            var envDef = new EnvelopeDefinition();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);

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
        public void JwtUnexpectedPEMTypeTest()
        {
            var rsaKey = "---Invalid private key---";
            // Create a stream of bytes... 
            byte[] privateKeyStream = System.Text.Encoding.UTF8.GetBytes(rsaKey);

            Exception ex = Assert.ThrowsException<Exception>(() => testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKeyNoConsent, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual(ex.Message, "Unexpected PEM type");
        }

        [TestMethod]
        public void JwtInvalidGrantTest()
        {
            // Adding a WRONG PEM key 
            byte[] privateKeyStream = File.ReadAllBytes(testConfig.PrivateKeyFilename);

            ApiException ex = Assert.ThrowsException<ApiException>(() => testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKeyNoConsent, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual(ex.ErrorContent, "{\"error\":\"invalid_grant\"}");
        }

        [TestMethod]
        public void JwtConsentRequiredTest()
        {
            // Adding a Correct PEM key - no consent granted
            byte[] pkey = System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(testConfig.PrivateKeyNoConsentFilename));
            ApiException ex = Assert.ThrowsException<ApiException>(() => testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKeyNoConsent, testConfig.UserId, testConfig.OAuthBasePath, pkey, testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual(ex.ErrorContent, "{\"error\":\"consent_required\"}");
        }

        [TestMethod]
        public void JwtInvalidAccessToken_Unauthorized_Test()
        {
            string access_token = "---Invalid-Access-Token---";

            ApiException ex = Assert.ThrowsException<ApiException>(() => testConfig.ApiClient.GetUserInfo(access_token));

            Assert.IsNotNull(ex);
            Assert.IsNotNull(ex.ErrorContent);

            int unauthorizedStatusCode = 401;
            Assert.AreEqual(ex.ErrorCode, unauthorizedStatusCode);
        }
    }
}
