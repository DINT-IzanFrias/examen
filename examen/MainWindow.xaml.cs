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

namespace examen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int c = 0;
        }

        private void añadir_Click(object sender, RoutedEventArgs e)
        {
            if(escribe is not null)
                añadir.IsEnabled=true;
            else
                añadir.IsEnabled = false;

            texto.Text += escribe.Text;

            c++;

        }

        private void Contador(object sender, RoutedEventArgs e)
        {
            MessageBoxImage("se ha pulsado" + c + "veces");
        }

    }
}
