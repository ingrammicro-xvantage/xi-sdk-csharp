# xi.sdk.resellers.Model.OrderModifyResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IngramOrderNumber** | **string** | The IngramMicro order number. | [optional] 
**ChangeDescription** | **string** | The description of the change. | [optional] 
**OrderModifiedDate** | **string** | The date the order was modified. | [optional] 
**CustomerOrderNumber** | **string** | The reseller&#39;s order number for reference in their system. | [optional] 
**EndCustomerOrderNumber** | **string** | The end user/customer&#39;s order number for reference in their system. | [optional] 
**OrderTotal** | **decimal** | The total for the order. | [optional] 
**Notes** | **string** | Order-level notes. | [optional] 
**OrderSubTotal** | **decimal** | The sub total for the order. | [optional] 
**FreightCharges** | **decimal** | The freight charges for the order. | [optional] 
**TotalTax** | **decimal** | The total tax for the order. | [optional] 
**OrderStatus** | **string** | The status of the order. One of the following. Backordered, In Progress, Shipped, Delivered, Canceled, On Hold | [optional] 
**BillToAddressId** | **string** | Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit. | [optional] 
**ShipToInfo** | [**OrderModifyResponseShipToInfo**](OrderModifyResponseShipToInfo.md) |  | [optional] 
**Lines** | [**List&lt;OrderModifyResponseLinesInner&gt;**](OrderModifyResponseLinesInner.md) | The line-level details for the order. | [optional] 
**RejectedLineItems** | [**List&lt;OrderModifyResponseRejectedLineItemsInner&gt;**](OrderModifyResponseRejectedLineItemsInner.md) | Details for failed lines in the order. | [optional] 
**AdditionalAttributes** | [**List&lt;OrderModifyResponseLinesInnerAdditionalAttributesInner&gt;**](OrderModifyResponseLinesInnerAdditionalAttributesInner.md) | Header-level additional attributes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

