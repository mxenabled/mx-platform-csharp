# MX.Platform.CSharp.Api.InsightsApi

All URIs are relative to *https://api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListAccountsInsight**](InsightsApi.md#listaccountsinsight) | **GET** /users/{user_guid}/insights/{insight_guid}/accounts | List all accounts associated with an insight. |
| [**ListCategoriesInsight**](InsightsApi.md#listcategoriesinsight) | **GET** /users/{user_guid}/insights/{insight_guid}/categories | List all categories associated with an insight. |
| [**ListInsightsByAccount**](InsightsApi.md#listinsightsbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/insights | List insights by account |
| [**ListInsightsUser**](InsightsApi.md#listinsightsuser) | **GET** /users/{user_guid}/insights | List all insights for a user. |
| [**ListMerchantsInsight**](InsightsApi.md#listmerchantsinsight) | **GET** /users/{user_guid}/insights/{insight_guid}/merchants | List all merchants associated with an insight. |
| [**ListScheduledPaymentsInsight**](InsightsApi.md#listscheduledpaymentsinsight) | **GET** /users/{user_guid}/insights/{insight_guid}/scheduled_payments | List all scheduled payments associated with an insight |
| [**ListTransactionsInsight**](InsightsApi.md#listtransactionsinsight) | **GET** /users/{user_guid}/insights/{insight_guid}/transactions | List all transactions associated with an insight. |
| [**ReadInsightsUser**](InsightsApi.md#readinsightsuser) | **GET** /users/{user_guid}/insights{insight_guid} | Read a specific insight. |
| [**UpdateInsight**](InsightsApi.md#updateinsight) | **PUT** /users/{user_guid}/insights{insight_guid} | Update insight |

<a id="listaccountsinsight"></a>
# **ListAccountsInsight**
> AccountsResponseBody ListAccountsInsight (string userGuid, string insightGuid, int? page = null, int? recordsPerPage = null)

List all accounts associated with an insight.

Use this endpoint to list all the accounts associated with the insight.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListAccountsInsightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var userGuid = USR-1234-abcd;  // string | The unique identifier for the user. Defined by MX.
            var insightGuid = BET-1234-abcd;  // string | The unique identifier for the insight. Defined by MX.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List all accounts associated with an insight.
                AccountsResponseBody result = apiInstance.ListAccountsInsight(userGuid, insightGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.ListAccountsInsight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccountsInsightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all accounts associated with an insight.
    ApiResponse<AccountsResponseBody> response = apiInstance.ListAccountsInsightWithHttpInfo(userGuid, insightGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.ListAccountsInsightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **insightGuid** | **string** | The unique identifier for the insight. Defined by MX. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**AccountsResponseBody**](AccountsResponseBody.md)

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

<a id="listcategoriesinsight"></a>
# **ListCategoriesInsight**
> CategoriesResponseBody ListCategoriesInsight (string userGuid, string insightGuid, int? page = null, int? recordsPerPage = null)

List all categories associated with an insight.

Use this endpoint to list all the categories associated with the insight.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListCategoriesInsightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var userGuid = USR-1234-abcd;  // string | The unique identifier for the user. Defined by MX.
            var insightGuid = BET-1234-abcd;  // string | The unique identifier for the insight. Defined by MX.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List all categories associated with an insight.
                CategoriesResponseBody result = apiInstance.ListCategoriesInsight(userGuid, insightGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.ListCategoriesInsight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCategoriesInsightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all categories associated with an insight.
    ApiResponse<CategoriesResponseBody> response = apiInstance.ListCategoriesInsightWithHttpInfo(userGuid, insightGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.ListCategoriesInsightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **insightGuid** | **string** | The unique identifier for the insight. Defined by MX. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**CategoriesResponseBody**](CategoriesResponseBody.md)

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

<a id="listinsightsbyaccount"></a>
# **ListInsightsByAccount**
> InsightsResponseBody ListInsightsByAccount (string accountGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List insights by account

Use this endpoint to list all insights associated with a specified account GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListInsightsByAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var accountGuid = ACT-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for the `account`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for the `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List insights by account
                InsightsResponseBody result = apiInstance.ListInsightsByAccount(accountGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.ListInsightsByAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInsightsByAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List insights by account
    ApiResponse<InsightsResponseBody> response = apiInstance.ListInsightsByAccountWithHttpInfo(accountGuid, userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.ListInsightsByAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for the &#x60;account&#x60;. |  |
| **userGuid** | **string** | The unique id for the &#x60;user&#x60;. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**InsightsResponseBody**](InsightsResponseBody.md)

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

<a id="listinsightsuser"></a>
# **ListInsightsUser**
> InsightsResponseBody ListInsightsUser (string userGuid, int? page = null, int? recordsPerPage = null)

List all insights for a user.

Use this endpoint to list all the insights associated with the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListInsightsUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var userGuid = USR-1234-abcd;  // string | The unique identifier for the user. Defined by MX.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List all insights for a user.
                InsightsResponseBody result = apiInstance.ListInsightsUser(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.ListInsightsUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInsightsUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all insights for a user.
    ApiResponse<InsightsResponseBody> response = apiInstance.ListInsightsUserWithHttpInfo(userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.ListInsightsUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**InsightsResponseBody**](InsightsResponseBody.md)

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

<a id="listmerchantsinsight"></a>
# **ListMerchantsInsight**
> MerchantsResponseBody ListMerchantsInsight (string userGuid, string insightGuid, int? page = null, int? recordsPerPage = null)

List all merchants associated with an insight.

Use this endpoint to list all the merchants associated with the insight.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListMerchantsInsightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var userGuid = USR-1234-abcd;  // string | The unique identifier for the user. Defined by MX.
            var insightGuid = BET-1234-abcd;  // string | The unique identifier for the insight. Defined by MX.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List all merchants associated with an insight.
                MerchantsResponseBody result = apiInstance.ListMerchantsInsight(userGuid, insightGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.ListMerchantsInsight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMerchantsInsightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all merchants associated with an insight.
    ApiResponse<MerchantsResponseBody> response = apiInstance.ListMerchantsInsightWithHttpInfo(userGuid, insightGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.ListMerchantsInsightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **insightGuid** | **string** | The unique identifier for the insight. Defined by MX. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

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

<a id="listscheduledpaymentsinsight"></a>
# **ListScheduledPaymentsInsight**
> ScheduledPaymentsResponseBody ListScheduledPaymentsInsight (string userGuid, string insightGuid, int? page = null, int? recordsPerPage = null)

List all scheduled payments associated with an insight

Use this endpoint to list all the scheduled payments associated with the insight.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListScheduledPaymentsInsightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var userGuid = USR-1234-abcd;  // string | The unique identifier for the user. Defined by MX.
            var insightGuid = BET-1234-abcd;  // string | The unique identifier for the insight. Defined by MX.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List all scheduled payments associated with an insight
                ScheduledPaymentsResponseBody result = apiInstance.ListScheduledPaymentsInsight(userGuid, insightGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.ListScheduledPaymentsInsight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListScheduledPaymentsInsightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all scheduled payments associated with an insight
    ApiResponse<ScheduledPaymentsResponseBody> response = apiInstance.ListScheduledPaymentsInsightWithHttpInfo(userGuid, insightGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.ListScheduledPaymentsInsightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **insightGuid** | **string** | The unique identifier for the insight. Defined by MX. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**ScheduledPaymentsResponseBody**](ScheduledPaymentsResponseBody.md)

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

<a id="listtransactionsinsight"></a>
# **ListTransactionsInsight**
> TransactionsResponseBody ListTransactionsInsight (string userGuid, string insightGuid, int? page = null, int? recordsPerPage = null)

List all transactions associated with an insight.

Use this endpoint to list all the transactions associated with the insight.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTransactionsInsightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var userGuid = USR-1234-abcd;  // string | The unique identifier for the user. Defined by MX.
            var insightGuid = BET-1234-abcd;  // string | The unique identifier for the insight. Defined by MX.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List all transactions associated with an insight.
                TransactionsResponseBody result = apiInstance.ListTransactionsInsight(userGuid, insightGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.ListTransactionsInsight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionsInsightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all transactions associated with an insight.
    ApiResponse<TransactionsResponseBody> response = apiInstance.ListTransactionsInsightWithHttpInfo(userGuid, insightGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.ListTransactionsInsightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **insightGuid** | **string** | The unique identifier for the insight. Defined by MX. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**TransactionsResponseBody**](TransactionsResponseBody.md)

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

<a id="readinsightsuser"></a>
# **ReadInsightsUser**
> InsightResponseBody ReadInsightsUser (string userGuid, string insightGuid)

Read a specific insight.

Use this endpoint to read the attributes of a specific insight according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadInsightsUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var userGuid = USR-1234-abcd;  // string | The unique identifier for the user. Defined by MX.
            var insightGuid = BET-1234-abcd;  // string | The unique identifier for the insight. Defined by MX.

            try
            {
                // Read a specific insight.
                InsightResponseBody result = apiInstance.ReadInsightsUser(userGuid, insightGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.ReadInsightsUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadInsightsUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a specific insight.
    ApiResponse<InsightResponseBody> response = apiInstance.ReadInsightsUserWithHttpInfo(userGuid, insightGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.ReadInsightsUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **insightGuid** | **string** | The unique identifier for the insight. Defined by MX. |  |

### Return type

[**InsightResponseBody**](InsightResponseBody.md)

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

<a id="updateinsight"></a>
# **UpdateInsight**
> InsightResponse UpdateInsight (string userGuid, string insightGuid, InsightUpdateRequest insightUpdateRequest)

Update insight

Use this endpoint to update the attributes of a particular insight according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateInsightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InsightsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for the user. Defined by MX.
            var insightGuid = BET-1234-abcd;  // string | The unique identifier for the insight. Defined by MX.
            var insightUpdateRequest = new InsightUpdateRequest(); // InsightUpdateRequest | The insight to be updated (None of these parameters are required, but the user object cannot be empty.)

            try
            {
                // Update insight
                InsightResponse result = apiInstance.UpdateInsight(userGuid, insightGuid, insightUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InsightsApi.UpdateInsight: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInsightWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update insight
    ApiResponse<InsightResponse> response = apiInstance.UpdateInsightWithHttpInfo(userGuid, insightGuid, insightUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InsightsApi.UpdateInsightWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **insightGuid** | **string** | The unique identifier for the insight. Defined by MX. |  |
| **insightUpdateRequest** | [**InsightUpdateRequest**](InsightUpdateRequest.md) | The insight to be updated (None of these parameters are required, but the user object cannot be empty.) |  |

### Return type

[**InsightResponse**](InsightResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.mx.api.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

