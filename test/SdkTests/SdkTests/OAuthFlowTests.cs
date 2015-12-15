using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
using Microsoft.Owin.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Owin;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Web.Http;

namespace SdkTests
{

    // This test demostrates the OAuth2 Authoration Code Flow sequence with the DocuSign Account Server
    // The steps are:
    // 1. Initiate a browser session to the DocuSign Account Server auth endpoint including the client_id and redirect_url
    // 2. The Account Server presents a login page in the browser.
    // 3. The user enters their credentials into the login page
    // 4. The Account Server authenticates the user and accesses the redirect_url with a code
    // 5. The applicatiion exchanges the code for an access_token using the Account Server token endpont.
    // 6. The access_token and a refresh_token are returned
    // 7. The application uses the access_token to make API calls to the REST API. The refresh_token may 
    //    be stored away and used retrieve a new access_token when the token expires.


    // Prerequisites - Register Application in Docusign Account Server envrionment
    // Navigate to accountAdmin.localhost
    // Add an application: 
    //  1. Make note of the client Application Id (client_id below)
    //  2. Set a Client Secret (client_secret below )
    //  3. Set a Callback Url (redirect_url below)

 


    [TestClass]
    public class OAuthFlowTests : ApiController
    {
        // rest API location
        public const string BaseUrl = "https://localhost/restapi";

        // These items are all registered with the DocuSign Account server (accountadmin.<host>.xxx.com)
        // and are required to perform the Oauth Sequence
        public const string client_id = "12e9e403-eff9-4d5b-a56e-b735fcb60fbe";
        public const string client_secret = "docusign";
        public const string redirect_url = "http://localhost:8090/myapp/auth_callback";

        // This is an application-speicifc param that may be passed around during the oauth
        // sequence. It allows the app to track its flow.
        public const string stateOptional = "testState";

        // This is the account server used for this test.
        public const string AccountServerHost = "account.DSV010331A";


        // This will be returned to the test via the callback url after the
        // user authenticates via the browser and the account server
        public static string AccessCode { get; internal set; }

        // This will be filled in with the access_token retrieved from the token endpoint using the Code above
        // after the user has authenticated via a browser and the account server
        // This is the Bearer token used to make API calls.
        public static string AccessToken { get; set; }
        public static string StateValue { get; internal set; }
 

        // This event handle is used to block the self-hosted Web service in the test
        // until the oauth login is completed.
        public static ManualResetEvent WaitForCallbackEvent = null;

        [TestMethod]
        public void OAuthAuthorizationCodeFlowTest()
        {
            // Initiate the browser session to the Authentication server
            // so the user can login.
            string accountServerAuthUrl = string.Format("https://{0}/oauth/auth?response_type=code&scope=all&client_id={1}&redirect_uri={2}&state=testState",
                                                        AccountServerHost,
                                                        client_id,
                                                        redirect_url,
                                                        stateOptional);
           System.Diagnostics.Process.Start(accountServerAuthUrl);

            WaitForCallbackEvent = new ManualResetEvent(false);

            // Launch a self-hosted web server to accepte the redirect_url call
            // after the user finishes authencation.
            using (WebApp.Start<Startup>("http://localhost:8090"))
            {
                Trace.WriteLine("WebServer Running- Waiting for access_token");

                // This waits for the redirect_url to be received in the REST controller
                // (see classes below) and then sleeps a short time to allow the response
                // to be returned to the web browser before the server session ends.
                WaitForCallbackEvent.WaitOne(60000, false);
                Thread.Sleep(1000);
            }

            Assert.IsNotNull(AccessCode);

            // The Authentication is completed, so now echange a code returned for
            // the access_token and refresh_token
            var webClient = new WebClient();

            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            // Add the Authorization header with client_id and client_secret as base64
            string codeAuth = client_id + ":" + client_secret;
            byte[] codeAuthBytes = Encoding.UTF8.GetBytes(codeAuth);
            string codeAuthBase64 = Convert.ToBase64String(codeAuthBytes);
            webClient.Headers.Add("Authorization", "Basic " + codeAuthBase64);

            // Add the code returned from the Authentication site
            string tokenGrantAndCode = string.Format("grant_type=authorization_code&code={0}", AccessCode);

            // Call the token endpoint to exchange the code for an access_token
            string tokenEndpoint = string.Format("https://{0}/oauth/token", AccountServerHost);
            string tokenResponse = webClient.UploadString(tokenEndpoint, tokenGrantAndCode);
            TokenResponse tokenObj = JsonConvert.DeserializeObject<TokenResponse>(tokenResponse);

            Assert.IsNotNull(tokenObj);
            Assert.IsNotNull(tokenObj.access_token);
            Trace.WriteLine("Access_token: " + tokenObj.access_token);

            // Make an API call with the token
            ApiClient apiClient = new ApiClient(BaseUrl);
            
            DocuSign.eSign.Client.Configuration.Default.ApiClient = apiClient;
            DocuSign.eSign.Client.Configuration.Default.AddDefaultHeader("Authorization", "Bearer " + tokenObj.access_token);

            AccountsApi accountsApi = new AccountsApi();
            AccountInformation accountInformation = accountsApi.GetAccountInformation("1");
            Trace.WriteLine(accountInformation.ToString());

            // Generally the refresh token is stored away and used to get a new access_token without authenticating via the browser
            // when the access_token expires (see expires_in). Here we test that the refresh_token can be
            // exchanged for a new access_token

            webClient = new WebClient();
            webClient.Headers.Add("Authorization", "Basic " + codeAuthBase64);
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            // Add the code returned from the Authentication site
            string refreshGrant = string.Format("grant_type=refresh_token&refresh_token={0}", tokenObj.refresh_token);
            tokenResponse = webClient.UploadString(tokenEndpoint, refreshGrant);
            tokenObj = JsonConvert.DeserializeObject<TokenResponse>(tokenResponse);

            Assert.IsNotNull(tokenObj);
            Assert.IsNotNull(tokenObj.access_token);
            Trace.WriteLine("Access_token (After Refresh): " + tokenObj.access_token);

            // Try another call with new acccess token
            accountInformation = accountsApi.GetAccountInformation("1");
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
                routeTemplate: "myApp/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }
    }

    // API Controller and action called via the redirect_url registered for thie client_id
    public class auth_callbackController : ApiController
    {
        // GET myapp/auth_callback 
        public HttpResponseMessage Get()
        {
            OAuthFlowTests.AccessCode = Request.RequestUri.ParseQueryString()["code"];

            // state is app-specific string that may be ppassed around.
            OAuthFlowTests.StateValue = Request.RequestUri.ParseQueryString()["state"];

            HttpResponseMessage response = new HttpResponseMessage();
            response.Content = new StringContent("Redirect Completed");
            response.StatusCode = System.Net.HttpStatusCode.OK;

            // Signal the main test that the rsponse has been received.
            OAuthFlowTests.WaitForCallbackEvent.Set();
            return response;
        }
    }

    // response object from the AuthServer token endpoint. This is used
    // to obtain access_tokens for making API calls and refresh_tokens for getting new
    // access tokens after the token expires.
    public class TokenResponse 
    {
        public string access_token { get; set; }

        public string token_type { get; set; }

        public string refresh_token { get; set; }

        public int? expires_in { get; set; }
    }

 

}



