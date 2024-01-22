# xi.sdk.resellers.Api.QuoteToOrderApi

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostQuoteToOrderV6**](QuoteToOrderApi.md#postquotetoorderv6) | **POST** /resellers/v6/q2o/orders | Quote To Order |

<a id="postquotetoorderv6"></a>
# **PostQuoteToOrderV6**
> QuoteToOrderResponse PostQuoteToOrderV6 (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, QuoteToOrderDetailsDTO quoteToOrderDetailsDTO, string? iMSenderID = null)

Quote To Order

The “Quote to Order” (QTO) endpoint allows a customer to create an order using the existing quote which is in “Ready to Order” status. A customer can create an order using Configure to order (CTO) quote or a non-configure to order (Non-CTO) quote. Upon successful submission of the order create request, a confirmation message will be returned as an API response. <br > <br >Ingram Micro offers webhooks as a method to send notifications to Resellers once the order creation request is received. All the updates related to Order creation will be pushed as a notification to the customer via a pre-defined callback URL as an HTTP post. <br > <br > **Prerequisite:** Pre-defined callback URL <br > <br > Before creating an order using the quote, it’s recommended to validate the quote using the “Validate Quote” endpoint. Validate Quote endpoint will not only validate the quote but also outline all the mandatory fields required by the vendor at a header level and at the line level which a customer need to pass to the Quote To Order endpoint request.  For a detailed understanding of the “Validate Quote” endpoint, review the “Validate Quote” endpoint documentation. <br ><br > **How it works:** <br ><br > - The customer validates the quote with a quote number from Validate Quote endpoint. <br > - The customer copies all the mandatory fields required by the vendor and adds them to the QTO request body. <br > - The customer provides all the values for Vendor mandatory fields along with other required information for QTO to create an order. <br > - After the order creation request receipt acknowledgment from the QTO endpoint, all further order creation updates will be provided via webhook push notification.

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
    public class PostQuoteToOrderV6Example
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
            var apiInstance = new QuoteToOrderApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction accross all the systems.
            var quoteToOrderDetailsDTO = new QuoteToOrderDetailsDTO(); // QuoteToOrderDetailsDTO | 
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. (optional) 

            try
            {
                // Quote To Order
                QuoteToOrderResponse result = apiInstance.PostQuoteToOrderV6(iMCustomerNumber, iMCountryCode, iMCorrelationID, quoteToOrderDetailsDTO, iMSenderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuoteToOrderApi.PostQuoteToOrderV6: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostQuoteToOrderV6WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Quote To Order
    ApiResponse<QuoteToOrderResponse> response = apiInstance.PostQuoteToOrderV6WithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, quoteToOrderDetailsDTO, iMSenderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuoteToOrderApi.PostQuoteToOrderV6WithHttpInfo: " + e.Message);
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
| **quoteToOrderDetailsDTO** | [**QuoteToOrderDetailsDTO**](QuoteToOrderDetailsDTO.md) |  |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. | [optional]  |

### Return type

[**QuoteToOrderResponse**](QuoteToOrderResponse.md)

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

