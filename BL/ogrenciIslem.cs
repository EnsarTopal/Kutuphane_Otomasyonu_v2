using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entity;
using DAL;
namespace BL
{
    public class ogrenciIslem
    {
        DAL.DAL data = new DAL.DAL();
        public List<ogrenciler> ogrenci_goster()
        {
            //veritabanından öğrenciler tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = data.DRVeriCek("SELECT * FROM ogrenciler", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<ogrenciler> ogrenciler1 = new List<ogrenciler>();
                while (dr.Read())
                {
                    ogrenciler ogrnci = new ogrenciler
                    {
                        ogrenciID = int.Parse(dr["ogrenciID"].ToString()),
                        ogrenciAdi = dr["ogrenciAdi"].ToString(),
                        ogrenciBolum = dr["ogrenciBolum"].ToString(),
                        ogrenciMail = dr["ogrenciMail"].ToString(),
                        ogrenciAdres = dr["ogrenciAdres"].ToString(),
                        ogrenciTelNo = dr["ogrenciTelNo"].ToString(),
                        ogrenciOkulNumarasi = dr["ogrenciOkulNumarasi"].ToString()
                    };
                    ogrenciler1.Add(ogrnci);
                }
                return ogrenciler1;
            }
            return null;
        }
        public List<ogrenciler> ogrenci_goster(string ogrenciOkulNumarasi)
        {
            //veritabanından öğrenciler tablosundaki değerleri öğrencinin okul numarasına göre çekiyoruz.
            OleDbDataReader dr = data.DRVeriCek("SELECT * FROM ogrenciler WHERE ogrenciOkulNumarasi='" +
                ogrenciOkulNumarasi + "'", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<ogrenciler> ogrenciler1 = new List<ogrenciler>();
                while (dr.Read())
                {
                    ogrenciler ogrnci = new ogrenciler
                    {
                        ogrenciID = int.Parse(dr["ogrenciID"].ToString()),
                        ogrenciAdi = dr["ogrenciAdi"].ToString(),
                        ogrenciBolum = dr["ogrenciBolum"].ToString(),
                        ogrenciMail = dr["ogrenciMail"].ToString(),
                        ogrenciAdres = dr["ogrenciAdres"].ToString(),
                        ogrenciTelNo = dr["ogrenciTelNo"].ToString(),
                        ogrenciOkulNumarasi = dr["ogrenciOkulNumarasi"].ToString()
                    };
                    ogrenciler1.Add(ogrnci);
                }
                return ogrenciler1;
            }
            return null;
        }
        public int ogr_ekle(string ogrenciAdi, string ogrenciBolum, string ogrenciMail, string ogrenciAdres, string ogrenciTelNo, string ogrenciOkulNumarasi)
        {
            //öğrenci eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data.EkleSilGuncelle("INSERT into ogrenciler (ogrenciAdi,ogrenciBolum,ogrenciMail,ogrenciAdres,ogrenciTelNo,ogrenciOkulNumarasi) VALUES ('" + ogrenciAdi + "','" + ogrenciBolum + "','" + ogrenciMail + "','" + ogrenciAdres + "','" + ogrenciTelNo + "','" + ogrenciOkulNumarasi + "')", System.Data.CommandType.Text);
            return sonuc;
        }
        public int ogr_guncelle(int ogrenciID, string ogrenciAdi, string ogrenciBolum, string ogrenciMail, string ogrenciAdres, string ogrenciTelNo, string ogrenciOkulNumarasi)
        {
            //öğrenci güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data.EkleSilGuncelle("UPDATE ogrenciler SET " +
                "ogrenciAdi='" + ogrenciAdi +
                "', ogrenciTelNo='" + ogrenciTelNo +
                "', ogrenciOkulNumarasi='" + ogrenciOkulNumarasi +
                "', ogrenciBolum='" + ogrenciBolum +
                "', ogrenciMail='" + ogrenciMail +
                "', ogrenciAdres='" + ogrenciAdres +
                "' WHERE ogrenciID=" + ogrenciID + "", System.Data.CommandType.Text);
            return sonuc;
        }
        public int ogr_sil(int ogrenciID)
        {
            //öğrenciyi silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data.EkleSilGuncelle("DELETE from ogrenciler where ogrenciID =" +
                ogrenciID + "", System.Data.CommandType.Text);
            return sonuc;
        }
        //aşağıdaki fonksiyonda veritabanında öğrenci numarası daha önce eklenmiş olan verinin olup olmadığı
        //kontrol ediliyor
        public int ogrenciVarMi(string aranan)
        {
            Baglanti baglanti = new Baglanti();
            OleDbCommand komut;
            int sonuc;
            string sorgu = "Select COUNT(ogrenciOkulNumarasi) from ogrenciler WHERE ogrenciOkulNumarasi='" + aranan + "'";
            komut = new OleDbCommand(sorgu, baglanti.ConnectionString);
            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            return sonuc;
        }
    }
}
