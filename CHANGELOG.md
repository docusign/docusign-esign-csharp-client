# DocuSign C# Client Changelog

## [v2.2.0] - 6/28/2018
### Added
* New SDK methods have been implemented that continue to impove the OAuth experience:
    * A new version of the GetAuthorizationUri method that returns the authorization URI in Uri rather than string format.
    * A new method, GetUserInfo, which is passed a valid access token and returns the full base path that a user will call into to perform API operations.
    * A new method, GenerateAccessToken, which provides support for the Authorization Code Grant OAuth flow. It exchanges a valid authorization code for an access token (and associated information).    
    
  Note that, if the base path has not been set prior to calling any of the new SDK methods, they will default to using the demo (rather than production) environment.

### Changed
* Some SDK methods have been deprecated and should be replaced with calls to other, more recently implemented methods:
  * The ConfigureJwtAuthorization method is now deprecated and should be replaced by ConfigureJwtAuthorizationFlowByKey, which allows you to pass in your private key directly as a string rather than referencing a .pem file containing the key value. If your are storing the private key in a .pem file that is referenced by your solution, you must update your code to read the file's contents to a string and provide that string to the new method.
    ```
       privateKey = File.ReadAllText(privateKeyFilename);
    ```
    The string passed into ConfigureJwtAuthorizationFlowByKey must contain the same header and footer information contained in the PEM file, including newlines.
    ```
       -----BEGIN RSA PRIVATE KEY-----\nYOUR_PRIVATE_KEY\n-----END RSA PRIVATE KEY-----
    ```
  * The version of **GetAuthorizationUri** that returns a string has been deprecated in favor of the new implementation of the same method that returns a Uri.  
  * The GetOAuthToken method has been deprecated and should be replaced by GenerateAccessToken.

## [v2.1.10] - 6/13/2018
### Added
* New SDK methods have been implemented to improve OAuth support:
    * ConfigureJwtAuthorizationFlowByKey, which performs JWT Bearer Grant OAuth authentication using the provided values and private key. If successful, it returns an access token and the DateTime when it expires.
    * GetAuthorizationUri, a helper method which returns the URI for a client to navigate to in order begin the OAuth authentication process.
    * GenerateAccessToken, a helper method which can exchange a previously-obtained authorization code for an access token.
    * GetUserInfo, a helper method which can, using a previously-obtained access token, return a set of basic user data that includes that user's base DocuSign API platform URI
    
### Changed
* Updates to the SDK are now being tracked by a change log.
* The SDK has been updated to match version 18.1.02 of the API.

### Fixed
* Fixed a bug that could cause the JWT Bearer Grant OAuth flow to break unexpectedly.
