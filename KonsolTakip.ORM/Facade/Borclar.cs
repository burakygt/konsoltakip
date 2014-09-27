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
    public class Borclar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("BorcListele");
        }
        public static bool Ekle(Borc entity)
        {

            SqlCommand komut = new SqlCommand("BorcEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", entity.ad);
            komut.Parameters.AddWithValue("@soyad", entity.soyad);
            komut.Parameters.AddWithValue("@tel", entity.tel);
            komut.Parameters.AddWithValue("@tutar", entity.tutar);
            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(Borc entity)
        {
            SqlCommand komut = new SqlCommand("BorcSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Borc entity)
        {
            SqlCommand komut = new SqlCommand("BorcGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            komut.Parameters.AddWithValue("@ad", entity.ad);
            komut.Parameters.AddWithValue("@soyad", entity.soyad);
            komut.Parameters.AddWithValue("@tutar", entity.tutar);
            komut.Parameters.AddWithValue("@tel", entity.tel);
            return Araclar.komut_calisma(komut);
        }

    }
}
