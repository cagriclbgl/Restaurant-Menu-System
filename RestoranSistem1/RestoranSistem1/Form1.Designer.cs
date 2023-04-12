namespace RestoranSistem1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Personel = new System.Windows.Forms.Button();
            this.Mutfak = new System.Windows.Forms.Button();
            this.Rapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Personel
            // 
            this.Personel.BackgroundImage = global::RestoranSistem1.Properties.Resources.MASA__2_;
            this.Personel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Personel.Location = new System.Drawing.Point(21, 227);
            this.Personel.Name = "Personel";
            this.Personel.Size = new System.Drawing.Size(236, 189);
            this.Personel.TabIndex = 0;
            this.Personel.UseVisualStyleBackColor = true;
            this.Personel.Click += new System.EventHandler(this.Personel_Click);
            // 
            // Mutfak
            // 
            this.Mutfak.BackgroundImage = global::RestoranSistem1.Properties.Resources.MUTFAK;
            this.Mutfak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mutfak.Location = new System.Drawing.Point(392, 227);
            this.Mutfak.Name = "Mutfak";
            this.Mutfak.Size = new System.Drawing.Size(236, 189);
            this.Mutfak.TabIndex = 1;
            this.Mutfak.UseVisualStyleBackColor = true;
            this.Mutfak.Click += new System.EventHandler(this.Mutfak_Click);
            // 
            // Rapor
            // 
            this.Rapor.BackgroundImage = global::RestoranSistem1.Properties.Resources.REZERVASYON__1_;
            this.Rapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rapor.Location = new System.Drawing.Point(214, 440);
            this.Rapor.Name = "Rapor";
            this.Rapor.Size = new System.Drawing.Size(236, 189);
            this.Rapor.TabIndex = 2;
            this.Rapor.UseVisualStyleBackColor = true;
            this.Rapor.Click += new System.EventHandler(this.Rapor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoranSistem1.Properties.Resources.MENU__1_;
            this.ClientSize = new System.Drawing.Size(664, 641);
            this.Controls.Add(this.Rapor);
            this.Controls.Add(this.Mutfak);
            this.Controls.Add(this.Personel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Personel;
        private System.Windows.Forms.Button Mutfak;
        private System.Windows.Forms.Button Rapor;
    }
}

