using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Entity
{
    public class Kiralama
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public string Tel { get; set; }
        public decimal GunlukUcret { get; set; }
        public DateTime Tarih { get; set; }
    }
}
