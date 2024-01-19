# xi.sdk.resellers.Model.OrderStatusAsyncNotificationRequestResourceInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The event name sent in the event request. | [optional] 
**OrderNumber** | **string** | The Ingram Micro order number. | [optional] 
**CustomerOrderNumber** | **string** | The reseller&#39;s unique PO/Order number. | [optional] 
**OrderEntryTimeStamp** | **string** | The timestamp at which the order was created. | [optional] 
**Lines** | [**List&lt;OrderStatusAsyncNotificationRequestResourceInnerLinesInner&gt;**](OrderStatusAsyncNotificationRequestResourceInnerLinesInner.md) | The line-level details for the order. | [optional] 
**Links** | [**List&lt;OrderStatusAsyncNotificationRequestResourceInnerLinksInner&gt;**](OrderStatusAsyncNotificationRequestResourceInnerLinksInner.md) | Link to Order Details for the order(s). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

