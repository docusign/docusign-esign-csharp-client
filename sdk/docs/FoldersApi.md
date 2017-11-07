# DocuSign.eSign.Api.FoldersApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**List**](FoldersApi.md#list) | **GET** /v2/accounts/{accountId}/folders | Gets a list of the folders for the account.
[**ListItems**](FoldersApi.md#listitems) | **GET** /v2/accounts/{accountId}/folders/{folderId} | Gets a list of the envelopes in the specified folder.
[**MoveEnvelopes**](FoldersApi.md#moveenvelopes) | **PUT** /v2/accounts/{accountId}/folders/{folderId} | Moves an envelope from its current folder to the specified folder.
[**Search**](FoldersApi.md#search) | **GET** /v2/accounts/{accountId}/search_folders/{searchFolderId} | Gets a list of envelopes in folders matching the specified criteria.


<a name="list"></a>
# **List**
> FoldersResponse List (string include = null, string startPosition = null, string template = null, string userFilter = null, string accountId)

Gets a list of the folders for the account.

Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.

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
            
            var apiInstance = new FoldersApi();
            var include = include_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string |  (optional) 
            var template = template_example;  // string | Specifies the items that are returned. Valid values are:   * include - The folder list will return normal folders plus template folders.  * only - Only the list of template folders are returned. (optional) 
            var userFilter = userFilter_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets a list of the folders for the account.
                FoldersResponse result = apiInstance.List(include, startPosition, template, userFilter, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.List: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include** | **string**|  | [optional] 
 **startPosition** | **string**|  | [optional] 
 **template** | **string**| Specifies the items that are returned. Valid values are:   * include - The folder list will return normal folders plus template folders.  * only - Only the list of template folders are returned. | [optional] 
 **userFilter** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**FoldersResponse**](FoldersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listitems"></a>
# **ListItems**
> FolderItemsResponse ListItems (string fromDate = null, string ownerEmail = null, string ownerName = null, string searchText = null, string startPosition = null, string status = null, string toDate = null, string accountId, string folderId)

Gets a list of the envelopes in the specified folder.

Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListItemsExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var fromDate = fromDate_example;  // string |  Only return items on or after this date. If no value is provided, the default search is the previous 30 days.  (optional) 
            var ownerEmail = ownerEmail_example;  // string |  The email of the folder owner.  (optional) 
            var ownerName = ownerName_example;  // string |  The name of the folder owner.  (optional) 
            var searchText = searchText_example;  // string |  The search text used to search the items of the envelope. The search looks at recipient names and emails, envelope custom fields, sender name, and subject.  (optional) 
            var startPosition = startPosition_example;  // string | The position of the folder items to return. This is used for repeated calls, when the number of envelopes returned is too much for one return (calls return 100 envelopes at a time). The default value is 0. (optional) 
            var status = status_example;  // string | The current status of the envelope. If no value is provided, the default search is all/any status. (optional) 
            var toDate = toDate_example;  // string | Only return items up to this date. If no value is provided, the default search is to the current date. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.

            try
            {
                // Gets a list of the envelopes in the specified folder.
                FolderItemsResponse result = apiInstance.ListItems(fromDate, ownerEmail, ownerName, searchText, startPosition, status, toDate, accountId, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.ListItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fromDate** | **string**|  Only return items on or after this date. If no value is provided, the default search is the previous 30 days.  | [optional] 
 **ownerEmail** | **string**|  The email of the folder owner.  | [optional] 
 **ownerName** | **string**|  The name of the folder owner.  | [optional] 
 **searchText** | **string**|  The search text used to search the items of the envelope. The search looks at recipient names and emails, envelope custom fields, sender name, and subject.  | [optional] 
 **startPosition** | **string**| The position of the folder items to return. This is used for repeated calls, when the number of envelopes returned is too much for one return (calls return 100 envelopes at a time). The default value is 0. | [optional] 
 **status** | **string**| The current status of the envelope. If no value is provided, the default search is all/any status. | [optional] 
 **toDate** | **string**| Only return items up to this date. If no value is provided, the default search is to the current date. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **folderId** | **string**| The ID of the folder being accessed. | 

### Return type

[**FolderItemsResponse**](FolderItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="moveenvelopes"></a>
# **MoveEnvelopes**
> FoldersResponse MoveEnvelopes (FoldersRequest foldersRequest = null, string accountId, string folderId)

Moves an envelope from its current folder to the specified folder.

Moves envelopes to the specified folder.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class MoveEnvelopesExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var foldersRequest = new FoldersRequest(); // FoldersRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.

            try
            {
                // Moves an envelope from its current folder to the specified folder.
                FoldersResponse result = apiInstance.MoveEnvelopes(foldersRequest, accountId, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.MoveEnvelopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **foldersRequest** | [**FoldersRequest**](FoldersRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **folderId** | **string**| The ID of the folder being accessed. | 

### Return type

[**FoldersResponse**](FoldersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="search"></a>
# **Search**
> FolderItemResponse Search (string all = null, string count = null, string fromDate = null, string includeRecipients = null, string order = null, string orderBy = null, string startPosition = null, string toDate = null, string accountId, string searchFolderId)

Gets a list of envelopes in folders matching the specified criteria.

Retrieves a list of envelopes that match the criteria specified in the query.  If the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var all = all_example;  // string | Specifies that all envelopes that match the criteria are returned. (optional) 
            var count = count_example;  // string | Specifies the number of records returned in the cache. The number must be greater than 0 and less than or equal to 100. (optional) 
            var fromDate = fromDate_example;  // string | Specifies the start of the date range to return. If no value is provided, the default search is the previous 30 days. (optional) 
            var includeRecipients = includeRecipients_example;  // string | When set to **true**, the recipient information is returned in the response. (optional) 
            var order = order_example;  // string | Specifies the order in which the list is returned. Valid values are: `asc` for ascending order, and `desc` for descending order. (optional) 
            var orderBy = orderBy_example;  // string | Specifies the property used to sort the list. Valid values are: `action_required`, `created`, `completed`, `sent`, `signer_list`, `status`, or `subject`. (optional) 
            var startPosition = startPosition_example;  // string | Specifies the the starting location in the result set of the items that are returned. (optional) 
            var toDate = toDate_example;  // string | Specifies the end of the date range to return. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var searchFolderId = searchFolderId_example;  // string | Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.

            try
            {
                // Gets a list of envelopes in folders matching the specified criteria.
                FolderItemResponse result = apiInstance.Search(all, count, fromDate, includeRecipients, order, orderBy, startPosition, toDate, accountId, searchFolderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **all** | **string**| Specifies that all envelopes that match the criteria are returned. | [optional] 
 **count** | **string**| Specifies the number of records returned in the cache. The number must be greater than 0 and less than or equal to 100. | [optional] 
 **fromDate** | **string**| Specifies the start of the date range to return. If no value is provided, the default search is the previous 30 days. | [optional] 
 **includeRecipients** | **string**| When set to **true**, the recipient information is returned in the response. | [optional] 
 **order** | **string**| Specifies the order in which the list is returned. Valid values are: &#x60;asc&#x60; for ascending order, and &#x60;desc&#x60; for descending order. | [optional] 
 **orderBy** | **string**| Specifies the property used to sort the list. Valid values are: &#x60;action_required&#x60;, &#x60;created&#x60;, &#x60;completed&#x60;, &#x60;sent&#x60;, &#x60;signer_list&#x60;, &#x60;status&#x60;, or &#x60;subject&#x60;. | [optional] 
 **startPosition** | **string**| Specifies the the starting location in the result set of the items that are returned. | [optional] 
 **toDate** | **string**| Specifies the end of the date range to return. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **searchFolderId** | **string**| Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature. | 

### Return type

[**FolderItemResponse**](FolderItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

