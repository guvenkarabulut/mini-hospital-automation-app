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
    public partial class frmRandevu1 : Form
    {
        public frmRandevu1()
        {
            InitializeComponent();
        }
        public string secilenTarih;
        frmRandevu2 frm4 = new frmRandevu2();

        private void frmRandevu1_Load(object sender, EventArgs e)
        {
            frmRandevuMain frm1 = (frmRandevuMain)Application.OpenForms["frmRandevuMain"];

            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);
            DateTime frm2deSecilenTarih = frm1.monthCalendar_randevuTarihleri.SelectionStart.Date;
            lblTarih1.Text = frm2deSecilenTarih.ToLongDateString();
            if (DateTime.Compare(frm1.monthCalendar_randevuTarihleri.SelectionRange.Start, DateTime.Today.Date) == 1)
                monthCalendar_randevuTarihleri.SelectionStart = frm1.monthCalendar_randevuTarihleri.SelectionStart;

        }

        private void picBoxBeyinveSinirCerrahisi_Click(object sender, EventArgs e)
        {
            if (lblBeyinveSinirCerrahisi.Text == "Beyin-ve-Sinir-Cerrahisi")
            {

                frm4.lblBransAdi1.Text = "Beyin-ve-Sinir-Cerrahisi";
                frm4.lblBolumİsmi.Text = lblBeyinveSinirCerrahisi.Text;
                this.Refresh();
                this.Visible = false;
                frm4.ShowDialog();
            }
            else
            {
                picBoxBeyinveSinirCerrahisi.Enabled = false;
            }
        }

        private void picBoxKardiyoloji_Click(object sender, EventArgs e)
        {
            if (lblKardiyoloji.Text == "Kardiyoloji")
            {

                frm4.lblBransAdi1.Text = "Kardiyoloji";
                frm4.lblBolumİsmi.Text = lblKardiyoloji.Text;
                this.Refresh();
                this.Visible = false;
                frm4.ShowDialog();
            }
            else
            {
                picBoxKardiyoloji.Enabled = false;
            }
        }

        private void lblNöroloji_Click(object sender, EventArgs e)
        {

        }

        private void picBoxNöroloji_Click(object sender, EventArgs e)
        {
            if (lblNöroloji.Text == "Nöroloji")
            {

                frm4.lblBransAdi1.Text = "Nöroloji";
                frm4.lblBolumİsmi.Text = lblNöroloji.Text;
                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxNöroloji.Enabled = false;
            }
        }

        private void picBoxPsikiyatri_Click(object sender, EventArgs e)
        {
            if (lblPsikiyatri.Text == "Psikiyatri")
            {

                frm4.lblBransAdi1.Text = "Psikiyatri";
                frm4.lblBolumİsmi.Text = lblPsikiyatri.Text;
                this.Refresh();
                this.Visible = false;
                frm4.ShowDialog();
            }
            else
            {
                picBoxPsikiyatri.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
