# ManticoreSearch.Model.DeleteDocumentRequest
Payload for delete request. Documents can be deleted either one by one by specifying the document id or by providing a query object. For more information see  [Delete API](https://manual.manticoresearch.com/Deleting_documents) 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **string** | Index name | 
**Cluster** | **string** | cluster name | [optional] 
**Id** | **long** | Document ID | [optional] 
**Query** | **Object** | Query tree object | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

