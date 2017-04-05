using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocuSign.eSign.Model;
using System.IO;
using DocuSign.eSign.Client;

namespace SdkTests
{
    class Utils
    {
        public static string CreateAuthHeader(string userName, string password, string integratorKey)
        {
            DocuSignCredentials dsCreds = new DocuSignCredentials()
            {
                Username = userName,
                Password = password,
                IntegratorKey = integratorKey
            };

            string authHeader = Newtonsoft.Json.JsonConvert.SerializeObject(dsCreds);
            return authHeader;
        }

        internal static EnvelopeTemplate CreateDefaultTemplate(string templateName = null)
        {
            // Read a file from disk to use as a document.

            EnvelopeTemplate templateDef = new EnvelopeTemplate();
            byte[] fileBytes = File.ReadAllBytes(TestConfig.SignTest1File);

            templateDef.EmailSubject = "Template " + DateTime.Now.ToString();
            templateDef.EnvelopeTemplateDefinition = new EnvelopeTemplateDefinition();

            string tempName = templateName;
            if (tempName == null) tempName = "Template Name " + DateTime.Now.ToString();
            templateDef.EnvelopeTemplateDefinition.Name = tempName;

            Document doc = new Document();
            doc.DocumentBase64 = System.Convert.ToBase64String(fileBytes);
            doc.Name = "TestFile.pdf";
            doc.DocumentId = "1";

            templateDef.Documents = new List<Document>();
            templateDef.Documents.Add(doc);

            // Add a recipient to sign the documeent
            Signer signer = new Signer();
            signer.RoleName = "Signer1";
            signer.RecipientId = "1";



            // Create a SignHere tab somewhere on the document for the signer to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "200";
            signHere.YPosition = "100";
            signHere.ScaleValue = "0.5";
            signer.Tabs.SignHereTabs.Add(signHere);

            templateDef.Recipients = new Recipients();
            templateDef.Recipients.Signers = new List<Signer>();
            templateDef.Recipients.Signers.Add(signer);
            return templateDef;
        }

        internal static void ConfigureApiClient()
        {
            ApiClient apiClient = new ApiClient(TestConfig.BaseUrl);
            string authHeader = Utils.CreateAuthHeader(TestConfig.UserName, TestConfig.Password, TestConfig.IntegratorKey);
            // set client in global config so we don't need to pass it to each API object.
            Configuration.Default.ApiClient = apiClient;

            if (Configuration.Default.DefaultHeader.ContainsKey("X-DocuSign-Authentication"))
            {
                Configuration.Default.DefaultHeader.Remove("X-DocuSign-Authentication");
            }
            Configuration.Default.AddDefaultHeader("X-DocuSign-Authentication", authHeader);


        }

        internal static EnvelopeDefinition CreateDraftEnvelopeDefinition()
        {
            // Read a file from disk to use as a document.
            byte[] fileBytes = File.ReadAllBytes(TestConfig.SignTest1File);

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "Please Sign my C# SDK Envelope";

            Document doc = new Document();
            doc.DocumentBase64 = System.Convert.ToBase64String(fileBytes);
            doc.Name = "TestFile.pdf";
            doc.DocumentId = "1";

            envDef.Documents = new List<Document>();
            envDef.Documents.Add(doc);

            // Add a recipient to sign the documeent
            Signer signer = new Signer();
            signer.Email = TestConfig.UserName;  // use name is same as my email
            signer.Name = "Pat Developer";
            signer.RecipientId = "1";



            // Create a SignHere tab somewhere on the document for the signer to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "100";
            signHere.YPosition = "100";
            signHere.ScaleValue = "0.5";
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.Signers.Add(signer);
            return envDef;
        }
    }
}
