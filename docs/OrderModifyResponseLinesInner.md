# xi.sdk.resellers.csharp.Model.OrderModifyResponseLinesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubOrderNumber** | **string** | The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number. | [optional] 
**IngramLineNumber** | **string** | The IngramMicro line number. | [optional] 
**CustomerLineNumber** | **string** | The reseller&#39;s line number for reference in their system. | [optional] 
**IngramPartNumber** | **string** | The unique IngramMicro part number for the line item. | [optional] 
**VendorPartNumber** | **string** | The vendor&#39;s part number for the line item. | [optional] 
**QuantityOrdered** | **int** | The quantity ordered of the line item. | [optional] 
**QuantityConfirmed** | **int** | The quantity confirmed of the line item. | [optional] 
**QuantityBackOrdered** | **int** | The quantity backordered of the line item. | [optional] 
**ShipmentDetails** | [**OrderModifyResponseLinesInnerShipmentDetails**](OrderModifyResponseLinesInnerShipmentDetails.md) |  | [optional] 
**AdditionalAttributes** | [**List&lt;OrderModifyResponseLinesInnerAdditionalAttributesInner&gt;**](OrderModifyResponseLinesInnerAdditionalAttributesInner.md) | SAP requested and country-specific line level details. | [optional] 
**Notes** | **string** | Line-level notes for the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

