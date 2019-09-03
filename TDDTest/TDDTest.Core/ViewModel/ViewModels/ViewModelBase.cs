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
            this.NextButton = new DelegateCommand(() => GotoNextPage(), nameof(this.NextButton));
            this.BackButton = new DelegateCommand(() => BacktoPreviousPage(), nameof(this.BackButton));
            this.navigationHistoryRepository.Store(new PageActivity(this.GetType().Name));
        }

        public DelegateCommand NextButton { get; set; }
        public DelegateCommand BackButton { get; set; }
        private void GotoNextPage()
        {
            this.navigationHistoryRepository.Store(new UserActivity(this.NextButton.CommandName));
            string nextPage = RouteGuidanceService.GetNextPageName();
            this.navigationService.Navigate(nextPage);
        }
        private void BacktoPreviousPage()
        {
            this.navigationHistoryRepository.Store(new UserActivity(this.BackButton.CommandName));
            string previousPage = RouteGuidanceService.GetPreviousPageName();
            this.navigationService.Navigate(previousPage);
        }
    }
}