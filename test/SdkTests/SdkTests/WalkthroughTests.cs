using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace SdkTests
{
    [TestClass]
    public class WalkthroughTests
    {
        [TestMethod]
        public void RequestSignatureOnADocumentTest()
        {
            try
            {

                // get the logininformation and accountId
                AuthenticationApiTests loginTests = new AuthenticationApiTests();
                loginTests.LoginTest();

                EnvelopeDefinition envDef = Utils.CreateDraftEnvelopeDefinition();
                // send the envelope (otherwise it will be "created" in the Draft folder
                envDef.EmailSubject = "RequestSignatureOnADocumentTest";
                envDef.Status = "sent";

                EnvelopesApi envelopesApi = new EnvelopesApi();
                //   EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(TestConfig.AccountId, envDef);
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
        public void EmbeddedSigningTest()
        {
            try
            {
                AuthenticationApiTests loginTests = new AuthenticationApiTests();
                loginTests.LoginTest();
                EnvelopeDefinition envDef = Utils.CreateDraftEnvelopeDefinition();
                envDef.Status = "sent";
                envDef.EmailSubject = "Please Sign my C# SDK Envelope";
                string clientUserId = "1234";
                envDef.Recipients.Signers[0].ClientUserId = clientUserId;

                EnvelopesApi envelopesApi = new EnvelopesApi();

                EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(TestConfig.AccountId, envDef);
                Assert.IsNotNull(envelopeSummary);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(envelopeSummary.EnvelopeId));


                // get a URL that can be placed in a browser or embedded in an IFrame
                string returnUrl = TestConfig.DefaultReturnUrl;
                RecipientViewRequest recipientView = new RecipientViewRequest()
                {
                    ReturnUrl = returnUrl,
                    ClientUserId = clientUserId,
                    AuthenticationMethod = "email",
                    UserName = envDef.Recipients.Signers[0].Name,
                    Email = envDef.Recipients.Signers[0].Email
                };

                ViewUrl viewUrl = envelopesApi.CreateRecipientView(TestConfig.AccountId, envelopeSummary.EnvelopeId, recipientView);
                Assert.IsNotNull(viewUrl);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(viewUrl.Url));
                Trace.WriteLine("ViewUrl is " + viewUrl);

                /// Start a browser to Sign
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
        public void GetEnvelopeRecipientsTest()
        {
            try
            {
                RequestSignatureOnADocumentTest();

                EnvelopesApi envelopesApi = new EnvelopesApi();
                Recipients recipients = envelopesApi.ListRecipients(TestConfig.AccountId, TestConfig.EnvelopeId);
                Assert.IsNotNull(recipients);
                Assert.IsNotNull(recipients.Signers);
                Assert.IsTrue(recipients.Signers.Count > 0);
                Assert.IsNotNull(recipients.Signers[0].Name);

                Assert.IsNotNull(recipients.Signers[0].Status);
                Assert.IsNotNull(recipients.RecipientCount);
                Assert.IsNotNull(recipients.CurrentRoutingOrder);

                Trace.WriteLine("Recipients" + recipients.ToJson());
            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }
        }

        [TestMethod]
        public void GetStatusOfEnvelopesTest()
        {
            try
            {
                // make sure we have at least one result.
                RequestSignatureOnADocumentTest();

                DateTime fromDate = DateTime.UtcNow;
                fromDate = fromDate.AddDays(-30);
                string fromDateStr = fromDate.ToString("o");

                EnvelopesApi.ListStatusChangesOptions ops = new EnvelopesApi.ListStatusChangesOptions()
                {
                    count = "10",
                    fromDate = fromDateStr
                };
                EnvelopesApi envelopesApi = new EnvelopesApi();
                EnvelopesInformation envInfo = envelopesApi.ListStatusChanges(TestConfig.AccountId, ops);
                Assert.IsNotNull(envInfo);
                Assert.IsNotNull(envInfo.ResultSetSize);
                int resultSetSize = int.Parse(envInfo.ResultSetSize);
                Assert.IsTrue(resultSetSize > 0);
                Trace.WriteLine(envInfo.ToJson());
            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }

        }

        [TestMethod]
        public void RequestSignatureViaTemplateTest()
        {
            try
            {
                // upload template if one doesn't exist
                // FAILED - CANT UPLOAD A TEMPLATE - API-3002 submitted
                // use predefined template
                AuthenticationApiTests authTests = new AuthenticationApiTests();
                authTests.LoginTest();

                // get pre-existing template with template name equals to "myTemplate"
                // since I can't upload a template right now
                TemplatesApi templatesApi = new TemplatesApi();
                EnvelopeTemplateResults templateResults = templatesApi.ListTemplates(TestConfig.AccountId);
                Assert.IsNotNull(templateResults);
                Assert.IsNotNull(templateResults.EnvelopeTemplates);
                string templateId = null;
                foreach (EnvelopeTemplateResult et in templateResults.EnvelopeTemplates)
                {
                    if (et.Name == "myTemplate")
                    {
                        templateId = et.TemplateId;
                        break;
                    }
                }
                Assert.IsNotNull(templateId);

                EnvelopeDefinition envDef = new EnvelopeDefinition();
                envDef.TemplateId = templateId;

                envDef.TemplateRoles = new List<TemplateRole>();
                TemplateRole templateRole = new TemplateRole();
                templateRole.Email = TestConfig.DefaultEmail;
                templateRole.Name = TestConfig.DefaultName;
                templateRole.RoleName = "Signer1";
                envDef.TemplateRoles.Add(templateRole);
                envDef.Status = "sent"; // trigger the envelope to be sent (vs. Draft/Created)


                // send envelope using template roles
                EnvelopesApi envelopesApi = new EnvelopesApi();
                EnvelopeSummary es = envelopesApi.CreateEnvelope(TestConfig.AccountId, envDef);
                Assert.IsNotNull(es);
                Assert.IsNotNull(es.EnvelopeId);
                Trace.WriteLine("Envelope: " + es.ToJson());

            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }


        }

        [TestMethod]
        public void GetEnvelopeInformationTest()
        {
            try
            {
                // get the logininformation and accountId
                AuthenticationApiTests loginTests = new AuthenticationApiTests();
                loginTests.LoginTest();

                EnvelopeDefinition envDef = Utils.CreateDraftEnvelopeDefinition();
                // send the envelope (otherwise it will be "created" in the Draft folder
                envDef.EmailSubject = "GetEnvelopeInformationTest";
                envDef.Status = "sent";

                EnvelopesApi envelopesApi = new EnvelopesApi();
                EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(TestConfig.AccountId, envDef);
                Assert.IsNotNull(envelopeSummary);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(envelopeSummary.EnvelopeId));

                // Get the status of the envelope
                Envelope envelope = envelopesApi.GetEnvelope(TestConfig.AccountId, envelopeSummary.EnvelopeId, null);
                Assert.IsNotNull(envelope);
                Assert.IsNotNull(envelope.Status);
                Assert.IsNotNull(envelope.EnvelopeId);
                Trace.WriteLine("Envelope: " + envelope.ToJson());

            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }
        }

        [TestMethod]

        public void GetDocumentListDownloadDocumentTest()
        {
            try
            {
                RequestSignatureOnADocumentTest();
                Assert.IsNotNull(TestConfig.AccountId);
                Assert.IsNotNull(TestConfig.EnvelopeId);

                EnvelopesApi envelopesApi = new EnvelopesApi();

                DateTime fromDate = DateTime.UtcNow;
                fromDate = fromDate.AddDays(-5);


                EnvelopesApi.ListStatusChangesOptions ops = new EnvelopesApi.ListStatusChangesOptions()
                {
                    count = "10",
                    fromDate = fromDate.ToString()
                };

                EnvelopesInformation eInfo = envelopesApi.ListStatusChanges(TestConfig.AccountId, ops);
                Assert.IsNotNull(eInfo);
                Assert.IsTrue(!string.IsNullOrEmpty(eInfo.ResultSetSize) && int.Parse(eInfo.ResultSetSize) > 0);

                string envelopeId = eInfo.Envelopes[0].EnvelopeId;
                EnvelopeDocumentsResult envDocsResult = envelopesApi.ListDocuments(TestConfig.AccountId, envelopeId);
                Assert.IsNotNull(envDocsResult);
                int docCount = envDocsResult.EnvelopeDocuments.Count;
                Assert.IsTrue(docCount > 0);

                MemoryStream docStream = (MemoryStream)envelopesApi.GetDocument(TestConfig.AccountId, envelopeId, envDocsResult.EnvelopeDocuments[0].DocumentId);

                string filePath = Path.GetTempPath() + Path.GetRandomFileName() + ".pdf";

                FileStream fs = new FileStream(filePath, FileMode.Create);
                docStream.Seek(0, SeekOrigin.Begin);
                docStream.CopyTo(fs);
                fs.Close();
                System.Diagnostics.Process.Start(filePath);

            }

            catch (DocuSign.eSign.Client.ApiException apiEx)
            {
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }


        }

        [TestMethod]
        public void EmbeddedConsoleTest()
        {
            try
            {
                // create draft envelope structure
                EnvelopeDefinition envDef = Utils.CreateDraftEnvelopeDefinition();
                envDef.EmailSubject = "EmbeddedConsoleTest";

                // call login to authenticate and get default accountId
                AuthenticationApiTests loginTests = new AuthenticationApiTests();
                loginTests.LoginTest();

                // create the Draft envelope on the DocuSign Service
                EnvelopesApi envelopesApi = new EnvelopesApi();
                EnvelopeSummary envSummary = envelopesApi.CreateEnvelope(TestConfig.AccountId, envDef);
                Assert.IsNotNull(envSummary);
                Assert.IsNotNull(envSummary.EnvelopeId);

                // Start the embedded sending session
                ReturnUrlRequest urlRequest = new ReturnUrlRequest();
                urlRequest.ReturnUrl = TestConfig.DefaultReturnUrl;

                // Adding the envelopeId start sthe console with the envelope open
                ConsoleViewRequest consoleViewRequest = new ConsoleViewRequest();
                consoleViewRequest.EnvelopeId = envSummary.EnvelopeId;
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
        public void EmeddedSendingTest()
        {
            try
            {
                // create draft envelope structure
                EnvelopeDefinition envDef = Utils.CreateDraftEnvelopeDefinition();
                envDef.EmailSubject = "EmbeddedSendingTest";

                // call login to authenticate and get default accountId
                if (TestConfig.Authenticated)
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
    }
}
