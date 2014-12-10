/** 
 * file: Examples.cs 
 * start date: 12/8/14
 * @author:  DocuSign
 * descr:  Sample C# console application used to illustrate DocuSign .NET Client usage.  
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using DocuSign.Integrations.Client;

// *** NOTE ***
// Please note that the following samples are just for illustration purposes and have been designed 
// to be self-contained.  It might make sense for you to define some of the local function variables in 
// other locations of your application, especially the Integrator Key and webURLs, for instance.  
// For other variables it might make sense to pass them as function parameters (ie. templateIds, 
// enevelopeIds, recipient data, etc.)
// ************

namespace DocuSignNuGetSamples
{
    class TestProgram
    {
        // Integrator Key and Environment are defined at the application level
        // Your Integrator Key can be found in your account Preferences -> API screen.
        protected const string IntegratorKey = "***";

        // update this once you move into production
        protected const string Environment = "http://demo.docusign.net"; 

        static void Main(string[] args)
        {
            // Example #1...
            Console.WriteLine("Testing Walkthrough #1...");
            
            // configure application's integrator key, webservice url, and rest api version
            RestSettings.Instance.IntegratorKey = IntegratorKey;
            RestSettings.Instance.DocuSignAddress = Environment;
            RestSettings.Instance.WebServiceUrl = Environment + "/restapi/v2";

            TestProgram test = new TestProgram();
            test.SignatureRequestFromTemplate();
            Console.ReadLine(); // pause to show console output
        }

        //==========================================================================================
        // *** Walkthrough #1 - Request Signature from Template
        //==========================================================================================
        private void SignatureRequestFromTemplate()
        {
            //*****************************************************************
            // ENTER VALUES FOR FOLLOWING VARIABLES!
            //*****************************************************************
            string AccountEmail = "***";
            string AccountPassword = "***";
            string RecipientEmail = "***";
            string RecipientName = "***";
            string TemplateId = "***";
            string TemplateRoleName = "***";
            //*****************************************************************

            // user credentials 
            Account account = new Account();
            account.Email = AccountEmail;
            account.Password = AccountPassword;

            // make the login call (retrieves your baseUrl and accountId)
            bool result = account.Login();
            if (!result)
            {
                Console.WriteLine("Login API call failed for user {0}.\nError Code:  {1}\nMessage:  {2}", account.Email, account.RestError.errorCode, account.RestError.message);
                return;
            }

            // create envelope object and assign login info
            Envelope envelope = new Envelope();
            envelope.Login = account;

            // use an existing server template
            envelope.TemplateId = TemplateId;

            // add one signer to a template role identified by roleName
            envelope.TemplateRoles = new TemplateRole[]
            {
                new TemplateRole()
                {
                    email = RecipientEmail,
                    name = RecipientName,
                    roleName = TemplateRoleName
                }
            };

            // Email subject is a required parameter when requesting signatures
            envelope.EmailSubject = "DocuSign .NET Client - Signature Request from Template";

            // "sent" to send immediately, "created" to save envelope as draft
            envelope.Status = "sent";

            // create and send the envelope (since status is set to "sent")
            result = envelope.Create();

            if (!result)
            {
                if (envelope.RestError != null)
                {
                    Console.WriteLine("Error code:  {0}\nMessage:  {1}", envelope.RestError.errorCode, envelope.RestError.message);
                    return;
                }
                else
                {
                    Console.WriteLine("Error encountered while requesting signature from template, please review your envelope and recipient data.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Signature request has been sent to {0}, envelopeId is {1}", envelope.TemplateRoles[0].email, envelope.EnvelopeId);
            }
        }

        //==========================================================================================
        // *** Walkthrough #2 - Get Envelope Information
        //==========================================================================================
        private void GetEnvelopeInformation()
        {
            //*****************************************************************
            // ENTER VALUES FOR FOLLOWING VARIABLES!
            //*****************************************************************
            string AccountEmail = "***";
            string AccountPassword = "***";
            string EnvelopeId = "***";
            //*****************************************************************

            // user credentials 
            Account account = new Account();
            account.Email = AccountEmail;
            account.Password = AccountPassword;

            // make the login call (retrieves your baseUrl and accountId)
            bool result = account.Login();
            if (!result)
            {
                Console.WriteLine("Login API call failed for user {0}.\nError Code:  {1}\nMessage:  {2}", account.Email, account.RestError.errorCode, account.RestError.message);
                return;
            }

            // create envelope object and assign login info
            Envelope envelope = new Envelope();
            envelope.Login = account;

            DateTime sentTime = envelope.GetStatus(EnvelopeId);

            if (envelope.RestError != null)
            {
                Console.WriteLine("Error code:  {0}\nMessage:  {1}", envelope.RestError.errorCode, envelope.RestError.message);
                return;
            }

            Console.WriteLine("Envelope originally sent {0} currently has status:  {1}\nEnvelope Email Subject is:  {2}", sentTime, envelope.Status, envelope.EmailSubject);
        }

        //==========================================================================================
        // *** Walkthrough #3 - Get Recipient Information
        //==========================================================================================
        private void GetEnvelopeRecipientInformation()
        {
            //*****************************************************************
            // ENTER VALUES FOR FOLLOWING VARIABLES!
            //*****************************************************************
            string AccountEmail = "***";
            string AccountPassword = "***";
            string EnvelopeId = "***";
            //*****************************************************************

            // user credentials 
            Account account = new Account();
            account.Email = AccountEmail;
            account.Password = AccountPassword;

            // make the login call (retrieves your baseUrl and accountId)
            bool result = account.Login();
            if (!result)
            {
                Console.WriteLine("Login API call failed for user {0}.\nError Code:  {1}\nMessage:  {2}", account.Email, account.RestError.errorCode, account.RestError.message);
                return;
            }

            // create envelope object and assign login info
            Envelope envelope = new Envelope();
            envelope.Login = account;

            // set the envelopeId for which we will retrieve recipient info from
            envelope.EnvelopeId = EnvelopeId;

            // Retrieve envelope recipient names
            var recipNames = envelope.GetRecipientNames();

            if (envelope.RestError != null)
            {
                Console.WriteLine("Error code:  {0}\nMessage:  {1}", envelope.RestError.errorCode, envelope.RestError.message);
                return;
            }

            Console.WriteLine("Envelope contains following recipients:\n");
            foreach (var name in recipNames)
            {
                Console.WriteLine("\t{0}", name);
            }

        }

        //==========================================================================================
        // *** Walkthrough #4 - Request Signature on Document
        //==========================================================================================
        private void SignatureRequestOnDocument()
        {
            //*****************************************************************
            // ENTER VALUES FOR FOLLOWING VARIABLES!
            //*****************************************************************
            string AccountEmail = "***";
            string AccountPassword = "***";
            string RecipientEmail = "***";
            string RecipientName = "***";
            string documentPath = "***";
            //*****************************************************************

            // user credentials 
            Account account = new Account();
            account.Email = AccountEmail;
            account.Password = AccountPassword;

            // make the login call (retrieves your baseUrl and accountId)
            bool result = account.Login();
            if (!result)
            {
                Console.WriteLine("Login API call failed for user {0}.\nError Code:  {1}\nMessage:  {2}", account.Email, account.RestError.errorCode, account.RestError.message);
                return;
            }

            // create envelope object and assign login info
            Envelope envelope = new Envelope();
            envelope.Login = account;

            // add one signer to the envelope
            envelope.Recipients = new Recipients()
            {
                signers = new Signer[]
                {
                    new Signer()
                    {
                        email = RecipientEmail,
                        name = RecipientName,
                        routingOrder = "1",
                        recipientId = "1"
                    }
                }
            };

            // send the envelope immediately (otherwise set to "created" to save as draft envelope)
            envelope.Status = "sent";

            // email subject is required
            envelope.EmailSubject = "DocuSign .NET Client - Signature Request on Document";

            // create envelope and send the signature request (since status is set to "sent")
            result = envelope.Create(documentPath);

            if (!result)
            {
                if (envelope.RestError != null)
                {
                    Console.WriteLine("Error code:  {0}\nMessage:  {1}", envelope.RestError.errorCode, envelope.RestError.message);
                    return;
                }
                else
                {
                    Console.WriteLine("Error encountered while requesting signature from template, please review your envelope and recipient data.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Signature request has been sent to {0}, envelopeId is {1}.", envelope.Recipients.signers[0].email, envelope.EnvelopeId);
            }
        }

        //==========================================================================================
        // *** Walkthrough #6 - Get Documents List and Download Documents
        //==========================================================================================
        private void GetDocsListAndDownloadDocuments()
        {
            //*****************************************************************
            // ENTER VALUES FOR FOLLOWING VARIABLES!
            //*****************************************************************
            string AccountEmail = "***";
            string AccountPassword = "***";
            string EnvelopeId = "***";
            //*****************************************************************

            // user credentials 
            Account account = new Account();
            account.Email = AccountEmail;
            account.Password = AccountPassword;

            // make the login call (retrieves your baseUrl and accountId)
            bool result = account.Login();
            if (!result)
            {
                Console.WriteLine("Login API call failed for user {0}.\nError Code:  {1}\nMessage:  {2}", account.Email, account.RestError.errorCode, account.RestError.message);
                return;
            }

            // create envelope object and assign login info
            Envelope envelope = new Envelope();
            envelope.Login = account;

            // assign the passed in envelope id to the newly created envelope object
            envelope.EnvelopeId = EnvelopeId;

            // get the envelope's documents 
            List<EnvelopeDocument> envDocs = envelope.GetDocuments();

            // loop through the documents and display some info about them
            foreach (var doc in envDocs)
            {
                Console.WriteLine("Document id {0} is named {1}.", doc.documentId, doc.name);
            }

            // now let's download the actual document bytes and store in a local file in the application's main directory
            string applicationPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            byte[] completedDocBytes = envelope.GetCompletedDocument(EnvelopeId, true);

            // set local document name here, currently using envelopeID.pdf as name
            string localFileName = applicationPath + "\\" + EnvelopeId + ".pdf";

            // combine all envelope documents (including certificate) into local PDF file
            File.WriteAllBytes(localFileName, completedDocBytes);

            Console.WriteLine("Completed documents have been downloaded to {0}", localFileName);
        }

        //==========================================================================================
        // *** Walkthrough #7 - Embedded Sending
        //==========================================================================================
        private void EmbeddedSending()
        {
            //*****************************************************************
            // ENTER VALUES FOR FOLLOWING VARIABLES!
            //*****************************************************************
            string AccountEmail = "***";
            string AccountPassword = "***";
            string documentPath = "***";
            //*****************************************************************

            // user credentials 
            Account account = new Account();
            account.Email = AccountEmail;
            account.Password = AccountPassword;

            // make the login call (retrieves your baseUrl and accountId)
            bool result = account.Login();
            if (!result)
            {
                Console.WriteLine("Login API call failed for user {0}.\nError Code:  {1}\nMessage:  {2}", account.Email, account.RestError.errorCode, account.RestError.message);
                return;
            }

            // create envelope object and assign login info
            Envelope envelope = new Envelope();
            envelope.Login = account;

            // create a new DocuSign envelope (i.e. server side)
            envelope.Create(documentPath);

            // generate sender view token
            result = envelope.GetSenderView("http://www.nuget.org/packages/DocuSign.Integration.Client.dll/");

            if (!result)
            {
                if (envelope.RestError != null)
                {
                    Console.WriteLine("Error code:  {0}\nMessage:  {1}", envelope.RestError.errorCode, envelope.RestError.message);
                    return;
                }
                else
                {
                    Console.WriteLine("Error encountered retrieving signing token, please review your envelope and recipient data.");
                    return;
                }
            }
            else
            {
                // open the envelope's sending view
                Process.Start(envelope.SenderViewUrl);
            }
        }

        //==========================================================================================
        // *** Walkthrough #8 - Embedded Signing
        //==========================================================================================
        private void EmbeddedSigning()
        {
            //*****************************************************************
            // ENTER VALUES FOR FOLLOWING VARIABLES!
            //*****************************************************************
            string AccountEmail = "***";
            string AccountPassword = "***";
            string EnvelopeId = "***";
            string RecipientEmail = "***";
            string RecipientName = "***";
            //*****************************************************************

            // user credentials 
            Account account = new Account();
            account.Email = AccountEmail;
            account.Password = AccountPassword;

            // make the login call (retrieves your baseUrl and accountId)
            bool result = account.Login();
            if (!result)
            {
                Console.WriteLine("Login API call failed for user {0}.\nError Code:  {1}\nMessage:  {2}", account.Email, account.RestError.errorCode, account.RestError.message);
                return;
            }

            // create envelope object and assign login info
            Envelope envelope = new Envelope();
            envelope.Login = account;

            // assign the envelope id that was passed in
            envelope.EnvelopeId = EnvelopeId;

            // add one signer (single recipient embedded signing currently supported in DocuSign .NET Client)
            envelope.Recipients = new Recipients()
            {
                signers = new Signer[]
                {
                    new Signer()
                    {
                        email = RecipientEmail,
                        name = RecipientName,
                        recipientId = "1"
                    }
                }
            };

            // generate the recipient view token
            result = envelope.GetRecipientView("http://www.nuget.org/packages/DocuSign.Integration.Client.dll/");

            if (!result)
            {
                if (envelope.RestError != null)
                {
                    Console.WriteLine("Error code:  {0}\nMessage:  {1}", envelope.RestError.errorCode, envelope.RestError.message);
                    return;
                }
                else
                {
                    Console.WriteLine("Error encountered retrieving signing token, please review your envelope and recipient data.");
                    return;
                }
            }
            else
            {
                // open the recipient view (SenderViewUrl field is re-used for the recipient URL)
                Process.Start(envelope.SenderViewUrl);
            }
        }

        //==========================================================================================
        // *** Walkthrough #9 - Embedded DocuSign Console
        //==========================================================================================
        private void EmbeddedDocuSignConsole()
        {
            //*****************************************************************
            // ENTER VALUES FOR FOLLOWING VARIABLES!
            //*****************************************************************
            string AccountEmail = "***";
            string AccountPassword = "***";
            //*****************************************************************

            // user credentials 
            Account account = new Account();
            account.Email = AccountEmail;
            account.Password = AccountPassword;

            // make the login call (retrieves your baseUrl and accountId)
            bool result = account.Login();
            if (!result)
            {
                Console.WriteLine("Login API call failed for user {0}.\nError Code:  {1}\nMessage:  {2}", account.Email, account.RestError.errorCode, account.RestError.message);
                return;
            }

            // generate user console URL 
            result = account.GetUserConsoleView();

            if (!result)
            {
                if (account.RestError != null)
                {
                    Console.WriteLine("Error code:  {0}\nMessage:  {1}", account.RestError.errorCode, account.RestError.message);
                    return;
                }
                else
                {
                    Console.WriteLine("Error encountered retrieving signing token, please review your envelope and recipient data.");
                    return;
                }
            }
            else
            {
                // open the DocuSign Console View
                Process.Start(account.ConsoleUrl);
            }
        }
    }
}
