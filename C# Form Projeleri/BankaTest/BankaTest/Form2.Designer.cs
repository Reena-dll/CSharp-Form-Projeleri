namespace BankaTest
{
    partial class Form2
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
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(115, 19);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(73, 19);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hesap No:";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(115, 50);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(39, 19);
            this.lblHesapNo.TabIndex = 3;
            this.lblHesapNo.Text = "Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "TC Kimlik:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(115, 87);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(39, 19);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Null";
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Location = new System.Drawing.Point(115, 123);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(39, 19);
            this.lblTcKimlik.TabIndex = 7;
            this.lblTcKimlik.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mskHesapNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(25, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(135, 102);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(108, 39);
            this.btnGonder.TabIndex = 13;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(135, 70);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(108, 26);
            this.txtTutar.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tutar:";
            // 
            // mskHesapNo
            // 
            this.mskHesapNo.Location = new System.Drawing.Point(135, 37);
            this.mskHesapNo.Mask = "000000";
            this.mskHesapNo.Name = "mskHesapNo";
            this.mskHesapNo.Size = new System.Drawing.Size(65, 26);
            this.mskHesapNo.TabIndex = 10;
            this.mskHesapNo.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hesap No:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(578, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTcKimlik);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskHesapNo;
        private System.Windows.Forms.Label label9;
    }
}