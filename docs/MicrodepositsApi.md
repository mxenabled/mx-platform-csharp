# MX.Platform.CSharp.Api.MicrodepositsApi

All URIs are relative to *https://api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MicroDepositsMicrodepositGuidVerifyPut**](MicrodepositsApi.md#microdepositsmicrodepositguidverifyput) | **PUT** /micro_deposits/{microdeposit_guid}/verify | Verify a Microdeposit |
| [**UsersUserGuidMicroDepositsGet**](MicrodepositsApi.md#usersuserguidmicrodepositsget) | **GET** /users/{user_guid}/micro_deposits | List all microdeposits for a user |
| [**UsersUserGuidMicroDepositsMicroDepositGuidDelete**](MicrodepositsApi.md#usersuserguidmicrodepositsmicrodepositguiddelete) | **DELETE** /users/{user_guid}/micro_deposits/{micro_deposit_guid} | Delete a microdeposit |
| [**UsersUserGuidMicroDepositsMicroDepositGuidGet**](MicrodepositsApi.md#usersuserguidmicrodepositsmicrodepositguidget) | **GET** /users/{user_guid}/micro_deposits/{micro_deposit_guid} | Read a microdeposit for a user |
| [**UsersUserGuidMicroDepositsPost**](MicrodepositsApi.md#usersuserguidmicrodepositspost) | **POST** /users/{user_guid}/micro_deposits | Create a microdeposit |

<a id="microdepositsmicrodepositguidverifyput"></a>
# **MicroDepositsMicrodepositGuidVerifyPut**
> MicrodepositResponseBody MicroDepositsMicrodepositGuidVerifyPut (string microdepositGuid, MicrodepositVerifyRequestBody? microdepositVerifyRequestBody = null)

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
    public class MicroDepositsMicrodepositGuidVerifyPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var microdepositGuid = "microdepositGuid_example";  // string | The unique identifier for the microdeposit. Defined by MX.
            var microdepositVerifyRequestBody = new MicrodepositVerifyRequestBody?(); // MicrodepositVerifyRequestBody? |  (optional) 

            try
            {
                // Verify a Microdeposit
                MicrodepositResponseBody result = apiInstance.MicroDepositsMicrodepositGuidVerifyPut(microdepositGuid, microdepositVerifyRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.MicroDepositsMicrodepositGuidVerifyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MicroDepositsMicrodepositGuidVerifyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify a Microdeposit
    ApiResponse<MicrodepositResponseBody> response = apiInstance.MicroDepositsMicrodepositGuidVerifyPutWithHttpInfo(microdepositGuid, microdepositVerifyRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.MicroDepositsMicrodepositGuidVerifyPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **microdepositGuid** | **string** | The unique identifier for the microdeposit. Defined by MX. |  |
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

<a id="usersuserguidmicrodepositsget"></a>
# **UsersUserGuidMicroDepositsGet**
> MicrodepositsResponseBody UsersUserGuidMicroDepositsGet (string userGuid)

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
    public class UsersUserGuidMicroDepositsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user. Defined by MX.

            try
            {
                // List all microdeposits for a user
                MicrodepositsResponseBody result = apiInstance.UsersUserGuidMicroDepositsGet(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.UsersUserGuidMicroDepositsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidMicroDepositsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all microdeposits for a user
    ApiResponse<MicrodepositsResponseBody> response = apiInstance.UsersUserGuidMicroDepositsGetWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.UsersUserGuidMicroDepositsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |

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

<a id="usersuserguidmicrodepositsmicrodepositguiddelete"></a>
# **UsersUserGuidMicroDepositsMicroDepositGuidDelete**
> void UsersUserGuidMicroDepositsMicroDepositGuidDelete (string microDepositGuid, string userGuid)

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
    public class UsersUserGuidMicroDepositsMicroDepositGuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var microDepositGuid = MIC-09ba578e-8448-4f7f-89e1-b62ff2517edb;  // string | The unique identifier for the microdeposit. Defined by MX.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete a microdeposit
                apiInstance.UsersUserGuidMicroDepositsMicroDepositGuidDelete(microDepositGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.UsersUserGuidMicroDepositsMicroDepositGuidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidMicroDepositsMicroDepositGuidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a microdeposit
    apiInstance.UsersUserGuidMicroDepositsMicroDepositGuidDeleteWithHttpInfo(microDepositGuid, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.UsersUserGuidMicroDepositsMicroDepositGuidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **microDepositGuid** | **string** | The unique identifier for the microdeposit. Defined by MX. |  |
| **userGuid** | **string** | The unique id for a &#x60;user&#x60;. |  |

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

<a id="usersuserguidmicrodepositsmicrodepositguidget"></a>
# **UsersUserGuidMicroDepositsMicroDepositGuidGet**
> MicrodepositResponseBody UsersUserGuidMicroDepositsMicroDepositGuidGet (string userGuid, string microDepositGuid)

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
    public class UsersUserGuidMicroDepositsMicroDepositGuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user. Defined by MX.
            var microDepositGuid = "microDepositGuid_example";  // string | The unique identifier for the microdeposit. Defined by MX.

            try
            {
                // Read a microdeposit for a user
                MicrodepositResponseBody result = apiInstance.UsersUserGuidMicroDepositsMicroDepositGuidGet(userGuid, microDepositGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.UsersUserGuidMicroDepositsMicroDepositGuidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidMicroDepositsMicroDepositGuidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a microdeposit for a user
    ApiResponse<MicrodepositResponseBody> response = apiInstance.UsersUserGuidMicroDepositsMicroDepositGuidGetWithHttpInfo(userGuid, microDepositGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.UsersUserGuidMicroDepositsMicroDepositGuidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
| **microDepositGuid** | **string** | The unique identifier for the microdeposit. Defined by MX. |  |

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

<a id="usersuserguidmicrodepositspost"></a>
# **UsersUserGuidMicroDepositsPost**
> MicrodepositResponseBody UsersUserGuidMicroDepositsPost (string userGuid, MicrodepositRequestBody microdepositRequestBody)

Create a microdeposit

Use this endpoint to create a microdeposit. The response will include the new microdeposit record with a status of INITIATED.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UsersUserGuidMicroDepositsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MicrodepositsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user. Defined by MX.
            var microdepositRequestBody = new MicrodepositRequestBody(); // MicrodepositRequestBody | 

            try
            {
                // Create a microdeposit
                MicrodepositResponseBody result = apiInstance.UsersUserGuidMicroDepositsPost(userGuid, microdepositRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrodepositsApi.UsersUserGuidMicroDepositsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidMicroDepositsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a microdeposit
    ApiResponse<MicrodepositResponseBody> response = apiInstance.UsersUserGuidMicroDepositsPostWithHttpInfo(userGuid, microdepositRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrodepositsApi.UsersUserGuidMicroDepositsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. Defined by MX. |  |
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

