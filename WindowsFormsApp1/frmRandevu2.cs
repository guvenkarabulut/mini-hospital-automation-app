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
    public partial class frmRandevu2 : Form
    {
        public frmRandevu2()
        {
            InitializeComponent();
        }
        public string doktorarama;
        public int frm1deno;
        GorselEntities1 vt = new GorselEntities1();
        private void frmRandevu2_Load(object sender, EventArgs e)
        {
            frmRandevuMain frm1 = (frmRandevuMain)Application.OpenForms["frmRandevuMain"];
            frmRandevu1 frm2 = (frmRandevu1)Application.OpenForms["frmRandevu1"];
            string frm1dekisim = frm1.lblHasta.Text;
            label1.Text = frm1dekisim;
            frm1deno = frmRandevuMain.hNo;
            DateTime frm3deSecilenTarih = frm2.monthCalendar_randevuTarihleri.SelectionStart.Date;
            lblTarih1.Text = frm3deSecilenTarih.ToLongDateString();
            dataGVeri.DataSource = vt.doktor.Where(p => p.klinikAd == lblBolumİsmi.Text).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doktorarama = textBox1.Text;
            dataGVeri.DataSource = vt.doktor.Where(p => p.doktorAd == doktorarama).ToList();
        }

        private void lblBolumİsmi_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            randevu ran = new randevu();
            ran.randevuTarih = lblTarih1.Text;
            ran.randevuSaat = listBox1.SelectedItem.ToString();
            ran.randevuKlinik = lblBolumİsmi.Text;
            ran.doktorNo = Convert.ToInt32 (label6.Text);
            ran.hastaNo = frm1deno;
            vt.randevu.Add(ran);
            vt.SaveChanges();
            int sonuc = (vt.SaveChanges());
            if (sonuc == 0)
            {
                MessageBox.Show("Randevu İşlemi Tamamlandı");
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Tamamlanmadı");

            }
        }

        private void dataGVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = dataGVeri.CurrentRow.Cells[1].Value.ToString();
            label6.Text = dataGVeri.CurrentRow.Cells[0].Value.ToString();


        }
    }
}
