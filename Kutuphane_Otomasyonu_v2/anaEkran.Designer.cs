﻿
namespace Kutuphane_Otomasyonu_v2
{
    partial class anaEkran
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
            this.btn_ogrenciIslemleri = new System.Windows.Forms.Button();
            this.btn_kitapIslemleri = new System.Windows.Forms.Button();
            this.btn_kitapAlmaVerme = new System.Windows.Forms.Button();
            this.btn_ogrenciAlmaVermeGosterimi = new System.Windows.Forms.Button();
            this.btn_kitapEmanetIade = new System.Windows.Forms.Button();
            this.btn_zedgraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ogrenciIslemleri
            // 
            this.btn_ogrenciIslemleri.Location = new System.Drawing.Point(42, 26);
            this.btn_ogrenciIslemleri.Name = "btn_ogrenciIslemleri";
            this.btn_ogrenciIslemleri.Size = new System.Drawing.Size(131, 63);
            this.btn_ogrenciIslemleri.TabIndex = 1;
            this.btn_ogrenciIslemleri.Text = "Öğrenci İşlemleri";
            this.btn_ogrenciIslemleri.UseVisualStyleBackColor = true;
            this.btn_ogrenciIslemleri.Click += new System.EventHandler(this.btn_ogrenciIslemleri_Click);
            // 
            // btn_kitapIslemleri
            // 
            this.btn_kitapIslemleri.Location = new System.Drawing.Point(200, 26);
            this.btn_kitapIslemleri.Name = "btn_kitapIslemleri";
            this.btn_kitapIslemleri.Size = new System.Drawing.Size(131, 63);
            this.btn_kitapIslemleri.TabIndex = 2;
            this.btn_kitapIslemleri.Text = "Kitap İşlemleri";
            this.btn_kitapIslemleri.UseVisualStyleBackColor = true;
            this.btn_kitapIslemleri.Click += new System.EventHandler(this.btn_kitapIslemleri_Click);
            // 
            // btn_kitapAlmaVerme
            // 
            this.btn_kitapAlmaVerme.Location = new System.Drawing.Point(371, 26);
            this.btn_kitapAlmaVerme.Name = "btn_kitapAlmaVerme";
            this.btn_kitapAlmaVerme.Size = new System.Drawing.Size(131, 63);
            this.btn_kitapAlmaVerme.TabIndex = 3;
            this.btn_kitapAlmaVerme.Text = "Öğrenci Kitap Alma Verme";
            this.btn_kitapAlmaVerme.UseVisualStyleBackColor = true;
            this.btn_kitapAlmaVerme.Click += new System.EventHandler(this.btn_kitapAlmaVerme_Click);
            // 
            // btn_ogrenciAlmaVermeGosterimi
            // 
            this.btn_ogrenciAlmaVermeGosterimi.Location = new System.Drawing.Point(42, 117);
            this.btn_ogrenciAlmaVermeGosterimi.Name = "btn_ogrenciAlmaVermeGosterimi";
            this.btn_ogrenciAlmaVermeGosterimi.Size = new System.Drawing.Size(131, 63);
            this.btn_ogrenciAlmaVermeGosterimi.TabIndex = 1;
            this.btn_ogrenciAlmaVermeGosterimi.Text = "Öğrenci Emanet - İade Gösterimi";
            this.btn_ogrenciAlmaVermeGosterimi.UseVisualStyleBackColor = true;
            this.btn_ogrenciAlmaVermeGosterimi.Click += new System.EventHandler(this.btn_ogrenciAlmaVermeGosterimi_Click);
            // 
            // btn_kitapEmanetIade
            // 
            this.btn_kitapEmanetIade.Location = new System.Drawing.Point(200, 117);
            this.btn_kitapEmanetIade.Name = "btn_kitapEmanetIade";
            this.btn_kitapEmanetIade.Size = new System.Drawing.Size(131, 63);
            this.btn_kitapEmanetIade.TabIndex = 1;
            this.btn_kitapEmanetIade.Text = "Kitap Emanet- İade Gösterimi";
            this.btn_kitapEmanetIade.UseVisualStyleBackColor = true;
            this.btn_kitapEmanetIade.Click += new System.EventHandler(this.btn_kitapEmanetIade_Click);
            // 
            // btn_zedgraph
            // 
            this.btn_zedgraph.Location = new System.Drawing.Point(371, 117);
            this.btn_zedgraph.Name = "btn_zedgraph";
            this.btn_zedgraph.Size = new System.Drawing.Size(131, 63);
            this.btn_zedgraph.TabIndex = 1;
            this.btn_zedgraph.Text = "Grafik";
            this.btn_zedgraph.UseVisualStyleBackColor = true;
            this.btn_zedgraph.Click += new System.EventHandler(this.btn_zedgraph_Click);
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 192);
            this.Controls.Add(this.btn_kitapAlmaVerme);
            this.Controls.Add(this.btn_kitapIslemleri);
            this.Controls.Add(this.btn_zedgraph);
            this.Controls.Add(this.btn_kitapEmanetIade);
            this.Controls.Add(this.btn_ogrenciAlmaVermeGosterimi);
            this.Controls.Add(this.btn_ogrenciIslemleri);
            this.Name = "anaEkran";
            this.Text = "ANA EKRAN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ogrenciIslemleri;
        private System.Windows.Forms.Button btn_kitapIslemleri;
        private System.Windows.Forms.Button btn_kitapAlmaVerme;
        private System.Windows.Forms.Button btn_ogrenciAlmaVermeGosterimi;
        private System.Windows.Forms.Button btn_kitapEmanetIade;
        private System.Windows.Forms.Button btn_zedgraph;
    }
}