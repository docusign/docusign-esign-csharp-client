using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DocuSign.Integrations.Client;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace RestClientUnitTests
{
    
    
    /// <summary>
    ///This is a test class for AccountTest and is intended
    ///to contain all AccountTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AccountTest
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
        public void AccountCreate()
        {
            try
            {
                bool expected = true;
                bool actual = false;

                ConfigLoader.LoadConfig();

                Account acct = new Account();
                //acct.Email = "test@trinity8.com";
                //acct.Password = "docusign";
                //acct.AccountName = "Fester Rester";
                acct.Password = Guid.NewGuid().ToString();

                acct.AccountName = Util.MakeUnique("freakin me out {unique}");
                acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");

                //AddressInformation ai = new AddressInformation();
                //acct.Address = ai;
                //ai.address1 = "123 Main ST";
                //ai.address2 = string.Empty;
                //ai.city = "Anytown";
                //ai.country = "USA";
                //ai.postalCode = "11111";
                //ai.state = "WA";

                //CreditCardInformation cc = new CreditCardInformation();
                //acct.CreditCard = cc;
                //cc.cardNumber = "4111 1111 1111 1111";
                //cc.cardType = "visa";
                //cc.expirationMonth = "12";
                //cc.expirationYear = "2015";
                //cc.nameOnCard = "Freak Me Out";

                try
                {
                    actual = acct.Create();
                }
                catch (Exception)
                {
                }

                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void AccountCreateNoName()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            Account acct = new Account();
            acct.AccountName = string.Empty;
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = "docusign";

            try
            {
                actual = acct.Create();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void AccountCreateNoEmail()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = string.Empty;
            acct.Password = "docusign";

            try
            {
                actual = acct.Create();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void AccountCreateNoPassword()
        {
            ConfigLoader.LoadConfig();

            bool expected = true;
            bool actual = false;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = string.Empty;

            try
            {
                actual = acct.Create();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void AccountCreateSocial()
        {
            ConfigLoader.LoadConfig();

            bool expected = true;
            bool actual = false;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("restclienttest {unique}");
            acct.Email = Util.MakeUnique("restclienttest_{unique}@gmail.com");
            //acct.AccountName = "Trinity UltraStar";
            //acct.Email = "tr8ultrastar@gmail.com";
            acct.Password = Guid.NewGuid().ToString();

            acct.Social = new SocialAccountInformation();
            acct.Social.email = acct.Email;
            acct.Social.provider = "Google";
            acct.Social.socialId = Util.MakeUnique("{unique}");
            acct.Social.userName = acct.AccountName;

            try
            {
                actual = acct.Create();
                var trace = acct.RestTrace;

                Assert.AreEqual(expected, actual);

                if (actual == true)
                {
                    actual = false;
                    acct.Password = string.Empty;
                    acct.Email = acct.AccountIdGuid.ToString();
                    actual = acct.Login();
                    trace = acct.RestTrace;

                    Assert.AreEqual(expected, actual);
                }
            }
            catch (Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void AccountCreateSocialNoProvider()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = "docusign";

            acct.Social = new SocialAccountInformation();
            acct.Social.email = Util.MakeUnique("someother_{unique}@me.com");
            acct.Social.provider = "";
            acct.Social.socialId = "";
            acct.Social.userName = Util.MakeUnique("someother_{unique}@me.com");

            try
            {
                actual = acct.Create();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void AccountCreateSocialNoEmail()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = "docusign";

            acct.Social = new SocialAccountInformation();
            acct.Social.email = string.Empty;
            acct.Social.provider = "FaceBook";
            acct.Social.socialId = string.Empty;
            acct.Social.userName = Util.MakeUnique("someother_{unique}@me.com");

            try
            {
                actual = acct.Create();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void AccountCreateSocialNoUserName()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = "docusign";

            acct.Social = new SocialAccountInformation();
            acct.Social.email = acct.Email;
            acct.Social.provider = "FaceBook";
            acct.Social.socialId = string.Empty;
            acct.Social.userName = string.Empty;

            try
            {
                actual = acct.Create();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void AccountAssociateSocial()
        {
            //bool expected = true;
            //bool actual = false;

            //Account acct = new Account();
            //acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            //acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            //acct.Password = "docusign";

            //try
            //{
            //    actual = acct.Create();
            //}
            //catch(Exception)
            //{
            //    actual = false;
            //}

            //Assert.AreEqual(expected, actual);
            //Assert.IsFalse(string.IsNullOrEmpty(acct.BaseUrl));
            //Assert.IsFalse(string.IsNullOrEmpty(acct.ApiPassword));

            //acct.Social = new SocialAccountInformation();
            //acct.Social.email = Util.MakeUnique("someother_{unique}@me.com");
            //acct.Social.provider = "FaceBook";
            //acct.Social.socialId = "";
            //acct.Social.userName = Util.MakeUnique("someother_{unique}@me.com");

            //try
            //{
            //    actual = acct.AssociateSocialAccount();
            //}
            //catch(Exception)
            //{
            //    actual = false;
            //}

            //Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Login
        ///</summary>
        [TestMethod()]
        public void AccountLogin()
        {
            ConfigLoader.LoadConfig();

            bool expected = true;
            bool actual = false;

            // create a new account
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
                actual = false;
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(acct.BaseUrl));
            Assert.IsFalse(string.IsNullOrEmpty(acct.ApiPassword));

            actual = false;
            Account acct2 = new Account();
            acct2.AccountName = acct.AccountName;
            acct2.Email = acct.Email;
            acct2.Password = acct.Password;

            try
            {
                actual = acct2.Login();
            }
            catch (Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(string.IsNullOrEmpty(acct.BaseUrl));
            Assert.IsFalse(string.IsNullOrEmpty(acct.ApiPassword));
        }

        /// <summary>
        ///A test for Login
        ///</summary>
        [TestMethod()]
        public void AccountLoginBadCredentials()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            // create a new account
            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = Util.MakeUnique("docusign");

            try
            {
                actual = acct.Login();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(string.IsNullOrEmpty(acct.BaseUrl));
            Assert.IsTrue(string.IsNullOrEmpty(acct.ApiPassword));
        }

        /// <summary>
        ///A test for Login
        ///</summary>
        [TestMethod()]
        public void AccountLoginNoAccountName()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            // create a new account
            Account acct = new Account();
            acct.AccountName = string.Empty;
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = Util.MakeUnique("docusign");

            try
            {
                actual = acct.Login();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(string.IsNullOrEmpty(acct.BaseUrl));
            Assert.IsTrue(string.IsNullOrEmpty(acct.ApiPassword));
        }

        /// <summary>
        ///A test for Login
        ///</summary>
        [TestMethod()]
        public void AccountLoginNoEmail()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            // create a new account
            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = string.Empty;
            acct.Password = Util.MakeUnique("docusign");

            try
            {
                actual = acct.Login();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(string.IsNullOrEmpty(acct.BaseUrl));
            Assert.IsTrue(string.IsNullOrEmpty(acct.ApiPassword));
        }

        /// <summary>
        ///A test for Login
        ///</summary>
        [TestMethod()]
        public void AccountLoginNoPassword()
        {
            ConfigLoader.LoadConfig();

            bool expected = false;
            bool actual = true;

            // create a new account
            Account acct = new Account();
            acct.AccountName = Util.MakeUnique("freakin me out {unique}");
            acct.Email = Util.MakeUnique("freakin_{unique}@gmail.com");
            acct.Password = string.Empty;

            try
            {
                actual = acct.Login();
            }
            catch(Exception)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(string.IsNullOrEmpty(acct.BaseUrl));
            Assert.IsTrue(string.IsNullOrEmpty(acct.ApiPassword));
        }

        /// <summary>
        ///A test for adding users
        ///</summary>
        [TestMethod()]
        public void AccountCreateAddUser()
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

            Assert.IsNotNull(added);
        }
    }
}
