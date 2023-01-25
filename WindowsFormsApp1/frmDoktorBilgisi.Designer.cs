namespace WindowsFormsApp1
{
    partial class frmDoktorBilgisi
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGVeri = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 177;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 176;
            // 
            // dataGVeri
            // 
            this.dataGVeri.AllowUserToDeleteRows = false;
            this.dataGVeri.BackgroundColor = System.Drawing.Color.White;
            this.dataGVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVeri.Location = new System.Drawing.Point(11, 53);
            this.dataGVeri.Margin = new System.Windows.Forms.Padding(2);
            this.dataGVeri.Name = "dataGVeri";
            this.dataGVeri.ReadOnly = true;
            this.dataGVeri.RowHeadersVisible = false;
            this.dataGVeri.RowHeadersWidth = 10;
            this.dataGVeri.RowTemplate.Height = 24;
            this.dataGVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVeri.Size = new System.Drawing.Size(778, 390);
            this.dataGVeri.TabIndex = 175;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 178;
            this.button2.Text = "Excele Aktar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDoktorBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGVeri);
            this.Name = "frmDoktorBilgisi";
            this.Text = "frmDoktorBilgisi";
            this.Load += new System.EventHandler(this.frmDoktorBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGVeri;
        private System.Windows.Forms.Button button2;
    }
}