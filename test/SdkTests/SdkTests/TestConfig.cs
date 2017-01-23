using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocuSign.eSign.Model;

namespace SdkTests
{
    class TestConfig
    {
        public const string UserName = "node_sdk@mailinator.com";
        public const string Password = "qweqweasd";
        public const string IntegratorKey = "SAND-7c8746af-7f4d-4dbb-bf53-fc10861ef45b";
        public const string BaseUrl = "https://demo.docusign.net/restapi";

        public const string SignTest1File = @".../../docs/SignTest1.pdf";


        // these are working variables shared across test executions.
        public static string EnvelopeId { get; set; }
        public static string AccountId { get; internal set; }
        public static bool Authenticated {
            get { return AccountId != null; }
        }

        private static string _EnvelopeStatusOnCreate = null;

        public static string EnvelopeStatusOnCreate
        {
            get
            {
                if (_EnvelopeStatusOnCreate == null)
                {
                    _EnvelopeStatusOnCreate = "sent";
                }
                return _EnvelopeStatusOnCreate;
            }
            set
            {
                _EnvelopeStatusOnCreate = value;

            }
        }

        public static CustomFields EnvelopeCustomFields { get; internal set; }

        public static string DefaultReturnUrl = "http://www.docusign.com/developer-center";
        internal static string DefaultEmail = "dev.user@docusign.com";
        internal static string DefaultName = "Devi User";

        internal static bool EnvelopeCustomFieldsEqual(CustomFieldsEnvelope cfe)
        {
            if (cfe == null && EnvelopeCustomFields == null) return true;
            if (cfe.TextCustomFields != null)
            {
                if (EnvelopeCustomFields.TextCustomFields == null) return false;
                if (cfe.TextCustomFields.Count != EnvelopeCustomFields.TextCustomFields.Count) return false;


                bool textFieldFound = false;
                foreach (var cfeItem in cfe.TextCustomFields)
                {
                    foreach (var ecf in EnvelopeCustomFields.TextCustomFields)
                    {
                        if (cfeItem.Name == ecf.Name && cfeItem.Value == ecf.Value)
                        {
                            textFieldFound = true;
                            break;
                        }
                    }
                    if (!textFieldFound) return false;
                    textFieldFound = false;
                }
            }
            else
            {
                if (EnvelopeCustomFields.TextCustomFields != null) return false;
            }
            return true;
        }
    }
}
