using System;
using System.Runtime.Serialization;

namespace DocuSign.Integrations.Client
{
    [Serializable, DataContract]
    public class Reminders
    {
        /// <summary>
        /// When true the envelope expires (is no longer available for signing) in the set number of days. 
        /// If false, the account default setting is used. 
        /// If the account does not have an expiration setting, the DocuSign default value of 120 days is used.
        /// </summary>
        [DataMember(Name = "reminderEnabled")]
        public bool ReminderEnabled { get; set; }

        /// <summary>
        /// An interger that sets the number of days after the recipient receives the envelope that reminder emails are sent to the recipient.
        /// </summary>
        [DataMember(Name = "reminderDelay")]
        public int ReminderDelay { get; set; }

        /// <summary>
        /// An interger that sets the interval, in days, between reminder emails.
        /// </summary>
        [DataMember(Name = "reminderFrequency")]
        public int ReminderFrequency { get; set; }
    }
}