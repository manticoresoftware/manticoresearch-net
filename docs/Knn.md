# ManticoreSearch.Model.Knn
Object representing a k-nearest neighbor search query

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Field to perform the k-nearest neighbor search on | 
**K** | **int** | The number of nearest neighbors to return | 
**Query** | [**KnnQuery**](KnnQuery.md) |  | [optional] 
**QueryVector** | **List&lt;decimal&gt;** | The vector used as input for the KNN search | [optional] 
**DocId** | **UInt64** | The document ID used as input for the KNN search | [optional]
**Ef** | **int** | Optional parameter controlling the accuracy of the search | [optional] 
**Filter** | [**QueryFilter**](QueryFilter.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

