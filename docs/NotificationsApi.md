# MX.Platform.CSharp.Api.NotificationsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNotification**](NotificationsApi.md#createnotification) | **POST** /users/{user_guid}/notifications | Create a notification |
| [**ListNotifications**](NotificationsApi.md#listnotifications) | **GET** /users/{user_guid}/notifications | List notifications |
| [**ReadNotifications**](NotificationsApi.md#readnotifications) | **GET** /users/{user_guid}/notifications/{notification_guid} | Read notifications |

<a id="createnotification"></a>
# **CreateNotification**
> NotificationResponseBody CreateNotification (string userGuid, string content, string subject)

Create a notification

All notifications created through the API will be of notification type `API_NOTIFICATION`, channel `PUSH`, and will not be associated to an entity.  No other channels are supported.  This will only have an effect for clients using an MX mobile application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateNotificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new NotificationsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var content = "content_example";  // string | The information related to the notification.
            var subject = "subject_example";  // string | The subject related to the notification.

            try
            {
                // Create a notification
                NotificationResponseBody result = apiInstance.CreateNotification(userGuid, content, subject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateNotification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a notification
    ApiResponse<NotificationResponseBody> response = apiInstance.CreateNotificationWithHttpInfo(userGuid, content, subject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.CreateNotificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **content** | **string** | The information related to the notification. |  |
| **subject** | **string** | The subject related to the notification. |  |

### Return type

[**NotificationResponseBody**](NotificationResponseBody.md)

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

<a id="listnotifications"></a>
# **ListNotifications**
> NotificationsResponseBody ListNotifications (string userGuid, string? fromDate = null, string? toDate = null, int? page = null, int? recordsPerPage = null)

List notifications

All notifications for the user can be listed, including notifications created by MX for other channels besides `PUSH`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListNotificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new NotificationsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var fromDate = 2024-01-01;  // string? | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. (optional) 
            var toDate = 2024-03-31;  // string? | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. (optional) 
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List notifications
                NotificationsResponseBody result = apiInstance.ListNotifications(userGuid, fromDate, toDate, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.ListNotifications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListNotificationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List notifications
    ApiResponse<NotificationsResponseBody> response = apiInstance.ListNotificationsWithHttpInfo(userGuid, fromDate, toDate, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.ListNotificationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **fromDate** | **string?** | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. | [optional]  |
| **toDate** | **string?** | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. | [optional]  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**NotificationsResponseBody**](NotificationsResponseBody.md)

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

<a id="readnotifications"></a>
# **ReadNotifications**
> NotificationResponseBody ReadNotifications (string userGuid, string notificationGuid)

Read notifications

Can pull up any notification associated with the user, including notifications created by MX for other channels besides `PUSH`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadNotificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new NotificationsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var notificationGuid = NTF-b53294f5-2356-4782-9f81-ae064c42b40a;  // string | The unique identifier for notifications. Defined by MX.

            try
            {
                // Read notifications
                NotificationResponseBody result = apiInstance.ReadNotifications(userGuid, notificationGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.ReadNotifications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadNotificationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read notifications
    ApiResponse<NotificationResponseBody> response = apiInstance.ReadNotificationsWithHttpInfo(userGuid, notificationGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.ReadNotificationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **notificationGuid** | **string** | The unique identifier for notifications. Defined by MX. |  |

### Return type

[**NotificationResponseBody**](NotificationResponseBody.md)

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

