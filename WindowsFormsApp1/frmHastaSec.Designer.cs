namespace WindowsFormsApp1
{
    partial class frmHastaSec
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
            this.dataGHastaSec = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGHastaSec)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGHastaSec
            // 
            this.dataGHastaSec.AllowUserToDeleteRows = false;
            this.dataGHastaSec.BackgroundColor = System.Drawing.Color.White;
            this.dataGHastaSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGHastaSec.Location = new System.Drawing.Point(11, 51);
            this.dataGHastaSec.Margin = new System.Windows.Forms.Padding(2);
            this.dataGHastaSec.Name = "dataGHastaSec";
            this.dataGHastaSec.ReadOnly = true;
            this.dataGHastaSec.RowHeadersVisible = false;
            this.dataGHastaSec.RowHeadersWidth = 10;
            this.dataGHastaSec.RowTemplate.Height = 24;
            this.dataGHastaSec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGHastaSec.Size = new System.Drawing.Size(519, 222);
            this.dataGHastaSec.TabIndex = 171;
            this.dataGHastaSec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGHastaSec_CellContentClick);
            this.dataGHastaSec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGHastaSec_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 182;
            this.button1.Text = "Hasta Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 181;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 183;
            this.button2.Text = "Listeyi Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 184;
            this.label1.Text = "Tc No:";
            // 
            // frmHastaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGHastaSec);
            this.Name = "frmHastaSec";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmHastaSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGHastaSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGHastaSec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}