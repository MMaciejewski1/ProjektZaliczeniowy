﻿using System;
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
        //zmienna wysylana do interfejsu InfoOFilmie 
        private String selectedFilm;
        //kto sie zalogowal
        private String user;
        private int id_film;
        public MainWindow(String user) {
            InitializeComponent();
            this.user = user;
            listView.Items.Add("Proszem wybrac date");
            //List<string> tab = new Cinema.Controller.KalendarzFilmow().getGodziny();
            //for (int i = 0; i < tab.Count; i++) comboBox.Items.Add(tab[i]);
        }  


        private void calendar_SelectedDateChanged(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();
            DateTime? date = calendar.SelectedDate;
            string a = date.ToString();
            string b = a.Substring(0, a.IndexOf('.'));
            string c = a.Substring(a.IndexOf('.') + 1, a.IndexOf('.'));
            string d = a.Substring(a.IndexOf(c) + 3, 4);
            //string a = date.ToString(); moje nie ruszać (Kamil)
            //string b = a.Substring(8, 2);
            //string c = a.Substring(5, 2);
            //string d = a.Substring(0, 4);

            List<string> tab = new List<string>();
            Cinema.Controller.KalendarzFilmow ac = new Cinema.Controller.KalendarzFilmow();
            label1.Content = date.ToString();
            tab = ac.getlistaFilmow(d, c, b);
            for (int i = 0; i < tab.Count; i++) listView.Items.Add(tab[i]);
    
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                String test = listView.SelectedItem.ToString();
                if (!test.Equals("Proszem wybrac date")) {
                    wybranyFilm.Content = test;
                    selectedFilm = test;
                    comboBox.Items.Clear();
                    Cinema.Controller.InfoOFilmie a = new Cinema.Controller.InfoOFilmie();
                    id_film = a.getId(selectedFilm);
                    List<string> tabgodziny = new Cinema.Controller.KalendarzFilmow().getGodziny(id_film);
                    for (int i = 0; i < tabgodziny.Count; i++) comboBox.Items.Add(tabgodziny[i]);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(selectedFilm == null)
            {
                    selectedFilm = "Matrix";
            }
            InfoOFilmie iOF = new InfoOFilmie(selectedFilm);
            iOF.Show();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            if(selectedFilm != null && comboBox.SelectedItem != null)
            {
                string date = comboBox.SelectedItem.ToString();
                Cinema.Controller.KalendarzFilmow ac = new Cinema.Controller.KalendarzFilmow();
                int id_screening = ac.id_screening_wybranego(id_film, date);
                SalaKinowa salakinowa = new SalaKinowa(user, selectedFilm, date, id_screening);
                salakinowa.Show();
                this.Close();
            }
        }
    }
}
