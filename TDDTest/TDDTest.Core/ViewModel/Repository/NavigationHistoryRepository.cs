using System;
using System.Collections.Generic;

namespace TDDTest.Core.ViewModel.Repository
{
    public sealed class NavigationHistoryRepository
    {
        public NavigationHistoryRepository()
        {
            History = new List<string>();
        }

        public List<string> History { get; private set; }

        internal void Store(string viewModelName)
        {
            History.Add(viewModelName);
        }
    }
}