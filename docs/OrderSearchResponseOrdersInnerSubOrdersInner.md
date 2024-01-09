# xi-sdk-csharp.Model.OrderSearchResponseOrdersInnerSubOrdersInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubOrderNumber** | **string** | The sub order number. The two-digit prefix is the warehouse code of the warehouse nearest to the reseller. The middle number is the order number. The two-digit suffix is the sub order number. | [optional] 
**SubOrderTotal** | **decimal** | The total for the suborder. | [optional] 
**SubOrderStatus** | **string** | The status of the suborder. One of:- Shipped, Canceled, Backordered, Processing, On Hold, Delivered | [optional] 
**Links** | [**List&lt;OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner&gt;**](OrderSearchResponseOrdersInnerSubOrdersInnerLinksInner.md) | Link to Order Details for the sub order(s). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

