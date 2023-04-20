# ManticoreSearch.Model.Highlight
Query HIGHLIGHT expression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fieldnames** | **List&lt;string&gt;** |  | [optional] 
**Fields** | [**List&lt;HighlightField&gt;**](HighlightField.md) |  | [optional] 
**Encoder** | **string** |  | [optional] 
**HighlightQuery** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**PreTags** | **string** |  | [optional] [default to "<strong>"]
**PostTags** | **string** |  | [optional] [default to "</strong>"]
**NoMatchSize** | **int** |  | [optional] 
**FragmentSize** | **int** |  | [optional] [default to 256]
**NumberOfFragments** | **int** |  | [optional] [default to 0]
**Limit** | **int** |  | [optional] [default to 256]
**LimitWords** | **int** |  | [optional] [default to 0]
**LimitSnippets** | **int** |  | [optional] [default to 0]
**LimitsPerField** | **bool** |  | [optional] [default to false]
**UseBoundaries** | **bool** |  | [optional] [default to false]
**ForceAllWords** | **bool** |  | [optional] [default to false]
**AllowEmpty** | **bool** |  | [optional] [default to false]
**EmitZones** | **bool** |  | [optional] [default to false]
**ForceSnippets** | **bool** |  | [optional] [default to false]
**Around** | **int** |  | [optional] [default to 5]
**StartSnippetId** | **int** |  | [optional] [default to 1]
**HtmlStripMode** | **string** |  | [optional] 
**SnippetBoundary** | **string** |  | [optional] 

[[Using in search requests]](SearchApi.md#Highlight)


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

