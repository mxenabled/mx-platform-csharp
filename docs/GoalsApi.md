# MX.Platform.CSharp.Api.GoalsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateGoal**](GoalsApi.md#creategoal) | **POST** /users/{user_guid}/goals | Create a goal |
| [**DeleteGoal**](GoalsApi.md#deletegoal) | **DELETE** /users/{user_guid}/goals/{goal_guid} | Delete a goal |
| [**ListGoals**](GoalsApi.md#listgoals) | **GET** /users/{user_guid}/goals | List goals |
| [**ReadGoal**](GoalsApi.md#readgoal) | **GET** /users/{user_guid}/goals/{goal_guid} | Read a goal |
| [**RepositionGoals**](GoalsApi.md#repositiongoals) | **PUT** /users/{user_guid}/goals/reposition | Reposition goals |
| [**UpdateGoal**](GoalsApi.md#updategoal) | **PUT** /users/{user_guid}/goals/{goal_guid} | Update a goal |

<a id="creategoal"></a>
# **CreateGoal**
> GoalResponseBody CreateGoal (string userGuid, GoalRequestBody goalRequestBody)

Create a goal

Create a goal. This endpoint accepts the optional `MX-Skip-Webhook` header and `skip_webhook` parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateGoalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var goalRequestBody = new GoalRequestBody(); // GoalRequestBody | 

            try
            {
                // Create a goal
                GoalResponseBody result = apiInstance.CreateGoal(userGuid, goalRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.CreateGoal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGoalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a goal
    ApiResponse<GoalResponseBody> response = apiInstance.CreateGoalWithHttpInfo(userGuid, goalRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.CreateGoalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **goalRequestBody** | [**GoalRequestBody**](GoalRequestBody.md) |  |  |

### Return type

[**GoalResponseBody**](GoalResponseBody.md)

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

<a id="deletegoal"></a>
# **DeleteGoal**
> void DeleteGoal (string goalGuid, string userGuid, string accept)

Delete a goal

Delete a goal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteGoalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var goalGuid = "goalGuid_example";  // string | The unique identifier for a goal. Defined by MX.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var accept = application/vnd.mx.api.v1+json;  // string | Specifies the media type expected in the response.

            try
            {
                // Delete a goal
                apiInstance.DeleteGoal(goalGuid, userGuid, accept);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.DeleteGoal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGoalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a goal
    apiInstance.DeleteGoalWithHttpInfo(goalGuid, userGuid, accept);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.DeleteGoalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalGuid** | **string** | The unique identifier for a goal. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **accept** | **string** | Specifies the media type expected in the response. |  |

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

<a id="listgoals"></a>
# **ListGoals**
> GoalsResponseBody ListGoals (string accept, string userGuid, int? page = null, int? recordsPerPage = null)

List goals

List all goals a user can set.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListGoalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var accept = application/vnd.mx.api.v1+json;  // string | Specifies the media type expected in the response.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List goals
                GoalsResponseBody result = apiInstance.ListGoals(accept, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.ListGoals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListGoalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List goals
    ApiResponse<GoalsResponseBody> response = apiInstance.ListGoalsWithHttpInfo(accept, userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.ListGoalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accept** | **string** | Specifies the media type expected in the response. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**GoalsResponseBody**](GoalsResponseBody.md)

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

<a id="readgoal"></a>
# **ReadGoal**
> GoalResponseBody ReadGoal (string goalGuid, string userGuid)

Read a goal

Read a specific goal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadGoalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var goalGuid = "goalGuid_example";  // string | The unique identifier for a goal. Defined by MX.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read a goal
                GoalResponseBody result = apiInstance.ReadGoal(goalGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.ReadGoal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadGoalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a goal
    ApiResponse<GoalResponseBody> response = apiInstance.ReadGoalWithHttpInfo(goalGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.ReadGoalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalGuid** | **string** | The unique identifier for a goal. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**GoalResponseBody**](GoalResponseBody.md)

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

<a id="repositiongoals"></a>
# **RepositionGoals**
> RepositionResponseBody RepositionGoals (string userGuid, RepositionRequestBody repositionRequestBody)

Reposition goals

This endpoint repositions goal priority levels. If one goal is set to a lower priority, then any other goals need to be adjusted accordingly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class RepositionGoalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var repositionRequestBody = new RepositionRequestBody(); // RepositionRequestBody | 

            try
            {
                // Reposition goals
                RepositionResponseBody result = apiInstance.RepositionGoals(userGuid, repositionRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.RepositionGoals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RepositionGoalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reposition goals
    ApiResponse<RepositionResponseBody> response = apiInstance.RepositionGoalsWithHttpInfo(userGuid, repositionRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.RepositionGoalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **repositionRequestBody** | [**RepositionRequestBody**](RepositionRequestBody.md) |  |  |

### Return type

[**RepositionResponseBody**](RepositionResponseBody.md)

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

<a id="updategoal"></a>
# **UpdateGoal**
> GoalResponseBody UpdateGoal (string goalGuid, string userGuid, UpdateGoalRequestBody updateGoalRequestBody)

Update a goal

This endpoint updates a specific goal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateGoalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var goalGuid = "goalGuid_example";  // string | The unique identifier for a goal. Defined by MX.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var updateGoalRequestBody = new UpdateGoalRequestBody(); // UpdateGoalRequestBody | 

            try
            {
                // Update a goal
                GoalResponseBody result = apiInstance.UpdateGoal(goalGuid, userGuid, updateGoalRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.UpdateGoal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGoalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a goal
    ApiResponse<GoalResponseBody> response = apiInstance.UpdateGoalWithHttpInfo(goalGuid, userGuid, updateGoalRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.UpdateGoalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalGuid** | **string** | The unique identifier for a goal. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **updateGoalRequestBody** | [**UpdateGoalRequestBody**](UpdateGoalRequestBody.md) |  |  |

### Return type

[**GoalResponseBody**](GoalResponseBody.md)

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

