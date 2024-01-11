# xi-sdk-resellers-csharp.Model.OrderDetailResponseServiceresponseOrderdetailresponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ordernumber** | **string** |  | [optional] 
**Ordertype** | **string** | Order Type   B - BRANCH TRANSFER C - CASH ORDER D - DIRECT ORDER F - FUTURE ORDER P - SPECIAL ORDER Q - QUOTE ORDER S - STOCK ORDER M - MEMO ORDER | [optional] 
**Customerordernumber** | **string** | Customer PO number | [optional] 
**Enduserponumber** | **string** | End User PO number | [optional] 
**Orderstatus** | **string** | Status of order within Ingram system S - SALES HOLD H - TAG HOLD I - INVOICED P - PENDING E - BILLING ERROR F - FORCE BILLING V - VOIDED T - TRANSFERRED D - HOLD SHIPMENT R - RELEASED O - IM ONLINE HOLD U - BILL FOR HISTORY ONLY W - ORDER NOT PRINTED A - DROP SHIP HOLD B - INTERNET CUST ORIG HOLD 1 - PICKED 2 - INSPECTED 3 - PACKED 4 - SHIPPED C - CREDIT HOLD 9 - CISCO 3A6 Q - RMA HOLD G - CREDIT HOLD N - CREDIT HOLD | [optional] 
**Entrytimestamp** | **string** | Time stamp of the order placed | [optional] 
**Entrymethoddescription** | **string** | Description of the entry method  | [optional] 
**Ordertotalvalue** | **decimal** | Total order value | [optional] 
**Ordersubtotal** | **decimal** | Subtotal order value | [optional] 
**Freightamount** | **string** | Freight charges | [optional] 
**Currencycode** | **string** | Country specific currency code | [optional] 
**Totalweight** | **string** | Total order weight. unit - - North america - Pounds , other countries will be KG | [optional] 
**Totaltax** | **string** | total tax on the orders placed | [optional] 
**Billtoaddress** | [**OrderDetailResponseServiceresponseOrderdetailresponseBilltoaddress**](OrderDetailResponseServiceresponseOrderdetailresponseBilltoaddress.md) |  | [optional] 
**Shiptoaddress** | [**OrderDetailResponseServiceresponseOrderdetailresponseShiptoaddress**](OrderDetailResponseServiceresponseOrderdetailresponseShiptoaddress.md) |  | [optional] 
**Enduserinfo** | [**OrderDetailResponseServiceresponseOrderdetailresponseEnduserinfo**](OrderDetailResponseServiceresponseOrderdetailresponseEnduserinfo.md) |  | [optional] 
**Lines** | [**List&lt;OrderDetailResponseServiceresponseOrderdetailresponseLinesInner&gt;**](OrderDetailResponseServiceresponseOrderdetailresponseLinesInner.md) |  | [optional] 
**Commentlines** | [**List&lt;OrderDetailResponseServiceresponseOrderdetailresponseCommentlinesInner&gt;**](OrderDetailResponseServiceresponseOrderdetailresponseCommentlinesInner.md) |  | [optional] 
**Miscfeeline** | [**List&lt;OrderDetailResponseServiceresponseOrderdetailresponseMiscfeelineInner&gt;**](OrderDetailResponseServiceresponseOrderdetailresponseMiscfeelineInner.md) |  | [optional] 
**Extendedspecs** | [**List&lt;OrderDetailResponseServiceresponseOrderdetailresponseExtendedspecsInner&gt;**](OrderDetailResponseServiceresponseOrderdetailresponseExtendedspecsInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

