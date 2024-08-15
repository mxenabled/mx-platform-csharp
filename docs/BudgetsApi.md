# MX.Platform.CSharp.Api.BudgetsApi

All URIs are relative to *https://api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersUserGuidBudgetsBudgetGuidDelete**](BudgetsApi.md#usersuserguidbudgetsbudgetguiddelete) | **DELETE** /users/{user_guid}/budgets/{budget_guid} | Delete a budget |
| [**UsersUserGuidBudgetsBudgetGuidGet**](BudgetsApi.md#usersuserguidbudgetsbudgetguidget) | **GET** /users/{user_guid}/budgets/{budget_guid} | Read a specific budget |
| [**UsersUserGuidBudgetsBudgetGuidPut**](BudgetsApi.md#usersuserguidbudgetsbudgetguidput) | **PUT** /users/{user_guid}/budgets/{budget_guid} | Update a specific budget |
| [**UsersUserGuidBudgetsGeneratePost**](BudgetsApi.md#usersuserguidbudgetsgeneratepost) | **POST** /users/{user_guid}/budgets/generate | Auto-generate budgets |
| [**UsersUserGuidBudgetsGet**](BudgetsApi.md#usersuserguidbudgetsget) | **GET** /users/{user_guid}/budgets | List all budgets |
| [**UsersUserGuidBudgetsPost**](BudgetsApi.md#usersuserguidbudgetspost) | **POST** /users/{user_guid}/budgets | Create a budget |

<a id="usersuserguidbudgetsbudgetguiddelete"></a>
# **UsersUserGuidBudgetsBudgetGuidDelete**
> void UsersUserGuidBudgetsBudgetGuidDelete (string userGuid, string budgetGuid)

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
    public class UsersUserGuidBudgetsBudgetGuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the budget. Defined by MX.
            var budgetGuid = "budgetGuid_example";  // string | The unique identifier for the budget. Defined by MX.

            try
            {
                // Delete a budget
                apiInstance.UsersUserGuidBudgetsBudgetGuidDelete(userGuid, budgetGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsBudgetGuidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidBudgetsBudgetGuidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a budget
    apiInstance.UsersUserGuidBudgetsBudgetGuidDeleteWithHttpInfo(userGuid, budgetGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsBudgetGuidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the budget. Defined by MX. |  |
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

<a id="usersuserguidbudgetsbudgetguidget"></a>
# **UsersUserGuidBudgetsBudgetGuidGet**
> BudgetResponseBody UsersUserGuidBudgetsBudgetGuidGet (string budgetGuid, string userGuid)

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
    public class UsersUserGuidBudgetsBudgetGuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var budgetGuid = "budgetGuid_example";  // string | The unique identifier for the budget. Defined by MX.
            var userGuid = "userGuid_example";  // string | The unique identifier for the budget. Defined by MX.

            try
            {
                // Read a specific budget
                BudgetResponseBody result = apiInstance.UsersUserGuidBudgetsBudgetGuidGet(budgetGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsBudgetGuidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidBudgetsBudgetGuidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a specific budget
    ApiResponse<BudgetResponseBody> response = apiInstance.UsersUserGuidBudgetsBudgetGuidGetWithHttpInfo(budgetGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsBudgetGuidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **budgetGuid** | **string** | The unique identifier for the budget. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for the budget. Defined by MX. |  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

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

<a id="usersuserguidbudgetsbudgetguidput"></a>
# **UsersUserGuidBudgetsBudgetGuidPut**
> BudgetResponseBody UsersUserGuidBudgetsBudgetGuidPut (string userGuid, string budgetGuid, BudgetUpdateRequestBody? budgetUpdateRequestBody = null)

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
    public class UsersUserGuidBudgetsBudgetGuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the budget. Defined by MX.
            var budgetGuid = "budgetGuid_example";  // string | The unique identifier for the budget. Defined by MX.
            var budgetUpdateRequestBody = new BudgetUpdateRequestBody?(); // BudgetUpdateRequestBody? |  (optional) 

            try
            {
                // Update a specific budget
                BudgetResponseBody result = apiInstance.UsersUserGuidBudgetsBudgetGuidPut(userGuid, budgetGuid, budgetUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsBudgetGuidPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidBudgetsBudgetGuidPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a specific budget
    ApiResponse<BudgetResponseBody> response = apiInstance.UsersUserGuidBudgetsBudgetGuidPutWithHttpInfo(userGuid, budgetGuid, budgetUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsBudgetGuidPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the budget. Defined by MX. |  |
| **budgetGuid** | **string** | The unique identifier for the budget. Defined by MX. |  |
| **budgetUpdateRequestBody** | [**BudgetUpdateRequestBody?**](BudgetUpdateRequestBody?.md) |  | [optional]  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

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

<a id="usersuserguidbudgetsgeneratepost"></a>
# **UsersUserGuidBudgetsGeneratePost**
> BudgetResponseBody UsersUserGuidBudgetsGeneratePost (string userGuid)

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
    public class UsersUserGuidBudgetsGeneratePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user. Defined by MX.

            try
            {
                // Auto-generate budgets
                BudgetResponseBody result = apiInstance.UsersUserGuidBudgetsGeneratePost(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsGeneratePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidBudgetsGeneratePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Auto-generate budgets
    ApiResponse<BudgetResponseBody> response = apiInstance.UsersUserGuidBudgetsGeneratePostWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsGeneratePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

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

<a id="usersuserguidbudgetsget"></a>
# **UsersUserGuidBudgetsGet**
> BudgetResponseBody UsersUserGuidBudgetsGet (string userGuid)

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
    public class UsersUserGuidBudgetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user. Defined by MX.

            try
            {
                // List all budgets
                BudgetResponseBody result = apiInstance.UsersUserGuidBudgetsGet(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidBudgetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all budgets
    ApiResponse<BudgetResponseBody> response = apiInstance.UsersUserGuidBudgetsGetWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

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

<a id="usersuserguidbudgetspost"></a>
# **UsersUserGuidBudgetsPost**
> BudgetResponseBody UsersUserGuidBudgetsPost (string userGuid, BudgetCreateRequestBody budgetCreateRequestBody)

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
    public class UsersUserGuidBudgetsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BudgetsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user. Defined by MX.
            var budgetCreateRequestBody = new BudgetCreateRequestBody(); // BudgetCreateRequestBody | 

            try
            {
                // Create a budget
                BudgetResponseBody result = apiInstance.UsersUserGuidBudgetsPost(userGuid, budgetCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidBudgetsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a budget
    ApiResponse<BudgetResponseBody> response = apiInstance.UsersUserGuidBudgetsPostWithHttpInfo(userGuid, budgetCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BudgetsApi.UsersUserGuidBudgetsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **budgetCreateRequestBody** | [**BudgetCreateRequestBody**](BudgetCreateRequestBody.md) |  |  |

### Return type

[**BudgetResponseBody**](BudgetResponseBody.md)

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

