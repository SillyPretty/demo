using MasterPolApp.Core;
using MasterPolApp.Model;
using MasterPolApp.View.Pages;
using System.Windows;

namespace MasterPolApp
{
    /// <summary>
    /// Главное окно навигации приложения
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyService.MainNavigationFrameApp = MainFrame;
            MyService.DB = new MasterPoldbEntities1();

            MainFrame.Navigate(new LoginPage());
        }

        private void PartnerProducts_Button_Click(object sender, RoutedEventArgs e)
        {
            MyService.MainNavigationFrameApp.Navigate(new PartnerProductsPage());
        }

        private void ProductType_Button_Click(object sender, RoutedEventArgs e)
        {
            MyService.MainNavigationFrameApp.Navigate(new ProductTypePage());
        }

        private void Material_Button_Click(object sender, RoutedEventArgs e)
        {
            MyService.MainNavigationFrameApp.Navigate(new MaterialPage());
        }

        private void Product_Button_Click(object sender, RoutedEventArgs e)
        {
            MyService.MainNavigationFrameApp.Navigate(new ProductsPage());
        }

        private void Partners_Click(object sender, RoutedEventArgs e)
        {
            MyService.MainNavigationFrameApp.Navigate(new ParnersPage());
        }

        private void TextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();

        }
    }
}
