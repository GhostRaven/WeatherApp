using Newtonsoft.Json;

namespace Examples.MVVM.Basic.Utilities
{
    public class Rain
    {
        [JsonProperty("3h")]
        public double _3h { get; set; }
    }
}
