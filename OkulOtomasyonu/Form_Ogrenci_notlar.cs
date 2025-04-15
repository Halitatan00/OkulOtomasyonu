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
    public partial class Form_Ogrenci_notlar : Form
    {
        public Form_Ogrenci_notlar()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string numara;
        private void Form_Ogrenci_notlar_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT d.Dersad,o.Ograd,n.Sınav1,n.Sınav2,n.Sınav3,n.Projenot,n.Ortalama, n.Durum FROM Tbl_Notlar n JOIN Tbl_Dersler d ON d.Dersid=n.Dersid  JOIN Tbl_Ogrenciler o ON o.Ogrid=n.Ogrid WHERE o.Ogrid=@o1", bgl.BaglantiGetir());
            cmd.Parameters.AddWithValue("@o1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form_Ogrenci_notlar_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
