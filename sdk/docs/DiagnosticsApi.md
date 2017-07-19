# DocuSign.eSign.Api.DiagnosticsApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRequestLogs**](DiagnosticsApi.md#deleterequestlogs) | **DELETE** /v2/diagnostics/request_logs | Deletes the request log files.
[**GetRequestLog**](DiagnosticsApi.md#getrequestlog) | **GET** /v2/diagnostics/request_logs/{requestLogId} | Gets a request logging log file.
[**GetRequestLogSettings**](DiagnosticsApi.md#getrequestlogsettings) | **GET** /v2/diagnostics/settings | Gets the API request logging settings.
[**GetResources**](DiagnosticsApi.md#getresources) | **GET** /v2 | Lists resources for REST version specified
[**GetService**](DiagnosticsApi.md#getservice) | **GET** /service_information | Retrieves the available REST API versions.
[**ListRequestLogs**](DiagnosticsApi.md#listrequestlogs) | **GET** /v2/diagnostics/request_logs | Gets the API request logging log files.
[**UpdateRequestLogSettings**](DiagnosticsApi.md#updaterequestlogsettings) | **PUT** /v2/diagnostics/settings | Enables or disables API request logging for troubleshooting.


<a name="deleterequestlogs"></a>
# **DeleteRequestLogs**
> void DeleteRequestLogs ()

Deletes the request log files.

Deletes the request log files.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class DeleteRequestLogsExample
    {
        public void main()
        {
            
            var apiInstance = new DiagnosticsApi();

            try
            {
                // Deletes the request log files.
                apiInstance.DeleteRequestLogs();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.DeleteRequestLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrequestlog"></a>
# **GetRequestLog**
> System.IO.Stream GetRequestLog (string requestLogId)

Gets a request logging log file.

Retrieves information for a single log entry.  **Request** The `requestLogfId` property can be retrieved by getting the list of log entries. The Content-Transfer-Encoding header can be set to base64 to retrieve the API request/response as base 64 string. Otherwise the bytes of the request/response are returned.  **Response** If the Content-Transfer-Encoding header was set to base64, the log is returned as a base64 string.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetRequestLogExample
    {
        public void main()
        {
            
            var apiInstance = new DiagnosticsApi();
            var requestLogId = requestLogId_example;  // string | 

            try
            {
                // Gets a request logging log file.
                System.IO.Stream result = apiInstance.GetRequestLog(requestLogId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.GetRequestLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestLogId** | **string**|  | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrequestlogsettings"></a>
# **GetRequestLogSettings**
> DiagnosticsSettingsInformation GetRequestLogSettings ()

Gets the API request logging settings.

Retrieves the current API request logging setting for the user and remaining log entries.  **Response** The response includes the current API request logging setting for the user, along with the maximum log entries and remaining log entries.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetRequestLogSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new DiagnosticsApi();

            try
            {
                // Gets the API request logging settings.
                DiagnosticsSettingsInformation result = apiInstance.GetRequestLogSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.GetRequestLogSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DiagnosticsSettingsInformation**](DiagnosticsSettingsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresources"></a>
# **GetResources**
> ResourceInformation GetResources ()

Lists resources for REST version specified

Retrieves the base resources available for the DocuSign REST APIs.  You do not need an integrator key to view the REST API versions and resources.  Example: https://demo.docusign.net/restapi/v2 lists all of the base resources available in version 2 of the REST API on the DocuSign Demo system.  To view descriptions and samples of the service operations for all versions, remove the version number and add /help to the URL.  Example: https://demo.docusign.net/restapi/help lists the REST API operations on the DocuSign Demo system with XML and JSON request and response samples.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetResourcesExample
    {
        public void main()
        {
            
            var apiInstance = new DiagnosticsApi();

            try
            {
                // Lists resources for REST version specified
                ResourceInformation result = apiInstance.GetResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.GetResources: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResourceInformation**](ResourceInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservice"></a>
# **GetService**
> ServiceInformation GetService ()

Retrieves the available REST API versions.

Retrieves the available REST API versions.  DocuSign Production system: https://www.docusign.net/restapi/service_information DocuSign Demo system: https://demo.docusign.net/restapi/service_information  You do not need an integrator key to view the REST API versions and resources.

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class GetServiceExample
    {
        public void main()
        {
            
            var apiInstance = new DiagnosticsApi();

            try
            {
                // Retrieves the available REST API versions.
                ServiceInformation result = apiInstance.GetService();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.GetService: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ServiceInformation**](ServiceInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrequestlogs"></a>
# **ListRequestLogs**
> ApiRequestLogsResult ListRequestLogs (string encoding = null)

Gets the API request logging log files.

Retrieves a list of log entries as a JSON or xml object or as a zip file containing the entries.  If the Accept header is set to application/zip, the response is a zip file containing individual text files, each representing an API request.  If the Accept header is set to `application/json` or `application/xml`, the response returns list of log entries in either JSON or XML. An example JSON response body is shown below. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListRequestLogsExample
    {
        public void main()
        {
            
            var apiInstance = new DiagnosticsApi();
            var encoding = encoding_example;  // string |  (optional) 

            try
            {
                // Gets the API request logging log files.
                ApiRequestLogsResult result = apiInstance.ListRequestLogs(encoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.ListRequestLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **encoding** | **string**|  | [optional] 

### Return type

[**ApiRequestLogsResult**](ApiRequestLogsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterequestlogsettings"></a>
# **UpdateRequestLogSettings**
> DiagnosticsSettingsInformation UpdateRequestLogSettings (DiagnosticsSettingsInformation diagnosticsSettingsInformation = null)

Enables or disables API request logging for troubleshooting.

Enables or disables API request logging for troubleshooting.  When enabled (`apiRequestLogging` is set to true), REST API requests and responses for the user are added to a log. A log can have up to 50 requests/responses and the current number of log entries can be determined by getting the settings. Logging is automatically disabled when the log limit of 50 is reached.  You can call [ML:GetRequestLog] or [ML:GetRequestLogs] to download the log files (individually or as a zip file). Call [ML:DeleteRequestLogs] to clear the log by deleting current entries.  Private information, such as passwords and integrator key information, which is normally located in the call header is omitted from the request/response log.  ###### Note: API request logging only captures requests from the authenticated user. Any call that does not authenticate the user and resolve a userId isn't logged. Meaning that login_information, NewAccounts, or other distributor-credential calls are not logged. 

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class UpdateRequestLogSettingsExample
    {
        public void main()
        {
            
            var apiInstance = new DiagnosticsApi();
            var diagnosticsSettingsInformation = new DiagnosticsSettingsInformation(); // DiagnosticsSettingsInformation |  (optional) 

            try
            {
                // Enables or disables API request logging for troubleshooting.
                DiagnosticsSettingsInformation result = apiInstance.UpdateRequestLogSettings(diagnosticsSettingsInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.UpdateRequestLogSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **diagnosticsSettingsInformation** | [**DiagnosticsSettingsInformation**](DiagnosticsSettingsInformation.md)|  | [optional] 

### Return type

[**DiagnosticsSettingsInformation**](DiagnosticsSettingsInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

