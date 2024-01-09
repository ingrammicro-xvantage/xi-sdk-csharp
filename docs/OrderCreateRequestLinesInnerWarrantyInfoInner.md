# xi-sdk-csharp.Model.OrderCreateRequestLinesInnerWarrantyInfoInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DirectLineLink** | **string** | Unique value to link hardware and warranty lines. Should be used only when products are purchased from both Ingram and/or vendor but the warranty is purchased through Ingram for them. | [optional] 
**WarrantyLineLink** | **string** | Customer line number of the hardware product in this request for linkage, either hardwareLineLink or warrantyLineLink can be used in a line. | [optional] 
**HardwareLineLink** | **string** | Customer line number of the warranty product in this request for linkage, either hardwareLineLink or warrantyLineLink can be used in a line  | [optional] 
**SerialInfo** | [**List&lt;OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner&gt;**](OrderCreateRequestLinesInnerWarrantyInfoInnerSerialInfoInner.md) | Serial information of the hardware to be associated with the warranty, applicable on post sale orders. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

