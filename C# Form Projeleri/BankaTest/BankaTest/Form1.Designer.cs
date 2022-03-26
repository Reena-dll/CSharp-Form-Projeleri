namespace BankaTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lnkKayıtOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // mskHesapNo
            // 
            this.mskHesapNo.Location = new System.Drawing.Point(120, 58);
            this.mskHesapNo.Mask = "000000";
            this.mskHesapNo.Name = "mskHesapNo";
            this.mskHesapNo.Size = new System.Drawing.Size(61, 26);
            this.mskHesapNo.TabIndex = 1;
            this.mskHesapNo.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(120, 99);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(122, 26);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(131, 142);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(95, 35);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lnkKayıtOl
            // 
            this.lnkKayıtOl.AutoSize = true;
            this.lnkKayıtOl.Location = new System.Drawing.Point(250, 150);
            this.lnkKayıtOl.Name = "lnkKayıtOl";
            this.lnkKayıtOl.Size = new System.Drawing.Size(68, 19);
            this.lnkKayıtOl.TabIndex = 4;
            this.lnkKayıtOl.TabStop = true;
            this.lnkKayıtOl.Text = "Kayıt Ol";
            this.lnkKayıtOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKayıtOl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(348, 267);
            this.Controls.Add(this.lnkKayıtOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskHesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskHesapNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel lnkKayıtOl;
    }
}

