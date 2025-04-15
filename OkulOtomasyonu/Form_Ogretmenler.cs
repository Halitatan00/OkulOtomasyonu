using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class Form_Ogretmenler : Form
    {
        public Form_Ogretmenler()
        {
            InitializeComponent();
        }

        private void btn_dersislemleri_Click(object sender, EventArgs e)
        {
            Form_Kulupislemleri frmkulupislemleri = new Form_Kulupislemleri();
            frmkulupislemleri.gelensayfa = 0;
            frmkulupislemleri.Show();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 frmhome = new Form1();
            frmhome.Show();
            this.Close();
        }

        private void btn_kulupislemleri_Click(object sender, EventArgs e)
        {
            Form_Kulupislemleri frmkulupislemleri =new Form_Kulupislemleri();
            frmkulupislemleri.gelensayfa = 1;
            frmkulupislemleri.Show();
        }

        private void btn_ogrenciisleri_Click(object sender, EventArgs e)
        {
            Form_Ogrenciisleri frmogrenciisleri =new Form_Ogrenciisleri();
            frmogrenciisleri.Show();
        }

        private void btn_sınavnotları_Click(object sender, EventArgs e)
        {
            Form_Sınavnotları frsınav =new Form_Sınavnotları();
            frsınav.Show();
            
        }
    }
}
