using System.Windows.Controls;
using WPFCoreTest.Factories;

namespace WPFCoreTest.Views
{
    /// <summary>
    /// Page2.xaml の相互作用ロジック
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            DataContext = ViewModelFactory.CreateInstance(GetType());
        }
    }
}
