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
    public class Adisyonlar
    {
        public static DataTable Listele()
        {
            return Araclar.Listele("AdisyonListele");
        }
        public static bool Ekle(Adisyon entity)
        {

            SqlCommand komut = new SqlCommand("AdisyonEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ua", entity.UrunAdi);
            komut.Parameters.AddWithValue("@uk", entity.UrunKodu);
            komut.Parameters.AddWithValue("@uadet", entity.Adet);
            komut.Parameters.AddWithValue("@f", entity.Fiyat);
            return Araclar.komut_calisma(komut);
        }
        public static bool Guncelle(Adisyon entity)
        {
            SqlCommand komut = new SqlCommand("AdisyonGuncelle", Araclar.Baglanti);
            komut.Parameters.AddWithValue("@ua", entity.UrunAdi);
            komut.Parameters.AddWithValue("@uk", entity.UrunKodu);
            komut.Parameters.AddWithValue("@uadet", entity.Adet);
            komut.Parameters.AddWithValue("@f", entity.Fiyat);
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
        public static bool Sil(Adisyon entity)
        {
            SqlCommand komut = new SqlCommand("AdisyonSil", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            return Araclar.komut_calisma(komut);
        }
    }
}
