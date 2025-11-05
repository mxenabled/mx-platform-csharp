# MX.Platform.CSharp.Api.WidgetsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RequestConnectWidgetURL**](WidgetsApi.md#requestconnectwidgeturl) | **POST** /users/{user_guid}/connect_widget_url | (Deprecated) Request connect widget URL |
| [**RequestOAuthWindowURI**](WidgetsApi.md#requestoauthwindowuri) | **GET** /users/{user_guid}/members/{member_guid}/oauth_window_uri | Request oauth window uri |
| [**RequestWidgetURL**](WidgetsApi.md#requestwidgeturl) | **POST** /users/{user_guid}/widget_urls | Request widget URL |

<a id="requestconnectwidgeturl"></a>
# **RequestConnectWidgetURL**
> ConnectWidgetResponseBody RequestConnectWidgetURL (string userGuid, ConnectWidgetRequestBody connectWidgetRequestBody)

(Deprecated) Request connect widget URL

This endpoint will return a URL for an embeddable version of MX Connect.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class RequestConnectWidgetURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WidgetsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var connectWidgetRequestBody = new ConnectWidgetRequestBody(); // ConnectWidgetRequestBody | Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)

            try
            {
                // (Deprecated) Request connect widget URL
                ConnectWidgetResponseBody result = apiInstance.RequestConnectWidgetURL(userGuid, connectWidgetRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WidgetsApi.RequestConnectWidgetURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestConnectWidgetURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // (Deprecated) Request connect widget URL
    ApiResponse<ConnectWidgetResponseBody> response = apiInstance.RequestConnectWidgetURLWithHttpInfo(userGuid, connectWidgetRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WidgetsApi.RequestConnectWidgetURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **connectWidgetRequestBody** | [**ConnectWidgetRequestBody**](ConnectWidgetRequestBody.md) | Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials) |  |

### Return type

[**ConnectWidgetResponseBody**](ConnectWidgetResponseBody.md)

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

<a id="requestoauthwindowuri"></a>
# **RequestOAuthWindowURI**
> OAuthWindowResponseBody RequestOAuthWindowURI (string memberGuid, string userGuid, string? clientRedirectUrl = null, string? enableApp2app = null, string? referralSource = null, bool? skipAggregation = null, string? uiMessageWebviewUrlScheme = null)

Request oauth window uri

This endpoint will generate an `oauth_window_uri` for the specified `member`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class RequestOAuthWindowURIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WidgetsApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var clientRedirectUrl = https://{yoursite.com};  // string? | A URL that MX will redirect to at the end of OAuth with additional query parameters. Only available with `referral_source=APP`. (optional) 
            var enableApp2app = false;  // string? | This indicates whether OAuth app2app behavior is enabled for institutions that support it. Defaults to `true`. When set to `false`, any `oauth_window_uri` generated will **not** direct the end user to the institution's mobile application. This setting is not persistent. This setting currently only affects Chase institutions. (optional) 
            var referralSource = APP;  // string? | Must be either `BROWSER` or `APP` depending on the implementation. Defaults to `BROWSER`. (optional) 
            var skipAggregation = false;  // bool? | Setting this parameter to `true` will prevent the member from automatically aggregating after being redirected from the authorization page. (optional) 
            var uiMessageWebviewUrlScheme = "uiMessageWebviewUrlScheme_example";  // string? | A scheme for routing the user back to the application state they were previously in. Only available with `referral_source=APP`. (optional) 

            try
            {
                // Request oauth window uri
                OAuthWindowResponseBody result = apiInstance.RequestOAuthWindowURI(memberGuid, userGuid, clientRedirectUrl, enableApp2app, referralSource, skipAggregation, uiMessageWebviewUrlScheme);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WidgetsApi.RequestOAuthWindowURI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestOAuthWindowURIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request oauth window uri
    ApiResponse<OAuthWindowResponseBody> response = apiInstance.RequestOAuthWindowURIWithHttpInfo(memberGuid, userGuid, clientRedirectUrl, enableApp2app, referralSource, skipAggregation, uiMessageWebviewUrlScheme);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WidgetsApi.RequestOAuthWindowURIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **clientRedirectUrl** | **string?** | A URL that MX will redirect to at the end of OAuth with additional query parameters. Only available with &#x60;referral_source&#x3D;APP&#x60;. | [optional]  |
| **enableApp2app** | **string?** | This indicates whether OAuth app2app behavior is enabled for institutions that support it. Defaults to &#x60;true&#x60;. When set to &#x60;false&#x60;, any &#x60;oauth_window_uri&#x60; generated will **not** direct the end user to the institution&#39;s mobile application. This setting is not persistent. This setting currently only affects Chase institutions. | [optional]  |
| **referralSource** | **string?** | Must be either &#x60;BROWSER&#x60; or &#x60;APP&#x60; depending on the implementation. Defaults to &#x60;BROWSER&#x60;. | [optional]  |
| **skipAggregation** | **bool?** | Setting this parameter to &#x60;true&#x60; will prevent the member from automatically aggregating after being redirected from the authorization page. | [optional]  |
| **uiMessageWebviewUrlScheme** | **string?** | A scheme for routing the user back to the application state they were previously in. Only available with &#x60;referral_source&#x3D;APP&#x60;. | [optional]  |

### Return type

[**OAuthWindowResponseBody**](OAuthWindowResponseBody.md)

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

<a id="requestwidgeturl"></a>
# **RequestWidgetURL**
> WidgetResponseBody RequestWidgetURL (string userGuid, WidgetRequestBody widgetRequestBody, string? acceptLanguage = null, string? X_CALLBACK_PAYLOAD = null)

Request widget URL

Get an embeddable URL for integrating a widget into your website or app. The URL expires after ten minutes or upon first use, whichever occurs first. You'll need to obtain a new URL each time the page loads or reloads.  Include the `widget_type` in the request body to specify which widget you want to embed—the Connect Widget, a Personal Financial Management widget, or an Insights widget. Some request parameters are specific to certain widget types.  To embed the Connect Widget, set `widget_type` to `connect_widget`.  For a full list of available widget types, see [Widget Types](/api-reference/platform-api/reference/widgets#widget-types). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class RequestWidgetURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WidgetsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var widgetRequestBody = new WidgetRequestBody(); // WidgetRequestBody | The widget url configuration options.
            var acceptLanguage = en-US;  // string? | The desired language of the widget. (optional) 
            var X_CALLBACK_PAYLOAD = 813e50bd-4a7e-4517-b6bb-9eef65a68cbd;  // string? | The base64 encoded string defined in this header will be returned in the [Member](/resources/webhooks/member/) and [Member Data Updated](/resources/webhooks/member#member-data-updated) webhooks. This allows you to trace user interactions and workflows initiated externally and internally in the MX Platform. Max 1024 characters. (optional) 

            try
            {
                // Request widget URL
                WidgetResponseBody result = apiInstance.RequestWidgetURL(userGuid, widgetRequestBody, acceptLanguage, X_CALLBACK_PAYLOAD);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WidgetsApi.RequestWidgetURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestWidgetURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request widget URL
    ApiResponse<WidgetResponseBody> response = apiInstance.RequestWidgetURLWithHttpInfo(userGuid, widgetRequestBody, acceptLanguage, X_CALLBACK_PAYLOAD);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WidgetsApi.RequestWidgetURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **widgetRequestBody** | [**WidgetRequestBody**](WidgetRequestBody.md) | The widget url configuration options. |  |
| **acceptLanguage** | **string?** | The desired language of the widget. | [optional]  |
| **X_CALLBACK_PAYLOAD** | **string?** | The base64 encoded string defined in this header will be returned in the [Member](/resources/webhooks/member/) and [Member Data Updated](/resources/webhooks/member#member-data-updated) webhooks. This allows you to trace user interactions and workflows initiated externally and internally in the MX Platform. Max 1024 characters. | [optional]  |

### Return type

[**WidgetResponseBody**](WidgetResponseBody.md)

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

