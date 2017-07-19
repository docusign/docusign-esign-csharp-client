# DocuSign.eSign.Model.Radio
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
**ErrorDetails** | [**ErrorDetails**](ErrorDetails.md) |  | [optional] 
**Locked** | **string** | When set to **true**, the signer cannot change the data of the custom tab. | [optional] 
**PageNumber** | **string** | Specifies the page number on which the tab is located. | [optional] 
**Required** | **string** | When set to **true**, the signer is required to fill out this tab | [optional] 
**Selected** | **string** | When set to **true**, the radio button is selected. | [optional] 
**TabId** | **string** | The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].      | [optional] 
**TabOrder** | **string** |  | [optional] 
**Value** | **string** | Specifies the value of the tab.  | [optional] 
**XPosition** | **string** | This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position. | [optional] 
**YPosition** | **string** | This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

