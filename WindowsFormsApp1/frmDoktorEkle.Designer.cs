namespace WindowsFormsApp1
{
    partial class frmDoktorEkle
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
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.labelad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(119, 113);
            this.txtTelNo.MaxLength = 14;
            this.txtTelNo.Multiline = true;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(182, 29);
            this.txtTelNo.TabIndex = 185;
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Location = new System.Drawing.Point(51, 122);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(63, 13);
            this.labelad.TabIndex = 186;
            this.labelad.Text = "Telefon No:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(119, 12);
            this.txtAd.MaxLength = 14;
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(182, 29);
            this.txtAd.TabIndex = 173;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(119, 183);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(182, 20);
            this.dtpDogumTarihi.TabIndex = 177;
            this.dtpDogumTarihi.ValueChanged += new System.EventHandler(this.dtpDogumTarihi_ValueChanged);
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(119, 214);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(96, 21);
            this.cbCinsiyet.TabIndex = 178;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(65, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 184;
            this.label15.Text = "Cinsiyeti:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 183;
            this.label13.Text = "Doğum Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 182;
            this.label10.Text = "Soyadı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(7, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 181;
            this.label12.Text = "T.C. Kimlik Numarası:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(119, 45);
            this.txtSoyad.MaxLength = 14;
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(182, 29);
            this.txtSoyad.TabIndex = 174;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 180;
            this.label3.Text = "Doğum Yeri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 179;
            this.label2.Text = "Adı:";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(119, 78);
            this.txtDogumYeri.MaxLength = 14;
            this.txtDogumYeri.Multiline = true;
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(182, 29);
            this.txtDogumYeri.TabIndex = 175;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(119, 148);
            this.txtTc.MaxLength = 11;
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(182, 29);
            this.txtTc.TabIndex = 176;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(436, 218);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 35);
            this.btnEkle.TabIndex = 187;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Beyin-ve-Sinir-Cerrahisi",
            "Kardiyoloji",
            "Nöroloji",
            "Psikiyatri"});
            this.comboBox1.Location = new System.Drawing.Point(380, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 188;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 189;
            this.label1.Text = "Klinik:";
            // 
            // frmDoktorEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtTc);
            this.Name = "frmDoktorEkle";
            this.Text = "ftmDoktorEkle";
            this.Load += new System.EventHandler(this.frmDoktorEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTelNo;
        public System.Windows.Forms.Label labelad;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        public System.Windows.Forms.ComboBox cbCinsiyet;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDogumYeri;
        public System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label1;
    }
}