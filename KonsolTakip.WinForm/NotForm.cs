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
    public partial class NotForm : Form
    {
        public NotForm()
        {
            InitializeComponent();
        }
        private void NotForm_Load(object sender, EventArgs e)
        {
            notlardata.DataSource = Notlar.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Not entity = new Not();
            entity.tarih = not_tarih.Value;
            entity.aciklama = not_aciklama.Text;
            if (!Notlar.Ekle(entity))
                MessageBox.Show("Not Eklenemedi");
            notlardata.DataSource = Notlar.Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (notlardata.SelectedRows.Count == 0) return;

            Not silincek = new Not();
            silincek.ID = (int)notlardata.CurrentRow.Cells["id"].Value;
            if (!Notlar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            notlardata.DataSource = Notlar.Listele();
        }

        private void notlardata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (notlardata.SelectedRows.Count == 0) return;

            not_tarih.Value = Convert.ToDateTime(notlardata.CurrentRow.Cells["tarih"].Value);
            not_aciklama.Text = notlardata.CurrentRow.Cells["aciklama"].Value.ToString();
            not_aciklama.Tag = notlardata.CurrentRow.Cells["id"].Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Not guncelle = new Not();
            guncelle.ID = (int)not_aciklama.Tag;
            guncelle.tarih = not_tarih.Value;
            guncelle.aciklama = not_aciklama.Text;
            if (!Notlar.Guncelle(guncelle))
                MessageBox.Show("Güncelleme Başarısız");
            notlardata.DataSource = Notlar.Listele();

        }
    }
}
