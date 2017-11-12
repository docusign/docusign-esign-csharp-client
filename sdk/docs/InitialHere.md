# DocuSign.eSign.Model.InitialHere
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnchorCaseSensitive** | **string** | When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**. | [optional] 
**AnchorHorizontalAlignment** | **string** | Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**. | [optional] 
**AnchorIgnoreIfNotPresent** | **string** | When set to **true**, this tab is ignored if anchorString is not found in the document. | [optional] 
**AnchorMatchWholeWord** | **string** | When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**. | [optional] 
**AnchorString** | **string** | Anchor text information for a radio button. | [optional] 
**AnchorUnits** | **string** | Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches. | [optional] 
**AnchorXOffset** | **string** | Specifies the X axis location of the tab, in achorUnits, relative to the anchorString. | [optional] 
**AnchorYOffset** | **string** | Specifies the Y axis location of the tab, in achorUnits, relative to the anchorString. | [optional] 
**ConditionalParentLabel** | **string** | For conditional fields this is the TabLabel of the parent tab that controls this tab&#39;s visibility. | [optional] 
**ConditionalParentValue** | **string** | For conditional fields, this is the value of the parent tab that controls the tab&#39;s visibility.  If the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \&quot;on\&quot; as the value to show that the parent tab is active.  | [optional] 
**CustomTabId** | **string** | The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties. | [optional] 
**DocumentId** | **string** | Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute. | [optional] 
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**MergeField** | [**MergeField**](MergeField.md) |  | [optional] 
**Name** | **string** | Specifies the tool tip text for the tab. | [optional] 
**Optional** | **string** |  | [optional] 
**PageNumber** | **string** | Specifies the page number on which the tab is located. | [optional] 
**RecipientId** | **string** | Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document. | [optional] 
**ScaleValue** | **string** |  Sets the size for the InitialHere tab. It can be value from 0.5 to 1.0, where 1.0 represents full size and 0.5 is 50% size. | [optional] 
**Status** | **string** | Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later. | [optional] 
**TabId** | **string** | The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].      | [optional] 
**TabLabel** | **string** | The label string associated with the tab. | [optional] 
**TabOrder** | **string** |  | [optional] 
**TemplateLocked** | **string** | When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients.  | [optional] 
**TemplateRequired** | **string** | When set to **true**, the sender may not remove the recipient. Used only when working with template recipients. | [optional] 
**XPosition** | **string** | This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position. | [optional] 
**YPosition** | **string** | This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

