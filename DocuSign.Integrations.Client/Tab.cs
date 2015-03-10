// -----------------------------------------------------------------------
// <copyright file="Tab.cs" company="DocuSign, Inc.">
// Copyright (c) DocuSign, Inc. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuSign.Integrations.Client
{
	/// <summary>
	/// Represents a Tab that can be used to sign an envelope
	/// </summary>
    [Serializable]
	public class Tab
	{
		/// <summary>
		/// Tab Id
		/// </summary>
		public string tabId { get; set; }
		/// <summary>
		/// Tab Name
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Page number where this tab shows in the document
		/// </summary>
		public int pageNumber { get; set; }
		/// <summary>
		/// Document where this tab shows
		/// </summary>
		public int documentId { get; set; }
		/// <summary>
		/// X pixels
		/// </summary>
		public int xPosition { get; set; }
		/// <summary>
		/// Y pixels
		/// </summary>
		public int yPosition { get; set; }
		/// <summary>
		/// Height in pixels
		/// </summary>
		public int height  { get; set; }
		/// <summary>
		/// Width in pixels
		/// </summary>
		public int width { get; set; }
		/// <summary>
		/// Tab Label for text tabs
		/// </summary>
		public string tabLabel { get; set; }
		private string _anchorString;
		/// <summary>
		/// String (regex) to use to match to this tab
		/// </summary>
		public string anchorString
		{
			get
			{
				// if it's white space - return null
				//
                if (String.IsNullOrEmpty(_anchorString) || _anchorString.Trim() == String.Empty)
                {
                    return null;
                }

                return  _anchorString;
			}
			set
			{
				_anchorString = value;
			}
		}

        /// <summary>
        /// Int X offset of the tab
        /// </summary>
        public int anchorXOffset { get; set; }
        /// <summary>
        /// Int Y offset of the tab
        /// </summary>
        public int anchorYOffset { get; set; }
        /// <summary>
        /// Units the tab offset is measured in
        /// </summary>
        public string anchorUnits { get; set; }
        /// <summary>
        ///The font size used for the information in
        ///the tab. Possible values are: Size7,
        ///Size8, Size9, Size10, Size11, Size12,
        ///Size14, Size16, Size18, Size20, Size22,
        ///Size24, Size26, Size28, Size36, Size48,
        ///or Size72.
        /// <s/ummary>
        public string fontSize { get; set; }

        /// <summary>
        ///If true, the signer is required to fill out this tab.
        /// <s/ummary>
        public bool required { get; set; }

        /// <summary>
        /// The recipient for the tab
        /// </summary>
        public string recipientId { get; set; }
	}

	/// <summary>
	/// Represents a collection of different type of tabs
	/// </summary>
	public class TabCollection
	{
		/// <summary>
		/// Place this tag where the recipient must sign the document. This tag can be set to be optional. 
		/// </summary>
		public List<Tab> signHereTabs { get; set; }
		/// <summary>
		/// Place this tag where the recipient must initial the document. This tag can be set to be optional
		/// </summary>
		public List<Tab> initialHereTabs { get; set; }
		/// <summary>
		/// Place this tag on the document where you want the recipient’s name to appear.
		/// </summary>
		public List<Tab> fullNameTabs { get; set; }
		/// <summary>
		/// This is a single-line fields that accepts any characters.
		/// </summary>
		public List<Tab> emailTabs { get; set; }
		/// <summary>
		/// This tab is a field where the recipient can enter any type of characters. 
		/// </summary>
		public List<TextTab> textTabs { get; set; }
		/// <summary>
		/// Place this tag on the document where you want the recipient’s title to appear.
		/// </summary>
		public List<Tab> titleTabs { get; set; }
		/// <summary>
		/// Place this tag on the document where you want the recipient’s company name to appear.
		/// </summary>
		public List<Tab> companyTabs { get; set; }
		/// <summary>
		/// Place this tag on the document where you want the date the recipient signed the document to automatically appear.
		/// </summary>
		public List<Tab> dateSignedTabs { get; set; }
		/// <summary>
		/// Place this tag on the document in a location where the recipient can select a yes/no (on/off) type option.
		/// </summary>
		public List<Tab> checkboxTabs { get; set; }
        /// <summary>
        /// Place this tag on the document to allow signer to add attachments to the signed doc
        /// </summary>
        public List<Tab> signerAttachmentTabs { get; set; }

		/// <summary>
		/// Default constructor
		/// </summary>
        public TabCollection()
		{
			this.signHereTabs = new List<Tab>();
			this.initialHereTabs = new List<Tab>();
			this.fullNameTabs = new List<Tab>();
			this.emailTabs = new List<Tab>();
            this.textTabs = new List<TextTab>();
			this.titleTabs = new List<Tab>();
			this.companyTabs = new List<Tab>();
			this.dateSignedTabs = new List<Tab>();
			this.checkboxTabs = new List<Tab>();
            this.signerAttachmentTabs = new List<Tab>();
		}
	}
}
