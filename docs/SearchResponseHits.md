# ManticoreSearch.Model.SearchResponseHits
Object containing the search hits, which represent the documents that matched the query.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxScore** | **int** | Maximum score among the matched documents | [optional] 
**Total** | **int** | Total number of matched documents | [optional] 
**TotalRelation** | **string** | Indicates whether the total number of hits is accurate or an estimate | [optional] 
**Hits** | [**List&lt;HitsHits&gt;**](HitsHits.md) | Array of hit objects, each representing a matched document | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

