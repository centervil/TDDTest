using TDDTest.Core.Helpers;
using TDDTest.Core.ViewModel.IViewServices;
using TDDTest.Core.ViewModel.Repository;

namespace TDDTest.Core.ViewModel.ViewModels
{
    public class ViewModelBase
    {
        private readonly INavigationService navigationService;
        private NavigationHistoryRepository navigationHistoryRepository = Singleton<NavigationHistoryRepository>.Instance;

        public ViewModelBase(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            this.NextButton = new DelegateCommand(() => { this.navigationService.Navigate(nameof(Page2ViewModel)); });
            this.navigationHistoryRepository.Store(this.GetType().Name);
        }

        public DelegateCommand NextButton { get; set; }
    }
}