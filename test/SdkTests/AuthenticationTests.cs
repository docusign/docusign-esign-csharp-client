using System;
using System.Collections.Generic;
using System.IO;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Client.Auth;
using DocuSign.eSign.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DocuSign.eSign.Client.Auth.OAuth;

namespace SdkTests
{
    [TestClass]
    public class AuthenticationTests
    {
        // Point to DocuSign Demo (sandbox) environment for requests
        public const string RestApiUrl = "https://demo.docusign.net/restapi";

        TestConfig testConfig = new TestConfig();
        
        // This is an application-specific param that may be passed around during the OAuth
        // flow. It allows the app to track its flow, in addition to more security.
        public const string stateOptional = "testState";

        [TestMethod]
        public void AuthorizationCodeGrantTest()
        {
            /*  Code example
          // These items are all registered at the DocuSign Admin console and are required 
          // to perform the OAuth flow.
          string client_id = "[YOUR_CLIENT_ID]";
          string client_secret = "[YOUR_CLIENT_SECRET]";
          string redirect_uri = "[YOUR_REDIRECT_URL]";
          // Instantiating a client.
          ApiClient apiClient = new ApiClient(RestApiUrl);
          // Adding signature as out scope.
          List<string> scopes = new List<string>
          {
              OAuth.Scope_SIGNATURE
          };
          /////////////////////////////////////////////////////////////////////////////////////////////////////////
          // STEP 1: Get the Auth URI          
          /////////////////////////////////////////////////////////////////////////////////////////////////////////
          Uri oauthLoginUrl = apiClient.GetAuthorizationUri(client_id, scopes, redirect_uri, OAuth.CODE, stateOptional);
          System.Diagnostics.Process.Start(oauthLoginUrl.AbsoluteUri);
          /////////////////////////////////////////////////////////////////////////////////////////////////////////
          // STEP 2: Get the code - Login to the browser and get the code from the url and paste it below 
          /////////////////////////////////////////////////////////////////////////////////////////////////////////
          string code = "[CODE_FROM_ABOVE_STEP]";
          ///////////////////////////////////////////////////////////////////////////////////////////////////////////
          // STEP 3: Get the token 
          /////////////////////////////////////////////////////////////////////////////////////////////////////////
          OAuth.OAuthToken oAuthToken = apiClient.GenerateAccessToken(client_id, client_secret, code);
          Assert.IsNotNull(oAuthToken);
          /////////////////////////////////////////////////////////////////////////////////////////////////////////
          // STEP 4: Get User Info -> send the accessToken retrieved from the above call...
          /////////////////////////////////////////////////////////////////////////////////////////////////////////
          // now that the API client has an OAuth token, let's use it in all
          // DocuSign APIs
          OAuth.UserInfo userInfo = apiClient.GetUserInfo(oAuthToken.access_token);
          // ASSERT - Uncomment Below Lines
          // Assert.IsNotNull(userInfo);
          // Assert.AreEqual("[YOUR_USER_NAME]", userInfo.GetName().ToLower());
          // Assert.IsNotNull(userInfo.GetAccounts());
          // Assert.AreEqual("[YOUR_ACCOUNT_NAME]", userInfo.GetAccounts()[0].GetAccountName());
          foreach (var item in userInfo.GetAccounts())
          {
              if (item.GetIsDefault() == "true")
              {
                  testConfig.AccountId = item.AccountId();
                  apiClient = new ApiClient(item.GetBaseUri() + "/restapi");
                  break;
              }
          }
          EnvelopeDefinition envDef = new EnvelopeDefinition();
          envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";
          // assign recipient to template role by setting name, email, and role name.  Note that the
          // template role name must match the placeholder role name saved in your account template.  
          TemplateRole tRole = new TemplateRole();
          tRole.Email = testConfig.RecipientEmail;
          tRole.Name = testConfig.RecipientName;
          tRole.RoleName = testConfig.TemplateRoleName;
          List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };
          // add the role to the envelope and assign valid templateId from your account
          envDef.TemplateRoles = rolesList;
          envDef.TemplateId = testConfig.TemplateId;
          // set envelope status to "sent" to immediately send the signature request
          envDef.Status = "sent";
          // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
          EnvelopesApi envelopesApi = new EnvelopesApi(apiClient.Configuration);
          EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

           */
        }

