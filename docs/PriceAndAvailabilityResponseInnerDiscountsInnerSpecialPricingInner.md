# xi-sdk-csharp.Model.PriceAndAvailabilityResponseInnerDiscountsInnerSpecialPricingInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscountType** | **string** | The type of discount being given to the customer. | [optional] 
**SpecialBidNumer** | **string** | Pre-approved special pricing/bid number provided to the reseller by the vendor for special pricing and discounts. Used to track the bid number where different line items have different bid numbers. Line-level bid numbers take precedence over header-level bid numbers. | [optional] 
**SpecialPricingDiscount** | **decimal** | Special pricing discount amount given to the customer. | [optional] 
**SpecialPricingEffectiveDate** | **DateTime** | The effective date of the special pricing available to the customer. | [optional] 
**SpecialPricingExpirationDate** | **DateTime** | The expiration date of the special pricing available to the customer. | [optional] 
**SpecialPricingAvailableQuantity** | **int** | The available quantity of products with discounts. | [optional] 
**SpecialPricingMinQuantity** | **int** | The minimum quantity of products that have to be purchased to ensure the discount is applied. | [optional] 
**GovernmentDiscountType** | **string** | Type of Government Discount. *Currently, this discount is only available in the USA. | [optional] 
**GovernmentDiscountedCustomerPrice** | **decimal** | Government Discounted Customer Price. *Currently, this discount is only available in the USA. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

