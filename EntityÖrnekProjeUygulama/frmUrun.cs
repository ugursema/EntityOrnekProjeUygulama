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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }
        EntityUrunEntities db = new EntityUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var urunler = db.tbl_Urun.ToList();
            dataGridView1.DataSource = urunler;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var urun = db.tbl_Urun.Find(x);
            db.tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Urun silindi");

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tbl_Urun u = new tbl_Urun();
            u.UrunAd = txtAd.Text;
            u.UrunMarka = txtMarka.Text;
            u.UrunStok = short.Parse(txtstok1.Text);
            u.UrunKategori = int.Parse(cmbkategori.Text);
            u.UrunFiyat = decimal.Parse(txtfiyat.Text);
            u.UrunDurum = true;
            db.tbl_Urun.Add(u);
            db.SaveChanges();
            MessageBox.Show("Urun eklendi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtId.Text);
            var urun = db.tbl_Urun.Find(x);
            urun.UrunAd = txtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Urun güncellendi");
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.tbl_Kategori select new { x.KategoriId, x.KategoriAd }).ToList();
            cmbkategori.ValueMember = "KategoriAd";
            cmbkategori.DisplayMember = "KategoriAd";
            cmbkategori.DataSource = kategoriler;
        }
    }
}
