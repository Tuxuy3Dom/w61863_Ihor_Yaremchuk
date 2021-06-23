using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Add_student
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public Student student;
        public StudentWindow(Student student = null)
        {
            InitializeComponent();
            if (student != null)
            {
                tbImie.Text = student.imie;
                tbNazwisko.Text = student.nazwisko;
                tbNrIndeksu.Text = student.NrIndeksu.ToString();
                tbWydzial.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(tbImie.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(tbNazwisko.Text, @"^\p{Lu}\p{Ll}{1,24}$") ||
                !Regex.IsMatch(tbWydzial.Text, @"^\b[A-Z]{1,12}\b$") ||
                !Regex.IsMatch(tbNrIndeksu.Text, @"^\p{Nd}{1,5}$"))
            {
                MessageBox.Show("Podano nie poprawne dane!", "Uwaga", MessageBoxButton.OK);
                return;
            }

            student.imie = tbImie.Text;
            student.nazwisko = tbNazwisko.Text;
            student.NrIndeksu = int.Parse(tbNrIndeksu.Text);
            student.wydzial = tbWydzial.Text;

            this.DialogResult = true;
        }
    }
}
