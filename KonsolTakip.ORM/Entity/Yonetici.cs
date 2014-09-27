using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Entity
{
   public class Yonetici
    {
        public int id { get; set; }
        public string kullanici { get; set; }
        public string sifre { get; set; }
        public string tur { get; set; }
        
    }
}
