using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu_v2
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void btn_ogrenciIslemleri_Click(object sender, EventArgs e)
        {
            ogrenciSayfasi frmOgrenciSayfasi = new ogrenciSayfasi();
            frmOgrenciSayfasi.Show();
            this.Hide();
        }

        private void btn_kitapIslemleri_Click(object sender, EventArgs e)
        {
            kitapSayfasi frmKitapSayfasi = new kitapSayfasi();
            frmKitapSayfasi.Show();
            this.Hide();
        }

        private void btn_kitapAlmaVerme_Click(object sender, EventArgs e)
        {
            ogrenciKitapAlmaIade frmIade = new ogrenciKitapAlmaIade();
            frmIade.Show();
            this.Hide();
        }

        private void btn_ogrenciAlmaVermeGosterimi_Click(object sender, EventArgs e)
        {
            ogrenciAlmaVermeGosterimi frmOgrenciGoster = new ogrenciAlmaVermeGosterimi();
            frmOgrenciGoster.Show();
            this.Hide();
        }

        private void btn_kitapEmanetIade_Click(object sender, EventArgs e)
        {
            almaVermeGosterim frmAlmaVermeGoster = new almaVermeGosterim();
            frmAlmaVermeGoster.Show();
            this.Hide();
        }

        private void btn_zedgraph_Click(object sender, EventArgs e)
        {
            Grafik frmGrafik = new Grafik();
            frmGrafik.Show();
            this.Hide();
        }
    }
}
