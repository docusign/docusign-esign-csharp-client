# The Official DocuSign eSignature C# Client SDK

[![Nuget version][nuget-image]][nuget-url]
[![Nuget downloads][downloads-image]][downloads-url]
[![Build status][appveyor-image]][appveyor-url]

## Requirements
*   Microsoft .NET version 4.5.2+ (4.7 recommended)
*   Free [developer account](https://go.docusign.com/sandbox/productshot/?elqCampaignId=16531)

## Compatibility
*   .NET Standard 2.0. See [.NET Standard Selector](https://immo.landwerth.net/netstandard-versions/) for details on versioning for the individual components in .NET Standard.
*   .NET Core 2.0 or above.
*   Microsoft .NET version 4.5.2+; we no longer support [version 4.5.1](https://devblogs.microsoft.com/dotnet/support-ending-for-the-net-framework-4-4-5-and-4-5-1/).
*   TLS 1.2

## Installation
This SDK is provided as open source, which enables you to customize its functionality to suit your particular use case. To do so, download or clone the repository. If the SDK’s given functionality meets your integration needs, or if you’re working through our [code examples](https://developers.docusign.com/docs/esign-rest-api/how-to/) from the [DocuSign Developer Center](https://developers.docusign.com/), you merely need to install it by following the instructions below.

### NuGet Package Manager:
1. Create a new C# project, or open an existing one.
2. Select **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution.**
3. Search for DocuSign.
4. Select **DocuSign.eSign.dll.**
5. Select the check box next to your project name.
6. Click **Install.**

### Package Manager Console:
1. Create a new C# project, or open an existing one.
2. Open the Package Manager Console by either method:
    1. Select **Package Manager Console** along the bottom of Visual Studio
    2. Select **Tools** > **NuGet Package Manager** > **Package Manager Console**
3. In the Package Manager Console, type: **Install-Package DocuSign.eSign.dll**

## Dependencies
This client has the following external dependencies:

**.NET Standard v2 and .NET Core:**
*   Microsoft.CSharp v4.5.0
*   Microsoft.IdentityModel.Protocols v5.4.0
*   Newtonsoft.Json 13.0.1
*   Portable.BouncyCastle v1.8.10
*   RestSharp v106.3.1
*   System.ComponentModel.Annotations v4.5.0
*   System.IdentityModel.tokens.Jwt v5.4.0

**.NET Framework, version 4.5.2:**
*   BouncyCastle v1.8.9
*   Microsoft.CSharp v4.5.0
*   Microsoft.IdentityModel.Protocols v5.4.0
*   Newtonsoft.Json 13.0.1
*   RestSharp v106.3.1
*   System.ComponentModel.Annotations v4.5.0
*   System.IdentityModel.tokens.Jwt v5.4.0

## Code examples
You can find on our GitHub a self-executing package of code examples for the eSignature C# SDK, called a [Launcher](https://github.com/docusign/code-examples-csharp/blob/master/README.md), that demonstrates common use cases. You can also download a version preconfigured for your DocuSign developer account from [Quickstart](https://developers.docusign.com/docs/esign-rest-api/quickstart/). These examples can use either the [Authorization Code Grant](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-code-grant) or [JSON Web Token (JWT)](https://developers.docusign.com/esign-rest-api/guides/authentication/oauth2-jsonwebtoken) authentication workflow.

## OAuth implementations
For details regarding which type of OAuth grant will work best for your DocuSign integration, see [Choose OAuth Type](https://developers.docusign.com/platform/auth/choose/) in the [DocuSign Developer Center](https://developers.docusign.com/).

For security purposes, DocuSign recommends using the [Authorization Code Grant](https://developers.docusign.com/platform/auth/authcode/) flow.

## Support
Log issues against this client through GitHub. We also have an [active developer community on Stack Overflow](https://stackoverflow.com/questions/tagged/docusignapi).

## License
The DocuSign eSignature C# Client SDK is licensed under the [MIT License](https://github.com/docusign/docusign-csharp-client/blob/master/LICENSE).

## Additional resources
*   [DocuSign Developer Center](https://developers.docusign.com/)
*   [DocuSign API on Twitter](https://twitter.com/docusignapi)
*   [DocuSign For Developers on LinkedIn](https://www.linkedin.com/showcase/docusign-for-developers/)
*   [DocuSign For Developers on YouTube](https://www.youtube.com/channel/UCJSJ2kMs_qeQotmw4-lX2NQ)

[nuget-image]: https://img.shields.io/nuget/v/DocuSign.eSign.dll.svg?style=flat
[nuget-url]: https://www.nuget.org/packages/DocuSign.eSign.dll
[downloads-image]: https://img.shields.io/nuget/dt/DocuSign.eSign.dll.svg?style=flat
[downloads-url]: https://www.nuget.org/packages/DocuSign.eSign.dll
[appveyor-image]:https://ci.appveyor.com/api/projects/status/m5a02n1vp3ma6qec?svg=true
[appveyor-url]:https://ci.appveyor.com/project/DocuSign/docusign-csharp-client