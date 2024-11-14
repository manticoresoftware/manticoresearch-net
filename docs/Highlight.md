# ManticoreSearch.Model.Highlight

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FragmentSize** | **Object** | Maximum size of the text fragments in highlighted snippets per field | [optional] 
**Limit** | **Object** | Maximum size of snippets per field | [optional] 
**LimitSnippets** | **Object** | Maximum number of snippets per field | [optional] 
**LimitWords** | **Object** | Maximum number of words per field | [optional] 
**NumberOfFragments** | **Object** | Total number of highlighted fragments per field | [optional] 
**AfterMatch** | **string** | Text inserted after the matched term, typically used for HTML formatting | [optional] [default to "</strong>"]
**AllowEmpty** | **bool** | Permits an empty string to be returned as the highlighting result. Otherwise, the beginning of the original text would be returned | [optional] 
**Around** | **int** | Number of words around the match to include in the highlight | [optional] 
**BeforeMatch** | **string** | Text inserted before the match, typically used for HTML formatting | [optional] [default to "<strong>"]
**EmitZones** | **bool** | Emits an HTML tag with the enclosing zone name before each highlighted snippet | [optional] 
**Encoder** | **string** | If set to &#39;html&#39;, retains HTML markup when highlighting | [optional] 
**Fields** | **Object** |  | [optional] 
**ForceAllWords** | **bool** | Ignores the length limit until the result includes all keywords | [optional] 
**ForceSnippets** | **bool** | Forces snippet generation even if limits allow highlighting the entire text | [optional] 
**HighlightQuery** | [**QueryFilter**](QueryFilter.md) |  | [optional] 
**HtmlStripMode** | **string** | Defines the mode for handling HTML markup in the highlight | [optional] 
**LimitsPerField** | **bool** | Determines whether the &#39;limit&#39;, &#39;limit_words&#39;, and &#39;limit_snippets&#39; options operate as individual limits in each field of the document | [optional] 
**NoMatchSize** | **int** | If set to 1, allows an empty string to be returned as a highlighting result | [optional] 
**Order** | **string** | Sets the sorting order of highlighted snippets | [optional] 
**PreTags** | **string** | Text inserted before each highlighted snippet | [optional] [default to "<strong>"]
**PostTags** | **string** | Text inserted after each highlighted snippet | [optional] [default to "</strong>"]
**StartSnippetId** | **int** | Sets the starting value of the %SNIPPET_ID% macro | [optional] 
**UseBoundaries** | **bool** | Defines whether to additionally break snippets by phrase boundary characters | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

