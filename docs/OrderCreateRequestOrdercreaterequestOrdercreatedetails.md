# xi-sdk-csharp.Model.OrderCreateRequestOrdercreaterequestOrdercreatedetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customerponumber** | **string** | The customers unique Purchase Order number. Keep it unique to retrieve order information | 
**Ordertype** | **string** | Order Type - Standard orders, Direct ship orders | 
**Enduserordernumber** | **string** | Customers End-user PO number | [optional] 
**Billtosuffix** | **string** | Designates flooring acct to be used | [optional] 
**Shiptosuffix** | **string** | Applies to customers with multiple ship to locations (store locations) | [optional] 
**Shiptoaddress** | [**OrderCreateRequestOrdercreaterequestOrdercreatedetailsShiptoaddress**](OrderCreateRequestOrdercreaterequestOrdercreatedetailsShiptoaddress.md) |  | 
**Carriercode** | **string** | A customer can dictate what carrier to use for their shipment (Ingram 2-digit carrier code is required). Our recommendation is leave this field blank which will allow Ingram Micro to choose the best carrier to gain the best freight rates. | [optional] 
**Thirdpartyfreightaccountnumber** | **string** | Refers to a third-party freight account number for charging freight against. The account number should be passed within this field and the appropriate carrier code should be supplied within the carrier code tags. Prior to sending your request containing the third-party account number, it must be first entered into our system. Your Ingram Micro Sales Representative can action this for you. If submitted within an order without this preapproval the third-party account number will be ignored.  Note: USA partners- For FedEx Air only (carrier codes F1, FO, F2, FG.), please send three leading zeros before your third-party freight account number (i.e.: 000999999999.)  | [optional] 
**Specialbidnumber** | **string** | This is the special quote number given to a customer either by a vendor for special pricing or by Ingram Micro. To receive the special pricing assigned to this number it must be included on the order. | [optional] 
**Lines** | [**List&lt;OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner&gt;**](OrderCreateRequestOrdercreaterequestOrdercreatedetailsLinesInner.md) |  | 
**Extendedspecs** | [**List&lt;OrderCreateRequestOrdercreaterequestOrdercreatedetailsExtendedspecsInner&gt;**](OrderCreateRequestOrdercreaterequestOrdercreatedetailsExtendedspecsInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

