namespace WindowsFormsApp1
{
    partial class frmMainDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainDoktor));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnilacara = new System.Windows.Forms.Button();
            this.btnİlacTemizle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGİlac = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGİlac)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 158;
            this.label1.Text = "Yapılan işlem:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 200);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 70);
            this.textBox1.TabIndex = 157;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(451, 325);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 34);
            this.btnKaydet.TabIndex = 155;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGVeri
            // 
            this.dataGVeri.AllowUserToDeleteRows = false;
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(6, 11);
            this.dataGVeri.Margin = new System.Windows.Forms.Padding(2);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.RowHeadersVisible = false;
            this.dataGVeri.RowHeadersWidth = 10;
            this.dataGVeri.RowTemplate.Height = 24;
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(664, 150);
            this.dataGVeri.TabIndex = 152;
            this.dataGVeri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellContentClick);
            this.dataGVeri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVeri_CellDoubleClick);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(167, 172);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 162;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(235, 172);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 163;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(309, 172);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(34, 13);
            this.lblTc.TabIndex = 164;
            this.lblTc.Text = "TcNo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 167;
            // 
            // btnilacara
            // 
            this.btnilacara.Location = new System.Drawing.Point(6, 187);
            this.btnilacara.Name = "btnilacara";
            this.btnilacara.Size = new System.Drawing.Size(58, 23);
            this.btnilacara.TabIndex = 168;
            this.btnilacara.Text = "İlaç Ara";
            this.btnilacara.UseVisualStyleBackColor = true;
            this.btnilacara.Click += new System.EventHandler(this.btnilacara_Click);
            // 
            // btnİlacTemizle
            // 
            this.btnİlacTemizle.Location = new System.Drawing.Point(70, 187);
            this.btnİlacTemizle.Name = "btnİlacTemizle";
            this.btnİlacTemizle.Size = new System.Drawing.Size(58, 23);
            this.btnİlacTemizle.TabIndex = 169;
            this.btnİlacTemizle.Text = "Temizle";
            this.btnİlacTemizle.UseVisualStyleBackColor = true;
            this.btnİlacTemizle.Click += new System.EventHandler(this.btnİlacTemizle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 173;
            this.button1.Text = "Reçete Çıkart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGİlac
            // 
            this.dataGİlac.AllowUserToDeleteRows = false;
            this.dataGİlac.BackgroundColor = System.Drawing.Color.White;
            this.dataGİlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGİlac.Location = new System.Drawing.Point(6, 215);
            this.dataGİlac.Margin = new System.Windows.Forms.Padding(2);
            this.dataGİlac.Name = "dataGİlac";
            this.dataGİlac.ReadOnly = true;
            this.dataGİlac.RowHeadersVisible = false;
            this.dataGİlac.RowHeadersWidth = 10;
            this.dataGİlac.RowTemplate.Height = 24;
            this.dataGİlac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGİlac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGİlac.Size = new System.Drawing.Size(122, 188);
            this.dataGİlac.TabIndex = 166;
            this.dataGİlac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGİlac_CellContentClick);
            this.dataGİlac.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGİlac_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 175;
            this.button2.Text = "İlaç Listesini Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İlaç";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(151, 215);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 188);
            this.listView1.TabIndex = 174;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 215);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 188);
            this.textBox3.TabIndex = 176;
            // 
            // frmMainDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 413);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnİlacTemizle);
            this.Controls.Add(this.btnilacara);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGİlac);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGVeri);
            this.Name = "frmMainDoktor";
            this.Text = "frmMainDoktor";
            this.Load += new System.EventHandler(this.frmMainDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGİlac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnilacara;
        private System.Windows.Forms.Button btnİlacTemizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGİlac;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox3;
    }
}