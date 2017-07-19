# DocuSign.eSign.Model.RecipientViewRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssertionId** | **string** | A unique identifier of the authentication event executed by the client application. | [optional] 
**AuthenticationInstant** | **string** | A sender generated value that indicates the date/time that the signer was authenticated. | [optional] 
**AuthenticationMethod** | **string** | A sender created value that indicates the convention used to authenticate the signer. This information is included in the Certificate of Completion. | [optional] 
**ClientUserId** | **string** | A sender created value that shows the recipient is embedded (captive).   Maximum length: 100 characters. | [optional] 
**Email** | **string** | Specifies the email of the recipient. You can use either email and userName or userId to identify the recipient. | [optional] 
**PingFrequency** | **string** | Only used if pingUrl is specified. This is the interval, in seconds, between pings on the pingUrl.  The default is 300 seconds. Valid values are 60-1200 seconds. | [optional] 
**PingUrl** | **string** | A client Url to be pinged by the DocuSign Signing experience to indicate to the client that Signing is active. An HTTP Get is executed against the client. The response from the client is ignored. The intent is for the client to reset it&#39;s session timer when the request is received. | [optional] 
**RecipientId** | **string** | Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document. | [optional] 
**ReturnUrl** | **string** | The url the recipient is redirected to after the signing session has ended. DocuSign redirects to the url and includes an event parameter that can be used by your application. Possible event parameter values:   * cancel (recipient canceled the signing operation) * decline (recipient declined to sign) * exception (an exception occurred) * fax_pending (recipient has a fax pending) * session_timeout (session timed out) * signing_complete (signer completed the signing ceremony) * ttl_expired (the TTL, time to live, timer expired) * viewing_complete (recipient completed viewing the envelope)  ###### Note: Include https:// in the URL or the redirect might not succeed on some browsers.  | [optional] 
**SecurityDomain** | **string** | The domain in which the user authenticated. | [optional] 
**UserId** | **string** | Specifies the user ID of the recipient. You can use with user ID or email and user name to identify the recipient. If user ID is used and a client user ID is provided, the value in the &#x60;userId&#x60; property must match a recipient ID (which can be retrieved with a GET recipients call) for the envelope. If a user ID is used and a clientUser ID is not provided, the user ID match the user ID of the authenticating user. | [optional] 
**UserName** | **string** | Specifies the username of the recipient. You can use either email and userName or userId to identify the recipient. | [optional] 
**XFrameOptions** | **string** |  | [optional] 
**XFrameOptionsAllowFromUrl** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

