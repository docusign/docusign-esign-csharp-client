# DocuSign.eSign.Model.RadioGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConditionalParentLabel** | **string** | For conditional fields this is the TabLabel of the parent tab that controls this tab&#39;s visibility. | [optional] 
**ConditionalParentValue** | **string** | For conditional fields, this is the value of the parent tab that controls the tab&#39;s visibility.  If the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \&quot;on\&quot; as the value to show that the parent tab is active.  | [optional] 
**DocumentId** | **string** | Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute. | [optional] 
**GroupName** | **string** | The name of the group. | [optional] 
**Radios** | [**List&lt;Radio&gt;**](Radio.md) | Specifies the locations and status for radio buttons that are grouped together. | [optional] 
**RecipientId** | **string** | Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document. | [optional] 
**RequireAll** | **string** | When set to **true** and shared is true, information must be entered in this field to complete the envelope.  | [optional] 
**RequireInitialOnSharedChange** | **string** | Optional element for field markup. When set to **true**, the signer is required to initial when they modify a shared field. | [optional] 
**Shared** | **string** | When set to **true**, this custom tab is shared. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

