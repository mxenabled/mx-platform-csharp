# MX.Platform.CSharp.Model.BudgetResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | A goal amount set by the user for a category&#39;s transaction total during a month. | [optional] 
**CategoryGuid** | **string** | Unique identifier for the budget category. Defined by MX. | [optional] 
**CreatedAt** | **string** | Date and time the budget was created, represented in ISO 8601 format with timestamp. | [optional] 
**Guid** | **string** | Unique identifier for the budget. Defined by MX. | [optional] 
**IsExceeded** | **bool** | If the budget has been exceeded, this field will be true. Otherwise, this field will be false. | [optional] 
**IsOffTrack** | **bool** | If the budget is off track, this field will be true. Otherwise, this field will be false. | [optional] 
**Metadata** | **string** | Additional information a partner can store on the budget. | [optional] 
**Name** | **string** | The name of the budget that is visible to the user (ie \&quot;Food\&quot;, \&quot;Bills\&quot;, \&quot;Entertainment\&quot;, etc). | [optional] 
**OffTrackPercentage** | **decimal?** | The percentage amount of off track spending. (Deprecated). | [optional] 
**ParentGuid** | **string** | Unique identifier for the parent budget. Defined by MX. | [optional] 
**PercentSpent** | **decimal?** | The percentage of a budget that has been spent during the current calendar month Calculated as the transaction total divided by the amount and then multiplied by 100.A value of zero will be returned when &#x60;amount&#x60; is zero. | [optional] 
**ProjectedSpending** | **decimal** | The projected amount of spending for the budget. | [optional] 
**Revision** | **int** | The revision number of this budget record. | [optional] 
**TransactionTotal** | **Object** | The cumulative amount of all transactions under the budget. | [optional] 
**UpdatedAt** | **Object** | Date and time the budget was updated, represented in ISO 8601 format with timestamp. | [optional] 
**UserGuid** | **Object** | Unique identifier for the user. Defined by MX. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

