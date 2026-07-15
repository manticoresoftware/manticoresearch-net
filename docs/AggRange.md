# ManticoreSearch.Model.AggRange
Group documents into custom numeric or date ranges. Use with the `range` or `date_range` aggregation type. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Attribute to group by | 
**Ranges** | [**List&lt;Range&gt;**](Range.md) | Ordered list of ranges | 
**Keyed** | **bool** | Return buckets as an object keyed by range label when true, or as an array when false. Default is false.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

