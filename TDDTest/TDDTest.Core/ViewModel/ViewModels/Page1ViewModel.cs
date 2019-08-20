using System;
using System.Collections.Generic;
using System.Text;
using TDDTest.Core.Helpers;
using TDDTest.Core.ViewModel.IViewServices;

namespace TDDTest.Core.ViewModel.ViewModels
{
    public class Page1ViewModel
    {
        private readonly INavigationService navigationService;

        public Page1ViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            this.NextButton = new DelegateCommand(() => { this.navigationService.Navigate(nameof(Page2ViewModel)); });
        }

        public DelegateCommand NextButton { get; set; }
    }
}
