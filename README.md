## Tests
### Test configuration
1. Login with your DocuSign account on https://appdemo.docusign.com.
2. Open Apps and Keys section in Settings and press Add App and Integration Key button.
3. Enter App name, add secret key, generate RSA key and press Save button.
4. Create new brand on https://admindemo.docusign.com/brands page and save its ID.
5. Create new template on https://appdemo.docusign.com/templates page and save its ID.
6. Create .env.example file copy with .env name and fill it with required data from steps 3-5. 
7. Write your generated private key to private.key file.

Also, you have to make sure you have the correct version of the .NET Framework installed on your PC, as one of the projects is configured to use the 4.6.2 version specifically.

You can download it from the official distributor by using a link (https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-developer-pack-offline-installer).

After downloading process is complete, you will need to open the installer and press the "Install" button.

Make sure the installation is successful before running the tests.

### Test running

In your Visual Studio, click Test->Run->All Tests

### Test running using command line

In order to run tests, try using `dotnet test` command, which will run tests from all three of the projects.

$ dotnet test 
