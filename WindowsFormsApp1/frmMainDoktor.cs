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
    public partial class frmMainDoktor : Form
    {
        public frmMainDoktor()
        {
            InitializeComponent();
        }
        
        GorselEntities1 db = new GorselEntities1();
        public int dno;
        Giris g = new Giris();
        public string gelecekveri=Giris.kullaniciAd;
        private void frmMainDoktor_Load(object sender, EventArgs e)
        {
            Kullanici kullanici = db.Kullanici.FirstOrDefault(p => p.KullaniciAd == gelecekveri);
            if (kullanici != null)
            {
                dno = kullanici.doktorNo.Value;
            }
            else
            {
                MessageBox.Show("sea");

            }
            dataGİlac.DataSource = db.ilac.ToList();
            dataGİlac.Columns[2].Visible = false;
            dataGİlac.Columns[3].Visible = false;
            dataGİlac.Columns[0].Visible = false;    
            dataGVeri.DataSource = db.sonSecimHasta.Where(p => p.doktorNoS == dno).ToList();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Sonislemhasta sish = new Sonislemhasta();
            Sonislemhasta sisl = new Sonislemhasta();

            sish.hastaAdss = lblAd.Text;
            sish.hastaSoyadss = lblSoyad.Text;
            sish.hastaSikayetss = textBox1.Text;
            sish.hastaTcNo = lblTc.Text;
            sish.hastailacss = textBox3.Text;
            db.Sonislemhasta.Add(sish);
            db.SaveChanges();
            textBox1.Text=("");
            textBox3.Text = ("");

        }

        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblAd.Text = dataGVeri.CurrentRow.Cells[2].Value.ToString();
            lblSoyad.Text= dataGVeri.CurrentRow.Cells[3].Value.ToString();
            lblTc.Text=dataGVeri.CurrentRow.Cells[1].Value.ToString();

        }

        private void dataGİTür_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnilacara_Click(object sender, EventArgs e)
        {
            string ilacd = textBox2.Text;
            dataGİlac.DataSource = db.ilac.Where(ilac => ilac.ilacAdı == ilacd).ToList();
        }

        private void btnİlacTemizle_Click(object sender, EventArgs e)
        {
            dataGİlac.DataSource = db.ilac.ToList();

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private void dataGİlac_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListViewItem lstItem = new ListViewItem();
            lstItem.Text= dataGİlac.CurrentRow.Cells[1].Value.ToString();
            listView1.Items.Add(lstItem);
            textBox3.Text += dataGİlac.CurrentRow.Cells[1].Value.ToString()+",";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Mini Hastane", Baslik, sb, 350, 100, st);

            e.Graphics.DrawString("________________________________________", altBaslik, sb, 350, 120, st);
            e.Graphics.DrawString("Hasta Ad:"+ lblAd.Text +"Hasta Soyad:"+lblSoyad.Text+  "Hasta Tc:"+lblTc.Text, altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("________________________________________________________________________________________________________", altBaslik, sb, 150, 280, st);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                e.Graphics.DrawString(listView1.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
            }
            e.Graphics.DrawString("Yapılan İşlem:" + textBox1.Text, altBaslik, sb, 250, 300+90, st);


        }

        private void dataGİlac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
