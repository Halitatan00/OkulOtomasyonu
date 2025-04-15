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

namespace OkulOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Ogrenci_notlar frmogrenci =new Form_Ogrenci_notlar();
            frmogrenci.numara = tx_ogrenci.Text;
            frmogrenci.Show();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_Ogretmenler frmogretmen=new Form_Ogretmenler();
            frmogretmen.Show();
            this.Hide();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
