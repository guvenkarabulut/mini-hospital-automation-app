namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.menuSekreter = new System.Windows.Forms.MenuStrip();
            this.yeniHastaGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHastaGirişiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıHastaGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYonetim = new System.Windows.Forms.MenuStrip();
            this.doktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSekreter.SuspendLayout();
            this.menuYonetim.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSekreter
            // 
            this.menuSekreter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHastaGirişiToolStripMenuItem,
            this.randevuAlToolStripMenuItem});
            this.menuSekreter.Location = new System.Drawing.Point(0, 0);
            this.menuSekreter.Name = "menuSekreter";
            this.menuSekreter.Size = new System.Drawing.Size(857, 24);
            this.menuSekreter.TabIndex = 1;
            this.menuSekreter.Text = "menuStrip2";
            this.menuSekreter.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuSekreter_ItemClicked);
            // 
            // yeniHastaGirişiToolStripMenuItem
            // 
            this.yeniHastaGirişiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHastaGirişiToolStripMenuItem1,
            this.kayıtlıHastaGirişiToolStripMenuItem});
            this.yeniHastaGirişiToolStripMenuItem.Name = "yeniHastaGirişiToolStripMenuItem";
            this.yeniHastaGirişiToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.yeniHastaGirişiToolStripMenuItem.Text = "Hasta";
            this.yeniHastaGirişiToolStripMenuItem.Click += new System.EventHandler(this.yeniHastaGirişiToolStripMenuItem_Click);
            // 
            // yeniHastaGirişiToolStripMenuItem1
            // 
            this.yeniHastaGirişiToolStripMenuItem1.Name = "yeniHastaGirişiToolStripMenuItem1";
            this.yeniHastaGirişiToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.yeniHastaGirişiToolStripMenuItem1.Text = "Yeni Hasta Girişi";
            this.yeniHastaGirişiToolStripMenuItem1.Click += new System.EventHandler(this.yeniHastaGirişiToolStripMenuItem1_Click_1);
            // 
            // kayıtlıHastaGirişiToolStripMenuItem
            // 
            this.kayıtlıHastaGirişiToolStripMenuItem.Name = "kayıtlıHastaGirişiToolStripMenuItem";
            this.kayıtlıHastaGirişiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kayıtlıHastaGirişiToolStripMenuItem.Text = "Hasta Kabul";
            this.kayıtlıHastaGirişiToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıHastaGirişiToolStripMenuItem_Click_1);
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.randevuAlToolStripMenuItem.Text = "Randevu Al";
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // menuYonetim
            // 
            this.menuYonetim.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorEkleToolStripMenuItem,
            this.doktorBilgisiToolStripMenuItem,
            this.hastaBilgisiToolStripMenuItem,
            this.hastaGüncelleToolStripMenuItem});
            this.menuYonetim.Location = new System.Drawing.Point(0, 24);
            this.menuYonetim.Name = "menuYonetim";
            this.menuYonetim.Size = new System.Drawing.Size(857, 24);
            this.menuYonetim.TabIndex = 2;
            this.menuYonetim.Text = "menuStrip1";
            // 
            // doktorEkleToolStripMenuItem
            // 
            this.doktorEkleToolStripMenuItem.Name = "doktorEkleToolStripMenuItem";
            this.doktorEkleToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.doktorEkleToolStripMenuItem.Text = "Doktor Ekle";
            this.doktorEkleToolStripMenuItem.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem_Click);
            // 
            // doktorBilgisiToolStripMenuItem
            // 
            this.doktorBilgisiToolStripMenuItem.Name = "doktorBilgisiToolStripMenuItem";
            this.doktorBilgisiToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.doktorBilgisiToolStripMenuItem.Text = "Doktor Bilgisi";
            this.doktorBilgisiToolStripMenuItem.Click += new System.EventHandler(this.doktorBilgisiToolStripMenuItem_Click);
            // 
            // hastaBilgisiToolStripMenuItem
            // 
            this.hastaBilgisiToolStripMenuItem.Name = "hastaBilgisiToolStripMenuItem";
            this.hastaBilgisiToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.hastaBilgisiToolStripMenuItem.Text = "Hasta Bilgisi";
            this.hastaBilgisiToolStripMenuItem.Click += new System.EventHandler(this.hastaBilgisiToolStripMenuItem_Click);
            // 
            // hastaGüncelleToolStripMenuItem
            // 
            this.hastaGüncelleToolStripMenuItem.Name = "hastaGüncelleToolStripMenuItem";
            this.hastaGüncelleToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.hastaGüncelleToolStripMenuItem.Text = "Hasta Güncelle";
            this.hastaGüncelleToolStripMenuItem.Click += new System.EventHandler(this.hastaGüncelleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 448);
            this.Controls.Add(this.menuYonetim);
            this.Controls.Add(this.menuSekreter);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuSekreter.ResumeLayout(false);
            this.menuSekreter.PerformLayout();
            this.menuYonetim.ResumeLayout(false);
            this.menuYonetim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSekreter;
        private System.Windows.Forms.ToolStripMenuItem yeniHastaGirişiToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuYonetim;
        private System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniHastaGirişiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıHastaGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
    }
}