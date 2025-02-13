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
namespace GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{repos-id}\{Owner-id}\branches\{branch}\protection\restrictions\apps
    /// </summary>
    public class AppsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new AppsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/protection/restrictions/apps", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AppsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{repos%2Did}/{Owner%2Did}/branches/{branch}/protection/restrictions/apps", rawUrl) {
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Removes the ability of an app to push to this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#remove-app-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Integration>?> DeleteAsync(AppsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Integration>> DeleteAsync(AppsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Integration>(requestInfo, Integration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Lists the GitHub Apps that have push access to this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#get-apps-with-access-to-the-protected-branch" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Integration>?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Integration>> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Integration>(requestInfo, Integration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Grants the specified apps push access for this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#add-app-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Integration>?> PostAsync(AppsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Integration>> PostAsync(AppsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Integration>(requestInfo, Integration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Replaces the list of apps that have push access to this branch. This removes all apps that previously had push access and grants push access to the new list of apps. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.
        /// API method documentation <see href="https://docs.github.com/rest/branches/branch-protection#set-app-access-restrictions" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Integration>?> PutAsync(AppsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Integration>> PutAsync(AppsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Integration>(requestInfo, Integration.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Removes the ability of an app to push to this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(AppsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(AppsDeleteRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Lists the GitHub Apps that have push access to this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.
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
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Grants the specified apps push access for this branch. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AppsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AppsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub&apos;s products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.Replaces the list of apps that have push access to this branch. This removes all apps that previously had push access and grants push access to the new list of apps. Only installed GitHub Apps with `write` access to the `contents` permission can be added as authorized actors on a protected branch.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(AppsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(AppsPutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AppsRequestBuilder WithUrl(string rawUrl) {
            return new AppsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes appsDeleteRequestBodyMember1, string
        /// </summary>
        public class AppsDeleteRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type appsDeleteRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsDeleteRequestBodyMember1? AppsDeleteRequestBodyAppsDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsDeleteRequestBodyMember1 AppsDeleteRequestBodyAppsDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type appsDeleteRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsDeleteRequestBodyMember1? AppsDeleteRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsDeleteRequestBodyMember1 AppsDeleteRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? AppsDeleteRequestBodyString { get; set; }
#nullable restore
#else
            public string AppsDeleteRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static AppsDeleteRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new AppsDeleteRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.AppsDeleteRequestBodyAppsDeleteRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsDeleteRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.AppsDeleteRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsDeleteRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string appsDeleteRequestBodyStringValue) {
                    result.AppsDeleteRequestBodyString = appsDeleteRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(AppsDeleteRequestBodyAppsDeleteRequestBodyMember1 != null) {
                    return AppsDeleteRequestBodyAppsDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                else if(AppsDeleteRequestBodyMember1 != null) {
                    return AppsDeleteRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(AppsDeleteRequestBodyAppsDeleteRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsDeleteRequestBodyMember1>(null, AppsDeleteRequestBodyAppsDeleteRequestBodyMember1);
                }
                else if(AppsDeleteRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsDeleteRequestBodyMember1>(null, AppsDeleteRequestBodyMember1);
                }
                else if(AppsDeleteRequestBodyString != null) {
                    writer.WriteStringValue(null, AppsDeleteRequestBodyString);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes appsPostRequestBodyMember1, string
        /// </summary>
        public class AppsPostRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type appsPostRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPostRequestBodyMember1? AppsPostRequestBodyAppsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPostRequestBodyMember1 AppsPostRequestBodyAppsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type appsPostRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPostRequestBodyMember1? AppsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPostRequestBodyMember1 AppsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? AppsPostRequestBodyString { get; set; }
#nullable restore
#else
            public string AppsPostRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static AppsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new AppsPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.AppsPostRequestBodyAppsPostRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.AppsPostRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPostRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string appsPostRequestBodyStringValue) {
                    result.AppsPostRequestBodyString = appsPostRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(AppsPostRequestBodyAppsPostRequestBodyMember1 != null) {
                    return AppsPostRequestBodyAppsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(AppsPostRequestBodyMember1 != null) {
                    return AppsPostRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(AppsPostRequestBodyAppsPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPostRequestBodyMember1>(null, AppsPostRequestBodyAppsPostRequestBodyMember1);
                }
                else if(AppsPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPostRequestBodyMember1>(null, AppsPostRequestBodyMember1);
                }
                else if(AppsPostRequestBodyString != null) {
                    writer.WriteStringValue(null, AppsPostRequestBodyString);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes appsPutRequestBodyMember1, string
        /// </summary>
        public class AppsPutRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type appsPutRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPutRequestBodyMember1? AppsPutRequestBodyAppsPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPutRequestBodyMember1 AppsPutRequestBodyAppsPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type appsPutRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPutRequestBodyMember1? AppsPutRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPutRequestBodyMember1 AppsPutRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? AppsPutRequestBodyString { get; set; }
#nullable restore
#else
            public string AppsPutRequestBodyString { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static AppsPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new AppsPutRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.AppsPutRequestBodyAppsPutRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPutRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.AppsPutRequestBodyMember1 = new GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPutRequestBodyMember1();
                }
                else if(parseNode.GetStringValue() is string appsPutRequestBodyStringValue) {
                    result.AppsPutRequestBodyString = appsPutRequestBodyStringValue;
                }
                else if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(AppsPutRequestBodyAppsPutRequestBodyMember1 != null) {
                    return AppsPutRequestBodyAppsPutRequestBodyMember1.GetFieldDeserializers();
                }
                else if(AppsPutRequestBodyMember1 != null) {
                    return AppsPutRequestBodyMember1.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(AppsPutRequestBodyAppsPutRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPutRequestBodyMember1>(null, AppsPutRequestBodyAppsPutRequestBodyMember1);
                }
                else if(AppsPutRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Repos.Item.Item.Branches.Item.Protection.Restrictions.Apps.AppsPutRequestBodyMember1>(null, AppsPutRequestBodyMember1);
                }
                else if(AppsPutRequestBodyString != null) {
                    writer.WriteStringValue(null, AppsPutRequestBodyString);
                }
                else if(String != null) {
                    writer.WriteStringValue(null, String);
                }
            }
        }
    }
}
