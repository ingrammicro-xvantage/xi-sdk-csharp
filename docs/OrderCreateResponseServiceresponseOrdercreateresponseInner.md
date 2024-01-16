# xi.sdk.resellers.csharp.Model.OrderCreateResponseServiceresponseOrdercreateresponseInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Numberoflineswithsuccess** | **string** | Number of line items that were successful | [optional] 
**Numberoflineswitherror** | **string** | Number of line items with error | [optional] 
**Numberoflineswithwarning** | **string** | Number of line items with warnings | [optional] 
**Globalorderid** | **string** | Ingram sales order number | [optional] 
**Ordertype** | **string** | S&#x3D;Stocked PO D&#x3D;Direct Ship PO | [optional] 
**Ordertimestamp** | **string** | Time order received | [optional] 
**Invoicingsystemorderid** | **string** | Ingram Micro generated order number | [optional] 
**Taxamount** | **decimal** |  | [optional] 
**Freightamount** | **decimal** | Freight amount customer pays for freight | [optional] 
**Orderamount** | **decimal** | Total amount of order with freight and taxes | [optional] 
**Lines** | [**List&lt;OrderCreateResponseServiceresponseOrdercreateresponseInnerLinesInner&gt;**](OrderCreateResponseServiceresponseOrdercreateresponseInnerLinesInner.md) | Collection of lines | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

