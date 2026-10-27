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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EntityUrunEntities db = new EntityUrunEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.tbl_Kategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tbl_Kategori t = new tbl_Kategori();
            t.KategoriAd = textBox2.Text;
            db.tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("kategori eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.tbl_Kategori.Find(x);
            db.tbl_Kategori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("kategori silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.tbl_Kategori.Find(x);
            ktgr.KategoriAd = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("kategori güncellendi");

        }
    }
}
