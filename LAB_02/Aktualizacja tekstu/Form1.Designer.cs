
namespace Aktualizacja_tekstu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVeryLarge = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chUnderline = new System.Windows.Forms.CheckBox();
            this.chSlope = new System.Windows.Forms.CheckBox();
            this.chBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radOrange = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.btnAktual = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tekst";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 23);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radVeryLarge);
            this.groupBox1.Controls.Add(this.radLarge);
            this.groupBox1.Controls.Add(this.radSmall);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            // 
            // radVeryLarge
            // 
            this.radVeryLarge.AutoSize = true;
            this.radVeryLarge.Location = new System.Drawing.Point(7, 75);
            this.radVeryLarge.Name = "radVeryLarge";
            this.radVeryLarge.Size = new System.Drawing.Size(89, 19);
            this.radVeryLarge.TabIndex = 2;
            this.radVeryLarge.TabStop = true;
            this.radVeryLarge.Text = "Bardzo duża";
            this.radVeryLarge.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(7, 49);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(51, 19);
            this.radLarge.TabIndex = 1;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Duża";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(7, 23);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(51, 19);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Mała";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chUnderline);
            this.groupBox2.Controls.Add(this.chSlope);
            this.groupBox2.Controls.Add(this.chBold);
            this.groupBox2.Location = new System.Drawing.Point(143, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl czcionki";
            // 
            // chUnderline
            // 
            this.chUnderline.AutoSize = true;
            this.chUnderline.Location = new System.Drawing.Point(7, 75);
            this.chUnderline.Name = "chUnderline";
            this.chUnderline.Size = new System.Drawing.Size(93, 19);
            this.chUnderline.TabIndex = 2;
            this.chUnderline.Text = "Podkreślenie";
            this.chUnderline.UseVisualStyleBackColor = true;
            // 
            // chSlope
            // 
            this.chSlope.AutoSize = true;
            this.chSlope.Location = new System.Drawing.Point(7, 49);
            this.chSlope.Name = "chSlope";
            this.chSlope.Size = new System.Drawing.Size(84, 19);
            this.chSlope.TabIndex = 1;
            this.chSlope.Text = "Pochylenie";
            this.chSlope.UseVisualStyleBackColor = true;
            // 
            // chBold
            // 
            this.chBold.AutoSize = true;
            this.chBold.Location = new System.Drawing.Point(7, 23);
            this.chBold.Name = "chBold";
            this.chBold.Size = new System.Drawing.Size(90, 19);
            this.chBold.TabIndex = 0;
            this.chBold.Text = "Pogrubienie";
            this.chBold.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radOrange);
            this.groupBox3.Controls.Add(this.radBlue);
            this.groupBox3.Controls.Add(this.radRed);
            this.groupBox3.Location = new System.Drawing.Point(314, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 108);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor czcionki";
            // 
            // radOrange
            // 
            this.radOrange.AutoSize = true;
            this.radOrange.Location = new System.Drawing.Point(7, 75);
            this.radOrange.Name = "radOrange";
            this.radOrange.Size = new System.Drawing.Size(106, 19);
            this.radOrange.TabIndex = 2;
            this.radOrange.TabStop = true;
            this.radOrange.Text = "Pomarańczowy";
            this.radOrange.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(7, 50);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(73, 19);
            this.radBlue.TabIndex = 1;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Niebieski";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(7, 25);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(77, 19);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Czerwony";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // btnAktual
            // 
            this.btnAktual.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAktual.Location = new System.Drawing.Point(178, 218);
            this.btnAktual.Name = "btnAktual";
            this.btnAktual.Size = new System.Drawing.Size(150, 55);
            this.btnAktual.TabIndex = 5;
            this.btnAktual.Text = "Aktualizuj";
            this.btnAktual.UseVisualStyleBackColor = true;
            this.btnAktual.Click += new System.EventHandler(this.btnAktual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 295);
            this.Controls.Add(this.btnAktual);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radVeryLarge;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chUnderline;
        private System.Windows.Forms.CheckBox chSlope;
        private System.Windows.Forms.CheckBox chBold;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radOrange;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Button btnAktual;
    }
}

