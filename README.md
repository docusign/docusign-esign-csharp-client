## Tests
### Test configuration
1. Login with your DocuSign account on https://appdemo.docusign.com.
2. Open Apps and Keys section in Settings and press Add App and Integration Key button.
3. Enter App name, add secret key, generate RSA key and press Save button.
4. Repeat steps 2-3 to create additional Integration Key and RSA key. 
5. Create new brand on https://admindemo.docusign.com/brands page and save its ID.
6. Create new template on https://appdemo.docusign.com/templates page and save its ID.
7. Create .env.example file copy with .env name and fill it with required data from steps 3-6. The Integration Key, recieved from step 3 should be added to a field called INTEGRATOR_KEY_JWT_NO_CONSENT.
8. Write your generated private key to private.key file.
9. Write the private key, generated during step 3, to the privatekey_noconsent.key file.

### Test running

In your Visual Studio, click Test->Run->All Tests
