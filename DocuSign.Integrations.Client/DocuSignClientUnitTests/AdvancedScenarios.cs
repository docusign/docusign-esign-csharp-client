using System;
using System.Linq;
using System.Collections.Generic;
using DocuSign.Integrations.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.IO;

namespace RestClientUnitTests
{
    [TestClass]
    public class AdvancedScenarios
    {
        private Account _account;

        [TestInitialize]
        public void InitializeAccount()
        {
            ConfigLoader.LoadConfig();
            //TODO - udpate these values with valid user/password for demo
            string email = "";
            string password = "";
            _account = new Account { Email = email, Password = password };
            Assert.IsTrue(_account.Login());
        }

        /// <summary>
        /// This test first create a new empty template, then adds recipients to the template
        /// then the test create a new envelope based on this template
        /// then we update the recipients for this envelope
        /// then we send the envelope
        /// </summary>
        [TestMethod]
        public void TemplateEndToEndTest()
        {
            var template = new Template { Login = _account };
            byte[] doc1 = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            var names = new List<string>();
            var docs = new List<byte[]>();
            names.Add("test1.doc");
            docs.Add(doc1);
            // add recipients
            var signers = new List<Signer>();
            signers.Add(new Signer { email = "unittest@testing.com", name = "test test", recipientId = "1", roleName = "signer1", routingOrder = "1" });
            signers.Add(new Signer { recipientId = "2", roleName = "signer2", routingOrder = "1" });
            var recipients = new Recipients { signers = signers.ToArray() };
            template.Recipients = recipients;
            Assert.IsTrue(template.CreateTemplate(docs, names, "DocuSign.NET Client Unit Test Template"));
            Assert.IsNull(template.RestError);
            // Note that EnvelopeId for a template is the TemplateId...
            // start a new envelope 
            var templateId = template.EnvelopeId;
            var envelope = new Envelope { Login = _account };
            Assert.IsTrue(envelope.Create());
            // add the template
            var templates = new List<string>();
            templates.Add(template.EnvelopeId);
            Assert.IsTrue(envelope.AddTemplates(templates));
            Assert.IsNull(template.RestError);
            // update recipients
            recipients.signers[1].name = "test test2";
            recipients.signers[1].email = "unitest2@testing.com";
            Assert.IsTrue(envelope.UpdateRecipients(recipients, false));
            Assert.IsNull(template.RestError);
            // send envelope
            envelope.Status = "sent";
            Assert.IsTrue(envelope.UpdateStatus());
            Assert.IsNull(template.RestError);
        }

        [TestMethod]
        public void ReteivingAllDraftEnvelopesTest()
        {
            var envelope = new Envelope { Login = _account };
            // add a draft envelope to be found later
            Assert.IsTrue(envelope.Create());
            Assert.IsNull(envelope.RestError);
            Thread.Sleep(1000); // need to allow the system to fully create the envelope
            var accountEnvelopes = envelope.GetDraftEnvelopes(DateTime.Now.AddSeconds(-5));
            Assert.IsNull(envelope.RestError);
            Assert.AreEqual(1, accountEnvelopes.Envelopes.Length, "We except only 1 draft envelope in the last 5 seconds that was created by this unit test");
        }

        [TestMethod]
        public void AddRemoveDocumentsFromEnvelopeTest()
        {
            var envelope = new Envelope { Login = _account };
            // add a draft envelope to be found later
            Assert.IsTrue(envelope.Create());
            Assert.IsNull(envelope.RestError);
            // no docs yet
            Assert.AreEqual(0, envelope.GetDocIds(envelope.EnvelopeId).Count);
            // add a doc
            byte[] doc1 = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            Assert.IsTrue(envelope.AddDocument(doc1, "test1.doc", 1));
            Assert.IsNull(envelope.RestError);
            // we should have exactly 1 doc now
            Assert.AreEqual(1, envelope.GetDocIds(envelope.EnvelopeId).Count);
            Assert.AreEqual("test1.doc", envelope.GetDocNames(envelope.EnvelopeId).First());
            var envelopeDocuments = envelope.GetEnvelopeDocumentInfo(envelope.EnvelopeId);
            Assert.AreEqual(envelopeDocuments.envelopeId, envelope.EnvelopeId);
            Assert.AreEqual(envelopeDocuments.envelopeDocuments[0].name, "test1.doc");
            Assert.AreEqual(envelopeDocuments.envelopeDocuments[0].documentId, "1");
            // remove the doc
            Assert.IsTrue(envelope.RemoveDocument(1));
            Assert.IsNull(envelope.RestError);
            // back to having no docs
            Assert.AreEqual(0, envelope.GetDocIds(envelope.EnvelopeId).Count);
        }

