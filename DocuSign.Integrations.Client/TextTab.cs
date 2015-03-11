// -----------------------------------------------------------------------
// <copyright file="TextTab.cs" company="Chris Stokes">
// Copyright (c) Chris Stokes
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSign.Integrations.Client
{
    public class TextTab : Tab
    {
        /// <summary>
        /// A regular expression that will be validated when data is entered in the field. This is
        /// optional and if not provided the default DocuSign validation rules will apply. This can 
        /// be a maximum of 250 characters. Javascript RegEx object is used for regular expression 
        /// validation. Regular expressions must be supported by this object to resolve.
        /// </summary>
        public string validationPattern { get; set; }

        /// <summary>
        /// Message to be displayed to the signer if the validation rule from validationPattern fails. 
        /// This is optional and if not provided the default DocuSign message will be displayed. This 
        /// can be a maximum of 250 characters. 
        /// </summary>
        public string validationMessage { get; set; }

        /// <summary>
        /// Optional element for field markup. When set to true, enables field markup for the field. 
        /// </summary>
        public bool shared { get; set; }

        /// <summary>
        /// Optional element for field markup. When set to true it requires the signer to initial when 
        /// they modify a shared field. 
        /// </summary>
        public bool requireInitialOnSharedChange { get; set; }

        /// <summary>
        /// ???? $TODO: Workout what this is
        /// </summary>
        public bool requireAll { get; set; }

        /// <summary>
        /// This element specifies the value of the tab.
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// If true, the Signer cannot change the data in the tab.
        /// </summary>
        public bool locked { get; set; }

        /// <summary>
        /// Optional element. If true the field appears normally while the recipient is adding or modifying 
        /// the information in the field, but the data is not visible (the characters are hidden by asterisks)
        /// to any other signer or the sender. When an envelope is completed the information is available to
        /// the sender through the Form Data link in the DocuSign Console. This setting applies only to text 
        /// boxes and does not affect  
        /// </summary>
        public bool concealValueOnDocument { get; set; }

        /// <summary>
        /// Disables the auto sizing of single line text boxes in the signing screen when the signer enters 
        /// data. If disabled users will only be able enter as much data as the text box can hold. By default 
        /// this is false. This property only affects single line text boxes.
        /// </summary>
        public bool disableAutoSize { get; set; }

        /// <summary>
        /// Optional element. Used only when working with template tabs. If true, the attributes of the tab 
        /// cannot be changed by the sender
        /// </summary>
        public bool templateLocked { get; set; }

        /// <summary>
        /// Optional element. Used only when working with template tabs. If true, the tab cannot be removed 
        /// by the sender.
        /// </summary>
        public bool templateRequired { get; set; }
    }
}
