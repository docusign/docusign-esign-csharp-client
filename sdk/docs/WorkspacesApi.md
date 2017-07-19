# DocuSign.eSign.Api.WorkspacesApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorkspace**](WorkspacesApi.md#createworkspace) | **POST** /v2/accounts/{accountId}/workspaces | Create a Workspace
[**CreateWorkspaceFile**](WorkspacesApi.md#createworkspacefile) | **POST** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId}/files | Creates a workspace file.
[**DeleteWorkspace**](WorkspacesApi.md#deleteworkspace) | **DELETE** /v2/accounts/{accountId}/workspaces/{workspaceId} | Delete Workspace
[**DeleteWorkspaceFolderItems**](WorkspacesApi.md#deleteworkspacefolderitems) | **DELETE** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId} | Deletes workspace one or more specific files/folders from the given folder or root.
[**GetWorkspace**](WorkspacesApi.md#getworkspace) | **GET** /v2/accounts/{accountId}/workspaces/{workspaceId} | Get Workspace
[**GetWorkspaceFile**](WorkspacesApi.md#getworkspacefile) | **GET** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId}/files/{fileId} | Get Workspace File
[**ListWorkspaceFilePages**](WorkspacesApi.md#listworkspacefilepages) | **GET** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId}/files/{fileId}/pages | List File Pages
[**ListWorkspaceFolderItems**](WorkspacesApi.md#listworkspacefolderitems) | **GET** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId} | List Workspace Folder Contents
[**ListWorkspaces**](WorkspacesApi.md#listworkspaces) | **GET** /v2/accounts/{accountId}/workspaces | List Workspaces
[**UpdateWorkspace**](WorkspacesApi.md#updateworkspace) | **PUT** /v2/accounts/{accountId}/workspaces/{workspaceId} | Update Workspace
[**UpdateWorkspaceFile**](WorkspacesApi.md#updateworkspacefile) | **PUT** /v2/accounts/{accountId}/workspaces/{workspaceId}/folders/{folderId}/files/{fileId} | Update Workspace File Metadata


<a name="createworkspace"></a>
# **CreateWorkspace**
> Workspace CreateWorkspace (Workspace workspace = null, string accountId)

Create a Workspace

Creates a new workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateWorkspaceExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var workspace = new Workspace(); // Workspace |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Create a Workspace
                Workspace result = apiInstance.CreateWorkspace(workspace, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.CreateWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspace** | [**Workspace**](Workspace.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**Workspace**](Workspace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createworkspacefile"></a>
# **CreateWorkspaceFile**
> WorkspaceItem CreateWorkspaceFile (string accountId, string workspaceId, string folderId)

Creates a workspace file.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreateWorkspaceFileExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.

            try
            {
                // Creates a workspace file.
                WorkspaceItem result = apiInstance.CreateWorkspaceFile(accountId, workspaceId, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.CreateWorkspaceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 

### Return type

[**WorkspaceItem**](WorkspaceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspace"></a>
# **DeleteWorkspace**
> Workspace DeleteWorkspace (string accountId, string workspaceId)

Delete Workspace

Deletes an existing workspace (logically).

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteWorkspaceExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.

            try
            {
                // Delete Workspace
                Workspace result = apiInstance.DeleteWorkspace(accountId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.DeleteWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 

### Return type

[**Workspace**](Workspace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteworkspacefolderitems"></a>
# **DeleteWorkspaceFolderItems**
> void DeleteWorkspaceFolderItems (WorkspaceItemList workspaceItemList = null, string accountId, string workspaceId, string folderId)

Deletes workspace one or more specific files/folders from the given folder or root.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteWorkspaceFolderItemsExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var workspaceItemList = new WorkspaceItemList(); // WorkspaceItemList |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.

            try
            {
                // Deletes workspace one or more specific files/folders from the given folder or root.
                apiInstance.DeleteWorkspaceFolderItems(workspaceItemList, accountId, workspaceId, folderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.DeleteWorkspaceFolderItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceItemList** | [**WorkspaceItemList**](WorkspaceItemList.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspace"></a>
# **GetWorkspace**
> Workspace GetWorkspace (string accountId, string workspaceId)

Get Workspace

Retrives properties about a workspace given a unique workspaceId. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetWorkspaceExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.

            try
            {
                // Get Workspace
                Workspace result = apiInstance.GetWorkspace(accountId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 

### Return type

[**Workspace**](Workspace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworkspacefile"></a>
# **GetWorkspaceFile**
> void GetWorkspaceFile (string isDownload = null, string pdfVersion = null, string accountId, string workspaceId, string folderId, string fileId)

Get Workspace File

Retrieves a workspace file (the binary).

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetWorkspaceFileExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var isDownload = isDownload_example;  // string | When set to **true**, the Content-Disposition header is set in the response. The value of the header provides the filename of the file. Default is **false**. (optional) 
            var pdfVersion = pdfVersion_example;  // string | When set to **true** the file returned as a PDF. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var fileId = fileId_example;  // string | Specifies the room file ID GUID.

            try
            {
                // Get Workspace File
                apiInstance.GetWorkspaceFile(isDownload, pdfVersion, accountId, workspaceId, folderId, fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.GetWorkspaceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isDownload** | **string**| When set to **true**, the Content-Disposition header is set in the response. The value of the header provides the filename of the file. Default is **false**. | [optional] 
 **pdfVersion** | **string**| When set to **true** the file returned as a PDF. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **fileId** | **string**| Specifies the room file ID GUID. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listworkspacefilepages"></a>
# **ListWorkspaceFilePages**
> PageImages ListWorkspaceFilePages (string count = null, string dpi = null, string maxHeight = null, string maxWidth = null, string startPosition = null, string accountId, string workspaceId, string folderId, string fileId)

List File Pages

Retrieves a workspace file as rasterized pages.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListWorkspaceFilePagesExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var count = count_example;  // string | The maximum number of results to be returned by this request. (optional) 
            var dpi = dpi_example;  // string | Number of dots per inch for the resulting image. The default if not used is 94. The range is 1-310. (optional) 
            var maxHeight = maxHeight_example;  // string | Sets the maximum height (in pixels) of the returned image. (optional) 
            var maxWidth = maxWidth_example;  // string | Sets the maximum width (in pixels) of the returned image. (optional) 
            var startPosition = startPosition_example;  // string | The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var fileId = fileId_example;  // string | Specifies the room file ID GUID.

            try
            {
                // List File Pages
                PageImages result = apiInstance.ListWorkspaceFilePages(count, dpi, maxHeight, maxWidth, startPosition, accountId, workspaceId, folderId, fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.ListWorkspaceFilePages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **string**| The maximum number of results to be returned by this request. | [optional] 
 **dpi** | **string**| Number of dots per inch for the resulting image. The default if not used is 94. The range is 1-310. | [optional] 
 **maxHeight** | **string**| Sets the maximum height (in pixels) of the returned image. | [optional] 
 **maxWidth** | **string**| Sets the maximum width (in pixels) of the returned image. | [optional] 
 **startPosition** | **string**| The position within the total result set from which to start returning values. The value **thumbnail** may be used to return the page image. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **fileId** | **string**| Specifies the room file ID GUID. | 

### Return type

[**PageImages**](PageImages.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listworkspacefolderitems"></a>
# **ListWorkspaceFolderItems**
> WorkspaceFolderContents ListWorkspaceFolderItems (string count = null, string includeFiles = null, string includeSubFolders = null, string includeThumbnails = null, string includeUserDetail = null, string startPosition = null, string workspaceUserId = null, string accountId, string workspaceId, string folderId)

List Workspace Folder Contents

Retrieves workspace folder contents, which can include sub folders and files.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListWorkspaceFolderItemsExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var count = count_example;  // string | The maximum number of results to be returned by this request. (optional) 
            var includeFiles = includeFiles_example;  // string | When set to **true**, file information is returned in the response along with folder information. The default is **false**. (optional) 
            var includeSubFolders = includeSubFolders_example;  // string | When set to **true**, information about the sub-folders of the current folder is returned. The default is **false**. (optional) 
            var includeThumbnails = includeThumbnails_example;  // string | When set to **true**, thumbnails are returned as part of the response.  The default is **false**. (optional) 
            var includeUserDetail = includeUserDetail_example;  // string | Set to **true** to return extended details about the user. The default is **false**. (optional) 
            var startPosition = startPosition_example;  // string | The position within the total result set from which to start returning values. (optional) 
            var workspaceUserId = workspaceUserId_example;  // string | If set, then the results are filtered to those associated with the specified userId. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.

            try
            {
                // List Workspace Folder Contents
                WorkspaceFolderContents result = apiInstance.ListWorkspaceFolderItems(count, includeFiles, includeSubFolders, includeThumbnails, includeUserDetail, startPosition, workspaceUserId, accountId, workspaceId, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.ListWorkspaceFolderItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **string**| The maximum number of results to be returned by this request. | [optional] 
 **includeFiles** | **string**| When set to **true**, file information is returned in the response along with folder information. The default is **false**. | [optional] 
 **includeSubFolders** | **string**| When set to **true**, information about the sub-folders of the current folder is returned. The default is **false**. | [optional] 
 **includeThumbnails** | **string**| When set to **true**, thumbnails are returned as part of the response.  The default is **false**. | [optional] 
 **includeUserDetail** | **string**| Set to **true** to return extended details about the user. The default is **false**. | [optional] 
 **startPosition** | **string**| The position within the total result set from which to start returning values. | [optional] 
 **workspaceUserId** | **string**| If set, then the results are filtered to those associated with the specified userId. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 

### Return type

[**WorkspaceFolderContents**](WorkspaceFolderContents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listworkspaces"></a>
# **ListWorkspaces**
> WorkspaceList ListWorkspaces (string accountId)

List Workspaces

Gets information about the Workspaces that have been created.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListWorkspacesExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // List Workspaces
                WorkspaceList result = apiInstance.ListWorkspaces(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.ListWorkspaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**WorkspaceList**](WorkspaceList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkspace"></a>
# **UpdateWorkspace**
> Workspace UpdateWorkspace (Workspace workspace = null, string accountId, string workspaceId)

Update Workspace

Updates information about a specific workspace.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateWorkspaceExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var workspace = new Workspace(); // Workspace |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.

            try
            {
                // Update Workspace
                Workspace result = apiInstance.UpdateWorkspace(workspace, accountId, workspaceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.UpdateWorkspace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspace** | [**Workspace**](Workspace.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 

### Return type

[**Workspace**](Workspace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateworkspacefile"></a>
# **UpdateWorkspaceFile**
> WorkspaceItem UpdateWorkspaceFile (string accountId, string workspaceId, string folderId, string fileId)

Update Workspace File Metadata

Updates workspace item metadata for one or more specific files/folders.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateWorkspaceFileExample
    {
        public void main()
        {
            
            var apiInstance = new WorkspacesApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var workspaceId = workspaceId_example;  // string | Specifies the workspace ID GUID.
            var folderId = folderId_example;  // string | The ID of the folder being accessed.
            var fileId = fileId_example;  // string | Specifies the room file ID GUID.

            try
            {
                // Update Workspace File Metadata
                WorkspaceItem result = apiInstance.UpdateWorkspaceFile(accountId, workspaceId, folderId, fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WorkspacesApi.UpdateWorkspaceFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **workspaceId** | **string**| Specifies the workspace ID GUID. | 
 **folderId** | **string**| The ID of the folder being accessed. | 
 **fileId** | **string**| Specifies the room file ID GUID. | 

### Return type

[**WorkspaceItem**](WorkspaceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

