namespace RestoranSistem1
{
    partial class Rapor
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
            this.raporListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.raporuGoster = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // raporListesi
            // 
            this.raporListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.raporListesi.HideSelection = false;
            this.raporListesi.Location = new System.Drawing.Point(90, 115);
            this.raporListesi.Name = "raporListesi";
            this.raporListesi.Size = new System.Drawing.Size(347, 266);
            this.raporListesi.TabIndex = 0;
            this.raporListesi.UseCompatibleStateImageBehavior = false;
            this.raporListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MasaID";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ÜrünAdı";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Toplam";
            this.columnHeader3.Width = 211;
            // 
            // raporuGoster
            // 
            this.raporuGoster.BackColor = System.Drawing.Color.Red;
            this.raporuGoster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.raporuGoster.Location = new System.Drawing.Point(307, 388);
            this.raporuGoster.Name = "raporuGoster";
            this.raporuGoster.Size = new System.Drawing.Size(114, 56);
            this.raporuGoster.TabIndex = 1;
            this.raporuGoster.Text = "RAPOR";
            this.raporuGoster.UseVisualStyleBackColor = false;
            this.raporuGoster.Click += new System.EventHandler(this.raporuGoster_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__6_2;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(432, 395);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(66, 49);
            this.back.TabIndex = 14;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoranSistem1.Properties.Resources.RAPOR;
            this.ClientSize = new System.Drawing.Size(510, 456);
            this.Controls.Add(this.back);
            this.Controls.Add(this.raporuGoster);
            this.Controls.Add(this.raporListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView raporListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button raporuGoster;
        private System.Windows.Forms.Button back;
    }
}