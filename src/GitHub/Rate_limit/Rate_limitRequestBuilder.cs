// <auto-generated/>
using GitHub.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Rate_limit {
    /// <summary>
    /// Builds and executes requests for operations under \rate_limit
    /// </summary>
    public class Rate_limitRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new Rate_limitRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Rate_limitRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rate_limit", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Rate_limitRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Rate_limitRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rate_limit", rawUrl) {
        }
        /// <summary>
        /// **Note:** Accessing this endpoint does not count against your REST API rate limit.Some categories of endpoints have custom rate limits that are separate from the rate limit governing the other REST API endpoints. For this reason, the API response categorizes your rate limit. Under `resources`, you&apos;ll see objects relating to different categories:* The `core` object provides your rate limit status for all non-search-related resources in the REST API.* The `search` object provides your rate limit status for the REST API for searching (excluding code searches). For more information, see &quot;[Search](https://docs.github.com/rest/search).&quot;* The `code_search` object provides your rate limit status for the REST API for searching code. For more information, see &quot;[Search code](https://docs.github.com/rest/search/search#search-code).&quot;* The `graphql` object provides your rate limit status for the GraphQL API. For more information, see &quot;[Resource limitations](https://docs.github.com/graphql/overview/resource-limitations#rate-limit).&quot;* The `integration_manifest` object provides your rate limit status for the `POST /app-manifests/{code}/conversions` operation. For more information, see &quot;[Creating a GitHub App from a manifest](https://docs.github.com/apps/creating-github-apps/setting-up-a-github-app/creating-a-github-app-from-a-manifest#3-you-exchange-the-temporary-code-to-retrieve-the-app-configuration).&quot;* The `dependency_snapshots` object provides your rate limit status for submitting snapshots to the dependency graph. For more information, see &quot;[Dependency graph](https://docs.github.com/rest/dependency-graph).&quot;* The `code_scanning_upload` object provides your rate limit status for uploading SARIF results to code scanning. For more information, see &quot;[Uploading a SARIF file to GitHub](https://docs.github.com/code-security/code-scanning/integrating-with-code-scanning/uploading-a-sarif-file-to-github).&quot;* The `actions_runner_registration` object provides your rate limit status for registering self-hosted runners in GitHub Actions. For more information, see &quot;[Self-hosted runners](https://docs.github.com/rest/actions/self-hosted-runners).&quot;* The `source_import` object is no longer in use for any API endpoints, and it will be removed in the next API version. For more information about API versions, see &quot;[API Versions](https://docs.github.com/rest/overview/api-versions).&quot;**Note:** The `rate` object is deprecated. If you&apos;re writing new API client code or updating existing code, you should use the `core` object instead of the `rate` object. The `core` object contains the same information that is present in the `rate` object.
        /// API method documentation <see href="https://docs.github.com/rest/rate-limit/rate-limit#get-rate-limit-status-for-the-authenticated-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RateLimitOverview?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RateLimitOverview> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RateLimitOverview>(requestInfo, RateLimitOverview.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note:** Accessing this endpoint does not count against your REST API rate limit.Some categories of endpoints have custom rate limits that are separate from the rate limit governing the other REST API endpoints. For this reason, the API response categorizes your rate limit. Under `resources`, you&apos;ll see objects relating to different categories:* The `core` object provides your rate limit status for all non-search-related resources in the REST API.* The `search` object provides your rate limit status for the REST API for searching (excluding code searches). For more information, see &quot;[Search](https://docs.github.com/rest/search).&quot;* The `code_search` object provides your rate limit status for the REST API for searching code. For more information, see &quot;[Search code](https://docs.github.com/rest/search/search#search-code).&quot;* The `graphql` object provides your rate limit status for the GraphQL API. For more information, see &quot;[Resource limitations](https://docs.github.com/graphql/overview/resource-limitations#rate-limit).&quot;* The `integration_manifest` object provides your rate limit status for the `POST /app-manifests/{code}/conversions` operation. For more information, see &quot;[Creating a GitHub App from a manifest](https://docs.github.com/apps/creating-github-apps/setting-up-a-github-app/creating-a-github-app-from-a-manifest#3-you-exchange-the-temporary-code-to-retrieve-the-app-configuration).&quot;* The `dependency_snapshots` object provides your rate limit status for submitting snapshots to the dependency graph. For more information, see &quot;[Dependency graph](https://docs.github.com/rest/dependency-graph).&quot;* The `code_scanning_upload` object provides your rate limit status for uploading SARIF results to code scanning. For more information, see &quot;[Uploading a SARIF file to GitHub](https://docs.github.com/code-security/code-scanning/integrating-with-code-scanning/uploading-a-sarif-file-to-github).&quot;* The `actions_runner_registration` object provides your rate limit status for registering self-hosted runners in GitHub Actions. For more information, see &quot;[Self-hosted runners](https://docs.github.com/rest/actions/self-hosted-runners).&quot;* The `source_import` object is no longer in use for any API endpoints, and it will be removed in the next API version. For more information about API versions, see &quot;[API Versions](https://docs.github.com/rest/overview/api-versions).&quot;**Note:** The `rate` object is deprecated. If you&apos;re writing new API client code or updating existing code, you should use the `core` object instead of the `rate` object. The `core` object contains the same information that is present in the `rate` object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        public Rate_limitRequestBuilder WithUrl(string rawUrl) {
            return new Rate_limitRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
