# DocuSign.eSign.Api.GroupsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroups**](GroupsApi.md#creategroups) | **POST** /v2/accounts/{accountId}/groups | Creates one or more groups for the account.
[**DeleteBrands**](GroupsApi.md#deletebrands) | **DELETE** /v2/accounts/{accountId}/groups/{groupId}/brands | Deletes brand information from the requested group.
[**DeleteGroupUsers**](GroupsApi.md#deletegroupusers) | **DELETE** /v2/accounts/{accountId}/groups/{groupId}/users | Deletes one or more users from a gro
[**DeleteGroups**](GroupsApi.md#deletegroups) | **DELETE** /v2/accounts/{accountId}/groups | Deletes an existing user group.
[**GetBrands**](GroupsApi.md#getbrands) | **GET** /v2/accounts/{accountId}/groups/{groupId}/brands | Gets group brand ID Information. 
[**ListGroupUsers**](GroupsApi.md#listgroupusers) | **GET** /v2/accounts/{accountId}/groups/{groupId}/users | Gets a list of users in a group.
[**ListGroups**](GroupsApi.md#listgroups) | **GET** /v2/accounts/{accountId}/groups | Gets information about groups associated with the account.
[**UpdateBrands**](GroupsApi.md#updatebrands) | **PUT** /v2/accounts/{accountId}/groups/{groupId}/brands | Adds group brand ID information to a group.
[**UpdateGroupUsers**](GroupsApi.md#updategroupusers) | **PUT** /v2/accounts/{accountId}/groups/{groupId}/users | Adds one or more users to an existing group.
[**UpdateGroups**](GroupsApi.md#updategroups) | **PUT** /v2/accounts/{accountId}/groups | Updates the group information for a group.


<a name="creategroups"></a>
# **CreateGroups**
> GroupInformation CreateGroups (GroupInformation groupInformation = null, string accountId)

Creates one or more groups for the account.

Creates one or more groups for the account.  Groups can be used to help manage users by associating users with a group. You can associate a group with a Permission Profile, which sets the user permissions for users in that group without having to set the `userSettings` property for each user. You are not required to set Permission Profiles for a group, but it makes it easier to manage user permissions for a large number of users. You can also use groups with template sharing to limit user access to templates.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupInformation = new GroupInformation(); // GroupInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Creates one or more groups for the account.
                GroupInformation result = apiInstance.CreateGroups(groupInformation, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroups: " + e.Message );
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

### Return type

[**GroupInformation**](GroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebrands"></a>
# **DeleteBrands**
> BrandsResponse DeleteBrands (BrandsRequest brandsRequest = null, string accountId, string groupId)

Deletes brand information from the requested group.

Deletes brand information from the requested group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var brandsRequest = new BrandsRequest(); // BrandsRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.

            try
            {
                // Deletes brand information from the requested group.
                BrandsResponse result = apiInstance.DeleteBrands(brandsRequest, accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandsRequest** | [**BrandsRequest**](BrandsRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 

### Return type

[**BrandsResponse**](BrandsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroupusers"></a>
# **DeleteGroupUsers**
> UsersResponse DeleteGroupUsers (UserInfoList userInfoList = null, string accountId, string groupId)

Deletes one or more users from a gro

Deletes one or more users from a group. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.

            try
            {
                // Deletes one or more users from a gro
                UsersResponse result = apiInstance.DeleteGroupUsers(userInfoList, accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 

### Return type

[**UsersResponse**](UsersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroups"></a>
# **DeleteGroups**
> GroupInformation DeleteGroups (GroupInformation groupInformation = null, string accountId)

Deletes an existing user group.

Deletes an existing user group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupInformation = new GroupInformation(); // GroupInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Deletes an existing user group.
                GroupInformation result = apiInstance.DeleteGroups(groupInformation, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroups: " + e.Message );
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

### Return type

[**GroupInformation**](GroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrands"></a>
# **GetBrands**
> BrandsResponse GetBrands (string accountId, string groupId)

Gets group brand ID Information. 

Retrieves information about the brands associated with the requested group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.

            try
            {
                // Gets group brand ID Information. 
                BrandsResponse result = apiInstance.GetBrands(accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 

### Return type

[**BrandsResponse**](BrandsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgroupusers"></a>
# **ListGroupUsers**
> UsersResponse ListGroupUsers (string count = null, string startPosition = null, string accountId, string groupId)

Gets a list of users in a group.

Retrieves a list of users in a group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var count = count_example;  // string | Number of records to return. The number must be greater than 1 and less than or equal to 100.  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.

            try
            {
                // Gets a list of users in a group.
                UsersResponse result = apiInstance.ListGroupUsers(count, startPosition, accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.ListGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **string**| Number of records to return. The number must be greater than 1 and less than or equal to 100.  | [optional] 
 **startPosition** | **string**| Starting value for the list. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 

### Return type

[**UsersResponse**](UsersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgroups"></a>
# **ListGroups**
> GroupInformation ListGroups (string count = null, string groupType = null, string searchText = null, string startPosition = null, string accountId)

Gets information about groups associated with the account.

Retrieves information about groups associated with the account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var count = count_example;  // string | Number of records to return. The number must be greater than 1 and less than or equal to 100. (optional) 
            var groupType = groupType_example;  // string |  (optional) 
            var searchText = searchText_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets information about groups associated with the account.
                GroupInformation result = apiInstance.ListGroups(count, groupType, searchText, startPosition, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.ListGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **string**| Number of records to return. The number must be greater than 1 and less than or equal to 100. | [optional] 
 **groupType** | **string**|  | [optional] 
 **searchText** | **string**|  | [optional] 
 **startPosition** | **string**| Starting value for the list. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**GroupInformation**](GroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebrands"></a>
# **UpdateBrands**
> BrandsResponse UpdateBrands (BrandsRequest brandsRequest = null, string accountId, string groupId)

Adds group brand ID information to a group.

Adds group brand ID information to a group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var brandsRequest = new BrandsRequest(); // BrandsRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.

            try
            {
                // Adds group brand ID information to a group.
                BrandsResponse result = apiInstance.UpdateBrands(brandsRequest, accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandsRequest** | [**BrandsRequest**](BrandsRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 

### Return type

[**BrandsResponse**](BrandsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroupusers"></a>
# **UpdateGroupUsers**
> UsersResponse UpdateGroupUsers (UserInfoList userInfoList = null, string accountId, string groupId)

Adds one or more users to an existing group.

Adds one or more users to an existing group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateGroupUsersExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.

            try
            {
                // Adds one or more users to an existing group.
                UsersResponse result = apiInstance.UpdateGroupUsers(userInfoList, accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 

### Return type

[**UsersResponse**](UsersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroups"></a>
# **UpdateGroups**
> GroupInformation UpdateGroups (GroupInformation groupInformation = null, string accountId)

Updates the group information for a group.

Updates the group name and modifies, or sets, the permission profile for the group.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateGroupsExample
    {
        public void main()
        {
            
            var apiInstance = new GroupsApi();
            var groupInformation = new GroupInformation(); // GroupInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Updates the group information for a group.
                GroupInformation result = apiInstance.UpdateGroups(groupInformation, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroups: " + e.Message );
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

### Return type

[**GroupInformation**](GroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

