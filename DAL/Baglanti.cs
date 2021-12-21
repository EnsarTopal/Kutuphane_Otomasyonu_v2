using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class Baglanti
    { //veritabanı bağlantımızı kontrol açmak için bu yapıyı kullanıyoruz.
        OleDbConnection baglanti;
        public OleDbConnection ConnectionString
        {
            get
            {
                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    return baglanti;
                }
                else
                {
                    baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:Kutuphane_Otomasyonu.mdb");
                    if (baglanti.State == ConnectionState.Closed)
                    {
                            baglanti.Open();
                    }
                    return baglanti;
                }
            }
        }
    }
}