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
    public partial class frmIstatistikler : Form
    {
        public frmIstatistikler()
        {
            InitializeComponent();
        }
        EntityUrunEntities connect = new EntityUrunEntities();
        private void frmIstatistikler_Load(object sender, EventArgs e)
        {
            panel();
        }

        void panel()
        {
            lblKategori.Text = connect.tbl_Kategori.Count().ToString();
            lblUrun.Text = connect.tbl_Urun.Count().ToString();
            lblAktifMusteri.Text = connect.tbl_Musteri.Count(x=>x.MusteriDurum==true).ToString();
            lblPasifMusteri.Text = connect.tbl_Musteri.Count(x => x.MusteriDurum == false).ToString();
            lblBeyazesya.Text = connect.tbl_Urun.Count(x => x.UrunKategori == 3).ToString();
            lblToplamStok.Text = connect.tbl_Urun.Sum(y=>y.UrunStok).ToString();
            lblKasadakiTutar.Text = connect.tbl_Satis.Sum(z => z.SatisFiyat).ToString() + " tl";
            lblEnyüksekfiyat.Text = (from x in connect.tbl_Urun orderby x.UrunFiyat descending select x.UrunAd).FirstOrDefault();
            lblEndüsükFiyat.Text = (from y in connect.tbl_Urun orderby y.UrunFiyat ascending select y.UrunAd).FirstOrDefault();
            lblSehir.Text= connect.tbl_Musteri.Select(a => a.MusteriSehir).Distinct().Count().ToString();
            label23.Text = connect.tbl_Urun.Count(b => b.UrunAd== "Kahve Makinesi").ToString();
            lblEnfazlamarka.Text = connect.markagetir().FirstOrDefault();
            
        }
    }
}
