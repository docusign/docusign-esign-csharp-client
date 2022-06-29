# DocuSign C# Client Changelog

## [v6.0.0-rc] - eSignature API v2.1-22.2.00.00 - 2022-06-23
### Changed
- Removed external reference to RestSharp
- Added support for version v2.1-22.2.00.00 of the DocuSign ESignature API.
- Updated the SDK release version.

### Breaking
- ApiClient in Api/*Api.cs files is now a DocuSignClient, so functionality based on direct access to attributes of previous RestSharp-based client will not work anymore.
- Following Api classes removed:
  - DataFeedApi.cs
  - SignatureApi.cs

## [v5.12.0] - eSignature API v2.1-22.2.00.00 - 2022-06-17
### Changed
- Added support for version v2.1-22.2.00.00 of the DocuSign ESignature API.
- Updated the SDK release version.

## [v5.11.0] - eSignature API v2.1-22.1.02.00 - 2022-05-18
### Changed
- Added support for version v2.1-22.1.02.00 of the DocuSign ESignature API.
- Updated the SDK release version.

## [v5.10.0] - eSignature API v2.1-22.1.01.00 - 2022-04-07
### Changed
- Added support for version v2.1-22.1.01.00 of the DocuSign ESignature API.
- Updated the SDK release version.

### Breaking
- Following models are renamed

    - `ScheduledSendingApiModel` is renamed to `ScheduledSending`
    - `DelayedRoutingApiModel` is renamed to `DelayedRouting`

## [v5.9.0] - eSignature API v2.1-21.4.02.00 - 2022-02-08
### Changed
- Added support for version v2.1-21.4.02.00 of the DocuSign ESignature API.
- Updated the SDK release version.

## [v5.9.0-rc] - eSignature API v2.1-21.4.01.00 - 2022-01-06
### Changed
- Added support for version v2.1-21.4.01.00 of the DocuSign ESignature API.
- Updated the SDK release version.

## [5.8.0] - ESignature API v2.1-21.4.00.00 - 2021-12-13
### Changed
- Added support for version v2.1-21.4.00.00 of the DocuSign ESignature API.
- Updated the SDK release version.


## [5.8.0-rc] - ESignature API v2.1-21.3.00.00 - 2021-09-23
### Changed
- Added support for version v2.1-21.3.00.00 of the DocuSign ESignature API.
- Updated the SDK release version.
### Fixed
- Fixed file upload ability to AccountBrands::updateResource (DCM-3867).


## [v5.7.0] - ESignature API v2.1-21.2.02.00 - 09/02/2021
### Changed
- Added support for version v2.1-21.2.02.00 of the DocuSign ESignature API.
- Updated the SDK release version.


## [v5.6.2] - eSignature API v2.1-21.2.00.00 - 07/21/2021
### Changed
- Updated Bouncy Castle version to latest stable (DCM-6142).
- Removed an obsolete `Parameter` class from ApiClient.
- Updated the SDK release version.

## [v5.6.1] - eSignature API v2.1-21.2.00.00 - 07/18/2021
### Changed
- Updated RestSharp version to latest stable (DCM-6070).
- Updated the SDK release version.

## [v5.6.0] - eSignature API v2.1-21.2.00.00 - 07/15/2021
### Changed
- Added support for version v2.1-21.2.00.00 of the DocuSign eSignature API.
- Updated the SDK release version.

## [v5.6.0-rc] - eSignature API v2.1-21.2.00.00 - 07/12/2021
### Changed
- Added support for version v2.1-21.2.00.00 of the DocuSign eSignature API.
- Updated the SDK release version.

## [v5.5.1-rc] - eSignature API v2.1-21.1.02.00 - 06/15/2021
### Added
- Added support for API exceptions to pass along API response headers information from DocuSign (DCM-4453).
### Changed
- Updated the SDK release version.
 
## [v5.5.0] - eSignature API v2.1-21.1.02.00 - 06/07/2021
### Breaking
- Removed methods `GetAccountSettingsExport`,`GetSealProviders` from Accounts.
- Removed methods `CreateConnectSecret`,`DeleteConnectSecret`,`GenerateConnectSecret`,`GetConnectSecrets` from Connect.
- Removed methods `GetDynamicSystemSettings`,`GetTemplateInfo`,`GetApplianceInfo`,`GetAccount`,`GetCustomFields`,`GeleteCustomFieldsV2`,`GetDocumentPages`,`GetImage`,`GetLocalePolicy`,`UpdatePageInfo`,`CreatePageInfo`,`DeletePageInfo`,`UpdatePdf`,`GetPdf`,`GetPdfBlob`,`UpdatePdfBlob`,`CreatePdfBlob`,`UpdateRecipientDeniedDocumentCopy`,`DeleteRecipientDeniedDocumentCopy`,`GetSignerAttachment`,`DeleteSignerAttachment`, from Envelopes.
- Removed methods `CompleteSignHash`,`GetUserInfo`,`HealthCheck`,`SignHashSessionInfo`,`UpdateTransaction` from TrustServiceProviders.
- Removed methods `GetUserListExport` from Users.
### Added
- Added new methods `GetBulkSendBatchEnvelopes` to BulkEnvelopes.
### Changed
- Added support for version v2.1-21.1.02.00 of the DocuSign eSignature API.
- Updated the SDK release version.
 
## [v5.5.0-rc] - eSignature API v2.1-21.1.02.00 - 05/20/2021
### Breaking
- Removed methods `GetAccountSettingsExport`,`GetSealProviders` from Accounts.
- Removed methods `CreateConnectSecret`,`DeleteConnectSecret`,`GenerateConnectSecret`,`GetConnectSecrets` from Connect.
- Removed methods `GetDynamicSystemSettings`,`GetTemplateInfo`,`GetApplianceInfo`,`GetAccount`,`GetCustomFields`,`GeleteCustomFieldsV2`,`GetDocumentPages`,`GetImage`,`GetLocalePolicy`,`UpdatePageInfo`,`CreatePageInfo`,`DeletePageInfo`,`UpdatePdf`,`GetPdf`,`GetPdfBlob`,`UpdatePdfBlob`,`CreatePdfBlob`,`UpdateRecipientDeniedDocumentCopy`,`DeleteRecipientDeniedDocumentCopy`,`GetSignerAttachment`,`DeleteSignerAttachment`, from Envelopes.
- Removed methods `CompleteSignHash`,`GetUserInfo`,`HealthCheck`,`SignHashSessionInfo`,`UpdateTransaction` from TrustServiceProviders.
- Removed methods `GetUserListExport` from Users.
### Added
- Added new methods `GetBulkSendBatchEnvelopes` to BulkEnvelopes.
### Changed
- Added support for version v2.1-21.1.02.00 of the DocuSign eSignature API.
- Updated the SDK release version.

## [v5.4.1] - eSignature API v2.1-21.1.01.03 - 05/19/2021
### Changed
- Updated the SDK release version to fix C# SDK Nuget 5.4.0 does not work with .NET Framework 4.8. (DCM-5727) 

## [v5.4.0] - eSignature API v2.1-21.1.01.03 - 04/26/2021
### Added
- Added new methods `DeleteCustomFieldsV2`, `DeletePageInfoV2`, `GetApplianceEnvelopeInfo`, `GetTemplateInfo` to envelopes.
- Added new method `DeleteConnectSecret` to connect.
### Changed
- Added support for version v2.1-21.1.01.03 of the DocuSign eSignature API.
- Updated the SDK release version.

## [v5.4.0-rc] - eSignature API v2.1-21.1.01 - 04/15/2021
### Changed
*   Added support for version v2.1-21.1.01 of the DocuSign eSignature API.
*   Updated the SDK release version

## [v5.3.1-rc] - eSignature API v2.1-20.4.01 - 01/20/2021
### Changed
*   Added support for version v2.1-20.4.01 of the DocuSign eSignature API.
*   Updated the SDK release version
### BREAKING
*	Deprecated update and delete recipients methods in BulkEnvelopesApi.

## [v5.3.0-rc] - eSignature API v2.1-20.4.00.01 - 12/28/2020
### Changed
*   Added support for version v2.1-20.4.00.01 of the DocuSign eSignature API.
*   Updated the SDK release version
### Fixed
- Expected field name in BrandsResponse model is `brandOptions` instead of `brands`. (DCM-4463)

## [v5.2.0] - eSignature API v2.1-20.3.01 - 10/29/2020
### Changed
*   Added support for version v2.1-20.3.01 of the DocuSign eSignature API.
*   Updated the SDK release version

## [v5.2.0-rc] - eSignature API v2.1-20.3.01 - 10/15/2020
### Changed
*   Added support for version v2.1-20.3.01 of the DocuSign eSignature API.
*   Updated the SDK release version

## [v5.1.0] - eSignature API v2.1-20.3.00 - 10/01/2020
### Changed
*   Added support for version v2.1-20.3.00 of the DocuSign eSignature API.
*   Updated the SDK release version
### Fixed
*	A bug with ApiClient SetBasePath which did not update basePath for RestClient (DCM-4276).

## [v5.1.0-rc] - eSignature API v2.1-20.3.00 - 09/24/2020
### Changed
*   Added support for version v2.1-20.3.00 of the DocuSign eSignature API.
*   Updated the SDK release version
### Fixed
*	A bug with ApiClient SetBasePath which did not update basePath for RestClient (DCM-4276).

## [v5.0.0] - eSignature API v2.1-20.2.02.02 - 08/24/2020
### BREAKING
*	Major design changes, resolved an issue with ApiClient and Configuration circular reference (DCM-3979). The initialization of any api object now requires ApiClient passed as a parameter as a parameter.
### Changed
*   Added support for version v2.1-20.2.02.02 of the DocuSign eSignature API.
*   Updated the SDK release version

## [v5.0.0-rc] - eSignature API v2.1-20.2.02.02 - 08/07/2020
### BREAKING
*	Major design changes, resolved an issue with ApiClient and Configuration circular reference (DCM-3979). The initialization of any api object now requires ApiClient passed as a parameter as a parameter.
### Changed
*   Added support for version v2.1-20.2.02.02 of the DocuSign eSignature API.
*   Updated the SDK release version

## [v4.5.2] - eSignature API v2.1-20.2.00 - 07/09/2020
### Changed
*   Added support for version v2.1-20.2.00 of the DocuSign eSignature API.
*   Updated the SDK release version
### Added
- Added properties for Bulk Update call

## [v4.4.1] - eSignature API v2.1-20.1.02 - 05/29/2020
### Changed
*   Added support for version v2.1-20.1.02 of the DocuSign eSignature API.
*   Updated the SDK release version
### Added
*   Made InterceptRequest and InterceptResponse methods overriable (DCM-4242)


## [v4.4.0-rc] - eSignature API v2.1-20.1.02 - 05/14/2020
### Changed
*   Added support for version v2.1-20.1.02 of the DocuSign eSignature API.
*   Updated the SDK release version

## [v4.3.0] - eSignature API v2.1 - 03/31/2020
### Changed
*   Added support for version v2.1-20.1.00 of the DocuSign eSignature API.
*   Updated the SDK release version.

### Added
*   Added the new property `CopyRecipientData` to envelopes. When set to **true**, the information that recipients enter is retained when you clone an envelope. For example, if you resend an envelope that was declined or voided after one or more recipients entered data, that data is retained. Note that this functionality must be enabled for the account.
*   Added `RecipientIdentityInputOption` and `InputOptions` to `RecipientIdentityVerification`: Reserved for DocuSign.

### Deleted
*   Deleted the GET methods for account seals providers, which returned the seals for an account.

## [v4.3.0-rc] - eSignature API v2.1 - 03/13/2020
### Changed
* The SDK now supports API v2.1-20.1.00 of the DocuSign eSignature API.
* SDK Release Version updated.

## [v4.2.0] - eSignature API v2.1 - 02/07/2020
### Changed
* The SDK now supports API v2.1-19.4.01 of the DocuSign eSignature API.
* SDK Release Version updated.

## [v4.2.0-rc] - eSignature API v2.1 - 01/03/2020
### Changed
* The SDK now supports API v2.1-19.4.01 of the DocuSign eSignature API.
* SDK Release Version updated.

## [v4.1.1] - eSignature API v2.1 - 10/08/2019
### Added
* Added support for WebProxy, integrations can now initialize the ApiClient by providing their proxy details. (DCM-3321)
### Changed
* SDK Release Version updated.

## [v4.1.1-rc] - eSignature API v2.1 - 09/23/2019
### Added
* Added support for WebProxy, integrations can now initialize the ApiClient by providing their proxy details. (DCM-3321)
### Changed
* SDK Release Version updated.

## [v4.1.0] - eSignature API v2.1 - 09/18/2019
### BREAKING
* .Net Framework minimum version updated to v4.5.2
### Changed
* Upgraded the dependencies related to the .net framework v4.5.2
* SDK Release Version updated.

## [v4.1.0-rc] - eSignature API v2.1 - 08/21/2019
### BREAKING
* .Net Framework minimum version updated to v4.5.2
### Changed
* Upgraded the dependencies related to the .net framework v4.5.2
* SDK Release Version updated.

## [v4.0.4] - eSignature API v2.1 - 08/21/2019
### Changed
* The SDK now supports API v2.1-19.2.02 of the DocuSign eSignature API.
* SDK Release Version updated.
### Fixed
* A bug with DocuSign .Net Core SDK which threw an error in a Linux based Docker container (DCM-3073)
* Documentation with 'expiresInHours' parameter fixed (DCM-3319)
* Updated the request claims added when we create the JWT Token by adding 'iat' suppressing the default time added on 'nbf' claim (DCM-3232)

## [v4.0.3-rc] - eSignature API v2.1 - 08/16/2019
### Fixed
* A bug with DocuSign .Net Core SDK which threw an error in a Linux based Docker container (DCM-3073)
* Documentation with 'expiresInHours' parameter fixed (DCM-3319)
* Updated the request claims added when we create the JWT Token by adding 'iat' suppressing the default time added on 'nbf' claim (DCM-3232)
### Changed
* SDK Release Version updated.

## [v4.0.1-rc] - eSignature API v2.1 - 08/08/2019
### Fixed
* A bug with DocuSign .Net Core SDK which threw an error in a Linux based Docker container (DCM-3073)
### Changed
* SDK Release Version updated.

## [v4.0.0] - eSignature API v2.1 - 07/12/2019
### BREAKING
* The SDK now supports API v2.1-19.1.02 of the DocuSign eSignature API.
* SDK Release Version updated.

## [v4.0.0-rc] - eSignature API v2.1 - 06/07/2019
### BREAKING
* The SDK now supports API v2.1-19.1.02 of the DocuSign eSignature API.
* SDK Release Version updated.

## [v3.1.5] - eSignature API v19.1.02 - 05/20/2019
### Changed
* The SDK now supports version 19.1.02 of the DocuSign eSignature API.
* SDK Release Version updated.
### Added
* Added new Cache-Control and Pragma headers to OAuth server request calls. (DCM-2243)
* Added a new *TabGroupLabels* field to all Tabs models
* Added a new *Witnesses* field to all Recipients models
* Implemented models for Smart Sections feature
* Implemented initial support of HMAC for DocuSign Connect
### Fixed
* A bug with that could cause the *MoveEnvelopes* method call to return a response without a *Content-Type* header. (DCM-3084)

## [v3.1.5-rc] - eSignature API v19.1.02 - 05/01/2019
### Changed
* The SDK now supports version 19.1.02 of the DocuSign eSignature API.
* SDK Release Version updated.
### Added
* Added new Cache-Control and Pragma headers to OAuth server request calls. (DCM-2243)
* Added a new *TabGroupLabels* field to all Tabs models
* Added a new *Witnesses* field to all Recipients models
* Implemented models for Smart Sections feature
* Implemented initial support of HMAC for DocuSign Connect
### Fixed
* A bug with that could cause the *MoveEnvelopes* method call to return a response without a *Content-Type* header. (DCM-3084)


## [v3.1.4] - eSignature API v18.4.02 - 02/25/2019
### Changed
* The SDK now supports version 18.4.02 of the DocuSign eSignature API.
* SDK Release Version updated.
### Fixed
* Fixed a problem with the  AccountsApi.UpdateBrandLogoByType method that prevented it from uploading brand logos.

## [v3.1.4-rc] - eSignature API v18.4.02 - 02/15/2019
### Changed
* The SDK now supports version 18.4.02 of the DocuSign eSignature API.
* SDK Release Version updated.
### Fixed
* Fixed a problem with the  AccountsApi.UpdateBrandLogoByType method that prevented it from uploading brand logos.

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
### BREAKING
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
