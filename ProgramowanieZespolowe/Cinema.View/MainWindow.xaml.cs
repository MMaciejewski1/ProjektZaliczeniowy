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
        public MainWindow() {
            InitializeComponent();
              List<string> tab = new List<string>();
            Cinema.Controller.InfoOFilmie a = new Cinema.Controller.InfoOFilmie();
            tab = a.listaFilmow();
             for (int i = 0; i < tab.Count; i++) listView.Items.Add(tab[i]);

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
