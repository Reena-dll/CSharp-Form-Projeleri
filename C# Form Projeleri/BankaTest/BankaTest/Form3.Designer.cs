namespace BankaTest
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnHesapNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tc Kimlik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hesap No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(122, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(167, 26);
            this.txtAd.TabIndex = 1;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(122, 101);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(167, 26);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(122, 72);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(167, 26);
            this.txtSoyad.TabIndex = 2;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(122, 133);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(167, 26);
            this.mskTel.TabIndex = 4;
            // 
            // mskHesapNo
            // 
            this.mskHesapNo.Enabled = false;
            this.mskHesapNo.Location = new System.Drawing.Point(122, 164);
            this.mskHesapNo.Mask = "000000";
            this.mskHesapNo.Name = "mskHesapNo";
            this.mskHesapNo.Size = new System.Drawing.Size(167, 26);
            this.mskHesapNo.TabIndex = 5;
            this.mskHesapNo.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(122, 195);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 26);
            this.txtSifre.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(148, 227);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 39);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnHesapNo
            // 
            this.btnHesapNo.Location = new System.Drawing.Point(295, 164);
            this.btnHesapNo.Name = "btnHesapNo";
            this.btnHesapNo.Size = new System.Drawing.Size(42, 26);
            this.btnHesapNo.TabIndex = 20;
            this.btnHesapNo.Text = "...";
            this.btnHesapNo.UseVisualStyleBackColor = true;
            this.btnHesapNo.Click += new System.EventHandler(this.btnHesapNo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(372, 372);
            this.Controls.Add(this.btnHesapNo);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskHesapNo);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskHesapNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnHesapNo;
    }
}