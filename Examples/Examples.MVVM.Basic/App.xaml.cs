﻿using Examples.MVVM.Basic.Utilities.Web;
using Examples.MVVM.Basic.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Examples.MVVM.Basic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainViewModel viewModel;

        protected override void OnStartup(StartupEventArgs e)
        {
            var webDataProvider = new DefaultWebDataProvider();

            viewModel = new MainViewModel(webDataProvider);
            var view = new MainWindow() { DataContext = viewModel };
            view.ShowDialog();
        }
    }
}
