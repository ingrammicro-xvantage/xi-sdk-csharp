# xi.sdk.resellers.Model.InvoiceDetailsv61ResponseLinesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IngramLineNumber** | **string** | Unique line number from Ingram. | [optional] 
**CustomerLineNumber** | **string** | Line number passes by customer while creating an order. | [optional] [default to "0"]
**IngramPartNumber** | **string** | Ingram Micro SKU (stock keeping unit). An identification, usually alphanumeric, of a particular product that allows it to be tracked for inventory purposes. | [optional] 
**VendorPartNumber** | **string** | Vendor Part Number. | [optional] 
**CustomerPartNumber** | **string** | Part number from customer&#39;s system. | [optional] 
**VendorName** | **string** | Name of the vendor. | [optional] 
**ProductDescription** | **string** | Description of the product. | [optional] 
**UnitWeight** | **string** | Weight of the product. | [optional] 
**Quantity** | **int** | Quantity of the product. | [optional] 
**UnitPrice** | **double** | Unit price of the product. | [optional] 
**UnitOfMeasure** | **string** | Unit of measure of the product. | [optional] 
**CurrencyCode** | **string** | Currency code. | [optional] 
**ExtendedPrice** | **double** | Extended price of the product. | [optional] 
**TaxPercentage** | **double** | Tax percentage | [optional] 
**TaxRate** | **double** | Tax rate | [optional] 
**TaxAmount** | **double** | Line level tax amount. | [optional] 
**SerialNumbers** | [**List&lt;InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner&gt;**](InvoiceDetailsv61ResponseLinesInnerSerialNumbersInner.md) |  | [optional] 
**QuantityOrdered** | **int** | Quantity ordered by the customer. | [optional] 
**QuantityShipped** | **int** | Quantity shipped to the customer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

