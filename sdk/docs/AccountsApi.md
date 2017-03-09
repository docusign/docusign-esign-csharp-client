# DocuSign.eSign.Api.AccountsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](AccountsApi.md#create) | **POST** /v2/accounts | Creates new accounts.
[**CreateBrand**](AccountsApi.md#createbrand) | **POST** /v2/accounts/{accountId}/brands | Creates one or more brand profile files for the account.
[**CreateEMortgageTransaction**](AccountsApi.md#createemortgagetransaction) | **POST** /v2/accounts/{accountId}/eMortgage/transactions | Starts a new eMortgage Transaction
[**CreatePermissionProfile**](AccountsApi.md#createpermissionprofile) | **POST** /v2/accounts/{accountId}/permission_profiles | Creates a new permission profile in the specified account.
[**Delete**](AccountsApi.md#delete) | **DELETE** /v2/accounts/{accountId} | Deletes the specified account.
[**DeleteBrand**](AccountsApi.md#deletebrand) | **DELETE** /v2/accounts/{accountId}/brands/{brandId} | Removes a brand.
[**DeleteBrandLogoByType**](AccountsApi.md#deletebrandlogobytype) | **DELETE** /v2/accounts/{accountId}/brands/{brandId}/logos/{logoType} | Delete one branding logo.
[**DeleteBrands**](AccountsApi.md#deletebrands) | **DELETE** /v2/accounts/{accountId}/brands | Deletes one or more brand profiles.
[**DeleteCaptiveRecipient**](AccountsApi.md#deletecaptiverecipient) | **DELETE** /v2/accounts/{accountId}/captive_recipients/{recipientPart} | Deletes the signature for one or more captive recipient records.
[**DeleteENoteConfiguration**](AccountsApi.md#deleteenoteconfiguration) | **DELETE** /v2/accounts/{accountId}/settings/enote_configuration | Deletes configuration information for the eNote eOriginal integration.
[**DeletePermissionProfile**](AccountsApi.md#deletepermissionprofile) | **DELETE** /v2/accounts/{accountId}/permission_profiles/{permissionProfileId} | Deletes a permissions profile within the specified account.
[**GetAccountInformation**](AccountsApi.md#getaccountinformation) | **GET** /v2/accounts/{accountId} | Retrieves the account information for the specified account.
[**GetAccountTabSettings**](AccountsApi.md#getaccounttabsettings) | **GET** /v2/accounts/{accountId}/settings/tabs | Returns tab settings list for specified account
[**GetBillingCharges**](AccountsApi.md#getbillingcharges) | **GET** /v2/accounts/{accountId}/billing_charges | Gets list of recurring and usage charges for the account.
[**GetBrand**](AccountsApi.md#getbrand) | **GET** /v2/accounts/{accountId}/brands/{brandId} | Get information for a specific brand.
[**GetBrandLogoByType**](AccountsApi.md#getbrandlogobytype) | **GET** /v2/accounts/{accountId}/brands/{brandId}/logos/{logoType} | Obtains the specified image for a brand.
[**GetBrandResources**](AccountsApi.md#getbrandresources) | **GET** /v2/accounts/{accountId}/brands/{brandId}/resources | Returns the specified account&#39;s list of branding resources (metadata).
[**GetBrandResourcesByContentType**](AccountsApi.md#getbrandresourcesbycontenttype) | **GET** /v2/accounts/{accountId}/brands/{brandId}/resources/{resourceContentType} | Returns the specified branding resource file.
[**GetConsumerDisclosure**](AccountsApi.md#getconsumerdisclosure) | **GET** /v2/accounts/{accountId}/consumer_disclosure/{langCode} | Gets the Electronic Record and Signature Disclosure.
[**GetConsumerDisclosureDefault**](AccountsApi.md#getconsumerdisclosuredefault) | **GET** /v2/accounts/{accountId}/consumer_disclosure | Gets the Electronic Record and Signature Disclosure for the account.
[**GetENoteConfiguration**](AccountsApi.md#getenoteconfiguration) | **GET** /v2/accounts/{accountId}/settings/enote_configuration | Returns the configuration information for the eNote eOriginal integration.
[**GetPermissionProfile**](AccountsApi.md#getpermissionprofile) | **GET** /v2/accounts/{accountId}/permission_profiles/{permissionProfileId} | Returns a permissions profile in the specified account.
[**GetProvisioning**](AccountsApi.md#getprovisioning) | **GET** /v2/accounts/provisioning | Retrieves the account provisioning information for the account.
[**ListBrands**](AccountsApi.md#listbrands) | **GET** /v2/accounts/{accountId}/brands | Gets a list of brand profiles.
[**ListCustomFields**](AccountsApi.md#listcustomfields) | **GET** /v2/accounts/{accountId}/custom_fields | Gets a list of custom fields associated with the account.
[**ListPermissions**](AccountsApi.md#listpermissions) | **GET** /v2/accounts/{accountId}/permission_profiles | Gets a list of permission profiles.
[**ListRecipientNamesByEmail**](AccountsApi.md#listrecipientnamesbyemail) | **GET** /v2/accounts/{accountId}/recipient_names | Gets recipient names associated with an email address.
[**ListSettings**](AccountsApi.md#listsettings) | **GET** /v2/accounts/{accountId}/settings | Gets account settings information.
[**ListSharedAccess**](AccountsApi.md#listsharedaccess) | **GET** /v2/accounts/{accountId}/shared_access | Reserved: Gets the shared item status for one or more users.
[**ListSignatureProviders**](AccountsApi.md#listsignatureproviders) | **GET** /v2/accounts/{accountId}/signatureProviders | Returns Account available signature providers for specified account.
[**ListUnsupportedFileTypes**](AccountsApi.md#listunsupportedfiletypes) | **GET** /v2/accounts/{accountId}/unsupported_file_types | Gets a list of unsupported file types.
[**UpdateAccountTabSettings**](AccountsApi.md#updateaccounttabsettings) | **PUT** /v2/accounts/{accountId}/settings/tabs | Modifies tab settings for specified account
[**UpdateBrand**](AccountsApi.md#updatebrand) | **PUT** /v2/accounts/{accountId}/brands/{brandId} | Updates an existing brand.
[**UpdateBrandLogoByType**](AccountsApi.md#updatebrandlogobytype) | **PUT** /v2/accounts/{accountId}/brands/{brandId}/logos/{logoType} | Put one branding logo.
[**UpdateBrandResourcesByContentType**](AccountsApi.md#updatebrandresourcesbycontenttype) | **PUT** /v2/accounts/{accountId}/brands/{brandId}/resources/{resourceContentType} | Uploads a branding resource file.
[**UpdateENoteConfiguration**](AccountsApi.md#updateenoteconfiguration) | **PUT** /v2/accounts/{accountId}/settings/enote_configuration | Updates configuration information for the eNote eOriginal integration.
[**UpdatePermissionProfile**](AccountsApi.md#updatepermissionprofile) | **PUT** /v2/accounts/{accountId}/permission_profiles/{permissionProfileId} | Updates a permission profile within the specified account.
[**UpdateSettings**](AccountsApi.md#updatesettings) | **PUT** /v2/accounts/{accountId}/settings | Updates the account settings for an account.
[**UpdateSharedAccess**](AccountsApi.md#updatesharedaccess) | **PUT** /v2/accounts/{accountId}/shared_access | Reserved: Sets the shared access information for users.


<a name="create"></a>
# **Create**
> NewAccountSummary Create (string previewBillingPlan = null, NewAccountDefinition newAccountDefinition = null)

Creates new accounts.

Creates new DocuSign service accounts.  This is used to create multiple DocuSign accounts with one call. It uses the same information and formats as the normal a  [Accounts:create](accounts_create) call with the information included within a `newAccountRequests` element. A maximum of 100 new accounts can be created at one time.  Note that the structure of the XML request is slightly different than the JSON request, in that the new account information is included in a `newAccountDefinition` property inside the `newAccountRequests` element. Response  The response returns the new account ID, password and the default user information for each newly created account.  A 201 code is returned if the call succeeded.  While the call may have succeed, some of the individual account requests may have failed. In the case of failures to create the account,  an `errorDetails` node is added in the response to each specific request that failed.

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
            
            var apiInstance = new AccountsApi();
            var previewBillingPlan = previewBillingPlan_example;  // string | When set to **true**, creates the account using a preview billing plan. (optional) 
            var newAccountDefinition = new NewAccountDefinition(); // NewAccountDefinition |  (optional) 

            try
            {
                // Creates new accounts.
                NewAccountSummary result = apiInstance.Create(previewBillingPlan, newAccountDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **previewBillingPlan** | **string**| When set to **true**, creates the account using a preview billing plan. | [optional] 
 **newAccountDefinition** | [**NewAccountDefinition**](NewAccountDefinition.md)|  | [optional] 

### Return type

[**NewAccountSummary**](NewAccountSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbrand"></a>
# **CreateBrand**
> BrandsResponse CreateBrand (string accountId, Brand brand = null)

Creates one or more brand profile files for the account.

Creates one or more brand profile files for the account. The Account Branding feature (accountSettings properties `canSelfBrandSend` and `canSelfBrandSig`) must be set to **true** for the account to use this call.  An error is returned if `brandId` property for a brand profile is already set for the account. To upload a new version of an existing brand profile, you must delete the profile and then upload the newer version.  When brand profile files are being uploaded, they must be combined into one zip file and the `Content-Type` must be `application/zip`.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateBrandExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brand = new Brand(); // Brand |  (optional) 

            try
            {
                // Creates one or more brand profile files for the account.
                BrandsResponse result = apiInstance.CreateBrand(accountId, brand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brand** | [**Brand**](Brand.md)|  | [optional] 

### Return type

[**BrandsResponse**](BrandsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemortgagetransaction"></a>
# **CreateEMortgageTransaction**
> PostTransactionsResponse CreateEMortgageTransaction (string accountId, PostTransactionsRequest postTransactionsRequest = null)

Starts a new eMortgage Transaction

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateEMortgageTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var postTransactionsRequest = new PostTransactionsRequest(); // PostTransactionsRequest |  (optional) 

            try
            {
                // Starts a new eMortgage Transaction
                PostTransactionsResponse result = apiInstance.CreateEMortgageTransaction(accountId, postTransactionsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateEMortgageTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **postTransactionsRequest** | [**PostTransactionsRequest**](PostTransactionsRequest.md)|  | [optional] 

### Return type

[**PostTransactionsResponse**](PostTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpermissionprofile"></a>
# **CreatePermissionProfile**
> PermissionProfile CreatePermissionProfile (string accountId, string include = null, PermissionProfile permissionProfile = null)

Creates a new permission profile in the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreatePermissionProfileExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var include = include_example;  // string |  (optional) 
            var permissionProfile = new PermissionProfile(); // PermissionProfile |  (optional) 

            try
            {
                // Creates a new permission profile in the specified account.
                PermissionProfile result = apiInstance.CreatePermissionProfile(accountId, include, permissionProfile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreatePermissionProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **include** | **string**|  | [optional] 
 **permissionProfile** | [**PermissionProfile**](PermissionProfile.md)|  | [optional] 

### Return type

[**PermissionProfile**](PermissionProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string accountId)

Deletes the specified account.

This closes the specified account. You must be an account admin to close your account. Once closed, an account must be reopened by DocuSign.

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
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Deletes the specified account.
                apiInstance.Delete(accountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebrand"></a>
# **DeleteBrand**
> void DeleteBrand (string accountId, string brandId)

Removes a brand.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteBrandExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.

            try
            {
                // Removes a brand.
                apiInstance.DeleteBrand(accountId, brandId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebrandlogobytype"></a>
# **DeleteBrandLogoByType**
> void DeleteBrandLogoByType (string accountId, string brandId, string logoType)

Delete one branding logo.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteBrandLogoByTypeExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var logoType = logoType_example;  // string | One of **Primary**, **Secondary** or **Email**.

            try
            {
                // Delete one branding logo.
                apiInstance.DeleteBrandLogoByType(accountId, brandId, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteBrandLogoByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **logoType** | **string**| One of **Primary**, **Secondary** or **Email**. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebrands"></a>
# **DeleteBrands**
> BrandsResponse DeleteBrands (string accountId, BrandsRequest brandsRequest = null)

Deletes one or more brand profiles.

Deletes one or more brand profiles from an account. The Account Branding feature (accountSettings properties `canSelfBrandSend` and `canSelfBrandSend`) must be set to **true** to use this call.

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
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandsRequest = new BrandsRequest(); // BrandsRequest |  (optional) 

            try
            {
                // Deletes one or more brand profiles.
                BrandsResponse result = apiInstance.DeleteBrands(accountId, brandsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandsRequest** | [**BrandsRequest**](BrandsRequest.md)|  | [optional] 

### Return type

[**BrandsResponse**](BrandsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecaptiverecipient"></a>
# **DeleteCaptiveRecipient**
> CaptiveRecipientInformation DeleteCaptiveRecipient (string accountId, string recipientPart, CaptiveRecipientInformation captiveRecipientInformation = null)

Deletes the signature for one or more captive recipient records.

Deletes the signature for one or more captive recipient records; it is primarily used for testing. This provides a way to reset the signature associated with a client user ID so that a new signature can be created the next time the client user ID is used.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteCaptiveRecipientExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var recipientPart = recipientPart_example;  // string | 
            var captiveRecipientInformation = new CaptiveRecipientInformation(); // CaptiveRecipientInformation |  (optional) 

            try
            {
                // Deletes the signature for one or more captive recipient records.
                CaptiveRecipientInformation result = apiInstance.DeleteCaptiveRecipient(accountId, recipientPart, captiveRecipientInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteCaptiveRecipient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **recipientPart** | **string**|  | 
 **captiveRecipientInformation** | [**CaptiveRecipientInformation**](CaptiveRecipientInformation.md)|  | [optional] 

### Return type

[**CaptiveRecipientInformation**](CaptiveRecipientInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteenoteconfiguration"></a>
# **DeleteENoteConfiguration**
> void DeleteENoteConfiguration (string accountId)

Deletes configuration information for the eNote eOriginal integration.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteENoteConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Deletes configuration information for the eNote eOriginal integration.
                apiInstance.DeleteENoteConfiguration(accountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteENoteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepermissionprofile"></a>
# **DeletePermissionProfile**
> void DeletePermissionProfile (string accountId, string permissionProfileId)

Deletes a permissions profile within the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeletePermissionProfileExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var permissionProfileId = permissionProfileId_example;  // string | 

            try
            {
                // Deletes a permissions profile within the specified account.
                apiInstance.DeletePermissionProfile(accountId, permissionProfileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.DeletePermissionProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **permissionProfileId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountinformation"></a>
# **GetAccountInformation**
> AccountInformation GetAccountInformation (string accountId, string includeAccountSettings = null)

Retrieves the account information for the specified account.

Retrieves the account information for the specified account.  **Response** The `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetAccountInformationExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var includeAccountSettings = includeAccountSettings_example;  // string | When set to **true**, includes the account settings for the account in the response. (optional) 

            try
            {
                // Retrieves the account information for the specified account.
                AccountInformation result = apiInstance.GetAccountInformation(accountId, includeAccountSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccountInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **includeAccountSettings** | **string**| When set to **true**, includes the account settings for the account in the response. | [optional] 

### Return type

[**AccountInformation**](AccountInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccounttabsettings"></a>
# **GetAccountTabSettings**
> TabAccountSettings GetAccountTabSettings (string accountId)

Returns tab settings list for specified account

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetAccountTabSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Returns tab settings list for specified account
                TabAccountSettings result = apiInstance.GetAccountTabSettings(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccountTabSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**TabAccountSettings**](TabAccountSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbillingcharges"></a>
# **GetBillingCharges**
> BillingChargeResponse GetBillingCharges (string accountId, string includeCharges = null)

Gets list of recurring and usage charges for the account.

Retrieves the list of recurring and usage charges for the account. This can be used to determine the charge structure and usage of charge plan items.   Privileges required: account administrator 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetBillingChargesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var includeCharges = includeCharges_example;  // string | Specifies which billing charges to return. Valid values are:  * envelopes * seats  (optional) 

            try
            {
                // Gets list of recurring and usage charges for the account.
                BillingChargeResponse result = apiInstance.GetBillingCharges(accountId, includeCharges);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetBillingCharges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **includeCharges** | **string**| Specifies which billing charges to return. Valid values are:  * envelopes * seats  | [optional] 

### Return type

[**BillingChargeResponse**](BillingChargeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrand"></a>
# **GetBrand**
> Brand GetBrand (string accountId, string brandId, string includeExternalReferences = null, string includeLogos = null)

Get information for a specific brand.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetBrandExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var includeExternalReferences = includeExternalReferences_example;  // string |  (optional) 
            var includeLogos = includeLogos_example;  // string |  (optional) 

            try
            {
                // Get information for a specific brand.
                Brand result = apiInstance.GetBrand(accountId, brandId, includeExternalReferences, includeLogos);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **includeExternalReferences** | **string**|  | [optional] 
 **includeLogos** | **string**|  | [optional] 

### Return type

[**Brand**](Brand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrandlogobytype"></a>
# **GetBrandLogoByType**
> void GetBrandLogoByType (string accountId, string brandId, string logoType)

Obtains the specified image for a brand.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetBrandLogoByTypeExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var logoType = logoType_example;  // string | One of **Primary**, **Secondary** or **Email**.

            try
            {
                // Obtains the specified image for a brand.
                apiInstance.GetBrandLogoByType(accountId, brandId, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetBrandLogoByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **logoType** | **string**| One of **Primary**, **Secondary** or **Email**. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrandresources"></a>
# **GetBrandResources**
> BrandResourcesList GetBrandResources (string accountId, string brandId)

Returns the specified account's list of branding resources (metadata).

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetBrandResourcesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.

            try
            {
                // Returns the specified account's list of branding resources (metadata).
                BrandResourcesList result = apiInstance.GetBrandResources(accountId, brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetBrandResources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 

### Return type

[**BrandResourcesList**](BrandResourcesList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrandresourcesbycontenttype"></a>
# **GetBrandResourcesByContentType**
> void GetBrandResourcesByContentType (string accountId, string brandId, string resourceContentType, string langcode = null, string returnMaster = null)

Returns the specified branding resource file.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetBrandResourcesByContentTypeExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var resourceContentType = resourceContentType_example;  // string | 
            var langcode = langcode_example;  // string |  (optional) 
            var returnMaster = returnMaster_example;  // string |  (optional) 

            try
            {
                // Returns the specified branding resource file.
                apiInstance.GetBrandResourcesByContentType(accountId, brandId, resourceContentType, langcode, returnMaster);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetBrandResourcesByContentType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **resourceContentType** | **string**|  | 
 **langcode** | **string**|  | [optional] 
 **returnMaster** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsumerdisclosure"></a>
# **GetConsumerDisclosure**
> ConsumerDisclosure GetConsumerDisclosure (string accountId, string langCode)

Gets the Electronic Record and Signature Disclosure.

Retrieves the Electronic Record and Signature Disclosure, with HTML formatting, for the requested envelope recipient. This might be different than the current account disclosure depending on account settings, such as branding, and when the account disclosure was last updated. An optional query string can be included to return the language for the disclosure.  

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetConsumerDisclosureExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var langCode = langCode_example;  // string | The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to �browser� to automatically detect the browser language being used by the viewer and display the disclosure in that language.

            try
            {
                // Gets the Electronic Record and Signature Disclosure.
                ConsumerDisclosure result = apiInstance.GetConsumerDisclosure(accountId, langCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetConsumerDisclosure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **langCode** | **string**| The simple type enumeration the language used in the response. The supported languages, with the language value shown in parenthesis, are:Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk) and Vietnamese (vi). Additionally, the value can be set to �browser� to automatically detect the browser language being used by the viewer and display the disclosure in that language. | 

### Return type

[**ConsumerDisclosure**](ConsumerDisclosure.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsumerdisclosuredefault"></a>
# **GetConsumerDisclosureDefault**
> ConsumerDisclosure GetConsumerDisclosureDefault (string accountId, string langCode = null)

Gets the Electronic Record and Signature Disclosure for the account.

Retrieves the Electronic Record and Signature Disclosure, with HTML formatting, associated with the account. You can use an optional query string to set the language for the disclosure.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetConsumerDisclosureDefaultExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var langCode = langCode_example;  // string | Specifies the language used in the response. The supported languages, with the language value shown in parenthesis, are: Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk), and Vietnamese (vi).  Additionally, the value can be set to `browser` to automatically detect the browser language being used by the viewer and display the disclosure in that language.  (optional) 

            try
            {
                // Gets the Electronic Record and Signature Disclosure for the account.
                ConsumerDisclosure result = apiInstance.GetConsumerDisclosureDefault(accountId, langCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetConsumerDisclosureDefault: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **langCode** | **string**| Specifies the language used in the response. The supported languages, with the language value shown in parenthesis, are: Arabic (ar), Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Bahasa Indonesia (id), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Bahasa Melayu (ms), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro), Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk), and Vietnamese (vi).  Additionally, the value can be set to &#x60;browser&#x60; to automatically detect the browser language being used by the viewer and display the disclosure in that language.  | [optional] 

### Return type

[**ConsumerDisclosure**](ConsumerDisclosure.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getenoteconfiguration"></a>
# **GetENoteConfiguration**
> ENoteConfiguration GetENoteConfiguration (string accountId)

Returns the configuration information for the eNote eOriginal integration.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetENoteConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Returns the configuration information for the eNote eOriginal integration.
                ENoteConfiguration result = apiInstance.GetENoteConfiguration(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetENoteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**ENoteConfiguration**](ENoteConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpermissionprofile"></a>
# **GetPermissionProfile**
> PermissionProfile GetPermissionProfile (string accountId, string permissionProfileId, string include = null)

Returns a permissions profile in the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetPermissionProfileExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var permissionProfileId = permissionProfileId_example;  // string | 
            var include = include_example;  // string |  (optional) 

            try
            {
                // Returns a permissions profile in the specified account.
                PermissionProfile result = apiInstance.GetPermissionProfile(accountId, permissionProfileId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetPermissionProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **permissionProfileId** | **string**|  | 
 **include** | **string**|  | [optional] 

### Return type

[**PermissionProfile**](PermissionProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprovisioning"></a>
# **GetProvisioning**
> ProvisioningInformation GetProvisioning ()

Retrieves the account provisioning information for the account.

Retrieves the account provisioning information for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetProvisioningExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();

            try
            {
                // Retrieves the account provisioning information for the account.
                ProvisioningInformation result = apiInstance.GetProvisioning();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.GetProvisioning: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProvisioningInformation**](ProvisioningInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbrands"></a>
# **ListBrands**
> BrandsResponse ListBrands (string accountId, string excludeDistributorBrand = null, string includeLogos = null)

Gets a list of brand profiles.

Retrieves the list of brand profiles associated with the account and the default brand profiles. The Account Branding feature (accountSettings properties `canSelfBrandSend` and `canSelfBrandSend`)  must be set to **true** for the account to use this call.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListBrandsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var excludeDistributorBrand = excludeDistributorBrand_example;  // string | When set to **true**, excludes distributor brand information from the response set. (optional) 
            var includeLogos = includeLogos_example;  // string | When set to **true**, returns the logos associated with the brand. (optional) 

            try
            {
                // Gets a list of brand profiles.
                BrandsResponse result = apiInstance.ListBrands(accountId, excludeDistributorBrand, includeLogos);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **excludeDistributorBrand** | **string**| When set to **true**, excludes distributor brand information from the response set. | [optional] 
 **includeLogos** | **string**| When set to **true**, returns the logos associated with the brand. | [optional] 

### Return type

[**BrandsResponse**](BrandsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcustomfields"></a>
# **ListCustomFields**
> CustomFields ListCustomFields (string accountId)

Gets a list of custom fields associated with the account.

Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.  There are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListCustomFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets a list of custom fields associated with the account.
                CustomFields result = apiInstance.ListCustomFields(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**CustomFields**](CustomFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpermissions"></a>
# **ListPermissions**
> PermissionProfileInformation ListPermissions (string accountId, string include = null)

Gets a list of permission profiles.

Retrieves a list of Permission Profiles. Permission Profiles are a standard set of user permissions that you can apply to individual users or users in a Group. This makes it easier to manage user permissions for a large number of users, without having to change permissions on a user-by-user basis.  Currently, Permission Profiles can only be created and modified in the DocuSign console.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListPermissionsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var include = include_example;  // string |  (optional) 

            try
            {
                // Gets a list of permission profiles.
                PermissionProfileInformation result = apiInstance.ListPermissions(accountId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **include** | **string**|  | [optional] 

### Return type

[**PermissionProfileInformation**](PermissionProfileInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrecipientnamesbyemail"></a>
# **ListRecipientNamesByEmail**
> RecipientNamesResponse ListRecipientNamesByEmail (string accountId, string email = null)

Gets recipient names associated with an email address.

Retrieves a list of recipients in the specified account that are associated with a email address supplied in the query string.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListRecipientNamesByEmailExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var email = email_example;  // string | The email address for the user (optional) 

            try
            {
                // Gets recipient names associated with an email address.
                RecipientNamesResponse result = apiInstance.ListRecipientNamesByEmail(accountId, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListRecipientNamesByEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **email** | **string**| The email address for the user | [optional] 

### Return type

[**RecipientNamesResponse**](RecipientNamesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsettings"></a>
# **ListSettings**
> AccountSettingsInformation ListSettings (string accountId)

Gets account settings information.

Retrieves the account settings information for the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets account settings information.
                AccountSettingsInformation result = apiInstance.ListSettings(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**AccountSettingsInformation**](AccountSettingsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsharedaccess"></a>
# **ListSharedAccess**
> AccountSharedAccess ListSharedAccess (string accountId, string count = null, string envelopesNotSharedUserStatus = null, string folderIds = null, string itemType = null, string searchText = null, string shared = null, string startPosition = null, string userIds = null)

Reserved: Gets the shared item status for one or more users.

Reserved: Retrieves shared item status for one or more users and types of items.  Users with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListSharedAccessExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var count = count_example;  // string | Specifies maximum number of results included in the response. If no value is specified, this defaults to 1000. (optional) 
            var envelopesNotSharedUserStatus = envelopesNotSharedUserStatus_example;  // string |  (optional) 
            var folderIds = folderIds_example;  // string |  (optional) 
            var itemType = itemType_example;  // string | Specifies the type of shared item being requested. The accepted values are: -envelopes: returns information about envelope sharing between users. (optional) 
            var searchText = searchText_example;  // string | This can be used to filter user names in the response. The wild-card ‘*’ (asterisk) can be used around the string. (optional) 
            var shared = shared_example;  // string | Specifies which users should be included in the response. Multiple values can be used in the query by using a comma separated list of shared values. If the requestor does not have account administrator privileges, the shared_to value is used. Requestors that do not have account administrator privileges can only use the shared_to, any other setting will result in an error. The accepted values are:  -not_shared: Returns account users that the specified item type is not being shared with and that are not sharing the specified item type with the user.  User X (Share) X Account user  -shared_to: Returns account users that the specified item type is not being shared with and who are sharing the specified item type with the user (only shared to the user).  User X (Share) Account user  -shared_from: Returns account users that the specified item type is being shared with and who are not sharing the specified item type with the user (only shared from the user).  User (Share) >> Account user  -shared_to_and_from: Returns account users that the specified item type is being shared with and who are sharing the specified item type with the user.  User << (Share) >> Account user (optional) 
            var startPosition = startPosition_example;  // string | If the response set exceeds Count, this can be used to specify that the method should return users starting at the specified index. The first index is 0, and should be used in the first GET call. Typically this number is a multiple of Count. If no value is specified, this defaults to be 0.  (optional) 
            var userIds = userIds_example;  // string | A comma separated list of userIds for whom the shared item information is being requested.  (optional) 

            try
            {
                // Reserved: Gets the shared item status for one or more users.
                AccountSharedAccess result = apiInstance.ListSharedAccess(accountId, count, envelopesNotSharedUserStatus, folderIds, itemType, searchText, shared, startPosition, userIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListSharedAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **count** | **string**| Specifies maximum number of results included in the response. If no value is specified, this defaults to 1000. | [optional] 
 **envelopesNotSharedUserStatus** | **string**|  | [optional] 
 **folderIds** | **string**|  | [optional] 
 **itemType** | **string**| Specifies the type of shared item being requested. The accepted values are: -envelopes: returns information about envelope sharing between users. | [optional] 
 **searchText** | **string**| This can be used to filter user names in the response. The wild-card ‘*’ (asterisk) can be used around the string. | [optional] 
 **shared** | **string**| Specifies which users should be included in the response. Multiple values can be used in the query by using a comma separated list of shared values. If the requestor does not have account administrator privileges, the shared_to value is used. Requestors that do not have account administrator privileges can only use the shared_to, any other setting will result in an error. The accepted values are:  -not_shared: Returns account users that the specified item type is not being shared with and that are not sharing the specified item type with the user.  User X (Share) X Account user  -shared_to: Returns account users that the specified item type is not being shared with and who are sharing the specified item type with the user (only shared to the user).  User X (Share) Account user  -shared_from: Returns account users that the specified item type is being shared with and who are not sharing the specified item type with the user (only shared from the user).  User (Share) &gt;&gt; Account user  -shared_to_and_from: Returns account users that the specified item type is being shared with and who are sharing the specified item type with the user.  User &lt;&lt; (Share) &gt;&gt; Account user | [optional] 
 **startPosition** | **string**| If the response set exceeds Count, this can be used to specify that the method should return users starting at the specified index. The first index is 0, and should be used in the first GET call. Typically this number is a multiple of Count. If no value is specified, this defaults to be 0.  | [optional] 
 **userIds** | **string**| A comma separated list of userIds for whom the shared item information is being requested.  | [optional] 

### Return type

[**AccountSharedAccess**](AccountSharedAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsignatureproviders"></a>
# **ListSignatureProviders**
> AccountSignatureProviders ListSignatureProviders (string accountId)

Returns Account available signature providers for specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListSignatureProvidersExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Returns Account available signature providers for specified account.
                AccountSignatureProviders result = apiInstance.ListSignatureProviders(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListSignatureProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**AccountSignatureProviders**](AccountSignatureProviders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listunsupportedfiletypes"></a>
# **ListUnsupportedFileTypes**
> FileTypeList ListUnsupportedFileTypes (string accountId)

Gets a list of unsupported file types.

Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListUnsupportedFileTypesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets a list of unsupported file types.
                FileTypeList result = apiInstance.ListUnsupportedFileTypes(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListUnsupportedFileTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**FileTypeList**](FileTypeList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccounttabsettings"></a>
# **UpdateAccountTabSettings**
> TabAccountSettings UpdateAccountTabSettings (string accountId, TabAccountSettings tabAccountSettings = null)

Modifies tab settings for specified account

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateAccountTabSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var tabAccountSettings = new TabAccountSettings(); // TabAccountSettings |  (optional) 

            try
            {
                // Modifies tab settings for specified account
                TabAccountSettings result = apiInstance.UpdateAccountTabSettings(accountId, tabAccountSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateAccountTabSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **tabAccountSettings** | [**TabAccountSettings**](TabAccountSettings.md)|  | [optional] 

### Return type

[**TabAccountSettings**](TabAccountSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebrand"></a>
# **UpdateBrand**
> Brand UpdateBrand (string accountId, string brandId, Brand brand = null)

Updates an existing brand.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateBrandExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var brand = new Brand(); // Brand |  (optional) 

            try
            {
                // Updates an existing brand.
                Brand result = apiInstance.UpdateBrand(accountId, brandId, brand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **brand** | [**Brand**](Brand.md)|  | [optional] 

### Return type

[**Brand**](Brand.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebrandlogobytype"></a>
# **UpdateBrandLogoByType**
> void UpdateBrandLogoByType (string accountId, string brandId, string logoType)

Put one branding logo.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateBrandLogoByTypeExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var logoType = logoType_example;  // string | One of **Primary**, **Secondary** or **Email**.

            try
            {
                // Put one branding logo.
                apiInstance.UpdateBrandLogoByType(accountId, brandId, logoType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateBrandLogoByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **logoType** | **string**| One of **Primary**, **Secondary** or **Email**. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebrandresourcesbycontenttype"></a>
# **UpdateBrandResourcesByContentType**
> BrandResources UpdateBrandResourcesByContentType (string accountId, string brandId, string resourceContentType)

Uploads a branding resource file.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateBrandResourcesByContentTypeExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var brandId = brandId_example;  // string | The unique identifier of a brand.
            var resourceContentType = resourceContentType_example;  // string | 

            try
            {
                // Uploads a branding resource file.
                BrandResources result = apiInstance.UpdateBrandResourcesByContentType(accountId, brandId, resourceContentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateBrandResourcesByContentType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **brandId** | **string**| The unique identifier of a brand. | 
 **resourceContentType** | **string**|  | 

### Return type

[**BrandResources**](BrandResources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateenoteconfiguration"></a>
# **UpdateENoteConfiguration**
> ENoteConfiguration UpdateENoteConfiguration (string accountId, ENoteConfiguration eNoteConfiguration = null)

Updates configuration information for the eNote eOriginal integration.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateENoteConfigurationExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var eNoteConfiguration = new ENoteConfiguration(); // ENoteConfiguration |  (optional) 

            try
            {
                // Updates configuration information for the eNote eOriginal integration.
                ENoteConfiguration result = apiInstance.UpdateENoteConfiguration(accountId, eNoteConfiguration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateENoteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **eNoteConfiguration** | [**ENoteConfiguration**](ENoteConfiguration.md)|  | [optional] 

### Return type

[**ENoteConfiguration**](ENoteConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepermissionprofile"></a>
# **UpdatePermissionProfile**
> PermissionProfile UpdatePermissionProfile (string accountId, string permissionProfileId, string include = null, PermissionProfile permissionProfile = null)

Updates a permission profile within the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdatePermissionProfileExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var permissionProfileId = permissionProfileId_example;  // string | 
            var include = include_example;  // string |  (optional) 
            var permissionProfile = new PermissionProfile(); // PermissionProfile |  (optional) 

            try
            {
                // Updates a permission profile within the specified account.
                PermissionProfile result = apiInstance.UpdatePermissionProfile(accountId, permissionProfileId, include, permissionProfile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdatePermissionProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **permissionProfileId** | **string**|  | 
 **include** | **string**|  | [optional] 
 **permissionProfile** | [**PermissionProfile**](PermissionProfile.md)|  | [optional] 

### Return type

[**PermissionProfile**](PermissionProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesettings"></a>
# **UpdateSettings**
> void UpdateSettings (string accountId, AccountSettingsInformation accountSettingsInformation = null)

Updates the account settings for an account.

Updates the account settings for the specified account.

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
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var accountSettingsInformation = new AccountSettingsInformation(); // AccountSettingsInformation |  (optional) 

            try
            {
                // Updates the account settings for an account.
                apiInstance.UpdateSettings(accountId, accountSettingsInformation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **accountSettingsInformation** | [**AccountSettingsInformation**](AccountSettingsInformation.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesharedaccess"></a>
# **UpdateSharedAccess**
> AccountSharedAccess UpdateSharedAccess (string accountId, string itemType = null, string userIds = null, AccountSharedAccess accountSharedAccess = null)

Reserved: Sets the shared access information for users.

Reserved: Sets the shared access information for one or more users.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateSharedAccessExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var itemType = itemType_example;  // string |  (optional) 
            var userIds = userIds_example;  // string |  (optional) 
            var accountSharedAccess = new AccountSharedAccess(); // AccountSharedAccess |  (optional) 

            try
            {
                // Reserved: Sets the shared access information for users.
                AccountSharedAccess result = apiInstance.UpdateSharedAccess(accountId, itemType, userIds, accountSharedAccess);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateSharedAccess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **itemType** | **string**|  | [optional] 
 **userIds** | **string**|  | [optional] 
 **accountSharedAccess** | [**AccountSharedAccess**](AccountSharedAccess.md)|  | [optional] 

### Return type

[**AccountSharedAccess**](AccountSharedAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

