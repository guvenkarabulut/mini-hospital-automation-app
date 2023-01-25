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
    public partial class frmHastaSec : Form
    {
        public frmHastaSec()
        {
            InitializeComponent();
        }
        GorselEntities1 vt = new GorselEntities1();
        private void dataGHastaSec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHastaSec_Load(object sender, EventArgs e)
        {
            dataGHastaSec.DataSource = vt.Hasta.ToList();

        }

        private void dataGHastaSec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                frmHastaKabul.hastaNo = Convert.ToInt32(dataGHastaSec.CurrentRow.Cells[1].Value);
                frmHastaKabul.hastaAd = dataGHastaSec.CurrentRow.Cells[2].Value.ToString();
                frmHastaKabul.hastaSoyad = dataGHastaSec.CurrentRow.Cells[3].Value.ToString();
                frmHastaKabul.hastaSecim = true;
                frmHastaKabul frm = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "frmHastaKabul")
                    {
                        frm = (frmHastaKabul)f;
                    }
                }

                frm.btnHastaSec.BackColor = Color.FromArgb(119, 221, 119);
                frm.lblHasta.Text = frmHastaKabul.hastaAd.ToString();

                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz...");
            }
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
