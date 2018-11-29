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

        public string IntegratorKeyNoConsent { get; set; }

        public string PrivateKeyNoConsentFilename { get; set; }

        public TestConfig(string username = null, string password = null, string integratorKey = null, string host = null, string recipientEmail = null, string recipientName = null, string templateRoleName = null, string templateId = null, string returnUrl = null)
        {
            this.Host = (host != null) ? host : "https://demo.docusign.net/restapi";
            this.Username = (username != null) ? username : "node_sdk@mailinator.com";
            this.Password = (password != null) ? password : "qweqweasdasd";
            this.IntegratorKey = (integratorKey != null) ? integratorKey : "ae30ea4e-3959-4d1c-b867-fcb57d2dc4df";

            this.RecipientEmail = (recipientEmail != null) ? recipientEmail : "node_sdk@mailinator.com";
            this.RecipientName = (recipientName != null) ? recipientName : "Pat Developer";

            this.TemplateRoleName = (templateRoleName != null) ? templateRoleName : "bob";
            this.TemplateId = (templateId != null) ? templateId : "cf2a46c2-8d6e-4258-9d62-752547b1a419";

            this.ReturnUrl = (returnUrl != null) ? returnUrl : "https://www.docusign.com/devcenter";

            this.UserId = "fcc5726c-cd73-4844-b580-40bbbe6ca126";
            this.OAuthBasePath = "account-d.docusign.com";
            this.PrivateKeyFilename = "../../docs/private.pem";
            this.ExpiresInHours = 1;

            this.EnvelopeIdsList = new List<string>();

            this.IntegratorKeyNoConsent = "66750331-ee4b-4ab8-b8ee-6c1a413a6096";
            this.PrivateKeyNoConsentFilename = "../../docs/privateKeyConsentReq.pem";
            //this.Configuration = new Configuration();
        }
    }
}