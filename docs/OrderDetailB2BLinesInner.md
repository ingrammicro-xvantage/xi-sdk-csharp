# xi-sdk-csharp.Model.OrderDetailB2BLinesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubOrderNumber** | **string** | The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest the reseller. The middle number is the order number. The two-digit suffix is the sub order number. | [optional] 
**IngramOrderLineNumber** | **string** | Unique Ingram Micro line number. Starts with 001. | [optional] 
**VendorSalesOrderLineNumber** | **string** | The vendor&#39;s sales order line number. | [optional] 
**CustomerLineNumber** | **string** | The reseller&#39;s line item number for reference in their system. | [optional] 
**LineStatus** | **string** | The status for the line item in the order. One of- Backordered, In Progress, Shipped, Delivered, Canceled, On Hold. | [optional] 
**IngramPartNumber** | **string** | Unique IngramMicro part number. | [optional] 
**VendorPartNumber** | **string** | The vendor&#39;s part number for the line item. | [optional] 
**VendorName** | **string** | The vendor&#39;s name for the part in their system. | [optional] 
**PartDescription** | **string** | The vendor&#39;s description of the part in their system. | [optional] 
**UnitWeight** | **double** | The unit weight of the line item. | [optional] 
**WeightUom** | **string** | The unit of measure for the line item. | [optional] 
**UnitPrice** | **double** | The unit price of the line item. | [optional] 
**UpcCode** | **string** | The UPC code of a product. | [optional] 
**ExtendedPrice** | **double** | Unit price X quantity for the line item. | [optional] 
**TaxAmount** | **double** | The tax amount for the line item. | [optional] 
**CurrencyCode** | **string** | The country-specific three character ISO 4217 currency code for the line item. | [optional] 
**QuantityOrdered** | **int** | The quantity ordered of the line item. | [optional] 
**QuantityConfirmed** | **int** | The quantity confirmed for the line item. | [optional] 
**QuantityBackOrdered** | **int** | The quantity backordered for the line item. | [optional] 
**SpecialBidNumber** | **string** | The line-level bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number in the case of split orders or where different line items have different bid numbers. Line-level bid numbers take precedence over header-level bid numbers. | [optional] 
**RequestedDeliverydate** | **string** | Reseller-requested delivery date. Delivery date is not guaranteed. | [optional] 
**PromisedDeliveryDate** | **string** | The delivery date promised by IngramMicro. | [optional] 
**LineNotes** | **string** | Line-level notes for the order. | [optional] 
**ShipmentDetails** | [**List&lt;OrderDetailB2BLinesInnerShipmentDetailsInner&gt;**](OrderDetailB2BLinesInnerShipmentDetailsInner.md) | Shipping details for the line item. | [optional] 
**ServiceContractInfo** | [**OrderDetailB2BLinesInnerServiceContractInfo**](OrderDetailB2BLinesInnerServiceContractInfo.md) |  | [optional] 
**AdditionalAttributes** | [**List&lt;OrderDetailB2BLinesInnerAdditionalAttributesInner&gt;**](OrderDetailB2BLinesInnerAdditionalAttributesInner.md) |  | [optional] 
**Links** | [**List&lt;OrderDetailB2BLinesInnerLinksInner&gt;**](OrderDetailB2BLinesInnerLinksInner.md) |  | [optional] 
**EstimatedDates** | [**List&lt;OrderDetailB2BLinesInnerEstimatedDatesInner&gt;**](OrderDetailB2BLinesInnerEstimatedDatesInner.md) |  | [optional] 
**ScheduleLines** | [**List&lt;OrderDetailB2BLinesInnerScheduleLinesInner&gt;**](OrderDetailB2BLinesInnerScheduleLinesInner.md) |  | [optional] 
**MultipleShipments** | [**List&lt;OrderDetailB2BLinesInnerMultipleShipmentsInner&gt;**](OrderDetailB2BLinesInnerMultipleShipmentsInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

