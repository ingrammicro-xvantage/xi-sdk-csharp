# xi.sdk.resellers.Model.OrderCreateV7RequestEndUserInfo
The contact information for the end user/customer provided by the reseller. Used to determine pricing and discounts

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndUserId** | **string** | ID for the end user/customer in Ingram Micro&#39;s system. | [optional] 
**Contact** | **string** | The contact name for the end user/customer. | [optional] 
**CompanyName** | **string** | The company name for the end user/customer. Required for Impulse countries. | [optional] 
**AddressLine1** | **string** | The end user/customer&#39;s street address and building or house number. Required for Impulse countries. | [optional] 
**AddressLine2** | **string** | The end user/customer&#39;s apartment number. | [optional] 
**City** | **string** | The end user/customer&#39;s city. Required for Impulse countries. | [optional] 
**State** | **string** | The end user/customer&#39;s state. Required for Impulse countries but optional for EMEA countries. | [optional] 
**PostalCode** | **string** | The end user/customer&#39;s zip or postal code. Required for Impulse countries. | [optional] 
**CountryCode** | **string** | The end user/customer&#39;s two-character ISO country code. | [optional] 
**PhoneNumber** | **int** | The end user/customer&#39;s phone number. | [optional] 
**Email** | **string** | The end user/customer&#39;s email. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

