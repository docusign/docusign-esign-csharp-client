# DocuSign.eSign.Api.NotaryApi

All URIs are relative to *https://www.docusign.net/restapi*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListNotaryJournals**](NotaryApi.md#listnotaryjournals) | **GET** /v2/current_user/notary/journals | Get notary jurisdictions for a user


<a name="listnotaryjournals"></a>
# **ListNotaryJournals**
> NotaryJournalList ListNotaryJournals (string count = null, string searchText = null, string startPosition = null)

Get notary jurisdictions for a user

### Example
```csharp
using System;
using System.Diagnostics;
using DocuSign.eSign.Api;
using DocuSign.eSign.Client;
using DocuSign.eSign.Model;

namespace Example
{
    public class ListNotaryJournalsExample
    {
        public void main()
        {
            
            var apiInstance = new NotaryApi();
            var count = count_example;  // string |  (optional) 
            var searchText = searchText_example;  // string |  (optional) 
            var startPosition = startPosition_example;  // string |  (optional) 

            try
            {
                // Get notary jurisdictions for a user
                NotaryJournalList result = apiInstance.ListNotaryJournals(count, searchText, startPosition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotaryApi.ListNotaryJournals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **string**|  | [optional] 
 **searchText** | **string**|  | [optional] 
 **startPosition** | **string**|  | [optional] 

### Return type

[**NotaryJournalList**](NotaryJournalList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

