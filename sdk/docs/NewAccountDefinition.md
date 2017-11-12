# DocuSign.eSign.Model.NewAccountDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountName** | **string** | The account name for the new account. | [optional] 
**AccountSettings** | [**List&lt;NameValue&gt;**](NameValue.md) | The list of account settings. These determine the features available for the account. Note that some features are determined by the plan used to create the account, and cannot be overridden. | [optional] 
**AddressInformation** | [**AccountAddress**](AccountAddress.md) |  | [optional] 
**CreditCardInformation** | [**CreditCardInformation**](CreditCardInformation.md) |  | [optional] 
**DistributorCode** | **string** | The code that identifies the billing plan groups and plans for the new account. | [optional] 
**DistributorPassword** | **string** | The password for the distributorCode. | [optional] 
**InitialUser** | [**UserInformation**](UserInformation.md) |  | [optional] 
**PaymentProcessorInformation** | [**PaymentProcessorInformation**](PaymentProcessorInformation.md) |  | [optional] 
**PlanInformation** | [**PlanInformation**](PlanInformation.md) |  | [optional] 
**ReferralInformation** | [**ReferralInformation**](ReferralInformation.md) |  | [optional] 
**SocialAccountInformation** | [**SocialAccountInformation**](SocialAccountInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

