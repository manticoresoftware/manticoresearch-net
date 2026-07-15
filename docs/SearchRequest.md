# ManticoreSearch.Model.SearchRequest
Request object for search operation. Either `table` (regular search) or `chat` (conversational search) must be provided. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Table** | **string** | The table to perform the search on | [optional] 
**Chat** | [**Chat**](Chat.md) |  | [optional] 
**Query** | [**SearchQuery**](SearchQuery.md) |  | [optional] 
**Join** | [**List&lt;Join&gt;**](Join.md) | Join clause to combine search data from multiple tables | [optional] 
**Highlight** | [**Highlight**](Highlight.md) |  | [optional] 
**Limit** | **int** | Maximum number of results to return | [optional] 
**Knn** | [**Knn**](Knn.md) | K-nearest neighbor search settings. Pass a single &#x60;knn&#x60; object or an array of objects for multi-vector search.  | [optional] 
**Hybrid** | [**Hybrid**](Hybrid.md) |  | [optional] 
**FacetFilterMode** | **FacetFilterMode** |  | [optional] 
**Aggs** | [**Dictionary&lt;string, Aggregation&gt;**](Aggregation.md) | Defines aggregation settings for grouping results | [optional] 
**Expressions** | **Dictionary&lt;string, string&gt;** | Expressions to calculate additional values for the result. Simpler alternative to &#x60;script_fields&#x60;; expression names must be lowercase.  | [optional] 
**ScriptFields** | [**Dictionary&lt;string, ScriptField&gt;**](ScriptField.md) | Named expressions computed at search time. Each value defines an inline script whose result is stored under the field name. For more information see [Expressions](https://manual.manticoresearch.com/Searching/Expressions#script_fields)  | [optional] 
**MaxMatches** | **int** | Maximum number of matches allowed in the result | [optional] 
**Offset** | **int** | Starting point for pagination of the result | [optional] 
**Options** | **Object** | Additional search options | [optional] 
**Profile** | **bool** | Enable or disable profiling of the search request | [optional] 
**Sort** | **Object** | Sorting criteria for the search results | [optional] 
**Source** | **Object** | Specify which fields to include or exclude in the response | [optional] 
**TrackScores** | **bool** | Enable or disable result weight calculation used for sorting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

