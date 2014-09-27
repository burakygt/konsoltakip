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
    public partial class BorcForm : Form
    {
        public BorcForm()
        {
            InitializeComponent();
        }
       

        private void BorcForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Borclar.Listele();
        }

        private void Düzenle_Click(object sender, EventArgs e)
        {
            Borc guncelle = new Borc();
            guncelle.id = (int)txtad.Tag;
            guncelle.ad = txtad.Text;
            guncelle.soyad = txtsoyad.Text;
            guncelle.tel = txttel.Text;
            guncelle.tutar = Convert.ToInt32(txttutar.Text);

            if (!Borclar.Guncelle(guncelle))
                MessageBox.Show("Güncelleme Başarısız");
            dataGridView1.DataSource = Borclar.Listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            txtad.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells["tel"].Value.ToString();
            txttutar.Text = dataGridView1.CurrentRow.Cells["tutar"].Value.ToString();
            txtad.Tag = dataGridView1.CurrentRow.Cells["id"].Value;



        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            Borc silincek = new Borc();
            silincek.id = (int)dataGridView1.CurrentRow.Cells["id"].Value;

            if (!Borclar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            dataGridView1.DataSource = Borclar.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borc entity = new Borc();
            entity.ad = txtad.Text.ToString();
            entity.soyad = txtsoyad.Text.ToString();
            entity.tel = txttel.Text.ToString();
            entity.tutar = Convert.ToInt32(txttutar.Text);
            if (!Borclar.Ekle(entity))
                MessageBox.Show("Eklenemedi");
            dataGridView1.DataSource = Borclar.Listele();
                      }
    }
}
