// <auto-generated/>
using GitHub.Models;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Approvals;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Approve;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Artifacts;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Attempts;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Cancel;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Deployment_protection_rule;
using GitHub.Repos.Item.Item.Actions.Runs.Item.ForceCancel;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Jobs;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Logs;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Pending_deployments;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Rerun;
using GitHub.Repos.Item.Item.Actions.Runs.Item.RerunFailedJobs;
using GitHub.Repos.Item.Item.Actions.Runs.Item.Timing;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Repos.Item.Item.Actions.Runs.Item {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\actions\runs\{run_id}
    /// </summary>
    public class WithRun_ItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The approvals property</summary>
        public ApprovalsRequestBuilder Approvals { get =>
            new ApprovalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The approve property</summary>
        public ApproveRequestBuilder Approve { get =>
            new ApproveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The artifacts property</summary>
        public ArtifactsRequestBuilder Artifacts { get =>
            new ArtifactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The attempts property</summary>
        public AttemptsRequestBuilder Attempts { get =>
            new AttemptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cancel property</summary>
        public CancelRequestBuilder Cancel { get =>
            new CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deployment_protection_rule property</summary>
        public Deployment_protection_ruleRequestBuilder Deployment_protection_rule { get =>
            new Deployment_protection_ruleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The forceCancel property</summary>
        public ForceCancelRequestBuilder ForceCancel { get =>
            new ForceCancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jobs property</summary>
        public JobsRequestBuilder Jobs { get =>
            new JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logs property</summary>
        public LogsRequestBuilder Logs { get =>
            new LogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pending_deployments property</summary>
        public Pending_deploymentsRequestBuilder Pending_deployments { get =>
            new Pending_deploymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rerun property</summary>
        public RerunRequestBuilder Rerun { get =>
            new RerunRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rerunFailedJobs property</summary>
        public RerunFailedJobsRequestBuilder RerunFailedJobs { get =>
            new RerunFailedJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The timing property</summary>
        public TimingRequestBuilder Timing { get =>
            new TimingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithRun_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRun_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions/runs/{run_id}{?exclude_pull_requests*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithRun_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRun_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/actions/runs/{run_id}{?exclude_pull_requests*}", rawUrl) {
        }
        /// <summary>
        /// Delete a specific workflow run. Anyone with write access to the repository can use this endpoint. If the repository isprivate you must use an access token with the `repo` scope. GitHub Apps must have the `actions:write` permission to usethis endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/actions/workflow-runs#delete-a-workflow-run" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a specific workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/actions/workflow-runs#get-a-workflow-run" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkflowRun?> GetAsync(Action<RequestConfiguration<WithRun_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkflowRun> GetAsync(Action<RequestConfiguration<WithRun_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<WorkflowRun>(requestInfo, WorkflowRun.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a specific workflow run. Anyone with write access to the repository can use this endpoint. If the repository isprivate you must use an access token with the `repo` scope. GitHub Apps must have the `actions:write` permission to usethis endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Gets a specific workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithRun_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithRun_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
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
        public WithRun_ItemRequestBuilder WithUrl(string rawUrl) {
            return new WithRun_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Gets a specific workflow run. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `actions:read` permission to use this endpoint.
        /// </summary>
        public class WithRun_ItemRequestBuilderGetQueryParameters {
            /// <summary>If `true` pull requests are omitted from the response (empty array).</summary>
            [QueryParameter("exclude_pull_requests")]
            public bool? ExcludePullRequests { get; set; }
        }
    }
}
