# DocuSign.eSign.Model.AccountSharedAccess
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account ID associated with the envelope. | [optional] 
**EndPosition** | **string** | The last position in the result set.  | [optional] 
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**NextUri** | **string** | The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null.  | [optional] 
**PreviousUri** | **string** | The postal code for the billing address. | [optional] 
**ResultSetSize** | **string** | The number of results returned in this response.  | [optional] 
**SharedAccess** | [**List&lt;MemberSharedItems&gt;**](MemberSharedItems.md) | A complex type containing the shared access information to an envelope for the users specified in the request. | [optional] 
**StartPosition** | **string** | Starting position of the current result set. | [optional] 
**TotalSetSize** | **string** | The total number of items available in the result set. This will always be greater than or equal to the value of the property returning the results in the in the response. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

