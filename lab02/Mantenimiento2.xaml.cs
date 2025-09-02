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
    /// Lógica de interacción para Mantenimiento2.xaml
    /// </summary>
    public partial class Mantenimiento2 : Window
    {
        public Mantenimiento2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento Mantenimiento = new Mantenimiento();
            Mantenimiento.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mantenimiento Mantenimiento = new Mantenimiento();
            Mantenimiento.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mantenimiento Mantenimiento = new Mantenimiento();
            Mantenimiento.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Mantenimiento Mantenimiento = new Mantenimiento();
            Mantenimiento.Show();
        }
    }
}
