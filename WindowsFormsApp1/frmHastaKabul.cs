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
    public partial class frmHastaKabul : Form
    {
        public frmHastaKabul()
        {
            InitializeComponent();
        }
        public static string hastaAd;
        public static string hastaSoyad;
        public static int hastaNo;
        public static bool hastaSecim = false;

        public static bool hasta = false;

        public static string doktorAd;
        public static int doktorNo;
        GorselEntities1 vt = new GorselEntities1();
        void veriYenile()
        {
            txtSikayet.Text = "";
            lblDoktor.Text = "";
            lblHasta.Text = "";
            btnDoktorSec.BackColor = Color.LightCoral;
            btnHastaSec.BackColor = Color.LightCoral;
            hastaSecim = false;
        }
        private void frmHastaKabul_Load(object sender, EventArgs e)
        {
           
        }

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
            frmHastaSec frm2 = new frmHastaSec();
            frm2.MdiParent = frm;
            frm2.Show();

        }

        private void btnDoktorSec_Click(object sender, EventArgs e)
        {
            MainForm frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "MainForm")
                {
                    frm = (MainForm)f;
                }
            }
            frmDoktorSec frm2 = new frmDoktorSec();
            frm2.MdiParent = frm;
            frm2.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sonSecimHasta ssHasta = new sonSecimHasta();
            ssHasta.hastaAdS = hastaAd;
            ssHasta.hastaSoyadS = hastaSoyad;
            ssHasta.hastaNoS = hastaNo;
            ssHasta.doktorAdS = doktorAd;
            ssHasta.doktorNoS = doktorNo;
            ssHasta.hastaSikayetS = txtSikayet.Text;
            vt.sonSecimHasta.Add(ssHasta);
            vt.SaveChanges();

            int sonuc = (vt.SaveChanges());
            if (sonuc==0)
            {
                MessageBox.Show("Kayıt Başarılı");
                veriYenile();

            }
            else
            {
                MessageBox.Show("Kayıt Başarısız Lütfen Tekrar Deneyin");
            }
        }
    }
}
