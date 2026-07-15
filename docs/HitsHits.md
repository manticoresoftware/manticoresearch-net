# ManticoreSearch.Model.HitsHits
Search hit representing a matched document

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The ID of the matched document | [optional] 
**Score** | **UInt64** | The score of the matched document | [optional]
**Source** | **Object** | The source data of the matched document | [optional] 
**KnnDist** | **decimal** | The knn distance of the matched document returned for knn queries | [optional] 
**Highlight** | **Object** | The highlighting-related data of the matched document | [optional] 
**Table** | **string** | The table name of the matched document returned for percolate queries | [optional] 
**Type** | **string** | The type of the matched document returned for percolate queries | [optional] 
**Fields** | **Object** | The percolate-related fields of the matched document returned for percolate queries | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

