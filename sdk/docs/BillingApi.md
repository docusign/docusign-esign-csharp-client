# DocuSign.eSign.Api.BillingApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBillingPlan**](BillingApi.md#getbillingplan) | **GET** /v2/billing_plans/{billingPlanId} | Get the billing plan details.
[**GetCreditCardInfo**](BillingApi.md#getcreditcardinfo) | **GET** /v2/accounts/{accountId}/billing_plan/credit_card | Get metadata for a given credit card.
[**GetInvoice**](BillingApi.md#getinvoice) | **GET** /v2/accounts/{accountId}/billing_invoices/{invoiceId} | Retrieves a billing invoice.
[**GetPayment**](BillingApi.md#getpayment) | **GET** /v2/accounts/{accountId}/billing_payments/{paymentId} | Gets billing payment information for a specific payment.
[**GetPlan**](BillingApi.md#getplan) | **GET** /v2/accounts/{accountId}/billing_plan | Get Account Billing Plan
[**ListBillingPlans**](BillingApi.md#listbillingplans) | **GET** /v2/billing_plans | Gets the list of available billing plans.
[**ListInvoices**](BillingApi.md#listinvoices) | **GET** /v2/accounts/{accountId}/billing_invoices | Get a List of Billing Invoices
[**ListInvoicesPastDue**](BillingApi.md#listinvoicespastdue) | **GET** /v2/accounts/{accountId}/billing_invoices_past_due | Get a list of past due invoices.
[**ListPayments**](BillingApi.md#listpayments) | **GET** /v2/accounts/{accountId}/billing_payments | Gets payment information for one or more payments.
[**MakePayment**](BillingApi.md#makepayment) | **POST** /v2/accounts/{accountId}/billing_payments | Posts a payment to a past due invoice.
[**PurchaseEnvelopes**](BillingApi.md#purchaseenvelopes) | **PUT** /v2/accounts/{accountId}/billing_plan/purchased_envelopes | Reserverd: Purchase additional envelopes.
[**UpdatePlan**](BillingApi.md#updateplan) | **PUT** /v2/accounts/{accountId}/billing_plan | Updates the account billing plan.


<a name="getbillingplan"></a>
# **GetBillingPlan**
> BillingPlanResponse GetBillingPlan (string billingPlanId)

Get the billing plan details.

Retrieves the billing plan details for the specified billing plan ID.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetBillingPlanExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var billingPlanId = billingPlanId_example;  // string | The ID of the billing plan being accessed.

            try
            {
                // Get the billing plan details.
                BillingPlanResponse result = apiInstance.GetBillingPlan(billingPlanId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetBillingPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingPlanId** | **string**| The ID of the billing plan being accessed. | 

### Return type

[**BillingPlanResponse**](BillingPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcreditcardinfo"></a>
# **GetCreditCardInfo**
> CreditCardInformation GetCreditCardInfo (string accountId)

Get metadata for a given credit card.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetCreditCardInfoExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get metadata for a given credit card.
                CreditCardInformation result = apiInstance.GetCreditCardInfo(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetCreditCardInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**CreditCardInformation**](CreditCardInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvoice"></a>
# **GetInvoice**
> BillingInvoice GetInvoice (string accountId, string invoiceId)

Retrieves a billing invoice.

Retrieves the specified invoice.   ###### Note: If the `pdfAvailable` property in the response is set to *true*, you can download a PDF version of the invoice. To download the PDF, make the call again and change the value of the `Accept` property in the header to `Accept: application/pdf`.  Privileges required: account administrator  The response returns a list of charges and information about the charges. Quantities are usually shown as ‘unlimited’ or an integer. Amounts are shown in the currency set for the account.  **Response** The following table provides a description of the different `chargeName` property values. The information will grow as more chargeable items are added to the system.  | chargeName | Description | | - -- | - -- | | id_check | ID Check Charge | | in_person_signing | In Person Signing charge | | envelopes Included | Sent Envelopes for the account | | age_verify | Age verification check | | ofac | OFAC Check | | id_confirm | ID confirmation check | | student_authentication | STAN PIN authentication check | | wet_sign_fax | Pages for returning signed documents by fax | | attachment_fax | Pages for returning attachments by fax | | phone_authentication | Phone authentication charge | | powerforms | PowerForm envelopes sent | | signer_payments | Payment processing charge | | outbound_fax | Send by fax charge | | bulk_recipient_envelopes | Bulk Recipient Envelopes sent | | sms_authentications | SMS authentication charge | | saml_authentications | SAML authentication charge | | express_signer_certificate | DocuSign Express Certificate charge | | personal_signer_certificate | Personal Signer Certificate charge | | safe_certificate | SAFE BioPharma Signer Certificate charge | | seats | Included active seats charge | | open_trust_certificate | OpenTrust Signer Certificate charge | 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetInvoiceExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var invoiceId = invoiceId_example;  // string | 

            try
            {
                // Retrieves a billing invoice.
                BillingInvoice result = apiInstance.GetInvoice(accountId, invoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **invoiceId** | **string**|  | 

### Return type

[**BillingInvoice**](BillingInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayment"></a>
# **GetPayment**
> BillingPaymentItem GetPayment (string accountId, string paymentId)

Gets billing payment information for a specific payment.

Retrieves the information for a specified payment.   Privileges required: account administrator 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetPaymentExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var paymentId = paymentId_example;  // string | 

            try
            {
                // Gets billing payment information for a specific payment.
                BillingPaymentItem result = apiInstance.GetPayment(accountId, paymentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetPayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **paymentId** | **string**|  | 

### Return type

[**BillingPaymentItem**](BillingPaymentItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplan"></a>
# **GetPlan**
> AccountBillingPlanResponse GetPlan (string includeCreditCardInformation = null, string includeMetadata = null, string includeSuccessorPlans = null, string accountId)

Get Account Billing Plan

Retrieves the billing plan information for the specified account, including the current billing plan, successor plans, billing address, and billing credit card.  By default the successor plan and credit card information is included in the response. This information can be excluded from the response by adding the appropriate optional query string with the `setting` set to **false**.   Response  The response returns the billing plan information, including the currency code, for the plan. The `billingPlan` and `succesorPlans` property values are the same as those shown in the [ML:Get Billing Plan Details] reference. the `billingAddress` and `creditCardInformation` property values are the same as those shown in the [ML:Update Billing Plan] reference.  ###### Note: When credit card number information is shown, a mask is applied to the response so that only the last 4 digits of the card number are visible. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetPlanExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var includeCreditCardInformation = includeCreditCardInformation_example;  // string | When set to **true**, excludes credit card information from the response. (optional) 
            var includeMetadata = includeMetadata_example;  // string | When set to **true**, the `canUpgrade` and `renewalStatus` properities are included the response and an array of `supportedCountries` property is added to the `billingAddress` information.  (optional) 
            var includeSuccessorPlans = includeSuccessorPlans_example;  // string | When set to **true**, excludes successor information from the response. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get Account Billing Plan
                AccountBillingPlanResponse result = apiInstance.GetPlan(includeCreditCardInformation, includeMetadata, includeSuccessorPlans, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeCreditCardInformation** | **string**| When set to **true**, excludes credit card information from the response. | [optional] 
 **includeMetadata** | **string**| When set to **true**, the &#x60;canUpgrade&#x60; and &#x60;renewalStatus&#x60; properities are included the response and an array of &#x60;supportedCountries&#x60; property is added to the &#x60;billingAddress&#x60; information.  | [optional] 
 **includeSuccessorPlans** | **string**| When set to **true**, excludes successor information from the response. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**AccountBillingPlanResponse**](AccountBillingPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbillingplans"></a>
# **ListBillingPlans**
> BillingPlansResponse ListBillingPlans ()

Gets the list of available billing plans.

Retrieves a list of the billing plans associated with a distributor.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListBillingPlansExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();

            try
            {
                // Gets the list of available billing plans.
                BillingPlansResponse result = apiInstance.ListBillingPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.ListBillingPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**BillingPlansResponse**](BillingPlansResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinvoices"></a>
# **ListInvoices**
> BillingInvoicesResponse ListInvoices (string fromDate = null, string toDate = null, string accountId)

Get a List of Billing Invoices

Retrieves a list of invoices for the account. If the from date or to date queries are not specified, the response returns invoices for the last 365 days.  Privileges required: account administrator 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListInvoicesExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var fromDate = fromDate_example;  // string | Specifies the date/time of the earliest invoice in the account to retrieve. (optional) 
            var toDate = toDate_example;  // string | Specifies the date/time of the latest invoice in the account to retrieve. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get a List of Billing Invoices
                BillingInvoicesResponse result = apiInstance.ListInvoices(fromDate, toDate, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.ListInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fromDate** | **string**| Specifies the date/time of the earliest invoice in the account to retrieve. | [optional] 
 **toDate** | **string**| Specifies the date/time of the latest invoice in the account to retrieve. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**BillingInvoicesResponse**](BillingInvoicesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinvoicespastdue"></a>
# **ListInvoicesPastDue**
> BillingInvoicesSummary ListInvoicesPastDue (string accountId)

Get a list of past due invoices.

Returns a list past due invoices for the account and notes if payment can be made through the REST API.   Privileges Required: account administrator

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListInvoicesPastDueExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Get a list of past due invoices.
                BillingInvoicesSummary result = apiInstance.ListInvoicesPastDue(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.ListInvoicesPastDue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**BillingInvoicesSummary**](BillingInvoicesSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpayments"></a>
# **ListPayments**
> BillingPaymentsResponse ListPayments (string fromDate = null, string toDate = null, string accountId)

Gets payment information for one or more payments.

Retrieves a list containing information about one or more payments. If the from date or to date queries are not used, the response returns payment information for the last 365 days.   Privileges required: account administrator 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListPaymentsExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var fromDate = fromDate_example;  // string | Specifies the date/time of the earliest payment in the account to retrieve. (optional) 
            var toDate = toDate_example;  // string | Specifies the date/time of the latest payment in the account to retrieve. (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Gets payment information for one or more payments.
                BillingPaymentsResponse result = apiInstance.ListPayments(fromDate, toDate, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.ListPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fromDate** | **string**| Specifies the date/time of the earliest payment in the account to retrieve. | [optional] 
 **toDate** | **string**| Specifies the date/time of the latest payment in the account to retrieve. | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**BillingPaymentsResponse**](BillingPaymentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="makepayment"></a>
# **MakePayment**
> BillingPaymentResponse MakePayment (BillingPaymentRequest billingPaymentRequest = null, string accountId)

Posts a payment to a past due invoice.

Posts a payment to a past due invoice.   ###### Note: This can only be used if the `paymentAllowed` value for a past due invoice is true. This can be determined calling [ML:GetBillingInvoicesPastDue].  The response returns information for a single payment, if a payment ID was used in the endpoint, or a list of payments. If the from date or to date queries or payment ID are not used, the response returns payment information for the last 365 days. If the request was for a single payment ID, the `nextUri` and `previousUri` properties are not returned.  Privileges required: account administrator

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class MakePaymentExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var billingPaymentRequest = new BillingPaymentRequest(); // BillingPaymentRequest |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Posts a payment to a past due invoice.
                BillingPaymentResponse result = apiInstance.MakePayment(billingPaymentRequest, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.MakePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **billingPaymentRequest** | [**BillingPaymentRequest**](BillingPaymentRequest.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**BillingPaymentResponse**](BillingPaymentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseenvelopes"></a>
# **PurchaseEnvelopes**
> void PurchaseEnvelopes (PurchasedEnvelopesInformation purchasedEnvelopesInformation = null, string accountId)

Reserverd: Purchase additional envelopes.

Reserved: At this time, this endpoint is limited to DocuSign internal use only. Completes the purchase of envelopes for your account. The actual purchase is done as part of an internal workflow interaction with an envelope vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class PurchaseEnvelopesExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var purchasedEnvelopesInformation = new PurchasedEnvelopesInformation(); // PurchasedEnvelopesInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Reserverd: Purchase additional envelopes.
                apiInstance.PurchaseEnvelopes(purchasedEnvelopesInformation, accountId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.PurchaseEnvelopes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchasedEnvelopesInformation** | [**PurchasedEnvelopesInformation**](PurchasedEnvelopesInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateplan"></a>
# **UpdatePlan**
> BillingPlanUpdateResponse UpdatePlan (string previewBillingPlan = null, BillingPlanInformation billingPlanInformation = null, string accountId)

Updates the account billing plan.

Updates the billing plan information, billing address, and credit card information for the specified account.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdatePlanExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var previewBillingPlan = previewBillingPlan_example;  // string | When set to **true**, updates the account using a preview billing plan. (optional) 
            var billingPlanInformation = new BillingPlanInformation(); // BillingPlanInformation |  (optional) 
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.

            try
            {
                // Updates the account billing plan.
                BillingPlanUpdateResponse result = apiInstance.UpdatePlan(previewBillingPlan, billingPlanInformation, accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.UpdatePlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **previewBillingPlan** | **string**| When set to **true**, updates the account using a preview billing plan. | [optional] 
 **billingPlanInformation** | [**BillingPlanInformation**](BillingPlanInformation.md)|  | [optional] 
 **accountId** | **string**| The external account number (int) or account ID Guid. | 

### Return type

[**BillingPlanUpdateResponse**](BillingPlanUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

