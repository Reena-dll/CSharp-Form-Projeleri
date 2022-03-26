using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İki_Boyutlu_Nesneleri_Form_Üzerinde_Hareketleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top<=35)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left>=787)
            {
                timer2.Stop();
                timer3.Start();

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top>=558)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <=60)
            {
                timer4.Stop();
                timer1.Start();
            }
        }
    }
}
