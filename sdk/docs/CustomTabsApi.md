# DocuSign.eSign.Api.CustomTabsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](CustomTabsApi.md#create) | **POST** /v2/accounts/{accountId}/tab_definitions | Creates a custom tab.
[**Delete**](CustomTabsApi.md#delete) | **DELETE** /v2/accounts/{accountId}/tab_definitions/{customTabId} | Deletes custom tab information.
[**Get**](CustomTabsApi.md#get) | **GET** /v2/accounts/{accountId}/tab_definitions/{customTabId} | Gets custom tab information.
[**List**](CustomTabsApi.md#list) | **GET** /v2/accounts/{accountId}/tab_definitions | Gets a list of all account tabs.
[**Update**](CustomTabsApi.md#update) | **PUT** /v2/accounts/{accountId}/tab_definitions/{customTabId} | Updates custom tab information.  


<a name="create"></a>
# **Create**
> TabMetadata Create (TabMetadata tabMetadata = null, string accountId)

Creates a custom tab.

Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.  Custom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            
            var apiInstance = new CustomTabsApi();
            var tabMetadata = new TabMetadata(); // TabMetadata |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Creates a custom tab.
                TabMetadata result = apiInstance.Create(tabMetadata, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tabMetadata** | [**TabMetadata**](TabMetadata.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**TabMetadata**](TabMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string accountId, string customTabId)

Deletes custom tab information.

Deletes the custom from the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            
            var apiInstance = new CustomTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customTabId = customTabId_example;  // string | 

            try
            {
                // Deletes custom tab information.
                apiInstance.Delete(accountId, customTabId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customTabId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> TabMetadata Get (string accountId, string customTabId)

Gets custom tab information.

Retrieves information about the requested custom tab on the specified account.

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
            
            var apiInstance = new CustomTabsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customTabId = customTabId_example;  // string | 

            try
            {
                // Gets custom tab information.
                TabMetadata result = apiInstance.Get(accountId, customTabId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customTabId** | **string**|  | 

### Return type

[**TabMetadata**](TabMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="list"></a>
# **List**
> TabMetadataList List (string customTabOnly = null, string accountId)

Gets a list of all account tabs.

Retrieves a list of all tabs associated with the account.

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
            
            var apiInstance = new CustomTabsApi();
            var customTabOnly = customTabOnly_example;  // string | When set to **true**, only custom tabs are returned in the response.  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets a list of all account tabs.
                TabMetadataList result = apiInstance.List(customTabOnly, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.List: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customTabOnly** | **string**| When set to **true**, only custom tabs are returned in the response.  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**TabMetadataList**](TabMetadataList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> TabMetadata Update (TabMetadata tabMetadata = null, string accountId, string customTabId)

Updates custom tab information.  

Updates the information in a custom tab for the specified account.

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
            
            var apiInstance = new CustomTabsApi();
            var tabMetadata = new TabMetadata(); // TabMetadata |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var customTabId = customTabId_example;  // string | 

            try
            {
                // Updates custom tab information.  
                TabMetadata result = apiInstance.Update(tabMetadata, accountId, customTabId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomTabsApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tabMetadata** | [**TabMetadata**](TabMetadata.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **customTabId** | **string**|  | 

### Return type

[**TabMetadata**](TabMetadata.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

