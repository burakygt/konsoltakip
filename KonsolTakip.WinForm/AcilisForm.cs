using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonsolTakip.WinForm
{
    public partial class AcilisForm : Form
    {
        public AcilisForm()
        {
            InitializeComponent();
        }

        private void AcilisForm_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;

            for (int i = 100; i <= 165; i++)
            {
                this.Size = new Size(367, i);
                Thread.Sleep(5);
            }
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text.ToString();
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
              for (int i = 165; i <= 310; i++)
            {
                this.Size = new Size(367, i);
                Thread.Sleep(5);
            }
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = textBox2.Text.ToString();

            label2.Location = new Point(12, 74);
            label4.Text = textBox2.Text.ToString();
            button3.Visible = false;
            textBox2.Visible = false;
            for (int i = 310; i <= 492; i++)
            {
                this.Size = new Size(367, i);
                Thread.Sleep(5);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Location = new Point(12, 110);
            button4.Visible = false;
            label6.Text = textBox3.Text.ToString();
            textBox3.Visible = false;
            for (int i = 310; i >= 220; i--)
            {
                this.Size = new Size(367, i);
                Thread.Sleep(5);
            }

        }

    
        
            
        
    }
}
