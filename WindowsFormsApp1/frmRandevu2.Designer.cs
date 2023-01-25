namespace WindowsFormsApp1
{
    partial class frmRandevu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRandevu2));
            this.picBoxBölüm = new System.Windows.Forms.PictureBox();
            this.lblBolumİsmi = new System.Windows.Forms.Label();
            this.picBoxTarihAciklama = new System.Windows.Forms.PictureBox();
            this.lblTarih1 = new System.Windows.Forms.Label();
            this.lblBransAdi1 = new System.Windows.Forms.Label();
            this.lblBransAdiAciklama = new System.Windows.Forms.Label();
            this.llblTarihAciklama = new System.Windows.Forms.Label();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBölüm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTarihAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxBölüm
            // 
            this.picBoxBölüm.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxBölüm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxBölüm.BackgroundImage")));
            this.picBoxBölüm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxBölüm.Location = new System.Drawing.Point(12, 299);
            this.picBoxBölüm.Name = "picBoxBölüm";
            this.picBoxBölüm.Size = new System.Drawing.Size(117, 70);
            this.picBoxBölüm.TabIndex = 116;
            this.picBoxBölüm.TabStop = false;
            // 
            // lblBolumİsmi
            // 
            this.lblBolumİsmi.AutoSize = true;
            this.lblBolumİsmi.BackColor = System.Drawing.Color.White;
            this.lblBolumİsmi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumİsmi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBolumİsmi.Image = ((System.Drawing.Image)(resources.GetObject("lblBolumİsmi.Image")));
            this.lblBolumİsmi.Location = new System.Drawing.Point(27, 323);
            this.lblBolumİsmi.Name = "lblBolumİsmi";
            this.lblBolumİsmi.Size = new System.Drawing.Size(79, 16);
            this.lblBolumİsmi.TabIndex = 119;
            this.lblBolumİsmi.Text = "Bölüm İsmi";
            this.lblBolumİsmi.Click += new System.EventHandler(this.lblBolumİsmi_Click);
            // 
            // picBoxTarihAciklama
            // 
            this.picBoxTarihAciklama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxTarihAciklama.BackgroundImage")));
            this.picBoxTarihAciklama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxTarihAciklama.Location = new System.Drawing.Point(12, 12);
            this.picBoxTarihAciklama.Name = "picBoxTarihAciklama";
            this.picBoxTarihAciklama.Size = new System.Drawing.Size(777, 80);
            this.picBoxTarihAciklama.TabIndex = 120;
            this.picBoxTarihAciklama.TabStop = false;
            // 
            // lblTarih1
            // 
            this.lblTarih1.AutoSize = true;
            this.lblTarih1.BackColor = System.Drawing.SystemColors.Control;
            this.lblTarih1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTarih1.Image = ((System.Drawing.Image)(resources.GetObject("lblTarih1.Image")));
            this.lblTarih1.Location = new System.Drawing.Point(119, 21);
            this.lblTarih1.Name = "lblTarih1";
            this.lblTarih1.Size = new System.Drawing.Size(114, 15);
            this.lblTarih1.TabIndex = 124;
            this.lblTarih1.Text = "ToLongDateString()";
            // 
            // lblBransAdi1
            // 
            this.lblBransAdi1.AutoSize = true;
            this.lblBransAdi1.BackColor = System.Drawing.SystemColors.Control;
            this.lblBransAdi1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBransAdi1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBransAdi1.Image = ((System.Drawing.Image)(resources.GetObject("lblBransAdi1.Image")));
            this.lblBransAdi1.Location = new System.Drawing.Point(119, 44);
            this.lblBransAdi1.Name = "lblBransAdi1";
            this.lblBransAdi1.Size = new System.Drawing.Size(59, 15);
            this.lblBransAdi1.TabIndex = 123;
            this.lblBransAdi1.Text = "Branş Adı";
            // 
            // lblBransAdiAciklama
            // 
            this.lblBransAdiAciklama.AutoSize = true;
            this.lblBransAdiAciklama.BackColor = System.Drawing.SystemColors.Control;
            this.lblBransAdiAciklama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBransAdiAciklama.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBransAdiAciklama.Image = ((System.Drawing.Image)(resources.GetObject("lblBransAdiAciklama.Image")));
            this.lblBransAdiAciklama.Location = new System.Drawing.Point(27, 44);
            this.lblBransAdiAciklama.Name = "lblBransAdiAciklama";
            this.lblBransAdiAciklama.Size = new System.Drawing.Size(95, 15);
            this.lblBransAdiAciklama.TabIndex = 122;
            this.lblBransAdiAciklama.Text = "Branş Adı          :";
            // 
            // llblTarihAciklama
            // 
            this.llblTarihAciklama.AutoSize = true;
            this.llblTarihAciklama.BackColor = System.Drawing.SystemColors.Control;
            this.llblTarihAciklama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llblTarihAciklama.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.llblTarihAciklama.Image = ((System.Drawing.Image)(resources.GetObject("llblTarihAciklama.Image")));
            this.llblTarihAciklama.Location = new System.Drawing.Point(27, 21);
            this.llblTarihAciklama.Name = "llblTarihAciklama";
            this.llblTarihAciklama.Size = new System.Drawing.Size(95, 15);
            this.llblTarihAciklama.TabIndex = 121;
            this.llblTarihAciklama.Text = "Tarih                   :";
            // 
            // dataGVeri
            // 
            this.dataGVeri.AllowUserToDeleteRows = false;
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(198, 133);
            this.dataGVeri.Margin = new System.Windows.Forms.Padding(2);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.RowHeadersVisible = false;
            this.dataGVeri.RowHeadersWidth = 10;
            this.dataGVeri.RowTemplate.Height = 24;
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(591, 160);
            this.dataGVeri.TabIndex = 178;
            this.dataGVeri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellDoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00"});
            this.listBox1.Location = new System.Drawing.Point(2, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 160);
            this.listBox1.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(119, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 183;
            this.label1.Text = "Hasta Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 182;
            this.label2.Text = "Hasta Adı          :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(152, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 185;
            this.label3.Text = "Randevu Al";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(135, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 70);
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 179;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 180;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(356, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 187;
            this.label4.Text = "Doktor Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(264, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 186;
            this.label5.Text = "Doktor Adı          :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(359, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 189;
            this.label6.Text = "DoktorNo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(267, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 188;
            this.label7.Text = "Doktor No  :";
            // 
            // frmRandevu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGVeri);
            this.Controls.Add(this.lblTarih1);
            this.Controls.Add(this.lblBransAdi1);
            this.Controls.Add(this.lblBransAdiAciklama);
            this.Controls.Add(this.llblTarihAciklama);
            this.Controls.Add(this.picBoxTarihAciklama);
            this.Controls.Add(this.lblBolumİsmi);
            this.Controls.Add(this.picBoxBölüm);
            this.Name = "frmRandevu2";
            this.Text = "frmRandevu2";
            this.Load += new System.EventHandler(this.frmRandevu2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBölüm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTarihAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox picBoxBölüm;
        public System.Windows.Forms.Label lblBolumİsmi;
        public System.Windows.Forms.PictureBox picBoxTarihAciklama;
        public System.Windows.Forms.Label lblTarih1;
        public System.Windows.Forms.Label lblBransAdi1;
        public System.Windows.Forms.Label lblBransAdiAciklama;
        public System.Windows.Forms.Label llblTarihAciklama;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
    }
}