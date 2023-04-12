namespace RestoranSistem1
{
    partial class Asci
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
            this.SiparisListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.backTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SiparisListesi
            // 
            this.SiparisListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SiparisListesi.HideSelection = false;
            this.SiparisListesi.Location = new System.Drawing.Point(69, 167);
            this.SiparisListesi.Name = "SiparisListesi";
            this.SiparisListesi.Size = new System.Drawing.Size(251, 434);
            this.SiparisListesi.TabIndex = 0;
            this.SiparisListesi.UseCompatibleStateImageBehavior = false;
            this.SiparisListesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MasaID";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ÜrünAdı";
            this.columnHeader2.Width = 140;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(362, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siparişleri Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backTo
            // 
            this.backTo.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__6_;
            this.backTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backTo.Location = new System.Drawing.Point(644, 585);
            this.backTo.Name = "backTo";
            this.backTo.Size = new System.Drawing.Size(66, 49);
            this.backTo.TabIndex = 4;
            this.backTo.UseVisualStyleBackColor = true;
            this.backTo.Click += new System.EventHandler(this.backTo_Click);
            // 
            // Asci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RestoranSistem1.Properties.Resources.aşçı;
            this.ClientSize = new System.Drawing.Size(737, 646);
            this.Controls.Add(this.backTo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SiparisListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asci";
            this.Text = "Asci";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView SiparisListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backTo;
    }
}