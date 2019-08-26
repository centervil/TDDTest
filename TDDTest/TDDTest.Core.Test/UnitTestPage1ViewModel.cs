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
        public void �{�^������������Page2�ɑJ��()
        {
            //�e�X�g����
            var NavigationServiceMock = new Mock<INavigationService>();
            Page2ViewModel vm2;

            NavigationServiceMock
                .Setup(nav => nav.Navigate(nameof(Page2ViewModel)))
                .Returns(true)
                .Callback(() => vm2 = new Page2ViewModel(NavigationServiceMock.Object));

            //�e�X�g���s
            var vm = new Page1ViewModel(NavigationServiceMock.Object);
            vm.NextButton.Execute();

            //�������킹
            var navigationHistoryRepository = Singleton<NavigationHistoryRepository>.Instance;
            var nowPageActivity = navigationHistoryRepository.History.Last();
            Assert.AreEqual(nameof(Page2ViewModel), nowPageActivity.ViewModelName);
        }
    }
}

