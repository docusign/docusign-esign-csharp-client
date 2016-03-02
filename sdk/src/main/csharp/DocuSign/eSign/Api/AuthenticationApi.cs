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
    public interface IAuthenticationApi
    {
        
        /// <summary>
        /// Gets login information for a specified user.
        /// </summary>
        /// <remarks>
        /// Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </remarks>
		
	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1LoginInformation</returns>
        LoginInformation Login (AuthenticationApi.LoginOptions options = null);
 
		/// <summary>
        /// Gets login information for a specified user.
        /// </summary>
        /// <remarks>
        /// Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </remarks>
 	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of LoginInformation</returns>
        ApiResponse<LoginInformation> LoginWithHttpInfo (AuthenticationApi.LoginOptions options = null);

        /// <summary>
        /// Gets login information for a specified user.
        /// </summary>
        /// <remarks>
        /// Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </remarks>
	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of LoginInformation</returns>
        System.Threading.Tasks.Task<LoginInformation> LoginAsync (AuthenticationApi.LoginOptions options = null);

        /// <summary>
        /// Gets login information for a specified user.
        /// </summary>
        /// <remarks>
        /// Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </remarks>
	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (LoginInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoginInformation>> LoginAsyncWithHttpInfo (AuthenticationApi.LoginOptions options = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticationApi : IAuthenticationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthenticationApi(Configuration configuration = null)
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
        /// Gets login information for a specified user. Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </summary>
		public class LoginOptions
		{
				
			/// Determines whether login settings are returned in the response.\n\nValid Values:\n\n* all -  All the login settings are returned. \n* none - no login settings are returned. 
			public string loginSettings {get; set;}
				
			/// When set to **true**, shows the account API password in the response. 
			public string apiPassword {get; set;}
				
			/// When set to **true**, shows the account ID GUID in the response. 
			public string includeAccountIdGuid {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Gets login information for a specified user. Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </summary>
 	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5LoginInformation</returns>
        public LoginInformation Login (AuthenticationApi.LoginOptions options = null)
        {
             ApiResponse<LoginInformation> response = LoginWithHttpInfo(options);
             return response.Data;
        }

        /// <summary>
        /// Gets login information for a specified user. Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </summary>
 	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of LoginInformation</returns>
        public ApiResponse< LoginInformation > LoginWithHttpInfo (AuthenticationApi.LoginOptions options = null)
        {
            
    
            var path_ = "/v2/login_information";
    
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
				if (options.loginSettings != null) queryParams.Add("login_settings", Configuration.ApiClient.ParameterToString(options.loginSettings)); // query parameter
				if (options.apiPassword != null) queryParams.Add("api_password", Configuration.ApiClient.ParameterToString(options.apiPassword)); // query parameter
				if (options.includeAccountIdGuid != null) queryParams.Add("include_account_id_guid", Configuration.ApiClient.ParameterToString(options.includeAccountIdGuid)); // query parameter
				
			}

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Login: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Login: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<LoginInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoginInformation) Configuration.ApiClient.Deserialize(response, typeof(LoginInformation)));
            
        }
    
        /// <summary>
        /// Gets login information for a specified user. Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </summary>
 	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of LoginInformation</returns>
        public async System.Threading.Tasks.Task<LoginInformation> LoginAsync (AuthenticationApi.LoginOptions options = null)
        {
             ApiResponse<LoginInformation> response = await LoginAsyncWithHttpInfo(options);
             return response.Data;

        }

        /// <summary>
        /// Gets login information for a specified user. Retrieves login information for a specified user. Each account that is associated with the login credentials is listed. You can use the returned information to determine whether a user is authenticated and select an account to use in future operations.  \n\nThe `baseUrl` property, returned in the response, is used in all future API calls as the base of the request URL. The `baseUrl` property contains the DocuSign server, the API version, and the `accountId` property that is used for the login. This request uses your DocuSign credentials to retrieve the account information.
        /// </summary>
	    /// <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (LoginInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoginInformation>> LoginAsyncWithHttpInfo (AuthenticationApi.LoginOptions options = null)
        {
            
    
            var path_ = "/v2/login_information";
    
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
				if (options.loginSettings != null) queryParams.Add("login_settings", Configuration.ApiClient.ParameterToString(options.loginSettings)); // query parameter
				if (options.apiPassword != null) queryParams.Add("api_password", Configuration.ApiClient.ParameterToString(options.apiPassword)); // query parameter
				if (options.includeAccountIdGuid != null) queryParams.Add("include_account_id_guid", Configuration.ApiClient.ParameterToString(options.includeAccountIdGuid)); // query parameter
				
			}
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Login: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Login: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<LoginInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LoginInformation) Configuration.ApiClient.Deserialize(response, typeof(LoginInformation)));
            
        }
        
    }
    
}
