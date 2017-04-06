# DocuSign.eSign.Api.CloudStorageApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProvider**](CloudStorageApi.md#createprovider) | **POST** /v2/accounts/{accountId}/users/{userId}/cloud_storage | Configures the redirect URL information  for one or more cloud storage providers for the specified user.
[**DeleteProvider**](CloudStorageApi.md#deleteprovider) | **DELETE** /v2/accounts/{accountId}/users/{userId}/cloud_storage/{serviceId} | Deletes the user authentication information for the specified cloud storage provider.
[**DeleteProviders**](CloudStorageApi.md#deleteproviders) | **DELETE** /v2/accounts/{accountId}/users/{userId}/cloud_storage | Deletes the user authentication information for one or more cloud storage providers.
[**GetProvider**](CloudStorageApi.md#getprovider) | **GET** /v2/accounts/{accountId}/users/{userId}/cloud_storage/{serviceId} | Gets the specified Cloud Storage Provider configuration for the User.
[**List**](CloudStorageApi.md#list) | **GET** /v2/accounts/{accountId}/users/{userId}/cloud_storage/{serviceId}/folders/{folderId} | Gets a list of all the items from the specified cloud storage provider.
[**ListFolders**](CloudStorageApi.md#listfolders) | **GET** /v2/accounts/{accountId}/users/{userId}/cloud_storage/{serviceId}/folders | Retrieves a list of all the items in a specified folder from the specified cloud storage provider.
[**ListProviders**](CloudStorageApi.md#listproviders) | **GET** /v2/accounts/{accountId}/users/{userId}/cloud_storage | Get the Cloud Storage Provider configuration for the specified user.


<a name="createprovider"></a>
# **CreateProvider**
> CloudStorageProviders CreateProvider (string accountId, string userId, CloudStorageProviders cloudStorageProviders = null)

Configures the redirect URL information  for one or more cloud storage providers for the specified user.

Configures the redirect URL information  for one or more cloud storage providers for the specified user. The redirect URL is added to the authentication URL to complete the return route.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateProviderExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var cloudStorageProviders = new CloudStorageProviders(); // CloudStorageProviders |  (optional) 

            try
            {
                // Configures the redirect URL information  for one or more cloud storage providers for the specified user.
                CloudStorageProviders result = apiInstance.CreateProvider(accountId, userId, cloudStorageProviders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.CreateProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **cloudStorageProviders** | [**CloudStorageProviders**](CloudStorageProviders.md)|  | [optional] 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprovider"></a>
# **DeleteProvider**
> CloudStorageProviders DeleteProvider (string accountId, string serviceId, string userId)

Deletes the user authentication information for the specified cloud storage provider.

Deletes the user authentication information for the specified cloud storage provider. The next time the user tries to access the cloud storage provider, they must pass normal authentication for this cloud storage provider.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteProviderExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var serviceId = serviceId_example;  // string | The ID of the service to access.   Valid values are the service name (\"Box\") or the numerical serviceId (\"4136\").
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Deletes the user authentication information for the specified cloud storage provider.
                CloudStorageProviders result = apiInstance.DeleteProvider(accountId, serviceId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.DeleteProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **serviceId** | **string**| The ID of the service to access.   Valid values are the service name (\&quot;Box\&quot;) or the numerical serviceId (\&quot;4136\&quot;). | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproviders"></a>
# **DeleteProviders**
> CloudStorageProviders DeleteProviders (string accountId, string userId, CloudStorageProviders cloudStorageProviders = null)

Deletes the user authentication information for one or more cloud storage providers.

Deletes the user authentication information for one or more cloud storage providers. The next time the user tries to access the cloud storage provider, they must pass normal authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteProvidersExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var cloudStorageProviders = new CloudStorageProviders(); // CloudStorageProviders |  (optional) 

            try
            {
                // Deletes the user authentication information for one or more cloud storage providers.
                CloudStorageProviders result = apiInstance.DeleteProviders(accountId, userId, cloudStorageProviders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.DeleteProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **cloudStorageProviders** | [**CloudStorageProviders**](CloudStorageProviders.md)|  | [optional] 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprovider"></a>
# **GetProvider**
> CloudStorageProviders GetProvider (string accountId, string serviceId, string userId, string redirectUrl = null)

Gets the specified Cloud Storage Provider configuration for the User.

Retrieves the list of cloud storage providers enabled for the account and the configuration information for the user.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetProviderExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var serviceId = serviceId_example;  // string | The ID of the service to access.   Valid values are the service name (\"Box\") or the numerical serviceId (\"4136\").
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var redirectUrl = redirectUrl_example;  // string |  The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.   (optional) 

            try
            {
                // Gets the specified Cloud Storage Provider configuration for the User.
                CloudStorageProviders result = apiInstance.GetProvider(accountId, serviceId, userId, redirectUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.GetProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **serviceId** | **string**| The ID of the service to access.   Valid values are the service name (\&quot;Box\&quot;) or the numerical serviceId (\&quot;4136\&quot;). | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **redirectUrl** | **string**|  The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.   | [optional] 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="list"></a>
# **List**
> ExternalFolder List (string accountId, string folderId, string serviceId, string userId, string cloudStorageFolderPath = null, string count = null, string order = null, string orderBy = null, string searchText = null, string startPosition = null)

Gets a list of all the items from the specified cloud storage provider.

Retrieves a list of all the items in all  the folders associated with the user from the specified cloud storage provider. You can limit the scope of the returned items by providing a comma separated list of folder IDs in the request.

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
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var serviceId = serviceId_example;  // string | The ID of the service to access.   Valid values are the service name (\"Box\") or the numerical serviceId (\"4136\").
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var cloudStorageFolderPath = cloudStorageFolderPath_example;  // string |  (optional) 
            var count = count_example;  // string | An optional value that sets how many items are included in the response.   The default setting for this is 25.  (optional) 
            var order = order_example;  // string | An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc = ascending sort order * desc = descending sort order  (optional) 
            var orderBy = orderBy_example;  // string | An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   (optional) 
            var searchText = searchText_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Indicates the starting point of the first item included in the response set. It uses a 0-based index. The default setting for this is 0.   (optional) 

            try
            {
                // Gets a list of all the items from the specified cloud storage provider.
                ExternalFolder result = apiInstance.List(accountId, folderId, serviceId, userId, cloudStorageFolderPath, count, order, orderBy, searchText, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.List: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **serviceId** | **string**| The ID of the service to access.   Valid values are the service name (\&quot;Box\&quot;) or the numerical serviceId (\&quot;4136\&quot;). | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **cloudStorageFolderPath** | **string**|  | [optional] 
 **count** | **string**| An optional value that sets how many items are included in the response.   The default setting for this is 25.  | [optional] 
 **order** | **string**| An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order  | [optional] 
 **orderBy** | **string**| An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   | [optional] 
 **searchText** | **string**|  | [optional] 
 **startPosition** | **string**| Indicates the starting point of the first item included in the response set. It uses a 0-based index. The default setting for this is 0.   | [optional] 

### Return type

[**ExternalFolder**](ExternalFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfolders"></a>
# **ListFolders**
> ExternalFolder ListFolders (string accountId, string serviceId, string userId, string cloudStorageFolderPath = null, string count = null, string order = null, string orderBy = null, string searchText = null, string startPosition = null)

Retrieves a list of all the items in a specified folder from the specified cloud storage provider.

Retrieves a list of all the items in a specified folder from the specified cloud storage provider. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListFoldersExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var serviceId = serviceId_example;  // string | The ID of the service to access.   Valid values are the service name (\"Box\") or the numerical serviceId (\"4136\").
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var cloudStorageFolderPath = cloudStorageFolderPath_example;  // string | A comma separated list of folder IDs included in the request.  (optional) 
            var count = count_example;  // string | An optional value that sets how many items are included in the response.   The default setting for this is 25.  (optional) 
            var order = order_example;  // string | An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc = ascending sort order * desc = descending sort order  (optional) 
            var orderBy = orderBy_example;  // string | An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   (optional) 
            var searchText = searchText_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Indicates the starting point of the first item included in the response set. It uses a 0-based index. The default setting for this is 0.   (optional) 

            try
            {
                // Retrieves a list of all the items in a specified folder from the specified cloud storage provider.
                ExternalFolder result = apiInstance.ListFolders(accountId, serviceId, userId, cloudStorageFolderPath, count, order, orderBy, searchText, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.ListFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **serviceId** | **string**| The ID of the service to access.   Valid values are the service name (\&quot;Box\&quot;) or the numerical serviceId (\&quot;4136\&quot;). | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **cloudStorageFolderPath** | **string**| A comma separated list of folder IDs included in the request.  | [optional] 
 **count** | **string**| An optional value that sets how many items are included in the response.   The default setting for this is 25.  | [optional] 
 **order** | **string**| An optional value that sets the direction order used to sort the item list.   Valid values are:   * asc &#x3D; ascending sort order * desc &#x3D; descending sort order  | [optional] 
 **orderBy** | **string**| An optional value that sets the file attribute used to sort the item list.   Valid values are:   * modified * name   | [optional] 
 **searchText** | **string**|  | [optional] 
 **startPosition** | **string**| Indicates the starting point of the first item included in the response set. It uses a 0-based index. The default setting for this is 0.   | [optional] 

### Return type

[**ExternalFolder**](ExternalFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listproviders"></a>
# **ListProviders**
> CloudStorageProviders ListProviders (string accountId, string userId, string redirectUrl = null)

Get the Cloud Storage Provider configuration for the specified user.

Retrieves the list of cloud storage providers enabled for the account and the configuration information for the user.  The {serviceId} parameter can be either the service name or serviceId.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListProvidersExample
    {
        public void main()
        {
            
            var apiInstance = new CloudStorageApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var redirectUrl = redirectUrl_example;  // string |  The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.   (optional) 

            try
            {
                // Get the Cloud Storage Provider configuration for the specified user.
                CloudStorageProviders result = apiInstance.ListProviders(accountId, userId, redirectUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CloudStorageApi.ListProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **redirectUrl** | **string**|  The URL the user is redirected to after the cloud storage provider authenticates the user. Using this will append the redirectUrl to the authenticationUrl.  The redirectUrl is restricted to URLs in the docusign.com or docusign.net domains.   | [optional] 

### Return type

[**CloudStorageProviders**](CloudStorageProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

