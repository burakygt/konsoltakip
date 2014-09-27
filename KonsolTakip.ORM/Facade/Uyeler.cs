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
    public class Uyeler
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("UyeListele");
        }
        public static bool Ekle(Uye entity)
        {

            SqlCommand komut = new SqlCommand("UyeEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", entity.ad);
            komut.Parameters.AddWithValue("@soyad", entity.soyad);
            komut.Parameters.AddWithValue("@tel", entity.tel);
            komut.Parameters.AddWithValue("@mail", entity.mail);
            komut.Parameters.AddWithValue("@adres", entity.adres);
            komut.Parameters.AddWithValue("@ucret", entity.ucret);
            komut.Parameters.AddWithValue("@sure", entity.sure);


            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(Uye entity)
        {
            SqlCommand komut = new SqlCommand("UyeSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Uye entity)
        {
            SqlCommand komut = new SqlCommand("UyeGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", entity.ad);
            komut.Parameters.AddWithValue("@soyad", entity.soyad);
            komut.Parameters.AddWithValue("@tel", entity.tel);
            komut.Parameters.AddWithValue("@mail", entity.mail);
            komut.Parameters.AddWithValue("@adres", entity.adres);
            komut.Parameters.AddWithValue("@ucret", entity.ucret);
            komut.Parameters.AddWithValue("@sure", entity.sure);
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}
