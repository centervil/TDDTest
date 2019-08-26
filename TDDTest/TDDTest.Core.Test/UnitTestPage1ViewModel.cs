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
        public void ボタンを押したらPage2に遷移()
        {
            //テスト準備
            var NavigationServiceMock = new Mock<INavigationService>();
            Page2ViewModel vm2;

            NavigationServiceMock
                .Setup(nav => nav.Navigate(nameof(Page2ViewModel)))
                .Returns(true)
                .Callback(() => vm2 = new Page2ViewModel(NavigationServiceMock.Object));

            //テスト実行
            var vm = new Page1ViewModel(NavigationServiceMock.Object);
            vm.NextButton.Execute();

            //答え合わせ
            var navigationHistoryRepository = Singleton<NavigationHistoryRepository>.Instance;
            var nowPageActivity = navigationHistoryRepository.History.Last();
            Assert.AreEqual(nameof(Page2ViewModel), nowPageActivity.ViewModelName);
        }
    }
}

