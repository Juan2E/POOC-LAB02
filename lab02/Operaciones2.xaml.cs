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
    /// Lógica de interacción para Operaciones2.xaml
    /// </summary>
    public partial class Operaciones2 : Window
    {
        public Operaciones2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Operaciones Operaciones = new Operaciones();
            Operaciones.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Operaciones Operaciones = new Operaciones();
            Operaciones.Show();
        }
    }
}
