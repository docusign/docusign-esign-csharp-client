# DocuSign.eSign.Model.BillingPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppStoreProducts** | [**List&lt;AppStoreProduct&gt;**](AppStoreProduct.md) | Reserved: TBD | [optional] 
**CurrencyPlanPrices** | [**List&lt;CurrencyPlanPrice&gt;**](CurrencyPlanPrice.md) | Contains the currencyCode and currencySymbol for the alternate currency values for envelopeFee, fixedFee, and seatFee that are configured for this plan feature set. | [optional] 
**EnableSupport** | **string** | When set to **true**, then customer support is provided as part of the account plan. | [optional] 
**IncludedSeats** | **string** | The number of seats (users) included. | [optional] 
**OtherDiscountPercent** | **string** |  | [optional] 
**PaymentCycle** | **string** |  The payment cycle associated with the plan. The possible values are: Monthly or Annually.  | [optional] 
**PaymentMethod** | **string** |  | [optional] 
**PerSeatPrice** | **string** | The per seat price for the plan. | [optional] 
**PlanClassification** | **string** | Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free. | [optional] 
**PlanFeatureSets** | [**List&lt;FeatureSet&gt;**](FeatureSet.md) |  | [optional] 
**PlanId** | **string** |  | [optional] 
**PlanName** | **string** | The name of the Billing Plan. | [optional] 
**SeatDiscounts** | [**List&lt;SeatDiscount&gt;**](SeatDiscount.md) |  | [optional] 
**SupportIncidentFee** | **string** | The support incident fee charged for each support incident. | [optional] 
**SupportPlanFee** | **string** | The support plan fee charged for this plan. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

