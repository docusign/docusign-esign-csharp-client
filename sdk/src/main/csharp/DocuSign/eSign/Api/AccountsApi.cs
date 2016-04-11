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
    public interface IAccountsApi
    {
        
        /// <summary>
        /// Retrieves the account information for the specified account.
        /// </summary>
        /// <remarks>
        /// Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1AccountInformation</returns>
        AccountInformation GetAccountInformation (string accountId, AccountsApi.GetAccountInformationOptions options = null);
 
		/// <summary>
        /// Retrieves the account information for the specified account.
        /// </summary>
        /// <remarks>
        /// Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of AccountInformation</returns>
        ApiResponse<AccountInformation> GetAccountInformationWithHttpInfo (string accountId, AccountsApi.GetAccountInformationOptions options = null);

        /// <summary>
        /// Retrieves the account information for the specified account.
        /// </summary>
        /// <remarks>
        /// Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of AccountInformation</returns>
        System.Threading.Tasks.Task<AccountInformation> GetAccountInformationAsync (string accountId, AccountsApi.GetAccountInformationOptions options = null);

        /// <summary>
        /// Retrieves the account information for the specified account.
        /// </summary>
        /// <remarks>
        /// Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (AccountInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountInformation>> GetAccountInformationAsyncWithHttpInfo (string accountId, AccountsApi.GetAccountInformationOptions options = null);
        
        /// <summary>
        /// Gets a list of custom fields associated with the account.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>1CustomFields</returns>
        CustomFields ListCustomFields (string accountId);
 
		/// <summary>
        /// Gets a list of custom fields associated with the account.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>2ApiResponse of CustomFields</returns>
        ApiResponse<CustomFields> ListCustomFieldsWithHttpInfo (string accountId);

        /// <summary>
        /// Gets a list of custom fields associated with the account.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>3Task of CustomFields</returns>
        System.Threading.Tasks.Task<CustomFields> ListCustomFieldsAsync (string accountId);

        /// <summary>
        /// Gets a list of custom fields associated with the account.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>4Task of ApiResponse (CustomFields)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFields>> ListCustomFieldsAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Gets account settings information.
        /// </summary>
        /// <remarks>
        /// Retrieves the account settings information for the specified account.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>1AccountSettingsInformation</returns>
        AccountSettingsInformation ListSettings (string accountId);
 
		/// <summary>
        /// Gets account settings information.
        /// </summary>
        /// <remarks>
        /// Retrieves the account settings information for the specified account.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>2ApiResponse of AccountSettingsInformation</returns>
        ApiResponse<AccountSettingsInformation> ListSettingsWithHttpInfo (string accountId);

        /// <summary>
        /// Gets account settings information.
        /// </summary>
        /// <remarks>
        /// Retrieves the account settings information for the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>3Task of AccountSettingsInformation</returns>
        System.Threading.Tasks.Task<AccountSettingsInformation> ListSettingsAsync (string accountId);

        /// <summary>
        /// Gets account settings information.
        /// </summary>
        /// <remarks>
        /// Retrieves the account settings information for the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>4Task of ApiResponse (AccountSettingsInformation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountSettingsInformation>> ListSettingsAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Updates the account settings for an account.
        /// </summary>
        /// <remarks>
        /// Updates the account settings for the specified account.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="accountSettingsInformation">TBD Description</param>
		/// <returns>1</returns>
        void UpdateSettings (string accountId, AccountSettingsInformation accountSettingsInformation);
 
		/// <summary>
        /// Updates the account settings for an account.
        /// </summary>
        /// <remarks>
        /// Updates the account settings for the specified account.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="accountSettingsInformation">TBD Description</param>
		/// <returns>2ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateSettingsWithHttpInfo (string accountId, AccountSettingsInformation accountSettingsInformation);

        /// <summary>
        /// Updates the account settings for an account.
        /// </summary>
        /// <remarks>
        /// Updates the account settings for the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="accountSettingsInformation">TBD Description</param>
		/// <returns>3Task of void</returns>
        System.Threading.Tasks.Task UpdateSettingsAsync (string accountId, AccountSettingsInformation accountSettingsInformation);

        /// <summary>
        /// Updates the account settings for an account.
        /// </summary>
        /// <remarks>
        /// Updates the account settings for the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="accountSettingsInformation">TBD Description</param>
		/// <returns>4Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSettingsAsyncWithHttpInfo (string accountId, AccountSettingsInformation accountSettingsInformation);
        
        /// <summary>
        /// Reserved: Gets the shared item status for one or more users.
        /// </summary>
        /// <remarks>
        /// Reserved: Retrieves shared item status for one or more users and types of items.\n\nUsers with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>1AccountSharedAccess</returns>
        AccountSharedAccess ListSharedAccess (string accountId);
 
		/// <summary>
        /// Reserved: Gets the shared item status for one or more users.
        /// </summary>
        /// <remarks>
        /// Reserved: Retrieves shared item status for one or more users and types of items.\n\nUsers with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>2ApiResponse of AccountSharedAccess</returns>
        ApiResponse<AccountSharedAccess> ListSharedAccessWithHttpInfo (string accountId);

        /// <summary>
        /// Reserved: Gets the shared item status for one or more users.
        /// </summary>
        /// <remarks>
        /// Reserved: Retrieves shared item status for one or more users and types of items.\n\nUsers with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>3Task of AccountSharedAccess</returns>
        System.Threading.Tasks.Task<AccountSharedAccess> ListSharedAccessAsync (string accountId);

        /// <summary>
        /// Reserved: Gets the shared item status for one or more users.
        /// </summary>
        /// <remarks>
        /// Reserved: Retrieves shared item status for one or more users and types of items.\n\nUsers with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>4Task of ApiResponse (AccountSharedAccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountSharedAccess>> ListSharedAccessAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Gets a list of unsupported file types.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>1FileTypeList</returns>
        FileTypeList ListUnsupportedFileTypes (string accountId);
 
		/// <summary>
        /// Gets a list of unsupported file types.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>2ApiResponse of FileTypeList</returns>
        ApiResponse<FileTypeList> ListUnsupportedFileTypesWithHttpInfo (string accountId);

        /// <summary>
        /// Gets a list of unsupported file types.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>3Task of FileTypeList</returns>
        System.Threading.Tasks.Task<FileTypeList> ListUnsupportedFileTypesAsync (string accountId);

        /// <summary>
        /// Gets a list of unsupported file types.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>4Task of ApiResponse (FileTypeList)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileTypeList>> ListUnsupportedFileTypesAsyncWithHttpInfo (string accountId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountsApi : IAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(Configuration configuration = null)
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
        /// Retrieves the account information for the specified account. Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </summary>
		public class GetAccountInformationOptions
		{
				
			/// When set to **true**, includes the account settings for the account in the response. 
			public string includeAccountSettings {get; set;}
				
			/// 
			public string op {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Retrieves the account information for the specified account. Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5AccountInformation</returns>
        public AccountInformation GetAccountInformation (string accountId, AccountsApi.GetAccountInformationOptions options = null)
        {
             ApiResponse<AccountInformation> response = GetAccountInformationWithHttpInfo(accountId, options);
             return response.Data;
        }

        /// <summary>
        /// Retrieves the account information for the specified account. Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of AccountInformation</returns>
        public ApiResponse< AccountInformation > GetAccountInformationWithHttpInfo (string accountId, AccountsApi.GetAccountInformationOptions options = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccountInformation");
            
    
            var path_ = "/v2/accounts/{accountId}";
    
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
            
			
			if (options != null)
			{
				if (options.includeAccountSettings != null) queryParams.Add("include_account_settings", Configuration.ApiClient.ParameterToString(options.includeAccountSettings)); // query parameter
				if (options.op != null) queryParams.Add("op", Configuration.ApiClient.ParameterToString(options.op)); // query parameter
				
			}

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAccountInformation: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAccountInformation: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AccountInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountInformation) Configuration.ApiClient.Deserialize(response, typeof(AccountInformation)));
            
        }
    
        /// <summary>
        /// Retrieves the account information for the specified account. Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of AccountInformation</returns>
        public async System.Threading.Tasks.Task<AccountInformation> GetAccountInformationAsync (string accountId, AccountsApi.GetAccountInformationOptions options = null)
        {
             ApiResponse<AccountInformation> response = await GetAccountInformationAsyncWithHttpInfo(accountId, options);
             return response.Data;

        }

        /// <summary>
        /// Retrieves the account information for the specified account. Retrieves the account information for the specified account.\n\n**Response**\nThe `canUpgrade` property contains is a Boolean that indicates whether the account can be upgraded through the API.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (AccountInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountInformation>> GetAccountInformationAsyncWithHttpInfo (string accountId, AccountsApi.GetAccountInformationOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling GetAccountInformation");
            
    
            var path_ = "/v2/accounts/{accountId}";
    
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
            

						
			if (options != null)
			{
				if (options.includeAccountSettings != null) queryParams.Add("include_account_settings", Configuration.ApiClient.ParameterToString(options.includeAccountSettings)); // query parameter
				if (options.op != null) queryParams.Add("op", Configuration.ApiClient.ParameterToString(options.op)); // query parameter
				
			}
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAccountInformation: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAccountInformation: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AccountInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountInformation) Configuration.ApiClient.Deserialize(response, typeof(AccountInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets a list of custom fields associated with the account. Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>5CustomFields</returns>
        public CustomFields ListCustomFields (string accountId)
        {
             ApiResponse<CustomFields> response = ListCustomFieldsWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of custom fields associated with the account. Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>6ApiResponse of CustomFields</returns>
        public ApiResponse< CustomFields > ListCustomFieldsWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/custom_fields";
    
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
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
    
        /// <summary>
        /// Gets a list of custom fields associated with the account. Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>7Task of CustomFields</returns>
        public async System.Threading.Tasks.Task<CustomFields> ListCustomFieldsAsync (string accountId)
        {
             ApiResponse<CustomFields> response = await ListCustomFieldsAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of custom fields associated with the account. Retrieves a list of envelope custom fields associated with the account. You can use these fields in the envelopes for your account to record information about the envelope, help search for envelopes and track information. The envelope custom fields are shown in the Envelope Settings section when a user is creating an envelope in the DocuSign member console. The envelope custom fields are not seen by the envelope recipients.\n\nThere are two types of envelope custom fields, text, and list. A text custom field lets the sender enter the value for the field. The list custom field lets the sender select the value of the field from a list you provide.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>8Task of ApiResponse (CustomFields)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFields>> ListCustomFieldsAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListCustomFields");
            
    
            var path_ = "/v2/accounts/{accountId}/custom_fields";
    
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
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListCustomFields: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CustomFields>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFields) Configuration.ApiClient.Deserialize(response, typeof(CustomFields)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets account settings information. Retrieves the account settings information for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>5AccountSettingsInformation</returns>
        public AccountSettingsInformation ListSettings (string accountId)
        {
             ApiResponse<AccountSettingsInformation> response = ListSettingsWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Gets account settings information. Retrieves the account settings information for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>6ApiResponse of AccountSettingsInformation</returns>
        public ApiResponse< AccountSettingsInformation > ListSettingsWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/settings";
    
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
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AccountSettingsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountSettingsInformation) Configuration.ApiClient.Deserialize(response, typeof(AccountSettingsInformation)));
            
        }
    
        /// <summary>
        /// Gets account settings information. Retrieves the account settings information for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>7Task of AccountSettingsInformation</returns>
        public async System.Threading.Tasks.Task<AccountSettingsInformation> ListSettingsAsync (string accountId)
        {
             ApiResponse<AccountSettingsInformation> response = await ListSettingsAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Gets account settings information. Retrieves the account settings information for the specified account.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>8Task of ApiResponse (AccountSettingsInformation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountSettingsInformation>> ListSettingsAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/settings";
    
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
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListSettings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AccountSettingsInformation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountSettingsInformation) Configuration.ApiClient.Deserialize(response, typeof(AccountSettingsInformation)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates the account settings for an account. Updates the account settings for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="accountSettingsInformation">TBD Description</param>
		/// <returns>5</returns>
        public void UpdateSettings (string accountId, AccountSettingsInformation accountSettingsInformation)
        {
             UpdateSettingsWithHttpInfo(accountId, accountSettingsInformation);
        }

        /// <summary>
        /// Updates the account settings for an account. Updates the account settings for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="accountSettingsInformation">TBD Description</param>
		/// <returns>6ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateSettingsWithHttpInfo (string accountId, AccountSettingsInformation accountSettingsInformation)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/settings";
    
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
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(accountSettingsInformation); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Updates the account settings for an account. Updates the account settings for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="accountSettingsInformation">TBD Description</param>
		/// <returns>7Task of void</returns>
        public async System.Threading.Tasks.Task UpdateSettingsAsync (string accountId, AccountSettingsInformation accountSettingsInformation)
        {
             await UpdateSettingsAsyncWithHttpInfo(accountId, accountSettingsInformation);

        }

        /// <summary>
        /// Updates the account settings for an account. Updates the account settings for the specified account.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="accountSettingsInformation">TBD Description</param>
		/// <returns>8Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSettingsAsyncWithHttpInfo (string accountId, AccountSettingsInformation accountSettingsInformation)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling UpdateSettings");
            
    
            var path_ = "/v2/accounts/{accountId}/settings";
    
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
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(accountSettingsInformation); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateSettings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateSettings: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Reserved: Gets the shared item status for one or more users. Reserved: Retrieves shared item status for one or more users and types of items.\n\nUsers with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>5AccountSharedAccess</returns>
        public AccountSharedAccess ListSharedAccess (string accountId)
        {
             ApiResponse<AccountSharedAccess> response = ListSharedAccessWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Reserved: Gets the shared item status for one or more users. Reserved: Retrieves shared item status for one or more users and types of items.\n\nUsers with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>6ApiResponse of AccountSharedAccess</returns>
        public ApiResponse< AccountSharedAccess > ListSharedAccessWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListSharedAccess");
            
    
            var path_ = "/v2/accounts/{accountId}/shared_access";
    
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
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListSharedAccess: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListSharedAccess: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AccountSharedAccess>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountSharedAccess) Configuration.ApiClient.Deserialize(response, typeof(AccountSharedAccess)));
            
        }
    
        /// <summary>
        /// Reserved: Gets the shared item status for one or more users. Reserved: Retrieves shared item status for one or more users and types of items.\n\nUsers with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>7Task of AccountSharedAccess</returns>
        public async System.Threading.Tasks.Task<AccountSharedAccess> ListSharedAccessAsync (string accountId)
        {
             ApiResponse<AccountSharedAccess> response = await ListSharedAccessAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Reserved: Gets the shared item status for one or more users. Reserved: Retrieves shared item status for one or more users and types of items.\n\nUsers with account administration privileges can retrieve shared access information for all account users. Users without account administrator privileges can only retrieve shared access information for themselves and the returned information is limited to the retrieving the status of all members of the account that are sharing their folders to the user. This is equivalent to setting the shared=shared_from.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>8Task of ApiResponse (AccountSharedAccess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountSharedAccess>> ListSharedAccessAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListSharedAccess");
            
    
            var path_ = "/v2/accounts/{accountId}/shared_access";
    
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
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListSharedAccess: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListSharedAccess: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AccountSharedAccess>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountSharedAccess) Configuration.ApiClient.Deserialize(response, typeof(AccountSharedAccess)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets a list of unsupported file types. Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>5FileTypeList</returns>
        public FileTypeList ListUnsupportedFileTypes (string accountId)
        {
             ApiResponse<FileTypeList> response = ListUnsupportedFileTypesWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of unsupported file types. Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>6ApiResponse of FileTypeList</returns>
        public ApiResponse< FileTypeList > ListUnsupportedFileTypesWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListUnsupportedFileTypes");
            
    
            var path_ = "/v2/accounts/{accountId}/unsupported_file_types";
    
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
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListUnsupportedFileTypes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListUnsupportedFileTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FileTypeList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FileTypeList) Configuration.ApiClient.Deserialize(response, typeof(FileTypeList)));
            
        }
    
        /// <summary>
        /// Gets a list of unsupported file types. Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>7Task of FileTypeList</returns>
        public async System.Threading.Tasks.Task<FileTypeList> ListUnsupportedFileTypesAsync (string accountId)
        {
             ApiResponse<FileTypeList> response = await ListUnsupportedFileTypesAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of unsupported file types. Retrieves a list of file types (mime-types and file-extensions) that are not supported for upload through the DocuSign system.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>8Task of ApiResponse (FileTypeList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileTypeList>> ListUnsupportedFileTypesAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListUnsupportedFileTypes");
            
    
            var path_ = "/v2/accounts/{accountId}/unsupported_file_types";
    
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
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListUnsupportedFileTypes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListUnsupportedFileTypes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FileTypeList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FileTypeList) Configuration.ApiClient.Deserialize(response, typeof(FileTypeList)));
            
        }
        
    }
    
}
