using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranSistem1
{
    public partial class Garson : Form
    {
        public Garson()
        {
            InitializeComponent();
        }

        private void userBox_Click(object sender, EventArgs e)
        {

        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBox_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void girisButonu_Click(object sender, EventArgs e)
        {
            if(userNameBox.Text=="" || passwordBox.Text =="")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş bırakılamaz !", "Uyarı");
            }
            else
            {
                if(userNameBox.Text =="garson" && passwordBox.Text == "1907" || userNameBox.Text == "garson1" && passwordBox.Text == "0104" || userNameBox.Text == "garson2" && passwordBox.Text == "2901")
                {
                    GercekGarson giris = new GercekGarson();
                    this.Hide();
                    giris.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı !!!");
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Personel personelDonus = new Personel();
            this.Hide();
            personelDonus.Show();
        }

        private void userNameBox_Click(object sender, EventArgs e)
        {
            userNameBox.Text = "";
        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            passwordBox.Text = "";
        }

        private void Garson_Load(object sender, EventArgs e)
        {

        }
    }
}
