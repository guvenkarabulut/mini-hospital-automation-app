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
    public partial class frmIlkHasta : Form
    {
        public frmIlkHasta()
        {
            InitializeComponent();
        }
        GorselEntities1 vt = new GorselEntities1();
        private void frmIlkHasta_Load(object sender, EventArgs e)
        {
            dataGVeri.DataSource = vt.Hasta.ToList();
        }
        public void veriYenile()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtDogumYeri.Text = "";
            txtBabaAdi.Text = "";
            txtAnaAdi.Text = "";
            txtAdres.Text = "";
            txtTc.Text = "";
            btnEkle.Text = "Ekle";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hasta hb = new Hasta();
            hb.hastaAdi = txtAd.Text;
            hb.hastoSoyadi = txtSoyad.Text;
            hb.hastaAdres = txtAdres.Text;
            hb.hastaAnneAdi = txtAnaAdi.Text;
            hb.hastaBabaAdi = txtBabaAdi.Text;
            hb.hastaTcNo = txtTc.Text;
            hb.hastaTel = txtTelNo.Text;
            hb.hastaCinsiyet = cbCinsiyet.SelectedItem.ToString();
            hb.hastaKanGrubu = cbKanGrubu.SelectedItem.ToString();
            hb.hastaMedeniHali = cbMedeniHal.SelectedItem.ToString();
            vt.Hasta.Add(hb);
            vt.SaveChanges();
           int sonuc= (vt.SaveChanges());
            if (sonuc == 0)
            {
                MessageBox.Show("Kayıt İşlemi Tamamlandı");
                veriYenile();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Tamamlanmadı");

            }
        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
