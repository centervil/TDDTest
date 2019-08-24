using System;
using System.Collections.Generic;
using System.Text;
using TDDTest.Core.ViewModel.IViewServices;

namespace TDDTest.Core.ViewModel.ViewModels
{
    public class Page1ViewModel : ViewModelBase
    {
        public Page1ViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
