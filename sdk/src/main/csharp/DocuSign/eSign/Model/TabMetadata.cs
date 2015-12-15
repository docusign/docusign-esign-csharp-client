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
    public class TabMetadata : IEquatable<TabMetadata>
    {
        
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
        /// Height of the tab in pixels.
        /// </summary>
        /// <value>Height of the tab in pixels.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public string Height { get; set; }
  
        
        /// <summary>
        /// Width of the tab in pixels.
        /// </summary>
        /// <value>Width of the tab in pixels.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public string Width { get; set; }
  
        
        /// <summary>
        /// The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties.
        /// </summary>
        /// <value>The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties.</value>
        [DataMember(Name="customTabId", EmitDefaultValue=false)]
        public string CustomTabId { get; set; }
  
        
        /// <summary>
        /// The original value of the tab.
        /// </summary>
        /// <value>The original value of the tab.</value>
        [DataMember(Name="initialValue", EmitDefaultValue=false)]
        public string InitialValue { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the tab is included in e-mails related to the envelope on which it exists. This applies to only specific tabs.
        /// </summary>
        /// <value>When set to **true**, the tab is included in e-mails related to the envelope on which it exists. This applies to only specific tabs.</value>
        [DataMember(Name="includedInEmail", EmitDefaultValue=false)]
        public string IncludedInEmail { get; set; }
  
        
        /// <summary>
        /// When set to **true**, disables the auto sizing of single line text boxes in the signing screen when the signer enters data. If disabled users will only be able enter as much data as the text box can hold. By default this is false. This property only affects single line text boxes.
        /// </summary>
        /// <value>When set to **true**, disables the auto sizing of single line text boxes in the signing screen when the signer enters data. If disabled users will only be able enter as much data as the text box can hold. By default this is false. This property only affects single line text boxes.</value>
        [DataMember(Name="disableAutoSize", EmitDefaultValue=false)]
        public string DisableAutoSize { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the field appears normally while the recipient is adding or modifying the information in the field, but the data is not visible (the characters are hidden by asterisks) to any other signer or the sender.\n\nWhen an envelope is completed the information is available to the sender through the Form Data link in the DocuSign Console.\n\nThis setting applies only to text boxes and does not affect list boxes, radio buttons, or check boxes.
        /// </summary>
        /// <value>When set to **true**, the field appears normally while the recipient is adding or modifying the information in the field, but the data is not visible (the characters are hidden by asterisks) to any other signer or the sender.\n\nWhen an envelope is completed the information is available to the sender through the Form Data link in the DocuSign Console.\n\nThis setting applies only to text boxes and does not affect list boxes, radio buttons, or check boxes.</value>
        [DataMember(Name="concealValueOnDocument", EmitDefaultValue=false)]
        public string ConcealValueOnDocument { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the signer cannot change the data of the custom tab.
        /// </summary>
        /// <value>When set to **true**, the signer cannot change the data of the custom tab.</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public string Locked { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the signer is required to fill out this tab
        /// </summary>
        /// <value>When set to **true**, the signer is required to fill out this tab</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public string Required { get; set; }
  
        
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
  
        
        /// <summary>
        /// If the tab is a list, this represents the values that are possible for the tab.
        /// </summary>
        /// <value>If the tab is a list, this represents the values that are possible for the tab.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }
  
        
        /// <summary>
        /// The label string associated with the tab.
        /// </summary>
        /// <value>The label string associated with the tab.</value>
        [DataMember(Name="tabLabel", EmitDefaultValue=false)]
        public string TabLabel { get; set; }
  
        
        /// <summary>
        /// The maximum number of entry characters supported by the custom tab.
        /// </summary>
        /// <value>The maximum number of entry characters supported by the custom tab.</value>
        [DataMember(Name="maximumLength", EmitDefaultValue=false)]
        public string MaximumLength { get; set; }
  
        
        /// <summary>
        /// An optional string that is used to auto-match tabs to strings located in the documents of an envelope.
        /// </summary>
        /// <value>An optional string that is used to auto-match tabs to strings located in the documents of an envelope.</value>
        [DataMember(Name="anchor", EmitDefaultValue=false)]
        public string Anchor { get; set; }
  
        
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
        [DataMember(Name="anchorMatchWholeWord", EmitDefaultValue=false)]
        public string AnchorMatchWholeWord { get; set; }
  
        
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
        [DataMember(Name="anchorHorizontalAlignment", EmitDefaultValue=false)]
        public string AnchorHorizontalAlignment { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// The type of this tab. Values are: Approve, CheckBox, Company, Date, DateSigned,	Decline, Email,	EmailAddress, EnvelopeId, FirstName, Formula, FullName,	InitialHere, InitialHereOptional, LastName, List, Note, Number,	Radio, SignerAttachment, SignHere, SignHereOptional, Ssn, Text, Title, Zip5, or Zip5Dash4.
        /// </summary>
        /// <value>The type of this tab. Values are: Approve, CheckBox, Company, Date, DateSigned,	Decline, Email,	EmailAddress, EnvelopeId, FirstName, Formula, FullName,	InitialHere, InitialHereOptional, LastName, List, Note, Number,	Radio, SignerAttachment, SignHere, SignHereOptional, Ssn, Text, Title, Zip5, or Zip5Dash4.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// The message displayed if the custom tab fails input validation (either custom of embedded).
        /// </summary>
        /// <value>The message displayed if the custom tab fails input validation (either custom of embedded).</value>
        [DataMember(Name="validationMessage", EmitDefaultValue=false)]
        public string ValidationMessage { get; set; }
  
        
        /// <summary>
        /// A regular expressionn used to validate input for the tab.
        /// </summary>
        /// <value>A regular expressionn used to validate input for the tab.</value>
        [DataMember(Name="validationPattern", EmitDefaultValue=false)]
        public string ValidationPattern { get; set; }
  
        
        /// <summary>
        /// The userId of the DocuSign user who last modified this object.
        /// </summary>
        /// <value>The userId of the DocuSign user who last modified this object.</value>
        [DataMember(Name="lastModifiedByUserId", EmitDefaultValue=false)]
        public string LastModifiedByUserId { get; set; }
  
        
        /// <summary>
        /// The User Name of the DocuSign user who last modified this object.
        /// </summary>
        /// <value>The User Name of the DocuSign user who last modified this object.</value>
        [DataMember(Name="lastModifiedByDisplayName", EmitDefaultValue=false)]
        public string LastModifiedByDisplayName { get; set; }
  
        
        /// <summary>
        /// The UTC DateTime this object was last modified. This is in ISO8601 format.
        /// </summary>
        /// <value>The UTC DateTime this object was last modified. This is in ISO8601 format.</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public string LastModified { get; set; }
  
        
        /// <summary>
        /// The userId of the DocuSign user who created this object.
        /// </summary>
        /// <value>The userId of the DocuSign user who created this object.</value>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public string CreatedByUserId { get; set; }
  
        
        /// <summary>
        /// The user name of the DocuSign user who created this object.
        /// </summary>
        /// <value>The user name of the DocuSign user who created this object.</value>
        [DataMember(Name="createdByDisplayName", EmitDefaultValue=false)]
        public string CreatedByDisplayName { get; set; }
  
        
        /// <summary>
        /// When set to **true**, the custom tab is editable. Otherwise the custom tab cannot be modified.
        /// </summary>
        /// <value>When set to **true**, the custom tab is editable. Otherwise the custom tab cannot be modified.</value>
        [DataMember(Name="editable", EmitDefaultValue=false)]
        public string Editable { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MergeField
        /// </summary>
        [DataMember(Name="mergeField", EmitDefaultValue=false)]
        public MergeField MergeField { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TabMetadata {\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  Bold: ").Append(Bold).Append("\n");
            sb.Append("  Italic: ").Append(Italic).Append("\n");
            sb.Append("  Underline: ").Append(Underline).Append("\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  CustomTabId: ").Append(CustomTabId).Append("\n");
            sb.Append("  InitialValue: ").Append(InitialValue).Append("\n");
            sb.Append("  IncludedInEmail: ").Append(IncludedInEmail).Append("\n");
            sb.Append("  DisableAutoSize: ").Append(DisableAutoSize).Append("\n");
            sb.Append("  ConcealValueOnDocument: ").Append(ConcealValueOnDocument).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  TabLabel: ").Append(TabLabel).Append("\n");
            sb.Append("  MaximumLength: ").Append(MaximumLength).Append("\n");
            sb.Append("  Anchor: ").Append(Anchor).Append("\n");
            sb.Append("  AnchorXOffset: ").Append(AnchorXOffset).Append("\n");
            sb.Append("  AnchorYOffset: ").Append(AnchorYOffset).Append("\n");
            sb.Append("  AnchorUnits: ").Append(AnchorUnits).Append("\n");
            sb.Append("  AnchorIgnoreIfNotPresent: ").Append(AnchorIgnoreIfNotPresent).Append("\n");
            sb.Append("  AnchorMatchWholeWord: ").Append(AnchorMatchWholeWord).Append("\n");
            sb.Append("  AnchorCaseSensitive: ").Append(AnchorCaseSensitive).Append("\n");
            sb.Append("  AnchorHorizontalAlignment: ").Append(AnchorHorizontalAlignment).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidationMessage: ").Append(ValidationMessage).Append("\n");
            sb.Append("  ValidationPattern: ").Append(ValidationPattern).Append("\n");
            sb.Append("  LastModifiedByUserId: ").Append(LastModifiedByUserId).Append("\n");
            sb.Append("  LastModifiedByDisplayName: ").Append(LastModifiedByDisplayName).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedByDisplayName: ").Append(CreatedByDisplayName).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  MergeField: ").Append(MergeField).Append("\n");
            
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
            return this.Equals(obj as TabMetadata);
        }

        /// <summary>
        /// Returns true if TabMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of TabMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TabMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.CustomTabId == other.CustomTabId ||
                    this.CustomTabId != null &&
                    this.CustomTabId.Equals(other.CustomTabId)
                ) && 
                (
                    this.InitialValue == other.InitialValue ||
                    this.InitialValue != null &&
                    this.InitialValue.Equals(other.InitialValue)
                ) && 
                (
                    this.IncludedInEmail == other.IncludedInEmail ||
                    this.IncludedInEmail != null &&
                    this.IncludedInEmail.Equals(other.IncludedInEmail)
                ) && 
                (
                    this.DisableAutoSize == other.DisableAutoSize ||
                    this.DisableAutoSize != null &&
                    this.DisableAutoSize.Equals(other.DisableAutoSize)
                ) && 
                (
                    this.ConcealValueOnDocument == other.ConcealValueOnDocument ||
                    this.ConcealValueOnDocument != null &&
                    this.ConcealValueOnDocument.Equals(other.ConcealValueOnDocument)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.TabLabel == other.TabLabel ||
                    this.TabLabel != null &&
                    this.TabLabel.Equals(other.TabLabel)
                ) && 
                (
                    this.MaximumLength == other.MaximumLength ||
                    this.MaximumLength != null &&
                    this.MaximumLength.Equals(other.MaximumLength)
                ) && 
                (
                    this.Anchor == other.Anchor ||
                    this.Anchor != null &&
                    this.Anchor.Equals(other.Anchor)
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
                    this.AnchorMatchWholeWord == other.AnchorMatchWholeWord ||
                    this.AnchorMatchWholeWord != null &&
                    this.AnchorMatchWholeWord.Equals(other.AnchorMatchWholeWord)
                ) && 
                (
                    this.AnchorCaseSensitive == other.AnchorCaseSensitive ||
                    this.AnchorCaseSensitive != null &&
                    this.AnchorCaseSensitive.Equals(other.AnchorCaseSensitive)
                ) && 
                (
                    this.AnchorHorizontalAlignment == other.AnchorHorizontalAlignment ||
                    this.AnchorHorizontalAlignment != null &&
                    this.AnchorHorizontalAlignment.Equals(other.AnchorHorizontalAlignment)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ValidationMessage == other.ValidationMessage ||
                    this.ValidationMessage != null &&
                    this.ValidationMessage.Equals(other.ValidationMessage)
                ) && 
                (
                    this.ValidationPattern == other.ValidationPattern ||
                    this.ValidationPattern != null &&
                    this.ValidationPattern.Equals(other.ValidationPattern)
                ) && 
                (
                    this.LastModifiedByUserId == other.LastModifiedByUserId ||
                    this.LastModifiedByUserId != null &&
                    this.LastModifiedByUserId.Equals(other.LastModifiedByUserId)
                ) && 
                (
                    this.LastModifiedByDisplayName == other.LastModifiedByDisplayName ||
                    this.LastModifiedByDisplayName != null &&
                    this.LastModifiedByDisplayName.Equals(other.LastModifiedByDisplayName)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.CreatedByUserId == other.CreatedByUserId ||
                    this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    this.CreatedByDisplayName == other.CreatedByDisplayName ||
                    this.CreatedByDisplayName != null &&
                    this.CreatedByDisplayName.Equals(other.CreatedByDisplayName)
                ) && 
                (
                    this.Editable == other.Editable ||
                    this.Editable != null &&
                    this.Editable.Equals(other.Editable)
                ) && 
                (
                    this.MergeField == other.MergeField ||
                    this.MergeField != null &&
                    this.MergeField.Equals(other.MergeField)
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
                
                if (this.Height != null)
                    hash = hash * 57 + this.Height.GetHashCode();
                
                if (this.Width != null)
                    hash = hash * 57 + this.Width.GetHashCode();
                
                if (this.CustomTabId != null)
                    hash = hash * 57 + this.CustomTabId.GetHashCode();
                
                if (this.InitialValue != null)
                    hash = hash * 57 + this.InitialValue.GetHashCode();
                
                if (this.IncludedInEmail != null)
                    hash = hash * 57 + this.IncludedInEmail.GetHashCode();
                
                if (this.DisableAutoSize != null)
                    hash = hash * 57 + this.DisableAutoSize.GetHashCode();
                
                if (this.ConcealValueOnDocument != null)
                    hash = hash * 57 + this.ConcealValueOnDocument.GetHashCode();
                
                if (this.Locked != null)
                    hash = hash * 57 + this.Locked.GetHashCode();
                
                if (this.Required != null)
                    hash = hash * 57 + this.Required.GetHashCode();
                
                if (this.Shared != null)
                    hash = hash * 57 + this.Shared.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 57 + this.Items.GetHashCode();
                
                if (this.TabLabel != null)
                    hash = hash * 57 + this.TabLabel.GetHashCode();
                
                if (this.MaximumLength != null)
                    hash = hash * 57 + this.MaximumLength.GetHashCode();
                
                if (this.Anchor != null)
                    hash = hash * 57 + this.Anchor.GetHashCode();
                
                if (this.AnchorXOffset != null)
                    hash = hash * 57 + this.AnchorXOffset.GetHashCode();
                
                if (this.AnchorYOffset != null)
                    hash = hash * 57 + this.AnchorYOffset.GetHashCode();
                
                if (this.AnchorUnits != null)
                    hash = hash * 57 + this.AnchorUnits.GetHashCode();
                
                if (this.AnchorIgnoreIfNotPresent != null)
                    hash = hash * 57 + this.AnchorIgnoreIfNotPresent.GetHashCode();
                
                if (this.AnchorMatchWholeWord != null)
                    hash = hash * 57 + this.AnchorMatchWholeWord.GetHashCode();
                
                if (this.AnchorCaseSensitive != null)
                    hash = hash * 57 + this.AnchorCaseSensitive.GetHashCode();
                
                if (this.AnchorHorizontalAlignment != null)
                    hash = hash * 57 + this.AnchorHorizontalAlignment.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.ValidationMessage != null)
                    hash = hash * 57 + this.ValidationMessage.GetHashCode();
                
                if (this.ValidationPattern != null)
                    hash = hash * 57 + this.ValidationPattern.GetHashCode();
                
                if (this.LastModifiedByUserId != null)
                    hash = hash * 57 + this.LastModifiedByUserId.GetHashCode();
                
                if (this.LastModifiedByDisplayName != null)
                    hash = hash * 57 + this.LastModifiedByDisplayName.GetHashCode();
                
                if (this.LastModified != null)
                    hash = hash * 57 + this.LastModified.GetHashCode();
                
                if (this.CreatedByUserId != null)
                    hash = hash * 57 + this.CreatedByUserId.GetHashCode();
                
                if (this.CreatedByDisplayName != null)
                    hash = hash * 57 + this.CreatedByDisplayName.GetHashCode();
                
                if (this.Editable != null)
                    hash = hash * 57 + this.Editable.GetHashCode();
                
                if (this.MergeField != null)
                    hash = hash * 57 + this.MergeField.GetHashCode();
                
                return hash;
            }
        }

    }
}
