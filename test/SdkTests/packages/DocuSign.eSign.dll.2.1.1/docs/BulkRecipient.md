# DocuSign.eSign.Model.BulkRecipient
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessCode** | **string** | If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account’s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required. | [optional] 
**Email** | **string** | Specifies the recipient&#39;s email address.   Maximum length: 100 characters. | [optional] 
**ErrorDetails** | [**List&lt;ErrorDetails&gt;**](ErrorDetails.md) | Array or errors. | [optional] 
**Identification** | **string** | Specifies the authentication check used for the signer. If blank then no authentication check is required for the signer. Only one value can be used in this field.  The acceptable values are:  * KBA: Enables the normal ID check authentication set up for your account. * Phone: Enables phone authentication. * SMS: Enables SMS authentication. | [optional] 
**Name** | **string** | Specifies the recipient&#39;s name.   Maximum length: 50 characters. | [optional] 
**Note** | **string** | Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.  Maximum Length: 1000 characters. | [optional] 
**PhoneNumber** | **string** | This is only used if the Identification field value is Phone or SMS. The value for this field can be a valid telephone number or, if Phone, usersupplied (SMS authentication cannot use a user supplied number). Parenthesis and dashes can be used in the telephone number.  If &#x60;usersupplied&#x60; is used, the signer supplies his or her own telephone number. | [optional] 
**RecipientSignatureProviderInfo** | [**List&lt;BulkRecipientSignatureProvider&gt;**](BulkRecipientSignatureProvider.md) |  | [optional] 
**RowNumber** | **string** |  | [optional] 
**TabLabels** | [**List&lt;BulkRecipientTabLabel&gt;**](BulkRecipientTabLabel.md) | Specifies values used to populate recipient tabs with information. This allows each bulk recipient signer to have different values for their associated tabs. Any number of &#x60;tabLabel&#x60; columns can be added to the bulk recipient file.  The information used in the bulk recipient file header must be the same as the &#x60;tabLabel&#x60; for the tab.  The values entered in this column are automatically inserted into the corresponding tab for the recipient in the same row.  Note that this option cannot be used for tabs that do not have data or that are automatically populated data such as Signature, Full Name, Email Address, Company, Title, and Date Signed tabs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

