using System;
using System.Linq;
using TDDTest.Core.Helpers;
using TDDTest.Core.ViewModel.Repository;

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
            return "";
        }
    }
}