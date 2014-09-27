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
    public partial class KiralamaForm : Form
    {
        public KiralamaForm()
        {
            InitializeComponent();
        }
        private void KiralamaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Kiralamalar.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kiralama entity = new Kiralama();
            entity.ad = txtad.Text;
            entity.soyad = txtsoyad.Text;
            entity.TcKimlikNo = txttckimlik.Text;
            entity.Tel = txttel.Text;
            entity.GunlukUcret = Convert.ToDecimal(txtgunluk.Text);
            entity.Tarih = dateTimePicker1.Value;

            if (!Kiralamalar.Ekle(entity))
                MessageBox.Show("Kiralama Eklenemedi");
            dataGridView1.DataSource = Kiralamalar.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            Kiralama silincek = new Kiralama();
            silincek.id = (int)dataGridView1.CurrentRow.Cells["id"].Value;

            if (!Kiralamalar.Sil(silincek))
                MessageBox.Show("Silinemedi");
            dataGridView1.DataSource = Kiralamalar.Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Tarih"].Value);
            txtad.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            txttckimlik.Text = dataGridView1.CurrentRow.Cells["TcKimlikNo"].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells["Tel"].Value.ToString();
            txtgunluk.Text = dataGridView1.CurrentRow.Cells["GunlukUcret"].Value.ToString();
            txtad.Tag = dataGridView1.CurrentRow.Cells["id"].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kiralama guncelle = new Kiralama();
            guncelle.id = (int)txtad.Tag;
            guncelle.Tarih = dateTimePicker1.Value;
            guncelle.ad = txtad.Text;
            guncelle.soyad = txtsoyad.Text;
            guncelle.TcKimlikNo = txttckimlik.Text;
            guncelle.Tel = txttel.Text;
            guncelle.GunlukUcret = Convert.ToDecimal(txtgunluk.Text);




            if (!Kiralamalar.Guncelle(guncelle))
                MessageBox.Show("Düzenleme Başarısız");
            dataGridView1.DataSource = Kiralamalar.Listele();
        }
    }
}
