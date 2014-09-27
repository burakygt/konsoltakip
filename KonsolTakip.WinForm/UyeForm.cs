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
    public partial class UyeForm : Form
    {
        public UyeForm()
        {
            InitializeComponent();
        }
        private void UyeForm_Load(object sender, EventArgs e)
        {
            UyeData.DataSource = Uyeler.Listele();

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            Uye entity = new Uye();
            entity.ad = txtad.Text.ToString();
            entity.soyad = txtsoyad.Text.ToString();
            entity.mail = txtmail.Text.ToString();
            entity.sure = Convert.ToInt32(txtsure.Text);
            entity.ucret = Convert.ToInt32(txttutar.Text);
            entity.adres = adres.Text.ToString();
            entity.tel = txttel.Text.ToString();
            if (!Uyeler.Ekle(entity))
                MessageBox.Show("Not Eklenemedi");
            UyeData.DataSource = Uyeler.Listele();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (UyeData.SelectedRows.Count == 0) return;

            Uye silincek = new Uye();
            silincek.id = (int)UyeData.CurrentRow.Cells["id"].Value;
            if (!Uyeler.Sil(silincek))
                MessageBox.Show("Silinemedi");
            UyeData.DataSource = Uyeler.Listele();
        }

        private void Düzenle_Click(object sender, EventArgs e)
        {

            Uye guncelle = new Uye();
            guncelle.ad = txtad.Text.ToString();
            guncelle.id = (int)txtad.Tag;
            guncelle.soyad = txtsoyad.Text.ToString();
            guncelle.mail = txtmail.Text.ToString();
            guncelle.sure = Convert.ToInt32(txtsure.Text);
            guncelle.ucret = Convert.ToInt32(txttutar.Text);
            guncelle.adres = adres.Text.ToString();
            guncelle.tel = txttel.Text.ToString();
            if (!Uyeler.Guncelle(guncelle))
                MessageBox.Show("Güncelleme Başarısız");
            UyeData.DataSource = Uyeler.Listele();

        }

        private void UyeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UyeData.SelectedRows.Count == 0) return;
            txtad.Text = UyeData.CurrentRow.Cells["ad"].Value.ToString();
            txtad.Tag = UyeData.CurrentRow.Cells["id"].Value;
            txtsoyad.Text = UyeData.CurrentRow.Cells["soyad"].Value.ToString();
            txtmail.Text = UyeData.CurrentRow.Cells["mail"].Value.ToString();
            txtsure.Text = UyeData.CurrentRow.Cells["sure"].Value.ToString();
            txttutar.Text = UyeData.CurrentRow.Cells["ucret"].Value.ToString();
            adres.Text = UyeData.CurrentRow.Cells["adres"].Value.ToString();
        }
    }
}
