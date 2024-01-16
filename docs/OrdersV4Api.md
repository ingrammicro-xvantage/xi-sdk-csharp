# xi.sdk.resellers.csharp.Api.OrdersV4Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostV4Ordercreate**](OrdersV4Api.md#postv4ordercreate) | **POST** /orders/v4/ordercreate | Create a new Order |
| [**PostV4Orderdelete**](OrdersV4Api.md#postv4orderdelete) | **POST** /orders/v4/orderdelete | Delete an Order |
| [**PostV4Orderdetails**](OrdersV4Api.md#postv4orderdetails) | **POST** /orders/v4/orderdetails | Get Order Details |
| [**PostV4Ordermodify**](OrdersV4Api.md#postv4ordermodify) | **POST** /orders/v4/ordermodify | Modify an Existing Order |
| [**PostV4Ordersearch**](OrdersV4Api.md#postv4ordersearch) | **POST** /orders/v4/orderlookup | Order Search |

<a id="postv4ordercreate"></a>
# **PostV4Ordercreate**
> OrderCreateResponse PostV4Ordercreate (OrderCreateRequest? orderCreateRequest = null)

Create a new Order

The order create transaction is a real-time transaction that allows customers to place standard product and direct ship (licensing and warranties) orders with Ingram Micro using API.

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
    public class PostV4OrdercreateExample
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
            var apiInstance = new OrdersV4Api(httpClient, config, httpClientHandler);
            var orderCreateRequest = new OrderCreateRequest?(); // OrderCreateRequest? |  (optional) 

            try
            {
                // Create a new Order
                OrderCreateResponse result = apiInstance.PostV4Ordercreate(orderCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV4Api.PostV4Ordercreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4OrdercreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Order
    ApiResponse<OrderCreateResponse> response = apiInstance.PostV4OrdercreateWithHttpInfo(orderCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV4Api.PostV4OrdercreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderCreateRequest** | [**OrderCreateRequest?**](OrderCreateRequest?.md) |  | [optional]  |

### Return type

[**OrderCreateResponse**](OrderCreateResponse.md)

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

<a id="postv4orderdelete"></a>
# **PostV4Orderdelete**
> OrderDeleteResponse PostV4Orderdelete (OrderDeleteRequest? orderDeleteRequest = null)

Delete an Order

A real-time request to delete a previously accepted order must be submitted before the order is released to Ingram Micro’s warehouse. After release the order is no longer eligible for deletion. Order delete transaction submitted after the order is released will be rejected and will not be applied. *Direct ship orders cannot be deleted. Contact your sales rep for assistance.

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
    public class PostV4OrderdeleteExample
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
            var apiInstance = new OrdersV4Api(httpClient, config, httpClientHandler);
            var orderDeleteRequest = new OrderDeleteRequest?(); // OrderDeleteRequest? |  (optional) 

            try
            {
                // Delete an Order
                OrderDeleteResponse result = apiInstance.PostV4Orderdelete(orderDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV4Api.PostV4Orderdelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4OrderdeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an Order
    ApiResponse<OrderDeleteResponse> response = apiInstance.PostV4OrderdeleteWithHttpInfo(orderDeleteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV4Api.PostV4OrderdeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderDeleteRequest** | [**OrderDeleteRequest?**](OrderDeleteRequest?.md) |  | [optional]  |

### Return type

[**OrderDeleteResponse**](OrderDeleteResponse.md)

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

<a id="postv4orderdetails"></a>
# **PostV4Orderdetails**
> OrderDetailResponse PostV4Orderdetails (OrderDetailRequest? orderDetailRequest = null)

Get Order Details

A real-time request that allows the customer to query Ingram Micro for detailed information for a specific open or shipped order. Orders are searched using Ingram Micro Sales Order Number.

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
    public class PostV4OrderdetailsExample
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
            var apiInstance = new OrdersV4Api(httpClient, config, httpClientHandler);
            var orderDetailRequest = new OrderDetailRequest?(); // OrderDetailRequest? |  (optional) 

            try
            {
                // Get Order Details
                OrderDetailResponse result = apiInstance.PostV4Orderdetails(orderDetailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV4Api.PostV4Orderdetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4OrderdetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order Details
    ApiResponse<OrderDetailResponse> response = apiInstance.PostV4OrderdetailsWithHttpInfo(orderDetailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV4Api.PostV4OrderdetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderDetailRequest** | [**OrderDetailRequest?**](OrderDetailRequest?.md) |  | [optional]  |

### Return type

[**OrderDetailResponse**](OrderDetailResponse.md)

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

<a id="postv4ordermodify"></a>
# **PostV4Ordermodify**
> OrderModifyResponse PostV4Ordermodify (OrderModifyRequest? orderModifyRequest = null)

Modify an Existing Order

The order modify transaction allows for changes to be made after the order creation process but before the order is released to Ingram Micro’s warehouse system.  Order modify transaction submitted after the order is released will be rejected and will not be applied.  Types of modifications allowable: Order release, add comment, and carrier change. NOTE - Direct Ship orders cannot be modified. 

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
    public class PostV4OrdermodifyExample
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
            var apiInstance = new OrdersV4Api(httpClient, config, httpClientHandler);
            var orderModifyRequest = new OrderModifyRequest?(); // OrderModifyRequest? |  (optional) 

            try
            {
                // Modify an Existing Order
                OrderModifyResponse result = apiInstance.PostV4Ordermodify(orderModifyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV4Api.PostV4Ordermodify: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4OrdermodifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Modify an Existing Order
    ApiResponse<OrderModifyResponse> response = apiInstance.PostV4OrdermodifyWithHttpInfo(orderModifyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV4Api.PostV4OrdermodifyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderModifyRequest** | [**OrderModifyRequest?**](OrderModifyRequest?.md) |  | [optional]  |

### Return type

[**OrderModifyResponse**](OrderModifyResponse.md)

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

<a id="postv4ordersearch"></a>
# **PostV4Ordersearch**
> OrderSearchResponse PostV4Ordersearch (OrderSearchRequest? orderSearchRequest = null)

Order Search

Search your orders using various search parameters

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
    public class PostV4OrdersearchExample
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
            var apiInstance = new OrdersV4Api(httpClient, config, httpClientHandler);
            var orderSearchRequest = new OrderSearchRequest?(); // OrderSearchRequest? |  (optional) 

            try
            {
                // Order Search
                OrderSearchResponse result = apiInstance.PostV4Ordersearch(orderSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV4Api.PostV4Ordersearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV4OrdersearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Order Search
    ApiResponse<OrderSearchResponse> response = apiInstance.PostV4OrdersearchWithHttpInfo(orderSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV4Api.PostV4OrdersearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderSearchRequest** | [**OrderSearchRequest?**](OrderSearchRequest?.md) |  | [optional]  |

### Return type

[**OrderSearchResponse**](OrderSearchResponse.md)

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

