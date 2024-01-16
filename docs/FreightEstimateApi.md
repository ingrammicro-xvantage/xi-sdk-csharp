# xi.sdk.resellers.csharp.Api.FreightEstimateApi

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostFreightestimate**](FreightEstimateApi.md#postfreightestimate) | **POST** /resellers/v6/freightestimate | Freight Estimate |

<a id="postfreightestimate"></a>
# **PostFreightestimate**
> FreightResponse PostFreightestimate (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string iMCustomerContact, string? iMSenderID = null, FreightRequest? freightRequest = null)

Freight Estimate

The freight estimator endpoint will allow customers to understand the freight cost for an order.

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
    public class PostFreightestimateExample
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
            var apiInstance = new FreightEstimateApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var iMCustomerContact = John.Doe@reseller.com;  // string | Logged in Users email address contact.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. (optional) 
            var freightRequest = new FreightRequest?(); // FreightRequest? |  (optional) 

            try
            {
                // Freight Estimate
                FreightResponse result = apiInstance.PostFreightestimate(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMCustomerContact, iMSenderID, freightRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FreightEstimateApi.PostFreightestimate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostFreightestimateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Freight Estimate
    ApiResponse<FreightResponse> response = apiInstance.PostFreightestimateWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMCustomerContact, iMSenderID, freightRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FreightEstimateApi.PostFreightestimateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **iMCustomerContact** | **string** | Logged in Users email address contact. |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. | [optional]  |
| **freightRequest** | [**FreightRequest?**](FreightRequest?.md) |  | [optional]  |

### Return type

[**FreightResponse**](FreightResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error: Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

