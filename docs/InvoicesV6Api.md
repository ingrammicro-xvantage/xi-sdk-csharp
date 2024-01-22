# xi.sdk.resellers.Api.InvoicesV6Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInvoicedetailsV6**](InvoicesV6Api.md#getinvoicedetailsv6) | **GET** /resellers/v6/invoices/{invoicenumber} | Get Invoice Details v6 |

<a id="getinvoicedetailsv6"></a>
# **GetInvoicedetailsV6**
> InvoiceDetailResponse GetInvoicedetailsV6 (string invoicenumber, string varVersion, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string iMApplicationID, string? customerType = null, bool? includeSerialNumbers = null)

Get Invoice Details v6

Use your Ingram Micro invoice number to search for existing invoices or retrieve existing invoice details.  The invoice number, IM-CustomerNumber, IM-CountryCode, IM-ApplicationId and IM-CorrelationID are required parameters.  .

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
    public class GetInvoicedetailsV6Example
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
            var apiInstance = new InvoicesV6Api(httpClient, config, httpClientHandler);
            var invoicenumber = 335238411;  // string | The Ingram Micro invoice number.
            var varVersion = 20-222222;  // string | Version of codebase.
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var iMApplicationID = MyCompany;  // string | Unique value used to identify the sender of the transaction. Example: MyCompany.
            var customerType = invoice;  // string? | it should be invoice or order (optional) 
            var includeSerialNumbers = false;  // bool? | if serial in the response send as true or else false (optional) 

            try
            {
                // Get Invoice Details v6
                InvoiceDetailResponse result = apiInstance.GetInvoicedetailsV6(invoicenumber, varVersion, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMApplicationID, customerType, includeSerialNumbers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesV6Api.GetInvoicedetailsV6: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoicedetailsV6WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Invoice Details v6
    ApiResponse<InvoiceDetailResponse> response = apiInstance.GetInvoicedetailsV6WithHttpInfo(invoicenumber, varVersion, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMApplicationID, customerType, includeSerialNumbers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesV6Api.GetInvoicedetailsV6WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoicenumber** | **string** | The Ingram Micro invoice number. |  |
| **varVersion** | **string** | Version of codebase. |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **iMApplicationID** | **string** | Unique value used to identify the sender of the transaction. Example: MyCompany. |  |
| **customerType** | **string?** | it should be invoice or order | [optional]  |
| **includeSerialNumbers** | **bool?** | if serial in the response send as true or else false | [optional]  |

### Return type

[**InvoiceDetailResponse**](InvoiceDetailResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-ApplicationID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

