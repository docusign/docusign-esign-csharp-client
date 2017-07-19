# DocuSign.eSign.Model.EventNotification
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnvelopeEvents** | [**List&lt;EnvelopeEvent&gt;**](EnvelopeEvent.md) | A list of envelope-level event statuses that will trigger Connect to send updates to the endpoint specified in the &#x60;url&#x60; property.   To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both. | [optional] 
**IncludeCertificateOfCompletion** | **string** | When set to **true**, the Connect Service includes the Certificate of Completion with completed envelopes.  | [optional] 
**IncludeCertificateWithSoap** | **string** | When set to **true**, this tells the Connect service to send the DocuSign signedby certificate as part of the outgoing SOAP xml. This appears in the XML as wsse:BinarySecurityToken. | [optional] 
**IncludeDocumentFields** | **string** | When set to **true**, the Document Fields associated with envelope documents are included in the data. Document Fields are optional custom name-value pairs added to documents using the API.  | [optional] 
**IncludeDocuments** | **string** | When set to **true**, the PDF documents are included in the message along with the updated XML.  | [optional] 
**IncludeEnvelopeVoidReason** | **string** | When set to **true**, this tells the Connect Service to include the void reason, as entered by the person that voided the envelope, in the message.  | [optional] 
**IncludeSenderAccountAsCustomField** | **string** | When set to **true**, the sender account ID is included as a envelope custom field in the data.  | [optional] 
**IncludeTimeZone** | **string** | When set to **true**, the envelope time zone information is included in the message.  | [optional] 
**LoggingEnabled** | **string** | When set to **true**, logging is turned on for envelope events on the Web Console Connect page.  | [optional] 
**RecipientEvents** | [**List&lt;RecipientEvent&gt;**](RecipientEvent.md) | A list of recipient event statuses that will trigger Connect to send updates to   the endpoint specified in the url property.  To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both. | [optional] 
**RequireAcknowledgment** | **string** | When set to **true**, the DocuSign Connect service checks that the message was received and retries on failures.  | [optional] 
**SignMessageWithX509Cert** | **string** | When set to **true**, messages are signed with an X509 certificate. This provides support for 2-way SSL in the envelope.  | [optional] 
**SoapNameSpace** | **string** | This lists the namespace in the SOAP listener provided. | [optional] 
**Url** | **string** | Specifies the endpoint to which envelope updates are sent. Udpates are sent as XML unless &#x60;useSoapInterface&#x60; property is set to **true**. | [optional] 
**UseSoapInterface** | **string** | When set to **true**, this tells the Connect service that the user&#39;s endpoint has implemented a SOAP interface.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

