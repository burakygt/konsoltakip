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
   public class Yoneticiler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("YoneticiListele");
        }
        public static bool Ekle(Yonetici entity)
        {

            SqlCommand komut = new SqlCommand("YoneticiEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kullanici", entity.kullanici);
            komut.Parameters.AddWithValue("@sifre", entity.sifre);
            komut.Parameters.AddWithValue("@tur", entity.tur);
            
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Yonetici entity)
        {
            SqlCommand komut = new SqlCommand("YoneticiGuncelle", Araclar.Baglanti);
            komut.Parameters.AddWithValue("@kullanici", entity.kullanici);
            komut.Parameters.AddWithValue("@sifre", entity.sifre);
            komut.Parameters.AddWithValue("@tur", entity.tur);
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(Yonetici entity)
        {
            SqlCommand komut = new SqlCommand("YoneticiSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}
