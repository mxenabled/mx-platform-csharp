# MX.Platform.CSharp.Api.CategoriesApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCategory**](CategoriesApi.md#createcategory) | **POST** /users/{user_guid}/categories | Create category |
| [**DeleteCategory**](CategoriesApi.md#deletecategory) | **DELETE** /users/{user_guid}/categories/{category_guid} | Delete category |
| [**ListCategories**](CategoriesApi.md#listcategories) | **GET** /users/{user_guid}/categories | List categories |
| [**ListDefaultCategories**](CategoriesApi.md#listdefaultcategories) | **GET** /categories/default | List default categories |
| [**ListDefaultCategoriesByUser**](CategoriesApi.md#listdefaultcategoriesbyuser) | **GET** /users/{user_guid}/categories/default | List default categories by user |
| [**ReadCategory**](CategoriesApi.md#readcategory) | **GET** /users/{user_guid}/categories/{category_guid} | Read a custom category |
| [**ReadDefaultCategory**](CategoriesApi.md#readdefaultcategory) | **GET** /categories/{category_guid} | Read a default category |
| [**UpdateCategory**](CategoriesApi.md#updatecategory) | **PUT** /users/{user_guid}/categories/{category_guid} | Update category |

<a id="createcategory"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CategoriesApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var categoryCreateRequestBody = new CategoryCreateRequestBody(); // CategoryCreateRequestBody | Custom category object to be created

            try
            {
                // Create category
                CategoryResponseBody result = apiInstance.CreateCategory(userGuid, categoryCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.CreateCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create category
    ApiResponse<CategoryResponseBody> response = apiInstance.CreateCategoryWithHttpInfo(userGuid, categoryCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.CreateCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **categoryCreateRequestBody** | [**CategoryCreateRequestBody**](CategoryCreateRequestBody.md) | Custom category object to be created |  |

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

<a id="deletecategory"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CategoriesApi(config);
            var categoryGuid = CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874;  // string | The unique id for a `category`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Delete category
                apiInstance.DeleteCategory(categoryGuid, userGuid);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.DeleteCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete category
    apiInstance.DeleteCategoryWithHttpInfo(categoryGuid, userGuid);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.DeleteCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryGuid** | **string** | The unique id for a &#x60;category&#x60;. |  |
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

<a id="listcategories"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CategoriesApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List categories
                CategoriesResponseBody result = apiInstance.ListCategories(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.ListCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List categories
    ApiResponse<CategoriesResponseBody> response = apiInstance.ListCategoriesWithHttpInfo(userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.ListCategoriesWithHttpInfo: " + e.Message);
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

<a id="listdefaultcategories"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CategoriesApi(config);
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `100`. If the value exceeds `100`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List default categories
                CategoriesResponseBody result = apiInstance.ListDefaultCategories(page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.ListDefaultCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDefaultCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List default categories
    ApiResponse<CategoriesResponseBody> response = apiInstance.ListDefaultCategoriesWithHttpInfo(page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.ListDefaultCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;100&#x60;. If the value exceeds &#x60;100&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

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

<a id="listdefaultcategoriesbyuser"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CategoriesApi(config);
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List default categories by user
                CategoriesResponseBody result = apiInstance.ListDefaultCategoriesByUser(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.ListDefaultCategoriesByUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDefaultCategoriesByUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List default categories by user
    ApiResponse<CategoriesResponseBody> response = apiInstance.ListDefaultCategoriesByUserWithHttpInfo(userGuid, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.ListDefaultCategoriesByUserWithHttpInfo: " + e.Message);
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

<a id="readcategory"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CategoriesApi(config);
            var categoryGuid = CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874;  // string | The unique id for a `category`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.

            try
            {
                // Read a custom category
                CategoryResponseBody result = apiInstance.ReadCategory(categoryGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.ReadCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a custom category
    ApiResponse<CategoryResponseBody> response = apiInstance.ReadCategoryWithHttpInfo(categoryGuid, userGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.ReadCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryGuid** | **string** | The unique id for a &#x60;category&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |

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

<a id="readdefaultcategory"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CategoriesApi(config);
            var categoryGuid = CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874;  // string | The unique id for a `category`.

            try
            {
                // Read a default category
                CategoryResponseBody result = apiInstance.ReadDefaultCategory(categoryGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.ReadDefaultCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadDefaultCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read a default category
    ApiResponse<CategoryResponseBody> response = apiInstance.ReadDefaultCategoryWithHttpInfo(categoryGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.ReadDefaultCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryGuid** | **string** | The unique id for a &#x60;category&#x60;. |  |

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

<a id="updatecategory"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CategoriesApi(config);
            var categoryGuid = CAT-7829f71c-2e8c-afa5-2f55-fa3634b89874;  // string | The unique id for a `category`.
            var userGuid = USR-fa7537f3-48aa-a683-a02a-b18940482f54;  // string | The unique identifier for a `user`, beginning with the prefix `USR-`.
            var categoryUpdateRequestBody = new CategoryUpdateRequestBody(); // CategoryUpdateRequestBody | Category object to be updated (While no single parameter is required, the `category` object cannot be empty)

            try
            {
                // Update category
                CategoryResponseBody result = apiInstance.UpdateCategory(categoryGuid, userGuid, categoryUpdateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CategoriesApi.UpdateCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update category
    ApiResponse<CategoryResponseBody> response = apiInstance.UpdateCategoryWithHttpInfo(categoryGuid, userGuid, categoryUpdateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CategoriesApi.UpdateCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryGuid** | **string** | The unique id for a &#x60;category&#x60;. |  |
| **userGuid** | **string** | The unique identifier for a &#x60;user&#x60;, beginning with the prefix &#x60;USR-&#x60;. |  |
| **categoryUpdateRequestBody** | [**CategoryUpdateRequestBody**](CategoryUpdateRequestBody.md) | Category object to be updated (While no single parameter is required, the &#x60;category&#x60; object cannot be empty) |  |

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

