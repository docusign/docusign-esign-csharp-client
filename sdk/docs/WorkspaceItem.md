# DocuSign.eSign.Model.WorkspaceItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallerAuthorization** | [**WorkspaceUserAuthorization**](WorkspaceUserAuthorization.md) |  | [optional] 
**ContentType** | **string** |  | [optional] 
**Created** | **string** | The UTC DateTime when the workspace item was created. | [optional] 
**CreatedById** | **string** |  | [optional] 
**CreatedByInformation** | [**WorkspaceUser**](WorkspaceUser.md) |  | [optional] 
**Extension** | **string** |  | [optional] 
**FileSize** | **string** |  | [optional] 
**FileUri** | **string** |  | [optional] 
**Id** | **string** |  | [optional] 
**IsPublic** | **string** |  If true, this supersedes need for bit mask permission with workspaceUserAuthorization | [optional] 
**LastModified** | **string** |  | [optional] 
**LastModifiedById** | **string** | Utc date and time the comment was last updated (can only be done by creator) | [optional] 
**LastModifiedByInformation** | [**WorkspaceUser**](WorkspaceUser.md) |  | [optional] 
**Name** | **string** | A simple string description of the item, such as a file name or a folder name. | [optional] 
**PageCount** | **string** |  | [optional] 
**ParentFolderId** | **string** | The ID of the parent folder. This is the GUID of the parent folder, or the special value &#39;root&#39; for the root folder. | [optional] 
**ParentFolderUri** | **string** |  | [optional] 
**Type** | **string** | The type of the workspace item. Valid values are file, folder. | [optional] 
**Uri** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

