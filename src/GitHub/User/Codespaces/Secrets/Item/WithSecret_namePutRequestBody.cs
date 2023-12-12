// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.User.Codespaces.Secrets.Item {
    public class WithSecret_namePutRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get the public key for the authenticated user](https://docs.github.com/rest/codespaces/secrets#get-public-key-for-the-authenticated-user) endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptedValue { get; set; }
#nullable restore
#else
        public string EncryptedValue { get; set; }
#endif
        /// <summary>ID of the key you used to encrypt the secret.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>An array of repository ids that can access the user secret. You can manage the list of selected repositories using the [List selected repositories for a user secret](https://docs.github.com/rest/codespaces/secrets#list-selected-repositories-for-a-user-secret), [Set selected repositories for a user secret](https://docs.github.com/rest/codespaces/secrets#set-selected-repositories-for-a-user-secret), and [Remove a selected repository from a user secret](https://docs.github.com/rest/codespaces/secrets#remove-a-selected-repository-from-a-user-secret) endpoints.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? SelectedRepositoryIds { get; set; }
#nullable restore
#else
        public List<int?> SelectedRepositoryIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new WithSecret_namePutRequestBody and sets the default values.
        /// </summary>
        public WithSecret_namePutRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithSecret_namePutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithSecret_namePutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"encrypted_value", n => { EncryptedValue = n.GetStringValue(); } },
                {"key_id", n => { KeyId = n.GetStringValue(); } },
                {"selected_repository_ids", n => { SelectedRepositoryIds = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("encrypted_value", EncryptedValue);
            writer.WriteStringValue("key_id", KeyId);
            writer.WriteCollectionOfPrimitiveValues<int?>("selected_repository_ids", SelectedRepositoryIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}