using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Facade
{
    public class KafeBilgiler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("KafeBilgiListele");
        }
    }
    
        
}
