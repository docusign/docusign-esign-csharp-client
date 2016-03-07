# DocuSign C# Client

You can sign up for a free [developer sandbox](https://www.docusign.com/developer-center).

Requirements
============

Microsoft .NET version 4.5 or later.

Installation
============

### NuGet Package Manager

To add to a new or existing Visual Studio project:  

	1. Open project and go to Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution.
	2. Search for "DocuSign", select the DocuSign.eSign package, and click Install.  

### Manual Install 

Copy `DocuSign.eSign.dll` file to your local machine and add reference through your project settings.

### Others

Alternatively you can just copy the source code directly into your project. 

#### Dependencies

This client has the following external dependencies: 

* Newtonsoft.Json.dll
* RestSharp.dll

Usage
=====

To initialize the client and make the Login API Call:

```csharp
	using DocuSign.eSign.Api;
	using DocuSign.eSign.Model;
	using DocuSign.eSign.Client;

	namespace DocuSignSample
	{
		class Program
		{
			static void Main(string[] args)
			{
				string username = "[EMAIL]";
				string password = "[PASSWORD]";
				string integratorKey = "[INTEGRATOR_KEY]";

				// initialize client for desired environment (for production change to www)
				ApiClient apiClient = new ApiClient("https://demo.docusign.net/restapi");
				Configuration.Default.ApiClient = apiClient;

				// configure custom authentication header
				string authHeader = "{\"Username\":\"" + username + "\", \"Password\":\"" + password + "\", \"IntegratorKey\":\"" + integratorKey + "\"}";
				Configuration.Default.AddDefaultHeader("X-DocuSign-Authentication", authHeader);

				// we will retrieve this from the login API call
				string accountId = null;

				// login call is available in the authentication api 
				AuthenticationApi authApi = new AuthenticationApi();
				LoginInformation loginInfo = authApi.Login();
				accountId = loginInfo.LoginAccounts[0].AccountId;
			}
		}
	}
```

See [CoreRecipes.cs](https://github.com/docusign/docusign-csharp-client/blob/master/test/Recipes/CoreRecipes.cs) for more examples.

Testing
=======

Unit tests are available in the [Test](/test/SdkTests) folder. 

Support
=======

Feel free to log issues against this client through GitHub.  We also have an active developer community on Stack Overflow, search the [DocuSignAPI](http://stackoverflow.com/questions/tagged/docusignapi) tag.

License
=======

The DocuSign CSharp Client is licensed under the following [License](LICENSE).

Notes
=======

This version of the client library does not implement all of the DocuSign REST API methods. The current client omits methods in the Accounts, Billing, Cloud Storage, Connect, Groups (Branding), and Templates (Bulk Recipients) categories. The client's methods support the core set of use cases that most integrations will encounter. For a complete list of omitted endpoints, see [Omitted Endpoints](./omitted_endpoints.md).
