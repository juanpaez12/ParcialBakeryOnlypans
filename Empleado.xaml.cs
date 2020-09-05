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
    /// Lógica de interacción para Empleado.xaml
    /// </summary>
    public partial class Empleado : Page
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            DateTime Now = DateTime.Now;
            string nombre = txtNombre.Text;
            string documento = txtdocumento.Text;
            string tipo = txtTipo.Text;
            string cantidad = txtCantidad.Text;

            Lstdata.Items.Add(txtNombre.Text);
            Lstdata.Items.Add(txtdocumento.Text);
            Lstdata.Items.Add(txtTipo.Text);
            Lstdata.Items.Add(txtCantidad.Text);


            if (txtTipo.Text == "1")
            {
                txtTipo.Text = "1000";
            }
            if (txtTipo.Text == "2")
            {
                txtTipo.Text = "500";
            }
            if (txtTipo.Text == "3")
            {
                txtTipo.Text = "2000";
            }

            int Cantidad;
            int precio;
            int total;

            try
            {
                Cantidad = int.Parse(txtCantidad.Text);
                precio = int.Parse(txtTipo.Text);


                total = Cantidad * precio;
                txtCantidad.Text = total.ToString();
                Lstdata.Items.Add(txtCantidad.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese sólo números");

            }
            Lstdata.Items.Add(DateTime.Now);


        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Home());
        }
    }
}
