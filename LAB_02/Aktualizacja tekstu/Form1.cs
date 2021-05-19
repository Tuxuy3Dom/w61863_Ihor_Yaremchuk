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

            if (small == true)
            {
                textBox1.Font = new System.Drawing.Font("Arial", 8, FontStyle.Regular);

                if (bold == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 8, FontStyle.Bold);
                }
                if (slope == true)
                { 
                    textBox1.Font = new System.Drawing.Font("Arial", 8, FontStyle.Italic);
                }
                if (underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 8, FontStyle.Underline);
                }
                if (bold == true && slope == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 8, FontStyle.Bold | FontStyle.Italic);
                }
                if (bold == true && underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 8, FontStyle.Bold | FontStyle.Underline);
                }
                if (underline == true && slope == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 8, FontStyle.Italic | FontStyle.Underline);
                }
                if (slope == true && bold == true && underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 8, FontStyle.Italic | FontStyle.Underline | FontStyle.Bold);
                }
            }
            else if (large == true)
            {
                textBox1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Regular);

                if (bold == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                }
                if (slope == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic);
                }
                if (underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Underline);
                }
                if (bold == true && slope == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
                }
                if (bold == true && underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold | FontStyle.Underline);
                }
                if (underline == true && slope == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic | FontStyle.Underline);
                }
                if (slope == true && bold == true && underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 10, FontStyle.Italic | FontStyle.Underline | FontStyle.Bold);
                }
            }
            else if (vLarge == true)
            {
                textBox1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular);

                if (bold == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                }
                if (slope == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Italic);
                }
                if (underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Underline);
                }
                if (bold == true && slope == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
                }
                if (bold == true && underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold | FontStyle.Underline);
                }
                if (underline == true && slope == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Italic | FontStyle.Underline);
                }
                if (slope == true && bold == true && underline == true)
                {
                    textBox1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Italic | FontStyle.Underline | FontStyle.Bold);
                }
            }

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
