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
    public partial class TarifeAyarlar : Form
    {
        public TarifeAyarlar()
        {
            InitializeComponent();
        }
        TextBox [] ucretler=new TextBox[4];
        Label[] dakikalar = new Label[4];
        int label_deger = 15;
        int label_konum = 20;
        int textbox_konum = 85;
        float ToplamUcret=0;
        int saat;
        int kalan = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) {
                for (int i = 0; i < 3; i++) {
                    dakikalar[i] = new Label();
                    dakikalar[i].Location = new Point(label_konum, 80);
                    dakikalar[i].Size = new System.Drawing.Size(65, 13);
                    dakikalar[i].Text = label_deger + " Dakika : ";
                    ucretler[i] = new TextBox();
                    ucretler[i].Size = new Size(50, 20);
                    ucretler[i].Location = new Point(textbox_konum, 75);
                    label_konum += 115;
                    textbox_konum += 115;
                    label_deger += 15;
                    this.Controls.Add(dakikalar[i]);
                    this.Controls.Add(ucretler[i]);
                    
                }         
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SabitUcret entity = new SabitUcret();
            entity.id = 1;
            entity.saat = float.Parse(textBox1.Text);
            entity.dk15 = float.Parse(ucretler[0].Text);
            entity.dk30 = float.Parse(ucretler[1].Text);
            entity.dk45 = float.Parse(ucretler[2].Text);
            if (!SabitUcretler.UcretKaydet(entity))
                MessageBox.Show("Kayıt Başarısız");
        }

        private void TarifeAyarlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SabitUcretler.Listele();
            dataGridView2.DataSource = Oturumlar.Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oturum entity = new Oturum();
            DateTime saat = DateTime.Now;
//            string suan = 
            entity.MasaId = 1;
            entity.BaslangicSaati = DateTime.Now.ToString("HH:mm:ss tt");
            entity.MasaTutari = float.Parse(dataGridView1.Rows[0].Cells["dk15"].Value.ToString());
            entity.KolSayisi = 1;
            if (!Oturumlar.OturumEkle(entity))
                MessageBox.Show("Oturum Açılamadı");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Oturum oturum = new Oturum();
            oturum.MasaId = 1;
            oturum.BitisSaati = DateTime.Now.ToString("HH:mm:ss tt");
            oturum.BaslangicSaati = dataGridView2.Rows[0].Cells["BaslangicSaati"].Value.ToString();
            DateTime ilkdeger = Convert.ToDateTime(oturum.BaslangicSaati);
            DateTime sondeger = Convert.ToDateTime(oturum.BitisSaati);
            if (!Oturumlar.OturumKapat(oturum))
                MessageBox.Show("Oturum Kapatılamadı");

            System.TimeSpan zaman;
            zaman = sondeger.Subtract(ilkdeger);
            int toplamdakika = Convert.ToInt32(zaman.TotalMinutes);
            if (toplamdakika <= 15) 
            {
                ToplamUcret = float.Parse(dataGridView1.Rows[0].Cells["dk15"].Value.ToString());
            }
            else if (toplamdakika > 15 && toplamdakika <= 30) 
            {
                ToplamUcret = float.Parse(dataGridView1.Rows[0].Cells["dk30"].Value.ToString());
            }
            else if (toplamdakika > 30 && toplamdakika <= 45)
            {
                ToplamUcret = float.Parse(dataGridView1.Rows[0].Cells["dk45"].Value.ToString());
            }
            else if (toplamdakika > 45 && toplamdakika <= 60)
            {
                ToplamUcret =float.Parse(dataGridView1.Rows[0].Cells["saat"].Value.ToString());
            }
             if (toplamdakika > 60) {
                saat=toplamdakika / 60;
                ToplamUcret = saat * float.Parse(dataGridView1.Rows[0].Cells["saat"].Value.ToString());
                kalan = toplamdakika - saat * 60;
                if (kalan != 0) {
                    if (toplamdakika <= 15)
                    {
                        ToplamUcret = ToplamUcret + float.Parse(dataGridView1.Rows[0].Cells["dk15"].Value.ToString());
                    }
                    else if (toplamdakika > 15 && toplamdakika <= 30)
                    {
                        ToplamUcret = ToplamUcret + float.Parse(dataGridView1.Rows[0].Cells["dk30"].Value.ToString());
                    }
                    else if (toplamdakika > 30 && toplamdakika <= 45)
                    {
                        ToplamUcret = float.Parse(dataGridView1.Rows[0].Cells["dk45"].Value.ToString());
                    }
                    else  if (toplamdakika > 45 && toplamdakika <= 60)
                    {
                        ToplamUcret = ToplamUcret + float.Parse(dataGridView1.Rows[0].Cells["saat"].Value.ToString());
                    }
                 }
            }
            MessageBox.Show("Ucret : " + ToplamUcret);
            Oturum entity = new Oturum();
            entity.MasaId = 1;
            entity.MasaTutari = ToplamUcret;
            if (!Oturumlar.Toplam(entity))
                MessageBox.Show("Hata Var");
        }
    }
}
