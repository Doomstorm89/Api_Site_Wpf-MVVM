using System.Windows;
using WpfApp2_News_test.Entities;
using WpfApp2_News_test.Extensions;
using WpfApp2_News_test.ViewModel;

namespace WpfApp2_News_test
{
   public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new NewsViewModel();
        }
    }
}