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
    public class Kiralamalar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("KiralamaListele");
        }
        public static bool Ekle(Kiralama entity)
        {

            SqlCommand komut = new SqlCommand("KiralamaEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", entity.ad);
            komut.Parameters.AddWithValue("@syd", entity.soyad);
            komut.Parameters.AddWithValue("@tc", entity.TcKimlikNo);
            komut.Parameters.AddWithValue("@tel", entity.Tel);
            komut.Parameters.AddWithValue("@t", entity.Tarih);
            komut.Parameters.AddWithValue("@g", entity.GunlukUcret);
            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(Kiralama entity)
        {
            SqlCommand komut = new SqlCommand("KiralamaSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Kiralama entity)
        {
            SqlCommand komut = new SqlCommand("KiralamaGuncelle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", entity.ad);
            komut.Parameters.AddWithValue("@syd", entity.soyad);
            komut.Parameters.AddWithValue("@tc", entity.TcKimlikNo);
            komut.Parameters.AddWithValue("@tel", entity.Tel);
            komut.Parameters.AddWithValue("@t", entity.Tarih);
            komut.Parameters.AddWithValue("@g", entity.GunlukUcret);
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}
