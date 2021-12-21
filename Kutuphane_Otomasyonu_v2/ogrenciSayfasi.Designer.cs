
namespace Kutuphane_Otomasyonu_v2
{
    partial class ogrenciSayfasi
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
            this.btn_ogrenciEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_ogrenciListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ogrenciNumarasi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ogrenciAra = new System.Windows.Forms.Button();
            this.txt_ogrenciAra = new System.Windows.Forms.TextBox();
            this.btn_ogrenciGuncelle = new System.Windows.Forms.Button();
            this.btn_ogrenciSil = new System.Windows.Forms.Button();
            this.btn_anaEkranaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ogrenciEkle
            // 
            this.btn_ogrenciEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciEkle.Location = new System.Drawing.Point(12, 351);
            this.btn_ogrenciEkle.Name = "btn_ogrenciEkle";
            this.btn_ogrenciEkle.Size = new System.Drawing.Size(181, 55);
            this.btn_ogrenciEkle.TabIndex = 8;
            this.btn_ogrenciEkle.Text = "Öğrenci Ekle";
            this.btn_ogrenciEkle.UseVisualStyleBackColor = true;
            this.btn_ogrenciEkle.Click += new System.EventHandler(this.btn_ogrenciEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 333);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adi →";
            // 
            // txt_adi
            // 
            this.txt_adi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi.Location = new System.Drawing.Point(161, 51);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(258, 26);
            this.txt_adi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Bölüm →";
            // 
            // txt_bolum
            // 
            this.txt_bolum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bolum.Location = new System.Drawing.Point(161, 83);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(258, 26);
            this.txt_bolum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Mail →";
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(161, 115);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(258, 26);
            this.txt_mail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Öğrenci Adres →";
            // 
            // txt_adres
            // 
            this.txt_adres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.Location = new System.Drawing.Point(162, 146);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(258, 26);
            this.txt_adres.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Öğrenci Telefon →";
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel.Location = new System.Drawing.Point(161, 178);
            this.txt_tel.MaxLength = 10;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(258, 26);
            this.txt_tel.TabIndex = 6;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Öğrenci ID →";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ID.Location = new System.Drawing.Point(162, 19);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(258, 26);
            this.txt_ID.TabIndex = 0;
            // 
            // btn_ogrenciListele
            // 
            this.btn_ogrenciListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciListele.Location = new System.Drawing.Point(676, 351);
            this.btn_ogrenciListele.Name = "btn_ogrenciListele";
            this.btn_ogrenciListele.Size = new System.Drawing.Size(181, 55);
            this.btn_ogrenciListele.TabIndex = 9;
            this.btn_ogrenciListele.Text = "Öğrenci Listele";
            this.btn_ogrenciListele.UseVisualStyleBackColor = true;
            this.btn_ogrenciListele.Click += new System.EventHandler(this.btn_ogrenciListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.txt_ogrenciNumarasi);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_adi);
            this.groupBox1.Controls.Add(this.txt_adres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_bolum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 254);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // txt_ogrenciNumarasi
            // 
            this.txt_ogrenciNumarasi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogrenciNumarasi.Location = new System.Drawing.Point(162, 210);
            this.txt_ogrenciNumarasi.Name = "txt_ogrenciNumarasi";
            this.txt_ogrenciNumarasi.Size = new System.Drawing.Size(258, 26);
            this.txt_ogrenciNumarasi.TabIndex = 7;
            this.txt_ogrenciNumarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ogrenciNumarasi_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Öğrenci Numara →";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ogrenciAra);
            this.groupBox2.Controls.Add(this.txt_ogrenciAra);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Ara";
            // 
            // btn_ogrenciAra
            // 
            this.btn_ogrenciAra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciAra.Location = new System.Drawing.Point(295, 25);
            this.btn_ogrenciAra.Name = "btn_ogrenciAra";
            this.btn_ogrenciAra.Size = new System.Drawing.Size(124, 32);
            this.btn_ogrenciAra.TabIndex = 2;
            this.btn_ogrenciAra.Text = "Öğrenci Ara";
            this.btn_ogrenciAra.UseVisualStyleBackColor = true;
            this.btn_ogrenciAra.Click += new System.EventHandler(this.btn_ogrenciAra_Click);
            // 
            // txt_ogrenciAra
            // 
            this.txt_ogrenciAra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ogrenciAra.Location = new System.Drawing.Point(6, 25);
            this.txt_ogrenciAra.Name = "txt_ogrenciAra";
            this.txt_ogrenciAra.Size = new System.Drawing.Size(254, 26);
            this.txt_ogrenciAra.TabIndex = 1;
            this.txt_ogrenciAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ogrenciGuncelle
            // 
            this.btn_ogrenciGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciGuncelle.Location = new System.Drawing.Point(455, 351);
            this.btn_ogrenciGuncelle.Name = "btn_ogrenciGuncelle";
            this.btn_ogrenciGuncelle.Size = new System.Drawing.Size(181, 55);
            this.btn_ogrenciGuncelle.TabIndex = 10;
            this.btn_ogrenciGuncelle.Text = "Öğrenci Güncelle";
            this.btn_ogrenciGuncelle.UseVisualStyleBackColor = true;
            this.btn_ogrenciGuncelle.Click += new System.EventHandler(this.btn_ogrenciGuncelle_Click);
            // 
            // btn_ogrenciSil
            // 
            this.btn_ogrenciSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciSil.Location = new System.Drawing.Point(230, 351);
            this.btn_ogrenciSil.Name = "btn_ogrenciSil";
            this.btn_ogrenciSil.Size = new System.Drawing.Size(181, 55);
            this.btn_ogrenciSil.TabIndex = 11;
            this.btn_ogrenciSil.Text = "Öğrenci Sil";
            this.btn_ogrenciSil.UseVisualStyleBackColor = true;
            this.btn_ogrenciSil.Click += new System.EventHandler(this.btn_ogrenciSil_Click);
            // 
            // btn_anaEkranaDon
            // 
            this.btn_anaEkranaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anaEkranaDon.Location = new System.Drawing.Point(903, 351);
            this.btn_anaEkranaDon.Name = "btn_anaEkranaDon";
            this.btn_anaEkranaDon.Size = new System.Drawing.Size(181, 55);
            this.btn_anaEkranaDon.TabIndex = 12;
            this.btn_anaEkranaDon.Text = "Ana Ekrana Dön";
            this.btn_anaEkranaDon.UseVisualStyleBackColor = true;
            this.btn_anaEkranaDon.Click += new System.EventHandler(this.btn_anaEkranaDon_Click);
            // 
            // ogrenciSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 416);
            this.Controls.Add(this.btn_anaEkranaDon);
            this.Controls.Add(this.btn_ogrenciSil);
            this.Controls.Add(this.btn_ogrenciGuncelle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ogrenciListele);
            this.Controls.Add(this.btn_ogrenciEkle);
            this.Name = "ogrenciSayfasi";
            this.Text = "Öğrenci Sayfası";
            this.Load += new System.EventHandler(this.ogrenciSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrenciEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_ogrenciListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ogrenciAra;
        private System.Windows.Forms.TextBox txt_ogrenciNumarasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ogrenciGuncelle;
        private System.Windows.Forms.Button btn_ogrenciSil;
        private System.Windows.Forms.Button btn_ogrenciAra;
        private System.Windows.Forms.Button btn_anaEkranaDon;
    }
}

