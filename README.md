DocuSign DevCon 2015
----------

![Alt text](DevCon.jpg "DocuSign DevCon 2015")

Looking to fast-track your integration?  Join us at DocuSign DevCon 2015 to learn from the leading business platforms, attend hands-on coding sessions, and network directly with DocuSign engineers and architects.  We'll be taking over Union Square in San Francisco for this 2-day developer conference starting with an opening keynote from the legendary Geoffrey Moore.  [REGISTER NOW!](http://momentum.docusign.com/san-francisco/dev-con/?mc=devcon-github)


#![Logo](icon.png)  DocuSign .NET Client
=========================================

The DocuSign .NET Client is built on DocuSign's public [REST API](https://www.docusign.com/p/RESTAPIGuide/RESTAPIGuide.htm) and provides a quick and easy way for developers to add DocuSign's world-class document signing experience to their .NET applications.

Pre-requisites
----------

* DocuSign Developer account (*Free*)

You can create your free dev account at the [DocuSign Dev Center](https://www.docusign.com/developer-center). You will need the **Integrator Key** from your developer account in order to use the DocuSign .NET Client.

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

