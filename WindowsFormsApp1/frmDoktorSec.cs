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
    public partial class frmDoktorSec : Form
    {
        public frmDoktorSec()
        {
            InitializeComponent();
        }
        GorselEntities1 vt = new GorselEntities1();
        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                frmHastaKabul.doktorNo = Convert.ToInt32(dataGVeri.CurrentRow.Cells[0].Value);

                frmHastaKabul.doktorAd = dataGVeri.CurrentRow.Cells[1].Value.ToString() + " " + dataGVeri.CurrentRow.Cells[2].Value.ToString();


                frmHastaKabul frm = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "frmHastaKabul")
                    {
                        frm = (frmHastaKabul)f;
                    }
                }

                frm.btnDoktorSec.BackColor = Color.FromArgb(119, 221, 119);
                frm.lblDoktor.Text = frmHastaKabul.doktorAd.ToString();

                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Dogru Alanı Seciniz...");
            }
        }

        private void frmDoktorSec_Load(object sender, EventArgs e)
        {
            dataGVeri.DataSource = vt.doktor.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hastaarama = textBox1.Text;
            dataGVeri.DataSource = vt.doktor.Where(p => p.doktorTcNO == hastaarama).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGVeri.DataSource = vt.Hasta.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenklinik = comboBox1.SelectedItem.ToString();
            dataGVeri.DataSource = vt.doktor.Where(p => p.klinikAd == secilenklinik).ToList();

        }
    }
}
