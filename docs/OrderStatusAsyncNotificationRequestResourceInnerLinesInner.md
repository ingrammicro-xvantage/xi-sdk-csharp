# xi.sdk.resellers.Model.OrderStatusAsyncNotificationRequestResourceInnerLinesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LineNumber** | **string** | The Ingram Micro line number for the product | [optional] 
**SubOrderNumber** | **string** | The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number. | [optional] 
**LineStatus** | **string** | The status for the line item in the order. One of: Backordered, Open, Shipped | [optional] 
**IngramPartNumber** | **string** | The Ingram Micro part number for the line item. | [optional] 
**VendorPartNumber** | **string** | The vendor part number for the line item. | [optional] 
**RequestedQuantity** | **string** | The quantity of the line item requested. | [optional] 
**ShippedQuantity** | **string** | The quantity of the line item that has been shipped. | [optional] 
**BackorderedQuantity** | **string** | The quantity of the line item that is backordered. | [optional] 
**ShipmentDetails** | [**List&lt;OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner&gt;**](OrderStatusAsyncNotificationRequestResourceInnerLinesInnerShipmentDetailsInner.md) |  | [optional] 
**SerialNumberDetails** | [**List&lt;OrderStatusAsyncNotificationRequestResourceInnerLinesInnerSerialNumberDetailsInner&gt;**](OrderStatusAsyncNotificationRequestResourceInnerLinesInnerSerialNumberDetailsInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

