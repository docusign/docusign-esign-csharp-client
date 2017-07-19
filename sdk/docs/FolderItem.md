# DocuSign.eSign.Model.FolderItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompletedDateTime** | **string** | Specifies the date and time this item was completed. | [optional] 
**CreatedDateTime** | **string** | Indicates the date and time the item was created. | [optional] 
**CustomFields** | [**List&lt;CustomFieldV2&gt;**](CustomFieldV2.md) | An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters. | [optional] 
**Description** | **string** |  | [optional] 
**EnvelopeId** | **string** | The envelope ID of the envelope status that failed to post. | [optional] 
**EnvelopeUri** | **string** | Contains a URI for an endpoint that you can use to retrieve the envelope or envelopes. | [optional] 
**Is21CFRPart11** | **string** | When set to **true**, indicates that this module is enabled on the account. | [optional] 
**IsSignatureProviderEnvelope** | **string** |  | [optional] 
**LastModified** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**OwnerName** | **string** | Name of the envelope owner. | [optional] 
**PageCount** | **int?** |  | [optional] 
**Password** | **string** |  | [optional] 
**SenderEmail** | **string** |  | [optional] 
**SenderName** | **string** | Name of the envelope sender. | [optional] 
**SentDateTime** | **string** | The date and time the envelope was sent. | [optional] 
**Shared** | **string** | When set to **true**, this custom tab is shared. | [optional] 
**Status** | **string** | Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later. | [optional] 
**Subject** | **string** |  | [optional] 
**TemplateId** | **string** | The unique identifier of the template. If this is not provided, DocuSign will generate a value.  | [optional] 
**Uri** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

