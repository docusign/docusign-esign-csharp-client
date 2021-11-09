## Tests
### Test configuration
1. Login with your DocuSign account on https://appdemo.docusign.com.
2. Open Apps and Keys section in Settings and press Add App and Integration Key button.
3. Enter App name, add secret key, generate RSA key and press Save button.
4. Create new brand on https://admindemo.docusign.com/brands page and save its ID.
5. Create new template on https://appdemo.docusign.com/templates page and save its ID.
6. Create .env.example file copy with .env name and fill it with required data from steps 3-5. 
7. Write your generated private key to private.key file.

### Recomended operating system
The prefered operating system to run unit-tests is Microsoft Windows 10.

### Installing .NET Runtime
To run tests for this project, please, install .NET Runtime (https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-5.0.12-windows-x64-installer).

After downloading process is complete, you will need to open the installer and press the "Install" button.

Make sure the installation is successful before moving on to next steps.

### Installing .NET SDK
To make sure, that libraries, set up in project files, will be loaded correctly, please, install .NET SDK from Microsoft page using a link (https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.403-windows-x64-installer). This link will locally install .NET SDK 5.0.403 version as the solution is using this version.

After downloading process is complete, you will need to open the installer and press the "Install" button.

Make sure the installation is successful before moving on to next steps.

### Setting up .NET versions

Also, you have to make sure you have the correct version of the .NET Framework installed on your PC, as one of the projects is configured to use the 4.6.2 version specifically.

You can download it from the official distributor by using a link (https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-developer-pack-offline-installer).

After downloading process is complete, you will need to open the installer and press the "Install" button.

Make sure the installation is successful before running the tests.

### Test running

In your Visual Studio, click Test->Run->All Tests

### Test running using command line

In order to run tests, open a console in test folder of the project and try using `dotnet test` command, which will run tests from all three of the projects.

$ dotnet test 
