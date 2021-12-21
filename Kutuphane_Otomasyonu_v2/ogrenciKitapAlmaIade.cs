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
using DAL;
using BL;

namespace Kutuphane_Otomasyonu_v2
{
    public partial class ogrenciKitapAlmaIade : Form
    {
        public ogrenciKitapAlmaIade()
        {
            InitializeComponent();
        }
        string konum = "";
        alımIadeIslemleri islemler = new alımIadeIslemleri();
        ogrenciIslem ogrIslem = new ogrenciIslem();
        kitapIslem ktpIslem = new kitapIslem();
        private void btn_anaSayfa_Click(object sender, EventArgs e)
        {
            anaEkran frmAna = new anaEkran();
            frmAna.Show();
            this.Hide();
        }
        private void btn_ogrenciArama_Click(object sender, EventArgs e)
        {
            //öğrenci tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<ogrenciler> ogr = ogrIslem.ogrenci_goster(txt_ogrenciArama.Text);
                dgv_ogrenciListesi.DataSource = ogr;
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz girdi!");
            }
        }
        private void btn_kitapArama_Click(object sender, EventArgs e)
        {
            //kitap tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<kitaplar> ktp = ktpIslem.kitaplariGoster(txt_kitapBilgisi.Text, konum);
                dgvKitapListesi.DataSource = ktp;
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Bulunamadı!");
            }
        }
        private void btn_emanetVer_Click(object sender, EventArgs e)
        {
        //    dTP_emanetVerilenTarih.Value = DateTime.Now;

            //emanetVermeIslemi fonksiyonuna gerekli parametreleri göndererek emanet verme işlemini yapıyoruz.
            try
            {
                int Sonuc = islemler.emanetVermeIslemi(
                    int.Parse(txt_kitapId.Text),
                    int.Parse(txt_ogrenciID.Text),
                    DateTime.Parse(dTP_emanetVerilenTarih.Text),
                    DateTime.Parse(txt_geriGetirilmesiGerekenTarih.Text),
                    "emanetVerme");
                MessageBox.Show("Emanet verme işlemi başarılı!");
            }
            catch (Exception err)
            {
                // MessageBox.Show("Emanet işlemi için lütfen alanları doldurunuz!");
                MessageBox.Show(err.Message);
            }
        }
        private void cmboxKitapKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            konum = cmboxKitapKategori.SelectedItem.ToString();
        }
        private void ogrenciKitapAlmaIade_Load(object sender, EventArgs e)
        {
            txt_geriGetirilmesiGerekenTarih.Text = DateTime.Now.AddDays(30).ToShortDateString();
        }
        private void btn_kitapEmanetListesi_Click(object sender, EventArgs e)
        {
            //kitapAlmaVerme tablosundaki verileri datagridview'e yüklemek için bu fonksiyonu kullanıyoruz.
            listele();
            // emanet_ve_iade_renk();
        }
        private void btn_iadeOgrenciArama_Click_1(object sender, EventArgs e)
        {
            //öğrenci tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<kitapAlmaVerme> kitapListele = islemler.ogrenciKaydiListeleme(int.Parse(txt_iadeOgrenci.Text));
                dgv_emanetListesi.DataSource = kitapListele;

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Bulunamadı!");
            }
        }
        private void btn_iadeKitapAra_Click_1(object sender, EventArgs e)
        {

            //kitap tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                string konum = " ";
                konum = cmboxIadeKitapKategori.SelectedItem.ToString();
                List<kitapAlmaVerme> kayit = islemler.kitapKaydiListeleme(txt_IadeKitapBilgi.Text, konum);
                dgv_emanetListesi.DataSource = kayit;
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }
        private void btn_iadeEt_Click(object sender, EventArgs e)
        {
            kitapAlmaVerme kitap = new kitapAlmaVerme();
            //txt_iadeEdilenTarih.Text = DateTime.Now.ToShortDateString();
            /*
            DateTime geriGelenTarih = Convert.ToDateTime(txt_iadeEdilenTarih.Text);
            DateTime iadegelentarih = Convert.ToDateTime(kitap.iadeTarihi);
            TimeSpan sonuc = geriGelenTarih - iadegelentarih;
            if (sonuc.TotalDays >= 0) //zaman farkını eksi olamaması kontrol edildi
            {
                //Burayı sonra yap!!!//listeRenklendirme();  // tablo satırları renklendirildi
                if (sonuc.TotalDays > 5)  // teslim süresi 5 günü geçmiş ise ceza işlemi uygulandı
                {
                    float ceza = float.Parse(sonuc.TotalDays.ToString()) - 15;  //15 gün teslim süresini aşanlara hergün için 1 tl kesildi
                    float iade = Convert.ToInt32(kitap.borc); //Ceza bilgisi çekildi
                    iade += ceza; //üzerine ekleme yapıldı     
                    islemler.iadeTablosuDuzenle(iade);
                    MessageBox.Show("iade → " + iade + "ceza → " + ceza);
                }
                MessageBox.Show("Teslim edildi");
            }
            else
            {
                MessageBox.Show("Teslim tarihi alım tarihinden önce olamaz!");
            }
            */
            //tablo_iade_duzenleme fonksiyonuna gerekli parametreleri göndererek iade etme işlemini yapıyoruz. 
            try
            {
                int Sonuc = islemler.iadeTablosuDuzenle
                    (
                    int.Parse(txt_iadeKitapId.Text),
                    int.Parse(txt_iadeOgrenciId.Text),
                    "iade", txt_iadeEdilenTarih.Text
                    );
                MessageBox.Show("İade başarılı!");
            }
            catch
            {
                MessageBox.Show("İade işlemi için lütfen alanları doldurunuz!");
            } //teslim işlemi gerçekleştirildi
            listele();

        }
        private void dgv_emanetListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView'de hangi satıra tıklanıldığı bulunup o satırdaki veriler gerekli textbox kontrollerine aktarılıyor.
            txt_iadeKitapId.Text = dgv_emanetListesi.CurrentRow.Cells[0].Value.ToString();
            txt_iadeOgrenciId.Text = dgv_emanetListesi.CurrentRow.Cells[1].Value.ToString();
            txt_iadeEdilenTarih.Text = dgv_emanetListesi.CurrentRow.Cells[4].Value.ToString();
        }
        void listele()
        {
            List<kitapAlmaVerme> listele = islemler.alımIadeGoster();
            dgv_emanetListesi.DataSource = listele;
        }
        public void emanet_ve_iade_renk()
        {
            double ceza = 0;
            for (int i = 0; i < dgv_emanetListesi.Rows.Count; i++)
            {
                ceza = double.Parse(dgv_emanetListesi.Rows[i].Cells[5].Value.ToString());
                dgv_emanetListesi.Rows[i].Cells[5].Value = ceza.ToString("c");
                string islemTuru = dgv_emanetListesi.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islemTuru == "iade")
                {
                    dgv_emanetListesi.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgv_emanetListesi.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islemTuru != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime iadeTarihi = DateTime.Parse(dgv_emanetListesi.Rows[i].Cells[3].Value.ToString());
                    t2 = iadeTarihi.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    //eğer iade tarihine 2 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dgv_emanetListesi.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dgv_emanetListesi.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dgv_emanetListesi.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgv_emanetListesi.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }


    }
}
