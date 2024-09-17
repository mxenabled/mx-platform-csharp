# MX.Platform.CSharp.Model.TransactionCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** |  | 
**Date** | **string** |  | 
**Description** | **string** |  | 
**Type** | **string** | The type of transaction, which must be CREDIT or DEBIT. See Transaction Fields for more information. | 
**CategoryGuid** | **string** | Unique identifier of the category. | [optional] 
**CurrencyCode** | **string** |  | [optional] 
**HasBeenViewed** | **bool** |  | [optional] 
**IsHidden** | **bool** |  | [optional] 
**IsInternational** | **bool** |  | [optional] 
**Memo** | **string** |  | [optional] 
**Metadata** | **string** |  | [optional] 
**SkipWebhook** | **bool** | When set to true, this parameter will prevent a webhook from being triggered by the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

