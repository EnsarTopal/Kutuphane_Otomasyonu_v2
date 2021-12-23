
namespace Kutuphane_Otomasyonu_v2
{
    partial class almaVermeGosterim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(almaVermeGosterim));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBox_iadeKitapAra = new System.Windows.Forms.ComboBox();
            this.txt_iadeKitap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_iadeKitapAra = new System.Windows.Forms.Button();
            this.dgv_IadeKitap = new System.Windows.Forms.DataGridView();
            this.dgv_kitap = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmBox_kitapAra = new System.Windows.Forms.ComboBox();
            this.txt_kitap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kitapAra = new System.Windows.Forms.Button();
            this.btn_ana = new System.Windows.Forms.Button();
            this.btn_tumKitaplar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IadeKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBox_iadeKitapAra);
            this.groupBox1.Controls.Add(this.txt_iadeKitap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_iadeKitapAra);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(63, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade Edilen Kitap";
            // 
            // cmbBox_iadeKitapAra
            // 
            this.cmbBox_iadeKitapAra.FormattingEnabled = true;
            this.cmbBox_iadeKitapAra.Items.AddRange(new object[] {
            "kitapAdi ",
            "kitapYazari",
            "kitapTuru"});
            this.cmbBox_iadeKitapAra.Location = new System.Drawing.Point(190, 29);
            this.cmbBox_iadeKitapAra.Name = "cmbBox_iadeKitapAra";
            this.cmbBox_iadeKitapAra.Size = new System.Drawing.Size(210, 27);
            this.cmbBox_iadeKitapAra.TabIndex = 3;
            // 
            // txt_iadeKitap
            // 
            this.txt_iadeKitap.Location = new System.Drawing.Point(190, 62);
            this.txt_iadeKitap.Name = "txt_iadeKitap";
            this.txt_iadeKitap.Size = new System.Drawing.Size(210, 26);
            this.txt_iadeKitap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Arama Kriteri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Bilgisi →";
            // 
            // btn_iadeKitapAra
            // 
            this.btn_iadeKitapAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iadeKitapAra.BackgroundImage")));
            this.btn_iadeKitapAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_iadeKitapAra.FlatAppearance.BorderSize = 0;
            this.btn_iadeKitapAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_iadeKitapAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_iadeKitapAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iadeKitapAra.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iadeKitapAra.Location = new System.Drawing.Point(233, 99);
            this.btn_iadeKitapAra.Name = "btn_iadeKitapAra";
            this.btn_iadeKitapAra.Size = new System.Drawing.Size(167, 41);
            this.btn_iadeKitapAra.TabIndex = 0;
            this.btn_iadeKitapAra.UseVisualStyleBackColor = true;
            this.btn_iadeKitapAra.Click += new System.EventHandler(this.btn_iadeKitapAra_Click);
            // 
            // dgv_IadeKitap
            // 
            this.dgv_IadeKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IadeKitap.Location = new System.Drawing.Point(12, 254);
            this.dgv_IadeKitap.Name = "dgv_IadeKitap";
            this.dgv_IadeKitap.Size = new System.Drawing.Size(588, 254);
            this.dgv_IadeKitap.TabIndex = 1;
            // 
            // dgv_kitap
            // 
            this.dgv_kitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kitap.Location = new System.Drawing.Point(632, 254);
            this.dgv_kitap.Name = "dgv_kitap";
            this.dgv_kitap.Size = new System.Drawing.Size(588, 254);
            this.dgv_kitap.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmBox_kitapAra);
            this.groupBox2.Controls.Add(this.txt_kitap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_kitapAra);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(696, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitaplar";
            // 
            // cmBox_kitapAra
            // 
            this.cmBox_kitapAra.FormattingEnabled = true;
            this.cmBox_kitapAra.Items.AddRange(new object[] {
            "kitapAdi ",
            "kitapNumarasi",
            "kitapYazari",
            "kitapTuru"});
            this.cmBox_kitapAra.Location = new System.Drawing.Point(201, 29);
            this.cmBox_kitapAra.Name = "cmBox_kitapAra";
            this.cmBox_kitapAra.Size = new System.Drawing.Size(210, 27);
            this.cmBox_kitapAra.TabIndex = 3;
            this.cmBox_kitapAra.SelectedIndexChanged += new System.EventHandler(this.cmBox_kitapAra_SelectedIndexChanged);
            // 
            // txt_kitap
            // 
            this.txt_kitap.Location = new System.Drawing.Point(201, 62);
            this.txt_kitap.Name = "txt_kitap";
            this.txt_kitap.Size = new System.Drawing.Size(210, 26);
            this.txt_kitap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitap Arama Kriteri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kitap Bilgisi →";
            // 
            // btn_kitapAra
            // 
            this.btn_kitapAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kitapAra.BackgroundImage")));
            this.btn_kitapAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_kitapAra.FlatAppearance.BorderSize = 0;
            this.btn_kitapAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_kitapAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_kitapAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapAra.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapAra.Location = new System.Drawing.Point(244, 99);
            this.btn_kitapAra.Name = "btn_kitapAra";
            this.btn_kitapAra.Size = new System.Drawing.Size(167, 41);
            this.btn_kitapAra.TabIndex = 0;
            this.btn_kitapAra.UseVisualStyleBackColor = true;
            this.btn_kitapAra.Click += new System.EventHandler(this.btn_kitapAra_Click);
            // 
            // btn_ana
            // 
            this.btn_ana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ana.BackgroundImage")));
            this.btn_ana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ana.FlatAppearance.BorderSize = 0;
            this.btn_ana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ana.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ana.Location = new System.Drawing.Point(1047, 514);
            this.btn_ana.Name = "btn_ana";
            this.btn_ana.Size = new System.Drawing.Size(173, 50);
            this.btn_ana.TabIndex = 4;
            this.btn_ana.UseVisualStyleBackColor = true;
            this.btn_ana.Click += new System.EventHandler(this.btn_ana_Click);
            // 
            // btn_tumKitaplar
            // 
            this.btn_tumKitaplar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tumKitaplar.BackgroundImage")));
            this.btn_tumKitaplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tumKitaplar.FlatAppearance.BorderSize = 0;
            this.btn_tumKitaplar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tumKitaplar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_tumKitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tumKitaplar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tumKitaplar.Location = new System.Drawing.Point(12, 514);
            this.btn_tumKitaplar.Name = "btn_tumKitaplar";
            this.btn_tumKitaplar.Size = new System.Drawing.Size(173, 50);
            this.btn_tumKitaplar.TabIndex = 4;
            this.btn_tumKitaplar.UseVisualStyleBackColor = true;
            this.btn_tumKitaplar.Click += new System.EventHandler(this.btn_tumKitaplar_Click);
            // 
            // almaVermeGosterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 576);
            this.Controls.Add(this.btn_tumKitaplar);
            this.Controls.Add(this.btn_ana);
            this.Controls.Add(this.dgv_kitap);
            this.Controls.Add(this.dgv_IadeKitap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "almaVermeGosterim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "almaVermeGosterim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IadeKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBox_iadeKitapAra;
        private System.Windows.Forms.TextBox txt_iadeKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_iadeKitapAra;
        private System.Windows.Forms.DataGridView dgv_IadeKitap;
        private System.Windows.Forms.DataGridView dgv_kitap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmBox_kitapAra;
        private System.Windows.Forms.TextBox txt_kitap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_kitapAra;
        private System.Windows.Forms.Button btn_ana;
        private System.Windows.Forms.Button btn_tumKitaplar;
    }
}