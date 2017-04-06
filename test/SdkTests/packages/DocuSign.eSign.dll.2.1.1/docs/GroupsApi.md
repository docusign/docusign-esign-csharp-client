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
> GroupInformation CreateGroups (string accountId, GroupInformation groupInformation = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupInformation = new GroupInformation(); // GroupInformation |  (optional) 

            try
            {
                // Creates one or more groups for the account.
                GroupInformation result = apiInstance.CreateGroups(accountId, groupInformation);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupInformation** | [**GroupInformation**](GroupInformation.md)|  | [optional] 

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
> BrandsResponse DeleteBrands (string accountId, string groupId, BrandsRequest brandsRequest = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var brandsRequest = new BrandsRequest(); // BrandsRequest |  (optional) 

            try
            {
                // Deletes brand information from the requested group.
                BrandsResponse result = apiInstance.DeleteBrands(accountId, groupId, brandsRequest);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **brandsRequest** | [**BrandsRequest**](BrandsRequest.md)|  | [optional] 

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
> UsersResponse DeleteGroupUsers (string accountId, string groupId, UserInfoList userInfoList = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 

            try
            {
                // Deletes one or more users from a gro
                UsersResponse result = apiInstance.DeleteGroupUsers(accountId, groupId, userInfoList);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 

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
> GroupInformation DeleteGroups (string accountId, GroupInformation groupInformation = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupInformation = new GroupInformation(); // GroupInformation |  (optional) 

            try
            {
                // Deletes an existing user group.
                GroupInformation result = apiInstance.DeleteGroups(accountId, groupInformation);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupInformation** | [**GroupInformation**](GroupInformation.md)|  | [optional] 

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
> UsersResponse ListGroupUsers (string accountId, string groupId, string count = null, string startPosition = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var count = count_example;  // string | Number of records to return. The number must be greater than 1 and less than or equal to 100.  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list. (optional) 

            try
            {
                // Gets a list of users in a group.
                UsersResponse result = apiInstance.ListGroupUsers(accountId, groupId, count, startPosition);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **count** | **string**| Number of records to return. The number must be greater than 1 and less than or equal to 100.  | [optional] 
 **startPosition** | **string**| Starting value for the list. | [optional] 

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
> GroupInformation ListGroups (string accountId, string count = null, string groupName = null, string groupType = null, string searchText = null, string startPosition = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var count = count_example;  // string | Number of records to return. The number must be greater than 1 and less than or equal to 100. (optional) 
            var groupName = groupName_example;  // string | Filters the groups returned by the group name or a sub-string of group name. (optional) 
            var groupType = groupType_example;  // string |  (optional) 
            var searchText = searchText_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list. (optional) 

            try
            {
                // Gets information about groups associated with the account.
                GroupInformation result = apiInstance.ListGroups(accountId, count, groupName, groupType, searchText, startPosition);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **count** | **string**| Number of records to return. The number must be greater than 1 and less than or equal to 100. | [optional] 
 **groupName** | **string**| Filters the groups returned by the group name or a sub-string of group name. | [optional] 
 **groupType** | **string**|  | [optional] 
 **searchText** | **string**|  | [optional] 
 **startPosition** | **string**| Starting value for the list. | [optional] 

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
> BrandsResponse UpdateBrands (string accountId, string groupId, BrandsRequest brandsRequest = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var brandsRequest = new BrandsRequest(); // BrandsRequest |  (optional) 

            try
            {
                // Adds group brand ID information to a group.
                BrandsResponse result = apiInstance.UpdateBrands(accountId, groupId, brandsRequest);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **brandsRequest** | [**BrandsRequest**](BrandsRequest.md)|  | [optional] 

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
> UsersResponse UpdateGroupUsers (string accountId, string groupId, UserInfoList userInfoList = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupId = groupId_example;  // string | The ID of the group being accessed.
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 

            try
            {
                // Adds one or more users to an existing group.
                UsersResponse result = apiInstance.UpdateGroupUsers(accountId, groupId, userInfoList);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupId** | **string**| The ID of the group being accessed. | 
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 

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
> GroupInformation UpdateGroups (string accountId, GroupInformation groupInformation = null)

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
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var groupInformation = new GroupInformation(); // GroupInformation |  (optional) 

            try
            {
                // Updates the group information for a group.
                GroupInformation result = apiInstance.UpdateGroups(accountId, groupInformation);
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
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **groupInformation** | [**GroupInformation**](GroupInformation.md)|  | [optional] 

### Return type

[**GroupInformation**](GroupInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

