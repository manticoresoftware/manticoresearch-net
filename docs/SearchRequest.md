# ManticoreSearch.Model.SearchRequest
Payload for search operation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **string** |  | [default to ""]
**Query** | **Object** |  | [optional] 
**FulltextFilter** | **Object** |  | [optional] 
**AttrFilter** | **Object** |  | [optional] 
**Limit** | **int** |  | [optional] 
**Offset** | **int** |  | [optional] 
**MaxMatches** | **int** |  | [optional] 
**Sort** | **List&lt;Object&gt;** |  | [optional] 
**SortOld** | **List&lt;Object&gt;** |  | [optional] 
**Aggs** | [**List&lt;Aggregation&gt;**](Aggregation.md) |  | [optional] 
**Expressions** | **List&lt;Object&gt;** |  | [optional] 
**Highlight** | [**Highlight**](Highlight.md) |  | [optional] 
**Source** | **Object** |  | [optional] 
**Options** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**Profile** | **bool** |  | [optional] 
**TrackScores** | **bool** |  | [optional] 

[[Using in search requests]](SearchApi.md#SearchRequest)


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

