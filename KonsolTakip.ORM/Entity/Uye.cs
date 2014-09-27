using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Entity
{
    public class Uye
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public string adres { get; set; }
        public int ucret { get; set; }
        public int sure { get; set; }


    }
}
