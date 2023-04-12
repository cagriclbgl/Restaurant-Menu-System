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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=FENERBAHCE-1907;Initial Catalog=adisyon;Integrated Security=True");

        private void Rapor_Load(object sender, EventArgs e)
        {

        }

        private void raporuGoster_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem add = new ListViewItem(oku["MasaID"].ToString());
                add.SubItems.Add(oku["ÜrünAdı"].ToString());
                add.SubItems.Add(oku["Toplam"].ToString());


                raporListesi.Items.Add(add);

            }

            baglan.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }
    }
}
