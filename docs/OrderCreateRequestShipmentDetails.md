# xi-sdk-resellers-csharp.Model.OrderCreateRequestShipmentDetails
Shipping details for the order provided by the customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierCode** | **string** | The code for the shipping carrier for the line item. | [optional] 
**FreightAccountNumber** | **string** | The reseller &#39;s shipping account number with carrier. Used to bill the shipping carrier directly from the reseller&#39;s account with the carrier. | [optional] 
**ShipComplete** | **string** | Specifies whether the shipment will be shipped only when all products are fulfilled. The value of this field along with acceptBackOrder field decides the value of backorderflag. If this field is set, acceptBackOrder field is ignored. Possible values for this field are true, C, P, E.    With value as true or C, backorderflag will be set as C.    With value as P, or E, backorderflag will be set as P or E respectively.    C &#x3D; Ship complete at distribution level.    P &#x3D; ship complete at line level.    E &#x3D; ship complete across all distributions.  | [optional] 
**RequestedDeliveryDate** | **DateTime** | The reseller-requested delivery date in UTC format. Delivery date is not guaranteed. | [optional] 
**SignatureRequired** | **bool** | Specifies whether a signature is required for delivery. Default is False. | [optional] 
**ShippingInstructions** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

