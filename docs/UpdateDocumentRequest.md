# ManticoreSearch.Model.UpdateDocumentRequest
Payload for updating a document or multiple documents in a table

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Table** | **string** | Name of the document table | 
**Cluster** | **string** | Name of the document cluster | [optional] 
**Doc** | **Object** | Object containing the document fields to update | 
**Id** | **UInt64** | Document ID | [optional]
**Query** | [**QueryFilter**](QueryFilter.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

