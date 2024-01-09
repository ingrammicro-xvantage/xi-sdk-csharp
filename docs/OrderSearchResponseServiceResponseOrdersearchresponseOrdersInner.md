# xi-sdk-csharp.Model.OrderSearchResponseServiceResponseOrdersearchresponseOrdersInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ordernumber** | **string** | Ingram micro sales order number | 
**Entrytimestamp** | **string** | The order creation date-time in UTC format | 
**Customerordernumber** | **string** | PO/Order number submitted while creating the order | [optional] 
**Suborders** | [**List&lt;OrderSearchResponseServiceResponseOrdersearchresponseOrdersInnerSubordersInner&gt;**](OrderSearchResponseServiceResponseOrdersearchresponseOrdersInnerSubordersInner.md) | An order MAY get divided into various sub orders, for example if the SKUs are being shipped from different warehouse. | [optional] 
**Links** | [**OrderSearchResponseServiceResponseOrdersearchresponseOrdersInnerLinks**](OrderSearchResponseServiceResponseOrdersearchresponseOrdersInnerLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

