using Examples.MVVM.Basic.Utilities;
using MvvmFoundation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Examples.MVVM.Basic.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private string _apiKey = "75c4a5cd628fa977ead497585555c7c8";
        private string _uriCountryInfo = @"https://restcountries.eu/rest/v2/all";
        private string _uriWeatherInfo = @"http://api.openweathermap.org/data/2.5/";

        private string _cityName;
        private List<City> _loadedCities;
        private ObservableCollection<City> _cities;
        private ObservableCollection<CountryInfo> _countries;
        private City _selectedCity;
        private CountryInfo _selectedCountry;
        private ForecastResponse _forecast;
        private WeatherResponse _weather;

        private string _flagSource;

        public string FlagSource
        {
            get { return _flagSource; }
            set { _flagSource = value; base.RaisePropertyChanged(nameof(FlagSource)); }
        }


        private ObservableObject _actualViewModel;
        public ObservableObject ActualViewModel
        {
            get { return _actualViewModel; }
            set { _actualViewModel = value; base.RaisePropertyChanged(nameof(ActualViewModel)); }
        }


        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; base.RaisePropertyChanged(nameof(CityName)); }
        }

        public List<City> LoadedCities
        {
            get { return _loadedCities; }
            set { _loadedCities = value; base.RaisePropertyChanged(nameof(LoadedCities)); }
        }

        public ObservableCollection<City> Cities
        {
            get { return _cities; }
            set { _cities = value; base.RaisePropertyChanged(nameof(Cities)); }
        }

        public ObservableCollection<CountryInfo> Countries
        {
            get { return _countries; }
            set { _countries = value; base.RaisePropertyChanged(nameof(Countries)); }
        }


        public City SelectedCity
        {
            get { return _selectedCity; }
            set { _selectedCity = value; base.RaisePropertyChanged(nameof(SelectedCity)); }
        }

        public CountryInfo SelectedCountry
        {
            get { return _selectedCountry; }
            set
            {
                if (value == _selectedCountry || value == null)
                    return;
                _selectedCountry = value;
                base.RaisePropertyChanged(nameof(SelectedCountry));

                DoShit(_selectedCountry.Alpha2Code);
            }
        }

        private void DoShit(string alpha2code)
        {
            Task.Factory.StartNew(() =>
            {
                FlagSource = $"https://www.countryflags.io/{alpha2code}/shiny/64.png";
                Cities = new ObservableCollection<City>(LoadedCities
                                                        .Where(x => x.Country == alpha2code)
                                                        .OrderBy(x => x.Name));
            });
        }

        public ForecastResponse Forecast
        {
            get { return _forecast; }
            set { _forecast = value; base.RaisePropertyChanged(nameof(Forecast)); }
        }
        public WeatherResponse Weather
        {
            get { return _weather; }
            set { _weather = value; base.RaisePropertyChanged(nameof(Weather)); }
        }

        private RelayCommand _commandGetWeather;
        public RelayCommand CommandGetWeather => _commandGetWeather ?? (_commandGetWeather = new RelayCommand(() =>
        {
            GetResponseWeather($"{_uriWeatherInfo}weather?id={SelectedCity.Id}&APPID={_apiKey}");   
        }));

        private RelayCommand _commandGetForecast;
        public RelayCommand CommandGetForecast => _commandGetForecast ?? (_commandGetForecast = new RelayCommand(() =>
        {
            GetResponseForecast($"{_uriWeatherInfo}forecast?id={SelectedCity.Id}&APPID={_apiKey}");
        }));


        public MainViewModel()
        {
            LoadedCities = Tools.JsonDeserialize<List<City>>(@"DataSystem/city.list.json");
            Countries = Tools.JsonDeserialize<ObservableCollection<CountryInfo>>(@"DataSystem/country.list.json");
            SelectedCountry = Countries.FirstOrDefault();
            Cities = new ObservableCollection<City>(LoadedCities
                                        .Where(x => x.Country == SelectedCountry.Alpha2Code)
                                        .OrderBy(x => x.Name));

            SelectedCity = Cities.FirstOrDefault();
        }


        public async void GetResponseCountries(string uri)
        {
            var result = await GetResponse(uri);
            Countries = (ObservableCollection<CountryInfo>)JsonConvert.DeserializeObject<ObservableCollection<CountryInfo>>(result);
            //Console.WriteLine("YY");
        }

        public async void GetResponseForecast(string uri)
        {
            var result = await GetResponse(uri);
            Forecast = (ForecastResponse)JsonConvert.DeserializeObject<ForecastResponse>(result);
            ActualViewModel = new ForecastViewModel(Forecast);
            //Console.WriteLine("XX");
        }

        public async void GetResponseWeather(string uri)
        {
            var result = await GetResponse(uri);
            Weather = (WeatherResponse)JsonConvert.DeserializeObject<WeatherResponse>(result);
            ActualViewModel = new WeatherViewModel(Weather);
            //Console.WriteLine("ZZ");
        }

        public Task<string> GetResponse(string uri)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetResponseFromWebsite(uri);
            });
        }
        public string GetResponseFromWebsite(string uri)
        {
            try
            {
                string output = string.Empty;

                HttpWebRequest request = WebRequest.CreateHttp(uri);
                request.Method = "GET";
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                    output = reader.ReadToEnd();

                return output;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}