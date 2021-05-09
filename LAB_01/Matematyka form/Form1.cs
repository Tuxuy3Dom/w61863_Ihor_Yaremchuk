using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematyka_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(liczbaX.Text);
                float y = float.Parse(liczbaY.Text);
                float z = float.Parse(liczbaZ.Text);
                wynik.Text = (x + y + z).ToString();
            } 
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void iloczyn_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(liczbaX.Text);
                float y = float.Parse(liczbaY.Text);
                float z = float.Parse(liczbaZ.Text);
                wynik.Text = (x - y - z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
