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
    public partial class MasaAcForm : Form
    {
        public MasaAcForm()
        {
            InitializeComponent();
        }
        PictureBox[] masalar;
        int masasayisi;
        int masa_x = 10;
        int masa_y = 10;
        PictureBox tiklanan = new PictureBox();
        private void MasaAcForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KafeBilgiler.Listele();
            masasayisi=(int)dataGridView1.Rows[0].Cells["MakineSayisi"].Value;
            masalar = new PictureBox[masasayisi+1];
            for (int i = 1; i <= masasayisi; i++) {
                masalar[i] = new PictureBox();
                masalar[i].Size = new Size(100, 100);
                masalar[i].Tag = i;
                masalar[i].Location = new Point(masa_x, masa_y);
                masalar[i].Image = Image.FromFile("C:\\Users\\musanmaz\\Documents\\GitHub\\konsoltakip\\KonsolTakip.WinForm\\images\\playstation_3_icon.png");
                masa_x += 120;
                if (i % 4 == 0) {
                    masa_x = 10;
                    masa_y += 120;
                }
                this.Controls.Add(masalar[i]);
                masalar[i].MouseClick += new MouseEventHandler(picturebox_click);

            }
        }

        private void picturebox_click(object sender, MouseEventArgs e)
        {
           
            OturumTuruSec oform=new OturumTuruSec();

            tiklanan = (PictureBox)sender;
            OturumTuruSec.Oturum(Convert.ToInt32(tiklanan.Tag));
            oform.Show();

        }
    }
}
