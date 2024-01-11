# xi-sdk-resellers-csharp.Model.PriceAndAvailabilityResponseInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductStatusCode** | **string** | Codes signifying whether the sku is active or not. | [optional] 
**ProductStatusMessage** | **string** | Message returned saying whether sku is active. | [optional] 
**IngramPartNumber** | **string** | Ingram Micro unique part number for the product. | [optional] 
**VendorPartNumber** | **string** | Vendor’s part number for the product. | [optional] 
**ExtendedVendorPartNumber** | **string** | Extended Vendor Part Number. *Currently, this feature is not available in these countries (Mexico, Turkey, New Zealand, Colombia, Chile, Brazil, Peru, Western Sahara). | [optional] 
**CustomerPartNumber** | **string** | Reseller / end-user’s part number for the product. | [optional] 
**Upc** | **string** | The UPC code for the product. Consists of 12 numeric digits that are uniquely assigned to each trade item. | [optional] 
**PartNumberType** | **string** | Number type of the part. | [optional] 
**VendorNumber** | **string** | Vendor number that identifies the product. | [optional] 
**VendorName** | **string** | Vendor name for the order. | [optional] 
**Description** | **string** | The description given for the product. | [optional] 
**ProductClass** | **string** | Indicates whether the product is directly shipped from the vendor’s warehouse or if the product ships from Ingram Micro’s warehouse. Class Codes are Ingram classifications on how skus are stocked A &#x3D; Product that is stocked usually in all IM warehouses and replenished on a regular basis. B &#x3D; Product that is stocked in limited IM warehouses and replenished on a regular basis C &#x3D; Product that is stocked in fewer IM warehouses and replenished on a regular basis. D &#x3D; Product that Ingram Micro has elected to discontinue. E &#x3D; Product that will be phased out later, according to the vendor. You may not want to replenish this product, but instead sell down what is in stock. F &#x3D; Product that we carry for a specific customer or supplier under a contractual agreement. N &#x3D; New Sku. Classification before first receipt O &#x3D; Discontinued product to be liquidated S&#x3D; Order for Specialized Demand (Order to backorder) X&#x3D; direct ship from Vendor V &#x3D; product that vendor has elected to discontinue. | [optional] 
**Uom** | **string** | The description given for the product. | [optional] 
**ProductStatus** | **string** | Status that gives whether the product is Active. | [optional] 
**AcceptBackOrder** | **bool** | Boolean that indicates if the product accepts backorder. | [optional] 
**ProductAuthorized** | **bool** | Boolean that indicates whether a product is authorized. | [optional] 
**ReturnableProduct** | **bool** | Boolean that indicates if the product can be returned. | [optional] 
**EndUserInfoRequired** | **bool** | Boolean that indicates  if end user information is required. | [optional] 
**GovtSpecialPriceAvailable** | **bool** | Boolean that indicates if special pricing is available for the product. | [optional] 
**GovtProgramType** | **string** | Program type, “PA” for government orders, “ED” for education order. | [optional] 
**GovtEndUserType** | **string** | Type of end user of the program. F &#x3D; Federal, S &#x3D; State, E &#x3D; Local, K &#x3D; K-12 school, and H &#x3D; Higher Education. | [optional] 
**Availability** | [**PriceAndAvailabilityResponseInnerAvailability**](PriceAndAvailabilityResponseInnerAvailability.md) |  | [optional] 
**ReserveInventoryDetails** | [**List&lt;PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner&gt;**](PriceAndAvailabilityResponseInnerReserveInventoryDetailsInner.md) |  | [optional] 
**Pricing** | [**PriceAndAvailabilityResponseInnerPricing**](PriceAndAvailabilityResponseInnerPricing.md) |  | [optional] 
**Discounts** | [**List&lt;PriceAndAvailabilityResponseInnerDiscountsInner&gt;**](PriceAndAvailabilityResponseInnerDiscountsInner.md) |  | [optional] 
**BundlePartIndicator** | **bool** | True of false value to indicate whether it’s bundle part. *Currently, this feature is not available in these countries (Mexico, Turkey, New Zealand, Colombia, Chile, Brazil, Peru, Western Sahara). | [optional] 
**ServiceFees** | [**List&lt;PriceAndAvailabilityResponseInnerServiceFeesInner&gt;**](PriceAndAvailabilityResponseInnerServiceFeesInner.md) | *Currently, this feature is not available in these countries (Mexico, Turkey, New Zealand, Colombia, Chile, Brazil, Peru, Western Sahara). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

