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


        // These items are all registered at the DocuSign Admin console and are required 
        // to perform the OAuth flow.
        public string client_id = "***REMOVED***";
        public string client_secret = "***REMOVED***";
        public string redirect_uri = "http://localhost:3000";

        // This is an application-specific param that may be passed around during the OAuth
        // flow. It allows the app to track its flow, in addition to more security.
        public const string stateOptional = "testState";

        [TestMethod]
        public void AuthorizationCodeGrantTest()
        {
            // These items are all registered at the DocuSign Admin console and are required 
            // to perform the OAuth flow.
            client_id = "***REMOVED***";
            client_secret = "***REMOVED***";
            redirect_uri = "http://localhost:3000";

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
            // System.Diagnostics.Process.Start(oauthLoginUrl.AbsoluteUri);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 2: Get the code - Login to the browser and get the code from the url and paste it below 
            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            string code = "eyJ0eXAiOiJNVCIsImFsZyI6IlJTMjU2Iiwia2lkIjoiNjgxODVmZjEtNGU1MS00Y2U5LWFmMWMtNjg5ODEyMjAzMzE3In0.AQgAAAABAAYABwCAjlsEKcvVSAgAgBriSynL1UgCAIJ68LfViMZCseKsUbNdP9wVAAEAAAAYAAEAAAAFAAAADQAkAAAAY2Y1NzdkODQtZTc3MS00OTA4LWExMWYtMjkyOTA5NGU0NmY2MAAASWqvJcvVSA.WjsA2qj4QE0GeEpQuplXI2v1hzQuCRtE5hGHcfwBnWlhDqqjj1Ru7JRcdOUld5wbDDxYyw5aWeFTPZNx7CqRKpSTcHi_y_q_ENwog-OmHYvb51YOl6ZetnqNPq9hj8nt8-4FpWYHt0Ft2t7h8LdwYT0rp_dP8Dh9fmQxakHADnMo30cGd7upA0RNwnL9rsG1HZo6jY2I7IrbnahVrQ46uSqXSD4gpVtYDAPtMV8In0LESjRf6LrgosW38rTGb-6iAQ2dhQ4q8Ui7UQEsNa67UMuv7Rggtx-VowuyIloY-OEpmizCv1J-jQwSrvdyxSyhykBIh1YxqdqfMjwzAH_5zw;";
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
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

            // ASSERT
            Assert.IsNotNull(userInfo);
            Assert.AreEqual("bharat rele", userInfo.GetName().ToLower());
            Assert.IsNotNull(userInfo.GetAccounts());
            Assert.AreEqual("BharatRele", userInfo.GetAccounts()[0].GetAccountName());
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

            EnvelopeDefinition envDef = new EnvelopeDefinition();
            envDef.EmailSubject = "[DocuSign C# SDK] - Please sign this doc";

            // assign recipient to template role by setting name, email, and role name.  Note that the
            // template role name must match the placeholder role name saved in your account template.  
            TemplateRole tRole = new TemplateRole();
            tRole.Email = "aparnapai22@gmail.com";
            tRole.Name = "Aparna Rele";
            tRole.RoleName = "Role";
            List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };

            // add the role to the envelope and assign valid templateId from your account
            envDef.TemplateRoles = rolesList;
            envDef.TemplateId = "3e148cc9-664c-46ab-862a-54ef073d3e5e";

            // set envelope status to "sent" to immediately send the signature request
            envDef.Status = "sent";

            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            EnvelopesApi envelopesApi = new EnvelopesApi(apiClient.Configuration);
            EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(accountId, envDef);
        }

        [TestMethod]
        public void ImplicitCodeGrantTest()
        {

            // These items are all registered at the DocuSign Admin console and are required 
            // to perform the OAuth flow.
            client_id = "46168e79-48ed-42aa-b3d5-efca05b01843"; // "[YOUR_CLIENT_ID]";
            // here client secret should be mobile app secret
            client_secret = "***REMOVED***"; // "[YOUR_CLIENT_SECRET]";
            redirect_uri = "http://localhost:3000";

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

            string token = "eyJ0eXAiOiJNVCIsImFsZyI6IlJTMjU2Iiwia2lkIjoiNjgxODVmZjEtNGU1MS00Y2U5LWFmMWMtNjg5ODEyMjAzMzE3In0.AQkAAAABAAUABwCA6FG1DMjVSAgAgCh1w0_I1UgCAIJ68LfViMZCseKsUbNdP9wVAAEAAAAYAAEAAAAFAAAADQAkAAAANDYxNjhlNzktNDhlZC00MmFhLWIzZDUtZWZjYTA1YjAxODQzMACA6FG1DMjVSBIAAQAAAAsAAABpbnRlcmFjdGl2ZQ.mrYj5ktHqS4fu2TAOhPSFag8QffI0FqGxBL0lEjdyW6lEkuLNYQqOl-Y4uFLFerESm410b8jXYUNjnsbOQhaPAB7ExA3zm3u8F642hXPLzwpIEktAneXzZMSanE-mJC75fo59JqDb_76MP0R4708aGPVsQo_NZk315uvjojfM6JpDAFyl1h4QL75jZYx9mmxrI0C3Nkv_EzHq5NMj2kLN3ZWrDYfAW84v1Md0gBxzHOixOLL0In2AkDSasy5tDKYUKPylii5sW34qEpb0w9fIFlxH0n-Njixna6EoLBEr8Ao0aVgERkIgrR3bN-_El-y596Zx8Bcs8O-CEVa1-_Xzg";
            //"[GET_THIS_FROM_LOGING_IN_USING_THE_ABOVE_URL]";

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 3: Get the User Info       
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // now that the API client has an OAuth token, let's use it in all
            // DocuSign APIs
            OAuth.UserInfo userInfo = apiClient.GetUserInfo(token);

            Assert.IsNotNull(userInfo);
            Assert.AreEqual("bharat rele", userInfo.GetName().ToLower());
            Assert.IsNotNull(userInfo.GetAccounts());
            Assert.AreEqual("BharatRele", userInfo.GetAccounts()[0].GetAccountName());
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
            // Uri oauthURI = testConfig.ApiClient.GetAuthorizationUri(testConfig.IntegratorKey, scopes, testConfig.ReturnUrl, OAuth.CODE, stateOptional);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 1: ConfigureJwtAuthorizationFlow      
            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            string privateKey = File.ReadAllText(testConfig.PrivateKeyFilename);
            OAuthToken tokenInfo = testConfig.ApiClient.ConfigureJwtAuthorizationFlowByKey(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKey, testConfig.ExpiresInHours);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // STEP 2: Get the Access Token 
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            // now that the API client has an OAuth token, let's use it in all
            // DocuSign APIs
            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.GetAccounts());

            string accountId = string.Empty;

            foreach (var item in userInfo.GetAccounts())
            {
                if (item.GetIsDefault() == "true")
                {
                    testConfig.AccountId = item.AccountId();
                    testConfig.ApiClient = new ApiClient(item.GetBaseUri() + "/restapi");
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