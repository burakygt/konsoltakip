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
    public class Envanterler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("EnvanterListele");
        }
        public static bool Ekle(Envanter entity)
        {

            SqlCommand komut = new SqlCommand("EnvanterEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@cn", entity.CihazNo);
            komut.Parameters.AddWithValue("@cs", entity.CihazSeriNo);
            komut.Parameters.AddWithValue("@cd", entity.CihazDurum);
            komut.Parameters.AddWithValue("@cm", entity.CihazModel);
            komut.Parameters.AddWithValue("@f", entity.Fiyat);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Envanter entity)
        {
            SqlCommand komut = new SqlCommand("EnvanterGuncelle", Araclar.Baglanti);
            komut.Parameters.AddWithValue("@cn", entity.CihazNo);
            komut.Parameters.AddWithValue("@cs", entity.CihazSeriNo);
            komut.Parameters.AddWithValue("@cd", entity.CihazDurum);
            komut.Parameters.AddWithValue("@cm", entity.CihazModel);
            komut.Parameters.AddWithValue("@f", entity.Fiyat);
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(Envanter entity)
        {
            SqlCommand komut = new SqlCommand("EnvanterSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}
