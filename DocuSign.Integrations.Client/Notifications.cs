using System;
using System.Runtime.Serialization;

namespace DocuSign.Integrations.Client
{
    [Serializable, DataContract]
    public class Notification
    {
        /// <summary>
        /// When true, the account default notification settings are used for the envelope.
        /// </summary>
        [DataMember(Name = "useAccountDefaults")]
        public bool UseAccountDefaults { get; set; }

        /// <summary>
        /// A complex element that specifies reminder settings for the envelope.
        /// </summary>
        [DataMember(Name = "expirations")]
        public Expirations Expirations { get; set; }

        /// <summary>
        /// A complex element that specifies the expiration settings for the envelope.
        /// </summary>
        [DataMember(Name = "reminders")]
        public Reminders Reminders { get; set; }
    }
}