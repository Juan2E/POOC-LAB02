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
using System.Windows.Shapes;

namespace lab02
{
    /// <summary>
    /// Lógica de interacción para MENUHOME.xaml
    /// </summary>
    public partial class MENUHOME : Window
    {
        public MENUHOME()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mantenimiento2 mantenimiento = new Mantenimiento2();
            mantenimiento.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
