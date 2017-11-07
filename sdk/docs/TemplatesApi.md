# DocuSign.eSign.Api.TemplatesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomFields**](TemplatesApi.md#createcustomfields) | **POST** /v2/accounts/{accountId}/templates/{templateId}/custom_fields | Creates custom document fields in an existing template document.
[**CreateDocumentFields**](TemplatesApi.md#createdocumentfields) | **POST** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields | Creates custom document fields in an existing template document.
[**CreateEditView**](TemplatesApi.md#createeditview) | **POST** /v2/accounts/{accountId}/templates/{templateId}/views/edit | Provides a URL to start an edit view of the Template UI
[**CreateLock**](TemplatesApi.md#createlock) | **POST** /v2/accounts/{accountId}/templates/{templateId}/lock | Lock a template.
[**CreateRecipients**](TemplatesApi.md#createrecipients) | **POST** /v2/accounts/{accountId}/templates/{templateId}/recipients | Adds tabs for a recipient.
[**CreateTabs**](TemplatesApi.md#createtabs) | **POST** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs | Adds tabs for a recipient.
[**CreateTemplate**](TemplatesApi.md#createtemplate) | **POST** /v2/accounts/{accountId}/templates | Creates an envelope from a template.
[**DeleteBulkRecipients**](TemplatesApi.md#deletebulkrecipients) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/bulk_recipients | Deletes the bulk recipient list on a template.
[**DeleteCustomFields**](TemplatesApi.md#deletecustomfields) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/custom_fields | Deletes envelope custom fields in a template.
[**DeleteDocumentFields**](TemplatesApi.md#deletedocumentfields) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields | Deletes custom document fields from an existing template document.
[**DeleteDocumentPage**](TemplatesApi.md#deletedocumentpage) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber} | Deletes a page from a document in an template.
[**DeleteDocuments**](TemplatesApi.md#deletedocuments) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/documents | Deletes documents from a template.
[**DeleteGroupShare**](TemplatesApi.md#deletegroupshare) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/{templatePart} | Removes a member group&#39;s sharing permissions for a template.
[**DeleteLock**](TemplatesApi.md#deletelock) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/lock | Deletes a template lock.
[**DeleteRecipient**](TemplatesApi.md#deleterecipient) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId} | Deletes the specified recipient file from a template.
[**DeleteRecipients**](TemplatesApi.md#deleterecipients) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/recipients | Deletes recipients from a template.
[**DeleteTabs**](TemplatesApi.md#deletetabs) | **DELETE** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs | Deletes the tabs associated with a recipient in a template.
[**Get**](TemplatesApi.md#get) | **GET** /v2/accounts/{accountId}/templates/{templateId} | Gets a list of templates for a specified account.
[**GetDocument**](TemplatesApi.md#getdocument) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId} | Gets PDF documents from a template.
[**GetDocumentPageImage**](TemplatesApi.md#getdocumentpageimage) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}/page_image | Gets a page image from a template for display.
[**GetDocumentTabs**](TemplatesApi.md#getdocumenttabs) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/tabs | Returns tabs on the document.
[**GetLock**](TemplatesApi.md#getlock) | **GET** /v2/accounts/{accountId}/templates/{templateId}/lock | Gets template lock information.
[**GetNotificationSettings**](TemplatesApi.md#getnotificationsettings) | **GET** /v2/accounts/{accountId}/templates/{templateId}/notification | Gets template notification information.
[**GetPageTabs**](TemplatesApi.md#getpagetabs) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}/tabs | Returns tabs on the specified page.
[**GetPages**](TemplatesApi.md#getpages) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages | Returns document page image(s) based on input.
[**ListBulkRecipients**](TemplatesApi.md#listbulkrecipients) | **GET** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/bulk_recipients | Gets the bulk recipient file from a template.
[**ListCustomFields**](TemplatesApi.md#listcustomfields) | **GET** /v2/accounts/{accountId}/templates/{templateId}/custom_fields | Gets the custom document fields from a template.
[**ListDocumentFields**](TemplatesApi.md#listdocumentfields) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields | Gets the custom document fields for a an existing template document.
[**ListDocuments**](TemplatesApi.md#listdocuments) | **GET** /v2/accounts/{accountId}/templates/{templateId}/documents | Gets a list of documents associated with a template.
[**ListRecipients**](TemplatesApi.md#listrecipients) | **GET** /v2/accounts/{accountId}/templates/{templateId}/recipients | Gets recipient information from a template.
[**ListTabs**](TemplatesApi.md#listtabs) | **GET** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs | Gets the tabs information for a signer or sign-in-person recipient in a template.
[**ListTemplates**](TemplatesApi.md#listtemplates) | **GET** /v2/accounts/{accountId}/templates | Gets the definition of a template.
[**RotateDocumentPage**](TemplatesApi.md#rotatedocumentpage) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}/page_image | Rotates page image from a template for display.
[**Update**](TemplatesApi.md#update) | **PUT** /v2/accounts/{accountId}/templates/{templateId} | Updates an existing template.
[**UpdateBulkRecipients**](TemplatesApi.md#updatebulkrecipients) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/bulk_recipients | Adds or replaces the bulk recipients list in a template.
[**UpdateCustomFields**](TemplatesApi.md#updatecustomfields) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/custom_fields | Updates envelope custom fields in a template.
[**UpdateDocument**](TemplatesApi.md#updatedocument) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId} | Adds a document to a template document.
[**UpdateDocumentFields**](TemplatesApi.md#updatedocumentfields) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/fields | Updates existing custom document fields in an existing template document.
[**UpdateDocuments**](TemplatesApi.md#updatedocuments) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/documents | Adds documents to a template document.
[**UpdateGroupShare**](TemplatesApi.md#updategroupshare) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/{templatePart} | Shares a template with a group
[**UpdateLock**](TemplatesApi.md#updatelock) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/lock | Updates a template lock.
[**UpdateNotificationSettings**](TemplatesApi.md#updatenotificationsettings) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/notification | Updates the notification  structure for an existing template.
[**UpdateRecipients**](TemplatesApi.md#updaterecipients) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients | Updates recipients in a template.
[**UpdateTabs**](TemplatesApi.md#updatetabs) | **PUT** /v2/accounts/{accountId}/templates/{templateId}/recipients/{recipientId}/tabs | Updates the tabs for a recipient.


<a name="createcustomfields"></a>
# **CreateCustomFields**
> CustomFields CreateCustomFields (TemplateCustomFields templateCustomFields = null, string accountId, string templateId)

Creates custom document fields in an existing template document.

Creates custom document fields in an existing template document.

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
            
            var apiInstance = new TemplatesApi();
            var templateCustomFields = new TemplateCustomFields(); // TemplateCustomFields |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Creates custom document fields in an existing template document.
                CustomFields result = apiInstance.CreateCustomFields(templateCustomFields, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateCustomFields** | [**TemplateCustomFields**](TemplateCustomFields.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

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
> DocumentFieldsInformation CreateDocumentFields (DocumentFieldsInformation documentFieldsInformation = null, string accountId, string templateId, string documentId)

Creates custom document fields in an existing template document.

Creates custom document fields in an existing template document.

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
            
            var apiInstance = new TemplatesApi();
            var documentFieldsInformation = new DocumentFieldsInformation(); // DocumentFieldsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Creates custom document fields in an existing template document.
                DocumentFieldsInformation result = apiInstance.CreateDocumentFields(documentFieldsInformation, accountId, templateId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateDocumentFields: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
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
> ViewUrl CreateEditView (ReturnUrlRequest returnUrlRequest = null, string accountId, string templateId)

Provides a URL to start an edit view of the Template UI

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
            
            var apiInstance = new TemplatesApi();
            var returnUrlRequest = new ReturnUrlRequest(); // ReturnUrlRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Provides a URL to start an edit view of the Template UI
                ViewUrl result = apiInstance.CreateEditView(returnUrlRequest, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateEditView: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**ViewUrl**](ViewUrl.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlock"></a>
# **CreateLock**
> LockInformation CreateLock (LockRequest lockRequest = null, string accountId, string templateId)

Lock a template.

Locks the specified template, and sets the time until the lock expires, to prevent other users or recipients from accessing and changing the template.  ###### Note: Users must have envelope locking capability enabled to use this function (the userSetting property `canLockEnvelopes` must be set to **true** for the user).

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
            
            var apiInstance = new TemplatesApi();
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Lock a template.
                LockInformation result = apiInstance.CreateLock(lockRequest, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateLock: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**LockInformation**](LockInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createrecipients"></a>
# **CreateRecipients**
> Recipients CreateRecipients (string resendEnvelope = null, TemplateRecipients templateRecipients = null, string accountId, string templateId)

Adds tabs for a recipient.

Adds one or more recipients to a template.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var resendEnvelope = resendEnvelope_example;  // string |  (optional) 
            var templateRecipients = new TemplateRecipients(); // TemplateRecipients |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Adds tabs for a recipient.
                Recipients result = apiInstance.CreateRecipients(resendEnvelope, templateRecipients, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resendEnvelope** | **string**|  | [optional] 
 **templateRecipients** | [**TemplateRecipients**](TemplateRecipients.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**Recipients**](Recipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtabs"></a>
# **CreateTabs**
> Tabs CreateTabs (TemplateTabs templateTabs = null, string accountId, string templateId, string recipientId)

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
            
            var apiInstance = new TemplatesApi();
            var templateTabs = new TemplateTabs(); // TemplateTabs |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Adds tabs for a recipient.
                Tabs result = apiInstance.CreateTabs(templateTabs, accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateTabs** | [**TemplateTabs**](TemplateTabs.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplate"></a>
# **CreateTemplate**
> TemplateSummary CreateTemplate (EnvelopeTemplate envelopeTemplate = null, string accountId)

Creates an envelope from a template.

Creates a template definition using a multipart request.  ###Template Email Subject Merge Fields  Call this endpoint to insert a recipient name and email address merge fields into the email subject line when creating or sending from a template.  The merge fields, based on the recipient’s role name, are added to the `emailSubject` property when the template is created or when the template is used to create an envelope. After a template sender adds the name and email information for the recipient and sends the envelope, the recipient information is automatically merged into the appropriate fields in the email subject line.  Both the sender and the recipients will see the information in the email subject line for any emails associated with the template. This provides an easy way for senders to organize their envelope emails without having to open an envelope to check the recipient. ###### Note: If merging the recipient information into the subject line causes the subject line to exceed 100 characters, then any characters over the 100 character limit are not included in the subject line. For cases where the recipient name or email is expected to be long, you should consider placing the merge field at the start of the email subject.  To add a recipient’s name in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:  [[<roleName>_UserName]]  Example:  `\"emailSubject\":\"[[Signer 1_UserName]], Please sign this NDA\",`  To add a recipient’s email address in the subject line add the following text in the `emailSubject` property when creating the template or when sending an envelope from a template:  [[<roleName>_Email]]  Example:  `\"emailSubject\":\"[[Signer 1_Email]], Please sign this NDA\",`   In both cases the <roleName> is the recipient's contents of the `roleName` property in the template.  For cases where another recipient (such as an Agent, Editor, or Intermediary recipient) is entering the name and email information for the recipient included in the email subject, then [[<roleName>_UserName]] or [[<roleName>_Email]] is shown in the email subject.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateTemplateExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var envelopeTemplate = new EnvelopeTemplate(); // EnvelopeTemplate |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Creates an envelope from a template.
                TemplateSummary result = apiInstance.CreateTemplate(envelopeTemplate, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.CreateTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **envelopeTemplate** | [**EnvelopeTemplate**](EnvelopeTemplate.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**TemplateSummary**](TemplateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebulkrecipients"></a>
# **DeleteBulkRecipients**
> BulkRecipientsUpdateResponse DeleteBulkRecipients (string accountId, string templateId, string recipientId)

Deletes the bulk recipient list on a template.

Deletes the bulk recipient list on a template.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteBulkRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Deletes the bulk recipient list on a template.
                BulkRecipientsUpdateResponse result = apiInstance.DeleteBulkRecipients(accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteBulkRecipients: " + e.Message );
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

[**BulkRecipientsUpdateResponse**](BulkRecipientsUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomfields"></a>
# **DeleteCustomFields**
> CustomFields DeleteCustomFields (TemplateCustomFields templateCustomFields = null, string accountId, string templateId)

Deletes envelope custom fields in a template.

Deletes envelope custom fields in a template.

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
            
            var apiInstance = new TemplatesApi();
            var templateCustomFields = new TemplateCustomFields(); // TemplateCustomFields |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Deletes envelope custom fields in a template.
                CustomFields result = apiInstance.DeleteCustomFields(templateCustomFields, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateCustomFields** | [**TemplateCustomFields**](TemplateCustomFields.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

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
> DocumentFieldsInformation DeleteDocumentFields (DocumentFieldsInformation documentFieldsInformation = null, string accountId, string templateId, string documentId)

Deletes custom document fields from an existing template document.

Deletes custom document fields from an existing template document.

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
            
            var apiInstance = new TemplatesApi();
            var documentFieldsInformation = new DocumentFieldsInformation(); // DocumentFieldsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Deletes custom document fields from an existing template document.
                DocumentFieldsInformation result = apiInstance.DeleteDocumentFields(documentFieldsInformation, accountId, templateId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteDocumentFields: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
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
> void DeleteDocumentPage (PageRequest pageRequest = null, string accountId, string templateId, string documentId, string pageNumber)

Deletes a page from a document in an template.

Deletes a page from a document in a template based on the page number.

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
            
            var apiInstance = new TemplatesApi();
            var pageRequest = new PageRequest(); // PageRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Deletes a page from a document in an template.
                apiInstance.DeleteDocumentPage(pageRequest, accountId, templateId, documentId, pageNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteDocumentPage: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
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
> TemplateDocumentsResult DeleteDocuments (EnvelopeDefinition envelopeDefinition = null, string accountId, string templateId)

Deletes documents from a template.

Deletes one or more documents from an existing template.

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
            
            var apiInstance = new TemplatesApi();
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Deletes documents from a template.
                TemplateDocumentsResult result = apiInstance.DeleteDocuments(envelopeDefinition, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteDocuments: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**TemplateDocumentsResult**](TemplateDocumentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupshare"></a>
# **DeleteGroupShare**
> GroupInformation DeleteGroupShare (GroupInformation groupInformation = null, string accountId, string templateId, string templatePart)

Removes a member group's sharing permissions for a template.

Removes a member group's sharing permissions for a specified template.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteGroupShareExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var groupInformation = new GroupInformation(); // GroupInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templatePart = templatePart_example;  // string | Currently, the only defined part is **groups**.

            try
            {
                // Removes a member group's sharing permissions for a template.
                GroupInformation result = apiInstance.DeleteGroupShare(groupInformation, accountId, templateId, templatePart);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteGroupShare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupInformation** | [**GroupInformation**](GroupInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **templatePart** | **string**| Currently, the only defined part is **groups**. | 

### Return type

[**GroupInformation**](GroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelock"></a>
# **DeleteLock**
> LockInformation DeleteLock (LockRequest lockRequest = null, string accountId, string templateId)

Deletes a template lock.

Deletes the lock from the specified template. The `X-DocuSign-Edit` header must be included in the request.

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
            
            var apiInstance = new TemplatesApi();
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Deletes a template lock.
                LockInformation result = apiInstance.DeleteLock(lockRequest, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteLock: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 

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
> Recipients DeleteRecipient (TemplateRecipients templateRecipients = null, string accountId, string templateId, string recipientId)

Deletes the specified recipient file from a template.

Deletes the specified recipient file from the specified template.

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
            
            var apiInstance = new TemplatesApi();
            var templateRecipients = new TemplateRecipients(); // TemplateRecipients |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Deletes the specified recipient file from a template.
                Recipients result = apiInstance.DeleteRecipient(templateRecipients, accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateRecipients** | [**TemplateRecipients**](TemplateRecipients.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
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
> Recipients DeleteRecipients (TemplateRecipients templateRecipients = null, string accountId, string templateId)

Deletes recipients from a template.

Deletes one or more recipients from a template. Recipients to be deleted are listed in the request, with the `recipientId` being used as the key for deleting recipients.

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
            
            var apiInstance = new TemplatesApi();
            var templateRecipients = new TemplateRecipients(); // TemplateRecipients |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Deletes recipients from a template.
                Recipients result = apiInstance.DeleteRecipients(templateRecipients, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateRecipients** | [**TemplateRecipients**](TemplateRecipients.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

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
> Tabs DeleteTabs (TemplateTabs templateTabs = null, string accountId, string templateId, string recipientId)

Deletes the tabs associated with a recipient in a template.

Deletes one or more tabs associated with a recipient in a template.

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
            
            var apiInstance = new TemplatesApi();
            var templateTabs = new TemplateTabs(); // TemplateTabs |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Deletes the tabs associated with a recipient in a template.
                Tabs result = apiInstance.DeleteTabs(templateTabs, accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.DeleteTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateTabs** | [**TemplateTabs**](TemplateTabs.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> EnvelopeTemplate Get (string include = null, string accountId, string templateId)

Gets a list of templates for a specified account.

Retrieves the definition of the specified template.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var include = include_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets a list of templates for a specified account.
                EnvelopeTemplate result = apiInstance.Get(include, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.Get: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**EnvelopeTemplate**](EnvelopeTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> System.IO.Stream GetDocument (string encrypt = null, string showChanges = null, string accountId, string templateId, string documentId)

Gets PDF documents from a template.

Retrieves one or more PDF documents from the specified template.  You can specify the ID of the document to retrieve or can specify `combined` to retrieve all documents in the template as one pdf.

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
            
            var apiInstance = new TemplatesApi();
            var encrypt = encrypt_example;  // string |  (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Gets PDF documents from a template.
                System.IO.Stream result = apiInstance.GetDocument(encrypt, showChanges, accountId, templateId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **encrypt** | **string**|  | [optional] 
 **showChanges** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
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
> System.IO.Stream GetDocumentPageImage (string dpi = null, string maxHeight = null, string maxWidth = null, string showChanges = null, string accountId, string templateId, string documentId, string pageNumber)

Gets a page image from a template for display.

Retrieves a page image for display from the specified template.

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
            
            var apiInstance = new TemplatesApi();
            var dpi = dpi_example;  // string |  (optional) 
            var maxHeight = maxHeight_example;  // string |  (optional) 
            var maxWidth = maxWidth_example;  // string |  (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Gets a page image from a template for display.
                System.IO.Stream result = apiInstance.GetDocumentPageImage(dpi, maxHeight, maxWidth, showChanges, accountId, templateId, documentId, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetDocumentPageImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dpi** | **string**|  | [optional] 
 **maxHeight** | **string**|  | [optional] 
 **maxWidth** | **string**|  | [optional] 
 **showChanges** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
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
> Tabs GetDocumentTabs (string pageNumbers = null, string accountId, string templateId, string documentId)

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
            
            var apiInstance = new TemplatesApi();
            var pageNumbers = pageNumbers_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Returns tabs on the document.
                Tabs result = apiInstance.GetDocumentTabs(pageNumbers, accountId, templateId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetDocumentTabs: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlock"></a>
# **GetLock**
> LockInformation GetLock (string accountId, string templateId)

Gets template lock information.

Retrieves general information about the template lock.  If the call is made by the user who has the lock and the request has the same integrator key as original, then the `X-DocuSign-Edit` header  field and additional lock information is included in the response. This allows users to recover a lost editing session token and the `X-DocuSign-Edit` header.

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
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets template lock information.
                LockInformation result = apiInstance.GetLock(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetLock: " + e.Message );
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
> Notification GetNotificationSettings (string accountId, string templateId)

Gets template notification information.

Retrieves the envelope notification, reminders and expirations, information for an existing template.

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
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets template notification information.
                Notification result = apiInstance.GetNotificationSettings(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetNotificationSettings: " + e.Message );
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
> Tabs GetPageTabs (string accountId, string templateId, string documentId, string pageNumber)

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
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Returns tabs on the specified page.
                Tabs result = apiInstance.GetPageTabs(accountId, templateId, documentId, pageNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetPageTabs: " + e.Message );
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
> PageImages GetPages (string count = null, string dpi = null, string maxHeight = null, string maxWidth = null, string nocache = null, string showChanges = null, string startPosition = null, string accountId, string templateId, string documentId)

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
            
            var apiInstance = new TemplatesApi();
            var count = count_example;  // string |  (optional) 
            var dpi = dpi_example;  // string |  (optional) 
            var maxHeight = maxHeight_example;  // string |  (optional) 
            var maxWidth = maxWidth_example;  // string |  (optional) 
            var nocache = nocache_example;  // string |  (optional) 
            var showChanges = showChanges_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Returns document page image(s) based on input.
                PageImages result = apiInstance.GetPages(count, dpi, maxHeight, maxWidth, nocache, showChanges, startPosition, accountId, templateId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.GetPages: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**PageImages**](PageImages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbulkrecipients"></a>
# **ListBulkRecipients**
> BulkRecipientsResponse ListBulkRecipients (string includeTabs = null, string startPosition = null, string accountId, string templateId, string recipientId)

Gets the bulk recipient file from a template.

Retrieves the bulk recipient file information from a template that has a bulk recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListBulkRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var includeTabs = includeTabs_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Gets the bulk recipient file from a template.
                BulkRecipientsResponse result = apiInstance.ListBulkRecipients(includeTabs, startPosition, accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.ListBulkRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeTabs** | **string**|  | [optional] 
 **startPosition** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**BulkRecipientsResponse**](BulkRecipientsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcustomfields"></a>
# **ListCustomFields**
> CustomFields ListCustomFields (string accountId, string templateId)

Gets the custom document fields from a template.

Retrieves the custom document field information from an existing template.

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
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets the custom document fields from a template.
                CustomFields result = apiInstance.ListCustomFields(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.ListCustomFields: " + e.Message );
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

### Return type

[**CustomFields**](CustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdocumentfields"></a>
# **ListDocumentFields**
> DocumentFieldsInformation ListDocumentFields (string accountId, string templateId, string documentId)

Gets the custom document fields for a an existing template document.

Retrieves the custom document fields for an existing template document.

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
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Gets the custom document fields for a an existing template document.
                DocumentFieldsInformation result = apiInstance.ListDocumentFields(accountId, templateId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.ListDocumentFields: " + e.Message );
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
> TemplateDocumentsResult ListDocuments (string accountId, string templateId)

Gets a list of documents associated with a template.

Retrieves a list of documents associated with the specified template.

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
            
            var apiInstance = new TemplatesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets a list of documents associated with a template.
                TemplateDocumentsResult result = apiInstance.ListDocuments(accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.ListDocuments: " + e.Message );
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

### Return type

[**TemplateDocumentsResult**](TemplateDocumentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrecipients"></a>
# **ListRecipients**
> Recipients ListRecipients (string includeAnchorTabLocations = null, string includeExtended = null, string includeTabs = null, string accountId, string templateId)

Gets recipient information from a template.

Retrieves the information for all recipients in the specified template.

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
            
            var apiInstance = new TemplatesApi();
            var includeAnchorTabLocations = includeAnchorTabLocations_example;  // string |  When set to **true** and `include_tabs` is set to **true**, all tabs with anchor tab properties are included in the response.  (optional) 
            var includeExtended = includeExtended_example;  // string |  When set to **true**, the extended properties are included in the response.  (optional) 
            var includeTabs = includeTabs_example;  // string | When set to **true**, the tab information associated with the recipient is included in the response. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Gets recipient information from a template.
                Recipients result = apiInstance.ListRecipients(includeAnchorTabLocations, includeExtended, includeTabs, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.ListRecipients: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**Recipients**](Recipients.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtabs"></a>
# **ListTabs**
> Tabs ListTabs (string includeAnchorTabLocations = null, string includeMetadata = null, string accountId, string templateId, string recipientId)

Gets the tabs information for a signer or sign-in-person recipient in a template.

Gets the tabs information for a signer or sign-in-person recipient in a template.

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
            
            var apiInstance = new TemplatesApi();
            var includeAnchorTabLocations = includeAnchorTabLocations_example;  // string | When set to **true**, all tabs with anchor tab properties are included in the response.  (optional) 
            var includeMetadata = includeMetadata_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Gets the tabs information for a signer or sign-in-person recipient in a template.
                Tabs result = apiInstance.ListTabs(includeAnchorTabLocations, includeMetadata, accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.ListTabs: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
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
> EnvelopeTemplateResults ListTemplates (string count = null, string folder = null, string folderIds = null, string fromDate = null, string include = null, string order = null, string orderBy = null, string searchText = null, string sharedByMe = null, string startPosition = null, string toDate = null, string usedFromDate = null, string usedToDate = null, string userFilter = null, string userId = null, string accountId)

Gets the definition of a template.

Retrieves the list of templates for the specified account. The request can be limited to a specific folder.

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
            
            var apiInstance = new TemplatesApi();
            var count = count_example;  // string | Number of records to return in the cache. (optional) 
            var folder = folder_example;  // string | The query value can be a folder name or folder ID. The response will only return templates in the specified folder. (optional) 
            var folderIds = folderIds_example;  // string | A comma separated list of folder ID GUIDs. (optional) 
            var fromDate = fromDate_example;  // string | Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. (optional) 
            var include = include_example;  // string | A comma separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. (optional) 
            var order = order_example;  // string | Sets the direction order used to sort the list. Valid values are: -asc = ascending sort order (a to z)  -desc = descending sort order (z to a) (optional) 
            var orderBy = orderBy_example;  // string | Sets the file attribute used to sort the list. Valid values are:  -name: template name  -modified: date/time template was last modified.  -used: date/time the template was last used. (optional) 
            var searchText = searchText_example;  // string | The search text used to search the names of templates. (optional) 
            var sharedByMe = sharedByMe_example;  // string | If true, the response only includes templates shared by the user. If false, the response only returns template not shared by the user. If not specified, the response is not affected. (optional) 
            var startPosition = startPosition_example;  // string | The starting index for the first template shown in the response. This must be greater than or equal to 0 (zero). (optional) 
            var toDate = toDate_example;  // string | End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. (optional) 
            var usedFromDate = usedFromDate_example;  // string | Start of the search date range. Only returns templates used or edited on or after this date/time. If no value is specified, there is no limit on the earliest date used. (optional) 
            var usedToDate = usedToDate_example;  // string | End of the search date range. Only returns templates used or edited up to this date/time. If no value is provided, this defaults to the current date. (optional) 
            var userFilter = userFilter_example;  // string | Sets if the templates shown in the response Valid values are:  -owned_by_me: only shows templates the user owns.  -shared_with_me: only shows templates that are shared with the user.  -all: shows all templates owned or shared with the user. (optional) 
            var userId = userId_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets the definition of a template.
                EnvelopeTemplateResults result = apiInstance.ListTemplates(count, folder, folderIds, fromDate, include, order, orderBy, searchText, sharedByMe, startPosition, toDate, usedFromDate, usedToDate, userFilter, userId, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.ListTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **string**| Number of records to return in the cache. | [optional] 
 **folder** | **string**| The query value can be a folder name or folder ID. The response will only return templates in the specified folder. | [optional] 
 **folderIds** | **string**| A comma separated list of folder ID GUIDs. | [optional] 
 **fromDate** | **string**| Start of the search date range. Only returns templates created on or after this date/time. If no value is specified, there is no limit on the earliest date created. | [optional] 
 **include** | **string**| A comma separated list of additional template attributes to include in the response. Valid values are: recipients, folders, documents, custom_fields, and notifications. | [optional] 
 **order** | **string**| Sets the direction order used to sort the list. Valid values are: -asc &#x3D; ascending sort order (a to z)  -desc &#x3D; descending sort order (z to a) | [optional] 
 **orderBy** | **string**| Sets the file attribute used to sort the list. Valid values are:  -name: template name  -modified: date/time template was last modified.  -used: date/time the template was last used. | [optional] 
 **searchText** | **string**| The search text used to search the names of templates. | [optional] 
 **sharedByMe** | **string**| If true, the response only includes templates shared by the user. If false, the response only returns template not shared by the user. If not specified, the response is not affected. | [optional] 
 **startPosition** | **string**| The starting index for the first template shown in the response. This must be greater than or equal to 0 (zero). | [optional] 
 **toDate** | **string**| End of the search date range. Only returns templates created up to this date/time. If no value is provided, this defaults to the current date. | [optional] 
 **usedFromDate** | **string**| Start of the search date range. Only returns templates used or edited on or after this date/time. If no value is specified, there is no limit on the earliest date used. | [optional] 
 **usedToDate** | **string**| End of the search date range. Only returns templates used or edited up to this date/time. If no value is provided, this defaults to the current date. | [optional] 
 **userFilter** | **string**| Sets if the templates shown in the response Valid values are:  -owned_by_me: only shows templates the user owns.  -shared_with_me: only shows templates that are shared with the user.  -all: shows all templates owned or shared with the user. | [optional] 
 **userId** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**EnvelopeTemplateResults**](EnvelopeTemplateResults.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rotatedocumentpage"></a>
# **RotateDocumentPage**
> void RotateDocumentPage (PageRequest pageRequest = null, string accountId, string templateId, string documentId, string pageNumber)

Rotates page image from a template for display.

Rotates page image from a template for display. The page image can be rotated to the left or right.

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
            
            var apiInstance = new TemplatesApi();
            var pageRequest = new PageRequest(); // PageRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.
            var pageNumber = pageNumber_example;  // string | The page number being accessed.

            try
            {
                // Rotates page image from a template for display.
                apiInstance.RotateDocumentPage(pageRequest, accountId, templateId, documentId, pageNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.RotateDocumentPage: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
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
> TemplateUpdateSummary Update (EnvelopeTemplate envelopeTemplate = null, string accountId, string templateId)

Updates an existing template.

Updates an existing template.

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
            
            var apiInstance = new TemplatesApi();
            var envelopeTemplate = new EnvelopeTemplate(); // EnvelopeTemplate |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Updates an existing template.
                TemplateUpdateSummary result = apiInstance.Update(envelopeTemplate, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **envelopeTemplate** | [**EnvelopeTemplate**](EnvelopeTemplate.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**TemplateUpdateSummary**](TemplateUpdateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebulkrecipients"></a>
# **UpdateBulkRecipients**
> BulkRecipientsSummaryResponse UpdateBulkRecipients (BulkRecipientsRequest bulkRecipientsRequest = null, string accountId, string templateId, string recipientId)

Adds or replaces the bulk recipients list in a template.

Updates the bulk recipients in a template using a file upload. The Content-Type supported for uploading a bulk recipient file is CSV (text/csv).  The REST API does not support modifying individual rows or values in the bulk recipients file. It only allows the entire file to be added or replaced with a new file.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateBulkRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var bulkRecipientsRequest = new BulkRecipientsRequest(); // BulkRecipientsRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Adds or replaces the bulk recipients list in a template.
                BulkRecipientsSummaryResponse result = apiInstance.UpdateBulkRecipients(bulkRecipientsRequest, accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateBulkRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bulkRecipientsRequest** | [**BulkRecipientsRequest**](BulkRecipientsRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**BulkRecipientsSummaryResponse**](BulkRecipientsSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomfields"></a>
# **UpdateCustomFields**
> CustomFields UpdateCustomFields (TemplateCustomFields templateCustomFields = null, string accountId, string templateId)

Updates envelope custom fields in a template.

Updates the custom fields in a template.  Each custom field used in a template must have a unique name.

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
            
            var apiInstance = new TemplatesApi();
            var templateCustomFields = new TemplateCustomFields(); // TemplateCustomFields |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Updates envelope custom fields in a template.
                CustomFields result = apiInstance.UpdateCustomFields(templateCustomFields, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateCustomFields** | [**TemplateCustomFields**](TemplateCustomFields.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

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
> EnvelopeDocument UpdateDocument (string applyDocumentFields = null, string isEnvelopeDefinition = null, EnvelopeDefinition envelopeDefinition = null, string accountId, string templateId, string documentId)

Adds a document to a template document.

Adds the specified document to an existing template document.

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
            
            var apiInstance = new TemplatesApi();
            var applyDocumentFields = applyDocumentFields_example;  // string |  (optional) 
            var isEnvelopeDefinition = isEnvelopeDefinition_example;  // string |  (optional) 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Adds a document to a template document.
                EnvelopeDocument result = apiInstance.UpdateDocument(applyDocumentFields, isEnvelopeDefinition, envelopeDefinition, accountId, templateId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applyDocumentFields** | **string**|  | [optional] 
 **isEnvelopeDefinition** | **string**|  | [optional] 
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **documentId** | **string**| The ID of the document being accessed. | 

### Return type

[**EnvelopeDocument**](EnvelopeDocument.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocumentfields"></a>
# **UpdateDocumentFields**
> DocumentFieldsInformation UpdateDocumentFields (DocumentFieldsInformation documentFieldsInformation = null, string accountId, string templateId, string documentId)

Updates existing custom document fields in an existing template document.

Updates existing custom document fields in an existing template document.

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
            
            var apiInstance = new TemplatesApi();
            var documentFieldsInformation = new DocumentFieldsInformation(); // DocumentFieldsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var documentId = documentId_example;  // string | The ID of the document being accessed.

            try
            {
                // Updates existing custom document fields in an existing template document.
                DocumentFieldsInformation result = apiInstance.UpdateDocumentFields(documentFieldsInformation, accountId, templateId, documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateDocumentFields: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 
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
> TemplateDocumentsResult UpdateDocuments (string applyDocumentFields = null, EnvelopeDefinition envelopeDefinition = null, string accountId, string templateId)

Adds documents to a template document.

Adds one or more documents to an existing template document.

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
            
            var apiInstance = new TemplatesApi();
            var applyDocumentFields = applyDocumentFields_example;  // string |  (optional) 
            var envelopeDefinition = new EnvelopeDefinition(); // EnvelopeDefinition |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Adds documents to a template document.
                TemplateDocumentsResult result = apiInstance.UpdateDocuments(applyDocumentFields, envelopeDefinition, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applyDocumentFields** | **string**|  | [optional] 
 **envelopeDefinition** | [**EnvelopeDefinition**](EnvelopeDefinition.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**TemplateDocumentsResult**](TemplateDocumentsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupshare"></a>
# **UpdateGroupShare**
> GroupInformation UpdateGroupShare (GroupInformation groupInformation = null, string accountId, string templateId, string templatePart)

Shares a template with a group

Shares a template with the specified members group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateGroupShareExample
    {
        public void main()
        {
            
            var apiInstance = new TemplatesApi();
            var groupInformation = new GroupInformation(); // GroupInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var templatePart = templatePart_example;  // string | Currently, the only defined part is **groups**.

            try
            {
                // Shares a template with a group
                GroupInformation result = apiInstance.UpdateGroupShare(groupInformation, accountId, templateId, templatePart);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateGroupShare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupInformation** | [**GroupInformation**](GroupInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **templatePart** | **string**| Currently, the only defined part is **groups**. | 

### Return type

[**GroupInformation**](GroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelock"></a>
# **UpdateLock**
> LockInformation UpdateLock (LockRequest lockRequest = null, string accountId, string templateId)

Updates a template lock.

Updates the lock duration time or update the `lockedByApp` property information for the specified template. The user and integrator key must match the user specified by the `lockByUser` property and integrator key information and the `X-DocuSign-Edit` header must be included or an error will be generated.

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
            
            var apiInstance = new TemplatesApi();
            var lockRequest = new LockRequest(); // LockRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Updates a template lock.
                LockInformation result = apiInstance.UpdateLock(lockRequest, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateLock: " + e.Message );
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
 **templateId** | **string**| The ID of the template being accessed. | 

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
> Notification UpdateNotificationSettings (TemplateNotificationRequest templateNotificationRequest = null, string accountId, string templateId)

Updates the notification  structure for an existing template.

Updates the notification structure for an existing template. Use this endpoint to set reminder and expiration notifications.

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
            
            var apiInstance = new TemplatesApi();
            var templateNotificationRequest = new TemplateNotificationRequest(); // TemplateNotificationRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Updates the notification  structure for an existing template.
                Notification result = apiInstance.UpdateNotificationSettings(templateNotificationRequest, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateNotificationSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateNotificationRequest** | [**TemplateNotificationRequest**](TemplateNotificationRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecipients"></a>
# **UpdateRecipients**
> RecipientsUpdateSummary UpdateRecipients (string resendEnvelope = null, TemplateRecipients templateRecipients = null, string accountId, string templateId)

Updates recipients in a template.

Updates recipients in a template.   You can edit the following properties: `email`, `userName`, `routingOrder`, `faxNumber`, `deliveryMethod`, `accessCode`, and `requireIdLookup`.

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
            
            var apiInstance = new TemplatesApi();
            var resendEnvelope = resendEnvelope_example;  // string |  (optional) 
            var templateRecipients = new TemplateRecipients(); // TemplateRecipients |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.

            try
            {
                // Updates recipients in a template.
                RecipientsUpdateSummary result = apiInstance.UpdateRecipients(resendEnvelope, templateRecipients, accountId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resendEnvelope** | **string**|  | [optional] 
 **templateRecipients** | [**TemplateRecipients**](TemplateRecipients.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 

### Return type

[**RecipientsUpdateSummary**](RecipientsUpdateSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetabs"></a>
# **UpdateTabs**
> Tabs UpdateTabs (TemplateTabs templateTabs = null, string accountId, string templateId, string recipientId)

Updates the tabs for a recipient.

Updates one or more tabs for a recipient in a template.

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
            
            var apiInstance = new TemplatesApi();
            var templateTabs = new TemplateTabs(); // TemplateTabs |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var templateId = templateId_example;  // string | The ID of the template being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Updates the tabs for a recipient.
                Tabs result = apiInstance.UpdateTabs(templateTabs, accountId, templateId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.UpdateTabs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateTabs** | [**TemplateTabs**](TemplateTabs.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **templateId** | **string**| The ID of the template being accessed. | 
 **recipientId** | **string**| The ID of the recipient being accessed. | 

### Return type

[**Tabs**](Tabs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

