using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aktualizacja_tekstu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktual_Click(object sender, EventArgs e)
        {
            // Wielkość
            var small = radSmall.Checked;
            var large = radLarge.Checked;
            var vLarge = radVeryLarge.Checked;
            // Styl czcionki
            var bold = chBold.Checked;
            var slope = chSlope.Checked;
            var underline = chUnderline.Checked;
            // Kolora
            var red = radRed.Checked;
            var blue = radBlue.Checked;
            var orange = radOrange.Checked;

            //Wielkość
            if (small == true)
            {
                textBox1.Font = new Font("Arial", 10, FontStyle.Regular);
            }
            else if (large == true)
            {
                textBox1.Font = new Font("Arial", 15, FontStyle.Regular);
            }
            else if (vLarge == true)
            {
                textBox1.Font = new Font("Arial", 20, FontStyle.Regular);
            }

            //Styl czcionki
            if (slope == true && bold == true && underline == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline | FontStyle.Bold);
            }
            else if (underline == true && slope == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Underline);
            }
            else if (bold == true && underline == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
            }
            else if (bold == true && slope == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }
            else if (underline == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
            else if (slope == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            else if (bold == true)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }

            // Kolora
            if (red == true)
            {
                textBox1.ForeColor = Color.Red;
            }
            else if (blue == true)
            {
                textBox1.ForeColor = Color.Blue;
            }
            else if (orange == true)
            {
                textBox1.ForeColor = Color.Orange;
            }
        }
    }
}
