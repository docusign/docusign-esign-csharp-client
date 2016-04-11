using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace DocuSign.eSign.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDiagnosticsApi
    {
        
        /// <summary>
        /// Retrieves the available REST API versions.
        /// </summary>
        /// <remarks>
        /// Retrieves the available REST API versions.\n\nDocuSign Production system: https://www.docusign.net/restapi/service_information\nDocuSign Demo system: https://demo.docusign.net/restapi/service_information\n\nYou do not need an integrator key to view the REST API versions and resources.
        /// </remarks>
		
	    ///
		/// <returns>1ServiceInformation</returns>
        ServiceInformation GetService ();
 
		/// <summary>
        /// Retrieves the available REST API versions.
        /// </summary>
        /// <remarks>
        /// Retrieves the available REST API versions.\n\nDocuSign Production system: https://www.docusign.net/restapi/service_information\nDocuSign Demo system: https://demo.docusign.net/restapi/service_information\n\nYou do not need an integrator key to view the REST API versions and resources.
        /// </remarks>
 	    ///
		/// <returns>2ApiResponse of ServiceInformation</returns>
        ApiResponse<ServiceInformation> GetServiceWithHttpInfo ();

        /// <summary>
        /// Retrieves the available REST API versions.
        /// </summary>
        /// <remarks>
        /// Retrieves the available REST API versions.\n\nDocuSign Production system: https://www.docusign.net/restapi/service_information\nDocuSign Demo system: https://demo.docusign.net/restapi/service_information\n\nYou do not need an integrator key to view the REST API versions and resources.
        /// </remarks>
	    ///
		/// <returns>3Task of ServiceInformation</returns>
        System.Threading.Tasks.Task<ServiceInformation> GetServiceAsync ();

        /// <summary>
        /// Retrieves the available REST API versions.
        /// </summary>
        /// <remarks>
        /// Retrieves the available REST API versions.\n\nDocuSign Production system: https://www.docusign.net/restapi/service_information\nDocuSign Demo system: https://demo.docusign.net/restapi/service_information\n\nYou do not need an integrator key to view the REST API versions and resources.
        /// </remarks>
	    ///
		/// <returns>4Task of ApiResponse (ServiceInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceInformation>> GetServiceAsyncWithHttpInfo ();
        
        /// <summary>
        /// Lists resources for REST version specified
        /// </summary>
        /// <remarks>
        /// Retrieves the base resources available for the DocuSign REST APIs.\n\nYou do not need an integrator key to view the REST API versions and resources.\n\nExample: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.\n\nTo view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.\n\nExample: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and json request and response samples.
        /// </remarks>
		
	    ///
		/// <returns>1ResourceInformation</returns>
        ResourceInformation GetResources ();
 
		/// <summary>
        /// Lists resources for REST version specified
        /// </summary>
        /// <remarks>
        /// Retrieves the base resources available for the DocuSign REST APIs.\n\nYou do not need an integrator key to view the REST API versions and resources.\n\nExample: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.\n\nTo view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.\n\nExample: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and json request and response samples.
        /// </remarks>
 	    ///
		/// <returns>2ApiResponse of ResourceInformation</returns>
        ApiResponse<ResourceInformation> GetResourcesWithHttpInfo ();

        /// <summary>
        /// Lists resources for REST version specified
        /// </summary>
        /// <remarks>
        /// Retrieves the base resources available for the DocuSign REST APIs.\n\nYou do not need an integrator key to view the REST API versions and resources.\n\nExample: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.\n\nTo view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.\n\nExample: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and json request and response samples.
        /// </remarks>
	    ///
		/// <returns>3Task of ResourceInformation</returns>
        System.Threading.Tasks.Task<ResourceInformation> GetResourcesAsync ();

        /// <summary>
        /// Lists resources for REST version specified
        /// </summary>
        /// <remarks>
        /// Retrieves the base resources available for the DocuSign REST APIs.\n\nYou do not need an integrator key to view the REST API versions and resources.\n\nExample: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.\n\nTo view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.\n\nExample: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and json request and response samples.
        /// </remarks>
	    ///
		/// <returns>4Task of ApiResponse (ResourceInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceInformation>> GetResourcesAsyncWithHttpInfo ();
        
        /// <summary>
        /// Gets the API request logging log files.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </remarks>
		
	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1ApiRequestLogsResult</returns>
        ApiRequestLogsResult ListRequestLogs (DiagnosticsApi.ListRequestLogsOptions options = null);
 
		/// <summary>
        /// Gets the API request logging log files.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </remarks>
 	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of ApiRequestLogsResult</returns>
        ApiResponse<ApiRequestLogsResult> ListRequestLogsWithHttpInfo (DiagnosticsApi.ListRequestLogsOptions options = null);

        /// <summary>
        /// Gets the API request logging log files.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </remarks>
	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of ApiRequestLogsResult</returns>
        System.Threading.Tasks.Task<ApiRequestLogsResult> ListRequestLogsAsync (DiagnosticsApi.ListRequestLogsOptions options = null);

        /// <summary>
        /// Gets the API request logging log files.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </remarks>
	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (ApiRequestLogsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiRequestLogsResult>> ListRequestLogsAsyncWithHttpInfo (DiagnosticsApi.ListRequestLogsOptions options = null);
        
        /// <summary>
        /// Deletes the request log files.
        /// </summary>
        /// <remarks>
        /// Deletes the request log files.
        /// </remarks>
		
	    ///
		/// <returns>1</returns>
        void DeleteRequestLogs ();
 
		/// <summary>
        /// Deletes the request log files.
        /// </summary>
        /// <remarks>
        /// Deletes the request log files.
        /// </remarks>
 	    ///
		/// <returns>2ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRequestLogsWithHttpInfo ();

        /// <summary>
        /// Deletes the request log files.
        /// </summary>
        /// <remarks>
        /// Deletes the request log files.
        /// </remarks>
	    ///
		/// <returns>3Task of void</returns>
        System.Threading.Tasks.Task DeleteRequestLogsAsync ();

        /// <summary>
        /// Deletes the request log files.
        /// </summary>
        /// <remarks>
        /// Deletes the request log files.
        /// </remarks>
	    ///
		/// <returns>4Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRequestLogsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Gets a request logging log file.
        /// </summary>
        /// <remarks>
        /// Retrieves information for a single log entry.\n\n**Request**\nThe `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.\n\n**Response**\nIf the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.
        /// </remarks>
		
	    ///<param name="requestLogId"></param>
		/// <returns>1Stream</returns>
        Stream GetRequestLog (string requestLogId);
 
		/// <summary>
        /// Gets a request logging log file.
        /// </summary>
        /// <remarks>
        /// Retrieves information for a single log entry.\n\n**Request**\nThe `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.\n\n**Response**\nIf the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.
        /// </remarks>
 	    ///<param name="requestLogId"></param>
		/// <returns>2ApiResponse of Stream</returns>
        ApiResponse<Stream> GetRequestLogWithHttpInfo (string requestLogId);

        /// <summary>
        /// Gets a request logging log file.
        /// </summary>
        /// <remarks>
        /// Retrieves information for a single log entry.\n\n**Request**\nThe `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.\n\n**Response**\nIf the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.
        /// </remarks>
	    ///<param name="requestLogId"></param>
		/// <returns>3Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> GetRequestLogAsync (string requestLogId);

        /// <summary>
        /// Gets a request logging log file.
        /// </summary>
        /// <remarks>
        /// Retrieves information for a single log entry.\n\n**Request**\nThe `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.\n\n**Response**\nIf the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.
        /// </remarks>
	    ///<param name="requestLogId"></param>
		/// <returns>4Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> GetRequestLogAsyncWithHttpInfo (string requestLogId);
        
        /// <summary>
        /// Gets the API request logging settings.
        /// </summary>
        /// <remarks>
        /// Retrieves the current API request logging setting for the user and remaining log entries.\n\n**Response**\nThe response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.
        /// </remarks>
		
	    ///
		/// <returns>1DiagnosticsSettingsInformation</returns>
        DiagnosticsSettingsInformation GetRequestLogSettings ();
 
		/// <summary>
        /// Gets the API request logging settings.
        /// </summary>
        /// <remarks>
        /// Retrieves the current API request logging setting for the user and remaining log entries.\n\n**Response**\nThe response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.
        /// </remarks>
 	    ///
		/// <returns>2ApiResponse of DiagnosticsSettingsInformation</returns>
        ApiResponse<DiagnosticsSettingsInformation> GetRequestLogSettingsWithHttpInfo ();

        /// <summary>
        /// Gets the API request logging settings.
        /// </summary>
        /// <remarks>
        /// Retrieves the current API request logging setting for the user and remaining log entries.\n\n**Response**\nThe response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.
        /// </remarks>
	    ///
		/// <returns>3Task of DiagnosticsSettingsInformation</returns>
        System.Threading.Tasks.Task<DiagnosticsSettingsInformation> GetRequestLogSettingsAsync ();

        /// <summary>
        /// Gets the API request logging settings.
        /// </summary>
        /// <remarks>
        /// Retrieves the current API request logging setting for the user and remaining log entries.\n\n**Response**\nThe response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.
        /// </remarks>
	    ///
		/// <returns>4Task of ApiResponse (DiagnosticsSettingsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DiagnosticsSettingsInformation>> GetRequestLogSettingsAsyncWithHttpInfo ();
        
        /// <summary>
        /// Enables or disables API request logging for troubleshooting.
        /// </summary>
        /// <remarks>
        /// Enables or disables API request logging for troubleshooting.\n\nWhen enabled (apiRequestLogging is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.\n\nYou can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.\n\nPrivate information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.\n\n### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn&#39;t logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged.
        /// </remarks>
		
	    /// <param name="diagnosticsSettingsInformation">TBD Description</param>
		/// <returns>1DiagnosticsSettingsInformation</returns>
        DiagnosticsSettingsInformation UpdateRequestLogSettings (DiagnosticsSettingsInformation diagnosticsSettingsInformation);
 
		/// <summary>
        /// Enables or disables API request logging for troubleshooting.
        /// </summary>
        /// <remarks>
        /// Enables or disables API request logging for troubleshooting.\n\nWhen enabled (apiRequestLogging is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.\n\nYou can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.\n\nPrivate information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.\n\n### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn&#39;t logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged.
        /// </remarks>
 	    /// <param name="diagnosticsSettingsInformation">TBD Description</param>
		/// <returns>2ApiResponse of DiagnosticsSettingsInformation</returns>
        ApiResponse<DiagnosticsSettingsInformation> UpdateRequestLogSettingsWithHttpInfo (DiagnosticsSettingsInformation diagnosticsSettingsInformation);

        /// <summary>
        /// Enables or disables API request logging for troubleshooting.
        /// </summary>
        /// <remarks>
        /// Enables or disables API request logging for troubleshooting.\n\nWhen enabled (apiRequestLogging is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.\n\nYou can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.\n\nPrivate information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.\n\n### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn&#39;t logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged.
        /// </remarks>
	    /// <param name="diagnosticsSettingsInformation">TBD Description</param>
		/// <returns>3Task of DiagnosticsSettingsInformation</returns>
        System.Threading.Tasks.Task<DiagnosticsSettingsInformation> UpdateRequestLogSettingsAsync (DiagnosticsSettingsInformation diagnosticsSettingsInformation);

        /// <summary>
        /// Enables or disables API request logging for troubleshooting.
        /// </summary>
        /// <remarks>
        /// Enables or disables API request logging for troubleshooting.\n\nWhen enabled (apiRequestLogging is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.\n\nYou can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.\n\nPrivate information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.\n\n### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn&#39;t logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged.
        /// </remarks>
	    /// <param name="diagnosticsSettingsInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse (DiagnosticsSettingsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<DiagnosticsSettingsInformation>> UpdateRequestLogSettingsAsyncWithHttpInfo (DiagnosticsSettingsInformation diagnosticsSettingsInformation);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DiagnosticsApi : IDiagnosticsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DiagnosticsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DiagnosticsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
		
		
		

		
		
		
        /// <summary>
        /// Retrieves the available REST API versions. Retrieves the available REST API versions.\n\nDocuSign Production system: https://www.docusign.net/restapi/service_information\nDocuSign Demo system: https://demo.docusign.net/restapi/service_information\n\nYou do not need an integrator key to view the REST API versions and resources.
        /// </summary>
 	    ///
		/// <returns>5ServiceInformation</returns>
        public ServiceInformation GetService ()
        {
             ApiResponse<ServiceInformation> response = GetServiceWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Retrieves the available REST API versions. Retrieves the available REST API versions.\n\nDocuSign Production system: https://www.docusign.net/restapi/service_information\nDocuSign Demo system: https://demo.docusign.net/restapi/service_information\n\nYou do not need an integrator key to view the REST API versions and resources.
        /// </summary>
 	    ///
		/// <returns>6ApiResponse of ServiceInformation</returns>
        public ApiResponse< ServiceInformation > GetServiceWithHttpInfo ()
        {
            
    
            var path_ = "/service_information";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetService: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetService: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ServiceInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInformation) Configuration.ApiClient.Deserialize(response, typeof(ServiceInformation)));
            
        }
    
        /// <summary>
        /// Retrieves the available REST API versions. Retrieves the available REST API versions.\n\nDocuSign Production system: https://www.docusign.net/restapi/service_information\nDocuSign Demo system: https://demo.docusign.net/restapi/service_information\n\nYou do not need an integrator key to view the REST API versions and resources.
        /// </summary>
 	    ///
		/// <returns>7Task of ServiceInformation</returns>
        public async System.Threading.Tasks.Task<ServiceInformation> GetServiceAsync ()
        {
             ApiResponse<ServiceInformation> response = await GetServiceAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Retrieves the available REST API versions. Retrieves the available REST API versions.\n\nDocuSign Production system: https://www.docusign.net/restapi/service_information\nDocuSign Demo system: https://demo.docusign.net/restapi/service_information\n\nYou do not need an integrator key to view the REST API versions and resources.
        /// </summary>
	    ///
		/// <returns>8Task of ApiResponse (ServiceInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceInformation>> GetServiceAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/service_information";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetService: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetService: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ServiceInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInformation) Configuration.ApiClient.Deserialize(response, typeof(ServiceInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Lists resources for REST version specified Retrieves the base resources available for the DocuSign REST APIs.\n\nYou do not need an integrator key to view the REST API versions and resources.\n\nExample: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.\n\nTo view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.\n\nExample: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and json request and response samples.
        /// </summary>
 	    ///
		/// <returns>5ResourceInformation</returns>
        public ResourceInformation GetResources ()
        {
             ApiResponse<ResourceInformation> response = GetResourcesWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Lists resources for REST version specified Retrieves the base resources available for the DocuSign REST APIs.\n\nYou do not need an integrator key to view the REST API versions and resources.\n\nExample: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.\n\nTo view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.\n\nExample: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and json request and response samples.
        /// </summary>
 	    ///
		/// <returns>6ApiResponse of ResourceInformation</returns>
        public ApiResponse< ResourceInformation > GetResourcesWithHttpInfo ()
        {
            
    
            var path_ = "/v2";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ResourceInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResourceInformation) Configuration.ApiClient.Deserialize(response, typeof(ResourceInformation)));
            
        }
    
        /// <summary>
        /// Lists resources for REST version specified Retrieves the base resources available for the DocuSign REST APIs.\n\nYou do not need an integrator key to view the REST API versions and resources.\n\nExample: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.\n\nTo view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.\n\nExample: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and json request and response samples.
        /// </summary>
 	    ///
		/// <returns>7Task of ResourceInformation</returns>
        public async System.Threading.Tasks.Task<ResourceInformation> GetResourcesAsync ()
        {
             ApiResponse<ResourceInformation> response = await GetResourcesAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Lists resources for REST version specified Retrieves the base resources available for the DocuSign REST APIs.\n\nYou do not need an integrator key to view the REST API versions and resources.\n\nExample: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.\n\nTo view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.\n\nExample: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and json request and response samples.
        /// </summary>
	    ///
		/// <returns>8Task of ApiResponse (ResourceInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ResourceInformation>> GetResourcesAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/v2";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetResources: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetResources: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ResourceInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ResourceInformation) Configuration.ApiClient.Deserialize(response, typeof(ResourceInformation)));
            
        }
        
		
		
        /// <summary>
        /// Gets the API request logging log files. Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </summary>
		public class ListRequestLogsOptions
		{
				
			/// 
			public string encoding {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Gets the API request logging log files. Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </summary>
 	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5ApiRequestLogsResult</returns>
        public ApiRequestLogsResult ListRequestLogs (DiagnosticsApi.ListRequestLogsOptions options = null)
        {
             ApiResponse<ApiRequestLogsResult> response = ListRequestLogsWithHttpInfo(options);
             return response.Data;
        }

        /// <summary>
        /// Gets the API request logging log files. Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </summary>
 	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of ApiRequestLogsResult</returns>
        public ApiResponse< ApiRequestLogsResult > ListRequestLogsWithHttpInfo (DiagnosticsApi.ListRequestLogsOptions options = null)
        {
            
    
            var path_ = "/v2/diagnostics/request_logs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
			
			if (options != null)
			{
				if (options.encoding != null) queryParams.Add("encoding", Configuration.ApiClient.ParameterToString(options.encoding)); // query parameter
				
			}

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListRequestLogs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListRequestLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<ApiRequestLogsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiRequestLogsResult) Configuration.ApiClient.Deserialize(response, typeof(ApiRequestLogsResult)));
            
        }
    
        /// <summary>
        /// Gets the API request logging log files. Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </summary>
 	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of ApiRequestLogsResult</returns>
        public async System.Threading.Tasks.Task<ApiRequestLogsResult> ListRequestLogsAsync (DiagnosticsApi.ListRequestLogsOptions options = null)
        {
             ApiResponse<ApiRequestLogsResult> response = await ListRequestLogsAsyncWithHttpInfo(options);
             return response.Data;

        }

        /// <summary>
        /// Gets the API request logging log files. Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.\n\nIf the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.\n\nIf the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below.
        /// </summary>
	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (ApiRequestLogsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiRequestLogsResult>> ListRequestLogsAsyncWithHttpInfo (DiagnosticsApi.ListRequestLogsOptions options = null)
        {
            
    
            var path_ = "/v2/diagnostics/request_logs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            

						
			if (options != null)
			{
				if (options.encoding != null) queryParams.Add("encoding", Configuration.ApiClient.ParameterToString(options.encoding)); // query parameter
				
			}
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListRequestLogs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListRequestLogs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<ApiRequestLogsResult>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiRequestLogsResult) Configuration.ApiClient.Deserialize(response, typeof(ApiRequestLogsResult)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes the request log files. Deletes the request log files.
        /// </summary>
 	    ///
		/// <returns>5</returns>
        public void DeleteRequestLogs ()
        {
             DeleteRequestLogsWithHttpInfo();
        }

        /// <summary>
        /// Deletes the request log files. Deletes the request log files.
        /// </summary>
 	    ///
		/// <returns>6ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRequestLogsWithHttpInfo ()
        {
            
    
            var path_ = "/v2/diagnostics/request_logs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRequestLogs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRequestLogs: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Deletes the request log files. Deletes the request log files.
        /// </summary>
 	    ///
		/// <returns>7Task of void</returns>
        public async System.Threading.Tasks.Task DeleteRequestLogsAsync ()
        {
             await DeleteRequestLogsAsyncWithHttpInfo();

        }

        /// <summary>
        /// Deletes the request log files. Deletes the request log files.
        /// </summary>
	    ///
		/// <returns>8Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteRequestLogsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/v2/diagnostics/request_logs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteRequestLogs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteRequestLogs: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets a request logging log file. Retrieves information for a single log entry.\n\n**Request**\nThe `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.\n\n**Response**\nIf the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.
        /// </summary>
 	    ///<param name="requestLogId"></param>
		/// <returns>5Stream</returns>
        public Stream GetRequestLog (string requestLogId)
        {
             ApiResponse<Stream> response = GetRequestLogWithHttpInfo(requestLogId);
             return response.Data;
        }

        /// <summary>
        /// Gets a request logging log file. Retrieves information for a single log entry.\n\n**Request**\nThe `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.\n\n**Response**\nIf the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.
        /// </summary>
 	    ///<param name="requestLogId"></param>
		/// <returns>6ApiResponse of Stream</returns>
        public ApiResponse< Stream > GetRequestLogWithHttpInfo (string requestLogId)
        {
            
            // verify the required parameter 'requestLogId' is set
            if (requestLogId == null) throw new ApiException(400, "Missing required parameter 'requestLogId' when calling GetRequestLog");
            
    
            var path_ = "/v2/diagnostics/request_logs/{requestLogId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/plain"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (requestLogId != null) pathParams.Add("requestLogId", Configuration.ApiClient.ParameterToString(requestLogId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRequestLog: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRequestLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
    
        /// <summary>
        /// Gets a request logging log file. Retrieves information for a single log entry.\n\n**Request**\nThe `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.\n\n**Response**\nIf the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.
        /// </summary>
 	    ///<param name="requestLogId"></param>
		/// <returns>7Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> GetRequestLogAsync (string requestLogId)
        {
             ApiResponse<Stream> response = await GetRequestLogAsyncWithHttpInfo(requestLogId);
             return response.Data;

        }

        /// <summary>
        /// Gets a request logging log file. Retrieves information for a single log entry.\n\n**Request**\nThe `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.\n\n**Response**\nIf the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.
        /// </summary>
	    ///<param name="requestLogId"></param>
		/// <returns>8Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> GetRequestLogAsyncWithHttpInfo (string requestLogId)
        {
            // verify the required parameter 'requestLogId' is set
            if (requestLogId == null) throw new ApiException(400, "Missing required parameter 'requestLogId' when calling GetRequestLog");
            
    
            var path_ = "/v2/diagnostics/request_logs/{requestLogId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/plain"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (requestLogId != null) pathParams.Add("requestLogId", Configuration.ApiClient.ParameterToString(requestLogId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRequestLog: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRequestLog: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets the API request logging settings. Retrieves the current API request logging setting for the user and remaining log entries.\n\n**Response**\nThe response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.
        /// </summary>
 	    ///
		/// <returns>5DiagnosticsSettingsInformation</returns>
        public DiagnosticsSettingsInformation GetRequestLogSettings ()
        {
             ApiResponse<DiagnosticsSettingsInformation> response = GetRequestLogSettingsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Gets the API request logging settings. Retrieves the current API request logging setting for the user and remaining log entries.\n\n**Response**\nThe response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.
        /// </summary>
 	    ///
		/// <returns>6ApiResponse of DiagnosticsSettingsInformation</returns>
        public ApiResponse< DiagnosticsSettingsInformation > GetRequestLogSettingsWithHttpInfo ()
        {
            
    
            var path_ = "/v2/diagnostics/settings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRequestLogSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRequestLogSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DiagnosticsSettingsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DiagnosticsSettingsInformation) Configuration.ApiClient.Deserialize(response, typeof(DiagnosticsSettingsInformation)));
            
        }
    
        /// <summary>
        /// Gets the API request logging settings. Retrieves the current API request logging setting for the user and remaining log entries.\n\n**Response**\nThe response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.
        /// </summary>
 	    ///
		/// <returns>7Task of DiagnosticsSettingsInformation</returns>
        public async System.Threading.Tasks.Task<DiagnosticsSettingsInformation> GetRequestLogSettingsAsync ()
        {
             ApiResponse<DiagnosticsSettingsInformation> response = await GetRequestLogSettingsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Gets the API request logging settings. Retrieves the current API request logging setting for the user and remaining log entries.\n\n**Response**\nThe response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.
        /// </summary>
	    ///
		/// <returns>8Task of ApiResponse (DiagnosticsSettingsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DiagnosticsSettingsInformation>> GetRequestLogSettingsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/v2/diagnostics/settings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetRequestLogSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetRequestLogSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DiagnosticsSettingsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DiagnosticsSettingsInformation) Configuration.ApiClient.Deserialize(response, typeof(DiagnosticsSettingsInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Enables or disables API request logging for troubleshooting. Enables or disables API request logging for troubleshooting.\n\nWhen enabled (apiRequestLogging is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.\n\nYou can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.\n\nPrivate information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.\n\n### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn&#39;t logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged.
        /// </summary>
 	    /// <param name="diagnosticsSettingsInformation">TBD Description</param>
		/// <returns>5DiagnosticsSettingsInformation</returns>
        public DiagnosticsSettingsInformation UpdateRequestLogSettings (DiagnosticsSettingsInformation diagnosticsSettingsInformation)
        {
             ApiResponse<DiagnosticsSettingsInformation> response = UpdateRequestLogSettingsWithHttpInfo(diagnosticsSettingsInformation);
             return response.Data;
        }

        /// <summary>
        /// Enables or disables API request logging for troubleshooting. Enables or disables API request logging for troubleshooting.\n\nWhen enabled (apiRequestLogging is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.\n\nYou can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.\n\nPrivate information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.\n\n### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn&#39;t logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged.
        /// </summary>
 	    /// <param name="diagnosticsSettingsInformation">TBD Description</param>
		/// <returns>6ApiResponse of DiagnosticsSettingsInformation</returns>
        public ApiResponse< DiagnosticsSettingsInformation > UpdateRequestLogSettingsWithHttpInfo (DiagnosticsSettingsInformation diagnosticsSettingsInformation)
        {
            
    
            var path_ = "/v2/diagnostics/settings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(diagnosticsSettingsInformation); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateRequestLogSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRequestLogSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<DiagnosticsSettingsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DiagnosticsSettingsInformation) Configuration.ApiClient.Deserialize(response, typeof(DiagnosticsSettingsInformation)));
            
        }
    
        /// <summary>
        /// Enables or disables API request logging for troubleshooting. Enables or disables API request logging for troubleshooting.\n\nWhen enabled (apiRequestLogging is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.\n\nYou can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.\n\nPrivate information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.\n\n### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn&#39;t logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged.
        /// </summary>
 	    /// <param name="diagnosticsSettingsInformation">TBD Description</param>
		/// <returns>7Task of DiagnosticsSettingsInformation</returns>
        public async System.Threading.Tasks.Task<DiagnosticsSettingsInformation> UpdateRequestLogSettingsAsync (DiagnosticsSettingsInformation diagnosticsSettingsInformation)
        {
             ApiResponse<DiagnosticsSettingsInformation> response = await UpdateRequestLogSettingsAsyncWithHttpInfo(diagnosticsSettingsInformation);
             return response.Data;

        }

        /// <summary>
        /// Enables or disables API request logging for troubleshooting. Enables or disables API request logging for troubleshooting.\n\nWhen enabled (apiRequestLogging is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.\n\nYou can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.\n\nPrivate information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.\n\n### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn&#39;t logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged.
        /// </summary>
	    /// <param name="diagnosticsSettingsInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse (DiagnosticsSettingsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DiagnosticsSettingsInformation>> UpdateRequestLogSettingsAsyncWithHttpInfo (DiagnosticsSettingsInformation diagnosticsSettingsInformation)
        {
            
    
            var path_ = "/v2/diagnostics/settings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(diagnosticsSettingsInformation); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateRequestLogSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateRequestLogSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<DiagnosticsSettingsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DiagnosticsSettingsInformation) Configuration.ApiClient.Deserialize(response, typeof(DiagnosticsSettingsInformation)));
            
        }
        
    }
    
}
