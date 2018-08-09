using Newtonsoft.Json;

namespace Examples.MVVM.Basic.Utilities
{
    public class City
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("country")] public string Country { get; set; }
        [JsonProperty("coord")] public Coord Coordinates { get; set; }
    }
}
