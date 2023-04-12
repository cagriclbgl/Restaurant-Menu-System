using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranSistem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Personel_Click(object sender, EventArgs e)
        {
            Personel personel1 = new Personel();
            this.Hide();
            personel1.Show();
            
        }

        private void Mutfak_Click(object sender, EventArgs e)
        {
            Asci asci = new Asci();
            this.Hide();
            asci.Show();
        }

        private void Rapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            this.Hide();
            rapor.Show();
        }
    }
}
