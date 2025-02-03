# ManticoreSearch.Model.DeleteDocumentRequest
Payload for delete request. Documents can be deleted either one by one by specifying the document id or by providing a query object. For more information see  [Delete API](https://manual.manticoresearch.com/Deleting_documents) 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **string** | Index name | 
**Cluster** | **string** | Cluster name | [optional] 
**Id** | **long** | The ID of document for deletion | [optional] 
**Query** | **Object** | Defines the criteria to match documents for deletion | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

