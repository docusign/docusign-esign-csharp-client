# DocuSign.eSign.Model.EnvelopeFormData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailSubject** | **string** | Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject. | [optional] 
**EnvelopeId** | **string** | The envelope ID of the envelope status that failed to post. | [optional] 
**FormData** | [**List&lt;NameValue&gt;**](NameValue.md) |  | [optional] 
**RecipientFormData** | [**List&lt;RecipientFormData&gt;**](RecipientFormData.md) |  | [optional] 
**SentDateTime** | **string** | The date and time the envelope was sent. | [optional] 
**Status** | **string** | Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

