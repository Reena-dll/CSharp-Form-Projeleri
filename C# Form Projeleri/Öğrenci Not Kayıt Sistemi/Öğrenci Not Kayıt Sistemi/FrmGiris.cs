using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Ders where OgrNumara=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenciDetay fr = new FrmOgrenciDetay();
                fr.numara = int.Parse(maskedTextBox1.Text);
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara Girdiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBox1.Clear();

            }
            baglanti.Close();

           
        }

  

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FrmOgrtmnDetay fr = new FrmOgrtmnDetay();
                fr.Show();
                this.Hide();
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
