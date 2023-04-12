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
    public partial class kasa : Form
    {
        public kasa()
        {
            InitializeComponent();
        }
        public string text;
        SqlConnection baglan = new SqlConnection("Data Source=FENERBAHCE-1907;Initial Catalog=adisyon;Integrated Security=True");
        private void masa1_Click(object sender, EventArgs e)
        {
            

            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu where MasaID='"+ text +"' " , baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (text == "1")
            {
                while (oku.Read())
                {
                    ListViewItem add = new ListViewItem(oku["ÜrünAdı"].ToString());
                    add.SubItems.Add(oku["Fiyat"].ToString());
                    add.SubItems.Add(oku["Toplam"].ToString());
                    add.SubItems.Add(oku["MasaID"].ToString());


                    kasaOdeme.Items.Add(add);

                }
                baglan.Close();
            }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            
                string query1 = "İnsert into adisyontablosu (MasaID,ÜrünAdı,Fiyat,Toplam) values(@text1,@text2,@text3,@text4)";
                SqlCommand ekle = new SqlCommand(query1, baglan);
                ekle.Parameters.AddWithValue("@text1", SiparisMasalar.texts);
                ekle.Parameters.AddWithValue("@text2", "kebap");
                ekle.Parameters.AddWithValue("@text3", "80");
                ekle.Parameters.AddWithValue("@text4", "80");
            
            kasaOdeme.Items.Clear();
            baglan.Close();

        }

        private void masa2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu where MasaID='" + text + "' ", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (text == "2")
            {
                while (oku.Read())
                {
                    ListViewItem add = new ListViewItem(oku["ÜrünAdı"].ToString());
                    add.SubItems.Add(oku["Fiyat"].ToString());
                    add.SubItems.Add(oku["Toplam"].ToString());
                    add.SubItems.Add(oku["MasaID"].ToString());


                    kasaOdeme.Items.Add(add);

                }
                baglan.Close();
            }
        }

        private void masa3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu where MasaID='" + text + "' ", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (text == "3")
            {
                while (oku.Read())
                {
                    ListViewItem add = new ListViewItem(oku["ÜrünAdı"].ToString());
                    add.SubItems.Add(oku["Fiyat"].ToString());
                    add.SubItems.Add(oku["Toplam"].ToString());
                    add.SubItems.Add(oku["MasaID"].ToString());


                    kasaOdeme.Items.Add(add);

                }
                baglan.Close();
            }
        }

        private void masa4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu where MasaID='" + text + "' ", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (text == "4")
            {
                while (oku.Read())
                {
                    ListViewItem add = new ListViewItem(oku["ÜrünAdı"].ToString());
                    add.SubItems.Add(oku["Fiyat"].ToString());
                    add.SubItems.Add(oku["Toplam"].ToString());
                    add.SubItems.Add(oku["MasaID"].ToString());


                    kasaOdeme.Items.Add(add);

                }
                baglan.Close();
            }
        }

        private void teras1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu where MasaID='" + text + "' ", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (text == "5")
            {
                while (oku.Read())
                {
                    ListViewItem add = new ListViewItem(oku["ÜrünAdı"].ToString());
                    add.SubItems.Add(oku["Fiyat"].ToString());
                    add.SubItems.Add(oku["Toplam"].ToString());
                    add.SubItems.Add(oku["MasaID"].ToString());


                    kasaOdeme.Items.Add(add);

                }
                baglan.Close();
            }
        }

        private void teras2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu where MasaID='" + text + "' ", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (text == "6")
            {
                while (oku.Read())
                {
                    ListViewItem add = new ListViewItem(oku["ÜrünAdı"].ToString());
                    add.SubItems.Add(oku["Fiyat"].ToString());
                    add.SubItems.Add(oku["Toplam"].ToString());
                    add.SubItems.Add(oku["MasaID"].ToString());


                    kasaOdeme.Items.Add(add);

                }
                baglan.Close();
            }
        }

        private void vip1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu where MasaID='" + text + "' ", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (text == "7")
            {
                while (oku.Read())
                {
                    ListViewItem add = new ListViewItem(oku["ÜrünAdı"].ToString());
                    add.SubItems.Add(oku["Fiyat"].ToString());
                    add.SubItems.Add(oku["Toplam"].ToString());
                    add.SubItems.Add(oku["MasaID"].ToString());


                    kasaOdeme.Items.Add(add);

                }
                baglan.Close();
            }
        }

        private void kasa_Load(object sender, EventArgs e)
        {
            text = SiparisMasalar.texts;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            this.Hide();
            personel.Show();
        }
    }
}
