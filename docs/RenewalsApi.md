# xi.sdk.resellers.csharp.Api.RenewalsApi

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetResellersV6Renewalsdetails**](RenewalsApi.md#getresellersv6renewalsdetails) | **GET** /resellers/v6/renewals/{renewalId} | Renewals Details |
| [**PostRenewalssearch**](RenewalsApi.md#postrenewalssearch) | **POST** /resellers/v6/renewals/search | Renewals Search |

<a id="getresellersv6renewalsdetails"></a>
# **GetResellersV6Renewalsdetails**
> RenewalsDetailsResponse GetResellersV6Renewalsdetails (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string renewalId, string? iMSenderID = null)

Renewals Details

The Renewal Details API endpoint will retrieve all the details related to the renewal. The customer is required to pass renewalId as a path parameter while sending a request.

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
    public class GetResellersV6RenewalsdetailsExample
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
            var apiInstance = new RenewalsApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var renewalId = 123456;  // string | Unique Ingram renewal ID.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 

            try
            {
                // Renewals Details
                RenewalsDetailsResponse result = apiInstance.GetResellersV6Renewalsdetails(iMCustomerNumber, iMCountryCode, iMCorrelationID, renewalId, iMSenderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RenewalsApi.GetResellersV6Renewalsdetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellersV6RenewalsdetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Renewals Details
    ApiResponse<RenewalsDetailsResponse> response = apiInstance.GetResellersV6RenewalsdetailsWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, renewalId, iMSenderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RenewalsApi.GetResellersV6RenewalsdetailsWithHttpInfo: " + e.Message);
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
| **renewalId** | **string** | Unique Ingram renewal ID. |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |

### Return type

[**RenewalsDetailsResponse**](RenewalsDetailsResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postrenewalssearch"></a>
# **PostRenewalssearch**
> RenewalsSearchResponse PostRenewalssearch (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string contentType, string? iMSenderID = null, string? customerOrderNumber = null, string? ingramPurchaseOrderNumber = null, string? serialNumber = null, string? page = null, string? size = null, string? sort = null, RenewalsSearchRequest? renewalsSearchRequest = null)

Renewals Search

The Renewal Search API, by default, will retrieve all the renewals that are associated with the customer’s account. The customer will be able to search for renewals via basic search or advanced search. Basic search is available thru the query string parameters, whereas the advanced search is available thru the request body schema. 

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
    public class PostRenewalssearchExample
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
            var apiInstance = new RenewalsApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var contentType = application/json;  // string | The media type for JSON Request.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 
            var customerOrderNumber = "customerOrderNumber_example";  // string? | The reseller's unique PO/Order number. (optional) 
            var ingramPurchaseOrderNumber = "ingramPurchaseOrderNumber_example";  // string? | Sales order number. (optional) 
            var serialNumber = "serialNumber_example";  // string? | A serial number of the product. (optional) 
            var page = "page_example";  // string? | Number of page. (optional) 
            var size = "size_example";  // string? | The submitted pagesize, default is 25. (optional) 
            var sort = "sort_example";  // string? | Refers to the column selected to apply the sorting criteria. (optional) 
            var renewalsSearchRequest = new RenewalsSearchRequest?(); // RenewalsSearchRequest? |  (optional) 

            try
            {
                // Renewals Search
                RenewalsSearchResponse result = apiInstance.PostRenewalssearch(iMCustomerNumber, iMCountryCode, iMCorrelationID, contentType, iMSenderID, customerOrderNumber, ingramPurchaseOrderNumber, serialNumber, page, size, sort, renewalsSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RenewalsApi.PostRenewalssearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostRenewalssearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Renewals Search
    ApiResponse<RenewalsSearchResponse> response = apiInstance.PostRenewalssearchWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, contentType, iMSenderID, customerOrderNumber, ingramPurchaseOrderNumber, serialNumber, page, size, sort, renewalsSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RenewalsApi.PostRenewalssearchWithHttpInfo: " + e.Message);
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
| **contentType** | **string** | The media type for JSON Request. |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |
| **customerOrderNumber** | **string?** | The reseller&#39;s unique PO/Order number. | [optional]  |
| **ingramPurchaseOrderNumber** | **string?** | Sales order number. | [optional]  |
| **serialNumber** | **string?** | A serial number of the product. | [optional]  |
| **page** | **string?** | Number of page. | [optional]  |
| **size** | **string?** | The submitted pagesize, default is 25. | [optional]  |
| **sort** | **string?** | Refers to the column selected to apply the sorting criteria. | [optional]  |
| **renewalsSearchRequest** | [**RenewalsSearchRequest?**](RenewalsSearchRequest?.md) |  | [optional]  |

### Return type

[**RenewalsSearchResponse**](RenewalsSearchResponse.md)

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

