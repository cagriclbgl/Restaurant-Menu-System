namespace RestoranSistem1
{
    partial class mainMenu
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siparisiTamamla = new System.Windows.Forms.Button();
            this.İcecek = new System.Windows.Forms.Button();
            this.Tatlılar = new System.Windows.Forms.Button();
            this.Atıştırmalık = new System.Windows.Forms.Button();
            this.AnaYemek = new System.Windows.Forms.Button();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxMenu.Controls.Add(this.back);
            this.groupBoxMenu.Controls.Add(this.button1);
            this.groupBoxMenu.Controls.Add(this.listView2);
            this.groupBoxMenu.Controls.Add(this.siparisiTamamla);
            this.groupBoxMenu.Controls.Add(this.İcecek);
            this.groupBoxMenu.Controls.Add(this.Tatlılar);
            this.groupBoxMenu.Controls.Add(this.Atıştırmalık);
            this.groupBoxMenu.Controls.Add(this.AnaYemek);
            this.groupBoxMenu.Location = new System.Drawing.Point(0, -2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(751, 479);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "MENU";
            this.groupBoxMenu.Enter += new System.EventHandler(this.groupBoxMenu_Enter);
            // 
            // back
            // 
            this.back.BackgroundImage = global::RestoranSistem1.Properties.Resources.Untitled_design__6_2;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(672, 421);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(66, 49);
            this.back.TabIndex = 13;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Adisyon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView2.Location = new System.Drawing.Point(459, 99);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(267, 295);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MasaID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Urunler";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Toplam";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fiyat";
            // 
            // siparisiTamamla
            // 
            this.siparisiTamamla.Location = new System.Drawing.Point(478, 418);
            this.siparisiTamamla.Name = "siparisiTamamla";
            this.siparisiTamamla.Size = new System.Drawing.Size(68, 55);
            this.siparisiTamamla.TabIndex = 8;
            this.siparisiTamamla.Text = "SiparişiBitir";
            this.siparisiTamamla.UseVisualStyleBackColor = true;
            this.siparisiTamamla.Click += new System.EventHandler(this.siparisiTamamla_Click);
            // 
            // İcecek
            // 
            this.İcecek.BackgroundImage = global::RestoranSistem1.Properties.Resources.ANA_YEMEK__6_;
            this.İcecek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.İcecek.Location = new System.Drawing.Point(0, 238);
            this.İcecek.Name = "İcecek";
            this.İcecek.Size = new System.Drawing.Size(167, 110);
            this.İcecek.TabIndex = 5;
            this.İcecek.UseVisualStyleBackColor = true;
            this.İcecek.Click += new System.EventHandler(this.İcecek_Click);
            // 
            // Tatlılar
            // 
            this.Tatlılar.BackgroundImage = global::RestoranSistem1.Properties.Resources.ANA_YEMEK__5_;
            this.Tatlılar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tatlılar.Location = new System.Drawing.Point(218, 238);
            this.Tatlılar.Name = "Tatlılar";
            this.Tatlılar.Size = new System.Drawing.Size(167, 110);
            this.Tatlılar.TabIndex = 4;
            this.Tatlılar.UseVisualStyleBackColor = true;
            this.Tatlılar.Click += new System.EventHandler(this.Tatlılar_Click);
            // 
            // Atıştırmalık
            // 
            this.Atıştırmalık.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Atıştırmalık.Image = global::RestoranSistem1.Properties.Resources.ANA_YEMEK__7_;
            this.Atıştırmalık.Location = new System.Drawing.Point(218, 72);
            this.Atıştırmalık.Name = "Atıştırmalık";
            this.Atıştırmalık.Size = new System.Drawing.Size(167, 110);
            this.Atıştırmalık.TabIndex = 2;
            this.Atıştırmalık.UseVisualStyleBackColor = true;
            this.Atıştırmalık.Click += new System.EventHandler(this.Atıştırmalık_Click);
            // 
            // AnaYemek
            // 
            this.AnaYemek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnaYemek.Image = global::RestoranSistem1.Properties.Resources.ANA_YEMEK__2_;
            this.AnaYemek.Location = new System.Drawing.Point(6, 72);
            this.AnaYemek.Name = "AnaYemek";
            this.AnaYemek.Size = new System.Drawing.Size(167, 110);
            this.AnaYemek.TabIndex = 1;
            this.AnaYemek.UseVisualStyleBackColor = true;
            this.AnaYemek.Click += new System.EventHandler(this.AnaYemek_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 474);
            this.Controls.Add(this.groupBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button İcecek;
        private System.Windows.Forms.Button Tatlılar;
        private System.Windows.Forms.Button Atıştırmalık;
        private System.Windows.Forms.Button AnaYemek;
        private System.Windows.Forms.Button siparisiTamamla;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button back;
    }
}