using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BitCouincalculatorTARpe23ChristoferKrabbi
{
    public class BitcoinRates
    {
        public Data Data { get; set; }
    }
    public class Data
    {
        [JsonProperty("BTC-USD")]
        public BTCUSD BTCUSD { get; set; }

    }
    

}
