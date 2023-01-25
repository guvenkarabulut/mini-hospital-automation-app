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
    public partial class frmHastaBilgisi : Form
    {
        public frmHastaBilgisi()
        {
            InitializeComponent();
        }
        public string arama;
        GorselEntities1 vt = new GorselEntities1();
        private void dataGVeri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHastaBilgisi_Load(object sender, EventArgs e)
        {
            dataGVeri.DataSource = vt.Hasta.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arama = textBox1.Text;
            dataGVeri.DataSource = vt.Hasta.Where(p => p.hastaAdi == arama).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGVeri.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myRange.Value2 = dataGVeri.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGVeri.Columns.Count; i++)
            {
                for (int j = 0; j < dataGVeri.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGVeri[i, j].Value;
                }
            }
        }
    }
}

