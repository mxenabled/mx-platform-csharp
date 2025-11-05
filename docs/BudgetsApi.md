# MX.Platform.CSharp.Api.BudgetsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AutoGenerateBudgets**](BudgetsApi.md#autogeneratebudgets) | **POST** /users/{user_guid}/budgets/generate | Auto-generate budgets |
| [**CreateBudget**](BudgetsApi.md#createbudget) | **POST** /users/{user_guid}/budgets | Create a budget |
| [**DeleteBudget**](BudgetsApi.md#deletebudget) | **DELETE** /users/{user_guid}/budgets/{budget_guid} | Delete a budget |
| [**ListAllBudgets**](BudgetsApi.md#listallbudgets) | **GET** /users/{user_guid}/budgets | List all budgets |
| [**ReadSpecificBudget**](BudgetsApi.md#readspecificbudget) | **GET** /users/{user_guid}/budgets/{budget_guid} | Read a specific budget |
| [**UpdateSpecificBudget**](BudgetsApi.md#updatespecificbudget) | **PUT** /users/{user_guid}/budgets/{budget_guid} | Update a specific budget |

<a id="autogeneratebudgets"></a>
# **AutoGenerateBudgets**
> BudgetResponseBody AutoGenerateBudgets (string userGuid)

Auto-generate budgets

This endpoint will automatically create budgets for several categories based on existing transactions; these budgets are returned as an array. Specifically, budgets will only be generated if the `user` has at least one `transaction` in a given category during each of the two previous calendar months. For example, if the request is made on March 6, and there is at least one \"Bills & Utilities\" `transaction` in both January and February, a budget will be generated for \"Bills & Utilities.\" If there are two \"Bills & Utilities\" transactions in February but none in January, no budget will be generated for that category. If budgets already exist for particular categories, new budgets will be generated and returned based on the available transactions. If one or more budgets remain unchanged, they will nevertheless be returned in the response. If no transaction data for the `user` meet the above criteria, a `422 Unprocessable Entity` error will be returned with status code 4221 along with the message, `There aren't enough transactions to automatically create any budgets`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class AutoGenerateBudgetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Auto-generate budgets
                BudgetResponseBody result = apiInstance.AutoGenerateBudgets(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.AutoGenerateBudgets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutoGenerateBudgetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Auto-generate budgets
    ApiResponse<BudgetResponseBody> response = apiInstance.AutoGenerateBudgetsWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.AutoGenerateBudgetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

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

<a id="createbudget"></a>
# **CreateBudget**
> BudgetResponseBody CreateBudget (string userGuid, BudgetCreateRequestBody budgetCreateRequestBody)

Create a budget

Create a budget. This endpoint accepts the optional `MX-Skip-Webhook` header and `skip_webhook` parameter. You cannot create a duplicate budget. For example, if you attempt to create a budget for \"Gas\", but that budget already exist, the request will fail. You can retrieve a list of all existing categories by using the List Categories endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateBudgetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var budgetCreateRequestBody = new BudgetCreateRequestBody(); // BudgetCreateRequestBody | 

            try
            {
                // Create a budget
                BudgetResponseBody result = apiInstance.CreateBudget(userGuid, budgetCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.CreateBudget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBudgetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a budget
    ApiResponse<BudgetResponseBody> response = apiInstance.CreateBudgetWithHttpInfo(userGuid, budgetCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.CreateBudgetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **budgetCreateRequestBody** | [**BudgetCreateRequestBody**](BudgetCreateRequestBody.md) |  |  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.mx.api.v1+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletebudget"></a>
# **DeleteBudget**
> void DeleteBudget (string userGuid, string budgetGuid)

Delete a budget

Delete a budget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteBudgetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var budgetGuid = "budgetGuid_example";  // string | The unique identifier for the budget. Defined by MX.

            try
            {
                // Delete a budget
                apiInstance.DeleteBudget(userGuid, budgetGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.DeleteBudget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBudgetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a budget
    apiInstance.DeleteBudgetWithHttpInfo(userGuid, budgetGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.DeleteBudgetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **budgetGuid** | **string** | The unique identifier for the budget. Defined by MX. |  |

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
| **204** | No content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listallbudgets"></a>
# **ListAllBudgets**
> BudgetResponseBody ListAllBudgets (string userGuid)

List all budgets

List all budgets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListAllBudgetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // List all budgets
                BudgetResponseBody result = apiInstance.ListAllBudgets(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.ListAllBudgets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllBudgetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all budgets
    ApiResponse<BudgetResponseBody> response = apiInstance.ListAllBudgetsWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.ListAllBudgetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

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

<a id="readspecificbudget"></a>
# **ReadSpecificBudget**
> BudgetResponseBody ReadSpecificBudget (string userGuid, string budgetGuid)

Read a specific budget

Read a specific budget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadSpecificBudgetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var budgetGuid = "budgetGuid_example";  // string | The unique identifier for the budget. Defined by MX.

            try
            {
                // Read a specific budget
                BudgetResponseBody result = apiInstance.ReadSpecificBudget(userGuid, budgetGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.ReadSpecificBudget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadSpecificBudgetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a specific budget
    ApiResponse<BudgetResponseBody> response = apiInstance.ReadSpecificBudgetWithHttpInfo(userGuid, budgetGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.ReadSpecificBudgetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **budgetGuid** | **string** | The unique identifier for the budget. Defined by MX. |  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

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

<a id="updatespecificbudget"></a>
# **UpdateSpecificBudget**
> BudgetResponseBody UpdateSpecificBudget (string userGuid, string budgetGuid, BudgetUpdateRequestBody? budgetUpdateRequestBody = null)

Update a specific budget

Update a specific budget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateSpecificBudgetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var budgetGuid = "budgetGuid_example";  // string | The unique identifier for the budget. Defined by MX.
            var budgetUpdateRequestBody = new BudgetUpdateRequestBody?(); // BudgetUpdateRequestBody? |  (optional) 

            try
            {
                // Update a specific budget
                BudgetResponseBody result = apiInstance.UpdateSpecificBudget(userGuid, budgetGuid, budgetUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UpdateSpecificBudget: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSpecificBudgetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a specific budget
    ApiResponse<BudgetResponseBody> response = apiInstance.UpdateSpecificBudgetWithHttpInfo(userGuid, budgetGuid, budgetUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.UpdateSpecificBudgetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **budgetGuid** | **string** | The unique identifier for the budget. Defined by MX. |  |
| **budgetUpdateRequestBody** | [**BudgetUpdateRequestBody?**](BudgetUpdateRequestBody?.md) |  | [optional]  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/vnd.mx.api.v1+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

