using System;
using System.Collections.Generic;
using System.Linq;
using TDDTest.Core.ViewModel.ViewModelServices;

namespace TDDTest.Core.ViewModel.Repository
{
    public sealed class NavigationHistoryRepository
    {
        public NavigationHistoryRepository()
        {
            History = new List<PageActivity>();
        }

        public List<PageActivity> History { get; private set; }

        internal void Store(PageActivity pageActivity)
        {
            History.Add(pageActivity);
        }
        internal void Store(UserActivity userActivity)
        {
            History.Last().AddUserActivity(userActivity);
        }
        internal void Store(PageState pageState)
        {
            History.Last().AddPageState(pageState);
        }
    }
}