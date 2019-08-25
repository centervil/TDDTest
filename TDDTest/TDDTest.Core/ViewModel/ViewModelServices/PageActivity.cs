using System;
using System.Collections.Generic;

namespace TDDTest.Core.ViewModel.ViewModelServices
{
    public class PageActivity
    {
        public PageActivity(string viewModelName)
        {
            this.ViewModelName = viewModelName;
        }

        public void AddUserActivity(UserActivity userActivity)
        {
            this.UserActivityList.Add(userActivity);
        }
        internal void AddPageState(PageState pageState)
        {
            this.PageStateList.Add(pageState);
        }

        public string ViewModelName { get; private set; }
        public List<UserActivity> UserActivityList { get; private set; }
        public List<PageState> PageStateList { get; private set; }

    }
}