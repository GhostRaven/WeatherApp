using ColourViewer.Views;
using MvvmFoundation;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace ColourViewer.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private ObservableCollection<ColourViewModel> _colours;

        public ObservableCollection<ColourViewModel> Colours
        {
            get { return _colours; }
            set { _colours = value; base.RaisePropertyChanged("Colours"); }
        }

        public MainViewModel()
        {
            Colours = new ObservableCollection<ColourViewModel>();
            Colours.CollectionChanged += Colours_CollectionChanged;
        }

        private void Colours_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            base.RaisePropertyChanged("Colours");
        }

        private RelayCommand _addCommand;
        public RelayCommand AddCommand => _addCommand ?? (_addCommand = new RelayCommand(() =>
        {
            Colours.Add(new ColourViewModel());
        }));

        private RelayCommand _loadCommand;
        public RelayCommand LoadCommand => _loadCommand ?? (_loadCommand = new RelayCommand(() =>
        {
            Colours.Clear();

            var window = new TextLoadWindow();
            window.ShowDialog();
            var input = window.Value;

            foreach (Match item in Regex.Matches(input, @"<SolidColorBrush.*\/>"))
            {
                var c = GenerateColour(item.Value);
                if (c == null)
                    continue;
                Colours.Add(c);
            }
        }));

        private ColourViewModel GenerateColour(string item)
        {
            var name = Regex.Match(item, "x:Key=\"([\\w+\\.]*)\"");
            var colour = Regex.Match(item, "Color=\"(#[A-Za-z0-9]*)\"");

            if (!name.Success || !colour.Success)
                return null;

            return new ColourViewModel() { ColourValue = colour.Groups[1].Value, Name = name.Groups[1].Value.Replace(".","\r\n") };
        }
    }
}
