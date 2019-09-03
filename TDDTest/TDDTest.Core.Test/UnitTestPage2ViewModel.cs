using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDDTest.Core.Helpers;
using TDDTest.Core.ViewModel.IViewServices;
using TDDTest.Core.ViewModel.Repository;
using TDDTest.Core.ViewModel.ViewModels;

namespace TDDTest.Core.Test
{

    [TestClass]
    public class UnitTestPage2ViewModel
    {
        [TestMethod]
        public void 戻るボタンを押したらPage1に遷移()
        {
            //テスト準備
            var NavigationServiceMock1 = new Mock<INavigationService>();
            var NavigationServiceMock2 = new Mock<INavigationService>();
            ViewModelBase vm;

            NavigationServiceMock1
                .Setup(nav => nav.Navigate(nameof(Page2ViewModel)))
                .Returns(true)
                .Callback(() => vm = new Page2ViewModel(NavigationServiceMock2.Object));

            NavigationServiceMock2
                .Setup(nav => nav.Navigate(nameof(Page1ViewModel)))
                .Returns(true)
                .Callback(() => vm = new Page1ViewModel(NavigationServiceMock1.Object));

            //テスト実行
            vm = new Page1ViewModel(NavigationServiceMock1.Object);
            vm.NextButton.Execute();
            vm.BackButton.Execute();

            //答え合わせ
            var navigationHistoryRepository = Singleton<NavigationHistoryRepository>.Instance;
            var nowPageActivity = navigationHistoryRepository.History.Last();
            Assert.AreEqual(nameof(Page1ViewModel), nowPageActivity.ViewModelName);
            Assert.AreEqual(1, navigationHistoryRepository.History.Count);
        }
    }
}
