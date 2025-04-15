using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulOtomasyonu.DataSet1TableAdapters;
using System.Data.SqlClient;

namespace OkulOtomasyonu
{
    public partial class Form_Ogrenciisleri : Form
    {
        public Form_Ogrenciisleri()
        {
            InitializeComponent();
        }

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
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataTable1TableAdapter(); //datasete bağlama
        SqlBaglanti bgl = new SqlBaglanti();
        private void Form_Ogrenciisleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrListesi();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Kulupler",bgl.BaglantiGetir());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            comboBox1.DisplayMember = "Kulupad";
            comboBox1.ValueMember = "Kulupid";
            comboBox1.DataSource = dt;
            bgl.BaglantiGetir().Close();
        }

        string c = "KADIN";
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                c = "ERKEK";
            }
            else if (radioButton2.Checked == true)
            {
                    c = "KADIN"; 
            }
            ds.Ogreekle(tx_ad.Text, tx_soyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c);
            MessageBox.Show("Eklendi ...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrListesi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            ds.Ogrencisil(int.Parse(tx_id.Text));
            MessageBox.Show("Silindi ...","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tx_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tx_soyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            c = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (c=="KADIN"){
                radioButton2.Checked = true;
            }
            else if (c == "ERKEK")
            {
                radioButton1.Checked = true;
            }
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(tx_ad.Text, tx_soyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c, int.Parse(tx_id.Text));
            MessageBox.Show("Güncellendi...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
