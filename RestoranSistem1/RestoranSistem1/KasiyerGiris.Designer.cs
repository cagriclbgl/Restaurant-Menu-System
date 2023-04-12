namespace RestoranSistem1
{
    partial class KasiyerGiris
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
            this.girisKasa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backPersonel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // girisKasa
            // 
            this.girisKasa.BackgroundImage = global::RestoranSistem1.Properties.Resources.GİRİŞ1;
            this.girisKasa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisKasa.Location = new System.Drawing.Point(228, 331);
            this.girisKasa.Name = "girisKasa";
            this.girisKasa.Size = new System.Drawing.Size(107, 41);
            this.girisKasa.TabIndex = 0;
            this.girisKasa.UseVisualStyleBackColor = true;
            this.girisKasa.Click += new System.EventHandler(this.girisKasa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__9_1;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(122, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__8_;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(122, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 73);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(202, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Kullanıcı Adı";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(202, 284);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(191, 25);
            this.textBox2.TabIndex = 4;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // backPersonel
            // 
            this.backPersonel.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__6_;
            this.backPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backPersonel.Location = new System.Drawing.Point(354, 331);
            this.backPersonel.Name = "backPersonel";
            this.backPersonel.Size = new System.Drawing.Size(66, 41);
            this.backPersonel.TabIndex = 5;
            this.backPersonel.UseVisualStyleBackColor = true;
            this.backPersonel.Click += new System.EventHandler(this.backPersonel_Click);
            // 
            // KasiyerGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoranSistem1.Properties.Resources.KASİYER__1_;
            this.ClientSize = new System.Drawing.Size(500, 411);
            this.Controls.Add(this.backPersonel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisKasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "KasiyerGiris";
            this.Text = "KasiyerGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisKasa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button backPersonel;
    }
}