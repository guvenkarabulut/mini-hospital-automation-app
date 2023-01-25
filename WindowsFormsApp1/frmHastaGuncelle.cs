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
    public partial class frmHastaGuncelle : Form
    {
        public frmHastaGuncelle()
        {
            InitializeComponent();
        }
        GorselEntities1 vt = new GorselEntities1();
        private void dataGVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGVeri.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dataGVeri.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text = dataGVeri.CurrentRow.Cells[3].Value.ToString();
            txtTelNo.Text = dataGVeri.CurrentRow.Cells[4].Value.ToString();
            txtDogumYeri.Text = dataGVeri.CurrentRow.Cells[6].Value.ToString();
            txtAnaAdi.Text = dataGVeri.CurrentRow.Cells[7].Value.ToString();
            txtBabaAdi.Text = dataGVeri.CurrentRow.Cells[8].Value.ToString();
            txtAdres.Text = dataGVeri.CurrentRow.Cells[9].Value.ToString();
            cbCinsiyet.SelectedItem = dataGVeri.CurrentRow.Cells[5].Value.ToString();

        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmHastaGuncelle_Load(object sender, EventArgs e)
        {
            dataGVeri.DataSource = vt.Hasta.ToList();
            dataGVeri.Columns[0].Visible = false;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string TC_ = txtTc.Text;
            var guncelle = vt.Hasta.Where(p => p.hastaTcNo == TC_).FirstOrDefault();
            guncelle.hastaAdi = txtAd.Text;
            guncelle.hastaAdres = txtAdres.Text;
            guncelle.hastaAnneAdi = txtAnaAdi.Text;
            guncelle.hastaBabaAdi = txtBabaAdi.Text;
            guncelle.hastaCinsiyet= cbCinsiyet.SelectedItem.ToString();
            guncelle.hastaDogumYeri = txtDogumYeri.Text;
            guncelle.hastaKanGrubu = cbKanGrubu.SelectedItem.ToString();
            guncelle.hastaMedeniHali = cbMedeniHal.SelectedItem.ToString();
            guncelle.hastaTcNo = txtTc.Text;
            guncelle.hastoSoyadi = txtSoyad.Text;
            vt.SaveChanges();
            dataGVeri.DataSource = vt.Hasta.ToList();

        }
    }
}
