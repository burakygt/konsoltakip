﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolTakip.ORM
{
    class Araclar
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Konsol_Baglanti"].ConnectionString);


        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }
        }
        public static bool komut_calisma(SqlCommand komut)
        {

            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();
                return komut.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State != ConnectionState.Closed)
                    komut.Connection.Close();
            }
        }
        public static DataTable Listele(string procedureAdi)
        {
            SqlDataAdapter adp = new SqlDataAdapter(procedureAdi, Araclar.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
         
            adp.Fill(dt);
            return dt;

        }
    }
}
