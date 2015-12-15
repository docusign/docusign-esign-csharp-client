using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;

namespace TestProj
{
    class CoreRecipes
    {
        // Integrator Key (aka API key) is needed to authenticate your API calls.  This is an application-wide key
        private string INTEGRATOR_KEY = "[INTEGRATOR_KEY]";

        //////////////////////////////////////////////////////////
        // Main()
        //////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            CoreRecipes recipes = new CoreRecipes();
            
            //*** TEST 1 - Request Signature (on local document)            
            EnvelopeSummary envSummary = recipes.requestSignatureOnDocumentTest();

            //*** TEST 2 - Request Signature (from Template)
            //EnvelopeSummary envSummary = recipes.requestSignatureFromTemplateTest();

            //*** TEST 3 - Get Envelope Information           
            //Envelope env = recipes.getEnvelopeInformationTest();

            //*** TEST 4 - Get Recipient Information
            //Recipients recips = recipes.listRecipientsTest();

            //*** TEST 5 - List Envelopes           
            //EnvelopesInformation envelopes = recipes.listEnvelopesTest();

            //*** TEST 6 - Download Envelope Documents
            //recipes.listDocumentsAndDownloadTest();

            //*** TEST 7 - Embedded Sending            
            //ViewUrl senderView = recipes.createEmbeddedSendingViewTest();

            //*** TEST 8 - Embedded Signing 
            //ViewUrl recipientView = recipes.createEmbeddedSigningViewTest();

            //*** TEST 9 - Embedded DocuSign Console          
            //ViewUrl consoleView = recipes.createEmbeddedConsoleViewTest();

            Console.Read();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public EnvelopeSummary requestSignatureOnDocumentTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // Enter recipient (signer) name and email address
            string recipientName = "[RECIPIENT_NAME]";
            string recipientEmail = "[RECIPIENT_EMAIL]";

            // the document (file) we want signed
            const string SignTest1File = @"[PATH/TO/DOCUMENT/TEST.PDF]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: Signature Request (AKA create & send Envelope)
            //===========================================================

            // Read a file from disk to use as a document.
            byte[] fileBytes = File.ReadAllBytes(SignTest1File);

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // Add a document to the envelope
            Document doc = new Document();
            doc.DocumentBase64 = System.Convert.ToBase64String(fileBytes);
            doc.Name = "TestFile.pdf";
            doc.DocumentId = "1";

            envDef.Documents = new List<Document>();
            envDef.Documents.Add(doc);

            // Add a recipient to sign the documeent
            Signer signer = new Signer();
            signer.Email = recipientEmail;
            signer.Name = recipientName;
            signer.RecipientId = "1";

            // Create a |SignHere| tab somewhere on the document for the recipient to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "100";
            signHere.YPosition = "100";
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.Signers.Add(signer);

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi();
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(accountId, envDef);

            // print the JSON response
            Console.WriteLine("EnvelopeSummary:\n{0}", JsonConvert.SerializeObject(envelopeSummary));

            return envelopeSummary;

        } // end requestSignatureTest()

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public EnvelopeSummary requestSignatureFromTemplateTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // Enter recipient (signer) name and email address
            string recipientName = "[RECIPIENT_NAME]";
            string recipientEmail = "[RECIPIENT_EMAIL]";

            // the document (file) we want signed
            string templateId = "[TEMPLATE_ID]";
            string templateRoleName = "[TEMPLATE_ROLE_NAME]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: Signature Request from Template 
            //===========================================================

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // assign recipient to template role by setting name, email, and role name.  Note that the
            // template role name must match the placeholder role name saved in your account template.  
            TemplateRole tRole = new TemplateRole();
            tRole.Email = recipientEmail;
            tRole.Name = recipientName;
            tRole.RoleName = templateRoleName;

            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            // add the role to the envelope and assign valid templateId from your account
            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = templateId;

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi();
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(accountId, envDef);

            // print the JSON response
            Console.WriteLine("EnvelopeSummary:\n{0}", JsonConvert.SerializeObject(envelopeSummary));

