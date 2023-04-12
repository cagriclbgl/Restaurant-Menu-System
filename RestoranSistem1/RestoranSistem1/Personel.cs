using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestoranSistem1
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=FENERBAHCE-1907;Initial Catalog=adisyon;Integrated Security=True");

        private void Garson_Click(object sender, EventArgs e)
        {
            Garson gGiris = new Garson();
            this.Hide();
            gGiris.Show();
            
        }

        private void Kasiyer_Click(object sender, EventArgs e)
        {
            KasiyerGiris kasiyer = new KasiyerGiris();
            this.Hide();
            kasiyer.Show();
        }

        private void Asci_Click(object sender, EventArgs e)
        {
            Asci asci = new Asci();
            this.Hide();
            asci.Show();
        }

        private void backTo_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
