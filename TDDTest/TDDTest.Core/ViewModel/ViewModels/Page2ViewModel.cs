using System;
using System.Collections.Generic;
using System.Text;
using TDDTest.Core.ViewModel.IViewServices;

namespace TDDTest.Core.ViewModel.ViewModels
{
    public class Page2ViewModel : ViewModelBase
    {
        public Page2ViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
