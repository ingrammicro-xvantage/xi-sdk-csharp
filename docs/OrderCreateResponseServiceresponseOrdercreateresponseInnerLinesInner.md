# xi-sdk-resellers-csharp.Model.OrderCreateResponseServiceresponseOrdercreateresponseInnerLinesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Linetype** | **string** | “P”-Line or SKU Number “C”-Comment Line | [optional] 
**Globallinenumber** | **string** | Ingram generated line number | [optional] 
**Partnumber** | **string** | Ingram Micro Sku Number | [optional] 
**Globalskuid** | **string** |  | [optional] 
**Linenumber** | **string** |  | [optional] 
**Carriercode** | **string** | Transportation 2 digit codes | [optional] 
**Carrierdescription** | **string** | Transportation Carrier Name | [optional] 
**Requestedunitprice** | **decimal** | Price requested by reseller. Price Variance can be set up by Ingram Micro Sales Rep | [optional] 
**Requestedquantity** | **int** | Quanity Requested | [optional] 
**Confirmedquantity** | **int** | Quanity Shipped | [optional] 
**Backorderedquantity** | **int** | Quanity of units that didn’t ship | [optional] 
**Unitproductprice** | **decimal** | Price Per Unit | [optional] 
**Netamount** | **decimal** | Total amount. Quantity X Unit Price | [optional] 
**Warehouseid** | **string** |  | [optional] 
**Ordersuffix** | **string** | Use order suffix with the globalorderid for this line item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

