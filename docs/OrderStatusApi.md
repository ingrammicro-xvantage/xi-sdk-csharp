# xi-sdk-resellers-csharp.Api.OrderStatusApi

All URIs are relative to *https://api.ingrammicro.com:443/sandbox*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResellersV1WebhooksOrderstatuseventPost**](OrderStatusApi.md#resellersv1webhooksorderstatuseventpost) | **POST** /resellers/v1/webhooks/orderstatusevent | Order Status |

<a id="resellersv1webhooksorderstatuseventpost"></a>
# **ResellersV1WebhooksOrderstatuseventPost**
> void ResellersV1WebhooksOrderstatuseventPost (string targeturl, string xHubSignature, OrderStatusAsyncNotificationRequest orderStatusAsyncNotificationRequest)

Order Status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using xi-sdk-resellers-csharp.Api;
using xi-sdk-resellers-csharp.Client;
using xi-sdk-resellers-csharp.Model;

namespace Example
{
    public class ResellersV1WebhooksOrderstatuseventPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443/sandbox";
            // Configure OAuth2 access token for authorization: application
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderStatusApi(config);
            var targeturl = https://59a2dc5368073ab42fd9a92e210a9fdb.m.pipedream.net/;  // string | The webhook url where the request needs to sent.
            var xHubSignature = 3LeaTfLE5FLj1FcYflwdwFosH4ADHmMbds6thtirGC3e9lEkF9/1pt4T2fQQGlxf40EznDBER0b60M75K6ZW0A==;  // string | Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works.
            var orderStatusAsyncNotificationRequest = new OrderStatusAsyncNotificationRequest(); // OrderStatusAsyncNotificationRequest | 

            try
            {
                // Order Status
                apiInstance.ResellersV1WebhooksOrderstatuseventPost(targeturl, xHubSignature, orderStatusAsyncNotificationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderStatusApi.ResellersV1WebhooksOrderstatuseventPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResellersV1WebhooksOrderstatuseventPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Order Status
    apiInstance.ResellersV1WebhooksOrderstatuseventPostWithHttpInfo(targeturl, xHubSignature, orderStatusAsyncNotificationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderStatusApi.ResellersV1WebhooksOrderstatuseventPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **targeturl** | **string** | The webhook url where the request needs to sent. |  |
| **xHubSignature** | **string** | Ingram Micro creates a signature token by use of a secret key + Event ID. The algorithm to generate the secret ley is given at link https://developer.ingrammicro.com/reseller/article/how-use-webhook-secret-key. Use the event Id in the below sample along with your secret key to generate the key. Alternatively, to send try this out, use a random text to see how it works. |  |
| **orderStatusAsyncNotificationRequest** | [**OrderStatusAsyncNotificationRequest**](OrderStatusAsyncNotificationRequest.md) |  |  |

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

