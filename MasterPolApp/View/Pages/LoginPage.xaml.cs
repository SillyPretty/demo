using MasterPolApp.Core;
using MasterPolApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterPolApp.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region Login
            if (string.IsNullOrEmpty(TbLogin.Text) && string.IsNullOrEmpty(TbPassword.Text))
            {
                MessageBox.Show("Все грустно :(");
            }
            else
            {
                User userModel = MyService.DB.Users.FirstOrDefault(r => r.UserLogin == TbLogin.Text && r.UserPassword == TbPassword.Text);

                if (userModel != null)
                {
                    switch (userModel.RoleID)
                    {
                        case 1:
                            MessageBox.Show("Я админ и есть редбул!");
                            break;
                        case 2:
                            MessageBox.Show("Я не админ но и есть редбул!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Все грустно :(, но иначе?");

                    TbPassword.Text = string.Empty;
                    TbLogin.Text = string.Empty;
                }
            }
            #endregion

            //if (string.IsNullOrEmpty(TbLogin.Text) && string.IsNullOrEmpty(TbPassword.Text))
            //{
            //    MessageBox.Show("Все грустно :(");
            //}
            //else 
            //{
            //    MyService.DB.Users.Add(new User()
            //    {
            //        UserLogin = TbLogin.Text,
            //        UserPassword = TbPassword.Text,
            //        RoleID = 2
            //    });
            //    MyService.DB.SaveChanges();
            //    MessageBox.Show("Новый редбул :)");

            //    TbPassword.Text = string.Empty;
            //    TbLogin.Text = string.Empty;
            //}
        }
    }
}
