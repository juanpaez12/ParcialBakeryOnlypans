using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BakeryOnlypans
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Empleado" && txtPassword.Password == "1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.frameMain.NavigationService.Navigate(new Empleado());
            }
            else if (txtUsername.Text == "Administrador" && txtPassword.Password == "admin123")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.frameMain.NavigationService.Navigate(new Administrador());
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalida");
            }
        }
    }
}
