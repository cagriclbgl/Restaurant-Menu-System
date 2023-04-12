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
    public partial class Tatlilar : Form
    {
        public Tatlilar()
        {
            InitializeComponent();
        }
        public static string secim;
        public static string fiyat;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void secim1AnaYemek_Click(object sender, EventArgs e)
        {
            secim1.Text = "tavukgogsu";
            secim = secim1.Text;
            fiyat1.Text = "40";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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

        private void Kebap_Click(object sender, EventArgs e)
        {

        }

        private void secim2AnaYemek_Click(object sender, EventArgs e)
        {
            secim1.Text = "sutlac";
            secim = secim1.Text;
            fiyat1.Text = "40";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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

        private void Kofte_Click(object sender, EventArgs e)
        {

        }

        private void secim3AnaYemek_Click(object sender, EventArgs e)
        {
            secim1.Text = "kazandibi";
            secim = secim1.Text;
            fiyat1.Text = "40";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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

        private void button1_Click(object sender, EventArgs e)
        {
            secim1.Text = "magnolia";
            secim = secim1.Text;
            fiyat1.Text = "38";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            secim1.Text = "gullac";
            secim = secim1.Text;
            fiyat1.Text = "35";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            secim1.Text = "sogukbaklava";
            secim = secim1.Text;
            fiyat1.Text = "60";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            secim1.Text = "kunefe";
            secim = secim1.Text;
            fiyat1.Text = "50";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            secim1.Text = "kadayıf";
            secim = secim1.Text;
            fiyat1.Text = "50";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            secim1.Text = "şekerpare";
            secim = secim1.Text;
            fiyat1.Text = "38";
            fiyat = fiyat1.Text;


            DatabaseConnections.baglan.Open();

            try
            {
                string ekle = "insert into odeme(MasaID,ÜrünAdı,Fiyat) values(@MasaID,@ÜrünAdı,@Fiyat)";
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
