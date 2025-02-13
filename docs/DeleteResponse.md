# ManticoreSearch.Model.DeleteResponse
Response object for successful delete request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Table** | **string** | The name of the table from which the document was deleted | [optional] 
**Deleted** | **int** | Number of documents deleted | [optional] 
**Id** | **long** | The ID of the deleted document. If multiple documents are deleted, the ID of the first deleted document is returned | [optional] 
**Found** | **bool** | Indicates whether any documents to be deleted were found | [optional] 
**Result** | **string** | Result of the delete operation, typically &#39;deleted&#39; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

