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
        private int screening_id = 1;
        private byte[][] sala;
        public SalaKinowa(String user, String selectedFilm)
        {
            InitializeComponent();
            this.user = user;
            this.selectedFilm = selectedFilm; Cinema.Controller.Sala s = new Cinema.Controller.Sala();
            sala = s.sala(screening_id);
            for (int i = 0; i < sala.Length; i++)
            {
                for (int j = 0; j < sala[i].Length; j++)
                {
                    Button a = new Button();
                    a.Content = (j + 1).ToString();
                    a.HorizontalAlignment = HorizontalAlignment.Left;
                    a.Margin = new Thickness(112 + j * 75, 130 + i * 35, 0, 0);
                    a.VerticalAlignment = VerticalAlignment.Top;
                    a.Width = 40;
                    if (sala[i][j] == 0)
                    {
                        a.Tag = new int[2] { i, j };
                        a.Click += new System.Windows.RoutedEventHandler(this.miejce_click);
                    }
                    else
                    {
                        a.Background = Brushes.Red;
                    }

                    a.Visibility = Visibility.Visible;
                    grid.Children.Add(a);
                }
            }
        }
    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow repertuar = new MainWindow(user);
            repertuar.Show();
            this.Close();
            
        }
        private void miejce_click(object sender, RoutedEventArgs e)
        {
            // if (miejcetylko1 == true) return;//jeśli ma być tylko 1 możliwe
            Button miejce = sender as Button;
            miejce.Background = Brushes.Green;
            sala[(miejce.Tag as int[])[0]][(miejce.Tag as int[])[1]] = 2;
            miejce.Click -= new System.Windows.RoutedEventHandler(this.miejce_click);
            miejce.Click += new System.Windows.RoutedEventHandler(this.miejce_cancel_click);
            //miejcetylko1 = true;//jeśli ma być tylko 1 możliwe
        }
        private void miejce_cancel_click(object sender, RoutedEventArgs e)
        {
            Button miejce = sender as Button;
            miejce.Background = Brushes.Transparent;
            sala[(miejce.Tag as int[])[0]][(miejce.Tag as int[])[1]] = 0;
            miejce.Click -= new System.Windows.RoutedEventHandler(this.miejce_cancel_click);
            miejce.Click += new System.Windows.RoutedEventHandler(this.miejce_click);
            // miejcetylko1 = false;//jeśli ma być tylko 1 możliwe
        }
        private void pokazmiejca()
        {

            for (int i = 0; i < sala.Length; i++)
            {
                for (int j = 0; j < sala[i].Length; j++)
                {
                    if (sala[i][j] == 2)
                    {
                        MessageBox.Show("rząd" + (i + 1).ToString() + "numer" + (j + 1).ToString());
                    }
                }
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //pokazmiejca();
            PotwierdzeniePlatnosci potplatnosc = new PotwierdzeniePlatnosci(user, selectedFilm);
            potplatnosc.Show();
            this.Close();
        }
    }
}
