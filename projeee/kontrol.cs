using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeee
{
    internal class kontrol
    {
        string con = "Server=localhost;Database=proje;Uid=root;Pwd='';";
        public int giris(string tc, string sf)
        {
            int sonuc = 0;

            using (var baglan = new MySqlConnection(con))
            {
                using (var komut = new MySqlCommand($"SELECT tc,sf FROM kullanici WHERE tc='{tc}' AND sf='{sf}'", baglan))
                {

                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dr = komut.ExecuteReader();
                        if (dr.Read())
                        {
                            string t = dr["tc"].ToString();
                            string s = dr["sf"].ToString();
                            if (t == tc && s == sf)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }
                        }
                    }
                    catch (System.Exception)
                    {

                        sonuc = 0;
                    }

                }
            }
            return sonuc;
        }
    }
}
