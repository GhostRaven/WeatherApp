using Newtonsoft.Json;

namespace Examples.MVVM.Basic.Utilities
{
    public class Coord
    {
        [JsonProperty("lon")] public double Longitude { get; set; }
        [JsonProperty("lat")] public double Lattitude { get; set; }
    }
}
