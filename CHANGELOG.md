# DocuSign C# Client Changelog

## [v3.1.3] - eSignature API v18.3.02 - 11/29/2018
### Changed
* The SDK now supports version 18.3.02 of the DocuSign eSignature API.
* SDK Release Version updated.
* Net Framework v4.5 Dependencies upgraded to gracefully support framework v4.5 SDK dependency issues with other versions.
### Added
* Added the response.Content from server to ApiException.ErrorContent property to avoid parsing error message string. (DCM-3016)
### Fixed
* Fixed a problem with the EnvelopesApi.ListStatus and EnvelopesApi.ListStatusChanges methods that could cause them to ignore sets of envelope IDs passed in to get statuses for specific envelopes. (DCM-2748)
* Fixed a problem with the BulkEnvelopesApi.UpdateRecipients method that could cause it to return a "Value cannot be null.\r\nParameter name: stream" error rather than add bulk recipients to an envelope. (DCM-2862)
* Removed a unnecessary prefix from a line of the Usage Example. (DCM-3005)
* Fixed a dependency issue with other libraries in v4.5 framework that could cause integration problems. (DCM-2999 and DCM-2942)

## [v3.1.3-rc] - eSignature API v18.3.02 - 11/19/2018
### Changed
* The SDK now supports version 18.3.02 of the DocuSign eSignature API.
* SDK Release Version updated.
* Net Framework v4.5 Dependencies upgraded to gracefully support framework v4.5 SDK dependency issues with other versions.
### Fixed
* Fixed a problem with the EnvelopesApi.ListStatus and EnvelopesApi.ListStatusChanges methods that could cause them to ignore sets of envelope IDs passed in to get statuses for specific envelopes. (DCM-2748)
* Fixed a problem with the BulkEnvelopesApi.UpdateRecipients method that could cause it to return a "Value cannot be null.\r\nParameter name: stream" error rather than add bulk recipients to an envelope. (DCM-2862)
* Removed a unnecessary prefix from a line of the Usage Example. (DCM-3005)
* Fixed a dependency issue with other libraries in v4.5 framework that could cause integration problems. (DCM-2999 and DCM-2942)

## [v3.1.1] - eSignature API v18.3.00 - 10/15/2018
### Updated
* SDK Release Version updated.

## [v3.1.1-rc] - eSignature API v18.3.00 - 10/2/2018
### Added
* The C# .NET Standard SDK can now be implemented by projects in Mac and Linux environments. (DCM-2837)

