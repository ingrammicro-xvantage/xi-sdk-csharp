# xi-sdk-resellers-csharp.Api.StockUpdateApi

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResellersV1WebhooksAvailabilityupdatePost**](StockUpdateApi.md#resellersv1webhooksavailabilityupdatepost) | **POST** /resellers/v1/webhooks/availabilityupdate | Stock Update |

<a id="resellersv1webhooksavailabilityupdatepost"></a>
# **ResellersV1WebhooksAvailabilityupdatePost**
> void ResellersV1WebhooksAvailabilityupdatePost (string targeturl, string xHubSignature, AvailabilityAsyncNotificationRequest availabilityAsyncNotificationRequest)

Stock Update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using xi-sdk-resellers-csharp.Api;
using xi-sdk-resellers-csharp.Client;
using xi-sdk-resellers-csharp.Model;

namespace Example
{
    public class ResellersV1WebhooksAvailabilityupdatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443/sandbox";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StockUpdateApi(config);
            var targeturl = https://59a2dc5368073ab42fd9a92e210a9fdb.m.pipedream.net/;  // string | The webhook url where the request needs to sent.
            var xHubSignature = 3LeaTfLE5FLj1FcYflwdwFosH4ADHmMbds6thtirGC3e9lEkF9/1pt4T2fQQGlxf40EznDBER0b60M75K6ZW0A==;  // string | Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.
            var availabilityAsyncNotificationRequest = new AvailabilityAsyncNotificationRequest(); // AvailabilityAsyncNotificationRequest | 

            try
            {
                // Stock Update
                apiInstance.ResellersV1WebhooksAvailabilityupdatePost(targeturl, xHubSignature, availabilityAsyncNotificationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StockUpdateApi.ResellersV1WebhooksAvailabilityupdatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResellersV1WebhooksAvailabilityupdatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stock Update
    apiInstance.ResellersV1WebhooksAvailabilityupdatePostWithHttpInfo(targeturl, xHubSignature, availabilityAsyncNotificationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StockUpdateApi.ResellersV1WebhooksAvailabilityupdatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **targeturl** | **string** | The webhook url where the request needs to sent. |  |
| **xHubSignature** | **string** | Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works. |  |
| **availabilityAsyncNotificationRequest** | [**AvailabilityAsyncNotificationRequest**](AvailabilityAsyncNotificationRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[application](../README.md#application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

