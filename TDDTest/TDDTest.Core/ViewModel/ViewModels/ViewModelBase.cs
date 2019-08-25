using System;
using System.Reflection;
using TDDTest.Core.Helpers;
using TDDTest.Core.ViewModel.IViewServices;
using TDDTest.Core.ViewModel.Repository;
using TDDTest.Core.ViewModel.ViewModelServices;

namespace TDDTest.Core.ViewModel.ViewModels
{
    public class ViewModelBase
    {
        private readonly INavigationService navigationService;
        private NavigationHistoryRepository navigationHistoryRepository = Singleton<NavigationHistoryRepository>.Instance;

        public ViewModelBase(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            this.NextButton = new DelegateCommand(() => GotoNextPage());
            this.navigationHistoryRepository.Store(this.GetType().Name);
        }

        public DelegateCommand NextButton { get; set; }
        private void GotoNextPage()
        {
            this.navigationHistoryRepository.Store(MethodBase.GetCurrentMethod().Name);
            string nextPage = RouteGuidanceService.GetNextPageName();
            this.navigationService.Navigate(nextPage);
        }
    }
}