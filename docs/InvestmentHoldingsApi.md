# MX.Platform.CSharp.Api.InvestmentHoldingsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeactivateUser**](InvestmentHoldingsApi.md#deactivateuser) | **GET** /users/{user_guid}/investment_holdings_deactivate | Deactivate user from Investment Holdings |
| [**ListHoldings**](InvestmentHoldingsApi.md#listholdings) | **GET** /users/{user_guid}/investment_holdings | List holdings by user |
| [**ListHoldingsByAccount**](InvestmentHoldingsApi.md#listholdingsbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/investment_holdings | List holdings by account |
| [**ListHoldingsByMember**](InvestmentHoldingsApi.md#listholdingsbymember) | **GET** /users/{user_guid}/members/{member_guid}/investment_holdings | List holdings by member |
| [**ReadHolding**](InvestmentHoldingsApi.md#readholding) | **GET** /users/{user_guid}/investment_holdings/{holding_guid} | Read holding |

<a id="deactivateuser"></a>
# **DeactivateUser**
> InvestmentHoldingsDeactivation DeactivateUser (string userGuid)

Deactivate user from Investment Holdings

This endpoint deactivates the specific user from the `/investment_holdings` product. To reactivate a user, use any of the current `/investment_holding` endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeactivateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InvestmentHoldingsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Deactivate user from Investment Holdings
                InvestmentHoldingsDeactivation result = apiInstance.DeactivateUser(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvestmentHoldingsApi.DeactivateUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeactivateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deactivate user from Investment Holdings
    ApiResponse<InvestmentHoldingsDeactivation> response = apiInstance.DeactivateUserWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvestmentHoldingsApi.DeactivateUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**InvestmentHoldingsDeactivation**](InvestmentHoldingsDeactivation.md)

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

<a id="listholdings"></a>
# **ListHoldings**
> InvestmentHoldingsResponseBody ListHoldings (string userGuid, int? page = null, int? recordsPerPage = null)

List holdings by user

This endpoint lists all holdings associated with the user across all accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InvestmentHoldingsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List holdings by user
                InvestmentHoldingsResponseBody result = apiInstance.ListHoldings(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvestmentHoldingsApi.ListHoldings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListHoldingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List holdings by user
    ApiResponse<InvestmentHoldingsResponseBody> response = apiInstance.ListHoldingsWithHttpInfo(userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvestmentHoldingsApi.ListHoldingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**InvestmentHoldingsResponseBody**](InvestmentHoldingsResponseBody.md)

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

<a id="listholdingsbyaccount"></a>
# **ListHoldingsByAccount**
> InvestmentHoldingsResponseBody ListHoldingsByAccount (string accountGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List holdings by account

This endpoint lists all holdings associated with the particular account defined.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListHoldingsByAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InvestmentHoldingsApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List holdings by account
                InvestmentHoldingsResponseBody result = apiInstance.ListHoldingsByAccount(accountGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvestmentHoldingsApi.ListHoldingsByAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListHoldingsByAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List holdings by account
    ApiResponse<InvestmentHoldingsResponseBody> response = apiInstance.ListHoldingsByAccountWithHttpInfo(accountGuid, userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvestmentHoldingsApi.ListHoldingsByAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**InvestmentHoldingsResponseBody**](InvestmentHoldingsResponseBody.md)

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

<a id="listholdingsbymember"></a>
# **ListHoldingsByMember**
> InvestmentHoldingsResponseBody ListHoldingsByMember (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List holdings by member

This endpoint lists all holdings associated with the specified member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListHoldingsByMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InvestmentHoldingsApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List holdings by member
                InvestmentHoldingsResponseBody result = apiInstance.ListHoldingsByMember(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvestmentHoldingsApi.ListHoldingsByMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListHoldingsByMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List holdings by member
    ApiResponse<InvestmentHoldingsResponseBody> response = apiInstance.ListHoldingsByMemberWithHttpInfo(memberGuid, userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvestmentHoldingsApi.ListHoldingsByMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**InvestmentHoldingsResponseBody**](InvestmentHoldingsResponseBody.md)

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

<a id="readholding"></a>
# **ReadHolding**
> InvestmentHoldingResponseBody ReadHolding (string holdingGuid, string userGuid)

Read holding

Use this endpoint to read the attributes of a specific `holding`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadHoldingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InvestmentHoldingsApi(config);
            var holdingGuid = HOL-d65683e8-9eab-26bb-bcfd-ced159c9abe2;  // string | The unique id for a `holding`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read holding
                InvestmentHoldingResponseBody result = apiInstance.ReadHolding(holdingGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvestmentHoldingsApi.ReadHolding: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadHoldingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read holding
    ApiResponse<InvestmentHoldingResponseBody> response = apiInstance.ReadHoldingWithHttpInfo(holdingGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvestmentHoldingsApi.ReadHoldingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **holdingGuid** | **string** | The unique id for a &#x60;holding&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**InvestmentHoldingResponseBody**](InvestmentHoldingResponseBody.md)

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

