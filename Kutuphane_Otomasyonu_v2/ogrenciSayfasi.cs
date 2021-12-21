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
using DAL;
using Entity;
using ADOX;

namespace Kutuphane_Otomasyonu_v2
{
    public partial class ogrenciSayfasi : Form
    {
        public ogrenciSayfasi()
        {
            InitializeComponent();
        }
        ogrenciIslem ogrenci_islem = new ogrenciIslem();//Bussiness Layer katmanında bulunan öğrenci işlemleri sınıfından bir nesne oluşturuyoruz.
        private void btn_ogrenciEkle_Click(object sender, EventArgs e)
        {
            #region if-else
            //aşağıdaki if else bloğunda form içerisindeki textboxların kontrolü sağlanmıştır.
            if (txt_adi.Text == "")
                MessageBox.Show("Öğrenci adı girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_bolum.Text == "")
                MessageBox.Show("Öğrenci bölümünü girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_adres.Text == "")
                MessageBox.Show("Öğrenci adresini girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_mail.Text == "")
                MessageBox.Show("Öğrenci mail adresini girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_ogrenciNumarasi.Text == "")
                MessageBox.Show("Öğrenci okul numarasını girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txt_tel.Text == "")
                MessageBox.Show("Öğrenci telefon numarasını girmediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ogrenci_islem.ogrenciVarMi(txt_ogrenciNumarasi.Text) != 0)
                MessageBox.Show("Eklemeye çalıştığınız öğrenciye ait bir kayıt veritabanında mevcut.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                int sonuc = ogrenci_islem.ogr_ekle(txt_adi.Text, txt_bolum.Text, txt_mail.Text, txt_adres.Text, txt_tel.Text, txt_ogrenciNumarasi.Text);
                textboxTemizle();
                ogr_gstr();
                MessageBox.Show("Öğrenci kaydı başarıyla tamamlandı.");
            }
            #endregion
        }
        private void btn_ogrenciListele_Click(object sender, EventArgs e)
        {
            //ogr_gstr fonksiyonu ile öğrenci listelemesi yapılır.
            ogr_gstr();
        }
        private void btn_ogrenciSil_Click(object sender, EventArgs e)
        {
            //ogrenci_islem nesnesiyle ogrenci silme metodu çağırılarak silme işlemi gerçekleştiriliyor
            try
            {
                ogrenci_islem.ogr_sil(int.Parse(txt_ID.Text));
                MessageBox.Show("Silme işlemi gerçekleştirildi :(");
                textboxTemizle();
            }
            catch (Exception err)
            {
                MessageBox.Show("Yanlış bir işlem gerçekleştirmeye çalıştınız.\nHata Mesajı → " + err.Message, "Onay", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textboxKontrol();
            ogr_gstr();
        }
        private void btn_ogrenciAra_Click(object sender, EventArgs e)
        {
            // arama textbox'ındaki metin ogrenciler tablosundan bulunarak listeleniyor.
            List<ogrenciler> ogrenciler = ogrenci_islem.ogrenci_goster(txt_ogrenciAra.Text);
            dataGridView1.DataSource = ogrenciler;
            textboxTemizle();
        }
        private void btn_ogrenciGuncelle_Click(object sender, EventArgs e)
        {
            // BL'daki ogrenci_islem sınıfındaki ogr_guncelle fonksiyonu çalıştırılarak öğrenci güncelleme işlemi yapılır.
            try
            {
                int sonuc = ogrenci_islem.ogr_guncelle(int.Parse(txt_ID.Text), txt_adi.Text, txt_bolum.Text, txt_mail.Text, txt_adres.Text, txt_tel.Text, txt_ogrenciNumarasi.Text);
                MessageBox.Show("Güncelleme İşlemi tamanlanmıştır.");
                textboxTemizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru girdiğinizden emin olun!");
            }
            textboxKontrol();
            ogr_gstr();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView'de bir satıra tıklandığı zaman gerçekleştirilecek işlemler
            textboxVeriÇekme();
            textboxKontrol();
        }
        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt_tel kontrolüne sadece sayı girilmesi tuşa basıldığı anda kontrolü yapılarak sağlanıyor
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_ogrenciNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt_ogrenciNumarasi kontrolüne sadece sayı girilmesi tuşa basıldığı anda kontrolü yapılarak sağlanıyor
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btn_anaEkranaDon_Click(object sender, EventArgs e)
        {
            //anaEkran formunun bir nesnesi oluşturularak oluşturulan nesneyle anaEkrana geçiş sağlandı
            anaEkran frmAnaEkran = new anaEkran();
            frmAnaEkran.Show();
            this.Hide();
        }
        private void ogrenciSayfasi_Load(object sender, EventArgs e)
        {
            List<ogrenciler> ogrenciler = ogrenci_islem.ogrenci_goster();
            if (ogrenciler != null)
            {
                dataGridView1.DataSource = ogrenciler;
            }

        }

        #region fonksiyonlar
        void ogr_gstr()
        {
            //ogrenciler listesindeki verileri ogr_goster fonkiyonu ile datagridview'e çağırır. 
            List<ogrenciler> ogrenciler = ogrenci_islem.ogrenci_goster();
            dataGridView1.DataSource = ogrenciler;
        }
        private void textboxKontrol()
        {
            //bu fonksiyonda textboxların doluluğuna göre btnogrenciekle butonun enabled özelliğini etkinleştirip deaktif ediyoruz.
            if (txt_adi.Text == "" && txt_adres.Text == "" && txt_bolum.Text == "" &&
              txt_mail.Text == "" && txt_tel.Text == "" && txt_ogrenciNumarasi.Text == "")
            {
                btn_ogrenciEkle.Enabled = true;
                btn_ogrenciSil.Enabled = false;
            }
            else
            {
                btn_ogrenciEkle.Enabled = false;
                btn_ogrenciSil.Enabled = true;
            }
        }
        private void textboxTemizle()
        {
            //textboxların içerisindeki verileri temizleme fonksiyonu
            txt_ID.Clear();
            txt_adi.Clear();
            txt_bolum.Clear();
            txt_mail.Clear();
            txt_adres.Clear();
            txt_tel.Clear();
            txt_ogrenciNumarasi.Clear();
            txt_ogrenciAra.Clear();
        }
        private void textboxVeriÇekme()
        {
            //dataGridView'de hangi satıra tıklanıldığı bulunup o satırdaki veriler gerekli textbox kontrollerine aktarılıyor.
            txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_bolum.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_mail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_adres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_tel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_ogrenciNumarasi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        #endregion

    }
}
