using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Entity
{
    public class Envanter
    {
        public int id { get; set; }
        public int CihazNo { get; set; }
        public string CihazSeriNo { get; set; }
        public string CihazDurum { get; set; }
        public string CihazModel { get; set; }
        public int Fiyat { get; set; }



    }
}
