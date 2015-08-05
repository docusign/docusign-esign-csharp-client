using System;
using System.Runtime.Serialization;

namespace DocuSign.Integrations.Client
{
    [Serializable, DataContract]
    public class Expirations
    {
        /// <summary>
        /// When true the envelope expires (is no longer available for signing) in the set number of days. 
        /// If false, the account default setting is used. 
        /// If the account does not have an expiration setting, the DocuSign default value of 120 days is used.
        /// </summary>
        [DataMember(Name = "expireEnabled")]
        public bool ExpireEnabled { get; set; }

        /// <summary>
        /// The number of days the envelope is active.
        /// </summary>
        [DataMember(Name = "expireAfter")]
        public int ExpireAfter { get; set; }

        /// <summary>
        /// The number of days before envelope expiration that an expiration warning email is sent to the recipient. 
        /// If set to 0 (zero), no warning email is sent.
        /// </summary>
        [DataMember(Name = "expireWarn")]
        public int ExpireWarn { get; set; }
    }
}