# DocuSign.eSign.Api.SigningGroupsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateList**](SigningGroupsApi.md#createlist) | **POST** /v2/accounts/{accountId}/signing_groups | Creates a signing group. 
[**DeleteList**](SigningGroupsApi.md#deletelist) | **DELETE** /v2/accounts/{accountId}/signing_groups | Deletes one or more signing groups.
[**DeleteUsers**](SigningGroupsApi.md#deleteusers) | **DELETE** /v2/accounts/{accountId}/signing_groups/{signingGroupId}/users | Deletes  one or more members from a signing group.
[**Get**](SigningGroupsApi.md#get) | **GET** /v2/accounts/{accountId}/signing_groups/{signingGroupId} | Gets information about a signing group. 
[**List**](SigningGroupsApi.md#list) | **GET** /v2/accounts/{accountId}/signing_groups | Gets a list of the Signing Groups in an account.
[**ListUsers**](SigningGroupsApi.md#listusers) | **GET** /v2/accounts/{accountId}/signing_groups/{signingGroupId}/users | Gets a list of members in a Signing Group.
[**Update**](SigningGroupsApi.md#update) | **PUT** /v2/accounts/{accountId}/signing_groups/{signingGroupId} | Updates a signing group. 
[**UpdateList**](SigningGroupsApi.md#updatelist) | **PUT** /v2/accounts/{accountId}/signing_groups | Updates signing group names.
[**UpdateUsers**](SigningGroupsApi.md#updateusers) | **PUT** /v2/accounts/{accountId}/signing_groups/{signingGroupId}/users | Adds members to a signing group. 


<a name="createlist"></a>
# **CreateList**
> SigningGroupInformation CreateList (string accountId, SigningGroupInformation signingGroupInformation = null)

Creates a signing group. 

Creates one or more signing groups.   Multiple signing groups can be created in one call. Only users with account administrator privileges can create signing groups.   An account can have a maximum of 50 signing groups. Each signing group can have a maximum of 50 group members.   Signing groups can be used by any account user.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateListExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupInformation = new SigningGroupInformation(); // SigningGroupInformation |  (optional) 

            try
            {
                // Creates a signing group. 
                SigningGroupInformation result = apiInstance.CreateList(accountId, signingGroupInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.CreateList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupInformation** | [**SigningGroupInformation**](SigningGroupInformation.md)|  | [optional] 

### Return type

[**SigningGroupInformation**](SigningGroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelist"></a>
# **DeleteList**
> SigningGroupInformation DeleteList (string accountId, SigningGroupInformation signingGroupInformation = null)

Deletes one or more signing groups.

Deletes one or more signing groups in the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteListExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupInformation = new SigningGroupInformation(); // SigningGroupInformation |  (optional) 

            try
            {
                // Deletes one or more signing groups.
                SigningGroupInformation result = apiInstance.DeleteList(accountId, signingGroupInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.DeleteList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupInformation** | [**SigningGroupInformation**](SigningGroupInformation.md)|  | [optional] 

### Return type

[**SigningGroupInformation**](SigningGroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteusers"></a>
# **DeleteUsers**
> SigningGroupUsers DeleteUsers (string accountId, string signingGroupId, SigningGroupUsers signingGroupUsers = null)

Deletes  one or more members from a signing group.

Deletes  one or more members from the specified signing group. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteUsersExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 
            var signingGroupUsers = new SigningGroupUsers(); // SigningGroupUsers |  (optional) 

            try
            {
                // Deletes  one or more members from a signing group.
                SigningGroupUsers result = apiInstance.DeleteUsers(accountId, signingGroupId, signingGroupUsers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.DeleteUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupId** | **string**|  | 
 **signingGroupUsers** | [**SigningGroupUsers**](SigningGroupUsers.md)|  | [optional] 

### Return type

[**SigningGroupUsers**](SigningGroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> SigningGroup Get (string accountId, string signingGroupId)

Gets information about a signing group. 

Retrieves information, including group member information, for the specified signing group. 

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
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 

            try
            {
                // Gets information about a signing group. 
                SigningGroup result = apiInstance.Get(accountId, signingGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupId** | **string**|  | 

### Return type

[**SigningGroup**](SigningGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="list"></a>
# **List**
> SigningGroupInformation List (string accountId, string groupType = null, string includeUsers = null)

Gets a list of the Signing Groups in an account.

Retrieves a list of all signing groups in the specified account.

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
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupType = groupType_example;  // string |  (optional) 
            var includeUsers = includeUsers_example;  // string | When set to **true**, the response includes the signing group members.  (optional) 

            try
            {
                // Gets a list of the Signing Groups in an account.
                SigningGroupInformation result = apiInstance.List(accountId, groupType, includeUsers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.List: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupType** | **string**|  | [optional] 
 **includeUsers** | **string**| When set to **true**, the response includes the signing group members.  | [optional] 

### Return type

[**SigningGroupInformation**](SigningGroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listusers"></a>
# **ListUsers**
> SigningGroupUsers ListUsers (string accountId, string signingGroupId)

Gets a list of members in a Signing Group.

Retrieves the list of members in the specified Signing Group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListUsersExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 

            try
            {
                // Gets a list of members in a Signing Group.
                SigningGroupUsers result = apiInstance.ListUsers(accountId, signingGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.ListUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupId** | **string**|  | 

### Return type

[**SigningGroupUsers**](SigningGroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> SigningGroup Update (string accountId, string signingGroupId, SigningGroup signingGroup = null)

Updates a signing group. 

Updates signing group name and member information. You can also add new members to the signing group. A signing group can have a maximum of 50 members. 

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
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 
            var signingGroup = new SigningGroup(); // SigningGroup |  (optional) 

            try
            {
                // Updates a signing group. 
                SigningGroup result = apiInstance.Update(accountId, signingGroupId, signingGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupId** | **string**|  | 
 **signingGroup** | [**SigningGroup**](SigningGroup.md)|  | [optional] 

### Return type

[**SigningGroup**](SigningGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelist"></a>
# **UpdateList**
> SigningGroupInformation UpdateList (string accountId, SigningGroupInformation signingGroupInformation = null)

Updates signing group names.

Updates the name of one or more existing signing groups. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateListExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupInformation = new SigningGroupInformation(); // SigningGroupInformation |  (optional) 

            try
            {
                // Updates signing group names.
                SigningGroupInformation result = apiInstance.UpdateList(accountId, signingGroupInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.UpdateList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupInformation** | [**SigningGroupInformation**](SigningGroupInformation.md)|  | [optional] 

### Return type

[**SigningGroupInformation**](SigningGroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateusers"></a>
# **UpdateUsers**
> SigningGroupUsers UpdateUsers (string accountId, string signingGroupId, SigningGroupUsers signingGroupUsers = null)

Adds members to a signing group. 

Adds one or more new members to a signing group. A signing group can have a maximum of 50 members. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateUsersExample
    {
        public void main()
        {
            
            var apiInstance = new SigningGroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signingGroupId = signingGroupId_example;  // string | 
            var signingGroupUsers = new SigningGroupUsers(); // SigningGroupUsers |  (optional) 

            try
            {
                // Adds members to a signing group. 
                SigningGroupUsers result = apiInstance.UpdateUsers(accountId, signingGroupId, signingGroupUsers);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SigningGroupsApi.UpdateUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signingGroupId** | **string**|  | 
 **signingGroupUsers** | [**SigningGroupUsers**](SigningGroupUsers.md)|  | [optional] 

### Return type

[**SigningGroupUsers**](SigningGroupUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

