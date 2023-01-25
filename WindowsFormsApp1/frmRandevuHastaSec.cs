using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRandevuHastaSec : Form
    {
        public frmRandevuHastaSec()
        {
            InitializeComponent();
        }
        GorselEntities1 vt = new GorselEntities1();

        private void dataGHastaSec_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmRandevuMain.hNo = Convert.ToInt32(dataGHastaSec.CurrentRow.Cells[0].Value);
                frmRandevuMain.hastaNo = Convert.ToInt32(dataGHastaSec.CurrentRow.Cells[1].Value);
                frmRandevuMain.hastaAd = dataGHastaSec.CurrentRow.Cells[2].Value.ToString();
                frmRandevuMain.hastaSoyad = dataGHastaSec.CurrentRow.Cells[3].Value.ToString();
                frmRandevuMain.hastaSecim = true;
                frmRandevuMain frm = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "frmRandevuMain")
                    {
                        frm = (frmRandevuMain)f;
                    }
                }

                frm.btnHastaSec.BackColor = Color.FromArgb(119, 221, 119);
                frm.lblHasta.Text = frmRandevuMain.hastaAd.ToString();

                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz...");
            }
        }

        private void frmRandevuHastaSec_Load(object sender, EventArgs e)
        {
            dataGHastaSec.DataSource = vt.Hasta.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hastaarama = textBox1.Text;
            dataGHastaSec.DataSource = vt.Hasta.Where(p => p.hastaTcNo == hastaarama).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGHastaSec.DataSource = vt.Hasta.ToList();

        }
    }
}
