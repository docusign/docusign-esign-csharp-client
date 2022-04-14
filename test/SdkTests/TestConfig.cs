using DocuSign.eSign.Client;
using System;
using System.Collections.Generic;

namespace SdkTests
{
    class TestConfig
    {
        public string IntegratorKey { get; set; }
        public string Host { get; set; }
        public ApiClient ApiClient { get; set; }
        public string AccountId { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientName { get; set; }
        public string TemplateRoleName { get; set; }
        public string TemplateId { get; set; }
        public string EnvelopeId { get; set; }
        public string ReturnUrl { get; set; }
        public string UserId { get; set; }
        public string OAuthBasePath { get; set; }
        public byte[] PrivateKey { get; set; }
        public int ExpiresInHours { get; set; }

        public List<string> EnvelopeIdsList { get; set; }

        public string IntegratorKeyNoConsent { get; set; }

        public string PrivateKeyNoConsent { get; set; }

        public string BrandLogo { get; set; }

        public string BrandId { get; set; }

        public TestConfig(string integratorKey = null, string host = null, string recipientEmail = null,
            string recipientName = null, string templateRoleName = null, string templateId = null,
            string returnUrl = null)
        {
            string userIdFromEnv = Environment.GetEnvironmentVariable("userid");
            string integratorKeyFromEnv = Environment.GetEnvironmentVariable("integratorkey");
            string integratorKeyNoConsentFromEnv = Environment.GetEnvironmentVariable("integratorkeynoconsent");
            string templateIdFromEnv = Environment.GetEnvironmentVariable("templateid");
            string brandIdFromEnv = Environment.GetEnvironmentVariable("brandid");

            this.Host = host ?? "https://demo.docusign.net/restapi";
            this.IntegratorKey = integratorKey ?? integratorKeyFromEnv;

            this.RecipientEmail = recipientEmail ?? "docusignsdktest@mailinator.com";
            this.RecipientName = recipientName ?? "Pat Developer";

            this.TemplateRoleName = templateRoleName ?? "bob";
            this.TemplateId = templateId ?? templateIdFromEnv;

            this.ReturnUrl = returnUrl ?? "https://www.docusign.com/api";

            this.UserId = userIdFromEnv;
            this.OAuthBasePath = "account-d.docusign.com";
            this.PrivateKey = Convert.FromBase64String(Environment.GetEnvironmentVariable("privatekey"));
            this.ExpiresInHours = 1;

            this.EnvelopeIdsList = new List<string>();

            this.IntegratorKeyNoConsent = integratorKeyNoConsentFromEnv;
            this.PrivateKeyNoConsent = Environment.GetEnvironmentVariable("privatekeynoconsent");

            this.BrandLogo =
                "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";
            this.BrandId = brandIdFromEnv;
        }
    }
}