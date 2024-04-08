# xi.sdk.resellers.Api.AsyncOrderCreateApi

All URIs are relative to *https://api.ingrammicro.com:443*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostAsyncOrderCreateV7**](AsyncOrderCreateApi.md#postasyncordercreatev7) | **POST** /resellers/v7/orders | Async Order Create |

<a id="postasyncordercreatev7"></a>
# **PostAsyncOrderCreateV7**
> AsyncOrderCreateResponse PostAsyncOrderCreateV7 (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, AsyncOrderCreateDTO asyncOrderCreateDTO, string? iMSenderID = null)

Async Order Create

This API will allow customers to perform both standard ordering and quote to order functionality via a single API enabling them to have a single endpoint to cater to all types of orders.  This approach will standardize the ordering flow for customers where they will get the response for all orders on to their webhooks.  It provides the much-awaited async ordering flow for Reseller API where large orders can also be placed via a single API with guaranteed delivery. 

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
    public class PostAsyncOrderCreateV7Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AsyncOrderCreateApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems.
            var asyncOrderCreateDTO = new AsyncOrderCreateDTO(); // AsyncOrderCreateDTO | 
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. (optional) 

            try
            {
                // Async Order Create
                AsyncOrderCreateResponse result = apiInstance.PostAsyncOrderCreateV7(iMCustomerNumber, iMCountryCode, iMCorrelationID, asyncOrderCreateDTO, iMSenderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AsyncOrderCreateApi.PostAsyncOrderCreateV7: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostAsyncOrderCreateV7WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Async Order Create
    ApiResponse<AsyncOrderCreateResponse> response = apiInstance.PostAsyncOrderCreateV7WithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, asyncOrderCreateDTO, iMSenderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AsyncOrderCreateApi.PostAsyncOrderCreateV7WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction accross all the systems. |  |
| **asyncOrderCreateDTO** | [**AsyncOrderCreateDTO**](AsyncOrderCreateDTO.md) |  |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. | [optional]  |

### Return type

[**AsyncOrderCreateResponse**](AsyncOrderCreateResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

