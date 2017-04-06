# DocuSign.eSign.Api.PowerFormsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePowerForm**](PowerFormsApi.md#createpowerform) | **POST** /v2/accounts/{accountId}/powerforms | Creates a new PowerForm.
[**DeletePowerForm**](PowerFormsApi.md#deletepowerform) | **DELETE** /v2/accounts/{accountId}/powerforms/{powerFormId} | Delete a PowerForm.
[**DeletePowerForms**](PowerFormsApi.md#deletepowerforms) | **DELETE** /v2/accounts/{accountId}/powerforms | Deletes one or more PowerForms
[**GetPowerForm**](PowerFormsApi.md#getpowerform) | **GET** /v2/accounts/{accountId}/powerforms/{powerFormId} | Returns a single PowerForm.
[**GetPowerFormData**](PowerFormsApi.md#getpowerformdata) | **GET** /v2/accounts/{accountId}/powerforms/{powerFormId}/form_data | Returns the form data associated with the usage of a PowerForm.
[**ListPowerFormSenders**](PowerFormsApi.md#listpowerformsenders) | **GET** /v2/accounts/{accountId}/powerforms/senders | Returns the list of PowerForms available to the user.
[**ListPowerForms**](PowerFormsApi.md#listpowerforms) | **GET** /v2/accounts/{accountId}/powerforms | Returns the list of PowerForms available to the user.
[**UpdatePowerForm**](PowerFormsApi.md#updatepowerform) | **PUT** /v2/accounts/{accountId}/powerforms/{powerFormId} | Creates a new PowerForm.


<a name="createpowerform"></a>
# **CreatePowerForm**
> PowerForm CreatePowerForm (string accountId, PowerForm powerForm = null)

Creates a new PowerForm.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CreatePowerFormExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerForm = new PowerForm(); // PowerForm |  (optional) 

            try
            {
                // Creates a new PowerForm.
                PowerForm result = apiInstance.CreatePowerForm(accountId, powerForm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.CreatePowerForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerForm** | [**PowerForm**](PowerForm.md)|  | [optional] 

### Return type

[**PowerForm**](PowerForm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepowerform"></a>
# **DeletePowerForm**
> void DeletePowerForm (string accountId, string powerFormId)

Delete a PowerForm.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeletePowerFormExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormId = powerFormId_example;  // string | 

            try
            {
                // Delete a PowerForm.
                apiInstance.DeletePowerForm(accountId, powerFormId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.DeletePowerForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerFormId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepowerforms"></a>
# **DeletePowerForms**
> PowerFormsResponse DeletePowerForms (string accountId, PowerFormsRequest powerFormsRequest = null)

Deletes one or more PowerForms

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeletePowerFormsExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormsRequest = new PowerFormsRequest(); // PowerFormsRequest |  (optional) 

            try
            {
                // Deletes one or more PowerForms
                PowerFormsResponse result = apiInstance.DeletePowerForms(accountId, powerFormsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.DeletePowerForms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerFormsRequest** | [**PowerFormsRequest**](PowerFormsRequest.md)|  | [optional] 

### Return type

[**PowerFormsResponse**](PowerFormsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerform"></a>
# **GetPowerForm**
> PowerForm GetPowerForm (string accountId, string powerFormId)

Returns a single PowerForm.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetPowerFormExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormId = powerFormId_example;  // string | 

            try
            {
                // Returns a single PowerForm.
                PowerForm result = apiInstance.GetPowerForm(accountId, powerFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.GetPowerForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerFormId** | **string**|  | 

### Return type

[**PowerForm**](PowerForm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerformdata"></a>
# **GetPowerFormData**
> PowerFormsFormDataResponse GetPowerFormData (string accountId, string powerFormId, string fromDate = null, string toDate = null)

Returns the form data associated with the usage of a PowerForm.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetPowerFormDataExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormId = powerFormId_example;  // string | 
            var fromDate = fromDate_example;  // string |  (optional) 
            var toDate = toDate_example;  // string |  (optional) 

            try
            {
                // Returns the form data associated with the usage of a PowerForm.
                PowerFormsFormDataResponse result = apiInstance.GetPowerFormData(accountId, powerFormId, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.GetPowerFormData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerFormId** | **string**|  | 
 **fromDate** | **string**|  | [optional] 
 **toDate** | **string**|  | [optional] 

### Return type

[**PowerFormsFormDataResponse**](PowerFormsFormDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpowerformsenders"></a>
# **ListPowerFormSenders**
> PowerFormSendersResponse ListPowerFormSenders (string accountId, string startPosition = null)

Returns the list of PowerForms available to the user.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListPowerFormSendersExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var startPosition = startPosition_example;  // string |  (optional) 

            try
            {
                // Returns the list of PowerForms available to the user.
                PowerFormSendersResponse result = apiInstance.ListPowerFormSenders(accountId, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.ListPowerFormSenders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **startPosition** | **string**|  | [optional] 

### Return type

[**PowerFormSendersResponse**](PowerFormSendersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpowerforms"></a>
# **ListPowerForms**
> PowerFormsResponse ListPowerForms (string accountId, string fromDate = null, string order = null, string orderBy = null, string toDate = null)

Returns the list of PowerForms available to the user.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListPowerFormsExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var fromDate = fromDate_example;  // string |  (optional) 
            var order = order_example;  // string |  (optional) 
            var orderBy = orderBy_example;  // string |  (optional) 
            var toDate = toDate_example;  // string |  (optional) 

            try
            {
                // Returns the list of PowerForms available to the user.
                PowerFormsResponse result = apiInstance.ListPowerForms(accountId, fromDate, order, orderBy, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.ListPowerForms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **fromDate** | **string**|  | [optional] 
 **order** | **string**|  | [optional] 
 **orderBy** | **string**|  | [optional] 
 **toDate** | **string**|  | [optional] 

### Return type

[**PowerFormsResponse**](PowerFormsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepowerform"></a>
# **UpdatePowerForm**
> PowerForm UpdatePowerForm (string accountId, string powerFormId, PowerForm powerForm = null)

Creates a new PowerForm.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdatePowerFormExample
    {
        public void main()
        {
            
            var apiInstance = new PowerFormsApi();
            var accountId = accountId_example;  // string | The external account number (int) or account ID Guid.
            var powerFormId = powerFormId_example;  // string | 
            var powerForm = new PowerForm(); // PowerForm |  (optional) 

            try
            {
                // Creates a new PowerForm.
                PowerForm result = apiInstance.UpdatePowerForm(accountId, powerFormId, powerForm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerFormsApi.UpdatePowerForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The external account number (int) or account ID Guid. | 
 **powerFormId** | **string**|  | 
 **powerForm** | [**PowerForm**](PowerForm.md)|  | [optional] 

### Return type

[**PowerForm**](PowerForm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

