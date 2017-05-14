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
    /// Interaction logic for SalaKinowa.xaml
    /// </summary>
    public partial class SalaKinowa : Window
    {
        private String user;
        private String selectedFilm;
        public SalaKinowa(String user, String selectedFilm)
        {
            InitializeComponent();
            this.user = user;
            this.selectedFilm = selectedFilm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow repertuar = new MainWindow(user);
            repertuar.Show();
            this.Close();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PotwierdzeniePlatnosci potplatnosc= new PotwierdzeniePlatnosci(user, selectedFilm);
            potplatnosc.Show();
            this.Close();
        }
    }
}
