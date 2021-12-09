using System.Collections.Generic;
using Newtonsoft.Json;

namespace CryptoCompare
{
    public class MappingFromSymbolResponse : BaseApiResponse
    {
        ///// <summary>
        ///// Gets or sets the coins data.
        ///// </summary>
        //[JsonProperty("current")]
        //public List<Pair> Pairs { get; set; }

        [JsonProperty("Data")]
        public Data Pairs { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("current")]
        public List<Pair> Current { get; set; }

        [JsonProperty("historical")]
        public List<object> Historical { get; set; }
    }

    public partial class Pair
    {
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("exchange_fsym")]
        public string ExchangeFsym { get; set; }

        [JsonProperty("exchange_tsym")]
        public string ExchangeTsym { get; set; }

        [JsonProperty("fsym")]
        public string Fsym { get; set; }

        [JsonProperty("tsym")]
        public string Tsym { get; set; }

        [JsonProperty("last_update")]
        public long LastUpdate { get; set; }
    }
}
