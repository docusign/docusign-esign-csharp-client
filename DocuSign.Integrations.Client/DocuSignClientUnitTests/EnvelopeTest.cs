using System.Collections.Generic;
using DocuSign.Integrations.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;

namespace RestClientUnitTests
{
    
    
    /// <summary>
    ///This is a test class for EnvelopeTest and is intended
    ///to contain all EnvelopeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EnvelopeTest
    {

        private static Account _account;

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            ConfigLoader.LoadConfig();
            // $TODO: Add creds for known account
            _account = new Account
            {
                Email = "",
                Password = "",
                AccountName = ""
            };


            try
            {
                if (!_account.Login())
                    Assert.Fail("Unexpected exception during account creation part of test {0}: {1}", _account.RestError.errorCode, _account.RestError.message);
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception during account creation part of test {0}: {1}", ex.GetType(), ex.Message);
            }
        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void EnvelopeCreateNoAccount()
        {
            ConfigLoader.LoadConfig();

            Envelope target = new Envelope(); 
            bool expected = false; 
            bool actual = false;

            try
            {
                actual = target.Create(string.Empty);
            }
            catch(ArgumentNullException)
            {
            }

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void EnvelopeCreateNotLoggedIn()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = false;

            Envelope target = new Envelope();
            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = "docusign";

            try
            {
                target.Login = acct;
                actual = target.Create(string.Empty);
            }
            catch(ArgumentNullException)
            {
            }

            Assert.AreEqual(expected, actual);
        }
        
        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod(), DeploymentItem("Test Contract.pdf")]
        public void EnvelopeCreateAddMemberWithDocumentTest()
        {
            ConfigLoader.LoadConfig();

            bool expected = true;
            bool actual = false;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("ds client unit test {unique}");
            acct.Email = Util.MakeUnique("ds_client_unit_{unique}@gmail.com");
            acct.Password = "docusign";

            try
            {
                actual = acct.Create();
            }
            catch (Exception)
            {
            }

            Assert.AreEqual(expected, actual);
            AddUsers add = new AddUsers();
            List<NewUser> userList = new List<NewUser>();

            NewUser nu = new NewUser();
            nu.userName = Util.MakeUnique("ds client unit test member {unique}");
            nu.email = Util.MakeUnique("ds_client_unit_member_{unique}@gmail.com");
            nu.sendActivationOnInvalidLogin = false.ToString();
            nu.enableConnectForUser = true.ToString();
            Guid g = Guid.NewGuid();
            nu.password = g.ToString();

            List<UserSetting> userSettings = new List<UserSetting>();
            userSettings.Add(new UserSetting("canSendAPIRequests", "true"));
            userSettings.Add(new UserSetting("canSendEnvelope", "true"));
            userSettings.Add(new UserSetting("AllowSendOnBehalfOf", "true"));
            nu.userSettings = userSettings.ToArray();

            userList.Add(nu);
            add.newUsers = userList.ToArray();

            CreatedUsers added = null;

            try
            {
                added = acct.AddUser(add);
            }
            catch (Exception)
            {
            }

            Account member = new Account();
            member.ApiPassword = added.NewUsers[0].ApiPassword;
            member.AccountId = added.NewUsers[0].UserId;
            member.Email = added.NewUsers[0].Email;
            //member.BaseUrl = added.NewUsers[0].Uri;
            bool log = member.Login();

            Assert.IsNotNull(added);
            Envelope target = new Envelope();
            target.Login = member;
            FileInfo fi = new FileInfo("./Test Contract.pdf");
            string path = fi.FullName;

            actual = false;

            try
            {
                actual = target.Create(path);
            }
            catch (ArgumentNullException)
            {
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(target.SenderViewUrl));
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod(), DeploymentItem("Test Contract.pdf")]
        public void EnvelopeCreateWithDocumentTest()
        {
            ConfigLoader.LoadConfig();

            bool expected = true;
            bool actual = false;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = "docusign";

            AddressInformation ai = new AddressInformation();
            acct.Address = ai;
            ai.address1 = "123 Main ST";
            ai.address2 = string.Empty;
            ai.city = "Anytown";
            ai.country = "USA";
            ai.postalCode = "11111";
            ai.state = "WA";

            CreditCardInformation cc = new CreditCardInformation();
            acct.CreditCard = cc;
            cc.cardNumber = "4111111111111111";
            cc.cardType = "visa";
            cc.expirationMonth = "12";
            cc.expirationYear = "2015";
            cc.nameOnCard = "Freak Me Out";

            try
            {
                actual = acct.Create();
            }
            catch (Exception)
            {
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(acct.BaseUrl));

            Envelope target = new Envelope();
            target.Login = acct;
            FileInfo fi = new FileInfo("./Test Contract.pdf");
            string path = fi.FullName;

            actual = false;

            try
            {
                actual = target.Create(path);
            }
            catch (ArgumentNullException)
            {
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(target.SenderViewUrl));
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod(), DeploymentItem("Test Contract.pdf")]
        public void EnvelopeCreateWithSmsAuthenticationDocumentTest()
        {
            ConfigLoader.LoadConfig();

            bool expected = true;
            bool actual = false;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = "docusign";

            AddressInformation ai = new AddressInformation();
            acct.Address = ai;
            ai.address1 = "123 Main ST";
            ai.address2 = string.Empty;
            ai.city = "Anytown";
            ai.country = "USA";
            ai.postalCode = "11111";
            ai.state = "WA";

            CreditCardInformation cc = new CreditCardInformation();
            acct.CreditCard = cc;
            cc.cardNumber = "4111111111111111";
            cc.cardType = "visa";
            cc.expirationMonth = "12";
            cc.expirationYear = "2015";
            cc.nameOnCard = "Freak Me Out";

            try
            {
                actual = acct.Create();
            }
            catch (Exception)
            {
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(acct.BaseUrl));

            if (expected == actual)
            {
                Envelope target = new Envelope();
                target.Login = acct;

                // add signers to the envelope
                target.Recipients = new Recipients()
                {
                    signers = new Signer[]
                {
                    new Signer()
                    {
                        email = "freakin_{unique}@gmail.com",
                        name = "freakin",
                        routingOrder = "1",
                        recipientId = "1",
                        requireIdLookup = "true",
                        idCheckConfigurationName = "SMS Auth $",
                        smsAuthentication = new SmsAuthentication()
                        {
                            senderProvidedNumbers = new string[]
                            {
                                String.Format("+{0} {1}", "34", "000000000")
                            }
                        }
                    }
                }
                };

                // Email subject is a required parameter when requesting signatures
                target.EmailSubject = "Example subject";

                // "sent" to send immediately, "created" to save envelope as draft
                target.Status = "sent";

                FileInfo fi = new FileInfo("./Test Contract.pdf");
                string path = fi.FullName;

                actual = false;

                try
                {
                    actual = target.Create(path);
                }
                catch (ArgumentNullException)
                {
                }

                Assert.AreEqual(expected, actual);
                Assert.IsFalse(string.IsNullOrEmpty(target.SenderViewUrl));
            }
        }
        
        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void EnvelopeCreateNoDocument()
        {
            ConfigLoader.LoadConfig();

            bool expected = true;
            bool actual = true;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = "docusign";

            try
            {
                actual = acct.Create();
            }
            catch (Exception)
            {
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(acct.BaseUrl));

            Envelope target = new Envelope();
            target.Login = acct;


            actual = false;

            try
            {
                actual = target.Create(string.Empty);
            }
            catch (ArgumentNullException)
            {
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(target.SenderViewUrl));
        }

