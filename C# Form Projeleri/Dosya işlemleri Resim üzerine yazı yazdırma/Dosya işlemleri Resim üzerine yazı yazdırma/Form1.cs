using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_işlemleri_Resim_üzerine_yazı_yazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string resim;

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }

        Color renk;
        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Bitmap bmp;

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(txtMetin.Text, new Font("Arial", Convert.ToInt32(txtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
            pictureBox1.Image = bmp;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim| .jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
