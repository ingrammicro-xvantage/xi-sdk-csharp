# xi.sdk.resellers.Api.InvoicesApi

All URIs are relative to *https://api.ingrammicro.com:443*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInvoicedetailsV61**](InvoicesApi.md#getinvoicedetailsv61) | **GET** /resellers/v6.1/invoices/{invoiceNumber} | Get Invoice Details v6.1 |
| [**GetResellersV6Invoicesearch**](InvoicesApi.md#getresellersv6invoicesearch) | **GET** /resellers/v6/invoices | Search your invoice |

<a id="getinvoicedetailsv61"></a>
# **GetInvoicedetailsV61**
> InvoiceDetailsv61Response GetInvoicedetailsV61 (string invoiceNumber, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string iMApplicationID, string? customerType = null, bool? includeSerialNumbers = null)

Get Invoice Details v6.1

Use your Ingram Micro invoice number to search for existing invoices or retrieve existing invoice details.  The invoice number, IM-CustomerNumber, IM-CountryCode, IM-ApplicationId and IM-CorrelationID are required parameters.  .

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
    public class GetInvoicedetailsV61Example
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
            var apiInstance = new InvoicesApi(httpClient, config, httpClientHandler);
            var invoiceNumber = 335238411;  // string | The Ingram Micro invoice number.
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var iMApplicationID = MyCompany;  // string | Unique value used to identify the sender of the transaction. Example: MyCompany.
            var customerType = invoice;  // string? | it should be invoice or order (optional) 
            var includeSerialNumbers = false;  // bool? | if serial in the response send as true or else false (optional) 

            try
            {
                // Get Invoice Details v6.1
                InvoiceDetailsv61Response result = apiInstance.GetInvoicedetailsV61(invoiceNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMApplicationID, customerType, includeSerialNumbers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetInvoicedetailsV61: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoicedetailsV61WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Invoice Details v6.1
    ApiResponse<InvoiceDetailsv61Response> response = apiInstance.GetInvoicedetailsV61WithHttpInfo(invoiceNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMApplicationID, customerType, includeSerialNumbers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.GetInvoicedetailsV61WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **invoiceNumber** | **string** | The Ingram Micro invoice number. |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **iMApplicationID** | **string** | Unique value used to identify the sender of the transaction. Example: MyCompany. |  |
| **customerType** | **string?** | it should be invoice or order | [optional]  |
| **includeSerialNumbers** | **bool?** | if serial in the response send as true or else false | [optional]  |

### Return type

[**InvoiceDetailsv61Response**](InvoiceDetailsv61Response.md)

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

<a id="getresellersv6invoicesearch"></a>
# **GetResellersV6Invoicesearch**
> InvoiceSearchResponse GetResellersV6Invoicesearch (string iMApplicationID, string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? paymentTermsNetDate = null, string? invoiceDate = null, string? invoiceDueDate = null, string? orderDate = null, string? orderFromDate = null, string? orderToDate = null, string? orderNumber = null, string? deliveryNumber = null, string? invoiceNumber = null, string? invoiceStatus = null, string? invoiceType = null, string? customerOrderNumber = null, string? endCustomerOrderNumber = null, string? specialBidNumber = null, string? invoiceFromDueDate = null, string? invoiceToDueDate = null, List<string>? invoiceFromDate = null, List<string>? invoiceToDate = null, int? pageSize = null, int? pageNumber = null, string? orderby = null, string? direction = null, string? serialNumber = null)

Search your invoice

Search your Ingram Micro invoices. This endpoint searches by multiple invoice parameters and supports pagination of results.

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
    public class GetResellersV6InvoicesearchExample
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
            var apiInstance = new InvoicesApi(httpClient, config, httpClientHandler);
            var iMApplicationID = MyCompany;  // string | Unique value used to identify the sender of the transaction. Example: MyCompany
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var paymentTermsNetDate = 2021-04-23;  // string? | Search by payment terms net date(yyyy-MM-dd). (optional) 
            var invoiceDate = 2021-04-23;  // string? | Search by invoice date(yyyy-MM-dd). (optional) 
            var invoiceDueDate = 2021-04-23;  // string? | Search by invoice date from(yyyy-MM-dd). (optional) 
            var orderDate = 2021-04-23;  // string? | Search by OrderDate date(yyyy-MM-dd). (optional) 
            var orderFromDate = 2021-04-23;  // string? | Search by OrderFromDate date(yyyy-MM-dd). (optional) 
            var orderToDate = 2021-04-23;  // string? | Search by OrderToDate date(yyyy-MM-dd). (optional) 
            var orderNumber = 2021-04-23;  // string? | Search by order number (optional) 
            var deliveryNumber = 335238411;  // string? | Search by delivery number. (optional) 
            var invoiceNumber = "invoiceNumber_example";  // string? | The Ingram Micro invoice number. (optional) 
            var invoiceStatus = "invoiceStatus_example";  // string? | Ingram Micro invoice status. (optional) 
            var invoiceType = "invoiceType_example";  // string? | Ingram Micro InvoiceType. (optional) 
            var customerOrderNumber = "customerOrderNumber_example";  // string? | Ingram Micro CustomerOrderNumber. (optional) 
            var endCustomerOrderNumber = "endCustomerOrderNumber_example";  // string? | Ingram Micro EndCustomerOrderNumber. (optional) 
            var specialBidNumber = "specialBidNumber_example";  // string? | Ingram Micro SpecialBidNumber. (optional) 
            var invoiceFromDueDate = 2021-04-23;  // string? | Search by invoice due date from(yyyy-MM-dd). (optional) 
            var invoiceToDueDate = 2021-04-23;  // string? | Search by invoice due date to(yyyy-MM-dd). (optional) 
            var invoiceFromDate = new List<string>?(); // List<string>? | Search by invoice date from(yyyy-MM-dd). (optional) 
            var invoiceToDate = new List<string>?(); // List<string>? | Search by invoice date To(yyyy-MM-dd). (optional) 
            var pageSize = 56;  // int? | Number of records required in the call - max records 100 per page. (optional) 
            var pageNumber = 56;  // int? | The page number reference. (optional) 
            var orderby = InvoiceDate;  // string? | Column name with which we want to sort. (optional) 
            var direction = desc;  // string? | asc or desc , along with orderby column result set will be sorted. (optional) 
            var serialNumber = "serialNumber_example";  // string? | Serial number of the product. (optional) 

            try
            {
                // Search your invoice
                InvoiceSearchResponse result = apiInstance.GetResellersV6Invoicesearch(iMApplicationID, iMCustomerNumber, iMCountryCode, iMCorrelationID, paymentTermsNetDate, invoiceDate, invoiceDueDate, orderDate, orderFromDate, orderToDate, orderNumber, deliveryNumber, invoiceNumber, invoiceStatus, invoiceType, customerOrderNumber, endCustomerOrderNumber, specialBidNumber, invoiceFromDueDate, invoiceToDueDate, invoiceFromDate, invoiceToDate, pageSize, pageNumber, orderby, direction, serialNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvoicesApi.GetResellersV6Invoicesearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellersV6InvoicesearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search your invoice
    ApiResponse<InvoiceSearchResponse> response = apiInstance.GetResellersV6InvoicesearchWithHttpInfo(iMApplicationID, iMCustomerNumber, iMCountryCode, iMCorrelationID, paymentTermsNetDate, invoiceDate, invoiceDueDate, orderDate, orderFromDate, orderToDate, orderNumber, deliveryNumber, invoiceNumber, invoiceStatus, invoiceType, customerOrderNumber, endCustomerOrderNumber, specialBidNumber, invoiceFromDueDate, invoiceToDueDate, invoiceFromDate, invoiceToDate, pageSize, pageNumber, orderby, direction, serialNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvoicesApi.GetResellersV6InvoicesearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **iMApplicationID** | **string** | Unique value used to identify the sender of the transaction. Example: MyCompany |  |
| **iMCustomerNumber** | **string** | Your unique Ingram Micro customer number. |  |
| **iMCountryCode** | **string** | Two-character ISO country code. |  |
| **iMCorrelationID** | **string** | Unique transaction number to identify each transaction across all the systems. |  |
| **paymentTermsNetDate** | **string?** | Search by payment terms net date(yyyy-MM-dd). | [optional]  |
| **invoiceDate** | **string?** | Search by invoice date(yyyy-MM-dd). | [optional]  |
| **invoiceDueDate** | **string?** | Search by invoice date from(yyyy-MM-dd). | [optional]  |
| **orderDate** | **string?** | Search by OrderDate date(yyyy-MM-dd). | [optional]  |
| **orderFromDate** | **string?** | Search by OrderFromDate date(yyyy-MM-dd). | [optional]  |
| **orderToDate** | **string?** | Search by OrderToDate date(yyyy-MM-dd). | [optional]  |
| **orderNumber** | **string?** | Search by order number | [optional]  |
| **deliveryNumber** | **string?** | Search by delivery number. | [optional]  |
| **invoiceNumber** | **string?** | The Ingram Micro invoice number. | [optional]  |
| **invoiceStatus** | **string?** | Ingram Micro invoice status. | [optional]  |
| **invoiceType** | **string?** | Ingram Micro InvoiceType. | [optional]  |
| **customerOrderNumber** | **string?** | Ingram Micro CustomerOrderNumber. | [optional]  |
| **endCustomerOrderNumber** | **string?** | Ingram Micro EndCustomerOrderNumber. | [optional]  |
| **specialBidNumber** | **string?** | Ingram Micro SpecialBidNumber. | [optional]  |
| **invoiceFromDueDate** | **string?** | Search by invoice due date from(yyyy-MM-dd). | [optional]  |
| **invoiceToDueDate** | **string?** | Search by invoice due date to(yyyy-MM-dd). | [optional]  |
| **invoiceFromDate** | [**List&lt;string&gt;?**](string.md) | Search by invoice date from(yyyy-MM-dd). | [optional]  |
| **invoiceToDate** | [**List&lt;string&gt;?**](string.md) | Search by invoice date To(yyyy-MM-dd). | [optional]  |
| **pageSize** | **int?** | Number of records required in the call - max records 100 per page. | [optional]  |
| **pageNumber** | **int?** | The page number reference. | [optional]  |
| **orderby** | **string?** | Column name with which we want to sort. | [optional]  |
| **direction** | **string?** | asc or desc , along with orderby column result set will be sorted. | [optional]  |
| **serialNumber** | **string?** | Serial number of the product. | [optional]  |

### Return type

[**InvoiceSearchResponse**](InvoiceSearchResponse.md)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | InvoiceSearchResponse to be returned |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

