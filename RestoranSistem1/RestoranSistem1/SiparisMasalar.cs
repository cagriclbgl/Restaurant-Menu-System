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
    public partial class SiparisMasalar : Form
    {
        public SiparisMasalar()
        {
            InitializeComponent();
        }
        public static string texts;
        SqlConnection baglan = new SqlConnection("Data Source=FENERBAHCE-1907;Initial Catalog=adisyon;Integrated Security=True");

        private void masa1_Click(object sender, EventArgs e)
        {
            masa_1.Text = "1";
            texts = masa_1.Text;
          
            mainMenu siparis = new mainMenu();
            this.Hide();
            siparis.Show();
        }
    

        private void masa2_Click(object sender, EventArgs e)
        {
            masa_1.Text = "2";
            texts = masa_1.Text;
            mainMenu siparis = new mainMenu();
            this.Hide();
            siparis.Show();

        }

        private void masa3_Click(object sender, EventArgs e)
        {
            masa_1.Text = "3";
            texts = masa_1.Text;
            mainMenu siparis = new mainMenu();
            this.Hide();
            siparis.Show();
        }

        private void masa4_Click(object sender, EventArgs e)
        {
            masa_1.Text = "4";
            texts = masa_1.Text;
            mainMenu siparis = new mainMenu();
            this.Hide();
            siparis.Show();
        }

        private void teras1_Click(object sender, EventArgs e)
        {
            masa_1.Text = "5";
            texts = masa_1.Text;
            mainMenu siparis = new mainMenu();
            this.Hide();
            siparis.Show();
        }

        private void teras2_Click(object sender, EventArgs e)
        {
            masa_1.Text = "6";
            texts=masa_1.Text;
            mainMenu siparis = new mainMenu();
            this.Hide();
            siparis.Show();
        }

        private void vip1_Click(object sender, EventArgs e)
        {
            masa_1.Text = "7";
            texts = masa_1.Text;
            mainMenu siparis = new mainMenu();
            this.Hide();
            siparis.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            this.Close();
            personel.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SiparisMasalar_Load(object sender, EventArgs e)
        {

        }

        
    }
}
