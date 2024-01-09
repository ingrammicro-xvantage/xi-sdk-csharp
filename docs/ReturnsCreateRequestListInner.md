# xi-sdk-csharp.Model.ReturnsCreateRequestListInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvoiceNumber** | **string** | The Invoice number of the order. | 
**InvoiceDate** | **DateTime** | Date of an Invoice. | 
**CustomerOrderNumber** | **string** | The reseller&#39;s order number for reference in their system. | [optional] 
**IngramPartNumber** | **string** | Unique line number from Ingram. | [optional] 
**VendorPartNumber** | **string** | Vendor Part Number. | [optional] 
**SerialNumber** | **string** | Serial number of the product. | [optional] 
**Quantity** | **int** | Return quantity of the product. | 
**PrimaryReason** | **string** | Primary reason to return the product. | 
**SecondaryReason** | **string** | Secondary reason to return the product. | 
**Notes** | **string** | Return notes. | [optional] 
**ReferenceNumber** | **string** | Reference number to return the product. | [optional] 
**BillToAddressId** | **string** | Suffix used to identify billing address. | [optional] 
**ShipFromInfo** | [**List&lt;ReturnsCreateRequestListInnerShipFromInfoInner&gt;**](ReturnsCreateRequestListInnerShipFromInfoInner.md) |  | 
**NumberOfBoxes** | **int** | Number of boxes to return. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

