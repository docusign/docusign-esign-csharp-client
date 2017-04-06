# DocuSign.eSign.Model.LockInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**LockDurationInSeconds** | **string** | Sets the time, in seconds, until the lock expires when there is no activity on the envelope.  If no value is entered, then the default value of 300 seconds is used. The maximum value is 1,800 seconds.  The lock duration can be extended.  | [optional] 
**LockedByApp** | **string** | Specifies the friendly name of  the application that is locking the envelope. | [optional] 
**LockedByUser** | [**UserInfo**](UserInfo.md) |  | [optional] 
**LockedUntilDateTime** | **string** | The datetime until the envelope lock expires. | [optional] 
**LockToken** | **string** | A unique identifier provided to the owner of the envelope lock.   Used to prove ownership of the lock. | [optional] 
**LockType** | **string** | The type of envelope lock.  Currently \&quot;edit\&quot; is the only supported type. | [optional] 
**UseScratchPad** | **string** | Reserved for future use.  Indicates whether a scratchpad is used for editing information.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

