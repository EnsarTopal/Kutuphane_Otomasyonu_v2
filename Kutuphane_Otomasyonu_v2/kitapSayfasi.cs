using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entity;

namespace Kutuphane_Otomasyonu_v2
{
    public partial class kitapSayfasi : Form
    {
        public kitapSayfasi()
        {
            InitializeComponent();
        }
        string yer = " ";
        kitapIslem kitapIslemleri = new kitapIslem();
        private void btn_anaEkran_Click(object sender, EventArgs e)
        {
            anaEkran frmAnaEkran = new anaEkran();
            frmAnaEkran.Show();
            this.Hide();
        }
        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            //aşağıdaki if else bloğunda form içerisindeki textboxların kontrolü sağlanmıştır.
            #region if-else blogu
            if (txt_kitapAdi.Text == "")
                MessageBox.Show("Kitap adı girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_kitapNumarasi.Text == "")
                MessageBox.Show("Kitap numarasını girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_kitapYazari.Text == "")
                MessageBox.Show("Kitap yazarını girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_kitapTuru.Text == "")
                MessageBox.Show("Kitap türünü girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_kitapYayinevi.Text == "")
                MessageBox.Show("Kitap yayınevini girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (kitapIslemleri.kitapVarMi(txt_kitapNumarasi.Text) != 0)
                MessageBox.Show("Eklemeye çalıştığınız kitaba ait bir kayıt veritabanında mevcut.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            #endregion
            else
            {
                int sonuc = kitapIslemleri.kitapEkle(txt_kitapAdi.Text, txt_kitapNumarasi.Text, txt_kitapYazari.Text, txt_kitapTuru.Text, txt_kitapYayinevi.Text);
                textboxTemizle();
                kitapGoster();
                MessageBox.Show("Kitap kaydı başarıyla tamamlandı.");
            }
        }
        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            //kitapIslemleri nesnesiyle kitap silme metodu çağırılarak silme işlemi gerçekleştiriliyor
            try
            {
                kitapIslemleri.kitapSil(int.Parse(txt_kitapID.Text));
                MessageBox.Show("Silme işlemi gerçekleştirildi :(");
                textboxTemizle();
            }
            catch (Exception err)
            {
                MessageBox.Show("Yanlış bir işlem gerçekleştirmeye çalıştınız.\nHata Mesajı → " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textboxKontrol();
            kitapGoster();
        }
        private void btn_kitapListele_Click(object sender, EventArgs e)
        {
            //kitapGoster fonksiyonu ile öğrenci listelemesi yapılır.
            kitapGoster();
        }
        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            // BL'daki kitapIslemleri sınıfındaki kitapGuncelle fonksiyonu çalıştırılarak kitap bilgileri güncelleme işlemi yapılır.
            try
            {
                int sonuc = kitapIslemleri.kitapGuncelle(int.Parse(txt_kitapID.Text), txt_kitapAdi.Text, txt_kitapNumarasi.Text, txt_kitapYazari.Text, txt_kitapTuru.Text, txt_kitapYayinevi.Text);
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi");
                textboxTemizle();
            }
            catch (Exception err)
            {
                MessageBox.Show("Yanlış bir işlem gerçekleştirmeye çalıştınız.\nHata Mesajı → " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textboxKontrol();
            kitapGoster();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView'de bir satıra tıklandığı zaman gerçekleştirilecek işlemler
            textboxVeriÇekme();
            textboxKontrol();
        }

        #region fonksiyonlar
        private void textboxTemizle()
        {
            //textboxların içerisindeki verileri temizleme fonksiyonu
            txt_kitapID.Clear();
            txt_kitapAdi.Clear();
            txt_kitapNumarasi.Clear();
            txt_kitapTuru.Clear();
            txt_kitapYazari.Clear();
            txt_kitapYayinevi.Clear();
        }
        private void textboxKontrol()
        {
            //bu fonksiyonda textboxların doluluğuna göre btnogrenciekle butonun enabled özelliğini etkinleştirip deaktif ediyoruz.
            if (txt_kitapAdi.Text == "" && txt_kitapNumarasi.Text == "" && txt_kitapTuru.Text == "" &&
               txt_kitapYazari.Text == "" && txt_kitapYayinevi.Text == "")
            {
                btn_kitapEkle.Enabled = true;
                btn_kitapSil.Enabled = false;
            }
            else
            {
                btn_kitapEkle.Enabled = false;
                btn_kitapSil.Enabled = true;
            }
        }
        private void textboxVeriÇekme()
        {           
            //dataGridView'de hangi satıra tıklanıldığı bulunup o satırdaki veriler gerekli textbox kontrollerine aktarılıyor.
            txt_kitapID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_kitapAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_kitapNumarasi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_kitapTuru.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kitapYazari.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_kitapYayinevi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void kitapGoster()
        {
            //kitaplar listesindeki verileri kitapGoster fonkiyonu ile datagridview'e çağırır. 
            List<kitaplar> kitaplar = kitapIslemleri.kitaplariGoster();
            dataGridView1.DataSource = kitaplar;
        }
        #endregion

        private void cmbox_kitapAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            //yer değeri textbox içersindeki seçilen değere eşitlenir.
            yer = cmbox_kitapAra.SelectedItem.ToString();
        }
        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfından kitap_goster fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try
            {
                List<kitaplar> kitaplar2 = kitapIslemleri.kitaplariGoster(txt_kitapAra.Text, yer);
                dataGridView1.DataSource = kitaplar2;                
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }

       

        private void txt_kitapAra_TextChanged(object sender, EventArgs e)
        {
            //txt_kitapAra.Text = "";
        }

        private void kitapSayfasi_Load(object sender, EventArgs e)
        {
            List<kitaplar> kitaplar = kitapIslemleri.kitaplariGoster();
            if (kitaplar != null)
            {
                dataGridView1.DataSource = kitaplar;
            }
        }
    }
}
