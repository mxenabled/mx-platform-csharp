# MX.Platform.CSharp.Model.ACHReturnCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountGuid** | **string** | The unique identifier for the account associated with the transaction. Defined by MX. | 
**AccountNumberLastFour** | **string** | The last 4 digits of the account number used for the transaction by the Originating Depository Financial Institution (ODFI). | [optional] 
**AchInitiatedAt** | **string** | The date and time when the transaction was initiated by the Originating Depository Financial Institution (ODFI) in ISO 8601 format without timestamp. | [optional] 
**CorrectedAccountNumber** | **string** | The account number correction reported by the RDFI. Populate only if the &#x60;resolution_code&#x60; is &#x60;NOTICE_OF_CHANGE&#x60;. | [optional] 
**CorrectedRoutingNumber** | **string** | The routing number correction reported by the RDFI. Populate only if the &#x60;resolution_code&#x60; is &#x60;NOTICE_OF_CHANGE&#x60;. Must be a valid 9-digit routing number format. | [optional] 
**Id** | **string** | Client-defined identifier for this specific return submission. Allows you to track and reference you requests. | 
**MemberGuid** | **string** | The unique identifier for the member associated with the transaction. Defined by MX. | 
**ReturnAccountNumber** | **string** | Incorrect account number used in the ACH transaction. | [optional] 
**ReturnCode** | **string** | The associated ACH return code and notice of change code (for example, R02, R03, R04, R05, R20, NOC). See [Return Codes](/api-reference/platform-api/reference/ach-return-fields#return-codes) for a complete list. | 
**ReturnNotes** | **string** | Notes that you set to inform MX on internal ACH processing. | [optional] 
**ReturnRoutingNumber** | **string** | Incorrect routing number used in the ACH transaction. | [optional] 
**ReturnedAt** | **string** | The date and time when the return was reported by the Receiving Financial Depository Institution (RDFI) in ISO 8601 format without timestamp. | [optional] 
**SecCode** | **string** | The SEC code (Standard Entry Class Code)–a three-letter code describing how a payment was authorized (for example, &#x60;WEB&#x60;). See [SEC Codes](/api-reference/platform-api/reference/ach-return-fields#sec-codes) for a complete list. | [optional] 
**TransactionAmount** | **decimal** | The amount of the transaction. | [optional] 
**TransactionAmountRange** | **decimal** | The transaction amount range, used for impact assessment. | [optional] 
**UserGuid** | **string** | MX-defined identifier for the user associated with the ACH return. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

