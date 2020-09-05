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
            cmbItms.Items.Add("Aliñados");
            cmbItms.Items.Add("NoAliñados");
            cmbItms.Items.Add("Especial");
        }

        private void Lstdata_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
