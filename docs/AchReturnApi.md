# MX.Platform.CSharp.Api.AchReturnApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateACHReturn**](AchReturnApi.md#createachreturn) | **POST** /ach_returns | Create ACH Return |
| [**ListACHRetruns**](AchReturnApi.md#listachretruns) | **GET** /ach_returns | List ACH Returns |
| [**ReadACHRetrun**](AchReturnApi.md#readachretrun) | **GET** /ach_returns/{ach_return_guid} | Read ACH Return |

<a id="createachreturn"></a>
# **CreateACHReturn**
> ACHReturnResponseBody CreateACHReturn (ACHReturnCreateRequestBody aCHReturnCreateRequestBody)

Create ACH Return

:::warning The features documented here are in a beta state, and this documentation is considered draft material subject to frequent change. :::  Use this endpoint to create an ACH return in our system. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class CreateACHReturnExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AchReturnApi(config);
            var aCHReturnCreateRequestBody = new ACHReturnCreateRequestBody(); // ACHReturnCreateRequestBody | ACH return object to be created.

            try
            {
                // Create ACH Return
                ACHReturnResponseBody result = apiInstance.CreateACHReturn(aCHReturnCreateRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AchReturnApi.CreateACHReturn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateACHReturnWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create ACH Return
    ApiResponse<ACHReturnResponseBody> response = apiInstance.CreateACHReturnWithHttpInfo(aCHReturnCreateRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AchReturnApi.CreateACHReturnWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aCHReturnCreateRequestBody** | [**ACHReturnCreateRequestBody**](ACHReturnCreateRequestBody.md) | ACH return object to be created. |  |

### Return type

[**ACHReturnResponseBody**](ACHReturnResponseBody.md)

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

<a id="listachretruns"></a>
# **ListACHRetruns**
> ACHReturnsResponseBody ListACHRetruns (string? institutionGuid = null, string? returnedAt = null, string? resolvedStatusAt = null, string? returnCode = null, string? returnStatus = null, int? page = null, int? recordsPerPage = null)

List ACH Returns

:::warning The features documented here are in a beta state, and this documentation is considered draft material subject to frequent change. :::  Use this endpoint to get all ACH returns. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ListACHRetrunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AchReturnApi(config);
            var institutionGuid = "institutionGuid_example";  // string? | The identifier for the institution associated with the ACH return. Defined by MX. (optional) 
            var returnedAt = 2025-02-13T18:09:00+00:00;  // string? | The date and time when the return was reported by the Receiving Financial Depository Institution (RDFI) in ISO 8601 format without timestamp. (optional) 
            var resolvedStatusAt = 2025-02-13T18:09:00+00:00;  // string? | The date and time when the return was resolved by the Receiving Financial Depository Institution (RDFI) in ISO 8601 format without timestamp (optional) 
            var returnCode = "returnCode_example";  // string? | The associated ACH return code and notice of change code. See [Return Codes](/api-reference/platform-api/reference/ach-return-fields#return-codes) for a complete list. (optional) 
            var returnStatus = SUBMITTED;  // string? | The status of the return. See [Return Statuses](/api-reference/platform-api/reference/ach-return-fields#return-status) for a complete list. (optional) 
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `100`. If the value exceeds `100`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List ACH Returns
                ACHReturnsResponseBody result = apiInstance.ListACHRetruns(institutionGuid, returnedAt, resolvedStatusAt, returnCode, returnStatus, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AchReturnApi.ListACHRetruns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListACHRetrunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List ACH Returns
    ApiResponse<ACHReturnsResponseBody> response = apiInstance.ListACHRetrunsWithHttpInfo(institutionGuid, returnedAt, resolvedStatusAt, returnCode, returnStatus, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AchReturnApi.ListACHRetrunsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **institutionGuid** | **string?** | The identifier for the institution associated with the ACH return. Defined by MX. | [optional]  |
| **returnedAt** | **string?** | The date and time when the return was reported by the Receiving Financial Depository Institution (RDFI) in ISO 8601 format without timestamp. | [optional]  |
| **resolvedStatusAt** | **string?** | The date and time when the return was resolved by the Receiving Financial Depository Institution (RDFI) in ISO 8601 format without timestamp | [optional]  |
| **returnCode** | **string?** | The associated ACH return code and notice of change code. See [Return Codes](/api-reference/platform-api/reference/ach-return-fields#return-codes) for a complete list. | [optional]  |
| **returnStatus** | **string?** | The status of the return. See [Return Statuses](/api-reference/platform-api/reference/ach-return-fields#return-status) for a complete list. | [optional]  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;100&#x60;. If the value exceeds &#x60;100&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

### Return type

[**ACHReturnsResponseBody**](ACHReturnsResponseBody.md)

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

<a id="readachretrun"></a>
# **ReadACHRetrun**
> ACHReturnResponseBody ReadACHRetrun (string achReturnGuid)

Read ACH Return

:::warning The features documented here are in a beta state, and this documentation is considered draft material subject to frequent change. :::  Use this endpoint to get an ACH return by its `guid` or `id`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace Example
{
    public class ReadACHRetrunExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AchReturnApi(config);
            var achReturnGuid = "achReturnGuid_example";  // string | The unique identifier (`guid`) for the ACH return. Defined by MX.

            try
            {
                // Read ACH Return
                ACHReturnResponseBody result = apiInstance.ReadACHRetrun(achReturnGuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AchReturnApi.ReadACHRetrun: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadACHRetrunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read ACH Return
    ApiResponse<ACHReturnResponseBody> response = apiInstance.ReadACHRetrunWithHttpInfo(achReturnGuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AchReturnApi.ReadACHRetrunWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **achReturnGuid** | **string** | The unique identifier (&#x60;guid&#x60;) for the ACH return. Defined by MX. |  |

### Return type

[**ACHReturnResponseBody**](ACHReturnResponseBody.md)

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

