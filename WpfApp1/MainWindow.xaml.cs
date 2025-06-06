using System.Windows;
using WpfApp1.Model;
using WpfApp1.Service;

namespace WpfApp1
{
    /// <summary>
    /// Главное окно навигации приложения
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyService.MyServiceNavigateApp = MainFrame;
            MyService.DB = new MasterPoldb2Entities();
        }
    }
}
