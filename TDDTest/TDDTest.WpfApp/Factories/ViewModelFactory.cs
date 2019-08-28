using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TDDTest.Core.ViewModel.ViewModels;
using TDDTest.WpfApp.ViewServices;

namespace TDDTest.WpfApp.Factories
{
    internal class ViewModelFactory
    {
        internal static ViewModelBase CreateInstance(Type pageType)
        {
            Assembly asm = Assembly.LoadFrom("TDDTest.Core.dll");
            string viewModelName = "TDDTest.Core.ViewModel.ViewModels." + pageType.Name + "ViewModel";
            Type viewModelType = asm.GetType(viewModelName);
            var navigationService = new NavigationService((MainWindow)Application.Current.MainWindow);
            return (ViewModelBase)Activator.CreateInstance(viewModelType, navigationService);
        }
    }
}
