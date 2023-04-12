namespace RestoranSistem1
{
    partial class GercekGarson
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
            this.siparisler = new System.Windows.Forms.Button();
            this.MutfakSiparis = new System.Windows.Forms.Button();
            this.backTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // siparisler
            // 
            this.siparisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siparisler.Image = global::RestoranSistem1.Properties.Resources.SİPARİŞLER;
            this.siparisler.Location = new System.Drawing.Point(58, 183);
            this.siparisler.Name = "siparisler";
            this.siparisler.Size = new System.Drawing.Size(149, 107);
            this.siparisler.TabIndex = 0;
            this.siparisler.UseVisualStyleBackColor = true;
            this.siparisler.Click += new System.EventHandler(this.siparisler_Click);
            // 
            // MutfakSiparis
            // 
            this.MutfakSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MutfakSiparis.Image = global::RestoranSistem1.Properties.Resources.SİPARİŞLER__1_;
            this.MutfakSiparis.Location = new System.Drawing.Point(279, 183);
            this.MutfakSiparis.Name = "MutfakSiparis";
            this.MutfakSiparis.Size = new System.Drawing.Size(149, 107);
            this.MutfakSiparis.TabIndex = 1;
            this.MutfakSiparis.UseVisualStyleBackColor = true;
            this.MutfakSiparis.Click += new System.EventHandler(this.MutfakSiparis_Click);
            // 
            // backTo
            // 
            this.backTo.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__6_;
            this.backTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backTo.Location = new System.Drawing.Point(403, 338);
            this.backTo.Name = "backTo";
            this.backTo.Size = new System.Drawing.Size(66, 49);
            this.backTo.TabIndex = 4;
            this.backTo.UseVisualStyleBackColor = true;
            this.backTo.Click += new System.EventHandler(this.backTo_Click);
            // 
            // GercekGarson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoranSistem1.Properties.Resources.GARSON__5_;
            this.ClientSize = new System.Drawing.Size(500, 411);
            this.Controls.Add(this.backTo);
            this.Controls.Add(this.MutfakSiparis);
            this.Controls.Add(this.siparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GercekGarson";
            this.Text = "GercekGarson";
            this.Load += new System.EventHandler(this.GercekGarson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button siparisler;
        private System.Windows.Forms.Button MutfakSiparis;
        private System.Windows.Forms.Button backTo;
    }
}