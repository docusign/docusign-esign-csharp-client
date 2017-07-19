# DocuSign.eSign.Model.BillingCharge
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedQuantity** | **string** | Reserved: TBD | [optional] 
**Blocked** | **string** | Reserved: TBD | [optional] 
**ChargeName** | **string** | Provides information on what services the charge item is for.  The following table provides a description of the different chargeName values available at this time.  | chargeName | Description | | - -- | - -- | | id_check | ID Check Charge | | in_person_signing | In Person Signing charge | | envelopes Included | Sent Envelopes for the account | | age_verify | Age verification check | | ofac | OFAC Check | | id_confirm | ID confirmation check | | student_authentication | STAN PIN authentication check | | wet_sign_fax | Pages for returning signed documents by fax | | attachment_fax | Pages for returning attachments by fax | | phone_authentication | Phone authentication charge | | powerforms | PowerForm envelopes sent | | signer_payments | Payment processing charge | | outbound_fax | Send by fax charge | | bulk_recipient_envelopes | Bulk Recipient Envelopes sent | | sms_authentications | SMS authentication charge | | saml_authentications | SAML authentication charge | | express_signer_certificate | DocuSign Express Certificate charge | | personal_signer_certificate | Personal Signer Certificate charge | | safe_certificate | SAFE BioPharma Signer Certificate charge | | seats | Included active seats charge | | open_trust_certificate | OpenTrust Signer Certificate charge | | [optional] 
**ChargeType** | **string** | Reserved: TBD | [optional] 
**ChargeUnitOfMeasure** | **string** | Reserved: TBD | [optional] 
**Discounts** | [**List&lt;BillingDiscount&gt;**](BillingDiscount.md) |  | [optional] 
**FirstEffectiveDate** | **string** |  | [optional] 
**IncludedQuantity** | **string** |  | [optional] 
**IncrementalQuantity** | **string** | Reserved: TBD | [optional] 
**LastEffectiveDate** | **string** |  | [optional] 
**Prices** | [**List&lt;BillingPrice&gt;**](BillingPrice.md) |  | [optional] 
**UnitPrice** | **string** | Reserved: TBD | [optional] 
**UsedQuantity** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

