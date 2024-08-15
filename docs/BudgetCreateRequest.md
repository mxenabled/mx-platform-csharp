# MX.Platform.CSharp.Model.BudgetCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryGuid** | **string** | Unique identifier of the category. | 
**ParentGuid** | **string** | Unique identifier of the parent budget. This is only required when creating a budget on a sub-category. | 
**Amount** | **int** | Amount of the budget. | [optional] 
**Metadata** | **string** | Additional information a partner can store on the budget. | [optional] 
**SkipWebhook** | **bool** | When set to true, this parameter will prevent a webhook from being triggered by the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

