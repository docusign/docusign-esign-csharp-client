# DocuSign.eSign.Model.SealSign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessCode** | **string** | If a value is provided, the recipient must enter the value as the access code to view and sign the envelope.   Maximum Length: 50 characters and it must conform to the account’s access code format setting.  If blank, but the signer &#x60;accessCode&#x60; property is set in the envelope, then that value is used.  If blank and the signer &#x60;accessCode&#x60; property is not set, then the access code is not required. | [optional] 
**AddAccessCodeToEmail** | **string** | This Optional attribute indicates that the access code will be added to the email sent to the recipient; this nullifies the Security measure of Access Code on the recipient. | [optional] 
**ClientUserId** | **string** | Specifies whether the recipient is embedded or remote.   If the &#x60;clientUserId&#x60; property is not null then the recipient is embedded. Note that if the &#x60;ClientUserId&#x60; property is set and either &#x60;SignerMustHaveAccount&#x60; or &#x60;SignerMustLoginToSign&#x60; property of the account settings is set to  **true**, an error is generated on sending.ng.   Maximum length: 100 characters.  | [optional] 
**CustomFields** | **List&lt;string&gt;** | An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters. | [optional] 
**DeclinedDateTime** | **string** | The date and time the recipient declined the document. | [optional] 
**DeclinedReason** | **string** | The reason the recipient declined the document. | [optional] 
**DeliveredDateTime** | **string** | Reserved: For DocuSign use only. | [optional] 
**DeliveryMethod** | **string** | Reserved: For DocuSign use only. | [optional] 
**DocumentVisibility** | [**List&lt;DocumentVisibility&gt;**](DocumentVisibility.md) |  | [optional] 
**EmailNotification** | [**RecipientEmailNotification**](RecipientEmailNotification.md) |  | [optional] 
**EmbeddedRecipientStartURL** | **string** | Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender’s system (the server responding to the URL) must request a recipient token to launch a signing session.   If set to &#x60;SIGN_AT_DOCUSIGN&#x60;, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.  It is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient’s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets &#x60;EmbeddedRecipientStartURL&#x3D;SIGN_AT_DOCUSIGN&#x60;, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.  If the &#x60;clientUserId&#x60; property is NOT set, and the &#x60;embeddedRecipientStartURL&#x60; is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The &#x60;customFields&#x60; property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets.   *Example*:   &#x60;http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&amp;[[mergeField3]]&#x60;  | [optional] 
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**FaxNumber** | **string** | Reserved: | [optional] 
**IdCheckConfigurationName** | **string** | Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.  *Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as &#39;ID Check $&#39; and &#39;SMS Auth $&#39;. To use ID check in an envelope, the idCheckConfigurationName should be &#39;ID Check &#39;. If you wanted to use SMS, it would be &#39;SMS Auth $&#39; and you would need to add you would need to add phone number information to the &#x60;smsAuthentication&#x60; node. | [optional] 
**IdCheckInformationInput** | [**IdCheckInformationInput**](IdCheckInformationInput.md) |  | [optional] 
**InheritEmailNotificationConfiguration** | **string** | When set to **true** and the envelope recipient creates a DocuSign account after signing, the Manage Account Email Notification settings are used as the default settings for the recipient&#39;s account.  | [optional] 
**Note** | **string** | Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.  Maximum Length: 1000 characters. | [optional] 
**PhoneAuthentication** | [**RecipientPhoneAuthentication**](RecipientPhoneAuthentication.md) |  | [optional] 
**RecipientAttachments** | [**List&lt;RecipientAttachment&gt;**](RecipientAttachment.md) | Reserved: | [optional] 
**RecipientAuthenticationStatus** | [**AuthenticationStatus**](AuthenticationStatus.md) |  | [optional] 
**RecipientId** | **string** | Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document. | [optional] 
**RecipientIdGuid** | **string** |  | [optional] 
**RecipientSignatureProviders** | [**List&lt;RecipientSignatureProvider&gt;**](RecipientSignatureProvider.md) |  | [optional] 
**RequireIdLookup** | **string** | When set to **true**, the recipient is required to use the specified ID check method (including Phone and SMS authentication) to validate their identity.  | [optional] 
**RoleName** | **string** | Optional element. Specifies the role name associated with the recipient.&lt;br/&gt;&lt;br/&gt;This is required when working with template recipients. | [optional] 
**RoutingOrder** | **string** | Specifies the routing order of the recipient in the envelope.  | [optional] 
**SamlAuthentication** | [**RecipientSAMLAuthentication**](RecipientSAMLAuthentication.md) |  | [optional] 
**SentDateTime** | **string** | The date and time the envelope was sent. | [optional] 
**SignedDateTime** | **string** | Reserved: For DocuSign use only.  | [optional] 
**SmsAuthentication** | [**RecipientSMSAuthentication**](RecipientSMSAuthentication.md) |  | [optional] 
**SocialAuthentications** | [**List&lt;SocialAuthentication&gt;**](SocialAuthentication.md) |  Lists the social ID type that can be used for recipient authentication. | [optional] 
**Status** | **string** | Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later. | [optional] 
**TemplateLocked** | **string** | When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients.  | [optional] 
**TemplateRequired** | **string** | When set to **true**, the sender may not remove the recipient. Used only when working with template recipients. | [optional] 
**TotalTabCount** | **string** |  | [optional] 
**UserId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

