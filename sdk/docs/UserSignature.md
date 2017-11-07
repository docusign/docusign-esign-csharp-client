# DocuSign.eSign.Model.UserSignature
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdoptedDateTime** | **string** | The date and time the user adopted their signature. | [optional] 
**CreatedDateTime** | **string** | Indicates the date and time the item was created. | [optional] 
**DateStampProperties** | [**DateStampProperties**](DateStampProperties.md) |  | [optional] 
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**ExternalID** | **string** |  | [optional] 
**ImageType** | **string** |  | [optional] 
**Initials150ImageId** | **string** |  | [optional] 
**InitialsImageUri** | **string** | Contains the URI for an endpoint that you can use to retrieve the initials image. | [optional] 
**IsDefault** | **string** |  | [optional] 
**PhoneticName** | **string** |  | [optional] 
**Signature150ImageId** | **string** |  | [optional] 
**SignatureFont** | **string** | The font type for the signature, if the signature is not drawn. The supported font types are:  \&quot;7_DocuSign\&quot;, \&quot;1_DocuSign\&quot;, \&quot;6_DocuSign\&quot;, \&quot;8_DocuSign\&quot;, \&quot;3_DocuSign\&quot;, \&quot;Mistral\&quot;, \&quot;4_DocuSign\&quot;, \&quot;2_DocuSign\&quot;, \&quot;5_DocuSign\&quot;, \&quot;Rage Italic\&quot;  | [optional] 
**SignatureId** | **string** | Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID. | [optional] 
**SignatureImageUri** | **string** | Contains the URI for an endpoint that you can use to retrieve the signature image. | [optional] 
**SignatureInitials** | **string** |  The initials associated with the signature. | [optional] 
**SignatureName** | **string** | Specifies the user signature name. | [optional] 
**SignatureType** | **string** |  | [optional] 
**StampFormat** | **string** |  | [optional] 
**StampImageUri** | **string** |  | [optional] 
**StampSizeMM** | **string** |  | [optional] 
**StampType** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

