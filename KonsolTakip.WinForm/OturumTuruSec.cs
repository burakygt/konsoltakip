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
    public partial class OturumTuruSec : Form
    {
        public OturumTuruSec()
        {
            InitializeComponent();
        }
        static int masaid;
        DateTime degisik = new DateTime();
        public static void Oturum(int id)
        {
            masaid = id;
        }
        private void OturumTuruSec_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SabitUcretler.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oturumlar.oturumOlustur(masaid);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oturum entity = new Oturum();
            DateTime zaman=DateTime.Now;
            degisik=zaman.AddMinutes(15);
            entity.MasaId = masaid;
            entity.BaslangicSaati = DateTime.Now.ToString("HH:mm:ss tt");
            entity.BitisSaati = degisik.ToString("HH:mm:ss tt");
            entity.MasaTutari = float.Parse(dataGridView1.Rows[0].Cells["dk15"].Value.ToString());
            entity.KolSayisi = 1;
            if (!Oturumlar.SureliAc(entity))
                MessageBox.Show("Oturum Açılamadı");
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oturum entity = new Oturum();
            DateTime zaman = DateTime.Now;
            degisik = zaman.AddMinutes(30);
            entity.MasaId = masaid;
            entity.BaslangicSaati = DateTime.Now.ToString("HH:mm:ss tt");
            entity.BitisSaati = degisik.ToString("HH:mm:ss tt");
            entity.MasaTutari = float.Parse(dataGridView1.Rows[0].Cells["dk30"].Value.ToString());
            entity.KolSayisi = 1;
            if (!Oturumlar.SureliAc(entity))
                MessageBox.Show("Oturum Açılamadı");
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Oturum entity = new Oturum();
            DateTime zaman = DateTime.Now;
            degisik = zaman.AddMinutes(45);
            entity.MasaId = masaid;
            entity.BaslangicSaati = DateTime.Now.ToString("HH:mm:ss tt");
            entity.BitisSaati = degisik.ToString("HH:mm:ss tt");
            entity.MasaTutari = float.Parse(dataGridView1.Rows[0].Cells["dk45"].Value.ToString());
            entity.KolSayisi = 1;
            if (!Oturumlar.SureliAc(entity))
                MessageBox.Show("Oturum Açılamadı");
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Oturum entity = new Oturum();
            DateTime zaman = DateTime.Now;
            degisik = zaman.AddHours(1);
            entity.MasaId = masaid;
            entity.BaslangicSaati = DateTime.Now.ToString("HH:mm:ss tt");
            entity.BitisSaati = degisik.ToString("HH:mm:ss tt");
            entity.MasaTutari = float.Parse(dataGridView1.Rows[0].Cells["saat"].Value.ToString());
            entity.KolSayisi = 1;
            if (!Oturumlar.SureliAc(entity))
                MessageBox.Show("Oturum Açılamadı");
            this.Close();

        }
    }
}
