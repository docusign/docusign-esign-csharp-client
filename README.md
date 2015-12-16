# DocuSign C# Client

The DocuSign C# Client is a Swagger-based auto-generated library that can be used to quickly interact with the DocuSign REST API.  It provides the C# versions of REST request and response models and endpoints. This project contains the core source code for the client along with tests and a few examples showing its use.  

**ORGANIZATION**

  * `\sdk`:  Source code for the client 
  * `\test`:  Unit tests and sample code

**HOW TO USE**

Add the following References to your Visual Studio project from [/sdk/bin/](sdk/bin/):

```
DocuSign.Core.dll
NewtonsoftJson.dll
RestSharp.dll
```
  
In your C# source code, add the following `using` statements:

```
using DocuSign.eSign.Api;  
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;
```

**EXAMPLES**

* Recipes (Code Walkthroughs) are available here:  [CoreRecipes.cs](test/Recipes/CoreRecipes.cs)
* Unit tests are available here: [/SDK Tests](test/SdkTests/SdkTests)

(Note: The tests for Account Server OAuth2 Authentication are early concept and not for external use. This is pre-release software.)
