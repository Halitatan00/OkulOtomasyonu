namespace OkulOtomasyonu
{
    partial class Form_Sınavnotları
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_sınav1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.tx_sınav2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_sınav3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_durum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_ortalama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_proje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cm_ders = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_sınav1
            // 
            this.tx_sınav1.Location = new System.Drawing.Point(142, 80);
            this.tx_sınav1.Name = "tx_sınav1";
            this.tx_sınav1.Size = new System.Drawing.Size(175, 26);
            this.tx_sınav1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "SINAV 1 :";
            // 
            // tx_id
            // 
            this.tx_id.Location = new System.Drawing.Point(142, 16);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(175, 26);
            this.tx_id.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "DERS :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(15, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 307);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "ÖĞRENCİ İD :";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(558, 51);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(188, 46);
            this.btn_hesapla.TabIndex = 22;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(558, 103);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(188, 46);
            this.btn_temizle.TabIndex = 25;
            this.btn_temizle.Text = "TEMZİLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(558, 155);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(188, 46);
            this.btn_guncelle.TabIndex = 27;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // tx_sınav2
            // 
            this.tx_sınav2.Location = new System.Drawing.Point(142, 112);
            this.tx_sınav2.Name = "tx_sınav2";
            this.tx_sınav2.Size = new System.Drawing.Size(175, 26);
            this.tx_sınav2.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "SINAV 2 :";
            // 
            // tx_sınav3
            // 
            this.tx_sınav3.Location = new System.Drawing.Point(142, 144);
            this.tx_sınav3.Name = "tx_sınav3";
            this.tx_sınav3.Size = new System.Drawing.Size(175, 26);
            this.tx_sınav3.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "SINAV 3 :";
            // 
            // tx_durum
            // 
            this.tx_durum.Location = new System.Drawing.Point(142, 240);
            this.tx_durum.Name = "tx_durum";
            this.tx_durum.Size = new System.Drawing.Size(175, 26);
            this.tx_durum.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "DURUM :";
            // 
            // tx_ortalama
            // 
            this.tx_ortalama.Location = new System.Drawing.Point(142, 208);
            this.tx_ortalama.Name = "tx_ortalama";
            this.tx_ortalama.Size = new System.Drawing.Size(175, 26);
            this.tx_ortalama.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "ORTALAMA :";
            // 
            // tx_proje
            // 
            this.tx_proje.Location = new System.Drawing.Point(142, 176);
            this.tx_proje.Name = "tx_proje";
            this.tx_proje.Size = new System.Drawing.Size(175, 26);
            this.tx_proje.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "PROJE :";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(559, 207);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(188, 46);
            this.btn_ara.TabIndex = 54;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OkulOtomasyonu.Properties.Resources.search;
            this.pictureBox4.Location = new System.Drawing.Point(452, 207);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::OkulOtomasyonu.Properties.Resources.close;
            this.pictureBox5.Location = new System.Drawing.Point(680, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(61, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::OkulOtomasyonu.Properties.Resources.left_arrow;
            this.pictureBox6.Location = new System.Drawing.Point(613, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OkulOtomasyonu.Properties.Resources.calculator;
            this.pictureBox1.Location = new System.Drawing.Point(452, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OkulOtomasyonu.Properties.Resources.broom;
            this.pictureBox2.Location = new System.Drawing.Point(452, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OkulOtomasyonu.Properties.Resources.refresh;
            this.pictureBox3.Location = new System.Drawing.Point(452, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // cm_ders
            // 
            this.cm_ders.FormattingEnabled = true;
            this.cm_ders.Location = new System.Drawing.Point(142, 46);
            this.cm_ders.Name = "cm_ders";
            this.cm_ders.Size = new System.Drawing.Size(175, 28);
            this.cm_ders.TabIndex = 56;
            // 
            // Form_Sınavnotları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(774, 598);
            this.Controls.Add(this.cm_ders);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tx_durum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_ortalama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_proje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tx_sınav3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_sınav2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tx_sınav1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Form_Sınavnotları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Sınavnotları";
            this.Load += new System.EventHandler(this.Form_Sınavnotları_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_sınav1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tx_sınav2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_sınav3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_durum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_ortalama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_proje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cm_ders;
    }
}