// <auto-generated/>
using GitHub.Projects.Columns.Cards.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Projects.Columns.Cards {
    /// <summary>
    /// Builds and executes requests for operations under \projects\columns\cards
    /// </summary>
    public class CardsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.projects.columns.cards.item collection</summary>
        /// <param name="position">The unique identifier of the card.</param>
        public WithCard_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("card_id", position);
            return new WithCard_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new CardsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/columns/cards", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CardsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/columns/cards", rawUrl) {
        }
    }
}
