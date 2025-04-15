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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulOtomasyonu
{
    public partial class Form_Sınavnotları : Form
    {
        public Form_Sınavnotları()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Ogretmenler frmogretmen = new Form_Ogretmenler();
            frmogretmen.Show();
            this.Close();
        }
        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds=new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        private void Form_Sınavnotları_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Dersler", bgl.BaglantiGetir());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cm_ders.DisplayMember = "Dersad";
            cm_ders.ValueMember = "Dersid";
            cm_ders.DataSource = dt;
            bgl.BaglantiGetir().Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(tx_id.Text));
        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tx_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cm_ders.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            tx_sınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tx_sınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tx_sınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tx_proje.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tx_ortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tx_durum.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        int sinav1, sinav2, sinav3, proje;
        double ortalama;
        string durum;
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            
            sinav1=Convert.ToInt32(tx_sınav1.Text);
            sinav2 = Convert.ToInt32(tx_sınav2.Text);
            sinav3 = Convert.ToInt32(tx_sınav3.Text);
            proje = Convert.ToInt32(tx_proje.Text);
            ortalama=(sinav1+sinav2+sinav3+proje)/4;
            tx_ortalama.Text = ortalama.ToString();
            if (ortalama >=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
            tx_durum.Text=durum;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cm_ders.SelectedValue.ToString()),int.Parse(tx_id.Text),byte.Parse(tx_sınav1.Text), byte.Parse(tx_sınav2.Text), byte.Parse(tx_sınav3.Text), byte.Parse(tx_proje.Text), decimal.Parse(tx_ortalama.Text),bool.Parse(tx_durum.Text),notid);
            MessageBox.Show("Güncellendi ...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