        /// <summary>
        /// In this test we create an envelope to be signed by the sender only
        /// </summary>
        [TestMethod]
        public void SelfSignedEnvelopeTest()
        {
            var envelope = new Envelope { Login = _account };
            byte[] doc1 = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            envelope.Status = "sent";
            var signers = new List<Signer>();
            signers.Add(new Signer { email = _account.Email, name = _account.AccountName, recipientId = "1", routingOrder = "1" });
            envelope.Recipients = new Recipients { signers = signers.ToArray() };
            Assert.IsTrue(envelope.Create(doc1, "test-self-signed.doc"));
            Assert.IsNull(envelope.RestError);
            Assert.IsTrue(envelope.GetRecipientView());
            Assert.IsNull(envelope.RestError);
            // note SenderViewUrl in this case is the Signer view (Recipient)
            Assert.IsNotNull(envelope.SenderViewUrl);
        }

        /// <summary>
        /// In this test we create an envelope to be signed by the sender only
        /// </summary>
        [TestMethod]
        public void CreateEnvelopeFromStreamTest()
        {
            var envelope = new Envelope { Login = _account };
            byte[] byteArray = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            var doc1 = new MemoryStream(byteArray);
            envelope.Status = "sent";
            var signers = new List<Signer>();
            signers.Add(new Signer { email = _account.Email, name = _account.AccountName, recipientId = "1", routingOrder = "1" });
            envelope.Recipients = new Recipients { signers = signers.ToArray() };
            Assert.IsTrue(envelope.Create(doc1, "test-self-signed.doc"));
            Assert.IsNull(envelope.RestError);
            Assert.IsTrue(envelope.GetRecipientView());
            Assert.IsNull(envelope.RestError);
            // note SenderViewUrl in this case is the Signer view (Recipient)
            Assert.IsNotNull(envelope.SenderViewUrl);
        }

        /// <summary>
        /// Create an envelope with a few recipients, add more, check them and send
        /// TODO - we're missing the RemoveRecipients() method, onces added - add it to this test..
        /// </summary>
        [TestMethod]
        public void RecipientsEndToEndTest()
        {
            var envelope = new Envelope { Login = _account };
            byte[] doc1 = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            var signers = new List<Signer>();
            var ccs = new List<Signer>();
            signers.Add(new Signer { email = "unitests1@testing.com", name = "test2", recipientId = "1", routingOrder = "1" });
            ccs.Add(new Signer { email = _account.Email, name = _account.AccountName, recipientId = "2", routingOrder = "2" });
            envelope.Recipients = new Recipients { signers = signers.ToArray(), carbonCopies = ccs.ToArray() };
            Assert.IsTrue(envelope.Create(doc1, "test-self-signed.doc"));
            Assert.IsNull(envelope.RestError);
            Assert.AreEqual(2, envelope.GetRecipientNames().Count());
            // add more recipients
            signers.Clear();
            ccs.Clear();
            ccs.Add(new Signer { email = "unitests1@testing.com", name = "test2", recipientId = "3", routingOrder = "4" });
            signers.Add(new Signer { email = _account.Email, name = _account.AccountName, recipientId = "4", routingOrder = "3" });
            Assert.IsTrue(envelope.AddRecipients(new Recipients { signers = signers.ToArray(), carbonCopies = ccs.ToArray() }));
            Assert.IsNull(envelope.RestError);
            Assert.AreEqual(4, envelope.GetRecipientNames().Count());
            Assert.AreEqual((string)(envelope.GetFirstRecipients().First()["email"]), "unitests1@testing.com");
        }

        [TestMethod]
        public void AddEmailSubjectAndBlurbToExisitingEnvelopeAndVeryifyStatusTest()
        {
            var envelope = new Envelope { Login = _account };
            byte[] doc1 = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            var signers = new List<Signer>();
            signers.Add(new Signer { email = "unitests1@testing.com", name = "test2", recipientId = "1", routingOrder = "1" });
            envelope.Recipients = new Recipients { signers = signers.ToArray()};
            Assert.IsTrue(envelope.Create(doc1, "test-self-signed.doc"));
            Assert.IsNull(envelope.RestError);
            Assert.IsTrue(envelope.AddEmailInformation("DocuSign Client Tests Message", "DocuSign Client Tests Message"));
            Assert.IsNull(envelope.RestError);
            var time = envelope.GetStatus(envelope.EnvelopeId);
            Assert.AreEqual("created", envelope.Status);
            // envelope was created very recently...
            Assert.IsTrue(DateTime.Now.Subtract(time).Ticks < 10000);
            // send envelope
            envelope.Status = "sent";
            envelope.UpdateStatus();
        }

