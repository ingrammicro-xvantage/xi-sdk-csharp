# xi-sdk-csharp.Api.QuotesV4Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostV4Quotedetails**](QuotesV4Api.md#postv4quotedetails) | **POST** /quotes/v1/quotedetails | Get Quote Details |
| [**PostV4Quotesearch**](QuotesV4Api.md#postv4quotesearch) | **POST** /quotes/v1/quotes | Get Quote List |

<a id="postv4quotedetails"></a>
# **PostV4Quotedetails**
> QuoteDetailsResponse PostV4Quotedetails (QuoteDetailsRequest? quoteDetailsRequest = null)

Get Quote Details

A real-time request to delete a previously accepted order must be submitted before the order is released to Ingram Micro’s warehouse. After release the order is no longer eligible for deletion. Order delete transaction submitted after the order is released will be rejected and will not be applied. *Direct ship orders cannot be deleted. Contact your sales rep for assistance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using xi-sdk-csharp.Api;
using xi-sdk-csharp.Client;
using xi-sdk-csharp.Model;

namespace Example
{
    public class PostV4QuotedetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443/sandbox";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuotesV4Api(config);
            var quoteDetailsRequest = new QuoteDetailsRequest?(); // QuoteDetailsRequest? |  (optional) 

            try
            {
                // Get Quote Details
                QuoteDetailsResponse result = apiInstance.PostV4Quotedetails(quoteDetailsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuotesV4Api.PostV4Quotedetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4QuotedetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Quote Details
    ApiResponse<QuoteDetailsResponse> response = apiInstance.PostV4QuotedetailsWithHttpInfo(quoteDetailsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuotesV4Api.PostV4QuotedetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **quoteDetailsRequest** | [**QuoteDetailsRequest?**](QuoteDetailsRequest?.md) |  | [optional]  |

### Return type

[**QuoteDetailsResponse**](QuoteDetailsResponse.md)

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

<a id="postv4quotesearch"></a>
# **PostV4Quotesearch**
> QuoteListResponse PostV4Quotesearch (QuoteListRequest? quoteListRequest = null)

Get Quote List

A real-time request that allows the customer to query Ingram Micro for detailed information for a specific open or shipped order. Orders are searched using Ingram Micro Sales Order Number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using xi-sdk-csharp.Api;
using xi-sdk-csharp.Client;
using xi-sdk-csharp.Model;

namespace Example
{
    public class PostV4QuotesearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443/sandbox";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuotesV4Api(config);
            var quoteListRequest = new QuoteListRequest?(); // QuoteListRequest? |  (optional) 

            try
            {
                // Get Quote List
                QuoteListResponse result = apiInstance.PostV4Quotesearch(quoteListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuotesV4Api.PostV4Quotesearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4QuotesearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Quote List
    ApiResponse<QuoteListResponse> response = apiInstance.PostV4QuotesearchWithHttpInfo(quoteListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuotesV4Api.PostV4QuotesearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **quoteListRequest** | [**QuoteListRequest?**](QuoteListRequest?.md) |  | [optional]  |

### Return type

[**QuoteListResponse**](QuoteListResponse.md)

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

