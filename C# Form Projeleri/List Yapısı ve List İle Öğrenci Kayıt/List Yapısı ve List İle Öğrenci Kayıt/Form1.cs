using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Yapısı_ve_List_İle_Öğrenci_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("Oğuzhan");
            karakterler.Add("Ruhsar");
            karakterler.Add("Mahzar");
            karakterler.Add("Menkıbe");
            karakterler.Add("Müfit");
            karakterler.Add("Reyhan");
            karakterler.Add("Firdevs");

            karakterler.Remove(karakterler[4]);
            foreach (string k in karakterler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(74);
            sayilar.Add(25);
            sayilar.Add(33);
            sayilar.Add(22);
            sayilar.Add(15);
            sayilar.Add(14);



            foreach (int s in sayilar)
            {
                if (s%5==0)
                {
                    listBox2.Items.Add(s);
                }
                
            }

            if (sayilar.Contains(74))
            {
                MessageBox.Show("Bu Sayı Var");
            }
            else
            {
                MessageBox.Show("Bu Sayı Yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();
            kisi.Add(new Kisiler()
            {
                ADI = "Ali",
                SOYADI = "Sadık",
                MESLEKI = "Öğretmen"
            });

            foreach (Kisiler y in kisi)
            {
                listBox3.Items.Add(y.ADI+" "+y.SOYADI+" "+y.MESLEKI);
            }
        }
    }
}
