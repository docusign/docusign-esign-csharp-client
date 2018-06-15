# DocuSign C# Client Changelog

## 18.1.02 (6/13/2018)
* Updates to the SDK are now being tracked by a change log.
* The SDK has been updated to match version 18.1.02 of the API.
* Fixed a bug that could cause the JWT Bearer Grant OAuth flow to break unexpectedly.
* New SDK methods have been implemented to improve OAuth support:
    * ConfigureJwtAuthorizationFlowByKey, which performs JWT Bearer Grant OAuth authentication using the provided values and private key. If successful, it returns an access token and the DateTime when it expires.
    * GetAuthorizationUri, a helper method which returns the URI for a client to navigate to in order begin the OAuth authentication process.
    * GenerateAccessToken, a helper method which can exchange a previously-obtained authorization code for an access token.
    * GetUserInfo, a helper method which can, using a previously-obtained access token, return a set of basic user data that includes that user's base DocuSign API platform URI.