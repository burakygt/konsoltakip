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
    public class Tamirler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("TamirListele");
        }
        public static bool Ekle(Tamir entity)
        {

            SqlCommand komut = new SqlCommand("TamirEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@durum", entity.TamirDurum);
            komut.Parameters.AddWithValue("@kimde", entity.Kimde);
            komut.Parameters.AddWithValue("@adres", entity.Adres);
            komut.Parameters.AddWithValue("@tel", entity.Tel);
            komut.Parameters.AddWithValue("@tarih", entity.Tarih);
            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(Tamir entity)
        {
            SqlCommand komut = new SqlCommand("TamirSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Tamir entity)
        {
            SqlCommand komut = new SqlCommand("TamirGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            komut.Parameters.AddWithValue("@durum", entity.TamirDurum);
            komut.Parameters.AddWithValue("@kimde", entity.Kimde);
            komut.Parameters.AddWithValue("@adres", entity.Adres);
            komut.Parameters.AddWithValue("@tel", entity.Tel);
            komut.Parameters.AddWithValue("@tarih", entity.Tarih);
            return Araclar.komut_calisma(komut);
        }
    }
}
