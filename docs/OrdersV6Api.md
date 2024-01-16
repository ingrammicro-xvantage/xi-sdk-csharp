# xi.sdk.resellers.csharp.Api.OrdersV6Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetOrderdetailsV6**](OrdersV6Api.md#getorderdetailsv6) | **GET** /resellers/v6/orders/{ordernumber} | Get Order Details v6 |

<a id="getorderdetailsv6"></a>
# **GetOrderdetailsV6**
> OrderDetailResponse GetOrderdetailsV6 (string ordernumber, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? iMSenderID = null, DateTime? ingramOrderDate = null, string? vendorNumber = null, string? simulateStatus = null, bool? isIml = null, string? regionCode = null)

Get Order Details v6

Use your Ingram Micro sales order number to search for existing orders or retrieve existing order details.  The sales order number, IM-CustomerNumber, IM-CountryCode, IM-SenderID and IM-CorrelationID are required parameters.  In a case when the IM sales order number is repeated, you can refine the result by providing for additional filtering.  Use the \"simulateStatus\" query parameter to test the GET order response for various order statuses. This parameter is only available in the sandbox to help with development and testing of the GET order endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using xi.sdk.resellers.csharp.Api;
using xi.sdk.resellers.csharp.Client;
using xi.sdk.resellers.csharp.Model;

namespace Example
{
    public class GetOrderdetailsV6Example
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
            var apiInstance = new OrdersV6Api(httpClient, config, httpClientHandler);
            var ordernumber = 20-RD3QV;  // string | The Ingram Micro sales order number.
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany. (optional) 
            var ingramOrderDate = Wed May 13 00:00:00 UTC 2020;  // DateTime? | The date and time in UTC format that the order was created. (optional) 
            var vendorNumber = "vendorNumber_example";  // string? | Vendor Number. (optional) 
            var simulateStatus = "IM::SHIPPED";  // string? | Order response for various order statuses. Not for use in production. (optional) 
            var isIml = true;  // bool? | True/False only for IML customers. (optional) 
            var regionCode = "regionCode_example";  // string? | Region code for sandbox testing - Not for use in production. (optional) 

            try
            {
                // Get Order Details v6
                OrderDetailResponse result = apiInstance.GetOrderdetailsV6(ordernumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, ingramOrderDate, vendorNumber, simulateStatus, isIml, regionCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV6Api.GetOrderdetailsV6: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderdetailsV6WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order Details v6
    ApiResponse<OrderDetailResponse> response = apiInstance.GetOrderdetailsV6WithHttpInfo(ordernumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, ingramOrderDate, vendorNumber, simulateStatus, isIml, regionCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV6Api.GetOrderdetailsV6WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ordernumber** | **string** | The Ingram Micro sales order number. |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction accross all the systems. |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany. | [optional]  |
| **ingramOrderDate** | **DateTime?** | The date and time in UTC format that the order was created. | [optional]  |
| **vendorNumber** | **string?** | Vendor Number. | [optional]  |
| **simulateStatus** | **string?** | Order response for various order statuses. Not for use in production. | [optional]  |
| **isIml** | **bool?** | True/False only for IML customers. | [optional]  |
| **regionCode** | **string?** | Region code for sandbox testing - Not for use in production. | [optional]  |

### Return type

[**OrderDetailResponse**](OrderDetailResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * IM-CorrelationID - Unique transaction number to identify each transaction across all the systems. <br>  * IM-SenderID - Unique value used to identify the sender of the transaction. Example: MyCompany <br>  |
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

