using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Entity
{
    public class KafeBilgi
    {
        public int id { get; set; }
        public string KafeAdı { get; set; }
        public string Sehir { get; set; }
        public string Tel { get; set; }
        public int MakineSayisi { get; set; }
        

    }
}
