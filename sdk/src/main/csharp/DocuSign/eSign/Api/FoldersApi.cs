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
    public interface IFoldersApi
    {
        
        /// <summary>
        /// Gets a list of the folders for the account.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>1FoldersResponse</returns>
        FoldersResponse List (string accountId);
 
		/// <summary>
        /// Gets a list of the folders for the account.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>2ApiResponse of FoldersResponse</returns>
        ApiResponse<FoldersResponse> ListWithHttpInfo (string accountId);

        /// <summary>
        /// Gets a list of the folders for the account.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>3Task of FoldersResponse</returns>
        System.Threading.Tasks.Task<FoldersResponse> ListAsync (string accountId);

        /// <summary>
        /// Gets a list of the folders for the account.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>4Task of ApiResponse (FoldersResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FoldersResponse>> ListAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// Gets a list of the envelopes in the specified folder.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param>
		/// <returns>1FolderItemsResponse</returns>
        FolderItemsResponse ListItems (string accountId, string folderId);
 
		/// <summary>
        /// Gets a list of the envelopes in the specified folder.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param>
		/// <returns>2ApiResponse of FolderItemsResponse</returns>
        ApiResponse<FolderItemsResponse> ListItemsWithHttpInfo (string accountId, string folderId);

        /// <summary>
        /// Gets a list of the envelopes in the specified folder.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param>
		/// <returns>3Task of FolderItemsResponse</returns>
        System.Threading.Tasks.Task<FolderItemsResponse> ListItemsAsync (string accountId, string folderId);

        /// <summary>
        /// Gets a list of the envelopes in the specified folder.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param>
		/// <returns>4Task of ApiResponse (FolderItemsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderItemsResponse>> ListItemsAsyncWithHttpInfo (string accountId, string folderId);
        
        /// <summary>
        /// Moves an envelope from its current folder to the specified folder.
        /// </summary>
        /// <remarks>
        /// Moves an envelope from its current folder to the specified folder.\n\n### Note: You can use this endpoint to delete envelopes by specifying `recyclebin&#39; in the `folderId` parameter of the endpoint. Placing an in process envelope (envelope status of `sent` or `delivered`) in the recycle bin voids the envelope. You can also use this endpoint to delete templates by specifying a template ID instead of an envelope ID in the &#39;envelopeIds&#39; property and specifying `recyclebin` in the `folderId` parameter.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param> <param name="foldersRequest">TBD Description</param>
		/// <returns>1FoldersResponse</returns>
        FoldersResponse MoveEnvelopes (string accountId, string folderId, FoldersRequest foldersRequest);
 
		/// <summary>
        /// Moves an envelope from its current folder to the specified folder.
        /// </summary>
        /// <remarks>
        /// Moves an envelope from its current folder to the specified folder.\n\n### Note: You can use this endpoint to delete envelopes by specifying `recyclebin&#39; in the `folderId` parameter of the endpoint. Placing an in process envelope (envelope status of `sent` or `delivered`) in the recycle bin voids the envelope. You can also use this endpoint to delete templates by specifying a template ID instead of an envelope ID in the &#39;envelopeIds&#39; property and specifying `recyclebin` in the `folderId` parameter.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param> <param name="foldersRequest">TBD Description</param>
		/// <returns>2ApiResponse of FoldersResponse</returns>
        ApiResponse<FoldersResponse> MoveEnvelopesWithHttpInfo (string accountId, string folderId, FoldersRequest foldersRequest);

        /// <summary>
        /// Moves an envelope from its current folder to the specified folder.
        /// </summary>
        /// <remarks>
        /// Moves an envelope from its current folder to the specified folder.\n\n### Note: You can use this endpoint to delete envelopes by specifying `recyclebin&#39; in the `folderId` parameter of the endpoint. Placing an in process envelope (envelope status of `sent` or `delivered`) in the recycle bin voids the envelope. You can also use this endpoint to delete templates by specifying a template ID instead of an envelope ID in the &#39;envelopeIds&#39; property and specifying `recyclebin` in the `folderId` parameter.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param> <param name="foldersRequest">TBD Description</param>
		/// <returns>3Task of FoldersResponse</returns>
        System.Threading.Tasks.Task<FoldersResponse> MoveEnvelopesAsync (string accountId, string folderId, FoldersRequest foldersRequest);

        /// <summary>
        /// Moves an envelope from its current folder to the specified folder.
        /// </summary>
        /// <remarks>
        /// Moves an envelope from its current folder to the specified folder.\n\n### Note: You can use this endpoint to delete envelopes by specifying `recyclebin&#39; in the `folderId` parameter of the endpoint. Placing an in process envelope (envelope status of `sent` or `delivered`) in the recycle bin voids the envelope. You can also use this endpoint to delete templates by specifying a template ID instead of an envelope ID in the &#39;envelopeIds&#39; property and specifying `recyclebin` in the `folderId` parameter.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param> <param name="foldersRequest">TBD Description</param>
		/// <returns>4Task of ApiResponse (FoldersResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FoldersResponse>> MoveEnvelopesAsyncWithHttpInfo (string accountId, string folderId, FoldersRequest foldersRequest);
        
        /// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </remarks>
		
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="searchFolderId">Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>1FolderItemResponse</returns>
        FolderItemResponse Search (string accountId, string searchFolderId, FoldersApi.SearchOptions options = null);
 
		/// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </remarks>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="searchFolderId">Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>2ApiResponse of FolderItemResponse</returns>
        ApiResponse<FolderItemResponse> SearchWithHttpInfo (string accountId, string searchFolderId, FoldersApi.SearchOptions options = null);

        /// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="searchFolderId">Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>3Task of FolderItemResponse</returns>
        System.Threading.Tasks.Task<FolderItemResponse> SearchAsync (string accountId, string searchFolderId, FoldersApi.SearchOptions options = null);

        /// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </remarks>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="searchFolderId">Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>4Task of ApiResponse (FolderItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderItemResponse>> SearchAsyncWithHttpInfo (string accountId, string searchFolderId, FoldersApi.SearchOptions options = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FoldersApi : IFoldersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FoldersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FoldersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FoldersApi(Configuration configuration = null)
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
        /// Gets a list of the folders for the account. Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>5FoldersResponse</returns>
        public FoldersResponse List (string accountId)
        {
             ApiResponse<FoldersResponse> response = ListWithHttpInfo(accountId);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of the folders for the account. Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>6ApiResponse of FoldersResponse</returns>
        public ApiResponse< FoldersResponse > ListWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling List");
            
    
            var path_ = "/v2/accounts/{accountId}/folders";
    
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
                throw new ApiException (statusCode, "Error calling List: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling List: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FoldersResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FoldersResponse) Configuration.ApiClient.Deserialize(response, typeof(FoldersResponse)));
            
        }
    
        /// <summary>
        /// Gets a list of the folders for the account. Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>7Task of FoldersResponse</returns>
        public async System.Threading.Tasks.Task<FoldersResponse> ListAsync (string accountId)
        {
             ApiResponse<FoldersResponse> response = await ListAsyncWithHttpInfo(accountId);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of the folders for the account. Retrieves a list of the folders for the account, including the folder hierarchy. You can specify whether to return just the template folder or template folder and normal folders by setting the `template` query string parameter.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param>
		/// <returns>8Task of ApiResponse (FoldersResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FoldersResponse>> ListAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling List");
            
    
            var path_ = "/v2/accounts/{accountId}/folders";
    
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
                throw new ApiException (statusCode, "Error calling List: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling List: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FoldersResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FoldersResponse) Configuration.ApiClient.Deserialize(response, typeof(FoldersResponse)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Gets a list of the envelopes in the specified folder. Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param>
		/// <returns>5FolderItemsResponse</returns>
        public FolderItemsResponse ListItems (string accountId, string folderId)
        {
             ApiResponse<FolderItemsResponse> response = ListItemsWithHttpInfo(accountId, folderId);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of the envelopes in the specified folder. Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param>
		/// <returns>6ApiResponse of FolderItemsResponse</returns>
        public ApiResponse< FolderItemsResponse > ListItemsWithHttpInfo (string accountId, string folderId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListItems");
            
            // verify the required parameter 'folderId' is set
            if (folderId == null) throw new ApiException(400, "Missing required parameter 'folderId' when calling ListItems");
            
    
            var path_ = "/v2/accounts/{accountId}/folders/{folderId}";
    
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
            if (folderId != null) pathParams.Add("folderId", Configuration.ApiClient.ParameterToString(folderId)); // path parameter
            
			
			

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListItems: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FolderItemsResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FolderItemsResponse) Configuration.ApiClient.Deserialize(response, typeof(FolderItemsResponse)));
            
        }
    
        /// <summary>
        /// Gets a list of the envelopes in the specified folder. Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param>
		/// <returns>7Task of FolderItemsResponse</returns>
        public async System.Threading.Tasks.Task<FolderItemsResponse> ListItemsAsync (string accountId, string folderId)
        {
             ApiResponse<FolderItemsResponse> response = await ListItemsAsyncWithHttpInfo(accountId, folderId);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of the envelopes in the specified folder. Retrieves a list of the envelopes in the specified folder. You can narrow the query by specifying search criteria in the query string parameters.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param>
		/// <returns>8Task of ApiResponse (FolderItemsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderItemsResponse>> ListItemsAsyncWithHttpInfo (string accountId, string folderId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ListItems");
            // verify the required parameter 'folderId' is set
            if (folderId == null) throw new ApiException(400, "Missing required parameter 'folderId' when calling ListItems");
            
    
            var path_ = "/v2/accounts/{accountId}/folders/{folderId}";
    
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
            if (folderId != null) pathParams.Add("folderId", Configuration.ApiClient.ParameterToString(folderId)); // path parameter
            

						
			
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListItems: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListItems: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FolderItemsResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FolderItemsResponse) Configuration.ApiClient.Deserialize(response, typeof(FolderItemsResponse)));
            
        }
        
		
		
		

		
		
		
        /// <summary>
        /// Moves an envelope from its current folder to the specified folder. Moves an envelope from its current folder to the specified folder.\n\n### Note: You can use this endpoint to delete envelopes by specifying `recyclebin&#39; in the `folderId` parameter of the endpoint. Placing an in process envelope (envelope status of `sent` or `delivered`) in the recycle bin voids the envelope. You can also use this endpoint to delete templates by specifying a template ID instead of an envelope ID in the &#39;envelopeIds&#39; property and specifying `recyclebin` in the `folderId` parameter.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param> <param name="foldersRequest">TBD Description</param>
		/// <returns>5FoldersResponse</returns>
        public FoldersResponse MoveEnvelopes (string accountId, string folderId, FoldersRequest foldersRequest)
        {
             ApiResponse<FoldersResponse> response = MoveEnvelopesWithHttpInfo(accountId, folderId, foldersRequest);
             return response.Data;
        }

        /// <summary>
        /// Moves an envelope from its current folder to the specified folder. Moves an envelope from its current folder to the specified folder.\n\n### Note: You can use this endpoint to delete envelopes by specifying `recyclebin&#39; in the `folderId` parameter of the endpoint. Placing an in process envelope (envelope status of `sent` or `delivered`) in the recycle bin voids the envelope. You can also use this endpoint to delete templates by specifying a template ID instead of an envelope ID in the &#39;envelopeIds&#39; property and specifying `recyclebin` in the `folderId` parameter.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param> <param name="foldersRequest">TBD Description</param>
		/// <returns>6ApiResponse of FoldersResponse</returns>
        public ApiResponse< FoldersResponse > MoveEnvelopesWithHttpInfo (string accountId, string folderId, FoldersRequest foldersRequest)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling MoveEnvelopes");
            
            // verify the required parameter 'folderId' is set
            if (folderId == null) throw new ApiException(400, "Missing required parameter 'folderId' when calling MoveEnvelopes");
            
    
            var path_ = "/v2/accounts/{accountId}/folders/{folderId}";
    
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
            if (folderId != null) pathParams.Add("folderId", Configuration.ApiClient.ParameterToString(folderId)); // path parameter
            
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(foldersRequest); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MoveEnvelopes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MoveEnvelopes: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FoldersResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FoldersResponse) Configuration.ApiClient.Deserialize(response, typeof(FoldersResponse)));
            
        }
    
        /// <summary>
        /// Moves an envelope from its current folder to the specified folder. Moves an envelope from its current folder to the specified folder.\n\n### Note: You can use this endpoint to delete envelopes by specifying `recyclebin&#39; in the `folderId` parameter of the endpoint. Placing an in process envelope (envelope status of `sent` or `delivered`) in the recycle bin voids the envelope. You can also use this endpoint to delete templates by specifying a template ID instead of an envelope ID in the &#39;envelopeIds&#39; property and specifying `recyclebin` in the `folderId` parameter.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param> <param name="foldersRequest">TBD Description</param>
		/// <returns>7Task of FoldersResponse</returns>
        public async System.Threading.Tasks.Task<FoldersResponse> MoveEnvelopesAsync (string accountId, string folderId, FoldersRequest foldersRequest)
        {
             ApiResponse<FoldersResponse> response = await MoveEnvelopesAsyncWithHttpInfo(accountId, folderId, foldersRequest);
             return response.Data;

        }

        /// <summary>
        /// Moves an envelope from its current folder to the specified folder. Moves an envelope from its current folder to the specified folder.\n\n### Note: You can use this endpoint to delete envelopes by specifying `recyclebin&#39; in the `folderId` parameter of the endpoint. Placing an in process envelope (envelope status of `sent` or `delivered`) in the recycle bin voids the envelope. You can also use this endpoint to delete templates by specifying a template ID instead of an envelope ID in the &#39;envelopeIds&#39; property and specifying `recyclebin` in the `folderId` parameter.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="folderId">The ID of the folder being accessed.</param> <param name="foldersRequest">TBD Description</param>
		/// <returns>8Task of ApiResponse (FoldersResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FoldersResponse>> MoveEnvelopesAsyncWithHttpInfo (string accountId, string folderId, FoldersRequest foldersRequest)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling MoveEnvelopes");
            // verify the required parameter 'folderId' is set
            if (folderId == null) throw new ApiException(400, "Missing required parameter 'folderId' when calling MoveEnvelopes");
            
    
            var path_ = "/v2/accounts/{accountId}/folders/{folderId}";
    
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
            if (folderId != null) pathParams.Add("folderId", Configuration.ApiClient.ParameterToString(folderId)); // path parameter
            

						
			
			

            
            
            postBody = Configuration.ApiClient.Serialize(foldersRequest); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling MoveEnvelopes: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling MoveEnvelopes: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FoldersResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FoldersResponse) Configuration.ApiClient.Deserialize(response, typeof(FoldersResponse)));
            
        }
        
		
		
        /// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria. Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </summary>
		public class SearchOptions
		{
				
			/// When set to **true**, the recipient information is returned in the response. 
			public string includeRecipients {get; set;}
				
			/// Specifies that all envelopes that match the criteria are returned. 
			public string all {get; set;}
				
			/// Specifies the order in which the list is returned. Valid values are: `asc` for ascending order, and `desc` for descending order. 
			public string order {get; set;}
				
			/// Specifies the number of records returned in the cache. The number must be greater than 0 and less than or equal to 100. 
			public string count {get; set;}
				
			/// Specifies the the starting location in the result set of the items that are returned. 
			public string startPosition {get; set;}
				
			/// Specifies the start of the date range to return. If no value is provided, the default search is the previous 30 days. 
			public string fromDate {get; set;}
				
			/// Specifies the end of the date range to return. 
			public string toDate {get; set;}
				
			/// Specifies the property used to sort the list. Valid values are: `action_required`, `created`, `completed`, `sent`, `signer_list`, `status`, or `subject`. 
			public string orderBy {get; set;}
			
		}
		
		

		
		
		
        /// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria. Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="searchFolderId">Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>5FolderItemResponse</returns>
        public FolderItemResponse Search (string accountId, string searchFolderId, FoldersApi.SearchOptions options = null)
        {
             ApiResponse<FolderItemResponse> response = SearchWithHttpInfo(accountId, searchFolderId, options);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria. Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="searchFolderId">Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>6ApiResponse of FolderItemResponse</returns>
        public ApiResponse< FolderItemResponse > SearchWithHttpInfo (string accountId, string searchFolderId, FoldersApi.SearchOptions options = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Search");
            
            // verify the required parameter 'searchFolderId' is set
            if (searchFolderId == null) throw new ApiException(400, "Missing required parameter 'searchFolderId' when calling Search");
            
    
            var path_ = "/v2/accounts/{accountId}/search_folders/{searchFolderId}";
    
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
            if (searchFolderId != null) pathParams.Add("searchFolderId", Configuration.ApiClient.ParameterToString(searchFolderId)); // path parameter
            
			
			if (options != null)
			{
				if (options.includeRecipients != null) queryParams.Add("include_recipients", Configuration.ApiClient.ParameterToString(options.includeRecipients)); // query parameter
				if (options.all != null) queryParams.Add("all", Configuration.ApiClient.ParameterToString(options.all)); // query parameter
				if (options.order != null) queryParams.Add("order", Configuration.ApiClient.ParameterToString(options.order)); // query parameter
				if (options.count != null) queryParams.Add("count", Configuration.ApiClient.ParameterToString(options.count)); // query parameter
				if (options.startPosition != null) queryParams.Add("start_position", Configuration.ApiClient.ParameterToString(options.startPosition)); // query parameter
				if (options.fromDate != null) queryParams.Add("from_date", Configuration.ApiClient.ParameterToString(options.fromDate)); // query parameter
				if (options.toDate != null) queryParams.Add("to_date", Configuration.ApiClient.ParameterToString(options.toDate)); // query parameter
				if (options.orderBy != null) queryParams.Add("order_by", Configuration.ApiClient.ParameterToString(options.orderBy)); // query parameter
				
			}

            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Search: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Search: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<FolderItemResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FolderItemResponse) Configuration.ApiClient.Deserialize(response, typeof(FolderItemResponse)));
            
        }
    
        /// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria. Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </summary>
 	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="searchFolderId">Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>7Task of FolderItemResponse</returns>
        public async System.Threading.Tasks.Task<FolderItemResponse> SearchAsync (string accountId, string searchFolderId, FoldersApi.SearchOptions options = null)
        {
             ApiResponse<FolderItemResponse> response = await SearchAsyncWithHttpInfo(accountId, searchFolderId, options);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of envelopes in folders matching the specified criteria. Retrieves a list of envelopes that match the criteria specified in the query.\n\nIf the user ID of the user making the call is the same as the user ID for any returned recipient, then the userId property is added to the returned information for those recipients.
        /// </summary>
	    ///<param name="accountId">The external account number (int) or account ID Guid.</param><param name="searchFolderId">Specifies the envelope group that is searched by the request. These are logical groupings, not actual folder names. Valid values are: drafts, awaiting_my_signature, completed, out_for_signature.</param> <param name="options">Options for modifying the behavior of the function.</param>
		/// <returns>8Task of ApiResponse (FolderItemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderItemResponse>> SearchAsyncWithHttpInfo (string accountId, string searchFolderId, FoldersApi.SearchOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling Search");
            // verify the required parameter 'searchFolderId' is set
            if (searchFolderId == null) throw new ApiException(400, "Missing required parameter 'searchFolderId' when calling Search");
            
    
            var path_ = "/v2/accounts/{accountId}/search_folders/{searchFolderId}";
    
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
            if (searchFolderId != null) pathParams.Add("searchFolderId", Configuration.ApiClient.ParameterToString(searchFolderId)); // path parameter
            

						
			if (options != null)
			{
				if (options.includeRecipients != null) queryParams.Add("include_recipients", Configuration.ApiClient.ParameterToString(options.includeRecipients)); // query parameter
				if (options.all != null) queryParams.Add("all", Configuration.ApiClient.ParameterToString(options.all)); // query parameter
				if (options.order != null) queryParams.Add("order", Configuration.ApiClient.ParameterToString(options.order)); // query parameter
				if (options.count != null) queryParams.Add("count", Configuration.ApiClient.ParameterToString(options.count)); // query parameter
				if (options.startPosition != null) queryParams.Add("start_position", Configuration.ApiClient.ParameterToString(options.startPosition)); // query parameter
				if (options.fromDate != null) queryParams.Add("from_date", Configuration.ApiClient.ParameterToString(options.fromDate)); // query parameter
				if (options.toDate != null) queryParams.Add("to_date", Configuration.ApiClient.ParameterToString(options.toDate)); // query parameter
				if (options.orderBy != null) queryParams.Add("order_by", Configuration.ApiClient.ParameterToString(options.orderBy)); // query parameter
				
			}
			

            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling Search: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling Search: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<FolderItemResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FolderItemResponse) Configuration.ApiClient.Deserialize(response, typeof(FolderItemResponse)));
            
        }
        
    }
    
}
