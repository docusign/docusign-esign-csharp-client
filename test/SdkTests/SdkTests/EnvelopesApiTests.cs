using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;

namespace SdkTests
{
    [TestClass]
    public class EnvelopesApiTests
    {
        [TestMethod]
        public void ApplyTemplateTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ApplyTemplateToDocumentTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void CreateConsoleViewTest()
        {
            try
            {
                // Create Envelope
                CreateEnvelopeTest();
                Assert.IsNotNull(TestConfig.EnvelopeId);

                // Start the embedded sending session
                ReturnUrlRequest urlRequest = new ReturnUrlRequest();
                urlRequest.ReturnUrl = TestConfig.DefaultReturnUrl;

                // Adding the envelopeId start sthe console with the envelope open
                ConsoleViewRequest consoleViewRequest = new ConsoleViewRequest();
                consoleViewRequest.EnvelopeId = TestConfig.EnvelopeId;

                EnvelopesApi envelopesApi = new EnvelopesApi();
                ViewUrl viewUrl = envelopesApi.CreateConsoleView(TestConfig.AccountId, consoleViewRequest);

                // Start the embedded signing session.
                System.Diagnostics.Process.Start(viewUrl.Url);
            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }
        }

        [TestMethod]
        public void CreateCorrectViewTest()
        {
            try
            {
                // Create Envelope
                CreateEnvelopeTest();
                Assert.IsNotNull(TestConfig.EnvelopeId);

                // Start the embedded sending session
                ReturnUrlRequest urlRequest = new ReturnUrlRequest();
                urlRequest.ReturnUrl = TestConfig.DefaultReturnUrl;

                // Adding the envelopeId start sthe console with the envelope open
                CorrectViewRequest correctViewRequest = new CorrectViewRequest();
                correctViewRequest.ReturnUrl = TestConfig.DefaultReturnUrl;

                EnvelopesApi envelopesApi = new EnvelopesApi();
                ViewUrl viewUrl = envelopesApi.CreateCorrectView(TestConfig.AccountId, TestConfig.EnvelopeId, correctViewRequest);

                // Start the embedded signing session.
                System.Diagnostics.Process.Start(viewUrl.Url);
            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }
        }

        [TestMethod]
        public void CreateCustomFieldsTest()
        {
            TestConfig.EnvelopeStatusOnCreate = "created";
            CreateEnvelopeTest();


            CustomFields customFields = new CustomFields();
            customFields.TextCustomFields = new System.Collections.Generic.List<TextCustomField>();
            TextCustomField textField = new TextCustomField()
            {
                Name = "TextCustomField1",
                Value = "TCFValue1"
            };
            customFields.TextCustomFields.Add(textField);
            
            EnvelopesApi envelopesApi = new EnvelopesApi();
            CustomFields customFieldsResponse = envelopesApi.CreateCustomFields(TestConfig.AccountId, TestConfig.EnvelopeId, customFields);
            Assert.IsNotNull(customFieldsResponse);
            Assert.IsTrue(customFieldsResponse.TextCustomFields != null && customFieldsResponse.TextCustomFields.Count > 0);

            TestConfig.EnvelopeCustomFields = customFields;
        }

        [TestMethod]
        public void CreateDocumentFieldsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void CreateEditViewTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void CreateEmailSettingsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void CreateEnvelopeTest()
        {
            try
            {
                // get the logininformation and accountId
                if (!TestConfig.Authenticated)
                {
                    AuthenticationApiTests loginTests = new AuthenticationApiTests();
                    loginTests.LoginTest();
                }

                EnvelopeDefinition envDef = Utils.CreateDraftEnvelopeDefinition();
                // send the envelope (otherwise it will be "created" in the Draft folder
                envDef.EmailSubject = "CreateEnvelopeTest";
                envDef.Status = TestConfig.EnvelopeStatusOnCreate;

                EnvelopesApi envelopesApi = new EnvelopesApi();
                EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(TestConfig.AccountId, envDef);
                Assert.IsNotNull(envelopeSummary);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(envelopeSummary.EnvelopeId));

                // store for use in other tests.
                TestConfig.EnvelopeId = envelopeSummary.EnvelopeId;

            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }
        }

        [TestMethod]
        public void CreateLockTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void CreateRecipientTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void CreateRecipientViewTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void CreateSenderViewTest()
        {
            try
            {
                // create draft envelope structure
                EnvelopeDefinition envDef = Utils.CreateDraftEnvelopeDefinition();
                envDef.EmailSubject = "EmbeddedSendingTest";

                // call login to authenticate and get default accountId
                if (!TestConfig.Authenticated)
                {
                    AuthenticationApiTests loginTests = new AuthenticationApiTests();
                    loginTests.LoginTest();
                }

                // create the Draft envelope on the DocuSign Service
                EnvelopesApi envelopesApi = new EnvelopesApi();
                EnvelopeSummary envSummary = envelopesApi.CreateEnvelope(TestConfig.AccountId, envDef);
                Assert.IsNotNull(envSummary);
                Assert.IsNotNull(envSummary.EnvelopeId);

                // Start the embedded sending session;
                ReturnUrlRequest urlRequest = new ReturnUrlRequest();
                urlRequest.ReturnUrl = TestConfig.DefaultReturnUrl;
                ViewUrl viewUrl = envelopesApi.CreateSenderView(TestConfig.AccountId, envSummary.EnvelopeId, urlRequest);

                // Start the embedded signing session.
                System.Diagnostics.Process.Start(viewUrl.Url);
            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }
        }

        [TestMethod]
        public void CreateTabsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void CreateViewLinkTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteCustomFieldsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteDocumentFieldsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteDocumentPageTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteDocumentsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteEmailSettingsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteLockTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteRecipientTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteRecipientsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteTabsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteTemplatesFromDocumentTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void DeleteViewLinkTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void GetDocumentTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void GetEmailSettingsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void GetEnvelopeTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void GetLockTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void GetNotificationSettingsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListAuditEventsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListCustomFieldsTest()
        {
            CreateCustomFieldsTest();

            EnvelopesApi envelopesApi = new EnvelopesApi();
            CustomFieldsEnvelope cfe = envelopesApi.ListCustomFields(TestConfig.AccountId, TestConfig.EnvelopeId);
            Assert.IsNotNull(cfe);
            Assert.IsTrue(TestConfig.EnvelopeCustomFieldsEqual(cfe));

        }

        [TestMethod]
        public void ListDocumentFieldsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListDocumentsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListRecipientsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListStatusTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListStatusChangesTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListTabsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListTemplatesTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void ListTemplatesForDocumentTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateCustomFieldsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateDocumentTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateDocumentFieldsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateDocumentsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateEmailSettingsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateLockTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateRecipientsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }

        [TestMethod]
        public void UpdateTabsTest()
        {
            //throw new AssertFailedException("Not Implemented");
        }
    }
}
