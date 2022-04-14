using Microsoft.VisualStudio.TestTools.UnitTesting;
using DocuSign.eSign.Model;
using DocuSign.eSign.Api;

namespace SdkNetCoreTests
{
    [TestClass]
    public class DiagnosticApiNetCoreUnitTests
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
