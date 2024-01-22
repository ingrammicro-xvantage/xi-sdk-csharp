# xi.sdk.resellers.Api.ReturnsApi

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetResellersV6Returnsdetails**](ReturnsApi.md#getresellersv6returnsdetails) | **GET** /resellers/v6/returns/{caseRequestNumber} | Returns Details |
| [**GetResellersV6Returnssearch**](ReturnsApi.md#getresellersv6returnssearch) | **GET** /resellers/v6/returns/search | Returns Search |
| [**PostReturnscreate**](ReturnsApi.md#postreturnscreate) | **POST** /resellers/v6/returns/create | Returns Create |

<a id="getresellersv6returnsdetails"></a>
# **GetResellersV6Returnsdetails**
> ReturnsDetailsResponse GetResellersV6Returnsdetails (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string caseRequestNumber, string? iMSenderID = null)

Returns Details

The Returns Details API will retrieve all the details related to the specific caseRequestNumber.

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
    public class GetResellersV6ReturnsdetailsExample
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
            var apiInstance = new ReturnsApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var caseRequestNumber = 12345678;  // string | A unique return request number.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 

            try
            {
                // Returns Details
                ReturnsDetailsResponse result = apiInstance.GetResellersV6Returnsdetails(iMCustomerNumber, iMCountryCode, iMCorrelationID, caseRequestNumber, iMSenderID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.GetResellersV6Returnsdetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellersV6ReturnsdetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns Details
    ApiResponse<ReturnsDetailsResponse> response = apiInstance.GetResellersV6ReturnsdetailsWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, caseRequestNumber, iMSenderID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnsApi.GetResellersV6ReturnsdetailsWithHttpInfo: " + e.Message);
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
| **caseRequestNumber** | **string** | A unique return request number. |  |
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |

### Return type

[**ReturnsDetailsResponse**](ReturnsDetailsResponse.md)

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

<a id="getresellersv6returnssearch"></a>
# **GetResellersV6Returnssearch**
> ReturnsSearchResponse GetResellersV6Returnssearch (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? iMSenderID = null, string? caseRequestNumber = null, string? invoiceNumber = null, string? returnClaimId = null, string? referenceNumber = null, string? ingramPartNumber = null, string? vendorPartNumber = null, string? returnStatusIn = null, string? claimStatusIn = null, string? createdOnBt = null, string? modifiedOnBt = null, string? returnReasonIn = null, string? page = null, string? size = null, string? sort = null, string? sortingColumnName = null)

Returns Search

The Returns Search API, by default, will retrieve all the returns that are associated with the customer’s account. The customer will be able to search returns using the query parameters. The Returns Search response will return the following information:  returnClaimId, caseRequestNumber, createdOn, referenceNumber, and returnReason.

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
    public class GetResellersV6ReturnssearchExample
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
            var apiInstance = new ReturnsApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 
            var caseRequestNumber = "caseRequestNumber_example";  // string? | A unique return request number. (optional) 
            var invoiceNumber = "invoiceNumber_example";  // string? | The Invoice number for the order. (optional) 
            var returnClaimId = "returnClaimId_example";  // string? | A unique return claim Id. (optional) 
            var referenceNumber = "referenceNumber_example";  // string? | The reference number for the return. (optional) 
            var ingramPartNumber = "ingramPartNumber_example";  // string? | Unique IngramMicro part number. (optional) 
            var vendorPartNumber = "vendorPartNumber_example";  // string? | The vendor's part number. (optional) 
            var returnStatusIn = "returnStatusIn_example";  // string? | Comma-separated values of pre-defined status. Open, Approved, Partially Approved, Denied, Voided. (optional) 
            var claimStatusIn = "claimStatusIn_example";  // string? | Comma-separated values of pre-defined status. Open, Approved, Partially Approved, Denied, Voided. (optional) 
            var createdOnBt = "createdOnBt_example";  // string? | The date on which the return request was created.  (optional) 
            var modifiedOnBt = "modifiedOnBt_example";  // string? | The date on which the return request was last updated. (optional) 
            var returnReasonIn = "returnReasonIn_example";  // string? | Comma separated Pre-defined value. test, (EW) Express Warehousing, (AR) Account Receivables, (BB) Buy Back, (BE) Stock Balance Exception, (BO) Bill Only, (CE) Credit Dept Use - Credit Exception, (CF) Configuration Fee, (CS ) Customer Service Discretion, (CS1) Customer Service Discretion CS Error, (DE) Defective Exception, (DF) Defective Items, (DI) Direct Credit, (DM) Damaged from Carrier, (DN) Damaged Without Product, (DT) Direct/ Special Order, (DT1) Direct Ship billed, not shipped., (FO) Freight Out, (FX) No-Scan, (IN) Incomplete, (LS) Lost Shipment, (MN) Minimum Order Fee Credit, (OS) Over Shipment, (PR) Pricing Error, (RF) Refusal Credit, (RI) Re-Invoice, (RP) Return For Repair, (RT) Return Not Credited, (RTD) RCN, (SB) Stock Balance, (SD) Sales Discretion, (SH) Incorrect Shipping And Handling, (SS) Short Shipment, (SSK) Short Ship kit, (SW) Sales Writeoff, (TE) Opened Return, (TR) Training Refund, (TX) Tax Credit, (WS) Wrong Sales Sealed, (WW) Wrong Warehouse, (FS) Warehouse Failed Serial# Capture, Latin America Vebdor Credits, Select Source, ITAD - Trade-in Credit, Withholding Tax (optional) 
            var page = "page_example";  // string? | Number of page. (optional) 
            var size = "size_example";  // string? | The submitted pagesize, default is 25 (optional) 
            var sort = "sort_example";  // string? | Refers to the column selected to apply the sorting criteria. (optional) 
            var sortingColumnName = "sortingColumnName_example";  // string? | The column name which will be sorted on. (optional) 

            try
            {
                // Returns Search
                ReturnsSearchResponse result = apiInstance.GetResellersV6Returnssearch(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, caseRequestNumber, invoiceNumber, returnClaimId, referenceNumber, ingramPartNumber, vendorPartNumber, returnStatusIn, claimStatusIn, createdOnBt, modifiedOnBt, returnReasonIn, page, size, sort, sortingColumnName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.GetResellersV6Returnssearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResellersV6ReturnssearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns Search
    ApiResponse<ReturnsSearchResponse> response = apiInstance.GetResellersV6ReturnssearchWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, caseRequestNumber, invoiceNumber, returnClaimId, referenceNumber, ingramPartNumber, vendorPartNumber, returnStatusIn, claimStatusIn, createdOnBt, modifiedOnBt, returnReasonIn, page, size, sort, sortingColumnName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnsApi.GetResellersV6ReturnssearchWithHttpInfo: " + e.Message);
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
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |
| **caseRequestNumber** | **string?** | A unique return request number. | [optional]  |
| **invoiceNumber** | **string?** | The Invoice number for the order. | [optional]  |
| **returnClaimId** | **string?** | A unique return claim Id. | [optional]  |
| **referenceNumber** | **string?** | The reference number for the return. | [optional]  |
| **ingramPartNumber** | **string?** | Unique IngramMicro part number. | [optional]  |
| **vendorPartNumber** | **string?** | The vendor&#39;s part number. | [optional]  |
| **returnStatusIn** | **string?** | Comma-separated values of pre-defined status. Open, Approved, Partially Approved, Denied, Voided. | [optional]  |
| **claimStatusIn** | **string?** | Comma-separated values of pre-defined status. Open, Approved, Partially Approved, Denied, Voided. | [optional]  |
| **createdOnBt** | **string?** | The date on which the return request was created.  | [optional]  |
| **modifiedOnBt** | **string?** | The date on which the return request was last updated. | [optional]  |
| **returnReasonIn** | **string?** | Comma separated Pre-defined value. test, (EW) Express Warehousing, (AR) Account Receivables, (BB) Buy Back, (BE) Stock Balance Exception, (BO) Bill Only, (CE) Credit Dept Use - Credit Exception, (CF) Configuration Fee, (CS ) Customer Service Discretion, (CS1) Customer Service Discretion CS Error, (DE) Defective Exception, (DF) Defective Items, (DI) Direct Credit, (DM) Damaged from Carrier, (DN) Damaged Without Product, (DT) Direct/ Special Order, (DT1) Direct Ship billed, not shipped., (FO) Freight Out, (FX) No-Scan, (IN) Incomplete, (LS) Lost Shipment, (MN) Minimum Order Fee Credit, (OS) Over Shipment, (PR) Pricing Error, (RF) Refusal Credit, (RI) Re-Invoice, (RP) Return For Repair, (RT) Return Not Credited, (RTD) RCN, (SB) Stock Balance, (SD) Sales Discretion, (SH) Incorrect Shipping And Handling, (SS) Short Shipment, (SSK) Short Ship kit, (SW) Sales Writeoff, (TE) Opened Return, (TR) Training Refund, (TX) Tax Credit, (WS) Wrong Sales Sealed, (WW) Wrong Warehouse, (FS) Warehouse Failed Serial# Capture, Latin America Vebdor Credits, Select Source, ITAD - Trade-in Credit, Withholding Tax | [optional]  |
| **page** | **string?** | Number of page. | [optional]  |
| **size** | **string?** | The submitted pagesize, default is 25 | [optional]  |
| **sort** | **string?** | Refers to the column selected to apply the sorting criteria. | [optional]  |
| **sortingColumnName** | **string?** | The column name which will be sorted on. | [optional]  |

### Return type

[**ReturnsSearchResponse**](ReturnsSearchResponse.md)

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

<a id="postreturnscreate"></a>
# **PostReturnscreate**
> ReturnsCreateResponse PostReturnscreate (string iMCustomerNumber, string iMCountryCode, string iMCorrelationID, string? iMSenderID = null, ReturnsCreateRequest? returnsCreateRequest = null)

Returns Create

Return create endpoint will allow customers to create a return request. In order to create a request, the customer must provide either ingramPartNumber or vendorPartNumber along with other required fields listed below. 

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
    public class PostReturnscreateExample
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
            var apiInstance = new ReturnsApi(httpClient, config, httpClientHandler);
            var iMCustomerNumber = 20-222222;  // string | Your unique Ingram Micro customer number.
            var iMCountryCode = US;  // string | Two-character ISO country code.
            var iMCorrelationID = fbac82ba-cf0a-4bcf-fc03-0c5084;  // string | Unique transaction number to identify each transaction across all the systems.
            var iMSenderID = MyCompany;  // string? | Unique value used to identify the sender of the transaction. Example: MyCompany (optional) 
            var returnsCreateRequest = new ReturnsCreateRequest?(); // ReturnsCreateRequest? |  (optional) 

            try
            {
                // Returns Create
                ReturnsCreateResponse result = apiInstance.PostReturnscreate(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, returnsCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnsApi.PostReturnscreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostReturnscreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns Create
    ApiResponse<ReturnsCreateResponse> response = apiInstance.PostReturnscreateWithHttpInfo(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, returnsCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnsApi.PostReturnscreateWithHttpInfo: " + e.Message);
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
| **iMSenderID** | **string?** | Unique value used to identify the sender of the transaction. Example: MyCompany | [optional]  |
| **returnsCreateRequest** | [**ReturnsCreateRequest?**](ReturnsCreateRequest?.md) |  | [optional]  |

### Return type

[**ReturnsCreateResponse**](ReturnsCreateResponse.md)

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

