# xi.sdk.resellers.Model.OrderCreateV7ResponseResourceOrdersInner

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
**Lines** | [**List&lt;OrderCreateV7ResponseResourceOrdersInnerLinesInner&gt;**](OrderCreateV7ResponseResourceOrdersInnerLinesInner.md) | The line-level details for the order. | [optional] 
**Links** | [**List&lt;OrderCreateResponseOrdersInnerLinksInner&gt;**](OrderCreateResponseOrdersInnerLinksInner.md) | Link to Order Details for the order(s). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

