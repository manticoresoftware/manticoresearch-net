# Manticore .Net client

Сlient for Manticore Search.


❗ WARNING: this is a development version of the client. The latest release's readme is https://github.com/manticoresoftware/manticoresearch-typescript/tree/4.0.0

## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext


## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

| Manticore Search  | manticoresearch-net     |
| ----------------- | ----------------------- |
| >= 6.2.0          | 4.0.0                   |
| >= 6.2.0          | 3.3.1                   |
| >= 2.5.1          | 1.0.x                   |

```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ManticoreSearch.Api;
using ManticoreSearch.Client;
using ManticoreSearch.Model;
```

## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each ApiClass (properly the ApiClient inside it) will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manager the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory.

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll loose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using ManticoreSearch.Api;
using ManticoreSearch.Client;
using ManticoreSearch.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost:9408";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new IndexApi(httpClient, config, httpClientHandler);
            var body = ["'{\"insert\": {\"index\": \"test\", \"id\": 1, \"doc\": {\"title\": \"Title 1\"}}},\\n{\"insert\": {\"index\": \"test\", \"id\": 2, \"doc\": {\"title\": \"Title 2\"}}}'"];  // string | 

            try
            {
                // Bulk index operations
                BulkResponse result = apiInstance.Bulk(body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling IndexApi.Bulk: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
            
            apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            
            // Create SearchRequest
            var searchRequest = new SearchRequest("test");
            searchRequest.FulltextFilter = new QueryFilter("Title 1"); 

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

## Documentation for API Endpoints

All URIs are relative to *http://localhost:9408*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*IndexApi* | [**Bulk**](docs/IndexApi.md#bulk) | **POST** /bulk | Bulk index operations
*IndexApi* | [**Delete**](docs/IndexApi.md#delete) | **POST** /delete | Delete a document in an index
*IndexApi* | [**Insert**](docs/IndexApi.md#insert) | **POST** /insert | Create a new document in an index
*IndexApi* | [**Replace**](docs/IndexApi.md#replace) | **POST** /replace | Replace new document in an index
*IndexApi* | [**Update**](docs/IndexApi.md#update) | **POST** /update | Update a document in an index
*SearchApi* | [**Percolate**](docs/SearchApi.md#percolate) | **POST** /pq/{index}/search | Perform reverse search on a percolate index
*SearchApi* | [**Search**](docs/SearchApi.md#search) | **POST** /search | Performs a search on an index
*UtilsApi* | [**Sql**](docs/UtilsApi.md#sql) | **POST** /sql | Perform SQL requests


## Documentation for Models

 - [Model.Aggregation](docs/Aggregation.md)
 - [Model.AggregationSortInnerValue](docs/AggregationSortInnerValue.md)
 - [Model.AggregationTerms](docs/AggregationTerms.md)
 - [Model.BoolFilter](docs/BoolFilter.md)
 - [Model.BulkResponse](docs/BulkResponse.md)
 - [Model.DeleteDocumentRequest](docs/DeleteDocumentRequest.md)
 - [Model.DeleteResponse](docs/DeleteResponse.md)
 - [Model.EqualsFilter](docs/EqualsFilter.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.Facet](docs/Facet.md)
 - [Model.FilterBoolean](docs/FilterBoolean.md)
 - [Model.FilterNumber](docs/FilterNumber.md)
 - [Model.FilterString](docs/FilterString.md)
 - [Model.GeoDistanceFilter](docs/GeoDistanceFilter.md)
 - [Model.GeoDistanceFilterLocationAnchor](docs/GeoDistanceFilterLocationAnchor.md)
 - [Model.Highlight](docs/Highlight.md)
 - [Model.HighlightField](docs/HighlightField.md)
 - [Model.InFilter](docs/InFilter.md)
 - [Model.InsertDocumentRequest](docs/InsertDocumentRequest.md)
 - [Model.MatchFilter](docs/MatchFilter.md)
 - [Model.MatchOp](docs/MatchOp.md)
 - [Model.MatchOpFilter](docs/MatchOpFilter.md)
 - [Model.MatchPhraseFilter](docs/MatchPhraseFilter.md)
 - [Model.NotFilterBoolean](docs/NotFilterBoolean.md)
 - [Model.NotFilterNumber](docs/NotFilterNumber.md)
 - [Model.NotFilterString](docs/NotFilterString.md)
 - [Model.PercolateRequest](docs/PercolateRequest.md)
 - [Model.PercolateRequestQuery](docs/PercolateRequestQuery.md)
 - [Model.QueryFilter](docs/QueryFilter.md)
 - [Model.RangeFilter](docs/RangeFilter.md)
 - [Model.SearchRequest](docs/SearchRequest.md)
 - [Model.SearchResponse](docs/SearchResponse.md)
 - [Model.SearchResponseHits](docs/SearchResponseHits.md)
 - [Model.SortMVA](docs/SortMVA.md)
 - [Model.SortMultiple](docs/SortMultiple.md)
 - [Model.SortOrder](docs/SortOrder.md)
 - [Model.SourceByRules](docs/SourceByRules.md)
 - [Model.SuccessResponse](docs/SuccessResponse.md)
 - [Model.UpdateDocumentRequest](docs/UpdateDocumentRequest.md)
 - [Model.UpdateResponse](docs/UpdateResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
