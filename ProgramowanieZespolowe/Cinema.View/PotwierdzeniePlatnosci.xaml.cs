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

namespace Cinema.View
{
    /// <summary>
    /// Interaction logic for PotwierdzeniePlatnosci.xaml
    /// </summary>
    public partial class PotwierdzeniePlatnosci : Window
    {
        private String user;
        public PotwierdzeniePlatnosci(String user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Anuluj_Click(object sender, RoutedEventArgs e)
        {
            MainWindow repertuar = new MainWindow(user);
            repertuar.Show();
            this.Close();
        }

        private void Potwierdz_Click(object sender, RoutedEventArgs e)
        {
            Platnosc platnosc = new Platnosc(user);
            platnosc.Show();
            this.Close();
        }
    }
}
