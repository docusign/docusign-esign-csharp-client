# DocuSign.eSign.Api.EnvelopesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplyTemplate**](EnvelopesApi.md#applytemplate) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/templates | Adds templates to an envelope.
[**ApplyTemplateToDocument**](EnvelopesApi.md#applytemplatetodocument) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates | Adds templates to a document in an  envelope.
[**CreateChunkedUpload**](EnvelopesApi.md#createchunkedupload) | **POST** /v2/accounts/{accountId}/chunked_uploads | Initiate a new ChunkedUpload.
[**CreateConsoleView**](EnvelopesApi.md#createconsoleview) | **POST** /v2/accounts/{accountId}/views/console | Returns a URL to the authentication view UI.
[**CreateCorrectView**](EnvelopesApi.md#createcorrectview) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/correct | Returns a URL to the envelope correction UI.
[**CreateCustomFields**](EnvelopesApi.md#createcustomfields) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields | Updates envelope custom fields for an envelope.
[**CreateDocumentFields**](EnvelopesApi.md#createdocumentfields) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields | Creates custom document fields in an existing envelope document.
[**CreateEditView**](EnvelopesApi.md#createeditview) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/edit | Returns a URL to the edit view UI.
[**CreateEmailSettings**](EnvelopesApi.md#createemailsettings) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings | Adds email setting overrides to an envelope.
[**CreateEnvelope**](EnvelopesApi.md#createenvelope) | **POST** /v2/accounts/{accountId}/envelopes | Creates an envelope.
[**CreateLock**](EnvelopesApi.md#createlock) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/lock | Lock an envelope.
[**CreateRecipient**](EnvelopesApi.md#createrecipient) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients | Adds one or more recipients to an envelope.
[**CreateRecipientView**](EnvelopesApi.md#createrecipientview) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/recipient | Returns a URL to the recipient view UI.
[**CreateSenderView**](EnvelopesApi.md#createsenderview) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/sender | Returns a URL to the sender view UI.
[**CreateTabs**](EnvelopesApi.md#createtabs) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs | Adds tabs for a recipient.
[**CreateViewLink**](EnvelopesApi.md#createviewlink) | **POST** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/viewlink | Reserved: Returns a URL to the secure link view UI.
[**DeleteAttachments**](EnvelopesApi.md#deleteattachments) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments | Delete one or more attachments from a DRAFT envelope.
[**DeleteChunkedUpload**](EnvelopesApi.md#deletechunkedupload) | **DELETE** /v2/accounts/{accountId}/chunked_uploads/{chunkedUploadId} | Delete an existing ChunkedUpload.
[**DeleteCustomFields**](EnvelopesApi.md#deletecustomfields) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields | Deletes envelope custom fields for draft and in-process envelopes.
[**DeleteDocumentFields**](EnvelopesApi.md#deletedocumentfields) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields | Deletes custom document fields from an existing envelope document.
[**DeleteDocumentPage**](EnvelopesApi.md#deletedocumentpage) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber} | Deletes a page from a document in an envelope.
[**DeleteDocuments**](EnvelopesApi.md#deletedocuments) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents | Deletes documents from a draft envelope.
[**DeleteEmailSettings**](EnvelopesApi.md#deleteemailsettings) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings | Deletes the email setting overrides for an envelope.
[**DeleteLock**](EnvelopesApi.md#deletelock) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/lock | Deletes an envelope lock.
[**DeleteRecipient**](EnvelopesApi.md#deleterecipient) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId} | Deletes a recipient from an envelope.
[**DeleteRecipients**](EnvelopesApi.md#deleterecipients) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients | Deletes recipients from an envelope.
[**DeleteTabs**](EnvelopesApi.md#deletetabs) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs | Deletes the tabs associated with a recipient.
[**DeleteTemplatesFromDocument**](EnvelopesApi.md#deletetemplatesfromdocument) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates/{templateId} | Deletes a template from a document in an existing envelope.
[**DeleteViewLink**](EnvelopesApi.md#deleteviewlink) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/views/viewlink | Reserved: Expires a secure view link.
[**GetAttachment**](EnvelopesApi.md#getattachment) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments/{attachmentId} | Retrieves an attachment from the envelope.
[**GetAttachments**](EnvelopesApi.md#getattachments) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments | Returns a list of attachments associated with the specified envelope
[**GetChunkedUpload**](EnvelopesApi.md#getchunkedupload) | **GET** /v2/accounts/{accountId}/chunked_uploads/{chunkedUploadId} | Retrieves the current metadata of a ChunkedUpload.
[**GetConsumerDisclosure**](EnvelopesApi.md#getconsumerdisclosure) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/consumer_disclosure/{langCode} | Reserved: Gets the Electronic Record and Signature Disclosure associated with the account.
[**GetConsumerDisclosureDefault**](EnvelopesApi.md#getconsumerdisclosuredefault) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/consumer_disclosure | Gets the Electronic Record and Signature Disclosure associated with the account.
[**GetDocument**](EnvelopesApi.md#getdocument) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId} | Gets a document from an envelope.
[**GetDocumentPageImage**](EnvelopesApi.md#getdocumentpageimage) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber}/page_image | Gets a page image from an envelope for display.
[**GetDocumentTabs**](EnvelopesApi.md#getdocumenttabs) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/tabs | Returns tabs on the document.
[**GetEmailSettings**](EnvelopesApi.md#getemailsettings) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings | Gets the email setting overrides for an envelope.
[**GetEnvelope**](EnvelopesApi.md#getenvelope) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId} | Gets the status of a envelope.
[**GetFormData**](EnvelopesApi.md#getformdata) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/form_data | Returns envelope form data for an existing envelope.
[**GetLock**](EnvelopesApi.md#getlock) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/lock | Gets envelope lock information.
[**GetNotificationSettings**](EnvelopesApi.md#getnotificationsettings) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/notification | Gets envelope notification information.
[**GetPageTabs**](EnvelopesApi.md#getpagetabs) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber}/tabs | Returns tabs on the specified page.
[**GetPages**](EnvelopesApi.md#getpages) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages | Returns document page image(s) based on input.
[**GetRecipientDocumentVisibility**](EnvelopesApi.md#getrecipientdocumentvisibility) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/document_visibility | Returns document visibility for the recipients
[**GetRecipientInitialsImage**](EnvelopesApi.md#getrecipientinitialsimage) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/initials_image | Gets the initials image for a user.
[**GetRecipientSignature**](EnvelopesApi.md#getrecipientsignature) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/signature | Gets signature information for a signer or sign-in-person recipient.
[**GetRecipientSignatureImage**](EnvelopesApi.md#getrecipientsignatureimage) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/signature_image | Retrieve signature image information for a signer/sign-in-person recipient.
[**GetTemplateRecipientDocumentVisibility**](EnvelopesApi.md#gettemplaterecipientdocumentvisibility) | **GET** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/document_visibility | Returns document visibility for the recipients
[**ListAuditEvents**](EnvelopesApi.md#listauditevents) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/audit_events | Gets the envelope audit events for an envelope.
[**ListCustomFields**](EnvelopesApi.md#listcustomfields) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields | Gets the custom field information for the specified envelope.
[**ListDocumentFields**](EnvelopesApi.md#listdocumentfields) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields | Gets the custom document fields from an  existing envelope document.
[**ListDocuments**](EnvelopesApi.md#listdocuments) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents | Gets a list of envelope documents.
[**ListRecipients**](EnvelopesApi.md#listrecipients) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients | Gets the status of recipients for an envelope.
[**ListStatus**](EnvelopesApi.md#liststatus) | **PUT** /v2/accounts/{accountId}/envelopes/status | Gets the envelope status for the specified envelopes.
[**ListStatusChanges**](EnvelopesApi.md#liststatuschanges) | **GET** /v2/accounts/{accountId}/envelopes | Gets status changes for one or more envelopes.
[**ListTabs**](EnvelopesApi.md#listtabs) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs | Gets the tabs information for a signer or sign-in-person recipient in an envelope.
[**ListTemplates**](EnvelopesApi.md#listtemplates) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/templates | Get List of Templates used in an Envelope
[**ListTemplatesForDocument**](EnvelopesApi.md#listtemplatesfordocument) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/templates | Gets the templates associated with a document in an existing envelope.
[**PutAttachment**](EnvelopesApi.md#putattachment) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments/{attachmentId} | Add an attachment to a DRAFT or IN-PROCESS envelope.
[**PutAttachments**](EnvelopesApi.md#putattachments) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/attachments | Add one or more attachments to a DRAFT or IN-PROCESS envelope.
[**RotateDocumentPage**](EnvelopesApi.md#rotatedocumentpage) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/pages/{pageNumber}/page_image | Rotates page image from an envelope for display.
[**Update**](EnvelopesApi.md#update) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId} | Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft
[**UpdateChunkedUpload**](EnvelopesApi.md#updatechunkedupload) | **PUT** /v2/accounts/{accountId}/chunked_uploads/{chunkedUploadId} | Integrity-Check and Commit a ChunkedUpload, readying it for use elsewhere.
[**UpdateChunkedUploadPart**](EnvelopesApi.md#updatechunkeduploadpart) | **PUT** /v2/accounts/{accountId}/chunked_uploads/{chunkedUploadId}/{chunkedUploadPartSeq} | Add a chunk, a chunk &#39;part&#39;, to an existing ChunkedUpload.
[**UpdateCustomFields**](EnvelopesApi.md#updatecustomfields) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/custom_fields | Updates envelope custom fields in an envelope.
[**UpdateDocument**](EnvelopesApi.md#updatedocument) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId} | Adds a document to an existing draft envelope.
[**UpdateDocumentFields**](EnvelopesApi.md#updatedocumentfields) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents/{documentId}/fields | Updates existing custom document fields in an existing envelope document.
[**UpdateDocuments**](EnvelopesApi.md#updatedocuments) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/documents | Adds one or more documents to an existing envelope document.
[**UpdateEmailSettings**](EnvelopesApi.md#updateemailsettings) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/email_settings | Updates the email setting overrides for an envelope.
[**UpdateLock**](EnvelopesApi.md#updatelock) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/lock | Updates an envelope lock.
[**UpdateNotificationSettings**](EnvelopesApi.md#updatenotificationsettings) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/notification | Sets envelope notification (Reminders/Expirations) structure for an existing envelope.
[**UpdateRecipientDocumentVisibility**](EnvelopesApi.md#updaterecipientdocumentvisibility) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/document_visibility | Updates document visibility for the recipients
[**UpdateRecipientInitialsImage**](EnvelopesApi.md#updaterecipientinitialsimage) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/initials_image | Sets the initials image for an accountless signer.
[**UpdateRecipientSignatureImage**](EnvelopesApi.md#updaterecipientsignatureimage) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/signature_image | Sets the signature image for an accountless signer.
[**UpdateRecipients**](EnvelopesApi.md#updaterecipients) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients | Updates recipients in a draft envelope or corrects recipient information for an in process envelope.
[**UpdateRecipientsDocumentVisibility**](EnvelopesApi.md#updaterecipientsdocumentvisibility) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/document_visibility | Updates document visibility for the recipients
[**UpdateTabs**](EnvelopesApi.md#updatetabs) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/tabs | Updates the tabs for a recipient.  
[**UpdateTemplateRecipientDocumentVisibility**](EnvelopesApi.md#updatetemplaterecipientdocumentvisibility) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/document_visibility | Updates document visibility for the recipients
[**UpdateTemplateRecipientsDocumentVisibility**](EnvelopesApi.md#updatetemplaterecipientsdocumentvisibility) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients/document_visibility | Updates document visibility for the recipients


<a name="applytemplate"></a>
# **ApplyTemplate**
> DocumentTemplateList ApplyTemplate (DocumentTemplateList documentTemplateList = null, string accountId, string envelopeId)

Adds templates to an envelope.

Adds templates to the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ApplyTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var documentTemplateList = new DocumentTemplateList(); // DocumentTemplateList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Adds templates to an envelope.
                DocumentTemplateList result = apiInstance.ApplyTemplate(documentTemplateList, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ApplyTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentTemplateList** | [**DocumentTemplateList**](DocumentTemplateList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**DocumentTemplateList**](DocumentTemplateList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applytemplatetodocument"></a>
# **ApplyTemplateToDocument**
> DocumentTemplateList ApplyTemplateToDocument (DocumentTemplateList documentTemplateList = null, string accountId, string envelopeId, string documentId)

Adds templates to a document in an  envelope.

Adds templates to a document in the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ApplyTemplateToDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var documentTemplateList = new DocumentTemplateList(); // DocumentTemplateList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Adds templates to a document in an  envelope.
                DocumentTemplateList result = apiInstance.ApplyTemplateToDocument(documentTemplateList, accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ApplyTemplateToDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentTemplateList** | [**DocumentTemplateList**](DocumentTemplateList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**DocumentTemplateList**](DocumentTemplateList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchunkedupload"></a>
# **CreateChunkedUpload**
> ChunkedUploadResponse CreateChunkedUpload (ChunkedUploadRequest chunkedUploadRequest = null, string accountId)

Initiate a new ChunkedUpload.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateChunkedUploadExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var chunkedUploadRequest = new ChunkedUploadRequest(); // ChunkedUploadRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Initiate a new ChunkedUpload.
                ChunkedUploadResponse result = apiInstance.CreateChunkedUpload(chunkedUploadRequest, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateChunkedUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chunkedUploadRequest** | [**ChunkedUploadRequest**](ChunkedUploadRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**ChunkedUploadResponse**](ChunkedUploadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createconsoleview"></a>
# **CreateConsoleView**
> ViewUrl CreateConsoleView (ConsoleViewRequest consoleViewRequest = null, string accountId)

Returns a URL to the authentication view UI.

Returns a URL that allows you to embed the authentication view of the DocuSign UI in your applications.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateConsoleViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var consoleViewRequest = new ConsoleViewRequest(); // ConsoleViewRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Returns a URL to the authentication view UI.
                ViewUrl result = apiInstance.CreateConsoleView(consoleViewRequest, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateConsoleView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **consoleViewRequest** | [**ConsoleViewRequest**](ConsoleViewRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcorrectview"></a>
# **CreateCorrectView**
> ViewUrl CreateCorrectView (CorrectViewRequest correctViewRequest = null, string accountId, string envelopeId)

Returns a URL to the envelope correction UI.

Returns a URL that allows you to embed the envelope correction view of the DocuSign UI in your applications.  Important: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateCorrectViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var correctViewRequest = new CorrectViewRequest(); // CorrectViewRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Returns a URL to the envelope correction UI.
                ViewUrl result = apiInstance.CreateCorrectView(correctViewRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateCorrectView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **correctViewRequest** | [**CorrectViewRequest**](CorrectViewRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomfields"></a>
# **CreateCustomFields**
> CustomFields CreateCustomFields (CustomFields customFields = null, string accountId, string envelopeId)

Updates envelope custom fields for an envelope.

Updates the envelope custom fields for draft and in-process envelopes.  Each custom field used in an envelope must have a unique name.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var customFields = new CustomFields(); // CustomFields |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Updates envelope custom fields for an envelope.
                CustomFields result = apiInstance.CreateCustomFields(customFields, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFields** | [**CustomFields**](CustomFields.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**CustomFields**](CustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdocumentfields"></a>
# **CreateDocumentFields**
> DocumentFieldsInformation CreateDocumentFields (DocumentFieldsInformation documentFieldsInformation = null, string accountId, string envelopeId, string documentId)

Creates custom document fields in an existing envelope document.

Creates custom document fields in an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var documentFieldsInformation = new DocumentFieldsInformation(); // DocumentFieldsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Creates custom document fields in an existing envelope document.
                DocumentFieldsInformation result = apiInstance.CreateDocumentFields(documentFieldsInformation, accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateDocumentFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentFieldsInformation** | [**DocumentFieldsInformation**](DocumentFieldsInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**DocumentFieldsInformation**](DocumentFieldsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createeditview"></a>
# **CreateEditView**
> ViewUrl CreateEditView (ReturnUrlRequest returnUrlRequest = null, string accountId, string envelopeId)

Returns a URL to the edit view UI.

Returns a URL that allows you to embed the edit view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign editing view.   Upon sending completion, the user is returned to the return URL provided by the API application.  Important: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateEditViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var returnUrlRequest = new ReturnUrlRequest(); // ReturnUrlRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Returns a URL to the edit view UI.
                ViewUrl result = apiInstance.CreateEditView(returnUrlRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateEditView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnUrlRequest** | [**ReturnUrlRequest**](ReturnUrlRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemailsettings"></a>
# **CreateEmailSettings**
> EmailSettings CreateEmailSettings (EmailSettings emailSettings = null, string accountId, string envelopeId)

Adds email setting overrides to an envelope.

Adds email override settings, changing the email address to reply to an email address, name, or the BCC for email archive information, for the envelope. Note that adding email settings will only affect email communications that occur after the addition was made.  ### Important: The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, use a Carbon Copies or Certified Deliveries Recipient Type.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateEmailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var emailSettings = new EmailSettings(); // EmailSettings |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Adds email setting overrides to an envelope.
                EmailSettings result = apiInstance.CreateEmailSettings(emailSettings, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateEmailSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailSettings** | [**EmailSettings**](EmailSettings.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EmailSettings**](EmailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createenvelope"></a>
# **CreateEnvelope**
> EnvelopeSummary CreateEnvelope (string cdseMode = null, string changeRoutingOrder = null, string completedDocumentsOnly = null, string mergeRolesOnDraft = null, EnvelopeDefinition envelopeDefinition = null, string accountId)

Creates an envelope.

Creates an envelope.   Using this function you can: * Create an envelope and send it. * Create an envelope from an existing template and send it.  In either case, you can choose to save the envelope as a draft envelope instead of sending it by setting the request’s `status` property to `created` instead of `sent`.  ## Sending Envelopes  Documents can be included with the Envelopes::create call itself or a template can include documents. Documents can be added by using a multi-part/form request or by using the `documentBase64` field of the [`document` object](#/definitions/document)  ### Recipient Types An [`envelopeDefinition` object](#/definitions/envelopeDefinition) is used as the method’s body. Envelope recipients can be defined in the envelope or in templates. The `envelopeDefinition` object’s `recipients` field is an [`EnvelopeRecipients` resource object](#/definitions/EnvelopeRecipients). It includes arrays of the seven types of recipients defined by DocuSign:  Recipient type | Object definition - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- agent (can add name and email information for later recipients/signers) | [`agent`](#/definitions/agent) carbon copy (receives a copy of the documents) | [`carbonCopy`](#/definitions/carbonCopy) certified delivery  (receives a copy of the documents and must acknowledge receipt) | [`certifiedDelivery`](#/definitions/certifiedDelivery) editor (can change recipients and document fields for later recipients/signers) | [`editor`](#/definitions/editor) in-person signer (“hosts” someone who signs in-person) | [`inPersonSigner`](#/definitions/inPersonSigner) intermediary (can add name and email information for some later recipients/signers.) | [`intermediary`](#/definitions/intermediary) signer (signs and/or updates document fields) | [`signer`](#/definitions/signer)  Additional information about the different types of recipients is available from the [`EnvelopeRecipients` resource page](../../EnvelopeRecipients) and from the [Developer Center](https://www.docusign.com/developer-center/explore/features/recipients)  ### Tabs Tabs (also referred to as `tags` and as `fields` in the web sending user interface), can be defined in the `envelopeDefinition`, in templates, by transforming PDF Form Fields, or by using Composite Templates (see below).  Defining tabs: the `inPersonSigner`, and `signer` recipient objects include a `tabs` field. It is an [`EnvelopeTabs` resource object](#/definitions/EnvelopeTabs). It includes arrays of the 24 different tab types available. See the [`EnvelopeTabs` resource](../../EnvelopeTabs) for more information.  ## Using Templates Envelopes use specific people or groups as recipients. Templates can specify a role, eg `account_manager.` When a template is used in an envelope, the roles must be replaced with specific people or groups.  When you create an envelope using a `templateId`, the different recipient type objects within the [`EnvelopeRecipients` object](#/definitions/EnvelopeRecipients) are used to assign recipients to the template’s roles via the `roleName` property. The recipient objects can also override settings that were specified in the template, and set values for tab fields that were defined in the template.  ### Message Lock When a template is added or applied to an envelope and the template has a locked email subject and message, that subject and message are used for the envelope and cannot be changed even if another locked template is subsequently added or applied to the envelope. The field `messageLock` is used to lock the email subject and message.  If an email subject or message is entered before adding or applying a template with `messageLock` **true**, the email subject and message is overwritten with the locked email subject and message from the template.  ## Envelope Status The status of sent envelopes can be determined through the DocuSign webhook system or by polling. Webhooks are highly recommended: they provide your application with the quickest updates when an envelope’s status changes. DocuSign limits polling to once every 15 minutes or less frequently.  When a webhook is used, DocuSign calls your application, via the URL you provide, with a notification XML message.   See the [Webhook recipe](https://www.docusign.com/developer-center/recipes/webhook-status) for examples and live demos of using webhooks.  ## Webhook Options The two webhook options, *eventNotification* and *Connect* use the same notification mechanism and message formats. eventNotification is used to create a webhook for a specific envelope sent via the API. Connect webhooks can be used for any envelope sent from an account, from any user, from any client.   ### eventNotification Webhooks The Envelopes::create method includes an optional [eventNotification object](#definition-eventNotification) that adds a webhook to the envelope. eventNotification webhooks are available for all DocuSign accounts with API access.  ### Connect Webhooks Connect can be used to create a webhook for all envelopes sent by all users in an account, either through the API or via other DocuSign clients (web, mobile, etc). Connect configurations are independent of specific envelopes. A Connect configuration includes a filter that may be used to limit the webhook to specific users, envelope statuses, etc.   Connect configurations may be created and managed using the [ConnectConfigurations resource](../../Connect/ConnectConfigurations). Configurations can also be created and managed from the Administration tool accessed by selecting “Go to Admin” from the menu next to your picture on the DocuSign web app. See the Integrations/Connect section of the Admin tool. For repeatability, and to minimize support questions, creating Connect configurations via the API is recommended, especially for ISVs.  Connect is available for some DocuSign account types. Please contact DocuSign Sales for more information.  ## Composite Templates  The Composite Templates feature, like [compositing in film production](https://en.wikipedia.org/wiki/Compositing), enables you to *overlay* document, recipient, and tab definitions from multiple sources, including PDF Form Field definitions, templates defined on the server, and more.  Each Composite Template consists of optional elements: server templates, inline templates, PDF Metadata templates, and documents.  * The Composite Template ID is an optional element used to identify the composite template. It is used as a reference when adding document object information via a multi-part HTTP message. If used, the document content-disposition must include the `compositeTemplateId` to which the document should be added. If `compositeTemplateId` is not specified in the content-disposition, the document is applied based on the `documentId` only. If no document object is specified, the composite template inherits the first document.  * Server Templates are server-side templates stored on the DocuSign platform. If supplied, they are overlaid into the envelope in the order of their Sequence value.  * Inline Templates provide a container to add documents, recipients, tabs, and custom fields. If inline templates are supplied, they are overlaid into the envelope in the order of their Sequence value.  * Document objects are optional structures that provide a container to pass in a document or form. If this object is not included, the composite template inherits the *first* document it finds from a server template or inline template, starting with the lowest sequence value.  PDF Form objects are only transformed from the document object. DocuSign does not derive PDF form properties from server templates or inline templates. To instruct DocuSign to transform fields from the PDF form, set `transformPdfFields` to \"true\" for the document. See the Transform PDF Fields section for more information about process.  * PDF Metadata Templates provide a container to embed design-time template information into a PDF document. DocuSign uses this information when processing the Envelope. This convention allows the document to carry the signing instructions with it, so that less information needs to be provided at run-time through an inline template or synchronized with an external structure like a server template. PDF Metadata templates are stored in the Metadata layer of a PDF in accordance with Acrobat's XMP specification. DocuSign will only find PDF Metadata templates inside documents passed in the Document object (see below). If supplied, the PDF metadata template will be overlaid into the envelope in the order of its Sequence value.  ### Compositing the definitions Each Composite Template adds a new document and templates overlay into the envelope. For each Composite Template these rules are applied:  * Templates are overlaid in the order of their Sequence value. * If Document is not passed into the Composite Template’s `document` field, the *first* template’s document (based on the template’s Sequence value) is used. * Last in wins in all cases except for the document (i.e. envelope information, recipient information, secure field information). There is no special casing.  For example, if you want higher security on a tab, then that needs to be specified in a later template (by sequence number) then where the tab is included. If you want higher security on a role recipient, then it needs to be in a later template then where that role recipient is specified.  * Recipient matching is based on Recipient Role and Routing Order. If there are matches, the recipient information is merged together. A final pass is done on all Composite Templates, after all template overlays have been applied, to collapse recipients with the same email, username and routing order. This prevents having the same recipients at the same routing order.  * If you specify in a template that a recipient is locked, once that recipient is overlaid the recipient attributes can no longer be changed. The only items that can be changed for the recipient in this case are the email, username, access code and IDCheckInformationInput.  * Tab matching is based on Tab Labels, Tab Types and Documents. If a Tab Label matches but the Document is not supplied, the Tab is overlaid for all the Documents.  For example, if you have a simple inline template with only one tab in it with a label and a value, the Signature, Initial, Company, Envelope ID, User Name tabs will only be matched and collapsed if they fall in the exact same X and Y locations.  * roleName and tabLabel matching is case sensitive.  * The defaultRecipient field enables you to specify which recipient the generated tabs from a PDF form are mapped to. You can also set PDF form generated tabs to a recipient other than the DefaultRecipient by specifying the mapping of the tab label that is created to one of the template recipients.  * You can use tabLabel wild carding to map a series of tabs from the PDF form. To use this you must end a tab label with “\\*” and then the system matches tabs that start with the label.  * If no DefaultRecipient is specified, tabs must be explicitly mapped to recipients in order to be generated from the form. Unmapped form objects will not be generated into their DocuSign equivalents. (In the case of Signature/Initials, the tabs will be disregarded entirely; in the case of pdf text fields, the field data will be flattened on the Envelope document, but there will not be a corresponding DocuSign data tab.)  ### Including the Document Content for Composite Templates Document content can be supplied inline, using the `documentBase64` or can be included in a multi-part HTTP message.  If a multi-part message is used and there are multiple Composite Templates, the document content-disposition can include the `compositeTemplateId` to which the document should be added. Using the `compositeTemplateId` sets which documents are associated with particular composite templates. An example of this usage is:  ```    - -5cd3320a-5aac-4453-b3a4-cbb52a4cba5d    Content-Type: application/pdf    Content-Disposition: file; filename=\"eula.pdf\"; documentId=1; compositeTemplateId=\"1\"    Content-Transfer-Encoding: base64 ```  ### PDF Form Field Transformation Only the following PDF Form FieldTypes will be transformed to DocuSign tabs: CheckBox, DateTime, ListBox, Numeric, Password, Radio, Signature, and Text  Field Properties that will be transformed: Read Only, Required, Max Length, Positions, and Initial Data.  When transforming a *PDF Form Digital Signature Field,* the following rules are used:  If the PDF Field Name Contains | Then the DocuSign Tab Will be - -- -- -- | - -- -- -- - DocuSignSignHere or eSignSignHere | Signature DocuSignSignHereOptional or eSignSignHereOptional | Optional Signature DocuSignInitialHere or eSignInitialHere | Initials DocuSignInitialHereOptional or eSignInitialHereOptional | Optional Initials  Any other PDF Form Digital Signature Field will be transformed to a DocuSign Signature tab  When transforming *PDF Form Text Fields,* the following rules are used:  If the PDF Field Name Contains | Then the DocuSign Tab Will be - -- -- -- | - -- -- -- - DocuSignSignHere or eSignSignHere | Signature DocuSignSignHereOptional or eSignSignHereOptional | Optional Signature DocuSignInitialHere or eSignInitialHere | Initials DocuSignInitialHereOptional or eSignInitialHereOptional | Optional Initials DocuSignEnvelopeID or eSignEnvelopeID | EnvelopeID DocuSignCompany or eSignCompany | Company DocuSignDateSigned or eSignDateSigned | Date Signed DocuSignTitle or eSignTitle | Title DocuSignFullName or eSignFullName |  Full Name DocuSignSignerAttachmentOptional or eSignSignerAttachmentOptional | Optional Signer Attachment  Any other PDF Form Text Field will be transformed to a DocuSign data (text) tab.  PDF Form Field Names that include “DocuSignIgnoreTransform” or “eSignIgnoreTransform” will not be transformed.  PDF Form Date fields will be transformed to Date Signed fields if their name includes DocuSignDateSigned or eSignDateSigned.  ## Template Email Subject Merge Fields This feature enables you to insert recipient name and email address merge fields into the email subject line when creating or sending from a template.  The merge fields, based on the recipient’s `roleName`, are added to the `emailSubject` when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.  Both the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient.  If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.  * To add a recipient’s name in the subject line add the following text in the `emailSubject` when creating the template or when sending an envelope from a template:     [[<roleName>_UserName]]     Example:     `\"emailSubject\":\"[[Signer 1_UserName]], Please sign this NDA\",`  * To add a recipient’s email address in the subject line add the following text in the emailSubject when creating the template or when sending an envelope from a template:     [[<roleName>_Email]]     Example:     `\"emailSubject\":\"[[Signer 1_Email]], Please sign this NDA\",`  In both cases the <roleName> is the recipient’s `roleName` in the template.  For cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[<roleName>_UserName]] or [[<roleName>_Email]] is shown in the email subject.  ## Branding an envelope The following rules are used to determine the `brandId` used in an envelope:  * If a `brandId` is specified in the envelope/template and that brandId is available to the account, that brand is used in the envelope. * If more than one template is used in an envelope and more than one `brandId` is specified, the first `brandId` specified is used throughout the envelope. * In cases where no brand is specified and the sender belongs to a Group; if there is only one brand associated with the Group, then that brand is used in the envelope. Otherwise, the account’s default signing brand is used. * For envelopes that do not meet any of the previous criteria, the account’s default signing brand is used for the envelope.  ## BCC Email address feature  The BCC Email address feature is designed to provide a copy of all email communications for external archiving purposes. DocuSign recommends that envelopes sent using the BCC for Email Archive feature, including the BCC Email Override option, include additional signer authentication options. To send a copy of the envelope to a recipient who does not need to sign, don’t use the BCC Email field. Use a Carbon Copy or Certified Delivery Recipient type.  ## Merge Recipient Roles for Draft Envelopes When an envelope with multiple templates is sent, the recipients from the templates are merged according to the template roles, and empty recipients are removed. When creating an envelope with multiple templates, but not sending it (keeping it in a created state), duplicate recipients are not merged, which could cause leave duplicate recipients in the envelope.  To prevent this, the query parameter `merge_roles_on_draft` should be added when posting a draft envelope (status=created) with multiple templates. Doing this will merge template roles and remove empty recipients.  ###### Note: DocuSign recommends that the `merge_roles_on_draft` query parameter be used anytime you are creating an envelope with multiple templates and keeping it in draft (created) status.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateEnvelopeExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var cdseMode = cdseMode_example;  // string |  (optional) 
            var changeRoutingOrder = changeRoutingOrder_example;  // string |  (optional) 
            var completedDocumentsOnly = completedDocumentsOnly_example;  // string | If set to true then we want to set the sourceEnvelopeId to indicate that this is a\"forward\" envelope action (optional) 
            var mergeRolesOnDraft = mergeRolesOnDraft_example;  // string | When set to **true**, merges template roles and remove empty recipients when you create an envelope with multiple templates. (optional) 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Creates an envelope.
                EnvelopeSummary result = apiInstance.CreateEnvelope(cdseMode, changeRoutingOrder, completedDocumentsOnly, mergeRolesOnDraft, envelopeDefinition, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateEnvelope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cdseMode** | **string**|  | [optional] 
 **changeRoutingOrder** | **string**|  | [optional] 
 **completedDocumentsOnly** | **string**| If set to true then we want to set the sourceEnvelopeId to indicate that this is a\&quot;forward\&quot; envelope action | [optional] 
 **mergeRolesOnDraft** | **string**| When set to **true**, merges template roles and remove empty recipients when you create an envelope with multiple templates. | [optional] 
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**EnvelopeSummary**](EnvelopeSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlock"></a>
# **CreateLock**
> LockInformation CreateLock (LockRequest lockRequest = null, string accountId, string envelopeId)

Lock an envelope.

Locks the specified envelope, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the envelope.  ###### Note: Users must have envelope locking capability enabled to use this function (userSetting `canLockEnvelopes` must be  set to true for the user).

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateLockExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Lock an envelope.
                LockInformation result = apiInstance.CreateLock(lockRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateLock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockRequest** | [**LockRequest**](LockRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**LockInformation**](LockInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrecipient"></a>
# **CreateRecipient**
> Recipients CreateRecipient (string resendEnvelope = null, Recipients recipients = null, string accountId, string envelopeId)

Adds one or more recipients to an envelope.

Adds one or more recipients to an envelope.  For an in process envelope, one that has been sent and has not been completed or voided, an email is sent to a new recipient when they are reached in the routing order. If the new recipient's routing order is before or the same as the envelope's next recipient, an email is only sent if the optional `resend_envelope` query string is set to **true**.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateRecipientExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var resendEnvelope = resendEnvelope_example;  // string | When set to **true**, resends the   envelope if the new recipient's routing order is before or the same as the envelope’s next recipient. (optional) 
            var recipients = new Recipients(); // Recipients |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Adds one or more recipients to an envelope.
                Recipients result = apiInstance.CreateRecipient(resendEnvelope, recipients, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resendEnvelope** | **string**| When set to **true**, resends the   envelope if the new recipient&#39;s routing order is before or the same as the envelope’s next recipient. | [optional] 
 **recipients** | [**Recipients**](Recipients.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**Recipients**](Recipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrecipientview"></a>
# **CreateRecipientView**
> ViewUrl CreateRecipientView (RecipientViewRequest recipientViewRequest = null, string accountId, string envelopeId)

Returns a URL to the recipient view UI.

Returns a URL that allows you to embed the recipient view of the DocuSign UI in your applications. This call cannot be used to view draft envelopes, since those envelopes have not been sent.   Important: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView.   An entry is added into the Security Level section of the DocuSign Certificate of Completion that reflects the `securityDomain` and `authenticationMethod` properties used to verify the user identity.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateRecipientViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var recipientViewRequest = new RecipientViewRequest(); // RecipientViewRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Returns a URL to the recipient view UI.
                ViewUrl result = apiInstance.CreateRecipientView(recipientViewRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateRecipientView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipientViewRequest** | [**RecipientViewRequest**](RecipientViewRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsenderview"></a>
# **CreateSenderView**
> ViewUrl CreateSenderView (ReturnUrlRequest returnUrlRequest = null, string accountId, string envelopeId)

Returns a URL to the sender view UI.

Returns a URL that allows you to embed the sender view of the DocuSign UI in your applications. This is a one-time use login token that allows the user to be placed into the DocuSign sending view.   Upon sending completion, the user is returned to the return URL provided by the API application.  Important: iFrames should not be used for embedded operations on mobile devices due to screen space issues. For iOS devices DocuSign recommends using a WebView. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateSenderViewExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var returnUrlRequest = new ReturnUrlRequest(); // ReturnUrlRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Returns a URL to the sender view UI.
                ViewUrl result = apiInstance.CreateSenderView(returnUrlRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateSenderView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **returnUrlRequest** | [**ReturnUrlRequest**](ReturnUrlRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtabs"></a>
# **CreateTabs**
> Tabs CreateTabs (Tabs tabs = null, string accountId, string envelopeId, string recipientId)

Adds tabs for a recipient.

Adds one or more tabs for a recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var tabs = new Tabs(); // Tabs |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Adds tabs for a recipient.
                Tabs result = apiInstance.CreateTabs(tabs, accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tabs** | [**Tabs**](Tabs.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createviewlink"></a>
# **CreateViewLink**
> ViewUrl CreateViewLink (ViewLinkRequest viewLinkRequest = null, string accountId, string envelopeId)

Reserved: Returns a URL to the secure link view UI.

Reserved: Returns a URL that allows you to embed the secure link view of the DocuSign UI in your applications.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateViewLinkExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var viewLinkRequest = new ViewLinkRequest(); // ViewLinkRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Reserved: Returns a URL to the secure link view UI.
                ViewUrl result = apiInstance.CreateViewLink(viewLinkRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.CreateViewLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewLinkRequest** | [**ViewLinkRequest**](ViewLinkRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteattachments"></a>
# **DeleteAttachments**
> EnvelopeAttachmentsResult DeleteAttachments (EnvelopeAttachmentsRequest envelopeAttachmentsRequest = null, string accountId, string envelopeId)

Delete one or more attachments from a DRAFT envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteAttachmentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var envelopeAttachmentsRequest = new EnvelopeAttachmentsRequest(); // EnvelopeAttachmentsRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Delete one or more attachments from a DRAFT envelope.
                EnvelopeAttachmentsResult result = apiInstance.DeleteAttachments(envelopeAttachmentsRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **envelopeAttachmentsRequest** | [**EnvelopeAttachmentsRequest**](EnvelopeAttachmentsRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeAttachmentsResult**](EnvelopeAttachmentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechunkedupload"></a>
# **DeleteChunkedUpload**
> ChunkedUploadResponse DeleteChunkedUpload (string accountId, string chunkedUploadId)

Delete an existing ChunkedUpload.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteChunkedUploadExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadId = chunkedUploadId_example;  // string | 

            try
            {
                // Delete an existing ChunkedUpload.
                ChunkedUploadResponse result = apiInstance.DeleteChunkedUpload(accountId, chunkedUploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteChunkedUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadId** | **string**|  | 

### Return type

[**ChunkedUploadResponse**](ChunkedUploadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomfields"></a>
# **DeleteCustomFields**
> CustomFields DeleteCustomFields (CustomFields customFields = null, string accountId, string envelopeId)

Deletes envelope custom fields for draft and in-process envelopes.

Deletes envelope custom fields for draft and in-process envelopes.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var customFields = new CustomFields(); // CustomFields |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Deletes envelope custom fields for draft and in-process envelopes.
                CustomFields result = apiInstance.DeleteCustomFields(customFields, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFields** | [**CustomFields**](CustomFields.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**CustomFields**](CustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentfields"></a>
# **DeleteDocumentFields**
> DocumentFieldsInformation DeleteDocumentFields (DocumentFieldsInformation documentFieldsInformation = null, string accountId, string envelopeId, string documentId)

Deletes custom document fields from an existing envelope document.

Deletes custom document fields from an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var documentFieldsInformation = new DocumentFieldsInformation(); // DocumentFieldsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Deletes custom document fields from an existing envelope document.
                DocumentFieldsInformation result = apiInstance.DeleteDocumentFields(documentFieldsInformation, accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteDocumentFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentFieldsInformation** | [**DocumentFieldsInformation**](DocumentFieldsInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**DocumentFieldsInformation**](DocumentFieldsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocumentpage"></a>
# **DeleteDocumentPage**
> void DeleteDocumentPage (string accountId, string envelopeId, string documentId, string pageNumber)

Deletes a page from a document in an envelope.

Deletes a page from a document in an envelope based on the page number.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteDocumentPageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Deletes a page from a document in an envelope.
                apiInstance.DeleteDocumentPage(accountId, envelopeId, documentId, pageNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteDocumentPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **pageNumber** | **string**| The page number being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocuments"></a>
# **DeleteDocuments**
> EnvelopeDocumentsResult DeleteDocuments (EnvelopeDefinition envelopeDefinition = null, string accountId, string envelopeId)

Deletes documents from a draft envelope.

Deletes one or more documents from an existing draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Deletes documents from a draft envelope.
                EnvelopeDocumentsResult result = apiInstance.DeleteDocuments(envelopeDefinition, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeDocumentsResult**](EnvelopeDocumentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailsettings"></a>
# **DeleteEmailSettings**
> EmailSettings DeleteEmailSettings (string accountId, string envelopeId)

Deletes the email setting overrides for an envelope.

Deletes all existing email override settings for the envelope. If you want to delete an individual email override setting, use the PUT and set the value to an empty string. Note that deleting email settings will only affect email communications that occur after the deletion and the normal account email settings are used for future email communications.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteEmailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Deletes the email setting overrides for an envelope.
                EmailSettings result = apiInstance.DeleteEmailSettings(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteEmailSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EmailSettings**](EmailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelock"></a>
# **DeleteLock**
> LockInformation DeleteLock (string accountId, string envelopeId)

Deletes an envelope lock.

Deletes the lock from the specified envelope. The `X-DocuSign-Edit` header must be included in the request.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteLockExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Deletes an envelope lock.
                LockInformation result = apiInstance.DeleteLock(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteLock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**LockInformation**](LockInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterecipient"></a>
# **DeleteRecipient**
> Recipients DeleteRecipient (string accountId, string envelopeId, string recipientId)

Deletes a recipient from an envelope.

Deletes the specified recipient file from the specified envelope. This cannot be used if the envelope has been sent.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteRecipientExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Deletes a recipient from an envelope.
                Recipients result = apiInstance.DeleteRecipient(accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**Recipients**](Recipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterecipients"></a>
# **DeleteRecipients**
> Recipients DeleteRecipients (Recipients recipients = null, string accountId, string envelopeId)

Deletes recipients from an envelope.

Deletes one or more recipients from a draft or sent envelope. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.  If the envelope is `In Process`, meaning that it has been sent and has not  been completed or voided, recipients that have completed their actions cannot be deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var recipients = new Recipients(); // Recipients |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Deletes recipients from an envelope.
                Recipients result = apiInstance.DeleteRecipients(recipients, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipients** | [**Recipients**](Recipients.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**Recipients**](Recipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetabs"></a>
# **DeleteTabs**
> Tabs DeleteTabs (Tabs tabs = null, string accountId, string envelopeId, string recipientId)

Deletes the tabs associated with a recipient.

Deletes one or more tabs associated with a recipient in a draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var tabs = new Tabs(); // Tabs |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Deletes the tabs associated with a recipient.
                Tabs result = apiInstance.DeleteTabs(tabs, accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tabs** | [**Tabs**](Tabs.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplatesfromdocument"></a>
# **DeleteTemplatesFromDocument**
> void DeleteTemplatesFromDocument (string accountId, string envelopeId, string documentId, string templateId)

Deletes a template from a document in an existing envelope.

Deletes the specified template from a document in an existing envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteTemplatesFromDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Deletes a template from a document in an existing envelope.
                apiInstance.DeleteTemplatesFromDocument(accountId, envelopeId, documentId, templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteTemplatesFromDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteviewlink"></a>
# **DeleteViewLink**
> void DeleteViewLink (string accountId, string envelopeId)

Reserved: Expires a secure view link.

Reserved: Expires a secure view link

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteViewLinkExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Reserved: Expires a secure view link.
                apiInstance.DeleteViewLink(accountId, envelopeId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.DeleteViewLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachment"></a>
# **GetAttachment**
> void GetAttachment (string accountId, string envelopeId, string attachmentId)

Retrieves an attachment from the envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetAttachmentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var attachmentId = attachmentId_example;  // string | 

            try
            {
                // Retrieves an attachment from the envelope.
                apiInstance.GetAttachment(accountId, envelopeId, attachmentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **attachmentId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattachments"></a>
# **GetAttachments**
> EnvelopeAttachmentsResult GetAttachments (string accountId, string envelopeId)

Returns a list of attachments associated with the specified envelope

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetAttachmentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Returns a list of attachments associated with the specified envelope
                EnvelopeAttachmentsResult result = apiInstance.GetAttachments(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeAttachmentsResult**](EnvelopeAttachmentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchunkedupload"></a>
# **GetChunkedUpload**
> ChunkedUploadResponse GetChunkedUpload (string include = null, string accountId, string chunkedUploadId)

Retrieves the current metadata of a ChunkedUpload.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetChunkedUploadExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var include = include_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadId = chunkedUploadId_example;  // string | 

            try
            {
                // Retrieves the current metadata of a ChunkedUpload.
                ChunkedUploadResponse result = apiInstance.GetChunkedUpload(include, accountId, chunkedUploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetChunkedUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadId** | **string**|  | 

### Return type

[**ChunkedUploadResponse**](ChunkedUploadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsumerdisclosure"></a>
# **GetConsumerDisclosure**
> ConsumerDisclosure GetConsumerDisclosure (string langCode2 = null, string accountId, string envelopeId, string recipientId, string langCode)

Reserved: Gets the Electronic Record and Signature Disclosure associated with the account.

Reserved: Retrieves the Electronic Record and Signature Disclosure, with HTML formatting, associated with the account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetConsumerDisclosureExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var langCode2 = langCode_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.
            var langCode = langCode_example;  // string | The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to �browser� to automatically detect the browser language being used by the viewer and display the disclosure in that language.

            try
            {
                // Reserved: Gets the Electronic Record and Signature Disclosure associated with the account.
                ConsumerDisclosure result = apiInstance.GetConsumerDisclosure(langCode2, accountId, envelopeId, recipientId, langCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetConsumerDisclosure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **langCode2** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 
 **langCode** | **string**| The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to �browser� to automatically detect the browser language being used by the viewer and display the disclosure in that language. | 

### Return type

[**ConsumerDisclosure**](ConsumerDisclosure.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsumerdisclosuredefault"></a>
# **GetConsumerDisclosureDefault**
> ConsumerDisclosure GetConsumerDisclosureDefault (string langCode = null, string accountId, string envelopeId, string recipientId)

Gets the Electronic Record and Signature Disclosure associated with the account.

Retrieves the Electronic Record and Signature Disclosure, with html formatting, associated with the account. You can use an optional query string to set the language for the disclosure.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetConsumerDisclosureDefaultExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var langCode = langCode_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Gets the Electronic Record and Signature Disclosure associated with the account.
                ConsumerDisclosure result = apiInstance.GetConsumerDisclosureDefault(langCode, accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetConsumerDisclosureDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **langCode** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**ConsumerDisclosure**](ConsumerDisclosure.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> System.IO.Stream GetDocument (string certificate = null, string encoding = null, string encrypt = null, string language = null, string recipientId = null, string showChanges = null, string watermark = null, string accountId, string envelopeId, string documentId)

Gets a document from an envelope.

Retrieves the specified document from the envelope. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.  You can also use this method to retrieve a PDF containing the combined content of all documents and the certificate. If the account has the Highlight Data Changes feature enabled, there is an option to request that any changes in the envelope be highlighted.   To retrieve the combined content replace the `{documentId}` parameter in the endpoint with `combined`. /accounts/{accountId}/envelopes/{envelopeId}/documents/combined

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var certificate = certificate_example;  // string | When set to **false**, the envelope signing certificate is removed from the download. (optional) 
            var encoding = encoding_example;  // string |  (optional) 
            var encrypt = encrypt_example;  // string | When set to **true**, the PDF bytes returned in the response are encrypted for all the key managers configured on your DocuSign account. The documents can be decrypted with the KeyManager Decrypt Document API. (optional) 
            var language = language_example;  // string | Specifies the language for the Certificate of Completion in the response. The supported languages, with the language value shown in parenthesis, are: Chinese Simplified (zh_CN), , Chinese Traditional (zh_TW), Dutch (nl), English US (en), French (fr), German (de), Italian (it), Japanese (ja), Korean (ko), Portuguese (pt), Portuguese (Brazil) (pt_BR), Russian (ru), Spanish (es).  (optional) 
            var recipientId = recipientId_example;  // string |  (optional) 
            var showChanges = showChanges_example;  // string | When set to **true**, any changed fields for the returned PDF are highlighted in yellow and optional signatures or initials outlined in red.  (optional) 
            var watermark = watermark_example;  // string | When set to **true**, the account has the watermark feature enabled, and the envelope is not complete, the watermark for the account is added to the PDF documents. This option can remove the watermark.  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Gets a document from an envelope.
                System.IO.Stream result = apiInstance.GetDocument(certificate, encoding, encrypt, language, recipientId, showChanges, watermark, accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **certificate** | **string**| When set to **false**, the envelope signing certificate is removed from the download. | [optional] 
 **encoding** | **string**|  | [optional] 
 **encrypt** | **string**| When set to **true**, the PDF bytes returned in the response are encrypted for all the key managers configured on your DocuSign account. The documents can be decrypted with the KeyManager Decrypt Document API. | [optional] 
 **language** | **string**| Specifies the language for the Certificate of Completion in the response. The supported languages, with the language value shown in parenthesis, are: Chinese Simplified (zh_CN), , Chinese Traditional (zh_TW), Dutch (nl), English US (en), French (fr), German (de), Italian (it), Japanese (ja), Korean (ko), Portuguese (pt), Portuguese (Brazil) (pt_BR), Russian (ru), Spanish (es).  | [optional] 
 **recipientId** | **string**|  | [optional] 
 **showChanges** | **string**| When set to **true**, any changed fields for the returned PDF are highlighted in yellow and optional signatures or initials outlined in red.  | [optional] 
 **watermark** | **string**| When set to **true**, the account has the watermark feature enabled, and the envelope is not complete, the watermark for the account is added to the PDF documents. This option can remove the watermark.  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentpageimage"></a>
# **GetDocumentPageImage**
> System.IO.Stream GetDocumentPageImage (string dpi = null, string maxHeight = null, string maxWidth = null, string showChanges = null, string accountId, string envelopeId, string documentId, string pageNumber)

Gets a page image from an envelope for display.

Retrieves a page image for display from the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetDocumentPageImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var dpi = dpi_example;  // string | Sets the dpi for the image. (optional) 
            var maxHeight = maxHeight_example;  // string | Sets the maximum height for the page image in pixels. The dpi is recalculated based on this setting. (optional) 
            var maxWidth = maxWidth_example;  // string | Sets the maximum width for the page image in pixels. The dpi is recalculated based on this setting. (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Gets a page image from an envelope for display.
                System.IO.Stream result = apiInstance.GetDocumentPageImage(dpi, maxHeight, maxWidth, showChanges, accountId, envelopeId, documentId, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetDocumentPageImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dpi** | **string**| Sets the dpi for the image. | [optional] 
 **maxHeight** | **string**| Sets the maximum height for the page image in pixels. The dpi is recalculated based on this setting. | [optional] 
 **maxWidth** | **string**| Sets the maximum width for the page image in pixels. The dpi is recalculated based on this setting. | [optional] 
 **showChanges** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **pageNumber** | **string**| The page number being accessed. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/png

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumenttabs"></a>
# **GetDocumentTabs**
> Tabs GetDocumentTabs (string pageNumbers = null, string accountId, string envelopeId, string documentId)

Returns tabs on the document.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetDocumentTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var pageNumbers = pageNumbers_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Returns tabs on the document.
                Tabs result = apiInstance.GetDocumentTabs(pageNumbers, accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetDocumentTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageNumbers** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailsettings"></a>
# **GetEmailSettings**
> EmailSettings GetEmailSettings (string accountId, string envelopeId)

Gets the email setting overrides for an envelope.

Retrieves the email override settings for the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetEmailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Gets the email setting overrides for an envelope.
                EmailSettings result = apiInstance.GetEmailSettings(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetEmailSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EmailSettings**](EmailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenvelope"></a>
# **GetEnvelope**
> Envelope GetEnvelope (string advancedUpdate = null, string include = null, string accountId, string envelopeId)

Gets the status of a envelope.

Retrieves the overall status for the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetEnvelopeExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var advancedUpdate = advancedUpdate_example;  // string | When true, envelope information can be added or modified. (optional) 
            var include = include_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Gets the status of a envelope.
                Envelope result = apiInstance.GetEnvelope(advancedUpdate, include, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetEnvelope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **advancedUpdate** | **string**| When true, envelope information can be added or modified. | [optional] 
 **include** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**Envelope**](Envelope.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getformdata"></a>
# **GetFormData**
> EnvelopeFormData GetFormData (string accountId, string envelopeId)

Returns envelope form data for an existing envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetFormDataExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Returns envelope form data for an existing envelope.
                EnvelopeFormData result = apiInstance.GetFormData(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetFormData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeFormData**](EnvelopeFormData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlock"></a>
# **GetLock**
> LockInformation GetLock (string accountId, string envelopeId)

Gets envelope lock information.

Retrieves general information about the envelope lock.  If the call is made by the locked by user and the request has the same integrator key as original, then the `X-DocuSign-Edit` header and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetLockExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Gets envelope lock information.
                LockInformation result = apiInstance.GetLock(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetLock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**LockInformation**](LockInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnotificationsettings"></a>
# **GetNotificationSettings**
> Notification GetNotificationSettings (string accountId, string envelopeId)

Gets envelope notification information.

Retrieves the envelope notification, reminders and expirations, information for an existing envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetNotificationSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Gets envelope notification information.
                Notification result = apiInstance.GetNotificationSettings(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetNotificationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpagetabs"></a>
# **GetPageTabs**
> Tabs GetPageTabs (string accountId, string envelopeId, string documentId, string pageNumber)

Returns tabs on the specified page.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetPageTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Returns tabs on the specified page.
                Tabs result = apiInstance.GetPageTabs(accountId, envelopeId, documentId, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetPageTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **pageNumber** | **string**| The page number being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpages"></a>
# **GetPages**
> PageImages GetPages (string count = null, string dpi = null, string maxHeight = null, string maxWidth = null, string nocache = null, string showChanges = null, string startPosition = null, string accountId, string envelopeId, string documentId)

Returns document page image(s) based on input.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetPagesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var count = count_example;  // string |  (optional) 
            var dpi = dpi_example;  // string |  (optional) 
            var maxHeight = maxHeight_example;  // string |  (optional) 
            var maxWidth = maxWidth_example;  // string |  (optional) 
            var nocache = nocache_example;  // string |  (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Returns document page image(s) based on input.
                PageImages result = apiInstance.GetPages(count, dpi, maxHeight, maxWidth, nocache, showChanges, startPosition, accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetPages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **string**|  | [optional] 
 **dpi** | **string**|  | [optional] 
 **maxHeight** | **string**|  | [optional] 
 **maxWidth** | **string**|  | [optional] 
 **nocache** | **string**|  | [optional] 
 **showChanges** | **string**|  | [optional] 
 **startPosition** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**PageImages**](PageImages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecipientdocumentvisibility"></a>
# **GetRecipientDocumentVisibility**
> DocumentVisibilityList GetRecipientDocumentVisibility (string accountId, string envelopeId, string recipientId)

Returns document visibility for the recipients

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetRecipientDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Returns document visibility for the recipients
                DocumentVisibilityList result = apiInstance.GetRecipientDocumentVisibility(accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetRecipientDocumentVisibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**DocumentVisibilityList**](DocumentVisibilityList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecipientinitialsimage"></a>
# **GetRecipientInitialsImage**
> System.IO.Stream GetRecipientInitialsImage (string includeChrome = null, string accountId, string envelopeId, string recipientId)

Gets the initials image for a user.

Retrieves the initials image for the specified user. The image is returned in the same format as it was uploaded. In the request you can specify if the chrome (the added line and identifier around the initial image) is returned with the image.  The userId specified in the endpoint must match the authenticated user's user id and the user must be a member of the account.  The `signatureIdOrName` paramter accepts signature ID or signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly URL encode. If you use the user name, it is likely that the name includes spaces and you might need to URL encode the name before using it in the endpoint.   For example: \"Bob Smith\" to \"Bob%20Smith\"  Older envelopes might only contain chromed images. If getting the non-chromed image fails, try getting the chromed image.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetRecipientInitialsImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var includeChrome = includeChrome_example;  // string | The added line and identifier around the initial image. Note: Older envelopes might only have chromed images. If getting the non-chromed image fails, try getting the chromed image. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Gets the initials image for a user.
                System.IO.Stream result = apiInstance.GetRecipientInitialsImage(includeChrome, accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetRecipientInitialsImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeChrome** | **string**| The added line and identifier around the initial image. Note: Older envelopes might only have chromed images. If getting the non-chromed image fails, try getting the chromed image. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/gif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecipientsignature"></a>
# **GetRecipientSignature**
> UserSignature GetRecipientSignature (string accountId, string envelopeId, string recipientId)

Gets signature information for a signer or sign-in-person recipient.

Retrieves signature information for a signer or sign-in-person recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetRecipientSignatureExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Gets signature information for a signer or sign-in-person recipient.
                UserSignature result = apiInstance.GetRecipientSignature(accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetRecipientSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**UserSignature**](UserSignature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecipientsignatureimage"></a>
# **GetRecipientSignatureImage**
> System.IO.Stream GetRecipientSignatureImage (string includeChrome = null, string accountId, string envelopeId, string recipientId)

Retrieve signature image information for a signer/sign-in-person recipient.

Retrieves the specified user signature image. The image is returned in the same format as uploaded. In the request you can specify if the chrome (the added line and identifier around the initial image) is returned with the image.  The userId specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureIdOrName` parameter accepts signature ID or signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that don't properly URL encode. If you use the user name, it is likely that the name includes spaces and you might need to URL encode the name before using it in the endpoint.   For example: \"Bob Smith\" to \"Bob%20Smith\"  Older envelopes might only have chromed images. If getting the non-chromed image fails, try getting the chromed image.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetRecipientSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var includeChrome = includeChrome_example;  // string | When set to **true**, indicates the chromed version of the signature image should be retrieved. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Retrieve signature image information for a signer/sign-in-person recipient.
                System.IO.Stream result = apiInstance.GetRecipientSignatureImage(includeChrome, accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetRecipientSignatureImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeChrome** | **string**| When set to **true**, indicates the chromed version of the signature image should be retrieved. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/gif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplaterecipientdocumentvisibility"></a>
# **GetTemplateRecipientDocumentVisibility**
> DocumentVisibilityList GetTemplateRecipientDocumentVisibility (string accountId, string templateId, string recipientId)

Returns document visibility for the recipients

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetTemplateRecipientDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Returns document visibility for the recipients
                DocumentVisibilityList result = apiInstance.GetTemplateRecipientDocumentVisibility(accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.GetTemplateRecipientDocumentVisibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**DocumentVisibilityList**](DocumentVisibilityList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listauditevents"></a>
# **ListAuditEvents**
> EnvelopeAuditEventResponse ListAuditEvents (string accountId, string envelopeId)

Gets the envelope audit events for an envelope.

Gets the envelope audit events for the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListAuditEventsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Gets the envelope audit events for an envelope.
                EnvelopeAuditEventResponse result = apiInstance.ListAuditEvents(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListAuditEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeAuditEventResponse**](EnvelopeAuditEventResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcustomfields"></a>
# **ListCustomFields**
> CustomFieldsEnvelope ListCustomFields (string accountId, string envelopeId)

Gets the custom field information for the specified envelope.

Retrieves the custom field information for the specified envelope. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes, and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.  There are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. With a list custom field, the sender selects the value of the field from a pre-made list.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Gets the custom field information for the specified envelope.
                CustomFieldsEnvelope result = apiInstance.ListCustomFields(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**CustomFieldsEnvelope**](CustomFieldsEnvelope.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdocumentfields"></a>
# **ListDocumentFields**
> DocumentFieldsInformation ListDocumentFields (string accountId, string envelopeId, string documentId)

Gets the custom document fields from an  existing envelope document.

Retrieves the custom document field information from an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Gets the custom document fields from an  existing envelope document.
                DocumentFieldsInformation result = apiInstance.ListDocumentFields(accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListDocumentFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**DocumentFieldsInformation**](DocumentFieldsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdocuments"></a>
# **ListDocuments**
> EnvelopeDocumentsResult ListDocuments (string accountId, string envelopeId)

Gets a list of envelope documents.

Retrieves a list of documents associated with the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Gets a list of envelope documents.
                EnvelopeDocumentsResult result = apiInstance.ListDocuments(accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeDocumentsResult**](EnvelopeDocumentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrecipients"></a>
# **ListRecipients**
> Recipients ListRecipients (string includeAnchorTabLocations = null, string includeExtended = null, string includeTabs = null, string accountId, string envelopeId)

Gets the status of recipients for an envelope.

Retrieves the status of all recipients in a single envelope and identifies the current recipient in the routing list.   The `currentRoutingOrder` property of the response contains the `routingOrder` value of the current recipient indicating that the envelope has been sent to the recipient, but the recipient has not completed their actions.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var includeAnchorTabLocations = includeAnchorTabLocations_example;  // string |  When set to **true** and `include_tabs` is set to **true**, all tabs with anchor tab properties are included in the response.  (optional) 
            var includeExtended = includeExtended_example;  // string |  When set to **true**, the extended properties are included in the response.  (optional) 
            var includeTabs = includeTabs_example;  // string | When set to **true**, the tab information associated with the recipient is included in the response. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Gets the status of recipients for an envelope.
                Recipients result = apiInstance.ListRecipients(includeAnchorTabLocations, includeExtended, includeTabs, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeAnchorTabLocations** | **string**|  When set to **true** and &#x60;include_tabs&#x60; is set to **true**, all tabs with anchor tab properties are included in the response.  | [optional] 
 **includeExtended** | **string**|  When set to **true**, the extended properties are included in the response.  | [optional] 
 **includeTabs** | **string**| When set to **true**, the tab information associated with the recipient is included in the response. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**Recipients**](Recipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststatus"></a>
# **ListStatus**
> EnvelopesInformation ListStatus (string email = null, string fromDate = null, string startPosition = null, string toDate = null, EnvelopeIdsRequest envelopeIdsRequest = null, string accountId)

Gets the envelope status for the specified envelopes.

Retrieves the envelope status for the specified envelopes.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListStatusExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var email = email_example;  // string |  (optional) 
            var fromDate = fromDate_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string |  (optional) 
            var toDate = toDate_example;  // string |  (optional) 
            var envelopeIdsRequest = new EnvelopeIdsRequest(); // EnvelopeIdsRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets the envelope status for the specified envelopes.
                EnvelopesInformation result = apiInstance.ListStatus(email, fromDate, startPosition, toDate, envelopeIdsRequest, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  | [optional] 
 **fromDate** | **string**|  | [optional] 
 **startPosition** | **string**|  | [optional] 
 **toDate** | **string**|  | [optional] 
 **envelopeIdsRequest** | [**EnvelopeIdsRequest**](EnvelopeIdsRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**EnvelopesInformation**](EnvelopesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststatuschanges"></a>
# **ListStatusChanges**
> EnvelopesInformation ListStatusChanges (string acStatus = null, string block = null, string count = null, string customField = null, string email = null, string envelopeIds = null, string fromDate = null, string fromToStatus = null, string startPosition = null, string status = null, string toDate = null, string transactionIds = null, string userName = null, string accountId)

Gets status changes for one or more envelopes.

Retrieves envelope status changes for all envelopes. You can modify the information returned by adding query strings to limit the request to check between certain dates and times, or for certain envelopes, or for certain status codes. It is recommended that you use one or more of the query strings in order to limit the size of the response.  ### Important: Unless you are requesting the status for specific envelopes (using the `envelopeIds` or `transactionIds` properties), you must add a set the `from_date` property in the request.  Getting envelope status using `transactionIds` is useful for offline signing situations where it can be used determine if an envelope was created or not, for the cases where a network connection was lost, before the envelope status could be returned.  ### Request Envelope Status Notes ###  The REST API GET /envelopes call uses certain filters to find results. In some cases requests are check for \"any status change\" instead of the just the single status requested. In these cases, more envelopes might be returned by the request than otherwise would be. For example, for a request with the begin date is set to Jan 1st, an end date set to Jan 7th and the status qualifier (`from_to_status`) set to `Delivered` &mdash; the response set might contain envelopes that were created during that time period, but not delivered during the time period.  To avoid unnecessary database queries, the DocuSign system checks requests to ensure that the added filters will not result in a zero-size response before acting on the request. The following table shows the valid envelope statuses (in the Valid Current Statuses column) for the status qualifiers in the request. If the status and status qualifiers in the API request do not contain any of the values shown in the valid current statuses column, then an empty list is returned.  For example, a request with a status qualifier (from_to_status) of `Delivered` and a status of \"`Created`,`Sent`\", DocuSign will always return an empty list. This is because the request essentially translates to: find the envelopes that were delivered between the begin and end dates that have a current status of `Created` or `Sent`, and since an envelope that has been delivered can never have a status of `Created` or `Sent`, a zero-size response would be generated. In this case, DocuSign does not run the request, but just returns the empty list.  Client applications should check that the statuses they are requesting make sense for a given status qualifier.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListStatusChangesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var acStatus = acStatus_example;  // string | Specifies the Authoritative Copy Status for the envelopes. The possible values are: Unknown, Original, Transferred, AuthoritativeCopy, AuthoritativeCopyExportPending, AuthoritativeCopyExported, DepositPending, Deposited, DepositedEO, or DepositFailed. (optional) 
            var block = block_example;  // string |  (optional) 
            var count = count_example;  // string |  (optional) 
            var customField = customField_example;  // string | This specifies the envelope custom field name and value searched for in the envelope information. The value portion of the query can use partial strings by adding '%' (percent sign) around the custom field query value.   Example 1: If you have an envelope custom field called \"Region\" and you want to search for all envelopes where the value is \"West\" you would use the query: `?custom_field=Region=West`.   Example 2: To search for envelopes where the `ApplicationID` custom field has the value or partial value of \"DocuSign\" in field, the query would be: `?custom_field=ApplicationId=%DocuSign%` This would find envelopes where the custom field value is \"DocuSign for Salesforce\" or \"DocuSign envelope.\"   (optional) 
            var email = email_example;  // string |  (optional) 
            var envelopeIds = envelopeIds_example;  // string |  (optional) 
            var fromDate = fromDate_example;  // string | The date/time setting that specifies the date/time when the request begins checking for status changes for envelopes in the account.  This is required unless 'envelopeId's are used. (optional) 
            var fromToStatus = fromToStatus_example;  // string | This is the status type checked for in the `from_date`/`to_date` period. If `changed` is specified, then envelopes that changed status during the period are found. If for example, `created` is specified, then envelopes created during the period are found. Default is `changed`.   Possible values are: Voided, Changed, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut and Processing. (optional) 
            var startPosition = startPosition_example;  // string |  (optional) 
            var status = status_example;  // string | The list of current statuses to include in the response. By default, all envelopes found are returned. If values are specified, then of the envelopes found, only those with the current status specified are returned in the results.   Possible values are: Voided, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut and Processing. (optional) 
            var toDate = toDate_example;  // string | Optional date/time setting that specifies the date/time when the request stops for status changes for envelopes in the account. If no entry, the system uses the time of the call as the `to_date`.  (optional) 
            var transactionIds = transactionIds_example;  // string | If included in the query string, this is a comma separated list of envelope `transactionId`s.   If included in the `request_body`, this is a list of envelope `transactionId`s.   ###### Note: `transactionId`s are only valid in the DocuSign system for seven days.  (optional) 
            var userName = userName_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets status changes for one or more envelopes.
                EnvelopesInformation result = apiInstance.ListStatusChanges(acStatus, block, count, customField, email, envelopeIds, fromDate, fromToStatus, startPosition, status, toDate, transactionIds, userName, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListStatusChanges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **acStatus** | **string**| Specifies the Authoritative Copy Status for the envelopes. The possible values are: Unknown, Original, Transferred, AuthoritativeCopy, AuthoritativeCopyExportPending, AuthoritativeCopyExported, DepositPending, Deposited, DepositedEO, or DepositFailed. | [optional] 
 **block** | **string**|  | [optional] 
 **count** | **string**|  | [optional] 
 **customField** | **string**| This specifies the envelope custom field name and value searched for in the envelope information. The value portion of the query can use partial strings by adding &#39;%&#39; (percent sign) around the custom field query value.   Example 1: If you have an envelope custom field called \&quot;Region\&quot; and you want to search for all envelopes where the value is \&quot;West\&quot; you would use the query: &#x60;?custom_field&#x3D;Region&#x3D;West&#x60;.   Example 2: To search for envelopes where the &#x60;ApplicationID&#x60; custom field has the value or partial value of \&quot;DocuSign\&quot; in field, the query would be: &#x60;?custom_field&#x3D;ApplicationId&#x3D;%DocuSign%&#x60; This would find envelopes where the custom field value is \&quot;DocuSign for Salesforce\&quot; or \&quot;DocuSign envelope.\&quot;   | [optional] 
 **email** | **string**|  | [optional] 
 **envelopeIds** | **string**|  | [optional] 
 **fromDate** | **string**| The date/time setting that specifies the date/time when the request begins checking for status changes for envelopes in the account.  This is required unless &#39;envelopeId&#39;s are used. | [optional] 
 **fromToStatus** | **string**| This is the status type checked for in the &#x60;from_date&#x60;/&#x60;to_date&#x60; period. If &#x60;changed&#x60; is specified, then envelopes that changed status during the period are found. If for example, &#x60;created&#x60; is specified, then envelopes created during the period are found. Default is &#x60;changed&#x60;.   Possible values are: Voided, Changed, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut and Processing. | [optional] 
 **startPosition** | **string**|  | [optional] 
 **status** | **string**| The list of current statuses to include in the response. By default, all envelopes found are returned. If values are specified, then of the envelopes found, only those with the current status specified are returned in the results.   Possible values are: Voided, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut and Processing. | [optional] 
 **toDate** | **string**| Optional date/time setting that specifies the date/time when the request stops for status changes for envelopes in the account. If no entry, the system uses the time of the call as the &#x60;to_date&#x60;.  | [optional] 
 **transactionIds** | **string**| If included in the query string, this is a comma separated list of envelope &#x60;transactionId&#x60;s.   If included in the &#x60;request_body&#x60;, this is a list of envelope &#x60;transactionId&#x60;s.   ###### Note: &#x60;transactionId&#x60;s are only valid in the DocuSign system for seven days.  | [optional] 
 **userName** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**EnvelopesInformation**](EnvelopesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtabs"></a>
# **ListTabs**
> Tabs ListTabs (string includeAnchorTabLocations = null, string includeMetadata = null, string accountId, string envelopeId, string recipientId)

Gets the tabs information for a signer or sign-in-person recipient in an envelope.

Retrieves information about the tabs associated with a recipient in a draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var includeAnchorTabLocations = includeAnchorTabLocations_example;  // string | When set to **true**, all tabs with anchor tab properties are included in the response.  (optional) 
            var includeMetadata = includeMetadata_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Gets the tabs information for a signer or sign-in-person recipient in an envelope.
                Tabs result = apiInstance.ListTabs(includeAnchorTabLocations, includeMetadata, accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeAnchorTabLocations** | **string**| When set to **true**, all tabs with anchor tab properties are included in the response.  | [optional] 
 **includeMetadata** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtemplates"></a>
# **ListTemplates**
> TemplateInformation ListTemplates (string include = null, string accountId, string envelopeId)

Get List of Templates used in an Envelope

This returns a list of the server-side templates, their name and ID, used in an envelope. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListTemplatesExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var include = include_example;  // string | The possible values are:  matching_applied – This returns template matching information for the template. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Get List of Templates used in an Envelope
                TemplateInformation result = apiInstance.ListTemplates(include, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include** | **string**| The possible values are:  matching_applied – This returns template matching information for the template. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**TemplateInformation**](TemplateInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtemplatesfordocument"></a>
# **ListTemplatesForDocument**
> TemplateInformation ListTemplatesForDocument (string include = null, string accountId, string envelopeId, string documentId)

Gets the templates associated with a document in an existing envelope.

Retrieves the templates associated with a document in the specified envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListTemplatesForDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var include = include_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Gets the templates associated with a document in an existing envelope.
                TemplateInformation result = apiInstance.ListTemplatesForDocument(include, accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.ListTemplatesForDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**TemplateInformation**](TemplateInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putattachment"></a>
# **PutAttachment**
> EnvelopeAttachmentsResult PutAttachment (Attachment attachment = null, string accountId, string envelopeId, string attachmentId)

Add an attachment to a DRAFT or IN-PROCESS envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class PutAttachmentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var attachment = new Attachment(); // Attachment |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var attachmentId = attachmentId_example;  // string | 

            try
            {
                // Add an attachment to a DRAFT or IN-PROCESS envelope.
                EnvelopeAttachmentsResult result = apiInstance.PutAttachment(attachment, accountId, envelopeId, attachmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.PutAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachment** | [**Attachment**](Attachment.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **attachmentId** | **string**|  | 

### Return type

[**EnvelopeAttachmentsResult**](EnvelopeAttachmentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putattachments"></a>
# **PutAttachments**
> EnvelopeAttachmentsResult PutAttachments (EnvelopeAttachmentsRequest envelopeAttachmentsRequest = null, string accountId, string envelopeId)

Add one or more attachments to a DRAFT or IN-PROCESS envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class PutAttachmentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var envelopeAttachmentsRequest = new EnvelopeAttachmentsRequest(); // EnvelopeAttachmentsRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Add one or more attachments to a DRAFT or IN-PROCESS envelope.
                EnvelopeAttachmentsResult result = apiInstance.PutAttachments(envelopeAttachmentsRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.PutAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **envelopeAttachmentsRequest** | [**EnvelopeAttachmentsRequest**](EnvelopeAttachmentsRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeAttachmentsResult**](EnvelopeAttachmentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rotatedocumentpage"></a>
# **RotateDocumentPage**
> void RotateDocumentPage (PageRequest pageRequest = null, string accountId, string envelopeId, string documentId, string pageNumber)

Rotates page image from an envelope for display.

Rotates page image from an envelope for display. The page image can be rotated to the left or right.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class RotateDocumentPageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var pageRequest = new PageRequest(); // PageRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Rotates page image from an envelope for display.
                apiInstance.RotateDocumentPage(pageRequest, accountId, envelopeId, documentId, pageNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.RotateDocumentPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageRequest** | [**PageRequest**](PageRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 
 **pageNumber** | **string**| The page number being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> EnvelopeUpdateSummary Update (string advancedUpdate = null, string resendEnvelope = null, Envelope envelope = null, string accountId, string envelopeId)

Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft

The Put Envelopes endpoint provides the following functionality:  * Sends the specified single draft envelope. Add {\"status\":\"sent\"} to the request body to send the envelope.  * Voids the specified in-process envelope. Add {\"status\":\"voided\", \"voidedReason\":\"The reason for voiding the envelope\"} to the request body to void the envelope.  * Replaces the current email subject and message for a draft envelope. Add {\"emailSubject\":\"subject\",  \"emailBlurb\":\"message\"}  to the request body to modify the subject and message.  * Place the envelope documents and envelope metadata in a purge queue so that this information is removed from the DocuSign system. Add {\"purgeState\":\"purge type\"} to the request body.  *Additional information on purging documents*  The purge request can only be used for completed envelopes that are not marked as the authoritative copy. The requesting user must have permission to purge documents and must be the sender (the requesting user can act as the sender using Send On Behalf Of).  ###### Note: If you have set the Document Retention policy on your account, envelope documents are automatically placed in the purge queue and the warning emails are sent at the end of the retention period.  ###### Note: You can set the Document Retention policy in the Classic DocuSign Experience by specifying the number of days to retain documents.  ###### Note: Setting a Document Retention policy is the same as setting a schedule for purging documents.  When the purge request is initiated the envelope documents, or documents and envelope metadata, are placed in a purge queue for deletion in 14 days. A warning email notification is sent to the sender and recipients associated with the envelope, notifying them that the envelope documents will be deleted in 14 days and providing a link to the documents. A second email is sent 7 days later with the same message. At the end of the 14-day period, the envelope documents are deleted from the system.  If `purgeState=\"documents_queued\"` is used in the request, then only the documents are deleted and any corresponding attachments and tabs remain in the DocuSign system. If `purgeState= \"documents_and_metadata_queued\"` is used in the request, then the documents, attachments, and tabs are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var advancedUpdate = advancedUpdate_example;  // string | When set to **true**, allows the caller to update recipients, tabs, custom fields, notification, email settings and other envelope attributes. (optional) 
            var resendEnvelope = resendEnvelope_example;  // string | When set to **true**, sends the specified envelope again. (optional) 
            var envelope = new Envelope(); // Envelope |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Send Draft Envelope/Void Envelope/Move/Purge Envelope/Modify draft
                EnvelopeUpdateSummary result = apiInstance.Update(advancedUpdate, resendEnvelope, envelope, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **advancedUpdate** | **string**| When set to **true**, allows the caller to update recipients, tabs, custom fields, notification, email settings and other envelope attributes. | [optional] 
 **resendEnvelope** | **string**| When set to **true**, sends the specified envelope again. | [optional] 
 **envelope** | [**Envelope**](Envelope.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeUpdateSummary**](EnvelopeUpdateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechunkedupload"></a>
# **UpdateChunkedUpload**
> ChunkedUploadResponse UpdateChunkedUpload (string action = null, string accountId, string chunkedUploadId)

Integrity-Check and Commit a ChunkedUpload, readying it for use elsewhere.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateChunkedUploadExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var action = action_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadId = chunkedUploadId_example;  // string | 

            try
            {
                // Integrity-Check and Commit a ChunkedUpload, readying it for use elsewhere.
                ChunkedUploadResponse result = apiInstance.UpdateChunkedUpload(action, accountId, chunkedUploadId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateChunkedUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadId** | **string**|  | 

### Return type

[**ChunkedUploadResponse**](ChunkedUploadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechunkeduploadpart"></a>
# **UpdateChunkedUploadPart**
> ChunkedUploadResponse UpdateChunkedUploadPart (ChunkedUploadRequest chunkedUploadRequest = null, string accountId, string chunkedUploadId, string chunkedUploadPartSeq)

Add a chunk, a chunk 'part', to an existing ChunkedUpload.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateChunkedUploadPartExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var chunkedUploadRequest = new ChunkedUploadRequest(); // ChunkedUploadRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var chunkedUploadId = chunkedUploadId_example;  // string | 
            var chunkedUploadPartSeq = chunkedUploadPartSeq_example;  // string | 

            try
            {
                // Add a chunk, a chunk 'part', to an existing ChunkedUpload.
                ChunkedUploadResponse result = apiInstance.UpdateChunkedUploadPart(chunkedUploadRequest, accountId, chunkedUploadId, chunkedUploadPartSeq);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateChunkedUploadPart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chunkedUploadRequest** | [**ChunkedUploadRequest**](ChunkedUploadRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **chunkedUploadId** | **string**|  | 
 **chunkedUploadPartSeq** | **string**|  | 

### Return type

[**ChunkedUploadResponse**](ChunkedUploadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomfields"></a>
# **UpdateCustomFields**
> CustomFields UpdateCustomFields (CustomFields customFields = null, string accountId, string envelopeId)

Updates envelope custom fields in an envelope.

Updates the envelope custom fields in draft and in-process envelopes.  Each custom field used in an envelope must have a unique name. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var customFields = new CustomFields(); // CustomFields |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Updates envelope custom fields in an envelope.
                CustomFields result = apiInstance.UpdateCustomFields(customFields, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFields** | [**CustomFields**](CustomFields.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**CustomFields**](CustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocument"></a>
# **UpdateDocument**
> void UpdateDocument (string applyDocumentFields = null, string accountId, string envelopeId, string documentId)

Adds a document to an existing draft envelope.

Adds a document to an existing draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var applyDocumentFields = applyDocumentFields_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Adds a document to an existing draft envelope.
                apiInstance.UpdateDocument(applyDocumentFields, accountId, envelopeId, documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applyDocumentFields** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocumentfields"></a>
# **UpdateDocumentFields**
> DocumentFieldsInformation UpdateDocumentFields (DocumentFieldsInformation documentFieldsInformation = null, string accountId, string envelopeId, string documentId)

Updates existing custom document fields in an existing envelope document.

Updates existing custom document fields in an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateDocumentFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var documentFieldsInformation = new DocumentFieldsInformation(); // DocumentFieldsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Updates existing custom document fields in an existing envelope document.
                DocumentFieldsInformation result = apiInstance.UpdateDocumentFields(documentFieldsInformation, accountId, envelopeId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateDocumentFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentFieldsInformation** | [**DocumentFieldsInformation**](DocumentFieldsInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**DocumentFieldsInformation**](DocumentFieldsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocuments"></a>
# **UpdateDocuments**
> EnvelopeDocumentsResult UpdateDocuments (string applyDocumentFields = null, EnvelopeDefinition envelopeDefinition = null, string accountId, string envelopeId)

Adds one or more documents to an existing envelope document.

Adds one or more documents to an existing envelope document.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateDocumentsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var applyDocumentFields = applyDocumentFields_example;  // string | When true, Document fields can be added or modified while adding or modifying envelope documents. (optional) 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Adds one or more documents to an existing envelope document.
                EnvelopeDocumentsResult result = apiInstance.UpdateDocuments(applyDocumentFields, envelopeDefinition, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applyDocumentFields** | **string**| When true, Document fields can be added or modified while adding or modifying envelope documents. | [optional] 
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EnvelopeDocumentsResult**](EnvelopeDocumentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailsettings"></a>
# **UpdateEmailSettings**
> EmailSettings UpdateEmailSettings (EmailSettings emailSettings = null, string accountId, string envelopeId)

Updates the email setting overrides for an envelope.

Updates the existing email override settings for the specified envelope. Note that modifying email settings will only affect email communications that occur after the modification was made.  This can also be used to delete an individual email override setting by using an empty string for the value to be deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateEmailSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var emailSettings = new EmailSettings(); // EmailSettings |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Updates the email setting overrides for an envelope.
                EmailSettings result = apiInstance.UpdateEmailSettings(emailSettings, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateEmailSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailSettings** | [**EmailSettings**](EmailSettings.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**EmailSettings**](EmailSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelock"></a>
# **UpdateLock**
> LockInformation UpdateLock (LockRequest lockRequest = null, string accountId, string envelopeId)

Updates an envelope lock.

Updates the lock duration time or update the `lockedByApp` property information for the specified envelope. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateLockExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Updates an envelope lock.
                LockInformation result = apiInstance.UpdateLock(lockRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateLock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockRequest** | [**LockRequest**](LockRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**LockInformation**](LockInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatenotificationsettings"></a>
# **UpdateNotificationSettings**
> Notification UpdateNotificationSettings (EnvelopeNotificationRequest envelopeNotificationRequest = null, string accountId, string envelopeId)

Sets envelope notification (Reminders/Expirations) structure for an existing envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateNotificationSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var envelopeNotificationRequest = new EnvelopeNotificationRequest(); // EnvelopeNotificationRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Sets envelope notification (Reminders/Expirations) structure for an existing envelope.
                Notification result = apiInstance.UpdateNotificationSettings(envelopeNotificationRequest, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateNotificationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **envelopeNotificationRequest** | [**EnvelopeNotificationRequest**](EnvelopeNotificationRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecipientdocumentvisibility"></a>
# **UpdateRecipientDocumentVisibility**
> DocumentVisibilityList UpdateRecipientDocumentVisibility (DocumentVisibilityList documentVisibilityList = null, string accountId, string envelopeId, string recipientId)

Updates document visibility for the recipients

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateRecipientDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var documentVisibilityList = new DocumentVisibilityList(); // DocumentVisibilityList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Updates document visibility for the recipients
                DocumentVisibilityList result = apiInstance.UpdateRecipientDocumentVisibility(documentVisibilityList, accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateRecipientDocumentVisibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentVisibilityList** | [**DocumentVisibilityList**](DocumentVisibilityList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**DocumentVisibilityList**](DocumentVisibilityList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecipientinitialsimage"></a>
# **UpdateRecipientInitialsImage**
> void UpdateRecipientInitialsImage (string accountId, string envelopeId, string recipientId)

Sets the initials image for an accountless signer.

Updates the initials image for a signer that does not have a DocuSign account. The supported image formats for this file are: gif, png, jpeg, and bmp. The file size must be less than 200K.  For the Authentication/Authorization for this call, the credentials must match the sender of the envelope, the recipient must be an accountless signer or in person signer. The account must have the `CanSendEnvelope` property set to **true** and the `ExpressSendOnly` property in `SendingUser` structure must be set to **false**.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateRecipientInitialsImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Sets the initials image for an accountless signer.
                apiInstance.UpdateRecipientInitialsImage(accountId, envelopeId, recipientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateRecipientInitialsImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecipientsignatureimage"></a>
# **UpdateRecipientSignatureImage**
> void UpdateRecipientSignatureImage (string accountId, string envelopeId, string recipientId)

Sets the signature image for an accountless signer.

Updates the signature image for an accountless signer. The supported image formats for this file are: gif, png, jpeg, and bmp. The file size must be less than 200K.  For the Authentication/Authorization for this call, the credentials must match the sender of the envelope, the recipient must be an accountless signer or in person signer. The account must have the `CanSendEnvelope` property set to **true** and the `ExpressSendOnly` property in `SendingUser` structure must be set to **false**.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateRecipientSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Sets the signature image for an accountless signer.
                apiInstance.UpdateRecipientSignatureImage(accountId, envelopeId, recipientId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateRecipientSignatureImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecipients"></a>
# **UpdateRecipients**
> RecipientsUpdateSummary UpdateRecipients (string resendEnvelope = null, Recipients recipients = null, string accountId, string envelopeId)

Updates recipients in a draft envelope or corrects recipient information for an in process envelope.

Updates recipients in a draft envelope or corrects recipient information for an in process envelope.   For draft envelopes, you can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.  Once an envelope has been sent, you can only edit: `email`, `userName`, `signerName`, `routingOrder`, `faxNumber`, and `deliveryMethod`. You can also select to resend an envelope by using the `resend_envelope` option.  If you send information for a recipient that does not already exist in a draft envelope, the recipient is added to the envelope (similar to the POST).

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var resendEnvelope = resendEnvelope_example;  // string | When set to **true**, resends the   envelope if the new recipient's routing order is before or the same as the envelope’s next recipient. (optional) 
            var recipients = new Recipients(); // Recipients |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Updates recipients in a draft envelope or corrects recipient information for an in process envelope.
                RecipientsUpdateSummary result = apiInstance.UpdateRecipients(resendEnvelope, recipients, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resendEnvelope** | **string**| When set to **true**, resends the   envelope if the new recipient&#39;s routing order is before or the same as the envelope’s next recipient. | [optional] 
 **recipients** | [**Recipients**](Recipients.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**RecipientsUpdateSummary**](RecipientsUpdateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecipientsdocumentvisibility"></a>
# **UpdateRecipientsDocumentVisibility**
> DocumentVisibilityList UpdateRecipientsDocumentVisibility (DocumentVisibilityList documentVisibilityList = null, string accountId, string envelopeId)

Updates document visibility for the recipients

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateRecipientsDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var documentVisibilityList = new DocumentVisibilityList(); // DocumentVisibilityList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.

            try
            {
                // Updates document visibility for the recipients
                DocumentVisibilityList result = apiInstance.UpdateRecipientsDocumentVisibility(documentVisibilityList, accountId, envelopeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateRecipientsDocumentVisibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentVisibilityList** | [**DocumentVisibilityList**](DocumentVisibilityList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 

### Return type

[**DocumentVisibilityList**](DocumentVisibilityList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetabs"></a>
# **UpdateTabs**
> Tabs UpdateTabs (Tabs tabs = null, string accountId, string envelopeId, string recipientId)

Updates the tabs for a recipient.  

Updates one or more tabs for a recipient in a draft envelope.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateTabsExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var tabs = new Tabs(); // Tabs |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Updates the tabs for a recipient.  
                Tabs result = apiInstance.UpdateTabs(tabs, accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tabs** | [**Tabs**](Tabs.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **envelopeId** | **string**| The envelopeId Guid of the envelope being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplaterecipientdocumentvisibility"></a>
# **UpdateTemplateRecipientDocumentVisibility**
> TemplateDocumentVisibilityList UpdateTemplateRecipientDocumentVisibility (TemplateDocumentVisibilityList templateDocumentVisibilityList = null, string accountId, string templateId, string recipientId)

Updates document visibility for the recipients

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateTemplateRecipientDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var templateDocumentVisibilityList = new TemplateDocumentVisibilityList(); // TemplateDocumentVisibilityList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Updates document visibility for the recipients
                TemplateDocumentVisibilityList result = apiInstance.UpdateTemplateRecipientDocumentVisibility(templateDocumentVisibilityList, accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateTemplateRecipientDocumentVisibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateDocumentVisibilityList** | [**TemplateDocumentVisibilityList**](TemplateDocumentVisibilityList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**TemplateDocumentVisibilityList**](TemplateDocumentVisibilityList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplaterecipientsdocumentvisibility"></a>
# **UpdateTemplateRecipientsDocumentVisibility**
> TemplateDocumentVisibilityList UpdateTemplateRecipientsDocumentVisibility (TemplateDocumentVisibilityList templateDocumentVisibilityList = null, string accountId, string templateId)

Updates document visibility for the recipients

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateTemplateRecipientsDocumentVisibilityExample
    {
        public void main()
        {
            
            var apiInstance = new EnvelopesApi();
            var templateDocumentVisibilityList = new TemplateDocumentVisibilityList(); // TemplateDocumentVisibilityList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Updates document visibility for the recipients
                TemplateDocumentVisibilityList result = apiInstance.UpdateTemplateRecipientsDocumentVisibility(templateDocumentVisibilityList, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnvelopesApi.UpdateTemplateRecipientsDocumentVisibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateDocumentVisibilityList** | [**TemplateDocumentVisibilityList**](TemplateDocumentVisibilityList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**TemplateDocumentVisibilityList**](TemplateDocumentVisibilityList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

