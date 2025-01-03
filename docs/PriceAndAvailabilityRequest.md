# xi.sdk.resellers.Model.PriceAndAvailabilityRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShowAvailableDiscounts** | **bool?** | Boolean value that will display Discount details in the response when true. | [optional] 
**ShowReserveInventoryDetails** | **bool?** | Boolean value that will display reserve inventory details in the response when true. | [optional] 
**SpecialBidNumber** | **string** | Pre-approved special pricing/bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number where different line items have different bid numbers. | [optional] 
**AvailabilityByWarehouse** | [**List&lt;PriceAndAvailabilityRequestAvailabilityByWarehouseInner&gt;**](PriceAndAvailabilityRequestAvailabilityByWarehouseInner.md) |  | [optional] 
**Products** | [**List&lt;PriceAndAvailabilityRequestProductsInner&gt;**](PriceAndAvailabilityRequestProductsInner.md) |  | [optional] 
**AdditionalAttributes** | [**List&lt;PriceAndAvailabilityRequestAdditionalAttributesInner&gt;**](PriceAndAvailabilityRequestAdditionalAttributesInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

