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
    public partial class TamirForm : Form
    {
        public TamirForm()
        {
            InitializeComponent();
        }

        private void TamirForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Tamirler.Listele();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            Tamir entity = new Tamir();
            entity.TamirDurum = Convert.ToInt32(txtdurum.Text);
            entity.Kimde = txtkimde.Text;
            entity.Adres = txtadres.Text;
            entity.Tel = txttel.Text;
            entity.Tarih = dateTimePicker1.Value;

            if (!Tamirler.Ekle(entity))
                MessageBox.Show("Tamir Eklenemedi");
            dataGridView1.DataSource = Tamirler.Listele();

        }

        private void Düzenle_Click(object sender, EventArgs e)
        {
            Tamir guncelle = new Tamir();
            guncelle.id = (int)txtkimde.Tag;
            guncelle.TamirDurum = Convert.ToInt32(txtdurum.Text);
            guncelle.Kimde = txtkimde.Text;
            guncelle.Adres = txtadres.Text;
            guncelle.Tel = txttel.Text;
            guncelle.Tarih = dateTimePicker1.Value;

            if (!Tamirler.Guncelle(guncelle))
                MessageBox.Show("Düzenleme Başarısız");
            dataGridView1.DataSource = Tamirler.Listele();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            Tamir silincek = new Tamir();
            silincek.id = (int)dataGridView1.CurrentRow.Cells["id"].Value;

            if (!Tamirler.Sil(silincek))
                MessageBox.Show("Silinemedi");
            dataGridView1.DataSource = Tamirler.Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["tarih"].Value);
            txtkimde.Tag = dataGridView1.CurrentRow.Cells["id"].Value;
            txtdurum.Text = dataGridView1.CurrentRow.Cells["durum"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells["tel"].Value.ToString();
            txtkimde.Text = dataGridView1.CurrentRow.Cells["kimde"].Value.ToString();
        }
    }
}
