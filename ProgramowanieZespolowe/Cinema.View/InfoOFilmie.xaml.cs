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
using Cinema.Controller;
namespace Cinema.View
{
    /// <summary>
    /// Interaction logic for InfoOFilmie.xaml
    /// </summary>
    public partial class InfoOFilmie : Window
    {
        public InfoOFilmie()
        {
            InitializeComponent();
            Cinema.Controller.InfoOFilmie a = new Cinema.Controller.InfoOFilmie();
           image.Source = new BitmapImage(
        new Uri(a.setOkladka(4), UriKind.Absolute));
            obsadaZBazy.Content=a.setObsada(4);
            rezyserZBazy.Content = a.setRezyser(4);
            dlugoscZBazy.Content = a.setDlugosc(4);
            opisZBazy.Content = a.setOpis(4);
          
        }
    }
}
