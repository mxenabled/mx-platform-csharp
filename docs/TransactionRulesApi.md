# MX.Platform.CSharp.Api.TransactionRulesApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransactionRule**](TransactionRulesApi.md#createtransactionrule) | **POST** /users/{user_guid}/transaction_rules | Create transaction rule |
| [**ListTransactionRules**](TransactionRulesApi.md#listtransactionrules) | **GET** /users/{user_guid}/transaction_rules | List transaction rules |
| [**ReadTransactionRule**](TransactionRulesApi.md#readtransactionrule) | **GET** /users/{user_guid}/transaction_rules/{transaction_rule_guid} | Read transaction rule |
| [**UpdateTransactionRule**](TransactionRulesApi.md#updatetransactionrule) | **PUT** /users/{user_guid}/transaction_rules/{transaction_rule_guid} | Update transaction rule |

<a id="createtransactionrule"></a>
# **CreateTransactionRule**
> TransactionRuleResponseBody CreateTransactionRule (string userGuid, TransactionRuleCreateRequestBody transactionRuleCreateRequestBody)

Create transaction rule

Use this endpoint to create a new transaction rule. The newly-created `transaction_rule` object will be returned if successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateTransactionRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionRulesApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var transactionRuleCreateRequestBody = new TransactionRuleCreateRequestBody(); // TransactionRuleCreateRequestBody | TransactionRule object to be created with optional parameters (description) and required parameters (category_guid and match_description)

            try
            {
                // Create transaction rule
                TransactionRuleResponseBody result = apiInstance.CreateTransactionRule(userGuid, transactionRuleCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionRulesApi.CreateTransactionRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransactionRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create transaction rule
    ApiResponse<TransactionRuleResponseBody> response = apiInstance.CreateTransactionRuleWithHttpInfo(userGuid, transactionRuleCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionRulesApi.CreateTransactionRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **transactionRuleCreateRequestBody** | [**TransactionRuleCreateRequestBody**](TransactionRuleCreateRequestBody.md) | TransactionRule object to be created with optional parameters (description) and required parameters (category_guid and match_description) |  |

### Return type

[**TransactionRuleResponseBody**](TransactionRuleResponseBody.md)

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

<a id="listtransactionrules"></a>
# **ListTransactionRules**
> TransactionRulesResponseBody ListTransactionRules (string userGuid, int? page = null, int? recordsPerPage = null)

List transaction rules

Use this endpoint to read the attributes of all existing transaction rules belonging to the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTransactionRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionRulesApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List transaction rules
                TransactionRulesResponseBody result = apiInstance.ListTransactionRules(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionRulesApi.ListTransactionRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List transaction rules
    ApiResponse<TransactionRulesResponseBody> response = apiInstance.ListTransactionRulesWithHttpInfo(userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionRulesApi.ListTransactionRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**TransactionRulesResponseBody**](TransactionRulesResponseBody.md)

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

<a id="readtransactionrule"></a>
# **ReadTransactionRule**
> TransactionRuleResponseBody ReadTransactionRule (string transactionRuleGuid, string userGuid)

Read transaction rule

Use this endpoint to read the attributes of an existing transaction rule based on the rule’s unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadTransactionRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionRulesApi(config);
            var transactionRuleGuid = TXR-a080e0f9-a2d4-4d6f-9e03-672cc357a4d3;  // string | The unique id for a `transaction_rule`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read transaction rule
                TransactionRuleResponseBody result = apiInstance.ReadTransactionRule(transactionRuleGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionRulesApi.ReadTransactionRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadTransactionRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read transaction rule
    ApiResponse<TransactionRuleResponseBody> response = apiInstance.ReadTransactionRuleWithHttpInfo(transactionRuleGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionRulesApi.ReadTransactionRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionRuleGuid** | **string** | The unique id for a &#x60;transaction_rule&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**TransactionRuleResponseBody**](TransactionRuleResponseBody.md)

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

<a id="updatetransactionrule"></a>
# **UpdateTransactionRule**
> TransactionRuleResponseBody UpdateTransactionRule (string transactionRuleGuid, string userGuid, TransactionRuleUpdateRequestBody transactionRuleUpdateRequestBody)

Update transaction rule

Use this endpoint to update the attributes of a specific transaction rule based on its unique GUID. The API will respond with the updated transaction_rule object. Any attributes not provided will be left unchanged.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateTransactionRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionRulesApi(config);
            var transactionRuleGuid = TXR-a080e0f9-a2d4-4d6f-9e03-672cc357a4d3;  // string | The unique id for a `transaction_rule`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var transactionRuleUpdateRequestBody = new TransactionRuleUpdateRequestBody(); // TransactionRuleUpdateRequestBody | TransactionRule object to be updated

            try
            {
                // Update transaction rule
                TransactionRuleResponseBody result = apiInstance.UpdateTransactionRule(transactionRuleGuid, userGuid, transactionRuleUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionRulesApi.UpdateTransactionRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update transaction rule
    ApiResponse<TransactionRuleResponseBody> response = apiInstance.UpdateTransactionRuleWithHttpInfo(transactionRuleGuid, userGuid, transactionRuleUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionRulesApi.UpdateTransactionRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionRuleGuid** | **string** | The unique id for a &#x60;transaction_rule&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **transactionRuleUpdateRequestBody** | [**TransactionRuleUpdateRequestBody**](TransactionRuleUpdateRequestBody.md) | TransactionRule object to be updated |  |

### Return type

[**TransactionRuleResponseBody**](TransactionRuleResponseBody.md)

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

