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
    public class Company : IEquatable<Company>
    {
        
        /// <summary>
        /// Specifies the tool tip text for the tab.
        /// </summary>
        /// <value>Specifies the tool tip text for the tab.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Specifies the value of the tab.
        /// </summary>
        /// <value>Specifies the value of the tab.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
  
        
        /// <summary>
        /// The initial value of the tab when it was sent to the recipient.
        /// </summary>
        /// <value>The initial value of the tab when it was sent to the recipient.</value>
        [DataMember(Name="originalValue", EmitDefaultValue=false)]
        public string OriginalValue { get; set; }
  
        
        /// <summary>
        /// Width of the tab in pixels.
        /// </summary>
        /// <value>Width of the tab in pixels.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the signer is required to fill out this tab
        /// </summary>
        /// <value>When set to **true**, the signer is required to fill out this tab</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public string Required { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the signer cannot change the data of the custom tab.
        /// </summary>
        /// <value>When set to **true**, the signer cannot change the data of the custom tab.</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public string Locked { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the field appears normally while the recipient is adding or modifying the information in the field, but the data is not visible (the characters are hidden by asterisks) to any other signer or the sender.\n\nWhen an envelope is completed the information is available to the sender through the Form Data link in the DocuSign Console.\n\nThis setting applies only to text boxes and does not affect list boxes, radio buttons, or check boxes.
        /// </summary>
        /// <value>When set to **true**, the field appears normally while the recipient is adding or modifying the information in the field, but the data is not visible (the characters are hidden by asterisks) to any other signer or the sender.\n\nWhen an envelope is completed the information is available to the sender through the Form Data link in the DocuSign Console.\n\nThis setting applies only to text boxes and does not affect list boxes, radio buttons, or check boxes.</value>
        [DataMember(Name="concealValueOnDocument", EmitDefaultValue=false)]
        public string ConcealValueOnDocument { get; set; }
  
        
        /// <summary>
        /// When set to **true**, disables the auto sizing of single line text boxes in the signing screen when the signer enters data. If disabled users will only be able enter as much data as the text box can hold. By default this is false. This property only affects single line text boxes.
        /// </summary>
        /// <value>When set to **true**, disables the auto sizing of single line text boxes in the signing screen when the signer enters data. If disabled users will only be able enter as much data as the text box can hold. By default this is false. This property only affects single line text boxes.</value>
        [DataMember(Name="disableAutoSize", EmitDefaultValue=false)]
        public string DisableAutoSize { get; set; }
  
        
        /// <summary>
        /// An optional value that describes the maximum length of the property when the property is a string.
        /// </summary>
        /// <value>An optional value that describes the maximum length of the property when the property is a string.</value>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }
  
        
        /// <summary>
        /// The label string associated with the tab.
        /// </summary>
        /// <value>The label string associated with the tab.</value>
        [DataMember(Name="tabLabel", EmitDefaultValue=false)]
        public string TabLabel { get; set; }
  
        
        /// <summary>
        /// The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default.
        /// </summary>
        /// <value>The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default.</value>
        [DataMember(Name="font", EmitDefaultValue=false)]
        public string Font { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the information in the tab is bold.
        /// </summary>
        /// <value>When set to **true**, the information in the tab is bold.</value>
        [DataMember(Name="bold", EmitDefaultValue=false)]
        public string Bold { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the information in the tab is italic.
        /// </summary>
        /// <value>When set to **true**, the information in the tab is italic.</value>
        [DataMember(Name="italic", EmitDefaultValue=false)]
        public string Italic { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the information in the tab is underlined.
        /// </summary>
        /// <value>When set to **true**, the information in the tab is underlined.</value>
        [DataMember(Name="underline", EmitDefaultValue=false)]
        public string Underline { get; set; }
  
        
        /// <summary>
        /// The font color used for the information in the tab.\n\nPossible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White.
        /// </summary>
        /// <value>The font color used for the information in the tab.\n\nPossible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White.</value>
        [DataMember(Name="fontColor", EmitDefaultValue=false)]
        public string FontColor { get; set; }
  
        
        /// <summary>
        /// The font size used for the information in the tab.\n\nPossible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72.
        /// </summary>
        /// <value>The font size used for the information in the tab.\n\nPossible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72.</value>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public string FontSize { get; set; }
  
        
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
            sb.Append("class Company {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  OriginalValue: ").Append(OriginalValue).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  ConcealValueOnDocument: ").Append(ConcealValueOnDocument).Append("\n");
            sb.Append("  DisableAutoSize: ").Append(DisableAutoSize).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  TabLabel: ").Append(TabLabel).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  Bold: ").Append(Bold).Append("\n");
            sb.Append("  Italic: ").Append(Italic).Append("\n");
            sb.Append("  Underline: ").Append(Underline).Append("\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
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
            return this.Equals(obj as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="other">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company other)
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
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.OriginalValue == other.OriginalValue ||
                    this.OriginalValue != null &&
                    this.OriginalValue.Equals(other.OriginalValue)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.ConcealValueOnDocument == other.ConcealValueOnDocument ||
                    this.ConcealValueOnDocument != null &&
                    this.ConcealValueOnDocument.Equals(other.ConcealValueOnDocument)
                ) && 
                (
                    this.DisableAutoSize == other.DisableAutoSize ||
                    this.DisableAutoSize != null &&
                    this.DisableAutoSize.Equals(other.DisableAutoSize)
                ) && 
                (
                    this.MaxLength == other.MaxLength ||
                    this.MaxLength != null &&
                    this.MaxLength.Equals(other.MaxLength)
                ) && 
                (
                    this.TabLabel == other.TabLabel ||
                    this.TabLabel != null &&
                    this.TabLabel.Equals(other.TabLabel)
                ) && 
                (
                    this.Font == other.Font ||
                    this.Font != null &&
                    this.Font.Equals(other.Font)
                ) && 
                (
                    this.Bold == other.Bold ||
                    this.Bold != null &&
                    this.Bold.Equals(other.Bold)
                ) && 
                (
                    this.Italic == other.Italic ||
                    this.Italic != null &&
                    this.Italic.Equals(other.Italic)
                ) && 
                (
                    this.Underline == other.Underline ||
                    this.Underline != null &&
                    this.Underline.Equals(other.Underline)
                ) && 
                (
                    this.FontColor == other.FontColor ||
                    this.FontColor != null &&
                    this.FontColor.Equals(other.FontColor)
                ) && 
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
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
                
                if (this.Value != null)
                    hash = hash * 57 + this.Value.GetHashCode();
                
                if (this.OriginalValue != null)
                    hash = hash * 57 + this.OriginalValue.GetHashCode();
                
                if (this.Width != null)
                    hash = hash * 57 + this.Width.GetHashCode();
                
                if (this.Required != null)
                    hash = hash * 57 + this.Required.GetHashCode();
                
                if (this.Locked != null)
                    hash = hash * 57 + this.Locked.GetHashCode();
                
                if (this.ConcealValueOnDocument != null)
                    hash = hash * 57 + this.ConcealValueOnDocument.GetHashCode();
                
                if (this.DisableAutoSize != null)
                    hash = hash * 57 + this.DisableAutoSize.GetHashCode();
                
                if (this.MaxLength != null)
                    hash = hash * 57 + this.MaxLength.GetHashCode();
                
                if (this.TabLabel != null)
                    hash = hash * 57 + this.TabLabel.GetHashCode();
                
                if (this.Font != null)
                    hash = hash * 57 + this.Font.GetHashCode();
                
                if (this.Bold != null)
                    hash = hash * 57 + this.Bold.GetHashCode();
                
                if (this.Italic != null)
                    hash = hash * 57 + this.Italic.GetHashCode();
                
                if (this.Underline != null)
                    hash = hash * 57 + this.Underline.GetHashCode();
                
                if (this.FontColor != null)
                    hash = hash * 57 + this.FontColor.GetHashCode();
                
                if (this.FontSize != null)
                    hash = hash * 57 + this.FontSize.GetHashCode();
                
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
