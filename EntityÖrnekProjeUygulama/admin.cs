using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityÖrnekProjeUygulama
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityUrunEntities connect = new EntityUrunEntities();
            var sorgu = from x in connect.tbl_Admin where x.KullaniciAd == textBox1.Text && x.KullaniciSifre == textBox2.Text select x;
            if (sorgu.Any())
            {
                frmAnaForm fr = new frmAnaForm();
                    fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }
    }
}
