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
    public partial class Icecekler : Form
    {
        public Icecekler()
        {
            InitializeComponent();
        }
        public static string secim;
        public static string fiyat;
        private void sogukİcecekler_Click(object sender, EventArgs e)
        {

        }

        private void su_Click(object sender, EventArgs e)
        {

        }

        private void secimSu_Click(object sender, EventArgs e)
        {
            secim1.Text = "su";
            secim = secim1.Text;
            fiyat1.Text = "3";
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

        private void soda_Click(object sender, EventArgs e)
        {

        }

        private void secimSoda_Click(object sender, EventArgs e)
        {
            secim1.Text = "soda";
            secim = secim1.Text;
            fiyat1.Text = "8";
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

        private void ayran_Click(object sender, EventArgs e)
        {

        }

        private void secimAyran_Click(object sender, EventArgs e)
        {
            secim1.Text = "ayran";
            secim = secim1.Text;
            fiyat1.Text = "12";
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

        private void kola_Click(object sender, EventArgs e)
        {

        }

        private void secimKola_Click(object sender, EventArgs e)
        {
            secim1.Text = "kola";
            secim = secim1.Text;
            fiyat1.Text = "15";
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

        private void sogukKahve_Click(object sender, EventArgs e)
        {

        }

        private void secimKahveSoguk_Click(object sender, EventArgs e)
        {
            secim1.Text = "kahve";
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

        private void sicakİcecekler_Click(object sender, EventArgs e)
        {

        }

        private void cay_Click(object sender, EventArgs e)
        {

        }

        private void secimCay_Click(object sender, EventArgs e)
        {
            secim1.Text = "cay";
            secim = secim1.Text;
            fiyat1.Text = "4";
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

        private void sicakKahve_Click(object sender, EventArgs e)
        {

        }

        private void secimKahveSicak_Click(object sender, EventArgs e)
        {
            secim1.Text = "kahve";
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

        private void kisCayi_Click(object sender, EventArgs e)
        {

        }

        private void secimKisCayi_Click(object sender, EventArgs e)
        {
            secim1.Text = "kiscayi";
            secim = secim1.Text;
            fiyat1.Text = "20";
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

        private void specials_Click(object sender, EventArgs e)
        {

        }

        private void secimSpecials_Click(object sender, EventArgs e)
        {
            secim1.Text = "specials";
            secim = secim1.Text;
            fiyat1.Text = "48";
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

        private void back_Click(object sender, EventArgs e)
        {
            mainMenu mainMenu = new mainMenu();
            this.Close();
            mainMenu.Show();
        }
    }
}
