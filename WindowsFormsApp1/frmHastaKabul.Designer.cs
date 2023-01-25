namespace WindowsFormsApp1
{
    partial class frmHastaKabul
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDoktorSec = new System.Windows.Forms.Button();
            this.btnHastaSec = new System.Windows.Forms.Button();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightCoral;
            this.btnKaydet.Location = new System.Drawing.Point(11, 241);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(256, 71);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDoktorSec
            // 
            this.btnDoktorSec.BackColor = System.Drawing.Color.LightCoral;
            this.btnDoktorSec.Location = new System.Drawing.Point(11, 82);
            this.btnDoktorSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoktorSec.Name = "btnDoktorSec";
            this.btnDoktorSec.Size = new System.Drawing.Size(256, 45);
            this.btnDoktorSec.TabIndex = 3;
            this.btnDoktorSec.Text = "Doktor Seç";
            this.btnDoktorSec.UseVisualStyleBackColor = false;
            this.btnDoktorSec.Click += new System.EventHandler(this.btnDoktorSec_Click);
            // 
            // btnHastaSec
            // 
            this.btnHastaSec.BackColor = System.Drawing.Color.LightCoral;
            this.btnHastaSec.Location = new System.Drawing.Point(11, 19);
            this.btnHastaSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnHastaSec.Name = "btnHastaSec";
            this.btnHastaSec.Size = new System.Drawing.Size(256, 45);
            this.btnHastaSec.TabIndex = 4;
            this.btnHastaSec.Text = "Hasta Seç";
            this.btnHastaSec.UseVisualStyleBackColor = false;
            this.btnHastaSec.Click += new System.EventHandler(this.btnHastaSec_Click);
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(11, 181);
            this.txtSikayet.Margin = new System.Windows.Forms.Padding(2);
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(257, 56);
            this.txtSikayet.TabIndex = 5;
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Location = new System.Drawing.Point(11, 129);
            this.lblDoktor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(42, 13);
            this.lblDoktor.TabIndex = 8;
            this.lblDoktor.Text = "Doktor:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(11, 66);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şikayet";
            // 
            // frmHastaKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 358);
            this.Controls.Add(this.lblDoktor);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSikayet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDoktorSec);
            this.Controls.Add(this.btnHastaSec);
            this.Name = "frmHastaKabul";
            this.Text = "frmHastaKabul";
            this.Load += new System.EventHandler(this.frmHastaKabul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Button btnDoktorSec;
        public System.Windows.Forms.Button btnHastaSec;
        private System.Windows.Forms.TextBox txtSikayet;
        public System.Windows.Forms.Label lblDoktor;
        public System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label label1;
    }
}