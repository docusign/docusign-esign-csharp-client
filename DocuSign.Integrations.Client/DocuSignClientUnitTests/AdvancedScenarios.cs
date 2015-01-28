using System;
using System.Collections.Generic;
using DocuSign.Integrations.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var accountEnvelopes = envelope.GetDraftEnvelopes(DateTime.Now.AddSeconds(-5));
            Assert.IsNull(envelope.RestError);
            Assert.AreEqual(1, accountEnvelopes.Envelopes.Length, "We except only 1 draft envelope in the last 5 seconds that was created by this unit test");
        }
    }
}
