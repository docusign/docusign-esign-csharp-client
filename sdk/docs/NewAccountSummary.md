# DocuSign.eSign.Model.NewAccountSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account ID associated with the envelope. | [optional] 
**AccountIdGuid** | **string** | The GUID associated with the account ID. | [optional] 
**AccountName** | **string** | The account name for the new account. | [optional] 
**ApiPassword** | **string** | Contains a token that can be used for authentication in API calls instead of using the user name and password. | [optional] 
**BaseUrl** | **string** | The URL that should be used for successive calls to this account. It includes the protocal (https), the DocuSign server where the account is located, and the account number. Use this Url to make API calls against this account. Many of the API calls provide Uri&#39;s that are relative to this baseUrl. | [optional] 
**BillingPlanPreview** | [**BillingPlanPreview**](BillingPlanPreview.md) |  | [optional] 
**UserId** | **string** | Specifies the user ID of the new user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

