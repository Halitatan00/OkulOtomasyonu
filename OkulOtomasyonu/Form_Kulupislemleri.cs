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
using System.Data.Common;

namespace OkulOtomasyonu
{
    public partial class Form_Kulupislemleri : Form
    {
        public Form_Kulupislemleri()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl =new SqlBaglanti();
        void listelekulup()
        {

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Kulupler", bgl.BaglantiGetir());
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void listeleders()
        {
            //listele
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Dersler", bgl.BaglantiGetir());
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        
        public int gelensayfa;
        private void Form_Kulupislemleri_Load(object sender, EventArgs e)
        {
            if (gelensayfa == 1)
            {
                label1.Text = "KULÜP İD";
                label2.Text = "KULÜP AD";
                groupBox1.Text = "KULÜP İŞLEMLERİ";
                listelekulup();  
            }
            else if (gelensayfa == 0) {
                listeleders();
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (gelensayfa==0)
            {
                SqlCommand cmdadd = new SqlCommand("INSERT INTO Tbl_Dersler (Dersad) VALUES (@d1)", bgl.BaglantiGetir());
                cmdadd.Parameters.AddWithValue("@d1", tx_ad.Text);
                cmdadd.ExecuteNonQuery();
                bgl.BaglantiGetir().Close();
                MessageBox.Show("Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listeleders();
            }
            else if(gelensayfa == 1)
            {
                SqlCommand cmdadd = new SqlCommand("INSERT INTO Tbl_Kulupler (Kulupad) VALUES (@d1)", bgl.BaglantiGetir());
                cmdadd.Parameters.AddWithValue("@d1", tx_ad.Text);
                cmdadd.ExecuteNonQuery();
                bgl.BaglantiGetir().Close();
                MessageBox.Show("Eklendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listelekulup();
            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            if (gelensayfa == 0)
            {
                listeleders();
            }
            else {
                listelekulup();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (gelensayfa == 0) {
                SqlCommand cmdsil = new SqlCommand("Delete From Tbl_Dersler Where Dersid=@d1", bgl.BaglantiGetir());
                cmdsil.Parameters.AddWithValue("@d1", tx_id.Text);
                cmdsil.ExecuteNonQuery();
                bgl.BaglantiGetir().Close();
                MessageBox.Show("Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listeleders();
            }
            else if(gelensayfa == 1)
            {
                SqlCommand cmdsil = new SqlCommand("Delete From Tbl_Kulupler Where Kulupid=@d1", bgl.BaglantiGetir());
                cmdsil.Parameters.AddWithValue("@d1", tx_id.Text);
                cmdsil.ExecuteNonQuery();
                bgl.BaglantiGetir().Close();
                MessageBox.Show("Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listelekulup();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if(gelensayfa == 0)
            {
                SqlCommand cmdgunc = new SqlCommand("Update Tbl_Dersler Set Dersad=@g1 Where Dersid=@g2", bgl.BaglantiGetir());
                cmdgunc.Parameters.AddWithValue("@g1", tx_ad.Text);
                cmdgunc.Parameters.AddWithValue("@g2", tx_id.Text);
                cmdgunc.ExecuteNonQuery();
                bgl.BaglantiGetir().Close();
                MessageBox.Show("Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listeleders();
            }
            else if (gelensayfa == 1)
            {
                SqlCommand cmdgunc = new SqlCommand("Update Tbl_Kulupler Set Kulupad=@g1 Where Kulupid=@g2", bgl.BaglantiGetir());
                cmdgunc.Parameters.AddWithValue("@g1", tx_ad.Text);
                cmdgunc.Parameters.AddWithValue("@g2", tx_id.Text);
                cmdgunc.ExecuteNonQuery();
                bgl.BaglantiGetir().Close();
                MessageBox.Show("Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listelekulup();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tx_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Ogretmenler frmogret =new Form_Ogretmenler();
            frmogret.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
