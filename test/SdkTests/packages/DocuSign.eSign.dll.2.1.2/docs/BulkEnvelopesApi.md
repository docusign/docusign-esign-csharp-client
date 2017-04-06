# DocuSign.eSign.Api.BulkEnvelopesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRecipients**](BulkEnvelopesApi.md#deleterecipients) | **DELETE** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/bulk_recipients | Deletes the bulk recipient file from an envelope.
[**Get**](BulkEnvelopesApi.md#get) | **GET** /v2/accounts/{accountId}/bulk_envelopes/{batchId} | Gets the status of a specified bulk send operation.
[**GetRecipients**](BulkEnvelopesApi.md#getrecipients) | **GET** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/bulk_recipients | Gets the bulk recipient file from an envelope.
[**List**](BulkEnvelopesApi.md#list) | **GET** /v2/accounts/{accountId}/bulk_envelopes | Gets status information about bulk recipient batches.
[**UpdateRecipients**](BulkEnvelopesApi.md#updaterecipients) | **PUT** /v2/accounts/{accountId}/envelopes/{envelopeId}/recipients/{recipientId}/bulk_recipients | Adds or replaces envelope bulk recipients.


<a name="deleterecipients"></a>
# **DeleteRecipients**
> BulkRecipientsUpdateResponse DeleteRecipients (string accountId, string envelopeId, string recipientId)

Deletes the bulk recipient file from an envelope.

Deletes the bulk recipient file from an envelope. This cannot be used if the envelope has been sent.  After using this, the `bulkRecipientsUri` property is not returned in subsequent GET calls for the envelope, but the recipient will remain as a bulk recipient.

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
            
            var apiInstance = new BulkEnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.

            try
            {
                // Deletes the bulk recipient file from an envelope.
                BulkRecipientsUpdateResponse result = apiInstance.DeleteRecipients(accountId, envelopeId, recipientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkEnvelopesApi.DeleteRecipients: " + e.Message );
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

[**BulkRecipientsUpdateResponse**](BulkRecipientsUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> BulkEnvelopeStatus Get (string accountId, string batchId, string count = null, string include = null, string startPosition = null)

Gets the status of a specified bulk send operation.

Retrieves the status information of a single bulk recipient batch. A bulk recipient batch is the set of envelopes sent from a single bulk recipient file. 

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
            
            var apiInstance = new BulkEnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var batchId = batchId_example;  // string | 
            var count = count_example;  // string | Specifies the number of entries to return. (optional) 
            var include = include_example;  // string | Specifies which entries are included in the response. Multiple entries can be included by using commas in the query string (example: ?include=”failed,queued”)   Valid values are:   * all - Returns all entries. If present, overrides all other query settings. This is the default if no query string is provided. * failed - This only returns entries with a failed status. * queued - This only returns entries with a queued status. * sent – This only returns entries with a sent status.   (optional) 
            var startPosition = startPosition_example;  // string | Specifies the location in the list of envelopes from which to start. (optional) 

            try
            {
                // Gets the status of a specified bulk send operation.
                BulkEnvelopeStatus result = apiInstance.Get(accountId, batchId, count, include, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkEnvelopesApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **batchId** | **string**|  | 
 **count** | **string**| Specifies the number of entries to return. | [optional] 
 **include** | **string**| Specifies which entries are included in the response. Multiple entries can be included by using commas in the query string (example: ?include&#x3D;”failed,queued”)   Valid values are:   * all - Returns all entries. If present, overrides all other query settings. This is the default if no query string is provided. * failed - This only returns entries with a failed status. * queued - This only returns entries with a queued status. * sent – This only returns entries with a sent status.   | [optional] 
 **startPosition** | **string**| Specifies the location in the list of envelopes from which to start. | [optional] 

### Return type

[**BulkEnvelopeStatus**](BulkEnvelopeStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecipients"></a>
# **GetRecipients**
> BulkRecipientsResponse GetRecipients (string accountId, string envelopeId, string recipientId, string includeTabs = null, string startPosition = null)

Gets the bulk recipient file from an envelope.

Retrieves the bulk recipient file information from an envelope that has a bulk recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetRecipientsExample
    {
        public void main()
        {
            
            var apiInstance = new BulkEnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.
            var includeTabs = includeTabs_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string |  (optional) 

            try
            {
                // Gets the bulk recipient file from an envelope.
                BulkRecipientsResponse result = apiInstance.GetRecipients(accountId, envelopeId, recipientId, includeTabs, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkEnvelopesApi.GetRecipients: " + e.Message );
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
 **includeTabs** | **string**|  | [optional] 
 **startPosition** | **string**|  | [optional] 

### Return type

[**BulkRecipientsResponse**](BulkRecipientsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="list"></a>
# **List**
> BulkEnvelopesResponse List (string accountId, string count = null, string include = null, string startPosition = null)

Gets status information about bulk recipient batches.

Retrieves status information about all the bulk recipient batches. A bulk recipient batch is the set of envelopes sent from a single bulk recipient file. The response includes general information about each bulk recipient batch.   The response returns information about the envelopes sent with bulk recipient batches, including the `batchId` property, which can be used to retrieve a more detailed status of individual bulk recipient batches.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListExample
    {
        public void main()
        {
            
            var apiInstance = new BulkEnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var count = count_example;  // string | The number of results to return. This can be 1 to 20. (optional) 
            var include = include_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | The position of the bulk envelope items in the response. This is used for repeated calls, when the number of bulk envelopes returned is too large for one return. The default value is 0. (optional) 

            try
            {
                // Gets status information about bulk recipient batches.
                BulkEnvelopesResponse result = apiInstance.List(accountId, count, include, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkEnvelopesApi.List: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **count** | **string**| The number of results to return. This can be 1 to 20. | [optional] 
 **include** | **string**|  | [optional] 
 **startPosition** | **string**| The position of the bulk envelope items in the response. This is used for repeated calls, when the number of bulk envelopes returned is too large for one return. The default value is 0. | [optional] 

### Return type

[**BulkEnvelopesResponse**](BulkEnvelopesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecipients"></a>
# **UpdateRecipients**
> BulkRecipientsSummaryResponse UpdateRecipients (string accountId, string envelopeId, string recipientId, BulkRecipientsRequest bulkRecipientsRequest = null)

Adds or replaces envelope bulk recipients.

Updates the bulk recipients in a draft envelope using a file upload. The Content-Type supported for uploading a bulk recipient file is CSV (text/csv).  The REST API does not support modifying individual rows or values in the bulk recipients file. It only allows the entire file to be added or replaced with a new file.

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
            
            var apiInstance = new BulkEnvelopesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var envelopeId = envelopeId_example;  // string | The envelopeId Guid of the envelope being accessed.
            var recipientId = recipientId_example;  // string | The ID of the recipient being accessed.
            var bulkRecipientsRequest = new BulkRecipientsRequest(); // BulkRecipientsRequest |  (optional) 

            try
            {
                // Adds or replaces envelope bulk recipients.
                BulkRecipientsSummaryResponse result = apiInstance.UpdateRecipients(accountId, envelopeId, recipientId, bulkRecipientsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkEnvelopesApi.UpdateRecipients: " + e.Message );
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
 **bulkRecipientsRequest** | [**BulkRecipientsRequest**](BulkRecipientsRequest.md)|  | [optional] 

### Return type

[**BulkRecipientsSummaryResponse**](BulkRecipientsSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

