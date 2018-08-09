using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.MVVM.Basic.Utilities
{
    public class Main
    {
        [JsonProperty("temp")]
        [JsonConverter(typeof(JsonKelvinToCelsiusConverter))]
        public double Temp { get; set; }

        [JsonProperty("temp_min")]
        [JsonConverter(typeof(JsonKelvinToCelsiusConverter))]
        public double TempMin { get; set; }

        [JsonProperty("temp_max")]
        [JsonConverter(typeof(JsonKelvinToCelsiusConverter))]
        public double TempMax { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("sea_level")]
        public double SeaLevel { get; set; }

        [JsonProperty("grnd_level")]
        public double GrndLevel { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("temp_kf")]
        public double TempKf { get; set; }
    }
}
