# xi-sdk-csharp.Model.OrderSearchResponseServiceResponseOrdersearchresponseOrdersInnerSubordersInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subordernumber** | **string** | A sub order number | [optional] 
**Statuscode** | **string** | Order status code | [optional] 
**Status** | **string** | Details of the order statuscode - i.e. statuscode &#x3D; 4 then status &#x3D; SHIPPED | [optional] 
**Holdreasoncode** | **string** | Will be returned in case of order on hold | [optional] 
**Holdreason** | **string** | Reason for order hold - will be returned if the order is on hold | [optional] 
**Links** | [**List&lt;OrderSearchResponseServiceResponseOrdersearchresponseOrdersInnerSubordersInnerLinksInner&gt;**](OrderSearchResponseServiceResponseOrdersearchresponseOrdersInnerSubordersInnerLinksInner.md) | HATEOAS links for the details and invoices of the sub-orders if available | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

