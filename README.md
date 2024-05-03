# The Official Docusign eSignature C# Client SDK

[![Nuget version][nuget-image]][nuget-url]
[![Nuget downloads][downloads-image]][downloads-url]

The Docusign REST API makes integrating Docusign into your apps and websites a super fast and painless process.

## Version Information
- **API version**: v2.1
- **Latest SDK version (Including prerelease)**: 7.0.0-rc2

## Requirements
*   Microsoft .NET version 4.6.2+ (4.7 recommended)
*   Free [developer account](https://go.docusign.com/o/sandbox/?postActivateUrl=https://developers.docusign.com/)

## Compatibility
*   .NET Standard 2.0. See [.NET Standard Selector](https://immo.landwerth.net/netstandard-versions/) for details on versioning for the individual components in .NET Standard.
*   .NET Core 2.0 or above.
*   Microsoft .NET version 4.6.2+.
*   TLS 1.2

## Installation
This SDK is provided as open source, which enables you to customize its functionality to suit your particular use case. To do so, download or clone the repository. If the SDK’s given functionality meets your integration needs, or if you’re working through our [code examples](https://developers.docusign.com/docs/esign-rest-api/how-to/) from the [Docusign Developer Center](https://developers.docusign.com/), you merely need to install it by following the instructions below.

### NuGet Package Manager:
1. Create a new C# project, or open an existing one.
2. Select **Tools** -> **NuGet Package Manager** -> **Manage NuGet Packages for Solution.**
3. Search for **DocuSign**.
4. Select **DocuSign.eSign.dll**.
5. Select the check box next to your project name.
6. Click **Install.**

### Package Manager Console:
1. Create a new C# project, or open an existing one.
2. Open the **Package Manager Console** by either method:
   1. Clicking **Package Manager Console** along the bottom of Visual Studio
   2. Clicking **Tools** -> **NuGet Package Manager** -> **Package Manager Console**
3. In the **Package Manager Console**, type: **Install-Package DocuSign.eSign.dll**

## Dependencies
This client has the following external dependencies:

### .NET Standard v2 and .NET Core:
*   Newtonsoft.Json v13.0.3
*   BouncyCastle.Cryptography v2.3.0
*   System.ComponentModel.Annotations v5.0.0
*   Microsoft.IdentityModel.JsonWebTokens v7.5.1

### .NET Framework, version 4.6.2:
*   Newtonsoft.Json v13.0.3
*   BouncyCastle.Cryptography v2.3.0
*   System.ComponentModel.Annotations v5.0.0
*   Microsoft.IdentityModel.JsonWebTokens v7.5.1

## Code examples
Explore our GitHub repository for the [Launcher](https://github.com/docusign/code-examples-csharp/), a self-executing package housing code examples for the eSignature C# SDK. This package showcases several common use cases and their respective source files. Additionally, you can download a version preconfigured for your Docusign developer account from [Quickstart](https://developers.docusign.com/docs/esign-rest-api/quickstart/). These examples support both the [Authorization Code Grant](https://developers.docusign.com/platform/auth/authcode/) and [JSON Web Token (JWT)](https://developers.docusign.com/platform/auth/jwt/) authentication workflows.

## OAuth implementations
For details regarding which type of OAuth grant will work best for your Docusign integration, see [Choose OAuth Type](https://developers.docusign.com/platform/auth/choose/) in the [Docusign Developer Center](https://developers.docusign.com/).

For security purposes, Docusign recommends using the [Authorization Code Grant](https://developers.docusign.com/platform/auth/authcode/) flow.

## Support
Log issues against this client through GitHub. We also have an [active developer community on Stack Overflow](https://stackoverflow.com/questions/tagged/docusignapi).

## License
The Docusign eSignature C# Client SDK is licensed under the [MIT License](https://github.com/docusign/docusign-esign-csharp-client/blob/master/LICENSE).

## Additional resources
*   [Docusign Developer Center](https://developers.docusign.com/)
*   [Docusign API on Twitter](https://twitter.com/docusignapi)
*   [Docusign For Developers on LinkedIn](https://www.linkedin.com/showcase/docusign-for-developers/)
*   [Docusign For Developers on YouTube](https://www.youtube.com/channel/UCJSJ2kMs_qeQotmw4-lX2NQ)

[nuget-image]: https://img.shields.io/nuget/v/DocuSign.eSign.dll.svg?style=flat
[nuget-url]: https://www.nuget.org/packages/DocuSign.eSign.dll
[downloads-image]: https://img.shields.io/nuget/dt/DocuSign.eSign.dll.svg?style=flat
[downloads-url]: https://www.nuget.org/packages/DocuSign.eSign.dll
