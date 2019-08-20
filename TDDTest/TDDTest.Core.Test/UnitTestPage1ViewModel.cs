using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTest.Core.Helpers;
using TDDTest.Core.ViewModel.IViewServices;
using TDDTest.Core.ViewModel.ViewModels;

namespace TDDTest.Core.Test
{
    [TestClass]
    public class UnitTestPage1ViewModel
    {
        [TestMethod]
        public void ƒ{ƒ^ƒ“‚ð‰Ÿ‚µ‚½‚çPage2‚É‘JˆÚ()
        {
            var navigationServiceMock = new NavigationServiceMock();
            var vm = new Page1ViewModel(navigationServiceMock);
            vm.NextButton.Execute();
            Assert.AreEqual(nameof(Page2ViewModel), navigationServiceMock.nextPage);
        }
    }

    internal class NavigationServiceMock : INavigationService
    {
        internal string nextPage = "";

        public NavigationServiceMock()
        {
        }

        public void Navigate(string v)
        {
            this.nextPage = v;
        }
    }
}
