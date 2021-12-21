using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class kitaplar
    {
        //Veritabanına kitaplar adındaki tabloya sütun isimlerini tanımlıyoruz.
        public int kitapID { get; set; }
        public string kitapAdi { get; set; }
        public string kitapNumarasi { get; set; }
        public string kitapYazari { get; set; }
        public string kitapTuru { get; set; }
        public string kitapYayinEvi { get; set; }
    }
}
