using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TDDTest.Core.ViewModel.IViewServices;
using WPFCoreTest;

namespace WPFCoreTest.ViewServices
{
    class NavigationService : INavigationService
    {
        private Frame frame;

        public NavigationService(MainWindow window)
        {
            frame = window.frame;
        }

        public bool Navigate(string nextViewModel)
        {
            Type pageType = GetPageType(nextViewModel);
            return frame.Navigate(Activator.CreateInstance(pageType));
        }

        private Type GetPageType(string nextViewModel)
        {
            string nextViewName = GetType().Namespace.Replace("Service", "") + "." + nextViewModel.Replace("ViewModel", "");
            return Type.GetType(nextViewName);
        }
    }
}
