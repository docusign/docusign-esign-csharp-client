# DocuSign.eSign.Model.AccountBillingPlanResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BillingAddress** | [**AccountAddress**](AccountAddress.md) |  | [optional] 
**BillingAddressIsCreditCardAddress** | **string** | When set to **true**, the credit card address information is the same as that returned as the billing address. If false, then the billing address is considered a billing contact address, and the credit card address can be different. | [optional] 
**BillingPlan** | [**AccountBillingPlan**](AccountBillingPlan.md) |  | [optional] 
**CreditCardInformation** | [**CreditCardInformation**](CreditCardInformation.md) |  | [optional] 
**PaymentProcessorInformation** | [**PaymentProcessorInformation**](PaymentProcessorInformation.md) |  | [optional] 
**ReferralInformation** | [**ReferralInformation**](ReferralInformation.md) |  | [optional] 
**SuccessorPlans** | [**List&lt;BillingPlan&gt;**](BillingPlan.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

