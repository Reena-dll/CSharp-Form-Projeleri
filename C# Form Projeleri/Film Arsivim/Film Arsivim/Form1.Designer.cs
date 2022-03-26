namespace Film_Arsivim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnRenkDegis = new System.Windows.Forms.Button();
            this.btnHakkımızda = new System.Windows.Forms.Button();
            this.btnTamEkran = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(250, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sinema Koltuk Yazılım";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1168, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtLink);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFilmAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 610);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Film";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCikis);
            this.groupBox4.Controls.Add(this.btnRenkDegis);
            this.groupBox4.Controls.Add(this.btnHakkımızda);
            this.groupBox4.Controls.Add(this.btnTamEkran);
            this.groupBox4.Location = new System.Drawing.Point(6, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 329);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(32, 200);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(152, 37);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRenkDegis
            // 
            this.btnRenkDegis.Location = new System.Drawing.Point(32, 157);
            this.btnRenkDegis.Name = "btnRenkDegis";
            this.btnRenkDegis.Size = new System.Drawing.Size(152, 37);
            this.btnRenkDegis.TabIndex = 12;
            this.btnRenkDegis.Text = "Karanlık Mod";
            this.btnRenkDegis.UseVisualStyleBackColor = true;
            this.btnRenkDegis.Click += new System.EventHandler(this.btnRenkDegis_Click);
            // 
            // btnHakkımızda
            // 
            this.btnHakkımızda.Location = new System.Drawing.Point(32, 114);
            this.btnHakkımızda.Name = "btnHakkımızda";
            this.btnHakkımızda.Size = new System.Drawing.Size(152, 37);
            this.btnHakkımızda.TabIndex = 11;
            this.btnHakkımızda.Text = "Hakkımızda";
            this.btnHakkımızda.UseVisualStyleBackColor = true;
            this.btnHakkımızda.Click += new System.EventHandler(this.btnHakkımızda_Click);
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.Location = new System.Drawing.Point(32, 71);
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Size = new System.Drawing.Size(152, 37);
            this.btnTamEkran.TabIndex = 10;
            this.btnTamEkran.Text = "Tam Ekran";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(150, 173);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 37);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(114, 138);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(177, 29);
            this.txtLink.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(114, 103);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(177, 29);
            this.txtKategori.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori:";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(114, 68);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(177, 29);
            this.txtFilmAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(663, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 610);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(623, 582);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(307, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 610);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 582);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1310, 690);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRenkDegis;
        private System.Windows.Forms.Button btnHakkımızda;
        private System.Windows.Forms.Button btnTamEkran;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

