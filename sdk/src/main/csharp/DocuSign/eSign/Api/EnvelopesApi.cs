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
    public interface IEnvelopesApi
    {
        
        /// <summary>
        /// Gets status changes for one or more envelopes.
        /// </summary>
        /// <remarks>
        /// Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1EnvelopesInformation</returns>
        EnvelopesInformation ListStatusChanges (string accountId, EnvelopesApi.ListStatusChangesOptions options = null);
 
		/// <summary>
        /// Gets status changes for one or more envelopes.
        /// </summary>
        /// <remarks>
        /// Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of EnvelopesInformation</returns>
        ApiResponse<EnvelopesInformation> ListStatusChangesWithHttpInfo (string accountId, EnvelopesApi.ListStatusChangesOptions options = null);

        /// <summary>
        /// Gets status changes for one or more envelopes.
        /// </summary>
        /// <remarks>
        /// Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of EnvelopesInformation</returns>
        System.Threading.Tasks.Task<EnvelopesInformation> ListStatusChangesAsync (string accountId, EnvelopesApi.ListStatusChangesOptions options = null);

        /// <summary>
        /// Gets status changes for one or more envelopes.
        /// </summary>
        /// <remarks>
        /// Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (EnvelopesInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopesInformation>> ListStatusChangesAsyncWithHttpInfo (string accountId, EnvelopesApi.ListStatusChangesOptions options = null);
        
        /// <summary>
        /// Creates an envelope.
        /// </summary>
        /// <remarks>
        /// Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeDefinition">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1EnvelopeSummary</returns>
        EnvelopeSummary CreateEnvelope (string accountId, EnvelopeDefinition envelopeDefinition, EnvelopesApi.CreateEnvelopeOptions options = null);
 
		/// <summary>
        /// Creates an envelope.
        /// </summary>
        /// <remarks>
        /// Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeDefinition">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of EnvelopeSummary</returns>
        ApiResponse<EnvelopeSummary> CreateEnvelopeWithHttpInfo (string accountId, EnvelopeDefinition envelopeDefinition, EnvelopesApi.CreateEnvelopeOptions options = null);

        /// <summary>
        /// Creates an envelope.
        /// </summary>
        /// <remarks>
        /// Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeDefinition">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of EnvelopeSummary</returns>
        System.Threading.Tasks.Task<EnvelopeSummary> CreateEnvelopeAsync (string accountId, EnvelopeDefinition envelopeDefinition, EnvelopesApi.CreateEnvelopeOptions options = null);

        /// <summary>
        /// Creates an envelope.
        /// </summary>
        /// <remarks>
        /// Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeDefinition">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (EnvelopeSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeSummary>> CreateEnvelopeAsyncWithHttpInfo (string accountId, EnvelopeDefinition envelopeDefinition, EnvelopesApi.CreateEnvelopeOptions options = null);
        
        /// <summary>
        /// Gets the envelope status for the specified envelopes.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope status for the specified envelopes.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeIdsRequest">TBD Description</param>
		/// <returns>1EnvelopesInformation</returns>
        EnvelopesInformation ListStatus (string accountId, EnvelopeIdsRequest envelopeIdsRequest);
 
		/// <summary>
        /// Gets the envelope status for the specified envelopes.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope status for the specified envelopes.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeIdsRequest">TBD Description</param>
		/// <returns>2ApiResponse of EnvelopesInformation</returns>
        ApiResponse<EnvelopesInformation> ListStatusWithHttpInfo (string accountId, EnvelopeIdsRequest envelopeIdsRequest);

        /// <summary>
        /// Gets the envelope status for the specified envelopes.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope status for the specified envelopes.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeIdsRequest">TBD Description</param>
		/// <returns>3Task of EnvelopesInformation</returns>
        System.Threading.Tasks.Task<EnvelopesInformation> ListStatusAsync (string accountId, EnvelopeIdsRequest envelopeIdsRequest);

        /// <summary>
        /// Gets the envelope status for the specified envelopes.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope status for the specified envelopes.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeIdsRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (EnvelopesInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopesInformation>> ListStatusAsyncWithHttpInfo (string accountId, EnvelopeIdsRequest envelopeIdsRequest);
        
        /// <summary>
        /// Gets the status of a envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the overall status for the specified envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1Envelope</returns>
        Envelope GetEnvelope (string accountId, string envelopeId, EnvelopesApi.GetEnvelopeOptions options = null);
 
		/// <summary>
        /// Gets the status of a envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the overall status for the specified envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of Envelope</returns>
        ApiResponse<Envelope> GetEnvelopeWithHttpInfo (string accountId, string envelopeId, EnvelopesApi.GetEnvelopeOptions options = null);

        /// <summary>
        /// Gets the status of a envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the overall status for the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of Envelope</returns>
        System.Threading.Tasks.Task<Envelope> GetEnvelopeAsync (string accountId, string envelopeId, EnvelopesApi.GetEnvelopeOptions options = null);

        /// <summary>
        /// Gets the status of a envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the overall status for the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (Envelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<Envelope>> GetEnvelopeAsyncWithHttpInfo (string accountId, string envelopeId, EnvelopesApi.GetEnvelopeOptions options = null);
        
        /// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft
        /// </summary>
        /// <remarks>
        /// The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelope">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1EnvelopeUpdateSummary</returns>
        EnvelopeUpdateSummary Update (string accountId, string envelopeId, Envelope envelope, EnvelopesApi.UpdateOptions options = null);
 
		/// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft
        /// </summary>
        /// <remarks>
        /// The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelope">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of EnvelopeUpdateSummary</returns>
        ApiResponse<EnvelopeUpdateSummary> UpdateWithHttpInfo (string accountId, string envelopeId, Envelope envelope, EnvelopesApi.UpdateOptions options = null);

        /// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft
        /// </summary>
        /// <remarks>
        /// The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelope">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of EnvelopeUpdateSummary</returns>
        System.Threading.Tasks.Task<EnvelopeUpdateSummary> UpdateAsync (string accountId, string envelopeId, Envelope envelope, EnvelopesApi.UpdateOptions options = null);

        /// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft
        /// </summary>
        /// <remarks>
        /// The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelope">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (EnvelopeUpdateSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeUpdateSummary>> UpdateAsyncWithHttpInfo (string accountId, string envelopeId, Envelope envelope, EnvelopesApi.UpdateOptions options = null);
        
        /// <summary>
        /// Gets the envelope audit events for an envelope.
        /// </summary>
        /// <remarks>
        /// Gets the envelope audit events for the specified envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1EnvelopeAuditEventResponse</returns>
        EnvelopeAuditEventResponse ListAuditEvents (string accountId, string envelopeId);
 
		/// <summary>
        /// Gets the envelope audit events for an envelope.
        /// </summary>
        /// <remarks>
        /// Gets the envelope audit events for the specified envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of EnvelopeAuditEventResponse</returns>
        ApiResponse<EnvelopeAuditEventResponse> ListAuditEventsWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Gets the envelope audit events for an envelope.
        /// </summary>
        /// <remarks>
        /// Gets the envelope audit events for the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of EnvelopeAuditEventResponse</returns>
        System.Threading.Tasks.Task<EnvelopeAuditEventResponse> ListAuditEventsAsync (string accountId, string envelopeId);

        /// <summary>
        /// Gets the envelope audit events for an envelope.
        /// </summary>
        /// <remarks>
        /// Gets the envelope audit events for the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (EnvelopeAuditEventResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeAuditEventResponse>> ListAuditEventsAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Gets the custom field information for the specified envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1CustomFieldsEnvelope</returns>
        CustomFieldsEnvelope ListCustomFields (string accountId, string envelopeId);
 
		/// <summary>
        /// Gets the custom field information for the specified envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of CustomFieldsEnvelope</returns>
        ApiResponse<CustomFieldsEnvelope> ListCustomFieldsWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Gets the custom field information for the specified envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of CustomFieldsEnvelope</returns>
        System.Threading.Tasks.Task<CustomFieldsEnvelope> ListCustomFieldsAsync (string accountId, string envelopeId);

        /// <summary>
        /// Gets the custom field information for the specified envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (CustomFieldsEnvelope)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFieldsEnvelope>> ListCustomFieldsAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Updates envelope custom fields in an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the envelope custom fields in draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>1CustomFields</returns>
        CustomFields UpdateCustomFields (string accountId, string envelopeId, CustomFields customFields);
 
		/// <summary>
        /// Updates envelope custom fields in an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the envelope custom fields in draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>2ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> UpdateCustomFieldsWithHttpInfo (string accountId, string envelopeId, CustomFields customFields);

        /// <summary>
        /// Updates envelope custom fields in an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the envelope custom fields in draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>3Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> UpdateCustomFieldsAsync (string accountId, string envelopeId, CustomFields customFields);

        /// <summary>
        /// Updates envelope custom fields in an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the envelope custom fields in draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>4Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> UpdateCustomFieldsAsyncWithHttpInfo (string accountId, string envelopeId, CustomFields customFields);
        
        /// <summary>
        /// Updates envelope custom fields for an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the envelope custom fields for draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>1CustomFields</returns>
        CustomFields CreateCustomFields (string accountId, string envelopeId, CustomFields customFields);
 
		/// <summary>
        /// Updates envelope custom fields for an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the envelope custom fields for draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>2ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> CreateCustomFieldsWithHttpInfo (string accountId, string envelopeId, CustomFields customFields);

        /// <summary>
        /// Updates envelope custom fields for an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the envelope custom fields for draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>3Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> CreateCustomFieldsAsync (string accountId, string envelopeId, CustomFields customFields);

        /// <summary>
        /// Updates envelope custom fields for an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the envelope custom fields for draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>4Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> CreateCustomFieldsAsyncWithHttpInfo (string accountId, string envelopeId, CustomFields customFields);
        
        /// <summary>
        /// Deletes envelope custom fields for draft and in-process envelopes.
        /// </summary>
        /// <remarks>
        /// Deletes envelope custom fields for draft and in-process envelopes.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>1CustomFields</returns>
        CustomFields DeleteCustomFields (string accountId, string envelopeId, CustomFields customFields);
 
		/// <summary>
        /// Deletes envelope custom fields for draft and in-process envelopes.
        /// </summary>
        /// <remarks>
        /// Deletes envelope custom fields for draft and in-process envelopes.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>2ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> DeleteCustomFieldsWithHttpInfo (string accountId, string envelopeId, CustomFields customFields);

        /// <summary>
        /// Deletes envelope custom fields for draft and in-process envelopes.
        /// </summary>
        /// <remarks>
        /// Deletes envelope custom fields for draft and in-process envelopes.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>3Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> DeleteCustomFieldsAsync (string accountId, string envelopeId, CustomFields customFields);

        /// <summary>
        /// Deletes envelope custom fields for draft and in-process envelopes.
        /// </summary>
        /// <remarks>
        /// Deletes envelope custom fields for draft and in-process envelopes.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>4Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> DeleteCustomFieldsAsyncWithHttpInfo (string accountId, string envelopeId, CustomFields customFields);
        
        /// <summary>
        /// Gets a list of envelope documents.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of documents associated with the specified envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1EnvelopeDocumentsResult</returns>
        EnvelopeDocumentsResult ListDocuments (string accountId, string envelopeId);
 
		/// <summary>
        /// Gets a list of envelope documents.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of documents associated with the specified envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of EnvelopeDocumentsResult</returns>
        ApiResponse<EnvelopeDocumentsResult> ListDocumentsWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Gets a list of envelope documents.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of documents associated with the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of EnvelopeDocumentsResult</returns>
        System.Threading.Tasks.Task<EnvelopeDocumentsResult> ListDocumentsAsync (string accountId, string envelopeId);

        /// <summary>
        /// Gets a list of envelope documents.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of documents associated with the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (EnvelopeDocumentsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeDocumentsResult>> ListDocumentsAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Adds one or more documents to an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Adds one or more documents to an existing envelope document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>1EnvelopeDocumentsResult</returns>
        EnvelopeDocumentsResult UpdateDocuments (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition);
 
		/// <summary>
        /// Adds one or more documents to an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Adds one or more documents to an existing envelope document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>2ApiResponse of EnvelopeDocumentsResult</returns>
        ApiResponse<EnvelopeDocumentsResult> UpdateDocumentsWithHttpInfo (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition);

        /// <summary>
        /// Adds one or more documents to an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Adds one or more documents to an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>3Task of EnvelopeDocumentsResult</returns>
        System.Threading.Tasks.Task<EnvelopeDocumentsResult> UpdateDocumentsAsync (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition);

        /// <summary>
        /// Adds one or more documents to an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Adds one or more documents to an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>4Task of ApiResponse (EnvelopeDocumentsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeDocumentsResult>> UpdateDocumentsAsyncWithHttpInfo (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition);
        
        /// <summary>
        /// Deletes documents from a draft envelope.
        /// </summary>
        /// <remarks>
        /// Deletes one or more documents from an existing draft envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>1EnvelopeDocumentsResult</returns>
        EnvelopeDocumentsResult DeleteDocuments (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition);
 
		/// <summary>
        /// Deletes documents from a draft envelope.
        /// </summary>
        /// <remarks>
        /// Deletes one or more documents from an existing draft envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>2ApiResponse of EnvelopeDocumentsResult</returns>
        ApiResponse<EnvelopeDocumentsResult> DeleteDocumentsWithHttpInfo (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition);

        /// <summary>
        /// Deletes documents from a draft envelope.
        /// </summary>
        /// <remarks>
        /// Deletes one or more documents from an existing draft envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>3Task of EnvelopeDocumentsResult</returns>
        System.Threading.Tasks.Task<EnvelopeDocumentsResult> DeleteDocumentsAsync (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition);

        /// <summary>
        /// Deletes documents from a draft envelope.
        /// </summary>
        /// <remarks>
        /// Deletes one or more documents from an existing draft envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>4Task of ApiResponse (EnvelopeDocumentsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnvelopeDocumentsResult>> DeleteDocumentsAsyncWithHttpInfo (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition);
        
        /// <summary>
        /// Gets a document from an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.\n\nYou can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted. \n\nTo retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`.\n/accounts/{accountId}/envelopes/{envelopeId}/documents/combined
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>1Stream</returns>
        Stream GetDocument (string accountId, string envelopeId, string documentId);
 
		/// <summary>
        /// Gets a document from an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.\n\nYou can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted. \n\nTo retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`.\n/accounts/{accountId}/envelopes/{envelopeId}/documents/combined
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>2ApiResponse of Stream</returns>
        ApiResponse<Stream> GetDocumentWithHttpInfo (string accountId, string envelopeId, string documentId);

        /// <summary>
        /// Gets a document from an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.\n\nYou can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted. \n\nTo retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`.\n/accounts/{accountId}/envelopes/{envelopeId}/documents/combined
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>3Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> GetDocumentAsync (string accountId, string envelopeId, string documentId);

        /// <summary>
        /// Gets a document from an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.\n\nYou can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted. \n\nTo retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`.\n/accounts/{accountId}/envelopes/{envelopeId}/documents/combined
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>4Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> GetDocumentAsyncWithHttpInfo (string accountId, string envelopeId, string documentId);
        
        /// <summary>
        /// Gets the custom document fields from an  existing envelope document.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document field information from an existing envelope document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>1DocumentFieldsInformation</returns>
        DocumentFieldsInformation ListDocumentFields (string accountId, string envelopeId, string documentId);
 
		/// <summary>
        /// Gets the custom document fields from an  existing envelope document.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document field information from an existing envelope document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>2ApiResponse of DocumentFieldsInformation</returns>
        ApiResponse<DocumentFieldsInformation> ListDocumentFieldsWithHttpInfo (string accountId, string envelopeId, string documentId);

        /// <summary>
        /// Gets the custom document fields from an  existing envelope document.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document field information from an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>3Task of DocumentFieldsInformation</returns>
        System.Threading.Tasks.Task<DocumentFieldsInformation> ListDocumentFieldsAsync (string accountId, string envelopeId, string documentId);

        /// <summary>
        /// Gets the custom document fields from an  existing envelope document.
        /// </summary>
        /// <remarks>
        /// Retrieves the custom document field information from an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>4Task of ApiResponse (DocumentFieldsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> ListDocumentFieldsAsyncWithHttpInfo (string accountId, string envelopeId, string documentId);
        
        /// <summary>
        /// Updates existing custom document fields in an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Updates existing custom document fields in an existing envelope document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>1DocumentFieldsInformation</returns>
        DocumentFieldsInformation UpdateDocumentFields (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);
 
		/// <summary>
        /// Updates existing custom document fields in an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Updates existing custom document fields in an existing envelope document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>2ApiResponse of DocumentFieldsInformation</returns>
        ApiResponse<DocumentFieldsInformation> UpdateDocumentFieldsWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Updates existing custom document fields in an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Updates existing custom document fields in an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>3Task of DocumentFieldsInformation</returns>
        System.Threading.Tasks.Task<DocumentFieldsInformation> UpdateDocumentFieldsAsync (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Updates existing custom document fields in an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Updates existing custom document fields in an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (DocumentFieldsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> UpdateDocumentFieldsAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);
        
        /// <summary>
        /// Creates custom document fields in an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing envelope document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>1DocumentFieldsInformation</returns>
        DocumentFieldsInformation CreateDocumentFields (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);
 
		/// <summary>
        /// Creates custom document fields in an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing envelope document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>2ApiResponse of DocumentFieldsInformation</returns>
        ApiResponse<DocumentFieldsInformation> CreateDocumentFieldsWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Creates custom document fields in an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>3Task of DocumentFieldsInformation</returns>
        System.Threading.Tasks.Task<DocumentFieldsInformation> CreateDocumentFieldsAsync (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Creates custom document fields in an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Creates custom document fields in an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (DocumentFieldsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> CreateDocumentFieldsAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);
        
        /// <summary>
        /// Deletes custom document fields from an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Deletes custom document fields from an existing envelope document.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>1DocumentFieldsInformation</returns>
        DocumentFieldsInformation DeleteDocumentFields (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);
 
		/// <summary>
        /// Deletes custom document fields from an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Deletes custom document fields from an existing envelope document.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>2ApiResponse of DocumentFieldsInformation</returns>
        ApiResponse<DocumentFieldsInformation> DeleteDocumentFieldsWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Deletes custom document fields from an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Deletes custom document fields from an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>3Task of DocumentFieldsInformation</returns>
        System.Threading.Tasks.Task<DocumentFieldsInformation> DeleteDocumentFieldsAsync (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);

        /// <summary>
        /// Deletes custom document fields from an existing envelope document.
        /// </summary>
        /// <remarks>
        /// Deletes custom document fields from an existing envelope document.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (DocumentFieldsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> DeleteDocumentFieldsAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation);
        
        /// <summary>
        /// Deletes a page from a document in an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes a page from a document in an envelope based on the page number.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param>
		/// <returns>1</returns>
        void DeleteDocumentPage (string accountId, string envelopeId, string documentId, string pageNumber);
 
		/// <summary>
        /// Deletes a page from a document in an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes a page from a document in an envelope based on the page number.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param>
		/// <returns>2ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteDocumentPageWithHttpInfo (string accountId, string envelopeId, string documentId, string pageNumber);

        /// <summary>
        /// Deletes a page from a document in an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes a page from a document in an envelope based on the page number.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param>
		/// <returns>3Task of void</returns>
        System.Threading.Tasks.Task DeleteDocumentPageAsync (string accountId, string envelopeId, string documentId, string pageNumber);

        /// <summary>
        /// Deletes a page from a document in an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes a page from a document in an envelope based on the page number.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param>
		/// <returns>4Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentPageAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, string pageNumber);
        
        /// <summary>
        /// Gets the templates associated with a document in an existing envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the templates associated with a document in the specified envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>1TemplateInformation</returns>
        TemplateInformation ListTemplatesForDocument (string accountId, string envelopeId, string documentId);
 
		/// <summary>
        /// Gets the templates associated with a document in an existing envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the templates associated with a document in the specified envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>2ApiResponse of TemplateInformation</returns>
        ApiResponse<TemplateInformation> ListTemplatesForDocumentWithHttpInfo (string accountId, string envelopeId, string documentId);

        /// <summary>
        /// Gets the templates associated with a document in an existing envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the templates associated with a document in the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>3Task of TemplateInformation</returns>
        System.Threading.Tasks.Task<TemplateInformation> ListTemplatesForDocumentAsync (string accountId, string envelopeId, string documentId);

        /// <summary>
        /// Gets the templates associated with a document in an existing envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the templates associated with a document in the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>4Task of ApiResponse (TemplateInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateInformation>> ListTemplatesForDocumentAsyncWithHttpInfo (string accountId, string envelopeId, string documentId);
        
        /// <summary>
        /// Adds templates to a document in an  envelope.
        /// </summary>
        /// <remarks>
        /// Adds templates to a document in the specified envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>1DocumentTemplateList</returns>
        DocumentTemplateList ApplyTemplateToDocument (string accountId, string envelopeId, string documentId, DocumentTemplateList documentTemplateList);
 
		/// <summary>
        /// Adds templates to a document in an  envelope.
        /// </summary>
        /// <remarks>
        /// Adds templates to a document in the specified envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>2ApiResponse of DocumentTemplateList</returns>
        ApiResponse<DocumentTemplateList> ApplyTemplateToDocumentWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentTemplateList documentTemplateList);

        /// <summary>
        /// Adds templates to a document in an  envelope.
        /// </summary>
        /// <remarks>
        /// Adds templates to a document in the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>3Task of DocumentTemplateList</returns>
        System.Threading.Tasks.Task<DocumentTemplateList> ApplyTemplateToDocumentAsync (string accountId, string envelopeId, string documentId, DocumentTemplateList documentTemplateList);

        /// <summary>
        /// Adds templates to a document in an  envelope.
        /// </summary>
        /// <remarks>
        /// Adds templates to a document in the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>4Task of ApiResponse (DocumentTemplateList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentTemplateList>> ApplyTemplateToDocumentAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentTemplateList documentTemplateList);
        
        /// <summary>
        /// Deletes a template from a document in an existing envelope.
        /// </summary>
        /// <remarks>
        /// Deletes the specified template from a document in an existing envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>1</returns>
        void DeleteTemplatesFromDocument (string accountId, string envelopeId, string documentId, string templateId);
 
		/// <summary>
        /// Deletes a template from a document in an existing envelope.
        /// </summary>
        /// <remarks>
        /// Deletes the specified template from a document in an existing envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>2ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteTemplatesFromDocumentWithHttpInfo (string accountId, string envelopeId, string documentId, string templateId);

        /// <summary>
        /// Deletes a template from a document in an existing envelope.
        /// </summary>
        /// <remarks>
        /// Deletes the specified template from a document in an existing envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>3Task of void</returns>
        System.Threading.Tasks.Task DeleteTemplatesFromDocumentAsync (string accountId, string envelopeId, string documentId, string templateId);

        /// <summary>
        /// Deletes a template from a document in an existing envelope.
        /// </summary>
        /// <remarks>
        /// Deletes the specified template from a document in an existing envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>4Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTemplatesFromDocumentAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, string templateId);
        
        /// <summary>
        /// Gets the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the email override settings for the specified envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1EmailSettings</returns>
        EmailSettings GetEmailSettings (string accountId, string envelopeId);
 
		/// <summary>
        /// Gets the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the email override settings for the specified envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of EmailSettings</returns>
        ApiResponse<EmailSettings> GetEmailSettingsWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Gets the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the email override settings for the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of EmailSettings</returns>
        System.Threading.Tasks.Task<EmailSettings> GetEmailSettingsAsync (string accountId, string envelopeId);

        /// <summary>
        /// Gets the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the email override settings for the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (EmailSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSettings>> GetEmailSettingsAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Updates the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.\n\nThis can also be used to delete an individual email override setting by using an empty string for the value to be deleted.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>1EmailSettings</returns>
        EmailSettings UpdateEmailSettings (string accountId, string envelopeId, EmailSettings emailSettings);
 
		/// <summary>
        /// Updates the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.\n\nThis can also be used to delete an individual email override setting by using an empty string for the value to be deleted.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>2ApiResponse of EmailSettings</returns>
        ApiResponse<EmailSettings> UpdateEmailSettingsWithHttpInfo (string accountId, string envelopeId, EmailSettings emailSettings);

        /// <summary>
        /// Updates the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.\n\nThis can also be used to delete an individual email override setting by using an empty string for the value to be deleted.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>3Task of EmailSettings</returns>
        System.Threading.Tasks.Task<EmailSettings> UpdateEmailSettingsAsync (string accountId, string envelopeId, EmailSettings emailSettings);

        /// <summary>
        /// Updates the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.\n\nThis can also be used to delete an individual email override setting by using an empty string for the value to be deleted.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>4Task of ApiResponse (EmailSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSettings>> UpdateEmailSettingsAsyncWithHttpInfo (string accountId, string envelopeId, EmailSettings emailSettings);
        
        /// <summary>
        /// Adds email setting overrides to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>1EmailSettings</returns>
        EmailSettings CreateEmailSettings (string accountId, string envelopeId, EmailSettings emailSettings);
 
		/// <summary>
        /// Adds email setting overrides to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>2ApiResponse of EmailSettings</returns>
        ApiResponse<EmailSettings> CreateEmailSettingsWithHttpInfo (string accountId, string envelopeId, EmailSettings emailSettings);

        /// <summary>
        /// Adds email setting overrides to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>3Task of EmailSettings</returns>
        System.Threading.Tasks.Task<EmailSettings> CreateEmailSettingsAsync (string accountId, string envelopeId, EmailSettings emailSettings);

        /// <summary>
        /// Adds email setting overrides to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>4Task of ApiResponse (EmailSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSettings>> CreateEmailSettingsAsyncWithHttpInfo (string accountId, string envelopeId, EmailSettings emailSettings);
        
        /// <summary>
        /// Deletes the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1EmailSettings</returns>
        EmailSettings DeleteEmailSettings (string accountId, string envelopeId);
 
		/// <summary>
        /// Deletes the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of EmailSettings</returns>
        ApiResponse<EmailSettings> DeleteEmailSettingsWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Deletes the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of EmailSettings</returns>
        System.Threading.Tasks.Task<EmailSettings> DeleteEmailSettingsAsync (string accountId, string envelopeId);

        /// <summary>
        /// Deletes the email setting overrides for an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (EmailSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailSettings>> DeleteEmailSettingsAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Gets envelope lock information.
        /// </summary>
        /// <remarks>
        /// Retrieves general information about the envelope lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1LockInformation</returns>
        LockInformation GetLock (string accountId, string envelopeId);
 
		/// <summary>
        /// Gets envelope lock information.
        /// </summary>
        /// <remarks>
        /// Retrieves general information about the envelope lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of LockInformation</returns>
        ApiResponse<LockInformation> GetLockWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Gets envelope lock information.
        /// </summary>
        /// <remarks>
        /// Retrieves general information about the envelope lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of LockInformation</returns>
        System.Threading.Tasks.Task<LockInformation> GetLockAsync (string accountId, string envelopeId);

        /// <summary>
        /// Gets envelope lock information.
        /// </summary>
        /// <remarks>
        /// Retrieves general information about the envelope lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (LockInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<LockInformation>> GetLockAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Updates an envelope lock.
        /// </summary>
        /// <remarks>
        /// Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>1LockInformation</returns>
        LockInformation UpdateLock (string accountId, string envelopeId, LockRequest lockRequest);
 
		/// <summary>
        /// Updates an envelope lock.
        /// </summary>
        /// <remarks>
        /// Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>2ApiResponse of LockInformation</returns>
        ApiResponse<LockInformation> UpdateLockWithHttpInfo (string accountId, string envelopeId, LockRequest lockRequest);

        /// <summary>
        /// Updates an envelope lock.
        /// </summary>
        /// <remarks>
        /// Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>3Task of LockInformation</returns>
        System.Threading.Tasks.Task<LockInformation> UpdateLockAsync (string accountId, string envelopeId, LockRequest lockRequest);

        /// <summary>
        /// Updates an envelope lock.
        /// </summary>
        /// <remarks>
        /// Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (LockInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<LockInformation>> UpdateLockAsyncWithHttpInfo (string accountId, string envelopeId, LockRequest lockRequest);
        
        /// <summary>
        /// Lock an envelope.
        /// </summary>
        /// <remarks>
        /// Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.\n\nNote: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>1LockInformation</returns>
        LockInformation CreateLock (string accountId, string envelopeId, LockRequest lockRequest);
 
		/// <summary>
        /// Lock an envelope.
        /// </summary>
        /// <remarks>
        /// Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.\n\nNote: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>2ApiResponse of LockInformation</returns>
        ApiResponse<LockInformation> CreateLockWithHttpInfo (string accountId, string envelopeId, LockRequest lockRequest);

        /// <summary>
        /// Lock an envelope.
        /// </summary>
        /// <remarks>
        /// Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.\n\nNote: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>3Task of LockInformation</returns>
        System.Threading.Tasks.Task<LockInformation> CreateLockAsync (string accountId, string envelopeId, LockRequest lockRequest);

        /// <summary>
        /// Lock an envelope.
        /// </summary>
        /// <remarks>
        /// Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.\n\nNote: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (LockInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<LockInformation>> CreateLockAsyncWithHttpInfo (string accountId, string envelopeId, LockRequest lockRequest);
        
        /// <summary>
        /// Deletes an envelope lock.
        /// </summary>
        /// <remarks>
        /// Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1LockInformation</returns>
        LockInformation DeleteLock (string accountId, string envelopeId);
 
		/// <summary>
        /// Deletes an envelope lock.
        /// </summary>
        /// <remarks>
        /// Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of LockInformation</returns>
        ApiResponse<LockInformation> DeleteLockWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Deletes an envelope lock.
        /// </summary>
        /// <remarks>
        /// Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of LockInformation</returns>
        System.Threading.Tasks.Task<LockInformation> DeleteLockAsync (string accountId, string envelopeId);

        /// <summary>
        /// Deletes an envelope lock.
        /// </summary>
        /// <remarks>
        /// Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (LockInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<LockInformation>> DeleteLockAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Gets envelope notification information.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope notification, reminders and expirations, information for an existing envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1Notification</returns>
        Notification GetNotificationSettings (string accountId, string envelopeId);
 
		/// <summary>
        /// Gets envelope notification information.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope notification, reminders and expirations, information for an existing envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of Notification</returns>
        ApiResponse<Notification> GetNotificationSettingsWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Gets envelope notification information.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope notification, reminders and expirations, information for an existing envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of Notification</returns>
        System.Threading.Tasks.Task<Notification> GetNotificationSettingsAsync (string accountId, string envelopeId);

        /// <summary>
        /// Gets envelope notification information.
        /// </summary>
        /// <remarks>
        /// Retrieves the envelope notification, reminders and expirations, information for an existing envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (Notification)</returns>
        System.Threading.Tasks.Task<ApiResponse<Notification>> GetNotificationSettingsAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Gets the status of recipients for an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list. \n\nThe `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1Recipients</returns>
        Recipients ListRecipients (string accountId, string envelopeId);
 
		/// <summary>
        /// Gets the status of recipients for an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list. \n\nThe `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of Recipients</returns>
        ApiResponse<Recipients> ListRecipientsWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Gets the status of recipients for an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list. \n\nThe `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of Recipients</returns>
        System.Threading.Tasks.Task<Recipients> ListRecipientsAsync (string accountId, string envelopeId);

        /// <summary>
        /// Gets the status of recipients for an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list. \n\nThe `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (Recipients)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipients>> ListRecipientsAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope.
        /// </summary>
        /// <remarks>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope. \n\nFor draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.\n\nOnce an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.\n\nIf you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>1RecipientsUpdateSummary</returns>
        RecipientsUpdateSummary UpdateRecipients (string accountId, string envelopeId, Recipients recipients);
 
		/// <summary>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope.
        /// </summary>
        /// <remarks>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope. \n\nFor draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.\n\nOnce an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.\n\nIf you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>2ApiResponse of RecipientsUpdateSummary</returns>
        ApiResponse<RecipientsUpdateSummary> UpdateRecipientsWithHttpInfo (string accountId, string envelopeId, Recipients recipients);

        /// <summary>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope.
        /// </summary>
        /// <remarks>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope. \n\nFor draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.\n\nOnce an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.\n\nIf you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>3Task of RecipientsUpdateSummary</returns>
        System.Threading.Tasks.Task<RecipientsUpdateSummary> UpdateRecipientsAsync (string accountId, string envelopeId, Recipients recipients);

        /// <summary>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope.
        /// </summary>
        /// <remarks>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope. \n\nFor draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.\n\nOnce an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.\n\nIf you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>4Task of ApiResponse (RecipientsUpdateSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecipientsUpdateSummary>> UpdateRecipientsAsyncWithHttpInfo (string accountId, string envelopeId, Recipients recipients);
        
        /// <summary>
        /// Adds one or more recipients to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds one or more recipients to an envelope.\n\nFor an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>1Recipients</returns>
        Recipients CreateRecipient (string accountId, string envelopeId, Recipients recipients);
 
		/// <summary>
        /// Adds one or more recipients to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds one or more recipients to an envelope.\n\nFor an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>2ApiResponse of Recipients</returns>
        ApiResponse<Recipients> CreateRecipientWithHttpInfo (string accountId, string envelopeId, Recipients recipients);

        /// <summary>
        /// Adds one or more recipients to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds one or more recipients to an envelope.\n\nFor an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>3Task of Recipients</returns>
        System.Threading.Tasks.Task<Recipients> CreateRecipientAsync (string accountId, string envelopeId, Recipients recipients);

        /// <summary>
        /// Adds one or more recipients to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds one or more recipients to an envelope.\n\nFor an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>4Task of ApiResponse (Recipients)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipients>> CreateRecipientAsyncWithHttpInfo (string accountId, string envelopeId, Recipients recipients);
        
        /// <summary>
        /// Deletes recipients from an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.\n\nIf the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>1Recipients</returns>
        Recipients DeleteRecipients (string accountId, string envelopeId, Recipients recipients);
 
		/// <summary>
        /// Deletes recipients from an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.\n\nIf the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>2ApiResponse of Recipients</returns>
        ApiResponse<Recipients> DeleteRecipientsWithHttpInfo (string accountId, string envelopeId, Recipients recipients);

        /// <summary>
        /// Deletes recipients from an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.\n\nIf the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>3Task of Recipients</returns>
        System.Threading.Tasks.Task<Recipients> DeleteRecipientsAsync (string accountId, string envelopeId, Recipients recipients);

        /// <summary>
        /// Deletes recipients from an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.\n\nIf the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>4Task of ApiResponse (Recipients)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipients>> DeleteRecipientsAsyncWithHttpInfo (string accountId, string envelopeId, Recipients recipients);
        
        /// <summary>
        /// Deletes a recipient from an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>1Recipients</returns>
        Recipients DeleteRecipient (string accountId, string envelopeId, string recipientId);
 
		/// <summary>
        /// Deletes a recipient from an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>2ApiResponse of Recipients</returns>
        ApiResponse<Recipients> DeleteRecipientWithHttpInfo (string accountId, string envelopeId, string recipientId);

        /// <summary>
        /// Deletes a recipient from an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>3Task of Recipients</returns>
        System.Threading.Tasks.Task<Recipients> DeleteRecipientAsync (string accountId, string envelopeId, string recipientId);

        /// <summary>
        /// Deletes a recipient from an envelope.
        /// </summary>
        /// <remarks>
        /// Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>4Task of ApiResponse (Recipients)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recipients>> DeleteRecipientAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId);
        
        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves information about the tabs associated with a recipient in a draft envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>1Tabs</returns>
        Tabs ListTabs (string accountId, string envelopeId, string recipientId);
 
		/// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves information about the tabs associated with a recipient in a draft envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>2ApiResponse of Tabs</returns>
        ApiResponse<Tabs> ListTabsWithHttpInfo (string accountId, string envelopeId, string recipientId);

        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves information about the tabs associated with a recipient in a draft envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>3Task of Tabs</returns>
        System.Threading.Tasks.Task<Tabs> ListTabsAsync (string accountId, string envelopeId, string recipientId);

        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in an envelope.
        /// </summary>
        /// <remarks>
        /// Retrieves information about the tabs associated with a recipient in a draft envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>4Task of ApiResponse (Tabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tabs>> ListTabsAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId);
        
        /// <summary>
        /// Updates the tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Updates one or more tabs for a recipient in a draft envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>1Tabs</returns>
        Tabs UpdateTabs (string accountId, string envelopeId, string recipientId, Tabs tabs);
 
		/// <summary>
        /// Updates the tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Updates one or more tabs for a recipient in a draft envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>2ApiResponse of Tabs</returns>
        ApiResponse<Tabs> UpdateTabsWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs);

        /// <summary>
        /// Updates the tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Updates one or more tabs for a recipient in a draft envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>3Task of Tabs</returns>
        System.Threading.Tasks.Task<Tabs> UpdateTabsAsync (string accountId, string envelopeId, string recipientId, Tabs tabs);

        /// <summary>
        /// Updates the tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Updates one or more tabs for a recipient in a draft envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>4Task of ApiResponse (Tabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tabs>> UpdateTabsAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs);
        
        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more tabs for a recipient.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>1Tabs</returns>
        Tabs CreateTabs (string accountId, string envelopeId, string recipientId, Tabs tabs);
 
		/// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more tabs for a recipient.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>2ApiResponse of Tabs</returns>
        ApiResponse<Tabs> CreateTabsWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs);

        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more tabs for a recipient.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>3Task of Tabs</returns>
        System.Threading.Tasks.Task<Tabs> CreateTabsAsync (string accountId, string envelopeId, string recipientId, Tabs tabs);

        /// <summary>
        /// Adds tabs for a recipient.
        /// </summary>
        /// <remarks>
        /// Adds one or more tabs for a recipient.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>4Task of ApiResponse (Tabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tabs>> CreateTabsAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs);
        
        /// <summary>
        /// Deletes the tabs associated with a recipient.
        /// </summary>
        /// <remarks>
        /// Deletes one or more tabs associated with a recipient in a draft envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>1Tabs</returns>
        Tabs DeleteTabs (string accountId, string envelopeId, string recipientId, Tabs tabs);
 
		/// <summary>
        /// Deletes the tabs associated with a recipient.
        /// </summary>
        /// <remarks>
        /// Deletes one or more tabs associated with a recipient in a draft envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>2ApiResponse of Tabs</returns>
        ApiResponse<Tabs> DeleteTabsWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs);

        /// <summary>
        /// Deletes the tabs associated with a recipient.
        /// </summary>
        /// <remarks>
        /// Deletes one or more tabs associated with a recipient in a draft envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>3Task of Tabs</returns>
        System.Threading.Tasks.Task<Tabs> DeleteTabsAsync (string accountId, string envelopeId, string recipientId, Tabs tabs);

        /// <summary>
        /// Deletes the tabs associated with a recipient.
        /// </summary>
        /// <remarks>
        /// Deletes one or more tabs associated with a recipient in a draft envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>4Task of ApiResponse (Tabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<Tabs>> DeleteTabsAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs);
        
        /// <summary>
        /// Get List of Templates used in an Envelope
        /// </summary>
        /// <remarks>
        /// This returns a list of the templates, name and ID, used in an envelope.&lt;br/&gt;&lt;br/&gt;Note: This only returns information for server side templates.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1TemplateInformation</returns>
        TemplateInformation ListTemplates (string accountId, string envelopeId);
 
		/// <summary>
        /// Get List of Templates used in an Envelope
        /// </summary>
        /// <remarks>
        /// This returns a list of the templates, name and ID, used in an envelope.&lt;br/&gt;&lt;br/&gt;Note: This only returns information for server side templates.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of TemplateInformation</returns>
        ApiResponse<TemplateInformation> ListTemplatesWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Get List of Templates used in an Envelope
        /// </summary>
        /// <remarks>
        /// This returns a list of the templates, name and ID, used in an envelope.&lt;br/&gt;&lt;br/&gt;Note: This only returns information for server side templates.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of TemplateInformation</returns>
        System.Threading.Tasks.Task<TemplateInformation> ListTemplatesAsync (string accountId, string envelopeId);

        /// <summary>
        /// Get List of Templates used in an Envelope
        /// </summary>
        /// <remarks>
        /// This returns a list of the templates, name and ID, used in an envelope.&lt;br/&gt;&lt;br/&gt;Note: This only returns information for server side templates.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse (TemplateInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateInformation>> ListTemplatesAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Adds templates to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds templates to the specified envelope.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>1DocumentTemplateList</returns>
        DocumentTemplateList ApplyTemplate (string accountId, string envelopeId, DocumentTemplateList documentTemplateList);
 
		/// <summary>
        /// Adds templates to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds templates to the specified envelope.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>2ApiResponse of DocumentTemplateList</returns>
        ApiResponse<DocumentTemplateList> ApplyTemplateWithHttpInfo (string accountId, string envelopeId, DocumentTemplateList documentTemplateList);

        /// <summary>
        /// Adds templates to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds templates to the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>3Task of DocumentTemplateList</returns>
        System.Threading.Tasks.Task<DocumentTemplateList> ApplyTemplateAsync (string accountId, string envelopeId, DocumentTemplateList documentTemplateList);

        /// <summary>
        /// Adds templates to an envelope.
        /// </summary>
        /// <remarks>
        /// Adds templates to the specified envelope.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>4Task of ApiResponse (DocumentTemplateList)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentTemplateList>> ApplyTemplateAsyncWithHttpInfo (string accountId, string envelopeId, DocumentTemplateList documentTemplateList);
        
        /// <summary>
        /// Returns a URL to the envelope correction UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="correctViewRequest">TBD Description</param>
		/// <returns>1ViewUrl</returns>
        ViewUrl CreateCorrectView (string accountId, string envelopeId, CorrectViewRequest correctViewRequest);
 
		/// <summary>
        /// Returns a URL to the envelope correction UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="correctViewRequest">TBD Description</param>
		/// <returns>2ApiResponse of ViewUrl</returns>
        ApiResponse<ViewUrl> CreateCorrectViewWithHttpInfo (string accountId, string envelopeId, CorrectViewRequest correctViewRequest);

        /// <summary>
        /// Returns a URL to the envelope correction UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="correctViewRequest">TBD Description</param>
		/// <returns>3Task of ViewUrl</returns>
        System.Threading.Tasks.Task<ViewUrl> CreateCorrectViewAsync (string accountId, string envelopeId, CorrectViewRequest correctViewRequest);

        /// <summary>
        /// Returns a URL to the envelope correction UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="correctViewRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (ViewUrl)</returns>
        System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateCorrectViewAsyncWithHttpInfo (string accountId, string envelopeId, CorrectViewRequest correctViewRequest);
        
        /// <summary>
        /// Returns a URL to the edit view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>1ViewUrl</returns>
        ViewUrl CreateEditView (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest);
 
		/// <summary>
        /// Returns a URL to the edit view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>2ApiResponse of ViewUrl</returns>
        ApiResponse<ViewUrl> CreateEditViewWithHttpInfo (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest);

        /// <summary>
        /// Returns a URL to the edit view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>3Task of ViewUrl</returns>
        System.Threading.Tasks.Task<ViewUrl> CreateEditViewAsync (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest);

        /// <summary>
        /// Returns a URL to the edit view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (ViewUrl)</returns>
        System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateEditViewAsyncWithHttpInfo (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest);
        
        /// <summary>
        /// Returns a URL to the recipient view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent. \n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. \n\nAn entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipientViewRequest">TBD Description</param>
		/// <returns>1ViewUrl</returns>
        ViewUrl CreateRecipientView (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest);
 
		/// <summary>
        /// Returns a URL to the recipient view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent. \n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. \n\nAn entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipientViewRequest">TBD Description</param>
		/// <returns>2ApiResponse of ViewUrl</returns>
        ApiResponse<ViewUrl> CreateRecipientViewWithHttpInfo (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest);

        /// <summary>
        /// Returns a URL to the recipient view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent. \n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. \n\nAn entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipientViewRequest">TBD Description</param>
		/// <returns>3Task of ViewUrl</returns>
        System.Threading.Tasks.Task<ViewUrl> CreateRecipientViewAsync (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest);

        /// <summary>
        /// Returns a URL to the recipient view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent. \n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. \n\nAn entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipientViewRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (ViewUrl)</returns>
        System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateRecipientViewAsyncWithHttpInfo (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest);
        
        /// <summary>
        /// Returns a URL to the sender view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>1ViewUrl</returns>
        ViewUrl CreateSenderView (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest);
 
		/// <summary>
        /// Returns a URL to the sender view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>2ApiResponse of ViewUrl</returns>
        ApiResponse<ViewUrl> CreateSenderViewWithHttpInfo (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest);

        /// <summary>
        /// Returns a URL to the sender view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>3Task of ViewUrl</returns>
        System.Threading.Tasks.Task<ViewUrl> CreateSenderViewAsync (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest);

        /// <summary>
        /// Returns a URL to the sender view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (ViewUrl)</returns>
        System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateSenderViewAsyncWithHttpInfo (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest);
        
        /// <summary>
        /// Reserved: Returns a URL to the secure link view UI.
        /// </summary>
        /// <remarks>
        /// Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="viewLinkRequest">TBD Description</param>
		/// <returns>1ViewUrl</returns>
        ViewUrl CreateViewLink (string accountId, string envelopeId, ViewLinkRequest viewLinkRequest);
 
		/// <summary>
        /// Reserved: Returns a URL to the secure link view UI.
        /// </summary>
        /// <remarks>
        /// Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="viewLinkRequest">TBD Description</param>
		/// <returns>2ApiResponse of ViewUrl</returns>
        ApiResponse<ViewUrl> CreateViewLinkWithHttpInfo (string accountId, string envelopeId, ViewLinkRequest viewLinkRequest);

        /// <summary>
        /// Reserved: Returns a URL to the secure link view UI.
        /// </summary>
        /// <remarks>
        /// Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="viewLinkRequest">TBD Description</param>
		/// <returns>3Task of ViewUrl</returns>
        System.Threading.Tasks.Task<ViewUrl> CreateViewLinkAsync (string accountId, string envelopeId, ViewLinkRequest viewLinkRequest);

        /// <summary>
        /// Reserved: Returns a URL to the secure link view UI.
        /// </summary>
        /// <remarks>
        /// Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="viewLinkRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (ViewUrl)</returns>
        System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateViewLinkAsyncWithHttpInfo (string accountId, string envelopeId, ViewLinkRequest viewLinkRequest);
        
        /// <summary>
        /// Reserved: Expires a secure view link.
        /// </summary>
        /// <remarks>
        /// Reserved: Expires a secure view link
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>1</returns>
        void DeleteViewLink (string accountId, string envelopeId);
 
		/// <summary>
        /// Reserved: Expires a secure view link.
        /// </summary>
        /// <remarks>
        /// Reserved: Expires a secure view link
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>2ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteViewLinkWithHttpInfo (string accountId, string envelopeId);

        /// <summary>
        /// Reserved: Expires a secure view link.
        /// </summary>
        /// <remarks>
        /// Reserved: Expires a secure view link
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>3Task of void</returns>
        System.Threading.Tasks.Task DeleteViewLinkAsync (string accountId, string envelopeId);

        /// <summary>
        /// Reserved: Expires a secure view link.
        /// </summary>
        /// <remarks>
        /// Reserved: Expires a secure view link
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>4Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteViewLinkAsyncWithHttpInfo (string accountId, string envelopeId);
        
        /// <summary>
        /// Returns a URL to the authentication view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="consoleViewRequest">TBD Description</param>
		/// <returns>1ViewUrl</returns>
        ViewUrl CreateConsoleView (string accountId, ConsoleViewRequest consoleViewRequest);
 
		/// <summary>
        /// Returns a URL to the authentication view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="consoleViewRequest">TBD Description</param>
		/// <returns>2ApiResponse of ViewUrl</returns>
        ApiResponse<ViewUrl> CreateConsoleViewWithHttpInfo (string accountId, ConsoleViewRequest consoleViewRequest);

        /// <summary>
        /// Returns a URL to the authentication view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="consoleViewRequest">TBD Description</param>
		/// <returns>3Task of ViewUrl</returns>
        System.Threading.Tasks.Task<ViewUrl> CreateConsoleViewAsync (string accountId, ConsoleViewRequest consoleViewRequest);

        /// <summary>
        /// Returns a URL to the authentication view UI.
        /// </summary>
        /// <remarks>
        /// Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="consoleViewRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (ViewUrl)</returns>
        System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateConsoleViewAsyncWithHttpInfo (string accountId, ConsoleViewRequest consoleViewRequest);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EnvelopesApi : IEnvelopesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EnvelopesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EnvelopesApi(Configuration configuration = null)
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
        /// Gets status changes for one or more envelopes. Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </summary>
		public class ListStatusChangesOptions
		{
				
			/// 
			public string block {get; set;}
				
			/// 
			public string powerformids {get; set;}
				
			/// 
			public string orderBy {get; set;}
				
			/// 
			public string intersectingFolderIds {get; set;}
				
			/// The date/time setting that specifies the date/time when the request begins checking for status changes for envelopes in the account.\n\nThis is required unless &#39;envelopeId&#39;s are used. 
			public string fromDate {get; set;}
				
			/// Specifies the Authoritative Copy Status for the envelopes. The possible values are: Unknown, Original, Transferred, AuthoritativeCopy, AuthoritativeCopyExportPending, AuthoritativeCopyExported, DepositPending, Deposited, DepositedEO, or DepositFailed. 
			public string acStatus {get; set;}
				
			/// 
			public string count {get; set;}
				
			/// This specifies the envelope custom field name and value searched for in the envelope information. The value portion of the query can use partial strings by adding &#39;%&#39; (percent sign) around the custom field query value. \n\nExample 1: If you have an envelope custom field called \&quot;Region\&quot; and you want to search for all envelopes where the value is \&quot;West\&quot; you would use the query: `?custom_field=Region=West`. \n\nExample 2: To search for envelopes where the `ApplicationID` custom field has the value or partial value of \&quot;DocuSign\&quot; in field, the query would be: `?custom_field=ApplicationId=%DocuSign%` This would find envelopes where the custom field value is \&quot;DocuSign for Salesforce\&quot; or \&quot;DocuSign envelope.\&quot; 
			public string customField {get; set;}
				
			/// 
			public string email {get; set;}
				
			/// 
			public string userName {get; set;}
				
			/// 
			public string exclude {get; set;}
				
			/// 
			public string folderIds {get; set;}
				
			/// 
			public string folderTypes {get; set;}
				
			/// 
			public string searchText {get; set;}
				
			/// This is the status type checked for in the `from_date`/`to_date` period. If `changed` is specified, then envelopes that changed status during the period are found. If for example, `created` is specified, then envelopes created during the period are found. Default is `changed`. \n\nPossible values are: Voided, Changed, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut and Processing. 
			public string fromToStatus {get; set;}
				
			/// 
			public string include {get; set;}
				
			/// 
			public string order {get; set;}
				
			/// 
			public string envelopeIds {get; set;}
				
			/// Optional date/time setting that specifies the date/time when the request stops for status changes for envelopes in the account. If no entry, the system uses the time of the call as the `to_date`. 
			public string toDate {get; set;}
				
			/// 
			public string userId {get; set;}
				
			/// The list of current statuses to include in the response. By default, all envelopes found are returned. If values are specified, then of the envelopes found, only those with the current status specified are returned in the results. \n\nPossible values are: Voided, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut and Processing. 
			public string status {get; set;}
				
			/// 
			public string startPosition {get; set;}
				
			/// If included in the query string, this is a comma separated list of envelope `transactionId`s. \n\nIf included in the `request_body`, this is a list of envelope `transactionId`s. \n\n### Note: `transactionId`s are only valid in the DocuSign system for seven days. 
			public string transactionIds {get; set;}
				
			/// 
			public string userFilter {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Gets status changes for one or more envelopes. Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5EnvelopesInformation</returns>
        public EnvelopesInformation ListStatusChanges (string accountId, EnvelopesApi.ListStatusChangesOptions options = null)
        {
             ApiResponse<EnvelopesInformation> response = ListStatusChangesWithHttpInfo(accountId, options);
             return response.Data;
        }

        /// <summary>
        /// Gets status changes for one or more envelopes. Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of EnvelopesInformation</returns>
        public ApiResponse< EnvelopesInformation > ListStatusChangesWithHttpInfo (string accountId, EnvelopesApi.ListStatusChangesOptions options = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListStatusChanges");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes";
    
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
            
			
			if (options != null)
			{
				if (options.block != null) queryParams.Add("block", Configuration.ApiClient.ParameterToString(options.block)); // query parameter
				if (options.powerformids != null) queryParams.Add("powerformids", Configuration.ApiClient.ParameterToString(options.powerformids)); // query parameter
				if (options.orderBy != null) queryParams.Add("order_by", Configuration.ApiClient.ParameterToString(options.orderBy)); // query parameter
				if (options.intersectingFolderIds != null) queryParams.Add("intersecting_folder_ids", Configuration.ApiClient.ParameterToString(options.intersectingFolderIds)); // query parameter
				if (options.fromDate != null) queryParams.Add("from_date", Configuration.ApiClient.ParameterToString(options.fromDate)); // query parameter
				if (options.acStatus != null) queryParams.Add("ac_status", Configuration.ApiClient.ParameterToString(options.acStatus)); // query parameter
				if (options.count != null) queryParams.Add("count", Configuration.ApiClient.ParameterToString(options.count)); // query parameter
				if (options.customField != null) queryParams.Add("custom_field", Configuration.ApiClient.ParameterToString(options.customField)); // query parameter
				if (options.email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(options.email)); // query parameter
				if (options.userName != null) queryParams.Add("user_name", Configuration.ApiClient.ParameterToString(options.userName)); // query parameter
				if (options.exclude != null) queryParams.Add("exclude", Configuration.ApiClient.ParameterToString(options.exclude)); // query parameter
				if (options.folderIds != null) queryParams.Add("folder_ids", Configuration.ApiClient.ParameterToString(options.folderIds)); // query parameter
				if (options.folderTypes != null) queryParams.Add("folder_types", Configuration.ApiClient.ParameterToString(options.folderTypes)); // query parameter
				if (options.searchText != null) queryParams.Add("search_text", Configuration.ApiClient.ParameterToString(options.searchText)); // query parameter
				if (options.fromToStatus != null) queryParams.Add("from_to_status", Configuration.ApiClient.ParameterToString(options.fromToStatus)); // query parameter
				if (options.include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(options.include)); // query parameter
				if (options.order != null) queryParams.Add("order", Configuration.ApiClient.ParameterToString(options.order)); // query parameter
				if (options.envelopeIds != null) queryParams.Add("envelope_ids", Configuration.ApiClient.ParameterToString(options.envelopeIds)); // query parameter
				if (options.toDate != null) queryParams.Add("to_date", Configuration.ApiClient.ParameterToString(options.toDate)); // query parameter
				if (options.userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(options.userId)); // query parameter
				if (options.status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(options.status)); // query parameter
				if (options.startPosition != null) queryParams.Add("start_position", Configuration.ApiClient.ParameterToString(options.startPosition)); // query parameter
				if (options.transactionIds != null) queryParams.Add("transaction_ids", Configuration.ApiClient.ParameterToString(options.transactionIds)); // query parameter
				if (options.userFilter != null) queryParams.Add("user_filter", Configuration.ApiClient.ParameterToString(options.userFilter)); // query parameter
				
			}

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListStatusChanges: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListStatusChanges: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopesInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopesInformation) Configuration.ApiClient.Deserialize(response, typeof(EnvelopesInformation)));
            
        }
    
        /// <summary>
        /// Gets status changes for one or more envelopes. Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of EnvelopesInformation</returns>
        public async System.Threading.Tasks.Task<EnvelopesInformation> ListStatusChangesAsync (string accountId, EnvelopesApi.ListStatusChangesOptions options = null)
        {
             ApiResponse<EnvelopesInformation> response = await ListStatusChangesAsyncWithHttpInfo(accountId, options);
             return response.Data;

        }

        /// <summary>
        /// Gets status changes for one or more envelopes. Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.\n\n### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.\n\nGetting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.\n\n### Request Envelope Status Notes ###\n\nThe REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \&quot;any status change\&quot; instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &amp;mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.\n\nTo avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.\n\nFor example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \&quot;`Created`,`Sent`\&quot;, DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.\n\nClient applications should check that the statuses they are requesting make sense for a given status qualifier.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (EnvelopesInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopesInformation>> ListStatusChangesAsyncWithHttpInfo (string accountId, EnvelopesApi.ListStatusChangesOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListStatusChanges");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes";
    
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
            

						
			if (options != null)
			{
				if (options.block != null) queryParams.Add("block", Configuration.ApiClient.ParameterToString(options.block)); // query parameter
				if (options.powerformids != null) queryParams.Add("powerformids", Configuration.ApiClient.ParameterToString(options.powerformids)); // query parameter
				if (options.orderBy != null) queryParams.Add("order_by", Configuration.ApiClient.ParameterToString(options.orderBy)); // query parameter
				if (options.intersectingFolderIds != null) queryParams.Add("intersecting_folder_ids", Configuration.ApiClient.ParameterToString(options.intersectingFolderIds)); // query parameter
				if (options.fromDate != null) queryParams.Add("from_date", Configuration.ApiClient.ParameterToString(options.fromDate)); // query parameter
				if (options.acStatus != null) queryParams.Add("ac_status", Configuration.ApiClient.ParameterToString(options.acStatus)); // query parameter
				if (options.count != null) queryParams.Add("count", Configuration.ApiClient.ParameterToString(options.count)); // query parameter
				if (options.customField != null) queryParams.Add("custom_field", Configuration.ApiClient.ParameterToString(options.customField)); // query parameter
				if (options.email != null) queryParams.Add("email", Configuration.ApiClient.ParameterToString(options.email)); // query parameter
				if (options.userName != null) queryParams.Add("user_name", Configuration.ApiClient.ParameterToString(options.userName)); // query parameter
				if (options.exclude != null) queryParams.Add("exclude", Configuration.ApiClient.ParameterToString(options.exclude)); // query parameter
				if (options.folderIds != null) queryParams.Add("folder_ids", Configuration.ApiClient.ParameterToString(options.folderIds)); // query parameter
				if (options.folderTypes != null) queryParams.Add("folder_types", Configuration.ApiClient.ParameterToString(options.folderTypes)); // query parameter
				if (options.searchText != null) queryParams.Add("search_text", Configuration.ApiClient.ParameterToString(options.searchText)); // query parameter
				if (options.fromToStatus != null) queryParams.Add("from_to_status", Configuration.ApiClient.ParameterToString(options.fromToStatus)); // query parameter
				if (options.include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(options.include)); // query parameter
				if (options.order != null) queryParams.Add("order", Configuration.ApiClient.ParameterToString(options.order)); // query parameter
				if (options.envelopeIds != null) queryParams.Add("envelope_ids", Configuration.ApiClient.ParameterToString(options.envelopeIds)); // query parameter
				if (options.toDate != null) queryParams.Add("to_date", Configuration.ApiClient.ParameterToString(options.toDate)); // query parameter
				if (options.userId != null) queryParams.Add("user_id", Configuration.ApiClient.ParameterToString(options.userId)); // query parameter
				if (options.status != null) queryParams.Add("status", Configuration.ApiClient.ParameterToString(options.status)); // query parameter
				if (options.startPosition != null) queryParams.Add("start_position", Configuration.ApiClient.ParameterToString(options.startPosition)); // query parameter
				if (options.transactionIds != null) queryParams.Add("transaction_ids", Configuration.ApiClient.ParameterToString(options.transactionIds)); // query parameter
				if (options.userFilter != null) queryParams.Add("user_filter", Configuration.ApiClient.ParameterToString(options.userFilter)); // query parameter
				
			}
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListStatusChanges: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListStatusChanges: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopesInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopesInformation) Configuration.ApiClient.Deserialize(response, typeof(EnvelopesInformation)));
            
        }
        
		
		
        /// <summary>
        /// Creates an envelope. Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
		public class CreateEnvelopeOptions
		{
				
			/// 
			public string cdseMode {get; set;}
				
			/// When set to **true**, merges template roles and remove empty recipients when you create an envelope with multiple templates. 
			public string mergeRolesOnDraft {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Creates an envelope. Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeDefinition">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5EnvelopeSummary</returns>
        public EnvelopeSummary CreateEnvelope (string accountId, EnvelopeDefinition envelopeDefinition, EnvelopesApi.CreateEnvelopeOptions options = null)
        {
             ApiResponse<EnvelopeSummary> response = CreateEnvelopeWithHttpInfo(accountId, envelopeDefinition, options);
             return response.Data;
        }

        /// <summary>
        /// Creates an envelope. Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeDefinition">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of EnvelopeSummary</returns>
        public ApiResponse< EnvelopeSummary > CreateEnvelopeWithHttpInfo (string accountId, EnvelopeDefinition envelopeDefinition, EnvelopesApi.CreateEnvelopeOptions options = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateEnvelope");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes";
    
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
            
			
			if (options != null)
			{
				if (options.cdseMode != null) queryParams.Add("cdse_mode", Configuration.ApiClient.ParameterToString(options.cdseMode)); // query parameter
				if (options.mergeRolesOnDraft != null) queryParams.Add("merge_roles_on_draft", Configuration.ApiClient.ParameterToString(options.mergeRolesOnDraft)); // query parameter
				
			}

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEnvelope: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEnvelope: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopeSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeSummary) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeSummary)));
            
        }
    
        /// <summary>
        /// Creates an envelope. Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeDefinition">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of EnvelopeSummary</returns>
        public async System.Threading.Tasks.Task<EnvelopeSummary> CreateEnvelopeAsync (string accountId, EnvelopeDefinition envelopeDefinition, EnvelopesApi.CreateEnvelopeOptions options = null)
        {
             ApiResponse<EnvelopeSummary> response = await CreateEnvelopeAsyncWithHttpInfo(accountId, envelopeDefinition, options);
             return response.Data;

        }

        /// <summary>
        /// Creates an envelope. Creates an envelope. \n\nUsing this function you can:\n* Create an envelope and send it.\n* Create an envelope from an existing template and send it.\n\nIn either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the `status` property in the request to `created` instead of `sent`.\n\n### Send an Envelope or Create a Draft Envelope\n\nThis is a multi-part/form request.\n\nEnvelope Event Notification: `eventNotification` is an optional property that specifies a set of envelope and recipient status codes, a URL, and some other options. When the envelope or recipient status changes to one of the specified status codes, DocuSign sends a message containing the updated status to the specified URL.\n\n### Note: DocuSign Connect must be enabled to use `eventNotification`, but Connect does not need to be configured for the account since the configuration is done for each envelope.\n\n### Send an Envelope from a Template\n\nWhen you create an envelope using a `templateId`, the `recipients` structure is used to assign recipients to template roles via the `roleName` property, override recipient settings that have been specified in the template and set values for tab fields that were defined in the template.\n\nWhen a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message is used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. If an email subject or message is entered before adding or applying a locked template, the email subject and message is overwritten with the email subject and message from the locked template.\n\n**Composite Templates**:\n\nYou can add Composite Templates structure to the  to create envelopes from a combination of DocuSign templates and PDF forms. The basic envelope remains the same, while the Composite Template adds new document and template overlays into the envelope. There can be any number of Composite Template structures in the envelope.\n\nEach Composite Template consists of server templates, inline templates, PDF Metadata templates, and documents.\n\n* Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.\n* Server Templates are server-side templates stored on the DocuSign server. If supplied they are overlaid into the envelope in the order of their Sequence value.\n* Inline Templates provide the container to pass inline XML properties. Inline templates allow you to add documents and, for PDF documents, transform the PDF fields into DocuSign tabs. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.\n* PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat&#39;s XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied the PDF meta data template will be overlaid into the envelope in the order of their Sequence value.\n* Document objects are optional structures that provide a container to pass in a document or form. If this object is not passed, the composite template inherits the first document it finds from some other server template or inline template, starting with the lowest sequence value (discussed below).\n\nIf there are multiple composite templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:\n\n```\n   --5cd3320a-5aac-4453-b3a4-cbb52a4cba5d\n\n   Content-Type: application/pdf\n\n   Content-Disposition: file; filename=\&quot;eula.pdf\&quot;; documentId=1; compositeTemplateId=\&quot;1\&quot;\n\n   Content-Transfer-Encoding: base64\n```\n\nAcrobat form objects are only extrapolated from the document object. DocuSign does not derive Acrobat form properties from server templates or inline templates. To instruct DocuSign to extrapolate objects from the Acrobat form, set `transformPdfFields` to \&quot;true\&quot; for the document. See the Transform PDF Fields section for more information about how fields are transformed into DocuSign tabs.\n\n*Sequence*\n\nEach type of template has a sequence property, which enables the templates to be over-laid in a particular order. This is significant because \&quot;last-out\&quot; wins in cases of the same property being specified in multiple places in the method schema.\n\n**Merge Recipient Roles for Draft Envelopes**\n\nWhen an envelope with multiple templates is sent, the recipients from the templates are merged according to template roles and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.\n\nTo prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.\n\n### Note: DocuSign recommends that the merge roles query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.\n\n**Template Email Subject Merge Fields**\n\nThis provides the ability to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.\n\nThe merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.\n\nBoth the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.\n\nIf merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.\n\n* To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_UserName]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_UserName]], Please sign this NDA\&quot;,`\n\n* To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:\n\n   [[&lt;roleName&gt;_Email]]\n\n   Example:\n\n   `\&quot;emailSubject\&quot;:\&quot;[[Signer 1_Email]], Please sign this NDA\&quot;,`\n\nIn both cases the &lt;roleName&gt; is the recipient’s `roleName` in the template.\n\nFor cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[&lt;roleName&gt;_UserName]] or [[&lt;roleName&gt;_Email]] is shown in the email subject.\n\n*Rules for determining the `brandId` used in an envelope*\n\nThe following rules are used to determine the `brandId` used in an envelope:\n\n* If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope.\n* If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope.\n* In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used.\n* For envelopes that do not meet any of the previous rules, the account&#39;s default signing brand is used in the envelope.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeDefinition">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (EnvelopeSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopeSummary>> CreateEnvelopeAsyncWithHttpInfo (string accountId, EnvelopeDefinition envelopeDefinition, EnvelopesApi.CreateEnvelopeOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateEnvelope");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes";
    
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
            

						
			if (options != null)
			{
				if (options.cdseMode != null) queryParams.Add("cdse_mode", Configuration.ApiClient.ParameterToString(options.cdseMode)); // query parameter
				if (options.mergeRolesOnDraft != null) queryParams.Add("merge_roles_on_draft", Configuration.ApiClient.ParameterToString(options.mergeRolesOnDraft)); // query parameter
				
			}
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEnvelope: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEnvelope: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopeSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeSummary) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeSummary)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the envelope status for the specified envelopes. Retrieves the envelope status for the specified envelopes.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeIdsRequest">TBD Description</param>
		/// <returns>5EnvelopesInformation</returns>
        public EnvelopesInformation ListStatus (string accountId, EnvelopeIdsRequest envelopeIdsRequest)
        {
             ApiResponse<EnvelopesInformation> response = ListStatusWithHttpInfo(accountId, envelopeIdsRequest);
             return response.Data;
        }

        /// <summary>
        /// Gets the envelope status for the specified envelopes. Retrieves the envelope status for the specified envelopes.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeIdsRequest">TBD Description</param>
		/// <returns>6ApiResponse of EnvelopesInformation</returns>
        public ApiResponse< EnvelopesInformation > ListStatusWithHttpInfo (string accountId, EnvelopeIdsRequest envelopeIdsRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListStatus");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/status";
    
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
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeIdsRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopesInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopesInformation) Configuration.ApiClient.Deserialize(response, typeof(EnvelopesInformation)));
            
        }
    
        /// <summary>
        /// Gets the envelope status for the specified envelopes. Retrieves the envelope status for the specified envelopes.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeIdsRequest">TBD Description</param>
		/// <returns>7Task of EnvelopesInformation</returns>
        public async System.Threading.Tasks.Task<EnvelopesInformation> ListStatusAsync (string accountId, EnvelopeIdsRequest envelopeIdsRequest)
        {
             ApiResponse<EnvelopesInformation> response = await ListStatusAsyncWithHttpInfo(accountId, envelopeIdsRequest);
             return response.Data;

        }

        /// <summary>
        /// Gets the envelope status for the specified envelopes. Retrieves the envelope status for the specified envelopes.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="envelopeIdsRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (EnvelopesInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopesInformation>> ListStatusAsyncWithHttpInfo (string accountId, EnvelopeIdsRequest envelopeIdsRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListStatus");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/status";
    
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
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeIdsRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListStatus: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopesInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopesInformation) Configuration.ApiClient.Deserialize(response, typeof(EnvelopesInformation)));
            
        }
        
		
		
        /// <summary>
        /// Gets the status of a envelope. Retrieves the overall status for the specified envelope.
        /// </summary>
		public class GetEnvelopeOptions
		{
				
			/// 
			public string include {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Gets the status of a envelope. Retrieves the overall status for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5Envelope</returns>
        public Envelope GetEnvelope (string accountId, string envelopeId, EnvelopesApi.GetEnvelopeOptions options = null)
        {
             ApiResponse<Envelope> response = GetEnvelopeWithHttpInfo(accountId, envelopeId, options);
             return response.Data;
        }

        /// <summary>
        /// Gets the status of a envelope. Retrieves the overall status for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of Envelope</returns>
        public ApiResponse< Envelope > GetEnvelopeWithHttpInfo (string accountId, string envelopeId, EnvelopesApi.GetEnvelopeOptions options = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetEnvelope");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetEnvelope");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			if (options != null)
			{
				if (options.include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(options.include)); // query parameter
				
			}

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetEnvelope: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEnvelope: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Envelope>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Envelope) Configuration.ApiClient.Deserialize(response, typeof(Envelope)));
            
        }
    
        /// <summary>
        /// Gets the status of a envelope. Retrieves the overall status for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of Envelope</returns>
        public async System.Threading.Tasks.Task<Envelope> GetEnvelopeAsync (string accountId, string envelopeId, EnvelopesApi.GetEnvelopeOptions options = null)
        {
             ApiResponse<Envelope> response = await GetEnvelopeAsyncWithHttpInfo(accountId, envelopeId, options);
             return response.Data;

        }

        /// <summary>
        /// Gets the status of a envelope. Retrieves the overall status for the specified envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (Envelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Envelope>> GetEnvelopeAsyncWithHttpInfo (string accountId, string envelopeId, EnvelopesApi.GetEnvelopeOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetEnvelope");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetEnvelope");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			if (options != null)
			{
				if (options.include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(options.include)); // query parameter
				
			}
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetEnvelope: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEnvelope: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Envelope>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Envelope) Configuration.ApiClient.Deserialize(response, typeof(Envelope)));
            
        }
        
		
		
        /// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </summary>
		public class UpdateOptions
		{
				
			/// When set to **true**, sends the specified envelope again. 
			public string resendEnvelope {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelope">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5EnvelopeUpdateSummary</returns>
        public EnvelopeUpdateSummary Update (string accountId, string envelopeId, Envelope envelope, EnvelopesApi.UpdateOptions options = null)
        {
             ApiResponse<EnvelopeUpdateSummary> response = UpdateWithHttpInfo(accountId, envelopeId, envelope, options);
             return response.Data;
        }

        /// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelope">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of EnvelopeUpdateSummary</returns>
        public ApiResponse< EnvelopeUpdateSummary > UpdateWithHttpInfo (string accountId, string envelopeId, Envelope envelope, EnvelopesApi.UpdateOptions options = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Update");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling Update");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			if (options != null)
			{
				if (options.resendEnvelope != null) queryParams.Add("resend_envelope", Configuration.ApiClient.ParameterToString(options.resendEnvelope)); // query parameter
				
			}

            
            
            postBody = Configuration.ApiClient.Serialize(envelope); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopeUpdateSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeUpdateSummary) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeUpdateSummary)));
            
        }
    
        /// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelope">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of EnvelopeUpdateSummary</returns>
        public async System.Threading.Tasks.Task<EnvelopeUpdateSummary> UpdateAsync (string accountId, string envelopeId, Envelope envelope, EnvelopesApi.UpdateOptions options = null)
        {
             ApiResponse<EnvelopeUpdateSummary> response = await UpdateAsyncWithHttpInfo(accountId, envelopeId, envelope, options);
             return response.Data;

        }

        /// <summary>
        /// Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft The Put Envelopes endpoint provides the following functionality:\n\n* Sends the specified single draft envelope.\nAdd {\&quot;status\&quot;:\&quot;sent\&quot;} to the request body to send the envelope.\n\n* Voids the specified in-process envelope.\nAdd {\&quot;status\&quot;:\&quot;voided\&quot;, \&quot;voidedReason\&quot;:\&quot;The reason for voiding the envelope\&quot;} to the request body to void the envelope.\n\n* Replaces the current email subject and message for a draft envelope.\nAdd {\&quot;emailSubject\&quot;:\&quot;subject\&quot;,  \&quot;emailBlurb\&quot;:\&quot;message\&quot;}  to the request body to modify the subject and message.\n\n* Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system.\nAdd {\&quot;purgeState\&quot;:\&quot;purge type\&quot;} to the request body.\n\n*Additional information on purging documents*\n\nThe purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).\n\n### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period. \n### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents. \n### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.\n\nWhen the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.\n\nIf `purgeState=\&quot;documents_queued\&quot;` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \&quot;documents_and_metadata_queued\&quot;` is used in the request, then the documents, attachments, and tabs are deleted.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelope">TBD Description</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (EnvelopeUpdateSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopeUpdateSummary>> UpdateAsyncWithHttpInfo (string accountId, string envelopeId, Envelope envelope, EnvelopesApi.UpdateOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Update");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling Update");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			if (options != null)
			{
				if (options.resendEnvelope != null) queryParams.Add("resend_envelope", Configuration.ApiClient.ParameterToString(options.resendEnvelope)); // query parameter
				
			}
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelope); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopeUpdateSummary>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeUpdateSummary) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeUpdateSummary)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the envelope audit events for an envelope. Gets the envelope audit events for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5EnvelopeAuditEventResponse</returns>
        public EnvelopeAuditEventResponse ListAuditEvents (string accountId, string envelopeId)
        {
             ApiResponse<EnvelopeAuditEventResponse> response = ListAuditEventsWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Gets the envelope audit events for an envelope. Gets the envelope audit events for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of EnvelopeAuditEventResponse</returns>
        public ApiResponse< EnvelopeAuditEventResponse > ListAuditEventsWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListAuditEvents");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListAuditEvents");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/audit_events";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListAuditEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListAuditEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopeAuditEventResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeAuditEventResponse) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeAuditEventResponse)));
            
        }
    
        /// <summary>
        /// Gets the envelope audit events for an envelope. Gets the envelope audit events for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of EnvelopeAuditEventResponse</returns>
        public async System.Threading.Tasks.Task<EnvelopeAuditEventResponse> ListAuditEventsAsync (string accountId, string envelopeId)
        {
             ApiResponse<EnvelopeAuditEventResponse> response = await ListAuditEventsAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Gets the envelope audit events for an envelope. Gets the envelope audit events for the specified envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (EnvelopeAuditEventResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopeAuditEventResponse>> ListAuditEventsAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListAuditEvents");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListAuditEvents");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/audit_events";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListAuditEvents: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListAuditEvents: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopeAuditEventResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeAuditEventResponse) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeAuditEventResponse)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the custom field information for the specified envelope. Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5CustomFieldsEnvelope</returns>
        public CustomFieldsEnvelope ListCustomFields (string accountId, string envelopeId)
        {
             ApiResponse<CustomFieldsEnvelope> response = ListCustomFieldsWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Gets the custom field information for the specified envelope. Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of CustomFieldsEnvelope</returns>
        public ApiResponse< CustomFieldsEnvelope > ListCustomFieldsWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListCustomFields");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CustomFieldsEnvelope>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFieldsEnvelope) Configuration.ApiClient.Deserialize(response, typeof(CustomFieldsEnvelope)));
            
        }
    
        /// <summary>
        /// Gets the custom field information for the specified envelope. Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of CustomFieldsEnvelope</returns>
        public async System.Threading.Tasks.Task<CustomFieldsEnvelope> ListCustomFieldsAsync (string accountId, string envelopeId)
        {
             ApiResponse<CustomFieldsEnvelope> response = await ListCustomFieldsAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Gets the custom field information for the specified envelope. Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (CustomFieldsEnvelope)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFieldsEnvelope>> ListCustomFieldsAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListCustomFields");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CustomFieldsEnvelope>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFieldsEnvelope) Configuration.ApiClient.Deserialize(response, typeof(CustomFieldsEnvelope)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates envelope custom fields in an envelope. Updates the envelope custom fields in draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>5CustomFields</returns>
        public CustomFields UpdateCustomFields (string accountId, string envelopeId, CustomFields customFields)
        {
             ApiResponse<CustomFields> response = UpdateCustomFieldsWithHttpInfo(accountId, envelopeId, customFields);
             return response.Data;
        }

        /// <summary>
        /// Updates envelope custom fields in an envelope. Updates the envelope custom fields in draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>6ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > UpdateCustomFieldsWithHttpInfo (string accountId, string envelopeId, CustomFields customFields)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateCustomFields");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(customFields); // http body (model) parameter
            

            
    
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
        /// Updates envelope custom fields in an envelope. Updates the envelope custom fields in draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>7Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> UpdateCustomFieldsAsync (string accountId, string envelopeId, CustomFields customFields)
        {
             ApiResponse<CustomFields> response = await UpdateCustomFieldsAsyncWithHttpInfo(accountId, envelopeId, customFields);
             return response.Data;

        }

        /// <summary>
        /// Updates envelope custom fields in an envelope. Updates the envelope custom fields in draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>8Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> UpdateCustomFieldsAsyncWithHttpInfo (string accountId, string envelopeId, CustomFields customFields)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateCustomFields");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(customFields); // http body (model) parameter
            

            

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
        /// Updates envelope custom fields for an envelope. Updates the envelope custom fields for draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>5CustomFields</returns>
        public CustomFields CreateCustomFields (string accountId, string envelopeId, CustomFields customFields)
        {
             ApiResponse<CustomFields> response = CreateCustomFieldsWithHttpInfo(accountId, envelopeId, customFields);
             return response.Data;
        }

        /// <summary>
        /// Updates envelope custom fields for an envelope. Updates the envelope custom fields for draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>6ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > CreateCustomFieldsWithHttpInfo (string accountId, string envelopeId, CustomFields customFields)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateCustomFields");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(customFields); // http body (model) parameter
            

            
    
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
        /// Updates envelope custom fields for an envelope. Updates the envelope custom fields for draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>7Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> CreateCustomFieldsAsync (string accountId, string envelopeId, CustomFields customFields)
        {
             ApiResponse<CustomFields> response = await CreateCustomFieldsAsyncWithHttpInfo(accountId, envelopeId, customFields);
             return response.Data;

        }

        /// <summary>
        /// Updates envelope custom fields for an envelope. Updates the envelope custom fields for draft and in-process envelopes.\n\nEach custom field used in an envelope must have a unique name.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>8Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> CreateCustomFieldsAsyncWithHttpInfo (string accountId, string envelopeId, CustomFields customFields)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateCustomFields");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(customFields); // http body (model) parameter
            

            

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
        /// Deletes envelope custom fields for draft and in-process envelopes. Deletes envelope custom fields for draft and in-process envelopes.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>5CustomFields</returns>
        public CustomFields DeleteCustomFields (string accountId, string envelopeId, CustomFields customFields)
        {
             ApiResponse<CustomFields> response = DeleteCustomFieldsWithHttpInfo(accountId, envelopeId, customFields);
             return response.Data;
        }

        /// <summary>
        /// Deletes envelope custom fields for draft and in-process envelopes. Deletes envelope custom fields for draft and in-process envelopes.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>6ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > DeleteCustomFieldsWithHttpInfo (string accountId, string envelopeId, CustomFields customFields)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteCustomFields");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(customFields); // http body (model) parameter
            

            
    
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
        /// Deletes envelope custom fields for draft and in-process envelopes. Deletes envelope custom fields for draft and in-process envelopes.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>7Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> DeleteCustomFieldsAsync (string accountId, string envelopeId, CustomFields customFields)
        {
             ApiResponse<CustomFields> response = await DeleteCustomFieldsAsyncWithHttpInfo(accountId, envelopeId, customFields);
             return response.Data;

        }

        /// <summary>
        /// Deletes envelope custom fields for draft and in-process envelopes. Deletes envelope custom fields for draft and in-process envelopes.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="customFields">TBD Description</param>
		/// <returns>8Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> DeleteCustomFieldsAsyncWithHttpInfo (string accountId, string envelopeId, CustomFields customFields)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteCustomFields");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(customFields); // http body (model) parameter
            

            

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
        /// Gets a list of envelope documents. Retrieves a list of documents associated with the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5EnvelopeDocumentsResult</returns>
        public EnvelopeDocumentsResult ListDocuments (string accountId, string envelopeId)
        {
             ApiResponse<EnvelopeDocumentsResult> response = ListDocumentsWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of envelope documents. Retrieves a list of documents associated with the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of EnvelopeDocumentsResult</returns>
        public ApiResponse< EnvelopeDocumentsResult > ListDocumentsWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListDocuments");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopeDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeDocumentsResult)));
            
        }
    
        /// <summary>
        /// Gets a list of envelope documents. Retrieves a list of documents associated with the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of EnvelopeDocumentsResult</returns>
        public async System.Threading.Tasks.Task<EnvelopeDocumentsResult> ListDocumentsAsync (string accountId, string envelopeId)
        {
             ApiResponse<EnvelopeDocumentsResult> response = await ListDocumentsAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of envelope documents. Retrieves a list of documents associated with the specified envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (EnvelopeDocumentsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopeDocumentsResult>> ListDocumentsAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListDocuments");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopeDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeDocumentsResult)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Adds one or more documents to an existing envelope document. Adds one or more documents to an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>5EnvelopeDocumentsResult</returns>
        public EnvelopeDocumentsResult UpdateDocuments (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition)
        {
             ApiResponse<EnvelopeDocumentsResult> response = UpdateDocumentsWithHttpInfo(accountId, envelopeId, envelopeDefinition);
             return response.Data;
        }

        /// <summary>
        /// Adds one or more documents to an existing envelope document. Adds one or more documents to an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>6ApiResponse of EnvelopeDocumentsResult</returns>
        public ApiResponse< EnvelopeDocumentsResult > UpdateDocumentsWithHttpInfo (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateDocuments");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopeDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeDocumentsResult)));
            
        }
    
        /// <summary>
        /// Adds one or more documents to an existing envelope document. Adds one or more documents to an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>7Task of EnvelopeDocumentsResult</returns>
        public async System.Threading.Tasks.Task<EnvelopeDocumentsResult> UpdateDocumentsAsync (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition)
        {
             ApiResponse<EnvelopeDocumentsResult> response = await UpdateDocumentsAsyncWithHttpInfo(accountId, envelopeId, envelopeDefinition);
             return response.Data;

        }

        /// <summary>
        /// Adds one or more documents to an existing envelope document. Adds one or more documents to an existing envelope document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>8Task of ApiResponse (EnvelopeDocumentsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopeDocumentsResult>> UpdateDocumentsAsyncWithHttpInfo (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateDocuments");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopeDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeDocumentsResult)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes documents from a draft envelope. Deletes one or more documents from an existing draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>5EnvelopeDocumentsResult</returns>
        public EnvelopeDocumentsResult DeleteDocuments (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition)
        {
             ApiResponse<EnvelopeDocumentsResult> response = DeleteDocumentsWithHttpInfo(accountId, envelopeId, envelopeDefinition);
             return response.Data;
        }

        /// <summary>
        /// Deletes documents from a draft envelope. Deletes one or more documents from an existing draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>6ApiResponse of EnvelopeDocumentsResult</returns>
        public ApiResponse< EnvelopeDocumentsResult > DeleteDocumentsWithHttpInfo (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocuments");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EnvelopeDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeDocumentsResult)));
            
        }
    
        /// <summary>
        /// Deletes documents from a draft envelope. Deletes one or more documents from an existing draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>7Task of EnvelopeDocumentsResult</returns>
        public async System.Threading.Tasks.Task<EnvelopeDocumentsResult> DeleteDocumentsAsync (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition)
        {
             ApiResponse<EnvelopeDocumentsResult> response = await DeleteDocumentsAsyncWithHttpInfo(accountId, envelopeId, envelopeDefinition);
             return response.Data;

        }

        /// <summary>
        /// Deletes documents from a draft envelope. Deletes one or more documents from an existing draft envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="envelopeDefinition">TBD Description</param>
		/// <returns>8Task of ApiResponse (EnvelopeDocumentsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnvelopeDocumentsResult>> DeleteDocumentsAsyncWithHttpInfo (string accountId, string envelopeId, EnvelopeDefinition envelopeDefinition)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocuments");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteDocuments");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(envelopeDefinition); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteDocuments: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EnvelopeDocumentsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnvelopeDocumentsResult) Configuration.ApiClient.Deserialize(response, typeof(EnvelopeDocumentsResult)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets a document from an envelope. Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.\n\nYou can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted. \n\nTo retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`.\n/accounts/{accountId}/envelopes/{envelopeId}/documents/combined
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>5Stream</returns>
        public Stream GetDocument (string accountId, string envelopeId, string documentId)
        {
             ApiResponse<Stream> response = GetDocumentWithHttpInfo(accountId, envelopeId, documentId);
             return response.Data;
        }

        /// <summary>
        /// Gets a document from an envelope. Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.\n\nYou can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted. \n\nTo retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`.\n/accounts/{accountId}/envelopes/{envelopeId}/documents/combined
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>6ApiResponse of Stream</returns>
        public ApiResponse< Stream > GetDocumentWithHttpInfo (string accountId, string envelopeId, string documentId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetDocument");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetDocument");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Gets a document from an envelope. Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.\n\nYou can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted. \n\nTo retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`.\n/accounts/{accountId}/envelopes/{envelopeId}/documents/combined
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>7Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> GetDocumentAsync (string accountId, string envelopeId, string documentId)
        {
             ApiResponse<Stream> response = await GetDocumentAsyncWithHttpInfo(accountId, envelopeId, documentId);
             return response.Data;

        }

        /// <summary>
        /// Gets a document from an envelope. Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.\n\nYou can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted. \n\nTo retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`.\n/accounts/{accountId}/envelopes/{envelopeId}/documents/combined
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>8Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> GetDocumentAsyncWithHttpInfo (string accountId, string envelopeId, string documentId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetDocument");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetDocument");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Gets the custom document fields from an  existing envelope document. Retrieves the custom document field information from an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>5DocumentFieldsInformation</returns>
        public DocumentFieldsInformation ListDocumentFields (string accountId, string envelopeId, string documentId)
        {
             ApiResponse<DocumentFieldsInformation> response = ListDocumentFieldsWithHttpInfo(accountId, envelopeId, documentId);
             return response.Data;
        }

        /// <summary>
        /// Gets the custom document fields from an  existing envelope document. Retrieves the custom document field information from an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>6ApiResponse of DocumentFieldsInformation</returns>
        public ApiResponse< DocumentFieldsInformation > ListDocumentFieldsWithHttpInfo (string accountId, string envelopeId, string documentId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListDocumentFields");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListDocumentFields");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ListDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Gets the custom document fields from an  existing envelope document. Retrieves the custom document field information from an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>7Task of DocumentFieldsInformation</returns>
        public async System.Threading.Tasks.Task<DocumentFieldsInformation> ListDocumentFieldsAsync (string accountId, string envelopeId, string documentId)
        {
             ApiResponse<DocumentFieldsInformation> response = await ListDocumentFieldsAsyncWithHttpInfo(accountId, envelopeId, documentId);
             return response.Data;

        }

        /// <summary>
        /// Gets the custom document fields from an  existing envelope document. Retrieves the custom document field information from an existing envelope document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>8Task of ApiResponse (DocumentFieldsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> ListDocumentFieldsAsyncWithHttpInfo (string accountId, string envelopeId, string documentId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListDocumentFields");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListDocumentFields");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ListDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Updates existing custom document fields in an existing envelope document. Updates existing custom document fields in an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>5DocumentFieldsInformation</returns>
        public DocumentFieldsInformation UpdateDocumentFields (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = UpdateDocumentFieldsWithHttpInfo(accountId, envelopeId, documentId, documentFieldsInformation);
             return response.Data;
        }

        /// <summary>
        /// Updates existing custom document fields in an existing envelope document. Updates existing custom document fields in an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>6ApiResponse of DocumentFieldsInformation</returns>
        public ApiResponse< DocumentFieldsInformation > UpdateDocumentFieldsWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateDocumentFields");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateDocumentFields");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling UpdateDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Updates existing custom document fields in an existing envelope document. Updates existing custom document fields in an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>7Task of DocumentFieldsInformation</returns>
        public async System.Threading.Tasks.Task<DocumentFieldsInformation> UpdateDocumentFieldsAsync (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = await UpdateDocumentFieldsAsyncWithHttpInfo(accountId, envelopeId, documentId, documentFieldsInformation);
             return response.Data;

        }

        /// <summary>
        /// Updates existing custom document fields in an existing envelope document. Updates existing custom document fields in an existing envelope document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (DocumentFieldsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> UpdateDocumentFieldsAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateDocumentFields");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateDocumentFields");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling UpdateDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Creates custom document fields in an existing envelope document. Creates custom document fields in an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>5DocumentFieldsInformation</returns>
        public DocumentFieldsInformation CreateDocumentFields (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = CreateDocumentFieldsWithHttpInfo(accountId, envelopeId, documentId, documentFieldsInformation);
             return response.Data;
        }

        /// <summary>
        /// Creates custom document fields in an existing envelope document. Creates custom document fields in an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>6ApiResponse of DocumentFieldsInformation</returns>
        public ApiResponse< DocumentFieldsInformation > CreateDocumentFieldsWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateDocumentFields");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateDocumentFields");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling CreateDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Creates custom document fields in an existing envelope document. Creates custom document fields in an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>7Task of DocumentFieldsInformation</returns>
        public async System.Threading.Tasks.Task<DocumentFieldsInformation> CreateDocumentFieldsAsync (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = await CreateDocumentFieldsAsyncWithHttpInfo(accountId, envelopeId, documentId, documentFieldsInformation);
             return response.Data;

        }

        /// <summary>
        /// Creates custom document fields in an existing envelope document. Creates custom document fields in an existing envelope document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (DocumentFieldsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> CreateDocumentFieldsAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateDocumentFields");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateDocumentFields");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling CreateDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Deletes custom document fields from an existing envelope document. Deletes custom document fields from an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>5DocumentFieldsInformation</returns>
        public DocumentFieldsInformation DeleteDocumentFields (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = DeleteDocumentFieldsWithHttpInfo(accountId, envelopeId, documentId, documentFieldsInformation);
             return response.Data;
        }

        /// <summary>
        /// Deletes custom document fields from an existing envelope document. Deletes custom document fields from an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>6ApiResponse of DocumentFieldsInformation</returns>
        public ApiResponse< DocumentFieldsInformation > DeleteDocumentFieldsWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocumentFields");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteDocumentFields");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Deletes custom document fields from an existing envelope document. Deletes custom document fields from an existing envelope document.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>7Task of DocumentFieldsInformation</returns>
        public async System.Threading.Tasks.Task<DocumentFieldsInformation> DeleteDocumentFieldsAsync (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
             ApiResponse<DocumentFieldsInformation> response = await DeleteDocumentFieldsAsyncWithHttpInfo(accountId, envelopeId, documentId, documentFieldsInformation);
             return response.Data;

        }

        /// <summary>
        /// Deletes custom document fields from an existing envelope document. Deletes custom document fields from an existing envelope document.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentFieldsInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (DocumentFieldsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentFieldsInformation>> DeleteDocumentFieldsAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentFieldsInformation documentFieldsInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocumentFields");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteDocumentFields");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentFields");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
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
        /// Deletes a page from a document in an envelope. Deletes a page from a document in an envelope based on the page number.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param>
		/// <returns>5</returns>
        public void DeleteDocumentPage (string accountId, string envelopeId, string documentId, string pageNumber)
        {
             DeleteDocumentPageWithHttpInfo(accountId, envelopeId, documentId, pageNumber);
        }

        /// <summary>
        /// Deletes a page from a document in an envelope. Deletes a page from a document in an envelope based on the page number.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param>
		/// <returns>6ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteDocumentPageWithHttpInfo (string accountId, string envelopeId, string documentId, string pageNumber)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocumentPage");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteDocumentPage");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentPage");
            
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling DeleteDocumentPage");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageNumber != null) pathParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // path parameter
            
			
			

            
            
            

            
    
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
        /// Deletes a page from a document in an envelope. Deletes a page from a document in an envelope based on the page number.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param>
		/// <returns>7Task of void</returns>
        public async System.Threading.Tasks.Task DeleteDocumentPageAsync (string accountId, string envelopeId, string documentId, string pageNumber)
        {
             await DeleteDocumentPageAsyncWithHttpInfo(accountId, envelopeId, documentId, pageNumber);

        }

        /// <summary>
        /// Deletes a page from a document in an envelope. Deletes a page from a document in an envelope based on the page number.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="pageNumber">The page number being accessed.</param>
		/// <returns>8Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteDocumentPageAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, string pageNumber)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteDocumentPage");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteDocumentPage");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteDocumentPage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null) throw new ApiException(400, "Missing required parameter 'pageNumber' when calling DeleteDocumentPage");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageNumber != null) pathParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // path parameter
            

						
			
			

            
            
            

            

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
        /// Gets the templates associated with a document in an existing envelope. Retrieves the templates associated with a document in the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>5TemplateInformation</returns>
        public TemplateInformation ListTemplatesForDocument (string accountId, string envelopeId, string documentId)
        {
             ApiResponse<TemplateInformation> response = ListTemplatesForDocumentWithHttpInfo(accountId, envelopeId, documentId);
             return response.Data;
        }

        /// <summary>
        /// Gets the templates associated with a document in an existing envelope. Retrieves the templates associated with a document in the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>6ApiResponse of TemplateInformation</returns>
        public ApiResponse< TemplateInformation > ListTemplatesForDocumentWithHttpInfo (string accountId, string envelopeId, string documentId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTemplatesForDocument");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListTemplatesForDocument");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ListTemplatesForDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListTemplatesForDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListTemplatesForDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateInformation) Configuration.ApiClient.Deserialize(response, typeof(TemplateInformation)));
            
        }
    
        /// <summary>
        /// Gets the templates associated with a document in an existing envelope. Retrieves the templates associated with a document in the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>7Task of TemplateInformation</returns>
        public async System.Threading.Tasks.Task<TemplateInformation> ListTemplatesForDocumentAsync (string accountId, string envelopeId, string documentId)
        {
             ApiResponse<TemplateInformation> response = await ListTemplatesForDocumentAsyncWithHttpInfo(accountId, envelopeId, documentId);
             return response.Data;

        }

        /// <summary>
        /// Gets the templates associated with a document in an existing envelope. Retrieves the templates associated with a document in the specified envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param>
		/// <returns>8Task of ApiResponse (TemplateInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateInformation>> ListTemplatesForDocumentAsyncWithHttpInfo (string accountId, string envelopeId, string documentId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTemplatesForDocument");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListTemplatesForDocument");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ListTemplatesForDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListTemplatesForDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListTemplatesForDocument: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateInformation) Configuration.ApiClient.Deserialize(response, typeof(TemplateInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Adds templates to a document in an  envelope. Adds templates to a document in the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>5DocumentTemplateList</returns>
        public DocumentTemplateList ApplyTemplateToDocument (string accountId, string envelopeId, string documentId, DocumentTemplateList documentTemplateList)
        {
             ApiResponse<DocumentTemplateList> response = ApplyTemplateToDocumentWithHttpInfo(accountId, envelopeId, documentId, documentTemplateList);
             return response.Data;
        }

        /// <summary>
        /// Adds templates to a document in an  envelope. Adds templates to a document in the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>6ApiResponse of DocumentTemplateList</returns>
        public ApiResponse< DocumentTemplateList > ApplyTemplateToDocumentWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentTemplateList documentTemplateList)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ApplyTemplateToDocument");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ApplyTemplateToDocument");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ApplyTemplateToDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentTemplateList); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ApplyTemplateToDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ApplyTemplateToDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DocumentTemplateList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTemplateList) Configuration.ApiClient.Deserialize(response, typeof(DocumentTemplateList)));
            
        }
    
        /// <summary>
        /// Adds templates to a document in an  envelope. Adds templates to a document in the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>7Task of DocumentTemplateList</returns>
        public async System.Threading.Tasks.Task<DocumentTemplateList> ApplyTemplateToDocumentAsync (string accountId, string envelopeId, string documentId, DocumentTemplateList documentTemplateList)
        {
             ApiResponse<DocumentTemplateList> response = await ApplyTemplateToDocumentAsyncWithHttpInfo(accountId, envelopeId, documentId, documentTemplateList);
             return response.Data;

        }

        /// <summary>
        /// Adds templates to a document in an  envelope. Adds templates to a document in the specified envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>8Task of ApiResponse (DocumentTemplateList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentTemplateList>> ApplyTemplateToDocumentAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, DocumentTemplateList documentTemplateList)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ApplyTemplateToDocument");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ApplyTemplateToDocument");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling ApplyTemplateToDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentTemplateList); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ApplyTemplateToDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ApplyTemplateToDocument: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentTemplateList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTemplateList) Configuration.ApiClient.Deserialize(response, typeof(DocumentTemplateList)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes a template from a document in an existing envelope. Deletes the specified template from a document in an existing envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>5</returns>
        public void DeleteTemplatesFromDocument (string accountId, string envelopeId, string documentId, string templateId)
        {
             DeleteTemplatesFromDocumentWithHttpInfo(accountId, envelopeId, documentId, templateId);
        }

        /// <summary>
        /// Deletes a template from a document in an existing envelope. Deletes the specified template from a document in an existing envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>6ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteTemplatesFromDocumentWithHttpInfo (string accountId, string envelopeId, string documentId, string templateId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteTemplatesFromDocument");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteTemplatesFromDocument");
            
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteTemplatesFromDocument");
            
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteTemplatesFromDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates/{templateId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteTemplatesFromDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTemplatesFromDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Deletes a template from a document in an existing envelope. Deletes the specified template from a document in an existing envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>7Task of void</returns>
        public async System.Threading.Tasks.Task DeleteTemplatesFromDocumentAsync (string accountId, string envelopeId, string documentId, string templateId)
        {
             await DeleteTemplatesFromDocumentAsyncWithHttpInfo(accountId, envelopeId, documentId, templateId);

        }

        /// <summary>
        /// Deletes a template from a document in an existing envelope. Deletes the specified template from a document in an existing envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="documentId">The ID of the document being accessed.</param><param name="templateId">The ID of the template being accessed.</param>
		/// <returns>8Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTemplatesFromDocumentAsyncWithHttpInfo (string accountId, string envelopeId, string documentId, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteTemplatesFromDocument");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteTemplatesFromDocument");
            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling DeleteTemplatesFromDocument");
            // verify the required parameter 'templateId' is set
            if (templateId == null) throw new ApiException(400, "Missing required parameter 'templateId' when calling DeleteTemplatesFromDocument");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates/{templateId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (documentId != null) pathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (templateId != null) pathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteTemplatesFromDocument: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTemplatesFromDocument: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the email setting overrides for an envelope. Retrieves the email override settings for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5EmailSettings</returns>
        public EmailSettings GetEmailSettings (string accountId, string envelopeId)
        {
             ApiResponse<EmailSettings> response = GetEmailSettingsWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Gets the email setting overrides for an envelope. Retrieves the email override settings for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of EmailSettings</returns>
        public ApiResponse< EmailSettings > GetEmailSettingsWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetEmailSettings");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetEmailSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetEmailSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSettings) Configuration.ApiClient.Deserialize(response, typeof(EmailSettings)));
            
        }
    
        /// <summary>
        /// Gets the email setting overrides for an envelope. Retrieves the email override settings for the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of EmailSettings</returns>
        public async System.Threading.Tasks.Task<EmailSettings> GetEmailSettingsAsync (string accountId, string envelopeId)
        {
             ApiResponse<EmailSettings> response = await GetEmailSettingsAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Gets the email setting overrides for an envelope. Retrieves the email override settings for the specified envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (EmailSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSettings>> GetEmailSettingsAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetEmailSettings");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetEmailSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetEmailSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEmailSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSettings) Configuration.ApiClient.Deserialize(response, typeof(EmailSettings)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates the email setting overrides for an envelope. Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.\n\nThis can also be used to delete an individual email override setting by using an empty string for the value to be deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>5EmailSettings</returns>
        public EmailSettings UpdateEmailSettings (string accountId, string envelopeId, EmailSettings emailSettings)
        {
             ApiResponse<EmailSettings> response = UpdateEmailSettingsWithHttpInfo(accountId, envelopeId, emailSettings);
             return response.Data;
        }

        /// <summary>
        /// Updates the email setting overrides for an envelope. Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.\n\nThis can also be used to delete an individual email override setting by using an empty string for the value to be deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>6ApiResponse of EmailSettings</returns>
        public ApiResponse< EmailSettings > UpdateEmailSettingsWithHttpInfo (string accountId, string envelopeId, EmailSettings emailSettings)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateEmailSettings");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateEmailSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(emailSettings); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateEmailSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEmailSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSettings) Configuration.ApiClient.Deserialize(response, typeof(EmailSettings)));
            
        }
    
        /// <summary>
        /// Updates the email setting overrides for an envelope. Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.\n\nThis can also be used to delete an individual email override setting by using an empty string for the value to be deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>7Task of EmailSettings</returns>
        public async System.Threading.Tasks.Task<EmailSettings> UpdateEmailSettingsAsync (string accountId, string envelopeId, EmailSettings emailSettings)
        {
             ApiResponse<EmailSettings> response = await UpdateEmailSettingsAsyncWithHttpInfo(accountId, envelopeId, emailSettings);
             return response.Data;

        }

        /// <summary>
        /// Updates the email setting overrides for an envelope. Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.\n\nThis can also be used to delete an individual email override setting by using an empty string for the value to be deleted.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>8Task of ApiResponse (EmailSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSettings>> UpdateEmailSettingsAsyncWithHttpInfo (string accountId, string envelopeId, EmailSettings emailSettings)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateEmailSettings");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateEmailSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(emailSettings); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateEmailSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateEmailSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSettings) Configuration.ApiClient.Deserialize(response, typeof(EmailSettings)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Adds email setting overrides to an envelope. Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>5EmailSettings</returns>
        public EmailSettings CreateEmailSettings (string accountId, string envelopeId, EmailSettings emailSettings)
        {
             ApiResponse<EmailSettings> response = CreateEmailSettingsWithHttpInfo(accountId, envelopeId, emailSettings);
             return response.Data;
        }

        /// <summary>
        /// Adds email setting overrides to an envelope. Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>6ApiResponse of EmailSettings</returns>
        public ApiResponse< EmailSettings > CreateEmailSettingsWithHttpInfo (string accountId, string envelopeId, EmailSettings emailSettings)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateEmailSettings");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateEmailSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(emailSettings); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEmailSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEmailSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSettings) Configuration.ApiClient.Deserialize(response, typeof(EmailSettings)));
            
        }
    
        /// <summary>
        /// Adds email setting overrides to an envelope. Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>7Task of EmailSettings</returns>
        public async System.Threading.Tasks.Task<EmailSettings> CreateEmailSettingsAsync (string accountId, string envelopeId, EmailSettings emailSettings)
        {
             ApiResponse<EmailSettings> response = await CreateEmailSettingsAsyncWithHttpInfo(accountId, envelopeId, emailSettings);
             return response.Data;

        }

        /// <summary>
        /// Adds email setting overrides to an envelope. Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.\n\n### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="emailSettings">TBD Description</param>
		/// <returns>8Task of ApiResponse (EmailSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSettings>> CreateEmailSettingsAsyncWithHttpInfo (string accountId, string envelopeId, EmailSettings emailSettings)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateEmailSettings");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateEmailSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(emailSettings); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEmailSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEmailSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSettings) Configuration.ApiClient.Deserialize(response, typeof(EmailSettings)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes the email setting overrides for an envelope. Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5EmailSettings</returns>
        public EmailSettings DeleteEmailSettings (string accountId, string envelopeId)
        {
             ApiResponse<EmailSettings> response = DeleteEmailSettingsWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Deletes the email setting overrides for an envelope. Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of EmailSettings</returns>
        public ApiResponse< EmailSettings > DeleteEmailSettingsWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteEmailSettings");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteEmailSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteEmailSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEmailSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EmailSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSettings) Configuration.ApiClient.Deserialize(response, typeof(EmailSettings)));
            
        }
    
        /// <summary>
        /// Deletes the email setting overrides for an envelope. Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of EmailSettings</returns>
        public async System.Threading.Tasks.Task<EmailSettings> DeleteEmailSettingsAsync (string accountId, string envelopeId)
        {
             ApiResponse<EmailSettings> response = await DeleteEmailSettingsAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Deletes the email setting overrides for an envelope. Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (EmailSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailSettings>> DeleteEmailSettingsAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteEmailSettings");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteEmailSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteEmailSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteEmailSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EmailSettings>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailSettings) Configuration.ApiClient.Deserialize(response, typeof(EmailSettings)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets envelope lock information. Retrieves general information about the envelope lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5LockInformation</returns>
        public LockInformation GetLock (string accountId, string envelopeId)
        {
             ApiResponse<LockInformation> response = GetLockWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Gets envelope lock information. Retrieves general information about the envelope lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of LockInformation</returns>
        public ApiResponse< LockInformation > GetLockWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetLock");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetLock");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/lock";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
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
        /// Gets envelope lock information. Retrieves general information about the envelope lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of LockInformation</returns>
        public async System.Threading.Tasks.Task<LockInformation> GetLockAsync (string accountId, string envelopeId)
        {
             ApiResponse<LockInformation> response = await GetLockAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Gets envelope lock information. Retrieves general information about the envelope lock.\n\nIf the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (LockInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LockInformation>> GetLockAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetLock");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetLock");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/lock";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

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
        /// Updates an envelope lock. Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>5LockInformation</returns>
        public LockInformation UpdateLock (string accountId, string envelopeId, LockRequest lockRequest)
        {
             ApiResponse<LockInformation> response = UpdateLockWithHttpInfo(accountId, envelopeId, lockRequest);
             return response.Data;
        }

        /// <summary>
        /// Updates an envelope lock. Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>6ApiResponse of LockInformation</returns>
        public ApiResponse< LockInformation > UpdateLockWithHttpInfo (string accountId, string envelopeId, LockRequest lockRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateLock");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateLock");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/lock";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(lockRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateLock: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateLock: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LockInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LockInformation) Configuration.ApiClient.Deserialize(response, typeof(LockInformation)));
            
        }
    
        /// <summary>
        /// Updates an envelope lock. Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>7Task of LockInformation</returns>
        public async System.Threading.Tasks.Task<LockInformation> UpdateLockAsync (string accountId, string envelopeId, LockRequest lockRequest)
        {
             ApiResponse<LockInformation> response = await UpdateLockAsyncWithHttpInfo(accountId, envelopeId, lockRequest);
             return response.Data;

        }

        /// <summary>
        /// Updates an envelope lock. Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (LockInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LockInformation>> UpdateLockAsyncWithHttpInfo (string accountId, string envelopeId, LockRequest lockRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateLock");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateLock");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/lock";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(lockRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateLock: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateLock: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LockInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LockInformation) Configuration.ApiClient.Deserialize(response, typeof(LockInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Lock an envelope. Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.\n\nNote: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>5LockInformation</returns>
        public LockInformation CreateLock (string accountId, string envelopeId, LockRequest lockRequest)
        {
             ApiResponse<LockInformation> response = CreateLockWithHttpInfo(accountId, envelopeId, lockRequest);
             return response.Data;
        }

        /// <summary>
        /// Lock an envelope. Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.\n\nNote: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>6ApiResponse of LockInformation</returns>
        public ApiResponse< LockInformation > CreateLockWithHttpInfo (string accountId, string envelopeId, LockRequest lockRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateLock");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateLock");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/lock";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(lockRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateLock: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateLock: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LockInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LockInformation) Configuration.ApiClient.Deserialize(response, typeof(LockInformation)));
            
        }
    
        /// <summary>
        /// Lock an envelope. Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.\n\nNote: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>7Task of LockInformation</returns>
        public async System.Threading.Tasks.Task<LockInformation> CreateLockAsync (string accountId, string envelopeId, LockRequest lockRequest)
        {
             ApiResponse<LockInformation> response = await CreateLockAsyncWithHttpInfo(accountId, envelopeId, lockRequest);
             return response.Data;

        }

        /// <summary>
        /// Lock an envelope. Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.\n\nNote: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="lockRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (LockInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LockInformation>> CreateLockAsyncWithHttpInfo (string accountId, string envelopeId, LockRequest lockRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateLock");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateLock");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/lock";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(lockRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateLock: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateLock: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LockInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LockInformation) Configuration.ApiClient.Deserialize(response, typeof(LockInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes an envelope lock. Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5LockInformation</returns>
        public LockInformation DeleteLock (string accountId, string envelopeId)
        {
             ApiResponse<LockInformation> response = DeleteLockWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Deletes an envelope lock. Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of LockInformation</returns>
        public ApiResponse< LockInformation > DeleteLockWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteLock");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteLock");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/lock";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteLock: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteLock: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LockInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LockInformation) Configuration.ApiClient.Deserialize(response, typeof(LockInformation)));
            
        }
    
        /// <summary>
        /// Deletes an envelope lock. Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of LockInformation</returns>
        public async System.Threading.Tasks.Task<LockInformation> DeleteLockAsync (string accountId, string envelopeId)
        {
             ApiResponse<LockInformation> response = await DeleteLockAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Deletes an envelope lock. Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (LockInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LockInformation>> DeleteLockAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteLock");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteLock");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/lock";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteLock: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteLock: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LockInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LockInformation) Configuration.ApiClient.Deserialize(response, typeof(LockInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets envelope notification information. Retrieves the envelope notification, reminders and expirations, information for an existing envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5Notification</returns>
        public Notification GetNotificationSettings (string accountId, string envelopeId)
        {
             ApiResponse<Notification> response = GetNotificationSettingsWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Gets envelope notification information. Retrieves the envelope notification, reminders and expirations, information for an existing envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of Notification</returns>
        public ApiResponse< Notification > GetNotificationSettingsWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetNotificationSettings");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetNotificationSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/notification";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
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
        /// Gets envelope notification information. Retrieves the envelope notification, reminders and expirations, information for an existing envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of Notification</returns>
        public async System.Threading.Tasks.Task<Notification> GetNotificationSettingsAsync (string accountId, string envelopeId)
        {
             ApiResponse<Notification> response = await GetNotificationSettingsAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Gets envelope notification information. Retrieves the envelope notification, reminders and expirations, information for an existing envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (Notification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Notification>> GetNotificationSettingsAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetNotificationSettings");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling GetNotificationSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/notification";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

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
        /// Gets the status of recipients for an envelope. Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list. \n\nThe `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5Recipients</returns>
        public Recipients ListRecipients (string accountId, string envelopeId)
        {
             ApiResponse<Recipients> response = ListRecipientsWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Gets the status of recipients for an envelope. Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list. \n\nThe `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of Recipients</returns>
        public ApiResponse< Recipients > ListRecipientsWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListRecipients");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
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
        /// Gets the status of recipients for an envelope. Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list. \n\nThe `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of Recipients</returns>
        public async System.Threading.Tasks.Task<Recipients> ListRecipientsAsync (string accountId, string envelopeId)
        {
             ApiResponse<Recipients> response = await ListRecipientsAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Gets the status of recipients for an envelope. Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list. \n\nThe `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (Recipients)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipients>> ListRecipientsAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListRecipients");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

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
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope. Updates recipients in a draft envelope or corrects recipient information for an in process envelope. \n\nFor draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.\n\nOnce an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.\n\nIf you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>5RecipientsUpdateSummary</returns>
        public RecipientsUpdateSummary UpdateRecipients (string accountId, string envelopeId, Recipients recipients)
        {
             ApiResponse<RecipientsUpdateSummary> response = UpdateRecipientsWithHttpInfo(accountId, envelopeId, recipients);
             return response.Data;
        }

        /// <summary>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope. Updates recipients in a draft envelope or corrects recipient information for an in process envelope. \n\nFor draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.\n\nOnce an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.\n\nIf you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>6ApiResponse of RecipientsUpdateSummary</returns>
        public ApiResponse< RecipientsUpdateSummary > UpdateRecipientsWithHttpInfo (string accountId, string envelopeId, Recipients recipients)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateRecipients");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(recipients); // http body (model) parameter
            

            
    
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
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope. Updates recipients in a draft envelope or corrects recipient information for an in process envelope. \n\nFor draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.\n\nOnce an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.\n\nIf you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>7Task of RecipientsUpdateSummary</returns>
        public async System.Threading.Tasks.Task<RecipientsUpdateSummary> UpdateRecipientsAsync (string accountId, string envelopeId, Recipients recipients)
        {
             ApiResponse<RecipientsUpdateSummary> response = await UpdateRecipientsAsyncWithHttpInfo(accountId, envelopeId, recipients);
             return response.Data;

        }

        /// <summary>
        /// Updates recipients in a draft envelope or corrects recipient information for an in process envelope. Updates recipients in a draft envelope or corrects recipient information for an in process envelope. \n\nFor draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.\n\nOnce an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.\n\nIf you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>8Task of ApiResponse (RecipientsUpdateSummary)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecipientsUpdateSummary>> UpdateRecipientsAsyncWithHttpInfo (string accountId, string envelopeId, Recipients recipients)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateRecipients");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(recipients); // http body (model) parameter
            

            

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
        /// Adds one or more recipients to an envelope. Adds one or more recipients to an envelope.\n\nFor an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>5Recipients</returns>
        public Recipients CreateRecipient (string accountId, string envelopeId, Recipients recipients)
        {
             ApiResponse<Recipients> response = CreateRecipientWithHttpInfo(accountId, envelopeId, recipients);
             return response.Data;
        }

        /// <summary>
        /// Adds one or more recipients to an envelope. Adds one or more recipients to an envelope.\n\nFor an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>6ApiResponse of Recipients</returns>
        public ApiResponse< Recipients > CreateRecipientWithHttpInfo (string accountId, string envelopeId, Recipients recipients)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateRecipient");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateRecipient");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(recipients); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateRecipient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRecipient: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
    
        /// <summary>
        /// Adds one or more recipients to an envelope. Adds one or more recipients to an envelope.\n\nFor an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>7Task of Recipients</returns>
        public async System.Threading.Tasks.Task<Recipients> CreateRecipientAsync (string accountId, string envelopeId, Recipients recipients)
        {
             ApiResponse<Recipients> response = await CreateRecipientAsyncWithHttpInfo(accountId, envelopeId, recipients);
             return response.Data;

        }

        /// <summary>
        /// Adds one or more recipients to an envelope. Adds one or more recipients to an envelope.\n\nFor an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient&#39;s routing order is before or the same as the envelope&#39;s next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>8Task of ApiResponse (Recipients)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipients>> CreateRecipientAsyncWithHttpInfo (string accountId, string envelopeId, Recipients recipients)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateRecipient");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateRecipient");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(recipients); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateRecipient: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRecipient: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Recipients>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recipients) Configuration.ApiClient.Deserialize(response, typeof(Recipients)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes recipients from an envelope. Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.\n\nIf the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>5Recipients</returns>
        public Recipients DeleteRecipients (string accountId, string envelopeId, Recipients recipients)
        {
             ApiResponse<Recipients> response = DeleteRecipientsWithHttpInfo(accountId, envelopeId, recipients);
             return response.Data;
        }

        /// <summary>
        /// Deletes recipients from an envelope. Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.\n\nIf the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>6ApiResponse of Recipients</returns>
        public ApiResponse< Recipients > DeleteRecipientsWithHttpInfo (string accountId, string envelopeId, Recipients recipients)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteRecipients");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(recipients); // http body (model) parameter
            

            
    
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
        /// Deletes recipients from an envelope. Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.\n\nIf the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>7Task of Recipients</returns>
        public async System.Threading.Tasks.Task<Recipients> DeleteRecipientsAsync (string accountId, string envelopeId, Recipients recipients)
        {
             ApiResponse<Recipients> response = await DeleteRecipientsAsyncWithHttpInfo(accountId, envelopeId, recipients);
             return response.Data;

        }

        /// <summary>
        /// Deletes recipients from an envelope. Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.\n\nIf the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipients">TBD Description</param>
		/// <returns>8Task of ApiResponse (Recipients)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipients>> DeleteRecipientsAsyncWithHttpInfo (string accountId, string envelopeId, Recipients recipients)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteRecipients");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteRecipients");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(recipients); // http body (model) parameter
            

            

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
        /// Deletes a recipient from an envelope. Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>5Recipients</returns>
        public Recipients DeleteRecipient (string accountId, string envelopeId, string recipientId)
        {
             ApiResponse<Recipients> response = DeleteRecipientWithHttpInfo(accountId, envelopeId, recipientId);
             return response.Data;
        }

        /// <summary>
        /// Deletes a recipient from an envelope. Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>6ApiResponse of Recipients</returns>
        public ApiResponse< Recipients > DeleteRecipientWithHttpInfo (string accountId, string envelopeId, string recipientId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteRecipient");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteRecipient");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling DeleteRecipient");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            

            
    
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
        /// Deletes a recipient from an envelope. Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>7Task of Recipients</returns>
        public async System.Threading.Tasks.Task<Recipients> DeleteRecipientAsync (string accountId, string envelopeId, string recipientId)
        {
             ApiResponse<Recipients> response = await DeleteRecipientAsyncWithHttpInfo(accountId, envelopeId, recipientId);
             return response.Data;

        }

        /// <summary>
        /// Deletes a recipient from an envelope. Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>8Task of ApiResponse (Recipients)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recipients>> DeleteRecipientAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteRecipient");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteRecipient");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling DeleteRecipient");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            

            

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
        /// Gets the tabs information for a signer or sign-in-person recipient in an envelope. Retrieves information about the tabs associated with a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>5Tabs</returns>
        public Tabs ListTabs (string accountId, string envelopeId, string recipientId)
        {
             ApiResponse<Tabs> response = ListTabsWithHttpInfo(accountId, envelopeId, recipientId);
             return response.Data;
        }

        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in an envelope. Retrieves information about the tabs associated with a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>6ApiResponse of Tabs</returns>
        public ApiResponse< Tabs > ListTabsWithHttpInfo (string accountId, string envelopeId, string recipientId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTabs");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListTabs");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling ListTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            

            
    
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
        /// Gets the tabs information for a signer or sign-in-person recipient in an envelope. Retrieves information about the tabs associated with a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>7Task of Tabs</returns>
        public async System.Threading.Tasks.Task<Tabs> ListTabsAsync (string accountId, string envelopeId, string recipientId)
        {
             ApiResponse<Tabs> response = await ListTabsAsyncWithHttpInfo(accountId, envelopeId, recipientId);
             return response.Data;

        }

        /// <summary>
        /// Gets the tabs information for a signer or sign-in-person recipient in an envelope. Retrieves information about the tabs associated with a recipient in a draft envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param>
		/// <returns>8Task of ApiResponse (Tabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tabs>> ListTabsAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTabs");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListTabs");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling ListTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            

            

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
        /// Updates the tabs for a recipient. Updates one or more tabs for a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>5Tabs</returns>
        public Tabs UpdateTabs (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
             ApiResponse<Tabs> response = UpdateTabsWithHttpInfo(accountId, envelopeId, recipientId, tabs);
             return response.Data;
        }

        /// <summary>
        /// Updates the tabs for a recipient. Updates one or more tabs for a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>6ApiResponse of Tabs</returns>
        public ApiResponse< Tabs > UpdateTabsWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateTabs");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateTabs");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling UpdateTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabs); // http body (model) parameter
            

            
    
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
        /// Updates the tabs for a recipient. Updates one or more tabs for a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>7Task of Tabs</returns>
        public async System.Threading.Tasks.Task<Tabs> UpdateTabsAsync (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
             ApiResponse<Tabs> response = await UpdateTabsAsyncWithHttpInfo(accountId, envelopeId, recipientId, tabs);
             return response.Data;

        }

        /// <summary>
        /// Updates the tabs for a recipient. Updates one or more tabs for a recipient in a draft envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>8Task of ApiResponse (Tabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tabs>> UpdateTabsAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateTabs");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling UpdateTabs");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling UpdateTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabs); // http body (model) parameter
            

            

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
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>5Tabs</returns>
        public Tabs CreateTabs (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
             ApiResponse<Tabs> response = CreateTabsWithHttpInfo(accountId, envelopeId, recipientId, tabs);
             return response.Data;
        }

        /// <summary>
        /// Adds tabs for a recipient. Adds one or more tabs for a recipient.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>6ApiResponse of Tabs</returns>
        public ApiResponse< Tabs > CreateTabsWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateTabs");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateTabs");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling CreateTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabs); // http body (model) parameter
            

            
    
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
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>7Task of Tabs</returns>
        public async System.Threading.Tasks.Task<Tabs> CreateTabsAsync (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
             ApiResponse<Tabs> response = await CreateTabsAsyncWithHttpInfo(accountId, envelopeId, recipientId, tabs);
             return response.Data;

        }

        /// <summary>
        /// Adds tabs for a recipient. Adds one or more tabs for a recipient.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>8Task of ApiResponse (Tabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tabs>> CreateTabsAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateTabs");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateTabs");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling CreateTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabs); // http body (model) parameter
            

            

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
        /// Deletes the tabs associated with a recipient. Deletes one or more tabs associated with a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>5Tabs</returns>
        public Tabs DeleteTabs (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
             ApiResponse<Tabs> response = DeleteTabsWithHttpInfo(accountId, envelopeId, recipientId, tabs);
             return response.Data;
        }

        /// <summary>
        /// Deletes the tabs associated with a recipient. Deletes one or more tabs associated with a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>6ApiResponse of Tabs</returns>
        public ApiResponse< Tabs > DeleteTabsWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteTabs");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteTabs");
            
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling DeleteTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabs); // http body (model) parameter
            

            
    
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
        /// Deletes the tabs associated with a recipient. Deletes one or more tabs associated with a recipient in a draft envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>7Task of Tabs</returns>
        public async System.Threading.Tasks.Task<Tabs> DeleteTabsAsync (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
             ApiResponse<Tabs> response = await DeleteTabsAsyncWithHttpInfo(accountId, envelopeId, recipientId, tabs);
             return response.Data;

        }

        /// <summary>
        /// Deletes the tabs associated with a recipient. Deletes one or more tabs associated with a recipient in a draft envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param><param name="recipientId">The ID of the recipient being accessed.</param> <param name="tabs">TBD Description</param>
		/// <returns>8Task of ApiResponse (Tabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Tabs>> DeleteTabsAsyncWithHttpInfo (string accountId, string envelopeId, string recipientId, Tabs tabs)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteTabs");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteTabs");
            // verify the required parameter 'recipientId' is set
            if (recipientId == null) throw new ApiException(400, "Missing required parameter 'recipientId' when calling DeleteTabs");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            if (recipientId != null) pathParams.Add("recipientId", Configuration.ApiClient.ParameterToString(recipientId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabs); // http body (model) parameter
            

            

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
        /// Get List of Templates used in an Envelope This returns a list of the templates, name and ID, used in an envelope.&lt;br/&gt;&lt;br/&gt;Note: This only returns information for server side templates.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5TemplateInformation</returns>
        public TemplateInformation ListTemplates (string accountId, string envelopeId)
        {
             ApiResponse<TemplateInformation> response = ListTemplatesWithHttpInfo(accountId, envelopeId);
             return response.Data;
        }

        /// <summary>
        /// Get List of Templates used in an Envelope This returns a list of the templates, name and ID, used in an envelope.&lt;br/&gt;&lt;br/&gt;Note: This only returns information for server side templates.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of TemplateInformation</returns>
        public ApiResponse< TemplateInformation > ListTemplatesWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTemplates");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListTemplates");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/templates";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListTemplates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateInformation) Configuration.ApiClient.Deserialize(response, typeof(TemplateInformation)));
            
        }
    
        /// <summary>
        /// Get List of Templates used in an Envelope This returns a list of the templates, name and ID, used in an envelope.&lt;br/&gt;&lt;br/&gt;Note: This only returns information for server side templates.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of TemplateInformation</returns>
        public async System.Threading.Tasks.Task<TemplateInformation> ListTemplatesAsync (string accountId, string envelopeId)
        {
             ApiResponse<TemplateInformation> response = await ListTemplatesAsyncWithHttpInfo(accountId, envelopeId);
             return response.Data;

        }

        /// <summary>
        /// Get List of Templates used in an Envelope This returns a list of the templates, name and ID, used in an envelope.&lt;br/&gt;&lt;br/&gt;Note: This only returns information for server side templates.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse (TemplateInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateInformation>> ListTemplatesAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListTemplates");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ListTemplates");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/templates";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListTemplates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListTemplates: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateInformation) Configuration.ApiClient.Deserialize(response, typeof(TemplateInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Adds templates to an envelope. Adds templates to the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>5DocumentTemplateList</returns>
        public DocumentTemplateList ApplyTemplate (string accountId, string envelopeId, DocumentTemplateList documentTemplateList)
        {
             ApiResponse<DocumentTemplateList> response = ApplyTemplateWithHttpInfo(accountId, envelopeId, documentTemplateList);
             return response.Data;
        }

        /// <summary>
        /// Adds templates to an envelope. Adds templates to the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>6ApiResponse of DocumentTemplateList</returns>
        public ApiResponse< DocumentTemplateList > ApplyTemplateWithHttpInfo (string accountId, string envelopeId, DocumentTemplateList documentTemplateList)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ApplyTemplate");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ApplyTemplate");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/templates";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentTemplateList); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ApplyTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ApplyTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DocumentTemplateList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTemplateList) Configuration.ApiClient.Deserialize(response, typeof(DocumentTemplateList)));
            
        }
    
        /// <summary>
        /// Adds templates to an envelope. Adds templates to the specified envelope.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>7Task of DocumentTemplateList</returns>
        public async System.Threading.Tasks.Task<DocumentTemplateList> ApplyTemplateAsync (string accountId, string envelopeId, DocumentTemplateList documentTemplateList)
        {
             ApiResponse<DocumentTemplateList> response = await ApplyTemplateAsyncWithHttpInfo(accountId, envelopeId, documentTemplateList);
             return response.Data;

        }

        /// <summary>
        /// Adds templates to an envelope. Adds templates to the specified envelope.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="documentTemplateList">TBD Description</param>
		/// <returns>8Task of ApiResponse (DocumentTemplateList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentTemplateList>> ApplyTemplateAsyncWithHttpInfo (string accountId, string envelopeId, DocumentTemplateList documentTemplateList)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ApplyTemplate");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling ApplyTemplate");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/templates";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(documentTemplateList); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ApplyTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ApplyTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DocumentTemplateList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTemplateList) Configuration.ApiClient.Deserialize(response, typeof(DocumentTemplateList)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Returns a URL to the envelope correction UI. Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="correctViewRequest">TBD Description</param>
		/// <returns>5ViewUrl</returns>
        public ViewUrl CreateCorrectView (string accountId, string envelopeId, CorrectViewRequest correctViewRequest)
        {
             ApiResponse<ViewUrl> response = CreateCorrectViewWithHttpInfo(accountId, envelopeId, correctViewRequest);
             return response.Data;
        }

        /// <summary>
        /// Returns a URL to the envelope correction UI. Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="correctViewRequest">TBD Description</param>
		/// <returns>6ApiResponse of ViewUrl</returns>
        public ApiResponse< ViewUrl > CreateCorrectViewWithHttpInfo (string accountId, string envelopeId, CorrectViewRequest correctViewRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateCorrectView");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateCorrectView");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/correct";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(correctViewRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateCorrectView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateCorrectView: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
    
        /// <summary>
        /// Returns a URL to the envelope correction UI. Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="correctViewRequest">TBD Description</param>
		/// <returns>7Task of ViewUrl</returns>
        public async System.Threading.Tasks.Task<ViewUrl> CreateCorrectViewAsync (string accountId, string envelopeId, CorrectViewRequest correctViewRequest)
        {
             ApiResponse<ViewUrl> response = await CreateCorrectViewAsyncWithHttpInfo(accountId, envelopeId, correctViewRequest);
             return response.Data;

        }

        /// <summary>
        /// Returns a URL to the envelope correction UI. Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="correctViewRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (ViewUrl)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateCorrectViewAsyncWithHttpInfo (string accountId, string envelopeId, CorrectViewRequest correctViewRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateCorrectView");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateCorrectView");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/correct";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(correctViewRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateCorrectView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateCorrectView: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Returns a URL to the edit view UI. Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>5ViewUrl</returns>
        public ViewUrl CreateEditView (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest)
        {
             ApiResponse<ViewUrl> response = CreateEditViewWithHttpInfo(accountId, envelopeId, returnUrlRequest);
             return response.Data;
        }

        /// <summary>
        /// Returns a URL to the edit view UI. Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>6ApiResponse of ViewUrl</returns>
        public ApiResponse< ViewUrl > CreateEditViewWithHttpInfo (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateEditView");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateEditView");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/edit";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(returnUrlRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEditView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEditView: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
    
        /// <summary>
        /// Returns a URL to the edit view UI. Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>7Task of ViewUrl</returns>
        public async System.Threading.Tasks.Task<ViewUrl> CreateEditViewAsync (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest)
        {
             ApiResponse<ViewUrl> response = await CreateEditViewAsyncWithHttpInfo(accountId, envelopeId, returnUrlRequest);
             return response.Data;

        }

        /// <summary>
        /// Returns a URL to the edit view UI. Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (ViewUrl)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateEditViewAsyncWithHttpInfo (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateEditView");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateEditView");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/edit";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(returnUrlRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEditView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEditView: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Returns a URL to the recipient view UI. Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent. \n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. \n\nAn entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipientViewRequest">TBD Description</param>
		/// <returns>5ViewUrl</returns>
        public ViewUrl CreateRecipientView (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest)
        {
             ApiResponse<ViewUrl> response = CreateRecipientViewWithHttpInfo(accountId, envelopeId, recipientViewRequest);
             return response.Data;
        }

        /// <summary>
        /// Returns a URL to the recipient view UI. Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent. \n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. \n\nAn entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipientViewRequest">TBD Description</param>
		/// <returns>6ApiResponse of ViewUrl</returns>
        public ApiResponse< ViewUrl > CreateRecipientViewWithHttpInfo (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateRecipientView");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateRecipientView");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/recipient";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(recipientViewRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateRecipientView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRecipientView: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
    
        /// <summary>
        /// Returns a URL to the recipient view UI. Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent. \n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. \n\nAn entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipientViewRequest">TBD Description</param>
		/// <returns>7Task of ViewUrl</returns>
        public async System.Threading.Tasks.Task<ViewUrl> CreateRecipientViewAsync (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest)
        {
             ApiResponse<ViewUrl> response = await CreateRecipientViewAsyncWithHttpInfo(accountId, envelopeId, recipientViewRequest);
             return response.Data;

        }

        /// <summary>
        /// Returns a URL to the recipient view UI. Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent. \n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. \n\nAn entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="recipientViewRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (ViewUrl)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateRecipientViewAsyncWithHttpInfo (string accountId, string envelopeId, RecipientViewRequest recipientViewRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateRecipientView");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateRecipientView");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/recipient";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(recipientViewRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateRecipientView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateRecipientView: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Returns a URL to the sender view UI. Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>5ViewUrl</returns>
        public ViewUrl CreateSenderView (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest)
        {
             ApiResponse<ViewUrl> response = CreateSenderViewWithHttpInfo(accountId, envelopeId, returnUrlRequest);
             return response.Data;
        }

        /// <summary>
        /// Returns a URL to the sender view UI. Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>6ApiResponse of ViewUrl</returns>
        public ApiResponse< ViewUrl > CreateSenderViewWithHttpInfo (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateSenderView");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateSenderView");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/sender";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(returnUrlRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateSenderView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateSenderView: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
    
        /// <summary>
        /// Returns a URL to the sender view UI. Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>7Task of ViewUrl</returns>
        public async System.Threading.Tasks.Task<ViewUrl> CreateSenderViewAsync (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest)
        {
             ApiResponse<ViewUrl> response = await CreateSenderViewAsyncWithHttpInfo(accountId, envelopeId, returnUrlRequest);
             return response.Data;

        }

        /// <summary>
        /// Returns a URL to the sender view UI. Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view. \n\nUpon sending completion, the user is returned to the return URL provided by the API application.\n\nImportant: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="returnUrlRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (ViewUrl)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateSenderViewAsyncWithHttpInfo (string accountId, string envelopeId, ReturnUrlRequest returnUrlRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateSenderView");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateSenderView");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/sender";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(returnUrlRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateSenderView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateSenderView: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Reserved: Returns a URL to the secure link view UI. Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="viewLinkRequest">TBD Description</param>
		/// <returns>5ViewUrl</returns>
        public ViewUrl CreateViewLink (string accountId, string envelopeId, ViewLinkRequest viewLinkRequest)
        {
             ApiResponse<ViewUrl> response = CreateViewLinkWithHttpInfo(accountId, envelopeId, viewLinkRequest);
             return response.Data;
        }

        /// <summary>
        /// Reserved: Returns a URL to the secure link view UI. Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="viewLinkRequest">TBD Description</param>
		/// <returns>6ApiResponse of ViewUrl</returns>
        public ApiResponse< ViewUrl > CreateViewLinkWithHttpInfo (string accountId, string envelopeId, ViewLinkRequest viewLinkRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateViewLink");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateViewLink");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/viewlink";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(viewLinkRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateViewLink: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateViewLink: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
    
        /// <summary>
        /// Reserved: Returns a URL to the secure link view UI. Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="viewLinkRequest">TBD Description</param>
		/// <returns>7Task of ViewUrl</returns>
        public async System.Threading.Tasks.Task<ViewUrl> CreateViewLinkAsync (string accountId, string envelopeId, ViewLinkRequest viewLinkRequest)
        {
             ApiResponse<ViewUrl> response = await CreateViewLinkAsyncWithHttpInfo(accountId, envelopeId, viewLinkRequest);
             return response.Data;

        }

        /// <summary>
        /// Reserved: Returns a URL to the secure link view UI. Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param> <param name="viewLinkRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (ViewUrl)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateViewLinkAsyncWithHttpInfo (string accountId, string envelopeId, ViewLinkRequest viewLinkRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateViewLink");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling CreateViewLink");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/viewlink";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(viewLinkRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateViewLink: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateViewLink: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Reserved: Expires a secure view link. Reserved: Expires a secure view link
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>5</returns>
        public void DeleteViewLink (string accountId, string envelopeId)
        {
             DeleteViewLinkWithHttpInfo(accountId, envelopeId);
        }

        /// <summary>
        /// Reserved: Expires a secure view link. Reserved: Expires a secure view link
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>6ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteViewLinkWithHttpInfo (string accountId, string envelopeId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteViewLink");
            
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteViewLink");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/viewlink";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteViewLink: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteViewLink: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Reserved: Expires a secure view link. Reserved: Expires a secure view link
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>7Task of void</returns>
        public async System.Threading.Tasks.Task DeleteViewLinkAsync (string accountId, string envelopeId)
        {
             await DeleteViewLinkAsyncWithHttpInfo(accountId, envelopeId);

        }

        /// <summary>
        /// Reserved: Expires a secure view link. Reserved: Expires a secure view link
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="envelopeId">The envelopeId Guid of the envelope being accessed.</param>
		/// <returns>8Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteViewLinkAsyncWithHttpInfo (string accountId, string envelopeId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling DeleteViewLink");
            // verify the required parameter 'envelopeId' is set
            if (envelopeId == null) throw new ApiException(400, "Missing required parameter 'envelopeId' when calling DeleteViewLink");
            
    
            var path_ = "/v2/accounts/{accountId}/envelopes/{envelopeId}/views/viewlink";
    
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
            if (envelopeId != null) pathParams.Add("envelopeId", Configuration.ApiClient.ParameterToString(envelopeId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteViewLink: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteViewLink: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Returns a URL to the authentication view UI. Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="consoleViewRequest">TBD Description</param>
		/// <returns>5ViewUrl</returns>
        public ViewUrl CreateConsoleView (string accountId, ConsoleViewRequest consoleViewRequest)
        {
             ApiResponse<ViewUrl> response = CreateConsoleViewWithHttpInfo(accountId, consoleViewRequest);
             return response.Data;
        }

        /// <summary>
        /// Returns a URL to the authentication view UI. Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="consoleViewRequest">TBD Description</param>
		/// <returns>6ApiResponse of ViewUrl</returns>
        public ApiResponse< ViewUrl > CreateConsoleViewWithHttpInfo (string accountId, ConsoleViewRequest consoleViewRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateConsoleView");
            
    
            var path_ = "/v2/accounts/{accountId}/views/console";
    
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
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(consoleViewRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateConsoleView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConsoleView: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
    
        /// <summary>
        /// Returns a URL to the authentication view UI. Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="consoleViewRequest">TBD Description</param>
		/// <returns>7Task of ViewUrl</returns>
        public async System.Threading.Tasks.Task<ViewUrl> CreateConsoleViewAsync (string accountId, ConsoleViewRequest consoleViewRequest)
        {
             ApiResponse<ViewUrl> response = await CreateConsoleViewAsyncWithHttpInfo(accountId, consoleViewRequest);
             return response.Data;

        }

        /// <summary>
        /// Returns a URL to the authentication view UI. Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="consoleViewRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (ViewUrl)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ViewUrl>> CreateConsoleViewAsyncWithHttpInfo (string accountId, ConsoleViewRequest consoleViewRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling CreateConsoleView");
            
    
            var path_ = "/v2/accounts/{accountId}/views/console";
    
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
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(consoleViewRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateConsoleView: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConsoleView: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ViewUrl>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ViewUrl) Configuration.ApiClient.Deserialize(response, typeof(ViewUrl)));
            
        }
        
    }
    
}
