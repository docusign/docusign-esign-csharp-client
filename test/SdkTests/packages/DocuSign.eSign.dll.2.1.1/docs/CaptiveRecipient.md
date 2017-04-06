# DocuSign.eSign.Model.CaptiveRecipient
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientUserId** | **string** | Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters.  | [optional] 
**Email** | **string** | Specifies the email address associated with the captive recipient. | [optional] 
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**UserName** | **string** | Specifies the user name associated with the captive recipient. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

