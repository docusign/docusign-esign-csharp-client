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
    public class TemplateRole : IEquatable<TemplateRole>
    {
        
        /// <summary>
        /// Specifies the email associated with a role name.
        /// </summary>
        /// <value>Specifies the email associated with a role name.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// Optional element. Specifies the role name associated with the recipient.<br/><br/>This is required when working with template recipients.
        /// </summary>
        /// <value>Optional element. Specifies the role name associated with the recipient.<br/><br/>This is required when working with template recipients.</value>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; set; }
  
        
        /// <summary>
        /// Specifies the recipient's name.
        /// </summary>
        /// <value>Specifies the recipient's name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// When set to **true** and the feature is enabled in the sender's account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).
        /// </summary>
        /// <value>When set to **true** and the feature is enabled in the sender's account, the signing recipient is required to draw signatures and initials at each signature/initial tab ( instead of adopting a signature/initial style or only drawing a signature/initial once).</value>
        [DataMember(Name="signingGroupId", EmitDefaultValue=false)]
        public string SigningGroupId { get; set; }
  
        
        /// <summary>
        /// Specifies the full legal name of the signer in person signer template roles.\n\nMaximum Length: 100 characters.
        /// </summary>
        /// <value>Specifies the full legal name of the signer in person signer template roles.\n\nMaximum Length: 100 characters.</value>
        [DataMember(Name="inPersonSignerName", EmitDefaultValue=false)]
        public string InPersonSignerName { get; set; }
  
        
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
        /// When set to **true**, this recipient is the default recipient and any tabs generated by the transformPdfFields option are mapped to this recipient.
        /// </summary>
        /// <value>When set to **true**, this recipient is the default recipient and any tabs generated by the transformPdfFields option are mapped to this recipient.</value>
        [DataMember(Name="defaultRecipient", EmitDefaultValue=false)]
        public string DefaultRecipient { get; set; }
  
        
        /// <summary>
        /// If a value is provided, the recipient must enter the value as the access code to view and sign the envelope. \n\nMaximum Length: 50 characters and must conform to account’s access code format setting.\n\nIf blank, but the signer `accessCode` property is set in the envelope, then that value is used.\n\nIf blank and the signer `accessCode` property is not set, then access code is not required.
        /// </summary>
        /// <value>If a value is provided, the recipient must enter the value as the access code to view and sign the envelope. \n\nMaximum Length: 50 characters and must conform to account’s access code format setting.\n\nIf blank, but the signer `accessCode` property is set in the envelope, then that value is used.\n\nIf blank and the signer `accessCode` property is not set, then access code is not required.</value>
        [DataMember(Name="accessCode", EmitDefaultValue=false)]
        public string AccessCode { get; set; }
  
        
        /// <summary>
        /// Specifies the routing order of the recipient in the envelope.
        /// </summary>
        /// <value>Specifies the routing order of the recipient in the envelope.</value>
        [DataMember(Name="routingOrder", EmitDefaultValue=false)]
        public string RoutingOrder { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EmailNotification
        /// </summary>
        [DataMember(Name="emailNotification", EmitDefaultValue=false)]
        public RecipientEmailNotification EmailNotification { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Tabs
        /// </summary>
        [DataMember(Name="tabs", EmitDefaultValue=false)]
        public Tabs Tabs { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateRole {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SigningGroupId: ").Append(SigningGroupId).Append("\n");
            sb.Append("  InPersonSignerName: ").Append(InPersonSignerName).Append("\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  EmbeddedRecipientStartURL: ").Append(EmbeddedRecipientStartURL).Append("\n");
            sb.Append("  DefaultRecipient: ").Append(DefaultRecipient).Append("\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  RoutingOrder: ").Append(RoutingOrder).Append("\n");
            sb.Append("  EmailNotification: ").Append(EmailNotification).Append("\n");
            sb.Append("  Tabs: ").Append(Tabs).Append("\n");
            
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
            return this.Equals(obj as TemplateRole);
        }

        /// <summary>
        /// Returns true if TemplateRole instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateRole other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.RoleName == other.RoleName ||
                    this.RoleName != null &&
                    this.RoleName.Equals(other.RoleName)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SigningGroupId == other.SigningGroupId ||
                    this.SigningGroupId != null &&
                    this.SigningGroupId.Equals(other.SigningGroupId)
                ) && 
                (
                    this.InPersonSignerName == other.InPersonSignerName ||
                    this.InPersonSignerName != null &&
                    this.InPersonSignerName.Equals(other.InPersonSignerName)
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
                    this.DefaultRecipient == other.DefaultRecipient ||
                    this.DefaultRecipient != null &&
                    this.DefaultRecipient.Equals(other.DefaultRecipient)
                ) && 
                (
                    this.AccessCode == other.AccessCode ||
                    this.AccessCode != null &&
                    this.AccessCode.Equals(other.AccessCode)
                ) && 
                (
                    this.RoutingOrder == other.RoutingOrder ||
                    this.RoutingOrder != null &&
                    this.RoutingOrder.Equals(other.RoutingOrder)
                ) && 
                (
                    this.EmailNotification == other.EmailNotification ||
                    this.EmailNotification != null &&
                    this.EmailNotification.Equals(other.EmailNotification)
                ) && 
                (
                    this.Tabs == other.Tabs ||
                    this.Tabs != null &&
                    this.Tabs.Equals(other.Tabs)
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
                
                if (this.Email != null)
                    hash = hash * 57 + this.Email.GetHashCode();
                
                if (this.RoleName != null)
                    hash = hash * 57 + this.RoleName.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.SigningGroupId != null)
                    hash = hash * 57 + this.SigningGroupId.GetHashCode();
                
                if (this.InPersonSignerName != null)
                    hash = hash * 57 + this.InPersonSignerName.GetHashCode();
                
                if (this.ClientUserId != null)
                    hash = hash * 57 + this.ClientUserId.GetHashCode();
                
                if (this.EmbeddedRecipientStartURL != null)
                    hash = hash * 57 + this.EmbeddedRecipientStartURL.GetHashCode();
                
                if (this.DefaultRecipient != null)
                    hash = hash * 57 + this.DefaultRecipient.GetHashCode();
                
                if (this.AccessCode != null)
                    hash = hash * 57 + this.AccessCode.GetHashCode();
                
                if (this.RoutingOrder != null)
                    hash = hash * 57 + this.RoutingOrder.GetHashCode();
                
                if (this.EmailNotification != null)
                    hash = hash * 57 + this.EmailNotification.GetHashCode();
                
                if (this.Tabs != null)
                    hash = hash * 57 + this.Tabs.GetHashCode();
                
                return hash;
            }
        }

    }
}
