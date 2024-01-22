# xi.sdk.resellers.Api.OrdersV5Api

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteOrdersOrderNumber**](OrdersV5Api.md#deleteordersordernumber) | **DELETE** /resellers/v5/Orders/{ordernumber} | Cancel an Existing Order |
| [**GetOrdersSearch**](OrdersV5Api.md#getorderssearch) | **GET** /resellers/v5/Orders/search | Search your Orders |
| [**GetV5OrdersDetails**](OrdersV5Api.md#getv5ordersdetails) | **GET** /resellers/v5/Orders/{ordernumber} | Get Order Details |
| [**PostV5OrdersCreate**](OrdersV5Api.md#postv5orderscreate) | **POST** /resellers/v5/Orders | Create a New Order |

<a id="deleteordersordernumber"></a>
# **DeleteOrdersOrderNumber**
> OrderCancelResponse DeleteOrdersOrderNumber (string ordernumber, string customerNumber, string isoCountryCode, string entryDate)

Cancel an Existing Order

This endpoint is a request to cancel a previously accepted order. Use your Ingram Micro sales order number to cancel an order.   The <strong>orderNumber, isoCountryCode, customerNumber</strong> and <strong>entryDate</strong> parameters are required.   This call must be submitted <strong>before</strong> the order is released to Ingram Micro’s warehouse. The order cannot be canceled once it is released to the warehouse.   Direct ship orders cannot be canceled. Contact your Ingram Micro sales rep for assistance.

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
    public class DeleteOrdersOrderNumberExample
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
            var apiInstance = new OrdersV5Api(httpClient, config, httpClientHandler);
            var ordernumber = 20-RD128;  // string | Ingram Micro sales order number
            var customerNumber = "customerNumber_example";  // string | Your unique Ingram Micro customer number
            var isoCountryCode = "isoCountryCode_example";  // string | 2 chars ISO country code
            var entryDate = "\"2020-04-03\"";  // string | Order entry date (yyyy-mm-dd) (default to "2020-04-03")

            try
            {
                // Cancel an Existing Order
                OrderCancelResponse result = apiInstance.DeleteOrdersOrderNumber(ordernumber, customerNumber, isoCountryCode, entryDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV5Api.DeleteOrdersOrderNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrdersOrderNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel an Existing Order
    ApiResponse<OrderCancelResponse> response = apiInstance.DeleteOrdersOrderNumberWithHttpInfo(ordernumber, customerNumber, isoCountryCode, entryDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV5Api.DeleteOrdersOrderNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ordernumber** | **string** | Ingram Micro sales order number |  |
| **customerNumber** | **string** | Your unique Ingram Micro customer number |  |
| **isoCountryCode** | **string** | 2 chars ISO country code |  |
| **entryDate** | **string** | Order entry date (yyyy-mm-dd) | [default to &quot;2020-04-03&quot;] |

### Return type

[**OrderCancelResponse**](OrderCancelResponse.md)

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

<a id="getorderssearch"></a>
# **GetOrdersSearch**
> OrderSearchResponse GetOrdersSearch (string customerNumber, string isocountrycode, string? ordernumber = null, string? customerordernumber = null, string? orderstatus = null, DateTime? startcreatetimestamp = null, DateTime? endcreatetimestamp = null, int? pagesize = null, int? pagenumber = null)

Search your Orders

Search your Ingram Micro orders. This endpoint searches by multiple order parameters and supports pagination of results. Search using one or more of the parameters below:   <ul><li>ordernumber — Ingram Micro sales order number</li><li>customerordernumber — The PO or order number provided by you when creating an order</li><li>orderstatus — user order status codes for the search, default is set to \"any\"</li><li>startcreatetimestamp and endcreatetimestamp — Order create date range</li></ul>   For pagination, please use these parameters:  <ul><li>pagesize — default 25, max 100</li><li>pagenumber — default 1</li></ul>   Order Status Values:  <ul><li>P – PENDING</li><li>R – RELEASED</li><li>4 – SHIPPED</li><li>I – INVOICED</li><li>V – VOIDED</li></ul>   The search endpoint also returns HATEOAS links for order details and invoice details, if applicable.

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
    public class GetOrdersSearchExample
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
            var apiInstance = new OrdersV5Api(httpClient, config, httpClientHandler);
            var customerNumber = 20-222222;  // string | Your unique Ingram Micro customer number
            var isocountrycode = US;  // string | 2 char iso country code
            var ordernumber = "ordernumber_example";  // string? | Ingram sales order number (optional) 
            var customerordernumber = ZENPO1;  // string? | Search using your PO/Order number (optional) 
            var orderstatus = ;  // string? | Ingram Micro order status (optional)  (default to any)
            var startcreatetimestamp = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search start date/time in UTC format (optional) 
            var endcreatetimestamp = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Search end date/time in UTC format (optional) 
            var pagesize = 56;  // int? | Number of records required in the call (optional) 
            var pagenumber = 1;  // int? | the page number reference (optional)  (default to 1)

            try
            {
                // Search your Orders
                OrderSearchResponse result = apiInstance.GetOrdersSearch(customerNumber, isocountrycode, ordernumber, customerordernumber, orderstatus, startcreatetimestamp, endcreatetimestamp, pagesize, pagenumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV5Api.GetOrdersSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrdersSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search your Orders
    ApiResponse<OrderSearchResponse> response = apiInstance.GetOrdersSearchWithHttpInfo(customerNumber, isocountrycode, ordernumber, customerordernumber, orderstatus, startcreatetimestamp, endcreatetimestamp, pagesize, pagenumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV5Api.GetOrdersSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerNumber** | **string** | Your unique Ingram Micro customer number |  |
| **isocountrycode** | **string** | 2 char iso country code |  |
| **ordernumber** | **string?** | Ingram sales order number | [optional]  |
| **customerordernumber** | **string?** | Search using your PO/Order number | [optional]  |
| **orderstatus** | **string?** | Ingram Micro order status | [optional] [default to any] |
| **startcreatetimestamp** | **DateTime?** | Search start date/time in UTC format | [optional]  |
| **endcreatetimestamp** | **DateTime?** | Search end date/time in UTC format | [optional]  |
| **pagesize** | **int?** | Number of records required in the call | [optional]  |
| **pagenumber** | **int?** | the page number reference | [optional] [default to 1] |

### Return type

[**OrderSearchResponse**](OrderSearchResponse.md)

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

<a id="getv5ordersdetails"></a>
# **GetV5OrdersDetails**
> OrderDetailResponse GetV5OrdersDetails (string ordernumber, string customernumber, string isocountrycode, string? customerordernumber = null, DateTime? startcreatetimestamp = null, string? endcreatetimestamp = null, string? simulate = null)

Get Order Details

Use your Ingram Micro sales order number to search for existing orders or retrieve existing order details.   <b>The sales order number, customer number and isoCountryCode are required parameters.</b>   The sales order number is returned in the Order Create POST response. Ingram Micro recommends that you save this number for future uses.   The IM sales order number can also be retrieved by searching for your existing order using the Order Search GET endpoint. You will need the customer PO number or order number that was provided at the time of order creation.   In a case when the IM sales order number is repeated, you can refine the result by providing customer order number for additional filtering or using the date range to filter orders by creation date.   Use the \"simulate\" query parameter to test the GET order response for various order statuses. This parameter is only available in the sandbox to help with development and testing of the GET order endpoint.

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
    public class GetV5OrdersDetailsExample
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
            var apiInstance = new OrdersV5Api(httpClient, config, httpClientHandler);
            var ordernumber = 20-RD128;  // string | Ingram Micro sales order number
            var customernumber = "\"20-222222\"";  // string | Your unique Ingram Micro customer number (default to "20-222222")
            var isocountrycode = "\"US\"";  // string | 2 chars ISO country code (default to "US")
            var customerordernumber = "customerordernumber_example";  // string? | Your PO/Order Number provide at the time of order creation (optional) 
            var startcreatetimestamp = Sun Mar 15 00:00:00 UTC 2020;  // DateTime? | Filter start date - format YYYY-MM-DD (optional) 
            var endcreatetimestamp = 2020-04-20;  // string? | Filter end date - format YYYY-MM-DD (optional) 
            var simulate = ;  // string? | Order response for various order statuses. Not for use in production. (optional) 

            try
            {
                // Get Order Details
                OrderDetailResponse result = apiInstance.GetV5OrdersDetails(ordernumber, customernumber, isocountrycode, customerordernumber, startcreatetimestamp, endcreatetimestamp, simulate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV5Api.GetV5OrdersDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetV5OrdersDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Order Details
    ApiResponse<OrderDetailResponse> response = apiInstance.GetV5OrdersDetailsWithHttpInfo(ordernumber, customernumber, isocountrycode, customerordernumber, startcreatetimestamp, endcreatetimestamp, simulate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV5Api.GetV5OrdersDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ordernumber** | **string** | Ingram Micro sales order number |  |
| **customernumber** | **string** | Your unique Ingram Micro customer number | [default to &quot;20-222222&quot;] |
| **isocountrycode** | **string** | 2 chars ISO country code | [default to &quot;US&quot;] |
| **customerordernumber** | **string?** | Your PO/Order Number provide at the time of order creation | [optional]  |
| **startcreatetimestamp** | **DateTime?** | Filter start date - format YYYY-MM-DD | [optional]  |
| **endcreatetimestamp** | **string?** | Filter end date - format YYYY-MM-DD | [optional]  |
| **simulate** | **string?** | Order response for various order statuses. Not for use in production. | [optional]  |

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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="postv5orderscreate"></a>
# **PostV5OrdersCreate**
> OrderCreateResponse PostV5OrdersCreate (OrderCreateRequest? orderCreateRequest = null)

Create a New Order

Instantly create and place orders. The POST API supports stocked SKUs as well as licensing and warranties SKUs.   Every order to be created with this API must complete these validations to be placed and processed:<ul><li>SKU, shipping address, product authorization and stock allocations must clear validation.</li><li>Ingram Micro Sales validates pricing, stock or other processing parameters. Ingram Micro sales may place an order a hold if revision is necessary.</li><li>Credit validation confirms available credit prior to processing an order. If an order does not clear credit validation, the Ingram Micro sales rep or accounts receivable manager will contact you for next steps.</li><li>Warehouse validation selects the location closest to the destination zip code. If the stock is not available in any of the warehouses, Ingram Micro places a backorder in the warehouse closest to the destination zip code.</li></ul>   Ingram Micro recommends that you provide the <strong>ingrampartnumber</strong> for each SKU contained in each order.   When using <strong>vendorpartnumber</strong> to place an order, please use the product search endpoint to find the <strong>ingrampartnumber</strong> for a specific <strong>vendorpartnumber</strong>, and then supply the <strong>ingrampartnumber</strong> to place an order.   <strong>NOTE:</strong> You must have net terms to use the <strong>Ingram Micro Order Create API</strong>. Ingram Micro offers trade credit when using our APIs, and repayment is based on net terms. For example, if your net terms agreement is net-30, you will have 30 days to make a full payment. Ingram Micro does not allow credit card transactions for API ordering.

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
    public class PostV5OrdersCreateExample
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
            var apiInstance = new OrdersV5Api(httpClient, config, httpClientHandler);
            var orderCreateRequest = new OrderCreateRequest?(); // OrderCreateRequest? |  (optional) 

            try
            {
                // Create a New Order
                OrderCreateResponse result = apiInstance.PostV5OrdersCreate(orderCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersV5Api.PostV5OrdersCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostV5OrdersCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a New Order
    ApiResponse<OrderCreateResponse> response = apiInstance.PostV5OrdersCreateWithHttpInfo(orderCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrdersV5Api.PostV5OrdersCreateWithHttpInfo: " + e.Message);
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

