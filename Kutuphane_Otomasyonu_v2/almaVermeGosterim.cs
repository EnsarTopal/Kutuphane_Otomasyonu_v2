using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BL;

namespace Kutuphane_Otomasyonu_v2
{
    public partial class almaVermeGosterim : Form
    {
        public almaVermeGosterim()
        {
            InitializeComponent();
        }
        alımIadeIslemleri islemler = new alımIadeIslemleri();
        string konum = "";
        kitapIslem kitapIslem = new kitapIslem();
        private void btn_iadeKitapAra_Click(object sender, EventArgs e)
        {
            //arama fonksiyonunda sorgu yapıp dönen liste değerlerini datagridview'e ekliyoruz.
            try
            {
                string konum = " ";
                konum = cmbBox_iadeKitapAra.SelectedItem.ToString();
                List<kitapAlmaVerme> kayit_cekme = islemler.kitapKaydiListeleme(txt_iadeKitap.Text, konum);
                dgv_IadeKitap.DataSource = kayit_cekme;
                MessageBox.Show("Arama başarılı!");
            }
            //eğer arama bölümü boş veya geçersiz ise hata mesajı veriyoruz.
            catch (Exception)
            {
                MessageBox.Show("Giriş değerlerini kontrol ediniz!");
            }
        }

        private void btn_ana_Click(object sender, EventArgs e)
        {
            anaEkran frmAna = new anaEkran();
            frmAna.Show();
            this.Hide();

        }
        private void cmBox_kitapAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            konum = cmBox_kitapAra.SelectedItem.ToString();
        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfından kitap_goster fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try
            {
                List<kitaplar> kitap = kitapIslem.kitaplariGoster(txt_kitap.Text, konum);
                dgv_kitap.DataSource = kitap;
                MessageBox.Show("Arama tamamlandı listeden kontrol ediniz.");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }

        private void btn_tumKitaplar_Click(object sender, EventArgs e)
        {
            //veritabanından almaverme'deki tüm verileri çekip datagridview'e yazıyoruz.
            List<kitapAlmaVerme> kitap = islemler.alımIadeGoster();
            dgv_IadeKitap.DataSource = kitap;
            MessageBox.Show("Kayıt gösterme Başarılı!");
        }
    }
}
