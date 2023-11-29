# MX.Platform.CSharp.Api.SpendingPlanApi

All URIs are relative to *https://api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSpendingPlan**](SpendingPlanApi.md#createspendingplan) | **POST** /users/{user_guid}/spending_plans | Create spending plan |
| [**CreateSpendingPlanIterationItem**](SpendingPlanApi.md#createspendingplaniterationitem) | **POST** /users/{user_guid}/spending_plans/{spending_plan_guid}/iterations/current/iteration_items | Create spending plan iteration item |
| [**DeleteSpendingPlan**](SpendingPlanApi.md#deletespendingplan) | **DELETE** /users/{user_guid}/spending_plans/{spending_plan_guid} | Delete spending plan |
| [**DeleteSpendingPlanAccount**](SpendingPlanApi.md#deletespendingplanaccount) | **DELETE** /users/{user_guid}/spending_plans/{spending_plan_guid}/spending_plan_accounts/{spending_plan_account_guid} | Delete spending plan account |
| [**DeleteSpendingPlanIterationItem**](SpendingPlanApi.md#deletespendingplaniterationitem) | **DELETE** /users/{user_guid}/spending_plans/{spending_plan_guid}/iterations/current/iteration_items/{iteration_item_guid} | Delete spending plan iteration item |
| [**ListSpendingPlanAccounts**](SpendingPlanApi.md#listspendingplanaccounts) | **GET** /users/{user_guid}/spending_plans/{spending_plan_guid}/spending_plan_accounts | List spending plan accounts |
| [**ListSpendingPlanIterationItems**](SpendingPlanApi.md#listspendingplaniterationitems) | **GET** /users/{user_guid}/spending_plans/{spending_plan_guid}/iterations/current/iteration_items | List spending plan iteration items |
| [**ListSpendingPlanIterations**](SpendingPlanApi.md#listspendingplaniterations) | **GET** /users/{user_guid}/spending_plans/{spending_plan_guid}/iterations | List spending plan iterations |
| [**ListSpendingPlans**](SpendingPlanApi.md#listspendingplans) | **GET** /users/{user_guid}/spending_plans | List spending plans |
| [**ReadSpendingPlanAccount**](SpendingPlanApi.md#readspendingplanaccount) | **GET** /users/{user_guid}/spending_plans/{spending_plan_guid}/spending_plan_accounts/{spending_plan_account_guid} | Read spending plan account |
| [**ReadSpendingPlanIteration**](SpendingPlanApi.md#readspendingplaniteration) | **GET** /users/{user_guid}/spending_plans/{spending_plan_guid}/iterations/{iteration_number} | Read a spending plan iteration |
| [**ReadSpendingPlanIterationItem**](SpendingPlanApi.md#readspendingplaniterationitem) | **GET** /users/{user_guid}/spending_plans/{spending_plan_guid}/iterations/current/iteration_items/{iteration_item_guid} | Read a spending plan iteration item |
| [**ReadSpendingPlanUser**](SpendingPlanApi.md#readspendingplanuser) | **GET** /users/{user_guid}/spending_plans/{spending_plan_guid} | Read a spending plan for a user |
| [**UpdateSpendingPlanIterationItem**](SpendingPlanApi.md#updatespendingplaniterationitem) | **PUT** /users/{user_guid}/spending_plans/{spending_plan_guid}/iterations/current/iteration_items/{iteration_item_guid} | Update a spending plan iteration item |

<a id="createspendingplan"></a>
# **CreateSpendingPlan**
> SpendingPlanResponse CreateSpendingPlan (string userGuid)

Create spending plan

This endpoint creates a new `spending_plan` for the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateSpendingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Create spending plan
                SpendingPlanResponse result = apiInstance.CreateSpendingPlan(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.CreateSpendingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSpendingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create spending plan
    ApiResponse<SpendingPlanResponse> response = apiInstance.CreateSpendingPlanWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.CreateSpendingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |

### Return type

[**SpendingPlanResponse**](SpendingPlanResponse.md)

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

<a id="createspendingplaniterationitem"></a>
# **CreateSpendingPlanIterationItem**
> SpendingPlanIterationItemResponse CreateSpendingPlanIterationItem (string spendingPlanGuid, string userGuid, SpendingPlanIterationItemCreateRequestBody spendingPlanIterationItemCreateRequestBody)

Create spending plan iteration item

This endpoint creates a new `spending_plan_iteration_item`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateSpendingPlanIterationItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanIterationItemCreateRequestBody = new SpendingPlanIterationItemCreateRequestBody(); // SpendingPlanIterationItemCreateRequestBody | Iteration item to be created with required parameter (planned_amount)

            try
            {
                // Create spending plan iteration item
                SpendingPlanIterationItemResponse result = apiInstance.CreateSpendingPlanIterationItem(spendingPlanGuid, userGuid, spendingPlanIterationItemCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.CreateSpendingPlanIterationItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSpendingPlanIterationItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create spending plan iteration item
    ApiResponse<SpendingPlanIterationItemResponse> response = apiInstance.CreateSpendingPlanIterationItemWithHttpInfo(spendingPlanGuid, userGuid, spendingPlanIterationItemCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.CreateSpendingPlanIterationItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanIterationItemCreateRequestBody** | [**SpendingPlanIterationItemCreateRequestBody**](SpendingPlanIterationItemCreateRequestBody.md) | Iteration item to be created with required parameter (planned_amount) |  |

### Return type

[**SpendingPlanIterationItemResponse**](SpendingPlanIterationItemResponse.md)

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

<a id="deletespendingplan"></a>
# **DeleteSpendingPlan**
> void DeleteSpendingPlan (string userGuid, string spendingPlanGuid)

Delete spending plan

Use this endpoint to delete a user's `spending_plan`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteSpendingPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique ID for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.

            try
            {
                // Delete spending plan
                apiInstance.DeleteSpendingPlan(userGuid, spendingPlanGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.DeleteSpendingPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSpendingPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete spending plan
    apiInstance.DeleteSpendingPlanWithHttpInfo(userGuid, spendingPlanGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.DeleteSpendingPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique ID for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletespendingplanaccount"></a>
# **DeleteSpendingPlanAccount**
> void DeleteSpendingPlanAccount (string userGuid, string spendingPlanGuid, string spendingPlanAccountGuid)

Delete spending plan account

Use this endpoint to delete a `spending_plan_account`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteSpendingPlanAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique ID for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var spendingPlanAccountGuid = ACT-e9f80fee-84da-7s7r-9a5e-0346g4279b4c;  // string | The unique ID for the specified account.

            try
            {
                // Delete spending plan account
                apiInstance.DeleteSpendingPlanAccount(userGuid, spendingPlanGuid, spendingPlanAccountGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.DeleteSpendingPlanAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSpendingPlanAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete spending plan account
    apiInstance.DeleteSpendingPlanAccountWithHttpInfo(userGuid, spendingPlanGuid, spendingPlanAccountGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.DeleteSpendingPlanAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique ID for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **spendingPlanAccountGuid** | **string** | The unique ID for the specified account. |  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletespendingplaniterationitem"></a>
# **DeleteSpendingPlanIterationItem**
> void DeleteSpendingPlanIterationItem (string userGuid, string spendingPlanGuid, string iterationItemGuid)

Delete spending plan iteration item

Use this endpoint to delete a spending plan `iteration_item`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteSpendingPlanIterationItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique ID for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var iterationItemGuid = SII-a4dc1549-da28-1245-9c9c-53eee4cdfbe3;  // string | The unique ID for the `iteration_item`.

            try
            {
                // Delete spending plan iteration item
                apiInstance.DeleteSpendingPlanIterationItem(userGuid, spendingPlanGuid, iterationItemGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.DeleteSpendingPlanIterationItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSpendingPlanIterationItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete spending plan iteration item
    apiInstance.DeleteSpendingPlanIterationItemWithHttpInfo(userGuid, spendingPlanGuid, iterationItemGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.DeleteSpendingPlanIterationItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique ID for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **iterationItemGuid** | **string** | The unique ID for the &#x60;iteration_item&#x60;. |  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listspendingplanaccounts"></a>
# **ListSpendingPlanAccounts**
> SpendingPlanAccountsResponse ListSpendingPlanAccounts (string userGuid, string spendingPlanGuid, int? page = null, int? recordsPerPage = null)

List spending plan accounts

Use this endpoint to list all the spending plan accounts associated with the spending plan.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListSpendingPlanAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List spending plan accounts
                SpendingPlanAccountsResponse result = apiInstance.ListSpendingPlanAccounts(userGuid, spendingPlanGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.ListSpendingPlanAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSpendingPlanAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List spending plan accounts
    ApiResponse<SpendingPlanAccountsResponse> response = apiInstance.ListSpendingPlanAccountsWithHttpInfo(userGuid, spendingPlanGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.ListSpendingPlanAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**SpendingPlanAccountsResponse**](SpendingPlanAccountsResponse.md)

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

<a id="listspendingplaniterationitems"></a>
# **ListSpendingPlanIterationItems**
> SpendingPlanIterationItemsResponseBody ListSpendingPlanIterationItems (string userGuid, string spendingPlanGuid, int? page = null, int? recordsPerPage = null)

List spending plan iteration items

Use this endpoint to list all the spending plan `iteration_items` associated with the `iteration`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListSpendingPlanIterationItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List spending plan iteration items
                SpendingPlanIterationItemsResponseBody result = apiInstance.ListSpendingPlanIterationItems(userGuid, spendingPlanGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.ListSpendingPlanIterationItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSpendingPlanIterationItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List spending plan iteration items
    ApiResponse<SpendingPlanIterationItemsResponseBody> response = apiInstance.ListSpendingPlanIterationItemsWithHttpInfo(userGuid, spendingPlanGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.ListSpendingPlanIterationItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**SpendingPlanIterationItemsResponseBody**](SpendingPlanIterationItemsResponseBody.md)

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

<a id="listspendingplaniterations"></a>
# **ListSpendingPlanIterations**
> SpendingPlanIterationsResponse ListSpendingPlanIterations (string userGuid, string spendingPlanGuid, int? page = null, int? recordsPerPage = null)

List spending plan iterations

Use this endpoint to list all the spending plan `iterations` associated with the `spending_plan`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListSpendingPlanIterationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List spending plan iterations
                SpendingPlanIterationsResponse result = apiInstance.ListSpendingPlanIterations(userGuid, spendingPlanGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.ListSpendingPlanIterations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSpendingPlanIterationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List spending plan iterations
    ApiResponse<SpendingPlanIterationsResponse> response = apiInstance.ListSpendingPlanIterationsWithHttpInfo(userGuid, spendingPlanGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.ListSpendingPlanIterationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**SpendingPlanIterationsResponse**](SpendingPlanIterationsResponse.md)

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

<a id="listspendingplans"></a>
# **ListSpendingPlans**
> SpendingPlansResponseBody ListSpendingPlans (string userGuid, int? page = null, int? recordsPerPage = null)

List spending plans

Use this endpoint to list all the spending plans associated with the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListSpendingPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List spending plans
                SpendingPlansResponseBody result = apiInstance.ListSpendingPlans(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.ListSpendingPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSpendingPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List spending plans
    ApiResponse<SpendingPlansResponseBody> response = apiInstance.ListSpendingPlansWithHttpInfo(userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.ListSpendingPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**SpendingPlansResponseBody**](SpendingPlansResponseBody.md)

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

<a id="readspendingplanaccount"></a>
# **ReadSpendingPlanAccount**
> SpendingPlanAccountResponse ReadSpendingPlanAccount (string userGuid, string spendingPlanGuid, string spendingPlanAccountGuid, int? page = null, int? recordsPerPage = null)

Read spending plan account

Use this endpoint to read the attributes of a specific spending plan account according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadSpendingPlanAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var spendingPlanAccountGuid = ACT-e9f80fee-84da-7s7r-9a5e-0346g4279b4c;  // string | The unique ID for the specified account.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // Read spending plan account
                SpendingPlanAccountResponse result = apiInstance.ReadSpendingPlanAccount(userGuid, spendingPlanGuid, spendingPlanAccountGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.ReadSpendingPlanAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadSpendingPlanAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read spending plan account
    ApiResponse<SpendingPlanAccountResponse> response = apiInstance.ReadSpendingPlanAccountWithHttpInfo(userGuid, spendingPlanGuid, spendingPlanAccountGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.ReadSpendingPlanAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **spendingPlanAccountGuid** | **string** | The unique ID for the specified account. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**SpendingPlanAccountResponse**](SpendingPlanAccountResponse.md)

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

<a id="readspendingplaniteration"></a>
# **ReadSpendingPlanIteration**
> SpendingPlanIterationResponse ReadSpendingPlanIteration (string userGuid, string spendingPlanGuid, int iterationNumber, int? page = null, int? recordsPerPage = null)

Read a spending plan iteration

Use this endpoint to read the attributes of a specific spending plan `iteration` according to its `iteration_number`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadSpendingPlanIterationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var iterationNumber = 1;  // int | The current iteration number for the spending plan `iteration``.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // Read a spending plan iteration
                SpendingPlanIterationResponse result = apiInstance.ReadSpendingPlanIteration(userGuid, spendingPlanGuid, iterationNumber, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.ReadSpendingPlanIteration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadSpendingPlanIterationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a spending plan iteration
    ApiResponse<SpendingPlanIterationResponse> response = apiInstance.ReadSpendingPlanIterationWithHttpInfo(userGuid, spendingPlanGuid, iterationNumber, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.ReadSpendingPlanIterationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **iterationNumber** | **int** | The current iteration number for the spending plan &#x60;iteration&#x60;&#x60;. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**SpendingPlanIterationResponse**](SpendingPlanIterationResponse.md)

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

<a id="readspendingplaniterationitem"></a>
# **ReadSpendingPlanIterationItem**
> SpendingPlanIterationItemResponse ReadSpendingPlanIterationItem (string userGuid, string spendingPlanGuid, string iterationItemGuid, int? page = null, int? recordsPerPage = null)

Read a spending plan iteration item

Use this endpoint to read the attributes of a specific spending plan `iteration_item` according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadSpendingPlanIterationItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var iterationItemGuid = SII-a4dc1549-da28-1245-9c9c-53eee4cdfbe3;  // string | The unique ID for the `iteration_item`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // Read a spending plan iteration item
                SpendingPlanIterationItemResponse result = apiInstance.ReadSpendingPlanIterationItem(userGuid, spendingPlanGuid, iterationItemGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.ReadSpendingPlanIterationItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadSpendingPlanIterationItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a spending plan iteration item
    ApiResponse<SpendingPlanIterationItemResponse> response = apiInstance.ReadSpendingPlanIterationItemWithHttpInfo(userGuid, spendingPlanGuid, iterationItemGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.ReadSpendingPlanIterationItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **iterationItemGuid** | **string** | The unique ID for the &#x60;iteration_item&#x60;. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**SpendingPlanIterationItemResponse**](SpendingPlanIterationItemResponse.md)

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

<a id="readspendingplanuser"></a>
# **ReadSpendingPlanUser**
> SpendingPlanResponse ReadSpendingPlanUser (string userGuid, string spendingPlanGuid, int? page = null, int? recordsPerPage = null)

Read a spending plan for a user

Use this endpoint to read the attributes of a specific spending plan according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadSpendingPlanUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // Read a spending plan for a user
                SpendingPlanResponse result = apiInstance.ReadSpendingPlanUser(userGuid, spendingPlanGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.ReadSpendingPlanUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadSpendingPlanUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a spending plan for a user
    ApiResponse<SpendingPlanResponse> response = apiInstance.ReadSpendingPlanUserWithHttpInfo(userGuid, spendingPlanGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.ReadSpendingPlanUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **page** | **int?** | Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | Specify records per page. | [optional]  |

### Return type

[**SpendingPlanResponse**](SpendingPlanResponse.md)

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

<a id="updatespendingplaniterationitem"></a>
# **UpdateSpendingPlanIterationItem**
> SpendingPlanIterationItemResponse UpdateSpendingPlanIterationItem (string userGuid, string spendingPlanGuid, string iterationItemGuid, SpendingPlanIterationItemCreateRequestBody spendingPlanIterationItemCreateRequestBody)

Update a spending plan iteration item

Use this endpoint to update an existing `spending_plan_iteration_item`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateSpendingPlanIterationItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SpendingPlanApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var spendingPlanGuid = SPL-e5f9a5bd-c5b3-4901-bdc0-62119b9db262;  // string | The unique ID for the `spending_plan`.
            var iterationItemGuid = SII-a4dc1549-da28-1245-9c9c-53eee4cdfbe3;  // string | The unique ID for the `iteration_item`.
            var spendingPlanIterationItemCreateRequestBody = new SpendingPlanIterationItemCreateRequestBody(); // SpendingPlanIterationItemCreateRequestBody | Iteration item to be updated with required parameter (planned_amount)

            try
            {
                // Update a spending plan iteration item
                SpendingPlanIterationItemResponse result = apiInstance.UpdateSpendingPlanIterationItem(userGuid, spendingPlanGuid, iterationItemGuid, spendingPlanIterationItemCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SpendingPlanApi.UpdateSpendingPlanIterationItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSpendingPlanIterationItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a spending plan iteration item
    ApiResponse<SpendingPlanIterationItemResponse> response = apiInstance.UpdateSpendingPlanIterationItemWithHttpInfo(userGuid, spendingPlanGuid, iterationItemGuid, spendingPlanIterationItemCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SpendingPlanApi.UpdateSpendingPlanIterationItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |
| **spendingPlanGuid** | **string** | The unique ID for the &#x60;spending_plan&#x60;. |  |
| **iterationItemGuid** | **string** | The unique ID for the &#x60;iteration_item&#x60;. |  |
| **spendingPlanIterationItemCreateRequestBody** | [**SpendingPlanIterationItemCreateRequestBody**](SpendingPlanIterationItemCreateRequestBody.md) | Iteration item to be updated with required parameter (planned_amount) |  |

### Return type

[**SpendingPlanIterationItemResponse**](SpendingPlanIterationItemResponse.md)

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

