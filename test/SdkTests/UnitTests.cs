using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SdkTests
{
    [TestClass]
    public class UnitTests
    {
        TestConfig testConfig = new TestConfig();

        //public UnitTests()
        //{
        //    testConfig = new TestConfig();
        //}

        [TestInitialize()]
        [TestMethod]
        public void LoginTest()
        {
            string authHeader = "{\"Username\":\"" + testConfig.Username + "\", \"Password\":\"" + testConfig.Password + "\", \"IntegratorKey\":\"" + testConfig.IntegratorKey + "\"}";
            
            Configuration configuration = new Configuration(new ApiClient(testConfig.Host));
            if (configuration.DefaultHeader.ContainsKey("X-DocuSign-Authentication"))
            {
                configuration.DefaultHeader.Remove("X-DocuSign-Authentication");
            }
            configuration.AddDefaultHeader("X-DocuSign-Authentication", authHeader);

            
            testConfig.Configuration = configuration;

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            AuthenticationApi authApi = new AuthenticationApi(configuration);
            LoginInformation loginInfo = authApi.Login();

            Assert.IsNotNull(loginInfo);
            Assert.IsNotNull(loginInfo.LoginAccounts);

            // find the default account for this user
            foreach (LoginAccount loginAcct in loginInfo.LoginAccounts)
            {
                if (loginAcct.IsDefault == "true" || testConfig.AccountId == null)
                {
                    testConfig.AccountId = loginAcct.AccountId;

                    string[] separatingStrings = { "/v2" };

                    // Update ApiClient with the new base url from login call
                    configuration.ApiClient = new ApiClient(loginAcct.BaseUrl.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries)[0]);
                    break;
                }
            }
            Assert.IsNotNull(testConfig.AccountId);
        }

        private void requestSignatureOnDocumentTest(string status = "sent")
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

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = status;

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }

        [TestMethod]
        public void requestSignatureFromTemplateTest()
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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }

        [TestMethod]
        public void getEnvelopeInformationTest()
        {
            requestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes including status calls
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);
            Envelope envInfo = envelopesApi.GetEnvelope(testConfig.AccountId, testConfig.EnvelopeId);

            Assert.IsNotNull(envInfo);
            Assert.IsNotNull(envInfo.EnvelopeId);
        }

        [TestMethod]
        public void listRecipientsTest()
        {
            requestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);
            Recipients recips = envelopesApi.ListRecipients(testConfig.AccountId, testConfig.EnvelopeId);

            Assert.IsNotNull(recips);
            Assert.IsNotNull(recips.RecipientCount);
        }

        [TestMethod]
        public void listEnvelopesTest()
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
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);
            EnvelopesInformation envelopes = envelopesApi.ListStatusChanges(testConfig.AccountId, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);

        } // end listEnvelopesTest()

        [TestMethod]
        public void listDocumentsAndDownloadTest()
        {
            requestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);
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
        public void createEmbeddedSendingViewTest()
        {
            requestSignatureOnDocumentTest("created");

            ReturnUrlRequest options = new ReturnUrlRequest();
            options.ReturnUrl = testConfig.ReturnUrl;

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);

            // generate the embedded sending URL
            ViewUrl senderView = envelopesApi.CreateSenderView(testConfig.AccountId, testConfig.EnvelopeId, options);

            Assert.IsNotNull(senderView);

            // Start the embedded sending session
            System.Diagnostics.Process.Start(senderView.Url);

            Assert.IsNotNull(senderView.Url);
        }

        [TestMethod]
        public void createEmbeddedSigningViewTest()
        {
            requestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);
           
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
            System.Diagnostics.Process.Start(recipientView.Url);

            Assert.IsNotNull(recipientView.Url);
        }

        [TestMethod]
        public void createEmbeddedConsoleViewTest()
        {
            requestSignatureOnDocumentTest();

            // Adding the envelopeId start sthe console with the envelope open
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.Configuration);

            ConsoleViewRequest consoleViewRequest = new ConsoleViewRequest();
            consoleViewRequest.EnvelopeId = testConfig.EnvelopeId;
            consoleViewRequest.ReturnUrl = testConfig.ReturnUrl;

            ViewUrl viewUrl = envelopesApi.CreateConsoleView(testConfig.AccountId, consoleViewRequest);

            // Start the embedded signing session.
            System.Diagnostics.Process.Start(viewUrl.Url);

            Assert.IsNotNull(viewUrl);
            Assert.IsNotNull(viewUrl.Url);
        }
    }
}
