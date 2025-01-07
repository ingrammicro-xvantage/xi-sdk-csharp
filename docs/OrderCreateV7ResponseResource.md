# xi.sdk.resellers.Model.OrderCreateV7ResponseResource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerOrderNumber** | **string** | The reseller&#39;s unique PO/Order number. | [optional] 
**BillToAddressId** | **string** | Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit | [optional] 
**OrderSplit** | **bool** | true for multiple orders | [optional] 
**ProcessedPartially** | **bool** | true for partial order succesfully placed | [optional] 
**PurchaseOrderTotal** | **decimal** | Total of all the orders including taxes and fees. | [optional] 
**ShipToInfo** | [**OrderCreateV7ResponseResourceShipToInfo**](OrderCreateV7ResponseResourceShipToInfo.md) |  | [optional] 
**Orders** | [**List&lt;OrderCreateV7ResponseResourceOrdersInner&gt;**](OrderCreateV7ResponseResourceOrdersInner.md) | Order-level details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

