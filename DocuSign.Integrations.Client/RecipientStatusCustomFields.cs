using System;

namespace DocuSign.Integrations.Client
{
    [Serializable]
    public class RecipientStatusCustomFields
    {
        [System.Xml.Serialization.XmlElementAttribute("CustomField")]
        public string[] CustomField { get; set; }
    }
}