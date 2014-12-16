using System.Collections.Generic;
using DocuSignClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace RestClientUnitTests
{
    
    
    /// <summary>
    ///This is a test class for EnvelopeTest and is intended
    ///to contain all EnvelopeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EnvelopeTest
    {


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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
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
            AddUsers add = new DocuSignClient.AddUsers();
            List<NewUser> userList = new List<DocuSignClient.NewUser>();

            NewUser nu = new DocuSignClient.NewUser();
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

            DocuSignClient.CreatedUsers added = null;

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
    }
}
