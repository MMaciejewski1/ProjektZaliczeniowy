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
using Cinema.Controller;
namespace Cinema.View {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            listView.Items.Add("Proszem wybrac date");
            List<string> tab = new Cinema.Controller.KalendarzFilmow().getGodziny();
            for (int i = 0; i < tab.Count; i++) comboBox.Items.Add(tab[i]);
        }  
        private void calendar_SelectedDateChanged(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();
            DateTime? date = calendar.SelectedDate;
            string a = date.ToString();
            string b = a.Substring(0, a.IndexOf('.'));
            string c = a.Substring(a.IndexOf('.') + 1, a.IndexOf('.'));
            string d = a.Substring(a.IndexOf(c) + 3, 4);
            List<string> tab = new List<string>();
            Cinema.Controller.KalendarzFilmow ac = new Cinema.Controller.KalendarzFilmow();
            label1.Content = date.ToString();
            tab = ac.getlistaFilmow(d, c, b);
            for (int i = 0; i < tab.Count; i++) listView.Items.Add(tab[i]);
        }
    }
}
