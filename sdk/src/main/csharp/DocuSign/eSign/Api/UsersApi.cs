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
    public interface IUsersApi
    {
        
        /// <summary>
        /// Gets the user account settings for a specified user.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the account settings and email notification information for the specified user.\n\nThe response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="userId">The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.</param>
		/// <returns>1UserSettingsInformation</returns>
        UserSettingsInformation GetSettings (string accountId, string userId);
 
		/// <summary>
        /// Gets the user account settings for a specified user.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the account settings and email notification information for the specified user.\n\nThe response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="userId">The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.</param>
		/// <returns>2ApiResponse of UserSettingsInformation</returns>
        ApiResponse<UserSettingsInformation> GetSettingsWithHttpInfo (string accountId, string userId);

        /// <summary>
        /// Gets the user account settings for a specified user.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the account settings and email notification information for the specified user.\n\nThe response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="userId">The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.</param>
		/// <returns>3Task of UserSettingsInformation</returns>
        System.Threading.Tasks.Task<UserSettingsInformation> GetSettingsAsync (string accountId, string userId);

        /// <summary>
        /// Gets the user account settings for a specified user.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the account settings and email notification information for the specified user.\n\nThe response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="userId">The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.</param>
		/// <returns>4Task of ApiResponse (UserSettingsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserSettingsInformation>> GetSettingsAsyncWithHttpInfo (string accountId, string userId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
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
        /// Gets the user account settings for a specified user. Retrieves a list of the account settings and email notification information for the specified user.\n\nThe response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="userId">The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.</param>
		/// <returns>5UserSettingsInformation</returns>
        public UserSettingsInformation GetSettings (string accountId, string userId)
        {
             ApiResponse<UserSettingsInformation> response = GetSettingsWithHttpInfo(accountId, userId);
             return response.Data;
        }

        /// <summary>
        /// Gets the user account settings for a specified user. Retrieves a list of the account settings and email notification information for the specified user.\n\nThe response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="userId">The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.</param>
		/// <returns>6ApiResponse of UserSettingsInformation</returns>
        public ApiResponse< UserSettingsInformation > GetSettingsWithHttpInfo (string accountId, string userId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetSettings");
            
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/users/{userId}/settings";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserSettingsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSettingsInformation) Configuration.ApiClient.Deserialize(response, typeof(UserSettingsInformation)));
            
        }
    
        /// <summary>
        /// Gets the user account settings for a specified user. Retrieves a list of the account settings and email notification information for the specified user.\n\nThe response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="userId">The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.</param>
		/// <returns>7Task of UserSettingsInformation</returns>
        public async System.Threading.Tasks.Task<UserSettingsInformation> GetSettingsAsync (string accountId, string userId)
        {
             ApiResponse<UserSettingsInformation> response = await GetSettingsAsyncWithHttpInfo(accountId, userId);
             return response.Data;

        }

        /// <summary>
        /// Gets the user account settings for a specified user. Retrieves a list of the account settings and email notification information for the specified user.\n\nThe response returns the account setting name/value information and the email notification settings for the specified user. For more information about the different user settings, see the [ML:userSettings list].
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="userId">The user ID of the user being accessed. Generally this is the user ID of the authenticated user, but if the authenticated user is an Admin on the account, this may be another user the Admin user is accessing.</param>
		/// <returns>8Task of ApiResponse (UserSettingsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserSettingsInformation>> GetSettingsAsyncWithHttpInfo (string accountId, string userId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetSettings");
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/users/{userId}/settings";
    
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
            if (accountId != null) pathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (userId != null) pathParams.Add("userId", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserSettingsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSettingsInformation) Configuration.ApiClient.Deserialize(response, typeof(UserSettingsInformation)));
            
        }
        
    }
    
}
