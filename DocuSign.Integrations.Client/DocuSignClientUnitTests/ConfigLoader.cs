using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientUnitTests
{
    static class ConfigLoader
    {
        public static void LoadConfig()
        {
            CustomConfig.AttributeSelectableSection rest = new CustomConfig.AttributeSelectableSection();
            CustomConfig.AttributeSelectableReader reader = new CustomConfig.AttributeSelectableReader();

            reader.ReadConfig(rest, "TargetSystems");

            DocuSignClient.RestSettings.Instance.DistributorCode = rest.Values["DistributorCode"];
            DocuSignClient.RestSettings.Instance.DistributorPassword = rest.Values["DistributorPassword"];
            DocuSignClient.RestSettings.Instance.IntegratorKey = rest.Values["IntegratorKey"];
            DocuSignClient.RestSettings.Instance.PlanId = rest.Values["PlanId"];
            DocuSignClient.RestSettings.Instance.FeatureSetId = rest.Values["FeatureSetId"];
            DocuSignClient.RestSettings.Instance.WebServiceUrl = rest.Values["WebServiceUrl"];
            DocuSignClient.RestSettings.Instance.EmailBlurb = rest.Values["EmailBlurb"];
            DocuSignClient.RestSettings.Instance.EmailSubject = rest.Values["EmailSubject"];
            DocuSignClient.RestSettings.Instance.RestTracing = true;
        }
    }
}
