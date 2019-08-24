using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TDDTest.Core.Helpers;
using TDDTest.Core.ViewModel.IViewServices;
using TDDTest.Core.ViewModel.ViewModels;
using TDDTest.Core.ViewModel.Repository;
using System.Linq;

namespace TDDTest.Core.Test
{
    [TestClass]
    public class UnitTestPage1ViewModel
    {
        [TestMethod]
        public void ƒ{ƒ^ƒ“‚ð‰Ÿ‚µ‚½‚çPage2‚É‘JˆÚ()
        {
            var testMock = new Mock<INavigationService>();
            Page2ViewModel vm2;
            testMock
                .Setup(nav => nav.Navigate(nameof(Page2ViewModel)))
                .Returns(true)
                .Callback(() => vm2 = new Page2ViewModel(testMock.Object));
            //var navigationServiceMock = new NavigationServiceMock();
            var vm = new Page1ViewModel(testMock.Object);
            vm.NextButton.Execute();
            //Assert.AreEqual(true, navigationServiceMock.nextPage);
            var navigationHistoryRepository = Singleton<NavigationHistoryRepository>.Instance;
            string nowPage = navigationHistoryRepository.History.Last();
            Assert.AreEqual(nameof(Page2ViewModel), nowPage);
        }
    }
}

//    internal class NavigationServiceMock : INavigationService
//    {
//        internal string nextPage = "";

//        public NavigationServiceMock()
//        {
//        }

//        public void Navigate(string v)
//        {
//            this.nextPage = v;
//        }
//    //}
//}
