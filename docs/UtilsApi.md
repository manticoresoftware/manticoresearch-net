# ManticoreSearch.Api.UtilsApi

All URIs are relative to *http://127.0.0.1:9308*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Sql**](UtilsApi.md#sql) | **POST** /sql | Perform SQL requests |

<a name="sql"></a>
# **Sql**
> List&lt;Object&gt; Sql (string body, bool? rawResponse = null)

Perform SQL requests

Run a query in SQL format. Expects a query string passed through `body` parameter and optional `raw_response` parameter that defines a format of response. `raw_response` can be set to `False` for Select queries only, e.g., `SELECT * FROM myindex` The query string must stay as it is, no URL encoding is needed. The response object depends on the query executed. In select mode the response has same format as `/search` operation. 

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
    public class SqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://127.0.0.1:9308";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UtilsApi(httpClient, config, httpClientHandler);
            var body = SHOW TABLES;  // string | A query parameter string. 
            var rawResponse = true;  // bool? | Optional parameter, defines a format of response. Can be set to `False` for Select only queries and set to `True` or omitted for any type of queries:  (optional)  (default to true)

            try
            {
                // Perform SQL requests
                List<Object> result = apiInstance.Sql(body, rawResponse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilsApi.Sql: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SqlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Perform SQL requests
    ApiResponse<List<Object>> response = apiInstance.SqlWithHttpInfo(body, rawResponse);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UtilsApi.SqlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | A query parameter string.  |  |
| **rawResponse** | **bool?** | Optional parameter, defines a format of response. Can be set to &#x60;False&#x60; for Select only queries and set to &#x60;True&#x60; or omitted for any type of queries:  | [optional] [default to true] |

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | In case of SELECT-only in mode none the response schema is the same as of &#x60;search&#x60;. In case of &#x60;mode&#x3D;raw&#x60; the response depends on the query executed.  |  -  |
| **0** | error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

