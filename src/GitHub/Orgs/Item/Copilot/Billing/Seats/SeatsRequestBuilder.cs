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
namespace GitHub.Orgs.Item.Copilot.Billing.Seats {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\copilot\billing\seats
    /// </summary>
    public class SeatsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new SeatsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SeatsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing/seats{?page*,per_page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SeatsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SeatsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot/billing/seats{?page*,per_page*}", rawUrl) {
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Lists all Copilot Business seat assignments for an organization that are currently being billed (either active or pending cancellation at the start of the next billing cycle).Only organization owners can configure and view details about the organization&apos;s Copilot Business subscription. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-business#list-all-copilot-business-seat-assignments-for-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SeatsGetResponse?> GetAsSeatsGetResponseAsync(Action<RequestConfiguration<SeatsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SeatsGetResponse> GetAsSeatsGetResponseAsync(Action<RequestConfiguration<SeatsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SeatsGetResponse>(requestInfo, SeatsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Lists all Copilot Business seat assignments for an organization that are currently being billed (either active or pending cancellation at the start of the next billing cycle).Only organization owners can configure and view details about the organization&apos;s Copilot Business subscription. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/copilot/copilot-business#list-all-copilot-business-seat-assignments-for-an-organization" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsSeatsGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<SeatsResponse?> GetAsync(Action<RequestConfiguration<SeatsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<SeatsResponse> GetAsync(Action<RequestConfiguration<SeatsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"500", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<SeatsResponse>(requestInfo, SeatsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Lists all Copilot Business seat assignments for an organization that are currently being billed (either active or pending cancellation at the start of the next billing cycle).Only organization owners can configure and view details about the organization&apos;s Copilot Business subscription. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SeatsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SeatsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public SeatsRequestBuilder WithUrl(string rawUrl) {
            return new SeatsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// **Note**: This endpoint is in beta and is subject to change.Lists all Copilot Business seat assignments for an organization that are currently being billed (either active or pending cancellation at the start of the next billing cycle).Only organization owners can configure and view details about the organization&apos;s Copilot Business subscription. You mustauthenticate using an access token with the `manage_billing:copilot` scope to use this endpoint.
        /// </summary>
        public class SeatsRequestBuilderGetQueryParameters {
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class SeatsRequestBuilderGetRequestConfiguration : RequestConfiguration<SeatsRequestBuilderGetQueryParameters> {
        }
    }
}