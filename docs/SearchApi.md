# ManticoreSearch.Api.SearchApi

All URIs are relative to *http://127.0.0.1:9308*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Search**](SearchApi.md#search) | **POST** /search | Performs a search |
| [**Percolate**](SearchApi.md#percolate) | **POST** /pq/{table}/search | Perform a reverse search on a percolate table |
| [**Autocomplete**](SearchApi.md#autocomplete) | **POST** /autocomplete | Performs an autocomplete search on a table |

## **Search**
> SearchResponse Search (SearchRequest searchRequest)

Performs a search on a table. 

The method expects an object with the following mandatory properties:
        
* the name of the table to search | string
        
For details, see the documentation on [**SearchRequest**](SearchRequest.md)

The method returns an object with the following properties:
        
- hits: an object with the following properties:
  - hits: an array of hit objects, where each hit object represents a matched document. Each hit object has the following properties:
    - _id: the ID of the matched document.
    - _score: the score of the matched document.
    - _source: the source data of the matched document.
  - total: the total number of hits found.
- timed_out: a boolean indicating whether the query timed out.
- took: the time taken to execute the search query.

In addition, if profiling is enabled, the response will include an additional array with profiling information attached.

Here is an example search response:
```   
{
  'took':10,
  'timed_out':false,
  'hits':
  {
    'total':2,
    'hits':
    [
      {
        '_id':'1',
        '_score':1,
        _source':{'gid':11}
      },
      {
        '_id':'2',
        '_score':1,
        '_source':{'gid':12}
      }
    ]
  }
}   
```  

For more information about the match query syntax and additional parameters that can be added to  request and response, please check: https://manual.manticoresearch.com/Searching/Full_text_matching/Basic_usage#HTTP-JSON. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ManticoreSearch.Api;
using ManticoreSearch.Client;
using ManticoreSearch.Model;

namespace Example
{
    public class SearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:9308";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);

			// Create SearchRequest
            var searchRequest = new SearchRequest("test");
            SearchQuery query = new SearchQuery();
            query.QueryString = "find smth";
            searchRequest.Query = query; 

            try
            {
                // Perform a search
                SearchResponse result = apiInstance.Search(searchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.Search: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchRequest** | [**SearchRequest**](SearchRequest.md) |  |  |

### Return type

[**SearchResponse**](SearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description |
|-------------|-------------|
| **200** | Success, query processed |
| **500** | Server Error |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## **Percolate**
> SearchResponse Percolate (string table, PercolateRequest percolateRequest)

Perform a reverse search on a percolate table

Performs a percolate search. 
This method must be used only on percolate tables.

Expects two parameters: the table name and an object with a document or an array of documents to search by.
Here is an example of the object with a single document:

```
{
  "query":
  {
    "percolate":
    {
      "document":
      {
        "content":"sample content"
      }
    }
  }
}
```

Responds with an object with matched stored queries:     
```   
{
  'timed_out':false,
  'hits':
  {
    'total':2,
    'max_score':1,
    'hits':
    [
      {
        'table':'idx_pq_1',
        '_type':'doc',
        '_id':'2',
        '_score':'1',
        '_source':
        {
          'query':
          {
            'match':{'title':'some'}
          }
        }
      },
      {
        'table':'idx_pq_1',
        '_type':'doc',
        '_id':'5',
        '_score':'1',
        '_source':
        {
          'query':{'ql':'some | none'}
        }
      }
    ]
  }
}   
``` 

And here is an example of the object with multiple documents:

```
{
  "query":
  {
    "percolate":
    {
      "documents": [
        {
          "content":"sample content"
        },
        {
          "content":"another sample content"
        }
      ]
    }
  }
}
```


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ManticoreSearch.Api;
using ManticoreSearch.Client;
using ManticoreSearch.Model;

namespace Example
{
    public class PercolateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:9308";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var table = "table_example";  // string | Name of the percolate table
            var percolateRequest = new PercolateRequest(); // PercolateRequest | 

            try
            {
                // Perform reverse search on a percolate table
                SearchResponse result = apiInstance.Percolate(table, percolateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.Percolate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PercolateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Perform reverse search on a percolate table
    ApiResponse<SearchResponse> response = apiInstance.PercolateWithHttpInfo(table, percolateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.PercolateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | Name of the percolate table |  |
| **percolateRequest** | [**PercolateRequest**](PercolateRequest.md) |  |  |

### Return type

[**SearchResponse**](SearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description |
|-------------|-------------|
| **200** | Success, query processed |
| **500** | Server error |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


## Autocomplete

> List&lt;Object&gt; Autocomplete (AutocompleteRequest autocompleteRequest)

Performs an autocomplete search on a table

 The method expects an object with the following mandatory properties: * the name of the table to search * the query string to autocomplete For details, see the documentation on [**Autocomplete**](Autocomplete.md) An example: ``` {   \"table\":\"table_name\",   \"query\":\"query_beginning\" }         ``` An example of the method's response:   ```  [    {      \"total\": 3,      \"error\": \"\",      \"warning\": \"\",      \"columns\": [        {          \"query\": {            \"type\": \"string\"          }        }      ],      \"data\": [        {          \"query\": \"hello\"        },        {          \"query\": \"helio\"        },        {          \"query\": \"hell\"        }      ]    }  ]   ```  For more detailed information about the autocomplete queries, please refer to the documentation [here](https://manual.manticoresearch.com/Searching/Autocomplete). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ManticoreSearch.Api;
using ManticoreSearch.Client;
using ManticoreSearch.Model;

namespace Example
{
    public class AutocompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:9308";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var autocompleteRequest = new AutocompleteRequest(); // AutocompleteRequest | 

            try
            {
                // Performs an autocomplete search on a table
                List<Object> result = apiInstance.Autocomplete(autocompleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.Autocomplete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutocompleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs an autocomplete search on a table
    ApiResponse<List<Object>> response = apiInstance.AutocompleteWithHttpInfo(autocompleteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.AutocompleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autocompleteRequest** | [**AutocompleteRequest**](AutocompleteRequest.md) |  |  |

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **0** | error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

