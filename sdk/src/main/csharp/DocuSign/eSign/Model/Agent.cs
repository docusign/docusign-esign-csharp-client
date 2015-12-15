using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Agent : IEquatable<Agent>
    {
        
        /// <summary>
        /// Specifies the documents that are not visible to this recipient. Document Visibility must be enabled for the account and the `enforceSignerVisibility` property must be set to **true** for the envelope to use this.\n\nWhen enforce signer visibility is enabled, documents with tabs can only be viewed by signers that have a tab on that document. Recipients that have an administrative role (Agent, Editor, or Intermediaries) or informational role (Certified Deliveries or Carbon Copies) can always see all the documents in an envelope, unless they are specifically excluded using this setting when an envelope is sent. Documents that do not have tabs are always visible to all recipients, unless they are specifically excluded using this setting when an envelope is sent.
        /// </summary>
        /// <value>Specifies the documents that are not visible to this recipient. Document Visibility must be enabled for the account and the `enforceSignerVisibility` property must be set to **true** for the envelope to use this.\n\nWhen enforce signer visibility is enabled, documents with tabs can only be viewed by signers that have a tab on that document. Recipients that have an administrative role (Agent, Editor, or Intermediaries) or informational role (Certified Deliveries or Carbon Copies) can always see all the documents in an envelope, unless they are specifically excluded using this setting when an envelope is sent. Documents that do not have tabs are always visible to all recipients, unless they are specifically excluded using this setting when an envelope is sent.</value>
        [DataMember(Name="excludedDocuments", EmitDefaultValue=false)]
        public List<string> ExcludedDocuments { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Email id of the recipient. Notification of the document to sign is sent to this email id. \n\nMaximum length: 100 characters.
        /// </summary>
        /// <value>Email id of the recipient. Notification of the document to sign is sent to this email id. \n\nMaximum length: 100 characters.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="emailRecipientPostSigningURL", EmitDefaultValue=false)]
        public string EmailRecipientPostSigningURL { get; set; }
  
        
        /// <summary>
        /// When set to **true** and the feature is enabled in the sender's account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).
        /// </summary>
        /// <value>When set to **true** and the feature is enabled in the sender's account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).</value>
        [DataMember(Name="signingGroupId", EmitDefaultValue=false)]
        public string SigningGroupId { get; set; }
  
        
        /// <summary>
        /// The display name for the signing group. \n\nMaximum Length: 100 characters.
        /// </summary>
        /// <value>The display name for the signing group. \n\nMaximum Length: 100 characters.</value>
        [DataMember(Name="signingGroupName", EmitDefaultValue=false)]
        public string SigningGroupName { get; set; }
  
        
        /// <summary>
        /// A complex type that contains information about users in the signing group.
        /// </summary>
        /// <value>A complex type that contains information about users in the signing group.</value>
        [DataMember(Name="signingGroupUsers", EmitDefaultValue=false)]
        public List<UserInfo> SigningGroupUsers { get; set; }
  
        
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="recipientIdGuid", EmitDefaultValue=false)]
        public string RecipientIdGuid { get; set; }
  
        
        /// <summary>
        /// If a value is provided, the recipient must enter the value as the access code to view and sign the envelope. \n\nMaximum Length: 50 characters and must conform to account’s access code format setting.\n\nIf blank, but the signer `accessCode` property is set in the envelope, then that value is used.\n\nIf blank and the signer `accessCode` property is not set, then access code is not required.
        /// </summary>
        /// <value>If a value is provided, the recipient must enter the value as the access code to view and sign the envelope. \n\nMaximum Length: 50 characters and must conform to account’s access code format setting.\n\nIf blank, but the signer `accessCode` property is set in the envelope, then that value is used.\n\nIf blank and the signer `accessCode` property is not set, then access code is not required.</value>
        [DataMember(Name="accessCode", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
  
        
        /// <summary>
        /// This Optional attribute indicates that the access code will be added to the email sent to the recipient; this nullifies the Security measure of Access Code on the recipient.
        /// </summary>
        /// <value>This Optional attribute indicates that the access code will be added to the email sent to the recipient; this nullifies the Security measure of Access Code on the recipient.</value>
        [DataMember(Name="addAccessCodeToEmail", EmitDefaultValue=false)]
        public string AddAccessCodeToEmail { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the recipient is required to use the specified ID check method (including Phone and SMS authentication) to validate their identity.
        /// </summary>
        /// <value>When set to **true**, the recipient is required to use the specified ID check method (including Phone and SMS authentication) to validate their identity.</value>
        [DataMember(Name="requireIdLookup", EmitDefaultValue=false)]
        public string RequireIdLookup { get; set; }
  
        
        /// <summary>
        /// Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.\n\n*Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as 'ID Check $' and 'SMS Auth $'. To use ID check in an envelope, the idCheckConfigurationName should be 'ID Check '. If you wanted to use SMS, it would be 'SMS Auth $' and you would need to add you would need to add phone number information to the `smsAuthentication` node.
        /// </summary>
        /// <value>Specifies authentication check by name. The names used here must be the same as the authentication type names used by the account (these name can also be found in the web console sending interface in the Identify list for a recipient,) This overrides any default authentication setting.\n\n*Example*: Your account has ID Check and SMS Authentication available and in the web console Identify list these appear as 'ID Check $' and 'SMS Auth $'. To use ID check in an envelope, the idCheckConfigurationName should be 'ID Check '. If you wanted to use SMS, it would be 'SMS Auth $' and you would need to add you would need to add phone number information to the `smsAuthentication` node.</value>
        [DataMember(Name="idCheckConfigurationName", EmitDefaultValue=false)]
        public string IdCheckConfigurationName { get; set; }
  
        
        /// <summary>
        /// Lists the social ID type that can be used for recipient authentication.
        /// </summary>
        /// <value>Lists the social ID type that can be used for recipient authentication.</value>
        [DataMember(Name="socialAuthentications", EmitDefaultValue=false)]
        public List<SocialAuthentication> SocialAuthentications { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PhoneAuthentication
        /// </summary>
        [DataMember(Name="phoneAuthentication", EmitDefaultValue=false)]
        public RecipientPhoneAuthentication PhoneAuthentication { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SamlAuthentication
        /// </summary>
        [DataMember(Name="samlAuthentication", EmitDefaultValue=false)]
        public RecipientSAMLAuthentication SamlAuthentication { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SmsAuthentication
        /// </summary>
        [DataMember(Name="smsAuthentication", EmitDefaultValue=false)]
        public RecipientSMSAuthentication SmsAuthentication { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
  
        
        /// <summary>
        /// Specifies whether the recipient is embedded or remote. \n\nIf the `clientUserId` property is not null then the recipient is embedded. Note that if the `ClientUserId` property is set and either `SignerMustHaveAccount` or `SignerMustLoginToSign` property of the account settings is set to  **true**, an error is generated on sending.ng. \n\nMaximum length: 100 characters.
        /// </summary>
        /// <value>Specifies whether the recipient is embedded or remote. \n\nIf the `clientUserId` property is not null then the recipient is embedded. Note that if the `ClientUserId` property is set and either `SignerMustHaveAccount` or `SignerMustLoginToSign` property of the account settings is set to  **true**, an error is generated on sending.ng. \n\nMaximum length: 100 characters.</value>
        [DataMember(Name="clientUserId", EmitDefaultValue=false)]
        public string ClientUserId { get; set; }
  
        
        /// <summary>
        /// Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender’s system (the server responding to the URL) must request a recipient token to launch a signing session. \n\nIf set to `SIGN_AT_DOCUSIGN`, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.\n\nIt is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient’s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets `EmbeddedRecipientStartURL=SIGN_AT_DOCUSIGN`, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.\n\nIf the `clientUserId` property is NOT set, and the `embeddedRecipientStartURL` is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The `customFields` property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets. \n\n*Example*: \n\n`http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&[[mergeField3]]`
        /// </summary>
        /// <value>Specifies a sender provided valid URL string for redirecting an embedded recipient. When using this option, the embedded recipient still receives an email from DocuSign, just as a remote recipient would. When the document link in the email is clicked the recipient is redirected, through DocuSign, to the supplied URL to complete their actions. When routing to the URL, the sender’s system (the server responding to the URL) must request a recipient token to launch a signing session. \n\nIf set to `SIGN_AT_DOCUSIGN`, the recipient is directed to an embedded signing or viewing process directly at DocuSign. The signing or viewing action is initiated by the DocuSign system and the transaction activity and Certificate of Completion records will reflect this. In all other ways the process is identical to an embedded signing or viewing operation that is launched by any partner.\n\nIt is important to remember that in a typical embedded workflow the authentication of an embedded recipient is the responsibility of the sending application, DocuSign expects that senders will follow their own process for establishing the recipient’s identity. In this workflow the recipient goes through the sending application before the embedded signing or viewing process in initiated. However, when the sending application sets `EmbeddedRecipientStartURL=SIGN_AT_DOCUSIGN`, the recipient goes directly to the embedded signing or viewing process bypassing the sending application and any authentication steps the sending application would use. In this case, DocuSign recommends that you use one of the normal DocuSign authentication features (Access Code, Phone Authentication, SMS Authentication, etc.) to verify the identity of the recipient.\n\nIf the `clientUserId` property is NOT set, and the `embeddedRecipientStartURL` is set, DocuSign will ignore the redirect URL and launch the standard signing process for the email recipient. Information can be appended to the embedded recipient start URL using merge fields. The available merge fields items are: envelopeId, recipientId, recipientName, recipientEmail, and customFields. The `customFields` property must be set fort the recipient or envelope. The merge fields are enclosed in double brackets. \n\n*Example*: \n\n`http://senderHost/[[mergeField1]]/ beginSigningSession? [[mergeField2]]&[[mergeField3]]`</value>
        [DataMember(Name="embeddedRecipientStartURL", EmitDefaultValue=false)]
        public string EmbeddedRecipientStartURL { get; set; }
  
        
        /// <summary>
        /// An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters.
        /// </summary>
        /// <value>An optional array of strings that allows the sender to provide custom data about the recipient. This information is returned in the envelope status but otherwise not used by DocuSign. Each customField string can be a maximum of 100 characters.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public List<string> CustomFields { get; set; }
  
        
        /// <summary>
        /// Specifies the routing order of the recipient in the envelope.
        /// </summary>
        /// <value>Specifies the routing order of the recipient in the envelope.</value>
        [DataMember(Name="routingOrder", EmitDefaultValue=false)]
        public string RoutingOrder { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IdCheckInformationInput
        /// </summary>
        [DataMember(Name="idCheckInformationInput", EmitDefaultValue=false)]
        public IdCheckInformationInput IdCheckInformationInput { get; set; }
  
        
        /// <summary>
        /// Reserved:
        /// </summary>
        /// <value>Reserved:</value>
        [DataMember(Name="recipientAttachments", EmitDefaultValue=false)]
        public List<Attachment> RecipientAttachments { get; set; }
  
        
        /// <summary>
        /// Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.\n\nMaximum Length: 1000 characters.
        /// </summary>
        /// <value>Specifies a note that is unique to this recipient. This note is sent to the recipient via the signing email. The note displays in the signing UI near the upper left corner of the document on the signing screen.\n\nMaximum Length: 1000 characters.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
  
        
        /// <summary>
        /// Optional element. Specifies the role name associated with the recipient.<br/><br/>This is required when working with template recipients.
        /// </summary>
        /// <value>Optional element. Specifies the role name associated with the recipient.<br/><br/>This is required when working with template recipients.</value>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; set; }
  
        
        /// <summary>
        /// Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Reserved: For DocuSign use only.
        /// </summary>
        /// <value>Reserved: For DocuSign use only.</value>
        [DataMember(Name="signedDateTime", EmitDefaultValue=false)]
        public string SignedDateTime { get; set; }
  
        
        /// <summary>
        /// Reserved: For DocuSign use only.
        /// </summary>
        /// <value>Reserved: For DocuSign use only.</value>
        [DataMember(Name="deliveredDateTime", EmitDefaultValue=false)]
        public string DeliveredDateTime { get; set; }
  
        
        /// <summary>
        /// The date and time the recipient declined the document.
        /// </summary>
        /// <value>The date and time the recipient declined the document.</value>
        [DataMember(Name="declinedDateTime", EmitDefaultValue=false)]
        public string DeclinedDateTime { get; set; }
  
        
        /// <summary>
        /// The date and time the envelope was sent.
        /// </summary>
        /// <value>The date and time the envelope was sent.</value>
        [DataMember(Name="sentDateTime", EmitDefaultValue=false)]
        public string SentDateTime { get; set; }
  
        
        /// <summary>
        /// The reason the recipient declined the document.
        /// </summary>
        /// <value>The reason the recipient declined the document.</value>
        [DataMember(Name="declinedReason", EmitDefaultValue=false)]
        public string DeclinedReason { get; set; }
  
        
        /// <summary>
        /// Reserved: For DocuSign use only.
        /// </summary>
        /// <value>Reserved: For DocuSign use only.</value>
        [DataMember(Name="deliveryMethod", EmitDefaultValue=false)]
        public string DeliveryMethod { get; set; }
  
        
        /// <summary>
        /// Reserved:
        /// </summary>
        /// <value>Reserved:</value>
        [DataMember(Name="faxNumber", EmitDefaultValue=false)]
        public string FaxNumber { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients.
        /// </summary>
        /// <value>When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients.</value>
        [DataMember(Name="templateLocked", EmitDefaultValue=false)]
        public string TemplateLocked { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the sender may not remove the recipient. Used only when working with template recipients.
        /// </summary>
        /// <value>When set to **true**, the sender may not remove the recipient. Used only when working with template recipients.</value>
        [DataMember(Name="templateRequired", EmitDefaultValue=false)]
        public string TemplateRequired { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EmailNotification
        /// </summary>
        [DataMember(Name="emailNotification", EmitDefaultValue=false)]
        public RecipientEmailNotification EmailNotification { get; set; }
  
        
        /// <summary>
        /// When set to **true** and the envelope recipient creates a DocuSign account after signing, the Manage Account Email Notification settings are used as the default settings for the recipient's account.
        /// </summary>
        /// <value>When set to **true** and the envelope recipient creates a DocuSign account after signing, the Manage Account Email Notification settings are used as the default settings for the recipient's account.</value>
        [DataMember(Name="inheritEmailNotificationConfiguration", EmitDefaultValue=false)]
        public string InheritEmailNotificationConfiguration { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RecipientAuthenticationStatus
        /// </summary>
        [DataMember(Name="recipientAuthenticationStatus", EmitDefaultValue=false)]
        public AuthenticationStatus RecipientAuthenticationStatus { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="totalTabCount", EmitDefaultValue=false)]
        public string TotalTabCount { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Agent {\n");
            sb.Append("  ExcludedDocuments: ").Append(ExcludedDocuments).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailRecipientPostSigningURL: ").Append(EmailRecipientPostSigningURL).Append("\n");
            sb.Append("  SigningGroupId: ").Append(SigningGroupId).Append("\n");
            sb.Append("  SigningGroupName: ").Append(SigningGroupName).Append("\n");
            sb.Append("  SigningGroupUsers: ").Append(SigningGroupUsers).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  RecipientIdGuid: ").Append(RecipientIdGuid).Append("\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  AddAccessCodeToEmail: ").Append(AddAccessCodeToEmail).Append("\n");
            sb.Append("  RequireIdLookup: ").Append(RequireIdLookup).Append("\n");
            sb.Append("  IdCheckConfigurationName: ").Append(IdCheckConfigurationName).Append("\n");
            sb.Append("  SocialAuthentications: ").Append(SocialAuthentications).Append("\n");
            sb.Append("  PhoneAuthentication: ").Append(PhoneAuthentication).Append("\n");
            sb.Append("  SamlAuthentication: ").Append(SamlAuthentication).Append("\n");
            sb.Append("  SmsAuthentication: ").Append(SmsAuthentication).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  EmbeddedRecipientStartURL: ").Append(EmbeddedRecipientStartURL).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  RoutingOrder: ").Append(RoutingOrder).Append("\n");
            sb.Append("  IdCheckInformationInput: ").Append(IdCheckInformationInput).Append("\n");
            sb.Append("  RecipientAttachments: ").Append(RecipientAttachments).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SignedDateTime: ").Append(SignedDateTime).Append("\n");
            sb.Append("  DeliveredDateTime: ").Append(DeliveredDateTime).Append("\n");
            sb.Append("  DeclinedDateTime: ").Append(DeclinedDateTime).Append("\n");
            sb.Append("  SentDateTime: ").Append(SentDateTime).Append("\n");
            sb.Append("  DeclinedReason: ").Append(DeclinedReason).Append("\n");
            sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  TemplateLocked: ").Append(TemplateLocked).Append("\n");
            sb.Append("  TemplateRequired: ").Append(TemplateRequired).Append("\n");
            sb.Append("  EmailNotification: ").Append(EmailNotification).Append("\n");
            sb.Append("  InheritEmailNotificationConfiguration: ").Append(InheritEmailNotificationConfiguration).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  RecipientAuthenticationStatus: ").Append(RecipientAuthenticationStatus).Append("\n");
            sb.Append("  TotalTabCount: ").Append(TotalTabCount).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Agent);
        }

        /// <summary>
        /// Returns true if Agent instances are equal
        /// </summary>
        /// <param name="other">Instance of Agent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Agent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExcludedDocuments == other.ExcludedDocuments ||
                    this.ExcludedDocuments != null &&
                    this.ExcludedDocuments.SequenceEqual(other.ExcludedDocuments)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailRecipientPostSigningURL == other.EmailRecipientPostSigningURL ||
                    this.EmailRecipientPostSigningURL != null &&
                    this.EmailRecipientPostSigningURL.Equals(other.EmailRecipientPostSigningURL)
                ) && 
                (
                    this.SigningGroupId == other.SigningGroupId ||
                    this.SigningGroupId != null &&
                    this.SigningGroupId.Equals(other.SigningGroupId)
                ) && 
                (
                    this.SigningGroupName == other.SigningGroupName ||
                    this.SigningGroupName != null &&
                    this.SigningGroupName.Equals(other.SigningGroupName)
                ) && 
                (
                    this.SigningGroupUsers == other.SigningGroupUsers ||
                    this.SigningGroupUsers != null &&
                    this.SigningGroupUsers.SequenceEqual(other.SigningGroupUsers)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.RecipientIdGuid == other.RecipientIdGuid ||
                    this.RecipientIdGuid != null &&
                    this.RecipientIdGuid.Equals(other.RecipientIdGuid)
                ) && 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
                ) && 
                (
                    this.AddAccessCodeToEmail == other.AddAccessCodeToEmail ||
                    this.AddAccessCodeToEmail != null &&
                    this.AddAccessCodeToEmail.Equals(other.AddAccessCodeToEmail)
                ) && 
                (
                    this.RequireIdLookup == other.RequireIdLookup ||
                    this.RequireIdLookup != null &&
                    this.RequireIdLookup.Equals(other.RequireIdLookup)
                ) && 
                (
                    this.IdCheckConfigurationName == other.IdCheckConfigurationName ||
                    this.IdCheckConfigurationName != null &&
                    this.IdCheckConfigurationName.Equals(other.IdCheckConfigurationName)
                ) && 
                (
                    this.SocialAuthentications == other.SocialAuthentications ||
                    this.SocialAuthentications != null &&
                    this.SocialAuthentications.SequenceEqual(other.SocialAuthentications)
                ) && 
                (
                    this.PhoneAuthentication == other.PhoneAuthentication ||
                    this.PhoneAuthentication != null &&
                    this.PhoneAuthentication.Equals(other.PhoneAuthentication)
                ) && 
                (
                    this.SamlAuthentication == other.SamlAuthentication ||
                    this.SamlAuthentication != null &&
                    this.SamlAuthentication.Equals(other.SamlAuthentication)
                ) && 
                (
                    this.SmsAuthentication == other.SmsAuthentication ||
                    this.SmsAuthentication != null &&
                    this.SmsAuthentication.Equals(other.SmsAuthentication)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.ClientUserId == other.ClientUserId ||
                    this.ClientUserId != null &&
                    this.ClientUserId.Equals(other.ClientUserId)
                ) && 
                (
                    this.EmbeddedRecipientStartURL == other.EmbeddedRecipientStartURL ||
                    this.EmbeddedRecipientStartURL != null &&
                    this.EmbeddedRecipientStartURL.Equals(other.EmbeddedRecipientStartURL)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) && 
                (
                    this.RoutingOrder == other.RoutingOrder ||
                    this.RoutingOrder != null &&
                    this.RoutingOrder.Equals(other.RoutingOrder)
                ) && 
                (
                    this.IdCheckInformationInput == other.IdCheckInformationInput ||
                    this.IdCheckInformationInput != null &&
                    this.IdCheckInformationInput.Equals(other.IdCheckInformationInput)
                ) && 
                (
                    this.RecipientAttachments == other.RecipientAttachments ||
                    this.RecipientAttachments != null &&
                    this.RecipientAttachments.SequenceEqual(other.RecipientAttachments)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.RoleName == other.RoleName ||
                    this.RoleName != null &&
                    this.RoleName.Equals(other.RoleName)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SignedDateTime == other.SignedDateTime ||
                    this.SignedDateTime != null &&
                    this.SignedDateTime.Equals(other.SignedDateTime)
                ) && 
                (
                    this.DeliveredDateTime == other.DeliveredDateTime ||
                    this.DeliveredDateTime != null &&
                    this.DeliveredDateTime.Equals(other.DeliveredDateTime)
                ) && 
                (
                    this.DeclinedDateTime == other.DeclinedDateTime ||
                    this.DeclinedDateTime != null &&
                    this.DeclinedDateTime.Equals(other.DeclinedDateTime)
                ) && 
                (
                    this.SentDateTime == other.SentDateTime ||
                    this.SentDateTime != null &&
                    this.SentDateTime.Equals(other.SentDateTime)
                ) && 
                (
                    this.DeclinedReason == other.DeclinedReason ||
                    this.DeclinedReason != null &&
                    this.DeclinedReason.Equals(other.DeclinedReason)
                ) && 
                (
                    this.DeliveryMethod == other.DeliveryMethod ||
                    this.DeliveryMethod != null &&
                    this.DeliveryMethod.Equals(other.DeliveryMethod)
                ) && 
                (
                    this.FaxNumber == other.FaxNumber ||
                    this.FaxNumber != null &&
                    this.FaxNumber.Equals(other.FaxNumber)
                ) && 
                (
                    this.TemplateLocked == other.TemplateLocked ||
                    this.TemplateLocked != null &&
                    this.TemplateLocked.Equals(other.TemplateLocked)
                ) && 
                (
                    this.TemplateRequired == other.TemplateRequired ||
                    this.TemplateRequired != null &&
                    this.TemplateRequired.Equals(other.TemplateRequired)
                ) && 
                (
                    this.EmailNotification == other.EmailNotification ||
                    this.EmailNotification != null &&
                    this.EmailNotification.Equals(other.EmailNotification)
                ) && 
                (
                    this.InheritEmailNotificationConfiguration == other.InheritEmailNotificationConfiguration ||
                    this.InheritEmailNotificationConfiguration != null &&
                    this.InheritEmailNotificationConfiguration.Equals(other.InheritEmailNotificationConfiguration)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.RecipientAuthenticationStatus == other.RecipientAuthenticationStatus ||
                    this.RecipientAuthenticationStatus != null &&
                    this.RecipientAuthenticationStatus.Equals(other.RecipientAuthenticationStatus)
                ) && 
                (
                    this.TotalTabCount == other.TotalTabCount ||
                    this.TotalTabCount != null &&
                    this.TotalTabCount.Equals(other.TotalTabCount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.ExcludedDocuments != null)
                    hash = hash * 57 + this.ExcludedDocuments.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                if (this.EmailRecipientPostSigningURL != null)
                    hash = hash * 57 + this.EmailRecipientPostSigningURL.GetHashCode();
                
                if (this.SigningGroupId != null)
                    hash = hash * 57 + this.SigningGroupId.GetHashCode();
                
                if (this.SigningGroupName != null)
                    hash = hash * 57 + this.SigningGroupName.GetHashCode();
                
                if (this.SigningGroupUsers != null)
                    hash = hash * 57 + this.SigningGroupUsers.GetHashCode();
                
                if (this.RecipientId != null)
                    hash = hash * 57 + this.RecipientId.GetHashCode();
                
                if (this.RecipientIdGuid != null)
                    hash = hash * 57 + this.RecipientIdGuid.GetHashCode();
                
                if (this.AccessCode != null)
                    hash = hash * 57 + this.AccessCode.GetHashCode();
                
                if (this.AddAccessCodeToEmail != null)
                    hash = hash * 57 + this.AddAccessCodeToEmail.GetHashCode();
                
                if (this.RequireIdLookup != null)
                    hash = hash * 57 + this.RequireIdLookup.GetHashCode();
                
                if (this.IdCheckConfigurationName != null)
                    hash = hash * 57 + this.IdCheckConfigurationName.GetHashCode();
                
                if (this.SocialAuthentications != null)
                    hash = hash * 57 + this.SocialAuthentications.GetHashCode();
                
                if (this.PhoneAuthentication != null)
                    hash = hash * 57 + this.PhoneAuthentication.GetHashCode();
                
                if (this.SamlAuthentication != null)
                    hash = hash * 57 + this.SamlAuthentication.GetHashCode();
                
                if (this.SmsAuthentication != null)
                    hash = hash * 57 + this.SmsAuthentication.GetHashCode();
                
                if (this.UserId != null)
                    hash = hash * 57 + this.UserId.GetHashCode();
                
                if (this.ClientUserId != null)
                    hash = hash * 57 + this.ClientUserId.GetHashCode();
                
                if (this.EmbeddedRecipientStartURL != null)
                    hash = hash * 57 + this.EmbeddedRecipientStartURL.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 57 + this.CustomFields.GetHashCode();
                
                if (this.RoutingOrder != null)
                    hash = hash * 57 + this.RoutingOrder.GetHashCode();
                
                if (this.IdCheckInformationInput != null)
                    hash = hash * 57 + this.IdCheckInformationInput.GetHashCode();
                
                if (this.RecipientAttachments != null)
                    hash = hash * 57 + this.RecipientAttachments.GetHashCode();
                
                if (this.Note != null)
                    hash = hash * 57 + this.Note.GetHashCode();
                
                if (this.RoleName != null)
                    hash = hash * 57 + this.RoleName.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.SignedDateTime != null)
                    hash = hash * 57 + this.SignedDateTime.GetHashCode();
                
                if (this.DeliveredDateTime != null)
                    hash = hash * 57 + this.DeliveredDateTime.GetHashCode();
                
                if (this.DeclinedDateTime != null)
                    hash = hash * 57 + this.DeclinedDateTime.GetHashCode();
                
                if (this.SentDateTime != null)
                    hash = hash * 57 + this.SentDateTime.GetHashCode();
                
                if (this.DeclinedReason != null)
                    hash = hash * 57 + this.DeclinedReason.GetHashCode();
                
                if (this.DeliveryMethod != null)
                    hash = hash * 57 + this.DeliveryMethod.GetHashCode();
                
                if (this.FaxNumber != null)
                    hash = hash * 57 + this.FaxNumber.GetHashCode();
                
                if (this.TemplateLocked != null)
                    hash = hash * 57 + this.TemplateLocked.GetHashCode();
                
                if (this.TemplateRequired != null)
                    hash = hash * 57 + this.TemplateRequired.GetHashCode();
                
                if (this.EmailNotification != null)
                    hash = hash * 57 + this.EmailNotification.GetHashCode();
                
                if (this.InheritEmailNotificationConfiguration != null)
                    hash = hash * 57 + this.InheritEmailNotificationConfiguration.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                if (this.RecipientAuthenticationStatus != null)
                    hash = hash * 57 + this.RecipientAuthenticationStatus.GetHashCode();
                
                if (this.TotalTabCount != null)
                    hash = hash * 57 + this.TotalTabCount.GetHashCode();
                
                return hash;
            }
        }

    }
}
