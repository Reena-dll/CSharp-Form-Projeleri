using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbNotKayit;Integrated Security=True");
        public int numara;
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_ders where OgrNumara=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", lblNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2] + " " + dr[3].ToString();
                lblSinav1.Text = dr[4].ToString();
                lblSinav2.Text = dr[5].ToString();
                lblSinav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();
                if (lblDurum.Text=="True")
                {
                    lblDurum.Text = "Geçti";
                }
                else
                {
                    lblDurum.Text = "Kaldı";
                }


            }
            baglanti.Close();
        }
    }
}
