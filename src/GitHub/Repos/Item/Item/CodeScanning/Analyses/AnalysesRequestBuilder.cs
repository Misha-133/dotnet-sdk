// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.CodeScanning.Analyses.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.CodeScanning.Analyses {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\code-scanning\analyses
    /// </summary>
    public class AnalysesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.repos.item.item.codeScanning.analyses.item collection</summary>
        /// <param name="position">The ID of the analysis, as returned from the `GET /repos/{owner}/{repo}/code-scanning/analyses` operation.</param>
        public WithAnalysis_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("analysis_id", position);
            return new WithAnalysis_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AnalysesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AnalysesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/code-scanning/analyses{?tool_name*,tool_guid*,page*,per_page*,ref*,sarif_id*,direction*,sort*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AnalysesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AnalysesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/code-scanning/analyses{?tool_name*,tool_guid*,page*,per_page*,ref*,sarif_id*,direction*,sort*}", rawUrl) {
        }
        /// <summary>
        /// Lists the details of all code scanning analyses for a repository,starting with the most recent.The response is paginated and you can use the `page` and `per_page` parametersto list the analyses you&apos;re interested in.By default 30 analyses are listed per page.The `rules_count` field in the response give the number of rulesthat were run in the analysis.For very old analyses this data is not available,and `0` is returned in this field.You must use an access token with the `security_events` scope to use this endpoint with private repositories,the `public_repo` scope also grants permission to read security events on public repositories only.**Deprecation notice**:The `tool_name` field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the `tool` field.
        /// API method documentation <see href="https://docs.github.com/rest/code-scanning/code-scanning#list-code-scanning-analyses-for-a-repository" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<CodeScanningAnalysis>?> GetAsync(Action<RequestConfiguration<AnalysesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<CodeScanningAnalysis>> GetAsync(Action<RequestConfiguration<AnalysesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"503", Analyses503Error.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<CodeScanningAnalysis>(requestInfo, CodeScanningAnalysis.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Lists the details of all code scanning analyses for a repository,starting with the most recent.The response is paginated and you can use the `page` and `per_page` parametersto list the analyses you&apos;re interested in.By default 30 analyses are listed per page.The `rules_count` field in the response give the number of rulesthat were run in the analysis.For very old analyses this data is not available,and `0` is returned in this field.You must use an access token with the `security_events` scope to use this endpoint with private repositories,the `public_repo` scope also grants permission to read security events on public repositories only.**Deprecation notice**:The `tool_name` field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the `tool` field.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AnalysesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AnalysesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AnalysesRequestBuilder WithUrl(string rawUrl) {
            return new AnalysesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the details of all code scanning analyses for a repository,starting with the most recent.The response is paginated and you can use the `page` and `per_page` parametersto list the analyses you&apos;re interested in.By default 30 analyses are listed per page.The `rules_count` field in the response give the number of rulesthat were run in the analysis.For very old analyses this data is not available,and `0` is returned in this field.You must use an access token with the `security_events` scope to use this endpoint with private repositories,the `public_repo` scope also grants permission to read security events on public repositories only.**Deprecation notice**:The `tool_name` field is deprecated and will, in future, not be included in the response for this endpoint. The example response reflects this change. The tool name can now be found inside the `tool` field.
        /// </summary>
        public class AnalysesRequestBuilderGetQueryParameters {
            /// <summary>The direction to sort the results by.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? Direction { get; set; }
            /// <summary>The page number of the results to fetch. For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100). For more information, see &quot;[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).&quot;</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The Git reference for the analyses you want to list. The `ref` for a branch can be formatted either as `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`. To reference a pull request use `refs/pull/&lt;number&gt;/merge`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("ref")]
            public string? Ref { get; set; }
#nullable restore
#else
            [QueryParameter("ref")]
            public string Ref { get; set; }
#endif
            /// <summary>Filter analyses belonging to the same SARIF upload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sarif_id")]
            public string? SarifId { get; set; }
#nullable restore
#else
            [QueryParameter("sarif_id")]
            public string SarifId { get; set; }
#endif
            /// <summary>The property by which to sort the results.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? Sort { get; set; }
            /// <summary>The GUID of a code scanning tool. Only results by this tool will be listed. Note that some code scanning tools may not include a GUID in their analysis data. You can specify the tool by using either `tool_guid` or `tool_name`, but not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tool_guid")]
            public string? ToolGuid { get; set; }
#nullable restore
#else
            [QueryParameter("tool_guid")]
            public string ToolGuid { get; set; }
#endif
            /// <summary>The name of a code scanning tool. Only results by this tool will be listed. You can specify the tool by using either `tool_name` or `tool_guid`, but not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("tool_name")]
            public string? ToolName { get; set; }
#nullable restore
#else
            [QueryParameter("tool_name")]
            public string ToolName { get; set; }
#endif
        }
    }
}
