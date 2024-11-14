# ManticoreSearch.Model.SuccessResponse
Response object indicating the success of an operation, such as inserting or updating a document

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **string** | Name of the document index | [optional] 
**Table** | **string** | Name of the document table (alias of index) | [optional] 
**Id** | **long** | ID of the document affected by the request operation | [optional] 
**Created** | **bool** | Indicates whether the document was created as a result of the operation | [optional] 
**Result** | **string** | Result of the operation, typically &#39;created&#39;, &#39;updated&#39;, or &#39;deleted&#39; | [optional] 
**Found** | **bool** | Indicates whether the document was found in the index | [optional] 
**Status** | **int** | HTTP status code representing the result of the operation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

