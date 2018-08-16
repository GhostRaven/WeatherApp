using MvvmFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ColourViewer.ViewModels
{
    public class ColourViewModel : ObservableObject
    {
        private string _colour;

        public string ColourValue
        {
            get { return _colour; }
            set
            {
                if (!ValidateColourValue(value))
                    return;

                _colour = value;
                base.RaisePropertyChanged("ColourValue");
            }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; base.RaisePropertyChanged("Name"); }
        }


        private bool ValidateColourValue(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            return Regex.IsMatch(input, @"#[A-Fa-f0-9]{8}");
        }

        public ColourViewModel()
        {
            ColourValue = "#FFFFFFFF";
            Name = "None";
        }
    }
}
