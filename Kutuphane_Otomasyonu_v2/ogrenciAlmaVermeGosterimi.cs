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
            databaseRenklendir();
        }

        private void btn_tumKayitlar_Click(object sender, EventArgs e)
        {
            //öğrencilerin daha önce yaptığı kitap alım ve iadeleri datagridview üzerinde gösterilir.
            List<kitapAlmaVerme> ktp1 = islemler.alımIadeGoster();
            dataGridView1.DataSource = ktp1;
            databaseRenklendir();
        }

        public void databaseRenklendir()
        {
            double ceza = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ceza = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                dataGridView1.Rows[i].Cells[5].Value = ceza.ToString("c");
                string islem_turu = dataGridView1.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islem_turu == "iade")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);

                    //eğer iade tarihine 2 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

    }
}
