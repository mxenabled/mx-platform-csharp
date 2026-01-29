# MX.Platform.CSharp.Api.TransactionsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateManualTransaction**](TransactionsApi.md#createmanualtransaction) | **POST** /users/{user_guid}/accounts/{account_guid}/transactions | Create manual transaction |
| [**CreateSplitTransactions**](TransactionsApi.md#createsplittransactions) | **POST** /users/{user_guid}/transactions/{transaction_guid}/split | Create split transactions |
| [**DeleteManualTransactions**](TransactionsApi.md#deletemanualtransactions) | **DELETE** /users/{user_guid}/transactions/{transaction_guid} | Delete manual transactions |
| [**DeleteSplitTransactions**](TransactionsApi.md#deletesplittransactions) | **DELETE** /users/{user_guid}/transactions/{transaction_guid}/split | Delete split transactions |
| [**DeleteTransactionRule**](TransactionsApi.md#deletetransactionrule) | **DELETE** /users/{user_guid}/transaction_rules/{transaction_rule_guid} | Delete transaction rule |
| [**EnhanceTransactions**](TransactionsApi.md#enhancetransactions) | **POST** /transactions/enhance | Enhance transactions |
| [**ExtendHistory**](TransactionsApi.md#extendhistory) | **POST** /users/{user_guid}/members/{member_guid}/extend_history | Extend history |
| [**ListTransactions**](TransactionsApi.md#listtransactions) | **GET** /users/{user_guid}/transactions | List transactions |
| [**ListTransactionsByAccount**](TransactionsApi.md#listtransactionsbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/transactions | List transactions by account |
| [**ListTransactionsByMember**](TransactionsApi.md#listtransactionsbymember) | **GET** /users/{user_guid}/members/{member_guid}/transactions | List transactions by member |
| [**ListTransactionsByTag**](TransactionsApi.md#listtransactionsbytag) | **GET** /users/{user_guid}/tags/{tag_guid}/transactions | List transactions by tag |
| [**ReadTransaction**](TransactionsApi.md#readtransaction) | **GET** /users/{user_guid}/transactions/{transaction_guid} | Read transaction |
| [**RepeatingTransactions**](TransactionsApi.md#repeatingtransactions) | **GET** /users/{user_guid}/repeating_transactions | List Repeating Transactions |
| [**SpecificRepeatingTransaction**](TransactionsApi.md#specificrepeatingtransaction) | **GET** /users/{user_guid}/repeating_transactions/{repeating_transaction_guid} | Get a Repeating Transaction |
| [**UpdateTransaction**](TransactionsApi.md#updatetransaction) | **PUT** /users/{user_guid}/transactions/{transaction_guid} | Update transaction |
| [**UpdateTransactionByAccount**](TransactionsApi.md#updatetransactionbyaccount) | **PUT** /users/{user_guid}/members/{member_guid}/accounts/{account_guid}/transactions/{transaction_guid} | Update Transaction by Account |

<a id="createmanualtransaction"></a>
# **CreateManualTransaction**
> TransactionCreateResponseBody CreateManualTransaction (string userGuid, string accountGuid, TransactionCreateRequestBody transactionCreateRequestBody)

Create manual transaction

This endpoint can only be used to create manual transactions that are under a manual account. This endpoint accepts the optional MX-Skip-Webhook header and skip_webhook parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateManualTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var transactionCreateRequestBody = new TransactionCreateRequestBody(); // TransactionCreateRequestBody | 

            try
            {
                // Create manual transaction
                TransactionCreateResponseBody result = apiInstance.CreateManualTransaction(userGuid, accountGuid, transactionCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateManualTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManualTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create manual transaction
    ApiResponse<TransactionCreateResponseBody> response = apiInstance.CreateManualTransactionWithHttpInfo(userGuid, accountGuid, transactionCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateManualTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **transactionCreateRequestBody** | [**TransactionCreateRequestBody**](TransactionCreateRequestBody.md) |  |  |

### Return type

[**TransactionCreateResponseBody**](TransactionCreateResponseBody.md)

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

<a id="createsplittransactions"></a>
# **CreateSplitTransactions**
> SplitTransactionsResponseBody CreateSplitTransactions (string transactionGuid, string userGuid, SplitTransactionRequestBody? splitTransactionRequestBody = null)

Create split transactions

This endpoint creates two or more child transactions that are branched from a previous transaction. This endpoint allows you to link multiple categories, descriptions, and amounts to a parent transaction.  When a split transaction is created, the parent transaction's `has_been_split` field will automatically be updated to true and the child transactions' `parent_guid` will have the transaction guid of the parent. The total amount of the child transactions must equal the amount of the parent transaction. Once a transaction has been split it can't be split again.    In order to re-split a transaction, it must first be un-split. This can be done by calling the Delete Split Transactions endpoint. Calling this endpoint will delete the existing child transactions and update the parent transaction's `has_been_split` field to false. You can then re-split the parent transaction by calling Create Split Transaction again. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateSplitTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var splitTransactionRequestBody = new SplitTransactionRequestBody?(); // SplitTransactionRequestBody? |  (optional) 

            try
            {
                // Create split transactions
                SplitTransactionsResponseBody result = apiInstance.CreateSplitTransactions(transactionGuid, userGuid, splitTransactionRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateSplitTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSplitTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create split transactions
    ApiResponse<SplitTransactionsResponseBody> response = apiInstance.CreateSplitTransactionsWithHttpInfo(transactionGuid, userGuid, splitTransactionRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateSplitTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionGuid** | **string** | The unique id for a &#x60;transaction&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **splitTransactionRequestBody** | [**SplitTransactionRequestBody?**](SplitTransactionRequestBody?.md) |  | [optional]  |

### Return type

[**SplitTransactionsResponseBody**](SplitTransactionsResponseBody.md)

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

<a id="deletemanualtransactions"></a>
# **DeleteManualTransactions**
> void DeleteManualTransactions (string userGuid, string transactionGuid)

Delete manual transactions

Delete a manual transaction. In the path, use the manual transaction guid as the `transaction_guid`, such as `MAN-810828b0-5210-4878-9bd3-f4ce514f90c4`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteManualTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.

            try
            {
                // Delete manual transactions
                apiInstance.DeleteManualTransactions(userGuid, transactionGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteManualTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteManualTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete manual transactions
    apiInstance.DeleteManualTransactionsWithHttpInfo(userGuid, transactionGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.DeleteManualTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **transactionGuid** | **string** | The unique id for a &#x60;transaction&#x60;. |  |

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

<a id="deletesplittransactions"></a>
# **DeleteSplitTransactions**
> void DeleteSplitTransactions (string transactionGuid, string userGuid)

Delete split transactions

This endpoint deletes all split transactions linked to a parent transaction, but it leaves the parent transaction active. This request will also update the parent transaction's has_been_split field to false. This endpoint accepts the optional MX-Skip-Webhook header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteSplitTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Delete split transactions
                apiInstance.DeleteSplitTransactions(transactionGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteSplitTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSplitTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete split transactions
    apiInstance.DeleteSplitTransactionsWithHttpInfo(transactionGuid, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.DeleteSplitTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionGuid** | **string** | The unique id for a &#x60;transaction&#x60;. |  |
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
| **204** | No content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetransactionrule"></a>
# **DeleteTransactionRule**
> void DeleteTransactionRule (string transactionRuleGuid, string userGuid)

Delete transaction rule

Use this endpoint to permanently delete a transaction rule based on its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteTransactionRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var transactionRuleGuid = TXR-a080e0f9-a2d4-4d6f-9e03-672cc357a4d3;  // string | The unique id for a `transaction_rule`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Delete transaction rule
                apiInstance.DeleteTransactionRule(transactionRuleGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteTransactionRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete transaction rule
    apiInstance.DeleteTransactionRuleWithHttpInfo(transactionRuleGuid, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.DeleteTransactionRuleWithHttpInfo: " + e.Message);
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

<a id="enhancetransactions"></a>
# **EnhanceTransactions**
> EnhanceTransactionsResponseBody EnhanceTransactions (EnhanceTransactionsRequestBody enhanceTransactionsRequestBody)

Enhance transactions

Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform. <br /><br />For more information on returned data, please see the [Enhanced Transactions fields guide](/api-reference/platform-api/reference/transactions-overview#enhanced-transactions).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class EnhanceTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var enhanceTransactionsRequestBody = new EnhanceTransactionsRequestBody(); // EnhanceTransactionsRequestBody | Transaction object to be enhanced

            try
            {
                // Enhance transactions
                EnhanceTransactionsResponseBody result = apiInstance.EnhanceTransactions(enhanceTransactionsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.EnhanceTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnhanceTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enhance transactions
    ApiResponse<EnhanceTransactionsResponseBody> response = apiInstance.EnhanceTransactionsWithHttpInfo(enhanceTransactionsRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.EnhanceTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enhanceTransactionsRequestBody** | [**EnhanceTransactionsRequestBody**](EnhanceTransactionsRequestBody.md) | Transaction object to be enhanced |  |

### Return type

[**EnhanceTransactionsResponseBody**](EnhanceTransactionsResponseBody.md)

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

<a id="extendhistory"></a>
# **ExtendHistory**
> MemberResponseBody ExtendHistory (string memberGuid, string userGuid)

Extend history

Some institutions allow developers to access an extended transaction history with up to 24 months of data associated with a particular member. The process for fetching and then reading this extended transaction history is much like standard aggregation, and it may trigger multi-factor authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ExtendHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Extend history
                MemberResponseBody result = apiInstance.ExtendHistory(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ExtendHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExtendHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extend history
    ApiResponse<MemberResponseBody> response = apiInstance.ExtendHistoryWithHttpInfo(memberGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.ExtendHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**MemberResponseBody**](MemberResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.mx.api.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtransactions"></a>
# **ListTransactions**
> TransactionsResponseBodyIncludes ListTransactions (string userGuid, int? page = null, int? recordsPerPage = null, string? fromDate = null, string? toDate = null, string? fromCreatedAt = null, string? toCreatedAt = null, string? fromUpdatedAt = null, string? toUpdatedAt = null, string? categoryGuid = null, List<string>? categoryGuid2 = null, string? topLevelCategoryGuid = null, List<string>? topLevelCategoryGuid2 = null, string? useCase = null, string? includes = null)

List transactions

Requests to this endpoint return a list of transactions associated with the specified `user`, across all members and accounts associated with that `user`. <br /><br />Enhanced transaction data may be requested using the `includes` parameter. To use this optional parameter, the value should include the optional metadata requested such as `repeating_transactions`, `merchants`, `classifications`, `geolocations`. For more information, see the [Optional Enhancement Query Parameter guide](/api-reference/platform-api/reference/transactions-overview#enhanced-transactions#optional-enhancement-query-parameter).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 
            var fromDate = 2024-01-01;  // string? | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. (optional) 
            var toDate = 2024-03-31;  // string? | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. (optional) 
            var fromCreatedAt = 2024-01-01;  // string? | Filter transactions from the date the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var toCreatedAt = 2024-03-31;  // string? | Filter transaction to the date in which the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var fromUpdatedAt = 2024-01-01;  // string? | Filter transactions from the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var toUpdatedAt = 2024-03-31;  // string? | Filter transactions to the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var categoryGuid = "categoryGuid_example";  // string? | Filter transactions belonging to specified `category_guid`.  For example, `?category_guid=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var categoryGuid2 = new List<string>?(); // List<string>? | Filter transactions belonging to any specified `category_guid[]` in url.  For example, `?category_guid[]=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var topLevelCategoryGuid = "topLevelCategoryGuid_example";  // string? | Filter transactions belonging to specified `top_level_category_guid`. This must be top level category guid, use `category_guid` for subcategory guid.  For example, `?top_level_category_guid=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var topLevelCategoryGuid2 = new List<string>?(); // List<string>? | Filter transactions belonging to any specified `top_level_category_guid[]` in url. This must be top level category guid(s), use `category_guid` for subcategory guid(s).  For example, `?top_level_category_guid[]=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var useCase = MONEY_MOVEMENT;  // string? | The use case associated with the member. Valid values are `PFM` and `MONEY_MOVEMENT`. For example, you can append either `?use_case=PFM` or `?use_case=MONEY_MOVEMENT`. (optional) 
            var includes = repeating_transactions,merchants,classifications,geolocations;  // string? | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: `repeating_transactions`, `merchants`, `classifications`, `geolocations`. The query value is format sensitive. To retrieve all available enhancements, append:  `?includes=repeating_transactions,merchants,classifications,geolocations`.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   `?includes=repeating_transactions,geolocations`.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  (optional) 

            try
            {
                // List transactions
                TransactionsResponseBodyIncludes result = apiInstance.ListTransactions(userGuid, page, recordsPerPage, fromDate, toDate, fromCreatedAt, toCreatedAt, fromUpdatedAt, toUpdatedAt, categoryGuid, categoryGuid2, topLevelCategoryGuid, topLevelCategoryGuid2, useCase, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List transactions
    ApiResponse<TransactionsResponseBodyIncludes> response = apiInstance.ListTransactionsWithHttpInfo(userGuid, page, recordsPerPage, fromDate, toDate, fromCreatedAt, toCreatedAt, fromUpdatedAt, toUpdatedAt, categoryGuid, categoryGuid2, topLevelCategoryGuid, topLevelCategoryGuid2, useCase, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.ListTransactionsWithHttpInfo: " + e.Message);
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
| **fromDate** | **string?** | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. | [optional]  |
| **toDate** | **string?** | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. | [optional]  |
| **fromCreatedAt** | **string?** | Filter transactions from the date the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **toCreatedAt** | **string?** | Filter transaction to the date in which the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **fromUpdatedAt** | **string?** | Filter transactions from the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **toUpdatedAt** | **string?** | Filter transactions to the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **categoryGuid** | **string?** | Filter transactions belonging to specified &#x60;category_guid&#x60;.  For example, &#x60;?category_guid&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **categoryGuid2** | [**List&lt;string&gt;?**](string.md) | Filter transactions belonging to any specified &#x60;category_guid[]&#x60; in url.  For example, &#x60;?category_guid[]&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **topLevelCategoryGuid** | **string?** | Filter transactions belonging to specified &#x60;top_level_category_guid&#x60;. This must be top level category guid, use &#x60;category_guid&#x60; for subcategory guid.  For example, &#x60;?top_level_category_guid&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **topLevelCategoryGuid2** | [**List&lt;string&gt;?**](string.md) | Filter transactions belonging to any specified &#x60;top_level_category_guid[]&#x60; in url. This must be top level category guid(s), use &#x60;category_guid&#x60; for subcategory guid(s).  For example, &#x60;?top_level_category_guid[]&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **useCase** | **string?** | The use case associated with the member. Valid values are &#x60;PFM&#x60; and &#x60;MONEY_MOVEMENT&#x60;. For example, you can append either &#x60;?use_case&#x3D;PFM&#x60; or &#x60;?use_case&#x3D;MONEY_MOVEMENT&#x60;. | [optional]  |
| **includes** | **string?** | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: &#x60;repeating_transactions&#x60;, &#x60;merchants&#x60;, &#x60;classifications&#x60;, &#x60;geolocations&#x60;. The query value is format sensitive. To retrieve all available enhancements, append:  &#x60;?includes&#x3D;repeating_transactions,merchants,classifications,geolocations&#x60;.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   &#x60;?includes&#x3D;repeating_transactions,geolocations&#x60;.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  | [optional]  |

### Return type

[**TransactionsResponseBodyIncludes**](TransactionsResponseBodyIncludes.md)

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

<a id="listtransactionsbyaccount"></a>
# **ListTransactionsByAccount**
> TransactionsResponseBodyIncludes ListTransactionsByAccount (string accountGuid, string userGuid, int? page = null, int? recordsPerPage = null, string? fromDate = null, string? toDate = null, string? fromCreatedAt = null, string? toCreatedAt = null, string? fromUpdatedAt = null, string? toUpdatedAt = null, string? categoryGuid = null, List<string>? categoryGuid2 = null, string? topLevelCategoryGuid = null, List<string>? topLevelCategoryGuid2 = null, string? includes = null)

List transactions by account

Requests to this endpoint return a list of transactions associated with the specified account. <br /><br /> Enhanced transaction data may be requested using the `includes` parameter. To use this optional parameter, the value should include the optional metadata requested such as `repeating_transactions`, `merchants`, `classifications`, `geolocations`. For more information, see the [Optional Enhancement Query Parameter guide](/api-reference/platform-api/reference/transactions-overview#enhanced-transactions#optional-enhancement-query-parameter).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTransactionsByAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 
            var fromDate = 2024-01-01;  // string? | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. (optional) 
            var toDate = 2024-03-31;  // string? | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. (optional) 
            var fromCreatedAt = 2024-01-01;  // string? | Filter transactions from the date the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var toCreatedAt = 2024-03-31;  // string? | Filter transaction to the date in which the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var fromUpdatedAt = 2024-01-01;  // string? | Filter transactions from the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var toUpdatedAt = 2024-03-31;  // string? | Filter transactions to the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var categoryGuid = "categoryGuid_example";  // string? | Filter transactions belonging to specified `category_guid`.  For example, `?category_guid=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var categoryGuid2 = new List<string>?(); // List<string>? | Filter transactions belonging to any specified `category_guid[]` in url.  For example, `?category_guid[]=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var topLevelCategoryGuid = "topLevelCategoryGuid_example";  // string? | Filter transactions belonging to specified `top_level_category_guid`. This must be top level category guid, use `category_guid` for subcategory guid.  For example, `?top_level_category_guid=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var topLevelCategoryGuid2 = new List<string>?(); // List<string>? | Filter transactions belonging to any specified `top_level_category_guid[]` in url. This must be top level category guid(s), use `category_guid` for subcategory guid(s).  For example, `?top_level_category_guid[]=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var includes = repeating_transactions,merchants,classifications,geolocations;  // string? | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: `repeating_transactions`, `merchants`, `classifications`, `geolocations`. The query value is format sensitive. To retrieve all available enhancements, append:  `?includes=repeating_transactions,merchants,classifications,geolocations`.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   `?includes=repeating_transactions,geolocations`.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  (optional) 

            try
            {
                // List transactions by account
                TransactionsResponseBodyIncludes result = apiInstance.ListTransactionsByAccount(accountGuid, userGuid, page, recordsPerPage, fromDate, toDate, fromCreatedAt, toCreatedAt, fromUpdatedAt, toUpdatedAt, categoryGuid, categoryGuid2, topLevelCategoryGuid, topLevelCategoryGuid2, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListTransactionsByAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionsByAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List transactions by account
    ApiResponse<TransactionsResponseBodyIncludes> response = apiInstance.ListTransactionsByAccountWithHttpInfo(accountGuid, userGuid, page, recordsPerPage, fromDate, toDate, fromCreatedAt, toCreatedAt, fromUpdatedAt, toUpdatedAt, categoryGuid, categoryGuid2, topLevelCategoryGuid, topLevelCategoryGuid2, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.ListTransactionsByAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |
| **fromDate** | **string?** | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. | [optional]  |
| **toDate** | **string?** | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. | [optional]  |
| **fromCreatedAt** | **string?** | Filter transactions from the date the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **toCreatedAt** | **string?** | Filter transaction to the date in which the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **fromUpdatedAt** | **string?** | Filter transactions from the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **toUpdatedAt** | **string?** | Filter transactions to the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **categoryGuid** | **string?** | Filter transactions belonging to specified &#x60;category_guid&#x60;.  For example, &#x60;?category_guid&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **categoryGuid2** | [**List&lt;string&gt;?**](string.md) | Filter transactions belonging to any specified &#x60;category_guid[]&#x60; in url.  For example, &#x60;?category_guid[]&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **topLevelCategoryGuid** | **string?** | Filter transactions belonging to specified &#x60;top_level_category_guid&#x60;. This must be top level category guid, use &#x60;category_guid&#x60; for subcategory guid.  For example, &#x60;?top_level_category_guid&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **topLevelCategoryGuid2** | [**List&lt;string&gt;?**](string.md) | Filter transactions belonging to any specified &#x60;top_level_category_guid[]&#x60; in url. This must be top level category guid(s), use &#x60;category_guid&#x60; for subcategory guid(s).  For example, &#x60;?top_level_category_guid[]&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **includes** | **string?** | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: &#x60;repeating_transactions&#x60;, &#x60;merchants&#x60;, &#x60;classifications&#x60;, &#x60;geolocations&#x60;. The query value is format sensitive. To retrieve all available enhancements, append:  &#x60;?includes&#x3D;repeating_transactions,merchants,classifications,geolocations&#x60;.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   &#x60;?includes&#x3D;repeating_transactions,geolocations&#x60;.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  | [optional]  |

### Return type

[**TransactionsResponseBodyIncludes**](TransactionsResponseBodyIncludes.md)

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

<a id="listtransactionsbymember"></a>
# **ListTransactionsByMember**
> TransactionsResponseBodyIncludes ListTransactionsByMember (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null, string? fromDate = null, string? toDate = null, string? fromCreatedAt = null, string? toCreatedAt = null, string? fromUpdatedAt = null, string? toUpdatedAt = null, string? categoryGuid = null, List<string>? categoryGuid2 = null, string? topLevelCategoryGuid = null, List<string>? topLevelCategoryGuid2 = null, string? includes = null)

List transactions by member

Requests to this endpoint return a list of transactions associated with the specified `member`, across all accounts associated with that `member`. <br /><br />Enhanced transaction data may be requested using the `includes` parameter. To use this optional parameter, the value should include the optional metadata requested such as `repeating_transactions`, `merchants`, `classifications`, `geolocations`. For more information, see the [Optional Enhancement Query Parameter guide](/api-reference/platform-api/reference/transactions-overview#enhanced-transactions#optional-enhancement-query-parameter).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTransactionsByMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 
            var fromDate = 2024-01-01;  // string? | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. (optional) 
            var toDate = 2024-03-31;  // string? | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. (optional) 
            var fromCreatedAt = 2024-01-01;  // string? | Filter transactions from the date the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var toCreatedAt = 2024-03-31;  // string? | Filter transaction to the date in which the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var fromUpdatedAt = 2024-01-01;  // string? | Filter transactions from the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var toUpdatedAt = 2024-03-31;  // string? | Filter transactions to the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var categoryGuid = "categoryGuid_example";  // string? | Filter transactions belonging to specified `category_guid`.  For example, `?category_guid=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var categoryGuid2 = new List<string>?(); // List<string>? | Filter transactions belonging to any specified `category_guid[]` in url.  For example, `?category_guid[]=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var topLevelCategoryGuid = "topLevelCategoryGuid_example";  // string? | Filter transactions belonging to specified `top_level_category_guid`. This must be top level category guid, use `category_guid` for subcategory guid.  For example, `?top_level_category_guid=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var topLevelCategoryGuid2 = new List<string>?(); // List<string>? | Filter transactions belonging to any specified `top_level_category_guid[]` in url. This must be top level category guid(s), use `category_guid` for subcategory guid(s).  For example, `?top_level_category_guid[]=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var includes = repeating_transactions,merchants,classifications,geolocations;  // string? | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: `repeating_transactions`, `merchants`, `classifications`, `geolocations`. The query value is format sensitive. To retrieve all available enhancements, append:  `?includes=repeating_transactions,merchants,classifications,geolocations`.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   `?includes=repeating_transactions,geolocations`.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  (optional) 

            try
            {
                // List transactions by member
                TransactionsResponseBodyIncludes result = apiInstance.ListTransactionsByMember(memberGuid, userGuid, page, recordsPerPage, fromDate, toDate, fromCreatedAt, toCreatedAt, fromUpdatedAt, toUpdatedAt, categoryGuid, categoryGuid2, topLevelCategoryGuid, topLevelCategoryGuid2, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListTransactionsByMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionsByMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List transactions by member
    ApiResponse<TransactionsResponseBodyIncludes> response = apiInstance.ListTransactionsByMemberWithHttpInfo(memberGuid, userGuid, page, recordsPerPage, fromDate, toDate, fromCreatedAt, toCreatedAt, fromUpdatedAt, toUpdatedAt, categoryGuid, categoryGuid2, topLevelCategoryGuid, topLevelCategoryGuid2, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.ListTransactionsByMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |
| **fromDate** | **string?** | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. | [optional]  |
| **toDate** | **string?** | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. | [optional]  |
| **fromCreatedAt** | **string?** | Filter transactions from the date the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **toCreatedAt** | **string?** | Filter transaction to the date in which the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **fromUpdatedAt** | **string?** | Filter transactions from the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **toUpdatedAt** | **string?** | Filter transactions to the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **categoryGuid** | **string?** | Filter transactions belonging to specified &#x60;category_guid&#x60;.  For example, &#x60;?category_guid&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **categoryGuid2** | [**List&lt;string&gt;?**](string.md) | Filter transactions belonging to any specified &#x60;category_guid[]&#x60; in url.  For example, &#x60;?category_guid[]&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **topLevelCategoryGuid** | **string?** | Filter transactions belonging to specified &#x60;top_level_category_guid&#x60;. This must be top level category guid, use &#x60;category_guid&#x60; for subcategory guid.  For example, &#x60;?top_level_category_guid&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **topLevelCategoryGuid2** | [**List&lt;string&gt;?**](string.md) | Filter transactions belonging to any specified &#x60;top_level_category_guid[]&#x60; in url. This must be top level category guid(s), use &#x60;category_guid&#x60; for subcategory guid(s).  For example, &#x60;?top_level_category_guid[]&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **includes** | **string?** | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: &#x60;repeating_transactions&#x60;, &#x60;merchants&#x60;, &#x60;classifications&#x60;, &#x60;geolocations&#x60;. The query value is format sensitive. To retrieve all available enhancements, append:  &#x60;?includes&#x3D;repeating_transactions,merchants,classifications,geolocations&#x60;.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   &#x60;?includes&#x3D;repeating_transactions,geolocations&#x60;.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  | [optional]  |

### Return type

[**TransactionsResponseBodyIncludes**](TransactionsResponseBodyIncludes.md)

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

<a id="listtransactionsbytag"></a>
# **ListTransactionsByTag**
> TransactionsResponseBodyIncludes ListTransactionsByTag (string userGuid, string tagGuid, int? page = null, int? recordsPerPage = null, string? fromDate = null, string? toDate = null, string? fromCreatedAt = null, string? toCreatedAt = null, string? fromUpdatedAt = null, string? toUpdatedAt = null, string? categoryGuid = null, List<string>? categoryGuid2 = null, string? topLevelCategoryGuid = null, List<string>? topLevelCategoryGuid2 = null, string? useCase = null, string? includes = null)

List transactions by tag

Use this endpoint to get a list of all transactions associated with a particular tag according to the tag's unique GUID. This lists all transactions that have been assigned to a particular tag using the create tagging endpoint. <br /><br />Enhanced transaction data may be requested using the `includes` parameter. To use this optional parameter, the value should include the optional metadata requested such as `repeating_transactions`, `merchants`, `classifications`, `geolocations`. For more information, see the [Optional Enhancement Query Parameter guide](/api-reference/platform-api/reference/transactions-overview#enhanced-transactions#optional-enhancement-query-parameter).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTransactionsByTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var tagGuid = TAG-aef36e72-6294-4c38-844d-e573e80aed52;  // string | The unique id for a `tag`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 
            var fromDate = 2024-01-01;  // string? | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. (optional) 
            var toDate = 2024-03-31;  // string? | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. (optional) 
            var fromCreatedAt = 2024-01-01;  // string? | Filter transactions from the date the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var toCreatedAt = 2024-03-31;  // string? | Filter transaction to the date in which the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var fromUpdatedAt = 2024-01-01;  // string? | Filter transactions from the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var toUpdatedAt = 2024-03-31;  // string? | Filter transactions to the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. (optional) 
            var categoryGuid = "categoryGuid_example";  // string? | Filter transactions belonging to specified `category_guid`.  For example, `?category_guid=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var categoryGuid2 = new List<string>?(); // List<string>? | Filter transactions belonging to any specified `category_guid[]` in url.  For example, `?category_guid[]=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var topLevelCategoryGuid = "topLevelCategoryGuid_example";  // string? | Filter transactions belonging to specified `top_level_category_guid`. This must be top level category guid, use `category_guid` for subcategory guid.  For example, `?top_level_category_guid=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var topLevelCategoryGuid2 = new List<string>?(); // List<string>? | Filter transactions belonging to any specified `top_level_category_guid[]` in url. This must be top level category guid(s), use `category_guid` for subcategory guid(s).  For example, `?top_level_category_guid[]=CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874`. (optional) 
            var useCase = MONEY_MOVEMENT;  // string? | The use case associated with the member. Valid values are `PFM` and `MONEY_MOVEMENT`. For example, you can append either `?use_case=PFM` or `?use_case=MONEY_MOVEMENT`. (optional) 
            var includes = repeating_transactions,merchants,classifications,geolocations;  // string? | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: `repeating_transactions`, `merchants`, `classifications`, `geolocations`. The query value is format sensitive. To retrieve all available enhancements, append:  `?includes=repeating_transactions,merchants,classifications,geolocations`.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   `?includes=repeating_transactions,geolocations`.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  (optional) 

            try
            {
                // List transactions by tag
                TransactionsResponseBodyIncludes result = apiInstance.ListTransactionsByTag(userGuid, tagGuid, page, recordsPerPage, fromDate, toDate, fromCreatedAt, toCreatedAt, fromUpdatedAt, toUpdatedAt, categoryGuid, categoryGuid2, topLevelCategoryGuid, topLevelCategoryGuid2, useCase, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListTransactionsByTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionsByTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List transactions by tag
    ApiResponse<TransactionsResponseBodyIncludes> response = apiInstance.ListTransactionsByTagWithHttpInfo(userGuid, tagGuid, page, recordsPerPage, fromDate, toDate, fromCreatedAt, toCreatedAt, fromUpdatedAt, toUpdatedAt, categoryGuid, categoryGuid2, topLevelCategoryGuid, topLevelCategoryGuid2, useCase, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.ListTransactionsByTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **tagGuid** | **string** | The unique id for a &#x60;tag&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |
| **fromDate** | **string?** | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. | [optional]  |
| **toDate** | **string?** | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. | [optional]  |
| **fromCreatedAt** | **string?** | Filter transactions from the date the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **toCreatedAt** | **string?** | Filter transaction to the date in which the transaction was created. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **fromUpdatedAt** | **string?** | Filter transactions from the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **toUpdatedAt** | **string?** | Filter transactions to the date in which the transaction was updated. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Maximum date range limit is 6 months. | [optional]  |
| **categoryGuid** | **string?** | Filter transactions belonging to specified &#x60;category_guid&#x60;.  For example, &#x60;?category_guid&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **categoryGuid2** | [**List&lt;string&gt;?**](string.md) | Filter transactions belonging to any specified &#x60;category_guid[]&#x60; in url.  For example, &#x60;?category_guid[]&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **topLevelCategoryGuid** | **string?** | Filter transactions belonging to specified &#x60;top_level_category_guid&#x60;. This must be top level category guid, use &#x60;category_guid&#x60; for subcategory guid.  For example, &#x60;?top_level_category_guid&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **topLevelCategoryGuid2** | [**List&lt;string&gt;?**](string.md) | Filter transactions belonging to any specified &#x60;top_level_category_guid[]&#x60; in url. This must be top level category guid(s), use &#x60;category_guid&#x60; for subcategory guid(s).  For example, &#x60;?top_level_category_guid[]&#x3D;CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874&#x60;. | [optional]  |
| **useCase** | **string?** | The use case associated with the member. Valid values are &#x60;PFM&#x60; and &#x60;MONEY_MOVEMENT&#x60;. For example, you can append either &#x60;?use_case&#x3D;PFM&#x60; or &#x60;?use_case&#x3D;MONEY_MOVEMENT&#x60;. | [optional]  |
| **includes** | **string?** | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: &#x60;repeating_transactions&#x60;, &#x60;merchants&#x60;, &#x60;classifications&#x60;, &#x60;geolocations&#x60;. The query value is format sensitive. To retrieve all available enhancements, append:  &#x60;?includes&#x3D;repeating_transactions,merchants,classifications,geolocations&#x60;.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   &#x60;?includes&#x3D;repeating_transactions,geolocations&#x60;.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  | [optional]  |

### Return type

[**TransactionsResponseBodyIncludes**](TransactionsResponseBodyIncludes.md)

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

<a id="readtransaction"></a>
# **ReadTransaction**
> TransactionsResponseBodyIncludes ReadTransaction (string userGuid, string transactionGuid, string? includes = null)

Read transaction

Requests to this endpoint will return the attributes of the specified `transaction`. To read a manual transaction, use the manual transaction guid in the path as the `transactionGuid`. <br /><br /> Enhanced transaction data may be requested using the `includes` parameter. To use this optional parameter, the value should include the optional metadata requested such as `repeating_transactions`, `merchants`, `classifications`, `geolocations`. For more information, see the [Optional Enhancement Query Parameter guide](/api-reference/platform-api/reference/transactions-overview#enhanced-transactions#optional-enhancement-query-parameter).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var includes = repeating_transactions,merchants,classifications,geolocations;  // string? | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: `repeating_transactions`, `merchants`, `classifications`, `geolocations`. The query value is format sensitive. To retrieve all available enhancements, append:  `?includes=repeating_transactions,merchants,classifications,geolocations`.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   `?includes=repeating_transactions,geolocations`.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  (optional) 

            try
            {
                // Read transaction
                TransactionsResponseBodyIncludes result = apiInstance.ReadTransaction(userGuid, transactionGuid, includes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ReadTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read transaction
    ApiResponse<TransactionsResponseBodyIncludes> response = apiInstance.ReadTransactionWithHttpInfo(userGuid, transactionGuid, includes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.ReadTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **transactionGuid** | **string** | The unique id for a &#x60;transaction&#x60;. |  |
| **includes** | **string?** | Options for enhanced transactions. This query parameter is optional. Possible additional metadata: &#x60;repeating_transactions&#x60;, &#x60;merchants&#x60;, &#x60;classifications&#x60;, &#x60;geolocations&#x60;. The query value is format sensitive. To retrieve all available enhancements, append:  &#x60;?includes&#x3D;repeating_transactions,merchants,classifications,geolocations&#x60;.    The query options may be combined to specific enhancements. For example, to request Repeating Transactions and Geolocation data, use:   &#x60;?includes&#x3D;repeating_transactions,geolocations&#x60;.  - Repeating Transactions: Identifies transactions with predictable recurrence patterns (e.g., Bill, Income, Subscription). - Merchants: Enriches transactions with merchant name. - Classifications: Provides more insight into the type of money movement that is occurring on the transaction, whether it be retail or investments. - Geolocation: Provides geographic metadata.  | [optional]  |

### Return type

[**TransactionsResponseBodyIncludes**](TransactionsResponseBodyIncludes.md)

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

<a id="repeatingtransactions"></a>
# **RepeatingTransactions**
> RepeatingTransactionsResponseBody RepeatingTransactions (string userGuid)

List Repeating Transactions

Retrieve a list of all recurring transactions for a user. <br /><br />For more see the [Repeating Transactions guide](/api-reference/platform-api/v20111101/reference/transactions-overview#repeating-transactions).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class RepeatingTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // List Repeating Transactions
                RepeatingTransactionsResponseBody result = apiInstance.RepeatingTransactions(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.RepeatingTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RepeatingTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Repeating Transactions
    ApiResponse<RepeatingTransactionsResponseBody> response = apiInstance.RepeatingTransactionsWithHttpInfo(userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.RepeatingTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**RepeatingTransactionsResponseBody**](RepeatingTransactionsResponseBody.md)

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

<a id="specificrepeatingtransaction"></a>
# **SpecificRepeatingTransaction**
> RepeatingTransactionsResponseBody SpecificRepeatingTransaction (string userGuid, string repeatingTransactionGuid)

Get a Repeating Transaction

Get a Specific Repeating Transaction. <br /><br />List For more see the  [Repeating Transactions guide](/api-reference/platform-api/v20111101/reference/transactions-overview#repeating-transactions)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class SpecificRepeatingTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var repeatingTransactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a recurring transaction.

            try
            {
                // Get a Repeating Transaction
                RepeatingTransactionsResponseBody result = apiInstance.SpecificRepeatingTransaction(userGuid, repeatingTransactionGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.SpecificRepeatingTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SpecificRepeatingTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Repeating Transaction
    ApiResponse<RepeatingTransactionsResponseBody> response = apiInstance.SpecificRepeatingTransactionWithHttpInfo(userGuid, repeatingTransactionGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.SpecificRepeatingTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **repeatingTransactionGuid** | **string** | The unique id for a recurring transaction. |  |

### Return type

[**RepeatingTransactionsResponseBody**](RepeatingTransactionsResponseBody.md)

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

<a id="updatetransaction"></a>
# **UpdateTransaction**
> TransactionResponseBody UpdateTransaction (string userGuid, string transactionGuid, TransactionUpdateRequestBody transactionUpdateRequestBody)

Update transaction

Use this endpoint to update a specific transaction according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var transactionUpdateRequestBody = new TransactionUpdateRequestBody(); // TransactionUpdateRequestBody | Transaction object with the fields to be updated.

            try
            {
                // Update transaction
                TransactionResponseBody result = apiInstance.UpdateTransaction(userGuid, transactionGuid, transactionUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update transaction
    ApiResponse<TransactionResponseBody> response = apiInstance.UpdateTransactionWithHttpInfo(userGuid, transactionGuid, transactionUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.UpdateTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **transactionGuid** | **string** | The unique id for a &#x60;transaction&#x60;. |  |
| **transactionUpdateRequestBody** | [**TransactionUpdateRequestBody**](TransactionUpdateRequestBody.md) | Transaction object with the fields to be updated. |  |

### Return type

[**TransactionResponseBody**](TransactionResponseBody.md)

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

<a id="updatetransactionbyaccount"></a>
# **UpdateTransactionByAccount**
> TransactionResponseBody UpdateTransactionByAccount (string userGuid, string memberGuid, string accountGuid, string transactionGuid, TransactionUpdateRequestBody transactionUpdateRequestBody)

Update Transaction by Account

Use this endpoint to update a specific transaction according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateTransactionByAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var transactionUpdateRequestBody = new TransactionUpdateRequestBody(); // TransactionUpdateRequestBody | Transaction object to be updated

            try
            {
                // Update Transaction by Account
                TransactionResponseBody result = apiInstance.UpdateTransactionByAccount(userGuid, memberGuid, accountGuid, transactionGuid, transactionUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransactionByAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionByAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Transaction by Account
    ApiResponse<TransactionResponseBody> response = apiInstance.UpdateTransactionByAccountWithHttpInfo(userGuid, memberGuid, accountGuid, transactionGuid, transactionUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.UpdateTransactionByAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **transactionGuid** | **string** | The unique id for a &#x60;transaction&#x60;. |  |
| **transactionUpdateRequestBody** | [**TransactionUpdateRequestBody**](TransactionUpdateRequestBody.md) | Transaction object to be updated |  |

### Return type

[**TransactionResponseBody**](TransactionResponseBody.md)

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

