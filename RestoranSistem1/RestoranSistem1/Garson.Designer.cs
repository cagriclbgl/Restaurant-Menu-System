namespace RestoranSistem1
{
    partial class Garson
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
            this.userBox = new System.Windows.Forms.PictureBox();
            this.passBox = new System.Windows.Forms.PictureBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.girisButonu = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__9_;
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userBox.Location = new System.Drawing.Point(122, 179);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(73, 73);
            this.userBox.TabIndex = 0;
            this.userBox.TabStop = false;
            this.userBox.Click += new System.EventHandler(this.userBox_Click);
            // 
            // passBox
            // 
            this.passBox.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__8_;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passBox.Location = new System.Drawing.Point(122, 258);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(73, 73);
            this.passBox.TabIndex = 1;
            this.passBox.TabStop = false;
            this.passBox.Click += new System.EventHandler(this.passBox_Click);
            // 
            // userNameBox
            // 
            this.userNameBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameBox.Location = new System.Drawing.Point(201, 206);
            this.userNameBox.Multiline = true;
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(191, 25);
            this.userNameBox.TabIndex = 2;
            this.userNameBox.Text = "Kullanıcı Adı";
            this.userNameBox.Click += new System.EventHandler(this.userNameBox_Click);
            this.userNameBox.TextChanged += new System.EventHandler(this.userNameBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordBox.Location = new System.Drawing.Point(201, 283);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(191, 25);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Click += new System.EventHandler(this.passwordBox_Click);
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // girisButonu
            // 
            this.girisButonu.BackgroundImage = global::RestoranSistem1.Properties.Resources.GİRİŞ;
            this.girisButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisButonu.Location = new System.Drawing.Point(228, 331);
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.Size = new System.Drawing.Size(107, 41);
            this.girisButonu.TabIndex = 4;
            this.girisButonu.UseVisualStyleBackColor = true;
            this.girisButonu.Click += new System.EventHandler(this.girisButonu_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__6_1;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(354, 331);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(66, 41);
            this.back.TabIndex = 5;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Garson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoranSistem1.Properties.Resources.RAPOR__2_;
            this.ClientSize = new System.Drawing.Size(500, 411);
            this.Controls.Add(this.back);
            this.Controls.Add(this.girisButonu);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Garson";
            this.Text = "Garson";
            this.Load += new System.EventHandler(this.Garson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userBox;
        private System.Windows.Forms.PictureBox passBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button girisButonu;
        private System.Windows.Forms.Button back;
    }
}