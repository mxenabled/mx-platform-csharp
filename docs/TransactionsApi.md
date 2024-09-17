# MX.Platform.CSharp.Api.TransactionsApi

All URIs are relative to *https://api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UsersUserGuidAccountsAccountGuidTransactionsPost**](TransactionsApi.md#usersuserguidaccountsaccountguidtransactionspost) | **POST** /users/{user_guid}/accounts/{account_guid}/transactions | Create manual transaction |

<a id="usersuserguidaccountsaccountguidtransactionspost"></a>
# **UsersUserGuidAccountsAccountGuidTransactionsPost**
> TransactionCreateResponseBody UsersUserGuidAccountsAccountGuidTransactionsPost (string userGuid, string accountGuid, TransactionCreateRequestBody transactionCreateRequestBody)

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
    public class UsersUserGuidAccountsAccountGuidTransactionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TransactionsApi(config);
            var userGuid = "userGuid_example";  // string | The unique identifier for the user.
            var accountGuid = "accountGuid_example";  // string | The unique identifier for the account.
            var transactionCreateRequestBody = new TransactionCreateRequestBody(); // TransactionCreateRequestBody | 

            try
            {
                // Create manual transaction
                TransactionCreateResponseBody result = apiInstance.UsersUserGuidAccountsAccountGuidTransactionsPost(userGuid, accountGuid, transactionCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.UsersUserGuidAccountsAccountGuidTransactionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersUserGuidAccountsAccountGuidTransactionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create manual transaction
    ApiResponse<TransactionCreateResponseBody> response = apiInstance.UsersUserGuidAccountsAccountGuidTransactionsPostWithHttpInfo(userGuid, accountGuid, transactionCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.UsersUserGuidAccountsAccountGuidTransactionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for the user. |  |
| **accountGuid** | **string** | The unique identifier for the account. |  |
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

