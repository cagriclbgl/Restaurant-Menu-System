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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        public static string fiyat;
        public static int toplam;
        
        
        

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxMenu_Enter(object sender, EventArgs e)
        {

        }

        private void AnaYemek_Click(object sender, EventArgs e)
        {
            anaYemek anayemek = new anaYemek();
            this.Hide();
            anayemek.Show();
        }

        private void Atıştırmalık_Click(object sender, EventArgs e)
        {
            Atistirmalik atistirmalik = new Atistirmalik();
            this.Hide();
            atistirmalik.Show();
        }

        private void İcecek_Click(object sender, EventArgs e)
        {
            Icecekler icecek = new Icecekler();
            this.Hide();
            icecek.Show();
        }

        private void Tatlılar_Click(object sender, EventArgs e)
        {
            Tatlilar tatli = new Tatlilar();
            this.Hide();
            tatli.Show();
        }

        
        
       

        SqlConnection baglan = new SqlConnection("Data Source=FENERBAHCE-1907;Initial Catalog=adisyon;Integrated Security=True");
        private void siparisiTamamla_Click(object sender, EventArgs e)
        { 
            
            baglan.Open();
            if (SiparisMasalar.texts=="masa1")
            {
                string query1 = "Insert into adisyontablosu (MasaID,ÜrünAdı,Fiyat,Toplam) values(@text1,@text2,@text3,@text4)";
                SqlCommand ekle = new SqlCommand(query1, baglan);
                ekle.Parameters.AddWithValue("@text1", SiparisMasalar.texts);
                ekle.Parameters.AddWithValue("@text2", "kebap");
                ekle.Parameters.AddWithValue("@text3", "80");
                ekle.Parameters.AddWithValue("@text4", "80");
            }
            
            baglan.Close(); 
            
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From adisyontablosu", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                ListViewItem add = new ListViewItem(oku["MasaID"].ToString());
                add.SubItems.Add(oku["ÜrünAdı"].ToString());
                add.SubItems.Add(oku["Fiyat"].ToString());
                add.SubItems.Add(oku["Toplam"].ToString());
                

                listView2.Items.Add(add);

            }
            
            baglan.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            SiparisMasalar masa = new SiparisMasalar();
            this.Hide();
            masa.Show();
        }
    }
}
