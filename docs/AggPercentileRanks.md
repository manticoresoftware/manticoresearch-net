# ManticoreSearch.Model.AggPercentileRanks
Object to use percentile ranks in aggregation. For more information see [Grouping](https://manual.manticoresearch.com/Searching/Grouping#PERCENTILE_RANKS(),-MEDIAN_ABSOLUTE_DEVIATION()) 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Numeric field to calculate percentile ranks for | 
**Values** | **List&lt;decimal&gt;** | Input values to rank | 
**Keyed** | **bool** | Return an object keyed by input value when true, or an array when false. Default is false.  | [optional] 
**Tdigest** | [**AggTDigest**](AggTDigest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

