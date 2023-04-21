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


## Building a search request

[[Docs on search options in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Options#Search-options)
```csharp
object query =  new { query_string="Star" };
var searchRequest = new SearchRequest("movies", query);

searchRequest.Limit = 10;
searchRequest.TrackScores = true;
searchRequest.Options = new Dictionary<string, Object>();
searchRequest.Options["cutoff"] = 5;
searchRequest.Options["ranker"] = "bm25";
searchRequest.Source = "title";

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

### SourceByRules

[[SourceByRules - input parameters]](SourceByRules.md)

[[Docs on the `source` property in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Search_results#Source-selection)
```csharp
//Setting the `Source` property with an auxiliary object:
object query =  new { query_string="Star" };
var searchRequest = new SearchRequest("movies", query);

var includes = new List<string> {"title", "year"};
var excludes = new List<string> {"code"};
searchRequest.Source = new SourceByRules(includes, excludes);

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

### Sort
```csharp
//Setting the `Sort` property:
object query =  new { query_string="Star" };
var searchRequest = new SearchRequest("movies", query);

searchRequest.Sort = new List<Object> {"year"};

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

### SortOrder

[[SortOrder - input parameters]](SortOrder.md)

### SortMVA

[[SortMVA - input parameters]](SortMVA.md)

[[Docs on sorting in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Sorting_and_ranking#HTTP)
```csharp
//Setting the `Sort` property with an auxiliary object:
object query =  new { query_string="Star" };
var searchRequest = new SearchRequest("movies", query);

searchRequest.Sort = new List<Object>();
var sort2 = new SortOrder("rating", SortOrder.OrderEnum.Asc);
searchRequest.Sort.Add(sort2);
var sort3 = new SortMVA("code", SortMVA.OrderEnum.Desc, SortMVA.ModeEnum.Max);
searchRequest.Sort.Add(sort3);

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

### Expressions

[[Docs on expressions in Manticore Search Manual expressions]](https://manual.manticoresearch.com/Searching/Expressions#Expressions-in-HTTP-JSON)
```csharp    
//Setting the `expressions` property:
object query =  new { query_string="Star" };
var searchRequest = new SearchRequest("movies", query);

var expr = new Dictionary<string, string> { {"expr", "min(year,2900)"} };
searchRequest.Expressions = new List<Object>();
searchRequest.Expressions.Add(expr);
searchRequest.Expressions.Add( new Dictionary<string, string> { {"expr2", "max(year,2100)"} } );
					        	
SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

### Aggregation

[[Aggregation - input parameters]](Aggregation.md)

[[Docs on aggregations in Manticore Search Manual](https://manual.manticoresearch.com/Searching/Faceted_search#Aggregations)
```csharp    
//Setting the `aggs` property with an auxiliary object:
object query =  new { query_string="Star" };
var searchRequest = new SearchRequest("movies", query);

var agg1 = new Aggregation("agg1", "year");
agg1.Size = 10;
searchRequest.Aggs = new List<Aggregation> {agg1};
searchRequest.Aggs.Add(new Aggregation("agg2", "rating"));

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

### Highlight

[[Highlight - input parameters]](Highlight.md)

[[Docs on highlighting in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Highlighting#Highlighting)
```csharp
//Settting the `highlight` property with an auxiliary object:
object query =  new { query_string="Star" };
var searchRequest = new SearchRequest("movies", query);

var highlight = new Highlight();
highlight.Fieldnames = new List<string> {"title"};
highlight.PostTags = "</post_tag>";
highlight.Encoder = Highlight.EncoderEnum.Default;
highlight.SnippetBoundary = Highlight.SnippetBoundaryEnum.Sentence;
searchRequest.Highlight = highlight;

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

#### HighlightField

[[HighlightField - input parameters]](HighlightField.md)

[[Docs on highlight fields in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Highlighting#Highlighting)
```csharp
// settting `highlight.fields` property with an auxiliary HighlightField object
object query =  new { query_string="Star" };
var searchRequest = new SearchRequest("movies", query);

var highlight = new Highlight();
var highlightField = new HighlightField("title");
highlightField.Limit = 5;
highlight.Fields = new List<HighlightField> {highlightField};

var highlightField2 = new HighlightField("plot");
highlightField2.LimitWords = 10;
highlight.Fields.Add(highlightField2);
searchRequest.Highlight = highlight;

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

### FulltextFilter
#### QueryFilter

[[Docs on fulltext filters in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Full_text_matching/Basic_usage#HTTP-JSON)

[[QueryFilter - input parameters]](QueryFilter.md)
```csharp    
//Setting the `FulltextFilter` property using different fulltext filter objects:

//Using a QueryFilter object
var searchRequest = new SearchRequest("movies");

searchRequest.FulltextFilter = new QueryFilter("Star Trek 2");

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

#### MatchFilter

[[MatchFilter - input parameters]](MatchFilter.md)
```csharp    
//Using a MatchFilter object
var searchRequest = new SearchRequest("movies");

searchRequest.FulltextFilter = new MatchFilter("Nemesis", "title");

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

#### MatchPhraseFilter

[[MatchPhraseFilter - input parameters]](MatchPhraseFilter.md)
```csharp    
//Using a MatchPhraseFilter object
var searchRequest = new SearchRequest("movies");

searchRequest.FulltextFilter = new MatchPhraseFilter("Star Trek 2", "title");

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

#### MatchOpFilter

[[MatchOpFilter - input parameters]](MatchOpFilter.md)
```csharp
//Using a MatchOpFilter object
var searchRequest = new SearchRequest("movies");

searchRequest.FulltextFilter = new MatchOpFilter("Enterprise test", "title,plot", MatchOpFilter.OperatorEnum.Or);

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```    

### AttrFilter
#### EqualsFilter

[[EqualsFilter - input parameters]](EqualsFilter.md)

[[Docs on equality filters in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Filters#Equality-filters)
```csharp
//Setting the `AttrFilter` property using different attribute filter objects:

//Using an EqualsFilter object
var searchRequest = new SearchRequest("movies");

searchRequest.AttrFilter = new EqualsFilter("year", 2003);

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

#### InFilter

[[InFilter - input parameters]](InFilter.md)

[[Docs on set filters in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Filters#Set-filters)
```csharp
//Using InFilter object
var searchRequest = new SearchRequest("movies");

var inFilter = new InFilter("year", new List<Object> {2001, 2002});
var addValues = new List<Object> {10,11};
inFilter.Values.AddRange(addValues);
searchRequest.AttrFilter = inFilter;

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

#### RangeFilter

[[RangeFilter - input parameters]](RangeFilter.md)

[[Docs on range filters in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Filters#Range-filters)
```csharp
//Using a RangeFilter object
var searchRequest = new SearchRequest("movies");

var rangeFilter = new RangeFilter("year");
rangeFilter.Lte = 2002;
rangeFilter.Gte = 1000;
searchRequest.AttrFilter = rangeFilter;

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

#### GeoDistanceFilter

[[GeoDistanceFilter - input parameters]](GeoDistanceFilter.md)

[[Docs on geo distance filters in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Filters#Geo-distance-filters)
```csharp
//Using a GeoDistanceFilter object
var searchRequest = new SearchRequest("geo");

var geoFilter = new GeoDistanceFilter();
var locAnchor = new GeoDistanceFilterLocationAnchor(10, 20);
geoFilter.LocationAnchor = locAnchor;
geoFilter.LocationSource = "field3,field4";
geoFilter.DistanceType = GeoDistanceFilter.DistanceTypeEnum.Adaptive;
geoFilter.Distance = "100km";
searchRequest.AttrFilter = geoFilter;

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

#### BoolFilter

[[BoolFilter - input parameters]](BoolFilter.md)

[[Docs on bool queries in Manticore Search Manual]](https://manual.manticoresearch.com/Searching/Filters#bool-query)
```csharp
//Setting the `AttrFilter` property using a bool filter object:
var searchRequest = new SearchRequest("movies");

var boolFilter = new BoolFilter();
boolFilter.Must = new List<Object> { new EqualsFilter("year", 2001) };
rangeFilter = new RangeFilter("rating");
rangeFilter.Lte = 20;
boolFilter.Must.Add(rangeFilter);
searchRequest.AttrFilter = boolFilter;

SearchResponse result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);

boolFilter.MustNot = new List<Object> { new EqualsFilter("year", 2001) };
searchRequest.AttrFilter = boolFilter;

result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);

//Using nested bool filters
boolFilter = new BoolFilter();
	
var fulltextFilter = new MatchFilter("Star", "title");
var nestedBoolFilter = new BoolFilter();
nestedBoolFilter.Should = new List<Object> { new EqualsFilter("rating", 6.5), fulltextFilter };
boolFilter.Must = new List<Object> {nestedBoolFilter};
searchRequest.AttrFilter = boolFilter;

result = apiInstance.Search(searchRequest);
Debug.WriteLine(result);
```

## Using the SearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs a search
    ApiResponse<SearchResponse> response = apiInstance.SearchWithHttpInfo(searchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

