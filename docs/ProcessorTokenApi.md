# MX.Platform.CSharp.Api.ProcessorTokenApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckRealTimeAccountBalance**](ProcessorTokenApi.md#checkrealtimeaccountbalance) | **POST** /account/check_balance | Check Real Time Account Balance (Processors Only) |
| [**DeprecatedRequestPaymentProcessorAuthorizationCode**](ProcessorTokenApi.md#deprecatedrequestpaymentprocessorauthorizationcode) | **POST** /payment_processor_authorization_code | (Deprecated) Request an authorization code |
| [**GetAccountOwnerInfo**](ProcessorTokenApi.md#getaccountownerinfo) | **GET** /account/transactions | Get account owner information (Processors Only) |
| [**ListTokens**](ProcessorTokenApi.md#listtokens) | **GET** /tokens | View a List of Tokens |
| [**ReadAccountBalance**](ProcessorTokenApi.md#readaccountbalance) | **GET** /payment_account | Read the account balance (Processors Only) |
| [**RequestAccountNumber**](ProcessorTokenApi.md#requestaccountnumber) | **GET** /account/account_numbers | Request an account number (Processors Only) |
| [**RequestAuthorizationCode**](ProcessorTokenApi.md#requestauthorizationcode) | **POST** /authorization_code | Request an authorization code |

<a id="checkrealtimeaccountbalance"></a>
# **CheckRealTimeAccountBalance**
> MemberResponseBody CheckRealTimeAccountBalance ()

Check Real Time Account Balance (Processors Only)

Check the real-time account balance using your access token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CheckRealTimeAccountBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProcessorTokenApi(config);

            try
            {
                // Check Real Time Account Balance (Processors Only)
                MemberResponseBody result = apiInstance.CheckRealTimeAccountBalance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessorTokenApi.CheckRealTimeAccountBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckRealTimeAccountBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Real Time Account Balance (Processors Only)
    ApiResponse<MemberResponseBody> response = apiInstance.CheckRealTimeAccountBalanceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessorTokenApi.CheckRealTimeAccountBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MemberResponseBody**](MemberResponseBody.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deprecatedrequestpaymentprocessorauthorizationcode"></a>
# **DeprecatedRequestPaymentProcessorAuthorizationCode**
> PaymentProcessorAuthorizationCodeResponseBody DeprecatedRequestPaymentProcessorAuthorizationCode (PaymentProcessorAuthorizationCodeRequestBody paymentProcessorAuthorizationCodeRequestBody)

(Deprecated) Request an authorization code

(This endpoint is deprecated. Clients should use `/authorization_code`.) Clients use this endpoint to request an authorization_code according to a user, member, and account specified in the request body. Clients then pass this code to processors. Processor access is scoped only to the user/member/account specified in this request. Before requesting an authorization_code, clients must have verified the specified member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeprecatedRequestPaymentProcessorAuthorizationCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessorTokenApi(config);
            var paymentProcessorAuthorizationCodeRequestBody = new PaymentProcessorAuthorizationCodeRequestBody(); // PaymentProcessorAuthorizationCodeRequestBody | The scope for the authorization code.

            try
            {
                // (Deprecated) Request an authorization code
                PaymentProcessorAuthorizationCodeResponseBody result = apiInstance.DeprecatedRequestPaymentProcessorAuthorizationCode(paymentProcessorAuthorizationCodeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessorTokenApi.DeprecatedRequestPaymentProcessorAuthorizationCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeprecatedRequestPaymentProcessorAuthorizationCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // (Deprecated) Request an authorization code
    ApiResponse<PaymentProcessorAuthorizationCodeResponseBody> response = apiInstance.DeprecatedRequestPaymentProcessorAuthorizationCodeWithHttpInfo(paymentProcessorAuthorizationCodeRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessorTokenApi.DeprecatedRequestPaymentProcessorAuthorizationCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentProcessorAuthorizationCodeRequestBody** | [**PaymentProcessorAuthorizationCodeRequestBody**](PaymentProcessorAuthorizationCodeRequestBody.md) | The scope for the authorization code. |  |

### Return type

[**PaymentProcessorAuthorizationCodeResponseBody**](PaymentProcessorAuthorizationCodeResponseBody.md)

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

<a id="getaccountownerinfo"></a>
# **GetAccountOwnerInfo**
> ProcessorOwnerBody GetAccountOwnerInfo ()

Get account owner information (Processors Only)

Get account owner information (Processors Only)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class GetAccountOwnerInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProcessorTokenApi(config);

            try
            {
                // Get account owner information (Processors Only)
                ProcessorOwnerBody result = apiInstance.GetAccountOwnerInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessorTokenApi.GetAccountOwnerInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountOwnerInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account owner information (Processors Only)
    ApiResponse<ProcessorOwnerBody> response = apiInstance.GetAccountOwnerInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessorTokenApi.GetAccountOwnerInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ProcessorOwnerBody**](ProcessorOwnerBody.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtokens"></a>
# **ListTokens**
> TokenResponseBody ListTokens (TokenRequestBody? tokenRequestBody = null)

View a List of Tokens

View a list of tokens that exist for a user, member, or account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessorTokenApi(config);
            var tokenRequestBody = new TokenRequestBody?(); // TokenRequestBody? |  (optional) 

            try
            {
                // View a List of Tokens
                TokenResponseBody result = apiInstance.ListTokens(tokenRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessorTokenApi.ListTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // View a List of Tokens
    ApiResponse<TokenResponseBody> response = apiInstance.ListTokensWithHttpInfo(tokenRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessorTokenApi.ListTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenRequestBody** | [**TokenRequestBody?**](TokenRequestBody?.md) |  | [optional]  |

### Return type

[**TokenResponseBody**](TokenResponseBody.md)

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

<a id="readaccountbalance"></a>
# **ReadAccountBalance**
> PaymentAccountBody ReadAccountBalance ()

Read the account balance (Processors Only)

Read the account balance (Processors Only)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadAccountBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProcessorTokenApi(config);

            try
            {
                // Read the account balance (Processors Only)
                PaymentAccountBody result = apiInstance.ReadAccountBalance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessorTokenApi.ReadAccountBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadAccountBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read the account balance (Processors Only)
    ApiResponse<PaymentAccountBody> response = apiInstance.ReadAccountBalanceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessorTokenApi.ReadAccountBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PaymentAccountBody**](PaymentAccountBody.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="requestaccountnumber"></a>
# **RequestAccountNumber**
> ProcessorAccountNumberBody RequestAccountNumber ()

Request an account number (Processors Only)

Get account information such as routing number and account number, scoped to your access token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class RequestAccountNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProcessorTokenApi(config);

            try
            {
                // Request an account number (Processors Only)
                ProcessorAccountNumberBody result = apiInstance.RequestAccountNumber();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessorTokenApi.RequestAccountNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestAccountNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request an account number (Processors Only)
    ApiResponse<ProcessorAccountNumberBody> response = apiInstance.RequestAccountNumberWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessorTokenApi.RequestAccountNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ProcessorAccountNumberBody**](ProcessorAccountNumberBody.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="requestauthorizationcode"></a>
# **RequestAuthorizationCode**
> AuthorizationCodeResponseBody RequestAuthorizationCode (AuthorizationCodeRequestBody authorizationCodeRequestBody)

Request an authorization code

Clients use this endpoint to request an authorization code according to the parameters specified in the scope. Clients then pass this code to processors. Processor access is scoped only to the GUIDs and features specified in this request. Before requesting an authorization code which includes a member in the scope, clients must have verified that member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class RequestAuthorizationCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ProcessorTokenApi(config);
            var authorizationCodeRequestBody = new AuthorizationCodeRequestBody(); // AuthorizationCodeRequestBody | The scope for the authorization code.

            try
            {
                // Request an authorization code
                AuthorizationCodeResponseBody result = apiInstance.RequestAuthorizationCode(authorizationCodeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProcessorTokenApi.RequestAuthorizationCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestAuthorizationCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request an authorization code
    ApiResponse<AuthorizationCodeResponseBody> response = apiInstance.RequestAuthorizationCodeWithHttpInfo(authorizationCodeRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProcessorTokenApi.RequestAuthorizationCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorizationCodeRequestBody** | [**AuthorizationCodeRequestBody**](AuthorizationCodeRequestBody.md) | The scope for the authorization code. |  |

### Return type

[**AuthorizationCodeResponseBody**](AuthorizationCodeResponseBody.md)

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

