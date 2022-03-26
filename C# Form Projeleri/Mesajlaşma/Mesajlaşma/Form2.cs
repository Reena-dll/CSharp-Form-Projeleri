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

namespace Mesajlaşma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Mesaj;Integrated Security=True");

        void gelenkutusu()
        {
            

             SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_mesajlar where alici="+numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView3.DataSource = dt1;
            
        }

        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tbl_mesajlar where Gonderen=" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView4.DataSource = dt2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gelenkutusu();
            gidenkutusu();

            baglanti.Open();
            lblNumara.Text = numara;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kisiler where Numara=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_mesajlar (gonderen,alici,baslik,icerik) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.Parameters.AddWithValue("@p4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız Gönderildi.");

            maskedTextBox1.Clear();
            textBox1.Clear();
            richTextBox1.Clear();
            gelenkutusu();
            gidenkutusu();

        }
    }
}
