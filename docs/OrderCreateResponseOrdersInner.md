# xi.sdk.resellers.Model.OrderCreateResponseOrdersInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumberOfLinesWithSuccess** | **int** | The number of lines in the order that were successful. | [optional] 
**NumberOfLinesWithError** | **int** | The number of lines in the order that have errors. | [optional] 
**NumberOfLinesWithWarning** | **int** | The number of lines in the order that have a warning. | [optional] 
**IngramOrderNumber** | **string** | The Ingram Micro order number. | [optional] 
**IngramOrderDate** | **string** | The date in UTC format that the order was created in Ingram Micro&#39;s system. | [optional] 
**Notes** | **string** | Order-level notes. | [optional] 
**OrderType** | **string** | The order typer. One of: S&#x3D;Stocked PO D&#x3D;Direct Ship PO | [optional] 
**OrderTotal** | **decimal** | The total price for the order. | [optional] 
**FreightCharges** | **decimal** | The total freight charges for the order. | [optional] 
**TotalTax** | **decimal** | The total tax for the order. | [optional] 
**CurrencyCode** | **string** | The country-specific three character ISO 4217 currency code used for the order. | [optional] 
**Lines** | [**List&lt;OrderCreateResponseOrdersInnerLinesInner&gt;**](OrderCreateResponseOrdersInnerLinesInner.md) | The line-level details for the order. | [optional] 
**MiscellaneousCharges** | [**List&lt;OrderCreateResponseOrdersInnerMiscellaneousChargesInner&gt;**](OrderCreateResponseOrdersInnerMiscellaneousChargesInner.md) |  | [optional] 
**Links** | [**List&lt;OrderCreateResponseOrdersInnerLinksInner&gt;**](OrderCreateResponseOrdersInnerLinksInner.md) | Link to Order Details for the order(s). | [optional] 
**RejectedLineItems** | [**List&lt;OrderCreateResponseOrdersInnerRejectedLineItemsInner&gt;**](OrderCreateResponseOrdersInnerRejectedLineItemsInner.md) | A list of rejected line items. | [optional] 
**AdditionalAttributes** | [**List&lt;OrderCreateResponseOrdersInnerAdditionalAttributesInner&gt;**](OrderCreateResponseOrdersInnerAdditionalAttributesInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

