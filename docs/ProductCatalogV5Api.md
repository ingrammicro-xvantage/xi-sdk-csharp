# xi-sdk-resellers-csharp.Api.ProductCatalogV5Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetV5CatalogProductsearch**](ProductCatalogV5Api.md#getv5catalogproductsearch) | **GET** /resellers/v5/Catalog | Search Product Catalog |
| [**MultiSKUPriceAndStock**](ProductCatalogV5Api.md#multiskupriceandstock) | **POST** /resellers/v5/Catalog/priceandavailability | Find availability of upto 50 SKUs |

<a id="getv5catalogproductsearch"></a>
# **GetV5CatalogProductsearch**
> ProductSearchResponse GetV5CatalogProductsearch (string customerNumber, string isoCountryCode, string partNumber)

Search Product Catalog

Search the Ingram Micro product catalog using customerNumber, isoCountryCode and partNumber.<ul><li>customerNumber and isoCountryCode fields are required.</li><li>The PartNumber field accepts the following:<ul><li>Ingram part number</li><li>Vendor part number</li><li>Customer part number</li><li>UPC (Universal Product Code)</li></ul></li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using xi-sdk-resellers-csharp.Api;
using xi-sdk-resellers-csharp.Client;
using xi-sdk-resellers-csharp.Model;

namespace Example
{
    public class GetV5CatalogProductsearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443/sandbox";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductCatalogV5Api(config);
            var customerNumber = "\"20-222222\"";  // string | Your unique Ingram Micro customer number (default to "20-222222")
            var isoCountryCode = "\"US\"";  // string | 2 chars country code (default to "US")
            var partNumber = "\"1AQ821\"";  // string | Part Number can be ingram part number or vendor part number or customer part number or UPC (default to "1AQ821")

            try
            {
                // Search Product Catalog
                ProductSearchResponse result = apiInstance.GetV5CatalogProductsearch(customerNumber, isoCountryCode, partNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCatalogV5Api.GetV5CatalogProductsearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetV5CatalogProductsearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Product Catalog
    ApiResponse<ProductSearchResponse> response = apiInstance.GetV5CatalogProductsearchWithHttpInfo(customerNumber, isoCountryCode, partNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCatalogV5Api.GetV5CatalogProductsearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerNumber** | **string** | Your unique Ingram Micro customer number | [default to &quot;20-222222&quot;] |
| **isoCountryCode** | **string** | 2 chars country code | [default to &quot;US&quot;] |
| **partNumber** | **string** | Part Number can be ingram part number or vendor part number or customer part number or UPC | [default to &quot;1AQ821&quot;] |

### Return type

[**ProductSearchResponse**](ProductSearchResponse.md)

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

<a id="multiskupriceandstock"></a>
# **MultiSKUPriceAndStock**
> PriceAndAvailabilityResponse MultiSKUPriceAndStock (PriceAndAvailabilityRequest? priceAndAvailabilityRequest = null)

Find availability of upto 50 SKUs

Search the product catalog for the price and availability for up to 50 SKUs at one time. This endpoint helps to confirm the details just prior to placing a real-time call.<ul><li>You may request visibility for reserve stock if you participate in reserved inventory, in addition to the stock that is open to all the partners. Please see the details in the endpoint model below.</li><li>Follow these guidelines when using this endpoint:<ul><li>This endpoint is not for refreshing the full catalog with availability and pricing information. Ingram Micro applies rate limits on this endpoint. Continuous cyclical calls will error out. Customers that perform this activity may lose access to the endpoint.</li><li>For the full catalog refresh, Ingram Micro can provide a Price and Inventory file in flat file format, made available through FTP download. Please contact your Ingram Micro sales rep for details.</li></ul></li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using xi-sdk-resellers-csharp.Api;
using xi-sdk-resellers-csharp.Client;
using xi-sdk-resellers-csharp.Model;

namespace Example
{
    public class MultiSKUPriceAndStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443/sandbox";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProductCatalogV5Api(config);
            var priceAndAvailabilityRequest = new PriceAndAvailabilityRequest?(); // PriceAndAvailabilityRequest? |  (optional) 

            try
            {
                // Find availability of upto 50 SKUs
                PriceAndAvailabilityResponse result = apiInstance.MultiSKUPriceAndStock(priceAndAvailabilityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductCatalogV5Api.MultiSKUPriceAndStock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MultiSKUPriceAndStockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find availability of upto 50 SKUs
    ApiResponse<PriceAndAvailabilityResponse> response = apiInstance.MultiSKUPriceAndStockWithHttpInfo(priceAndAvailabilityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductCatalogV5Api.MultiSKUPriceAndStockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **priceAndAvailabilityRequest** | [**PriceAndAvailabilityRequest?**](PriceAndAvailabilityRequest?.md) |  | [optional]  |

### Return type

[**PriceAndAvailabilityResponse**](PriceAndAvailabilityResponse.md)

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

