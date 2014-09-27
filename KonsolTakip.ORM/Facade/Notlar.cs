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
    public class Notlar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("NotListele");
        }
        public static bool Ekle(Not entity)
        {

            SqlCommand komut = new SqlCommand("NotEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@t", entity.tarih);
            komut.Parameters.AddWithValue("@a", entity.aciklama);
            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(Not entity)
        {
            SqlCommand komut = new SqlCommand("NotSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.ID);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Not entity)
        {
            SqlCommand komut = new SqlCommand("NotGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@t", entity.tarih);
            komut.Parameters.AddWithValue("@a", entity.aciklama);
            komut.Parameters.AddWithValue("@id", entity.ID);
            return Araclar.komut_calisma(komut);
        }
    }
}
