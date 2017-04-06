# DocuSign.eSign.Model.AccountBillingPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddOns** | [**List&lt;AddOn&gt;**](AddOn.md) | Reserved: | [optional] 
**CanCancelRenewal** | **string** | Reserved: TBD | [optional] 
**CanUpgrade** | **string** | When set to **true**, specifies that you can upgrade the account through the API. | [optional] 
**CurrencyCode** | **string** | Specifies the ISO currency code for the account. | [optional] 
**EnableSupport** | **string** | When set to **true**, then customer support is provided as part of the account plan. | [optional] 
**IncludedSeats** | **string** | The number of seats (users) included. | [optional] 
**IncrementalSeats** | **string** | Reserved: TBD | [optional] 
**IsDowngrade** | **string** |  | [optional] 
**OtherDiscountPercent** | **string** |  Any other percentage discount for the plan.  | [optional] 
**PaymentCycle** | **string** |  | [optional] 
**PaymentMethod** | **string** |  The payment method used with the plan. The possible values are: CreditCard, PurchaseOrder, Premium, or Freemium.  | [optional] 
**PerSeatPrice** | **string** |  | [optional] 
**PlanClassification** | **string** | Identifies the type of plan. Examples include Business, Corporate, Enterprise, Free. | [optional] 
**PlanFeatureSets** | [**List&lt;FeatureSet&gt;**](FeatureSet.md) | A complex type that sets the feature sets for the account. It contains the following information (all string content):  * currencyFeatureSetPrices - Contains the currencyCode and currencySymbol for the alternate currency values for envelopeFee, fixedFee, seatFee that are configured for this plan feature set. * envelopeFee - An incremental envelope cost for plans with envelope overages (when isEnabled&#x3D;true). * featureSetId - A unique ID for the feature set. * fixedFee - A one-time fee associated with the plan (when isEnabled&#x3D;true). * isActive - Specifies whether the feature set is actively set as part of the plan. * isEnabled - Specifies whether the feature set is actively enabled as part of the plan. * name - The name of the feature set. * seatFee - An incremental seat cost for seat-based plans (when isEnabled&#x3D;true).  | [optional] 
**PlanId** | **string** |  | [optional] 
**PlanName** | **string** | The name of the Billing Plan. | [optional] 
**RenewalStatus** | **string** | The renewal status for the account. The acceptable values are:  * auto: The account automatically renews. * queued_for_close: Account will be closed at the billingPeriodEndDate. * queued_for_downgrade: Account will be downgraded at the billingPeriodEndDate. | [optional] 
**SeatDiscounts** | [**List&lt;SeatDiscount&gt;**](SeatDiscount.md) |  A complex type that contains any seat discount information.  Values are: BeginSeatCount, EndSeatCount, and SeatDiscountPercent.   | [optional] 
**SupportIncidentFee** | **string** | The support incident fee charged for each support incident. | [optional] 
**SupportPlanFee** | **string** | The support plan fee charged for this plan. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

