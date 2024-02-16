# xi.sdk.resellers.Model.OrderDetailResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IngramOrderNumber** | **string** | The IngramMicro sales order number. | [optional] 
**IngramOrderDate** | **string** | The date and time in UTC format that the order was created. | [optional] 
**OrderType** | **string** | The order type. One of B &#x3D; Branch Transfer, C &#x3D; COD, D &#x3D; Direct Ship, F &#x3D; Future Order, P &#x3D; Special Order, M &#x3D; Memo, Q &#x3D; Quote, S &#x3D; Sales Order. | [optional] 
**CustomerOrderNumber** | **string** | The reseller&#39;s order number for reference in their system. | [optional] 
**EndCustomerOrderNumber** | **string** | The end user/customer&#39;s order number for reference in their system. | [optional] 
**VendorSalesOrderNumber** | **string** | The vendor&#39;s order number for reference in their system. | [optional] 
**OrderStatus** | **string** | The header-level status of the order. One of- Shipped, Canceled, Backordered, Processing, On Hold, Delivered. | [optional] 
**OrderTotal** | **decimal** | The total cost for the order, includes subtotal, freight charges, and tax. | [optional] 
**OrderSubTotal** | **decimal** | The sub total cost for the order, not including tax and freight. | [optional] 
**FreightCharges** | **decimal** | The freight charges for the order. | [optional] 
**CurrencyCode** | **string** | The country-specific three digit ISO 4217 currency code for the order. | [optional] 
**TotalWeight** | **decimal** | The total weight of the order. Pounds in North America, KG in all other countries. | [optional] 
**TotalTax** | **decimal** | The total tax for the order. | [optional] 
**PaymentTerms** | **string** | The payment terms of the order. (Ex- Net 30 days). | [optional] 
**Notes** | **string** | The header-level notes for the order. | [optional] 
**BillToInfo** | [**OrderDetailResponseBillToInfo**](OrderDetailResponseBillToInfo.md) |  | [optional] 
**ShipToInfo** | [**OrderDetailResponseShipToInfo**](OrderDetailResponseShipToInfo.md) |  | [optional] 
**EndUserInfo** | [**OrderDetailResponseEndUserInfo**](OrderDetailResponseEndUserInfo.md) |  | [optional] 
**Lines** | [**List&lt;OrderDetailResponseLinesInner&gt;**](OrderDetailResponseLinesInner.md) |  | [optional] 
**MiscellaneousCharges** | [**List&lt;OrderDetailResponseMiscellaneousChargesInner&gt;**](OrderDetailResponseMiscellaneousChargesInner.md) |  | [optional] 
**AdditionalAttributes** | [**List&lt;OrderDetailResponseLinesInnerAdditionalAttributesInner&gt;**](OrderDetailResponseLinesInnerAdditionalAttributesInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

