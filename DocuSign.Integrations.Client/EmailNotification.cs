using System;

namespace DocuSignClient
{
    [Serializable]
    public class EmailNotification
    {
        public string emailBody { get; set; }

        public string emailSubject { get; set; }

        public string supportedLanguage { get; set; }
    }
}
