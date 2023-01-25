namespace WindowsFormsApp1
{
    partial class frmRandevuMain
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
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnHastaSec = new System.Windows.Forms.Button();
            this.monthCalendar_randevuTarihleri = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(11, 57);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnHastaSec
            // 
            this.btnHastaSec.BackColor = System.Drawing.Color.LightCoral;
            this.btnHastaSec.Location = new System.Drawing.Point(11, 11);
            this.btnHastaSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnHastaSec.Name = "btnHastaSec";
            this.btnHastaSec.Size = new System.Drawing.Size(256, 45);
            this.btnHastaSec.TabIndex = 8;
            this.btnHastaSec.Text = "Hasta Seç";
            this.btnHastaSec.UseVisualStyleBackColor = false;
            this.btnHastaSec.Click += new System.EventHandler(this.btnHastaSec_Click);
            // 
            // monthCalendar_randevuTarihleri
            // 
            this.monthCalendar_randevuTarihleri.BackColor = System.Drawing.Color.Gold;
            this.monthCalendar_randevuTarihleri.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar_randevuTarihleri.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthCalendar_randevuTarihleri.ForeColor = System.Drawing.Color.White;
            this.monthCalendar_randevuTarihleri.Location = new System.Drawing.Point(325, 11);
            this.monthCalendar_randevuTarihleri.MaxSelectionCount = 1;
            this.monthCalendar_randevuTarihleri.Name = "monthCalendar_randevuTarihleri";
            this.monthCalendar_randevuTarihleri.TabIndex = 22;
            this.monthCalendar_randevuTarihleri.TitleBackColor = System.Drawing.Color.Red;
            this.monthCalendar_randevuTarihleri.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar_randevuTarihleri.TrailingForeColor = System.Drawing.SystemColors.WindowFrame;
            this.monthCalendar_randevuTarihleri.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_randevuTarihleri_DateChanged);
            this.monthCalendar_randevuTarihleri.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_randevuTarihleri_DateSelected);
            // 
            // frmRandevuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 198);
            this.Controls.Add(this.monthCalendar_randevuTarihleri);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnHastaSec);
            this.Name = "frmRandevuMain";
            this.Text = "frmRandevuMain";
            this.Load += new System.EventHandler(this.frmRandevuMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHasta;
        public System.Windows.Forms.Button btnHastaSec;
        public System.Windows.Forms.MonthCalendar monthCalendar_randevuTarihleri;
    }
}