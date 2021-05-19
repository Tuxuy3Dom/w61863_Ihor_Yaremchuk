
namespace Obliczenie_wagi
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblWynik = new System.Windows.Forms.Label();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radWoman = new System.Windows.Forms.RadioButton();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chStandard = new System.Windows.Forms.CheckBox();
            this.chIdeal = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj wzrost [cm]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj płec";
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWynik.Location = new System.Drawing.Point(12, 191);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(45, 17);
            this.lblWynik.TabIndex = 2;
            this.lblWynik.Text = "Wynik";
            // 
            // btnOblicz
            // 
            this.btnOblicz.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOblicz.Location = new System.Drawing.Point(237, 142);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(91, 37);
            this.btnOblicz.TabIndex = 3;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 23);
            this.textBox1.TabIndex = 4;
            // 
            // radWoman
            // 
            this.radWoman.AutoSize = true;
            this.radWoman.Location = new System.Drawing.Point(141, 80);
            this.radWoman.Name = "radWoman";
            this.radWoman.Size = new System.Drawing.Size(65, 19);
            this.radWoman.TabIndex = 5;
            this.radWoman.TabStop = true;
            this.radWoman.Text = "Kobieta";
            this.radWoman.UseVisualStyleBackColor = true;
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(214, 80);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(82, 19);
            this.radMan.TabIndex = 6;
            this.radMan.TabStop = true;
            this.radMan.Text = "Mężczyzna";
            this.radMan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chIdeal);
            this.groupBox1.Controls.Add(this.chStandard);
            this.groupBox1.Location = new System.Drawing.Point(355, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waga";
            // 
            // chStandard
            // 
            this.chStandard.AutoSize = true;
            this.chStandard.Location = new System.Drawing.Point(7, 23);
            this.chStandard.Name = "chStandard";
            this.chStandard.Size = new System.Drawing.Size(95, 19);
            this.chStandard.TabIndex = 0;
            this.chStandard.Text = "Standardowa";
            this.chStandard.UseVisualStyleBackColor = true;
            // 
            // chIdeal
            // 
            this.chIdeal.AutoSize = true;
            this.chIdeal.Location = new System.Drawing.Point(7, 59);
            this.chIdeal.Name = "chIdeal";
            this.chIdeal.Size = new System.Drawing.Size(64, 19);
            this.chIdeal.TabIndex = 1;
            this.chIdeal.Text = "Idealna";
            this.chIdeal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radMan);
            this.Controls.Add(this.radWoman);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radWoman;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chIdeal;
        private System.Windows.Forms.CheckBox chStandard;
    }
}

