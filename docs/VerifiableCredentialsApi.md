# MX.Platform.CSharp.Api.VerifiableCredentialsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountsData**](VerifiableCredentialsApi.md#getaccountsdata) | **GET** /vc/users/{user_guid}/members/{member_guid}/accounts | Get Accounts Data |
| [**GetIdentityData**](VerifiableCredentialsApi.md#getidentitydata) | **GET** /vc/users/{user_guid}/members/{member_guid}/customers | Get Identity Data |
| [**GetTransactionsData**](VerifiableCredentialsApi.md#gettransactionsdata) | **GET** /vc/users/{user_guid}/accounts/{account_guid}/transactions | Get Transactions Data |

<a id="getaccountsdata"></a>
# **GetAccountsData**
> VCResponse GetAccountsData (string userGuid, string memberGuid)

Get Accounts Data

Get an MX-issued verifiable credential of a user's accounts data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class GetAccountsDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VerifiableCredentialsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.

            try
            {
                // Get Accounts Data
                VCResponse result = apiInstance.GetAccountsData(userGuid, memberGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerifiableCredentialsApi.GetAccountsData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountsDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Accounts Data
    ApiResponse<VCResponse> response = apiInstance.GetAccountsDataWithHttpInfo(userGuid, memberGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerifiableCredentialsApi.GetAccountsDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |

### Return type

[**VCResponse**](VCResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.mx.api.v2beta+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getidentitydata"></a>
# **GetIdentityData**
> VCResponse GetIdentityData (string userGuid, string memberGuid)

Get Identity Data

Get an MX-issued verifiable credential of a user's identity data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class GetIdentityDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VerifiableCredentialsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.

            try
            {
                // Get Identity Data
                VCResponse result = apiInstance.GetIdentityData(userGuid, memberGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerifiableCredentialsApi.GetIdentityData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIdentityDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Identity Data
    ApiResponse<VCResponse> response = apiInstance.GetIdentityDataWithHttpInfo(userGuid, memberGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerifiableCredentialsApi.GetIdentityDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |

### Return type

[**VCResponse**](VCResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.mx.api.v2beta+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactionsdata"></a>
# **GetTransactionsData**
> VCResponse GetTransactionsData (string userGuid, string accountGuid, string? startTime = null, string? endTime = null)

Get Transactions Data

Get an MX-issued verifiable credential of a user's transaction data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class GetTransactionsDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new VerifiableCredentialsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var startTime = 2015-09-20;  // string? | Filter transactions from this date. Must be in the format YYYY-MM-DD. The range is limited to 1 year. (optional) 
            var endTime = 2015-09-20;  // string? | Filter transactions to this date. Must be in the format YYYY-MM-DD. The range is limited to 1 year. (optional) 

            try
            {
                // Get Transactions Data
                VCResponse result = apiInstance.GetTransactionsData(userGuid, accountGuid, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerifiableCredentialsApi.GetTransactionsData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transactions Data
    ApiResponse<VCResponse> response = apiInstance.GetTransactionsDataWithHttpInfo(userGuid, accountGuid, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerifiableCredentialsApi.GetTransactionsDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **startTime** | **string?** | Filter transactions from this date. Must be in the format YYYY-MM-DD. The range is limited to 1 year. | [optional]  |
| **endTime** | **string?** | Filter transactions to this date. Must be in the format YYYY-MM-DD. The range is limited to 1 year. | [optional]  |

### Return type

[**VCResponse**](VCResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.mx.api.v2beta+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

