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
    public partial class frmRandevuMain : Form
    {
        public string secilenTarih;
        public frmRandevuMain()
        {
            InitializeComponent();
        }
        frmRandevu2 frmrandevu2 = new frmRandevu2();

        public static string hastaAd;
        public static string hastaSoyad;
        public static int hastaNo;
        public static int hNo;

        public static bool hastaSecim = false;
        private void btnHastaSec_Click(object sender, EventArgs e)
        {
            MainForm frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "MainForm")
                {
                    frm = (MainForm)f;
                }
            }
            frmRandevuHastaSec frm2 = new frmRandevuHastaSec();
            frm2.MdiParent = frm;
            frm2.Show();
        }

        private void monthCalendar_randevuTarihleri_DateSelected(object sender, DateRangeEventArgs e)
        {
            frmRandevu1 frm3 = new frmRandevu1();

            if ((DateTime.Compare(e.Start.Date, DateTime.Today.Date) == 1) || (DateTime.Compare(e.Start.Date, DateTime.Today.Date) == 0))
            {
                secilenTarih = e.Start.ToShortDateString();

                this.Refresh();
                this.Visible = false;

                frm3.ShowDialog();

            }
        }

        private void monthCalendar_randevuTarihleri_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void frmRandevuMain_Load(object sender, EventArgs e)
        {

        }
    }
}
