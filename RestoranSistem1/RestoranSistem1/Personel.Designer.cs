namespace RestoranSistem1
{
    partial class Personel
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
            this.Garson = new System.Windows.Forms.Button();
            this.Kasiyer = new System.Windows.Forms.Button();
            this.Asci = new System.Windows.Forms.Button();
            this.backTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Garson
            // 
            this.Garson.BackgroundImage = global::RestoranSistem1.Properties.Resources.GARSON__4_;
            this.Garson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Garson.Location = new System.Drawing.Point(26, 184);
            this.Garson.Name = "Garson";
            this.Garson.Size = new System.Drawing.Size(134, 113);
            this.Garson.TabIndex = 0;
            this.Garson.UseVisualStyleBackColor = true;
            this.Garson.Click += new System.EventHandler(this.Garson_Click);
            // 
            // Kasiyer
            // 
            this.Kasiyer.BackgroundImage = global::RestoranSistem1.Properties.Resources.GARSON__1_;
            this.Kasiyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kasiyer.Location = new System.Drawing.Point(191, 184);
            this.Kasiyer.Name = "Kasiyer";
            this.Kasiyer.Size = new System.Drawing.Size(134, 113);
            this.Kasiyer.TabIndex = 1;
            this.Kasiyer.UseVisualStyleBackColor = true;
            this.Kasiyer.Click += new System.EventHandler(this.Kasiyer_Click);
            // 
            // Asci
            // 
            this.Asci.BackgroundImage = global::RestoranSistem1.Properties.Resources.GARSON__2_;
            this.Asci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Asci.Location = new System.Drawing.Point(356, 184);
            this.Asci.Name = "Asci";
            this.Asci.Size = new System.Drawing.Size(134, 113);
            this.Asci.TabIndex = 2;
            this.Asci.UseVisualStyleBackColor = true;
            this.Asci.Click += new System.EventHandler(this.Asci_Click);
            // 
            // backTo
            // 
            this.backTo.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__6_;
            this.backTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backTo.Location = new System.Drawing.Point(410, 373);
            this.backTo.Name = "backTo";
            this.backTo.Size = new System.Drawing.Size(66, 49);
            this.backTo.TabIndex = 3;
            this.backTo.UseVisualStyleBackColor = true;
            this.backTo.Click += new System.EventHandler(this.backTo_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoranSistem1.Properties.Resources.PERSONEL;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.backTo);
            this.Controls.Add(this.Asci);
            this.Controls.Add(this.Kasiyer);
            this.Controls.Add(this.Garson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personel";
            this.Text = "Personel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Garson;
        private System.Windows.Forms.Button Kasiyer;
        private System.Windows.Forms.Button Asci;
        private System.Windows.Forms.Button backTo;
    }
}