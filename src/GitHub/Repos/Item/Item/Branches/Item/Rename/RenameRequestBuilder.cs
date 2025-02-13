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
namespace GitHub.Repos.Item.Item.Branches.Item.Rename {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\branches\{branch}\rename
    /// </summary>
    public class RenameRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new RenameRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RenameRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/rename", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RenameRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RenameRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/rename", rawUrl) {
        }
        /// <summary>
        /// Renames a branch in a repository.**Note:** Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won&apos;t be able to push to the old branch name while the rename process is in progress. For more information, see &quot;[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)&quot;.The permissions required to use this endpoint depends on whether you are renaming the default branch.To rename a non-default branch:* Users must have push access.* GitHub Apps must have the `contents:write` repository permission.To rename the default branch:* Users must have admin or owner permissions.* GitHub Apps must have the `contents:write` and `administration:write` repository permissions.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branches#rename-a-branch" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BranchWithProtection?> PostAsync(RenamePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BranchWithProtection> PostAsync(RenamePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<BranchWithProtection>(requestInfo, BranchWithProtection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Renames a branch in a repository.**Note:** Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won&apos;t be able to push to the old branch name while the rename process is in progress. For more information, see &quot;[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)&quot;.The permissions required to use this endpoint depends on whether you are renaming the default branch.To rename a non-default branch:* Users must have push access.* GitHub Apps must have the `contents:write` repository permission.To rename the default branch:* Users must have admin or owner permissions.* GitHub Apps must have the `contents:write` and `administration:write` repository permissions.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(RenamePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(RenamePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RenameRequestBuilder WithUrl(string rawUrl) {
            return new RenameRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
