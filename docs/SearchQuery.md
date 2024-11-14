# ManticoreSearch.Model.SearchQuery
Defines a query structure for performing search operations

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueryString** | **Object** | Filter object defining a query string | [optional] 
**Match** | **Object** | Filter object defining a match keyword passed as a string or in a Match object | [optional] 
**MatchPhrase** | **Object** | Filter object defining a match phrase | [optional] 
**MatchAll** | **Object** | Filter object to select all documents | [optional] 
**VarBool** | [**BoolFilter**](BoolFilter.md) |  | [optional] 
**PropertyEquals** | **Object** |  | [optional] 
**VarIn** | **Object** | Filter to match a given set of attribute values. | [optional] 
**Range** | **Object** | Filter to match a given range of attribute values passed in Range objects | [optional] 
**GeoDistance** | [**GeoDistance**](GeoDistance.md) |  | [optional] 
**Highlight** | [**Highlight**](Highlight.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

