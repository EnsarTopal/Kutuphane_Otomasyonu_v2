using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BL
{
    public class alımIadeIslemleri
    {
        DAL.DAL dataAccess = new DAL.DAL();
        public List<kitapAlmaVerme> alımIadeGoster()
        {
            OleDbDataReader dr = dataAccess.DRVeriCek("Select * from kitapAlmaVerme", CommandType.Text); //DAL katmanı yardımıyla kitapAlmaVerme tablosundaki verilerimizi çekiyoruz.
            if (dr.HasRows)
            {
                List<kitapAlmaVerme> islem_kayit = new List<kitapAlmaVerme>();
                while (dr.Read())
                {
                    //tablodaki verileri çekip yukle listesine ekliyoruz. 
                    kitapAlmaVerme kaydet = new kitapAlmaVerme
                    {
                        kitapId = int.Parse(dr["kitapId"].ToString()),
                        ogrenciId = int.Parse(dr["ogrenciId"].ToString()),
                        alımTarihi = dr["alımTarihi"].ToString(),
                        iadeTarihi = dr["iadeTarihi"].ToString(),
                        geriGetirmeTarihi = dr["geriGetirmeTarihi"].ToString(),
                        borc = (dr["borc"]).ToString(),
                        islemTuru = dr["islemTuru"].ToString()
                    };
                    islem_kayit.Add(kaydet);
                }
                return islem_kayit; //listeyi geri yolluyoruz.
            }
            return null;
        }

        public int iadeTablosuDuzenle(int kitapId, int ogrenciId, double borc)
        {
            //kitapAlmaVerme tablosundaki verileri güncellemek için sorgumuzu gönderiyoruz.
            int Sonuc = dataAccess.EkleSilGuncelle(
                "update kitapAlmaVerme set borc='" + borc + "' where ogrenciId=" + ogrenciId +
                " and kitapId = " + kitapId + "", CommandType.Text);
            return Sonuc;
        }

        public int iadeTablosuDuzenle(int kitapId, int ogrenciId, string islemTuru, string geriGetirmeTarihi)
        {
            //kitapAlmaVerme tablosundaki verileri güncellemek için sorgumuzu gönderiyoruz.
            int Sonuc = dataAccess.EkleSilGuncelle(
                "update kitapAlmaVerme set geriGetirmeTarihi='" + geriGetirmeTarihi +
                "', islemTuru ='" + islemTuru +
                "' where ogrenciId=" + ogrenciId +
                " and kitapId = " + kitapId + "", System.Data.CommandType.Text);
            return Sonuc;
        }

        public List<kitapAlmaVerme> ogrenciKaydiListeleme(int ogrenciNumarasi)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = dataAccess.DRVeriCek("Select * from kitapAlmaVerme where ogrenciId in (select ogrenciId from ogrenciler where ogrenciOkulNumarasi ='" + ogrenciNumarasi + "')", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<kitapAlmaVerme> islem_kayit = new List<kitapAlmaVerme>();
                while (dr.Read())
                {
                    kitapAlmaVerme kaydet = new kitapAlmaVerme
                    {
                        kitapId = int.Parse(dr["kitapId"].ToString()),
                        ogrenciId = int.Parse(dr["ogrenciId"].ToString()),
                        alımTarihi = dr["alımTarihi"].ToString(),
                        iadeTarihi = dr["iadeTarihi"].ToString(),
                        geriGetirmeTarihi = dr["geriGetirmeTarihi"].ToString(),
                        borc = (dr["borc"]).ToString(),
                        islemTuru = dr["islemTuru"].ToString()
                    };
                    islem_kayit.Add(kaydet);
                }
                return islem_kayit;
            }
            return null;
        }

        public int emanetVermeIslemi(int kitapId, int ogrenciId, DateTime alımTarihi, DateTime iadeTarihi, string islemTuru)
        {
            //emanet vermek için kitapAlmaVerme tablosuna gerekli verileri yolluyoruz.
            int Sonuc = dataAccess.EkleSilGuncelle("insert into kitapAlmaVerme " +
                "(kitapId,ogrenciId,alımTarihi,iadeTarihi,islemTuru) values " +
                "(" + kitapId + "," + ogrenciId + ",'" + alımTarihi + "','" + iadeTarihi + "','" + islemTuru + "')", System.Data.CommandType.Text);
            return Sonuc;
        }

        public List<kitapAlmaVerme> ogrenci_emanet_iade_listele(string deger)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = dataAccess.DRVeriCek("Select * from kitapAlmaVerme " +
                "where ogrenciId in (Select ogrenciId from ogrenciler " +
                "where ogrenciOkulNumarasi='" + deger + "')", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<kitapAlmaVerme> islem_kayit = new List<kitapAlmaVerme>();
                while (dr.Read())
                {
                    kitapAlmaVerme kaydet = new kitapAlmaVerme
                    {
                        kitapId = int.Parse(dr["kitapId"].ToString()),
                        ogrenciId = int.Parse(dr["ogrenciId"].ToString()),
                        alımTarihi = dr["alımTarihi"].ToString(),
                        iadeTarihi = dr["iadeTarihi"].ToString(),
                        geriGetirmeTarihi = dr["geriGetirmeTarihi"].ToString(),
                        borc = (dr["borc"]).ToString(),
                        islemTuru = dr["islemTuru"].ToString()
                    };

                    islem_kayit.Add(kaydet);
                }
                return islem_kayit;
            }
            return null;
        }

        public List<kitapAlmaVerme> kitapKaydiListeleme(string deger, string yer)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 

            OleDbDataReader dr = dataAccess.DRVeriCek("Select * from kitapAlmaVerme where kitapId in (Select kitapId from kitaplar where " + yer + " ='" + deger + "')", CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<kitapAlmaVerme> islem_kayit = new List<kitapAlmaVerme>();
                while (dr.Read())
                {
                    kitapAlmaVerme kaydet = new kitapAlmaVerme
                    {
                        kitapId = int.Parse(dr["kitapId"].ToString()),
                        ogrenciId = int.Parse(dr["ogrenciId"].ToString()),
                        alımTarihi = dr["alımTarihi"].ToString(),
                        iadeTarihi = dr["iadeTarihi"].ToString(),
                        geriGetirmeTarihi = dr["geriGetirmeTarihi"].ToString(),
                        borc = dr["borc"].ToString(),
                        islemTuru = dr["islemTuru"].ToString()
                    };
                    islem_kayit.Add(kaydet);
                }
                return islem_kayit;
            }
            return null;
        }

        public DateTime getKitapIadeTarihi(int kitapId)
        {
            OleDbDataReader dr = dataAccess.DRVeriCek("select * from kitapAlmaVerme where kitapId=" + kitapId, CommandType.Text);
            if (dr.HasRows)
            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                kitapAlmaVerme iade = new kitapAlmaVerme();
                while (dr.Read())
                {
                    kitapAlmaVerme kaydet = new kitapAlmaVerme
                    {
                        kitapId = int.Parse(dr["kitapId"].ToString()),
                        ogrenciId = int.Parse(dr["ogrenciId"].ToString()),
                        alımTarihi = dr["alımTarihi"].ToString(),
                        iadeTarihi = dr["iadeTarihi"].ToString(),
                        geriGetirmeTarihi = dr["geriGetirmeTarihi"].ToString(),
                        borc = dr["borc"].ToString(),
                        islemTuru = dr["islemTuru"].ToString()
                    };
                    iade = kaydet;
                }
                return Convert.ToDateTime(iade.iadeTarihi);
            }
            return DateTime.Now;

        }
    }
}
