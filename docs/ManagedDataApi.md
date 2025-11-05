# MX.Platform.CSharp.Api.ManagedDataApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateManagedAccount**](ManagedDataApi.md#createmanagedaccount) | **POST** /users/{user_guid}/managed_members/{member_guid}/accounts | Create managed account |
| [**CreateManagedMember**](ManagedDataApi.md#createmanagedmember) | **POST** /users/{user_guid}/managed_members | Create managed member |
| [**CreateManagedTransaction**](ManagedDataApi.md#createmanagedtransaction) | **POST** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions | Create managed transaction |
| [**DeleteManagedAccount**](ManagedDataApi.md#deletemanagedaccount) | **DELETE** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid} | Delete managed account |
| [**DeleteManagedMember**](ManagedDataApi.md#deletemanagedmember) | **DELETE** /users/{user_guid}/managed_members/{member_guid} | Delete managed member |
| [**DeleteManagedTransaction**](ManagedDataApi.md#deletemanagedtransaction) | **DELETE** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions/{transaction_guid} | Delete managed transaction |
| [**ListManagedAccounts**](ManagedDataApi.md#listmanagedaccounts) | **GET** /users/{user_guid}/managed_members/{member_guid}/accounts | List managed accounts |
| [**ListManagedInstitutions**](ManagedDataApi.md#listmanagedinstitutions) | **GET** /managed_institutions | List managed institutions |
| [**ListManagedMembers**](ManagedDataApi.md#listmanagedmembers) | **GET** /users/{user_guid}/managed_members | List managed members |
| [**ListManagedTransactions**](ManagedDataApi.md#listmanagedtransactions) | **GET** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions | List managed transactions |
| [**ReadManagedAccount**](ManagedDataApi.md#readmanagedaccount) | **GET** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid} | Read managed account |
| [**ReadManagedMember**](ManagedDataApi.md#readmanagedmember) | **GET** /users/{user_guid}/managed_members/{member_guid} | Read managed member |
| [**ReadManagedTransaction**](ManagedDataApi.md#readmanagedtransaction) | **GET** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions/{transaction_guid} | Read managed transaction |
| [**UpdateManagedAccount**](ManagedDataApi.md#updatemanagedaccount) | **PUT** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid} | Update managed account |
| [**UpdateManagedMember**](ManagedDataApi.md#updatemanagedmember) | **PUT** /users/{user_guid}/managed_members/{member_guid} | Update managed member |
| [**UpdateManagedTransaction**](ManagedDataApi.md#updatemanagedtransaction) | **PUT** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions/{transaction_guid} | Update managed transaction |

<a id="createmanagedaccount"></a>
# **CreateManagedAccount**
> AccountResponseBody CreateManagedAccount (string memberGuid, string userGuid, ManagedAccountCreateRequestBody managedAccountCreateRequestBody)

Create managed account

Use this endpoint to create a partner-managed account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateManagedAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var managedAccountCreateRequestBody = new ManagedAccountCreateRequestBody(); // ManagedAccountCreateRequestBody | Managed account to be created.

            try
            {
                // Create managed account
                AccountResponseBody result = apiInstance.CreateManagedAccount(memberGuid, userGuid, managedAccountCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.CreateManagedAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManagedAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create managed account
    ApiResponse<AccountResponseBody> response = apiInstance.CreateManagedAccountWithHttpInfo(memberGuid, userGuid, managedAccountCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.CreateManagedAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **managedAccountCreateRequestBody** | [**ManagedAccountCreateRequestBody**](ManagedAccountCreateRequestBody.md) | Managed account to be created. |  |

### Return type

[**AccountResponseBody**](AccountResponseBody.md)

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

<a id="createmanagedmember"></a>
# **CreateManagedMember**
> MemberResponseBody CreateManagedMember (string userGuid, ManagedMemberCreateRequestBody managedMemberCreateRequestBody)

Create managed member

Use this endpoint to create a new partner-managed `member`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateManagedMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var managedMemberCreateRequestBody = new ManagedMemberCreateRequestBody(); // ManagedMemberCreateRequestBody | Managed member to be created.

            try
            {
                // Create managed member
                MemberResponseBody result = apiInstance.CreateManagedMember(userGuid, managedMemberCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.CreateManagedMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManagedMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create managed member
    ApiResponse<MemberResponseBody> response = apiInstance.CreateManagedMemberWithHttpInfo(userGuid, managedMemberCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.CreateManagedMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **managedMemberCreateRequestBody** | [**ManagedMemberCreateRequestBody**](ManagedMemberCreateRequestBody.md) | Managed member to be created. |  |

### Return type

[**MemberResponseBody**](MemberResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.mx.api.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createmanagedtransaction"></a>
# **CreateManagedTransaction**
> TransactionResponseBody CreateManagedTransaction (string accountGuid, string memberGuid, string userGuid, ManagedTransactionCreateRequestBody managedTransactionCreateRequestBody)

Create managed transaction

Use this endpoint to create a new partner-managed `transaction`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateManagedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var managedTransactionCreateRequestBody = new ManagedTransactionCreateRequestBody(); // ManagedTransactionCreateRequestBody | Managed transaction to be created.

            try
            {
                // Create managed transaction
                TransactionResponseBody result = apiInstance.CreateManagedTransaction(accountGuid, memberGuid, userGuid, managedTransactionCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.CreateManagedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManagedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create managed transaction
    ApiResponse<TransactionResponseBody> response = apiInstance.CreateManagedTransactionWithHttpInfo(accountGuid, memberGuid, userGuid, managedTransactionCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.CreateManagedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **managedTransactionCreateRequestBody** | [**ManagedTransactionCreateRequestBody**](ManagedTransactionCreateRequestBody.md) | Managed transaction to be created. |  |

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

<a id="deletemanagedaccount"></a>
# **DeleteManagedAccount**
> void DeleteManagedAccount (string accountGuid, string memberGuid, string userGuid)

Delete managed account

Use this endpoint to delete a partner-managed account according to its unique GUID. If successful, the API will respond with a status of `204 No Content`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteManagedAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Delete managed account
                apiInstance.DeleteManagedAccount(accountGuid, memberGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.DeleteManagedAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteManagedAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete managed account
    apiInstance.DeleteManagedAccountWithHttpInfo(accountGuid, memberGuid, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.DeleteManagedAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
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

<a id="deletemanagedmember"></a>
# **DeleteManagedMember**
> void DeleteManagedMember (string memberGuid, string accept, string userGuid)

Delete managed member

Use this endpoint to delete the specified partner-managed `member`. The endpoint will respond with a status of `204 No Content` without a resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteManagedMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var accept = application/vnd.mx.api.v1+json;  // string | Specifies the media type expected in the response.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Delete managed member
                apiInstance.DeleteManagedMember(memberGuid, accept, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.DeleteManagedMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteManagedMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete managed member
    apiInstance.DeleteManagedMemberWithHttpInfo(memberGuid, accept, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.DeleteManagedMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **accept** | **string** | Specifies the media type expected in the response. |  |
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

<a id="deletemanagedtransaction"></a>
# **DeleteManagedTransaction**
> void DeleteManagedTransaction (string accountGuid, string memberGuid, string transactionGuid, string userGuid)

Delete managed transaction

Use this endpoint to delete the specified partner-managed `transaction`. The endpoint will respond with a status of `204 No Content` without a resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteManagedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Delete managed transaction
                apiInstance.DeleteManagedTransaction(accountGuid, memberGuid, transactionGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.DeleteManagedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteManagedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete managed transaction
    apiInstance.DeleteManagedTransactionWithHttpInfo(accountGuid, memberGuid, transactionGuid, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.DeleteManagedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
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
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmanagedaccounts"></a>
# **ListManagedAccounts**
> AccountsResponseBody ListManagedAccounts (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List managed accounts

Use this endpoint to retrieve a list of all the partner-managed accounts associated with the given partner-managed member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListManagedAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List managed accounts
                AccountsResponseBody result = apiInstance.ListManagedAccounts(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.ListManagedAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListManagedAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List managed accounts
    ApiResponse<AccountsResponseBody> response = apiInstance.ListManagedAccountsWithHttpInfo(memberGuid, userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.ListManagedAccountsWithHttpInfo: " + e.Message);
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

### Return type

[**AccountsResponseBody**](AccountsResponseBody.md)

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

<a id="listmanagedinstitutions"></a>
# **ListManagedInstitutions**
> InstitutionsResponseBody ListManagedInstitutions (int? page = null, int? recordsPerPage = null)

List managed institutions

This endpoint returns a list of institutions which can be used to create partner-managed members.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListManagedInstitutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List managed institutions
                InstitutionsResponseBody result = apiInstance.ListManagedInstitutions(page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.ListManagedInstitutions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListManagedInstitutionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List managed institutions
    ApiResponse<InstitutionsResponseBody> response = apiInstance.ListManagedInstitutionsWithHttpInfo(page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.ListManagedInstitutionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**InstitutionsResponseBody**](InstitutionsResponseBody.md)

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

<a id="listmanagedmembers"></a>
# **ListManagedMembers**
> MembersResponseBody ListManagedMembers (string userGuid, int? page = null, int? recordsPerPage = null)

List managed members

This endpoint returns a list of all the partner-managed members associated with the specified `user`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListManagedMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List managed members
                MembersResponseBody result = apiInstance.ListManagedMembers(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.ListManagedMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListManagedMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List managed members
    ApiResponse<MembersResponseBody> response = apiInstance.ListManagedMembersWithHttpInfo(userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.ListManagedMembersWithHttpInfo: " + e.Message);
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

[**MembersResponseBody**](MembersResponseBody.md)

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

<a id="listmanagedtransactions"></a>
# **ListManagedTransactions**
> TransactionsResponseBody ListManagedTransactions (string accountGuid, string memberGuid, string userGuid, int? page = null, string? fromDate = null, string? toDate = null, int? recordsPerPage = null)

List managed transactions

This endpoint returns a list of all the partner-managed transactions associated with the specified `account`, scoped through a `user` and a `member`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListManagedTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var fromDate = 2024-01-01;  // string? | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. (optional) 
            var toDate = 2024-03-31;  // string? | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List managed transactions
                TransactionsResponseBody result = apiInstance.ListManagedTransactions(accountGuid, memberGuid, userGuid, page, fromDate, toDate, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.ListManagedTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListManagedTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List managed transactions
    ApiResponse<TransactionsResponseBody> response = apiInstance.ListManagedTransactionsWithHttpInfo(accountGuid, memberGuid, userGuid, page, fromDate, toDate, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.ListManagedTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **fromDate** | **string?** | Filter transactions from this date. This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 120 days ago if not provided. | [optional]  |
| **toDate** | **string?** | Filter transactions to this date (at midnight). This only supports ISO 8601 format without timestamp (YYYY-MM-DD). Defaults to 5 days forward from the day the request is made to capture pending transactions. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**TransactionsResponseBody**](TransactionsResponseBody.md)

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

<a id="readmanagedaccount"></a>
# **ReadManagedAccount**
> AccountResponseBody ReadManagedAccount (string accountGuid, string memberGuid, string userGuid)

Read managed account

Use this endpoint to read the attributes of a partner-managed account according to its unique guid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadManagedAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read managed account
                AccountResponseBody result = apiInstance.ReadManagedAccount(accountGuid, memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.ReadManagedAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadManagedAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read managed account
    ApiResponse<AccountResponseBody> response = apiInstance.ReadManagedAccountWithHttpInfo(accountGuid, memberGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.ReadManagedAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**AccountResponseBody**](AccountResponseBody.md)

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

<a id="readmanagedmember"></a>
# **ReadManagedMember**
> MemberResponseBody ReadManagedMember (string memberGuid, string userGuid)

Read managed member

This endpoint returns the attributes of the specified partner-managed`member`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadManagedMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read managed member
                MemberResponseBody result = apiInstance.ReadManagedMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.ReadManagedMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadManagedMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read managed member
    ApiResponse<MemberResponseBody> response = apiInstance.ReadManagedMemberWithHttpInfo(memberGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.ReadManagedMemberWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readmanagedtransaction"></a>
# **ReadManagedTransaction**
> TransactionResponseBody ReadManagedTransaction (string accountGuid, string memberGuid, string transactionGuid, string userGuid)

Read managed transaction

Requests to this endpoint will return the attributes of the specified partner-managed `transaction`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadManagedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read managed transaction
                TransactionResponseBody result = apiInstance.ReadManagedTransaction(accountGuid, memberGuid, transactionGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.ReadManagedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadManagedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read managed transaction
    ApiResponse<TransactionResponseBody> response = apiInstance.ReadManagedTransactionWithHttpInfo(accountGuid, memberGuid, transactionGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.ReadManagedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **transactionGuid** | **string** | The unique id for a &#x60;transaction&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

### Return type

[**TransactionResponseBody**](TransactionResponseBody.md)

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

<a id="updatemanagedaccount"></a>
# **UpdateManagedAccount**
> AccountResponseBody UpdateManagedAccount (string accountGuid, string memberGuid, string userGuid, ManagedAccountUpdateRequestBody managedAccountUpdateRequestBody)

Update managed account

Use this endpoint to update the attributes of a partner-managed account according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateManagedAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var managedAccountUpdateRequestBody = new ManagedAccountUpdateRequestBody(); // ManagedAccountUpdateRequestBody | Managed account object to be updated (While no single parameter is required, the request body can't be empty)

            try
            {
                // Update managed account
                AccountResponseBody result = apiInstance.UpdateManagedAccount(accountGuid, memberGuid, userGuid, managedAccountUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.UpdateManagedAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateManagedAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update managed account
    ApiResponse<AccountResponseBody> response = apiInstance.UpdateManagedAccountWithHttpInfo(accountGuid, memberGuid, userGuid, managedAccountUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.UpdateManagedAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **managedAccountUpdateRequestBody** | [**ManagedAccountUpdateRequestBody**](ManagedAccountUpdateRequestBody.md) | Managed account object to be updated (While no single parameter is required, the request body can&#39;t be empty) |  |

### Return type

[**AccountResponseBody**](AccountResponseBody.md)

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

<a id="updatemanagedmember"></a>
# **UpdateManagedMember**
> MemberResponseBody UpdateManagedMember (string memberGuid, string userGuid, ManagedMemberUpdateRequestBody managedMemberUpdateRequestBody)

Update managed member

Use this endpoint to update the attributes of the specified partner_managed `member`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateManagedMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var managedMemberUpdateRequestBody = new ManagedMemberUpdateRequestBody(); // ManagedMemberUpdateRequestBody | Managed member object to be updated (While no single parameter is required, the request body can't be empty)

            try
            {
                // Update managed member
                MemberResponseBody result = apiInstance.UpdateManagedMember(memberGuid, userGuid, managedMemberUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.UpdateManagedMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateManagedMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update managed member
    ApiResponse<MemberResponseBody> response = apiInstance.UpdateManagedMemberWithHttpInfo(memberGuid, userGuid, managedMemberUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.UpdateManagedMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **managedMemberUpdateRequestBody** | [**ManagedMemberUpdateRequestBody**](ManagedMemberUpdateRequestBody.md) | Managed member object to be updated (While no single parameter is required, the request body can&#39;t be empty) |  |

### Return type

[**MemberResponseBody**](MemberResponseBody.md)

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

<a id="updatemanagedtransaction"></a>
# **UpdateManagedTransaction**
> TransactionResponseBody UpdateManagedTransaction (string accountGuid, string memberGuid, string transactionGuid, string userGuid, ManagedTransactionUpdateRequestBody managedTransactionUpdateRequestBody)

Update managed transaction

Use this endpoint to update the attributes of the specified partner_managed `transaction`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateManagedTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ManagedDataApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var managedTransactionUpdateRequestBody = new ManagedTransactionUpdateRequestBody(); // ManagedTransactionUpdateRequestBody | Managed transaction object to be updated (While no single parameter is required, the request body can't be empty)

            try
            {
                // Update managed transaction
                TransactionResponseBody result = apiInstance.UpdateManagedTransaction(accountGuid, memberGuid, transactionGuid, userGuid, managedTransactionUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManagedDataApi.UpdateManagedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateManagedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update managed transaction
    ApiResponse<TransactionResponseBody> response = apiInstance.UpdateManagedTransactionWithHttpInfo(accountGuid, memberGuid, transactionGuid, userGuid, managedTransactionUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManagedDataApi.UpdateManagedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountGuid** | **string** | The unique id for an &#x60;account&#x60;. |  |
| **memberGuid** | **string** | The unique id for a &#x60;member&#x60;. |  |
| **transactionGuid** | **string** | The unique id for a &#x60;transaction&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **managedTransactionUpdateRequestBody** | [**ManagedTransactionUpdateRequestBody**](ManagedTransactionUpdateRequestBody.md) | Managed transaction object to be updated (While no single parameter is required, the request body can&#39;t be empty) |  |

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

