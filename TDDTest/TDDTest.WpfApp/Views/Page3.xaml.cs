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
using TDDTest.WpfApp.Factories;

namespace TDDTest.WpfApp.Views
{
    /// <summary>
    /// Page3.xaml の相互作用ロジック
    /// </summary>
    public partial class Page3 : PageBase
    {
        public Page3()
        {
            InitializeComponent();
            this.DataContext = ViewModelFactory.CreateInstance(this.GetType());
        }
    }
}
