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
    public class AuthNetCoreUnitTests
    {
        private TestConfig _testConfig;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }

        [TestMethod]
        public void ApiExceptionHeadersTest()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";
            // random incorrect guid
            envDef.TemplateId = "510fc78e-32f4-8778-44eb-6b53abb6c82E";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            ApiException ex = Assert.ThrowsException<ApiException>(() => envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef));

            Assert.IsNotNull(ex);
            Assert.IsNotNull(ex.Headers);
        }

        [TestMethod]
        public void SetBasePathTest()
        {
            // Prepare
            var configBasePath = _testConfig.ApiClient.Configuration.BasePath;
            var restBasePath = Convert.ToString(_testConfig.ApiClient.GetBasePath());

            // Test is everything initialized properly
            Assert.AreEqual(configBasePath, restBasePath);

            // Test a new basepath
            var testBasePath = "https://na.docusign.net/restapi";

            _testConfig.ApiClient.SetBasePath(testBasePath);

            // Assert the new basePAth
            Assert.AreEqual(testBasePath, Convert.ToString(_testConfig.ApiClient.GetBasePath()));
            Assert.AreEqual(testBasePath, _testConfig.ApiClient.Configuration.BasePath);

            // Reset 
            _testConfig.ApiClient.SetBasePath(configBasePath);

            // Assert
            Assert.AreEqual(restBasePath, Convert.ToString(_testConfig.ApiClient.GetBasePath()));
            Assert.AreEqual(configBasePath, _testConfig.ApiClient.Configuration.BasePath);
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
            signer.Email = _testConfig.RecipientEmail;
            signer.Name = _testConfig.RecipientName;
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
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            _testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }

        private void GetSampleEnvelopeIds()
        {
            if (_testConfig.EnvelopeIdsList.Count <= 0)
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
            tRole.Email = _testConfig.RecipientEmail;
            tRole.Name = _testConfig.RecipientName;
            tRole.RoleName = _testConfig.TemplateRoleName;

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            // add the role to the envelope and assign valid templateId from your account
            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = _testConfig.TemplateId;

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            this._testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }

        [TestMethod]
        public void JwtGetEnvelopeInformationTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes including status calls
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            Envelope envInfo = envelopesApi.GetEnvelope(_testConfig.AccountId, _testConfig.EnvelopeId);

            Assert.IsNotNull(envInfo);
            Assert.IsNotNull(envInfo.EnvelopeId);
        }

        [TestMethod]
        public void JwtListRecipientsTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            Recipients recips = envelopesApi.ListRecipients(_testConfig.AccountId, _testConfig.EnvelopeId);

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
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopesInformation envelopes = envelopesApi.ListStatusChanges(_testConfig.AccountId, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);

            foreach (var envelopeslist in envelopes.Envelopes)
            {
                _testConfig.EnvelopeIdsList.Add(envelopeslist.EnvelopeId);
            }
        } // end listEnvelopesTest()

        [TestMethod]
        public void JwtListEnvelopesWithSpecifiedEnvelopeIdsInQueryParameterTest()
        {
            GetSampleEnvelopeIds();
            // This example gets statuses of all envelopes listed in envelopeIds comma separated
            var envIds = string.Join(", ", _testConfig.EnvelopeIdsList);

            // set a filter for the envelopes we want returned using the envelopeIds property in the query parameter
            EnvelopesApi.ListStatusChangesOptions options = new EnvelopesApi.ListStatusChangesOptions()
            {
                envelopeIds = envIds
            };

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            EnvelopesInformation envelopes = envelopesApi.ListStatusChanges(_testConfig.AccountId, options);

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
            EnvelopeIdsRequest envIdsRequest = new EnvelopeIdsRequest(_testConfig.EnvelopeIdsList);

            // set a filter for the envelopes we want returned - we will ask the API to let the List of Envelope Ids from request body
            EnvelopesApi.ListStatusOptions options = new EnvelopesApi.ListStatusOptions()
            {
                envelopeIds = "request_body"
            };

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            EnvelopesInformation envelopes = envelopesApi.ListStatus(_testConfig.AccountId, envIdsRequest, options);

            Assert.IsNotNull(envelopes);
            Assert.IsNotNull(envelopes.Envelopes);
            Assert.IsNotNull(envelopes.Envelopes[0].EnvelopeId);
            Assert.IsNotNull(envelopes.Envelopes[0].Status);
        }

        [TestMethod]
        public void JwtListDocumentsAndDownloadTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeDocumentsResult docsList = envelopesApi.ListDocuments(_testConfig.AccountId, _testConfig.EnvelopeId);

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
                MemoryStream docStream = (MemoryStream)envelopesApi.GetDocument(_testConfig.AccountId, _testConfig.EnvelopeId, docsList.EnvelopeDocuments[i].DocumentId);

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
            options.ReturnUrl = _testConfig.ReturnUrl;

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            // generate the embedded sending URL
            ViewUrl senderView = envelopesApi.CreateSenderView(_testConfig.AccountId, _testConfig.EnvelopeId, options);

            Assert.IsNotNull(senderView);
            Assert.IsNotNull(senderView.Url);
        }

        [TestMethod]
        public void JwtCreateEmbeddedSigningViewTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            RecipientViewRequest viewOptions = new RecipientViewRequest()
            {
                ReturnUrl = _testConfig.ReturnUrl,
                ClientUserId = "1234",  // must match clientUserId set in step #2!
                AuthenticationMethod = "email",
                UserName = _testConfig.RecipientName,
                Email = _testConfig.RecipientEmail
            };

            // create the recipient view (aka signing URL)
            ViewUrl recipientView = envelopesApi.CreateRecipientView(_testConfig.AccountId, _testConfig.EnvelopeId, viewOptions);

            Assert.IsNotNull(recipientView);

            // Start the embedded signing session
            //System.Diagnostics.Process.Start(recipientView.Url);
            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {recipientView.Url}"));

            Assert.IsNotNull(recipientView.Url);
        }

        [TestMethod]
        public void JwtCreateEmbeddedConsoleViewTest()
        {
            JwtRequestSignatureOnDocumentTest();

            // Adding the envelopeId start sthe console with the envelope open
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            ConsoleViewRequest consoleViewRequest = new ConsoleViewRequest();
            consoleViewRequest.EnvelopeId = _testConfig.EnvelopeId;
            consoleViewRequest.ReturnUrl = _testConfig.ReturnUrl;

            ViewUrl viewUrl = envelopesApi.CreateConsoleView(_testConfig.AccountId, consoleViewRequest);

            // Start the embedded signing session.
            //System.Diagnostics.Process.Start(viewUrl.Url);
            //System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {viewUrl.Url}"));

            Assert.IsNotNull(viewUrl);
            Assert.IsNotNull(viewUrl.Url);
        }

        [TestMethod]
        public void JwtCreateEnvelopeWithHttpInfoRateLimitHeadersTest()
        {
            var envDef = new EnvelopeDefinition();

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);

            ApiResponse<EnvelopeSummary> envelopeSummary = envelopesApi.CreateEnvelopeWithHttpInfo(_testConfig.AccountId, envDef);

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

            Exception ex = Assert.ThrowsException<Exception>(() => _testConfig.ApiClient.RequestJWTUserToken(_testConfig.IntegratorKeyNoConsent, _testConfig.UserId, _testConfig.OAuthBasePath, privateKeyStream, _testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual(ex.Message, "Unexpected PEM type");
        }

        [TestMethod]
        public void JwtInvalidGrantTest()
        {
            // Adding a WRONG PEM key 
            byte[] privateKeyStream = _testConfig.PrivateKey;

            ApiException ex = Assert.ThrowsException<ApiException>(() => _testConfig.ApiClient.RequestJWTUserToken(_testConfig.IntegratorKeyNoConsent, _testConfig.UserId, _testConfig.OAuthBasePath, privateKeyStream, _testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            Assert.AreEqual("{\"error\":\"invalid_grant\",\"error_description\":\"no_valid_keys_or_signatures\"}", ex.ErrorContent);
        }

        [TestMethod]
        public void JwtConsentRequiredTest()
        {
            // Adding a Correct PEM key - no consent granted
            byte[] pkey = Convert.FromBase64String(_testConfig.PrivateKeyNoConsent);
            ApiException ex = Assert.ThrowsException<ApiException>(() => _testConfig.ApiClient.RequestJWTUserToken(_testConfig.IntegratorKeyNoConsent, _testConfig.UserId, _testConfig.OAuthBasePath, pkey, _testConfig.ExpiresInHours));

            Assert.IsNotNull(ex);
            //Assert.AreEqual("{\"error\":\"consent_required\"}", ex.ErrorContent);
        }

        [TestMethod]
        public void JwtInvalidAccessToken_Unauthorized_Test()
        {
            string access_token = "---Invalid-Access-Token---";

            ApiException ex = Assert.ThrowsException<ApiException>(() => _testConfig.ApiClient.GetUserInfo(access_token));

            Assert.IsNotNull(ex);
            Assert.IsNotNull(ex.ErrorContent);

            int unauthorizedStatusCode = 401;
            Assert.AreEqual(unauthorizedStatusCode, ex.ErrorCode);
        }

        [TestMethod]
        public void JwtListBrandTest()
        {
            AccountsApi accApi = new AccountsApi(_testConfig.ApiClient);
            var brandsResponse = accApi.ListBrands(_testConfig.AccountId);

            Assert.IsNotNull(brandsResponse);
        }

        [TestMethod]
        public void JwtUploadBrandLogoTest()
        {
            AccountsApi accApi = new AccountsApi(_testConfig.ApiClient);

            if (string.IsNullOrEmpty(_testConfig.BrandId))
            {
                CreateBrandTest();
            }

            try
            {
                byte[] brandLogoByteArray = Convert.FromBase64String(_testConfig.BrandLogo);
                accApi.UpdateBrandLogoByType(_testConfig.AccountId, _testConfig.BrandId, "primary", brandLogoByteArray);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void JwtGetBrandLogoByBrandIdTest()
        {
            AccountsApi accApi = new AccountsApi(_testConfig.ApiClient);
            if (string.IsNullOrEmpty(_testConfig.BrandId))
            {
                CreateBrandTest();
            }

            byte[] brandLogoByteArray = Convert.FromBase64String(_testConfig.BrandLogo);

            //Check if C# png just got uploaded
            Stream stream = accApi.GetBrandLogoByType(_testConfig.AccountId, _testConfig.BrandId, "primary");

            Assert.IsNotNull(stream);

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                byte[] brandLogofromApi = ms.ToArray();
                Assert.AreEqual(Convert.ToBase64String(brandLogoByteArray), Convert.ToBase64String(brandLogofromApi));
            }
        }

        [TestMethod]
        public void JwtListTabsTest()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // assign recipient to template role by setting name, email, and role name.  Note that the
            // template role name must match the placeholder role name saved in your account template.  
            TemplateRole tRole = new TemplateRole();
            tRole.Email = _testConfig.RecipientEmail;
            tRole.Name = _testConfig.RecipientName;
            tRole.RoleName = "Manager";

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            // add the role to the envelope and assign valid templateId from your account
            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = _testConfig.TemplateId;

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            var recipients = envelopesApi.ListRecipients(_testConfig.AccountId, envelopeSummary.EnvelopeId);
            var tabs = envelopesApi.ListTabs(_testConfig.AccountId, envelopeSummary.EnvelopeId, recipients.Signers[1].RecipientId);

            Assert.IsNotNull(tabs);
            Assert.IsNotNull(tabs.ListTabs);
            Assert.IsInstanceOfType(tabs.ListTabs.FirstOrDefault(), typeof(DocuSign.eSign.Model.List));
        }

        [TestMethod]
        public void JwtGetFormDataTest()
        {
            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // assign recipient to template role by setting name, email, and role name.  Note that the
            // template role name must match the placeholder role name saved in your account template.  
            TemplateRole tRole = new TemplateRole();
            tRole.Email = _testConfig.RecipientEmail;
            tRole.Name = _testConfig.RecipientName;
            tRole.RoleName = "Manager";

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            // add the role to the envelope and assign valid templateId from your account
            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = _testConfig.TemplateId;

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            EnvelopeFormData envFormData = envelopesApi.GetFormData(_testConfig.AccountId, envelopeSummary.EnvelopeId);

            Assert.IsNotNull(envFormData);
            Assert.IsNotNull(envFormData.FormData);
            Assert.IsNotNull(envFormData.EnvelopeId);
            Assert.IsNotNull(envFormData.FormData.FirstOrDefault().Name);
        }

        private void CreateBrandTest()
        {
            AccountsApi accApi = new AccountsApi(_testConfig.ApiClient);
            Brand brand = new Brand
            {
                BrandName = "C# Brand"
            };

            var brands = accApi.CreateBrand(_testConfig.AccountId, brand);

            foreach (var brnds in brands.Brands)
            {
                if (brnds.BrandName == brand.BrandName)
                {
                    _testConfig.BrandId = brnds.BrandId;
                }
            }
        }

        public void JwtMoveEnvelopesTest()
        {
            JwtRequestSignatureOnDocumentTest("sent");

            FoldersApi foldersApi = new FoldersApi(_testConfig.ApiClient);

            FoldersRequest foldersRequest = new FoldersRequest(EnvelopeIds: new List<string> { _testConfig.EnvelopeId }, FromFolderId: "sentitems");

            string ToFolderId = "draft";

            try
            {
                foldersApi.MoveEnvelopes(_testConfig.AccountId, ToFolderId, foldersRequest);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, Actual error message: " + ex.Message);
            }

            // Test if we moved the envelope to the correct folder
            FoldersApi.ListItemsOptions searchOptions = new FoldersApi.ListItemsOptions();

            var listfromDraftsFolder = foldersApi.ListItems(_testConfig.AccountId, ToFolderId, searchOptions);

            Assert.IsNotNull(listfromDraftsFolder);

            bool doesExists = false;
            foreach (var folder in listfromDraftsFolder.Folders)
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

        [TestMethod]
        public void CreateEnvelope_WrongTemplateId_ReturnApiException()
        {
            var envelopesApi = new EnvelopesApi(_testConfig.ApiClient);
            var envDef = new EnvelopeDefinition
            {
                EmailSubject = "[DocuSign C# SDK] - Please sign this doc",
                TemplateId = "510fc78e-32f4-8778-44eb-6b53abb6c82E"
            };

            ApiException ex = Assert.ThrowsException<ApiException>(() => envelopesApi.CreateEnvelope(_testConfig.AccountId, envDef));

            Assert.IsNotNull(ex?.Headers);
        }

        [TestMethod]
        public void SetBasePath_MultibleBasePathUsed_BasePathIsChanged()
        {
            string configBasePath = _testConfig.ApiClient.Configuration.BasePath;
            var restBasePath = Convert.ToString(_testConfig.ApiClient.GetBasePath());

            Assert.AreEqual(configBasePath, restBasePath);

            var testBasePath = "https://na.docusign.net/restapi";

            _testConfig.ApiClient.SetBasePath(testBasePath);

            Assert.AreEqual(testBasePath, Convert.ToString(_testConfig.ApiClient.GetBasePath()));
            Assert.AreEqual(testBasePath, _testConfig.ApiClient.Configuration.BasePath);

            _testConfig.ApiClient.SetBasePath(configBasePath);

            Assert.AreEqual(restBasePath, Convert.ToString(_testConfig.ApiClient.GetBasePath()));
            Assert.AreEqual(configBasePath, _testConfig.ApiClient.Configuration.BasePath);
        }

        [TestMethod]
        public void GetUserInfo_WrongAccessToken_ReturnsException()
        {
            var access_token = "---Invalid-Access-Token---";

            ApiException ex = Assert.ThrowsException<ApiException>(() => _testConfig.ApiClient.GetUserInfo(access_token));

            Assert.IsNotNull(ex?.ErrorContent);

            int unauthorizedStatusCode = 401;
            Assert.AreEqual(ex.ErrorCode, unauthorizedStatusCode);
        }
    }
}
