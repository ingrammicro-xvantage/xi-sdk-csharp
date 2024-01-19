# xi.sdk.resellers.Api.QuotesV5Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetV5QuotesDetails**](QuotesV5Api.md#getv5quotesdetails) | **GET** /resellers/v5/quote/{quoteNumber} | Get Quote Details |
| [**PostV5QuotesSearch**](QuotesV5Api.md#postv5quotessearch) | **POST** /resellers/v5/quote/search | Search Quotes |

<a id="getv5quotesdetails"></a>
# **GetV5QuotesDetails**
> QuoteDetails GetV5QuotesDetails (string quoteNumber, string customerNumber, string isoCountryCode, string? thirdPartySource = null)

Get Quote Details

The quote details API provides all quote details associated with the quote number provided.   The “<strong>quoteNumber</strong>”, “<strong>isoCountryCode</strong>” and “<strong>customerNumber</strong>” parameters are required.

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
    public class GetV5QuotesDetailsExample
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
            var apiInstance = new QuotesV5Api(httpClient, config, httpClientHandler);
            var quoteNumber = "\"QUO-25576-C8S2W7\"";  // string | Ingram Micro Quote Number (default to "QUO-25576-C8S2W7")
            var customerNumber = "\"20-222222\"";  // string | Your Ingram Micro unique customer number (default to "20-222222")
            var isoCountryCode = "\"US\"";  // string |  (default to "US")
            var thirdPartySource = "\"customer\"";  // string? | Unique identifier used to identify the third party source accessing the services (optional)  (default to "customer")

            try
            {
                // Get Quote Details
                QuoteDetails result = apiInstance.GetV5QuotesDetails(quoteNumber, customerNumber, isoCountryCode, thirdPartySource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuotesV5Api.GetV5QuotesDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetV5QuotesDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Quote Details
    ApiResponse<QuoteDetails> response = apiInstance.GetV5QuotesDetailsWithHttpInfo(quoteNumber, customerNumber, isoCountryCode, thirdPartySource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuotesV5Api.GetV5QuotesDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **quoteNumber** | **string** | Ingram Micro Quote Number | [default to &quot;QUO-25576-C8S2W7&quot;] |
| **customerNumber** | **string** | Your Ingram Micro unique customer number | [default to &quot;20-222222&quot;] |
| **isoCountryCode** | **string** |  | [default to &quot;US&quot;] |
| **thirdPartySource** | **string?** | Unique identifier used to identify the third party source accessing the services | [optional] [default to &quot;customer&quot;] |

### Return type

[**QuoteDetails**](QuoteDetails.md)

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

<a id="postv5quotessearch"></a>
# **PostV5QuotesSearch**
> QuoteListResponse PostV5QuotesSearch (QuoteListRequest? quoteListRequest = null)

Search Quotes

This endpoint enables the retrieval and filtering of relevant quote list key criteria data, such as quote number, special bid numbers, end user name, status, and date ranges from the Ingram Micro system. By default, the Quotes endpoint retrieves quotes modified or created within the last 30 days.   Observe these additional parameters:<ul><li>Only active quotes are available through this API.</li><li>Quotes older than 365 days are excluded by default.</li><li>You can use date range filters to retrieve quotes older than 30 days and up to 365 days.</li><li>Quotes that are in draft and closed states are excluded, and are not accessible through this API.</li></ul>

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
    public class PostV5QuotesSearchExample
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
            var apiInstance = new QuotesV5Api(httpClient, config, httpClientHandler);
            var quoteListRequest = new QuoteListRequest?(); // QuoteListRequest? |  (optional) 

            try
            {
                // Search Quotes
                QuoteListResponse result = apiInstance.PostV5QuotesSearch(quoteListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuotesV5Api.PostV5QuotesSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV5QuotesSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Quotes
    ApiResponse<QuoteListResponse> response = apiInstance.PostV5QuotesSearchWithHttpInfo(quoteListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuotesV5Api.PostV5QuotesSearchWithHttpInfo: " + e.Message);
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

