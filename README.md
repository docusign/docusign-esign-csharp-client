DocuSign NuGet Client
=========================================

The DocuSign NuGet Client is built on our public [REST API](https://www.docusign.com/p/RESTAPIGuide/RESTAPIGuide.htm) and provides a quick and easy way for developers to add DocuSign's world-class document signing experience to their .NET applications.

Pre-requisites
----------

* DocuSign Developer account (Free)
* Microsoft Visual Studio

You can create your free dev account at the [DocuSign DevCenter](https://www.docusign.com/developer-center) using this [registration from](https://www.docusign.com/developer-center/get-started). You will need the **Integrator Key** from your developer account in order to use the DocuSign NuGet Client.  See [Common Terms](https://www.docusign.com/developer-center/explore/overview) for an explantion of the basic components of the DocuSign platform.

Quickstart Guide
----------

### Add the DocuSign NuGet Client to your project

Follow these steps to add the DocuSign NuGet Client to your project:

* In Visual Studio open existing project or create a new one.
* Go to **Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution**.
* Search for "DocuSign" in the package manager window.
* Select the **DocuSign NuGet Package** and click **Install**. 
* Additionally install **Json.NET** (the client's only external dependency).

You can also install the DocuSign NuGet Client and Json.NET dependency by running the following commands in the [NuGet Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console)

    PM> Install-Package DocuSign.Integration.Client.dll
    PM> Install-Package Newtonsoft.Json

### Add the using directive for access to DocuSign types

Add the following line to your project:

```
using DocuSign.Integrations.Client;
```

### Authenticate with DocuSign

Users of your integration authenticate with DocuSign by making the Login API call.  This requires 3 main pieces of data: 

* email address
* password
* Integrator Key

For example, to authenticate against the DocuSign demo environment (ie _demo.docusign.net_) you can use the following code:

	// configure application's integrator key and webservice url
	RestSettings.Instance.IntegratorKey = "<Your_Integrator_Key>";
	RestSettings.Instance.DocuSignAddress = "http://demo.docusign.net";
	RestSettings.Instance.WebServiceUrl = RestSettings.Instance.DocuSignAddress + "/restapi/v2";
	
	// credentials for sending account
	Account account = new Account();
	account.Email = "<Email_Address>";
	account.Password = "<Password>";

	// make the Login API call
	bool result = account.Login();

If you are not sure how to obtain your Integrator Key please read [Quick Start](https://www.docusign.com/developer-center/quick-start/first-api-call) section of the DocuSign Developer Center.  

### Create a DocuSign Envelope

The DocuSign NuGet Client supports envelope creation on local documents as well as DocuSign (server-side) Templates.

For example, to create an envelope from a local document:

	// create envelope object and assign login info
	Envelope envelope = new Envelope();
	envelope.Login = account;  // assign account info from above

	// "sent" to send immediately, "created" to save envelope as draft
	envelope.Status = "sent";

	// create a new DocuSign envelope (i.e. server side)
	envelope.Create("FULL_PATH_TO_DOCUMENT");

Code Samples
----------

Please see [Examples.cs](Examples.cs) for complete code samples of some of the most common DocuSign API scenarios.


License
----------

The DocuSign NuGet Client is licensed under the [DocuSign NuGet Client License](LICENSE).