            return envelopeSummary;

        } // end requestSignatureFromTemplateTest()

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Envelope getEnvelopeInformationTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // provide a valid envelope ID from your account.  
            string envelopeId = "[ENVELOPE_ID]]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: Get Envelope Information
            //===========================================================

            // |EnvelopesApi| contains methods related to creating and sending Envelopes including status calls
            EnvelopesApi envelopesApi = new EnvelopesApi();
            Envelope envInfo = envelopesApi.GetEnvelope(accountId, envelopeId);

            // print the JSON response
            Console.WriteLine("EnvelopeInformation:\n{0}", JsonConvert.SerializeObject(envInfo));

            return envInfo;
        } // end requestSignatureFromTemplateTest()

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Recipients listRecipientsTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // provide a valid envelope ID from your account.  
            string envelopeId = "[ENVELOPE_ID]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: List Envelope Recipients
            //===========================================================

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi();
            Recipients recips = envelopesApi.ListRecipients(accountId, envelopeId);

            // print the JSON response
            Console.WriteLine("Recipients:\n{0}", JsonConvert.SerializeObject(recips));

            return recips;

        } // end getRecipientInformationTest()

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public EnvelopesInformation listEnvelopesTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: List Envelopes (using filters)
            //===========================================================

            // This example gets statuses of all envelopes in your account going back 1 full month...
            DateTime fromDate = DateTime.UtcNow;
            fromDate = fromDate.AddDays(-30);
            string fromDateStr = fromDate.ToString("o");

            // set a filter for the envelopes we want returned using the fromDate and count properties
            EnvelopesApi.ListStatusChangesOptions options = new EnvelopesApi.ListStatusChangesOptions()
            {
                count = "10",
                fromDate = fromDateStr
            };

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi();
            EnvelopesInformation envelopes = envelopesApi.ListStatusChanges(accountId, options);

            // print the JSON response
            Console.WriteLine("Envelopes:\n{0}", JsonConvert.SerializeObject(envelopes));

            return envelopes;

        } // end listEnvelopesTest()

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void listDocumentsAndDownloadTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // provide a valid envelope ID from your account.  
            string envelopeId = "[ENVELOPE_ID]]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: List Envelope Document(s)
            //===========================================================

            // |EnvelopesApi| contains methods related to envelopes and envelope recipients
            EnvelopesApi envelopesApi = new EnvelopesApi();
            EnvelopeDocumentsResult docsList = envelopesApi.ListDocuments(accountId, envelopeId);

            // print the JSON response
            Console.WriteLine("EnvelopeDocumentsResult:\n{0}", JsonConvert.SerializeObject(docsList));

            //===========================================================
            // Step 3: Download Envelope Document(s)
            //===========================================================

            // read how many documents are in the envelope
            int docCount = docsList.EnvelopeDocuments.Count;
            string filePath = null;
            FileStream fs = null;

            // loop through the envelope's documents and download each doc
            for (int i = 0; i < docCount; i++)
            {
                // GetDocument() API call returns a MemoryStream
                MemoryStream docStream = (MemoryStream)envelopesApi.GetDocument(accountId, envelopeId, docsList.EnvelopeDocuments[i].DocumentId);
                // let's save the document to local file system
                filePath = Path.GetTempPath() + Path.GetRandomFileName() + ".pdf";
                fs = new FileStream(filePath, FileMode.Create);
                docStream.Seek(0, SeekOrigin.Begin);
                docStream.CopyTo(fs);
                fs.Close();
                Console.WriteLine("Envelope Document {0} has been downloaded to:  {1}", i, filePath);
            }

        } // end listDocumentsAndDownloadTest()

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public ViewUrl createEmbeddedSendingViewTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // Enter recipient (signer) name and email address
            string recipientName = "[RECIPIENT_NAME]";
            string recipientEmail = "[RECIPIENT_EMAIL]";

            // the document (file) we want signed
            const string SignTest1File = @"[PATH/TO/DOCUMENT/TEST.PDF]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: Create A Draft Envelope
            //===========================================================

            // Read a file from disk to use as a document.
            byte[] fileBytes = File.ReadAllBytes(SignTest1File);

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // Add a document to the envelope
            Document doc = new Document();
            doc.DocumentBase64 = System.Convert.ToBase64String(fileBytes);
            doc.Name = "TestFile.pdf";
            doc.DocumentId = "1";

            envDef.Documents = new List<Document>();
            envDef.Documents.Add(doc);

            // Add a recipient to sign the documeent
            Signer signer = new Signer();
            signer.Email = recipientEmail;
            signer.Name = recipientName;
            signer.RecipientId = "1";

            // Create a |SignHere| tab somewhere on the document for the recipient to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "100";
            signHere.YPosition = "100";
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.Signers.Add(signer);

            // must set status to "created" since we cannot open Sender View on an Envelope that has already been sent, only on draft envelopes
            envDef.Status = "created";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi();
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(accountId, envDef);

            //===========================================================
            // Step 3: Create Embedded Sending View (URL)
            //===========================================================

            ReturnUrlRequest options = new ReturnUrlRequest();
            options.ReturnUrl = "https://www.docusign.com/devcenter";

            // generate the embedded sending URL
            ViewUrl senderView = envelopesApi.CreateSenderView(accountId, envelopeSummary.EnvelopeId, options);

            // print the JSON response
            Console.WriteLine("ViewUrl:\n{0}", JsonConvert.SerializeObject(senderView));

            // Start the embedded sending session
            System.Diagnostics.Process.Start(senderView.Url);

            return senderView;

        } // end createEmbeddedSendingViewTest()


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public ViewUrl createEmbeddedSigningViewTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // Enter recipient (signer) name and email address
            string recipientName = "[RECIPIENT_NAME]";
            string recipientEmail = "[RECIPIENT_EMAIL]";

            // the document (file) we want signed
            const string SignTest1File = @"[PATH/TO/DOCUMENT/TEST.PDF]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: Create and Send an Envelope with Embedded Recipient
            //===========================================================

            // Read a file from disk to use as a document.
            byte[] fileBytes = File.ReadAllBytes(SignTest1File);

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // Add a document to the envelope
            Document doc = new Document();
            doc.DocumentBase64 = System.Convert.ToBase64String(fileBytes);
            doc.Name = "TestFile.pdf";
            doc.DocumentId = "1";

            envDef.Documents = new List<Document>();
            envDef.Documents.Add(doc);

            // Add a recipient to sign the documeent
            Signer signer = new Signer();
            signer.Email = recipientEmail;
            signer.Name = recipientName;
            signer.RecipientId = "1";
            signer.ClientUserId = "1234"; // must set |clientUserId| to embed the recipient!

            // Create a |SignHere| tab somewhere on the document for the recipient to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "100";
            signHere.YPosition = "100";
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.Signers.Add(signer);

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi();
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(accountId, envDef);

            //===========================================================
            // Step 3: Create Embedded Signing View (URL)
            //===========================================================

            RecipientViewRequest viewOptions = new RecipientViewRequest()
            {
                ReturnUrl = "https://www.docusign.com/devcenter",
                ClientUserId = "1234",  // must match clientUserId set in step #2!
                AuthenticationMethod = "email",
                UserName = envDef.Recipients.Signers[0].Name,
                Email = envDef.Recipients.Signers[0].Email
            };

            // create the recipient view (aka signing URL)
            ViewUrl recipientView = envelopesApi.CreateRecipientView(accountId, envelopeSummary.EnvelopeId, viewOptions);

            // print the JSON response
            Console.WriteLine("ViewUrl:\n{0}", JsonConvert.SerializeObject(recipientView));

            // Start the embedded signing session
            System.Diagnostics.Process.Start(recipientView.Url);

            return recipientView;

        } // end createEmbeddedSigningViewTest()

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public ViewUrl createEmbeddedConsoleViewTest()
        {
            // Enter your DocuSign credentials below.  Note: You only need a DocuSign account to SEND documents,
            // signing is always free and signers do not need an account.
            string username = "[EMAIL]";
            string password = "[PASSWORD]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient("https://demo.docusign.net/restapi");

            //===========================================================
            // Step 1: Login()
            //===========================================================

            // call the Login() API which sets the user's baseUrl and returns their accountId
            string accountId = loginApi(username, password);

            //===========================================================
            // Step 2: Create Embedded Console View (URL)
            //===========================================================

            ReturnUrlRequest urlRequest = new ReturnUrlRequest();
            urlRequest.ReturnUrl = "https://www.docusign.com/devcenter";

            // Adding the envelopeId start sthe console with the envelope open
            EnvelopesApi envelopesApi = new EnvelopesApi();
            ViewUrl viewUrl = envelopesApi.CreateConsoleView(accountId, null);

            // Start the embedded signing session.
            System.Diagnostics.Process.Start(viewUrl.Url);

            return viewUrl;

        } // end createEmbeddedConsoleViewTest()




        //**********************************************************************************************************************
        //**********************************************************************************************************************
        //*  HELPER FUNCTIONS
        //**********************************************************************************************************************
        //**********************************************************************************************************************
        public void configureApiClient(string basePath)
        {
            // instantiate a new api client
            ApiClient apiClient = new ApiClient(basePath);

            // set client in global config so we don't need to pass it to each API object.
            Configuration.Default.ApiClient = apiClient;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public string loginApi(string usr, string pwd)
        {
            // we set the api client in global config when we configured the client 
            ApiClient apiClient = Configuration.Default.ApiClient;
            string authHeader = "{\"Username\":\"" + usr + "\", \"Password\":\"" + pwd + "\", \"IntegratorKey\":\"" + INTEGRATOR_KEY + "\"}";
            Configuration.Default.AddDefaultHeader("X-DocuSign-Authentication", authHeader);

            // we will retrieve this from the login() results
            string accountId = null;

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            AuthenticationApi authApi = new AuthenticationApi();
            LoginInformation loginInfo = authApi.Login();

            // find the default account for this user
            foreach (LoginAccount loginAcct in loginInfo.LoginAccounts)
            {
                if (loginAcct.IsDefault == "true")
                {
                    accountId = loginAcct.AccountId;
                    break;
                }
            }
            if (accountId == null)
            { // if no default found set to first account
                accountId = loginInfo.LoginAccounts[0].AccountId;
            }
            return accountId;
        }

    } // end class
} // end namespace
