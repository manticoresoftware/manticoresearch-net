# ManticoreSearch.Model.QueryFilter
Object used to apply various conditions, such as full-text matching or attribute filtering, to a search query

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueryString** | **string** | Filter object defining a query string | [optional] 
**Match** | **Object** | Filter object defining a match keyword passed as a string or in a Match object | [optional] 
**MatchPhrase** | **Object** | Filter object defining a match phrase | [optional] 
**MatchAll** | **Object** | Filter object to select all documents | [optional] 
**Bool** | [**BoolFilter**](BoolFilter.md) |  | [optional] 
**PropertyEquals** | **Object** | Filter to match exact attribute values. | [optional] 
**In** | **Object** | Filter to match a given set of attribute values. | [optional] 
**Range** | **Object** | Filter to match a given range of attribute values passed in Range objects | [optional] 
**GeoDistance** | [**GeoDistance**](GeoDistance.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

