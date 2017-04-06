# DocuSign.eSign.Model.UserSignatureDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SignatureFont** | **string** |  | [optional] 
**SignatureId** | **string** | Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID. | [optional] 
**SignatureInitials** | **string** |  | [optional] 
**SignatureName** | **string** | Specifies the user signature name. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

