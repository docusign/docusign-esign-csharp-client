using DocuSign.eSign.Client;
using System.Collections.Generic;

namespace SdkTests
{
    class TestConfig
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string IntegratorKey { get; set; }
        public string Host { get; set; }
        public ApiClient ApiClient { get; set; }
        //public Configuration Configuration { get; set; }
        public string AccountId { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientName { get; set; }
        public string TemplateRoleName { get; set; }
        public string TemplateId { get; set; }
        public string EnvelopeId { get; set; }
        public string ReturnUrl { get; set; }
        public string UserId { get; set; }
        public string OAuthBasePath { get; set; }
        public string PrivateKeyFilename { get; set; }
        public int ExpiresInHours { get; set; }

        public List<string> EnvelopeIdsList { get; set; }

        public TestConfig(string username = null, string password = null, string integratorKey = null, string host = null, string recipientEmail = null, string recipientName = null, string templateRoleName = null, string templateId = null, string returnUrl = null)
        {
            this.Host = (host != null) ? host : "https://demo.docusign.net/restapi";
            this.Username = (username != null) ? username : "node_sdk@mailinator.com";
            this.Password = (password != null) ? password : "***REMOVED***";
            this.IntegratorKey = (integratorKey != null) ? integratorKey : "***REMOVED***";

            this.RecipientEmail = (recipientEmail != null) ? recipientEmail : "node_sdk@mailinator.com";
            this.RecipientName = (recipientName != null) ? recipientName : "Pat Developer";

            this.TemplateRoleName = (templateRoleName != null) ? templateRoleName : "bob";
            this.TemplateId = (templateId != null) ? templateId : "***REMOVED***";

            this.ReturnUrl = (returnUrl != null) ? returnUrl : "https://www.docusign.com/devcenter";

            this.UserId = "***REMOVED***";
            this.OAuthBasePath = "account-d.docusign.com";
            this.PrivateKeyFilename = "../../docs/private.pem";
            this.ExpiresInHours = 1;

            this.EnvelopeIdsList = new List<string>();
            //this.Configuration = new Configuration();
        }
    }
}