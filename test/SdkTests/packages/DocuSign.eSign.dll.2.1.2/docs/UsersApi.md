# DocuSign.eSign.Api.UsersApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](UsersApi.md#create) | **POST** /v2/accounts/{accountId}/users | Adds news user to the specified account.
[**CreateSignatures**](UsersApi.md#createsignatures) | **POST** /v2/accounts/{accountId}/users/{userId}/signatures | Adds user Signature and initials images to a Signature.
[**Delete**](UsersApi.md#delete) | **DELETE** /v2/accounts/{accountId}/users | Removes users account privileges.
[**DeleteContactWithId**](UsersApi.md#deletecontactwithid) | **DELETE** /v2/accounts/{accountId}/contacts/{contactId} | Replaces a particular contact associated with an account for the DocuSign service.
[**DeleteContacts**](UsersApi.md#deletecontacts) | **DELETE** /v2/accounts/{accountId}/contacts | Delete contacts associated with an account for the DocuSign service.
[**DeleteCustomSettings**](UsersApi.md#deletecustomsettings) | **DELETE** /v2/accounts/{accountId}/users/{userId}/custom_settings | Deletes custom user settings for a specified user.
[**DeleteProfileImage**](UsersApi.md#deleteprofileimage) | **DELETE** /v2/accounts/{accountId}/users/{userId}/profile/image | Deletes the user profile image for the specified user.
[**DeleteSignature**](UsersApi.md#deletesignature) | **DELETE** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId} | Removes removes signature information for the specified user.
[**DeleteSignatureImage**](UsersApi.md#deletesignatureimage) | **DELETE** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId}/{imageType} | Deletes the user initials image or the  user signature image for the specified user.
[**GetContactById**](UsersApi.md#getcontactbyid) | **GET** /v2/accounts/{accountId}/contacts/{contactId} | Gets a particular contact associated with the user&#39;s account.
[**GetInformation**](UsersApi.md#getinformation) | **GET** /v2/accounts/{accountId}/users/{userId} | Gets the user information for a specified user.
[**GetProfile**](UsersApi.md#getprofile) | **GET** /v2/accounts/{accountId}/users/{userId}/profile | Retrieves the user profile for a specified user.
[**GetProfileImage**](UsersApi.md#getprofileimage) | **GET** /v2/accounts/{accountId}/users/{userId}/profile/image | Retrieves the user profile image for the specified user.
[**GetSettings**](UsersApi.md#getsettings) | **GET** /v2/accounts/{accountId}/users/{userId}/settings | Gets the user account settings for a specified user.
[**GetSignature**](UsersApi.md#getsignature) | **GET** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId} | Gets the user signature information for the specified user.
[**GetSignatureImage**](UsersApi.md#getsignatureimage) | **GET** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId}/{imageType} | Retrieves the user initials image or the  user signature image for the specified user.
[**List**](UsersApi.md#list) | **GET** /v2/accounts/{accountId}/users | Retrieves the list of users for the specified account.
[**ListCustomSettings**](UsersApi.md#listcustomsettings) | **GET** /v2/accounts/{accountId}/users/{userId}/custom_settings | Retrieves the custom user settings for a specified user.
[**ListSignatures**](UsersApi.md#listsignatures) | **GET** /v2/accounts/{accountId}/users/{userId}/signatures | Retrieves a list of user signature definitions for a specified user.
[**PostContacts**](UsersApi.md#postcontacts) | **POST** /v2/accounts/{accountId}/contacts | Imports multiple new contacts into the contacts collection from CSV, JSON, or XML (based on content type).
[**PutContacts**](UsersApi.md#putcontacts) | **PUT** /v2/accounts/{accountId}/contacts | Replaces contacts associated with an account for the DocuSign service.
[**UpdateCustomSettings**](UsersApi.md#updatecustomsettings) | **PUT** /v2/accounts/{accountId}/users/{userId}/custom_settings | Adds or updates custom user settings for the specified user.
[**UpdateProfile**](UsersApi.md#updateprofile) | **PUT** /v2/accounts/{accountId}/users/{userId}/profile | Updates the user profile information for the specified user.
[**UpdateProfileImage**](UsersApi.md#updateprofileimage) | **PUT** /v2/accounts/{accountId}/users/{userId}/profile/image | Updates the user profile image for a specified user.
[**UpdateSettings**](UsersApi.md#updatesettings) | **PUT** /v2/accounts/{accountId}/users/{userId}/settings | Updates the user account settings for a specified user.
[**UpdateSignature**](UsersApi.md#updatesignature) | **PUT** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId} | Updates the user signature for a specified user.
[**UpdateSignatureImage**](UsersApi.md#updatesignatureimage) | **PUT** /v2/accounts/{accountId}/users/{userId}/signatures/{signatureId}/{imageType} | Updates the user signature image or user initials image for the specified user.
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /v2/accounts/{accountId}/users/{userId} | Updates the specified user information.
[**UpdateUsers**](UsersApi.md#updateusers) | **PUT** /v2/accounts/{accountId}/users | Change one or more user in the specified account.


<a name="create"></a>
# **Create**
> NewUsersSummary Create (string accountId, NewUsersDefinition newUsersDefinition = null)

Adds news user to the specified account.

Adds new users to your account. Set the `userSettings` property in the request to specify the actions the users can perform on the account.

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
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var newUsersDefinition = new NewUsersDefinition(); // NewUsersDefinition |  (optional) 

            try
            {
                // Adds news user to the specified account.
                NewUsersSummary result = apiInstance.Create(accountId, newUsersDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **newUsersDefinition** | [**NewUsersDefinition**](NewUsersDefinition.md)|  | [optional] 

### Return type

[**NewUsersSummary**](NewUsersSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsignatures"></a>
# **CreateSignatures**
> UserSignaturesInformation CreateSignatures (string accountId, string userId, UserSignaturesInformation userSignaturesInformation = null)

Adds user Signature and initials images to a Signature.

Adds a user signature image and/or user initials image to the specified user.   The userId property specified in the endpoint must match the authenticated user's userId and the user must be a member of the account.  The rules and processes associated with this are:  * If Content-Type is set to application/json, then the default behavior for creating a default signature image, based on the name and a DocuSign font, is used. * If Content-Type is set to multipart/form-data, then the request must contain a first part with the user signature information, followed by parts that contain the images.  For each Image part, the Content-Disposition header has a \"filename\" value that is used to map to the `signatureName` and/or `signatureInitials` properties in the JSON to the image.   For example:  `Content-Disposition: file; filename=\"Ron Test20121127083900\"`  If no matching image (by filename value) is found, then the image is not set. One, both, or neither of the signature and initials images can be set with this call.  The Content-Transfer-Encoding: base64 header, set in the header for the part containing the image, can be set to indicate that the images are formatted as base64 instead of as binary.  If successful, 200-OK is returned, and a JSON structure containing the signature information is provided, note that the signatureId can change with each API POST, PUT, or DELETE since the changes to the signature structure cause the current signature to be closed, and a new signature record to be created.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateSignaturesExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userSignaturesInformation = new UserSignaturesInformation(); // UserSignaturesInformation |  (optional) 

            try
            {
                // Adds user Signature and initials images to a Signature.
                UserSignaturesInformation result = apiInstance.CreateSignatures(accountId, userId, userSignaturesInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateSignatures: " + e.Message );
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
 **userSignaturesInformation** | [**UserSignaturesInformation**](UserSignaturesInformation.md)|  | [optional] 

### Return type

[**UserSignaturesInformation**](UserSignaturesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> UsersResponse Delete (string accountId, UserInfoList userInfoList = null)

Removes users account privileges.

This closes one or more user records in the account. Users are never deleted from an account, but closing a user prevents them from using account functions.  The response returns whether the API execution was successful (200 - OK) or  if it failed. The response contains a user structure similar to the request and includes the user changes. If an error occurred during the DELETE operation for any of the users, the response for that user contains an `errorDetails` node with `errorCode` and `message` properties.

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
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 

            try
            {
                // Removes users account privileges.
                UsersResponse result = apiInstance.Delete(accountId, userInfoList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 

### Return type

[**UsersResponse**](UsersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontactwithid"></a>
# **DeleteContactWithId**
> ContactUpdateResponse DeleteContactWithId (string accountId, string contactId)

Replaces a particular contact associated with an account for the DocuSign service.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteContactWithIdExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactId = contactId_example;  // string | The unique identifier of a person in the contacts address book.

            try
            {
                // Replaces a particular contact associated with an account for the DocuSign service.
                ContactUpdateResponse result = apiInstance.DeleteContactWithId(accountId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteContactWithId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactId** | **string**| The unique identifier of a person in the contacts address book. | 

### Return type

[**ContactUpdateResponse**](ContactUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontacts"></a>
# **DeleteContacts**
> ContactUpdateResponse DeleteContacts (string accountId, ContactModRequest contactModRequest = null)

Delete contacts associated with an account for the DocuSign service.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteContactsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 

            try
            {
                // Delete contacts associated with an account for the DocuSign service.
                ContactUpdateResponse result = apiInstance.DeleteContacts(accountId, contactModRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 

### Return type

[**ContactUpdateResponse**](ContactUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomsettings"></a>
# **DeleteCustomSettings**
> CustomSettingsInformation DeleteCustomSettings (string accountId, string userId, CustomSettingsInformation customSettingsInformation = null)

Deletes custom user settings for a specified user.

Deletes the specified custom user settings for a single user.  ###Deleting Grouped Custom User Settings###  If the custom user settings you want to delete are grouped, you must include the following information in the header, after Content-Type, in the request:  `X-DocuSign-User-Settings-Key:group_name`  Where the `group_name` is your designated name for the group of customer user settings.  If the extra header information is not included, only the custom user settings that were added without a group are deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteCustomSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var customSettingsInformation = new CustomSettingsInformation(); // CustomSettingsInformation |  (optional) 

            try
            {
                // Deletes custom user settings for a specified user.
                CustomSettingsInformation result = apiInstance.DeleteCustomSettings(accountId, userId, customSettingsInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteCustomSettings: " + e.Message );
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
 **customSettingsInformation** | [**CustomSettingsInformation**](CustomSettingsInformation.md)|  | [optional] 

### Return type

[**CustomSettingsInformation**](CustomSettingsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprofileimage"></a>
# **DeleteProfileImage**
> void DeleteProfileImage (string accountId, string userId)

Deletes the user profile image for the specified user.

Deletes the user profile image from the  specified user's profile.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteProfileImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Deletes the user profile image for the specified user.
                apiInstance.DeleteProfileImage(accountId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteProfileImage: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesignature"></a>
# **DeleteSignature**
> void DeleteSignature (string accountId, string signatureId, string userId)

Removes removes signature information for the specified user.

Removes the signature information for the user.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteSignatureExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Removes removes signature information for the specified user.
                apiInstance.DeleteSignature(accountId, signatureId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesignatureimage"></a>
# **DeleteSignatureImage**
> UserSignature DeleteSignatureImage (string accountId, string imageType, string signatureId, string userId)

Deletes the user initials image or the  user signature image for the specified user.

Deletes the specified initials image or signature image for the specified user.  The function deletes one or the other of the image types, to delete both the initials image and signature image you must call the endpoint twice.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Deletes the user initials image or the  user signature image for the specified user.
                UserSignature result = apiInstance.DeleteSignatureImage(accountId, imageType, signatureId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteSignatureImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**UserSignature**](UserSignature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactbyid"></a>
# **GetContactById**
> ContactGetResponse GetContactById (string accountId, string contactId)

Gets a particular contact associated with the user's account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetContactByIdExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactId = contactId_example;  // string | The unique identifier of a person in the contacts address book.

            try
            {
                // Gets a particular contact associated with the user's account.
                ContactGetResponse result = apiInstance.GetContactById(accountId, contactId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactId** | **string**| The unique identifier of a person in the contacts address book. | 

### Return type

[**ContactGetResponse**](ContactGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinformation"></a>
# **GetInformation**
> UserInformation GetInformation (string accountId, string userId, string additionalInfo = null, string email = null)

Gets the user information for a specified user.

Retrieves the user information for the specified user.   To return additional user information that details the last login date, login status, and the user's password expiration date, set the optional `additional_info` query string parameter to **true**.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetInformationExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var additionalInfo = additionalInfo_example;  // string | When set to **true**, the full list of user information is returned for each user in the account. (optional) 
            var email = email_example;  // string |  (optional) 

            try
            {
                // Gets the user information for a specified user.
                UserInformation result = apiInstance.GetInformation(accountId, userId, additionalInfo, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetInformation: " + e.Message );
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
 **additionalInfo** | **string**| When set to **true**, the full list of user information is returned for each user in the account. | [optional] 
 **email** | **string**|  | [optional] 

### Return type

[**UserInformation**](UserInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprofile"></a>
# **GetProfile**
> UserProfile GetProfile (string accountId, string userId)

Retrieves the user profile for a specified user.

Retrieves the user profile information, the privacy settings and personal information (address, phone number, etc.) for the specified user.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetProfileExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Retrieves the user profile for a specified user.
                UserProfile result = apiInstance.GetProfile(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetProfile: " + e.Message );
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

[**UserProfile**](UserProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprofileimage"></a>
# **GetProfileImage**
> System.IO.Stream GetProfileImage (string accountId, string userId, string encoding = null)

Retrieves the user profile image for the specified user.

Retrieves the user profile picture for the specified user. The image is returned in the same format as uploaded.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the specified account.  If successful, the response returns a 200 - OK and the user profile image.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetProfileImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var encoding = encoding_example;  // string |  (optional) 

            try
            {
                // Retrieves the user profile image for the specified user.
                System.IO.Stream result = apiInstance.GetProfileImage(accountId, userId, encoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetProfileImage: " + e.Message );
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
 **encoding** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/gif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettings"></a>
# **GetSettings**
> UserSettingsInformation GetSettings (string accountId, string userId)

Gets the user account settings for a specified user.

Retrieves a list of the account settings and email notification information for the specified user.  The response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Gets the user account settings for a specified user.
                UserSettingsInformation result = apiInstance.GetSettings(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetSettings: " + e.Message );
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

[**UserSettingsInformation**](UserSettingsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsignature"></a>
# **GetSignature**
> UserSignature GetSignature (string accountId, string signatureId, string userId)

Gets the user signature information for the specified user.

Retrieves the structure of a single signature with a known signature name.  The userId specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetSignatureExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Gets the user signature information for the specified user.
                UserSignature result = apiInstance.GetSignature(accountId, signatureId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**UserSignature**](UserSignature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsignatureimage"></a>
# **GetSignatureImage**
> System.IO.Stream GetSignatureImage (string accountId, string imageType, string signatureId, string userId, string includeChrome = null)

Retrieves the user initials image or the  user signature image for the specified user.

Retrieves the specified initials image or signature image for the specified user. The image is returned in the same format as uploaded. In the request you can specify if the chrome (the added line and identifier around the initial image) is returned with the image.  The userId property specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".  ###### Note: Older envelopes might only have chromed images. If getting the non-chromed image fails, try getting the chromed image.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var includeChrome = includeChrome_example;  // string |  (optional) 

            try
            {
                // Retrieves the user initials image or the  user signature image for the specified user.
                System.IO.Stream result = apiInstance.GetSignatureImage(accountId, imageType, signatureId, userId, includeChrome);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetSignatureImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **includeChrome** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: image/gif

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="list"></a>
# **List**
> UserInformationList List (string accountId, string additionalInfo = null, string count = null, string email = null, string emailSubstring = null, string groupId = null, string includeUsersettingsForCsv = null, string loginStatus = null, string notGroupId = null, string startPosition = null, string status = null, string userNameSubstring = null)

Retrieves the list of users for the specified account.

Retrieves the list of users for the specified account.  The response returns the list of users for the account along with the information about the result set. If the `additional_info` query was added to the endpoint and set to **true**, the full user information is returned for each user

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
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var additionalInfo = additionalInfo_example;  // string | When set to **true**, the full list of user information is returned for each user in the account. (optional) 
            var count = count_example;  // string | Number of records to return. The number must be greater than 0 and less than or equal to 100.  (optional) 
            var email = email_example;  // string |  (optional) 
            var emailSubstring = emailSubstring_example;  // string | Filters the returned user records by the email address or a sub-string of email address. (optional) 
            var groupId = groupId_example;  // string | Filters user records returned by one or more group Id's. (optional) 
            var includeUsersettingsForCsv = includeUsersettingsForCsv_example;  // string |  (optional) 
            var loginStatus = loginStatus_example;  // string |  (optional) 
            var notGroupId = notGroupId_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list.  (optional) 
            var status = status_example;  // string |  (optional) 
            var userNameSubstring = userNameSubstring_example;  // string | Filters the user records returned by the user name or a sub-string of user name. (optional) 

            try
            {
                // Retrieves the list of users for the specified account.
                UserInformationList result = apiInstance.List(accountId, additionalInfo, count, email, emailSubstring, groupId, includeUsersettingsForCsv, loginStatus, notGroupId, startPosition, status, userNameSubstring);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.List: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **additionalInfo** | **string**| When set to **true**, the full list of user information is returned for each user in the account. | [optional] 
 **count** | **string**| Number of records to return. The number must be greater than 0 and less than or equal to 100.  | [optional] 
 **email** | **string**|  | [optional] 
 **emailSubstring** | **string**| Filters the returned user records by the email address or a sub-string of email address. | [optional] 
 **groupId** | **string**| Filters user records returned by one or more group Id&#39;s. | [optional] 
 **includeUsersettingsForCsv** | **string**|  | [optional] 
 **loginStatus** | **string**|  | [optional] 
 **notGroupId** | **string**|  | [optional] 
 **startPosition** | **string**| Starting value for the list.  | [optional] 
 **status** | **string**|  | [optional] 
 **userNameSubstring** | **string**| Filters the user records returned by the user name or a sub-string of user name. | [optional] 

### Return type

[**UserInformationList**](UserInformationList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcustomsettings"></a>
# **ListCustomSettings**
> CustomSettingsInformation ListCustomSettings (string accountId, string userId)

Retrieves the custom user settings for a specified user.

Retrieves a list of custom user settings for a single user.  Custom settings provide a flexible way to store and retrieve custom user information that can be used in your own system.  ###### Note: Custom user settings are not the same as user account settings.  ###Getting Grouped Custom User Settings###  If the custom user settings you want to retrieve are grouped, you must include the following information in the header, after Content-Type, in the request:  `X-DocuSign-User-Settings-Key:group_name`  Where the `group_name` is your designated name for the group of customer user settings.  If the extra header information is not included, only the custom user settings that were added without a group are retrieved.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListCustomSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Retrieves the custom user settings for a specified user.
                CustomSettingsInformation result = apiInstance.ListCustomSettings(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListCustomSettings: " + e.Message );
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

[**CustomSettingsInformation**](CustomSettingsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsignatures"></a>
# **ListSignatures**
> UserSignaturesInformation ListSignatures (string accountId, string userId)

Retrieves a list of user signature definitions for a specified user.

Retrieves the signature definitions for the specified user.  The userId parameter specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListSignaturesExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Retrieves a list of user signature definitions for a specified user.
                UserSignaturesInformation result = apiInstance.ListSignatures(accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListSignatures: " + e.Message );
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

[**UserSignaturesInformation**](UserSignaturesInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcontacts"></a>
# **PostContacts**
> ContactUpdateResponse PostContacts (string accountId, ContactModRequest contactModRequest = null)

Imports multiple new contacts into the contacts collection from CSV, JSON, or XML (based on content type).

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class PostContactsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 

            try
            {
                // Imports multiple new contacts into the contacts collection from CSV, JSON, or XML (based on content type).
                ContactUpdateResponse result = apiInstance.PostContacts(accountId, contactModRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 

### Return type

[**ContactUpdateResponse**](ContactUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcontacts"></a>
# **PutContacts**
> ContactUpdateResponse PutContacts (string accountId, ContactModRequest contactModRequest = null)

Replaces contacts associated with an account for the DocuSign service.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class PutContactsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 

            try
            {
                // Replaces contacts associated with an account for the DocuSign service.
                ContactUpdateResponse result = apiInstance.PutContacts(accountId, contactModRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 

### Return type

[**ContactUpdateResponse**](ContactUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecustomsettings"></a>
# **UpdateCustomSettings**
> CustomSettingsInformation UpdateCustomSettings (string accountId, string userId, CustomSettingsInformation customSettingsInformation = null)

Adds or updates custom user settings for the specified user.

Adds or updates custom user settings for the specified user.  ###### Note: Custom user settings are not the same as user account settings.  Custom settings provide a flexible way to store and retrieve custom user information that you can use in your own system.  **Important**: There is a limit on the size for all the custom user settings for a single user. The limit is 4,000 characters, which includes the XML and JSON structure for the settings.  ### Grouping Custom User Settings ###  You can group custom user settings when adding them. Grouping allows you to retrieve settings that are in a specific group, instead of retrieving all the user custom settings.  To group custom user settings, add the following information in the header, after Content-Type:  `X-DocuSign-User-Settings-Key:group_name`  Where the `group_name` is your designated name for the group of customer user settings. Grouping is shown in the Example Request Body below.  When getting or deleting grouped custom user settings, you must include the extra header information.  Grouping custom user settings is not required and if the extra header information is not included, the custom user settings are added normally and can be retrieved or deleted without including the additional header.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateCustomSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var customSettingsInformation = new CustomSettingsInformation(); // CustomSettingsInformation |  (optional) 

            try
            {
                // Adds or updates custom user settings for the specified user.
                CustomSettingsInformation result = apiInstance.UpdateCustomSettings(accountId, userId, customSettingsInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateCustomSettings: " + e.Message );
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
 **customSettingsInformation** | [**CustomSettingsInformation**](CustomSettingsInformation.md)|  | [optional] 

### Return type

[**CustomSettingsInformation**](CustomSettingsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprofile"></a>
# **UpdateProfile**
> void UpdateProfile (string accountId, string userId, UserProfile userProfile = null)

Updates the user profile information for the specified user.

Updates the user's detail information, profile information, privacy settings, and personal information in the user ID card.  You can also change a user's name by changing the information in the `userDetails` property. When changing a user's name, you can either change the information in the `userName` property OR change the information in `firstName`, `middleName`, `lastName, suffixName`, and `title` properties. Changes to `firstName`, `middleName`, `lastName`, `suffixName`, and `title` properties take precedence over changes to the `userName` property.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateProfileExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userProfile = new UserProfile(); // UserProfile |  (optional) 

            try
            {
                // Updates the user profile information for the specified user.
                apiInstance.UpdateProfile(accountId, userId, userProfile);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateProfile: " + e.Message );
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
 **userProfile** | [**UserProfile**](UserProfile.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprofileimage"></a>
# **UpdateProfileImage**
> void UpdateProfileImage (string accountId, string userId)

Updates the user profile image for a specified user.

Updates the user profile image by uploading an image to the user profile.  The supported image formats are: gif, png, jpeg, and bmp. The file must be less than 200K. For best viewing results, DocuSign recommends that the image is no more than 79 pixels wide and high.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateProfileImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Updates the user profile image for a specified user.
                apiInstance.UpdateProfileImage(accountId, userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateProfileImage: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesettings"></a>
# **UpdateSettings**
> void UpdateSettings (string accountId, string userId, UserSettingsInformation userSettingsInformation = null)

Updates the user account settings for a specified user.

Updates the account settings list and email notification types for the specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userSettingsInformation = new UserSettingsInformation(); // UserSettingsInformation |  (optional) 

            try
            {
                // Updates the user account settings for a specified user.
                apiInstance.UpdateSettings(accountId, userId, userSettingsInformation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateSettings: " + e.Message );
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
 **userSettingsInformation** | [**UserSettingsInformation**](UserSettingsInformation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesignature"></a>
# **UpdateSignature**
> UserSignature UpdateSignature (string accountId, string signatureId, string userId, string closeExistingSignature = null, UserSignatureDefinition userSignatureDefinition = null)

Updates the user signature for a specified user.

Creates, or updates, the signature font and initials for the specified user. When creating a signature, you use this resource to create the signature name and then add the signature and initials images into the signature.  ###### Note: This will also create a default signature for the user when one does not exist.  The userId property specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateSignatureExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var closeExistingSignature = closeExistingSignature_example;  // string | When set to **true**, closes the current signature. (optional) 
            var userSignatureDefinition = new UserSignatureDefinition(); // UserSignatureDefinition |  (optional) 

            try
            {
                // Updates the user signature for a specified user.
                UserSignature result = apiInstance.UpdateSignature(accountId, signatureId, userId, closeExistingSignature, userSignatureDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **closeExistingSignature** | **string**| When set to **true**, closes the current signature. | [optional] 
 **userSignatureDefinition** | [**UserSignatureDefinition**](UserSignatureDefinition.md)|  | [optional] 

### Return type

[**UserSignature**](UserSignature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesignatureimage"></a>
# **UpdateSignatureImage**
> UserSignature UpdateSignatureImage (string accountId, string imageType, string signatureId, string userId)

Updates the user signature image or user initials image for the specified user.

Updates the user signature image or user initials image for the specified user. The supported image formats for this file are: gif, png, jpeg, and bmp. The file must be less than 200K.  The userId property specified in the endpoint must match the authenticated user's user ID and the user must be a member of the account.  The `signatureId` parameter accepts a signature ID or a signature name. DocuSign recommends you use signature ID (`signatureId`), since some names contain characters that do not properly encode into a URL. If you use the user name, it is likely that the name includes spaces. In that case, URL encode the name before using it in the endpoint.   For example encode \"Bob Smith\" as \"Bob%20Smith\". 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateSignatureImageExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Updates the user signature image or user initials image for the specified user.
                UserSignature result = apiInstance.UpdateSignatureImage(accountId, imageType, signatureId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateSignatureImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

### Return type

[**UserSignature**](UserSignature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> UserInformation UpdateUser (string accountId, string userId, UserInformation userInformation = null)

Updates the specified user information.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var userInformation = new UserInformation(); // UserInformation |  (optional) 

            try
            {
                // Updates the specified user information.
                UserInformation result = apiInstance.UpdateUser(accountId, userId, userInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
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
 **userInformation** | [**UserInformation**](UserInformation.md)|  | [optional] 

### Return type

[**UserInformation**](UserInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateusers"></a>
# **UpdateUsers**
> UserInformationList UpdateUsers (string accountId, UserInformationList userInformationList = null)

Change one or more user in the specified account.

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
            
            var apiInstance = new UsersApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userInformationList = new UserInformationList(); // UserInformationList |  (optional) 

            try
            {
                // Change one or more user in the specified account.
                UserInformationList result = apiInstance.UpdateUsers(accountId, userInformationList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userInformationList** | [**UserInformationList**](UserInformationList.md)|  | [optional] 

### Return type

[**UserInformationList**](UserInformationList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

