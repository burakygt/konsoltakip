using KonsolTakip.ORM.Entity;
using KonsolTakip.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonsolTakip.WinForm
{
    public partial class AdisyonForm : Form
    {
        public AdisyonForm()
        {
            InitializeComponent();
        }
        private void AdisyonForm_Load(object sender, EventArgs e)
        {
            AdisyonData.DataSource = Adisyonlar.Listele();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adisyon entity = new Adisyon();
            entity.UrunAdi = UrunAdi.Text.ToString();
            entity.UrunKodu = UrunKodu.Text.ToString();
            entity.Fiyat = (decimal)UrunFiyat.Value;
            entity.Adet = (int)UrunAdet.Value;

            if (!Adisyonlar.Ekle(entity))
                MessageBox.Show("Not Eklenemedi");
            AdisyonData.DataSource = Adisyonlar.Listele();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Adisyon guncelle = new Adisyon();
            guncelle.id = (int)UrunAdi.Tag;
            guncelle.UrunAdi = UrunAdi.Text.ToString();
            guncelle.UrunKodu = UrunKodu.Text.ToString();
            guncelle.Fiyat = (decimal)UrunFiyat.Value;
            guncelle.Adet = (int)UrunAdet.Value;
            if (!Adisyonlar.Guncelle(guncelle))
                MessageBox.Show("Güncelleme Başarısız");
            AdisyonData.DataSource = Adisyonlar.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (AdisyonData.SelectedRows.Count == 0) return;

            Adisyon silincek = new Adisyon();
            silincek.id = (int)AdisyonData.CurrentRow.Cells["id"].Value;
            if (!Adisyonlar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            AdisyonData.DataSource = Adisyonlar.Listele();
        }

        private void AdisyonData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AdisyonData.SelectedRows.Count == 0) return;


            UrunAdi.Text = AdisyonData.CurrentRow.Cells["UrunAdi"].Value.ToString();
            UrunAdi.Tag = AdisyonData.CurrentRow.Cells["id"].Value;
            UrunKodu.Text = AdisyonData.CurrentRow.Cells["UrunKodu"].Value.ToString();
            UrunFiyat.Value = (decimal)AdisyonData.CurrentRow.Cells["Fiyat"].Value;
            UrunAdet.Value = (int)AdisyonData.CurrentRow.Cells["Adet"].Value;
        }
    }
}
