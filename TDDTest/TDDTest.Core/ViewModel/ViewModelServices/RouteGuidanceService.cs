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
                default:
                    break;
            }
            return nextPage;
        }
    }
}