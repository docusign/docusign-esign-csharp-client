# DocuSign.eSign.Model.LoginAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account ID associated with the envelope. | [optional] 
**AccountIdGuid** | **string** | The GUID associated with the account ID. | [optional] 
**BaseUrl** | **string** | The URL that should be used for successive calls to this account. It includes the protocal (https), the DocuSign server where the account is located, and the account number. Use this Url to make API calls against this account. Many of the API calls provide Uri&#39;s that are relative to this baseUrl. | [optional] 
**Email** | **string** | The email address for the user. | [optional] 
**IsDefault** | **string** | This value is true if this is the default account for the user, otherwise false is returned. | [optional] 
**LoginAccountSettings** | [**List&lt;NameValue&gt;**](NameValue.md) | A list of settings on the acccount that indicate what features are available. | [optional] 
**LoginUserSettings** | [**List&lt;NameValue&gt;**](NameValue.md) | A list of user-level settings that indicate what user-specific features are available. | [optional] 
**Name** | **string** | The name associated with the account. | [optional] 
**SiteDescription** | **string** | An optional descirption of the site that hosts the account. | [optional] 
**UserId** | **string** |  | [optional] 
**UserName** | **string** | The name of this user as defined by the account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

