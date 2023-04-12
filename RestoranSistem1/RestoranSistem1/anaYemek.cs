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
    public partial class anaYemek : Form
    {
        public anaYemek()
        {
            InitializeComponent();
        }
        public static string secim;
        public static string fiyat;
        
        
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void secim1AnaYemek_Click(object sender, EventArgs e)
        {
            
            secim1.Text = "İskender";
            secim = secim1.Text;
            fiyat1.Text = "80";
            fiyat = fiyat1.Text;
            
            
            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into adisyontablosu(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
                SqlCommand komut = new SqlCommand(ekle,DatabaseConnections.baglan);

                komut.Parameters.AddWithValue("@MasaID", SiparisMasalar.texts);
                komut.Parameters.AddWithValue("@ÜrünAdı",secim);
                komut.Parameters.AddWithValue("@Fiyat",fiyat);
                komut.ExecuteNonQuery();
                
                DatabaseConnections.baglan.Close();
                

            }
            catch(Exception Hata)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi Hata kodu = " + Hata.Message);
            }

        }

        private void Kebap_Click(object sender, EventArgs e)
        {

        }

        private void secim2AnaYemek_Click(object sender, EventArgs e)
        {
            secim1.Text = "Kebap";
            secim= secim1.Text;
            fiyat1.Text = "75";
            fiyat = fiyat1.Text;

            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into adisyontablosu(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
                SqlCommand komut = new SqlCommand(ekle, DatabaseConnections.baglan);

                komut.Parameters.AddWithValue("@MasaID", SiparisMasalar.texts);
                komut.Parameters.AddWithValue("@ÜrünAdı", secim);
                komut.Parameters.AddWithValue("@Fiyat", fiyat);
                komut.ExecuteNonQuery();

                DatabaseConnections.baglan.Close();
                
            }
            catch(Exception Hata)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi Hata Kodu = " + Hata.Message);
            }
        }

        private void Kofte_Click(object sender, EventArgs e)
        {
            
        }

        private void secim3AnaYemek_Click(object sender, EventArgs e)
        {
            secim1.Text = "Kofte";
            secim = secim1.Text;
            fiyat1.Text = "50";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into adisyontablosu(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
                SqlCommand komut = new SqlCommand(ekle, DatabaseConnections.baglan);

                komut.Parameters.AddWithValue("@MasaID", SiparisMasalar.texts);
                komut.Parameters.AddWithValue("@ÜrünAdı", secim);
                komut.Parameters.AddWithValue("@Fiyat", fiyat);
                komut.ExecuteNonQuery();

                DatabaseConnections.baglan.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi Hata kodu = " + Hata.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void secim4AnaYemek_Click(object sender, EventArgs e)
        {
            secim1.Text = "Doner";
            secim = secim1.Text;
            fiyat1.Text = "67";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into adisyontablosu(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
                SqlCommand komut = new SqlCommand(ekle, DatabaseConnections.baglan);

                komut.Parameters.AddWithValue("@MasaID", SiparisMasalar.texts);
                komut.Parameters.AddWithValue("@ÜrünAdı", secim);
                komut.Parameters.AddWithValue("@Fiyat", fiyat);
                komut.ExecuteNonQuery();

                DatabaseConnections.baglan.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi Hata kodu = " + Hata.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void secim5AnaYemek_Click(object sender, EventArgs e)
        {
            secim1.Text = "Hamburger";
            secim = secim1.Text;
            fiyat1.Text = "80";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into adisyontablosu(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
                SqlCommand komut = new SqlCommand(ekle, DatabaseConnections.baglan);

                komut.Parameters.AddWithValue("@MasaID", SiparisMasalar.texts);
                komut.Parameters.AddWithValue("@ÜrünAdı", secim);
                komut.Parameters.AddWithValue("@Fiyat", fiyat);
                komut.ExecuteNonQuery();

                DatabaseConnections.baglan.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi Hata kodu = " + Hata.Message);
            }
        }

        private void backAnaYemek_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            this.Close();
            mainMenu.Show();    
        }
    }
}
