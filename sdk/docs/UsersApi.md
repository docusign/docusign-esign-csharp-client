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
[**UpdateSignatures**](UsersApi.md#updatesignatures) | **PUT** /v2/accounts/{accountId}/users/{userId}/signatures | Adds/updates a user signature.
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /v2/accounts/{accountId}/users/{userId} | Updates the specified user information.
[**UpdateUsers**](UsersApi.md#updateusers) | **PUT** /v2/accounts/{accountId}/users | Change one or more user in the specified account.


<a name="create"></a>
# **Create**
> NewUsersSummary Create (NewUsersDefinition newUsersDefinition = null, string accountId)

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
            var newUsersDefinition = new NewUsersDefinition(); // NewUsersDefinition |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Adds news user to the specified account.
                NewUsersSummary result = apiInstance.Create(newUsersDefinition, accountId);
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
 **newUsersDefinition** | [**NewUsersDefinition**](NewUsersDefinition.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

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
> UserSignaturesInformation CreateSignatures (UserSignaturesInformation userSignaturesInformation = null, string accountId, string userId)

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
            var userSignaturesInformation = new UserSignaturesInformation(); // UserSignaturesInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Adds user Signature and initials images to a Signature.
                UserSignaturesInformation result = apiInstance.CreateSignatures(userSignaturesInformation, accountId, userId);
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
 **userSignaturesInformation** | [**UserSignaturesInformation**](UserSignaturesInformation.md)|  | [optional] 
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

<a name="delete"></a>
# **Delete**
> UsersResponse Delete (UserInfoList userInfoList = null, string accountId)

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
            var userInfoList = new UserInfoList(); // UserInfoList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Removes users account privileges.
                UsersResponse result = apiInstance.Delete(userInfoList, accountId);
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
 **userInfoList** | [**UserInfoList**](UserInfoList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

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
> ContactUpdateResponse DeleteContacts (ContactModRequest contactModRequest = null, string accountId)

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
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Delete contacts associated with an account for the DocuSign service.
                ContactUpdateResponse result = apiInstance.DeleteContacts(contactModRequest, accountId);
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
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

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
> CustomSettingsInformation DeleteCustomSettings (CustomSettingsInformation customSettingsInformation = null, string accountId, string userId)

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
            var customSettingsInformation = new CustomSettingsInformation(); // CustomSettingsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Deletes custom user settings for a specified user.
                CustomSettingsInformation result = apiInstance.DeleteCustomSettings(customSettingsInformation, accountId, userId);
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
 **customSettingsInformation** | [**CustomSettingsInformation**](CustomSettingsInformation.md)|  | [optional] 
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
> void DeleteSignature (string accountId, string userId, string signatureId)

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
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.

            try
            {
                // Removes removes signature information for the specified user.
                apiInstance.DeleteSignature(accountId, userId, signatureId);
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
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 

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
> UserSignature DeleteSignatureImage (string accountId, string userId, string signatureId, string imageType)

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
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.

            try
            {
                // Deletes the user initials image or the  user signature image for the specified user.
                UserSignature result = apiInstance.DeleteSignatureImage(accountId, userId, signatureId, imageType);
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
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 

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
> UserInformation GetInformation (string additionalInfo = null, string email = null, string accountId, string userId)

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
            var additionalInfo = additionalInfo_example;  // string | When set to **true**, the full list of user information is returned for each user in the account. (optional) 
            var email = email_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Gets the user information for a specified user.
                UserInformation result = apiInstance.GetInformation(additionalInfo, email, accountId, userId);
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
 **additionalInfo** | **string**| When set to **true**, the full list of user information is returned for each user in the account. | [optional] 
 **email** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

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
> System.IO.Stream GetProfileImage (string encoding = null, string accountId, string userId)

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
            var encoding = encoding_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Retrieves the user profile image for the specified user.
                System.IO.Stream result = apiInstance.GetProfileImage(encoding, accountId, userId);
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
 **encoding** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

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
> UserSignature GetSignature (string accountId, string userId, string signatureId)

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
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.

            try
            {
                // Gets the user signature information for the specified user.
                UserSignature result = apiInstance.GetSignature(accountId, userId, signatureId);
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
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 

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
> System.IO.Stream GetSignatureImage (string includeChrome = null, string accountId, string userId, string signatureId, string imageType)

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
            var includeChrome = includeChrome_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.

            try
            {
                // Retrieves the user initials image or the  user signature image for the specified user.
                System.IO.Stream result = apiInstance.GetSignatureImage(includeChrome, accountId, userId, signatureId, imageType);
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
 **includeChrome** | **string**|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 

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
> UserInformationList List (string additionalInfo = null, string count = null, string email = null, string emailSubstring = null, string groupId = null, string loginStatus = null, string notGroupId = null, string startPosition = null, string status = null, string userNameSubstring = null, string accountId)

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
            var additionalInfo = additionalInfo_example;  // string | When set to **true**, the full list of user information is returned for each user in the account. (optional) 
            var count = count_example;  // string | Number of records to return. The number must be greater than 0 and less than or equal to 100.  (optional) 
            var email = email_example;  // string |  (optional) 
            var emailSubstring = emailSubstring_example;  // string | Filters the returned user records by the email address or a sub-string of email address. (optional) 
            var groupId = groupId_example;  // string | Filters user records returned by one or more group Id's. (optional) 
            var loginStatus = loginStatus_example;  // string |  (optional) 
            var notGroupId = notGroupId_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string | Starting value for the list.  (optional) 
            var status = status_example;  // string |  (optional) 
            var userNameSubstring = userNameSubstring_example;  // string | Filters the user records returned by the user name or a sub-string of user name. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Retrieves the list of users for the specified account.
                UserInformationList result = apiInstance.List(additionalInfo, count, email, emailSubstring, groupId, loginStatus, notGroupId, startPosition, status, userNameSubstring, accountId);
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
 **additionalInfo** | **string**| When set to **true**, the full list of user information is returned for each user in the account. | [optional] 
 **count** | **string**| Number of records to return. The number must be greater than 0 and less than or equal to 100.  | [optional] 
 **email** | **string**|  | [optional] 
 **emailSubstring** | **string**| Filters the returned user records by the email address or a sub-string of email address. | [optional] 
 **groupId** | **string**| Filters user records returned by one or more group Id&#39;s. | [optional] 
 **loginStatus** | **string**|  | [optional] 
 **notGroupId** | **string**|  | [optional] 
 **startPosition** | **string**| Starting value for the list.  | [optional] 
 **status** | **string**|  | [optional] 
 **userNameSubstring** | **string**| Filters the user records returned by the user name or a sub-string of user name. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

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
> UserSignaturesInformation ListSignatures (string stampType = null, string accountId, string userId)

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
            var stampType = stampType_example;  // string |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Retrieves a list of user signature definitions for a specified user.
                UserSignaturesInformation result = apiInstance.ListSignatures(stampType, accountId, userId);
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
 **stampType** | **string**|  | [optional] 
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
> ContactUpdateResponse PostContacts (ContactModRequest contactModRequest = null, string accountId)

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
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Imports multiple new contacts into the contacts collection from CSV, JSON, or XML (based on content type).
                ContactUpdateResponse result = apiInstance.PostContacts(contactModRequest, accountId);
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
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

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
> ContactUpdateResponse PutContacts (ContactModRequest contactModRequest = null, string accountId)

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
            var contactModRequest = new ContactModRequest(); // ContactModRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Replaces contacts associated with an account for the DocuSign service.
                ContactUpdateResponse result = apiInstance.PutContacts(contactModRequest, accountId);
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
 **contactModRequest** | [**ContactModRequest**](ContactModRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

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
> CustomSettingsInformation UpdateCustomSettings (CustomSettingsInformation customSettingsInformation = null, string accountId, string userId)

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
            var customSettingsInformation = new CustomSettingsInformation(); // CustomSettingsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Adds or updates custom user settings for the specified user.
                CustomSettingsInformation result = apiInstance.UpdateCustomSettings(customSettingsInformation, accountId, userId);
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
 **customSettingsInformation** | [**CustomSettingsInformation**](CustomSettingsInformation.md)|  | [optional] 
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

<a name="updateprofile"></a>
# **UpdateProfile**
> void UpdateProfile (UserProfile userProfile = null, string accountId, string userId)

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
            var userProfile = new UserProfile(); // UserProfile |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Updates the user profile information for the specified user.
                apiInstance.UpdateProfile(userProfile, accountId, userId);
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
 **userProfile** | [**UserProfile**](UserProfile.md)|  | [optional] 
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
> void UpdateSettings (UserSettingsInformation userSettingsInformation = null, string accountId, string userId)

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
            var userSettingsInformation = new UserSettingsInformation(); // UserSettingsInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Updates the user account settings for a specified user.
                apiInstance.UpdateSettings(userSettingsInformation, accountId, userId);
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
 **userSettingsInformation** | [**UserSettingsInformation**](UserSettingsInformation.md)|  | [optional] 
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

<a name="updatesignature"></a>
# **UpdateSignature**
> UserSignature UpdateSignature (string closeExistingSignature = null, UserSignatureDefinition userSignatureDefinition = null, string accountId, string userId, string signatureId)

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
            var closeExistingSignature = closeExistingSignature_example;  // string | When set to **true**, closes the current signature. (optional) 
            var userSignatureDefinition = new UserSignatureDefinition(); // UserSignatureDefinition |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.

            try
            {
                // Updates the user signature for a specified user.
                UserSignature result = apiInstance.UpdateSignature(closeExistingSignature, userSignatureDefinition, accountId, userId, signatureId);
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
 **closeExistingSignature** | **string**| When set to **true**, closes the current signature. | [optional] 
 **userSignatureDefinition** | [**UserSignatureDefinition**](UserSignatureDefinition.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 

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
> UserSignature UpdateSignatureImage (string accountId, string userId, string signatureId, string imageType)

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
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.
            var signatureId = signatureId_example;  // string | The ID of the signature being accessed.
            var imageType = imageType_example;  // string | One of **signature_image** or **initials_image**.

            try
            {
                // Updates the user signature image or user initials image for the specified user.
                UserSignature result = apiInstance.UpdateSignatureImage(accountId, userId, signatureId, imageType);
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
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 
 **signatureId** | **string**| The ID of the signature being accessed. | 
 **imageType** | **string**| One of **signature_image** or **initials_image**. | 

### Return type

[**UserSignature**](UserSignature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesignatures"></a>
# **UpdateSignatures**
> UserSignaturesInformation UpdateSignatures (UserSignaturesInformation userSignaturesInformation = null, string accountId, string userId)

Adds/updates a user signature.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateSignaturesExample
    {
        public void main()
        {
            
            var apiInstance = new UsersApi();
            var userSignaturesInformation = new UserSignaturesInformation(); // UserSignaturesInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Adds/updates a user signature.
                UserSignaturesInformation result = apiInstance.UpdateSignatures(userSignaturesInformation, accountId, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateSignatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userSignaturesInformation** | [**UserSignaturesInformation**](UserSignaturesInformation.md)|  | [optional] 
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

<a name="updateuser"></a>
# **UpdateUser**
> UserInformation UpdateUser (UserInformation userInformation = null, string accountId, string userId)

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
            var userInformation = new UserInformation(); // UserInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var userId = userId_example;  // string | The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.

            try
            {
                // Updates the specified user information.
                UserInformation result = apiInstance.UpdateUser(userInformation, accountId, userId);
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
 **userInformation** | [**UserInformation**](UserInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **userId** | **string**| The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing. | 

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
> UserInformationList UpdateUsers (UserInformationList userInformationList = null, string accountId)

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
            var userInformationList = new UserInformationList(); // UserInformationList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Change one or more user in the specified account.
                UserInformationList result = apiInstance.UpdateUsers(userInformationList, accountId);
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
 **userInformationList** | [**UserInformationList**](UserInformationList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**UserInformationList**](UserInformationList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

