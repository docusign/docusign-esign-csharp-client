using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkTests462
{
    [TestClass]
    public class DiagnosticApiUnitTests
    {
        private TestConfig _testConfig;
        private DiagnosticsApi _diagnosticsApi;

        [TestInitialize]
        public void TestInitialize()
        {
            _testConfig = new TestConfig();
            JwtLoginMethod.RequestJWTUserToken_CorrectInputParameters_ReturnsOAuthToken(ref _testConfig);
            _diagnosticsApi = new DiagnosticsApi(_testConfig.ApiClient);
        }

        [TestMethod]
        public void GetSetting_ReturnDiagnosticsSettingsInformation()
        {
            
            DiagnosticsSettingsInformation diagnosticsSettingsInformation = _diagnosticsApi.GetRequestLogSettings();

            Assert.IsNotNull(diagnosticsSettingsInformation?.ApiRequestLogMaxEntries);
            Assert.IsNotNull(diagnosticsSettingsInformation?.ApiRequestLogRemainingEntries);
            Assert.IsNotNull(diagnosticsSettingsInformation?.ApiRequestLogging);
        }
    }
}
