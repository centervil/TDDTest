using System;
using System.Collections.Generic;
using System.Text;

namespace TDDTest.Core.ViewModel.IViewServices
{
    public interface INavigationService
    {
        bool Navigate(string nextViewModel);

    }
}