        [TestMethod]
        public void EnvelopeCustomFieldsTest()
        {
            var envelope = new Envelope { Login = _account };
            byte[] doc1 = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            var signers = new List<Signer>();
            signers.Add(new Signer { email = "unitests1@testing.com", name = "test2", recipientId = "1", routingOrder = "1" });
            envelope.Recipients = new Recipients { signers = signers.ToArray() };
            Assert.IsTrue(envelope.Create(doc1, "test-self-signed.doc"));
            Assert.IsNull(envelope.RestError);
            var fields = new Dictionary<string, object>();
            fields.Add("time", DateTime.Now);
            fields.Add("isUnitTest", true);
            fields.Add("unitTestName", "EnvelopeCustomFieldsTest");
            Assert.IsTrue(envelope.AddCustomFields(fields));
            Assert.IsNull(envelope.RestError);
            Assert.IsTrue(envelope.GetCustomFields()); 
            Assert.IsNull(envelope.RestError);
            Assert.AreEqual(3, envelope.CustomFields.textCustomFields.Length);
            Assert.AreEqual("True", envelope.CustomFields.textCustomFields[1].value);
        }

        [TestMethod]
        public void UserSettingsAndInfoTest()
        {
            // insure we have UserId (would not be needed in this case, but good to have)
            _account.updateAllAccountsInfo();
            Assert.IsNull(_account.RestError);
            var userSettings = _account.GetUserSettings(_account.UserId);
            Assert.IsNull(_account.RestError);
            Assert.IsNotNull(userSettings);
            Assert.AreEqual("canManageAccount", userSettings.userSettings[0].name);
            Assert.AreEqual("true", userSettings.userSettings[0].value);
            var pic = _account.GetUserProfilePicture();
            Assert.IsNull(_account.RestError);
            string templateAccess = _account.CanManageTemplates();
            Assert.IsNull(_account.RestError);
            Assert.AreEqual("share", templateAccess);
            Assert.IsTrue(_account.GetUserConsoleView());
            Assert.IsNull(_account.RestError);
            Assert.IsFalse(string.IsNullOrEmpty(_account.ConsoleUrl));
            // must have a profile picture for this part...
            Assert.IsNotNull(pic);
            Assert.IsTrue(pic.Length > 0);
        }

        [TestMethod]
        public void EmbeddedSigningViewTest()
        {
            // create a new envelope with 2 recipients            
            var envelope = new Envelope { Login = _account };
            byte[] doc1 = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            var signers = new List<Signer>();
            // note we need to specify clientUserId
            signers.Add(new Signer { email = "unitests1@testing.com", name = "test1", recipientId = "1", routingOrder = "1", clientUserId = "1" });
            signers.Add(new Signer { email = "unitests2@testing.com", name = "test2", recipientId = "2", routingOrder = "2", clientUserId = "2" });
            envelope.Recipients = new Recipients { signers = signers.ToArray() };
            Assert.IsTrue(envelope.Create(doc1, "test-self-signed.doc"));
            Assert.IsNull(envelope.RestError);
            // send it
            envelope.Status = "sent";
            Assert.IsTrue(envelope.UpdateStatus());
            Assert.IsNull(envelope.RestError);
            // get embedded signing views for 2 recipients
            string urlForfirstSigner = envelope.GetEmbeddedSignerView("www.docusign.com", signers.First());
            Assert.IsNull(envelope.RestError);
            Assert.IsFalse(string.IsNullOrEmpty(urlForfirstSigner));
            string urlForSecondSigner = envelope.GetEmbeddedSignerView("www.docusign.com", signers.Last());
            // now, this one won't work until first one signed (which cannot happen in this test)
            // this is because second recpieint was set to sign only after the first one finished (routing order)
            Assert.IsTrue(string.IsNullOrEmpty(urlForSecondSigner));
        }

        [TestMethod]
        public void GetSearchFolderCountTest()
        {
            // Note: in order for this test to pass- you must have envelopes in these states
            var envelope = new Envelope { Login = _account };
            int completed = envelope.GetSearchFolderCount("completed", DateTime.Today.AddMonths(-1));
            Assert.IsNull(envelope.RestError);
            Assert.AreNotEqual(completed, 0);
            int waitingMe = envelope.GetSearchFolderCount("awaiting_my_signature", DateTime.Today.AddMonths(-1));
            Assert.IsNull(envelope.RestError);
            Assert.AreNotEqual(waitingMe, 0);
            int waitingOthers = envelope.GetSearchFolderCount("out_for_signature", DateTime.Today.AddMonths(-1));
            Assert.IsNull(envelope.RestError);
            Assert.AreNotEqual(waitingOthers, 0);
        }
    }
}
