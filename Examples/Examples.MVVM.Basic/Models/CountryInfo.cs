using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.MVVM.Basic.Utilities
{

    public class CountryInfo
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("topLevelDomain")] public IList<string> TopLevelDomain { get; set; }
        [JsonProperty("alpha2Code")] public string Alpha2Code { get; set; }
        [JsonProperty("alpha3Code")] public string Alpha3Code { get; set; }
        [JsonProperty("callingCodes")] public IList<string> CallingCodes { get; set; }
        [JsonProperty("capital")] public string Capital { get; set; }
        [JsonProperty("altSpellings")] public IList<string> AltSpellings { get; set; }
        [JsonProperty("region")] public string Region { get; set; }
        [JsonProperty("subregion")] public string Subregion { get; set; }
        [JsonProperty("population")] public int Population { get; set; }
        [JsonProperty("latlng")] public IList<double> Latlng { get; set; }
        [JsonProperty("demonym")] public string Demonym { get; set; }
        [JsonProperty("area")] public double? Area { get; set; }
        [JsonProperty("gini")] public double? Gini { get; set; }
        [JsonProperty("timezones")] public IList<string> Timezones { get; set; }
        [JsonProperty("borders")] public IList<string> Borders { get; set; }
        [JsonProperty("nativeName")] public string NativeName { get; set; }
        [JsonProperty("numericCode")] public string NumericCode { get; set; }
        [JsonProperty("currencies")] public IList<Currency> Currencies { get; set; }
        [JsonProperty("languages")] public IList<Language> Languages { get; set; }
        [JsonProperty("translations")] public Translations Translations { get; set; }
        [JsonProperty("flag")] public string Flag { get; set; }
        [JsonProperty("regionalBlocs")] public IList<RegionalBloc> RegionalBlocs { get; set; }
        [JsonProperty("cioc")] public string Cioc { get; set; }
    }
}
