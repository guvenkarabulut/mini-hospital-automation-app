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
    public partial class MainForm : Form
    {
        private string v;

        public MainForm()
        {
            InitializeComponent();

        }

        public MainForm(string rolKod)
        {
            InitializeComponent();
            menuSekreter.Visible = false;
            menuYonetim.Visible = false;
            switch (rolKod)
            {
                case "Sekreter":
                    menuSekreter.Visible = true;
                    break;
                case "Yonetim":
                    menuYonetim.Visible = true;
                    break;
                case "Doktor":
                    frmMainDoktor doktormain = new frmMainDoktor();
                    doktormain.MdiParent = this;
                    doktormain.Show();
                    break;
            }
        }

        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktorEkle DoktorEkle = new frmDoktorEkle();
            DoktorEkle.MdiParent = this;
            DoktorEkle.Show();
        }

        private void yeniHastaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuSekreter_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void yeniHastaGirişiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIlkHasta ilkHasta = new frmIlkHasta();
            ilkHasta.MdiParent = this;
            ilkHasta.Show();
        }

        private void kayıtlıHastaGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaKabul hastaKabul = new frmHastaKabul();
            hastaKabul.MdiParent = this;
            hastaKabul.Show();
        }

        private void yeniHastaGirişiToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmIlkHasta ilkHasta = new frmIlkHasta();
            ilkHasta.MdiParent = this;
            ilkHasta.Show();
        }

        private void kayıtlıHastaGirişiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmHastaKabul hastaKabul = new frmHastaKabul();
            hastaKabul.MdiParent = this;
            hastaKabul.Show();
        }

        private void doktorBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoktorBilgisi doktorbilgi = new frmDoktorBilgisi();
            doktorbilgi.MdiParent = this;
            doktorbilgi.Show();
        }

        private void hastaBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaBilgisi hastaBilgisi = new frmHastaBilgisi();
            hastaBilgisi.MdiParent = this;
            hastaBilgisi.Show();
        }

        private void hastaGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHastaGuncelle hastaguncelle = new frmHastaGuncelle();
            hastaguncelle.MdiParent = this;
            hastaguncelle.Show();
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRandevuMain frmrandvedas = new frmRandevuMain();
            frmrandvedas.Show();
        }
    }
}
