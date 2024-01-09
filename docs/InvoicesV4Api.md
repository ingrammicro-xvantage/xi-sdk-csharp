# xi-sdk-csharp.Api.InvoicesV4Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostV4Invoicedetails**](InvoicesV4Api.md#postv4invoicedetails) | **POST** /invoices/v4/invoicedetails | Get Invoice Details |

<a id="postv4invoicedetails"></a>
# **PostV4Invoicedetails**
> InvoiceDetailResponse PostV4Invoicedetails (InvoiceDetailRequest? invoiceDetailRequest = null)

Get Invoice Details

A real-time request that allows the customer to query Ingram Micro for Invoice information for a specific open or shipped order (in the past 9 months). Orders are searched using Ingram Micro Sales Order Number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using xi-sdk-csharp.Api;
using xi-sdk-csharp.Client;
using xi-sdk-csharp.Model;

namespace Example
{
    public class PostV4InvoicedetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443/sandbox";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InvoicesV4Api(config);
            var invoiceDetailRequest = new InvoiceDetailRequest?(); // InvoiceDetailRequest? |  (optional) 

            try
            {
                // Get Invoice Details
                InvoiceDetailResponse result = apiInstance.PostV4Invoicedetails(invoiceDetailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesV4Api.PostV4Invoicedetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4InvoicedetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Invoice Details
    ApiResponse<InvoiceDetailResponse> response = apiInstance.PostV4InvoicedetailsWithHttpInfo(invoiceDetailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesV4Api.PostV4InvoicedetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceDetailRequest** | [**InvoiceDetailRequest?**](InvoiceDetailRequest?.md) |  | [optional]  |

### Return type

[**InvoiceDetailResponse**](InvoiceDetailResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

