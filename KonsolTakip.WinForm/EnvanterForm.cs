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
    public partial class EnvanterForm : Form
    {
        public EnvanterForm()
        {
            InitializeComponent();
        }
        private void EnvanterForm_Load(object sender, EventArgs e)
        {
            envanterData.DataSource = Envanterler.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Envanter entity = new Envanter();
            entity.CihazNo = Convert.ToInt32(textBox1.Text);
            entity.CihazSeriNo = textBox2.Text.ToString();
            entity.CihazDurum = comboBox1.SelectedItem.ToString();
            entity.CihazModel = comboBox2.SelectedItem.ToString();
            entity.Fiyat = Convert.ToInt32(textBox3.Text);
            if (!Envanterler.Ekle(entity))
                MessageBox.Show("Envanter Eklenemedi");
            envanterData.DataSource = Envanterler.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Envanter guncelle = new Envanter();
            guncelle.CihazNo = Convert.ToInt32(textBox1.Text);
            guncelle.CihazSeriNo = textBox2.Text.ToString();
            guncelle.CihazDurum = comboBox1.SelectedItem.ToString();
            guncelle.CihazModel = comboBox2.SelectedItem.ToString();
            guncelle.Fiyat = Convert.ToInt32(textBox3.Text);
            guncelle.id = (int)textBox1.Tag;
            if (!Envanterler.Guncelle(guncelle))
                MessageBox.Show("Güncelleme Başarısız");
            envanterData.DataSource = Envanterler.Listele();
        }

        private void envanterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (envanterData.SelectedRows.Count == 0) return;

            textBox1.Text = envanterData.CurrentRow.Cells["CihazNo"].Value.ToString();
            textBox1.Tag = envanterData.CurrentRow.Cells["id"].Value;
            textBox2.Text = envanterData.CurrentRow.Cells["CihazSeriNo"].Value.ToString();
            comboBox1.SelectedItem = envanterData.CurrentRow.Cells["CihazDurum"].Value.ToString();
            comboBox2.SelectedItem = envanterData.CurrentRow.Cells["CihazModel"].Value.ToString();
            textBox3.Text = envanterData.CurrentRow.Cells["Fiyat"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (envanterData.SelectedRows.Count == 0) return;

            Envanter silincek = new Envanter();
            silincek.id = (int)envanterData.CurrentRow.Cells["id"].Value;
            if (!Envanterler.Sil(silincek))
                MessageBox.Show("Silinemedi");
            envanterData.DataSource = Envanterler.Listele();
        }
    }
}
