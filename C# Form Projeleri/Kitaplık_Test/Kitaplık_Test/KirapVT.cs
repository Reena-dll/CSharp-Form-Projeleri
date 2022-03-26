using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kitaplık_Test

    
{
    class KirapVT
    {
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Kitaplık_Test;Integrated Security=True");
        public List<Kitap> Liste()
        {
            List<Kitap> ktp = new List<Kitap>();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kitaplar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt16(dr[0].ToString());
                k.ADI = dr[1].ToString();
                k.YAZARI = dr[2].ToString();

                ktp.Add(k);
            }
            baglanti.Close();
            return ktp;
        }

        public void KitapEkle(Kitap kt)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitaplar (KitapAd,yazar) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.ADI);
            komut.Parameters.AddWithValue("@p2", kt.YAZARI);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
