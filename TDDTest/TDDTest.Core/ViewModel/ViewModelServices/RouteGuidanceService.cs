using System;
using System.Linq;
using TDDTest.Core.Helpers;
using TDDTest.Core.ViewModel.Repository;
using TDDTest.Core.ViewModel.ViewModels;

namespace TDDTest.Core.ViewModel.ViewModelServices
{
    internal class RouteGuidanceService
    {
        internal static string GetNextPageName()
        {
            var navigationHistoryRepository = Singleton<NavigationHistoryRepository>.Instance;
            PageActivity LatestPageActivity = navigationHistoryRepository.History.Last();
            return DeriveNextPage(LatestPageActivity);
        }
        private static string DeriveNextPage(PageActivity pageActivity)
        {
            string nextPage = "";
            switch (pageActivity.ViewModelName)
            {
                case nameof(Page1ViewModel):
                    if (pageActivity.UserActivityList.Last().CommandName == nameof(Page1ViewModel.NextButton))
                        nextPage = nameof(Page2ViewModel);
                    break;
                case nameof(Page2ViewModel):
                    if (pageActivity.UserActivityList.Last().CommandName == nameof(Page2ViewModel.NextButton))
                        nextPage = nameof(Page3ViewModel);
                    break;
                case nameof(Page3ViewModel):
                    if (pageActivity.UserActivityList.Last().CommandName == nameof(Page3ViewModel.NextButton))
                        nextPage = nameof(Page1ViewModel);
                    break;
                default:
                    break;
            }
            return nextPage;
        }

        internal static string GetPreviousPageName()
        {
            var navigationHistoryRepository = Singleton<NavigationHistoryRepository>.Instance;
            var previousViewModelName = navigationHistoryRepository.GetPreviousPageActivity().ViewModelName;
            navigationHistoryRepository.RemoveLast();
            navigationHistoryRepository.RemoveLast();
            return previousViewModelName;
        }
    }
}