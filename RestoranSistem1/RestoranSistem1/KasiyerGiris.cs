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
    public partial class KasiyerGiris : Form
    {
        public KasiyerGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=FENERBAHCE-1907;Initial Catalog=adisyon;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void girisKasa_Click(object sender, EventArgs e)
        {
            //baglan.Open();
      
            //SqlCommand komut = new SqlCommand("Select *From adminler where k_ad = @k_ad AND k_sifre = @k_sifre", baglan);
            //SqlParameter temp1 = new SqlParameter("k_ad",textBox1.Text);
            //SqlParameter temp2 = new SqlParameter("k_sifre", textBox2.Text);

            //SqlDataReader oku =  komut.ExecuteReader();

            
            
               
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Kullanıcı adı ve/veya şifre boş bırakılamaz !", "Uyarı");
                }
                else
                {
                    if (textBox1.Text == "kasiyer" && textBox2.Text == "1907" || textBox1.Text == "kasiyer1" && textBox2.Text == "0104" || textBox1.Text == "kasiyer2" && textBox2.Text == "2901")
                    {
                        kasa kasa = new kasa();
                        this.Hide();
                        kasa.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı !!!");
                    }
                }
            
        }

        private void backPersonel_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            this.Hide();
            personel.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
