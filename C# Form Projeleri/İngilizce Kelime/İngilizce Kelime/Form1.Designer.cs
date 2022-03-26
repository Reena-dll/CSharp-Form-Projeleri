namespace İngilizce_Kelime
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtingilizce = new System.Windows.Forms.TextBox();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // txtingilizce
            // 
            this.txtingilizce.Location = new System.Drawing.Point(104, 23);
            this.txtingilizce.Name = "txtingilizce";
            this.txtingilizce.Size = new System.Drawing.Size(290, 26);
            this.txtingilizce.TabIndex = 1;
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(104, 68);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(290, 26);
            this.txtTurkce.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(487, 23);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(27, 19);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kelime:";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(487, 71);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(18, 19);
            this.lblKelime.TabIndex = 7;
            this.lblKelime.Text = "0";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(414, 120);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(63, 19);
            this.lblCevap.TabIndex = 8;
            this.lblCevap.Text = "LABEL";
            this.lblCevap.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 161);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtingilizce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtingilizce;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Timer timer1;
    }
}

