# ManticoreSearch.Model.SearchResponse
Response object containing search results. For conversational search requests that include a `chat` object, the optional chat fields below are also populated. For conversational search response fields see [Conversational search](https://manual.manticoresearch.com/Searching/Conversational_search#Response) 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Took** | **int** | Time taken to execute the search | [optional] 
**TimedOut** | **bool** | Indicates whether the search operation timed out | [optional] 
**Aggregations** | [**Dictionary&lt;string, AggBucketsResult&gt;**](AggBucketsResult.md) | Aggregated search results grouped by the specified criteria. Each named aggregation typically contains a &#x60;buckets&#x60; array (or keyed map) of bucket objects with &#x60;key&#x60;, &#x60;doc_count&#x60;, and optional &#x60;status&#x60;.  | [optional] 
**Hits** | [**SearchResponseHits**](SearchResponseHits.md) |  | [optional] 
**Profile** | **Object** | Profile information about the search execution, if profiling is enabled | [optional] 
**Scroll** | **string** | Scroll token to be used fo pagination | [optional] 
**Warning** | **Object** | Warnings encountered during the search operation | [optional] 
**ConversationUuid** | **string** | Existing or generated conversation id (conversational search) | [optional] 
**UserQuery** | **string** | Original user query (conversational search) | [optional] 
**SearchQuery** | **string** | Standalone search query used for KNN retrieval (conversational search) | [optional] 
**Response** | **string** | LLM answer as generated (conversational search) | [optional] 
**Sources** | **string** | JSON string containing retrieved source rows used as LLM context (conversational search).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

