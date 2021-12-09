using System.Net.Http;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace CryptoCompare
{
    public class MappingFromSymbolClient : BaseApiClient, IMappingFromSymbolClient
    {
        /// <summary>
        /// Initializes a new instance of the CryptoCompare.Clients.CoinsClient class.
        /// </summary>
        /// <param name="httpClient">The HTTP client. This cannot be null.</param>
        public MappingFromSymbolClient([NotNull] HttpClient httpClient)
            : base(httpClient)
        {
        }

        public async Task<MappingFromSymbolResponse> ListPairsAsync([NotNull] string symbol)
        {
            return await this.GetAsync<MappingFromSymbolResponse>(ApiUrls.CoinPairs(symbol)).ConfigureAwait(false);
        }
    }
}
