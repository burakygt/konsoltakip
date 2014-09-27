using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Entity
{
    public class Tamir
    {
        public int id { get; set; }
        public int TamirDurum { get; set; }
        public string Kimde { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public DateTime Tarih { get; set; }


    }
}
