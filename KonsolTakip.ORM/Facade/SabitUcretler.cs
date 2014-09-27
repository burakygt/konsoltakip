using KonsolTakip.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM.Facade
{
    public class SabitUcretler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("UcretListele");
        }

        public static bool UcretKaydet(SabitUcret entity) {

            SqlCommand komut = new SqlCommand("UcretKaydet",Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@saat", entity.saat);
            komut.Parameters.AddWithValue("@dk15", entity.dk15);
            komut.Parameters.AddWithValue("@dk30", entity.dk30);
            komut.Parameters.AddWithValue("@dk45", entity.dk45);
            return Araclar.komut_calisma(komut);
            

        }
    }
}
