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
    public partial class ogrenciAlmaVermeGosterimi : Form
    {
        public ogrenciAlmaVermeGosterimi()
        {
            InitializeComponent();
        }
        alımIadeIslemleri islemler = new alımIadeIslemleri();
        private void btn_anaSayfa_Click(object sender, EventArgs e)
        {
            //anaEkran formunun bir nesnesi oluşturularak oluşturulan nesneyle anaEkrana geçiş sağlandı
            anaEkran frmAna = new anaEkran();
            frmAna.Show();
            this.Hide();
        }

        private void btn_ogrenciAra_Click(object sender, EventArgs e)
        {
            //BL'daki iade_alim_islemleri sınıfından ogrenci_emanet_iade_listele fanksiyonu
            //çalıştırılıp arama textbox içindeki veri tablodan çağırılıp datagridview üzerinden
            //gösterilir.
            List<kitapAlmaVerme> arama = islemler.ogrenci_emanet_iade_listele(txt_ogrenciAra.Text);
            dataGridView1.DataSource = arama;
        }

        private void btn_tumKayitlar_Click(object sender, EventArgs e)
        {
            //öğrencilerin daha önce yaptığı kitap alım ve iadeleri datagridview üzerinde gösterilir.
            List<kitapAlmaVerme> ktp1 = islemler.alımIadeGoster();
            dataGridView1.DataSource = ktp1;
        }

        private void ogrenciAlmaVermeGosterimi_Load(object sender, EventArgs e)
        {

        }
    }
}
