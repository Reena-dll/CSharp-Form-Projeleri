namespace Öğrenci_Etüt_ve_Ders_Kayıt_Sistemi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEtutOlustur = new System.Windows.Forms.Button();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOgretmen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEtutver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtOgrenci = new System.Windows.Forms.TextBox();
            this.txtEtutId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOgretmenEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtutOlustur);
            this.groupBox1.Controls.Add(this.mskSaat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbOgretmen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskTarih);
            this.groupBox1.Controls.Add(this.cmbDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEtutOlustur
            // 
            this.btnEtutOlustur.Location = new System.Drawing.Point(147, 213);
            this.btnEtutOlustur.Name = "btnEtutOlustur";
            this.btnEtutOlustur.Size = new System.Drawing.Size(140, 43);
            this.btnEtutOlustur.TabIndex = 10;
            this.btnEtutOlustur.Text = "Etüt Oluştur";
            this.btnEtutOlustur.UseVisualStyleBackColor = true;
            this.btnEtutOlustur.Click += new System.EventHandler(this.btnEtutOlustur_Click);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(106, 175);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(218, 26);
            this.mskSaat.TabIndex = 9;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saat:";
            // 
            // cmbOgretmen
            // 
            this.cmbOgretmen.FormattingEnabled = true;
            this.cmbOgretmen.Location = new System.Drawing.Point(106, 80);
            this.cmbOgretmen.Name = "cmbOgretmen";
            this.cmbOgretmen.Size = new System.Drawing.Size(218, 27);
            this.cmbOgretmen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğretmen:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(106, 138);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(218, 26);
            this.mskTarih.TabIndex = 3;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(106, 48);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(218, 27);
            this.cmbDers.TabIndex = 2;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.cmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEtutId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOgrenci);
            this.groupBox2.Controls.Add(this.btnEtutver);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(432, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnEtutver
            // 
            this.btnEtutver.Location = new System.Drawing.Point(126, 107);
            this.btnEtutver.Name = "btnEtutver";
            this.btnEtutver.Size = new System.Drawing.Size(124, 43);
            this.btnEtutver.TabIndex = 15;
            this.btnEtutver.Text = "Etüt Ver";
            this.btnEtutver.UseVisualStyleBackColor = true;
            this.btnEtutver.Click += new System.EventHandler(this.btnEtutver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(25, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1051, 294);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(102, 73);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(174, 26);
            this.txtOgrenci.TabIndex = 17;
            // 
            // txtEtutId
            // 
            this.txtEtutId.Enabled = false;
            this.txtEtutId.Location = new System.Drawing.Point(102, 37);
            this.txtEtutId.Name = "txtEtutId";
            this.txtEtutId.Size = new System.Drawing.Size(174, 26);
            this.txtEtutId.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Etüt ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(426, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 100);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mskTelefon);
            this.groupBox5.Controls.Add(this.btnOgrenciEkle);
            this.groupBox5.Controls.Add(this.txtMail);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtSinif);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtAd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtSoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(810, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 270);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Öğrenci Kayıt";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(92, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(174, 26);
            this.txtAd.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(92, 70);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(174, 26);
            this.txtSoyad.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Soyad:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(1104, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(372, 270);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.btnOgretmenEkle);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.txtOgretmenAd);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.txtOgretmenSoyad);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(1104, 323);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(372, 294);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Öğretmen Kayıt";
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(92, 104);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(174, 26);
            this.txtSinif.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Sınıf:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "Telefon:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(92, 175);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(174, 26);
            this.txtMail.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "Mail:";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(126, 207);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(124, 43);
            this.btnOgrenciEkle.TabIndex = 20;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(92, 138);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(174, 26);
            this.mskTelefon.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 26);
            this.textBox1.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 19);
            this.label16.TabIndex = 28;
            this.label16.Text = "Ders Adı:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ders Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 37);
            this.button2.TabIndex = 30;
            this.button2.Text = "Fotoğraf Yükle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ders:";
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(111, 38);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(174, 26);
            this.txtOgretmenAd.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "Ad:";
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(111, 74);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(174, 26);
            this.txtOgretmenSoyad.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 19);
            this.label17.TabIndex = 29;
            this.label17.Text = "Soyad:";
            // 
            // btnOgretmenEkle
            // 
            this.btnOgretmenEkle.Location = new System.Drawing.Point(126, 140);
            this.btnOgretmenEkle.Name = "btnOgretmenEkle";
            this.btnOgretmenEkle.Size = new System.Drawing.Size(141, 37);
            this.btnOgretmenEkle.TabIndex = 37;
            this.btnOgretmenEkle.Text = "Öğretmen Ekle";
            this.btnOgretmenEkle.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 27);
            this.comboBox1.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1479, 646);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEtutOlustur;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOgretmen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEtutver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEtutId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenci;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnOgretmenEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

