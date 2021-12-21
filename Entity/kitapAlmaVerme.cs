using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class kitapAlmaVerme
    {
        public int kitapId { get; set; }
        public int ogrenciId { get; set; }
        public string alımTarihi { get; set; }
        public string iadeTarihi { get; set; }
        public string geriGetirmeTarihi { get; set; }
        public string borc { get; set; }
        public string islemTuru { get; set; }
    }
}
