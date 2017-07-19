# DocuSign.eSign.Api.AuthenticationApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSocialLogin**](AuthenticationApi.md#deletesociallogin) | **DELETE** /v2/accounts/{accountId}/users/{userId}/social | Deletes user&#39;s social account.
[**GetOAuthToken**](AuthenticationApi.md#getoauthtoken) | **POST** /v2/oauth2/token | Creates an authorization token.
[**ListSocialLogins**](AuthenticationApi.md#listsociallogins) | **GET** /v2/accounts/{accountId}/users/{userId}/social | Gets a list of a user&#39;s social accounts.
[**Login**](AuthenticationApi.md#login) | **GET** /v2/login_information | Gets login information for a specified user.
[**RevokeOAuthToken**](AuthenticationApi.md#revokeoauthtoken) | **POST** /v2/oauth2/revoke | Revokes an authorization token.
[**UpdatePassword**](AuthenticationApi.md#updatepassword) | **PUT** /v2/login_information/{loginPart} | Updates the password for a specified user.
[**UpdateSocialLogin**](AuthenticationApi.md#updatesociallogin) | **PUT** /v2/accounts/{accountId}/users/{userId}/social | Adds social account for a user.


<a name="deletesociallogin"></a>
# **DeleteSocialLogin**
> void DeleteSocialLogin (SocialAccountInformation socialAccountInformation = null, string accountId, string userId)

Deletes user's social account.

Deletes a social account from a use's account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteSocialLoginExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var socialAccountInformation = new SocialAccountInformation(); // SocialAccountInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Deletes user's social account.
                apiInstance.DeleteSocialLogin(socialAccountInformation, accountId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.DeleteSocialLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **socialAccountInformation** | [**SocialAccountInformation**](SocialAccountInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoauthtoken"></a>
# **GetOAuthToken**
> OauthAccess GetOAuthToken ()

Creates an authorization token.

Creates an OAuth2 authorization server token endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetOAuthTokenExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();

            try
            {
                // Creates an authorization token.
                OauthAccess result = apiInstance.GetOAuthToken();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetOAuthToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OauthAccess**](OauthAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsociallogins"></a>
# **ListSocialLogins**
> UserSocialIdResult ListSocialLogins (string accountId, string userId)

Gets a list of a user's social accounts.

Retrieves a list of social accounts linked to a user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListSocialLoginsExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Gets a list of a user's social accounts.
                UserSocialIdResult result = apiInstance.ListSocialLogins(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.ListSocialLogins: " + e.Message );
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

### Return type

[**UserSocialIdResult**](UserSocialIdResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> LoginInformation Login (string apiPassword = null, string embedAccountIdGuid = null, string includeAccountIdGuid = null, string loginSettings = null)

Gets login information for a specified user.

Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.    The `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var apiPassword = apiPassword_example;  // string | When set to **true**, shows the account API password in the response. (optional) 
            var embedAccountIdGuid = embedAccountIdGuid_example;  // string |  (optional) 
            var includeAccountIdGuid = includeAccountIdGuid_example;  // string | When set to **true**, shows the account ID GUID in the response. (optional) 
            var loginSettings = loginSettings_example;  // string | Determines whether login settings are returned in the response.  Valid Values:  * all -  All the login settings are returned.  * none - no login settings are returned. (optional) 

            try
            {
                // Gets login information for a specified user.
                LoginInformation result = apiInstance.Login(apiPassword, embedAccountIdGuid, includeAccountIdGuid, loginSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiPassword** | **string**| When set to **true**, shows the account API password in the response. | [optional] 
 **embedAccountIdGuid** | **string**|  | [optional] 
 **includeAccountIdGuid** | **string**| When set to **true**, shows the account ID GUID in the response. | [optional] 
 **loginSettings** | **string**| Determines whether login settings are returned in the response.  Valid Values:  * all -  All the login settings are returned.  * none - no login settings are returned. | [optional] 

### Return type

[**LoginInformation**](LoginInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revokeoauthtoken"></a>
# **RevokeOAuthToken**
> void RevokeOAuthToken ()

Revokes an authorization token.

Revokes an OAuth2 authorization server token. After the revocation is complete, a caller must re-authenticate to restore access.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class RevokeOAuthTokenExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();

            try
            {
                // Revokes an authorization token.
                apiInstance.RevokeOAuthToken();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.RevokeOAuthToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepassword"></a>
# **UpdatePassword**
> void UpdatePassword (UserPasswordInformation userPasswordInformation = null, string loginPart)

Updates the password for a specified user.

Updates the password for a specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdatePasswordExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var userPasswordInformation = new UserPasswordInformation(); // UserPasswordInformation |  (optional) 
            var loginPart = loginPart_example;  // string | Currently, only the value **password** is supported.

            try
            {
                // Updates the password for a specified user.
                apiInstance.UpdatePassword(userPasswordInformation, loginPart);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.UpdatePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userPasswordInformation** | [**UserPasswordInformation**](UserPasswordInformation.md)|  | [optional] 
 **loginPart** | **string**| Currently, only the value **password** is supported. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesociallogin"></a>
# **UpdateSocialLogin**
> void UpdateSocialLogin (SocialAccountInformation socialAccountInformation = null, string accountId, string userId)

Adds social account for a user.

Adds a new social account to a user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateSocialLoginExample
    {
        public void main()
        {
            
            var apiInstance = new AuthenticationApi();
            var socialAccountInformation = new SocialAccountInformation(); // SocialAccountInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Adds social account for a user.
                apiInstance.UpdateSocialLogin(socialAccountInformation, accountId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.UpdateSocialLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **socialAccountInformation** | [**SocialAccountInformation**](SocialAccountInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

