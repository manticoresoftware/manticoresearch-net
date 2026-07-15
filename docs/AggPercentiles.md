# ManticoreSearch.Model.AggPercentiles
Object to use percentile values in aggregation. For more information see [Grouping](https://manual.manticoresearch.com/Searching/Grouping#PERCENTILES(),-PERCENTILE_RANKS(),-MEDIAN_ABSOLUTE_DEVIATION()) 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Numeric field to calculate percentiles for | 
**Values** | **List&lt;decimal&gt;** | Percentile points to compute (0-100). Defaults to 1, 5, 25, 50, 75, 95, and 99 when omitted.  | [optional] 
**Keyed** | **bool** | Return an object keyed by percentile when true, or an array when false. Default is false.  | [optional] 
**Tdigest** | [**AggTDigest**](AggTDigest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

