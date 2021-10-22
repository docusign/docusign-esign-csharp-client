using System.Linq;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkTests462
{
    [TestClass]
    public class TemplatesApiUnitTests
    {
        private TestConfig _testConfig;

        [ClassInitialize]
        public void ClassInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }


        [TestMethod]
        public void JwtGetTemplates_CorrectAccountId_ReturnEnvelopeTemplateResults()
        {
            TemplatesApi templatesApi = new TemplatesApi(_testConfig.ApiClient);
            EnvelopeTemplateResults envelopeTemplateResults = templatesApi.ListTemplates(_testConfig.AccountId);
            
            Assert.IsNotNull(envelopeTemplateResults);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault()?.TemplateId);
        }

        [TestMethod]
        public void JwtGetTemplate_CorrectAccountIdAndTemplateId_ReturnEnvelopeTemplate()
        {
            TemplatesApi templatesApi = new TemplatesApi(_testConfig.ApiClient);
            EnvelopeTemplateResults envelopeTemplateResults = templatesApi.ListTemplates(_testConfig.AccountId);
            string templateId = envelopeTemplateResults.EnvelopeTemplates.FirstOrDefault()?.TemplateId;

            Assert.IsNotNull(envelopeTemplateResults);
            Assert.IsNotNull(envelopeTemplateResults.EnvelopeTemplates);
            Assert.IsNotNull(templateId);

            EnvelopeTemplate envelopeTemplate = templatesApi.Get(_testConfig.AccountId, templateId);

            Assert.IsNotNull(envelopeTemplate);
            Assert.AreEqual(envelopeTemplate.TemplateId, templateId);
        }
    }
}
