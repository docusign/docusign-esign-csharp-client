using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;

namespace SdkTests
{
    [TestClass]
    public class DiagnosticApiUnitTests
    {
        private TestConfig _testConfig;

        [ClassInitialize]
        public void ClassInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
        }

        [TestMethod]
        public void GetSetting_ReturnDiagnosticsSettingsInformation()
        {
            DiagnosticsApi diagnosticsApi = new DiagnosticsApi(_testConfig.ApiClient);
            DiagnosticsSettingsInformation diagnosticsSettingsInformation = diagnosticsApi.GetRequestLogSettings();

            Assert.IsNotNull(diagnosticsSettingsInformation);
            Assert.IsNotNull(diagnosticsSettingsInformation.ApiRequestLogMaxEntries);
            Assert.IsNotNull(diagnosticsSettingsInformation.ApiRequestLogRemainingEntries);
            Assert.IsNotNull(diagnosticsSettingsInformation.ApiRequestLogging);
        }
    }
}
