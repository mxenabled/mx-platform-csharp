# MX.Platform.CSharp.Api.MxPlatformApi

All URIs are relative to *https://api.mx.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AggregateMember**](MxPlatformApi.md#aggregatemember) | **POST** /users/{user_guid}/members/{member_guid}/aggregate | Aggregate member
[**CheckBalances**](MxPlatformApi.md#checkbalances) | **POST** /users/{user_guid}/members/{member_guid}/check_balance | Check balances
[**CreateCategory**](MxPlatformApi.md#createcategory) | **POST** /users/{user_guid}/categories | Create category
[**CreateManagedAccount**](MxPlatformApi.md#createmanagedaccount) | **POST** /users/{user_guid}/managed_members/{member_guid}/accounts | Create managed account
[**CreateManagedMember**](MxPlatformApi.md#createmanagedmember) | **POST** /users/{user_guid}/managed_members | Create managed member
[**CreateManagedTransaction**](MxPlatformApi.md#createmanagedtransaction) | **POST** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions | Create managed transaction
[**CreateMember**](MxPlatformApi.md#createmember) | **POST** /users/{user_guid}/members | Create member
[**CreateTag**](MxPlatformApi.md#createtag) | **POST** /users/{user_guid}/tags | Create tag
[**CreateTagging**](MxPlatformApi.md#createtagging) | **POST** /users/{user_guid}/taggings | Create tagging
[**CreateTransactionRule**](MxPlatformApi.md#createtransactionrule) | **POST** /users/{user_guid}/transaction_rules | Create transaction rule
[**CreateUser**](MxPlatformApi.md#createuser) | **POST** /users | Create user
[**DeleteCategory**](MxPlatformApi.md#deletecategory) | **DELETE** /users/{user_guid}/categories/{category_guid} | Delete category
[**DeleteManagedAccount**](MxPlatformApi.md#deletemanagedaccount) | **DELETE** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid} | Delete managed account
[**DeleteManagedMember**](MxPlatformApi.md#deletemanagedmember) | **DELETE** /users/{user_guid}/managed_members/{member_guid} | Delete managed member
[**DeleteManagedTransaction**](MxPlatformApi.md#deletemanagedtransaction) | **DELETE** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions/{transaction_guid} | Delete managed transaction
[**DeleteMember**](MxPlatformApi.md#deletemember) | **DELETE** /users/{user_guid}/members/{member_guid} | Delete member
[**DeleteTag**](MxPlatformApi.md#deletetag) | **DELETE** /users/{user_guid}/tags/{tag_guid} | Delete tag
[**DeleteTagging**](MxPlatformApi.md#deletetagging) | **DELETE** /users/{user_guid}/taggings/{tagging_guid} | Delete tagging
[**DeleteTransactionRule**](MxPlatformApi.md#deletetransactionrule) | **DELETE** /users/{user_guid}/transaction_rules/{transaction_rule_guid} | Delete transaction rule
[**DeleteUser**](MxPlatformApi.md#deleteuser) | **DELETE** /users/{user_guid} | Delete user
[**DownloadStatementPDF**](MxPlatformApi.md#downloadstatementpdf) | **GET** /users/{user_guid}/members/{member_guid}/statements/{statement_guid}.pdf | Download statement pdf
[**EnhanceTransactions**](MxPlatformApi.md#enhancetransactions) | **POST** /transactions/enhance | Enhance transactions
[**ExtendHistory**](MxPlatformApi.md#extendhistory) | **POST** /users/{user_guid}/members/{member_guid}/extend_history | Extend history
[**FetchStatements**](MxPlatformApi.md#fetchstatements) | **POST** /users/{user_guid}/members/{member_guid}/fetch_statements | Fetch statements
[**IdentifyMember**](MxPlatformApi.md#identifymember) | **POST** /users/{user_guid}/members/{member_guid}/identify | Identify member
[**ListAccountNumbersByAccount**](MxPlatformApi.md#listaccountnumbersbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/account_numbers | List account numbers by account
[**ListAccountNumbersByMember**](MxPlatformApi.md#listaccountnumbersbymember) | **GET** /users/{user_guid}/members/{member_guid}/account_numbers | List account numbers by member
[**ListAccountOwnersByMember**](MxPlatformApi.md#listaccountownersbymember) | **GET** /users/{user_guid}/members/{member_guid}/account_owners | List account owners by member
[**ListCategories**](MxPlatformApi.md#listcategories) | **GET** /users/{user_guid}/categories | List categories
[**ListDefaultCategories**](MxPlatformApi.md#listdefaultcategories) | **GET** /categories/default | List default categories
[**ListDefaultCategoriesByUser**](MxPlatformApi.md#listdefaultcategoriesbyuser) | **GET** /users/{user_guid}/categories/default | List default categories by user
[**ListFavoriteInstitutions**](MxPlatformApi.md#listfavoriteinstitutions) | **GET** /institutions/favorites | List favorite institutions
[**ListHoldings**](MxPlatformApi.md#listholdings) | **GET** /users/{user_guid}/holdings | List holdings
[**ListHoldingsByAccount**](MxPlatformApi.md#listholdingsbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/holdings | List holdings by account
[**ListHoldingsByMember**](MxPlatformApi.md#listholdingsbymember) | **GET** /users/{user_guid}/members/{member_guid}/holdings | List holdings by member
[**ListInstitutionCredentials**](MxPlatformApi.md#listinstitutioncredentials) | **GET** /institutions/{institution_code}/credentials | List institution credentials
[**ListInstitutions**](MxPlatformApi.md#listinstitutions) | **GET** /institutions | List institutions
[**ListManagedAccounts**](MxPlatformApi.md#listmanagedaccounts) | **GET** /users/{user_guid}/managed_members/{member_guid}/accounts | List managed accounts
[**ListManagedInstitutions**](MxPlatformApi.md#listmanagedinstitutions) | **GET** /managed_institutions | List managed institutions
[**ListManagedMembers**](MxPlatformApi.md#listmanagedmembers) | **GET** /users/{user_guid}/managed_members | List managed members
[**ListManagedTransactions**](MxPlatformApi.md#listmanagedtransactions) | **GET** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions | List managed transactions
[**ListMemberChallenges**](MxPlatformApi.md#listmemberchallenges) | **GET** /users/{user_guid}/members/{member_guid}/challenges | List member challenges
[**ListMemberCredentials**](MxPlatformApi.md#listmembercredentials) | **GET** /users/{user_guid}/members/{member_guid}/credentials | List member credentials
[**ListMembers**](MxPlatformApi.md#listmembers) | **GET** /users/{user_guid}/members | List members
[**ListMerchants**](MxPlatformApi.md#listmerchants) | **GET** /merchants | List merchants
[**ListStatementsByMember**](MxPlatformApi.md#liststatementsbymember) | **GET** /users/{user_guid}/members/{member_guid}/statements | List statements by member
[**ListTaggings**](MxPlatformApi.md#listtaggings) | **GET** /users/{user_guid}/taggings | List taggings
[**ListTags**](MxPlatformApi.md#listtags) | **GET** /users/{user_guid}/tags | List tags
[**ListTransactionRules**](MxPlatformApi.md#listtransactionrules) | **GET** /users/{user_guid}/transaction_rules | List transaction rules
[**ListTransactions**](MxPlatformApi.md#listtransactions) | **GET** /users/{user_guid}/transactions | List transactions
[**ListTransactionsByAccount**](MxPlatformApi.md#listtransactionsbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/transactions | List transactions by account
[**ListTransactionsByMember**](MxPlatformApi.md#listtransactionsbymember) | **GET** /users/{user_guid}/members/{member_guid}/transactions | List transactions by member
[**ListTransactionsByTag**](MxPlatformApi.md#listtransactionsbytag) | **GET** /users/{user_guid}/tags/{tag_guid}/transactions | List transactions by tag
[**ListUserAccounts**](MxPlatformApi.md#listuseraccounts) | **GET** /users/{user_guid}/accounts | List accounts
[**ListUsers**](MxPlatformApi.md#listusers) | **GET** /users | List users
[**ReadAccount**](MxPlatformApi.md#readaccount) | **GET** /users/{user_guid}/accounts/{account_guid} | Read account
[**ReadCategory**](MxPlatformApi.md#readcategory) | **GET** /users/{user_guid}/categories/{category_guid} | Read a custom category
[**ReadDefaultCategory**](MxPlatformApi.md#readdefaultcategory) | **GET** /categories/{category_guid} | Read a default category
[**ReadHolding**](MxPlatformApi.md#readholding) | **GET** /users/{user_guid}/holdings/{holding_guid} | Read holding
[**ReadInstitution**](MxPlatformApi.md#readinstitution) | **GET** /institutions/{institution_code} | Read institution
[**ReadManagedAccount**](MxPlatformApi.md#readmanagedaccount) | **GET** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid} | Read managed account
[**ReadManagedMember**](MxPlatformApi.md#readmanagedmember) | **GET** /users/{user_guid}/managed_members/{member_guid} | Read managed member
[**ReadManagedTransaction**](MxPlatformApi.md#readmanagedtransaction) | **GET** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions/{transaction_guid} | Read managed transaction
[**ReadMember**](MxPlatformApi.md#readmember) | **GET** /users/{user_guid}/members/{member_guid} | Read member
[**ReadMemberStatus**](MxPlatformApi.md#readmemberstatus) | **GET** /users/{user_guid}/members/{member_guid}/status | Read member status
[**ReadMerchant**](MxPlatformApi.md#readmerchant) | **GET** /merchants/{merchant_guid} | Read merchant
[**ReadMerchantLocation**](MxPlatformApi.md#readmerchantlocation) | **GET** /merchant_locations/{merchant_location_guid} | Read merchant location
[**ReadStatementByMember**](MxPlatformApi.md#readstatementbymember) | **GET** /users/{user_guid}/members/{member_guid}/statements/{statement_guid} | Read statement by member
[**ReadTag**](MxPlatformApi.md#readtag) | **GET** /users/{user_guid}/tags/{tag_guid} | Read tag
[**ReadTagging**](MxPlatformApi.md#readtagging) | **GET** /users/{user_guid}/taggings/{tagging_guid} | Read tagging
[**ReadTransaction**](MxPlatformApi.md#readtransaction) | **GET** /users/{user_guid}/transactions/{transaction_guid} | Read transaction
[**ReadTransactionRule**](MxPlatformApi.md#readtransactionrule) | **GET** /users/{user_guid}/transaction_rules/{transaction_rule_guid} | Read transaction rule
[**ReadUser**](MxPlatformApi.md#readuser) | **GET** /users/{user_guid} | Read user
[**RequestConnectWidgetURL**](MxPlatformApi.md#requestconnectwidgeturl) | **POST** /users/{user_guid}/connect_widget_url | Request connect widget url
[**RequestOAuthWindowURI**](MxPlatformApi.md#requestoauthwindowuri) | **GET** /users/{user_guid}/members/{member_guid}/oauth_window_uri | Request oauth window uri
[**RequestWidgetURL**](MxPlatformApi.md#requestwidgeturl) | **POST** /users/{user_guid}/widget_urls | Request widget url
[**ResumeAggregation**](MxPlatformApi.md#resumeaggregation) | **PUT** /users/{user_guid}/members/{member_guid}/resume | Resume aggregation
[**UpdateAccountByMember**](MxPlatformApi.md#updateaccountbymember) | **PUT** /users/{user_guid}/members/{member_guid}/accounts/{account_guid} | Update account by member
[**UpdateCategory**](MxPlatformApi.md#updatecategory) | **PUT** /users/{user_guid}/categories/{category_guid} | Update category
[**UpdateManagedAccount**](MxPlatformApi.md#updatemanagedaccount) | **PUT** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid} | Update managed account
[**UpdateManagedMember**](MxPlatformApi.md#updatemanagedmember) | **PUT** /users/{user_guid}/managed_members/{member_guid} | Update managed member
[**UpdateManagedTransaction**](MxPlatformApi.md#updatemanagedtransaction) | **PUT** /users/{user_guid}/managed_members/{member_guid}/accounts/{account_guid}/transactions/{transaction_guid} | Update managed transaction
[**UpdateMember**](MxPlatformApi.md#updatemember) | **PUT** /users/{user_guid}/members/{member_guid} | Update member
[**UpdateTag**](MxPlatformApi.md#updatetag) | **PUT** /users/{user_guid}/tags/{tag_guid} | Update tag
[**UpdateTagging**](MxPlatformApi.md#updatetagging) | **PUT** /users/{user_guid}/taggings/{tagging_guid} | Update tagging
[**UpdateTransaction**](MxPlatformApi.md#updatetransaction) | **PUT** /users/{user_guid}/transactions/{transaction_guid} | Update transaction
[**UpdateTransactionRule**](MxPlatformApi.md#updatetransactionrule) | **PUT** /users/{user_guid}/transaction_rules/{transaction_rule_guid} | Update transaction_rule
[**UpdateUser**](MxPlatformApi.md#updateuser) | **PUT** /users/{user_guid} | Update user
[**VerifyMember**](MxPlatformApi.md#verifymember) | **POST** /users/{user_guid}/members/{member_guid}/verify | Verify member


<a name="aggregatemember"></a>
# **AggregateMember**
> MemberResponseBody AggregateMember (string memberGuid, string userGuid)

Aggregate member

Calling this endpoint initiates an aggregation event for the member. This brings in the latest account and transaction data from the connected institution. If this data has recently been updated, MX may not initiate an aggregation event.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class AggregateMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Aggregate member
                MemberResponseBody result = apiInstance.AggregateMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.AggregateMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="checkbalances"></a>
# **CheckBalances**
> MemberResponseBody CheckBalances (string memberGuid, string userGuid)

Check balances

This endpoint operates much like the aggregate member endpoint except that it gathers only account balance information; it does not gather any transaction data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CheckBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Check balances
                MemberResponseBody result = apiInstance.CheckBalances(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CheckBalances: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="createcategory"></a>
# **CreateCategory**
> CategoryResponseBody CreateCategory (string userGuid, CategoryCreateRequestBody categoryCreateRequestBody)

Create category

Use this endpoint to create a new custom category for a specific `user`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var categoryCreateRequestBody = new CategoryCreateRequestBody(); // CategoryCreateRequestBody | Custom category object to be created

            try
            {
                // Create category
                CategoryResponseBody result = apiInstance.CreateCategory(userGuid, categoryCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateCategory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **categoryCreateRequestBody** | [**CategoryCreateRequestBody**](CategoryCreateRequestBody.md)| Custom category object to be created | 

### Return type

[**CategoryResponseBody**](CategoryResponseBody.md)

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

<a name="createmanagedaccount"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var managedAccountCreateRequestBody = new ManagedAccountCreateRequestBody(); // ManagedAccountCreateRequestBody | Managed account to be created.

            try
            {
                // Create managed account
                AccountResponseBody result = apiInstance.CreateManagedAccount(memberGuid, userGuid, managedAccountCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateManagedAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **managedAccountCreateRequestBody** | [**ManagedAccountCreateRequestBody**](ManagedAccountCreateRequestBody.md)| Managed account to be created. | 

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
| **202** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmanagedmember"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var managedMemberCreateRequestBody = new ManagedMemberCreateRequestBody(); // ManagedMemberCreateRequestBody | Managed member to be created.

            try
            {
                // Create managed member
                MemberResponseBody result = apiInstance.CreateManagedMember(userGuid, managedMemberCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateManagedMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **managedMemberCreateRequestBody** | [**ManagedMemberCreateRequestBody**](ManagedMemberCreateRequestBody.md)| Managed member to be created. | 

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

<a name="createmanagedtransaction"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var managedTransactionCreateRequestBody = new ManagedTransactionCreateRequestBody(); // ManagedTransactionCreateRequestBody | Managed transaction to be created.

            try
            {
                // Create managed transaction
                TransactionResponseBody result = apiInstance.CreateManagedTransaction(accountGuid, memberGuid, userGuid, managedTransactionCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateManagedTransaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **managedTransactionCreateRequestBody** | [**ManagedTransactionCreateRequestBody**](ManagedTransactionCreateRequestBody.md)| Managed transaction to be created. | 

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
| **202** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmember"></a>
# **CreateMember**
> MemberResponseBody CreateMember (string userGuid, MemberCreateRequestBody memberCreateRequestBody)

Create member

This endpoint allows you to create a new member. Members are created with the required parameters credentials and institution_code, and the optional parameters id and metadata. When creating a member, youll need to include the correct type of credential required by the financial institution and provided by the user. You can find out which credential type is required with the `/institutions/{institution_code}/credentials` endpoint. If successful, the MX Platform API will respond with the newly-created member object. Once you successfully create a member, MX will immediately validate the provided credentials and attempt to aggregate data for accounts and transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var memberCreateRequestBody = new MemberCreateRequestBody(); // MemberCreateRequestBody | Member object to be created with optional parameters (id and metadata) and required parameters (credentials and institution_code)

            try
            {
                // Create member
                MemberResponseBody result = apiInstance.CreateMember(userGuid, memberCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **memberCreateRequestBody** | [**MemberCreateRequestBody**](MemberCreateRequestBody.md)| Member object to be created with optional parameters (id and metadata) and required parameters (credentials and institution_code) | 

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
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtag"></a>
# **CreateTag**
> TagResponseBody CreateTag (string userGuid, TagCreateRequestBody tagCreateRequestBody)

Create tag

Use this endpoint to create a new custom tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var tagCreateRequestBody = new TagCreateRequestBody(); // TagCreateRequestBody | Tag object to be created with required parameters (tag_guid)

            try
            {
                // Create tag
                TagResponseBody result = apiInstance.CreateTag(userGuid, tagCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **tagCreateRequestBody** | [**TagCreateRequestBody**](TagCreateRequestBody.md)| Tag object to be created with required parameters (tag_guid) | 

### Return type

[**TagResponseBody**](TagResponseBody.md)

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

<a name="createtagging"></a>
# **CreateTagging**
> TaggingResponseBody CreateTagging (string userGuid, TaggingCreateRequestBody taggingCreateRequestBody)

Create tagging

Use this endpoint to create a new association between a tag and a particular transaction, according to their unique GUIDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateTaggingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var taggingCreateRequestBody = new TaggingCreateRequestBody(); // TaggingCreateRequestBody | Tagging object to be created with required parameters (tag_guid and transaction_guid)

            try
            {
                // Create tagging
                TaggingResponseBody result = apiInstance.CreateTagging(userGuid, taggingCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateTagging: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **taggingCreateRequestBody** | [**TaggingCreateRequestBody**](TaggingCreateRequestBody.md)| Tagging object to be created with required parameters (tag_guid and transaction_guid) | 

### Return type

[**TaggingResponseBody**](TaggingResponseBody.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.mx.api.v1+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtransactionrule"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var transactionRuleCreateRequestBody = new TransactionRuleCreateRequestBody(); // TransactionRuleCreateRequestBody | TransactionRule object to be created with optional parameters (description) and required parameters (category_guid and match_description)

            try
            {
                // Create transaction rule
                TransactionRuleResponseBody result = apiInstance.CreateTransactionRule(userGuid, transactionRuleCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateTransactionRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **transactionRuleCreateRequestBody** | [**TransactionRuleCreateRequestBody**](TransactionRuleCreateRequestBody.md)| TransactionRule object to be created with optional parameters (description) and required parameters (category_guid and match_description) | 

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

<a name="createuser"></a>
# **CreateUser**
> UserResponseBody CreateUser (UserCreateRequestBody userCreateRequestBody)

Create user

Use this endpoint to create a new user. The API will respond with the newly-created user object if successful. Disabling a user means that accounts and transactions associated with it will not be updated in the background by MX. It will also restrict access to that user’s data until they are no longer disabled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userCreateRequestBody = new UserCreateRequestBody(); // UserCreateRequestBody | User object to be created. (None of these parameters are required, but the user object cannot be empty)

            try
            {
                // Create user
                UserResponseBody result = apiInstance.CreateUser(userCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.CreateUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userCreateRequestBody** | [**UserCreateRequestBody**](UserCreateRequestBody.md)| User object to be created. (None of these parameters are required, but the user object cannot be empty) | 

### Return type

[**UserResponseBody**](UserResponseBody.md)

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

<a name="deletecategory"></a>
# **DeleteCategory**
> void DeleteCategory (string categoryGuid, string userGuid)

Delete category

Use this endpoint to delete a specific custom category according to its unique GUID. The API will respond with an empty object and a status of `204 No Content`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var categoryGuid = CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874;  // string | The unique id for a `category`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete category
                apiInstance.DeleteCategory(categoryGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteCategory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryGuid** | **string**| The unique id for a &#x60;category&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="deletemanagedaccount"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete managed account
                apiInstance.DeleteManagedAccount(accountGuid, memberGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteManagedAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="deletemanagedmember"></a>
# **DeleteManagedMember**
> void DeleteManagedMember (string memberGuid, string userGuid)

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete managed member
                apiInstance.DeleteManagedMember(memberGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteManagedMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="deletemanagedtransaction"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete managed transaction
                apiInstance.DeleteManagedTransaction(accountGuid, memberGuid, transactionGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteManagedTransaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **transactionGuid** | **string**| The unique id for a &#x60;transaction&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="deletemember"></a>
# **DeleteMember**
> void DeleteMember (string memberGuid, string userGuid)

Delete member

Accessing this endpoint will permanently delete a member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete member
                apiInstance.DeleteMember(memberGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="deletetag"></a>
# **DeleteTag**
> void DeleteTag (string tagGuid, string userGuid)

Delete tag

Use this endpoint to permanently delete a specific tag based on its unique GUID. If successful, the API will respond with status of `204 No Content`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var tagGuid = TAG-aef36e72-6294-4c38-844d-e573e80aed52;  // string | The unique id for a `tag`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete tag
                apiInstance.DeleteTag(tagGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGuid** | **string**| The unique id for a &#x60;tag&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="deletetagging"></a>
# **DeleteTagging**
> void DeleteTagging (string taggingGuid, string userGuid)

Delete tagging

Use this endpoint to delete a tagging according to its unique GUID. If successful, the API will respond with an empty body and a status of 204 NO Content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteTaggingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var taggingGuid = TGN-007f5486-17e1-45fc-8b87-8f03984430fe;  // string | The unique id for a `tagging`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete tagging
                apiInstance.DeleteTagging(taggingGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteTagging: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taggingGuid** | **string**| The unique id for a &#x60;tagging&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="deletetransactionrule"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var transactionRuleGuid = TXR-a080e0f9-a2d4-4d6f-9e03-672cc357a4d3;  // string | The unique id for a `transaction_rule`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete transaction rule
                apiInstance.DeleteTransactionRule(transactionRuleGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteTransactionRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRuleGuid** | **string**| The unique id for a &#x60;transaction_rule&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string userGuid)

Delete user

Use this endpoint to delete the specified `user`. The response will have a status of `204 No Content` without an object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Delete user
                apiInstance.DeleteUser(userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DeleteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="downloadstatementpdf"></a>
# **DownloadStatementPDF**
> System.IO.Stream DownloadStatementPDF (string memberGuid, string statementGuid, string userGuid)

Download statement pdf

Use this endpoint to download a specified statement PDF.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class DownloadStatementPDFExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var statementGuid = STA-737a344b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for a `statement`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Download statement pdf
                System.IO.Stream result = apiInstance.DownloadStatementPDF(memberGuid, statementGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.DownloadStatementPDF: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **statementGuid** | **string**| The unique id for a &#x60;statement&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

### Return type

**System.IO.Stream**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.mx.api.v1+pdf


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enhancetransactions"></a>
# **EnhanceTransactions**
> EnhanceTransactionsResponseBody EnhanceTransactions (EnhanceTransactionsRequestBody enhanceTransactionsRequestBody)

Enhance transactions

Use this endpoint to categorize, cleanse, and classify transactions. These transactions are not persisted or stored on the MX platform.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var enhanceTransactionsRequestBody = new EnhanceTransactionsRequestBody(); // EnhanceTransactionsRequestBody | Transaction object to be enhanced

            try
            {
                // Enhance transactions
                EnhanceTransactionsResponseBody result = apiInstance.EnhanceTransactions(enhanceTransactionsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.EnhanceTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enhanceTransactionsRequestBody** | [**EnhanceTransactionsRequestBody**](EnhanceTransactionsRequestBody.md)| Transaction object to be enhanced | 

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

<a name="extendhistory"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique identifier for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`.

            try
            {
                // Extend history
                MemberResponseBody result = apiInstance.ExtendHistory(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ExtendHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

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

<a name="fetchstatements"></a>
# **FetchStatements**
> MemberResponseBody FetchStatements (string memberGuid, string userGuid)

Fetch statements

Use this endpoint to fetch the statements associated with a particular member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class FetchStatementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Fetch statements
                MemberResponseBody result = apiInstance.FetchStatements(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.FetchStatements: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="identifymember"></a>
# **IdentifyMember**
> MemberResponseBody IdentifyMember (string memberGuid, string userGuid)

Identify member

The identify endpoint begins an identification process for an already-existing member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class IdentifyMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Identify member
                MemberResponseBody result = apiInstance.IdentifyMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.IdentifyMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="listaccountnumbersbyaccount"></a>
# **ListAccountNumbersByAccount**
> AccountNumbersResponseBody ListAccountNumbersByAccount (string accountGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List account numbers by account

This endpoint returns a list of account numbers associated with the specified `account`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListAccountNumbersByAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List account numbers by account
                AccountNumbersResponseBody result = apiInstance.ListAccountNumbersByAccount(accountGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListAccountNumbersByAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**AccountNumbersResponseBody**](AccountNumbersResponseBody.md)

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

<a name="listaccountnumbersbymember"></a>
# **ListAccountNumbersByMember**
> AccountNumbersResponseBody ListAccountNumbersByMember (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List account numbers by member

This endpoint returns a list of account numbers associated with the specified `member`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListAccountNumbersByMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List account numbers by member
                AccountNumbersResponseBody result = apiInstance.ListAccountNumbersByMember(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListAccountNumbersByMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**AccountNumbersResponseBody**](AccountNumbersResponseBody.md)

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

<a name="listaccountownersbymember"></a>
# **ListAccountOwnersByMember**
> AccountOwnersResponseBody ListAccountOwnersByMember (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List account owners by member

This endpoint returns an array with information about every account associated with a particular member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListAccountOwnersByMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List account owners by member
                AccountOwnersResponseBody result = apiInstance.ListAccountOwnersByMember(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListAccountOwnersByMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**AccountOwnersResponseBody**](AccountOwnersResponseBody.md)

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

<a name="listcategories"></a>
# **ListCategories**
> CategoriesResponseBody ListCategories (string userGuid, int? page = null, int? recordsPerPage = null)

List categories

Use this endpoint to list all categories associated with a `user`, including both default and custom categories.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List categories
                CategoriesResponseBody result = apiInstance.ListCategories(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListCategories: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**CategoriesResponseBody**](CategoriesResponseBody.md)

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

<a name="listdefaultcategories"></a>
# **ListDefaultCategories**
> CategoriesResponseBody ListDefaultCategories (int? page = null, int? recordsPerPage = null)

List default categories

Use this endpoint to retrieve a list of all the default categories and subcategories offered within the MX Platform API. In other words, each item in the returned list will have its `is_default` field set to `true`. There are currently 119 default categories and subcategories. Both the _list default categories_ and _list default categories by user_ endpoints return the same results. The different routes are provided for convenience.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListDefaultCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List default categories
                CategoriesResponseBody result = apiInstance.ListDefaultCategories(page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListDefaultCategories: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**CategoriesResponseBody**](CategoriesResponseBody.md)

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

<a name="listdefaultcategoriesbyuser"></a>
# **ListDefaultCategoriesByUser**
> CategoriesResponseBody ListDefaultCategoriesByUser (string userGuid, int? page = null, int? recordsPerPage = null)

List default categories by user

Use this endpoint to retrieve a list of all the default categories and subcategories, scoped by user, offered within the MX Platform API. In other words, each item in the returned list will have its `is_default` field set to `true`. There are currently 119 default categories and subcategories. Both the _list default categories_ and _list default categories by user_ endpoints return the same results. The different routes are provided for convenience.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListDefaultCategoriesByUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List default categories by user
                CategoriesResponseBody result = apiInstance.ListDefaultCategoriesByUser(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListDefaultCategoriesByUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**CategoriesResponseBody**](CategoriesResponseBody.md)

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

<a name="listfavoriteinstitutions"></a>
# **ListFavoriteInstitutions**
> InstitutionsResponseBody ListFavoriteInstitutions (int? page = null, int? recordsPerPage = null)

List favorite institutions

This endpoint returns a paginated list containing institutions that have been set as the partner’s favorites, sorted by popularity. Please contact MX to set a list of favorites.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListFavoriteInstitutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List favorite institutions
                InstitutionsResponseBody result = apiInstance.ListFavoriteInstitutions(page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListFavoriteInstitutions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

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

<a name="listholdings"></a>
# **ListHoldings**
> HoldingsResponseBody ListHoldings (string userGuid, string fromDate = null, int? page = null, int? recordsPerPage = null, string toDate = null)

List holdings

This endpoint returns all holdings associated with the specified `user` across all accounts and members.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var fromDate = 2015-09-20;  // string | Filter holdings from this date. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 
            var toDate = 2019-10-20;  // string | Filter holdings to this date. (optional) 

            try
            {
                // List holdings
                HoldingsResponseBody result = apiInstance.ListHoldings(userGuid, fromDate, page, recordsPerPage, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListHoldings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **fromDate** | **string**| Filter holdings from this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **toDate** | **string**| Filter holdings to this date. | [optional] 

### Return type

[**HoldingsResponseBody**](HoldingsResponseBody.md)

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

<a name="listholdingsbyaccount"></a>
# **ListHoldingsByAccount**
> HoldingsResponseBody ListHoldingsByAccount (string accountGuid, string userGuid, string fromDate = null, int? page = null, int? recordsPerPage = null, string toDate = null)

List holdings by account

This endpoint returns all holdings associated with the specified `account`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListHoldingsByAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for the `account`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for the `user`.
            var fromDate = 2015-09-20;  // string | Filter holdings from this date. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 
            var toDate = 2019-10-20;  // string | Filter holdings to this date. (optional) 

            try
            {
                // List holdings by account
                HoldingsResponseBody result = apiInstance.ListHoldingsByAccount(accountGuid, userGuid, fromDate, page, recordsPerPage, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListHoldingsByAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for the &#x60;account&#x60;. | 
 **userGuid** | **string**| The unique id for the &#x60;user&#x60;. | 
 **fromDate** | **string**| Filter holdings from this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **toDate** | **string**| Filter holdings to this date. | [optional] 

### Return type

[**HoldingsResponseBody**](HoldingsResponseBody.md)

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

<a name="listholdingsbymember"></a>
# **ListHoldingsByMember**
> HoldingsResponseBody ListHoldingsByMember (string memberGuid, string userGuid, string fromDate = null, int? page = null, int? recordsPerPage = null, string toDate = null)

List holdings by member

This endpoint returns all holdings associated with the specified `member` across all accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListHoldingsByMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var fromDate = 2015-09-20;  // string | Filter holdings from this date. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 
            var toDate = 2019-10-20;  // string | Filter holdings to this date. (optional) 

            try
            {
                // List holdings by member
                HoldingsResponseBody result = apiInstance.ListHoldingsByMember(memberGuid, userGuid, fromDate, page, recordsPerPage, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListHoldingsByMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **fromDate** | **string**| Filter holdings from this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **toDate** | **string**| Filter holdings to this date. | [optional] 

### Return type

[**HoldingsResponseBody**](HoldingsResponseBody.md)

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

<a name="listinstitutioncredentials"></a>
# **ListInstitutionCredentials**
> CredentialsResponseBody ListInstitutionCredentials (string institutionCode, int? page = null, int? recordsPerPage = null)

List institution credentials

Use this endpoint to see which credentials will be needed to create a member for a specific institution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListInstitutionCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var institutionCode = chase;  // string | The institution_code of the institution.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List institution credentials
                CredentialsResponseBody result = apiInstance.ListInstitutionCredentials(institutionCode, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListInstitutionCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **institutionCode** | **string**| The institution_code of the institution. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**CredentialsResponseBody**](CredentialsResponseBody.md)

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

<a name="listinstitutions"></a>
# **ListInstitutions**
> InstitutionsResponseBody ListInstitutions (string name = null, int? page = null, int? recordsPerPage = null, bool? supportsAccountIdentification = null, bool? supportsAccountStatement = null, bool? supportsAccountVerification = null, bool? supportsTransactionHistory = null)

List institutions

This endpoint returns a list of institutions based on the specified search term or parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListInstitutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var name = chase;  // string | This will list only institutions in which the appended string appears. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 
            var supportsAccountIdentification = true;  // bool? | Filter only institutions which support account identification. (optional) 
            var supportsAccountStatement = true;  // bool? | Filter only institutions which support account statements. (optional) 
            var supportsAccountVerification = true;  // bool? | Filter only institutions which support account verification. (optional) 
            var supportsTransactionHistory = true;  // bool? | Filter only institutions which support extended transaction history. (optional) 

            try
            {
                // List institutions
                InstitutionsResponseBody result = apiInstance.ListInstitutions(name, page, recordsPerPage, supportsAccountIdentification, supportsAccountStatement, supportsAccountVerification, supportsTransactionHistory);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListInstitutions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| This will list only institutions in which the appended string appears. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **supportsAccountIdentification** | **bool?**| Filter only institutions which support account identification. | [optional] 
 **supportsAccountStatement** | **bool?**| Filter only institutions which support account statements. | [optional] 
 **supportsAccountVerification** | **bool?**| Filter only institutions which support account verification. | [optional] 
 **supportsTransactionHistory** | **bool?**| Filter only institutions which support extended transaction history. | [optional] 

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

<a name="listmanagedaccounts"></a>
# **ListManagedAccounts**
> AccountsResponseBody ListManagedAccounts (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List managed accounts

Use this endpoint to retrieve a list of all the partner-managed accounts associated with the given partner-manage member.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List managed accounts
                AccountsResponseBody result = apiInstance.ListManagedAccounts(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListManagedAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

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

<a name="listmanagedinstitutions"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List managed institutions
                InstitutionsResponseBody result = apiInstance.ListManagedInstitutions(page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListManagedInstitutions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

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

<a name="listmanagedmembers"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List managed members
                MembersResponseBody result = apiInstance.ListManagedMembers(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListManagedMembers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

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

<a name="listmanagedtransactions"></a>
# **ListManagedTransactions**
> TransactionsResponseBody ListManagedTransactions (string accountGuid, string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List managed transactions
                TransactionsResponseBody result = apiInstance.ListManagedTransactions(accountGuid, memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListManagedTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

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

<a name="listmemberchallenges"></a>
# **ListMemberChallenges**
> ChallengesResponseBody ListMemberChallenges (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List member challenges

Use this endpoint for information on what multi-factor authentication challenges need to be answered in order to aggregate a member. If the aggregation is not challenged, i.e., the member does not have a connection status of `CHALLENGED`, then code `204 No Content` will be returned. If the aggregation has been challenged, i.e., the member does have a connection status of `CHALLENGED`, then code `200 OK` will be returned - along with the corresponding credentials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListMemberChallengesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List member challenges
                ChallengesResponseBody result = apiInstance.ListMemberChallenges(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListMemberChallenges: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**ChallengesResponseBody**](ChallengesResponseBody.md)

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

<a name="listmembercredentials"></a>
# **ListMemberCredentials**
> CredentialsResponseBody ListMemberCredentials (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List member credentials

This endpoint returns an array which contains information on every non-MFA credential associated with a specific member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListMemberCredentialsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List member credentials
                CredentialsResponseBody result = apiInstance.ListMemberCredentials(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListMemberCredentials: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**CredentialsResponseBody**](CredentialsResponseBody.md)

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

<a name="listmembers"></a>
# **ListMembers**
> MembersResponseBody ListMembers (string userGuid, int? page = null, int? recordsPerPage = null)

List members

This endpoint returns an array which contains information on every member associated with a specific user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List members
                MembersResponseBody result = apiInstance.ListMembers(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListMembers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

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

<a name="listmerchants"></a>
# **ListMerchants**
> MerchantsResponseBody ListMerchants (int? page = null, int? recordsPerPage = null)

List merchants

This endpoint returns a paginated list of all the merchants in the MX system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListMerchantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List merchants
                MerchantsResponseBody result = apiInstance.ListMerchants(page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListMerchants: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**MerchantsResponseBody**](MerchantsResponseBody.md)

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

<a name="liststatementsbymember"></a>
# **ListStatementsByMember**
> StatementsResponseBody ListStatementsByMember (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List statements by member

Use this endpoint to get an array of available statements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListStatementsByMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List statements by member
                StatementsResponseBody result = apiInstance.ListStatementsByMember(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListStatementsByMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**StatementsResponseBody**](StatementsResponseBody.md)

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

<a name="listtaggings"></a>
# **ListTaggings**
> TaggingsResponseBody ListTaggings (string userGuid, int? page = null, int? recordsPerPage = null)

List taggings

Use this endpoint to retrieve a list of all the taggings associated with a specific user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTaggingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List taggings
                TaggingsResponseBody result = apiInstance.ListTaggings(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListTaggings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**TaggingsResponseBody**](TaggingsResponseBody.md)

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

<a name="listtags"></a>
# **ListTags**
> TagsResponseBody ListTags (string userGuid, int? page = null, int? recordsPerPage = null)

List tags

Use this endpoint to list all tags associated with the specified `user`. Each user includes the `Business` tag by default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List tags
                TagsResponseBody result = apiInstance.ListTags(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListTags: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**TagsResponseBody**](TagsResponseBody.md)

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

<a name="listtransactionrules"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List transaction rules
                TransactionRulesResponseBody result = apiInstance.ListTransactionRules(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListTransactionRules: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

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

<a name="listtransactions"></a>
# **ListTransactions**
> TransactionsResponseBody ListTransactions (string userGuid, string fromDate = null, int? page = null, int? recordsPerPage = null, string toDate = null)

List transactions

Requests to this endpoint return a list of transactions associated with the specified `user`, accross all members and accounts associated with that `user`.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var fromDate = 2015-09-20;  // string | Filter transactions from this date. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 
            var toDate = 2019-10-20;  // string | Filter transactions to this date. (optional) 

            try
            {
                // List transactions
                TransactionsResponseBody result = apiInstance.ListTransactions(userGuid, fromDate, page, recordsPerPage, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **fromDate** | **string**| Filter transactions from this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **toDate** | **string**| Filter transactions to this date. | [optional] 

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

<a name="listtransactionsbyaccount"></a>
# **ListTransactionsByAccount**
> TransactionsResponseBody ListTransactionsByAccount (string accountGuid, string userGuid, string fromDate = null, int? page = null, int? recordsPerPage = null, string toDate = null)

List transactions by account

This endpoint returns a list of the last 90 days of transactions associated with the specified account.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var fromDate = 2015-09-20;  // string | Filter transactions from this date. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 
            var toDate = 2019-10-20;  // string | Filter transactions to this date. (optional) 

            try
            {
                // List transactions by account
                TransactionsResponseBody result = apiInstance.ListTransactionsByAccount(accountGuid, userGuid, fromDate, page, recordsPerPage, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListTransactionsByAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **fromDate** | **string**| Filter transactions from this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **toDate** | **string**| Filter transactions to this date. | [optional] 

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

<a name="listtransactionsbymember"></a>
# **ListTransactionsByMember**
> TransactionsResponseBody ListTransactionsByMember (string memberGuid, string userGuid, string fromDate = null, int? page = null, int? recordsPerPage = null, string toDate = null)

List transactions by member

Requests to this endpoint return a list of transactions associated with the specified `member`, accross all accounts associated with that `member`.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var fromDate = 2015-09-20;  // string | Filter transactions from this date. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 
            var toDate = 2019-10-20;  // string | Filter transactions to this date. (optional) 

            try
            {
                // List transactions by member
                TransactionsResponseBody result = apiInstance.ListTransactionsByMember(memberGuid, userGuid, fromDate, page, recordsPerPage, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListTransactionsByMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **fromDate** | **string**| Filter transactions from this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **toDate** | **string**| Filter transactions to this date. | [optional] 

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

<a name="listtransactionsbytag"></a>
# **ListTransactionsByTag**
> TransactionsResponseBody ListTransactionsByTag (string tagGuid, string userGuid, string fromDate = null, int? page = null, int? recordsPerPage = null, string toDate = null)

List transactions by tag

Use this endpoint to get a list of all transactions associated with a particular tag according to the tag’s unique GUID. In other words, a list of all transactions that have been assigned to a particular tag using the create a tagging endpoint.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var tagGuid = TAG-aef36e72-6294-4c38-844d-e573e80aed52;  // string | The unique id for a `tag`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var fromDate = 2015-09-20;  // string | Filter transactions from this date. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 
            var toDate = 2019-10-20;  // string | Filter transactions to this date. (optional) 

            try
            {
                // List transactions by tag
                TransactionsResponseBody result = apiInstance.ListTransactionsByTag(tagGuid, userGuid, fromDate, page, recordsPerPage, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListTransactionsByTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGuid** | **string**| The unique id for a &#x60;tag&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **fromDate** | **string**| Filter transactions from this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 
 **toDate** | **string**| Filter transactions to this date. | [optional] 

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

<a name="listuseraccounts"></a>
# **ListUserAccounts**
> AccountsResponseBody ListUserAccounts (string userGuid, int? page = null, int? recordsPerPage = null)

List accounts

This endpoint returns a list of all the accounts associated with the specified `user`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListUserAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List accounts
                AccountsResponseBody result = apiInstance.ListUserAccounts(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListUserAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

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

<a name="listusers"></a>
# **ListUsers**
> UsersResponseBody ListUsers (int? page = null, int? recordsPerPage = null)

List users

Use this endpoint to list every user you've created in the MX Platform API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | Specify records per page. (optional) 

            try
            {
                // List users
                UsersResponseBody result = apiInstance.ListUsers(page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ListUsers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**UsersResponseBody**](UsersResponseBody.md)

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

<a name="readaccount"></a>
# **ReadAccount**
> AccountResponseBody ReadAccount (string accountGuid, string userGuid)

Read account

This endpoint returns the specified `account` resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read account
                AccountResponseBody result = apiInstance.ReadAccount(accountGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="readcategory"></a>
# **ReadCategory**
> CategoryResponseBody ReadCategory (string categoryGuid, string userGuid)

Read a custom category

Use this endpoint to read the attributes of either a default category or a custom category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var categoryGuid = CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874;  // string | The unique id for a `category`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read a custom category
                CategoryResponseBody result = apiInstance.ReadCategory(categoryGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadCategory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryGuid** | **string**| The unique id for a &#x60;category&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

### Return type

[**CategoryResponseBody**](CategoryResponseBody.md)

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

<a name="readdefaultcategory"></a>
# **ReadDefaultCategory**
> CategoryResponseBody ReadDefaultCategory (string categoryGuid)

Read a default category

Use this endpoint to read the attributes of a default category.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadDefaultCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var categoryGuid = CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874;  // string | The unique id for a `category`.

            try
            {
                // Read a default category
                CategoryResponseBody result = apiInstance.ReadDefaultCategory(categoryGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadDefaultCategory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryGuid** | **string**| The unique id for a &#x60;category&#x60;. | 

### Return type

[**CategoryResponseBody**](CategoryResponseBody.md)

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

<a name="readholding"></a>
# **ReadHolding**
> HoldingResponseBody ReadHolding (string holdingGuid, string userGuid)

Read holding

Use this endpoint to read the attributes of a specific `holding`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadHoldingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var holdingGuid = HOL-d65683e8-9eab-26bb-bcfd-ced159c9abe2;  // string | The unique id for a `holding`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read holding
                HoldingResponseBody result = apiInstance.ReadHolding(holdingGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadHolding: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **holdingGuid** | **string**| The unique id for a &#x60;holding&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

### Return type

[**HoldingResponseBody**](HoldingResponseBody.md)

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

<a name="readinstitution"></a>
# **ReadInstitution**
> InstitutionResponseBody ReadInstitution (string institutionCode)

Read institution

This endpoint returns information about the institution specified by `institution_code`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadInstitutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var institutionCode = chase;  // string | The institution_code of the institution.

            try
            {
                // Read institution
                InstitutionResponseBody result = apiInstance.ReadInstitution(institutionCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadInstitution: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **institutionCode** | **string**| The institution_code of the institution. | 

### Return type

[**InstitutionResponseBody**](InstitutionResponseBody.md)

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

<a name="readmanagedaccount"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read managed account
                AccountResponseBody result = apiInstance.ReadManagedAccount(accountGuid, memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadManagedAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="readmanagedmember"></a>
# **ReadManagedMember**
> MemberResponseBody ReadManagedMember (string memberGuid, string userGuid)

Read managed member

This endpoint returns the attributes of the specified partner-managed `member`.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read managed member
                MemberResponseBody result = apiInstance.ReadManagedMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadManagedMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="readmanagedtransaction"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read managed transaction
                TransactionResponseBody result = apiInstance.ReadManagedTransaction(accountGuid, memberGuid, transactionGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadManagedTransaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **transactionGuid** | **string**| The unique id for a &#x60;transaction&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="readmember"></a>
# **ReadMember**
> MemberResponseBody ReadMember (string memberGuid, string userGuid)

Read member

Use this endpoint to read the attributes of a specific member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read member
                MemberResponseBody result = apiInstance.ReadMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="readmemberstatus"></a>
# **ReadMemberStatus**
> MemberStatusResponseBody ReadMemberStatus (string memberGuid, string userGuid)

Read member status

This endpoint provides the status of the members most recent aggregation event. This is an important step in the aggregation process, and the results returned by this endpoint should determine what you do next in order to successfully aggregate a member. MX has introduced new, more detailed information on the current status of a members connection to a financial institution and the state of its aggregation - the connection_status field. These are intended to replace and expand upon the information provided in the status field, which will soon be deprecated; support for the status field remains for the time being.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadMemberStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read member status
                MemberStatusResponseBody result = apiInstance.ReadMemberStatus(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadMemberStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

### Return type

[**MemberStatusResponseBody**](MemberStatusResponseBody.md)

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

<a name="readmerchant"></a>
# **ReadMerchant**
> MerchantResponseBody ReadMerchant (string merchantGuid)

Read merchant

Returns information about a particular merchant, such as a logo, name, and website.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadMerchantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var merchantGuid = MCH-7ed79542-884d-2b1b-dd74-501c5cc9d25b;  // string | The unique id for a `merchant`.

            try
            {
                // Read merchant
                MerchantResponseBody result = apiInstance.ReadMerchant(merchantGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadMerchant: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantGuid** | **string**| The unique id for a &#x60;merchant&#x60;. | 

### Return type

[**MerchantResponseBody**](MerchantResponseBody.md)

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

<a name="readmerchantlocation"></a>
# **ReadMerchantLocation**
> MerchantLocationResponseBody ReadMerchantLocation (string merchantLocationGuid)

Read merchant location

This endpoint returns the specified merchant_location resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadMerchantLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var merchantLocationGuid = MCH-09466f0a-fb58-9d1a-bae2-2af0afbea621;  // string | The unique id for a `merchant_location`.

            try
            {
                // Read merchant location
                MerchantLocationResponseBody result = apiInstance.ReadMerchantLocation(merchantLocationGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadMerchantLocation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantLocationGuid** | **string**| The unique id for a &#x60;merchant_location&#x60;. | 

### Return type

[**MerchantLocationResponseBody**](MerchantLocationResponseBody.md)

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

<a name="readstatementbymember"></a>
# **ReadStatementByMember**
> StatementResponseBody ReadStatementByMember (string memberGuid, string statementGuid, string userGuid)

Read statement by member

Use this endpoint to read a JSON representation of the statement.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadStatementByMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var statementGuid = STA-737a344b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for a `statement`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read statement by member
                StatementResponseBody result = apiInstance.ReadStatementByMember(memberGuid, statementGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadStatementByMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **statementGuid** | **string**| The unique id for a &#x60;statement&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

### Return type

[**StatementResponseBody**](StatementResponseBody.md)

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

<a name="readtag"></a>
# **ReadTag**
> TagResponseBody ReadTag (string tagGuid, string userGuid)

Read tag

Use this endpoint to read the attributes of a particular tag according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var tagGuid = TAG-aef36e72-6294-4c38-844d-e573e80aed52;  // string | The unique id for a `tag`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read tag
                TagResponseBody result = apiInstance.ReadTag(tagGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGuid** | **string**| The unique id for a &#x60;tag&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

### Return type

[**TagResponseBody**](TagResponseBody.md)

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

<a name="readtagging"></a>
# **ReadTagging**
> TaggingResponseBody ReadTagging (string taggingGuid, string userGuid)

Read tagging

Use this endpoint to read the attributes of a `tagging` according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadTaggingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var taggingGuid = TGN-007f5486-17e1-45fc-8b87-8f03984430fe;  // string | The unique id for a `tagging`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read tagging
                TaggingResponseBody result = apiInstance.ReadTagging(taggingGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadTagging: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taggingGuid** | **string**| The unique id for a &#x60;tagging&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

### Return type

[**TaggingResponseBody**](TaggingResponseBody.md)

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

<a name="readtransaction"></a>
# **ReadTransaction**
> TransactionResponseBody ReadTransaction (string transactionGuid, string userGuid)

Read transaction

Requests to this endpoint will return the attributes of the specified `transaction`.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read transaction
                TransactionResponseBody result = apiInstance.ReadTransaction(transactionGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadTransaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionGuid** | **string**| The unique id for a &#x60;transaction&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="readtransactionrule"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var transactionRuleGuid = TXR-a080e0f9-a2d4-4d6f-9e03-672cc357a4d3;  // string | The unique id for a `transaction_rule`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read transaction rule
                TransactionRuleResponseBody result = apiInstance.ReadTransactionRule(transactionRuleGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadTransactionRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRuleGuid** | **string**| The unique id for a &#x60;transaction_rule&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

<a name="readuser"></a>
# **ReadUser**
> UserResponseBody ReadUser (string userGuid)

Read user

Use this endpoint to read the attributes of a specific user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Read user
                UserResponseBody result = apiInstance.ReadUser(userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ReadUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

### Return type

[**UserResponseBody**](UserResponseBody.md)

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

<a name="requestconnectwidgeturl"></a>
# **RequestConnectWidgetURL**
> ConnectWidgetResponseBody RequestConnectWidgetURL (string userGuid, ConnectWidgetRequestBody connectWidgetRequestBody)

Request connect widget url

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var connectWidgetRequestBody = new ConnectWidgetRequestBody(); // ConnectWidgetRequestBody | Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials)

            try
            {
                // Request connect widget url
                ConnectWidgetResponseBody result = apiInstance.RequestConnectWidgetURL(userGuid, connectWidgetRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.RequestConnectWidgetURL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **connectWidgetRequestBody** | [**ConnectWidgetRequestBody**](ConnectWidgetRequestBody.md)| Optional config options for WebView (is_mobile_webview, current_institution_code, current_member_guid, update_credentials) | 

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

<a name="requestoauthwindowuri"></a>
# **RequestOAuthWindowURI**
> OAuthWindowResponseBody RequestOAuthWindowURI (string memberGuid, string userGuid, string referralSource = null, bool? skipAggregation = null, string uiMessageWebviewUrlScheme = null)

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var referralSource = APP;  // string | Must be either `BROWSER` or `APP` depending on the implementation. Defaults to `BROWSER`. (optional) 
            var skipAggregation = false;  // bool? | Setting this parameter to `true` will prevent the member from automatically aggregating after being redirected from the authorization page. (optional) 
            var uiMessageWebviewUrlScheme = mx;  // string | A scheme for routing the user back to the application state they were previously in. (optional) 

            try
            {
                // Request oauth window uri
                OAuthWindowResponseBody result = apiInstance.RequestOAuthWindowURI(memberGuid, userGuid, referralSource, skipAggregation, uiMessageWebviewUrlScheme);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.RequestOAuthWindowURI: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **referralSource** | **string**| Must be either &#x60;BROWSER&#x60; or &#x60;APP&#x60; depending on the implementation. Defaults to &#x60;BROWSER&#x60;. | [optional] 
 **skipAggregation** | **bool?**| Setting this parameter to &#x60;true&#x60; will prevent the member from automatically aggregating after being redirected from the authorization page. | [optional] 
 **uiMessageWebviewUrlScheme** | **string**| A scheme for routing the user back to the application state they were previously in. | [optional] 

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

<a name="requestwidgeturl"></a>
# **RequestWidgetURL**
> WidgetResponseBody RequestWidgetURL (string userGuid, WidgetRequestBody widgetRequestBody, string acceptLanguage = null)

Request widget url

This endpoint allows partners to get a URL by passing the `widget_type` in the request body, as well as configuring it in several different ways. In the case of Connect, that means setting the `widget_type` to `connect_widget`. Partners may also pass an optional `Accept-Language` header as well as a number of configuration options. Note that this is a `POST` request.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var widgetRequestBody = new WidgetRequestBody(); // WidgetRequestBody | The widget url configuration options.
            var acceptLanguage = en-US;  // string | The desired language of the widget. (optional) 

            try
            {
                // Request widget url
                WidgetResponseBody result = apiInstance.RequestWidgetURL(userGuid, widgetRequestBody, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.RequestWidgetURL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **widgetRequestBody** | [**WidgetRequestBody**](WidgetRequestBody.md)| The widget url configuration options. | 
 **acceptLanguage** | **string**| The desired language of the widget. | [optional] 

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

<a name="resumeaggregation"></a>
# **ResumeAggregation**
> MemberResponseBody ResumeAggregation (string memberGuid, string userGuid, MemberResumeRequestBody memberResumeRequestBody)

Resume aggregation

This endpoint answers the challenges needed when a member has been challenged by multi-factor authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ResumeAggregationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var memberResumeRequestBody = new MemberResumeRequestBody(); // MemberResumeRequestBody | Member object with MFA challenge answers

            try
            {
                // Resume aggregation
                MemberResponseBody result = apiInstance.ResumeAggregation(memberGuid, userGuid, memberResumeRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.ResumeAggregation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **memberResumeRequestBody** | [**MemberResumeRequestBody**](MemberResumeRequestBody.md)| Member object with MFA challenge answers | 

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
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccountbymember"></a>
# **UpdateAccountByMember**
> AccountResponseBody UpdateAccountByMember (string accountGuid, string memberGuid, string userGuid, AccountUpdateRequestBody accountUpdateRequestBody)

Update account by member

This endpoint allows you to update certain attributes of an `account` resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateAccountByMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var accountUpdateRequestBody = new AccountUpdateRequestBody(); // AccountUpdateRequestBody | Account object to be created with optional parameters (is_hidden)

            try
            {
                // Update account by member
                AccountResponseBody result = apiInstance.UpdateAccountByMember(accountGuid, memberGuid, userGuid, accountUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateAccountByMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **accountUpdateRequestBody** | [**AccountUpdateRequestBody**](AccountUpdateRequestBody.md)| Account object to be created with optional parameters (is_hidden) | 

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

<a name="updatecategory"></a>
# **UpdateCategory**
> CategoryResponseBody UpdateCategory (string categoryGuid, string userGuid, CategoryUpdateRequestBody categoryUpdateRequestBody)

Update category

Use this endpoint to update the attributes of a custom category according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var categoryGuid = CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874;  // string | The unique id for a `category`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var categoryUpdateRequestBody = new CategoryUpdateRequestBody(); // CategoryUpdateRequestBody | Category object to be updated (While no single parameter is required, the `category` object cannot be empty)

            try
            {
                // Update category
                CategoryResponseBody result = apiInstance.UpdateCategory(categoryGuid, userGuid, categoryUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateCategory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryGuid** | **string**| The unique id for a &#x60;category&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **categoryUpdateRequestBody** | [**CategoryUpdateRequestBody**](CategoryUpdateRequestBody.md)| Category object to be updated (While no single parameter is required, the &#x60;category&#x60; object cannot be empty) | 

### Return type

[**CategoryResponseBody**](CategoryResponseBody.md)

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

<a name="updatemanagedaccount"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var managedAccountUpdateRequestBody = new ManagedAccountUpdateRequestBody(); // ManagedAccountUpdateRequestBody | Managed account object to be updated (While no single parameter is required, the request body can't be empty)

            try
            {
                // Update managed account
                AccountResponseBody result = apiInstance.UpdateManagedAccount(accountGuid, memberGuid, userGuid, managedAccountUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateManagedAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **managedAccountUpdateRequestBody** | [**ManagedAccountUpdateRequestBody**](ManagedAccountUpdateRequestBody.md)| Managed account object to be updated (While no single parameter is required, the request body can&#39;t be empty) | 

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

<a name="updatemanagedmember"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var managedMemberUpdateRequestBody = new ManagedMemberUpdateRequestBody(); // ManagedMemberUpdateRequestBody | Managed member object to be updated (While no single parameter is required, the request body can't be empty)

            try
            {
                // Update managed member
                MemberResponseBody result = apiInstance.UpdateManagedMember(memberGuid, userGuid, managedMemberUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateManagedMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **managedMemberUpdateRequestBody** | [**ManagedMemberUpdateRequestBody**](ManagedMemberUpdateRequestBody.md)| Managed member object to be updated (While no single parameter is required, the request body can&#39;t be empty) | 

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

<a name="updatemanagedtransaction"></a>
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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var accountGuid = ACT-06d7f44b-caae-0f6e-1384-01f52e75dcb1;  // string | The unique id for an `account`.
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var managedTransactionUpdateRequestBody = new ManagedTransactionUpdateRequestBody(); // ManagedTransactionUpdateRequestBody | Managed transaction object to be updated (While no single parameter is required, the request body can't be empty)

            try
            {
                // Update managed transaction
                TransactionResponseBody result = apiInstance.UpdateManagedTransaction(accountGuid, memberGuid, transactionGuid, userGuid, managedTransactionUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateManagedTransaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountGuid** | **string**| The unique id for an &#x60;account&#x60;. | 
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **transactionGuid** | **string**| The unique id for a &#x60;transaction&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **managedTransactionUpdateRequestBody** | [**ManagedTransactionUpdateRequestBody**](ManagedTransactionUpdateRequestBody.md)| Managed transaction object to be updated (While no single parameter is required, the request body can&#39;t be empty) | 

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

<a name="updatemember"></a>
# **UpdateMember**
> MemberResponseBody UpdateMember (string memberGuid, string userGuid, MemberUpdateRequestBody memberUpdateRequestBody)

Update member

Use this endpoint to update a members attributes. Only the credentials, id, and metadata parameters can be updated. To get a list of the required credentials for the member, use the list member credentials endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var memberUpdateRequestBody = new MemberUpdateRequestBody(); // MemberUpdateRequestBody | Member object to be updated (While no single parameter is required, the request body can't be empty)

            try
            {
                // Update member
                MemberResponseBody result = apiInstance.UpdateMember(memberGuid, userGuid, memberUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **memberUpdateRequestBody** | [**MemberUpdateRequestBody**](MemberUpdateRequestBody.md)| Member object to be updated (While no single parameter is required, the request body can&#39;t be empty) | 

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

<a name="updatetag"></a>
# **UpdateTag**
> TagResponseBody UpdateTag (string tagGuid, string userGuid, TagUpdateRequestBody tagUpdateRequestBody)

Update tag

Use this endpoint to update the name of a specific tag according to its unique GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var tagGuid = TAG-aef36e72-6294-4c38-844d-e573e80aed52;  // string | The unique id for a `tag`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var tagUpdateRequestBody = new TagUpdateRequestBody(); // TagUpdateRequestBody | Tag object to be updated with required parameter (tag_guid)

            try
            {
                // Update tag
                TagResponseBody result = apiInstance.UpdateTag(tagGuid, userGuid, tagUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGuid** | **string**| The unique id for a &#x60;tag&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **tagUpdateRequestBody** | [**TagUpdateRequestBody**](TagUpdateRequestBody.md)| Tag object to be updated with required parameter (tag_guid) | 

### Return type

[**TagResponseBody**](TagResponseBody.md)

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

<a name="updatetagging"></a>
# **UpdateTagging**
> TaggingResponseBody UpdateTagging (string taggingGuid, string userGuid, TaggingUpdateRequestBody taggingUpdateRequestBody)

Update tagging

Use this endpoint to update a tagging.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateTaggingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var taggingGuid = TGN-007f5486-17e1-45fc-8b87-8f03984430fe;  // string | The unique id for a `tagging`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var taggingUpdateRequestBody = new TaggingUpdateRequestBody(); // TaggingUpdateRequestBody | Tagging object to be updated with required parameter (tag_guid)

            try
            {
                // Update tagging
                TaggingResponseBody result = apiInstance.UpdateTagging(taggingGuid, userGuid, taggingUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateTagging: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taggingGuid** | **string**| The unique id for a &#x60;tagging&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **taggingUpdateRequestBody** | [**TaggingUpdateRequestBody**](TaggingUpdateRequestBody.md)| Tagging object to be updated with required parameter (tag_guid) | 

### Return type

[**TaggingResponseBody**](TaggingResponseBody.md)

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

<a name="updatetransaction"></a>
# **UpdateTransaction**
> TransactionResponseBody UpdateTransaction (string transactionGuid, string userGuid, TransactionUpdateRequestBody transactionUpdateRequestBody)

Update transaction

Use this endpoint to update the `description` of a specific transaction according to its unique GUID.

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var transactionGuid = TRN-810828b0-5210-4878-9bd3-f4ce514f90c4;  // string | The unique id for a `transaction`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var transactionUpdateRequestBody = new TransactionUpdateRequestBody(); // TransactionUpdateRequestBody | Transaction object to be updated with a new description

            try
            {
                // Update transaction
                TransactionResponseBody result = apiInstance.UpdateTransaction(transactionGuid, userGuid, transactionUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateTransaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionGuid** | **string**| The unique id for a &#x60;transaction&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **transactionUpdateRequestBody** | [**TransactionUpdateRequestBody**](TransactionUpdateRequestBody.md)| Transaction object to be updated with a new description | 

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

<a name="updatetransactionrule"></a>
# **UpdateTransactionRule**
> TransactionRuleResponseBody UpdateTransactionRule (string transactionRuleGuid, string userGuid, TransactionRuleUpdateRequestBody transactionRuleUpdateRequestBody)

Update transaction_rule

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
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var transactionRuleGuid = TXR-a080e0f9-a2d4-4d6f-9e03-672cc357a4d3;  // string | The unique id for a `transaction_rule`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var transactionRuleUpdateRequestBody = new TransactionRuleUpdateRequestBody(); // TransactionRuleUpdateRequestBody | TransactionRule object to be updated

            try
            {
                // Update transaction_rule
                TransactionRuleResponseBody result = apiInstance.UpdateTransactionRule(transactionRuleGuid, userGuid, transactionRuleUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateTransactionRule: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRuleGuid** | **string**| The unique id for a &#x60;transaction_rule&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **transactionRuleUpdateRequestBody** | [**TransactionRuleUpdateRequestBody**](TransactionRuleUpdateRequestBody.md)| TransactionRule object to be updated | 

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

<a name="updateuser"></a>
# **UpdateUser**
> UserResponseBody UpdateUser (string userGuid, UserUpdateRequestBody userUpdateRequestBody)

Update user

Use this endpoint to update the attributes of the specified user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.
            var userUpdateRequestBody = new UserUpdateRequestBody(); // UserUpdateRequestBody | User object to be updated (None of these parameters are required, but the user object cannot be empty.)

            try
            {
                // Update user
                UserResponseBody result = apiInstance.UpdateUser(userGuid, userUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.UpdateUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 
 **userUpdateRequestBody** | [**UserUpdateRequestBody**](UserUpdateRequestBody.md)| User object to be updated (None of these parameters are required, but the user object cannot be empty.) | 

### Return type

[**UserResponseBody**](UserResponseBody.md)

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

<a name="verifymember"></a>
# **VerifyMember**
> MemberResponseBody VerifyMember (string memberGuid, string userGuid)

Verify member

The verify endpoint begins a verification process for a member.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class VerifyMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MxPlatformApi(config);
            var memberGuid = MBR-7c6f361b-e582-15b6-60c0-358f12466b4b;  // string | The unique id for a `member`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique id for a `user`.

            try
            {
                // Verify member
                MemberResponseBody result = apiInstance.VerifyMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MxPlatformApi.VerifyMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique id for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique id for a &#x60;user&#x60;. | 

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

