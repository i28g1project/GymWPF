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
using System.Text.RegularExpressions;

namespace GymWPF
{
    /// <summary>
    /// Logika interakcji dla klasy bmi_window.xaml
    /// </summary>
    public partial class bmi_window : Window
    {
        private int h;
        private int w;
        private double bmi;
        public bmi_window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            main_page main_page = new main_page();

            this.Close();
            main_page.Show();
        }
        private void Calculate_BMI(object sender, RoutedEventArgs e)
        {
            if (height.Text != "" && height.Text != "")
            {
                h = int.Parse(height.Text);
                w = int.Parse(weight.Text);
                Console.WriteLine(h.ToString(), w.ToString());
                bmi = (w / ((h / 100) * (h / 100)));
                BMI.Content = "Your BMI: " + bmi.ToString();
            }
             
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
