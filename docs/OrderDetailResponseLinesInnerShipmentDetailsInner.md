# xi-sdk-resellers-csharp.Model.OrderDetailResponseLinesInnerShipmentDetailsInner
Shipping details for the line item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **int** | The quantity shipped of the line item. | [optional] 
**EstimatedShipDate** | **DateTime** | The estimated ship date for the line item. | [optional] 
**ShippedDate** | **DateTime** | The date the line item was shipped. | [optional] 
**EstimatedDeliveryDate** | **DateTime** | The date the line item is expected to be delivered. | [optional] 
**DeliveredDate** | **DateTime** | The actual date of delivery of the line item. | [optional] 
**ShipFromWarehouseId** | **string** | The ID of the warehouse the product will ship from. | [optional] 
**ShipFromLocation** | **string** | The city and state the line item ships from. | [optional] 
**InvoiceNumber** | **string** | The Ingram Micro invoice number for the line item. | [optional] 
**InvoiceDate** | **DateTime** | The date the IngramMicro invoice was created for the line item. | [optional] 
**CarrierDetails** | [**OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetails**](OrderDetailResponseLinesInnerShipmentDetailsInnerCarrierDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

