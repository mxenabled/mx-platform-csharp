# MX.Platform.CSharp.Api.MerchantsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListMerchants**](MerchantsApi.md#listmerchants) | **GET** /merchants | List merchants |
| [**ReadMerchant**](MerchantsApi.md#readmerchant) | **GET** /merchants/{merchant_guid} | Read merchant |
| [**ReadMerchantLocation**](MerchantsApi.md#readmerchantlocation) | **GET** /merchant_locations/{merchant_location_guid} | Read merchant location |

<a id="listmerchants"></a>
# **ListMerchants**
> MerchantsResponseBody ListMerchants (string? name = null, int? page = null, int? recordsPerPage = null)

List merchants

This endpoint returns a paginated list of all the merchants in the MX system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListMerchantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MerchantsApi(config);
            var name = Comcast;  // string? | This will list only merchants in which the appended string appears. (optional) 
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List merchants
                MerchantsResponseBody result = apiInstance.ListMerchants(name, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MerchantsApi.ListMerchants: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMerchantsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List merchants
    ApiResponse<MerchantsResponseBody> response = apiInstance.ListMerchantsWithHttpInfo(name, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MerchantsApi.ListMerchantsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | This will list only merchants in which the appended string appears. | [optional]  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**MerchantsResponseBody**](MerchantsResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.mx.api.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readmerchant"></a>
# **ReadMerchant**
> MerchantResponseBody ReadMerchant (string merchantGuid)

Read merchant

Returns information about a particular merchant, such as a logo, name, and website.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadMerchantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MerchantsApi(config);
            var merchantGuid = MCH-7ed79542-884d-2b1b-dd74-501c5cc9d25b;  // string | The unique id for a `merchant`.

            try
            {
                // Read merchant
                MerchantResponseBody result = apiInstance.ReadMerchant(merchantGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MerchantsApi.ReadMerchant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadMerchantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read merchant
    ApiResponse<MerchantResponseBody> response = apiInstance.ReadMerchantWithHttpInfo(merchantGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MerchantsApi.ReadMerchantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **merchantGuid** | **string** | The unique id for a &#x60;merchant&#x60;. |  |

### Return type

[**MerchantResponseBody**](MerchantResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.mx.api.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readmerchantlocation"></a>
# **ReadMerchantLocation**
> MerchantLocationResponseBody ReadMerchantLocation (string merchantLocationGuid)

Read merchant location

This endpoint returns the specified `merchant_location` resource. The `merchant_location_guid` can be found on `transaction` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadMerchantLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MerchantsApi(config);
            var merchantLocationGuid = MCH-09466f0a-fb58-9d1a-bae2-2af0afbea621;  // string | The unique id for a `merchant_location`.

            try
            {
                // Read merchant location
                MerchantLocationResponseBody result = apiInstance.ReadMerchantLocation(merchantLocationGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MerchantsApi.ReadMerchantLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadMerchantLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read merchant location
    ApiResponse<MerchantLocationResponseBody> response = apiInstance.ReadMerchantLocationWithHttpInfo(merchantLocationGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MerchantsApi.ReadMerchantLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **merchantLocationGuid** | **string** | The unique id for a &#x60;merchant_location&#x60;. |  |

### Return type

[**MerchantLocationResponseBody**](MerchantLocationResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.mx.api.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