        /// <summary>
        ///A test for Status on a known envelope
        ///</summary>
        [TestMethod()]
        public void EnvelopeGetRecipients()
        {
            ConfigLoader.LoadConfig();

            bool expected = true;
            bool actual = true;

            Account acct = new Account();

            // $TODO: Add creds for known account
            acct.Email = "";
            acct.Password = "";
            acct.AccountName = "";

            try
            {
                actual = acct.Login();
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception during account creation part of test {0}: {1}", ex.GetType(), ex.Message);
                return;
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(acct.BaseUrl));

            Envelope target = new Envelope();
            target.Login = acct;

            // $TODO: add known Envelope ID
            target.EnvelopeId = " 10211DCED6744C13A2B82AACC0AF4BEC";


            actual = false;

            try
            {
                actual = target.GetRecipients();
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception during test {0}: {1}", ex.GetType(), ex.Message);
                return;
            }

            Assert.AreEqual(expected, actual);

            // $TODO: add Asserts for known Recipient Properties on the envelope
            Assert.IsNotNull(target.Recipients);
            Assert.AreEqual(target.Recipients.recipientCount, "3");
            Assert.AreEqual(target.Recipients.signers[0].email, "test1@docusign20154.onmicrosoft.com");
            Assert.AreEqual(target.Recipients.signers[0].name, "Test One");
            Assert.AreEqual(target.Recipients.signers[0].status, "sent");
            Assert.AreEqual(target.Recipients.signers[1].email, "test2@docusign20154.onmicrosoft.com");
            Assert.AreEqual(target.Recipients.signers[1].name, "Test Two");
            Assert.AreEqual(target.Recipients.signers[1].status, "created");
            Assert.AreEqual(target.Recipients.signers[2].email, "test3@docusign20154.onmicrosoft.com");
            Assert.AreEqual(target.Recipients.signers[2].name, "Test Three");
            Assert.AreEqual(target.Recipients.signers[2].status, "created");
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod(), DeploymentItem("Test Contract.pdf")]
        public void EnvelopeCreateWithDocumentObjectsAndGetDocumentFieldsTest()
        {
            const bool expected = true;
            const string expectedDocumentAttributeName = "Document Attribute Name";
            const string expectedDocumentAttributeValue = "Document Attribute Value";
            var actual = false;

            Assert.IsFalse(string.IsNullOrEmpty(_account.BaseUrl));

            var target = new Envelope { Login = _account };
            var fi = new FileInfo("./Test Contract.pdf");

            var documentCustomFields = new List<DocumentField>
            {
                new DocumentField {name = expectedDocumentAttributeName, value = expectedDocumentAttributeValue}
            };
            var documents = new List<Document>
            {
                new Document
                {
                    attachmentDescription = fi.Name.Replace(fi.Extension, string.Empty),
                    documentId = "1",
                    documentFields = documentCustomFields.ToArray(),
                    fileExtension = fi.Extension,
                    name = fi.Name
                }
            };

            var fileBytes = new List<Byte[]> { File.ReadAllBytes(fi.FullName) };

            try
            {
                actual = target.Create(fileBytes, documents);
            }
            catch (ArgumentNullException)
            {
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(target.SenderViewUrl));
            var actualDocuments = target.GetDocuments();
            Assert.AreEqual(documents.Count, actualDocuments.Count);
            for (var i = 0; i < documents.Count; i++)
            {
                Assert.AreEqual(documents[i].documentId, actualDocuments[i].documentId);
                Assert.AreEqual(documents[i].name, actualDocuments[i].name);

                var fields = target.GetDocumentFields(documents[i].documentId);
                Assert.AreEqual(documents[i].documentFields.Count(), fields.documentFields.Count());
                for (var j = 0; j < documents[i].documentFields.Count(); j++)
                {
                    Assert.AreEqual(documents[i].documentFields[j].name, fields.documentFields[j].name);
                    Assert.AreEqual(documents[i].documentFields[j].value, fields.documentFields[j].value);
                }
            }
        }
    }
}
