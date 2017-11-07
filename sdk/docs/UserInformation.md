# DocuSign.eSign.Model.UserInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountManagementGranular** | [**UserAccountManagementGranularInformation**](UserAccountManagementGranularInformation.md) |  | [optional] 
**ActivationAccessCode** | **string** | The activation code the new user must enter when activating their account. | [optional] 
**CreatedDateTime** | **string** | Indicates the date and time the item was created. | [optional] 
**CustomSettings** | [**List&lt;NameValue&gt;**](NameValue.md) | The name/value pair information for the user custom setting. | [optional] 
**Email** | **string** |  | [optional] 
**EnableConnectForUser** | **string** | Specifies whether the user is enabled for updates from DocuSign Connect. Valid values: true or false. | [optional] 
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**FirstName** | **string** | The user’s first name.  Maximum Length: 50 characters. | [optional] 
**ForgottenPasswordInfo** | [**ForgottenPasswordInformation**](ForgottenPasswordInformation.md) |  | [optional] 
**GroupList** | [**List&lt;Group&gt;**](Group.md) | A list of the group information for groups to add the user to. Group information can be found by calling [ML:GET group information]. The only required parameter is groupId.   The parameters are:  * groupId – The DocuSign group ID for the group. * groupName – The name of the group * permissionProfileId – The ID of the permission profile associated with the group. * groupType – The group type.  | [optional] 
**HomeAddress** | [**AddressInformationV2**](AddressInformationV2.md) |  | [optional] 
**InitialsImageUri** | **string** | Contains the URI for an endpoint that you can use to retrieve the initials image. | [optional] 
**IsAdmin** | **string** | Determines if the feature set is actively set as part of the plan. | [optional] 
**JobTitle** | **string** |  | [optional] 
**LastLogin** | **string** | Shows the date-time when the user last logged on to the system. | [optional] 
**LastName** | **string** | The user’s last name.  Maximum Length: 50 characters. | [optional] 
**LoginStatus** | **string** | Shows the current status of the user’s password. Possible values are:   * password_reset * password_active * password_expired * password_locked * password_reset_failed   | [optional] 
**MiddleName** | **string** | The user’s middle name.  Maximum Length: 50 characters. | [optional] 
**Password** | **string** |  | [optional] 
**PasswordExpiration** | **string** |  | [optional] 
**PermissionProfileId** | **string** |  | [optional] 
**PermissionProfileName** | **string** |  | [optional] 
**ProfileImageUri** | **string** |  | [optional] 
**SendActivationEmail** | **string** |  | [optional] 
**SendActivationOnInvalidLogin** | **string** | When set to **true**, specifies that an additional activation email is sent to the user if they fail a log on before activating their account.  | [optional] 
**SignatureImageUri** | **string** | Contains the URI for an endpoint that you can use to retrieve the signature image. | [optional] 
**SuffixName** | **string** | The suffix for the user&#39;s name.   Maximum Length: 50 characters.  | [optional] 
**Title** | **string** | The title of the user. | [optional] 
**Uri** | **string** |  | [optional] 
**UserId** | **string** |  | [optional] 
**UserName** | **string** |  | [optional] 
**UserProfileLastModifiedDate** | **string** |  | [optional] 
**UserSettings** | [**List&lt;NameValue&gt;**](NameValue.md) |  The name/value pair information for user settings. These determine the actions that a user can take in the account. The &#x60;[ML:userSettings]&#x60; are listed and described below. | [optional] 
**UserStatus** | **string** |  | [optional] 
**UserType** | **string** |  | [optional] 
**WorkAddress** | [**AddressInformationV2**](AddressInformationV2.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

