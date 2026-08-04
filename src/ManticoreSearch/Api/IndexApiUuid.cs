using System;
using ManticoreSearch.Model;

namespace ManticoreSearch.Api
{
    public partial class IndexApi
    {
        /// <summary>Partially replaces a document identified by its UUID.</summary>
        public UpdateResponse PartialReplaceUuid(string table, string uuid, ReplaceDocumentRequest replaceDocumentRequest)
        {
            return PartialReplaceUuidWithHttpInfo(table, uuid, replaceDocumentRequest).Data;
        }

        /// <summary>Partially replaces a document identified by its UUID.</summary>
        public ManticoreSearch.Client.ApiResponse<UpdateResponse> PartialReplaceUuidWithHttpInfo(string table, string uuid, ReplaceDocumentRequest replaceDocumentRequest)
        {
            var options = CreatePartialReplaceUuidOptions(table, uuid, replaceDocumentRequest);
            var response = Client.Post<UpdateResponse>("/{table}/_update/{id}", options, Configuration);
            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PartialReplaceUuid", response);
                if (exception != null) throw exception;
            }
            return response;
        }

        /// <summary>Asynchronously partially replaces a document identified by its UUID.</summary>
        public async System.Threading.Tasks.Task<UpdateResponse> PartialReplaceUuidAsync(string table, string uuid, ReplaceDocumentRequest replaceDocumentRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            return (await PartialReplaceUuidWithHttpInfoAsync(table, uuid, replaceDocumentRequest, cancellationToken).ConfigureAwait(false)).Data;
        }

        /// <summary>Asynchronously partially replaces a document identified by its UUID.</summary>
        public async System.Threading.Tasks.Task<ManticoreSearch.Client.ApiResponse<UpdateResponse>> PartialReplaceUuidWithHttpInfoAsync(string table, string uuid, ReplaceDocumentRequest replaceDocumentRequest, System.Threading.CancellationToken cancellationToken = default)
        {
            var options = CreatePartialReplaceUuidOptions(table, uuid, replaceDocumentRequest);
            var response = await AsynchronousClient.PostAsync<UpdateResponse>("/{table}/_update/{id}", options, Configuration, cancellationToken).ConfigureAwait(false);
            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PartialReplaceUuid", response);
                if (exception != null) throw exception;
            }
            return response;
        }

        private ManticoreSearch.Client.RequestOptions CreatePartialReplaceUuidOptions(string table, string uuid, ReplaceDocumentRequest replaceDocumentRequest)
        {
            if (table == null) throw new ManticoreSearch.Client.ApiException(400, "Missing required parameter 'table' when calling IndexApi->PartialReplaceUuid");
            if (uuid == null) throw new ManticoreSearch.Client.ApiException(400, "Missing required parameter 'uuid' when calling IndexApi->PartialReplaceUuid");
            if (replaceDocumentRequest == null) throw new ManticoreSearch.Client.ApiException(400, "Missing required parameter 'replaceDocumentRequest' when calling IndexApi->PartialReplaceUuid");
            var options = new ManticoreSearch.Client.RequestOptions();
            options.HeaderParameters.Add("Content-Type", "application/json");
            options.HeaderParameters.Add("Accept", "application/json");
            options.PathParameters.Add("table", ManticoreSearch.Client.ClientUtils.ParameterToString(table));
            options.PathParameters.Add("id", ManticoreSearch.Client.ClientUtils.ParameterToString(uuid));
            options.Data = replaceDocumentRequest;
            if ((!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password)) && !options.HeaderParameters.ContainsKey("Authorization"))
                options.HeaderParameters.Add("Authorization", "Basic " + ManticoreSearch.Client.ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !options.HeaderParameters.ContainsKey("Authorization"))
                options.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            return options;
        }
    }
}
