﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TDDTest.Core.ViewModel.ViewModels;
using TDDTest.WpfApp.Factories;
using TDDTest.WpfApp.ViewServices;

namespace TDDTest.WpfApp.Views
{
    /// <summary>
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            this.DataContext = ViewModelFactory.CreateInstance(this.GetType()) ;
        }
    }
}
