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
    public class kitapIslem
    {
        DAL.DAL data = new DAL.DAL();
        public List<kitaplar> kitaplariGoster()
        {
            //veritabanından öğrenciler tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = data.DRVeriCek("SELECT * FROM kitaplar", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<kitaplar> kitaplar = new List<kitaplar>();
                while (dr.Read())
                {
                    kitaplar kitap = new kitaplar
                    {
                        kitapID = int.Parse(dr["kitapID"].ToString()),
                        kitapAdi = dr["kitapAdi"].ToString(),
                        kitapNumarasi = dr["kitapNumarasi"].ToString(),
                        kitapYazari = dr["kitapYazari"].ToString(),
                        kitapTuru = dr["kitapTuru"].ToString(),
                        kitapYayinEvi = dr["kitapYayinEvi"].ToString()
                    };
                    kitaplar.Add(kitap);
                }
                return kitaplar;
            }
            return null;
        }
        public List<kitaplar> kitaplariGoster(string deger, string yer)
        {
            //veritabanından öğrenciler tablosundaki değerleri öğrencinin okul numarasına göre çekiyoruz.
            OleDbDataReader dr = data.DRVeriCek("SELECT * FROM kitaplar WHERE " + yer + " = '" + deger + "'", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<kitaplar> kitaplar = new List<kitaplar>();
                while (dr.Read())
                {
                    kitaplar kitap = new kitaplar
                    {
                        kitapID = int.Parse(dr["kitapID"].ToString()),
                        kitapAdi = dr["kitapAdi"].ToString(),
                        kitapNumarasi = dr["kitapNumarasi"].ToString(),
                        kitapYazari = dr["kitapYazari"].ToString(),
                        kitapTuru = dr["kitapTuru"].ToString(),
                        kitapYayinEvi = dr["kitapYayinEvi"].ToString()
                    };
                    kitaplar.Add(kitap);
                }
                return kitaplar;
            }
            return null;
        }
        public int kitapEkle(string kitapAdi, string kitapNumarasi, string kitapYazari, string kitapTuru, string kitapYayinEvi)
        {
            //kitap eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data.EkleSilGuncelle("INSERT into kitaplar (kitapAdi,kitapNumarasi,kitapYazari,kitapTuru,kitapYayinEvi) VALUES ('" + kitapAdi + "','" + kitapNumarasi + "','" + kitapYazari + "','" + kitapTuru + "','" + kitapYayinEvi + "')", System.Data.CommandType.Text);
            return sonuc;
        }
        public int kitapGuncelle(int kitapID, string kitapAdi, string kitapNumarasi, string kitapYazari, string kitapTuru, string kitapYayinEvi)
        {
            //Kitabı güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data.EkleSilGuncelle("UPDATE kitaplar SET " +
                "kitapAdi='" + kitapAdi +
                "', kitapNumarasi='" + kitapNumarasi +
                "', kitapYazari='" + kitapYazari +
                "', kitapTuru='" + kitapTuru +
                "', kitapYayinEvi='" + kitapYayinEvi +
                "' WHERE kitapID=" + kitapID + "", System.Data.CommandType.Text);
            return sonuc;
        }
        public int kitapSil(int kitapID)
        {
            //Kitabı silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data.EkleSilGuncelle("DELETE from kitaplar where kitapID =" +
                kitapID + "", System.Data.CommandType.Text);
            return sonuc;
        }
        public int kitapVarMi(string aranan)
        {
            Baglanti baglanti = new Baglanti();
            OleDbCommand komut;
            int sonuc;
            string sorgu = "Select COUNT(kitapNumarasi) from kitaplar WHERE kitapNumarasi='" + aranan + "'";
            komut = new OleDbCommand(sorgu, baglanti.ConnectionString);
            sonuc = Convert.ToInt32(komut.ExecuteScalar());
            return sonuc;
        }
    }
}
