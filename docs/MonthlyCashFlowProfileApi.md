# MX.Platform.CSharp.Api.MonthlyCashFlowProfileApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReadMonthlyCashFlowProfile**](MonthlyCashFlowProfileApi.md#readmonthlycashflowprofile) | **GET** /users/{user_guid}/monthly_cash_flow_profile | Read monthly cash flow profile |
| [**UpdateMonthlyCashFlowProfile**](MonthlyCashFlowProfileApi.md#updatemonthlycashflowprofile) | **PUT** /users/{user_guid}/monthly_cash_flow_profile | Update monthly cash flow profile |

<a id="readmonthlycashflowprofile"></a>
# **ReadMonthlyCashFlowProfile**
> MonthlyCashFlowResponseBody ReadMonthlyCashFlowProfile (string userGuid)

Read monthly cash flow profile

Read monthly cash flow profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadMonthlyCashFlowProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MonthlyCashFlowProfileApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read monthly cash flow profile
                MonthlyCashFlowResponseBody result = apiInstance.ReadMonthlyCashFlowProfile(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonthlyCashFlowProfileApi.ReadMonthlyCashFlowProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadMonthlyCashFlowProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read monthly cash flow profile
    ApiResponse<MonthlyCashFlowResponseBody> response = apiInstance.ReadMonthlyCashFlowProfileWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonthlyCashFlowProfileApi.ReadMonthlyCashFlowProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**MonthlyCashFlowResponseBody**](MonthlyCashFlowResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemonthlycashflowprofile"></a>
# **UpdateMonthlyCashFlowProfile**
> MonthlyCashFlowResponseBody UpdateMonthlyCashFlowProfile (string userGuid, MonthlyCashFlowProfileRequestBody monthlyCashFlowProfileRequestBody)

Update monthly cash flow profile

Use this endpoint to update the attributes of a `monthly_cash_flow_profile`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateMonthlyCashFlowProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MonthlyCashFlowProfileApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var monthlyCashFlowProfileRequestBody = new MonthlyCashFlowProfileRequestBody(); // MonthlyCashFlowProfileRequestBody | 

            try
            {
                // Update monthly cash flow profile
                MonthlyCashFlowResponseBody result = apiInstance.UpdateMonthlyCashFlowProfile(userGuid, monthlyCashFlowProfileRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonthlyCashFlowProfileApi.UpdateMonthlyCashFlowProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMonthlyCashFlowProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update monthly cash flow profile
    ApiResponse<MonthlyCashFlowResponseBody> response = apiInstance.UpdateMonthlyCashFlowProfileWithHttpInfo(userGuid, monthlyCashFlowProfileRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonthlyCashFlowProfileApi.UpdateMonthlyCashFlowProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **monthlyCashFlowProfileRequestBody** | [**MonthlyCashFlowProfileRequestBody**](MonthlyCashFlowProfileRequestBody.md) |  |  |

### Return type

[**MonthlyCashFlowResponseBody**](MonthlyCashFlowResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

