# The Official DocuSign C# Client

[![Nuget version][nuget-image]][nuget-url]
[![Nuget downloads][downloads-image]][downloads-url]
[![Build status][appveyor-image]][appveyor-url]

## Requirements

- Microsoft .NET version 4.5+ (4.6.1 recommended)
- Free [Developer Sandbox](https://go.docusign.com/sandbox/productshot/?elqCampaignId=16531)

## Compatibility

- .NET Standard 2.0. See [.NET Standard Selector](https://immo.landwerth.net/netstandard-versions/) for details on versioning for the individual components in .NET Standard
- .NET Core 2.0
- Microsoft .NET version 4.5+
- TLS 1.2

## Note

This open-source SDK is provided for cases where you would like to make additional changes that the SDK does not provide out-of-the-box. If you simply want to use the SDK with any of the examples shown in the [Developer Center](https://developers.docusign.com/esign-rest-api/code-examples), follow the installation instructions below.

## Installation

### NuGet Package Manager:

1. Create a new C# project, or open an existing one.
2. Click **Tools** -&gt; **NuGet Package Manager** -&gt; **Manage NuGet Packages for Solution**.
3. Search for **DocuSign**.
4. Select **DocuSign.eSign.dll**.
5. Click the check box next to your project name.
6. Click **Install**.

### Package Manager Console:

1. Open or create a new C# project.
2. Open the **Package Manager Console** by either:
  1. Clicking **Package Manager Console** along the bottom of Visual Studio
  2. Clicking **Tools** -&gt; **NuGet Package Manager** -&gt; **Package Manager Console**
3. In the **Package Manager Console**, type: **Install-Package DocuSign.eSign.dll**

## Dependencies

This client has the following external dependencies:

### .NET Standard v2 and .NET Core:

- Microsoft.CSharp v4.5.0
- Microsoft.IdentityModel.Protocols v5.2.2
- Newtonsoft.Json 11.0.2
- Portable.BouncyCastle v1.8.2
- RestSharp v106.3.1
- System.ComponentModel.Annotations v4.5.0
- System.IdentityModel.tokens.Jwt v5.2.2


### .NET Framework, version 4.5:

- BouncyCastle v1.8.1
- Microsoft.Identity.Model.Logging v1.1.4
- Microsoft.IdentityModel.Tokens v5.1.14
- Newtonsoft.Json v10.0.0.1
- RestSharpSigned v105.2.3
- System.IdentityModel.Tokens.Jwt v5.1.4


## Code Examples

### Launchers

DocuSign provides a sample application referred to as a [Launcher](https://github.com/docusign/eg-03-csharp-auth-code-grant-core). The Launcher contains a set of 14 common use cases and associated source files. These examples use DocuSign&#39;s [Authorization Code Grant](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-code-grant) flow.

### Proof-of-concept applications

If your goal is to create a proof-of-concept application, DocuSign provides a set of [Quick Start](https://developers.docusign.com/esign-rest-api/code-examples/quickstart-overview) examples. The Quick Startexamples are meant to be used with DocuSign&#39;s [OAuth Token Generator](https://developers.docusign.com/oauth-token-generator), which will allow you to generate tokens for the Demo/Sandbox environment only. These tokens last for eight hours and will enable you to build your proof-of-concept application without the need to fully implement an OAuth solution.

## OAuth Implementations

For details regarding which type of OAuth grant will work best for your DocuSign integration, see the [REST API Authentication Overview](https://developers.docusign.com/esign-rest-api/guides/authentication) guide located on the [DocuSign Developer Center](https://developers.docusign.com/).

For security purposes, DocuSign recommends using the [Authorization Code Grant](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-code-grant) flow.

There are other use-case scenarios, such as  **single-page applications** (SPA) that use  **Cross-Origin Resource Sharing** (CORS), or where there may not be a user to interact with your Service Account. For these use cases, DocuSign also supports [JWT](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-jsonwebtoken) and [Implicit](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-implicit) grants. For Code Examples, see the links below:

- [JWT (JSON Web Token)](https://github.com/docusign/eg-01-csharp-jwt-core)
- Implicit Grant (coming soon)

## Support

Log issues against this client through GitHub. We also have an [active developer community on Stack Overflow](https://stackoverflow.com/questions/tagged/docusignapi).

## License

The DocuSign C# Client is licensed under the [MIT License](https://github.com/docusign/docusign-csharp-client/blob/master/LICENSE).


[nuget-image]: https://img.shields.io/nuget/v/DocuSign.eSign.dll.svg?style=flat
[nuget-url]: https://www.nuget.org/packages/DocuSign.eSign.dll
[downloads-image]: https://img.shields.io/nuget/dt/DocuSign.eSign.dll.svg?style=flat
[downloads-url]: https://www.nuget.org/packages/DocuSign.eSign.dll
[appveyor-image]:https://ci.appveyor.com/api/projects/status/m5a02n1vp3ma6qec?svg=true
[appveyor-url]:https://ci.appveyor.com/project/RajRele/docusign-csharp-client
