using Examples.MVVM.Basic.Utilities;
using MvvmFoundation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.MVVM.Basic.ViewModels
{
    public class WeatherViewModel : ObservableObject
    {
        private Coord _coord;
        public Coord Coord
        {
            get { return _coord; }
            set { _coord = value; base.RaisePropertyChanged(nameof(Coord)); }
        }

        private ObservableCollection<Weather> _weather;
        public ObservableCollection<Weather> Weather
        {
            get { return _weather; }
            set { _weather = value; base.RaisePropertyChanged(nameof(Weather)); }
        }

        private string _base;
        public string Base
        {
            get { return _base; }
            set { _base = value; base.RaisePropertyChanged(nameof(Base)); }
        }

        private Main _main;
        public Main Main
        {
            get { return _main; }
            set { _main = value; base.RaisePropertyChanged(nameof(Main)); }
        }

        private Wind _wind;
        public Wind Wind
        {
            get { return _wind; }
            set { _wind = value; base.RaisePropertyChanged(nameof(Wind)); }
        }

        private Clouds _clouds;
        public Clouds Clouds
        {
            get { return _clouds; }
            set { _clouds = value; base.RaisePropertyChanged(nameof(Clouds)); }
        }

        private int _dt;
        public int Dt
        {
            get { return _dt; }
            set { _dt = value; base.RaisePropertyChanged(nameof(Dt)); }
        }

        private Sys _sys;
        public Sys Sys
        {
            get { return _sys; }
            set { _sys = value; base.RaisePropertyChanged(nameof(Sys)); }
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; base.RaisePropertyChanged(nameof(Id)); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; base.RaisePropertyChanged(nameof(Name)); }
        }

        private int _cod;
        public int Cod
        {
            get { return _cod; }
            set { _cod = value; base.RaisePropertyChanged(nameof(Cod)); }
        }


        public WeatherViewModel(WeatherResponse weather)
        {
            Coord = weather.Coord;
            Weather = new ObservableCollection<Weather>(weather.Weather);
            Base = weather.Base;
            Main = weather.Main;
            Wind = weather.Wind;
            Clouds = weather.Clouds;
            Dt = weather.Dt;
            Sys = weather.Sys;
            Id = weather.Id;
            Name = weather.Name;
            Cod = weather.Cod;
        }
    }
}
