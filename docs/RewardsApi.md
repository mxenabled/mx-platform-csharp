# MX.Platform.CSharp.Api.RewardsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreditCard**](RewardsApi.md#creditcard) | **GET** /credit_card_products/{credit_card_product_guid} | Read a Credit Card Product |
| [**FetchRewards**](RewardsApi.md#fetchrewards) | **POST** /users/{user_guid}/members/{member_guid}/fetch_rewards | Fetch Rewards |
| [**ListRewards**](RewardsApi.md#listrewards) | **GET** /users/{user_guid}/members/{member_guid}/rewards | List Rewards |
| [**ReadRewards**](RewardsApi.md#readrewards) | **GET** /users/{user_guid}/members/{member_guid}/rewards/{reward_guid} | Read Reward |

<a id="creditcard"></a>
# **CreditCard**
> CreditCardProductResponse CreditCard (string creditCardProductGuid)

Read a Credit Card Product

This endpoint returns the specified `credit_card_product` according to the unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreditCardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RewardsApi(config);
            var creditCardProductGuid = credit_card_product_guid;  // string | The required `credit_card_product_guid` can be found on the `account` object.

            try
            {
                // Read a Credit Card Product
                CreditCardProductResponse result = apiInstance.CreditCard(creditCardProductGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RewardsApi.CreditCard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreditCardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a Credit Card Product
    ApiResponse<CreditCardProductResponse> response = apiInstance.CreditCardWithHttpInfo(creditCardProductGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RewardsApi.CreditCardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **creditCardProductGuid** | **string** | The required &#x60;credit_card_product_guid&#x60; can be found on the &#x60;account&#x60; object. |  |

### Return type

[**CreditCardProductResponse**](CreditCardProductResponse.md)

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

<a id="fetchrewards"></a>
# **FetchRewards**
> MemberResponseBody FetchRewards (string userGuid, string memberGuid)

Fetch Rewards

Calling this endpoint initiates an aggregation-type event which will gather the member's rewards information, as well as account and transaction information. Rewards data is also gathered with daily background aggregations. Member and Rewards guids are defined by MX.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class FetchRewardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RewardsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.

            try
            {
                // Fetch Rewards
                MemberResponseBody result = apiInstance.FetchRewards(userGuid, memberGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RewardsApi.FetchRewards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchRewardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch Rewards
    ApiResponse<MemberResponseBody> response = apiInstance.FetchRewardsWithHttpInfo(userGuid, memberGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RewardsApi.FetchRewardsWithHttpInfo: " + e.Message);
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

[**MemberResponseBody**](MemberResponseBody.md)

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

<a id="listrewards"></a>
# **ListRewards**
> RewardsResponseBody ListRewards (string userGuid, string memberGuid)

List Rewards

Use this endpoint to list all the `rewards` associated with a specified `member`. Member guids are defined by MX.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListRewardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RewardsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.

            try
            {
                // List Rewards
                RewardsResponseBody result = apiInstance.ListRewards(userGuid, memberGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RewardsApi.ListRewards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRewardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Rewards
    ApiResponse<RewardsResponseBody> response = apiInstance.ListRewardsWithHttpInfo(userGuid, memberGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RewardsApi.ListRewardsWithHttpInfo: " + e.Message);
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

[**RewardsResponseBody**](RewardsResponseBody.md)

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

<a id="readrewards"></a>
# **ReadRewards**
> RewardResponseBody ReadRewards (string userGuid, string memberGuid, string rewardGuid)

Read Reward

Use this endpoint to read a specific `reward` based on its unique GUID. Member and Rewards guids are defined by MX.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadRewardsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new RewardsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var rewardGuid = RWD-fa7537f3-48aa-a683-a02a-b324322f54;  // string | The unique identifier for the rewards. Defined by MX.

            try
            {
                // Read Reward
                RewardResponseBody result = apiInstance.ReadRewards(userGuid, memberGuid, rewardGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RewardsApi.ReadRewards: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadRewardsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Reward
    ApiResponse<RewardResponseBody> response = apiInstance.ReadRewardsWithHttpInfo(userGuid, memberGuid, rewardGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RewardsApi.ReadRewardsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **rewardGuid** | **string** | The unique identifier for the rewards. Defined by MX. |  |

### Return type

[**RewardResponseBody**](RewardResponseBody.md)

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

