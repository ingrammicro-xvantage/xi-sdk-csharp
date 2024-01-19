# xi.sdk.resellers.Model.OrderSearchResponseOrdersInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IngramOrderNumber** | **string** | The Ingram Micro order number. | [optional] 
**IngramOrderDate** | **string** | The date the order was created(UTC). | [optional] 
**CustomerOrderNumber** | **string** | The reseller&#39;s order number for reference in their system. | [optional] 
**VendorSalesOrderNumber** | **string** | The vendor&#39;s order number.(only for D-Type Orders) | [optional] 
**VendorName** | **string** | The name of the vendor. | [optional] 
**EndUserCompanyName** | **string** | The company name of the end user/customer. | [optional] 
**OrderTotal** | **decimal** | The total of the order. | [optional] 
**OrderStatus** | **string** | The header-level status of the order.(OPEN/CLOSED/CANCELLED) | [optional] 
**SubOrders** | [**List&lt;OrderSearchResponseOrdersInnerSubOrdersInner&gt;**](OrderSearchResponseOrdersInnerSubOrdersInner.md) | Individual Ingram Micro order numbers associated with a single reseller PO. | [optional] 
**Links** | [**OrderSearchResponseOrdersInnerLinks**](OrderSearchResponseOrdersInnerLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

