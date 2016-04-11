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
    public interface ICustomTabsApi
    {
        
        /// <summary>
        /// Gets a list of all account tabs.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all tabs associated with the account.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1TabMetadataList</returns>
        TabMetadataList List (string accountId, CustomTabsApi.ListOptions options = null);
 
		/// <summary>
        /// Gets a list of all account tabs.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all tabs associated with the account.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of TabMetadataList</returns>
        ApiResponse<TabMetadataList> ListWithHttpInfo (string accountId, CustomTabsApi.ListOptions options = null);

        /// <summary>
        /// Gets a list of all account tabs.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all tabs associated with the account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of TabMetadataList</returns>
        System.Threading.Tasks.Task<TabMetadataList> ListAsync (string accountId, CustomTabsApi.ListOptions options = null);

        /// <summary>
        /// Gets a list of all account tabs.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of all tabs associated with the account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (TabMetadataList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TabMetadataList>> ListAsyncWithHttpInfo (string accountId, CustomTabsApi.ListOptions options = null);
        
        /// <summary>
        /// Creates a custom tab.
        /// </summary>
        /// <remarks>
        /// Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.\n\nCustom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="tabMetadata">TBD Description</param>
		/// <returns>1TabMetadata</returns>
        TabMetadata Create (string accountId, TabMetadata tabMetadata);
 
		/// <summary>
        /// Creates a custom tab.
        /// </summary>
        /// <remarks>
        /// Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.\n\nCustom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="tabMetadata">TBD Description</param>
		/// <returns>2ApiResponse of TabMetadata</returns>
        ApiResponse<TabMetadata> CreateWithHttpInfo (string accountId, TabMetadata tabMetadata);

        /// <summary>
        /// Creates a custom tab.
        /// </summary>
        /// <remarks>
        /// Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.\n\nCustom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="tabMetadata">TBD Description</param>
		/// <returns>3Task of TabMetadata</returns>
        System.Threading.Tasks.Task<TabMetadata> CreateAsync (string accountId, TabMetadata tabMetadata);

        /// <summary>
        /// Creates a custom tab.
        /// </summary>
        /// <remarks>
        /// Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.\n\nCustom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="tabMetadata">TBD Description</param>
		/// <returns>4Task of ApiResponse (TabMetadata)</returns>
        System.Threading.Tasks.Task<ApiResponse<TabMetadata>> CreateAsyncWithHttpInfo (string accountId, TabMetadata tabMetadata);
        
        /// <summary>
        /// Gets custom tab information.
        /// </summary>
        /// <remarks>
        /// Retrieves information about the requested custom tab on the specified account.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>1TabMetadata</returns>
        TabMetadata Get (string accountId, string customTabId);
 
		/// <summary>
        /// Gets custom tab information.
        /// </summary>
        /// <remarks>
        /// Retrieves information about the requested custom tab on the specified account.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>2ApiResponse of TabMetadata</returns>
        ApiResponse<TabMetadata> GetWithHttpInfo (string accountId, string customTabId);

        /// <summary>
        /// Gets custom tab information.
        /// </summary>
        /// <remarks>
        /// Retrieves information about the requested custom tab on the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>3Task of TabMetadata</returns>
        System.Threading.Tasks.Task<TabMetadata> GetAsync (string accountId, string customTabId);

        /// <summary>
        /// Gets custom tab information.
        /// </summary>
        /// <remarks>
        /// Retrieves information about the requested custom tab on the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>4Task of ApiResponse (TabMetadata)</returns>
        System.Threading.Tasks.Task<ApiResponse<TabMetadata>> GetAsyncWithHttpInfo (string accountId, string customTabId);
        
        /// <summary>
        /// Updates custom tab information.
        /// </summary>
        /// <remarks>
        /// Updates the information in a custom tab for the specified account.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param> <param name="tabMetadata">TBD Description</param>
		/// <returns>1TabMetadata</returns>
        TabMetadata Update (string accountId, string customTabId, TabMetadata tabMetadata);
 
		/// <summary>
        /// Updates custom tab information.
        /// </summary>
        /// <remarks>
        /// Updates the information in a custom tab for the specified account.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param> <param name="tabMetadata">TBD Description</param>
		/// <returns>2ApiResponse of TabMetadata</returns>
        ApiResponse<TabMetadata> UpdateWithHttpInfo (string accountId, string customTabId, TabMetadata tabMetadata);

        /// <summary>
        /// Updates custom tab information.
        /// </summary>
        /// <remarks>
        /// Updates the information in a custom tab for the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param> <param name="tabMetadata">TBD Description</param>
		/// <returns>3Task of TabMetadata</returns>
        System.Threading.Tasks.Task<TabMetadata> UpdateAsync (string accountId, string customTabId, TabMetadata tabMetadata);

        /// <summary>
        /// Updates custom tab information.
        /// </summary>
        /// <remarks>
        /// Updates the information in a custom tab for the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param> <param name="tabMetadata">TBD Description</param>
		/// <returns>4Task of ApiResponse (TabMetadata)</returns>
        System.Threading.Tasks.Task<ApiResponse<TabMetadata>> UpdateAsyncWithHttpInfo (string accountId, string customTabId, TabMetadata tabMetadata);
        
        /// <summary>
        /// Deletes custom tab information.
        /// </summary>
        /// <remarks>
        /// Deletes the custom from the specified account.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>1</returns>
        void Delete (string accountId, string customTabId);
 
		/// <summary>
        /// Deletes custom tab information.
        /// </summary>
        /// <remarks>
        /// Deletes the custom from the specified account.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>2ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo (string accountId, string customTabId);

        /// <summary>
        /// Deletes custom tab information.
        /// </summary>
        /// <remarks>
        /// Deletes the custom from the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>3Task of void</returns>
        System.Threading.Tasks.Task DeleteAsync (string accountId, string customTabId);

        /// <summary>
        /// Deletes custom tab information.
        /// </summary>
        /// <remarks>
        /// Deletes the custom from the specified account.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>4Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (string accountId, string customTabId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomTabsApi : ICustomTabsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTabsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomTabsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTabsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomTabsApi(Configuration configuration = null)
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
        /// Gets a list of all account tabs. Retrieves a list of all tabs associated with the account.
        /// </summary>
		public class ListOptions
		{
				
			/// When set to **true**, only custom tabs are returned in the response. 
			public string customTabOnly {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Gets a list of all account tabs. Retrieves a list of all tabs associated with the account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5TabMetadataList</returns>
        public TabMetadataList List (string accountId, CustomTabsApi.ListOptions options = null)
        {
             ApiResponse<TabMetadataList> response = ListWithHttpInfo(accountId, options);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of all account tabs. Retrieves a list of all tabs associated with the account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of TabMetadataList</returns>
        public ApiResponse< TabMetadataList > ListWithHttpInfo (string accountId, CustomTabsApi.ListOptions options = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling List");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions";
    
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
				if (options.customTabOnly != null) queryParams.Add("custom_tab_only", Configuration.ApiClient.ParameterToString(options.customTabOnly)); // query parameter
				
			}

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling List: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling List: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TabMetadataList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TabMetadataList) Configuration.ApiClient.Deserialize(response, typeof(TabMetadataList)));
            
        }
    
        /// <summary>
        /// Gets a list of all account tabs. Retrieves a list of all tabs associated with the account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of TabMetadataList</returns>
        public async System.Threading.Tasks.Task<TabMetadataList> ListAsync (string accountId, CustomTabsApi.ListOptions options = null)
        {
             ApiResponse<TabMetadataList> response = await ListAsyncWithHttpInfo(accountId, options);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of all account tabs. Retrieves a list of all tabs associated with the account.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (TabMetadataList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TabMetadataList>> ListAsyncWithHttpInfo (string accountId, CustomTabsApi.ListOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling List");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions";
    
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
				if (options.customTabOnly != null) queryParams.Add("custom_tab_only", Configuration.ApiClient.ParameterToString(options.customTabOnly)); // query parameter
				
			}
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling List: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling List: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TabMetadataList>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TabMetadataList) Configuration.ApiClient.Deserialize(response, typeof(TabMetadataList)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Creates a custom tab. Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.\n\nCustom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="tabMetadata">TBD Description</param>
		/// <returns>5TabMetadata</returns>
        public TabMetadata Create (string accountId, TabMetadata tabMetadata)
        {
             ApiResponse<TabMetadata> response = CreateWithHttpInfo(accountId, tabMetadata);
             return response.Data;
        }

        /// <summary>
        /// Creates a custom tab. Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.\n\nCustom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="tabMetadata">TBD Description</param>
		/// <returns>6ApiResponse of TabMetadata</returns>
        public ApiResponse< TabMetadata > CreateWithHttpInfo (string accountId, TabMetadata tabMetadata)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Create");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions";
    
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
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabMetadata); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TabMetadata>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TabMetadata) Configuration.ApiClient.Deserialize(response, typeof(TabMetadata)));
            
        }
    
        /// <summary>
        /// Creates a custom tab. Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.\n\nCustom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="tabMetadata">TBD Description</param>
		/// <returns>7Task of TabMetadata</returns>
        public async System.Threading.Tasks.Task<TabMetadata> CreateAsync (string accountId, TabMetadata tabMetadata)
        {
             ApiResponse<TabMetadata> response = await CreateAsyncWithHttpInfo(accountId, tabMetadata);
             return response.Data;

        }

        /// <summary>
        /// Creates a custom tab. Creates a tab with pre-defined properties, such as a text tab with a certain font type and validation pattern. Users can access the custom tabs when sending documents through the DocuSign web application.\n\nCustom tabs can be created for approve, checkbox, company, date, date signed, decline, email, email address, envelope ID, first name, formula, full name, initial here, last name, list, note, number, radio, sign here, signer attachment, SSN, text, title, and zip tabs.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param> <param name="tabMetadata">TBD Description</param>
		/// <returns>8Task of ApiResponse (TabMetadata)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TabMetadata>> CreateAsyncWithHttpInfo (string accountId, TabMetadata tabMetadata)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Create");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions";
    
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
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabMetadata); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Create: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TabMetadata>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TabMetadata) Configuration.ApiClient.Deserialize(response, typeof(TabMetadata)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets custom tab information. Retrieves information about the requested custom tab on the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>5TabMetadata</returns>
        public TabMetadata Get (string accountId, string customTabId)
        {
             ApiResponse<TabMetadata> response = GetWithHttpInfo(accountId, customTabId);
             return response.Data;
        }

        /// <summary>
        /// Gets custom tab information. Retrieves information about the requested custom tab on the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>6ApiResponse of TabMetadata</returns>
        public ApiResponse< TabMetadata > GetWithHttpInfo (string accountId, string customTabId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Get");
            
            // verify the required parameter 'customTabId' is set
            if (customTabId == null) throw new ApiException(400, "Missing required parameter 'customTabId' when calling Get");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions/{customTabId}";
    
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
            if (customTabId != null) pathParams.Add("customTabId", Configuration.ApiClient.ParameterToString(customTabId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TabMetadata>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TabMetadata) Configuration.ApiClient.Deserialize(response, typeof(TabMetadata)));
            
        }
    
        /// <summary>
        /// Gets custom tab information. Retrieves information about the requested custom tab on the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>7Task of TabMetadata</returns>
        public async System.Threading.Tasks.Task<TabMetadata> GetAsync (string accountId, string customTabId)
        {
             ApiResponse<TabMetadata> response = await GetAsyncWithHttpInfo(accountId, customTabId);
             return response.Data;

        }

        /// <summary>
        /// Gets custom tab information. Retrieves information about the requested custom tab on the specified account.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>8Task of ApiResponse (TabMetadata)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TabMetadata>> GetAsyncWithHttpInfo (string accountId, string customTabId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Get");
            // verify the required parameter 'customTabId' is set
            if (customTabId == null) throw new ApiException(400, "Missing required parameter 'customTabId' when calling Get");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions/{customTabId}";
    
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
            if (customTabId != null) pathParams.Add("customTabId", Configuration.ApiClient.ParameterToString(customTabId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Get: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Get: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TabMetadata>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TabMetadata) Configuration.ApiClient.Deserialize(response, typeof(TabMetadata)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Updates custom tab information. Updates the information in a custom tab for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param> <param name="tabMetadata">TBD Description</param>
		/// <returns>5TabMetadata</returns>
        public TabMetadata Update (string accountId, string customTabId, TabMetadata tabMetadata)
        {
             ApiResponse<TabMetadata> response = UpdateWithHttpInfo(accountId, customTabId, tabMetadata);
             return response.Data;
        }

        /// <summary>
        /// Updates custom tab information. Updates the information in a custom tab for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param> <param name="tabMetadata">TBD Description</param>
		/// <returns>6ApiResponse of TabMetadata</returns>
        public ApiResponse< TabMetadata > UpdateWithHttpInfo (string accountId, string customTabId, TabMetadata tabMetadata)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Update");
            
            // verify the required parameter 'customTabId' is set
            if (customTabId == null) throw new ApiException(400, "Missing required parameter 'customTabId' when calling Update");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions/{customTabId}";
    
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
            if (customTabId != null) pathParams.Add("customTabId", Configuration.ApiClient.ParameterToString(customTabId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabMetadata); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TabMetadata>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TabMetadata) Configuration.ApiClient.Deserialize(response, typeof(TabMetadata)));
            
        }
    
        /// <summary>
        /// Updates custom tab information. Updates the information in a custom tab for the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param> <param name="tabMetadata">TBD Description</param>
		/// <returns>7Task of TabMetadata</returns>
        public async System.Threading.Tasks.Task<TabMetadata> UpdateAsync (string accountId, string customTabId, TabMetadata tabMetadata)
        {
             ApiResponse<TabMetadata> response = await UpdateAsyncWithHttpInfo(accountId, customTabId, tabMetadata);
             return response.Data;

        }

        /// <summary>
        /// Updates custom tab information. Updates the information in a custom tab for the specified account.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param> <param name="tabMetadata">TBD Description</param>
		/// <returns>8Task of ApiResponse (TabMetadata)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TabMetadata>> UpdateAsyncWithHttpInfo (string accountId, string customTabId, TabMetadata tabMetadata)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Update");
            // verify the required parameter 'customTabId' is set
            if (customTabId == null) throw new ApiException(400, "Missing required parameter 'customTabId' when calling Update");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions/{customTabId}";
    
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
            if (customTabId != null) pathParams.Add("customTabId", Configuration.ApiClient.ParameterToString(customTabId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(tabMetadata); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Update: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TabMetadata>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TabMetadata) Configuration.ApiClient.Deserialize(response, typeof(TabMetadata)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Deletes custom tab information. Deletes the custom from the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>5</returns>
        public void Delete (string accountId, string customTabId)
        {
             DeleteWithHttpInfo(accountId, customTabId);
        }

        /// <summary>
        /// Deletes custom tab information. Deletes the custom from the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>6ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (string accountId, string customTabId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Delete");
            
            // verify the required parameter 'customTabId' is set
            if (customTabId == null) throw new ApiException(400, "Missing required parameter 'customTabId' when calling Delete");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions/{customTabId}";
    
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
            if (customTabId != null) pathParams.Add("customTabId", Configuration.ApiClient.ParameterToString(customTabId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Deletes custom tab information. Deletes the custom from the specified account.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>7Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAsync (string accountId, string customTabId)
        {
             await DeleteAsyncWithHttpInfo(accountId, customTabId);

        }

        /// <summary>
        /// Deletes custom tab information. Deletes the custom from the specified account.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="customTabId"></param>
		/// <returns>8Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (string accountId, string customTabId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Delete");
            // verify the required parameter 'customTabId' is set
            if (customTabId == null) throw new ApiException(400, "Missing required parameter 'customTabId' when calling Delete");
            
    
            var path_ = "/v2/accounts/{accountId}/tab_definitions/{customTabId}";
    
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
            if (customTabId != null) pathParams.Add("customTabId", Configuration.ApiClient.ParameterToString(customTabId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
