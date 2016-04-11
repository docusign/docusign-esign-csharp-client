using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace DocuSign.eSign.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITemplatesApi
    {
        
        /// <summary>
        /// Gets the definition of a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the list of templates for the specified account. The request can be limited to a specific folder.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>1EnvelopeTemplateResults</returns>
        EnvelopeTemplateResults ListTemplates (string accountId);
 
		/// <summary>
        /// Gets the definition of a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the list of templates for the specified account. The request can be limited to a specific folder.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>2ApiResponse of EnvelopeTemplateResults</returns>
        ApiResponse<EnvelopeTemplateResults> ListTemplatesWithHttpInfo (string accountId);

        /// <summary>
        /// Gets the definition of a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the list of templates for the specified account. The request can be limited to a specific folder.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>3Task of EnvelopeTemplateResults</returns>
        System.Threading.Tasks.Task<EnvelopeTemplateResults> ListTemplatesAsync (string accountId);

        /// <summary>
        /// Gets the definition of a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the list of templates for the specified account. The request can be limited to a specific folder.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>4Task of ApiResponse (EnvelopeTemplateResults)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeTemplateResults>> ListTemplatesAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Creates an envelope from a template.
        /// </summary>
        /// <remarks>
        /// Creates a template definition using a multipart request.\n\n###Template Email Subject Merge Fields\n\nCall this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\nTo add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_UserName]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\nTo add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_Email]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\n\nIn both cases the &lt;roleName&gt; is the recipient&#39;s contents of the `roleName` property in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>1TemplateSummary</returns>
        TemplateSummary CreateTemplate (string accountId, EnvelopeTemplate envelopeTemplate);
 
		/// <summary>
        /// Creates an envelope from a template.
        /// </summary>
        /// <remarks>
        /// Creates a template definition using a multipart request.\n\n###Template Email Subject Merge Fields\n\nCall this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\nTo add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_UserName]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\nTo add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_Email]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\n\nIn both cases the &lt;roleName&gt; is the recipient&#39;s contents of the `roleName` property in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>2ApiResponse of TemplateSummary</returns>
        ApiResponse<TemplateSummary> CreateTemplateWithHttpInfo (string accountId, EnvelopeTemplate envelopeTemplate);

        /// <summary>
        /// Creates an envelope from a template.
        /// </summary>
        /// <remarks>
        /// Creates a template definition using a multipart request.\n\n###Template Email Subject Merge Fields\n\nCall this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\nTo add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_UserName]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\nTo add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_Email]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\n\nIn both cases the &lt;roleName&gt; is the recipient&#39;s contents of the `roleName` property in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>3Task of TemplateSummary</returns>
        System.Threading.Tasks.Task<TemplateSummary> CreateTemplateAsync (string accountId, EnvelopeTemplate envelopeTemplate);

        /// <summary>
        /// Creates an envelope from a template.
        /// </summary>
        /// <remarks>
        /// Creates a template definition using a multipart request.\n\n###Template Email Subject Merge Fields\n\nCall this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\nTo add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_UserName]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\nTo add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_Email]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\n\nIn both cases the &lt;roleName&gt; is the recipient&#39;s contents of the `roleName` property in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>4Task of ApiResponse (TemplateSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateSummary>> CreateTemplateAsyncWithHttpInfo (string accountId, EnvelopeTemplate envelopeTemplate);
        
        /// <summary>
        /// Gets a list of templates for a specified account.
        /// </summary>
        /// <remarks>
        /// Retrieves the definition of the specified template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>1EnvelopeTemplate</returns>
        EnvelopeTemplate Get (string accountId, string templateId);
 
		/// <summary>
        /// Gets a list of templates for a specified account.
        /// </summary>
        /// <remarks>
        /// Retrieves the definition of the specified template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>2ApiResponse of EnvelopeTemplate</returns>
        ApiResponse<EnvelopeTemplate> GetWithHttpInfo (string accountId, string templateId);

        /// <summary>
        /// Gets a list of templates for a specified account.
        /// </summary>
        /// <remarks>
        /// Retrieves the definition of the specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>3Task of EnvelopeTemplate</returns>
        System.Threading.Tasks.Task<EnvelopeTemplate> GetAsync (string accountId, string templateId);

        /// <summary>
        /// Gets a list of templates for a specified account.
        /// </summary>
        /// <remarks>
        /// Retrieves the definition of the specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>4Task of ApiResponse (EnvelopeTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeTemplate>> GetAsyncWithHttpInfo (string accountId, string templateId);
        
        /// <summary>
        /// Updates an existing template.
        /// </summary>
        /// <remarks>
        /// Updates an existing template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>1TemplateUpdateSummary</returns>
        TemplateUpdateSummary Update (string accountId, string templateId, EnvelopeTemplate envelopeTemplate);
 
		/// <summary>
        /// Updates an existing template.
        /// </summary>
        /// <remarks>
        /// Updates an existing template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>2ApiResponse of TemplateUpdateSummary</returns>
        ApiResponse<TemplateUpdateSummary> UpdateWithHttpInfo (string accountId, string templateId, EnvelopeTemplate envelopeTemplate);

        /// <summary>
        /// Updates an existing template.
        /// </summary>
        /// <remarks>
        /// Updates an existing template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>3Task of TemplateUpdateSummary</returns>
        System.Threading.Tasks.Task<TemplateUpdateSummary> UpdateAsync (string accountId, string templateId, EnvelopeTemplate envelopeTemplate);

        /// <summary>
        /// Updates an existing template.
        /// </summary>
        /// <remarks>
        /// Updates an existing template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>4Task of ApiResponse (TemplateUpdateSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateUpdateSummary>> UpdateAsyncWithHttpInfo (string accountId, string templateId, EnvelopeTemplate envelopeTemplate);
        
        /// <summary>
        /// Gets the custom document fields from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document field information from an existing template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>1CustomFields</returns>
        CustomFields ListCustomFields (string accountId, string templateId);
 
		/// <summary>
        /// Gets the custom document fields from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document field information from an existing template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>2ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> ListCustomFieldsWithHttpInfo (string accountId, string templateId);

        /// <summary>
        /// Gets the custom document fields from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document field information from an existing template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>3Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> ListCustomFieldsAsync (string accountId, string templateId);

        /// <summary>
        /// Gets the custom document fields from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document field information from an existing template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>4Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> ListCustomFieldsAsyncWithHttpInfo (string accountId, string templateId);
        
        /// <summary>
        /// Updates envelope custom fields in a template.
        /// </summary>
        /// <remarks>
        /// Updates the custom fields in a template.\n\nEach custom field used in a template must have a unique name.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>1CustomFields</returns>
        CustomFields UpdateCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields);
 
		/// <summary>
        /// Updates envelope custom fields in a template.
        /// </summary>
        /// <remarks>
        /// Updates the custom fields in a template.\n\nEach custom field used in a template must have a unique name.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>2ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> UpdateCustomFieldsWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields);

        /// <summary>
        /// Updates envelope custom fields in a template.
        /// </summary>
        /// <remarks>
        /// Updates the custom fields in a template.\n\nEach custom field used in a template must have a unique name.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>3Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> UpdateCustomFieldsAsync (string accountId, string templateId, TemplateCustomFields templateCustomFields);

        /// <summary>
        /// Updates envelope custom fields in a template.
        /// </summary>
        /// <remarks>
        /// Updates the custom fields in a template.\n\nEach custom field used in a template must have a unique name.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>4Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> UpdateCustomFieldsAsyncWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields);
        
        /// <summary>
        /// Creates custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing template document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>1CustomFields</returns>
        CustomFields CreateCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields);
 
		/// <summary>
        /// Creates custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing template document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>2ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> CreateCustomFieldsWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields);

        /// <summary>
        /// Creates custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>3Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> CreateCustomFieldsAsync (string accountId, string templateId, TemplateCustomFields templateCustomFields);

        /// <summary>
        /// Creates custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>4Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> CreateCustomFieldsAsyncWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields);
        
        /// <summary>
        /// Deletes envelope custom fields in a template.
        /// </summary>
        /// <remarks>
        /// Deletes envelope custom fields in a template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>1CustomFields</returns>
        CustomFields DeleteCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields);
 
		/// <summary>
        /// Deletes envelope custom fields in a template.
        /// </summary>
        /// <remarks>
        /// Deletes envelope custom fields in a template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>2ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> DeleteCustomFieldsWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields);

        /// <summary>
        /// Deletes envelope custom fields in a template.
        /// </summary>
        /// <remarks>
        /// Deletes envelope custom fields in a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>3Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> DeleteCustomFieldsAsync (string accountId, string templateId, TemplateCustomFields templateCustomFields);

        /// <summary>
        /// Deletes envelope custom fields in a template.
        /// </summary>
        /// <remarks>
        /// Deletes envelope custom fields in a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>4Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> DeleteCustomFieldsAsyncWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields);
        
        /// <summary>
        /// Gets a list of documents associated with a template.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of documents associated with the specified template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>1TemplateDocumentsResult</returns>
        TemplateDocumentsResult ListDocuments (string accountId, string templateId);
 
		/// <summary>
        /// Gets a list of documents associated with a template.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of documents associated with the specified template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>2ApiResponse of TemplateDocumentsResult</returns>
        ApiResponse<TemplateDocumentsResult> ListDocumentsWithHttpInfo (string accountId, string templateId);

        /// <summary>
        /// Gets a list of documents associated with a template.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of documents associated with the specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>3Task of TemplateDocumentsResult</returns>
        System.Threading.Tasks.Task<TemplateDocumentsResult> ListDocumentsAsync (string accountId, string templateId);

        /// <summary>
        /// Gets a list of documents associated with a template.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of documents associated with the specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>4Task of ApiResponse (TemplateDocumentsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateDocumentsResult>> ListDocumentsAsyncWithHttpInfo (string accountId, string templateId);
        
        /// <summary>
        /// Adds documents to a template document.
        /// </summary>
        /// <remarks>
        /// Adds one or more documents to an existing template document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>1TemplateDocumentsResult</returns>
        TemplateDocumentsResult UpdateDocuments (string accountId, string templateId, EnvelopeDefinition envelopeDefinition);
 
		/// <summary>
        /// Adds documents to a template document.
        /// </summary>
        /// <remarks>
        /// Adds one or more documents to an existing template document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>2ApiResponse of TemplateDocumentsResult</returns>
        ApiResponse<TemplateDocumentsResult> UpdateDocumentsWithHttpInfo (string accountId, string templateId, EnvelopeDefinition envelopeDefinition);

        /// <summary>
        /// Adds documents to a template document.
        /// </summary>
        /// <remarks>
        /// Adds one or more documents to an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>3Task of TemplateDocumentsResult</returns>
        System.Threading.Tasks.Task<TemplateDocumentsResult> UpdateDocumentsAsync (string accountId, string templateId, EnvelopeDefinition envelopeDefinition);

        /// <summary>
        /// Adds documents to a template document.
        /// </summary>
        /// <remarks>
        /// Adds one or more documents to an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>4Task of ApiResponse (TemplateDocumentsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateDocumentsResult>> UpdateDocumentsAsyncWithHttpInfo (string accountId, string templateId, EnvelopeDefinition envelopeDefinition);
        
        /// <summary>
        /// Deletes documents from a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more documents from an existing template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>1TemplateDocumentsResult</returns>
        TemplateDocumentsResult DeleteDocuments (string accountId, string templateId, EnvelopeDefinition envelopeDefinition);
 
		/// <summary>
        /// Deletes documents from a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more documents from an existing template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>2ApiResponse of TemplateDocumentsResult</returns>
        ApiResponse<TemplateDocumentsResult> DeleteDocumentsWithHttpInfo (string accountId, string templateId, EnvelopeDefinition envelopeDefinition);

        /// <summary>
        /// Deletes documents from a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more documents from an existing template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>3Task of TemplateDocumentsResult</returns>
        System.Threading.Tasks.Task<TemplateDocumentsResult> DeleteDocumentsAsync (string accountId, string templateId, EnvelopeDefinition envelopeDefinition);

        /// <summary>
        /// Deletes documents from a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more documents from an existing template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>4Task of ApiResponse (TemplateDocumentsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateDocumentsResult>> DeleteDocumentsAsyncWithHttpInfo (string accountId, string templateId, EnvelopeDefinition envelopeDefinition);
        
        /// <summary>
        /// Gets PDF documents from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves one or more PDF documents from the specified template.\n\nYou can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>1Stream</returns>
        Stream GetDocument (string accountId, string templateId, string documentId);
 
		/// <summary>
        /// Gets PDF documents from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves one or more PDF documents from the specified template.\n\nYou can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>2ApiResponse of Stream</returns>
        ApiResponse<Stream> GetDocumentWithHttpInfo (string accountId, string templateId, string documentId);

        /// <summary>
        /// Gets PDF documents from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves one or more PDF documents from the specified template.\n\nYou can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>3Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> GetDocumentAsync (string accountId, string templateId, string documentId);

        /// <summary>
        /// Gets PDF documents from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves one or more PDF documents from the specified template.\n\nYou can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>4Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> GetDocumentAsyncWithHttpInfo (string accountId, string templateId, string documentId);
        
        /// <summary>
        /// Gets the custom document fields for a an existing template document.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document fields for an existing template document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>1DocumentFieldsInformation</returns>
        DocumentFieldsInformation ListDocumentFields (string accountId, string templateId, string documentId);
 
		/// <summary>
        /// Gets the custom document fields for a an existing template document.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document fields for an existing template document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>2ApiResponse of DocumentFieldsInformation</returns>
        ApiResponse<DocumentFieldsInformation> ListDocumentFieldsWithHttpInfo (string accountId, string templateId, string documentId);

        /// <summary>
        /// Gets the custom document fields for a an existing template document.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document fields for an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>3Task of DocumentFieldsInformation</returns>
        System.Threading.Tasks.Task<DocumentFieldsInformation> ListDocumentFieldsAsync (string accountId, string templateId, string documentId);

        /// <summary>
        /// Gets the custom document fields for a an existing template document.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document fields for an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>4Task of ApiResponse (DocumentFieldsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> ListDocumentFieldsAsyncWithHttpInfo (string accountId, string templateId, string documentId);
        
        /// <summary>
        /// Updates existing custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Updates existing custom document fields in an existing template document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>1DocumentFieldsInformation</returns>
        DocumentFieldsInformation UpdateDocumentFields (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);
 
		/// <summary>
        /// Updates existing custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Updates existing custom document fields in an existing template document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>2ApiResponse of DocumentFieldsInformation</returns>
        ApiResponse<DocumentFieldsInformation> UpdateDocumentFieldsWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Updates existing custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Updates existing custom document fields in an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>3Task of DocumentFieldsInformation</returns>
        System.Threading.Tasks.Task<DocumentFieldsInformation> UpdateDocumentFieldsAsync (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Updates existing custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Updates existing custom document fields in an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (DocumentFieldsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> UpdateDocumentFieldsAsyncWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);
        
        /// <summary>
        /// Creates custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing template document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>1DocumentFieldsInformation</returns>
        DocumentFieldsInformation CreateDocumentFields (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);
 
		/// <summary>
        /// Creates custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing template document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>2ApiResponse of DocumentFieldsInformation</returns>
        ApiResponse<DocumentFieldsInformation> CreateDocumentFieldsWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Creates custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>3Task of DocumentFieldsInformation</returns>
        System.Threading.Tasks.Task<DocumentFieldsInformation> CreateDocumentFieldsAsync (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Creates custom document fields in an existing template document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (DocumentFieldsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> CreateDocumentFieldsAsyncWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);
        
        /// <summary>
        /// Deletes custom document fields from an existing template document.
        /// </summary>
        /// <remarks>
        /// Deletes custom document fields from an existing template document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>1DocumentFieldsInformation</returns>
        DocumentFieldsInformation DeleteDocumentFields (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);
 
		/// <summary>
        /// Deletes custom document fields from an existing template document.
        /// </summary>
        /// <remarks>
        /// Deletes custom document fields from an existing template document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>2ApiResponse of DocumentFieldsInformation</returns>
        ApiResponse<DocumentFieldsInformation> DeleteDocumentFieldsWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Deletes custom document fields from an existing template document.
        /// </summary>
        /// <remarks>
        /// Deletes custom document fields from an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>3Task of DocumentFieldsInformation</returns>
        System.Threading.Tasks.Task<DocumentFieldsInformation> DeleteDocumentFieldsAsync (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Deletes custom document fields from an existing template document.
        /// </summary>
        /// <remarks>
        /// Deletes custom document fields from an existing template document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (DocumentFieldsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> DeleteDocumentFieldsAsyncWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation);
        
        /// <summary>
        /// Deletes a page from a document in an template.
        /// </summary>
        /// <remarks>
        /// Deletes a page from a document in a template based on the page number.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param> <param name="pageRequest">TBD Description</param>
		/// <returns>1</returns>
        void DeleteDocumentPage (string accountId, string templateId, string documentId, string pageNumber, PageRequest pageRequest);
 
		/// <summary>
        /// Deletes a page from a document in an template.
        /// </summary>
        /// <remarks>
        /// Deletes a page from a document in a template based on the page number.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param> <param name="pageRequest">TBD Description</param>
		/// <returns>2ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteDocumentPageWithHttpInfo (string accountId, string templateId, string documentId, string pageNumber, PageRequest pageRequest);

        /// <summary>
        /// Deletes a page from a document in an template.
        /// </summary>
        /// <remarks>
        /// Deletes a page from a document in a template based on the page number.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param> <param name="pageRequest">TBD Description</param>
		/// <returns>3Task of void</returns>
        System.Threading.Tasks.Task DeleteDocumentPageAsync (string accountId, string templateId, string documentId, string pageNumber, PageRequest pageRequest);

        /// <summary>
        /// Deletes a page from a document in an template.
        /// </summary>
        /// <remarks>
        /// Deletes a page from a document in a template based on the page number.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param> <param name="pageRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentPageAsyncWithHttpInfo (string accountId, string templateId, string documentId, string pageNumber, PageRequest pageRequest);
        
        /// <summary>
        /// Gets template lock information.
        /// </summary>
        /// <remarks>
        /// Retrieves general information about the template lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>1LockInformation</returns>
        LockInformation GetLock (string accountId, string templateId);
 
		/// <summary>
        /// Gets template lock information.
        /// </summary>
        /// <remarks>
        /// Retrieves general information about the template lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>2ApiResponse of LockInformation</returns>
        ApiResponse<LockInformation> GetLockWithHttpInfo (string accountId, string templateId);

        /// <summary>
        /// Gets template lock information.
        /// </summary>
        /// <remarks>
        /// Retrieves general information about the template lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>3Task of LockInformation</returns>
        System.Threading.Tasks.Task<LockInformation> GetLockAsync (string accountId, string templateId);

        /// <summary>
        /// Gets template lock information.
        /// </summary>
        /// <remarks>
        /// Retrieves general information about the template lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>4Task of ApiResponse (LockInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<LockInformation>> GetLockAsyncWithHttpInfo (string accountId, string templateId);
        
        /// <summary>
        /// Gets template notification information.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope notification, reminders and expirations, information for an existing template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>1Notification</returns>
        Notification GetNotificationSettings (string accountId, string templateId);
 
		/// <summary>
        /// Gets template notification information.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope notification, reminders and expirations, information for an existing template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>2ApiResponse of Notification</returns>
        ApiResponse<Notification> GetNotificationSettingsWithHttpInfo (string accountId, string templateId);

        /// <summary>
        /// Gets template notification information.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope notification, reminders and expirations, information for an existing template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>3Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> GetNotificationSettingsAsync (string accountId, string templateId);

        /// <summary>
        /// Gets template notification information.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope notification, reminders and expirations, information for an existing template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>4Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> GetNotificationSettingsAsyncWithHttpInfo (string accountId, string templateId);
        
        /// <summary>
        /// Updates the notification  structure for an existing template.
        /// </summary>
        /// <remarks>
        /// Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateNotificationRequest">TBD Description</param>
		/// <returns>1Notification</returns>
        Notification UpdateNotificationSettings (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest);
 
		/// <summary>
        /// Updates the notification  structure for an existing template.
        /// </summary>
        /// <remarks>
        /// Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateNotificationRequest">TBD Description</param>
		/// <returns>2ApiResponse of Notification</returns>
        ApiResponse<Notification> UpdateNotificationSettingsWithHttpInfo (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest);

        /// <summary>
        /// Updates the notification  structure for an existing template.
        /// </summary>
        /// <remarks>
        /// Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateNotificationRequest">TBD Description</param>
		/// <returns>3Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> UpdateNotificationSettingsAsync (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest);

        /// <summary>
        /// Updates the notification  structure for an existing template.
        /// </summary>
        /// <remarks>
        /// Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateNotificationRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> UpdateNotificationSettingsAsyncWithHttpInfo (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest);
        
        /// <summary>
        /// Gets recipient information from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the information for all recipients in the specified template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>1Recipients</returns>
        Recipients ListRecipients (string accountId, string templateId);
 
		/// <summary>
        /// Gets recipient information from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the information for all recipients in the specified template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>2ApiResponse of Recipients</returns>
        ApiResponse<Recipients> ListRecipientsWithHttpInfo (string accountId, string templateId);

        /// <summary>
        /// Gets recipient information from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the information for all recipients in the specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>3Task of Recipients</returns>
        System.Threading.Tasks.Task<Recipients> ListRecipientsAsync (string accountId, string templateId);

        /// <summary>
        /// Gets recipient information from a template.
        /// </summary>
        /// <remarks>
        /// Retrieves the information for all recipients in the specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>4Task of ApiResponse (Recipients)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipients>> ListRecipientsAsyncWithHttpInfo (string accountId, string templateId);
        
        /// <summary>
        /// Updates recipients in a template.
        /// </summary>
        /// <remarks>
        /// Updates recipients in a template. \n\nYou can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>1RecipientsUpdateSummary</returns>
        RecipientsUpdateSummary UpdateRecipients (string accountId, string templateId, TemplateRecipients templateRecipients);
 
		/// <summary>
        /// Updates recipients in a template.
        /// </summary>
        /// <remarks>
        /// Updates recipients in a template. \n\nYou can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>2ApiResponse of RecipientsUpdateSummary</returns>
        ApiResponse<RecipientsUpdateSummary> UpdateRecipientsWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients);

        /// <summary>
        /// Updates recipients in a template.
        /// </summary>
        /// <remarks>
        /// Updates recipients in a template. \n\nYou can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>3Task of RecipientsUpdateSummary</returns>
        System.Threading.Tasks.Task<RecipientsUpdateSummary> UpdateRecipientsAsync (string accountId, string templateId, TemplateRecipients templateRecipients);

        /// <summary>
        /// Updates recipients in a template.
        /// </summary>
        /// <remarks>
        /// Updates recipients in a template. \n\nYou can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>4Task of ApiResponse (RecipientsUpdateSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecipientsUpdateSummary>> UpdateRecipientsAsyncWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients);
        
        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more recipients to a template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>1Recipients</returns>
        Recipients CreateRecipients (string accountId, string templateId, TemplateRecipients templateRecipients);
 
		/// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more recipients to a template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>2ApiResponse of Recipients</returns>
        ApiResponse<Recipients> CreateRecipientsWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients);

        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more recipients to a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>3Task of Recipients</returns>
        System.Threading.Tasks.Task<Recipients> CreateRecipientsAsync (string accountId, string templateId, TemplateRecipients templateRecipients);

        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more recipients to a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>4Task of ApiResponse (Recipients)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipients>> CreateRecipientsAsyncWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients);
        
        /// <summary>
        /// Deletes recipients from a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>1Recipients</returns>
        Recipients DeleteRecipients (string accountId, string templateId, TemplateRecipients templateRecipients);
 
		/// <summary>
        /// Deletes recipients from a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>2ApiResponse of Recipients</returns>
        ApiResponse<Recipients> DeleteRecipientsWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients);

        /// <summary>
        /// Deletes recipients from a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>3Task of Recipients</returns>
        System.Threading.Tasks.Task<Recipients> DeleteRecipientsAsync (string accountId, string templateId, TemplateRecipients templateRecipients);

        /// <summary>
        /// Deletes recipients from a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>4Task of ApiResponse (Recipients)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipients>> DeleteRecipientsAsyncWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients);
        
        /// <summary>
        /// Deletes the specified recipient file from a template.
        /// </summary>
        /// <remarks>
        /// Deletes the specified recipient file from the specified template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>1Recipients</returns>
        Recipients DeleteRecipient (string accountId, string templateId, string recipientId, TemplateRecipients templateRecipients);
 
		/// <summary>
        /// Deletes the specified recipient file from a template.
        /// </summary>
        /// <remarks>
        /// Deletes the specified recipient file from the specified template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>2ApiResponse of Recipients</returns>
        ApiResponse<Recipients> DeleteRecipientWithHttpInfo (string accountId, string templateId, string recipientId, TemplateRecipients templateRecipients);

        /// <summary>
        /// Deletes the specified recipient file from a template.
        /// </summary>
        /// <remarks>
        /// Deletes the specified recipient file from the specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>3Task of Recipients</returns>
        System.Threading.Tasks.Task<Recipients> DeleteRecipientAsync (string accountId, string templateId, string recipientId, TemplateRecipients templateRecipients);

        /// <summary>
        /// Deletes the specified recipient file from a template.
        /// </summary>
        /// <remarks>
        /// Deletes the specified recipient file from the specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>4Task of ApiResponse (Recipients)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipients>> DeleteRecipientAsyncWithHttpInfo (string accountId, string templateId, string recipientId, TemplateRecipients templateRecipients);
        
        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </summary>
        /// <remarks>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>1Tabs</returns>
        Tabs ListTabs (string accountId, string templateId, string recipientId, Tabs tabs);
 
		/// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </summary>
        /// <remarks>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>2ApiResponse of Tabs</returns>
        ApiResponse<Tabs> ListTabsWithHttpInfo (string accountId, string templateId, string recipientId, Tabs tabs);

        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </summary>
        /// <remarks>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>3Task of Tabs</returns>
        System.Threading.Tasks.Task<Tabs> ListTabsAsync (string accountId, string templateId, string recipientId, Tabs tabs);

        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </summary>
        /// <remarks>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>4Task of ApiResponse (Tabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tabs>> ListTabsAsyncWithHttpInfo (string accountId, string templateId, string recipientId, Tabs tabs);
        
        /// <summary>
        /// Updates the tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Updates one or more tabs for a recipient in a template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>1Tabs</returns>
        Tabs UpdateTabs (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);
 
		/// <summary>
        /// Updates the tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Updates one or more tabs for a recipient in a template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>2ApiResponse of Tabs</returns>
        ApiResponse<Tabs> UpdateTabsWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);

        /// <summary>
        /// Updates the tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Updates one or more tabs for a recipient in a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>3Task of Tabs</returns>
        System.Threading.Tasks.Task<Tabs> UpdateTabsAsync (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);

        /// <summary>
        /// Updates the tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Updates one or more tabs for a recipient in a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>4Task of ApiResponse (Tabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tabs>> UpdateTabsAsyncWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);
        
        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more tabs for a recipient.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>1Tabs</returns>
        Tabs CreateTabs (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);
 
		/// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more tabs for a recipient.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>2ApiResponse of Tabs</returns>
        ApiResponse<Tabs> CreateTabsWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);

        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more tabs for a recipient.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>3Task of Tabs</returns>
        System.Threading.Tasks.Task<Tabs> CreateTabsAsync (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);

        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more tabs for a recipient.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>4Task of ApiResponse (Tabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tabs>> CreateTabsAsyncWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);
        
        /// <summary>
        /// Deletes the tabs associated with a recipient in a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more tabs associated with a recipient in a template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>1Tabs</returns>
        Tabs DeleteTabs (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);
 
		/// <summary>
        /// Deletes the tabs associated with a recipient in a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more tabs associated with a recipient in a template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>2ApiResponse of Tabs</returns>
        ApiResponse<Tabs> DeleteTabsWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);

        /// <summary>
        /// Deletes the tabs associated with a recipient in a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more tabs associated with a recipient in a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>3Task of Tabs</returns>
        System.Threading.Tasks.Task<Tabs> DeleteTabsAsync (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);

        /// <summary>
        /// Deletes the tabs associated with a recipient in a template.
        /// </summary>
        /// <remarks>
        /// Deletes one or more tabs associated with a recipient in a template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>4Task of ApiResponse (Tabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tabs>> DeleteTabsAsyncWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs);
        
        /// <summary>
        /// Shares a template with a group
        /// </summary>
        /// <remarks>
        /// Shares a template with the specified members group.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>1GroupInformation</returns>
        GroupInformation UpdateGroupShare (string accountId, string templateId, string templatePart, GroupInformation groupInformation);
 
		/// <summary>
        /// Shares a template with a group
        /// </summary>
        /// <remarks>
        /// Shares a template with the specified members group.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>2ApiResponse of GroupInformation</returns>
        ApiResponse<GroupInformation> UpdateGroupShareWithHttpInfo (string accountId, string templateId, string templatePart, GroupInformation groupInformation);

        /// <summary>
        /// Shares a template with a group
        /// </summary>
        /// <remarks>
        /// Shares a template with the specified members group.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>3Task of GroupInformation</returns>
        System.Threading.Tasks.Task<GroupInformation> UpdateGroupShareAsync (string accountId, string templateId, string templatePart, GroupInformation groupInformation);

        /// <summary>
        /// Shares a template with a group
        /// </summary>
        /// <remarks>
        /// Shares a template with the specified members group.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (GroupInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupInformation>> UpdateGroupShareAsyncWithHttpInfo (string accountId, string templateId, string templatePart, GroupInformation groupInformation);
        
        /// <summary>
        /// Removes a member group&#39;s sharing permissions for a template.
        /// </summary>
        /// <remarks>
        /// Removes a member group&#39;s sharing permissions for a specified template.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>1GroupInformation</returns>
        GroupInformation DeleteGroupShare (string accountId, string templateId, string templatePart, GroupInformation groupInformation);
 
		/// <summary>
        /// Removes a member group&#39;s sharing permissions for a template.
        /// </summary>
        /// <remarks>
        /// Removes a member group&#39;s sharing permissions for a specified template.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>2ApiResponse of GroupInformation</returns>
        ApiResponse<GroupInformation> DeleteGroupShareWithHttpInfo (string accountId, string templateId, string templatePart, GroupInformation groupInformation);

        /// <summary>
        /// Removes a member group&#39;s sharing permissions for a template.
        /// </summary>
        /// <remarks>
        /// Removes a member group&#39;s sharing permissions for a specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>3Task of GroupInformation</returns>
        System.Threading.Tasks.Task<GroupInformation> DeleteGroupShareAsync (string accountId, string templateId, string templatePart, GroupInformation groupInformation);

        /// <summary>
        /// Removes a member group&#39;s sharing permissions for a template.
        /// </summary>
        /// <remarks>
        /// Removes a member group&#39;s sharing permissions for a specified template.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (GroupInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<GroupInformation>> DeleteGroupShareAsyncWithHttpInfo (string accountId, string templateId, string templatePart, GroupInformation groupInformation);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TemplatesApi : ITemplatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TemplatesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TemplatesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the definition of a template. Retrieves the list of templates for the specified account. The request can be limited to a specific folder.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>5EnvelopeTemplateResults</returns>
        public EnvelopeTemplateResults ListTemplates (string accountId)
        {
             ApiResponse<EnvelopeTemplateResults> response = ListTemplatesWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Gets the definition of a template. Retrieves the list of templates for the specified account. The request can be limited to a specific folder.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>6ApiResponse of EnvelopeTemplateResults</returns>
        public ApiResponse< EnvelopeTemplateResults > ListTemplatesWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTemplates");
            
    
            var path_ = "/v2/accounts/{accountId}/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListTemplates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopeTemplateResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeTemplateResults) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeTemplateResults)));
            
        }
    
        /// <summary>
        /// Gets the definition of a template. Retrieves the list of templates for the specified account. The request can be limited to a specific folder.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>7Task of EnvelopeTemplateResults</returns>
        public async System.Threading.Tasks.Task<EnvelopeTemplateResults> ListTemplatesAsync (string accountId)
        {
             ApiResponse<EnvelopeTemplateResults> response = await ListTemplatesAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Gets the definition of a template. Retrieves the list of templates for the specified account. The request can be limited to a specific folder.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>8Task of ApiResponse (EnvelopeTemplateResults)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopeTemplateResults>> ListTemplatesAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTemplates");
            
    
            var path_ = "/v2/accounts/{accountId}/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListTemplates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListTemplates: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopeTemplateResults>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeTemplateResults) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeTemplateResults)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Creates an envelope from a template. Creates a template definition using a multipart request.\n\n###Template Email Subject Merge Fields\n\nCall this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\nTo add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_UserName]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\nTo add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_Email]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\n\nIn both cases the &lt;roleName&gt; is the recipient&#39;s contents of the `roleName` property in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>5TemplateSummary</returns>
        public TemplateSummary CreateTemplate (string accountId, EnvelopeTemplate envelopeTemplate)
        {
             ApiResponse<TemplateSummary> response = CreateTemplateWithHttpInfo(accountId, envelopeTemplate);
             return response.Data;
        }

        /// <summary>
        /// Creates an envelope from a template. Creates a template definition using a multipart request.\n\n###Template Email Subject Merge Fields\n\nCall this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\nTo add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_UserName]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\nTo add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_Email]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\n\nIn both cases the &lt;roleName&gt; is the recipient&#39;s contents of the `roleName` property in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>6ApiResponse of TemplateSummary</returns>
        public ApiResponse< TemplateSummary > CreateTemplateWithHttpInfo (string accountId, EnvelopeTemplate envelopeTemplate)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateTemplate");
            
    
            var path_ = "/v2/accounts/{accountId}/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeTemplate); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateSummary) Configuration.ApiClient.Deserialize(response, typeof(TemplateSummary)));
            
        }
    
        /// <summary>
        /// Creates an envelope from a template. Creates a template definition using a multipart request.\n\n###Template Email Subject Merge Fields\n\nCall this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\nTo add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_UserName]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\nTo add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_Email]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\n\nIn both cases the &lt;roleName&gt; is the recipient&#39;s contents of the `roleName` property in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>7Task of TemplateSummary</returns>
        public async System.Threading.Tasks.Task<TemplateSummary> CreateTemplateAsync (string accountId, EnvelopeTemplate envelopeTemplate)
        {
             ApiResponse<TemplateSummary> response = await CreateTemplateAsyncWithHttpInfo(accountId, envelopeTemplate);
             return response.Data;

        }

        /// <summary>
        /// Creates an envelope from a template. Creates a template definition using a multipart request.\n\n###Template Email Subject Merge Fields\n\nCall this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\nTo add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_UserName]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\nTo add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:\n\n[[&lt;roleName&gt;_Email]]\n\nExample:\n\n`\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\n\nIn both cases the &lt;roleName&gt; is the recipient&#39;s contents of the `roleName` property in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>8Task of ApiResponse (TemplateSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateSummary>> CreateTemplateAsyncWithHttpInfo (string accountId, EnvelopeTemplate envelopeTemplate)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateTemplate");
            
    
            var path_ = "/v2/accounts/{accountId}/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeTemplate); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateSummary) Configuration.ApiClient.Deserialize(response, typeof(TemplateSummary)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets a list of templates for a specified account. Retrieves the definition of the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>5EnvelopeTemplate</returns>
        public EnvelopeTemplate Get (string accountId, string templateId)
        {
             ApiResponse<EnvelopeTemplate> response = GetWithHttpInfo(accountId, templateId);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of templates for a specified account. Retrieves the definition of the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>6ApiResponse of EnvelopeTemplate</returns>
        public ApiResponse< EnvelopeTemplate > GetWithHttpInfo (string accountId, string templateId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Get");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling Get");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopeTemplate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeTemplate) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeTemplate)));
            
        }
    
        /// <summary>
        /// Gets a list of templates for a specified account. Retrieves the definition of the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>7Task of EnvelopeTemplate</returns>
        public async System.Threading.Tasks.Task<EnvelopeTemplate> GetAsync (string accountId, string templateId)
        {
             ApiResponse<EnvelopeTemplate> response = await GetAsyncWithHttpInfo(accountId, templateId);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of templates for a specified account. Retrieves the definition of the specified template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>8Task of ApiResponse (EnvelopeTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopeTemplate>> GetAsyncWithHttpInfo (string accountId, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Get");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling Get");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopeTemplate>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeTemplate) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeTemplate)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates an existing template. Updates an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>5TemplateUpdateSummary</returns>
        public TemplateUpdateSummary Update (string accountId, string templateId, EnvelopeTemplate envelopeTemplate)
        {
             ApiResponse<TemplateUpdateSummary> response = UpdateWithHttpInfo(accountId, templateId, envelopeTemplate);
             return response.Data;
        }

        /// <summary>
        /// Updates an existing template. Updates an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>6ApiResponse of TemplateUpdateSummary</returns>
        public ApiResponse< TemplateUpdateSummary > UpdateWithHttpInfo (string accountId, string templateId, EnvelopeTemplate envelopeTemplate)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Update");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling Update");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeTemplate); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateUpdateSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateUpdateSummary) Configuration.ApiClient.Deserialize(response, typeof(TemplateUpdateSummary)));
            
        }
    
        /// <summary>
        /// Updates an existing template. Updates an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>7Task of TemplateUpdateSummary</returns>
        public async System.Threading.Tasks.Task<TemplateUpdateSummary> UpdateAsync (string accountId, string templateId, EnvelopeTemplate envelopeTemplate)
        {
             ApiResponse<TemplateUpdateSummary> response = await UpdateAsyncWithHttpInfo(accountId, templateId, envelopeTemplate);
             return response.Data;

        }

        /// <summary>
        /// Updates an existing template. Updates an existing template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeTemplate">TBD Description</param>
		/// <returns>8Task of ApiResponse (TemplateUpdateSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateUpdateSummary>> UpdateAsyncWithHttpInfo (string accountId, string templateId, EnvelopeTemplate envelopeTemplate)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Update");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling Update");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeTemplate); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateUpdateSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateUpdateSummary) Configuration.ApiClient.Deserialize(response, typeof(TemplateUpdateSummary)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the custom document fields from a template. Retrieves the custom document field information from an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>5CustomFields</returns>
        public CustomFields ListCustomFields (string accountId, string templateId)
        {
             ApiResponse<CustomFields> response = ListCustomFieldsWithHttpInfo(accountId, templateId);
             return response.Data;
        }

        /// <summary>
        /// Gets the custom document fields from a template. Retrieves the custom document field information from an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>6ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > ListCustomFieldsWithHttpInfo (string accountId, string templateId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListCustomFields");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/custom_fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
    
        /// <summary>
        /// Gets the custom document fields from a template. Retrieves the custom document field information from an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>7Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> ListCustomFieldsAsync (string accountId, string templateId)
        {
             ApiResponse<CustomFields> response = await ListCustomFieldsAsyncWithHttpInfo(accountId, templateId);
             return response.Data;

        }

        /// <summary>
        /// Gets the custom document fields from a template. Retrieves the custom document field information from an existing template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>8Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> ListCustomFieldsAsyncWithHttpInfo (string accountId, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListCustomFields");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/custom_fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates envelope custom fields in a template. Updates the custom fields in a template.\n\nEach custom field used in a template must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>5CustomFields</returns>
        public CustomFields UpdateCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
             ApiResponse<CustomFields> response = UpdateCustomFieldsWithHttpInfo(accountId, templateId, templateCustomFields);
             return response.Data;
        }

        /// <summary>
        /// Updates envelope custom fields in a template. Updates the custom fields in a template.\n\nEach custom field used in a template must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>6ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > UpdateCustomFieldsWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateCustomFields");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/custom_fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateCustomFields); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateCustomFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
    
        /// <summary>
        /// Updates envelope custom fields in a template. Updates the custom fields in a template.\n\nEach custom field used in a template must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>7Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> UpdateCustomFieldsAsync (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
             ApiResponse<CustomFields> response = await UpdateCustomFieldsAsyncWithHttpInfo(accountId, templateId, templateCustomFields);
             return response.Data;

        }

        /// <summary>
        /// Updates envelope custom fields in a template. Updates the custom fields in a template.\n\nEach custom field used in a template must have a unique name.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>8Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> UpdateCustomFieldsAsyncWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateCustomFields");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/custom_fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateCustomFields); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateCustomFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Creates custom document fields in an existing template document. Creates custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>5CustomFields</returns>
        public CustomFields CreateCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
             ApiResponse<CustomFields> response = CreateCustomFieldsWithHttpInfo(accountId, templateId, templateCustomFields);
             return response.Data;
        }

        /// <summary>
        /// Creates custom document fields in an existing template document. Creates custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>6ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > CreateCustomFieldsWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateCustomFields");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/custom_fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateCustomFields); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateCustomFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
    
        /// <summary>
        /// Creates custom document fields in an existing template document. Creates custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>7Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> CreateCustomFieldsAsync (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
             ApiResponse<CustomFields> response = await CreateCustomFieldsAsyncWithHttpInfo(accountId, templateId, templateCustomFields);
             return response.Data;

        }

        /// <summary>
        /// Creates custom document fields in an existing template document. Creates custom document fields in an existing template document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>8Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> CreateCustomFieldsAsyncWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateCustomFields");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/custom_fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateCustomFields); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateCustomFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes envelope custom fields in a template. Deletes envelope custom fields in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>5CustomFields</returns>
        public CustomFields DeleteCustomFields (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
             ApiResponse<CustomFields> response = DeleteCustomFieldsWithHttpInfo(accountId, templateId, templateCustomFields);
             return response.Data;
        }

        /// <summary>
        /// Deletes envelope custom fields in a template. Deletes envelope custom fields in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>6ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > DeleteCustomFieldsWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteCustomFields");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/custom_fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateCustomFields); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCustomFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
    
        /// <summary>
        /// Deletes envelope custom fields in a template. Deletes envelope custom fields in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>7Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> DeleteCustomFieldsAsync (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
             ApiResponse<CustomFields> response = await DeleteCustomFieldsAsyncWithHttpInfo(accountId, templateId, templateCustomFields);
             return response.Data;

        }

        /// <summary>
        /// Deletes envelope custom fields in a template. Deletes envelope custom fields in a template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateCustomFields">TBD Description</param>
		/// <returns>8Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> DeleteCustomFieldsAsyncWithHttpInfo (string accountId, string templateId, TemplateCustomFields templateCustomFields)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteCustomFields");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/custom_fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateCustomFields); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCustomFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets a list of documents associated with a template. Retrieves a list of documents associated with the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>5TemplateDocumentsResult</returns>
        public TemplateDocumentsResult ListDocuments (string accountId, string templateId)
        {
             ApiResponse<TemplateDocumentsResult> response = ListDocumentsWithHttpInfo(accountId, templateId);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of documents associated with a template. Retrieves a list of documents associated with the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>6ApiResponse of TemplateDocumentsResult</returns>
        public ApiResponse< TemplateDocumentsResult > ListDocumentsWithHttpInfo (string accountId, string templateId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListDocuments");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(TemplateDocumentsResult)));
            
        }
    
        /// <summary>
        /// Gets a list of documents associated with a template. Retrieves a list of documents associated with the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>7Task of TemplateDocumentsResult</returns>
        public async System.Threading.Tasks.Task<TemplateDocumentsResult> ListDocumentsAsync (string accountId, string templateId)
        {
             ApiResponse<TemplateDocumentsResult> response = await ListDocumentsAsyncWithHttpInfo(accountId, templateId);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of documents associated with a template. Retrieves a list of documents associated with the specified template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>8Task of ApiResponse (TemplateDocumentsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateDocumentsResult>> ListDocumentsAsyncWithHttpInfo (string accountId, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListDocuments");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(TemplateDocumentsResult)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Adds documents to a template document. Adds one or more documents to an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>5TemplateDocumentsResult</returns>
        public TemplateDocumentsResult UpdateDocuments (string accountId, string templateId, EnvelopeDefinition envelopeDefinition)
        {
             ApiResponse<TemplateDocumentsResult> response = UpdateDocumentsWithHttpInfo(accountId, templateId, envelopeDefinition);
             return response.Data;
        }

        /// <summary>
        /// Adds documents to a template document. Adds one or more documents to an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>6ApiResponse of TemplateDocumentsResult</returns>
        public ApiResponse< TemplateDocumentsResult > UpdateDocumentsWithHttpInfo (string accountId, string templateId, EnvelopeDefinition envelopeDefinition)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateDocuments");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(TemplateDocumentsResult)));
            
        }
    
        /// <summary>
        /// Adds documents to a template document. Adds one or more documents to an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>7Task of TemplateDocumentsResult</returns>
        public async System.Threading.Tasks.Task<TemplateDocumentsResult> UpdateDocumentsAsync (string accountId, string templateId, EnvelopeDefinition envelopeDefinition)
        {
             ApiResponse<TemplateDocumentsResult> response = await UpdateDocumentsAsyncWithHttpInfo(accountId, templateId, envelopeDefinition);
             return response.Data;

        }

        /// <summary>
        /// Adds documents to a template document. Adds one or more documents to an existing template document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>8Task of ApiResponse (TemplateDocumentsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateDocumentsResult>> UpdateDocumentsAsyncWithHttpInfo (string accountId, string templateId, EnvelopeDefinition envelopeDefinition)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateDocuments");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(TemplateDocumentsResult)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes documents from a template. Deletes one or more documents from an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>5TemplateDocumentsResult</returns>
        public TemplateDocumentsResult DeleteDocuments (string accountId, string templateId, EnvelopeDefinition envelopeDefinition)
        {
             ApiResponse<TemplateDocumentsResult> response = DeleteDocumentsWithHttpInfo(accountId, templateId, envelopeDefinition);
             return response.Data;
        }

        /// <summary>
        /// Deletes documents from a template. Deletes one or more documents from an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>6ApiResponse of TemplateDocumentsResult</returns>
        public ApiResponse< TemplateDocumentsResult > DeleteDocumentsWithHttpInfo (string accountId, string templateId, EnvelopeDefinition envelopeDefinition)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocuments");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(TemplateDocumentsResult)));
            
        }
    
        /// <summary>
        /// Deletes documents from a template. Deletes one or more documents from an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>7Task of TemplateDocumentsResult</returns>
        public async System.Threading.Tasks.Task<TemplateDocumentsResult> DeleteDocumentsAsync (string accountId, string templateId, EnvelopeDefinition envelopeDefinition)
        {
             ApiResponse<TemplateDocumentsResult> response = await DeleteDocumentsAsyncWithHttpInfo(accountId, templateId, envelopeDefinition);
             return response.Data;

        }

        /// <summary>
        /// Deletes documents from a template. Deletes one or more documents from an existing template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>8Task of ApiResponse (TemplateDocumentsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateDocumentsResult>> DeleteDocumentsAsyncWithHttpInfo (string accountId, string templateId, EnvelopeDefinition envelopeDefinition)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocuments");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(TemplateDocumentsResult)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets PDF documents from a template. Retrieves one or more PDF documents from the specified template.\n\nYou can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>5Stream</returns>
        public Stream GetDocument (string accountId, string templateId, string documentId)
        {
             ApiResponse<Stream> response = GetDocumentWithHttpInfo(accountId, templateId, documentId);
             return response.Data;
        }

        /// <summary>
        /// Gets PDF documents from a template. Retrieves one or more PDF documents from the specified template.\n\nYou can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>6ApiResponse of Stream</returns>
        public ApiResponse< Stream > GetDocumentWithHttpInfo (string accountId, string templateId, string documentId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetDocument");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling GetDocument");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/pdf"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
    
        /// <summary>
        /// Gets PDF documents from a template. Retrieves one or more PDF documents from the specified template.\n\nYou can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>7Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> GetDocumentAsync (string accountId, string templateId, string documentId)
        {
             ApiResponse<Stream> response = await GetDocumentAsyncWithHttpInfo(accountId, templateId, documentId);
             return response.Data;

        }

        /// <summary>
        /// Gets PDF documents from a template. Retrieves one or more PDF documents from the specified template.\n\nYou can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>8Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> GetDocumentAsyncWithHttpInfo (string accountId, string templateId, string documentId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetDocument");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling GetDocument");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/pdf"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetDocument: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the custom document fields for a an existing template document. Retrieves the custom document fields for an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>5DocumentFieldsInformation</returns>
        public DocumentFieldsInformation ListDocumentFields (string accountId, string templateId, string documentId)
        {
             ApiResponse<DocumentFieldsInformation> response = ListDocumentFieldsWithHttpInfo(accountId, templateId, documentId);
             return response.Data;
        }

        /// <summary>
        /// Gets the custom document fields for a an existing template document. Retrieves the custom document fields for an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>6ApiResponse of DocumentFieldsInformation</returns>
        public ApiResponse< DocumentFieldsInformation > ListDocumentFieldsWithHttpInfo (string accountId, string templateId, string documentId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListDocumentFields");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListDocumentFields");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ListDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListDocumentFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListDocumentFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DocumentFieldsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentFieldsInformation) Configuration.ApiClient.Deserialize(response, typeof(DocumentFieldsInformation)));
            
        }
    
        /// <summary>
        /// Gets the custom document fields for a an existing template document. Retrieves the custom document fields for an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>7Task of DocumentFieldsInformation</returns>
        public async System.Threading.Tasks.Task<DocumentFieldsInformation> ListDocumentFieldsAsync (string accountId, string templateId, string documentId)
        {
             ApiResponse<DocumentFieldsInformation> response = await ListDocumentFieldsAsyncWithHttpInfo(accountId, templateId, documentId);
             return response.Data;

        }

        /// <summary>
        /// Gets the custom document fields for a an existing template document. Retrieves the custom document fields for an existing template document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>8Task of ApiResponse (DocumentFieldsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> ListDocumentFieldsAsyncWithHttpInfo (string accountId, string templateId, string documentId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListDocumentFields");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListDocumentFields");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ListDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListDocumentFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListDocumentFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentFieldsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentFieldsInformation) Configuration.ApiClient.Deserialize(response, typeof(DocumentFieldsInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates existing custom document fields in an existing template document. Updates existing custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>5DocumentFieldsInformation</returns>
        public DocumentFieldsInformation UpdateDocumentFields (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = UpdateDocumentFieldsWithHttpInfo(accountId, templateId, documentId, documentFieldsInformation);
             return response.Data;
        }

        /// <summary>
        /// Updates existing custom document fields in an existing template document. Updates existing custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>6ApiResponse of DocumentFieldsInformation</returns>
        public ApiResponse< DocumentFieldsInformation > UpdateDocumentFieldsWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateDocumentFields");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateDocumentFields");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling UpdateDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentFieldsInformation); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateDocumentFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDocumentFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DocumentFieldsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentFieldsInformation) Configuration.ApiClient.Deserialize(response, typeof(DocumentFieldsInformation)));
            
        }
    
        /// <summary>
        /// Updates existing custom document fields in an existing template document. Updates existing custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>7Task of DocumentFieldsInformation</returns>
        public async System.Threading.Tasks.Task<DocumentFieldsInformation> UpdateDocumentFieldsAsync (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = await UpdateDocumentFieldsAsyncWithHttpInfo(accountId, templateId, documentId, documentFieldsInformation);
             return response.Data;

        }

        /// <summary>
        /// Updates existing custom document fields in an existing template document. Updates existing custom document fields in an existing template document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (DocumentFieldsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> UpdateDocumentFieldsAsyncWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateDocumentFields");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateDocumentFields");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling UpdateDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentFieldsInformation); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateDocumentFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDocumentFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentFieldsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentFieldsInformation) Configuration.ApiClient.Deserialize(response, typeof(DocumentFieldsInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Creates custom document fields in an existing template document. Creates custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>5DocumentFieldsInformation</returns>
        public DocumentFieldsInformation CreateDocumentFields (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = CreateDocumentFieldsWithHttpInfo(accountId, templateId, documentId, documentFieldsInformation);
             return response.Data;
        }

        /// <summary>
        /// Creates custom document fields in an existing template document. Creates custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>6ApiResponse of DocumentFieldsInformation</returns>
        public ApiResponse< DocumentFieldsInformation > CreateDocumentFieldsWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateDocumentFields");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateDocumentFields");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling CreateDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentFieldsInformation); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateDocumentFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDocumentFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DocumentFieldsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentFieldsInformation) Configuration.ApiClient.Deserialize(response, typeof(DocumentFieldsInformation)));
            
        }
    
        /// <summary>
        /// Creates custom document fields in an existing template document. Creates custom document fields in an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>7Task of DocumentFieldsInformation</returns>
        public async System.Threading.Tasks.Task<DocumentFieldsInformation> CreateDocumentFieldsAsync (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = await CreateDocumentFieldsAsyncWithHttpInfo(accountId, templateId, documentId, documentFieldsInformation);
             return response.Data;

        }

        /// <summary>
        /// Creates custom document fields in an existing template document. Creates custom document fields in an existing template document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (DocumentFieldsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> CreateDocumentFieldsAsyncWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateDocumentFields");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateDocumentFields");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling CreateDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentFieldsInformation); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateDocumentFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDocumentFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentFieldsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentFieldsInformation) Configuration.ApiClient.Deserialize(response, typeof(DocumentFieldsInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes custom document fields from an existing template document. Deletes custom document fields from an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>5DocumentFieldsInformation</returns>
        public DocumentFieldsInformation DeleteDocumentFields (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = DeleteDocumentFieldsWithHttpInfo(accountId, templateId, documentId, documentFieldsInformation);
             return response.Data;
        }

        /// <summary>
        /// Deletes custom document fields from an existing template document. Deletes custom document fields from an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>6ApiResponse of DocumentFieldsInformation</returns>
        public ApiResponse< DocumentFieldsInformation > DeleteDocumentFieldsWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocumentFields");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteDocumentFields");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentFieldsInformation); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocumentFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocumentFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DocumentFieldsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentFieldsInformation) Configuration.ApiClient.Deserialize(response, typeof(DocumentFieldsInformation)));
            
        }
    
        /// <summary>
        /// Deletes custom document fields from an existing template document. Deletes custom document fields from an existing template document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>7Task of DocumentFieldsInformation</returns>
        public async System.Threading.Tasks.Task<DocumentFieldsInformation> DeleteDocumentFieldsAsync (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = await DeleteDocumentFieldsAsyncWithHttpInfo(accountId, templateId, documentId, documentFieldsInformation);
             return response.Data;

        }

        /// <summary>
        /// Deletes custom document fields from an existing template document. Deletes custom document fields from an existing template document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (DocumentFieldsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> DeleteDocumentFieldsAsyncWithHttpInfo (string accountId, string templateId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocumentFields");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteDocumentFields");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentFieldsInformation); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocumentFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocumentFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentFieldsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentFieldsInformation) Configuration.ApiClient.Deserialize(response, typeof(DocumentFieldsInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes a page from a document in an template. Deletes a page from a document in a template based on the page number.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param> <param name="pageRequest">TBD Description</param>
		/// <returns>5</returns>
        public void DeleteDocumentPage (string accountId, string templateId, string documentId, string pageNumber, PageRequest pageRequest)
        {
             DeleteDocumentPageWithHttpInfo(accountId, templateId, documentId, pageNumber, pageRequest);
        }

        /// <summary>
        /// Deletes a page from a document in an template. Deletes a page from a document in a template based on the page number.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param> <param name="pageRequest">TBD Description</param>
		/// <returns>6ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteDocumentPageWithHttpInfo (string accountId, string templateId, string documentId, string pageNumber, PageRequest pageRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocumentPage");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteDocumentPage");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentPage");
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling DeleteDocumentPage");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageNumber != null) pathParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(pageRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocumentPage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocumentPage: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Deletes a page from a document in an template. Deletes a page from a document in a template based on the page number.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param> <param name="pageRequest">TBD Description</param>
		/// <returns>7Task of void</returns>
        public async System.Threading.Tasks.Task DeleteDocumentPageAsync (string accountId, string templateId, string documentId, string pageNumber, PageRequest pageRequest)
        {
             await DeleteDocumentPageAsyncWithHttpInfo(accountId, templateId, documentId, pageNumber, pageRequest);

        }

        /// <summary>
        /// Deletes a page from a document in an template. Deletes a page from a document in a template based on the page number.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param> <param name="pageRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentPageAsyncWithHttpInfo (string accountId, string templateId, string documentId, string pageNumber, PageRequest pageRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocumentPage");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteDocumentPage");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentPage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling DeleteDocumentPage");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageNumber != null) pathParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(pageRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocumentPage: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocumentPage: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets template lock information. Retrieves general information about the template lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>5LockInformation</returns>
        public LockInformation GetLock (string accountId, string templateId)
        {
             ApiResponse<LockInformation> response = GetLockWithHttpInfo(accountId, templateId);
             return response.Data;
        }

        /// <summary>
        /// Gets template lock information. Retrieves general information about the template lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>6ApiResponse of LockInformation</returns>
        public ApiResponse< LockInformation > GetLockWithHttpInfo (string accountId, string templateId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetLock");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling GetLock");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/lock";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetLock: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLock: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LockInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LockInformation) Configuration.ApiClient.Deserialize(response, typeof(LockInformation)));
            
        }
    
        /// <summary>
        /// Gets template lock information. Retrieves general information about the template lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>7Task of LockInformation</returns>
        public async System.Threading.Tasks.Task<LockInformation> GetLockAsync (string accountId, string templateId)
        {
             ApiResponse<LockInformation> response = await GetLockAsyncWithHttpInfo(accountId, templateId);
             return response.Data;

        }

        /// <summary>
        /// Gets template lock information. Retrieves general information about the template lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>8Task of ApiResponse (LockInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LockInformation>> GetLockAsyncWithHttpInfo (string accountId, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetLock");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling GetLock");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/lock";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetLock: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetLock: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LockInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LockInformation) Configuration.ApiClient.Deserialize(response, typeof(LockInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets template notification information. Retrieves the envelope notification, reminders and expirations, information for an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>5Notification</returns>
        public Notification GetNotificationSettings (string accountId, string templateId)
        {
             ApiResponse<Notification> response = GetNotificationSettingsWithHttpInfo(accountId, templateId);
             return response.Data;
        }

        /// <summary>
        /// Gets template notification information. Retrieves the envelope notification, reminders and expirations, information for an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>6ApiResponse of Notification</returns>
        public ApiResponse< Notification > GetNotificationSettingsWithHttpInfo (string accountId, string templateId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetNotificationSettings");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling GetNotificationSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/notification";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetNotificationSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetNotificationSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Notification>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Notification) Configuration.ApiClient.Deserialize(response, typeof(Notification)));
            
        }
    
        /// <summary>
        /// Gets template notification information. Retrieves the envelope notification, reminders and expirations, information for an existing template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>7Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> GetNotificationSettingsAsync (string accountId, string templateId)
        {
             ApiResponse<Notification> response = await GetNotificationSettingsAsyncWithHttpInfo(accountId, templateId);
             return response.Data;

        }

        /// <summary>
        /// Gets template notification information. Retrieves the envelope notification, reminders and expirations, information for an existing template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>8Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> GetNotificationSettingsAsyncWithHttpInfo (string accountId, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetNotificationSettings");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling GetNotificationSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/notification";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetNotificationSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetNotificationSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Notification>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Notification) Configuration.ApiClient.Deserialize(response, typeof(Notification)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates the notification  structure for an existing template. Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateNotificationRequest">TBD Description</param>
		/// <returns>5Notification</returns>
        public Notification UpdateNotificationSettings (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest)
        {
             ApiResponse<Notification> response = UpdateNotificationSettingsWithHttpInfo(accountId, templateId, templateNotificationRequest);
             return response.Data;
        }

        /// <summary>
        /// Updates the notification  structure for an existing template. Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateNotificationRequest">TBD Description</param>
		/// <returns>6ApiResponse of Notification</returns>
        public ApiResponse< Notification > UpdateNotificationSettingsWithHttpInfo (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateNotificationSettings");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateNotificationSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/notification";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateNotificationRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateNotificationSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateNotificationSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Notification>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Notification) Configuration.ApiClient.Deserialize(response, typeof(Notification)));
            
        }
    
        /// <summary>
        /// Updates the notification  structure for an existing template. Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateNotificationRequest">TBD Description</param>
		/// <returns>7Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> UpdateNotificationSettingsAsync (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest)
        {
             ApiResponse<Notification> response = await UpdateNotificationSettingsAsyncWithHttpInfo(accountId, templateId, templateNotificationRequest);
             return response.Data;

        }

        /// <summary>
        /// Updates the notification  structure for an existing template. Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateNotificationRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> UpdateNotificationSettingsAsyncWithHttpInfo (string accountId, string templateId, TemplateNotificationRequest templateNotificationRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateNotificationSettings");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateNotificationSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/notification";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateNotificationRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateNotificationSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateNotificationSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Notification>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Notification) Configuration.ApiClient.Deserialize(response, typeof(Notification)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets recipient information from a template. Retrieves the information for all recipients in the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>5Recipients</returns>
        public Recipients ListRecipients (string accountId, string templateId)
        {
             ApiResponse<Recipients> response = ListRecipientsWithHttpInfo(accountId, templateId);
             return response.Data;
        }

        /// <summary>
        /// Gets recipient information from a template. Retrieves the information for all recipients in the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>6ApiResponse of Recipients</returns>
        public ApiResponse< Recipients > ListRecipientsWithHttpInfo (string accountId, string templateId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListRecipients");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListRecipients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListRecipients: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
    
        /// <summary>
        /// Gets recipient information from a template. Retrieves the information for all recipients in the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>7Task of Recipients</returns>
        public async System.Threading.Tasks.Task<Recipients> ListRecipientsAsync (string accountId, string templateId)
        {
             ApiResponse<Recipients> response = await ListRecipientsAsyncWithHttpInfo(accountId, templateId);
             return response.Data;

        }

        /// <summary>
        /// Gets recipient information from a template. Retrieves the information for all recipients in the specified template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>8Task of ApiResponse (Recipients)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipients>> ListRecipientsAsyncWithHttpInfo (string accountId, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListRecipients");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListRecipients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListRecipients: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates recipients in a template. Updates recipients in a template. \n\nYou can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>5RecipientsUpdateSummary</returns>
        public RecipientsUpdateSummary UpdateRecipients (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
             ApiResponse<RecipientsUpdateSummary> response = UpdateRecipientsWithHttpInfo(accountId, templateId, templateRecipients);
             return response.Data;
        }

        /// <summary>
        /// Updates recipients in a template. Updates recipients in a template. \n\nYou can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>6ApiResponse of RecipientsUpdateSummary</returns>
        public ApiResponse< RecipientsUpdateSummary > UpdateRecipientsWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateRecipients");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateRecipients); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateRecipients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRecipients: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<RecipientsUpdateSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecipientsUpdateSummary) Configuration.ApiClient.Deserialize(response, typeof(RecipientsUpdateSummary)));
            
        }
    
        /// <summary>
        /// Updates recipients in a template. Updates recipients in a template. \n\nYou can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>7Task of RecipientsUpdateSummary</returns>
        public async System.Threading.Tasks.Task<RecipientsUpdateSummary> UpdateRecipientsAsync (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
             ApiResponse<RecipientsUpdateSummary> response = await UpdateRecipientsAsyncWithHttpInfo(accountId, templateId, templateRecipients);
             return response.Data;

        }

        /// <summary>
        /// Updates recipients in a template. Updates recipients in a template. \n\nYou can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>8Task of ApiResponse (RecipientsUpdateSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecipientsUpdateSummary>> UpdateRecipientsAsyncWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateRecipients");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateRecipients); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateRecipients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRecipients: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<RecipientsUpdateSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecipientsUpdateSummary) Configuration.ApiClient.Deserialize(response, typeof(RecipientsUpdateSummary)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Adds tabs for a recipient. Adds one or more recipients to a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>5Recipients</returns>
        public Recipients CreateRecipients (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
             ApiResponse<Recipients> response = CreateRecipientsWithHttpInfo(accountId, templateId, templateRecipients);
             return response.Data;
        }

        /// <summary>
        /// Adds tabs for a recipient. Adds one or more recipients to a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>6ApiResponse of Recipients</returns>
        public ApiResponse< Recipients > CreateRecipientsWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateRecipients");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateRecipients); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateRecipients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRecipients: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
    
        /// <summary>
        /// Adds tabs for a recipient. Adds one or more recipients to a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>7Task of Recipients</returns>
        public async System.Threading.Tasks.Task<Recipients> CreateRecipientsAsync (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
             ApiResponse<Recipients> response = await CreateRecipientsAsyncWithHttpInfo(accountId, templateId, templateRecipients);
             return response.Data;

        }

        /// <summary>
        /// Adds tabs for a recipient. Adds one or more recipients to a template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>8Task of ApiResponse (Recipients)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipients>> CreateRecipientsAsyncWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateRecipients");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateRecipients); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateRecipients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRecipients: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes recipients from a template. Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>5Recipients</returns>
        public Recipients DeleteRecipients (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
             ApiResponse<Recipients> response = DeleteRecipientsWithHttpInfo(accountId, templateId, templateRecipients);
             return response.Data;
        }

        /// <summary>
        /// Deletes recipients from a template. Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>6ApiResponse of Recipients</returns>
        public ApiResponse< Recipients > DeleteRecipientsWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteRecipients");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateRecipients); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRecipients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRecipients: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
    
        /// <summary>
        /// Deletes recipients from a template. Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>7Task of Recipients</returns>
        public async System.Threading.Tasks.Task<Recipients> DeleteRecipientsAsync (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
             ApiResponse<Recipients> response = await DeleteRecipientsAsyncWithHttpInfo(accountId, templateId, templateRecipients);
             return response.Data;

        }

        /// <summary>
        /// Deletes recipients from a template. Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>8Task of ApiResponse (Recipients)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipients>> DeleteRecipientsAsyncWithHttpInfo (string accountId, string templateId, TemplateRecipients templateRecipients)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteRecipients");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateRecipients); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRecipients: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRecipients: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes the specified recipient file from a template. Deletes the specified recipient file from the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>5Recipients</returns>
        public Recipients DeleteRecipient (string accountId, string templateId, string recipientId, TemplateRecipients templateRecipients)
        {
             ApiResponse<Recipients> response = DeleteRecipientWithHttpInfo(accountId, templateId, recipientId, templateRecipients);
             return response.Data;
        }

        /// <summary>
        /// Deletes the specified recipient file from a template. Deletes the specified recipient file from the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>6ApiResponse of Recipients</returns>
        public ApiResponse< Recipients > DeleteRecipientWithHttpInfo (string accountId, string templateId, string recipientId, TemplateRecipients templateRecipients)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteRecipient");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteRecipient");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling DeleteRecipient");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateRecipients); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRecipient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRecipient: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
    
        /// <summary>
        /// Deletes the specified recipient file from a template. Deletes the specified recipient file from the specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>7Task of Recipients</returns>
        public async System.Threading.Tasks.Task<Recipients> DeleteRecipientAsync (string accountId, string templateId, string recipientId, TemplateRecipients templateRecipients)
        {
             ApiResponse<Recipients> response = await DeleteRecipientAsyncWithHttpInfo(accountId, templateId, recipientId, templateRecipients);
             return response.Data;

        }

        /// <summary>
        /// Deletes the specified recipient file from a template. Deletes the specified recipient file from the specified template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateRecipients">TBD Description</param>
		/// <returns>8Task of ApiResponse (Recipients)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipients>> DeleteRecipientAsyncWithHttpInfo (string accountId, string templateId, string recipientId, TemplateRecipients templateRecipients)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteRecipient");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteRecipient");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling DeleteRecipient");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateRecipients); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRecipient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRecipient: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template. Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>5Tabs</returns>
        public Tabs ListTabs (string accountId, string templateId, string recipientId, Tabs tabs)
        {
             ApiResponse<Tabs> response = ListTabsWithHttpInfo(accountId, templateId, recipientId, tabs);
             return response.Data;
        }

        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template. Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>6ApiResponse of Tabs</returns>
        public ApiResponse< Tabs > ListTabsWithHttpInfo (string accountId, string templateId, string recipientId, Tabs tabs)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTabs");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListTabs");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling ListTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabs); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListTabs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListTabs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Tabs>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tabs) Configuration.ApiClient.Deserialize(response, typeof(Tabs)));
            
        }
    
        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template. Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>7Task of Tabs</returns>
        public async System.Threading.Tasks.Task<Tabs> ListTabsAsync (string accountId, string templateId, string recipientId, Tabs tabs)
        {
             ApiResponse<Tabs> response = await ListTabsAsyncWithHttpInfo(accountId, templateId, recipientId, tabs);
             return response.Data;

        }

        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in a template. Gets the tabs information for a signer or sign-in-person recipient in a template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>8Task of ApiResponse (Tabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tabs>> ListTabsAsyncWithHttpInfo (string accountId, string templateId, string recipientId, Tabs tabs)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTabs");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling ListTabs");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling ListTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabs); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListTabs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListTabs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Tabs>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tabs) Configuration.ApiClient.Deserialize(response, typeof(Tabs)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates the tabs for a recipient. Updates one or more tabs for a recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>5Tabs</returns>
        public Tabs UpdateTabs (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
             ApiResponse<Tabs> response = UpdateTabsWithHttpInfo(accountId, templateId, recipientId, templateTabs);
             return response.Data;
        }

        /// <summary>
        /// Updates the tabs for a recipient. Updates one or more tabs for a recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>6ApiResponse of Tabs</returns>
        public ApiResponse< Tabs > UpdateTabsWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateTabs");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateTabs");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling UpdateTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateTabs); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateTabs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateTabs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Tabs>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tabs) Configuration.ApiClient.Deserialize(response, typeof(Tabs)));
            
        }
    
        /// <summary>
        /// Updates the tabs for a recipient. Updates one or more tabs for a recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>7Task of Tabs</returns>
        public async System.Threading.Tasks.Task<Tabs> UpdateTabsAsync (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
             ApiResponse<Tabs> response = await UpdateTabsAsyncWithHttpInfo(accountId, templateId, recipientId, templateTabs);
             return response.Data;

        }

        /// <summary>
        /// Updates the tabs for a recipient. Updates one or more tabs for a recipient in a template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>8Task of ApiResponse (Tabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tabs>> UpdateTabsAsyncWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateTabs");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateTabs");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling UpdateTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateTabs); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateTabs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateTabs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Tabs>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tabs) Configuration.ApiClient.Deserialize(response, typeof(Tabs)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Adds tabs for a recipient. Adds one or more tabs for a recipient.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>5Tabs</returns>
        public Tabs CreateTabs (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
             ApiResponse<Tabs> response = CreateTabsWithHttpInfo(accountId, templateId, recipientId, templateTabs);
             return response.Data;
        }

        /// <summary>
        /// Adds tabs for a recipient. Adds one or more tabs for a recipient.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>6ApiResponse of Tabs</returns>
        public ApiResponse< Tabs > CreateTabsWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateTabs");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateTabs");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling CreateTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateTabs); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateTabs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateTabs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Tabs>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tabs) Configuration.ApiClient.Deserialize(response, typeof(Tabs)));
            
        }
    
        /// <summary>
        /// Adds tabs for a recipient. Adds one or more tabs for a recipient.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>7Task of Tabs</returns>
        public async System.Threading.Tasks.Task<Tabs> CreateTabsAsync (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
             ApiResponse<Tabs> response = await CreateTabsAsyncWithHttpInfo(accountId, templateId, recipientId, templateTabs);
             return response.Data;

        }

        /// <summary>
        /// Adds tabs for a recipient. Adds one or more tabs for a recipient.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>8Task of ApiResponse (Tabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tabs>> CreateTabsAsyncWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateTabs");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling CreateTabs");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling CreateTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateTabs); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateTabs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateTabs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Tabs>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tabs) Configuration.ApiClient.Deserialize(response, typeof(Tabs)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes the tabs associated with a recipient in a template. Deletes one or more tabs associated with a recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>5Tabs</returns>
        public Tabs DeleteTabs (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
             ApiResponse<Tabs> response = DeleteTabsWithHttpInfo(accountId, templateId, recipientId, templateTabs);
             return response.Data;
        }

        /// <summary>
        /// Deletes the tabs associated with a recipient in a template. Deletes one or more tabs associated with a recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>6ApiResponse of Tabs</returns>
        public ApiResponse< Tabs > DeleteTabsWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteTabs");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteTabs");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling DeleteTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateTabs); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteTabs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTabs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Tabs>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tabs) Configuration.ApiClient.Deserialize(response, typeof(Tabs)));
            
        }
    
        /// <summary>
        /// Deletes the tabs associated with a recipient in a template. Deletes one or more tabs associated with a recipient in a template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>7Task of Tabs</returns>
        public async System.Threading.Tasks.Task<Tabs> DeleteTabsAsync (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
             ApiResponse<Tabs> response = await DeleteTabsAsyncWithHttpInfo(accountId, templateId, recipientId, templateTabs);
             return response.Data;

        }

        /// <summary>
        /// Deletes the tabs associated with a recipient in a template. Deletes one or more tabs associated with a recipient in a template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="templateTabs">TBD Description</param>
		/// <returns>8Task of ApiResponse (Tabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tabs>> DeleteTabsAsyncWithHttpInfo (string accountId, string templateId, string recipientId, TemplateTabs templateTabs)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteTabs");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteTabs");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling DeleteTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(templateTabs); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteTabs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTabs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Tabs>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Tabs) Configuration.ApiClient.Deserialize(response, typeof(Tabs)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Shares a template with a group Shares a template with the specified members group.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>5GroupInformation</returns>
        public GroupInformation UpdateGroupShare (string accountId, string templateId, string templatePart, GroupInformation groupInformation)
        {
             ApiResponse<GroupInformation> response = UpdateGroupShareWithHttpInfo(accountId, templateId, templatePart, groupInformation);
             return response.Data;
        }

        /// <summary>
        /// Shares a template with a group Shares a template with the specified members group.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>6ApiResponse of GroupInformation</returns>
        public ApiResponse< GroupInformation > UpdateGroupShareWithHttpInfo (string accountId, string templateId, string templatePart, GroupInformation groupInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateGroupShare");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateGroupShare");
            
            // verify the required parameter 'templatePart' is set
            if (templatePart == null) throw new ApiException(400, "Missing required parameter 'templatePart' when calling UpdateGroupShare");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/{templatePart}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (templatePart != null) pathParams.Add("templatePart", Configuration.ApiClient.ParameterToString(templatePart)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(groupInformation); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateGroupShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateGroupShare: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GroupInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupInformation) Configuration.ApiClient.Deserialize(response, typeof(GroupInformation)));
            
        }
    
        /// <summary>
        /// Shares a template with a group Shares a template with the specified members group.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>7Task of GroupInformation</returns>
        public async System.Threading.Tasks.Task<GroupInformation> UpdateGroupShareAsync (string accountId, string templateId, string templatePart, GroupInformation groupInformation)
        {
             ApiResponse<GroupInformation> response = await UpdateGroupShareAsyncWithHttpInfo(accountId, templateId, templatePart, groupInformation);
             return response.Data;

        }

        /// <summary>
        /// Shares a template with a group Shares a template with the specified members group.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (GroupInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GroupInformation>> UpdateGroupShareAsyncWithHttpInfo (string accountId, string templateId, string templatePart, GroupInformation groupInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateGroupShare");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling UpdateGroupShare");
            // verify the required parameter 'templatePart' is set
            if (templatePart == null) throw new ApiException(400, "Missing required parameter 'templatePart' when calling UpdateGroupShare");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/{templatePart}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (templatePart != null) pathParams.Add("templatePart", Configuration.ApiClient.ParameterToString(templatePart)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(groupInformation); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateGroupShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateGroupShare: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GroupInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupInformation) Configuration.ApiClient.Deserialize(response, typeof(GroupInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Removes a member group&#39;s sharing permissions for a template. Removes a member group&#39;s sharing permissions for a specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>5GroupInformation</returns>
        public GroupInformation DeleteGroupShare (string accountId, string templateId, string templatePart, GroupInformation groupInformation)
        {
             ApiResponse<GroupInformation> response = DeleteGroupShareWithHttpInfo(accountId, templateId, templatePart, groupInformation);
             return response.Data;
        }

        /// <summary>
        /// Removes a member group&#39;s sharing permissions for a template. Removes a member group&#39;s sharing permissions for a specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>6ApiResponse of GroupInformation</returns>
        public ApiResponse< GroupInformation > DeleteGroupShareWithHttpInfo (string accountId, string templateId, string templatePart, GroupInformation groupInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteGroupShare");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteGroupShare");
            
            // verify the required parameter 'templatePart' is set
            if (templatePart == null) throw new ApiException(400, "Missing required parameter 'templatePart' when calling DeleteGroupShare");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/{templatePart}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (templatePart != null) pathParams.Add("templatePart", Configuration.ApiClient.ParameterToString(templatePart)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(groupInformation); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteGroupShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteGroupShare: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GroupInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupInformation) Configuration.ApiClient.Deserialize(response, typeof(GroupInformation)));
            
        }
    
        /// <summary>
        /// Removes a member group&#39;s sharing permissions for a template. Removes a member group&#39;s sharing permissions for a specified template.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>7Task of GroupInformation</returns>
        public async System.Threading.Tasks.Task<GroupInformation> DeleteGroupShareAsync (string accountId, string templateId, string templatePart, GroupInformation groupInformation)
        {
             ApiResponse<GroupInformation> response = await DeleteGroupShareAsyncWithHttpInfo(accountId, templateId, templatePart, groupInformation);
             return response.Data;

        }

        /// <summary>
        /// Removes a member group&#39;s sharing permissions for a template. Removes a member group&#39;s sharing permissions for a specified template.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="templateId">The ID of the template being accessed.</param><param name="templatePart">Currently, the only defined part is **groups**.</param> <param name="groupInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (GroupInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GroupInformation>> DeleteGroupShareAsyncWithHttpInfo (string accountId, string templateId, string templatePart, GroupInformation groupInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteGroupShare");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteGroupShare");
            // verify the required parameter 'templatePart' is set
            if (templatePart == null) throw new ApiException(400, "Missing required parameter 'templatePart' when calling DeleteGroupShare");
            
    
            var path_ = "/v2/accounts/{accountId}/templates/{templateId}/{templatePart}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (templatePart != null) pathParams.Add("templatePart", Configuration.ApiClient.ParameterToString(templatePart)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(groupInformation); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteGroupShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteGroupShare: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GroupInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GroupInformation) Configuration.ApiClient.Deserialize(response, typeof(GroupInformation)));
            
        }
        
    }
    
}
