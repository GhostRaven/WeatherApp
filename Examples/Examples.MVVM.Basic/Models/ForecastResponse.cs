using Newtonsoft.Json;
using System.Collections.Generic;

namespace Examples.MVVM.Basic.Utilities
{
    public class ForecastResponse
    {
        [JsonProperty("cod")] public string Cod { get; set; }
        [JsonProperty("message")] public double Message { get; set; }
        [JsonProperty("cnt")] public int Cnt { get; set; }
        [JsonProperty("list")] public IList<List> List { get; set; }
        [JsonProperty("city")] public City City { get; set; }
    }
}
