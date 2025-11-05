# MX.Platform.CSharp.Model.MemberCreateRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientRedirectUrl** | **string** |  | [optional] 
**EnableApp2app** | **bool** | This indicates whether OAuth app2app behavior is enabled for institutions that support it. Defaults to &#x60;true&#x60;. When set to &#x60;false&#x60;, any &#x60;oauth_window_uri&#x60; generated will **not** direct the end user to the institution&#39;s mobile application. This setting is not persistent. This setting currently only affects Chase institutions.  | [optional] 
**Member** | [**MemberCreateRequest**](MemberCreateRequest.md) |  | [optional] 
**ReferralSource** | **string** |  | [optional] 
**UiMessageWebviewUrlScheme** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

