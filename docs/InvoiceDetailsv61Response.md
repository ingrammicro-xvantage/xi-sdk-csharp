# xi-sdk-resellers-csharp.Model.InvoiceDetailsv61Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceNumber** | **string** | The Invoice number for the order. | [optional] 
**InvoiceStatus** | **string** | Status of the invoice. | [optional] 
**InvoiceDate** | **DateTime** | Date of an Invoice. | [optional] 
**CustomerOrderNumber** | **string** | The reseller&#39;s order number for reference in their system. | [optional] 
**EndCustomerOrderNumber** | **string** | The end customer&#39;s order number for reference in their system. | [optional] 
**OrderDate** | **DateTime** | The date and time in UTC format that the order was created. | [optional] 
**BillToID** | **string** | Bill to party | [optional] 
**InvoiceType** | **string** | Type of the Invoice | [optional] 
**InvoiceDueDate** | **string** | Date when the invoice is due. | [optional] 
**CustomerCountryCode** | **string** | Customer country code. | [optional] 
**CustomerNumber** | **string** | Unique customer number in Ingram&#39;s system. | [optional] 
**IngramOrderNumber** | **string** | The IngramMicro sales order number. | [optional] 
**Notes** | **string** | Notes for the invoice. | [optional] 
**PaymentTermsInfo** | [**InvoiceDetailsv61ResponsePaymentTermsInfo**](InvoiceDetailsv61ResponsePaymentTermsInfo.md) |  | [optional] 
**BillToInfo** | [**InvoiceDetailsv61ResponseBillToInfo**](InvoiceDetailsv61ResponseBillToInfo.md) |  | [optional] 
**ShipToInfo** | [**InvoiceDetailsv61ResponseShipToInfo**](InvoiceDetailsv61ResponseShipToInfo.md) |  | [optional] 
**Lines** | [**List&lt;InvoiceDetailsv61ResponseLinesInner&gt;**](InvoiceDetailsv61ResponseLinesInner.md) |  | [optional] 
**FxRateInfo** | [**InvoiceDetailsv61ResponseFxRateInfo**](InvoiceDetailsv61ResponseFxRateInfo.md) |  | [optional] 
**Summary** | [**InvoiceDetailsv61ResponseSummary**](InvoiceDetailsv61ResponseSummary.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

