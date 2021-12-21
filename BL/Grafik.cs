using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.OleDb;    
namespace BL
{
    public class Grafik
    {
        DAL.DAL dl = new DAL.DAL();
        public int listele()
        {
            //veritabanından kitap sayılarını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;
            OleDbDataReader dr = dl.DRVeriCek("Select kitapId from kitaplar", CommandType.Text);
            if (dr.HasRows)
            {
                List<kitaplar> kitaplar = new List<kitaplar>();
                while (dr.Read())
                {
                    sayac++;
                }
                return sayac;
            }

            return 0;
        }
        public int alma()
        {
            //veritabanında işlem türü alım olan verilerin sayısını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;
            OleDbDataReader dr = dl.DRVeriCek("Select * from kitapAlmaVerme where islemTuru='" + "emanetVerme" + "'", CommandType.Text);
            if (dr.HasRows)
            {
                List<kitaplar> kitaplar = new List<kitaplar>();
                while (dr.Read())
                {
                    sayac++;
                }
                return sayac;
            }

            return 0;
        }

    }
}
