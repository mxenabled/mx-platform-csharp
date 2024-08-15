# MX.Platform.CSharp.Api.GoalsApi

All URIs are relative to *https://api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersUserGuidGoalsGet**](GoalsApi.md#usersuserguidgoalsget) | **GET** /users/{user_guid}/goals | List goals |
| [**UsersUserGuidGoalsGoalGuidDelete**](GoalsApi.md#usersuserguidgoalsgoalguiddelete) | **DELETE** /users/{user_guid}/goals/{goal_guid} | Delete a goal |
| [**UsersUserGuidGoalsGoalGuidGet**](GoalsApi.md#usersuserguidgoalsgoalguidget) | **GET** /users/{user_guid}/goals/{goal_guid} | Read a goal |
| [**UsersUserGuidGoalsGoalGuidPut**](GoalsApi.md#usersuserguidgoalsgoalguidput) | **PUT** /users/{user_guid}/goals/{goal_guid} | Update a goal |
| [**UsersUserGuidGoalsPost**](GoalsApi.md#usersuserguidgoalspost) | **POST** /users/{user_guid}/goals | Create a goal |
| [**UsersUserGuidGoalsRepositionPut**](GoalsApi.md#usersuserguidgoalsrepositionput) | **PUT** /users/{user_guid}/goals/reposition | Reposition goals |

<a id="usersuserguidgoalsget"></a>
# **UsersUserGuidGoalsGet**
> GoalsResponseBody UsersUserGuidGoalsGet (string userGuid, string? page = null, string? recordsPerAge = null)

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
    public class UsersUserGuidGoalsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user.
            var page = "page_example";  // string? | Results are returned in paginated sets, this is the page of the results you would like to view. Defaults to page 1 if no page is specified. (optional) 
            var recordsPerAge = "recordsPerAge_example";  // string? | The supported range is from 10 to 1000. If the records_per_page parameter is not specified or is outside this range, a default of 25 records per page will be used. (optional) 

            try
            {
                // List goals
                GoalsResponseBody result = apiInstance.UsersUserGuidGoalsGet(userGuid, page, recordsPerAge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidGoalsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List goals
    ApiResponse<GoalsResponseBody> response = apiInstance.UsersUserGuidGoalsGetWithHttpInfo(userGuid, page, recordsPerAge);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. |  |
| **page** | **string?** | Results are returned in paginated sets, this is the page of the results you would like to view. Defaults to page 1 if no page is specified. | [optional]  |
| **recordsPerAge** | **string?** | The supported range is from 10 to 1000. If the records_per_page parameter is not specified or is outside this range, a default of 25 records per page will be used. | [optional]  |

### Return type

[**GoalsResponseBody**](GoalsResponseBody.md)

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

<a id="usersuserguidgoalsgoalguiddelete"></a>
# **UsersUserGuidGoalsGoalGuidDelete**
> void UsersUserGuidGoalsGoalGuidDelete (string goalGuid, string userGuid)

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
    public class UsersUserGuidGoalsGoalGuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var goalGuid = "goalGuid_example";  // string | The unique identifier for a goal. Defined by MX.
            var userGuid = "userGuid_example";  // string | The unique identifier for a user.

            try
            {
                // Delete a goal
                apiInstance.UsersUserGuidGoalsGoalGuidDelete(goalGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsGoalGuidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidGoalsGoalGuidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a goal
    apiInstance.UsersUserGuidGoalsGoalGuidDeleteWithHttpInfo(goalGuid, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsGoalGuidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalGuid** | **string** | The unique identifier for a goal. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for a user. |  |

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

<a id="usersuserguidgoalsgoalguidget"></a>
# **UsersUserGuidGoalsGoalGuidGet**
> GoalResponseBody UsersUserGuidGoalsGoalGuidGet (string goalGuid, string userGuid)

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
    public class UsersUserGuidGoalsGoalGuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var goalGuid = "goalGuid_example";  // string | The unique identifier for a goal. Defined by MX.
            var userGuid = "userGuid_example";  // string | The unique identifier for a user.

            try
            {
                // Read a goal
                GoalResponseBody result = apiInstance.UsersUserGuidGoalsGoalGuidGet(goalGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsGoalGuidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidGoalsGoalGuidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a goal
    ApiResponse<GoalResponseBody> response = apiInstance.UsersUserGuidGoalsGoalGuidGetWithHttpInfo(goalGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsGoalGuidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalGuid** | **string** | The unique identifier for a goal. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for a user. |  |

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

<a id="usersuserguidgoalsgoalguidput"></a>
# **UsersUserGuidGoalsGoalGuidPut**
> GoalResponseBody UsersUserGuidGoalsGoalGuidPut (string goalGuid, string userGuid, UpdateGoalRequestBody updateGoalRequestBody)

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
    public class UsersUserGuidGoalsGoalGuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var goalGuid = "goalGuid_example";  // string | The unique identifier for a goal. Defined by MX.
            var userGuid = "userGuid_example";  // string | The unique identifier for a user.
            var updateGoalRequestBody = new UpdateGoalRequestBody(); // UpdateGoalRequestBody | 

            try
            {
                // Update a goal
                GoalResponseBody result = apiInstance.UsersUserGuidGoalsGoalGuidPut(goalGuid, userGuid, updateGoalRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsGoalGuidPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidGoalsGoalGuidPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a goal
    ApiResponse<GoalResponseBody> response = apiInstance.UsersUserGuidGoalsGoalGuidPutWithHttpInfo(goalGuid, userGuid, updateGoalRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsGoalGuidPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalGuid** | **string** | The unique identifier for a goal. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for a user. |  |
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

<a id="usersuserguidgoalspost"></a>
# **UsersUserGuidGoalsPost**
> GoalResponseBody UsersUserGuidGoalsPost (string userGuid, GoalRequestBody goalRequestBody)

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
    public class UsersUserGuidGoalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user.
            var goalRequestBody = new GoalRequestBody(); // GoalRequestBody | 

            try
            {
                // Create a goal
                GoalResponseBody result = apiInstance.UsersUserGuidGoalsPost(userGuid, goalRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidGoalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a goal
    ApiResponse<GoalResponseBody> response = apiInstance.UsersUserGuidGoalsPostWithHttpInfo(userGuid, goalRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. |  |
| **goalRequestBody** | [**GoalRequestBody**](GoalRequestBody.md) |  |  |

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

<a id="usersuserguidgoalsrepositionput"></a>
# **UsersUserGuidGoalsRepositionPut**
> RepositionResponseBody UsersUserGuidGoalsRepositionPut (string userGuid, RepositionRequestBody repositionRequestBody)

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
    public class UsersUserGuidGoalsRepositionPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new GoalsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user.
            var repositionRequestBody = new RepositionRequestBody(); // RepositionRequestBody | 

            try
            {
                // Reposition goals
                RepositionResponseBody result = apiInstance.UsersUserGuidGoalsRepositionPut(userGuid, repositionRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsRepositionPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidGoalsRepositionPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reposition goals
    ApiResponse<RepositionResponseBody> response = apiInstance.UsersUserGuidGoalsRepositionPutWithHttpInfo(userGuid, repositionRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalsApi.UsersUserGuidGoalsRepositionPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. |  |
| **repositionRequestBody** | [**RepositionRequestBody**](RepositionRequestBody.md) |  |  |

### Return type

[**RepositionResponseBody**](RepositionResponseBody.md)

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

