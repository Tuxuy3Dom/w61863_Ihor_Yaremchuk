using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obliczenie_wagi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    double waga = 0;
                    float wzrost = float.Parse(textBox1.Text);

                    if (chStandard.Checked == true && chIdeal.Checked == true)
                    {
                        MessageBox.Show("Nie możesz zaznaczyć dwie opcje wag jednocześnie!", "Uwaga!", MessageBoxButtons.OK);
                    }
                    else if (chStandard.Checked == true)
                    {
                        if (radMan.Checked == true || radWoman.Checked == true)
                        {
                            waga = (wzrost - 100);
                            lblWynik.Text = "Waga standardowa: " + Convert.ToString(waga);
                        }
                        else
                        {
                            MessageBox.Show("Zaznacz płec!", "Uwaga!", MessageBoxButtons.OK);
                        }
                    }
                    else if (chIdeal.Checked == true)
                    {
                        if (radMan.Checked == true)
                        {
                            waga = (wzrost - 100) * 0.90;
                            lblWynik.Text = "Waga idealna: " + Convert.ToString(waga);
                        }
                        else if (radWoman.Checked == true)
                        {
                            waga = (wzrost - 100) * 0.85;
                            lblWynik.Text = "Waga idealna: " + Convert.ToString(waga);
                        }
                        else
                        {
                            MessageBox.Show("Zaznacz płec!", "Uwaga!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Zaznacz jedną opcję wag!", "Uwaga!", MessageBoxButtons.OK);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Podano błędne dane!", "Uwaga!", MessageBoxButtons.OK);
                }
            }
        }
}
