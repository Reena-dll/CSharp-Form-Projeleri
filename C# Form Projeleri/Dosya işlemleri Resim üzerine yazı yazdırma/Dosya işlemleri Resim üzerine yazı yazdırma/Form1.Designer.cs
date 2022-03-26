namespace Dosya_işlemleri_Resim_üzerine_yazı_yazdırma
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
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.txtBoyut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(95, 102);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(235, 45);
            this.btnRenk.TabIndex = 5;
            this.btnRenk.Text = "Renk Seç";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(95, 37);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(235, 45);
            this.btnResim.TabIndex = 1;
            this.btnResim.Text = "Resim Seç";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnYazdır
            // 
            this.btnYazdır.Location = new System.Drawing.Point(95, 167);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(235, 45);
            this.btnYazdır.TabIndex = 2;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(95, 236);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(235, 45);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metni Girin:";
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(193, 311);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(137, 26);
            this.txtMetin.TabIndex = 5;
            // 
            // txtBoyut
            // 
            this.txtBoyut.Location = new System.Drawing.Point(193, 356);
            this.txtBoyut.Name = "txtBoyut";
            this.txtBoyut.Size = new System.Drawing.Size(137, 26);
            this.txtBoyut.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Metni Girin:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(397, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnRenk);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.TextBox txtBoyut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

