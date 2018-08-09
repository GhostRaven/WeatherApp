using Examples.MVVM.Basic.Utilities;
using MvvmFoundation;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Examples.MVVM.Basic.ViewModels
{
    public class ForecastViewModel : ObservableObject
    {
        private string _cod;
        public string Cod
        {
            get { return _cod; }
            set { _cod = value; base.RaisePropertyChanged(nameof(Cod)); }
        }

        private double _message;
        public double Message
        {
            get { return _message; }
            set { _message = value; base.RaisePropertyChanged(nameof(Message)); }
        }

        private int _cnt;
        public int Cnt
        {
            get { return _cnt; }
            set { _cnt = value; base.RaisePropertyChanged(nameof(Cnt)); }
        }

        private ObservableCollection<List> _list = new ObservableCollection<Utilities.List>();
        public ObservableCollection<List> List
        {
            get { return _list; }
            set { _list = value; base.RaisePropertyChanged(nameof(List)); }
        }

        private City _city;
        public City City
        {
            get { return _city; }
            set { _city = value; base.RaisePropertyChanged(nameof(City)); }
        }

        public ForecastViewModel(ForecastResponse forecast)
        {
            Cod = forecast.Cod;
            Message = forecast.Message;
            Cnt = forecast.Cnt;
            List = new ObservableCollection<List>(forecast.List);
            City = forecast.City;
        }
    }
}
