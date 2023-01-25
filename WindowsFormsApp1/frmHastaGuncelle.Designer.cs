namespace WindowsFormsApp1
{
    partial class frmHastaGuncelle
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
            this.labelad = new System.Windows.Forms.Label();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbKanGrubu = new System.Windows.Forms.ComboBox();
            this.cbMedeniHal = new System.Windows.Forms.ComboBox();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnaAdi = new System.Windows.Forms.TextBox();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.SuspendLayout();
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Location = new System.Drawing.Point(26, 191);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(63, 13);
            this.labelad.TabIndex = 199;
            this.labelad.Text = "Telefon No:";
            // 
            // dataGVeri
            // 
            this.dataGVeri.AllowUserToDeleteRows = false;
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(23, 306);
            this.dataGVeri.Margin = new System.Windows.Forms.Padding(2);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.RowHeadersVisible = false;
            this.dataGVeri.RowHeadersWidth = 10;
            this.dataGVeri.RowTemplate.Height = 24;
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(578, 133);
            this.dataGVeri.TabIndex = 197;
            this.dataGVeri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellContentClick);
            this.dataGVeri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellDoubleClick);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 12);
            this.txtAd.MaxLength = 14;
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(168, 29);
            this.txtAd.TabIndex = 173;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(403, 47);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(182, 20);
            this.dtpDogumTarihi.TabIndex = 180;
            // 
            // cbKanGrubu
            // 
            this.cbKanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKanGrubu.FormattingEnabled = true;
            this.cbKanGrubu.Items.AddRange(new object[] {
            "0 Rh+",
            "0 Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-",
            "AB Rh+",
            "AB Rh-"});
            this.cbKanGrubu.Location = new System.Drawing.Point(403, 106);
            this.cbKanGrubu.Name = "cbKanGrubu";
            this.cbKanGrubu.Size = new System.Drawing.Size(96, 21);
            this.cbKanGrubu.TabIndex = 182;
            // 
            // cbMedeniHal
            // 
            this.cbMedeniHal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedeniHal.FormattingEnabled = true;
            this.cbMedeniHal.Items.AddRange(new object[] {
            "Evli",
            "Bekar",
            "Dul"});
            this.cbMedeniHal.Location = new System.Drawing.Point(403, 132);
            this.cbMedeniHal.Name = "cbMedeniHal";
            this.cbMedeniHal.Size = new System.Drawing.Size(96, 21);
            this.cbMedeniHal.TabIndex = 183;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbCinsiyet.Location = new System.Drawing.Point(403, 78);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(96, 21);
            this.cbCinsiyet.TabIndex = 181;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 227);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 196;
            this.label18.Text = "Adres:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(336, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 195;
            this.label17.Text = "Kan Grubu:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(330, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 194;
            this.label16.Text = "Medeni Hali:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 193;
            this.label15.Text = "Cinsiyeti:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(320, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 192;
            this.label13.Text = "Doğum Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 191;
            this.label10.Text = "Soyadı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(291, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 190;
            this.label12.Text = "T.C. Kimlik Numarası:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 45);
            this.txtSoyad.MaxLength = 14;
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(168, 29);
            this.txtSoyad.TabIndex = 174;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(94, 217);
            this.txtAdres.MaxLength = 250;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(198, 71);
            this.txtAdres.TabIndex = 178;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 189;
            this.label5.Text = "Ana Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 188;
            this.label4.Text = "Baba Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 187;
            this.label3.Text = "Doğum Yeri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 186;
            this.label2.Text = "Adı:";
            // 
            // txtAnaAdi
            // 
            this.txtAnaAdi.Location = new System.Drawing.Point(94, 147);
            this.txtAnaAdi.MaxLength = 14;
            this.txtAnaAdi.Multiline = true;
            this.txtAnaAdi.Name = "txtAnaAdi";
            this.txtAnaAdi.Size = new System.Drawing.Size(168, 29);
            this.txtAnaAdi.TabIndex = 177;
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Location = new System.Drawing.Point(94, 113);
            this.txtBabaAdi.MaxLength = 14;
            this.txtBabaAdi.Multiline = true;
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(168, 29);
            this.txtBabaAdi.TabIndex = 176;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(94, 78);
            this.txtDogumYeri.MaxLength = 14;
            this.txtDogumYeri.Multiline = true;
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(168, 29);
            this.txtDogumYeri.TabIndex = 175;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(403, 12);
            this.txtTc.MaxLength = 11;
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(182, 29);
            this.txtTc.TabIndex = 179;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(457, 253);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(116, 35);
            this.btnEkle.TabIndex = 184;
            this.btnEkle.Text = "Güncelle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(94, 182);
            this.txtTelNo.MaxLength = 14;
            this.txtTelNo.Multiline = true;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(168, 29);
            this.txtTelNo.TabIndex = 198;
            // 
            // frmHastaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.dataGVeri);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.cbKanGrubu);
            this.Controls.Add(this.cbMedeniHal);
            this.Controls.Add(this.cbCinsiyet);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnaAdi);
            this.Controls.Add(this.txtBabaAdi);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtTc);
            this.Name = "frmHastaGuncelle";
            this.Text = "frmHastaGuncelle";
            this.Load += new System.EventHandler(this.frmHastaGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelad;
        private System.Windows.Forms.DataGridView dataGVeri;
        public System.Windows.Forms.TextBox txtAd;
        public System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        public System.Windows.Forms.ComboBox cbKanGrubu;
        public System.Windows.Forms.ComboBox cbMedeniHal;
        public System.Windows.Forms.ComboBox cbCinsiyet;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAdres;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAnaAdi;
        public System.Windows.Forms.TextBox txtBabaAdi;
        public System.Windows.Forms.TextBox txtDogumYeri;
        public System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.TextBox txtTelNo;
    }
}