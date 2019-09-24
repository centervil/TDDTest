using System.Windows.Controls;
using WPFCoreTest.Factories;

namespace WPFCoreTest.Views
{
    /// <summary>
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            DataContext = ViewModelFactory.CreateInstance(GetType());
        }
    }
}
