# DocuSign.eSign.Api.TrustServiceProvidersApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompleteSignHash**](TrustServiceProvidersApi.md#completesignhash) | **POST** /v2/signature/completesignhash | Complete Sign Hash
[**GetUserInfo**](TrustServiceProvidersApi.md#getuserinfo) | **GET** /v2/signature/userInfo | Get User Info To Sign Document
[**HealthCheck**](TrustServiceProvidersApi.md#healthcheck) | **POST** /v2/signature/healthcheck | Report status from the TSP to DocuSign
[**SignHashSessionInfo**](TrustServiceProvidersApi.md#signhashsessioninfo) | **POST** /v2/signature/signhashsessioninfo | Get Signature Session Info To Sign Document Hash
[**UpdateTransaction**](TrustServiceProvidersApi.md#updatetransaction) | **POST** /v2/signature/updatetransaction | Report an error from the tsp to docusign


<a name="completesignhash"></a>
# **CompleteSignHash**
> CompleteSignHashResponse CompleteSignHash (CompleteSignRequest completeSignRequest = null)

Complete Sign Hash

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class CompleteSignHashExample
    {
        public void main()
        {
            
            var apiInstance = new TrustServiceProvidersApi();
            var completeSignRequest = new CompleteSignRequest(); // CompleteSignRequest |  (optional) 

            try
            {
                // Complete Sign Hash
                CompleteSignHashResponse result = apiInstance.CompleteSignHash(completeSignRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustServiceProvidersApi.CompleteSignHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **completeSignRequest** | [**CompleteSignRequest**](CompleteSignRequest.md)|  | [optional] 

### Return type

[**CompleteSignHashResponse**](CompleteSignHashResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserinfo"></a>
# **GetUserInfo**
> UserInfoResponse GetUserInfo ()

Get User Info To Sign Document

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetUserInfoExample
    {
        public void main()
        {
            
            var apiInstance = new TrustServiceProvidersApi();

            try
            {
                // Get User Info To Sign Document
                UserInfoResponse result = apiInstance.GetUserInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustServiceProvidersApi.GetUserInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserInfoResponse**](UserInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="healthcheck"></a>
# **HealthCheck**
> void HealthCheck (TspHealthCheckRequest tspHealthCheckRequest = null)

Report status from the TSP to DocuSign

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class HealthCheckExample
    {
        public void main()
        {
            
            var apiInstance = new TrustServiceProvidersApi();
            var tspHealthCheckRequest = new TspHealthCheckRequest(); // TspHealthCheckRequest |  (optional) 

            try
            {
                // Report status from the TSP to DocuSign
                apiInstance.HealthCheck(tspHealthCheckRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustServiceProvidersApi.HealthCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tspHealthCheckRequest** | [**TspHealthCheckRequest**](TspHealthCheckRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signhashsessioninfo"></a>
# **SignHashSessionInfo**
> SignHashSessionInfoResponse SignHashSessionInfo (SignSessionInfoRequest signSessionInfoRequest = null)

Get Signature Session Info To Sign Document Hash

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class SignHashSessionInfoExample
    {
        public void main()
        {
            
            var apiInstance = new TrustServiceProvidersApi();
            var signSessionInfoRequest = new SignSessionInfoRequest(); // SignSessionInfoRequest |  (optional) 

            try
            {
                // Get Signature Session Info To Sign Document Hash
                SignHashSessionInfoResponse result = apiInstance.SignHashSessionInfo(signSessionInfoRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustServiceProvidersApi.SignHashSessionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signSessionInfoRequest** | [**SignSessionInfoRequest**](SignSessionInfoRequest.md)|  | [optional] 

### Return type

[**SignHashSessionInfoResponse**](SignHashSessionInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransaction"></a>
# **UpdateTransaction**
> UpdateTransactionResponse UpdateTransaction (UpdateTransactionRequest updateTransactionRequest = null)

Report an error from the tsp to docusign

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateTransactionExample
    {
        public void main()
        {
            
            var apiInstance = new TrustServiceProvidersApi();
            var updateTransactionRequest = new UpdateTransactionRequest(); // UpdateTransactionRequest |  (optional) 

            try
            {
                // Report an error from the tsp to docusign
                UpdateTransactionResponse result = apiInstance.UpdateTransaction(updateTransactionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrustServiceProvidersApi.UpdateTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateTransactionRequest** | [**UpdateTransactionRequest**](UpdateTransactionRequest.md)|  | [optional] 

### Return type

[**UpdateTransactionResponse**](UpdateTransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

