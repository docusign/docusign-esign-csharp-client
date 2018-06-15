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
using DocuSign.eSign.Client.Auth;

namespace TestProj
{
    class CoreRecipes
    {

        // Enter your DocuSign API information and credentials below.  
        // Note: You only need a DocuSign account to SEND documents,
        // signing is always free and signers do not need an account.

        //Base Path for the demo account
        private readonly string BASE_URL = "https://demo.docusign.net/restapi";
        // Integrator Key (aka API key) is needed to authenticate your API calls.  This is an application-wide key
        private readonly string INTEGRATOR_KEY = "[INTEGRATOR_KEY]";
        // User ID (aka APIUserName)
        private readonly string USER_ID = "[USER_ID]";
        // Redirect URI - this is where the user will be redirected once Authentication steps succeeds.
        private readonly string REDIRECT_URI = "[REDIRECT_URL]";
        //Private Key - paste the entire PRIVATE Key here
        private readonly string PRIVATE_KEY = "[PRIVATE_KEY]";
        //Optional State  - state which you want to return
        private readonly string STATE = "";

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
            // Enter recipient (signer) name and email address
            string recipientName = "[RECIPIENT_NAME]";
            string recipientEmail = "[RECIPIENT_EMAIL]";

            // the document (file) we want signed
            const string SignTest1File = @"[PATH/TO/DOCUMENT/TEST.PDF]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1:JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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
            // Enter recipient (signer) name and email address
            string recipientName = "[RECIPIENT_NAME]";
            string recipientEmail = "[RECIPIENT_EMAIL]";

            // the document (file) we want signed
            string templateId = "[TEMPLATE_ID]";
            string templateRoleName = "[TEMPLATE_ROLE_NAME]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1:JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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
            // provide a valid envelope ID from your account.  
            string envelopeId = "[ENVELOPE_ID]]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1:JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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
            // provide a valid envelope ID from your account.  
            string envelopeId = "[ENVELOPE_ID]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1:JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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
            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1: JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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
            // provide a valid envelope ID from your account.  
            string envelopeId = "[ENVELOPE_ID]]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1:JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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
            // Enter recipient (signer) name and email address
            string recipientName = "[RECIPIENT_NAME]";
            string recipientEmail = "[RECIPIENT_EMAIL]";

            // the document (file) we want signed
            const string SignTest1File = @"[PATH/TO/DOCUMENT/TEST.PDF]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1:JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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
            // Enter recipient (signer) name and email address
            string recipientName = "[RECIPIENT_NAME]";
            string recipientEmail = "[RECIPIENT_EMAIL]";

            // the document (file) we want signed
            const string SignTest1File = @"[PATH/TO/DOCUMENT/TEST.PDF]";

            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1:JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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
            // instantiate api client with appropriate environment (for production change to www.docusign.net/restapi)
            configureApiClient(BASE_URL);

            //===========================================================
            // Step 1:JWT Login()
            //===========================================================

            // call the JWT Configure and UserInfo API which sets the user's baseUrl and returns their accountId
            string accountId = JWTAuthLogin();

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

        public string JWTAuthLogin()
        {
            // we set the api client in global config when we configured the client 
            ApiClient apiClient = Configuration.Default.ApiClient;

            // ONE TIME STEP for granting consent
            // Update and Run the below Uri with your INTEGRATOR_KEY and REDIRECT_URI
            // Example authorization URI -> https://account-d.docusign.com/oauth/auth?
            // response_type =code&scope=signature%20impersonation&client_id=$INTEGRATOR_KEY&redirect_uri=$REDIRECT_URI"

            // OR Run the below method to get your app specific Uri generated for you...
            // string oauthLoginUrl = GetAuthorizationURLforConsent();
            // Once you give consent (one-time only) then you can continue with futher requests...

            string oAuthBasePath = "account-d.docusign.com"; // for demo the base path would have "-d"

            OAuth.OAuthToken tokenInfo = apiClient.ConfigureJwtAuthorizationFlowByKey(INTEGRATOR_KEY, USER_ID, oAuthBasePath, PRIVATE_KEY, 1);

            OAuth.UserInfo userInfo = apiClient.GetUserInfo(tokenInfo.access_token);

            string accountId = string.Empty;

            foreach (var item in userInfo.GetAccounts())
            {
                if (item.GetIsDefault() == "true")
                {
                    accountId = item.AccountId();
                    apiClient = new ApiClient(item.GetBaseUri() + "/restapi");
                    break;
                }
            }

            return accountId;
        }

        private string GetAuthorizationURLforConsent()
        {
            // we set the api client in global config when we configured the client 
            ApiClient apiClient = Configuration.Default.ApiClient;

            // Give consent to your app
            // Adding signature as out scope.
            List<string> scopes = new List<string>
            {
                OAuth.Scope_SIGNATURE,
                OAuth.Scope_IMPERSONATION
            };

            Uri oauthLoginUrl = apiClient.GetAuthorizationUri(INTEGRATOR_KEY, scopes, REDIRECT_URI, OAuth.CODE, STATE);

            return oauthLoginUrl.AbsoluteUri;
        }

    } // end class
} // end namespace
