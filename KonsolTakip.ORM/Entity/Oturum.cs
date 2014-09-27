using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Entity
{
    public class Oturum
    {
        public int id { get; set; }
        public int MasaId { get; set; }
        public string BaslangicSaati { get; set; }
        public string BitisSaati { get; set; }
        public float AdisyonTutari { get; set; }
        public float MasaTutari { get; set; }
        public int KolSayisi { get; set; }
    }
}
