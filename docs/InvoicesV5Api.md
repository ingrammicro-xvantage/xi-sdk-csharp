# xi.sdk.resellers.Api.InvoicesV5Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInvoices**](InvoicesV5Api.md#getinvoices) | **GET** /resellers/v5/invoices/{invoiceNumber} | Get Invoice Details |

<a id="getinvoices"></a>
# **GetInvoices**
> InvoiceDetails GetInvoices (string invoiceNumber, string customerNumber, string isoCountryCode)

Get Invoice Details

View invoice details. This is a request to query invoice details for a specific Ingram Micro order placed in the last 9 months, whether open or shipped.   <strong>invoiceNumber</strong>, <strong>isoCountryCode</strong> and <strong>customerNumber</strong> parameters are required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using xi.sdk.resellers.Api;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443/sandbox";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InvoicesV5Api(httpClient, config, httpClientHandler);
            var invoiceNumber = "\"20-RCW67-11\"";  // string | Ingram Micro Invoice Number (default to "20-RCW67-11")
            var customerNumber = "\"20-222222\"";  // string | Your unique Ingram Micro customer number (default to "20-222222")
            var isoCountryCode = "\"US\"";  // string | ISO 2 char country code (default to "US")

            try
            {
                // Get Invoice Details
                InvoiceDetails result = apiInstance.GetInvoices(invoiceNumber, customerNumber, isoCountryCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesV5Api.GetInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Invoice Details
    ApiResponse<InvoiceDetails> response = apiInstance.GetInvoicesWithHttpInfo(invoiceNumber, customerNumber, isoCountryCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesV5Api.GetInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceNumber** | **string** | Ingram Micro Invoice Number | [default to &quot;20-RCW67-11&quot;] |
| **customerNumber** | **string** | Your unique Ingram Micro customer number | [default to &quot;20-222222&quot;] |
| **isoCountryCode** | **string** | ISO 2 char country code | [default to &quot;US&quot;] |

### Return type

[**InvoiceDetails**](InvoiceDetails.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

