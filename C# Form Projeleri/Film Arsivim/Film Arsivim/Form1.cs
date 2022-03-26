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

namespace Film_Arsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=FilmArsivim;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Link from Tbl_Filmler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void btnRenkDegis_Click(object sender, EventArgs e)
        {
            
         
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Filmler (Ad,Kategori,Link) values(@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Kayıt Edildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string link = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu porje Oğuzhan Sadıkoğlu Tarafından Yapıldı");
        }
    }
}
