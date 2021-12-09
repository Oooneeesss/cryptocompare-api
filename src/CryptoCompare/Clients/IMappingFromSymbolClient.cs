using System.Threading.Tasks;

namespace CryptoCompare
{
    public interface IMappingFromSymbolClient : IApiClient
    {
        /// <summary>
        /// Returns all the pairs tradable on exchanges for the current  
        /// </summary>
        Task<MappingFromSymbolResponse> ListPairsAsync(string symbol);
    }
}
