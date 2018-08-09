using Newtonsoft.Json;

namespace Examples.MVVM.Basic.Utilities
{
    public class Wind
    {

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public double Deg { get; set; }
    }

}
