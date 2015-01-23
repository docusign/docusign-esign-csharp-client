using DocuSign.Integrations.Client;
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

            //TODO - update these values so that tests can run properly
            RestSettings.Instance.DistributorCode = "";
            RestSettings.Instance.DistributorPassword = "";
            RestSettings.Instance.IntegratorKey = "";
            RestSettings.Instance.PlanId = "";
            RestSettings.Instance.FeatureSetId = "";
            RestSettings.Instance.WebServiceUrl = "";
            RestSettings.Instance.EmailBlurb = "";
            RestSettings.Instance.EmailSubject = "";
            RestSettings.Instance.RestTracing = true;
        }
    }
}
