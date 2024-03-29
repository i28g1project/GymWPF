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
using System.Windows.Shapes;

namespace GymWPF
{
    /// <summary>
    /// Logika interakcji dla klasy main_page.xaml
    /// </summary>
    public partial class main_page : Window
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bmi_window bmi_window = new bmi_window();

            this.Close();
            bmi_window.Show();
        }

        private void Protein(object sender, RoutedEventArgs e)
        {
            protein_window protein_window = new protein_window();

            this.Close();
            protein_window.Show();
        }
    }
}