        [TestMethod]
        public void ImplicitCodeGrantTest()
        {

            /*  Code example
            // These items are all registered at the DocuSign Admin console and are required 
            // to perform the OAuth flow.
            string client_id = "[YOUR_CLIENT_ID]";
            // here client secret should be mobile app secret
            string client_secret = "[YOUR_CLIENT_SECRET]";
            string redirect_uri = "[YOUR_REDIRECT_URL]";
            //Initialize a client
            ApiClient apiClient = new ApiClient(RestApiUrl);
            List<string> scopes = new List<string>();
            scopes.Add(OAuth.Scope_SIGNATURE);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 1: Get the Uri       
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            Uri oauthLoginUrl = apiClient.GetAuthorizationUri(client_id, scopes, redirect_uri, OAuth.TOKEN, stateOptional);
            System.Diagnostics.Process.Start(oauthLoginUrl.AbsoluteUri);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 2: Get the Token from the Uri paste it below...       
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            string token = "[GET_THIS_FROM_LOGING_IN_USING_THE_ABOVE_URL]";
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 3: Get the User Info       
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // now that the API client has an OAuth token, let's use it in all
            // DocuSign APIs
            OAuth.UserInfo userInfo = apiClient.GetUserInfo(token);
            // ASSERT - Uncomment Below Lines
            // Assert.IsNotNull(userInfo);
            // Assert.AreEqual("[YOUR_USER_NAME]", userInfo.GetName().ToLower());
            // Assert.IsNotNull(userInfo.GetAccounts());
            // Assert.AreEqual("[YOUR_ACCOUNT_NAME]", userInfo.GetAccounts()[0].GetAccountName());
            */
        }

        [TestInitialize]
        [TestMethod]
        public void JwtTest()
        {
            // Instantiating a client
            testConfig.ApiClient = new ApiClient(testConfig.Host);
            // Adding signature as out scope.
            List<string> scopes = new List<string>
            {
                OAuth.Scope_SIGNATURE,
                OAuth.Scope_IMPERSONATION
            };

            // If this is the first time logging in - Get Consent from the user - this is a onetime step.
            //Uri oauthURI = testConfig.ApiClient.GetAuthorizationUri(testConfig.IntegratorKey, scopes, testConfig.ReturnUrl, OAuth.CODE, stateOptional);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 1: RequestJWTUserToken      
            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            byte[] privateKeyStream = File.ReadAllBytes(testConfig.PrivateKeyFilename);
            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 2: Get the Access Token 
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // now that the API client has an OAuth token, let's use it in all
            // DocuSign APIs
            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.Accounts);

            string accountId = string.Empty;

            foreach (var item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    testConfig.AccountId = item.AccountId;
                    testConfig.ApiClient = new ApiClient(item.BaseUri + "/restapi");
                    break;
                }
            }

            JwtRequestSignatureOnDocumentTest();
        }

        private void JwtRequestSignatureOnDocumentTest(string status = "sent")
        {
            // the document (file) we want signed
            const string SignTest1File = @"../../docs/SignTest1.pdf";

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
            signer.Email = testConfig.RecipientEmail;
            signer.Name = testConfig.RecipientName;
            signer.RecipientId = "1";
            signer.ClientUserId = "1234";

            // Create a |SignHere| tab somewhere on the document for the recipient to sign
            signer.Tabs = new Tabs();
            signer.Tabs.SignHereTabs = new List<SignHere>();
            SignHere signHere = new SignHere();
            signHere.DocumentId = "1";
            signHere.PageNumber = "1";
            signHere.RecipientId = "1";
            signHere.XPosition = "100";
            signHere.YPosition = "100";
            signHere.ScaleValue = ".5";
            signer.Tabs.SignHereTabs.Add(signHere);

            envDef.Recipients = new Recipients();
            envDef.Recipients.Signers = new List<Signer>();
            envDef.Recipients.Signers.Add(signer);


            TemplateTabs templateTabs = new TemplateTabs();
            templateTabs.DateTabs = new List<Date>();

            Tabs tabs = new Tabs();
            tabs.DateTabs = new List<Date>();

            SignerAttachment signerAttachment = new SignerAttachment();
            signerAttachment.ScaleValue = "";

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = status;

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(testConfig.ApiClient.Configuration);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(testConfig.AccountId, envDef);

            Assert.IsNotNull(envelopeSummary);
            Assert.IsNotNull(envelopeSummary.EnvelopeId);

            testConfig.EnvelopeId = envelopeSummary.EnvelopeId;
        }
    }
}