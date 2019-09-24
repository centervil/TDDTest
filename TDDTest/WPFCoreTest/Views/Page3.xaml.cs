using System.Windows.Controls;
using WPFCoreTest.Factories;

namespace WPFCoreTest.Views
{
    /// <summary>
    /// Page3.xaml の相互作用ロジック
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            DataContext = ViewModelFactory.CreateInstance(GetType());
        }
    }
}
