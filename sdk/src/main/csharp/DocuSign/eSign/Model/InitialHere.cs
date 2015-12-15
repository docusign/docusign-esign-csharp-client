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
    public class InitialHere : IEquatable<InitialHere>
    {
        
        /// <summary>
        /// Specifies the tool tip text for the tab.
        /// </summary>
        /// <value>Specifies the tool tip text for the tab.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// The label string associated with the tab.
        /// </summary>
        /// <value>The label string associated with the tab.</value>
        [DataMember(Name="tabLabel", EmitDefaultValue=false)]
        public string TabLabel { get; set; }
  
        
        /// <summary>
        /// Sets the size for the InitialHere tab. It can be value from 0.5 to 1.0, where 1.0 represents full size and 0.5 is 50% size.
        /// </summary>
        /// <value>Sets the size for the InitialHere tab. It can be value from 0.5 to 1.0, where 1.0 represents full size and 0.5 is 50% size.</value>
        [DataMember(Name="scaleValue", EmitDefaultValue=false)]
        public Object ScaleValue { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="optional", EmitDefaultValue=false)]
        public string Optional { get; set; }
  
        
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document's ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
  
        
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
  
        
        /// <summary>
        /// Specifies the page number on which the tab is located.
        /// </summary>
        /// <value>Specifies the page number on which the tab is located.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public string PageNumber { get; set; }
  
        
        /// <summary>
        /// This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position.
        /// </summary>
        /// <value>This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position.</value>
        [DataMember(Name="xPosition", EmitDefaultValue=false)]
        public string XPosition { get; set; }
  
        
        /// <summary>
        /// This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position.
        /// </summary>
        /// <value>This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position.</value>
        [DataMember(Name="yPosition", EmitDefaultValue=false)]
        public string YPosition { get; set; }
  
        
        /// <summary>
        /// Anchor text information for a radio button.
        /// </summary>
        /// <value>Anchor text information for a radio button.</value>
        [DataMember(Name="anchorString", EmitDefaultValue=false)]
        public string AnchorString { get; set; }
  
        
        /// <summary>
        /// Specifies the X axis location of the tab, in achorUnits, relative to the anchorString.
        /// </summary>
        /// <value>Specifies the X axis location of the tab, in achorUnits, relative to the anchorString.</value>
        [DataMember(Name="anchorXOffset", EmitDefaultValue=false)]
        public string AnchorXOffset { get; set; }
  
        
        /// <summary>
        /// Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString.
        /// </summary>
        /// <value>Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString.</value>
        [DataMember(Name="anchorYOffset", EmitDefaultValue=false)]
        public string AnchorYOffset { get; set; }
  
        
        /// <summary>
        /// Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches.
        /// </summary>
        /// <value>Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches.</value>
        [DataMember(Name="anchorUnits", EmitDefaultValue=false)]
        public string AnchorUnits { get; set; }
  
        
        /// <summary>
        /// When set to **true**, this tab is ignored if anchorString is not found in the document.
        /// </summary>
        /// <value>When set to **true**, this tab is ignored if anchorString is not found in the document.</value>
        [DataMember(Name="anchorIgnoreIfNotPresent", EmitDefaultValue=false)]
        public string AnchorIgnoreIfNotPresent { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="anchorCaseSensitive", EmitDefaultValue=false)]
        public string AnchorCaseSensitive { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="anchorMatchWholeWord", EmitDefaultValue=false)]
        public string AnchorMatchWholeWord { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="anchorHorizontalAlignment", EmitDefaultValue=false)]
        public string AnchorHorizontalAlignment { get; set; }
  
        
        /// <summary>
        /// The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].
        /// </summary>
        /// <value>The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].</value>
        [DataMember(Name="tabId", EmitDefaultValue=false)]
        public string TabId { get; set; }
  
        
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
        /// For conditional fields this is the TabLabel of the parent tab that controls this tab's visibility.
        /// </summary>
        /// <value>For conditional fields this is the TabLabel of the parent tab that controls this tab's visibility.</value>
        [DataMember(Name="conditionalParentLabel", EmitDefaultValue=false)]
        public string ConditionalParentLabel { get; set; }
  
        
        /// <summary>
        /// For conditional fields, this is the value of the parent tab that controls the tab's visibility.\n\nIf the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \"on\" as the value to show that the parent tab is active.
        /// </summary>
        /// <value>For conditional fields, this is the value of the parent tab that controls the tab's visibility.\n\nIf the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \"on\" as the value to show that the parent tab is active.</value>
        [DataMember(Name="conditionalParentValue", EmitDefaultValue=false)]
        public string ConditionalParentValue { get; set; }
  
        
        /// <summary>
        /// The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties.
        /// </summary>
        /// <value>The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties.</value>
        [DataMember(Name="customTabId", EmitDefaultValue=false)]
        public string CustomTabId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MergeField
        /// </summary>
        [DataMember(Name="mergeField", EmitDefaultValue=false)]
        public MergeField MergeField { get; set; }
  
        
        /// <summary>
        /// Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:\n\n* sent - The envelope is sent to the recipients. \n* created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitialHere {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TabLabel: ").Append(TabLabel).Append("\n");
            sb.Append("  ScaleValue: ").Append(ScaleValue).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  XPosition: ").Append(XPosition).Append("\n");
            sb.Append("  YPosition: ").Append(YPosition).Append("\n");
            sb.Append("  AnchorString: ").Append(AnchorString).Append("\n");
            sb.Append("  AnchorXOffset: ").Append(AnchorXOffset).Append("\n");
            sb.Append("  AnchorYOffset: ").Append(AnchorYOffset).Append("\n");
            sb.Append("  AnchorUnits: ").Append(AnchorUnits).Append("\n");
            sb.Append("  AnchorIgnoreIfNotPresent: ").Append(AnchorIgnoreIfNotPresent).Append("\n");
            sb.Append("  AnchorCaseSensitive: ").Append(AnchorCaseSensitive).Append("\n");
            sb.Append("  AnchorMatchWholeWord: ").Append(AnchorMatchWholeWord).Append("\n");
            sb.Append("  AnchorHorizontalAlignment: ").Append(AnchorHorizontalAlignment).Append("\n");
            sb.Append("  TabId: ").Append(TabId).Append("\n");
            sb.Append("  TemplateLocked: ").Append(TemplateLocked).Append("\n");
            sb.Append("  TemplateRequired: ").Append(TemplateRequired).Append("\n");
            sb.Append("  ConditionalParentLabel: ").Append(ConditionalParentLabel).Append("\n");
            sb.Append("  ConditionalParentValue: ").Append(ConditionalParentValue).Append("\n");
            sb.Append("  CustomTabId: ").Append(CustomTabId).Append("\n");
            sb.Append("  MergeField: ").Append(MergeField).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            
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
            return this.Equals(obj as InitialHere);
        }

        /// <summary>
        /// Returns true if InitialHere instances are equal
        /// </summary>
        /// <param name="other">Instance of InitialHere to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitialHere other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.TabLabel == other.TabLabel ||
                    this.TabLabel != null &&
                    this.TabLabel.Equals(other.TabLabel)
                ) && 
                (
                    this.ScaleValue == other.ScaleValue ||
                    this.ScaleValue != null &&
                    this.ScaleValue.Equals(other.ScaleValue)
                ) && 
                (
                    this.Optional == other.Optional ||
                    this.Optional != null &&
                    this.Optional.Equals(other.Optional)
                ) && 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.XPosition == other.XPosition ||
                    this.XPosition != null &&
                    this.XPosition.Equals(other.XPosition)
                ) && 
                (
                    this.YPosition == other.YPosition ||
                    this.YPosition != null &&
                    this.YPosition.Equals(other.YPosition)
                ) && 
                (
                    this.AnchorString == other.AnchorString ||
                    this.AnchorString != null &&
                    this.AnchorString.Equals(other.AnchorString)
                ) && 
                (
                    this.AnchorXOffset == other.AnchorXOffset ||
                    this.AnchorXOffset != null &&
                    this.AnchorXOffset.Equals(other.AnchorXOffset)
                ) && 
                (
                    this.AnchorYOffset == other.AnchorYOffset ||
                    this.AnchorYOffset != null &&
                    this.AnchorYOffset.Equals(other.AnchorYOffset)
                ) && 
                (
                    this.AnchorUnits == other.AnchorUnits ||
                    this.AnchorUnits != null &&
                    this.AnchorUnits.Equals(other.AnchorUnits)
                ) && 
                (
                    this.AnchorIgnoreIfNotPresent == other.AnchorIgnoreIfNotPresent ||
                    this.AnchorIgnoreIfNotPresent != null &&
                    this.AnchorIgnoreIfNotPresent.Equals(other.AnchorIgnoreIfNotPresent)
                ) && 
                (
                    this.AnchorCaseSensitive == other.AnchorCaseSensitive ||
                    this.AnchorCaseSensitive != null &&
                    this.AnchorCaseSensitive.Equals(other.AnchorCaseSensitive)
                ) && 
                (
                    this.AnchorMatchWholeWord == other.AnchorMatchWholeWord ||
                    this.AnchorMatchWholeWord != null &&
                    this.AnchorMatchWholeWord.Equals(other.AnchorMatchWholeWord)
                ) && 
                (
                    this.AnchorHorizontalAlignment == other.AnchorHorizontalAlignment ||
                    this.AnchorHorizontalAlignment != null &&
                    this.AnchorHorizontalAlignment.Equals(other.AnchorHorizontalAlignment)
                ) && 
                (
                    this.TabId == other.TabId ||
                    this.TabId != null &&
                    this.TabId.Equals(other.TabId)
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
                    this.ConditionalParentLabel == other.ConditionalParentLabel ||
                    this.ConditionalParentLabel != null &&
                    this.ConditionalParentLabel.Equals(other.ConditionalParentLabel)
                ) && 
                (
                    this.ConditionalParentValue == other.ConditionalParentValue ||
                    this.ConditionalParentValue != null &&
                    this.ConditionalParentValue.Equals(other.ConditionalParentValue)
                ) && 
                (
                    this.CustomTabId == other.CustomTabId ||
                    this.CustomTabId != null &&
                    this.CustomTabId.Equals(other.CustomTabId)
                ) && 
                (
                    this.MergeField == other.MergeField ||
                    this.MergeField != null &&
                    this.MergeField.Equals(other.MergeField)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
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
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.TabLabel != null)
                    hash = hash * 57 + this.TabLabel.GetHashCode();
                
                if (this.ScaleValue != null)
                    hash = hash * 57 + this.ScaleValue.GetHashCode();
                
                if (this.Optional != null)
                    hash = hash * 57 + this.Optional.GetHashCode();
                
                if (this.DocumentId != null)
                    hash = hash * 57 + this.DocumentId.GetHashCode();
                
                if (this.RecipientId != null)
                    hash = hash * 57 + this.RecipientId.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 57 + this.PageNumber.GetHashCode();
                
                if (this.XPosition != null)
                    hash = hash * 57 + this.XPosition.GetHashCode();
                
                if (this.YPosition != null)
                    hash = hash * 57 + this.YPosition.GetHashCode();
                
                if (this.AnchorString != null)
                    hash = hash * 57 + this.AnchorString.GetHashCode();
                
                if (this.AnchorXOffset != null)
                    hash = hash * 57 + this.AnchorXOffset.GetHashCode();
                
                if (this.AnchorYOffset != null)
                    hash = hash * 57 + this.AnchorYOffset.GetHashCode();
                
                if (this.AnchorUnits != null)
                    hash = hash * 57 + this.AnchorUnits.GetHashCode();
                
                if (this.AnchorIgnoreIfNotPresent != null)
                    hash = hash * 57 + this.AnchorIgnoreIfNotPresent.GetHashCode();
                
                if (this.AnchorCaseSensitive != null)
                    hash = hash * 57 + this.AnchorCaseSensitive.GetHashCode();
                
                if (this.AnchorMatchWholeWord != null)
                    hash = hash * 57 + this.AnchorMatchWholeWord.GetHashCode();
                
                if (this.AnchorHorizontalAlignment != null)
                    hash = hash * 57 + this.AnchorHorizontalAlignment.GetHashCode();
                
                if (this.TabId != null)
                    hash = hash * 57 + this.TabId.GetHashCode();
                
                if (this.TemplateLocked != null)
                    hash = hash * 57 + this.TemplateLocked.GetHashCode();
                
                if (this.TemplateRequired != null)
                    hash = hash * 57 + this.TemplateRequired.GetHashCode();
                
                if (this.ConditionalParentLabel != null)
                    hash = hash * 57 + this.ConditionalParentLabel.GetHashCode();
                
                if (this.ConditionalParentValue != null)
                    hash = hash * 57 + this.ConditionalParentValue.GetHashCode();
                
                if (this.CustomTabId != null)
                    hash = hash * 57 + this.CustomTabId.GetHashCode();
                
                if (this.MergeField != null)
                    hash = hash * 57 + this.MergeField.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.ErrorDetails != null)
                    hash = hash * 57 + this.ErrorDetails.GetHashCode();
                
                return hash;
            }
        }

    }
}
