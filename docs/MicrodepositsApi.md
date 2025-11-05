# MX.Platform.CSharp.Api.MicrodepositsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateMicrodeposit**](MicrodepositsApi.md#createmicrodeposit) | **POST** /users/{user_guid}/micro_deposits | Create or pre-initiate a microdeposit |
| [**DeleteMicrodeposit**](MicrodepositsApi.md#deletemicrodeposit) | **DELETE** /users/{user_guid}/micro_deposits/{micro_deposit_guid} | Delete a microdeposit |
| [**ListUserMicrodeposits**](MicrodepositsApi.md#listusermicrodeposits) | **GET** /users/{user_guid}/micro_deposits | List all microdeposits for a user |
| [**ListUserVerifications**](MicrodepositsApi.md#listuserverifications) | **GET** /users/{user_guid}/account_verifications | List all verifications for a user |
| [**ReadUserMicrodeposit**](MicrodepositsApi.md#readusermicrodeposit) | **GET** /users/{user_guid}/micro_deposits/{micro_deposit_guid} | Read a microdeposit for a user |
| [**VerifyMicrodeposit**](MicrodepositsApi.md#verifymicrodeposit) | **PUT** /micro_deposits/{micro_deposit_guid}/verify | Verify a Microdeposit |

<a id="createmicrodeposit"></a>
# **CreateMicrodeposit**
> MicrodepositResponseBody CreateMicrodeposit (string userGuid, MicrodepositRequestBody microdepositRequestBody)

Create or pre-initiate a microdeposit

Use this endpoint to create or pre-initiate a microdeposit. The response will include the new microdeposit record with a status of `INITIATED` or `PREINITIATED` respectively.  To pre-initiate a microdeposit, you only need to set `email` (string), `first_name` (string), and `last_name` (string) in the request body.   Pre-initiating a microdeposit allows you to pass the end user's first name, last name, and email if this data has already been collected. If the end user selects an institution which requires the microdeposit flow, the pre-initiated `micro_deposit` will be used and the Connect Widget step that normally requests this info from the end user will be skipped. However, if the end user selects an institution which supports IAV, the pre-initiated `micro_deposit` will be deleted and IAV will be used instead. When requesting a Connect Widget URL after pre-initiating, make sure to set the `current_microdeposit_guid` to the resulting microdeposit's `guid` and set the `mode` to `verification`. If you use this enhanced flow, a `micro_deposit` should be pre-initiated for all connect sessions in verification mode. After pre-initiating a microdeposit, pass the GUID to the config as `current_microdeposit_guid` and set the `mode` to `verification` when requesting a Connect URL.  Pre-initiating a microdeposit is optional. If you choose to implement this flow, it should be used for all Connect Widget sessions in verification mode. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateMicrodepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var microdepositRequestBody = new MicrodepositRequestBody(); // MicrodepositRequestBody | 

            try
            {
                // Create or pre-initiate a microdeposit
                MicrodepositResponseBody result = apiInstance.CreateMicrodeposit(userGuid, microdepositRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.CreateMicrodeposit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMicrodepositWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or pre-initiate a microdeposit
    ApiResponse<MicrodepositResponseBody> response = apiInstance.CreateMicrodepositWithHttpInfo(userGuid, microdepositRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.CreateMicrodepositWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **microdepositRequestBody** | [**MicrodepositRequestBody**](MicrodepositRequestBody.md) |  |  |

### Return type

[**MicrodepositResponseBody**](MicrodepositResponseBody.md)

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

<a id="deletemicrodeposit"></a>
# **DeleteMicrodeposit**
> void DeleteMicrodeposit (string microDepositGuid, string userGuid)

Delete a microdeposit

Use this endpoint to delete the specified microdeposit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteMicrodepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var microDepositGuid = MIC-09ba578e-8448-4f7f-89e1-b62ff2517edb;  // string | The unique identifier for the microdeposit. Defined by MX.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Delete a microdeposit
                apiInstance.DeleteMicrodeposit(microDepositGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.DeleteMicrodeposit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMicrodepositWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a microdeposit
    apiInstance.DeleteMicrodepositWithHttpInfo(microDepositGuid, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.DeleteMicrodepositWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **microDepositGuid** | **string** | The unique identifier for the microdeposit. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

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

<a id="listusermicrodeposits"></a>
# **ListUserMicrodeposits**
> MicrodepositsResponseBody ListUserMicrodeposits (string userGuid)

List all microdeposits for a user

Use this endpoint to read the attributes of a specific microdeposit according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListUserMicrodepositsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // List all microdeposits for a user
                MicrodepositsResponseBody result = apiInstance.ListUserMicrodeposits(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.ListUserMicrodeposits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUserMicrodepositsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all microdeposits for a user
    ApiResponse<MicrodepositsResponseBody> response = apiInstance.ListUserMicrodepositsWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.ListUserMicrodepositsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**MicrodepositsResponseBody**](MicrodepositsResponseBody.md)

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

<a id="listuserverifications"></a>
# **ListUserVerifications**
> MicrodepositResponseBody ListUserVerifications (string userGuid)

List all verifications for a user

This endpoint returns a list of the account verifications associated with the user, as well as the status of those verifications. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListUserVerificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // List all verifications for a user
                MicrodepositResponseBody result = apiInstance.ListUserVerifications(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.ListUserVerifications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUserVerificationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all verifications for a user
    ApiResponse<MicrodepositResponseBody> response = apiInstance.ListUserVerificationsWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.ListUserVerificationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**MicrodepositResponseBody**](MicrodepositResponseBody.md)

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

<a id="readusermicrodeposit"></a>
# **ReadUserMicrodeposit**
> MicrodepositResponseBody ReadUserMicrodeposit (string microDepositGuid, string userGuid)

Read a microdeposit for a user

Use this endpoint to read the attributes of a specific microdeposit according to its unique GUID. <br></br> Webhooks for microdeposit status changes are triggered when a status changes. The actual status of the microdeposit guid updates every minute. You may force a status update by calling the read microdeposit endpoint. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadUserMicrodepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var microDepositGuid = MIC-09ba578e-8448-4f7f-89e1-b62ff2517edb;  // string | The unique identifier for the microdeposit. Defined by MX.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read a microdeposit for a user
                MicrodepositResponseBody result = apiInstance.ReadUserMicrodeposit(microDepositGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.ReadUserMicrodeposit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadUserMicrodepositWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a microdeposit for a user
    ApiResponse<MicrodepositResponseBody> response = apiInstance.ReadUserMicrodepositWithHttpInfo(microDepositGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.ReadUserMicrodepositWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **microDepositGuid** | **string** | The unique identifier for the microdeposit. Defined by MX. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**MicrodepositResponseBody**](MicrodepositResponseBody.md)

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

<a id="verifymicrodeposit"></a>
# **VerifyMicrodeposit**
> MicrodepositResponseBody VerifyMicrodeposit (string microDepositGuid, MicrodepositVerifyRequestBody? microdepositVerifyRequestBody = null)

Verify a Microdeposit

Use this endpoint to verify the amounts deposited into the account during a microdeposit verification. The verification has not successfully completed until the `status` is `VERIFIED`. Poll the `/users/{user_guid}/micro_deposits/{micro_deposit_guid}` (read microdeposit) endpoint until you see this status or an error state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class VerifyMicrodepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var microDepositGuid = MIC-09ba578e-8448-4f7f-89e1-b62ff2517edb;  // string | The unique identifier for the microdeposit. Defined by MX.
            var microdepositVerifyRequestBody = new MicrodepositVerifyRequestBody?(); // MicrodepositVerifyRequestBody? |  (optional) 

            try
            {
                // Verify a Microdeposit
                MicrodepositResponseBody result = apiInstance.VerifyMicrodeposit(microDepositGuid, microdepositVerifyRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.VerifyMicrodeposit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyMicrodepositWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify a Microdeposit
    ApiResponse<MicrodepositResponseBody> response = apiInstance.VerifyMicrodepositWithHttpInfo(microDepositGuid, microdepositVerifyRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.VerifyMicrodepositWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **microDepositGuid** | **string** | The unique identifier for the microdeposit. Defined by MX. |  |
| **microdepositVerifyRequestBody** | [**MicrodepositVerifyRequestBody?**](MicrodepositVerifyRequestBody?.md) |  | [optional]  |

### Return type

[**MicrodepositResponseBody**](MicrodepositResponseBody.md)

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

