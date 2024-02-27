# xi.sdk.resellers.Api.AccesstokenApi

All URIs are relative to *https://api.ingrammicro.com:443*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccesstoken**](AccesstokenApi.md#getaccesstoken) | **GET** /oauth/oauth20/token | Accesstoken |

<a id="getaccesstoken"></a>
# **GetAccesstoken**
> AccesstokenResponse GetAccesstoken (string grantType, string clientId, string clientSecret)

Accesstoken

The Authentication endpoint will provide an access token to access the API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using xi.sdk.resellers.Api;
using xi.sdk.resellers.Client;
using xi.sdk.resellers.Model;

namespace Example
{
    public class GetAccesstokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ingrammicro.com:443";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AccesstokenApi(httpClient, config, httpClientHandler);
            var grantType = client_credentials;  // string | Keep grant_type as client_credentials only.
            var clientId = "clientId_example";  // string | 
            var clientSecret = "clientSecret_example";  // string | 

            try
            {
                // Accesstoken
                AccesstokenResponse result = apiInstance.GetAccesstoken(grantType, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccesstokenApi.GetAccesstoken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccesstokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Accesstoken
    ApiResponse<AccesstokenResponse> response = apiInstance.GetAccesstokenWithHttpInfo(grantType, clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccesstokenApi.GetAccesstokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string** | Keep grant_type as client_credentials only. |  |
| **clientId** | **string** |  |  |
| **clientSecret** | **string** |  |  |

### Return type

[**AccesstokenResponse**](AccesstokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

