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

namespace TextBox
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

        private void Btn_Update_Click(object sender, RoutedEventArgs e)
        {
            var small = Rad_Small.IsChecked;
            var large = Rad_Large.IsChecked;
            var vLarge = Rad_VLarge.IsChecked;

            var bold = Ch_Bold.IsChecked;
            var slope = Ch_Italic.IsChecked;
            var underline = Ch_Underline.IsChecked;

            string textStand = "Standartowa wielkość 12";
            string textSmall = "Wiekość rózwna się 10";
            string textLarge = "Wiekość rózwna się 14";
            string textVLarge = "Wiekość rózwna się 18";

            //Funtions Styles Text
            void StyleBold()
            {
                TextBox.FontWeight = FontWeights.Bold;
            }
            void FontStyleItalic()
            {
                TextBox.FontStyle = FontStyles.Italic;
            }
            void TextDecorationUnderline()
            {
                TextBox.TextDecorations = TextDecorations.Underline;
            }

            // Label - content info style function
            void fontSizeText(string textStyle)
            {
                if (small == true)
                {
                    LBL_Style.Content = textSmall + textStyle;
                }
                else if (large == true)
                {
                    LBL_Style.Content = textLarge + textStyle;
                }
                else if (vLarge == true)
                {
                    LBL_Style.Content = textVLarge + textStyle;
                }
                else
                {
                    LBL_Style.Content = textStand + textStyle;
                }
            }
            // End funtions styles text

            //Clear functions styles text
            void ClearStyle()
            {
                TextBox.FontStyle = new FontStyle();
            }
            void ClearFontWeight()
            {
                TextBox.FontWeight = new FontWeight();
            }
            void ClearDecoration()
            {
                TextBox.TextDecorations = null;
            }
            // End funtions clear styles tex

            // Size logic  
            if (small == true)
            {
                TextBox.FontSize = 10;
                LBL_Style.Content = textSmall;
            }
            else if (large == true)
            {
                TextBox.FontSize = 14;
                LBL_Style.Content = textLarge;
            }
            else if (vLarge == true)
            {
                TextBox.FontSize = 18;
                LBL_Style.Content = textVLarge;
            }
            else
            {
                LBL_Style.Content = textStand + ", styl jest standartowy";
            }
            // End size logic

            // Stylish text logic
            if (slope == true && bold == true && underline == true)
            {
                StyleBold();
                FontStyleItalic();
                TextDecorationUnderline();
                string textStyle = ", styles: Bold, Italic, Underline";
                fontSizeText(textStyle);
            }
            else if (underline == true && slope == true)
            {
                FontStyleItalic();
                TextDecorationUnderline();
                ClearFontWeight();
                string textStyle = ", styles: Italic, Underline";
                fontSizeText(textStyle);
            }
            else if (bold == true && underline == true)
            {
                StyleBold();
                TextDecorationUnderline();
                ClearStyle();
                string textStyle = ", styles: Bold, Underline";
                fontSizeText(textStyle);
            }
            else if (bold == true && slope == true)
            {
                StyleBold();
                FontStyleItalic();
                ClearDecoration();
                string textStyle = ", styles: Bold, Italic";
                fontSizeText(textStyle);
            }
            else if (underline == true)
            {
                TextDecorationUnderline();
                ClearStyle();
                ClearFontWeight();
                string textStyle = ", style underline";
                fontSizeText(textStyle);
            }
            else if (slope == true)
            {
                FontStyleItalic();
                ClearFontWeight();
                ClearDecoration();
                string textStyle = ", style italic";
                fontSizeText(textStyle);
            }
            else if (bold == true)
            {
                StyleBold();
                ClearDecoration();
                ClearStyle();
                string textStyle = ", style bold";
                fontSizeText(textStyle);
            }
            else
            {
                ClearStyle();
                ClearFontWeight();
                ClearDecoration();
            }
            // End stylish text logic
        }
    }
}
