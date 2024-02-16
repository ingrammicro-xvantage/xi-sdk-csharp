# xi.sdk.resellers.Model.OrderCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerOrderNumber** | **string** | The reseller&#39;s unique PO/Order number. | 
**EndCustomerOrderNumber** | **string** | The end user/customer&#39;s Purchase Order number. | [optional] 
**BillToAddressId** | **string** | Suffix used to identify billing address. Created during onboarding. Resellers are provided with one or more address IDs depending on how many bill to addresses they need for various flooring companies they are using for credit. | [optional] 
**SpecialBidNumber** | **string** | The bid number provided to the reseller by the vendor for special pricing and discounts. Line-level bid numbers take precedence over header-level bid numbers. | [optional] 
**Notes** | **string** | Order level notes. | [optional] 
**AcceptBackOrder** | **bool** | ENUM [\&quot;true\&quot;,\&quot;false\&quot;] - accept order if this item is backordered. This field along with shipComplete field decides the value of backorderflag. The value of this field is ignored when shipComplete field is present. | [optional] 
**ResellerInfo** | [**OrderCreateRequestResellerInfo**](OrderCreateRequestResellerInfo.md) |  | [optional] 
**Vmf** | [**OrderCreateRequestVmf**](OrderCreateRequestVmf.md) |  | [optional] 
**ShipToInfo** | [**OrderCreateRequestShipToInfo**](OrderCreateRequestShipToInfo.md) |  | [optional] 
**EndUserInfo** | [**OrderCreateRequestEndUserInfo**](OrderCreateRequestEndUserInfo.md) |  | [optional] 
**Lines** | [**List&lt;OrderCreateRequestLinesInner&gt;**](OrderCreateRequestLinesInner.md) | The line-level details of the order. | [optional] 
**ShipmentDetails** | [**OrderCreateRequestShipmentDetails**](OrderCreateRequestShipmentDetails.md) |  | [optional] 
**AdditionalAttributes** | [**List&lt;OrderCreateRequestAdditionalAttributesInner&gt;**](OrderCreateRequestAdditionalAttributesInner.md) | Shipment-level additional attributes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

