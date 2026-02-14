# ManticoreSearch.Model.Knn
Object representing a k-nearest neighbor search query

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Field to perform the k-nearest neighbor search on | 
**K** | **int** | The number of nearest neighbors to return | 
**Query** | [**KnnQuery**](KnnQuery.md) |  | [optional] 
**QueryVector** | **List&lt;decimal&gt;** | The vector used as input for the KNN search | [optional] 
**DocId** | **UInt64** | The docuemnt ID used as input for the KNN search | [optional] 
**Ef** | **int** | Optional parameter controlling the accuracy of the search | [optional] 
**Rescore** | **bool** | Optional parameter enabling KNN rescoring (disabled by default) | [optional] 
**Oversampling** | **decimal** | Optional parameter setting a factor by which k is multiplied when executing the KNN search | [optional] 
**Filter** | [**QueryFilter**](QueryFilter.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

