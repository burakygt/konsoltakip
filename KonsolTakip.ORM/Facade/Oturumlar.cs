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
    public class Oturumlar
    {
       public static decimal ToplamTutar = 0;
       public static DataTable Listele()
       {
           return Araclar.Listele("OturumListele");
       }

        public static bool OturumEkle(Oturum entity)
        {

            SqlCommand komut = new SqlCommand("OturumEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@MasaId", entity.MasaId);
            komut.Parameters.AddWithValue("@BaslangicSaati", entity.BaslangicSaati);
            komut.Parameters.AddWithValue("@MasaTutari", entity.MasaTutari);
            komut.Parameters.AddWithValue("@kolSayisi", entity.KolSayisi);
            return Araclar.komut_calisma(komut);
        }
        public static bool OturumKapat(Oturum entity) {

            SqlCommand komut = new SqlCommand("OturumKapat", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@BitisSaati", entity.BitisSaati);
  //          komut.Parameters.AddWithValue("@id", entity.id);
            komut.Parameters.AddWithValue("@MasaId", entity.MasaId);
            return Araclar.komut_calisma(komut);
        
        }
        public static decimal TutarHesabı(Oturum entity) {
            SqlCommand komut = new SqlCommand("TutarHesapla", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            komut.Parameters.AddWithValue("@degisken", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            ToplamTutar =Convert.ToDecimal( komut.Parameters["Sonuc"].Value);
            return ToplamTutar;
        }
        public static bool KolEkle(Oturum entity) {
            SqlCommand komut = new SqlCommand("KolEkle", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.id);
            komut.Parameters.AddWithValue("@KolSayisi", entity.KolSayisi);

            return Araclar.komut_calisma(komut);
        }
        public static bool Toplam(Oturum entity)
        {
            SqlCommand komut = new SqlCommand("OturumToplam", Araclar.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@MasaId", entity.MasaId);
            komut.Parameters.AddWithValue("@MasaTutari", entity.MasaTutari);

            return Araclar.komut_calisma(komut);
        }

        //public static bool AdisyonEkle(Adisyon entity,Oturum durum) {
        //    SqlCommand komut = new SqlCommand("AdisyonOlustur", Araclar.Baglanti);
        //    komut.CommandType = CommandType.StoredProcedure;
        //    komut.Parameters.AddWithValue("@adisyonid",entity.id);
        //}

    }
}
