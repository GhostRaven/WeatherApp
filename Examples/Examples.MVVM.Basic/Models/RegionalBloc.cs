using Newtonsoft.Json;
using System.Collections.Generic;

namespace Examples.MVVM.Basic.Utilities
{
    public class RegionalBloc
    {

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("otherAcronyms")]
        public IList<object> OtherAcronyms { get; set; }

        [JsonProperty("otherNames")]
        public IList<object> OtherNames { get; set; }
    }
}
