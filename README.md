# The Official DocuSign C# Client

[![Nuget version][nuget-image]][nuget-url]
[![Nuget downloads][downloads-image]][downloads-url]
[![Build status][appveyor-image]][appveyor-url]

## Requirements

- Microsoft .NET version 4.5.2+ (4.7 recommended)
- Free [Developer Sandbox](https://go.docusign.com/sandbox/productshot/?elqCampaignId=16531)

## Compatibility

- .NET Standard 2.0. See [.NET Standard Selector](https://immo.landwerth.net/netstandard-versions/) for details on versioning for the individual components in .NET Standard
- .NET Core 2.0
- Microsoft .NET version 4.5.2+ We no longer support [version 4.5.1](https://devblogs.microsoft.com/dotnet/support-ending-for-the-net-framework-4-4-5-and-4-5-1/)
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
- Microsoft.IdentityModel.Protocols v5.4.0
- Newtonsoft.Json 11.0.2
- Portable.BouncyCastle v1.8.2
- RestSharp v106.3.1
- System.ComponentModel.Annotations v4.5.0
- System.IdentityModel.tokens.Jwt v5.4.0


### .NET Framework, version 4.5.2:

- BouncyCastle v1.8.1
- Microsoft.CSharp v4.5.0
- Microsoft.IdentityModel.Protocols v5.4.0
- Newtonsoft.Json 11.0.2
- RestSharp v106.3.1
- System.ComponentModel.Annotations v4.5.0
- System.IdentityModel.tokens.Jwt v5.4.0


## Code Examples

### Launchers

DocuSign provides a sample application code referred to as a [Launcher](https://github.com/docusign/code-examples-csharp). The Launcher contains a set of 31 common use cases and associated source files. These examples use either DocuSign&#39;s [Authorization Code Grant](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-code-grant) or [JSON Web Tokens (JWT)](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-jsonwebtoken) flows.

### Proof-of-concept applications

If your goal is to create a proof-of-concept application, DocuSign provides a set of [Quick Start](https://developers.docusign.com/esign-rest-api/code-examples/quickstart-overview) examples. The Quick Startexamples are meant to be used with DocuSign&#39;s [OAuth Token Generator](https://developers.docusign.com/oauth-token-generator), which will allow you to generate tokens for the Demo/Sandbox environment only. These tokens last for eight hours and will enable you to build your proof-of-concept application without the need to fully implement an OAuth solution.

## OAuth Implementations

For details regarding which type of OAuth grant will work best for your DocuSign integration, see the [REST API Authentication Overview](https://developers.docusign.com/esign-rest-api/guides/authentication) guide located on the [DocuSign Developer Center](https://developers.docusign.com/).

For security purposes, DocuSign recommends using the [Authorization Code Grant](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-code-grant) flow.


## Support

Log issues against this client through GitHub. We also have an [active developer community on Stack Overflow](https://stackoverflow.com/questions/tagged/docusignapi).

## License

The DocuSign C# Client is licensed under the [MIT License](https://github.com/docusign/docusign-csharp-client/blob/master/LICENSE).


[nuget-image]: https://img.shields.io/nuget/v/DocuSign.eSign.dll.svg?style=flat
[nuget-url]: https://www.nuget.org/packages/DocuSign.eSign.dll
[downloads-image]: https://img.shields.io/nuget/dt/DocuSign.eSign.dll.svg?style=flat
[downloads-url]: https://www.nuget.org/packages/DocuSign.eSign.dll
[appveyor-image]:https://ci.appveyor.com/api/projects/status/m5a02n1vp3ma6qec?svg=true
[appveyor-url]:https://ci.appveyor.com/project/DocuSign/docusign-csharp-client

### Additional Resources
* [DocuSign Developer Center](https://developers.docusign.com)
* [DocuSign API on Twitter](https://twitter.com/docusignapi)
* [DocuSign For Developers on LinkedIn](https://www.linkedin.com/showcase/docusign-for-developers/)
* [DocuSign For Developers on YouTube](https://www.youtube.com/channel/UCJSJ2kMs_qeQotmw4-lX2NQ)



