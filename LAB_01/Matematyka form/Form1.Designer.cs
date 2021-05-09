
namespace Matematyka_form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.liczbaX = new System.Windows.Forms.TextBox();
            this.liczbaY = new System.Windows.Forms.TextBox();
            this.liczbaZ = new System.Windows.Forms.TextBox();
            this.wynik = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.Button();
            this.iloczyn = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wynik:";
            // 
            // liczbaX
            // 
            this.liczbaX.Location = new System.Drawing.Point(131, 21);
            this.liczbaX.Name = "liczbaX";
            this.liczbaX.Size = new System.Drawing.Size(100, 23);
            this.liczbaX.TabIndex = 4;
            // 
            // liczbaY
            // 
            this.liczbaY.Location = new System.Drawing.Point(131, 62);
            this.liczbaY.Name = "liczbaY";
            this.liczbaY.Size = new System.Drawing.Size(100, 23);
            this.liczbaY.TabIndex = 5;
            // 
            // liczbaZ
            // 
            this.liczbaZ.Location = new System.Drawing.Point(131, 103);
            this.liczbaZ.Name = "liczbaZ";
            this.liczbaZ.Size = new System.Drawing.Size(100, 23);
            this.liczbaZ.TabIndex = 6;
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(131, 146);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(100, 23);
            this.wynik.TabIndex = 7;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(288, 42);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 23);
            this.suma.TabIndex = 8;
            this.suma.Text = "Suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // iloczyn
            // 
            this.iloczyn.Location = new System.Drawing.Point(288, 85);
            this.iloczyn.Name = "iloczyn";
            this.iloczyn.Size = new System.Drawing.Size(75, 23);
            this.iloczyn.TabIndex = 9;
            this.iloczyn.Text = "Iloczyn";
            this.iloczyn.UseVisualStyleBackColor = true;
            this.iloczyn.Click += new System.EventHandler(this.iloczyn_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(288, 129);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(75, 23);
            this.end.TabIndex = 10;
            this.end.Text = "Wyjście";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 221);
            this.Controls.Add(this.end);
            this.Controls.Add(this.iloczyn);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.liczbaZ);
            this.Controls.Add(this.liczbaY);
            this.Controls.Add(this.liczbaX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Matematyka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox liczbaX;
        private System.Windows.Forms.TextBox liczbaY;
        private System.Windows.Forms.TextBox liczbaZ;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button iloczyn;
        private System.Windows.Forms.Button end;
    }
}