## [v3.1.0-rc] - eSignature API v18.3.00 - 9/12/2018
### Breaking
* The AccountId() method has been removed from the SDK and replaced with by a settable AccountId property in the OAuth.UserInfo.Account object. Existing implementations that use the AccountId() method must be updated to use the AccountId property instead. Attempting to call AccountId() will result in the following error: `CS1955  Non-invocable member 'OAuth.UserInfo.Account.AccountId' cannot be used like a method.` (DCM-2636) 
### Changed
* The base path for OAuth authentication is now a property of the ApiClient object. 
* Updated the TLS logic to disable older, unsecure TLS versions. [Open Source contribution](https://github.com/docusign/docusign-csharp-client/pull/180).
* This release of the C# SDK is [Strong-Named](https://docs.microsoft.com/en-us/dotnet/framework/app-domains/strong-named-assemblies). (DCM-2784)
* Updated the format of the response returned GetUserInfo method to now contain information on the user's organization, if they are part of one. (DCM-2385)
### Added
* Added a new method, RequestJWTUserToken. This method is passed a user's client id, user id, requested scopes, and their private key in byte array format, performs JWT authentication for the specified user, and returns an access token. (DCM-2762)
* Added a new method, RequestJWTApplicationToken. This is a reserved method that is only enabled by partners and resellers, which obtains an access token that makes requests on behalf of an application rather than a user. It is passed a user's client id, requested scopes, and a private key in byte array format, then returns an access token. (DCM-2762)
* SetOauthBasePath, which can be used to set the OAuth base path for your ApiClient. (DCM-2692)
### Deprecated
* The ConfigureJwtAuthorizationFlowByKey method is now deprecated. Please use the RequestJWTUserToken method instead, which improves security by accepting the private key as a byte array or stream. (DCM-2762)
* The GetIsDefault method has been deprecated and replaced with by a settable IsDefault property in the ApiClient object. (DCM-2636)
* The GetBaseUri method has been deprecated and replaced with by a settable BaseUri property in the ApiClient object. (DCM-2636)
* The GetAccounts method has been deprecated and replaced with by a settable Accounts property in the ApiClient object. (DCM-2636)

## [v3.0.1] - eSignature API v18.1.02 - 8/16/2018
### Fixed
* Fixed a problem with multi-threaded environments that could intermittently route ConfigureJwtAuthorizationFlowByKey, GetUserInfo, and GenerateAccessToken method calls to the OAuth endpoint rather than the API endpoint. 
* Fixed a problem that would cause the ConfigureJwtAuthorizationFlowByKey, GetUserInfo, and GenerateAccessToken methods to return null when encountering errors, rather than an error code. 
### Deprecated
* The TokenResponse class has been deprecated. Please use the OAuth.OAuthToken class instead.

## [v3.0.0] - eSignature API v18.1.02 - 8/6/2018
### Added
* Added support for .Net Standard 2.0. Applications built with the DocuSign C# SDK are now compatible with .NET Core 2.0 along with .NET Framework 4.5 or later.

## [v2.2.1] - eSignature API v18.1.02 - 7/16/2018
### Fixed 
* Fixed a problem with the CreateRSAKeyFromPem method that would cause the ConfigureJwtAuthorizationFlow method to fail with a CryptographicException error when deploying to Azure Web Apps. (DCM-2363)

## [v2.2.0] - eSignature API v18.1.02 - 6/28/2018
### Added
* New SDK methods have been implemented that continue to improve the OAuth experience:
    * A new version of the `GetAuthorizationUri` method that allows you to specify the requested scopes and response type. Additionally, the new method returns the authorization URI in Uri rather than string format.
    * A new method, `GetUserInfo`, which is passed a valid access token and returns the full set of account information associated with the user specified in the access token, including the base path that a user will call into to perform API operations by an internal call to the [OAuth::userInfo API method](https://developers.docusign.com/esign-rest-api/guides/authentication/user-info-endpoints). Use the following procedure to complete the base path returned by this method, allowing you to make REST eSignature API calls.
      1. Set the base path to either [https://demo.docusign.net/restapi](https://demo.docusign.net/restapi) for a demo or developer sandbox account or [https://www.docusign.net/restapi](https://www.docusign.net/restapi) for production accounts.
      2.	Then authenticate the user and determine the base path by using the new `GetUserInfo` method.
      3.	Then reset the base path to the correct value.

    * A new method, `GenerateAccessToken`, which provides support for the Authorization Code Grant OAuth flow. It exchanges a valid authorization code for an access token (and associated information).    
    
  Note that, if the base path has not been set prior to calling any of the new SDK methods, they will default to using the demo (rather than production) environment.

### Deprecated
* Some SDK methods have been deprecated and should be replaced with calls to other, more recently implemented methods:
  * The `ConfigureJwtAuthorization` method is now deprecated and should be replaced by `ConfigureJwtAuthorizationFlowByKey`, which allows you to pass in your private key directly as a string rather than referencing a .pem file containing the key value. If you are storing the private key in a .pem file that is referenced by your solution, you must update your code to read the file's contents to a string and provide that string to the new method. For example:
    ```
       privateKey = File.ReadAllText(privateKeyFilename);
    ```
    The string passed into `ConfigureJwtAuthorizationFlowByKey` must contain the same header and footer information contained in the PEM file, including newlines, as shown below.
    ```
       -----BEGIN RSA PRIVATE KEY-----\nYOUR_PRIVATE_KEY\n-----END RSA PRIVATE KEY-----
    ```
  * The version of `GetAuthorizationUri` that returns a string has been deprecated in favor of the new implementation of the same method that returns a Uri.  
  * The `GetOAuthToken` method has been deprecated and should be replaced by `GenerateAccessToken`.

## [v2.1.10] - eSignature API v18.1.02 - 6/13/2018
### Added
* Added support for TLS 1.2, enabling your applications built with the C# SDK to be compatible with TLS 1.2 by default.
* New SDK methods have been implemented to improve OAuth support:
    * `ConfigureJwtAuthorizationFlowByKey`, which performs JWT Bearer Grant OAuth authentication using the provided values and private key. If successful, it returns an access token and the amount of time that it is valid, in seconds.
    * `GetAuthorizationUri`, a helper method which returns a authorization URI. You can redirect the user's browser to this URI to begin the OAuth Authorization Code Grant authentication flow.
    * `GenerateAccessToken`, a helper method which can exchange a previously-obtained authorization code for an access token.
    * `GetUserInfo`, a helper method which can, using a previously-obtained access token, return a set of basic user data that includes that user's base DocuSign API platform URI
    
### Changed
* Updates to the SDK are now being tracked by a change log.
* The SDK has been updated to match version 18.1.02 of the API.

### Fixed
* Fixed a bug that could cause the JWT Bearer Grant OAuth flow to break unexpectedly.
