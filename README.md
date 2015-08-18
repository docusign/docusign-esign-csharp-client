#![Logo](icon.png)  DocuSign .NET Client
=========================================

The DocuSign .NET Client is built on DocuSign's public [REST API](https://www.docusign.com/p/RESTAPIGuide/RESTAPIGuide.htm) and provides a quick and easy way for developers to add DocuSign's world-class eSignature functionality to their .NET applications. The DocuSign .NET Client is available through NuGet (see Visual Studio -> Tools -> NuGet Package Manager) as well as this open source repository. 

Pre-requisites
----------

* DocuSign Developer account (*Free*)

You can create your free dev sandbox at the [DocuSign Developer Center](https://www.docusign.com/developer-center). You will need the **Integrator Key** from your developer account in order to use the DocuSign .NET Client, see the Quick Start section of the Developer Center for steps on how to create your key.  

Quickstart Guide
----------

### Add the DocuSign .NET Client to your project

METHOD 1:  Install from Visual Studio

* In Visual Studio open existing project or create a new one.
* Go to **Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution**.
* Search for "DocuSign" in the package manager window.
* Select the **DocuSign .NET Client** and click **Install**. 

METHOD 2:  Install from the Console

You can also install the DocuSign .NET Client and Json.NET dependency by running the following commands in the [NuGet Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console)

    PM> Install-Package DocuSign.Integration.Client.dll

METHOD 3:  Manual Install

* Download GitHub zip or pull code from Git command line.
* Copy source into your project's library directory (or other locations as needed).
* Make sure you also install the project's single dependency - Json.NET - from NewtonSoft.

### Add the using directive for access to DocuSign types

Add the following line of code to your project:

```
using DocuSign.Integrations.Client;
```

### Authenticate with DocuSign

Users of your integration authenticate with DocuSign by making the Login API call.  This requires 3 pieces of data: 

* Integrator Key (aka API key)
* Email Address 
* Password

For example, to authenticate against the DocuSign demo environment (ie _demo.docusign.net_) - which is where the DocuSign developer sandbox accounts operate in - you can use the following code:

	// configure application's integrator key and webservice url
	RestSettings.Instance.IntegratorKey = "INTEGRATOR_KEY";
	
	// credentials for sending account
	Account account = new Account();
	account.Email = "EMAIL";
	account.Password = "PASSWORD";

	// make the Login API call
	bool result = account.Login();

If you are not sure how to obtain your Integrator Key please read [Quick Start](https://www.docusign.com/developer-center/quick-start/first-api-call) section of the DocuSign Developer Center.  

### Create a DocuSign Envelope

The DocuSign .NET Client supports envelope creation on local documents as well as DocuSign (server-side) Templates.

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

The DocuSign .NET Client is licensed under the [DocuSign .NET Client License](LICENSE).

