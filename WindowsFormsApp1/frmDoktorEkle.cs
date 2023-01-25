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
    public partial class frmDoktorEkle : Form
    {
        public frmDoktorEkle()
        {
            InitializeComponent();
        }
        public DateTime tarih;
        GorselEntities1 vt = new GorselEntities1();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            doktor dekle = new doktor();
            dekle.doktorAd = txtAd.Text;
            dekle.doktorSoyAd = txtSoyad.Text;
            dekle.doktorTcNO = txtTc.Text;
            dekle.doktorTel = txtTelNo.Text;
            dekle.doktorCinsiyet = cbCinsiyet.SelectedItem.ToString();
            dekle.doktorDtarihi = tarih;
            dekle.klinikAd = comboBox1.SelectedItem.ToString();
            vt.doktor.Add(dekle);
            vt.SaveChanges();
            int sonuc = (vt.SaveChanges());
            if (sonuc == 0)
            {
                MessageBox.Show("Kayıt İşlemi Tamamlandı");
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Tamamlanmadı");

            }

        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
             tarih = dtpDogumTarihi.Value;
        }

        private void frmDoktorEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
