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
    public partial class Atistirmalik : Form
    {
        public Atistirmalik()
        {
            InitializeComponent();
        }
        public static string secim;
        public static string fiyat;

        private void atistirmaliklar_Click(object sender, EventArgs e)
        {

        }

        private void patatesKızartma_Click(object sender, EventArgs e)
        {

        }

        private void secimPatates_Click(object sender, EventArgs e)
        {

            secim1.Text = "patates";
            secim = secim1.Text;
            fiyat1.Text = "80";
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

        private void Tost_Click(object sender, EventArgs e)
        {
            
        }

        private void secimTost_Click(object sender, EventArgs e)
        {
            secim1.Text = "tost";
            secim = secim1.Text;
            fiyat1.Text = "80";
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

        private void Sandvic_Click(object sender, EventArgs e)
        {

        }

        private void secimSandvic_Click(object sender, EventArgs e)
        {
            secim1.Text = "sandvic";
            secim = secim1.Text;
            fiyat1.Text = "80";
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

        private void Sosisli_Click(object sender, EventArgs e)
        {

        }

        private void secimSosisli_Click(object sender, EventArgs e)
        {
            secim1.Text = "sosisli";
            secim = secim1.Text;
            fiyat1.Text = "80";
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
