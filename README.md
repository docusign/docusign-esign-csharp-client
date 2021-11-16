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
To make sure, that libraries, set up in project files, will be loaded correctly, please, install .NET SDK from Microsoft page using a link (https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.403-windows-x64-installer). 

This link will locally install .NET SDK 5.0.403 version as the solution is using this version.

After downloading process is complete, you will need to open the installer and press the "Install" button.

Make sure the installation is successful before moving on to next steps.

### Installing .NET Core SDK
To make sure, that SdkNetCoreTest can run correctly, please, install .NET Core SDK from Microsoft page using a link (https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-2.1.202-windows-x64-installer). 

This link will locally install .NET Core SDK 2.0 version.

After downloading process is complete, you will need to open the installer and press the "Install" button.

Make sure the installation is successful before moving on to next steps.

### Setting up .NET versions

Also, you have to make sure you have the correct version of the .NET Framework installed on your PC, as one of the projects is configured to use the 4.6.2 version specifically and the eSignature SDK requires a 4.8 version to run correctly.

You can download them from the official distributor by using links:
* https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-developer-pack-offline-installer to load .Net Framework 4.6.2
* https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-developer-pack-offline-installer to load .Net Framework 4.8

After downloading process is complete, you will need to open each installer and press the "Install" button.

Make sure the installation is successful before running the tests.

### Restore the packages

#### Step 1: Restore the packages using nuget command

To restore any packages missing from the packages folder, please open a console in test folder of the project and try using `nuget restore` command.

``` nuget restore ```

If you are using command prompt and getting message that 'nuget' is not recognized as an internal or external command, operable program or batch file" then follow the steps below:

1. Download NuGet.exe from https://dist.nuget.org/win-x86-commandline/latest/nuget.exe

2. Open control panel>System and Security>System

3. Click on Advanced system settings

4. In advanced section, click in Environment Variables

5. In System variables, select path and edit

6. After semicolon, write "C:\Program Files\NuGet"

7. Click on Ok button till end.

9. Try running `nuget restore` command once again.

#### Step 2: Restore the packages using dotnet command

In order to restore the project dependencies, open a console in test folder of the project and try using `dotnet restore` command.

``` dotnet restore ```

If you are using command prompt and getting message that 'dotnet' is not recognized as an internal or external command, operable program or batch file" then first check the ```C:\Program Files\dotnet>``` path. If you found the ```C:\Program Files\dotnet>``` path then just copy it and set it as an environment variable of your PC.

Steps:

1. Open control panel>System and Security>System

2. Click on Advanced system settings

3. In advanced section, click in Environment Variables

4. In System variables, select path and edit

5. After semicolon, write "C:\Program Files\dotnet"

6. Click on Ok button till end.

7. Check whether its working on not. Just open command propmpt and type

```dotnet --version```
This will show the dotnet version installed in your PC.

### Test running

In your Visual Studio, click Test->Run->All Tests

### Test running using command line

In order to run tests, open a console in test folder of the project and try using `dotnet test` command, which will run tests from all three of the projects.

``` dotnet test ```
