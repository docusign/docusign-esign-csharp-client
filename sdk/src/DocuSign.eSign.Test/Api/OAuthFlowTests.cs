using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
using Microsoft.Owin.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Owin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Web.Http;

namespace SdkTests
{
    // This test demostrates the DocuSign OAuth2 authorization fode flow
    // The steps are:
    // 1. Initiate a browser session to the DocuSign OAuth auth endpoint including the client_id and redirect_url
    // 2. DocuSign presents a login page in the browser;
    // 3. The user enters their credentials into the login page;
    // 4. DocuSign authenticates the user and redirects the browser to the specified redirect_url with a code;
    // 5. Your application exchanges the code for an access_token using DocuSign OAuth token endpoint;
    // 6. The access_token and a refresh_token are returned;
    // 7. The application uses the access_token to make API calls to the REST API. The refresh_token may 
    //    be stored away and used to retrieve a new access_token when the token expires.

    // Prerequisites - Register your Application in the Docusign Admin console
    // Add an application: 
    //  1. Make note of the integrator key (client_id below);
    //  2. Set a client Secret (client_secret below );
    //  3. Set a callback Url (redirect_url below).

    [TestClass]
    public class OAuthFlowTests : ApiController
    {
        // DocuSign REST API base URL
        public const string BaseUrl = "https://demo.docusign.net/restapi";

        // These items are all registered at the DocuSign Admin console and are required to perform 
        // the OAuth flow.
        public const string client_id = "ae30ea4e-3959-4d1c-b867-fcb57d2dc4df";
        public const string client_secret = "b4dccdbe-232f-46cc-96c5-b2f0f7448f8f";
        public const string redirect_url = "http://localhost:3000/auth/callback";

        // This is an application-speicifc param that may be passed around during the OAuth
        // flow. It allows the app to track its flow, in addition to more security.
        public const string stateOptional = "testState";

        // This will be returned to the test via the callback url after the
        // user authenticates via the browser.
        public static string AccessCode { get; internal set; }

        // This will be filled in with the access_token retrieved from the token endpoint using the code above.
        // This is the Bearer token that will be used to make API calls.
        public static string AccessToken { get; set; }
        public static string StateValue { get; internal set; }

        // This event handle is used to block the self-hosted Web service in the test
        // until the OAuth login is completed.
        public static ManualResetEvent WaitForCallbackEvent = null;

        [TestMethod]
        public void OAuthAuthorizationCodeFlowTest()
        {

            // Make an API call with the token
            ApiClient apiClient = new ApiClient(BaseUrl);
            DocuSign.eSign.Client.Configuration.Default.ApiClient = apiClient;

            List<string> scopes = new List<string>
            {
                "signature"
            };

            string response_type = "CODE";

            // Initiate the browser session to the Authentication server
            // so the user can login.
            Uri accountServerAuthUrl = apiClient.GetAuthorizationUri(client_id, scopes, redirect_url, response_type, stateOptional);
            System.Diagnostics.Process.Start(accountServerAuthUrl.AbsolutePath);

            WaitForCallbackEvent = new ManualResetEvent(false);

            // Launch a self-hosted web server to accepte the redirect_url call
            // after the user finishes authentication.
            using (WebApp.Start<Startup>("http://localhost:3000"))
            {
                Trace.WriteLine("WebServer Running. Waiting for access_token...");

                // This waits for the redirect_url to be received in the REST controller
                // (see classes below) and then sleeps a short time to allow the response
                // to be returned to the web browser before the server session ends.
                WaitForCallbackEvent.WaitOne(60000, false);
                Thread.Sleep(1000);
            }
            Assert.IsNotNull(AccessCode);

            DocuSign.eSign.Client.Auth.OAuth.OAuthToken oAuthToken = apiClient.GenerateAccessToken(client_id, client_secret, AccessCode);
            Assert.IsNotNull(oAuthToken);
            Trace.WriteLine("Access_token: " + oAuthToken.access_token);

            // we will retrieve this from the login API call
            string accountId = null;

            /////////////////////////////////////////////////////////////////
            // STEP 1: LOGIN API        
            /////////////////////////////////////////////////////////////////

            // login call is available in the authentication api 
            AuthenticationApi authApi = new AuthenticationApi();
            LoginInformation loginInfo = authApi.Login();

            // parse the first account ID that is returned (user might belong to multiple accounts)
            accountId = loginInfo.LoginAccounts[0].AccountId;

            // Update ApiClient with the new base url from login call
            apiClient = new ApiClient(loginInfo.LoginAccounts[0].BaseUrl);

            /////////////////////////////////////////////////////////////////
            // STEP 2: CREATE ACCOUNTS API        
            /////////////////////////////////////////////////////////////////	
            AccountsApi accountsApi = new AccountsApi();
            AccountInformation accountInformation = accountsApi.GetAccountInformation(accountId);
            Trace.WriteLine(accountInformation.ToString());
        }

        [TestMethod]
        public void OAuthResourceOwnerPasswordGrantTest()
        {

            // NOT RELEASED IN THIS VERSION
            throw new AssertFailedException("Not Implemented");
            //ApiClient apiClient = new ApiClient(TestConfig.BaseUrl);
            //string authHeader = Utils.CreateAuthHeader(TestConfig.UserName, TestConfig.Password, TestConfig.IntegratorKey);


            //// set client in global config so we don't need to pass it to each API object.
            //DocuSign.eSign.Client.Configuration.Default.ApiClient = apiClient;
            //DocuSign.eSign.Client.Configuration.Default.AddDefaultHeader("X-DocuSign-Authentication", authHeader);

            //AuthenticationApi authApi = new AuthenticationApi();
            //OauthAccess oauthAccess = authApi.GetOAuthToken();

            //// use the oauth token and header instead of the DocuSign auth header
            //apiClient = new ApiClient(TestConfig.BaseUrl);

            //DocuSign.eSign.Client.Configuration.Default.ApiClient = apiClient;
            //DocuSign.eSign.Client.Configuration.Default.AddDefaultHeader("Authorization", "Bearer " + oauthAccess.AccessToken);
            //LoginInformation loginInfo = authApi.Login();

            ////Assert.IsNotNull(loginInfo.ApiPassword);
            //Assert.IsNotNull(loginInfo.LoginAccounts);
            //Assert.IsTrue(loginInfo.LoginAccounts.Count > 0);
            //Assert.IsTrue(!String.IsNullOrWhiteSpace(loginInfo.LoginAccounts[0].AccountId));

            //authApi.RevokeOAuthToken();
            //loginInfo = authApi.Login();


        }
    }

    // Configuration for self-hosted Web service. THis allows the test to call out to the
    // Account Server endponts and have the resulting browser login session redirect
    // directly into this test.
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "auth/{controller}/{id}",
                defaults: new { controller = "callback", id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }
    }

    // API Controller and action called via the redirect_url registered for thie client_id
    public class CallbackController : ApiController
    {
        // GET auth/callback 
        public HttpResponseMessage Get()
        {
            OAuthFlowTests.AccessCode = Request.RequestUri.ParseQueryString()["code"];

            // state is app-specific string that may be passed around for validation.
            OAuthFlowTests.StateValue = Request.RequestUri.ParseQueryString()["state"];

            HttpResponseMessage response = new HttpResponseMessage
            {
                Content = new StringContent("Redirect Completed"),
                StatusCode = HttpStatusCode.OK
            };

            // Signal the main test that the response has been received.
            OAuthFlowTests.WaitForCallbackEvent.Set();
            return response;
        }
    }
}



