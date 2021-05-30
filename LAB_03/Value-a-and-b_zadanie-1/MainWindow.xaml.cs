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

namespace Value_a_and_b_zadanie_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        float a;
        float b;
        float wynik;
        private void BT_Odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = float.Parse(TXT_A.Text);
                b = float.Parse(TXT_B.Text);

                wynik = a - b;
                LBL_Wynik.Content = "Różnica " + a + " - " + b + " = " + wynik.ToString();
            } catch (Exception)
            {
                MessageBox.Show("Podano błędne dane!", "Error", MessageBoxButton.OK);
            }
        }

        private void BT_Dodawanie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = float.Parse(TXT_A.Text);
                b = float.Parse(TXT_B.Text);
                wynik = a + b;
                LBL_Wynik.Content = "Suma " + a + " + " + b + " = " + wynik.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane!", "Error", MessageBoxButton.OK);
            }
        }

        private void BT_Mnozenie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = float.Parse(TXT_A.Text);
                b = float.Parse(TXT_B.Text);
                wynik = a * b;
                LBL_Wynik.Content = "IIoczyn " + a + " * " + b + " = " + wynik.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane!", "Error", MessageBoxButton.OK);
            }
        }

        private void BT_Dzielenie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = float.Parse(TXT_A.Text);
                b = float.Parse(TXT_B.Text);

                if (b != 0)
                {
                    wynik = a / b;
                    LBL_Wynik.Content = "IIoraz " + a + " / " + b + " = " + wynik.ToString();
                }
                else
                {
                    MessageBox.Show("Nie można dzielić przez 0!", "Error", MessageBoxButton.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane!", "Error", MessageBoxButton.OK);
            }
        }
    }
}
