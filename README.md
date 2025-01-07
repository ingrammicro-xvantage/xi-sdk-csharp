# xi.sdk.resellers - the C# library for the XI Sdk Resellers

For resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.



## Frameworks supported


## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

## Installation
From NuGet:
```sh
dotnet add package xi.sdk.resellers
```
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using xi.sdk.resellers.Api;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;
```

## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out xi.sdk.resellers.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each ApiClass (properly the ApiClient inside it) will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manager the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory.

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll loose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


## Getting Started

Quickstart on creating an application can be found [here](getting-started.md)

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using xi.sdk.resellers.Api;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AccesstokenApi(httpClient, config, httpClientHandler);
            var grantType = client_credentials;  // string | Keep grant_type as client_credentials only.
            var clientId = "clientId_example";  // string | 
            var clientSecret = "clientSecret_example";  // string | 

            try
            {
                // Accesstoken
                AccesstokenResponse result = apiInstance.GetAccesstoken(grantType, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccesstokenApi.GetAccesstoken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```


## Documentation for API Endpoints

All URIs are relative to *https://api.ingrammicro.com:443*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccesstokenApi* | [**GetAccesstoken**](docs/AccesstokenApi.md#getaccesstoken) | **GET** /oauth/oauth20/token | Accesstoken
*DealsApi* | [**GetResellersV6Dealsdetails**](docs/DealsApi.md#getresellersv6dealsdetails) | **GET** /resellers/v6/deals/{dealId} | Deals Details
*DealsApi* | [**GetResellersV6Dealssearch**](docs/DealsApi.md#getresellersv6dealssearch) | **GET** /resellers/v6/deals/search | Deals Search
*FreightEstimateApi* | [**PostFreightestimate**](docs/FreightEstimateApi.md#postfreightestimate) | **POST** /resellers/v6/freightestimate | Freight Estimate
*InvoicesApi* | [**GetInvoicedetailsV61**](docs/InvoicesApi.md#getinvoicedetailsv61) | **GET** /resellers/v6.1/invoices/{invoiceNumber} | Get Invoice Details v6.1
*InvoicesApi* | [**GetResellersV6Invoicesearch**](docs/InvoicesApi.md#getresellersv6invoicesearch) | **GET** /resellers/v6/invoices | Search your invoice
*OrderStatusApi* | [**ResellersV1WebhooksOrderstatuseventPost**](docs/OrderStatusApi.md#resellersv1webhooksorderstatuseventpost) | **POST** /resellers/v1/webhooks/orderstatusevent | Order Status
*OrdersApi* | [**DeleteOrdercancel**](docs/OrdersApi.md#deleteordercancel) | **DELETE** /resellers/v6/orders/{OrderNumber} | Cancel your Order
*OrdersApi* | [**GetOrderdetailsV61**](docs/OrdersApi.md#getorderdetailsv61) | **GET** /resellers/v6.1/orders/{ordernumber} | Get Order Details v6.1
*OrdersApi* | [**GetResellersV6Ordersearch**](docs/OrdersApi.md#getresellersv6ordersearch) | **GET** /resellers/v6/orders/search | Search your Orders
*OrdersApi* | [**PostCreateorderV6**](docs/OrdersApi.md#postcreateorderv6) | **POST** /resellers/v6/orders | Create your Order
*OrdersApi* | [**PostCreateorderV7**](docs/OrdersApi.md#postcreateorderv7) | **POST** /resellers/v7/orders | Create your Order v7
*OrdersApi* | [**PutOrdermodify**](docs/OrdersApi.md#putordermodify) | **PUT** /resellers/v6/orders/{orderNumber} | Modify your Order
*ProductCatalogApi* | [**GetResellerV6Productdetail**](docs/ProductCatalogApi.md#getresellerv6productdetail) | **GET** /resellers/v6/catalog/details/{ingramPartNumber} | Product Details
*ProductCatalogApi* | [**GetResellerV6Productdetailcmp**](docs/ProductCatalogApi.md#getresellerv6productdetailcmp) | **GET** /resellers/v6/catalog/details | Product Details
*ProductCatalogApi* | [**GetResellerV6Productsearch**](docs/ProductCatalogApi.md#getresellerv6productsearch) | **GET** /resellers/v6/catalog | Search Products
*ProductCatalogApi* | [**PostPriceandavailability**](docs/ProductCatalogApi.md#postpriceandavailability) | **POST** /resellers/v6/catalog/priceandavailability | Price and Availability
*QuotesApi* | [**GetQuotessearchV6**](docs/QuotesApi.md#getquotessearchv6) | **GET** /resellers/v6/quotes/search | Quote Search
*QuotesApi* | [**GetResellerV6ValidateQuote**](docs/QuotesApi.md#getresellerv6validatequote) | **GET** /resellers/v6/q2o/validatequote | Validate Quote
*QuotesApi* | [**GetResellersV6Quotes**](docs/QuotesApi.md#getresellersv6quotes) | **GET** /resellers/v6/quotes/{quoteNumber} | Get Quote Details
*RenewalsApi* | [**GetResellersV6Renewalsdetails**](docs/RenewalsApi.md#getresellersv6renewalsdetails) | **GET** /resellers/v6/renewals/{renewalId} | Renewals Details
*RenewalsApi* | [**PostRenewalssearch**](docs/RenewalsApi.md#postrenewalssearch) | **POST** /resellers/v6/renewals/search | Renewals Search
*ReturnsApi* | [**GetResellersV6Returnsdetails**](docs/ReturnsApi.md#getresellersv6returnsdetails) | **GET** /resellers/v6/returns/{caseRequestNumber} | Returns Details
*ReturnsApi* | [**GetResellersV6Returnssearch**](docs/ReturnsApi.md#getresellersv6returnssearch) | **GET** /resellers/v6/returns/search | Returns Search
*ReturnsApi* | [**PostReturnscreate**](docs/ReturnsApi.md#postreturnscreate) | **POST** /resellers/v6/returns/create | Returns Create
*StockUpdateApi* | [**ResellersV1WebhooksAvailabilityupdatePost**](docs/StockUpdateApi.md#resellersv1webhooksavailabilityupdatepost) | **POST** /resellers/v1/webhooks/availabilityupdate | Stock Update



## Documentation for Models

 - [Model.AccesstokenResponse](docs/AccesstokenResponse.md)
 - [Model.AvailabilityAsyncNotificationRequest](docs/AvailabilityAsyncNotificationRequest.md)
 - [Model.AvailabilityAsyncNotificationRequestResourceInner](docs/AvailabilityAsyncNotificationRequestResourceInner.md)
 - [Model.AvailabilityAsyncNotificationRequestResourceInnerLinksInner](docs/AvailabilityAsyncNotificationRequestResourceInnerLinksInner.md)
 - [Model.DealsDetailsResponse](docs/DealsDetailsResponse.md)
 - [Model.DealsDetailsResponseProductsInner](docs/DealsDetailsResponseProductsInner.md)
 - [Model.DealsSearchResponse](docs/DealsSearchResponse.md)
 - [Model.DealsSearchResponseDealsInner](docs/DealsSearchResponseDealsInner.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.ErrorResponseDTO](docs/ErrorResponseDTO.md)
 - [Model.ErrorResponseErrorsInner](docs/ErrorResponseErrorsInner.md)
 - [Model.ErrorResponseErrorsInnerFieldsInner](docs/ErrorResponseErrorsInnerFieldsInner.md)
 - [Model.Fields](docs/Fields.md)
 - [Model.FreightRequest](docs/FreightRequest.md)
 - [Model.FreightRequestLinesInner](docs/FreightRequestLinesInner.md)
 - [Model.FreightRequestShipToAddressInner](docs/FreightRequestShipToAddressInner.md)
 - [Model.FreightResponse](docs/FreightResponse.md)
 - [Model.FreightResponseFreightEstimateResponse](docs/FreightResponseFreightEstimateResponse.md)
 - [Model.FreightResponseFreightEstimateResponseDistributionInner](docs/FreightResponseFreightEstimateResponseDistributionInner.md)
 - [Model.FreightResponseFreightEstimateResponseDistributionInnerCarrierListInner](docs/FreightResponseFreightEstimateResponseDistributionInnerCarrierListInner.md)
 - [Model.FreightResponseFreightEstimateResponseLinesInner](docs/FreightResponseFreightEstimateResponseLinesInner.md)
 - [Model.GetAccesstoken400Response](docs/GetAccesstoken400Response.md)
 - [Model.GetAccesstoken500Response](docs/GetAccesstoken500Response.md)
 - [Model.GetAccesstoken500ResponseFault](docs/GetAccesstoken500ResponseFault.md)
 - [Model.GetAccesstoken500ResponseFaultDetail](docs/GetAccesstoken500ResponseFaultDetail.md)
 - [Model.GetResellerV6ValidateQuote400Response](docs/GetResellerV6ValidateQuote400Response.md)
 - [Model.GetResellerV6ValidateQuote400ResponseFieldsInner](docs/GetResellerV6ValidateQuote400ResponseFieldsInner.md)
 - [Model.InvoiceDetailsv61Response](docs/InvoiceDetailsv61Response.md)
 - [Model.InvoiceDetailsv61ResponseBillToInfo](docs/InvoiceDetailsv61ResponseBillToInfo.md)
 - [Model.InvoiceDetailsv61ResponseFxRateInfo](docs/InvoiceDetailsv61ResponseFxRateInfo.md)
 - [Model.InvoiceDetailsv61ResponseLinesInner](docs/InvoiceDetailsv61ResponseLinesInner.md)
 - [Model.InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner](docs/InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner.md)
 - [Model.InvoiceDetailsv61ResponsePaymentTermsInfo](docs/InvoiceDetailsv61ResponsePaymentTermsInfo.md)
 - [Model.InvoiceDetailsv61ResponseShipToInfo](docs/InvoiceDetailsv61ResponseShipToInfo.md)
 - [Model.InvoiceDetailsv61ResponseSummary](docs/InvoiceDetailsv61ResponseSummary.md)
 - [Model.InvoiceDetailsv61ResponseSummaryForeignFxTotals](docs/InvoiceDetailsv61ResponseSummaryForeignFxTotals.md)
 - [Model.InvoiceDetailsv61ResponseSummaryLines](docs/InvoiceDetailsv61ResponseSummaryLines.md)
 - [Model.InvoiceDetailsv61ResponseSummaryMiscChargesInner](docs/InvoiceDetailsv61ResponseSummaryMiscChargesInner.md)
 - [Model.InvoiceDetailsv61ResponseSummaryTotals](docs/InvoiceDetailsv61ResponseSummaryTotals.md)
 - [Model.InvoiceSearchResponse](docs/InvoiceSearchResponse.md)
 - [Model.InvoiceSearchResponseInvoicesInner](docs/InvoiceSearchResponseInvoicesInner.md)
 - [Model.OrderCreateRequest](docs/OrderCreateRequest.md)
 - [Model.OrderCreateRequestAdditionalAttributesInner](docs/OrderCreateRequestAdditionalAttributesInner.md)
 - [Model.OrderCreateRequestEndUserInfo](docs/OrderCreateRequestEndUserInfo.md)
 - [Model.OrderCreateRequestLinesInner](docs/OrderCreateRequestLinesInner.md)
 - [Model.OrderCreateRequestLinesInnerAdditionalAttributesInner](docs/OrderCreateRequestLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderCreateRequestLinesInnerEndUserInfoInner](docs/OrderCreateRequestLinesInnerEndUserInfoInner.md)
 - [Model.OrderCreateRequestLinesInnerWarrantyInfoInner](docs/OrderCreateRequestLinesInnerWarrantyInfoInner.md)
 - [Model.OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner](docs/OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner.md)
 - [Model.OrderCreateRequestResellerInfo](docs/OrderCreateRequestResellerInfo.md)
 - [Model.OrderCreateRequestShipToInfo](docs/OrderCreateRequestShipToInfo.md)
 - [Model.OrderCreateRequestShipmentDetails](docs/OrderCreateRequestShipmentDetails.md)
 - [Model.OrderCreateRequestVmf](docs/OrderCreateRequestVmf.md)
 - [Model.OrderCreateResponse](docs/OrderCreateResponse.md)
 - [Model.OrderCreateResponseEndUserInfo](docs/OrderCreateResponseEndUserInfo.md)
 - [Model.OrderCreateResponseOrdersInner](docs/OrderCreateResponseOrdersInner.md)
 - [Model.OrderCreateResponseOrdersInnerAdditionalAttributesInner](docs/OrderCreateResponseOrdersInnerAdditionalAttributesInner.md)
 - [Model.OrderCreateResponseOrdersInnerLinesInner](docs/OrderCreateResponseOrdersInnerLinesInner.md)
 - [Model.OrderCreateResponseOrdersInnerLinesInnerAdditionalAttributesInner](docs/OrderCreateResponseOrdersInnerLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner](docs/OrderCreateResponseOrdersInnerLinesInnerShipmentDetailsInner.md)
 - [Model.OrderCreateResponseOrdersInnerLinksInner](docs/OrderCreateResponseOrdersInnerLinksInner.md)
 - [Model.OrderCreateResponseOrdersInnerMiscellaneousChargesInner](docs/OrderCreateResponseOrdersInnerMiscellaneousChargesInner.md)
 - [Model.OrderCreateResponseOrdersInnerRejectedLineItemsInner](docs/OrderCreateResponseOrdersInnerRejectedLineItemsInner.md)
 - [Model.OrderCreateResponseShipToInfo](docs/OrderCreateResponseShipToInfo.md)
 - [Model.OrderCreateV7Request](docs/OrderCreateV7Request.md)
 - [Model.OrderCreateV7RequestAdditionalAttributesInner](docs/OrderCreateV7RequestAdditionalAttributesInner.md)
 - [Model.OrderCreateV7RequestEndUserInfo](docs/OrderCreateV7RequestEndUserInfo.md)
 - [Model.OrderCreateV7RequestLinesInner](docs/OrderCreateV7RequestLinesInner.md)
 - [Model.OrderCreateV7RequestLinesInnerAdditionalAttributesInner](docs/OrderCreateV7RequestLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderCreateV7RequestLinesInnerEndUserInfoInner](docs/OrderCreateV7RequestLinesInnerEndUserInfoInner.md)
 - [Model.OrderCreateV7RequestLinesInnerVmfAdditionalAttributesLinesInner](docs/OrderCreateV7RequestLinesInnerVmfAdditionalAttributesLinesInner.md)
 - [Model.OrderCreateV7RequestResellerInfo](docs/OrderCreateV7RequestResellerInfo.md)
 - [Model.OrderCreateV7RequestShipToInfo](docs/OrderCreateV7RequestShipToInfo.md)
 - [Model.OrderCreateV7RequestShipmentDetails](docs/OrderCreateV7RequestShipmentDetails.md)
 - [Model.OrderCreateV7RequestVmfAdditionalAttributesInner](docs/OrderCreateV7RequestVmfAdditionalAttributesInner.md)
 - [Model.OrderCreateV7Response](docs/OrderCreateV7Response.md)
 - [Model.OrderCreateV7Response201](docs/OrderCreateV7Response201.md)
 - [Model.OrderCreateV7ResponseResource](docs/OrderCreateV7ResponseResource.md)
 - [Model.OrderCreateV7ResponseResourceOrdersInner](docs/OrderCreateV7ResponseResourceOrdersInner.md)
 - [Model.OrderCreateV7ResponseResourceOrdersInnerLinesInner](docs/OrderCreateV7ResponseResourceOrdersInnerLinesInner.md)
 - [Model.OrderCreateV7ResponseResourceOrdersInnerLinesInnerShipmentDetailsInner](docs/OrderCreateV7ResponseResourceOrdersInnerLinesInnerShipmentDetailsInner.md)
 - [Model.OrderCreateV7ResponseResourceShipToInfo](docs/OrderCreateV7ResponseResourceShipToInfo.md)
 - [Model.OrderDetailB2B](docs/OrderDetailB2B.md)
 - [Model.OrderDetailB2BAdditionalAttributesInner](docs/OrderDetailB2BAdditionalAttributesInner.md)
 - [Model.OrderDetailB2BBillToInfo](docs/OrderDetailB2BBillToInfo.md)
 - [Model.OrderDetailB2BEndUserInfo](docs/OrderDetailB2BEndUserInfo.md)
 - [Model.OrderDetailB2BLinesInner](docs/OrderDetailB2BLinesInner.md)
 - [Model.OrderDetailB2BLinesInnerAdditionalAttributesInner](docs/OrderDetailB2BLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInner](docs/OrderDetailB2BLinesInnerEstimatedDatesInner.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInnerDelivery](docs/OrderDetailB2BLinesInnerEstimatedDatesInnerDelivery.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInnerDeliveryDeliveryDateRange](docs/OrderDetailB2BLinesInnerEstimatedDatesInnerDeliveryDeliveryDateRange.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInnerShip](docs/OrderDetailB2BLinesInnerEstimatedDatesInnerShip.md)
 - [Model.OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange](docs/OrderDetailB2BLinesInnerEstimatedDatesInnerShipShipDateRange.md)
 - [Model.OrderDetailB2BLinesInnerLinksInner](docs/OrderDetailB2BLinesInnerLinksInner.md)
 - [Model.OrderDetailB2BLinesInnerMultipleShipmentsInner](docs/OrderDetailB2BLinesInnerMultipleShipmentsInner.md)
 - [Model.OrderDetailB2BLinesInnerScheduleLinesInner](docs/OrderDetailB2BLinesInnerScheduleLinesInner.md)
 - [Model.OrderDetailB2BLinesInnerServiceContractInfo](docs/OrderDetailB2BLinesInnerServiceContractInfo.md)
 - [Model.OrderDetailB2BLinesInnerServiceContractInfoContractInfo](docs/OrderDetailB2BLinesInnerServiceContractInfoContractInfo.md)
 - [Model.OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo](docs/OrderDetailB2BLinesInnerServiceContractInfoLicenseInfo.md)
 - [Model.OrderDetailB2BLinesInnerServiceContractInfoSubscriptions](docs/OrderDetailB2BLinesInnerServiceContractInfoSubscriptions.md)
 - [Model.OrderDetailB2BLinesInnerShipmentDetailsInner](docs/OrderDetailB2BLinesInnerShipmentDetailsInner.md)
 - [Model.OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInner](docs/OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInner.md)
 - [Model.OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInner](docs/OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInner.md)
 - [Model.OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner](docs/OrderDetailB2BLinesInnerShipmentDetailsInnerCarrierDetailsInnerTrackingDetailsInnerSerialNumbersInner.md)
 - [Model.OrderDetailB2BMiscellaneousChargesInner](docs/OrderDetailB2BMiscellaneousChargesInner.md)
 - [Model.OrderDetailB2BShipToInfo](docs/OrderDetailB2BShipToInfo.md)
 - [Model.OrderModifyRequest](docs/OrderModifyRequest.md)
 - [Model.OrderModifyRequestAdditionalAttributesInner](docs/OrderModifyRequestAdditionalAttributesInner.md)
 - [Model.OrderModifyRequestLinesInner](docs/OrderModifyRequestLinesInner.md)
 - [Model.OrderModifyRequestShipToInfo](docs/OrderModifyRequestShipToInfo.md)
 - [Model.OrderModifyResponse](docs/OrderModifyResponse.md)
 - [Model.OrderModifyResponseLinesInner](docs/OrderModifyResponseLinesInner.md)
 - [Model.OrderModifyResponseLinesInnerAdditionalAttributesInner](docs/OrderModifyResponseLinesInnerAdditionalAttributesInner.md)
 - [Model.OrderModifyResponseLinesInnerShipmentDetails](docs/OrderModifyResponseLinesInnerShipmentDetails.md)
 - [Model.OrderModifyResponseRejectedLineItemsInner](docs/OrderModifyResponseRejectedLineItemsInner.md)
 - [Model.OrderModifyResponseShipToInfo](docs/OrderModifyResponseShipToInfo.md)
 - [Model.OrderSearchResponse](docs/OrderSearchResponse.md)
 - [Model.OrderSearchResponseOrdersInner](docs/OrderSearchResponseOrdersInner.md)
 - [Model.OrderSearchResponseOrdersInnerLinks](docs/OrderSearchResponseOrdersInnerLinks.md)
 - [Model.OrderSearchResponseOrdersInnerSubOrdersInner](docs/OrderSearchResponseOrdersInnerSubOrdersInner.md)
 - [Model.OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner](docs/OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner.md)
 - [Model.OrderStatusAsyncNotificationRequest](docs/OrderStatusAsyncNotificationRequest.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInner](docs/OrderStatusAsyncNotificationRequestResourceInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInner](docs/OrderStatusAsyncNotificationRequestResourceInnerLinesInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInnerSerialNumberDetailsInner](docs/OrderStatusAsyncNotificationRequestResourceInnerLinesInnerSerialNumberDetailsInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner](docs/OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInnerPackageDetailsInner](docs/OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInnerPackageDetailsInner.md)
 - [Model.OrderStatusAsyncNotificationRequestResourceInnerLinksInner](docs/OrderStatusAsyncNotificationRequestResourceInnerLinksInner.md)
 - [Model.PostCreateorderV7400Response](docs/PostCreateorderV7400Response.md)
 - [Model.PostCreateorderV7400ResponseFieldsInner](docs/PostCreateorderV7400ResponseFieldsInner.md)
 - [Model.PostCreateorderV7500Response](docs/PostCreateorderV7500Response.md)
 - [Model.PostRenewalssearch400Response](docs/PostRenewalssearch400Response.md)
 - [Model.PriceAndAvailabilityRequest](docs/PriceAndAvailabilityRequest.md)
 - [Model.PriceAndAvailabilityRequestAdditionalAttributesInner](docs/PriceAndAvailabilityRequestAdditionalAttributesInner.md)
 - [Model.PriceAndAvailabilityRequestAvailabilityByWarehouseInner](docs/PriceAndAvailabilityRequestAvailabilityByWarehouseInner.md)
 - [Model.PriceAndAvailabilityRequestProductsInner](docs/PriceAndAvailabilityRequestProductsInner.md)
 - [Model.PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner](docs/PriceAndAvailabilityRequestProductsInnerAdditionalAttributesInner.md)
 - [Model.PriceAndAvailabilityResponseInner](docs/PriceAndAvailabilityResponseInner.md)
 - [Model.PriceAndAvailabilityResponseInnerAvailability](docs/PriceAndAvailabilityResponseInnerAvailability.md)
 - [Model.PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInner](docs/PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInner.md)
 - [Model.PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInnerBackOrderInfoInner](docs/PriceAndAvailabilityResponseInnerAvailabilityAvailabilityByWarehouseInnerBackOrderInfoInner.md)
 - [Model.PriceAndAvailabilityResponseInnerDiscountsInner](docs/PriceAndAvailabilityResponseInnerDiscountsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner](docs/PriceAndAvailabilityResponseInnerDiscountsInnerQuantityDiscountsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner](docs/PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner.md)
 - [Model.PriceAndAvailabilityResponseInnerPricing](docs/PriceAndAvailabilityResponseInnerPricing.md)
 - [Model.PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner](docs/PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerServiceFeesInner](docs/PriceAndAvailabilityResponseInnerServiceFeesInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerBillingPeriod](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerBillingPeriod.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerGroupsInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerGroupsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInnerSpecialPricingInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInnerSpecialPricingInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInnerVolumeDiscountsInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerDiscountsInnerVolumeDiscountsInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerFeesInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerFeesInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerResourcePricingInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerOptionsInnerResourcePricingInner.md)
 - [Model.PriceAndAvailabilityResponseInnerSubscriptionPriceInnerSubscriptionPeriodInner](docs/PriceAndAvailabilityResponseInnerSubscriptionPriceInnerSubscriptionPeriodInner.md)
 - [Model.ProductDetailResponse](docs/ProductDetailResponse.md)
 - [Model.ProductDetailResponseAdditionalInformation](docs/ProductDetailResponseAdditionalInformation.md)
 - [Model.ProductDetailResponseAdditionalInformationProductWeightInner](docs/ProductDetailResponseAdditionalInformationProductWeightInner.md)
 - [Model.ProductDetailResponseCiscoFields](docs/ProductDetailResponseCiscoFields.md)
 - [Model.ProductDetailResponseIndicators](docs/ProductDetailResponseIndicators.md)
 - [Model.ProductDetailResponseSubscriptionDetailsInner](docs/ProductDetailResponseSubscriptionDetailsInner.md)
 - [Model.ProductDetailResponseSubscriptionDetailsInnerBillingPeriod](docs/ProductDetailResponseSubscriptionDetailsInnerBillingPeriod.md)
 - [Model.ProductDetailResponseSubscriptionDetailsInnerGroupsInner](docs/ProductDetailResponseSubscriptionDetailsInnerGroupsInner.md)
 - [Model.ProductDetailResponseSubscriptionDetailsInnerOptionsInner](docs/ProductDetailResponseSubscriptionDetailsInnerOptionsInner.md)
 - [Model.ProductDetailResponseSubscriptionDetailsInnerSubscriptionPeriodInner](docs/ProductDetailResponseSubscriptionDetailsInnerSubscriptionPeriodInner.md)
 - [Model.ProductSearchResponse](docs/ProductSearchResponse.md)
 - [Model.ProductSearchResponseCatalogInner](docs/ProductSearchResponseCatalogInner.md)
 - [Model.ProductSearchResponseCatalogInnerLinksInner](docs/ProductSearchResponseCatalogInnerLinksInner.md)
 - [Model.ProductSearchResponseSubscriptionCatalogInner](docs/ProductSearchResponseSubscriptionCatalogInner.md)
 - [Model.ProductSearchResponseSubscriptionCatalogInnerPlansInner](docs/ProductSearchResponseSubscriptionCatalogInnerPlansInner.md)
 - [Model.ProductSearchResponseSubscriptionCatalogInnerPlansInnerLinksInner](docs/ProductSearchResponseSubscriptionCatalogInnerPlansInnerLinksInner.md)
 - [Model.ProductSearchResponseSubscriptionCatalogInnerPlansInnerSubscriptionPeriodSummaryInner](docs/ProductSearchResponseSubscriptionCatalogInnerPlansInnerSubscriptionPeriodSummaryInner.md)
 - [Model.QuoteDetailsResponse](docs/QuoteDetailsResponse.md)
 - [Model.QuoteDetailsResponseAdditionalAttributesInner](docs/QuoteDetailsResponseAdditionalAttributesInner.md)
 - [Model.QuoteDetailsResponseEndUserInfo](docs/QuoteDetailsResponseEndUserInfo.md)
 - [Model.QuoteDetailsResponseProductsInner](docs/QuoteDetailsResponseProductsInner.md)
 - [Model.QuoteDetailsResponseProductsInnerBillDetailsInner](docs/QuoteDetailsResponseProductsInnerBillDetailsInner.md)
 - [Model.QuoteDetailsResponseProductsInnerPrice](docs/QuoteDetailsResponseProductsInnerPrice.md)
 - [Model.QuoteDetailsResponseProductsInnerPriceDiscountsInner](docs/QuoteDetailsResponseProductsInnerPriceDiscountsInner.md)
 - [Model.QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner](docs/QuoteDetailsResponseProductsInnerPriceExtraFeesDetailsInner.md)
 - [Model.QuoteDetailsResponseResellerInfo](docs/QuoteDetailsResponseResellerInfo.md)
 - [Model.QuoteDetailsResponseShippingInfo](docs/QuoteDetailsResponseShippingInfo.md)
 - [Model.QuoteSearchResponse](docs/QuoteSearchResponse.md)
 - [Model.QuoteSearchResponseQuotesInner](docs/QuoteSearchResponseQuotesInner.md)
 - [Model.QuoteSearchResponseQuotesInnerLinks](docs/QuoteSearchResponseQuotesInnerLinks.md)
 - [Model.RenewalsDetailsResponse](docs/RenewalsDetailsResponse.md)
 - [Model.RenewalsDetailsResponseAdditionalAttributesInner](docs/RenewalsDetailsResponseAdditionalAttributesInner.md)
 - [Model.RenewalsDetailsResponseEndUserInfo](docs/RenewalsDetailsResponseEndUserInfo.md)
 - [Model.RenewalsDetailsResponseProductsInner](docs/RenewalsDetailsResponseProductsInner.md)
 - [Model.RenewalsDetailsResponseReferenceNumber](docs/RenewalsDetailsResponseReferenceNumber.md)
 - [Model.RenewalsSearchRequest](docs/RenewalsSearchRequest.md)
 - [Model.RenewalsSearchRequestDateType](docs/RenewalsSearchRequestDateType.md)
 - [Model.RenewalsSearchRequestDateTypeEndDate](docs/RenewalsSearchRequestDateTypeEndDate.md)
 - [Model.RenewalsSearchRequestDateTypeExpirationDate](docs/RenewalsSearchRequestDateTypeExpirationDate.md)
 - [Model.RenewalsSearchRequestDateTypeInvoiceDate](docs/RenewalsSearchRequestDateTypeInvoiceDate.md)
 - [Model.RenewalsSearchRequestDateTypeStartDate](docs/RenewalsSearchRequestDateTypeStartDate.md)
 - [Model.RenewalsSearchRequestStatus](docs/RenewalsSearchRequestStatus.md)
 - [Model.RenewalsSearchRequestStatusOpporutinyStatus](docs/RenewalsSearchRequestStatusOpporutinyStatus.md)
 - [Model.RenewalsSearchResponse](docs/RenewalsSearchResponse.md)
 - [Model.RenewalsSearchResponseRenewalsInner](docs/RenewalsSearchResponseRenewalsInner.md)
 - [Model.RenewalsSearchResponseRenewalsInnerLinksInner](docs/RenewalsSearchResponseRenewalsInnerLinksInner.md)
 - [Model.ReturnsCreateRequest](docs/ReturnsCreateRequest.md)
 - [Model.ReturnsCreateRequestListInner](docs/ReturnsCreateRequestListInner.md)
 - [Model.ReturnsCreateRequestListInnerShipFromInfoInner](docs/ReturnsCreateRequestListInnerShipFromInfoInner.md)
 - [Model.ReturnsCreateResponse](docs/ReturnsCreateResponse.md)
 - [Model.ReturnsCreateResponseReturnsClaimsInner](docs/ReturnsCreateResponseReturnsClaimsInner.md)
 - [Model.ReturnsDetailsResponse](docs/ReturnsDetailsResponse.md)
 - [Model.ReturnsDetailsResponseProductsInner](docs/ReturnsDetailsResponseProductsInner.md)
 - [Model.ReturnsSearchResponse](docs/ReturnsSearchResponse.md)
 - [Model.ReturnsSearchResponseReturnsClaimsInner](docs/ReturnsSearchResponseReturnsClaimsInner.md)
 - [Model.ReturnsSearchResponseReturnsClaimsInnerLinksInner](docs/ReturnsSearchResponseReturnsClaimsInnerLinksInner.md)
 - [Model.ValidateQuoteResponse](docs/ValidateQuoteResponse.md)
 - [Model.ValidateQuoteResponseLinesInner](docs/ValidateQuoteResponseLinesInner.md)
 - [Model.ValidateQuoteResponseLinesInnerVmfAdditionalAttributesLinesInner](docs/ValidateQuoteResponseLinesInnerVmfAdditionalAttributesLinesInner.md)
 - [Model.ValidateQuoteResponseVmfAdditionalAttributesInner](docs/ValidateQuoteResponseVmfAdditionalAttributesInner.md)


## Documentation for Authorization


Authentication schemes defined for the API:
### application

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: https://api.ingrammicro.com:443/oauth/oauth20/token?grant_type=client_credentials&client_id={ClientId}&client_secret={clientSecret}
- **Method**: Get
- **Scopes**: 
  - write: allows modifying resources
  - read: allows reading resources
 

## Author
-[Ingram Micro Xvantage](https://github.com/ingrammicro-xvantage)

## Contact

For any inquiries or support, please feel free to contact us at:

- Email: xi_support@ingrammicro.com