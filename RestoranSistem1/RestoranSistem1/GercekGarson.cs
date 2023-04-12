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
    public partial class GercekGarson : Form
    {
        public GercekGarson()
        {
            InitializeComponent();
        }

        private void GercekGarson_Load(object sender, EventArgs e)
        {

        }

        private void siparisler_Click(object sender, EventArgs e)
        {
            
            SiparisMasalar siparisAl = new SiparisMasalar();
            
            this.Hide();
            siparisAl.Show();
        }

        private void MutfakSiparis_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            this.Close();
            personel.Show();
        }

        private void backTo_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            this.Hide();
            personel.Show();
        }
    }
}
