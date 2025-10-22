# ManticoreSearch.Model.SearchResponse
Response object containing the results of a search request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Took** | **int** | Time taken to execute the search | [optional] 
**TimedOut** | **bool** | Indicates whether the search operation timed out | [optional] 
**Aggregations** | **Object** | Aggregated search results grouped by the specified criteria | [optional] 
**Hits** | [**SearchResponseHits**](SearchResponseHits.md) |  | [optional] 
**Profile** | **Object** | Profile information about the search execution, if profiling is enabled | [optional] 
**Scroll** | **string** | Scroll token to be used fo pagination | [optional] 
**Warning** | **Object** | Warnings encountered during the search operation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

