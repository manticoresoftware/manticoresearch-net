# ManticoreSearch.Model.SearchRequest
Request object for search operation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Table** | **string** | The table to perform the search on | 
**Query** | [**SearchQuery**](SearchQuery.md) |  | [optional] 
**Join** | [**List&lt;Join&gt;**](Join.md) | Join clause to combine search data from multiple tables | [optional] 
**Highlight** | [**Highlight**](Highlight.md) |  | [optional] 
**Limit** | **int** | Maximum number of results to return | [optional] 
**Knn** | [**Knn**](Knn.md) |  | [optional] 
**Aggs** | [**Dictionary&lt;string, Aggregation&gt;**](Aggregation.md) | Defines aggregation settings for grouping results | [optional] 
**Expressions** | **Dictionary&lt;string, string&gt;** | Expressions to calculate additional values for the result | [optional] 
**MaxMatches** | **int** | Maximum number of matches allowed in the result | [optional] 
**Offset** | **int** | Starting point for pagination of the result | [optional] 
**Options** | **Object** | Additional search options | [optional] 
**Profile** | **bool** | Enable or disable profiling of the search request | [optional] 
**Sort** | **Object** | Sorting criteria for the search results | [optional] 
**Source** | **Object** | Specify which fields to include or exclude in the response | [optional] 
**TrackScores** | **bool** | Enable or disable result weight calculation used for sorting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

