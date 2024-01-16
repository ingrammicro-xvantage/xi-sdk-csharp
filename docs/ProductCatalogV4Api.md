# xi.sdk.resellers.csharp.Api.ProductCatalogV4Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostV4Multiskupriceandstock**](ProductCatalogV4Api.md#postv4multiskupriceandstock) | **POST** /products/v4/multiskupriceandstock | Product availability for upto 50 SKUs |
| [**PostV4Productsearch**](ProductCatalogV4Api.md#postv4productsearch) | **POST** /products/v4/productsearch | Real-time Product Search |

<a id="postv4multiskupriceandstock"></a>
# **PostV4Multiskupriceandstock**
> MultiSKUPriceAndStockResponse PostV4Multiskupriceandstock (MultiSKUPriceAndStockRequest? multiSKUPriceAndStockRequest = null)

Product availability for upto 50 SKUs

Find price and availability of up to 50 SKUs in a single request. As you increase the number of items in the request response time will be extended. This transaction must not be used as a continuous cyclical call to populate availability and pricing for your full catalog. Customers that perform this activity will lose access to price and availability.  Ingram can provide a Price catalog file and an Inventory file in flat file format, which can be obtained through FTP download. Please contact 1800-616-4665 or Electronic.Services@ingrammicro.com for more information on these files.

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
    public class PostV4MultiskupriceandstockExample
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
            var apiInstance = new ProductCatalogV4Api(httpClient, config, httpClientHandler);
            var multiSKUPriceAndStockRequest = new MultiSKUPriceAndStockRequest?(); // MultiSKUPriceAndStockRequest? |  (optional) 

            try
            {
                // Product availability for upto 50 SKUs
                MultiSKUPriceAndStockResponse result = apiInstance.PostV4Multiskupriceandstock(multiSKUPriceAndStockRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCatalogV4Api.PostV4Multiskupriceandstock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4MultiskupriceandstockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Product availability for upto 50 SKUs
    ApiResponse<MultiSKUPriceAndStockResponse> response = apiInstance.PostV4MultiskupriceandstockWithHttpInfo(multiSKUPriceAndStockRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCatalogV4Api.PostV4MultiskupriceandstockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **multiSKUPriceAndStockRequest** | [**MultiSKUPriceAndStockRequest?**](MultiSKUPriceAndStockRequest?.md) |  | [optional]  |

### Return type

[**MultiSKUPriceAndStockResponse**](MultiSKUPriceAndStockResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postv4productsearch"></a>
# **PostV4Productsearch**
> ProductSearchResponse PostV4Productsearch (ProductSearchRequest? productSearchRequest = null)

Real-time Product Search

A real time search that provides the Ingram Micro part number using the manufacturer part number.  This API is helpful to eliminate any errors when a manufactuer has the same part number and Ingram Micro has had to create multiple sku numbers 

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
    public class PostV4ProductsearchExample
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
            var apiInstance = new ProductCatalogV4Api(httpClient, config, httpClientHandler);
            var productSearchRequest = new ProductSearchRequest?(); // ProductSearchRequest? |  (optional) 

            try
            {
                // Real-time Product Search
                ProductSearchResponse result = apiInstance.PostV4Productsearch(productSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCatalogV4Api.PostV4Productsearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4ProductsearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Real-time Product Search
    ApiResponse<ProductSearchResponse> response = apiInstance.PostV4ProductsearchWithHttpInfo(productSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCatalogV4Api.PostV4ProductsearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productSearchRequest** | [**ProductSearchRequest?**](ProductSearchRequest?.md) |  | [optional]  |

### Return type

[**ProductSearchResponse**](ProductSearchResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

