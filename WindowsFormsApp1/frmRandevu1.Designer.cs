namespace WindowsFormsApp1
{
    partial class frmRandevu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandevu1));
            this.monthCalendar_randevuTarihleri = new System.Windows.Forms.MonthCalendar();
            this.lblPsikiyatri = new System.Windows.Forms.Label();
            this.lblNöroloji = new System.Windows.Forms.Label();
            this.lblKardiyoloji = new System.Windows.Forms.Label();
            this.lblBeyinveSinirCerrahisi = new System.Windows.Forms.Label();
            this.picBoxBeyinveSinirCerrahisi = new System.Windows.Forms.PictureBox();
            this.picBoxKardiyoloji = new System.Windows.Forms.PictureBox();
            this.picBoxNöroloji = new System.Windows.Forms.PictureBox();
            this.picBoxPsikiyatri = new System.Windows.Forms.PictureBox();
            this.lblTarih1 = new System.Windows.Forms.Label();
            this.llblTarihAciklama = new System.Windows.Forms.Label();
            this.picBoxTarihAciklama = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBeyinveSinirCerrahisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKardiyoloji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNöroloji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPsikiyatri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTarihAciklama)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar_randevuTarihleri
            // 
            this.monthCalendar_randevuTarihleri.BackColor = System.Drawing.Color.Gold;
            this.monthCalendar_randevuTarihleri.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar_randevuTarihleri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthCalendar_randevuTarihleri.ForeColor = System.Drawing.Color.White;
            this.monthCalendar_randevuTarihleri.Location = new System.Drawing.Point(18, 50);
            this.monthCalendar_randevuTarihleri.MaxSelectionCount = 1;
            this.monthCalendar_randevuTarihleri.Name = "monthCalendar_randevuTarihleri";
            this.monthCalendar_randevuTarihleri.TabIndex = 128;
            this.monthCalendar_randevuTarihleri.TitleBackColor = System.Drawing.Color.Red;
            this.monthCalendar_randevuTarihleri.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar_randevuTarihleri.TrailingForeColor = System.Drawing.SystemColors.WindowFrame;
            // 
            // lblPsikiyatri
            // 
            this.lblPsikiyatri.AutoSize = true;
            this.lblPsikiyatri.BackColor = System.Drawing.Color.White;
            this.lblPsikiyatri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPsikiyatri.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPsikiyatri.Image = ((System.Drawing.Image)(resources.GetObject("lblPsikiyatri.Image")));
            this.lblPsikiyatri.Location = new System.Drawing.Point(865, 143);
            this.lblPsikiyatri.Name = "lblPsikiyatri";
            this.lblPsikiyatri.Size = new System.Drawing.Size(66, 16);
            this.lblPsikiyatri.TabIndex = 146;
            this.lblPsikiyatri.Text = "Psikiyatri";
            // 
            // lblNöroloji
            // 
            this.lblNöroloji.AutoSize = true;
            this.lblNöroloji.BackColor = System.Drawing.Color.White;
            this.lblNöroloji.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNöroloji.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblNöroloji.Image = ((System.Drawing.Image)(resources.GetObject("lblNöroloji.Image")));
            this.lblNöroloji.Location = new System.Drawing.Point(718, 143);
            this.lblNöroloji.Name = "lblNöroloji";
            this.lblNöroloji.Size = new System.Drawing.Size(58, 16);
            this.lblNöroloji.TabIndex = 145;
            this.lblNöroloji.Text = "Nöroloji";
            this.lblNöroloji.Click += new System.EventHandler(this.lblNöroloji_Click);
            // 
            // lblKardiyoloji
            // 
            this.lblKardiyoloji.AutoSize = true;
            this.lblKardiyoloji.BackColor = System.Drawing.Color.White;
            this.lblKardiyoloji.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKardiyoloji.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblKardiyoloji.Image = ((System.Drawing.Image)(resources.GetObject("lblKardiyoloji.Image")));
            this.lblKardiyoloji.Location = new System.Drawing.Point(558, 143);
            this.lblKardiyoloji.Name = "lblKardiyoloji";
            this.lblKardiyoloji.Size = new System.Drawing.Size(77, 16);
            this.lblKardiyoloji.TabIndex = 144;
            this.lblKardiyoloji.Text = "Kardiyoloji";
            // 
            // lblBeyinveSinirCerrahisi
            // 
            this.lblBeyinveSinirCerrahisi.AutoSize = true;
            this.lblBeyinveSinirCerrahisi.BackColor = System.Drawing.Color.White;
            this.lblBeyinveSinirCerrahisi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeyinveSinirCerrahisi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBeyinveSinirCerrahisi.Image = ((System.Drawing.Image)(resources.GetObject("lblBeyinveSinirCerrahisi.Image")));
            this.lblBeyinveSinirCerrahisi.Location = new System.Drawing.Point(403, 134);
            this.lblBeyinveSinirCerrahisi.Name = "lblBeyinveSinirCerrahisi";
            this.lblBeyinveSinirCerrahisi.Size = new System.Drawing.Size(97, 32);
            this.lblBeyinveSinirCerrahisi.TabIndex = 143;
            this.lblBeyinveSinirCerrahisi.Text = "Beyin-ve-Sinir\r\n-Cerrahisi";
            // 
            // picBoxBeyinveSinirCerrahisi
            // 
            this.picBoxBeyinveSinirCerrahisi.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxBeyinveSinirCerrahisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxBeyinveSinirCerrahisi.BackgroundImage")));
            this.picBoxBeyinveSinirCerrahisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxBeyinveSinirCerrahisi.Location = new System.Drawing.Point(375, 127);
            this.picBoxBeyinveSinirCerrahisi.Name = "picBoxBeyinveSinirCerrahisi";
            this.picBoxBeyinveSinirCerrahisi.Size = new System.Drawing.Size(145, 63);
            this.picBoxBeyinveSinirCerrahisi.TabIndex = 135;
            this.picBoxBeyinveSinirCerrahisi.TabStop = false;
            this.picBoxBeyinveSinirCerrahisi.Click += new System.EventHandler(this.picBoxBeyinveSinirCerrahisi_Click);
            // 
            // picBoxKardiyoloji
            // 
            this.picBoxKardiyoloji.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxKardiyoloji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxKardiyoloji.BackgroundImage")));
            this.picBoxKardiyoloji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxKardiyoloji.Location = new System.Drawing.Point(526, 127);
            this.picBoxKardiyoloji.Name = "picBoxKardiyoloji";
            this.picBoxKardiyoloji.Size = new System.Drawing.Size(145, 63);
            this.picBoxKardiyoloji.TabIndex = 136;
            this.picBoxKardiyoloji.TabStop = false;
            this.picBoxKardiyoloji.Click += new System.EventHandler(this.picBoxKardiyoloji_Click);
            // 
            // picBoxNöroloji
            // 
            this.picBoxNöroloji.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxNöroloji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxNöroloji.BackgroundImage")));
            this.picBoxNöroloji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxNöroloji.Location = new System.Drawing.Point(677, 127);
            this.picBoxNöroloji.Name = "picBoxNöroloji";
            this.picBoxNöroloji.Size = new System.Drawing.Size(145, 63);
            this.picBoxNöroloji.TabIndex = 137;
            this.picBoxNöroloji.TabStop = false;
            this.picBoxNöroloji.Click += new System.EventHandler(this.picBoxNöroloji_Click);
            // 
            // picBoxPsikiyatri
            // 
            this.picBoxPsikiyatri.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxPsikiyatri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxPsikiyatri.BackgroundImage")));
            this.picBoxPsikiyatri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPsikiyatri.Location = new System.Drawing.Point(828, 127);
            this.picBoxPsikiyatri.Name = "picBoxPsikiyatri";
            this.picBoxPsikiyatri.Size = new System.Drawing.Size(145, 63);
            this.picBoxPsikiyatri.TabIndex = 138;
            this.picBoxPsikiyatri.TabStop = false;
            this.picBoxPsikiyatri.Click += new System.EventHandler(this.picBoxPsikiyatri_Click);
            // 
            // lblTarih1
            // 
            this.lblTarih1.AutoSize = true;
            this.lblTarih1.BackColor = System.Drawing.SystemColors.Control;
            this.lblTarih1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTarih1.Image = ((System.Drawing.Image)(resources.GetObject("lblTarih1.Image")));
            this.lblTarih1.Location = new System.Drawing.Point(441, 72);
            this.lblTarih1.Name = "lblTarih1";
            this.lblTarih1.Size = new System.Drawing.Size(116, 15);
            this.lblTarih1.TabIndex = 134;
            this.lblTarih1.Text = "ToLongDateString()";
            // 
            // llblTarihAciklama
            // 
            this.llblTarihAciklama.AutoSize = true;
            this.llblTarihAciklama.BackColor = System.Drawing.SystemColors.Control;
            this.llblTarihAciklama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llblTarihAciklama.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.llblTarihAciklama.Image = ((System.Drawing.Image)(resources.GetObject("llblTarihAciklama.Image")));
            this.llblTarihAciklama.Location = new System.Drawing.Point(346, 72);
            this.llblTarihAciklama.Name = "llblTarihAciklama";
            this.llblTarihAciklama.Size = new System.Drawing.Size(98, 15);
            this.llblTarihAciklama.TabIndex = 133;
            this.llblTarihAciklama.Text = "Tarih                    :";
            // 
            // picBoxTarihAciklama
            // 
            this.picBoxTarihAciklama.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTarihAciklama.Image")));
            this.picBoxTarihAciklama.Location = new System.Drawing.Point(338, 67);
            this.picBoxTarihAciklama.Name = "picBoxTarihAciklama";
            this.picBoxTarihAciklama.Size = new System.Drawing.Size(690, 25);
            this.picBoxTarihAciklama.TabIndex = 132;
            this.picBoxTarihAciklama.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 147;
            this.label1.Text = "Branş Listesi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(338, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 39);
            this.panel1.TabIndex = 148;
            // 
            // frmRandevu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 256);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPsikiyatri);
            this.Controls.Add(this.lblNöroloji);
            this.Controls.Add(this.lblKardiyoloji);
            this.Controls.Add(this.lblBeyinveSinirCerrahisi);
            this.Controls.Add(this.picBoxBeyinveSinirCerrahisi);
            this.Controls.Add(this.picBoxKardiyoloji);
            this.Controls.Add(this.picBoxNöroloji);
            this.Controls.Add(this.picBoxPsikiyatri);
            this.Controls.Add(this.lblTarih1);
            this.Controls.Add(this.llblTarihAciklama);
            this.Controls.Add(this.picBoxTarihAciklama);
            this.Controls.Add(this.monthCalendar_randevuTarihleri);
            this.Name = "frmRandevu1";
            this.Text = "frmRandevu1";
            this.Load += new System.EventHandler(this.frmRandevu1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBeyinveSinirCerrahisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKardiyoloji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNöroloji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPsikiyatri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTarihAciklama)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblPsikiyatri;
        public System.Windows.Forms.Label lblNöroloji;
        public System.Windows.Forms.Label lblKardiyoloji;
        public System.Windows.Forms.Label lblBeyinveSinirCerrahisi;
        public System.Windows.Forms.PictureBox picBoxBeyinveSinirCerrahisi;
        public System.Windows.Forms.PictureBox picBoxKardiyoloji;
        public System.Windows.Forms.PictureBox picBoxNöroloji;
        public System.Windows.Forms.PictureBox picBoxPsikiyatri;
        public System.Windows.Forms.Label lblTarih1;
        public System.Windows.Forms.Label llblTarihAciklama;
        public System.Windows.Forms.PictureBox picBoxTarihAciklama;
        public System.Windows.Forms.MonthCalendar monthCalendar_randevuTarihleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}