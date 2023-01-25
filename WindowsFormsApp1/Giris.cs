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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();

            
        }
        public static string kullaniciAd;
        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAd.Text) || string.IsNullOrEmpty(txtKullaniciAd.Text))
                MessageBox.Show("Lütfen alanları doldur");
            else
            {
                GorselEntities1 vt = new GorselEntities1();
                 kullaniciAd = txtKullaniciAd.Text.Trim();
                string Sifre = txtSifre.Text.Trim();
                Kullanici kullanici = vt.Kullanici.FirstOrDefault
                    (p => p.KullaniciAd == kullaniciAd && p.Sifre == Sifre);
                if (kullanici == null)
                    MessageBox.Show("Böyle bir kullanıcı yok");
                else
                {
                    MainForm f = new MainForm(kullanici.Rol.RolKod.Trim());
                    f.Show();
                    this.Hide();
                    frmMainDoktor fr = new frmMainDoktor();
                }

            }
        }
    }
}
