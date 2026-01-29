# MX.Platform.CSharp.Api.InstitutionsApi

All URIs are relative to *https://int-api.mx.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListFavoriteInstitutions**](InstitutionsApi.md#listfavoriteinstitutions) | **GET** /institutions/favorites | List favorite institutions |
| [**ListInstitutionCredentials**](InstitutionsApi.md#listinstitutioncredentials) | **GET** /institutions/{institution_code}/credentials | List institution credentials |
| [**ListInstitutions**](InstitutionsApi.md#listinstitutions) | **GET** /institutions | List institutions |
| [**ReadInstitution**](InstitutionsApi.md#readinstitution) | **GET** /institutions/{institution_code} | Read institution |

<a id="listfavoriteinstitutions"></a>
# **ListFavoriteInstitutions**
> InstitutionsResponseBody ListFavoriteInstitutions (List<string>? isoCountryCode = null, int? page = null, int? recordsPerPage = null)

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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var isoCountryCode = new List<string>?(); // List<string>? | An array of strings that filters institutions in the widget by the specified country code. Acceptable codes include `US`, `CA`, and `MX` (Mexico). (optional) 
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List favorite institutions
                InstitutionsResponseBody result = apiInstance.ListFavoriteInstitutions(isoCountryCode, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ListFavoriteInstitutions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFavoriteInstitutionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List favorite institutions
    ApiResponse<InstitutionsResponseBody> response = apiInstance.ListFavoriteInstitutionsWithHttpInfo(isoCountryCode, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstitutionsApi.ListFavoriteInstitutionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **isoCountryCode** | [**List&lt;string&gt;?**](string.md) | An array of strings that filters institutions in the widget by the specified country code. Acceptable codes include &#x60;US&#x60;, &#x60;CA&#x60;, and &#x60;MX&#x60; (Mexico). | [optional]  |
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

<a id="listinstitutioncredentials"></a>
# **ListInstitutionCredentials**
> CredentialsResponseBody ListInstitutionCredentials (string institutionCode, int? page = null, int? recordsPerPage = null)

List institution credentials

Use this endpoint to see which credentials will be needed to create a member for a specific institution.  Passing an invalid `institution_code` returns a `404`. 

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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var institutionCode = mxbank;  // string | The institution_code of the institution.
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 

            try
            {
                // List institution credentials
                CredentialsResponseBody result = apiInstance.ListInstitutionCredentials(institutionCode, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ListInstitutionCredentials: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInstitutionCredentialsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List institution credentials
    ApiResponse<CredentialsResponseBody> response = apiInstance.ListInstitutionCredentialsWithHttpInfo(institutionCode, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstitutionsApi.ListInstitutionCredentialsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **institutionCode** | **string** | The institution_code of the institution. |  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |

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

<a id="listinstitutions"></a>
# **ListInstitutions**
> InstitutionsResponseBody ListInstitutions (string? name = null, List<string>? isoCountryCode = null, int? page = null, int? recordsPerPage = null, bool? supportsAccountIdentification = null, bool? supportsAccountStatement = null, bool? supportsAccountVerification = null, bool? supportsTransactionHistory = null)

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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var name = mxbank;  // string? | This will list only institutions in which the appended string appears. (optional) 
            var isoCountryCode = new List<string>?(); // List<string>? | An array of strings that filters institutions in the widget by the specified country code. Acceptable codes include `US`, `CA`, and `MX` (Mexico). (optional) 
            var page = 1;  // int? | Results are paginated. Specify current page. (optional) 
            var recordsPerPage = 10;  // int? | This specifies the number of records to be returned on each page. Defaults to `25`. The valid range is from `10` to `1000`. If the value exceeds `1000`, the default value of `25` will be used instead. (optional) 
            var supportsAccountIdentification = true;  // bool? | Filter only institutions which support account identification. (optional) 
            var supportsAccountStatement = true;  // bool? | Filter only institutions which support account statements. (optional) 
            var supportsAccountVerification = true;  // bool? | Filter only institutions which support account verification. (optional) 
            var supportsTransactionHistory = true;  // bool? | Filter only institutions which support extended transaction history. (optional) 

            try
            {
                // List institutions
                InstitutionsResponseBody result = apiInstance.ListInstitutions(name, isoCountryCode, page, recordsPerPage, supportsAccountIdentification, supportsAccountStatement, supportsAccountVerification, supportsTransactionHistory);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ListInstitutions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInstitutionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List institutions
    ApiResponse<InstitutionsResponseBody> response = apiInstance.ListInstitutionsWithHttpInfo(name, isoCountryCode, page, recordsPerPage, supportsAccountIdentification, supportsAccountStatement, supportsAccountVerification, supportsTransactionHistory);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstitutionsApi.ListInstitutionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** | This will list only institutions in which the appended string appears. | [optional]  |
| **isoCountryCode** | [**List&lt;string&gt;?**](string.md) | An array of strings that filters institutions in the widget by the specified country code. Acceptable codes include &#x60;US&#x60;, &#x60;CA&#x60;, and &#x60;MX&#x60; (Mexico). | [optional]  |
| **page** | **int?** | Results are paginated. Specify current page. | [optional]  |
| **recordsPerPage** | **int?** | This specifies the number of records to be returned on each page. Defaults to &#x60;25&#x60;. The valid range is from &#x60;10&#x60; to &#x60;1000&#x60;. If the value exceeds &#x60;1000&#x60;, the default value of &#x60;25&#x60; will be used instead. | [optional]  |
| **supportsAccountIdentification** | **bool?** | Filter only institutions which support account identification. | [optional]  |
| **supportsAccountStatement** | **bool?** | Filter only institutions which support account statements. | [optional]  |
| **supportsAccountVerification** | **bool?** | Filter only institutions which support account verification. | [optional]  |
| **supportsTransactionHistory** | **bool?** | Filter only institutions which support extended transaction history. | [optional]  |

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

<a id="readinstitution"></a>
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
            config.BasePath = "https://int-api.mx.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new InstitutionsApi(config);
            var institutionCode = mxbank;  // string | The institution_code of the institution.

            try
            {
                // Read institution
                InstitutionResponseBody result = apiInstance.ReadInstitution(institutionCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.ReadInstitution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadInstitutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read institution
    ApiResponse<InstitutionResponseBody> response = apiInstance.ReadInstitutionWithHttpInfo(institutionCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstitutionsApi.ReadInstitutionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **institutionCode** | **string** | The institution_code of the institution. |  |

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

