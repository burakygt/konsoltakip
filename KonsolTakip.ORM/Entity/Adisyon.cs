using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Entity
{
   
        public class Adisyon
        {
            public int id { get; set; }
            public string UrunAdi { get; set; }
            public string UrunKodu { get; set; }
            public decimal Fiyat { get; set; }
            public int Adet { get; set; }
        }
    
}
