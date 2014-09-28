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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adisyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdisyonForm aform = new AdisyonForm();
            aform.Show();
        }

        private void borçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorcForm bform = new BorcForm();
            bform.Show();
        }

        private void envanterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnvanterForm eform = new EnvanterForm();
            eform.Show();
        }

        private void kiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaForm kform = new KiralamaForm();
            kform.Show();
        }

        private void notlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotForm nform = new NotForm();
            nform.Show();

        }

        private void tamirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TamirForm tform = new TamirForm();
            tform.Show();
        }

        private void üyelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeForm uform = new UyeForm();
            uform.Show();
        }

        private void açılışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcilisForm acilisform = new AcilisForm();
            acilisform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasaAcForm tform = new MasaAcForm();
            tform.Show();
        }

    }
}
