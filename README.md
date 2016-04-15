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

To send a signature request from a template:

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

				// configure 'X-DocuSign-Authentication' header
				string authHeader = "{\"Username\":\"" + username + "\", \"Password\":\"" + password + "\", \"IntegratorKey\":\"" + integratorKey + "\"}";
				Configuration.Default.AddDefaultHeader("X-DocuSign-Authentication", authHeader);

				// we will retrieve this from the login API call
				string accountId = null;

				/////////////////////////////////////////////////////////////////
				// STEP 1: LOGIN API        
				/////////////////////////////////////////////////////////////////

				// login call is available in the authentication api 
				AuthenticationApi authApi = new AuthenticationApi();
				LoginInformation loginInfo = authApi.Login();
				
				// parse the first account ID that is returned (user might belong to multiple accounts)
				accountId = loginInfo.LoginAccounts[0].AccountId;
				
				/////////////////////////////////////////////////////////////////
				// STEP 2: CREATE ENVELOPE API        
				/////////////////////////////////////////////////////////////////				
				
				// create a new envelope which we will use to send the signature request
				EnvelopeDefinition envDef = new EnvelopeDefinition();
				envDef.EmailSubject = "[DocuSign C# SDK] - Sample Signature Request";

				// provide a valid template ID from a template in your account
				envDef.TemplateId = "[TEMPLATE_ID]";

				// assign recipient to template role by setting name, email, and role name.  Note that the
				// template role name must match the placeholder role name saved in your account template.  
				TemplateRole tRole = new TemplateRole();
				tRole.Email = "[SIGNER_EMAIL]";
				tRole.Name = "[SIGNER_NAME]";
				tRole.RoleName = "[ROLE_NAME]";

				// add the roles list with the our single role to the envelope
				List<TemplateRole> rolesList = new List<TemplateRole>() { tRole };
				envDef.TemplateRoles = rolesList;

				// set envelope status to "sent" to immediately send the signature request
				envDef.Status = "sent";

				// |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
				EnvelopesApi envelopesApi = new EnvelopesApi();
				EnvelopeSummary envelopeSummary = envelopesApi.CreateEnvelope(accountId, envDef);
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
