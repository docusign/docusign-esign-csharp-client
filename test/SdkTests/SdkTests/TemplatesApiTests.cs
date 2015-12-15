using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;

namespace SdkTests
{
    [TestClass]
    public class TemplatesApiTests
    {
        [TestMethod]
        public void CreateTemplateTest()
        {
            try
            {
                AuthenticationApiTests authTests = new AuthenticationApiTests();
                authTests.LoginTest();

                EnvelopeTemplate templateDef = Utils.CreateDefaultTemplate();

                TemplatesApi templatesApi = new TemplatesApi();
                TemplateSummary tempSummary = templatesApi.CreateTemplate(TestConfig.AccountId, templateDef);
                Assert.IsNotNull(tempSummary);
                Assert.IsNotNull(tempSummary.TemplateId);
                Trace.WriteLine("TemplateSummary: " + tempSummary.ToJson());

            }
            catch (DocuSign.eSign.Client.ApiException apiEx)
            { 

                // FAILS - API-3002 submitted.
                Assert.IsNotNull(apiEx.ErrorCode);
                Assert.IsTrue(!string.IsNullOrWhiteSpace(apiEx.Message));
                Assert.IsTrue(false, "Failed with ErrorCode: " + apiEx.ErrorCode + ", Message: " + apiEx.Message);
            }
        }
    }
}
