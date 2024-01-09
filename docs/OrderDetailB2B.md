# xi-sdk-csharp.Model.OrderDetailB2B

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IngramOrderNumber** | **string** | The IngramMicro sales order number. | [optional] 
**IngramOrderDate** | **DateTime** | The IngramMicro sales order date. | [optional] 
**OrderType** | **string** | The IngramMicro sales order type. | [optional] 
**CustomerOrderNumber** | **string** | The reseller&#39;s order number for reference in their system. | [optional] 
**EndCustomerOrderNumber** | **string** | The end customer&#39;s order number for reference in their system. | [optional] 
**WebOrderId** | **string** | The web order id of the order. | [optional] 
**VendorSalesOrderNumber** | **string** | The vendor&#39;s order number for reference in their system | [optional] 
**IngramPurchaseOrderNumber** | **string** | Ingram purchase order number. | [optional] 
**OrderStatus** | **string** | The header-level status of the order. One of- Shipped, Canceled, Backordered, Processing, On Hold, Delivered. | [optional] 
**OrderTotal** | **double** | The total cost for the order, includes subtotal, freight charges, and tax. | [optional] 
**OrderSubTotal** | **double** | The sub total cost for the order, not including tax and freight. | [optional] 
**FreightCharges** | **double** | The freight charges for the order. | [optional] 
**CurrencyCode** | **string** | The country-specific three digit ISO 4217 currency code for the order. | [optional] 
**TotalWeight** | **double** | Total order weight. unit - - North america - Pounds , other countries will be KG. | [optional] 
**TotalTax** | **double** | Total tax on the orders placed. | [optional] 
**PaymentTerms** | **string** | The payment terms of the order. (Ex- Net 30 days). | [optional] 
**Notes** | **string** | The header-level notes for the order. | [optional] 
**BillToInfo** | [**OrderDetailB2BBillToInfo**](OrderDetailB2BBillToInfo.md) |  | [optional] 
**ShipToInfo** | [**OrderDetailB2BShipToInfo**](OrderDetailB2BShipToInfo.md) |  | [optional] 
**EndUserInfo** | [**OrderDetailB2BEndUserInfo**](OrderDetailB2BEndUserInfo.md) |  | [optional] 
**Lines** | [**List&lt;OrderDetailB2BLinesInner&gt;**](OrderDetailB2BLinesInner.md) |  | [optional] 
**MiscellaneousCharges** | [**List&lt;OrderDetailB2BMiscellaneousChargesInner&gt;**](OrderDetailB2BMiscellaneousChargesInner.md) |  | [optional] 
**AdditionalAttributes** | [**List&lt;OrderDetailB2BAdditionalAttributesInner&gt;**](OrderDetailB2BAdditionalAttributesInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

