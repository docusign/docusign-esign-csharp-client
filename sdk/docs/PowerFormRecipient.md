# DocuSign.eSign.Model.PowerFormRecipient
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessCode** | **string** | If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account’s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required. | [optional] 
**AccessCodeLocked** | **string** |  | [optional] 
**AccessCodeRequired** | **string** |  | [optional] 
**Email** | **string** |  | [optional] 
**EmailLocked** | **string** |  | [optional] 
**IdCheckConfigurationName** | **string** | Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.  *Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as &#39;ID Check $&#39; and &#39;SMS Auth $&#39;. To use ID check in an envelope, the idCheckConfigurationName should be &#39;ID Check &#39;. If you wanted to use SMS, it would be &#39;SMS Auth $&#39; and you would need to add you would need to add phone number information to the &#x60;smsAuthentication&#x60; node. | [optional] 
**IdCheckRequired** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**RecipientType** | **string** |  | [optional] 
**RoleName** | **string** | Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients. | [optional] 
**RoutingOrder** | **string** | Specifies the routing order of the recipient in the envelope.  | [optional] 
**TemplateRequiresIdLookup** | **string** |  | [optional] 
**UserNameLocked** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

