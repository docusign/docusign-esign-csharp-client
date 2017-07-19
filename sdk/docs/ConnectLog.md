# DocuSign.eSign.Model.ConnectLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account ID associated with the envelope. | [optional] 
**ConfigUrl** | **string** | The web address of the listener or Retrieving Service end point for Connect. | [optional] 
**ConnectDebugLog** | [**List&lt;ConnectDebugLog&gt;**](ConnectDebugLog.md) | A complex element containing information about the Connect configuration, error details, date/time, description and payload.  This is only included in the response if the query additional_info&#x3D;true is used. | [optional] 
**ConnectId** | **string** | The identifier for the Connect configuration that failed. If an account has multiple Connect configurations, this value is used to look up the Connect configuration for the failed post. | [optional] 
**Created** | **string** | The date and time the entry was created. | [optional] 
**Email** | **string** | The email that sent the envelope. | [optional] 
**EnvelopeId** | **string** | The envelope ID of the envelope status that failed to post. | [optional] 
**Error** | **string** | The error that caused the Connect post to fail. | [optional] 
**FailureId** | **string** | The failure log ID for the failure. | [optional] 
**FailureUri** | **string** | The URI for the failure. | [optional] 
**LastTry** | **string** | The date and time the last attempt to post. | [optional] 
**LogId** | **string** | The Connect log ID for the entry. | [optional] 
**LogUri** | **string** | The URI for the log item. | [optional] 
**RetryCount** | **string** | The number of times the Connect post has been retried. | [optional] 
**RetryUri** | **string** | The UEI to retry to publish the Connect failure. | [optional] 
**Status** | **string** | The new envelope status for the failed Connect post. The possible values are: Any, Voided, Created, Deleted, Sent, Delivered, Signed, Completed, Declined, TimedOut, Template, or Processing. | [optional] 
**Subject** | **string** | The envelope subject. | [optional] 
**UserName** | **string** | The name of the envelope sender. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

