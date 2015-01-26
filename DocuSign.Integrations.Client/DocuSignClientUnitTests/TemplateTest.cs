using System;
using System.Collections.Generic;
using DocuSign.Integrations.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RestClientUnitTests
{
    [TestClass]
    public class TemplateTest
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
        
        [TestMethod]
        public void GetAllTempaltesForUserTest()
        {
            var template = new Template { Login = _account };
            var templates = template.GetTemplates();
            Assert.IsNull(template.RestError);
            Assert.IsTrue(templates.Count > 0); 
        }

        [TestMethod]
        public void CreateNewTemplate()
        {
            var template = new Template { Login = _account };
            byte[] doc1 = { 36, 45, 34, 67, 121, 87, 99, 32, 32, 32, 54, 54, 55, 56, 32 };
            var names = new List<string>();
            var docs = new List<byte[]>();
            names.Add("test1.doc");
            docs.Add(doc1);
            Assert.IsTrue(template.CreateTemplate(docs, names, "DocuSign.NET Client Unit Test Template"));
            Assert.IsNull(template.RestError);
            // Note that EnvelopeId for a template is the TemplateId...
            Assert.IsFalse(string.IsNullOrEmpty(template.EnvelopeId));
        }
    }
}
