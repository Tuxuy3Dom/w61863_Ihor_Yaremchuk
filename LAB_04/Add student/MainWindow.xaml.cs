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
using System.Text.RegularExpressions;

namespace Add_student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }
        public List<OceneStudent> Grades { get; set; }
        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student(){imie = "Jan", nazwisko = "Kowalski", NrIndeksu = 1234, wydzial = "KIS"},
                new Student(){imie = "Anna", nazwisko = "Nowak", NrIndeksu = 4321, wydzial = "KIS"},
                new Student(){imie = "Ihor", nazwisko = "Yaremchuk", NrIndeksu = 81863, wydzial = "IoT"},
            };

            InitializeComponent();

            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Imie", Binding = new Binding("imie") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nr Indeksu", Binding = new Binding("NrIndeksu") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Wydział", Binding = new Binding("wydzial") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Ocena", Binding = new Binding("ocena") });

            dgStudent.AutoGenerateColumns = false;
            dgStudent.ItemsSource = ListaStudentow;
        }

        private void bAddStudent_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() == true)
            {
                ListaStudentow.Add(dialog.student);
                dgStudent.Items.Refresh();
            }
        }
       
        private void bRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student)
            {
                ListaStudentow.Remove((Student)dgStudent.SelectedItem);
            }
            dgStudent.Items.Refresh();
        }

        private void bEditStudent_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow(); 
            if (dgStudent.SelectedItem is Student)
            {
                
            }
            dgStudent.Items.Refresh();
        }

        private void bAddSchoolGrades_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void bSchoolGrades_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
